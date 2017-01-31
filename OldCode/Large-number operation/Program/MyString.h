/*
=======================================================================================================================
File name:		MyString.c
Date:			11-14,2015
Author:			star cluster
Description:	�ṩ�ַ������ܵķ���
=======================================================================================================================
*/
#ifndef MyString_H
#define MyString_H


#define BOOL short
#define FALSE 0
#define TRUE 1

typedef char *String;

/*
	name:newstr
	function:creat a String
	return:the String pointer
*/
extern String getstr(void);

/*
	name:reverse
	function:��ת�ַ���
	return:�ɹ�����״̬
*/
extern BOOL reverse(String str, int len);

/*
	name:stringlen
	function:����ַ�������
	return:�ַ�������
*/
extern int stringlen(String str);

/*
	name:numcmp
	fuction:�Ƚ������ַ�����������Ĵ�С
	returne:��һ�������ڵ��ڵڶ������򷵻�true�����򷵻�false
*/
extern BOOL numcmp(String first,String second);


#undef BOOL
#undef FALSE
#undef TRUE


#endif