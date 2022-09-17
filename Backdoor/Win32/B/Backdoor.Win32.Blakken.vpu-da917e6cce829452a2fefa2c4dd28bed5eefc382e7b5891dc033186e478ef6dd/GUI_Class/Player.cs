#define DEBUG
using System;
using System.Diagnostics;
using System.Drawing;

namespace GUI_Class;

public class Player
{
	public const int INITIAL_FUEL_AMOUNT = 60;

	private string name;

	private int position;

	private Square location;

	private int fuelLeft;

	private bool hasPower;

	private bool atFinish = false;

	private Brush playerTokenColour;

	private Image playerTokenImage;

	public string Name
	{
		get
		{
			return name;
		}
		set
		{
			name = value;
		}
	}

	public int Position
	{
		get
		{
			return position;
		}
		set
		{
			position = value;
		}
	}

	public Square Location
	{
		get
		{
			return location;
		}
		set
		{
			location = value;
		}
	}

	public int RocketFuel
	{
		get
		{
			return fuelLeft;
		}
		set
		{
			fuelLeft = value;
		}
	}

	public bool HasPower
	{
		get
		{
			return hasPower;
		}
		set
		{
			hasPower = value;
		}
	}

	public bool AtFinish
	{
		get
		{
			return atFinish;
		}
		set
		{
			atFinish = value;
		}
	}

	public Brush PlayerTokenColour
	{
		get
		{
			return playerTokenColour;
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			playerTokenColour = value;
			playerTokenImage = (Image)new Bitmap(1, 1);
			Graphics val = Graphics.FromImage(PlayerTokenImage);
			try
			{
				val.FillRectangle(playerTokenColour, 0, 0, 1, 1);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
	}

	public Image PlayerTokenImage => playerTokenImage;

	public Player()
	{
		throw new ArgumentException("Parameterless constructor invalid.");
	}

	public Player(string name)
	{
		Name = name;
		fuelLeft = 60;
	}

	public void Play(Die d1, Die d2)
	{
		d1.Roll();
		d2.Roll();
		int num = d1.FaceValue + d2.FaceValue;
		Position += num;
		AtFinish = ReachedFinalSquare();
	}

	public void ConsumeFuel(int amount)
	{
		Debug.Assert(amount > 0, "amount > 0");
		if (fuelLeft > amount)
		{
			fuelLeft -= amount;
			return;
		}
		fuelLeft = 0;
		HasPower = false;
	}

	private bool ReachedFinalSquare()
	{
		if (Position >= 55)
		{
			Position = 55;
			return true;
		}
		return false;
	}
}
