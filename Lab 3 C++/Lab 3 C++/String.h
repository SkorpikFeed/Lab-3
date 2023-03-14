#pragma once
#include <string>
#include <cctype>
using namespace std;
class String
{
private:
	string value;
public:
	String()
	{
		value = "";
	}
	String(string value)
	{
		this->value = value;
	}
	String(string& value)
	{
		this->value = value;
	}
	string getValue()
	{
		return value;
	}
	void setValue(string value)
	{
		this->value = value;
	}
	String operator+(String s)
	{
		String temp;
		temp.value = this->value + s.value;
		return temp;
	}
	bool operator!=(String s)
	{
		return this->value != s.value;
	}
	String operator++(int)
	{
		String temp;
		temp.value = this->value + "5";
		return temp;
	}
	bool operator!()
	{
		bool result = false;
		for (char c : this->value) 
		{
			if (isupper(c)) 
			{
				result = true;
				break;
			}
		}
		return result;
	}
	String operator*(int A)
	{
		String temp;
		temp.value = this->value;
		for (int i = 0; i < A; i++)
		{
			temp.value += this->value[i];
		}
		return temp;
	}
	friend String operator*(int A,String B)
	{
		String temp = B;
		for (int i = 0; i < A; i++)
		{
			temp.value += B.value[i];
		}
		return temp;
	}
};

