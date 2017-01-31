/*
=======================================================================================================================
File name:		openration.h
Date:			11-14,2015
Author:			star cluster
Description:	提供大数运算功能的访问
=======================================================================================================================
*/
#ifndef OPENRATION_H
#define OPENRATION_H


#include <stdint.h>
#include "MyString.h"

typedef int8_t *Num;


/*
	name:add
	function:传入两个字符串形式的数,进行加法运算
	return:以字符串形式返回运算结果
*/
extern String add(String first, String second);

/*
	name:numlen
	function:测出数组长度
	return:数组长度
*/
extern int numlen(Num num);


#endif