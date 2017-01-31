/*
=======================================================================================================================
File name:		MyString.c
Date:			11-14,2015
Author:			star cluster
Description:	ʵ���ַ�����������
=======================================================================================================================
*/
#include <stdio.h>
#include <malloc.h>
#include "MyString.h"
#include "openration.h"

#define BOOL short
#define FALSE 0
#define TRUE 1
#define StrRealloc(memory,newlen) (String)realloc(memory,(newlen)*sizeof(char))

extern String getstr(void)//����������һ���µ��ַ���
{
	String newstr = NULL;
	int len = 0; char ch = '\0';
	for (len = 0,ch = '\0'; ((ch = getchar()) != '\n'&&ch != EOF);)
	{
		newstr = StrRealloc(newstr,++len);
		newstr[len - 1] = ch;
	}
	return newstr;
}

extern BOOL reverse(String str,int len)//�����ַ���
{
	if (str == NULL)
		return FALSE;
	char temp = '\0';
	for (int i = 0; i < len / 2; ++i)
	{
		temp = str[i];
		str[i] = str[len - 1 - i];
		str[len - 1 - i] = str[i];
	}
	return TRUE;
}

extern int stringlen(String str)//����ַ�������
{
	int len = 0;
	while (str[len++]!='\0');
	return len - 1;
}

extern BOOL numcmp(String first,String second)//�жϵ�һ�����Ƿ���ڵڶ�����
{
	int flen = stringlen(first),slen = stringlen(second);
	if(flen>slen)
		return TRUE;
	if(flen<slen)
		return FALSE;
	for(int i = flen;i>=0;++i)
	{
		if(first[i]>second[i])
			return TRUE;
	}
	return FALSE;
}