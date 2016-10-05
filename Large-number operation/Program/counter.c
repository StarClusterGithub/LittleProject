#if 0
/*
=======================================================================================================================
Name:		 counter.c
Author:		 star_cluster
Description: �������鷽ʽ���д���������(��������Χ)
=======================================================================================================================
*/
#pragma warning(disable:4996)//�ص�getch()�İ�ȫ���
#include <stdio.h>
#include <time.h>
#include <conio.h>
#include <stdlib.h>
#include <string.h>
#include <windows.h>

#define RADIX 1000000000
typedef long long DataType;

typedef struct OPERATION//����һ���ṹ��,�����������
{
	char sign;//�������
	DataType *first;//��һ����
	DataType *second;//�ڶ�����
	DataType *result;//������
	int flen;//��һ�����ĳ���
	int slen;//�ڶ������ĳ���
	int len;//�������ĳ���
}OPERATION;


void getnum(OPERATION *num);//���뺯��,����������Ҫ�����ʽ��,������ʽ�ӵķ���
void control(OPERATION *num);//���ƺ���,�����ж��������Ͳ����д���
void sort(DataType *num, int len);//������,�����������鰴��������
int compare(DataType *first, int flen, DataType *second, int slen);//�ȽϺ���,�Ƚ�������������Ĵ�С
void addition(OPERATION *num);//�ӷ�����
void subtraction(OPERATION *num);//��������
void difference(OPERATION *num);//�����һ������ȥ�ڶ������Ľ��
void multiplication(OPERATION *num);//�˷�����
void division(OPERATION *num);//��������
void factorial(OPERATION *num);//�׳�����
void power(OPERATION *num);//������
int putnum(OPERATION *num);//�������,���������ʽ
void keep(OPERATION *num,int len);//���溯��,������������Ϊ�ı��ļ�,���������ֱ�Ϊ��Ҫ���������ʽ������ʽ����ĳ���

static clock_t Start = 0, Finish = 0, Time_open = 0, Time_put = 0;//��¼ʱ��

int main(void)
{
	for (char ch = '\0'; ch != 27; ch = getch())
	{
		OPERATION num = { '\0', NULL, NULL, NULL, 0, 0, 0 };
		char choose = '\0';//ѡ��
		int len = 0;//����������
		system("cls");
		printf("\n\t\t�������������1.2��");
		printf("\n\t\tMade in star cluster\n");
		printf("��ܰ��ʾ:����������֧���������ļӼ��˳����׳ˡ�������,���ݿ����ö��Ÿ���.\n");
		printf("��������:12345+54321                 ��������:12345*-12345\n");
		printf("\n\n��������������Χ�ڵ�����ʽ(����ָ���������):\n");
		for (getnum(&num); num.sign != '!' && (num.first == NULL || num.second == NULL); free(num.first), free(num.second), getnum(&num))
			printf("����ʽ�������!����������!�����׼��ο���ܰ��ʾ.\n");
		Start = clock();//��¼��������ʱ��
		control(&num);//ͨ�����ƺ������м���
		Finish = clock();//��¼��������ʱ��
		Time_open = Finish - Start;//�����������ķ�ʱ��
		Start = clock();//��¼�������ʱ��
		printf("������Ϊ:\n");
		len = putnum(&num);
		Finish = clock();//��¼�������ʱ��
		printf("�������ĳ���Ϊ:%dλ��.\n", len);
		printf("The program running time of %ld milliseconds, %.3lf second.\n", Time_open, (double)(Time_open / 1000.0));
		Time_put = Finish - Start;//����������ķ�ʱ��
		printf("The program output takes %ld milliseconds, %.3lf second.\n", Time_put, (double)(Time_put / 1000.0));
		for (choose = '\0'; 'Y' != choose && 'N' != choose && 'y' != choose && 'n' != choose; fflush(stdin), choose = getchar())
			printf("�Ƿ񱣴�������?(Y/N)");
		if ('Y' == choose || 'y' == choose)
			keep(&num,len);
		printf("��ESC���˳�,�����������...\n");
		fflush(stdin);
		//�ͷŶ�̬������ڴ�
		free(num.first);
		free(num.second);
		free(num.result);
	}
	printf("��л����ʹ��,�ټ�!\n");
	Sleep(2500);
	return 0;
}


//���뺯��,����������Ҫ�����ʽ��(����������)
void getnum(OPERATION *num)
{
	char *temp = NULL;//temp������ʱ�м����
	int i = 0, j = 0, length = 0, right = 0, power = 0;//iΪ��ʱ����temp���±��,jΪѭ������,length�ǳ���,right�ж�������ַ��Ƿ��������,powerΪ10��length-1����
	num->sign = '\0', num->first = NULL, num->second = NULL, num->result = NULL, num->flen = 0, num->slen = 0;
	for (; right == 0;)
	{
		for (i = 0, temp = (char *)malloc(sizeof(char)); scanf("%c", temp + i), temp[i] != '\n'; temp = (char *)realloc(temp, (++i + 1)*sizeof(char)))//��������ʽ�������temp��
		{
			if (temp[i] == '+' || temp[i] == '-' || temp[i] == '*' || temp[i] == '/' || temp[i] == '!' || temp[i] == '^')//����Ƿ������������
			{
				++right;
				continue;
			}
			if (temp[i] != ',' && (temp[i]<'0' || temp[i]>'9'))
			{
				right = 0;
				fflush(stdin);
				break;
			}
		}
		if (right == 0||right>1)
		{
			printf("����ʽ�������!����������!�����׼��ο���ܰ��ʾ.\n");
			free(temp); temp = NULL; right = 0;
		}
	}
	for (length = 1; temp[i] != '+' && temp[i] != '-' && temp[i] != '*' && temp[i] != '/' && temp[i] != '!'&&temp[i] != '^'; --i)//�����һ���ַ���ʼ��ȡ������second��
	{
		if ('0' <= temp[i] && temp[i] <= '9')//ֻ�е�����������ǰ���������ʱ�Ž��д���
		{
			if (1 == length)
			{
				num->second = (DataType *)realloc(num->second, ++num->slen*sizeof(DataType));//lengthΪ1˵����10�ڽ����е�"��λ��",��Ҫ������һ���ڴ�ռ���
				num->second[num->slen - 1] = 0;
			}
			for (j = 1, power = 1; j < length; ++j)
				power *= 10;
			num->second[num->slen - 1] += (temp[i] - '0') * power;
			if (9 == length)//length�ﵽ9ʱ��10�ڽ����е�"���λ",��Ҫ��length��ֵΪ0
				length = 1;
			else//δ��9���������
				++length;
		}
	}
	for (num->sign = temp[i--], length = 1; i >= 0; --i)//��¼������Ų���ʣ�����ݷ���first��
	{
		if ('0' <= temp[i] && temp[i] <= '9')
		{
			if (1 == length)//lengthΪ1˵����10�ڽ����е�"��λ��",��Ҫ������һ���ڴ�ռ���
			{
				num->first = (DataType *)realloc(num->first, ++num->flen*sizeof(DataType));
				num->first[num->flen - 1] = 0;
			}
			for (j = 1, power = 1; j < length; ++j)
				power *= 10;
			num->first[num->flen - 1] += (temp[i] - '0') * power;
			if (9 == length)//length�ﵽ9ʱ��10�ڽ����е�"���λ",��Ҫ��length��ֵΪ0
				length = 1;
			else//δ��9���������
				++length;
		}
	}
	free(temp);//�ͷ�temp
	fflush(stdin);//��ջ�����
}


//���ƺ���,�����ж��������Ͳ����д���
void control(OPERATION *num)
{
	switch (num->sign)
	{
	case '+':
		addition(num);//�ӷ�
		break;
	case '-':
		subtraction(num);//����
		break;
	case '*':
		multiplication(num);//�˷�
		break;
	case '/':
		division(num);//����
		break;
	case '!':
		if (num->first[0] < 0)
		{
			printf("����û�н׳�!");
		}
		else
			factorial(num);//�׳�����
		break;
	case '^':
		power(num);
		break;
	default:
		printf("��֧�ֵ������!\n");
		break;
	}
	//��������
	sort(num->first, num->flen);
	sort(num->second, num->slen);
	sort(num->result, num->len);
}


//������,���ڶ���������������,ʹ֮��������˳����
void sort(DataType *num, int len)
{
	int i = 0, j = 0; DataType temp = 0;
	for (i = 0, j = len - 1; i < j; ++i, --j)
	{
		temp = num[i];
		num[i] = num[j];
		num[j] = temp;
	}
}


//�ȽϺ���,�Ƚ�������������Ĵ�С,����1��ʾ��һ�������ڵڶ�����,-1���෴,0��ʾ�������
int compare(DataType *first,int flen,DataType *second,int slen)
{
	int i = 0, j = 0, big = 0;//iΪ�±��,big��¼��С��Ϣ
	if (flen > slen)//����һ������ڶ������Ĵ�С��ϵ,1��ʾ��һ�������ڵڶ�����,0���෴,-1��ʾ�������
		big = 1;
	else
	{
		if (flen < slen)
			big = -1;
		else
		{
			for (i = flen - 1, j = slen - 1; i >= 0; --i, --j)//���������������������,��Ӹ�λ��(��������һλ)��ʼ��λ�ж�
			{
				if (first[i] > second[j])
				{
					big = 1;
					break;
				}
				else
				{
					if (first[i] < second[j])
					{
						big = -1;
						break;
					}
				}
			}
		}
	}
	return big;
}


//�ӷ�����
void addition(OPERATION *num)
{
	int i = 0;//iΪ�������������������±�
	int carry = 0, bigger = (num->flen > num->slen ? num->flen : num->slen), minor = (num->flen < num->slen ? num->flen : num->slen);//carry�ǽ�λ��,bigger�Ǽ����ͱ������г��Ƚϴ��,minor���ǽ�С��
	for (i = 0; i < bigger; ++i)
	{
		num->result = (DataType *)realloc(num->result, ++num->len *sizeof(DataType));//�ı�num->result�Ĵ�С,ʹ֮�ܹ�����������
		if (i >= minor)//����������е�һ�����Ѿ�������,��ô������Ǹ�����������������
		{
			if (i >= num->flen)
			{
				num->result[i] = (num->second[i] + carry) % RADIX;//��δ����������λ��������������
				carry = (num->second[i] + carry) / RADIX;
			}
			else
			{
				num->result[i] = (num->first[i] + carry) % RADIX;//ͬ��
				carry = (num->first[i] + carry) / RADIX;
			}
		}
		else
		{
			num->result[i] = (num->first[i] + num->second[i] + carry) % RADIX;//�����Ӻ����
			carry = (num->first[i] + num->second[i] + carry) / RADIX;//��¼��Ӻ�Ľ�λ��
		}
		if ((i + 1 == bigger) && carry != 0)//�����������г�����λ���Ѿ��ӵ�����ǰһλ,������Ҫ��λ,��ִ�д����
		{
			num->result = (DataType *)realloc(num->result, ++num->len*sizeof(DataType));//�ı�num->result�Ĵ�С,ʹ֮�ܹ�����������
			num->result[num->len - 1] = carry;
		}
	}
}


//��������
void subtraction(OPERATION *num)
{
	DataType *temporary = NULL; int temp = 0; //tempΪ����num->result˳��ͼ���С���������������м����,temporary�Ǽ���С����������ָ���м����
	switch (compare(num->first,num->flen,num->second,num->slen))//���ݼ����뱻�����Ĵ�С��ϵ��������
	{
	case 0://���������ڼ���
		num->result = (DataType *)malloc(++num->len*sizeof(DataType));//������Ϊ0,ֻ��Ҫһ��int���ڴ浥λ
		num->result[0] = 0;
		break;
	case 1://���������ڼ���
		difference(num);//ֱ�Ӽ����ֵ
		break;
	case -1://������С�ڼ���

		//�������ͱ���������
		temporary = num->first;
		num->first = num->second;
		num->second = temporary;
		temp = num->flen;
		num->flen = num->slen;
		num->slen = temp;

		difference(num);//���ú��������ֵ

		//�������ͱ�����������
		temporary = num->first;
		num->first = num->second;
		num->second = temporary;
		temp = num->flen;
		num->flen = num->slen;
		num->slen = temp;

		//С��������,���Ϊ��,��ǰһλ�����ϸ���
		num->result[num->len - 1] *= -1;
	}
}


//�����һ������ȥ�ڶ������Ĳ�ֵ
void difference(OPERATION *num)
{
	int i = 0;//iΪ�±�ű���
	int carry = 0, bigger = (num->flen > num->slen ? num->flen : num->slen), minor = (num->flen < num->slen ? num->flen : num->slen);// carryΪ��λ��,bigger���������г��Ƚϴ�����ĳ���,minor���ǽ�С��
	for (i = 0; i < bigger; ++i)
	{
		num->result = (DataType *)realloc(num->result, ++num->len*sizeof(DataType));//ʹnum->result�ܷ�������
		if (i >= minor)//�������Ѿ���������ֻ��Ҫ���ʵ�ʵı�����(��num->first[i]+carry)
		{
			if (carry + num->first[i] < 0)//������ʵ��ֵС��0ʱ
			{
				num->result[i] = (carry + num->first[i] + RADIX) % RADIX;//����RADIX(10��)�Ա�֤num->first[i]Ϊ��
				carry = -1;
			}
			else//������ʵ��ֵ��С��0
			{
				num->result[i] = (carry + num->first[i]) % RADIX;
				carry = 0;
			}
		}
		else//����δ����
		{
			if (num->first[i] + carry < num->second[i])//�����λ���ı�����С�ڼ���
			{
				num->result[i] = ((num->first[i] + carry + RADIX) - num->second[i]) % RADIX;//�����,+RADIX��%RADIX��֤�������0С��10��
				carry = -1;//��ʱ��Ҫ���λ����1
			}
			else//��λ���ı��������ڼ�����ֱ�����
			{
				num->result[i] = (num->first[i] + carry) - num->second[i];
				carry = 0;
			}
		}
	}

	//������֮����������ж����0ȥ��
	for (i = num->len - 1; i >= 0; --i)
	{
		if (num->result[i] == 0)
		{
			num->result = (DataType *)realloc(num->result, --num->len*sizeof(DataType));
		}
		else
			break;//ֻҪ����һ����Ϊ0������˵��ʣ�µĶ�����Ч������,���˳�
	}
}


//�˷�����
void multiplication(OPERATION *num)
{
	int i = 0, j = 0, k = 0;//i,j,kΪ�±�ű���
	int carry = 0;// carryΪ��λ��
	DataType temp = 0;//tempΪ�ۼ�ʱ����ʱ����

	for (j = 0; j < num->slen; ++j)//���ճ˷���������һλ����
	{
		for (i = 0, k = j, carry = 0, temp = 0; i < num->flen; ++i, ++k)//iΪ��һλ�����±��,kΪ������±��
		{
			num->result = (DataType *)realloc(num->result, (num->len > (k + 1) ? num->len : (k + 1))*sizeof(DataType));//��result���ȵ���Ϊ���ʳ���,����ÿ��ִ����ѭ��ʱ��k=j,������Ҫ��k+1��len�Ƚ�,���ϴ����Ϊ����
			if (num->result[k] < 0 || num->result[k] > RADIX - 1)//�ж��Ƿ���Ч����,û�еĻ�����0
			{
				num->result[k] = 0;
			}
			temp = num->result[k] + num->second[j] * num->first[i] + carry;
			num->result[k] = temp % RADIX;//ȡ����λ��
			carry = temp / RADIX;//ȡ����λ��
			if (i == num->flen - 1 && carry != 0)//����Ѿ����굫�ǻ����λ
			{
				num->result = (DataType *)realloc(num->result, (++k + 1)*sizeof(DataType));
				num->result[k] = carry;
			}
		}
		num->len = k;//��num->len��ȷ��¼result�ĳ���
	}
}


//��������
void division(OPERATION *num)
{
	OPERATION temp = { '-', NULL, NULL, NULL, 0, 0, 0 };//�����������ʱ����
	int i = 0, k = 0;//ѭ������i,num->result�±�ű���k
	int end = 1;//��������

	num->result = (DataType *)malloc(++num->len*sizeof(DataType));//Ϊ�����������ڴ�
	num->result[0] = 0;//��ʼ��

	//����num��ֵ
	temp.first = (DataType *)malloc(num->flen*sizeof(DataType));
	for (temp.flen = num->flen, i = 0; i < num->flen; i++)
		temp.first[i] = num->first[i];
	temp.second = (DataType *)malloc(num->slen*sizeof(DataType));
	for (temp.slen = num->slen, i = 0; i < num->slen; i++)
		temp.second[i] = num->second[i];

	for (; end;)
	{
		switch (compare(temp.first, temp.flen, temp.second, temp.slen))//�ж�������С�����ִ����Ӧ����,-1ΪС��,0Ϊ���,1Ϊ����
		{
		case -1:
			end = 0;
			break;
		case 0:
			++num->result[0];//�̼�һ
			if (num->result[0] > RADIX - 1)//������
			{
				num->result[0] = 0;
				for (k = 1;; k++)
				{
					if (k > num->len - 1)//���鲻����ʱ
					{
						num->result = (DataType *)realloc(num->result, ++num->len*sizeof(DataType));
						num->result[num->len - 1] = 0;
					}
					++num->result[k];
					if (num->result[k] <= RADIX - 1)
						break;
					else
						num->result[k] = 0;
				}
			}
			end = 0;
			break;
		case 1:
			difference(&temp);//���
			//���֮�󽫽����Ϊ������
			temp.flen = temp.len;
			temp.len = 0;
			free(temp.first);
			temp.first = temp.result;
			temp.result = NULL;
			++num->result[0];//�̼�һ
			if (num->result[0] > RADIX - 1)//������
			{
				num->result[0] = 0;
				for (k = 1;; k++)
				{
					if (k > num->len - 1)//���鲻����ʱ
					{
						num->result = (DataType *)realloc(num->result, ++num->len*sizeof(DataType));
						num->result[num->len - 1] = 0;
					}
					++num->result[k];
					if (num->result[k] <= RADIX - 1)
						break;
					else
						num->result[k] = 0;
				}
			}
			break;
		}
	}
	free(temp.first);
	free(temp.second);
	if (temp.result != NULL)
		free(temp.result);
}


//�׳˺���
void factorial(OPERATION *num)
{
	if (num->flen == 1 && (num->first[0] == 0 || num->first[0] == 1))
	{
		num->result = (DataType *)malloc(++num->len*sizeof(DataType));//��result����һ�����ȵ��ڴ�
		num->result[0] = 1;//0��1�Ľ׳˶�Ϊ1
	}
	else
	{
		OPERATION temp = { '*', NULL, NULL, NULL, 0, 0, 0 };//��ʱ����,second��������,result�ǽ��,first��ǰһ�������Ľ׳�
		int i = 0;//iΪ����(second)���±��

		//������3��ʼ����,�������2��ʼ,��Ϊ���������2,��2�Ľ׳���Ϊ2
		temp.result = (DataType *)malloc(++temp.len*sizeof(DataType)); temp.result[0] = 2;
		temp.second = (DataType *)malloc(++temp.slen*sizeof(DataType)); temp.second[0] = 3;

		for (; compare(num->first, num->flen, temp.second, temp.slen) != -1;)//ѭ������Ϊ����С�ڵ����������
		{
			free(temp.first);
			temp.first = temp.result; temp.flen = temp.len;//�����(ǰһ�����Ľ׳�)��Ϊ������
			temp.result = NULL; temp.len = 0;//ʹresult��ָ���κ��ڴ�
			multiplication(&temp);//�˷�����
			for (++temp.second[0], i = 0; temp.second[i] == RADIX; ++i)//ʹ��������1
			{
				temp.second[i] = 0;
				if (i == temp.slen - 1)//������Ȳ�����ı�temp.second�Ĵ�С
				{
					temp.second = (DataType *)realloc(temp.second, ++temp.slen*sizeof(DataType));
					temp.second[++i] = 1;
				}
				else
					++temp.second[i + 1];
			}
		}
		num->result = temp.result; num->len = temp.len;//�������������
		//�ͷ��ڴ�
		free(temp.first);
		free(temp.second);
	}
}


//�����㺯��
void power(OPERATION *num)
{
	if (num->slen == 1 && num->second[0] == 0)//���ָ���Ƿ�Ϊ0,������Ϊ1
	{
		num->result = (DataType *)malloc(++num->len*sizeof(DataType));
		num->result[0] = 1;
	}
	else
	{
		if (num->slen == 1 && num->second[0] == 1)//���ָ���Ƿ�Ϊ1,������Ϊ��������
		{
			int i = 0;
			num->len = num->flen;
			num->result = (DataType *)malloc(num->len*sizeof(DataType));
			for (i = 0; i < num->len; ++i)
				num->result[i] = num->first[i];
		}
		else//��ָ����Ϊ1��0,���ö��������ݷ�������
		{
			OPERATION baseTemp = { '*', NULL, NULL, NULL, 0, 0, 0 }, resultTemp = { '*', NULL, NULL, NULL, 0, 0, 0 };//baseTemp�ǵ�����ʱ����,���ڼ��������ƽ��,resultTemp�ǽ����ʱ����,���ڼ����µĽ��
			DataType *temp = NULL;int tlen = 0;//temp��tlen�Ǽ��������ʱ����ʱ����
			int *binary = NULL, blen = 0, carry = 0;//binary��blen���ڴ���ָ���Ķ����Ƶ����鼰����ĳ���,carry�ǽ�λ��
			int i = 0, j = 0;//�±�ű���
			//���Ƶ���
			baseTemp.first = baseTemp.second = (DataType *)malloc(num->flen*sizeof(DataType)), baseTemp.flen = baseTemp.slen = num->flen;
			for (i = 0; i < num->flen; ++i)
				baseTemp.first[i] = num->first[i];
			//��ʼ�������ʱ����
			resultTemp.result = (DataType *)malloc(sizeof(DataType)), resultTemp.len = 1; resultTemp.result[0] = 1;
			//����ָ��
			temp = (DataType *)malloc(num->slen*sizeof(DataType)); tlen = num->slen;
			for (i = 0; i < num->slen; ++i)
				temp[i] = num->second[i];
			//����ָ���Ķ����Ʋ������binary
			for (; tlen > 0;)
			{
				binary = (int *)realloc(binary, ++blen*sizeof(int));
				binary[blen - 1] = temp[0] % 2;
				for (carry = 0, i = tlen - 1; i >= 0; --i)
				{
					if (temp[i] % 2 == 1)
					{
						temp[i] = (temp[i] + carry * RADIX) / 2;
						carry = 1;
					}
					else
					{
						temp[i] = (temp[i] + carry * RADIX) / 2;
						carry = 0;
					}

				}
				for (i = tlen - 1; i >= 0 && temp[i] == 0; --i)
					temp = (DataType *)realloc(temp, --tlen*sizeof(DataType));
			}
			for (i = 0; i <= blen; ++i)
			{
				if (binary[i] == 1 || i == blen)//��ֵ
				{
					free(resultTemp.second);
					resultTemp.first = baseTemp.first, resultTemp.flen = baseTemp.flen;
					resultTemp.second = resultTemp.result; resultTemp.slen = resultTemp.len;
					resultTemp.result = NULL, resultTemp.len = 0;
					multiplication(&resultTemp);
				}
				if (i != blen)//�����Գ�
				{
					multiplication(&baseTemp);
					free(baseTemp.first);
					baseTemp.first = baseTemp.second = baseTemp.result; baseTemp.flen = baseTemp.slen = baseTemp.len;
					baseTemp.result = NULL; baseTemp.len = 0;
				}
			}
			num->result = resultTemp.second; num->len = resultTemp.slen;
			free(baseTemp.first);
		}//ָ����Ϊ0��1ʱ��else�Ļ�����
	}
}


//�������,���������ʽ
int putnum(OPERATION *num)
{
	int i = 0;
	int len = 0, counting = 0;//len���������ĳ���,counting�ǳ��ȵļ�������
	printf("%lld", num->first[0]);//�����һ����
	for (i = 1; i < num->flen; i++)//�����һ����
	{
		printf("%09lld", num->first[i]);
	}
	printf(" %c ", num->sign);//����������
	if (num->second != NULL)//����ǽ׳�������secondΪNULL,��ȡ��ֵ�ᷢ���쳣
	{
		printf("%lld", num->second[0]);//�����һ����
		for (i = 1; i < num->slen; i++)//����ڶ�����
		{
			printf("%09lld", num->second[i]);
		}
	}
	printf("  =  ");//����Ⱥ�
	printf("%lld", num->result[0]);//�����һ����
	for (i = 1; i < num->len; i++)//���������
	{
		printf(",%09lld", num->result[i]);
	}
	printf("\n");//����
	for (len = (num->len - 1) * 9, counting = 1; counting <= (num->result[0] >= 0 ? num->result[0] : -1 * num->result[0]); counting *= 10, ++len);

	return len;
}


//���溯��,������������Ϊ�ı��ļ�,���������ֱ�Ϊ��Ҫ���������ʽ������ʽ����ĳ���
void keep(OPERATION *num, int len)
{
	FILE *target = NULL;//�ļ�ָ��
	char catalogue[100], tabletop[] = "����", here[] = "��ǰ�ļ���", temp[100];//�ļ�Ŀ¼catalogue,����tabletop,��ǰ�ļ���here,��ʱ����temp
	int i = 0;//ѭ������
	clock_t start = 0, finish = 0;//ʱ�����
	printf("�����뱣��·�����ļ���,��D:\\������.txt\n");
	printf("��Ҫ������������ߵ�ǰ�ļ��������ֱ�����������ǰ�ļ���,������\\������.txt\n");
	fflush(stdin);
	gets(temp);
	start = clock();//��ȡ����ʱ��
	for (i = 0; i < 10; ++i)//�ж������·��
	{
		if (temp[i] != tabletop[i] && temp[i] != here[i])
			break;
	}
	switch (i)//�������·������catalogue��
	{
	case 4:strcpy(catalogue, "C:\\Users\\Administrator\\Desktop\\"); strcat(catalogue, temp + 5); break;
	case 10:strcpy(catalogue, temp + 11); break;
	default:strcpy(catalogue, temp); break;
	}
	if (NULL == (target = fopen(catalogue, "w")))//����(��)�ļ�
	{
		perror("Cannot open this file!\nThe error message");
		system("pause"); exit(EXIT_FAILURE);
	}
	fprintf(target, "%lld", num->first[0]);//�����һ����
	for (i = 1; i < num->flen; i++)//�����һ����
	{
		fprintf(target, "%09lld", num->first[i]);
	}
	fprintf(target, " %c ", num->sign);//����������
	if (num->second != NULL)//����ǽ׳�������secondΪNULL,��ȡ��ֵ�ᷢ���쳣
	{
		fprintf(target, "%lld", num->second[0]);//�����һ����
		for (i = 1; i < num->slen; i++)//����ڶ�����
		{
			fprintf(target, "%09lld", num->second[i]);
		}
	}
	fprintf(target, "  =  ");//����Ⱥ�
	fprintf(target, "%lld", num->result[0]);//�����һ����
	for (i = 1; i < num->len; i++)//���������
	{
		fprintf(target, ",%09lld", num->result[i]);
	}
	fprintf(target, "\n");//����
	finish = clock();//��ȡ����ʱ��
	fprintf(target,"�������ĳ���Ϊ:%dλ��.\n", len);
	fprintf(target, "The program running time of %ld milliseconds, %.3lf second.\n", Time_open, (double)(Time_open / 1000.0));
	fprintf(target, "The program output takes %ld milliseconds, %.3lf second.\n", Time_put, (double)(Time_put / 1000.0));
	fprintf(target, "Save the results of time - consuming %ld milliseconds, %.3lf second.", finish - start, (double)((finish - start) / 1000.0));
	printf("����ɹ�!\n");
	fclose(target);//�ر��ļ�
}
#endif