#include <iostream>
#include "Includes.h"

using namespace std;

template<class T>
void Solution()
{
	srand(time(NULL));
	int i = 0,
		Count_tanker1 = 25,
		Count_tanker2 = 55,
		Count_tanker3 = 20;
	T* Create_turn = new T[100];
	Tanker1 First_tanker;
	Tanker2 Second_tanker;
	Tanker3 Third_tanker;
	while(i < 100)
	{
		int choice = rand() % 3;
		switch (choice)
		{
		case 1:
			if (Count_tanker1 > 0)
			{
				Create_turn[i] = First_tanker;
				Count_tanker1--;
				i++;
			}
			break;
		case 2:
			if (Count_tanker2 > 0)
			{
				Create_turn[i] = Second_tanker;
				Count_tanker2--;
				i++;
			}
			break;
		case 3:
			if (Count_tanker3 > 0)
			{
				Create_turn[i] = Third_tanker;
				Count_tanker3--;
				i++;
			}
			break;
		}
	}
}

int main()
{
	setlocale(LC_ALL, "ru");
	Solution<void*>();

	return 0;
}