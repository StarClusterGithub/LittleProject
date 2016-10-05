/*
=======================================================================================================================
File name:		openration.c
Date:			11-14,2015
Author:			star cluster
Description:	ʵ�ִ�������
=======================================================================================================================
*/
#include <stdio.h>
#include <malloc.h>
#include "openration.h"


#define NumRealloc(memory,newlen) (Num)realloc(memory,(newlen)*sizeof(int8_t))
#define StrRealloc(memory,newlen) (String)realloc(memory,(newlen)*sizeof(char))

static Num tonum(String str);//��Stringת��ΪNum
static String tostring(Num num);//��Numת��ΪString
static Num addition(Num first, int flen, Num second, int slen);//�ӷ�ʵ��
static Num subtraction(Num first, int flen, Num second, int slen);//����ʵ��


extern String add(String first, String second)//�ӷ�
{
	Num num1 = tonum(first), num2 = tonum(second);
	return tostring(addition(num1, numlen(num1), num2, numlen(num2)));
}

extern String sub(String first, String second)
{
	Num num1 = tonum(first), num2 = tonum(second);
	return tostring(subtraction(num1, numlen(num1), num2, numlen(num2)));
}

extern int numlen(Num num)//num�ĳ���
{
	int len = 0;
	while (num[len++] != -128);
	return len - 1;
}

static Num addition(Num first, int flen, Num second, int slen)//�ӷ�ʵ��
{
	Num result = NULL;
	int i = 0, fnum = 0, snum = 0, carry = 0;
	for (i = 0, fnum = 0, snum = 0, carry = 0; i < flen || i < slen || carry == 1; ++i)
	{
		result = NumRealloc(result, i + 2);
		fnum = i > flen - 1 ? 0 : first[i];
		snum = i > slen - 1 ? 0 : second[i];
		result[i] = (fnum + snum + carry) % 100;
		carry = (fnum + snum + carry) / 100;
	}
	result[i] = -128;
	free(first); free(second);
	return result;
}

static Num subtraction(Num first, int flen, Num second, int slen)//����ʵ��
{
	Num result = NULL;
	int i = 0, fnum = 0, snum = 0, carry = 0;
	for (i = 0, fnum = 0, snum = 0, carry = 0; i < flen || i < slen; ++i)
	{
		result = NumRealloc(result, i + 2);
		fnum = i > flen - 1 ? 0 : first[i];
		snum = i > slen - 1 ? 0 : second[i];
		result[i] = ((fnum - carry + 100)- snum) % 100 ;
		carry = (fnum - carry) < snum ? 1 : 0;
	}
	result[i] = -128;
	free(first); free(second);
	return result;
}

static Num tonum(String str)//��strת��ΪNum(������)
{
	Num number = NULL;
	int i = 0, j = 0, len = 0;//iΪstr���±�,jΪnumber���±�,len���Ѷ�����
	for (number = NumRealloc(number, 2), i = stringlen(str) - 1, j = 0, len = 0, number[0] = 0; i>=0&&str[i] != '-'; --i, ++len)//��str�԰ٽ�����������num��
	{
		if (len == 2)
		{
			len = 0; ++j;
			number = NumRealloc(number, j + 2);//���һ��λ�������������ֹ���
			number[j] = 0;
		}
		number[j] += (len == 0) ? (str[i] - '0') : ((str[i] - '0') * 10);
	}
	number[j] *= str[0] == '-' ? -1 : 1;
	number[j + 1] = -128;//��ֹ���
	//free(str);
	return number;
}

static String tostring(Num num)//��Numת��ΪSting
{
	String str = NULL;
	int i = 0, j = 0, len = numlen(num);
	if (num[len - 1] < 0)//���Ŵ���
	{
		str = StrRealloc(str, 1);
		str[i++] = '-';
		num[len - 1] *= -1;
	}
	str = StrRealloc(str, num[len - 1] < 10 ? i + 2 : i + 3);
	if (num[len - 1] >= 10)
		str[i++] = num[len - 1] / 10 + '0';
	str[i++] = num[len - 1] % 10 + '0';
	for (j = len - 2; j >= 0; --j)
	{
		str = StrRealloc(str, i + 3);
		str[i++] = num[j] / 10 + '0';
		str[i++] = num[j] % 10 + '0';
	}
	str = StrRealloc(str, i + 1);
	str[i] = '\0';
	free(num);
	return str;
}