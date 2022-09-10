using System;

namespace homework;

public class student
{
	public string m_Name;

	private char m_Sexy;

	public int m_Age;

	public student(string name)
	{
		m_Name = name;
	}

	public student(string name, char sexy, int age)
	{
		m_Name = name;
		m_Sexy = sexy;
		m_Age = age;
	}

	public void SortAge()
	{
	}

	public void CalSexy()
	{
		if (m_Sexy == '男')
		{
			Console.WriteLine(m_Name + "他的年龄是：" + m_Age);
		}
		else
		{
			Console.WriteLine(m_Name + "她的年龄是：" + m_Age);
		}
	}
}
