using System;

namespace TreehouseDefense;

internal class Tower
{
	private readonly MapLocation _location;

	protected virtual int Range { get; } = 1;


	protected virtual int Power { get; } = 1;


	protected virtual double Accuracy { get; } = 0.75;


	public Tower(MapLocation location)
	{
		_location = location;
	}

	private bool IsSuccessfulShot()
	{
		return Random.NextDouble() < Accuracy;
	}

	public void FireOnInvaders(IInvader[] invaders)
	{
		int num = 0;
		IInvader invader;
		while (true)
		{
			if (num < invaders.Length)
			{
				invader = invaders[num];
				if (invader.IsActive && _location.InRangeOf(invader.Location, Range))
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		if (IsSuccessfulShot())
		{
			invader.DecreaseHealth(Power);
			if (invader.IsNeutralized)
			{
				Console.WriteLine("Neutralized an invader at " + invader.Location?.ToString() + "!");
			}
		}
		else
		{
			Console.WriteLine("Shot at and missed an invader");
		}
	}
}
