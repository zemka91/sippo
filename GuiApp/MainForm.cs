using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GuiApp
{
	public partial class MainForm : Form
	{
		[DllImport("MathLib.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr SolveByUserInput(int m, int n, int[] aFlat, int[] c, ref int length, ref double sum);
		[DllImport("MathLib.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr SolveFromFile(string fileName, ref int length, ref double sum);

		public MainForm()
		{
			InitializeComponent();

			translatorCount_ValueChanged(translatorCount, EventArgs.Empty);
			languageCount_ValueChanged(languageCount, EventArgs.Empty);
			opFile.Checked = true;
		}

		private int[] FlattenArray(int[,] aExp, int rows, int cols)
		{
			var res = new int[rows * cols];

			for (var i = 0; i < rows; i++)
				for (var j = 0; j < cols; j++)
					res[i * cols + j] = aExp[i, j];

			return res;
		}
		
		private void ShowResults(int[] buf, int length, double sum)
		{
			gridResults.RowCount = length;
			gridResults.ColumnCount = 2;

			for (var i = 0; i < length; i++)
			{
				gridResults[0, i].Value = "Переводчик " + i;
				gridResults[1, i].Value = buf[i] == 1 ? "+" : "";
			}

			labelSum.Text = sum + " руб.";
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
				fileName.Text = openFileDialog1.FileName;
		}

		private void inputType_CheckedChanged(object sender, EventArgs e)
		{
			groupFile.Enabled = opFile.Checked;
			useExe.Enabled = opFile.Checked;
			groupManual.Enabled = opManual.Checked;
		}

		private void translatorCount_ValueChanged(object sender, EventArgs e)
		{
			gridProblem.ColumnCount = (int)translatorCount.Value;
		}

		private void languageCount_ValueChanged(object sender, EventArgs e)
		{
			gridProblem.RowCount = (int)languageCount.Value + 1;

			for (var i = 0; i < gridProblem.RowCount; i++)
				gridProblem.Rows[i].HeaderCell.Value = (i == gridProblem.RowCount - 1) ? "Стоимость" : "";
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			try {
				int[] buf = new int[100 * 100];
				int length = 0;
				double sum = 0;

				if (opFile.Checked)
				{
					if (!File.Exists(fileName.Text))
						throw new Exception("Файл не указан или не существует");

					if (useExe.Checked)
					{
						var process = new Process();
						
						process.StartInfo.FileName = "ConsoleApp.exe";
						process.StartInfo.Arguments = fileName.Text;
						process.StartInfo.RedirectStandardOutput = true;
						process.StartInfo.UseShellExecute = false;
						process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
						process.Start();
						process.WaitForExit();

						var resultStrings = process.StandardOutput.ReadToEnd()
							.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
						var resultArray = resultStrings[0]
							.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
							.Select(o => int.Parse(o)).ToArray();

						sum = double.Parse(resultStrings[1]);
						length = resultArray.Count();

						for (var i = 0; i < length; i++)
							buf[i] = resultArray[i];
					}
					else
						Marshal.Copy(SolveFromFile(fileName.Text, ref length, ref sum), buf, 0, length);
				}
				else
				{
					var n = (int)languageCount.Value;
					var m = (int)translatorCount.Value;
					var a = new int[n, m];
					var c = new int[m];

					for (var i = 0; i < n; i++)
						for (var j = 0; j < m; j++)
						{
							var number = 0;

							if (gridProblem[j, i].Value != null && int.TryParse(gridProblem[j, i].Value.ToString(), out number))
								a[i, j] = number;
							else
								throw new Exception("Ошибка данных");
						}

					for (var i = 0; i < m; i++)
					{
						var salary = 0;

						if (gridProblem[i, n].Value != null && int.TryParse(gridProblem[i, n].Value.ToString(), out salary))
							c[i] = salary;
						else
							throw new Exception("Ошибка данных");
					}

					Marshal.Copy(SolveByUserInput(m, n, FlattenArray(a, n, m), c, ref length, ref sum), buf, 0, length);
				}
				
				tabs.SelectTab(tabSolution);
				ShowResults(buf, length, sum);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
