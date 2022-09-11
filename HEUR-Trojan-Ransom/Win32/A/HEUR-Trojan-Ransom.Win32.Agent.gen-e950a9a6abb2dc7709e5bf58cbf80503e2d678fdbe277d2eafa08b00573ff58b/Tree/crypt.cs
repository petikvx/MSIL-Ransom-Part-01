using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Tree;

public class crypt
{
	public static string strFileToEncrypt;

	public static string strFileToDecrypt;

	public static string strOutputEncrypt;

	public static string strOutputDecrypt;

	public static FileStream fsInput;

	public static FileStream fsOutput;

	public static byte[] CreateKey(string strPassword)
	{
		byte[] bytes = Encoding.ASCII.GetBytes("salt");
		PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(strPassword, bytes);
		return passwordDeriveBytes.GetBytes(32);
	}

	public static byte[] CreateIV(string strPassword)
	{
		byte[] bytes = Encoding.ASCII.GetBytes("salt");
		PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(strPassword, bytes);
		return passwordDeriveBytes.GetBytes(16);
	}

	public static void Encrypt(string strInputFile, string strOutputFile, byte[] bytKey, byte[] bytIV)
	{
		try
		{
			fsInput = new FileStream(strInputFile, FileMode.Open, FileAccess.Read);
			fsOutput = new FileStream(strOutputFile, FileMode.OpenOrCreate, FileAccess.Write);
			fsOutput.SetLength(0L);
			byte[] buffer = new byte[4097];
			long num = 0L;
			long length = fsInput.Length;
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			CryptoStream cryptoStream = new CryptoStream(fsOutput, rijndaelManaged.CreateEncryptor(bytKey, bytIV), CryptoStreamMode.Write);
			int num2;
			for (; num < length; num = checked(num + num2))
			{
				num2 = fsInput.Read(buffer, 0, 4096);
				cryptoStream.Write(buffer, 0, num2);
			}
			cryptoStream.Close();
			fsInput.Close();
			fsOutput.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void decrypt(string strInputFile, string strOutputFile, byte[] bytKey, byte[] bytIV)
	{
		try
		{
			fsInput = new FileStream(strInputFile, FileMode.Open, FileAccess.Read);
			fsOutput = new FileStream(strOutputFile, FileMode.OpenOrCreate, FileAccess.Write);
			fsOutput.SetLength(0L);
			byte[] buffer = new byte[4097];
			long num = 0L;
			long length = fsInput.Length;
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			CryptoStream cryptoStream = new CryptoStream(fsOutput, rijndaelManaged.CreateDecryptor(bytKey, bytIV), CryptoStreamMode.Write);
			int num2;
			for (; num < length; num = checked(num + num2))
			{
				num2 = fsInput.Read(buffer, 0, 4096);
				cryptoStream.Write(buffer, 0, num2);
			}
			cryptoStream.Close();
			fsInput.Close();
			fsOutput.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
