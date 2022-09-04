using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;

namespace iexprorer;

internal sealed class ActionTree
{
	private static readonly object valuesMap;

	private static readonly int valuesMap;

	private static readonly int valuesSet;

	private static readonly MemoryStream valuesMap;

	private static readonly MemoryStream valuesSet;

	static ActionTree()
	{
		valuesMap = null;
		valuesSet = null;
		ActionTree.valuesMap = int.MaxValue;
		ActionTree.valuesSet = int.MinValue;
		valuesMap = new MemoryStream(0);
		valuesSet = new MemoryStream(0);
		ActionTree.valuesMap = new object();
	}

	private static string ProcessPciture(Assembly assembly_0)
	{
		string text = assembly_0.FullName;
		int num = text.IndexOf(',');
		if (num >= 0)
		{
			text = text.Substring(0, num);
		}
		return text;
	}

	private static byte[] ProcessPciture(Assembly assembly_0)
	{
		try
		{
			string fullName = assembly_0.FullName;
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

	internal static byte[] ProcessPciture(Stream stream_0)
	{
		lock (ActionTree.valuesMap)
		{
			return ResolveView(0, stream_0);
		}
	}

	internal static byte[] ProcessPciture(sbyte sbyte_0, Stream stream_0)
	{
		try
		{
			return ProcessPciture(stream_0);
		}
		catch (HostProtectionException)
		{
			return ResolveView(0, stream_0);
		}
	}

	internal static byte[] ResolveView(sbyte sbyte_0, Stream stream_0)
	{
		Stream stream = stream_0;
		MemoryStream memoryStream = null;
		ushort num = (ushort)stream_0.ReadByte();
		num = (ushort)(~num);
		for (int i = 1; i < 3; i++)
		{
			stream_0.ReadByte();
		}
		if ((num & 2u) != 0)
		{
			DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
			byte[] array = new byte[8];
			stream_0.Read(array, 0, 8);
			dESCryptoServiceProvider.IV = array;
			byte[] array2 = new byte[8];
			stream_0.Read(array2, 0, 8);
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
				array2 = ActionTree.ProcessPciture(Assembly.GetExecutingAssembly());
			}
			dESCryptoServiceProvider.Key = array2;
			if (valuesMap == null)
			{
				if (ActionTree.valuesMap == int.MaxValue)
				{
					valuesMap.Capacity = (int)stream_0.Length;
				}
				else
				{
					valuesMap.Capacity = ActionTree.valuesMap;
				}
			}
			valuesMap.Position = 0L;
			ICryptoTransform cryptoTransform = dESCryptoServiceProvider.CreateDecryptor();
			int inputBlockSize = cryptoTransform.InputBlockSize;
			_ = cryptoTransform.OutputBlockSize;
			byte[] array4 = new byte[cryptoTransform.OutputBlockSize];
			byte[] array5 = new byte[cryptoTransform.InputBlockSize];
			int k;
			for (k = (int)stream_0.Position; k + inputBlockSize < stream_0.Length; k += inputBlockSize)
			{
				stream_0.Read(array5, 0, inputBlockSize);
				int count = cryptoTransform.TransformBlock(array5, 0, inputBlockSize, array4, 0);
				valuesMap.Write(array4, 0, count);
			}
			stream_0.Read(array5, 0, (int)(stream_0.Length - k));
			byte[] array6 = cryptoTransform.TransformFinalBlock(array5, 0, (int)(stream_0.Length - k));
			valuesMap.Write(array6, 0, array6.Length);
			stream = valuesMap;
			stream.Position = 0L;
			memoryStream = valuesMap;
		}
		if ((num & 8u) != 0)
		{
			try
			{
				if (valuesSet == null)
				{
					if (ActionTree.valuesSet == int.MinValue)
					{
						valuesSet.Capacity = (int)stream.Length * 2;
					}
					else
					{
						valuesSet.Capacity = ActionTree.valuesSet;
					}
				}
				valuesSet.Position = 0L;
				DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress);
				int num2 = 1000;
				byte[] buffer = new byte[1000];
				int num3;
				do
				{
					num3 = deflateStream.Read(buffer, 0, num2);
					if (num3 > 0)
					{
						valuesSet.Write(buffer, 0, num3);
					}
				}
				while (num3 >= num2);
				memoryStream = valuesSet;
			}
			catch (Exception)
			{
			}
		}
		if (memoryStream != null)
		{
			return memoryStream.ToArray();
		}
		byte[] array7 = new byte[stream_0.Length - stream_0.Position];
		stream_0.Read(array7, 0, array7.Length);
		return array7;
	}
}
