using System.Collections.Generic;

namespace DiceRoller;

public abstract class DiceRoll
{
	private string m_name;

	private List<Die> m_dice;

	private List<Modification> m_modifiers;

	private int m_result;

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

	public List<Die> Dice
	{
		get
		{
			return m_dice;
		}
		set
		{
			m_dice = value;
		}
	}

	public List<Modification> Modifiers
	{
		get
		{
			return m_modifiers;
		}
		set
		{
			m_modifiers = value;
		}
	}

	public DiceRoll()
	{
		m_dice = new List<Die>();
		m_modifiers = new List<Modification>();
		m_name = "";
		m_dice = null;
		m_modifiers = null;
		m_result = 0;
	}

	public DiceRoll(string name)
	{
		m_dice = new List<Die>();
		m_modifiers = new List<Modification>();
		m_name = name;
		m_dice = null;
		m_modifiers = null;
		m_result = 0;
	}

	public int Roll()
	{
		int num = 0;
		if (m_dice.Count > 0)
		{
			foreach (Die die in m_dice)
			{
				num = checked(num + die.Roll());
			}
		}
		m_result = num;
		return num;
	}
}
