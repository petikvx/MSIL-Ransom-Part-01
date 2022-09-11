using System;
using System.IO;

public static class GClass4
{
	public static object object_0 = new object();

	public static void smethod_0(string string_0, string string_1)
	{
		try
		{
			lock (object_0)
			{
				File.AppendAllText(string_0, string.Format("{0}: {1}", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), string_1 + Environment.NewLine));
			}
		}
		catch
		{
		}
	}
}
