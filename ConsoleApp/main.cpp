// sippozemka.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>
#include <fstream>
#include <cstdio>
#include <string>
#include <windows.h>
#include <stdio.h>
#include "solver.h"

using namespace std;

void printResult(int* result, Problem& problem, bool verbatim = true) {
	if (verbatim)
		cout << "Массив назначений: " << endl;

	for (int j = 0; j < problem.GetM(); j++)
		cout << result[j] << " ";

	int summ = 0;

	for (int j = 0; j < problem.GetM(); j++)
		if (result[j] == 1) summ += problem.GetCi(j);
	
	if (verbatim)
		cout << endl << "Суммарная стоимость найма: " << summ;
	else
		cout << endl << summ;
}

int menu() {
	int var;

	// MENU
	cout << "Выберите вариант\n" << endl;
	cout << "1. Ввести данные вручную" << endl << "2. Считать из файла" << endl;
	cin >> var;

	return var;
}

void runByUserInput(bool verbatim = true) {
	int n, m;
	int *c;
	int **a;

	cout << "Введите количество переводчиков" << endl;
	cin >> m;
	cout << "Введите количество языков" << endl;
	cin >> n;

	c = new int[m];
	a = new int*[n];

	for (int i = 0; i < n; i++) a[i] = new int[m];

	cout << "Заполните матрицу " << endl;

	for (int i = 0; i < n; i++)
		for (int j = 0; j < m; j++)
		{
			cout << "Введите элемент строки " << i << " столбца " << j << endl;
			cin >> a[i][j];
		}

	for (int j = 0; j < m; j++)
	{
		cout << "Введите зарплату переводчика " << j << endl;
		cin >> c[j];
	}

	Problem p(m, n, a, c);
	Solver t;
	int* result = t.Greed(p);

	printResult(result, p, verbatim);
	delete[] result;
	delete[] c;

	for (int i = 0; i < n; i++)
		delete[] a[i];

	delete[] a;
}

void runByFile(char* fileName, bool verbatim = true) {
	Solver t;
	Problem p(fileName);
	int* result = t.Greed(p);

	printResult(result, p, verbatim);
	delete[] result;
}

int main(int argc, char** argv)
{
	setlocale(LC_ALL, "Russian");
	
	int var = 0;
	
	if (argc == 1) {
		var = menu();

		if (var == 1)
			runByUserInput();
		else if (var == 2)
		{
			char* fileName = new char[512];

			cout << "Введите название файла: ";
			cin >> fileName;

			runByFile(fileName);

			delete[] fileName;
		}
	}
	else
		runByFile(argv[1], false);


	return 0;
}
