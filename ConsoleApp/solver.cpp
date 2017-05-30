#include "stdafx.h"
#include "solver.h"

int* Solver::Greed(Problem& problem )
{
	int k = 0, *lang, s;
	int* res = new int[problem.GetM()];

	lang = new int[problem.GetN()];
	
	for (int i = 0; i < problem.GetN(); i++) lang[i] = 0; //массив непокрытых €зыков
	for (int j = 0; j < problem.GetM(); j++) res[j] = 0; //массив с назначени€ми

	for (int i = 0; i < problem.GetN(); i++)
	{
		for (int j = 0; j < problem.GetM(); j++)
		{
			if (problem.GetAij(i,j) == 1)         
			{
				k++;
				s = j;
			}
		}
		if (k == 1)                   //если €зык i знает только 1 переводчик
		{
			res[s] = 1;
			for (int p = 0; p < problem.GetN(); p++)
			{
				if (problem.GetAij(p, s) == 1) lang[p] = 1;
			}
		}
	}

	//закрываем все непокрытые €зыки, на каждом шаге выбираем переводчика с оптимальной средней стоимостью относительно непокрытых €зыков
	for (int i = 0; i < problem.GetN(); i++)
	{
		if (lang[i] == 0)
		{
			s = MinAveragePrice(problem, lang);
			res[s] = 1;                          //назначаем переводчика
			for (int j = 0; j < problem.GetN(); j++)
			{
				if (problem.GetAij(j, s) == 1) lang[j] = 1;   // покрываем €зыки, которые знает оптимальный на данной итерации переводчик
			}
			i = 0;   // чтобы заново начать проверку €зыков на покрытость
		}
	}

	return res;
}

int Solver::MinAveragePrice(Problem& problem, int* lang)
{
	// вычисл€ем среднюю стоимость переводчика относительно количества непокрытых €зыков, которыми он владеет и возвращаем номер переводчика с оптимальной ценой
	int s = -1;         //номер оптимального переводчика
	double *r, tmp;    //массив дл€ средней стоимости переводчиков, счетчик
	r = new double[problem.GetM()];
	for (int j = 0; j < problem.GetM(); j++)
	{
		tmp = 0;
		for (int i = 0; i < problem.GetN(); i++)
		{
			if ((problem.GetAij(i, j) == 1) && (lang[i] == 0)) tmp++;
		}
		if (tmp != 0) r[j] = problem.GetCi(j) / tmp;      // средн€€ стоимость переводчика j
		else r[j] = 0;
	}
	tmp = 0;
	for (int j = 0; j < problem.GetM(); j++)
	{
		if (r[j] > 0) {
			tmp = r[j];
			s = j;
			break;
		}
	}
	for (int j = 0; j < problem.GetM(); j++)
	{
		if ((r[j] < tmp) && (r[j]>0))
		{
			tmp = r[j];
			s = j;
		}
	}

	delete[] r;

	return s;
}
