using System;
using System.IO;

namespace ns0;

internal class Class3
{
	public static bool smethod_0(string string_0)
	{
		try
		{
			using (FileStream fileStream = File.Open(string_0, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
			{
				fileStream.Close();
			}
			return false;
		}
		catch (Exception)
		{
			return true;
		}
	}
}
