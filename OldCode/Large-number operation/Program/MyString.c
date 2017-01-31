/*
=======================================================================================================================
File name:		MyString.c
Date:			11-14,2015
Author:			star cluster
Description:	实现字符串操作功能
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

extern String getstr(void)//创建并返回一个新的字符串
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

extern BOOL reverse(String str,int len)//逆置字符串
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

extern int stringlen(String str)//测出字符串长度
{
	int len = 0;
	while (str[len++]!='\0');
	return len - 1;
}

extern BOOL numcmp(String first,String second)//判断第一个数是否大于第二个数
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