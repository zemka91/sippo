#pragma once
#include "stdafx.h"
#include <string>

using namespace std;

class Problem
{
private:
	int m, n, **a, *c;  //пол€ - кол-во переводчиков, кол-во €зыков, матрица знани€ €зыков, массив стоимости переводчиков
public:
	Problem(string fileName);
	Problem(int m, int n, int** a, int* c);
	~Problem();

	int GetM() { return m; }
	int GetN() { return n; }
	double GetCi(int i) { return c[i]; }
	double GetAij(int i, int j) { return a[i][j]; }
};
