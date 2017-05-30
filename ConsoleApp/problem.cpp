#include "stdafx.h"
#include "problem.h"
#include <iostream>
#include <fstream>
#include <cstdio>
#include <windows.h>
#include <stdio.h>

Problem::Problem(string fileName)
{
	ifstream f(fileName);

	if (!f)
		throw 0;

	f >> n;
	f >> m;
	
	c = new int[m];
	a = new int*[n];
	
	for (int i = 0; i < n; i++) a[i] = new int[m];
	for (int i = 0; i < n; i++)
		for (int j = 0; j < m; j++)
			f >> a[i][j];
	for (int j = 0; j < m; j++) f >> c[j];

	f.close();
}

Problem::Problem(int m, int n, int** a, int* c)
{
	this->m = m;
	this->n = n;
	this->a = new int* [n];

	for (int i = 0; i < n; i++) {
		this->a[i] = new int[m];

		for (int j = 0; j < m; j++)
			this->a[i][j] = a[i][j];
	}
	
	this->c = new int [m];

	for (int j = 0; j < m; j++)
		this->c[j] = c[j];
}

Problem::~Problem()
{
	delete[] c;
	
	for (int i = 0; i < n; i++)
		delete[] a[i];

	delete[] a;
}
