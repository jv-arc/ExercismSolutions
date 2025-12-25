#include "leap.h"
#include <stdbool.h>

bool leap_year(int year){
	bool by_4 = (year % 4) == 0;
	bool by_100 = (year % 100) == 0;
	bool by_400 = (year % 400) == 0;

	return ((by_4 && !by_100) || by_400);
}
