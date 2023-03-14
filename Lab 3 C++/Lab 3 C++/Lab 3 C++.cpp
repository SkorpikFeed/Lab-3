#include "String.h"
#include <iostream>
using namespace std;

int main()
{
	string New;
	String s1, s2, s3;
	{
	start1:
		cout << "Enter first string:" << endl;
		cin >> New;
		int i = 0;
		bool result = true;
		while (New[i] != '\0')
		{
			if (New[i] < '0' || New[i] > '9')
				result = false;
			i++;
		}
		system("cls");
		if (result == false)
		{
			cout << "Try again" << endl;
			goto start1;
		}
		s1.setValue(New);
	}
	New = "";
	{
	start2:
		cout << "Enter second string:" << endl;
		cin >> New;
		int i = 0;
		bool result = true;
		while (New[i] != '\0')
		{
			if (New[i] < '0' || New[i] > '9')
				result = false;
			i++;
		}
		system("cls");
		if (result == false)
		{
			cout << "Try again" << endl;
			goto start2;
		}
		s2.setValue(New);
	}
	cout <<"Your first string: " << s1.getValue() << endl;
	cout <<"Your second string: " << s2.getValue() << endl;
	s3 = s1 + s2;
	cout <<"String concatenation: " << s3.getValue() << endl;
	s3 = s1++;
	cout <<"Adding character 5: " << s3.getValue() << endl;
	s3 = s1 * 3;
	cout <<"String increasing(String*int): " << s3.getValue() << endl;
	s3 = 3 * s1;
	cout << "String increasing(int*String): " << s3.getValue() << endl;
	if (s1 != s2)
		cout << "The strings are different" << endl;
	else
		cout << "The strings are same" << endl;
	if (!s1)
		cout << "First string has no uppercase character" << endl;
	else
		cout << "First string has uppercase character" << endl;
}