#define DEBUG
using System.Diagnostics;

namespace GUI_Class;

public static class Board
{
	public const int NUMBER_OF_SQUARES = 56;

	public const int START_SQUARE_NUMBER = 0;

	public const int FINISH_SQUARE_NUMBER = 55;

	private static Square[] squares = new Square[56];

	public static int[] special = new int[16]
	{
		2, 3, 5, 12, 16, 29, 40, 45, 10, 26,
		30, 35, 36, 49, 52, 53
	};

	private static int[,] wormHoles = new int[8, 3]
	{
		{ 2, 22, 10 },
		{ 3, 9, 3 },
		{ 5, 17, 6 },
		{ 12, 24, 6 },
		{ 16, 47, 15 },
		{ 29, 38, 4 },
		{ 40, 51, 5 },
		{ 45, 54, 4 }
	};

	private static int[,] blackHoles = new int[8, 3]
	{
		{ 10, 4, 6 },
		{ 26, 8, 18 },
		{ 30, 19, 11 },
		{ 35, 11, 24 },
		{ 36, 34, 2 },
		{ 49, 13, 36 },
		{ 52, 41, 11 },
		{ 53, 42, 11 }
	};

	public static Square[] Squares
	{
		get
		{
			Debug.Assert(squares != null, "squares != null", "The game board has not been instantiated");
			return squares;
		}
	}

	public static Square StartSquare => squares[0];

	public static void SetUpBoard()
	{
		squares[0] = new Square("Start", 0);
		for (int i = 1; i < 55; i++)
		{
			for (int j = 0; j < blackHoles.GetLength(0); j++)
			{
				int destNum;
				int amount;
				if (i != blackHoles[j, 0])
				{
					if (i != wormHoles[j, 0])
					{
						squares[i] = new Square(i.ToString(), i);
						continue;
					}
					FindDestSquare(wormHoles, i, out destNum, out amount);
					squares[i] = new WormholeSquare(i.ToString(), i, destNum, amount);
					break;
				}
				FindDestSquare(blackHoles, i, out destNum, out amount);
				squares[i] = new BlackholeSquare(i.ToString(), i, destNum, amount);
				break;
			}
		}
		squares[55] = new Square("Finish", 55);
	}

	private static void FindDestSquare(int[,] holes, int squareNum, out int destNum, out int amount)
	{
		destNum = 0;
		amount = 0;
		int num = 0;
		while (true)
		{
			if (num < holes.GetLength(0))
			{
				if (squareNum == holes[num, 0])
				{
					break;
				}
				amount = 2;
				num++;
				continue;
			}
			return;
		}
		destNum = holes[num, 1];
		amount = holes[num, 2];
	}
}
