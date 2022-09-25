using System;
using System.IO;

namespace Stealer;

internal class Handler
{
	public static void error(string e)
	{
		File.AppendAllText(Path.GetTempPath() + "Error_Ades.txt", $"[{DateTime.Now}] - {e}\n");
	}
}
