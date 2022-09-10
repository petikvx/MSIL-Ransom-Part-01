using System;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace ns0;

internal static class Class0
{
	private static string string_0 = "a68ca6a1";

	private static string string_1 = "9b4a6429";

	[STAThread]
	private static void _007B()
	{
		Assembly assembly = null;
		MethodInfo methodInfo = null;
		ParameterInfo[] array = null;
		object[] parameters = null;
		object[] customAttributes = Assembly.GetEntryAssembly()!.GetCustomAttributes(typeof(GuidAttribute), inherit: false);
		string_1 = ((GuidAttribute)customAttributes[0]).Value;
		assembly = smethod_0(string_0);
		if ((object)assembly != null)
		{
			methodInfo = assembly.EntryPoint;
			array = methodInfo.GetParameters();
			if (array != null && array.Length > 0)
			{
				parameters = new object[1] { Environment.GetCommandLineArgs() };
			}
			methodInfo.Invoke(null, parameters);
		}
	}

	private static Assembly smethod_0(string string_2)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string[] manifestResourceNames = executingAssembly.GetManifestResourceNames();
		string baseName = manifestResourceNames[0].Substring(0, manifestResourceNames[0].LastIndexOf("."));
		ResourceManager resourceManager = new ResourceManager(baseName, executingAssembly);
		byte[] array = smethod_1((byte[])resourceManager.GetObject(string_2));
		if (array == null)
		{
			return null;
		}
		return Assembly.Load(array);
	}

	private static byte[] smethod_1(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			return null;
		}
		MemoryStream memoryStream = null;
		MemoryStream memoryStream2 = null;
		DeflateStream deflateStream = null;
		MemoryStream memoryStream3 = null;
		int num = 0;
		byte[] array = null;
		byte[] result = null;
		try
		{
			memoryStream = new MemoryStream(byte_0);
			memoryStream.Read(byte_0, 0, byte_0.Length);
			memoryStream.Seek(0L, SeekOrigin.Begin);
			memoryStream2 = smethod_2(memoryStream);
			memoryStream.Close();
			memoryStream = null;
			if (memoryStream2 != null)
			{
				deflateStream = new DeflateStream(memoryStream2, CompressionMode.Decompress);
				memoryStream3 = new MemoryStream();
				array = new byte[1024];
				while ((num = deflateStream.Read(array, 0, array.Length)) > 0)
				{
					memoryStream3.Write(array, 0, num);
				}
				deflateStream.Close();
				deflateStream = null;
				memoryStream2.Close();
				memoryStream2 = null;
				result = memoryStream3.ToArray();
			}
			return result;
		}
		finally
		{
			deflateStream?.Close();
			memoryStream?.Close();
			memoryStream3?.Close();
		}
	}

	private static MemoryStream smethod_2(MemoryStream memoryStream_0)
	{
		CryptoStream cryptoStream = null;
		MemoryStream memoryStream = null;
		try
		{
			DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
			byte[] bytes = Encoding.UTF8.GetBytes(string_1);
			dESCryptoServiceProvider.Key = smethod_3(bytes, dESCryptoServiceProvider.Key.Length);
			dESCryptoServiceProvider.IV = smethod_3(bytes, dESCryptoServiceProvider.IV.Length);
			ICryptoTransform transform = dESCryptoServiceProvider.CreateDecryptor();
			cryptoStream = new CryptoStream(memoryStream_0, transform, CryptoStreamMode.Read);
			memoryStream = new MemoryStream();
			int num = 0;
			byte[] array = new byte[1024];
			while ((num = cryptoStream.Read(array, 0, array.Length)) > 0)
			{
				memoryStream.Write(array, 0, num);
			}
			memoryStream.Seek(0L, SeekOrigin.Begin);
			return memoryStream;
		}
		finally
		{
			cryptoStream?.Close();
		}
	}

	private static byte[] smethod_3(byte[] byte_0, int int_0)
	{
		byte[] array = new byte[int_0];
		if (byte_0.Length <= int_0)
		{
			for (int i = 0; i < byte_0.Length; i++)
			{
				array[i] = byte_0[i];
			}
		}
		else
		{
			int num = 0;
			for (int j = 0; j < byte_0.Length; j++)
			{
				array[num++] ^= byte_0[j];
				if (num >= array.Length)
				{
					num = 0;
				}
			}
		}
		return array;
	}
}
