/*
=======================================================================================================================
File name:		MyString.c
Date:			11-14,2015
Author:			star cluster
Description:	提供字符串功能的访问
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
	function:逆转字符串
	return:成功与否的状态
*/
extern BOOL reverse(String str, int len);

/*
	name:stringlen
	function:测出字符串长度
	return:字符串长度
*/
extern int stringlen(String str);

/*
	name:numcmp
	fuction:比较两个字符串代表的数的大小
	returne:第一个数大于等于第二个数则返回true，否则返回false
*/
extern BOOL numcmp(String first,String second);


#undef BOOL
#undef FALSE
#undef TRUE


#endif