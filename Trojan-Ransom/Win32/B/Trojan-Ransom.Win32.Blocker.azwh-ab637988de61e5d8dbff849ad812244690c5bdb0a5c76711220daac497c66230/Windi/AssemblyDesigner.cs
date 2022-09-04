using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;

namespace Windi;

internal class AssemblyDesigner
{
	private static readonly object logLength;

	private static readonly int currentNames;

	private static readonly int currentUri;

	private static readonly MemoryStream filterCollection;

	private static readonly MemoryStream messageInitialized;

	private static readonly byte categoryAvailable;

	static AssemblyDesigner()
	{
		filterCollection = null;
		messageInitialized = null;
		currentNames = int.MaxValue;
		currentUri = int.MinValue;
		filterCollection = new MemoryStream(0);
		messageInitialized = new MemoryStream(0);
		logLength = new object();
	}

	private static string ProcessBuilder(Assembly logLength)
	{
		string text = logLength.FullName;
		int num = text.IndexOf(',');
		if (num >= 0)
		{
			text = text.Substring(0, num);
		}
		return text;
	}

	private static byte[] SortActivator(Assembly logLength)
	{
		try
		{
			string fullName = logLength.FullName;
			int num = fullName.IndexOf("PublicKeyToken=");
			if (num < 0)
			{
				num = fullName.IndexOf("publickeytoken=");
			}
			if (num < 0)
			{
				return null;
			}
			num += 15;
			if (fullName[num] != 'n' && fullName[num] != 'N')
			{
				string s = fullName.Substring(num, 16);
				long value = long.Parse(s, NumberStyles.HexNumber);
				byte[] bytes = BitConverter.GetBytes(value);
				Array.Reverse((Array)bytes);
				return bytes;
			}
			return null;
		}
		catch
		{
		}
		return null;
	}

	internal static byte[] SearchContext(Stream logLength)
	{
		lock (AssemblyDesigner.logLength)
		{
			return DeployPciture(97L, logLength);
		}
	}

	internal static byte[] TestPackage(long logLength, Stream currentNames)
	{
		try
		{
			return SearchContext(currentNames);
		}
		catch (HostProtectionException)
		{
			return DeployPciture(97L, currentNames);
		}
	}

	internal static byte[] DeployPciture(long logLength, Stream currentNames)
	{
		Stream stream = currentNames;
		MemoryStream memoryStream = null;
		ushort num = (ushort)currentNames.ReadByte();
		num = (ushort)(~num);
		for (int i = 1; i < 3; i++)
		{
			currentNames.ReadByte();
		}
		if ((num & 2u) != 0)
		{
			DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
			byte[] array = new byte[8];
			currentNames.Read(array, 0, 8);
			dESCryptoServiceProvider.IV = array;
			byte[] array2 = new byte[8];
			currentNames.Read(array2, 0, 8);
			bool flag = true;
			byte[] array3 = array2;
			for (int j = 0; j < array3.Length; j++)
			{
				if (array3[j] != 0)
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				array2 = SortActivator(Assembly.GetExecutingAssembly());
			}
			dESCryptoServiceProvider.Key = array2;
			if (filterCollection == null)
			{
				if (AssemblyDesigner.currentNames == int.MaxValue)
				{
					filterCollection.Capacity = (int)currentNames.Length;
				}
				else
				{
					filterCollection.Capacity = AssemblyDesigner.currentNames;
				}
			}
			filterCollection.Position = 0L;
			ICryptoTransform cryptoTransform = dESCryptoServiceProvider.CreateDecryptor();
			int inputBlockSize = cryptoTransform.InputBlockSize;
			_ = cryptoTransform.OutputBlockSize;
			byte[] array4 = new byte[cryptoTransform.OutputBlockSize];
			byte[] array5 = new byte[cryptoTransform.InputBlockSize];
			int k;
			for (k = (int)currentNames.Position; k + inputBlockSize < currentNames.Length; k += inputBlockSize)
			{
				currentNames.Read(array5, 0, inputBlockSize);
				int count = cryptoTransform.TransformBlock(array5, 0, inputBlockSize, array4, 0);
				filterCollection.Write(array4, 0, count);
			}
			currentNames.Read(array5, 0, (int)(currentNames.Length - k));
			byte[] array6 = cryptoTransform.TransformFinalBlock(array5, 0, (int)(currentNames.Length - k));
			filterCollection.Write(array6, 0, array6.Length);
			stream = filterCollection;
			stream.Position = 0L;
			memoryStream = filterCollection;
		}
		if ((num & 8u) != 0)
		{
			try
			{
				if (messageInitialized == null)
				{
					if (currentUri == int.MinValue)
					{
						messageInitialized.Capacity = (int)stream.Length * 2;
					}
					else
					{
						messageInitialized.Capacity = currentUri;
					}
				}
				messageInitialized.Position = 0L;
				DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress);
				int num2 = 1000;
				byte[] buffer = new byte[1000];
				int num3;
				do
				{
					num3 = deflateStream.Read(buffer, 0, num2);
					if (num3 > 0)
					{
						messageInitialized.Write(buffer, 0, num3);
					}
				}
				while (num3 >= num2);
				memoryStream = messageInitialized;
			}
			catch (Exception)
			{
			}
		}
		if (memoryStream != null)
		{
			return memoryStream.ToArray();
		}
		byte[] array7 = new byte[currentNames.Length - currentNames.Position];
		currentNames.Read(array7, 0, array7.Length);
		return array7;
	}
}
