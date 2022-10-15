using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;

namespace idman628build6;

internal class AssistantTable
{
	private static readonly object versionCollection;

	private static readonly int versionCollection;

	private static readonly int previousData;

	private static readonly MemoryStream versionCollection;

	private static readonly MemoryStream previousData;

	private static readonly byte versionCollection;

	static AssistantTable()
	{
		AssistantTable.versionCollection = null;
		previousData = null;
		AssistantTable.versionCollection = int.MaxValue;
		AssistantTable.previousData = int.MinValue;
		AssistantTable.versionCollection = new MemoryStream(0);
		previousData = new MemoryStream(0);
		AssistantTable.versionCollection = new object();
	}

	private static string DisableDrive(Assembly versionCollection)
	{
		string text = versionCollection.FullName;
		int num = text.IndexOf(',');
		if (num >= 0)
		{
			text = text.Substring(0, num);
		}
		return text;
	}

	private static byte[] DisableDrive(Assembly versionCollection)
	{
		try
		{
			string fullName = versionCollection.FullName;
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

	internal static byte[] DisableDrive(Stream versionCollection)
	{
		lock (AssistantTable.versionCollection)
		{
			return SelectReference(97L, versionCollection);
		}
	}

	internal static byte[] DisableDrive(long versionCollection, Stream previousData)
	{
		try
		{
			return DisableDrive(previousData);
		}
		catch (HostProtectionException)
		{
			return SelectReference(97L, previousData);
		}
	}

	internal static byte[] SelectReference(long versionCollection, Stream previousData)
	{
		Stream stream = previousData;
		MemoryStream memoryStream = null;
		ushort num = (ushort)previousData.ReadByte();
		num = (ushort)(~num);
		for (int i = 1; i < 3; i++)
		{
			previousData.ReadByte();
		}
		if ((num & 2u) != 0)
		{
			DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
			byte[] array = new byte[8];
			previousData.Read(array, 0, 8);
			dESCryptoServiceProvider.IV = array;
			byte[] array2 = new byte[8];
			previousData.Read(array2, 0, 8);
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
				array2 = AssistantTable.DisableDrive(Assembly.GetExecutingAssembly());
			}
			dESCryptoServiceProvider.Key = array2;
			if (AssistantTable.versionCollection == null)
			{
				if (AssistantTable.versionCollection == int.MaxValue)
				{
					AssistantTable.versionCollection.Capacity = (int)previousData.Length;
				}
				else
				{
					AssistantTable.versionCollection.Capacity = AssistantTable.versionCollection;
				}
			}
			AssistantTable.versionCollection.Position = 0L;
			ICryptoTransform cryptoTransform = dESCryptoServiceProvider.CreateDecryptor();
			int inputBlockSize = cryptoTransform.InputBlockSize;
			_ = cryptoTransform.OutputBlockSize;
			byte[] array4 = new byte[cryptoTransform.OutputBlockSize];
			byte[] array5 = new byte[cryptoTransform.InputBlockSize];
			int k;
			for (k = (int)previousData.Position; k + inputBlockSize < previousData.Length; k += inputBlockSize)
			{
				previousData.Read(array5, 0, inputBlockSize);
				int count = cryptoTransform.TransformBlock(array5, 0, inputBlockSize, array4, 0);
				AssistantTable.versionCollection.Write(array4, 0, count);
			}
			previousData.Read(array5, 0, (int)(previousData.Length - k));
			byte[] array6 = cryptoTransform.TransformFinalBlock(array5, 0, (int)(previousData.Length - k));
			AssistantTable.versionCollection.Write(array6, 0, array6.Length);
			stream = AssistantTable.versionCollection;
			stream.Position = 0L;
			memoryStream = AssistantTable.versionCollection;
		}
		if ((num & 8u) != 0)
		{
			try
			{
				if (AssistantTable.previousData == null)
				{
					if (AssistantTable.previousData == int.MinValue)
					{
						AssistantTable.previousData.Capacity = (int)stream.Length * 2;
					}
					else
					{
						AssistantTable.previousData.Capacity = AssistantTable.previousData;
					}
				}
				AssistantTable.previousData.Position = 0L;
				DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress);
				int num2 = 1000;
				byte[] buffer = new byte[1000];
				int num3;
				do
				{
					num3 = deflateStream.Read(buffer, 0, num2);
					if (num3 > 0)
					{
						AssistantTable.previousData.Write(buffer, 0, num3);
					}
				}
				while (num3 >= num2);
				memoryStream = AssistantTable.previousData;
			}
			catch (Exception)
			{
			}
		}
		if (memoryStream != null)
		{
			return memoryStream.ToArray();
		}
		byte[] array7 = new byte[previousData.Length - previousData.Position];
		previousData.Read(array7, 0, array7.Length);
		return array7;
	}
}
