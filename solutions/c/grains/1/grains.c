#include "grains.h"
#include <stdio.h>

uint64_t square(uint8_t index){
	if(index == 0){
		return 0;
	}
	int i;
	uint64_t grains = 1;
	for(i=1; i<index; i++){
		grains *=2;
	}
	return grains;
}

uint64_t total(void){
	return (square(65)-1);
}
