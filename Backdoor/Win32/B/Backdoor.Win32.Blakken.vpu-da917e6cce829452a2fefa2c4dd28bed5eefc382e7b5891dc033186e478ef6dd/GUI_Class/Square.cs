using System;

namespace GUI_Class;

public class Square
{
	private int number;

	private string name;

	public int Number => number;

	public string Name => name;

	public virtual Square NextSquare()
	{
		return null;
	}

	public Square()
	{
		throw new ArgumentException("Parameterless constructor invalid.");
	}

	public Square(string name, int number)
	{
		this.name = name;
		this.number = number;
	}

	public virtual void LandOn(Player player)
	{
		player.ConsumeFuel(2);
	}

	public bool IsStart()
	{
		return Number == 0;
	}
}
