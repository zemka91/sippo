#include "stdafx.h"
#include <fstream>
#include <string>
#include <iostream>
#include "problem.h"
#include "solver.h"

using namespace std;

int** expandArray(int* arr, int length, int rows) {
	int** res = new int*[rows];
	int cols = length / rows;

	for (int i = 0; i < rows; i++) {
		res[i] = new int[cols];

		for (int j = 0; j < cols; j++) {
			res[i][j] = arr[i * cols + j];
		}
	}

	return res;
}

double getSum(Problem& p, int* result) {
	double sum = 0;

	for (int i = 0; i < p.GetM(); i++)
		if (result[i] == 1)
			sum += p.GetCi(i);

	return sum;
}

extern "C" {
	__declspec(dllexport) int* SolveByUserInput(int m, int n, int* aFlat, int* c, int& length, double& sum) {
		int** a = expandArray(aFlat, m * n, n);
		Problem p(m, n, a, c);
		Solver s;
		int* res = s.Greed(p);

		length = p.GetM();
		sum = getSum(p, res);

		for (int i = 0; i < n; i++)
			delete[] a[i];

		delete[] a;

		return res;
	}

	__declspec(dllexport) int* SolveFromFile(char* fileName, int& length, double& sum) {
		Problem p(fileName);
		Solver s;
		int* res = s.Greed(p);

		length = p.GetM();
		sum = getSum(p, res);

		return res;
	}
}
