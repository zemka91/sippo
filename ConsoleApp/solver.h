#pragma once
#include "problem.h"

class Solver
{
private:
	//int minaverageprice(int n, int m, int**a, int* c, int* lang);
	int MinAveragePrice(Problem& problem, int* lang);
public:
	//void SetResi(int i) { res[i] = 1; } //назначить переводчика i
	//void greed(int n, int m, int** a, int* c, int *result);
	int* Greed(Problem& problem);
};
