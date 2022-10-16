using System;
using Microsoft.VisualBasic.CompilerServices;

namespace DiceRoller;

public class Die
{
	private string m_name;

	private int m_max;

	private int m_min;

	private int m_result;

	private static Random rand = new Random();

	public string Name
	{
		get
		{
			return m_name;
		}
		set
		{
			m_name = value;
		}
	}

	public int Max
	{
		get
		{
			return m_max;
		}
		set
		{
			if (value > 0)
			{
				m_max = value;
			}
		}
	}

	public int Min
	{
		get
		{
			return m_min;
		}
		set
		{
			if (value > 0)
			{
				m_min = value;
			}
		}
	}

	public int Result => m_result;

	public Die(string name, int min, int max)
	{
		m_name = name;
		m_min = min;
		m_max = max;
	}

	public override string ToString()
	{
		return "d" + Conversions.ToString(m_max);
	}

	public int Roll()
	{
		m_result = rand.Next(m_min, m_max);
		return m_result;
	}
}
