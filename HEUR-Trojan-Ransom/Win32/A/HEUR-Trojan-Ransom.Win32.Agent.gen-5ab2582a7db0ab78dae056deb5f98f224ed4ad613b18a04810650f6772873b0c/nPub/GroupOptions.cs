using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;

namespace nPub;

internal class GroupOptions
{
	private static readonly object syncObjectHandle;

	private static readonly int syncObjectHandle;

	private static readonly int syncObjectList;

	private static readonly MemoryStream syncObjectHandle;

	private static readonly MemoryStream syncObjectList;

	private static readonly byte syncObjectHandle;

	static GroupOptions()
	{
		GroupOptions.syncObjectHandle = null;
		syncObjectList = null;
		GroupOptions.syncObjectHandle = int.MaxValue;
		GroupOptions.syncObjectList = int.MinValue;
		GroupOptions.syncObjectHandle = new MemoryStream(0);
		syncObjectList = new MemoryStream(0);
		GroupOptions.syncObjectHandle = new object();
	}

	private static string OrderAddin(Assembly syncObjectHandle)
	{
		string text = syncObjectHandle.FullName;
		int num = text.IndexOf(',');
		if (num >= 0)
		{
			text = text.Substring(0, num);
		}
		return text;
	}

	private static byte[] OrderAddin(Assembly syncObjectHandle)
	{
		try
		{
			string fullName = syncObjectHandle.FullName;
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

	internal static byte[] OrderAddin(Stream syncObjectHandle)
	{
		lock (GroupOptions.syncObjectHandle)
		{
			return IncreaseSolution(97L, syncObjectHandle);
		}
	}

	internal static byte[] OrderAddin(long syncObjectHandle, Stream syncObjectList)
	{
		try
		{
			return OrderAddin(syncObjectList);
		}
		catch (HostProtectionException)
		{
			return IncreaseSolution(97L, syncObjectList);
		}
	}

	internal static byte[] IncreaseSolution(long syncObjectHandle, Stream syncObjectList)
	{
		Stream stream = syncObjectList;
		MemoryStream memoryStream = null;
		ushort num = (ushort)syncObjectList.ReadByte();
		num = (ushort)(~num);
		for (int i = 1; i < 4; i++)
		{
			syncObjectList.ReadByte();
		}
		if ((num & 2u) != 0)
		{
			DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
			byte[] array = new byte[8];
			syncObjectList.Read(array, 0, 8);
			dESCryptoServiceProvider.IV = array;
			byte[] array2 = new byte[8];
			syncObjectList.Read(array2, 0, 8);
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
				array2 = GroupOptions.OrderAddin(Assembly.GetExecutingAssembly());
			}
			dESCryptoServiceProvider.Key = array2;
			if (GroupOptions.syncObjectHandle == null)
			{
				if (GroupOptions.syncObjectHandle == int.MaxValue)
				{
					GroupOptions.syncObjectHandle.Capacity = (int)syncObjectList.Length;
				}
				else
				{
					GroupOptions.syncObjectHandle.Capacity = GroupOptions.syncObjectHandle;
				}
			}
			GroupOptions.syncObjectHandle.Position = 0L;
			ICryptoTransform cryptoTransform = dESCryptoServiceProvider.CreateDecryptor();
			int inputBlockSize = cryptoTransform.InputBlockSize;
			_ = cryptoTransform.OutputBlockSize;
			byte[] array4 = new byte[cryptoTransform.OutputBlockSize];
			byte[] array5 = new byte[cryptoTransform.InputBlockSize];
			int k;
			for (k = (int)syncObjectList.Position; k + inputBlockSize < syncObjectList.Length; k += inputBlockSize)
			{
				syncObjectList.Read(array5, 0, inputBlockSize);
				int count = cryptoTransform.TransformBlock(array5, 0, inputBlockSize, array4, 0);
				GroupOptions.syncObjectHandle.Write(array4, 0, count);
			}
			syncObjectList.Read(array5, 0, (int)(syncObjectList.Length - k));
			byte[] array6 = cryptoTransform.TransformFinalBlock(array5, 0, (int)(syncObjectList.Length - k));
			GroupOptions.syncObjectHandle.Write(array6, 0, array6.Length);
			stream = GroupOptions.syncObjectHandle;
			stream.Position = 0L;
			memoryStream = GroupOptions.syncObjectHandle;
		}
		if ((num & 8u) != 0)
		{
			try
			{
				if (GroupOptions.syncObjectList == null)
				{
					if (GroupOptions.syncObjectList == int.MinValue)
					{
						GroupOptions.syncObjectList.Capacity = (int)stream.Length * 2;
					}
					else
					{
						GroupOptions.syncObjectList.Capacity = GroupOptions.syncObjectList;
					}
				}
				GroupOptions.syncObjectList.Position = 0L;
				DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress);
				int num2 = 1000;
				byte[] buffer = new byte[1000];
				int num3;
				do
				{
					num3 = deflateStream.Read(buffer, 0, num2);
					if (num3 > 0)
					{
						GroupOptions.syncObjectList.Write(buffer, 0, num3);
					}
				}
				while (num3 >= num2);
				memoryStream = GroupOptions.syncObjectList;
			}
			catch (Exception)
			{
			}
		}
		if (memoryStream != null)
		{
			return memoryStream.ToArray();
		}
		byte[] array7 = new byte[syncObjectList.Length - syncObjectList.Position];
		syncObjectList.Read(array7, 0, array7.Length);
		return array7;
	}
}
