using System;

namespace com.daudus;

public class ConsoleSpiner
{
	private int pCounter;

	private long pPercent100;

	private decimal pStep;

	private byte pMode;

	public ConsoleSpiner(long percent100, byte mode)
		: this(percent100)
	{
		checked
		{
			pMode = (byte)Math.Abs(unchecked((int)mode % 2));
		}
	}

	public ConsoleSpiner(long percent100)
		: this()
	{
		pPercent100 = percent100;
		pStep = new decimal(100.0 / (double)percent100);
	}

	public ConsoleSpiner()
	{
		pMode = 0;
		pCounter = 0;
	}

	private void _turnNumber()
	{
		Console.Write("{0,3:##0}%", decimal.Multiply(new decimal(pCounter), pStep));
		Console.Write(new string('\b', 4));
	}

	private void _turnPseudoGraphic()
	{
		switch (pCounter % 4)
		{
		case 0:
			Console.Write("/");
			break;
		case 1:
			Console.Write("-");
			break;
		case 2:
			Console.Write("\\\\");
			break;
		case 3:
			Console.Write("-");
			break;
		}
		Console.Write(new string('\b', 1));
	}

	public void Turn()
	{
		checked
		{
			pCounter++;
			switch (pMode)
			{
			default:
				_turnNumber();
				break;
			case 1:
				_turnNumber();
				break;
			case 0:
				_turnPseudoGraphic();
				break;
			}
		}
	}

	public void Finish()
	{
		Console.WriteLine();
	}
}
