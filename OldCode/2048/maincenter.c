/*
==================================================================================================================
Name        :	2048.c
Author      :	Star cluster
Description :	2048��Ϸ,���ֳ���2����(ֻ����2��4),֮�����ͨ����������������ƶ�����,��ͬ������ײ��ϲ�,
ÿһ�β��������ڿհ״��������2��4,���������ʱ��Ϸʧ��,����ģʽ�������ۼӵ�2048��ɹ�
==================================================================================================================
*/
#pragma warning(disable:4996)//�ص�getch()�İ�ȫ���
#include<stdio.h>/*printf,scanf,NULL*/
#include<stdlib.h>/*srand,rand*/
#include<time.h>/*time*/
#include<conio.h>/*getch*/
#include<windows.h>/*system,Sleep*/


int start(void);//��ʼ����
void initialise(int num[4][4], int *mark, char *ch);//��ʼ��
void newnum(int num[4][4]);//����������
int control(int num[4][4]);//���ƹ���
int upward(int num[4][4]);//�����ƶ�����
int downward(int num[4][4]);//�����ƶ�����
int aleft(int num[4][4]);//�����ƶ�����
int dextrad(int num[4][4]);//�����ƶ�����
void grade(int num[4][4]);//����ȼ�
void output(int num[4][4]);//�������
int status(int num[4][4]);//�ж���Ϸ�Ƿ����
int win(int num[4][4]);//ʤ����ؽ���
void color(int num);//�ı�������ɫ


static int score = 0, rank = 0;//��¼�����͵ȼ�

int main(void)
{
	int num[4][4];
	int flag = 1, *mark = &flag, pass = 2048;//���ڱ����Ϸ״̬,flag���ж��Ƿ���ȷ����,*mark�ǳ�ʼ�������иı�flag��ֵ,pass���޾�ģʽ���жϱ�׼
	char choose, *ch = &choose;//�ж��Ƿ��˳�,*ch�ǳ�ʼ��ʱ�ı�choose��ֵ
	srand((unsigned)time(NULL));//Ϊ�����������
	system("color F0");
	while (1)
	{
		pass = 2048;//��ʼ��
		initialise(num, mark, ch);
		switch (start())//���ÿ�ʼ���������ʾ��Ϣ������һ��ֵ��switchʹ��
		{
		case 1:
			while (flag != 2)//���޷��ƶ����������Ұ���ESC(��ʱflag=2)ʱֹͣ��Ϸ
			{
				if (rank == 2048)//�����ﵽʤ����׼
				{
					output(num);//���ʤ��ʱ�ĳɼ�
					printf("\r  ��ϲ����������ʤ��!��1���¿�ʼ������Ϸ,��������ص����˵�,��Esc�˳���Ϸ");
					if (win(num) == 1)//ʤ��֮����win�����ж��û���ѡ�񲢾����Ƿ��˳�
						initialise(num, mark, ch);
					else
						break;
				}
				if (flag == 1)//�ж��Ƿ���������
				{
					newnum(num);
					output(num);
				}
				flag = control(num);//���ÿ��ƺ���������flag�Ա���һ��ѭ��ʱ�ж��Ƿ���������
				if (status(num) == 0)//����status�����ж���Ϸ�Ƿ����(game over)
				{
					printf("\r\t   ����,������!�����밴1,�ص����˵��밴�����.");
					if ((choose = getch()) == 49)
						initialise(num, mark, ch);
					else
						break;
				}
			}
			break;
		case 2:
			while (flag != 2)//�޾�ģʽ��ʵ�Ǿ���ģʽ���޾���
			{
				if (rank == pass&&rank != 0)//�����ﵽʤ����׼
				{
					pass *= 2;//��һ���ȼ�
					flag = 0;//��֤newnum�����������ҵ�ѡ���з�Ӧ
					output(num);//�����ʱ�ɼ�
					printf("\r  ��ϲ��ϳ�������%d!��1�ص����˵�,�����������,��Esc�˳���Ϸ", rank);
					if (win(num) == 1)//���׺�֮����win�����ж��û���ѡ�񲢾����Ƿ��˳�
						break;
				}
				if (flag == 1)//�ж��Ƿ���������
				{
					newnum(num);
					output(num);
				}
				flag = control(num);//���ÿ��ƺ���������flag�Ա���һ��ѭ��ʱ�ж��Ƿ���������
				if (status(num) == 0)//����status�����ж���Ϸ�Ƿ����(game over)
				{
					printf("\r\t   ����,������!�����밴1,�ص����˵��밴�����.");
					if ((choose = getch()) == 49)
					{
						pass = 2048;
						initialise(num, mark, ch);
					}
					else
						break;
				}
			}
			break;
		case 3:
			printf("\t\t\tȷ��Ҫ�˳���?(Y/N)");
			choose = getch();
			if (choose == 'y' || choose == 'Y')
				exit(0);
			else
				break;
		default:
			printf("�������!û�����ѡ��!");
		}
	}
	return 0;
}


//��ʼ����
int start(void)
{
	int choose;
	system("cls");
	printf("\n\t\t\t��ӭ����2048��Ϸ!");
	printf("\n\n\t\t\t   1.����ģʽ");
	printf("\n\t\t\t   2.�޾�ģʽ");
	printf("\n\t\t\t   3.�˳�");
	printf("\n\n\n\n\t\t\t   ��ѡ��:");
	scanf("%d", &choose);
	return choose;
}


//��ʼ��
void initialise(int num[4][4], int *mark, char *ch)
{
	int i, j;
	for (i = 0; i<4; i++)
	for (j = 0; j<4; j++)
		num[i][j] = 0;
	score = 0, rank = 0;
	*mark = 1, *ch = '\0';
}


//��������
void newnum(int num[4][4])
{
	int i = 0, j = 0, k = 2, flag = 0;
	for (i = 0; i<4; i++)//��ÿһ�������м��,����п�λ���ʾӦ��������
	for (j = 0; j<4; j++)
	if (num[i][j] == 0)
	{
		flag = 1;//��1��ʾ�п�λ
		i = 3;//��i��Ϊ3���break�˳�ѭ��
		break;
	}
	while (flag)//���flagΪ0���ʾ��������,����������
	{
		//�����漴�����������λ��������
		i = rand() % 4;
		j = rand() % 4;
		if (num[i][j] != 0)//�ж�λ���Ƿ�Ϊ��λ,���ǿ�λ�Ļ����¿�ʼ
			continue;
		if (rand() % 2 == 1)//�������2��4
			num[i][j] = 2;
		else
			num[i][j] = 4;
		k--;
		//ͨ��rank��k���ж��Ƿ��Ǹտ�ʼ��Ϸ,���������������,��������һ������
		if (rank != 0 || k == 0)
			break;
	}
}


//���ƹ���
int control(int num[4][4])
{
	int key, flag = 1;//��flag�ж��Ƿ��ƶ��˷���
	if ((key = getch()) == 224)//�ж�����Ƿ��·����,���û�в�����û����ȷ��������else����з���0
	{
		switch (key = getch())//�ж���Ұ��µķ�������ĸ�,��ִ����Ӧ����
		{
			//4��case��䶼��flag�ж��Ƿ���ȷ����,û����flagΪ0,�����������в�ִ�в���
		case 72:
			flag = upward(num);
			break;
		case 80:
			flag = downward(num);
			break;
		case 75:
			flag = aleft(num);
			break;
		case 77:
			flag = dextrad(num);
			break;
		default:
			flag = 0;
			break;
		}
	}
	else
	{
		if (key == 27)//�����Ұ��µ���Esc��,��ѯ���Ƿ��˳�
		{
			printf("\n\t\t\tȷ���˳���?(Y/N)");
			if ((key = getch()) == 89 || key == 121)
				flag = 2;
			else
			{
				flag = 0;
				output(num);//������ȡ�����˳�,�򽫴˴�ѡ�������µļ���Ϊ��Ч����,��ˢ�����ҳ��
			}
		}
		else
			flag = 0;//����Ȳ��Ƿ�����ֲ���Esc��,��˵��û����ȷ����,����0ֵ
	}
	grade(num);//������ɺ��ȡ��ǰ�ȼ�
	return flag;
}


//�����ƶ�����
int upward(int num[4][4])
{
	int i = 0, j = 0, k = 0, flag = 0;//i,j,k�����±��,flag�жϱ���,�ж��Ƿ�ı��˷���λ��
	for (j = 0; j<4; j++)//j������,i������,����Ϊ��׼,��ͬһ��ÿ��������,Ѱ�ҷ�����������
	{
		for (i = 0; i<3; i++)//Ѱ����ȵ���,������i�к�i+1�жԱ�,���i<3
		{
			for (k = i + 1; num[i][j] != 0 && k<4; k++)//������num[i][j]��Ϊ0�������Ѱ����ͬ����
			{
				if (num[k][j] == 0)//����0�����¿�ʼѭ��
					continue;
				if (num[k][j] != num[i][j])//�������һλ��Ϊ0������num[i][j]����ͬ���˳�ѭ���ж���һ��
					break;
				if (num[i][j] == num[k][j])//�ж��Ƿ��ҵ���ͬ����
				{
					num[i][j] *= 2;//��ͬ������ӿ����ó���2����
					num[k][j] = 0;//���ϲ�������ÿ�,�Դﵽ�ϲ�Ч��
					score += num[i][j];//�������
					flag = 1;//��flag��Ϊ1��ʾ����λ�÷����ı�
					break;//�˳�ѭ��Ѱ����һλ
				}
			}
		}
		for (i = 0; i<3; i++)//Ѱ�ҿ�λ,����ÿһ�ξ������ǰ��Ŀ�λ,��˿��Բ��ؼ�����һ��
		{
			if (num[i][j] == 0)//���ֿ�λ��ִ����һ��
			{
				for (k = i + 1; k<4; k++)//�ӷ��ֵĿ�λ��ʼ���������,�ҵ����ǿ�λ��
				{
					if (num[k][j] != 0)//�ж��Ƿ�Ϊ��λ
					{
						num[i][j] = num[k][j];//���ҵ��ķǿ�λ�����ǰ��Ŀ�λ
						num[k][j] = 0;//���ƶ���������ÿ�,�Դﵽ�ƶ���Ч��
						flag = 1;//��flag��Ϊ1��ʾ����λ�÷����ı�
						break;//�˳�ѭ��Ѱ����һλ
					}
				}
			}
		}
	}
	return flag;
}


int downward(int num[4][4])//�����ƶ�����
{
	int i = 0, j = 0, k = 0, flag = 0;//i,j,k�����±��,flag�жϱ���,�ж��Ƿ�ı��˷���λ��
	for (j = 0; j<4; j++)//j������,i������,����Ϊ��׼,��ͬһ��ÿ��������,Ѱ�ҷ�����������
	{
		for (i = 3; i>0; i--)//Ѱ����ȵ���,������i�к�i-1�жԱ�,���i>0
		{
			for (k = i - 1; num[i][j] != 0 && k >= 0; k--)//������num[i][j]��Ϊ0�������Ѱ����ͬ����
			{
				if (num[k][j] == 0)//����0�����¿�ʼѭ��
					continue;
				if (num[k][j] != num[i][j])//�������һλ��Ϊ0������num[i][j]����ͬ���˳�ѭ���ж���һ��
					break;
				if (num[i][j] == num[k][j])//�ж��Ƿ��ҵ���ͬ����
				{
					num[i][j] *= 2;//��ͬ������ӿ����ó���2����
					num[k][j] = 0;//���ϲ�������ÿ�,�Դﵽ�ϲ�Ч��
					score += num[i][j];//�������
					flag = 1;//��flag��Ϊ1��ʾ����λ�÷����ı�
					break;//�˳�ѭ��Ѱ����һλ
				}
			}
		}
		for (i = 3; i>0; i--)//Ѱ�ҿ�λ,����ÿһ�ξ����������Ŀ�λ,��˿��Բ��ؼ���һ��
		{
			if (num[i][j] == 0)//���ֿ�λ��ִ����һ��
			{
				for (k = i - 1; k >= 0; k--)//�ӷ��ֵĿ�λ��ʼ���������,�ҵ����ǿ�λ��
				{
					if (num[k][j] != 0)//�ж��Ƿ�Ϊ��λ
					{
						num[i][j] = num[k][j];//���ҵ��ķǿ�λ�����ǰ��Ŀ�λ
						num[k][j] = 0;//���ƶ���������ÿ�,�Դﵽ�ƶ���Ч��
						flag = 1;//��flag��Ϊ1��ʾ����λ�÷����ı�
						break;//�˳�ѭ��Ѱ����һλ
					}
				}
			}
		}
	}
	return flag;
}


int aleft(int num[4][4])//�����ƶ�����
{
	int i = 0, j = 0, k = 0, flag = 0;//i,j,k�����±��,flag�жϱ���,�ж��Ƿ�ı��˷���λ��
	for (i = 0; i<4; i++)//i������,j������,����Ϊ��׼,��ͬһ��ÿ��������,Ѱ�ҷ�����������
	{
		for (j = 0; j<3; j++)//Ѱ����ȵ���,������j�к�j+1�жԱ�,���i<3
		{
			for (k = j + 1; num[i][j] != 0 && k<4; k++)//������num[i][j]��Ϊ0�������Ѱ����ͬ����
			{
				if (num[i][k] == 0)//����0�����¿�ʼѭ��
					continue;
				if (num[i][k] != num[i][j])//�������һλ��Ϊ0������num[i][j]����ͬ���˳�ѭ���ж���һ��
					break;
				if (num[i][j] == num[i][k])//�ж��Ƿ��ҵ���ͬ����
				{
					num[i][j] *= 2;//��ͬ������ӿ����ó���2����
					num[i][k] = 0;//���ϲ�������ÿ�,�Դﵽ�ϲ�Ч��
					score += num[i][j];//�������
					flag = 1;//��flag��Ϊ1��ʾ����λ�÷����ı�
					break;//�˳�ѭ��Ѱ����һλ
				}
			}
		}
		for (j = 0; j<3; j++)//Ѱ�ҿ�λ,����ÿһ�ξ������ǰ��Ŀ�λ,��˿��Բ��ؼ�����һ��
		{
			if (num[i][j] == 0)//���ֿ�λ��ִ����һ��
			{
				for (k = j + 1; k<4; k++)//�ӷ��ֵĿ�λ��ʼ���������,�ҵ����ǿ�λ��
				{
					if (num[i][k] != 0)//�ж��Ƿ�Ϊ��λ
					{
						num[i][j] = num[i][k];//���ҵ��ķǿ�λ�����ǰ��Ŀ�λ
						num[i][k] = 0;//���ƶ���������ÿ�,�Դﵽ�ƶ���Ч��
						flag = 1;//��flag��Ϊ1��ʾ����λ�÷����ı�
						break;//�˳�ѭ��Ѱ����һλ
					}
				}
			}
		}
	}
	return flag;
}


int dextrad(int num[4][4])//�����ƶ�����
{
	int i = 0, j = 0, k = 0, flag = 0;//i,j,k�����±��,flag�жϱ���,�ж��Ƿ�ı��˷���λ��
	for (i = 0; i<4; i++)//j������,i������,����Ϊ��׼,��ͬһ��ÿ��������,Ѱ�ҷ�����������
	{
		for (j = 3; j>0; j--)//Ѱ����ȵ���,������j�к�j-1�жԱ�,���i>0
		{
			for (k = j - 1; num[i][j] != 0 && k >= 0; k--)//������num[i][j]��Ϊ0�������Ѱ����ͬ����
			{
				if (num[i][k] == 0)//����0�����¿�ʼѭ��
					continue;
				if (num[i][k] != num[i][j])//�������һλ��Ϊ0������num[i][j]����ͬ���˳�ѭ���ж���һ��
					break;
				if (num[i][j] == num[i][k])//�ж��Ƿ��ҵ���ͬ����
				{
					num[i][j] *= 2;//��ͬ������ӿ����ó���2����
					num[i][k] = 0;//���ϲ�������ÿ�,�Դﵽ�ϲ�Ч��
					score += num[i][j];//�������
					flag = 1;//��flag��Ϊ1��ʾ����λ�÷����ı�
					break;//�˳�ѭ��Ѱ����һλ
				}
			}
		}
		for (j = 3; j>0; j--)//Ѱ�ҿ�λ,����ÿһ�ξ������ǰ��Ŀ�λ,��˿��Բ��ؼ���һ��
		{
			if (num[i][j] == 0)//���ֿ�λ��ִ����һ��
			{
				for (k = j - 1; k >= 0; k--)//�ӷ��ֵĿ�λ��ʼ���������,�ҵ����ǿ�λ��
				{
					if (num[i][k] != 0)//�ж��Ƿ�Ϊ��λ
					{
						num[i][j] = num[i][k];//���ҵ��ķǿ�λ�����ǰ��Ŀ�λ
						num[i][k] = 0;//���ƶ���������ÿ�,�Դﵽ�ƶ���Ч��
						flag = 1;//��flag��Ϊ1��ʾ����λ�÷����ı�
						break;//�˳�ѭ��Ѱ����һλ
					}
				}
			}
		}
	}
	return flag;
}


//����ȼ�
void grade(int num[4][4])
{
	int i, j, flag = 1;
	for (i = 0; i<4; i++)
	for (j = 0; j<4; j++)
	{
		if (num[i][j]>rank)
			rank = num[i][j];
	}
}


//�������
void output(int num[4][4])
{
	int i = 0, j = 0;
	system("cls");
	printf("\n\t\t ��Ŀǰ�ķ���Ϊ:%d    ���ĵȼ�Ϊ:%d", score, rank);
	printf("\n\t\t�X�T�T�T�j�T�T�T�j�T�T�T�j�T�T�T�[");
	printf("\n\t\t�U      �U      �U      �U      �U");
	for (i = 0; i<4; i++)
	{
		printf("\n\t\t");
		for (j = 0; j<4; j++)
		{
			if (num[i][j] == 0)
				printf("�U      ");
			else
			{
				printf("�U  ");
				color(num[i][j]);
				printf("%-4d", num[i][j]);
				SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 0xf0);
			}


		}
		printf("�U");
		if (i == 3)
			break;
		printf("\n\t\t�U      �U      �U      �U      �U");
		printf("\n\t\t�d�T�T�T�p�T�T�T�p�T�T�T�p�T�T�T�g");
		printf("\n\t\t�U      �U      �U      �U      �U");
	}
	printf("\n\t\t�U      �U      �U      �U      �U");
	printf("\n\t\t�^�T�T�T�m�T�T�T�m�T�T�T�m�T�T�T�a");
	printf("\n\t\t  �����������Ʒ��黬��,��Esc�˳�");
}


//�ж���Ϸ�Ƿ����
int status(int num[4][4])
{
	int i, j;
	for (i = 0; i<4; i++)//��ÿһ�������м��,����п�λ���ʾ��Ϸδ����,����1
	{
		for (j = 0; j<4; j++)

		{
			if (num[i][j] == 0)
				return 1;
		}
	}
	for (i = 0; i<4; i++)//�������Ƿ���������������ͬ��,�����ʾ��Ϸδ����,����1
	{
		for (j = 0; j<3; j++)
		{
			if (num[i][j] == num[i][j + 1])
				return 1;
		}
	}
	for (i = 0; i<3; i++)//�������Ƿ���������������ͬ��,�����ʾ��Ϸδ����,����1
	{
		for (j = 0; j<4; j++)
		{
			if (num[i][j] == num[i + 1][j])
				return 1;
		}
	}
	return 0;//�����û���ҵ���λ��û�����ڵ���������ͬ,����Ϸ����,����0
}


//ʤ����ؽ���
int win(int num[4][4])
{
	int over = 0;//��over����һ��ֵ�ж�����Ƿ�ѡ�������Ϸ
	char choose = '\0', c, color[9] = "color ";//color����ͱ���c����ʤ�������system("color");����
	for (; kbhit() == 0;)//������û�а���,��һֱ�����ɫ
	{
		while ((c = rand() % 58)<'1' || c>'9');
		color[6] = c;
		while ((c = rand() % 71)<'A' || c>'F');
		color[7] = c;
		system(color);
		Sleep(1000);
	}
	if ((choose = getch()) == 224)//�����Ұ��·����,�����������������
		choose = getch();
	else
	if (choose == 27)//�ж���ҵ�ѡ��
		exit(0);
	else
	if (choose == 49)//ѡ�������Ϸ
		over = 1;
	system("color F0");
	return over;
}
void color(int num)
{
	switch (num)
	{
	case 2:
	case 4:
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 0xf8);
		break;
	case 8:
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 0xfb);
		break;
	case 16:
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 0xfa);
		break;
	case 32:
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 0xfe); 
		break;
	case 64:
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 0xf6); 
		break;
	case 128:
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 0xfd);
		break;
	case 256:
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 0xf5);
		break;
	case 512:
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 0xfc);
		break;
	case 1024:
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 0xf4);
		break;
	case 2048:
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 0xf0);
		break;
	case 4096:
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 0xf9);
		break;
	case 8192:
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 0xf3);
		break;
	case 16384:
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 0xf1);
		break;
	default :
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 0xf0);
		break;
	}
}