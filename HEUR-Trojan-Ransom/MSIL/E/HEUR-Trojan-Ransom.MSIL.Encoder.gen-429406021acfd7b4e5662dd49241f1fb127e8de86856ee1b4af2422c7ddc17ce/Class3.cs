using System;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security.Cryptography;

internal class Class3
{
	private static Assembly assembly_0;

	private static string[] string_0;

	private static Assembly smethod_0(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if (string_0 == null)
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(Class4.smethod_0("鲮覰課趴풶\udcb8\ud8ba貼誾ꋀꇂ\uf7c4\uf3c6꿈流琉귎뗐\ue6d2\ue1d4\ue5d6\uebd8\ue9da\ueedc믞훠퇢蛤퓦탨틪헬", 6));
			if (manifestResourceStream != null)
			{
				DeflateStream deflateStream = new DeflateStream(new CryptoStream(manifestResourceStream, new DESCryptoServiceProvider().CreateDecryptor(BitConverter.GetBytes(13678491277113174794uL), BitConverter.GetBytes(17525861682881933482uL)), CryptoStreamMode.Read), CompressionMode.Decompress);
				MemoryStream memoryStream = new MemoryStream();
				deflateStream.CopyTo(memoryStream);
				string_0 = (assembly_0 = Assembly.Load(memoryStream.ToArray())).GetManifestResourceNames();
			}
		}
		if (string_0 != null && (object)Assembly.GetExecutingAssembly() == resolveEventArgs_0.RequestingAssembly)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				if (string_0[i] == resolveEventArgs_0.Name)
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
