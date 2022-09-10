using System;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security.Cryptography;

internal class Class1
{
	private static Assembly assembly_0;

	private static string[] string_0;

	private static Assembly smethod_0(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if (string_0 == null)
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(Class2.smethod_0("삡鶣슥춧麩钫쮭膯讱肳펵\udeb7躹誻貽\uf0bf贈ꃃ\uf5c5ￇﻉ\uf5cbꯍ\ue4cf\ue0d1럓\uefd5\uecd7뿙\uecdb뫝蓟", 7));
			if (manifestResourceStream != null)
			{
				Stream stream = new DeflateStream(new CryptoStream(manifestResourceStream, new DESCryptoServiceProvider().CreateDecryptor(BitConverter.GetBytes(16954607111507422649uL), BitConverter.GetBytes(17156072796150509993uL)), CryptoStreamMode.Read), CompressionMode.Decompress);
				MemoryStream memoryStream = new MemoryStream();
				byte[] buffer = new byte[4096];
				int count;
				while ((count = stream.Read(buffer, 0, 4096)) != 0)
				{
					memoryStream.Write(buffer, 0, count);
				}
				string_0 = (assembly_0 = Assembly.Load(memoryStream.ToArray())).GetManifestResourceNames();
			}
		}
		if (string_0 != null)
		{
			for (int count = 0; count < string_0.Length; count++)
			{
				if (string_0[count] == resolveEventArgs_0.Name)
				{
					return assembly_0;
				}
			}
		}
		return null;
	}

	internal static void smethod_1()
	{
		AppDomain.CurrentDomain.ResourceResolve += smethod_0;
	}
}
