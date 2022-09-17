using System;
using System.ComponentModel;
using System.Drawing;

namespace GUI_Class;

public static class SpaceRaceGame
{
	public const int MIN_PLAYERS = 2;

	public const int MAX_PLAYERS = 6;

	private static int numberOfPlayers = 2;

	public static string[] names = new string[6] { "One", "Two", "Three", "Four", "Five", "Six" };

	private static Brush[] playerTokenColours = (Brush[])(object)new Brush[6]
	{
		Brushes.get_Yellow(),
		Brushes.get_Red(),
		Brushes.get_Orange(),
		Brushes.get_White(),
		Brushes.get_Green(),
		Brushes.get_DarkViolet()
	};

	private static BindingList<Player> players = new BindingList<Player>();

	private static Die die1 = new Die();

	private static Die die2 = new Die();

	public static int NumberOfPlayers
	{
		get
		{
			return numberOfPlayers;
		}
		set
		{
			numberOfPlayers = value;
		}
	}

	public static BindingList<Player> Players => players;

	public static void SetUpPlayers()
	{
		for (int i = 0; i < NumberOfPlayers; i++)
		{
			players.Add(new Player(names[i]));
			players[i].Location = Board.Squares[0];
			players[i].PlayerTokenColour = playerTokenColours[i];
		}
	}

	public static void PlayOneRound()
	{
		for (int i = 0; i < players.Count; i++)
		{
			PlayOneTurn(i);
		}
	}

	public static void PlayOneTurn(int i)
	{
		if (players[i].RocketFuel != 0)
		{
			players[i].Play(die1, die2);
		}
		for (int j = 0; j < Board.Squares.Length; j++)
		{
			if (Board.Squares[j].Number == players[i].Position)
			{
				players[i].Location = Board.Squares[j];
				break;
			}
		}
		bool flag = false;
		for (int k = 0; k < Board.special.Length; k++)
		{
			if (players[i].Location.Number == Board.special[k])
			{
				players[i].Location.LandOn(players[i]);
				flag = true;
			}
		}
		if (!flag)
		{
			players[i].ConsumeFuel(2);
		}
		if (players[i].Position >= 55)
		{
			players[i].Position = 55;
		}
		if (players[i].RocketFuel == 0)
		{
			Console.WriteLine("{0} is removed as there is zero fuel left.", players[i].Name);
		}
	}

	public static bool AllPlayerFuel()
	{
		int[] array = new int[NumberOfPlayers];
		int num = 0;
		for (int i = 0; i < NumberOfPlayers; i++)
		{
			if (Players[i].RocketFuel == 0)
			{
				array[i] = 1;
			}
			else
			{
				array[i] = 0;
			}
			num += array[i];
		}
		if (num == NumberOfPlayers)
		{
			return true;
		}
		return false;
	}
}
