/*
=======================================================================================================================
File name:		openration.h
Date:			11-14,2015
Author:			star cluster
Description:	�ṩ�������㹦�ܵķ���
=======================================================================================================================
*/
#ifndef OPENRATION_H
#define OPENRATION_H


#include <stdint.h>
#include "MyString.h"

typedef int8_t *Num;


/*
	name:add
	function:���������ַ�����ʽ����,���мӷ�����
	return:���ַ�����ʽ����������
*/
extern String add(String first, String second);

/*
	name:numlen
	function:������鳤��
	return:���鳤��
*/
extern int numlen(Num num);


#endif