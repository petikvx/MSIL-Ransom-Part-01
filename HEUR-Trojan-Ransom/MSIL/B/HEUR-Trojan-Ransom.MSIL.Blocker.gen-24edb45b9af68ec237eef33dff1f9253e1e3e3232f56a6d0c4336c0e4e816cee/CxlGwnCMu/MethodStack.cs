using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;

namespace CxlGwnCMu;

internal class MethodStack
{
	private static readonly object sessionToken;

	private static readonly int logList;

	private static readonly int previousCaption;

	private static readonly MemoryStream parentCategory;

	private static readonly MemoryStream rootName;

	private static readonly byte optionsHeader;

	static MethodStack()
	{
		parentCategory = null;
		rootName = null;
		logList = int.MaxValue;
		previousCaption = int.MinValue;
		parentCategory = new MemoryStream(0);
		rootName = new MemoryStream(0);
		sessionToken = new object();
	}

	private static string FreeMethod(Assembly sessionToken)
	{
		string text = sessionToken.FullName;
		int num = text.IndexOf(',');
		if (num >= 0)
		{
			text = text.Substring(0, num);
		}
		return text;
	}

	private static byte[] ToggleAddin(Assembly sessionToken)
	{
		try
		{
			string fullName = sessionToken.FullName;
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

	internal static byte[] ProcessMemory(Stream sessionToken)
	{
		lock (MethodStack.sessionToken)
		{
			return ExitOutline(97L, sessionToken);
		}
	}

	internal static byte[] DisposeIcon(long sessionToken, Stream logList)
	{
		try
		{
			return ProcessMemory(logList);
		}
		catch (HostProtectionException)
		{
			return ExitOutline(97L, logList);
		}
	}

	internal static byte[] ExitOutline(long sessionToken, Stream logList)
	{
		Stream stream = logList;
		MemoryStream memoryStream = null;
		for (int i = 1; i < 4; i++)
		{
			logList.ReadByte();
		}
		ushort num = (ushort)logList.ReadByte();
		num = (ushort)(~num);
		if ((num & 2u) != 0)
		{
			DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
			byte[] array = new byte[8];
			logList.Read(array, 0, 8);
			dESCryptoServiceProvider.IV = array;
			byte[] array2 = new byte[8];
			logList.Read(array2, 0, 8);
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
				array2 = ToggleAddin(Assembly.GetExecutingAssembly());
			}
			dESCryptoServiceProvider.Key = array2;
			if (parentCategory == null)
			{
				if (MethodStack.logList == int.MaxValue)
				{
					parentCategory.Capacity = (int)logList.Length;
				}
				else
				{
					parentCategory.Capacity = MethodStack.logList;
				}
			}
			parentCategory.Position = 0L;
			ICryptoTransform cryptoTransform = dESCryptoServiceProvider.CreateDecryptor();
			int inputBlockSize = cryptoTransform.InputBlockSize;
			_ = cryptoTransform.OutputBlockSize;
			byte[] array4 = new byte[cryptoTransform.OutputBlockSize];
			byte[] array5 = new byte[cryptoTransform.InputBlockSize];
			int k;
			for (k = (int)logList.Position; k + inputBlockSize < logList.Length; k += inputBlockSize)
			{
				logList.Read(array5, 0, inputBlockSize);
				int count = cryptoTransform.TransformBlock(array5, 0, inputBlockSize, array4, 0);
				parentCategory.Write(array4, 0, count);
			}
			logList.Read(array5, 0, (int)(logList.Length - k));
			byte[] array6 = cryptoTransform.TransformFinalBlock(array5, 0, (int)(logList.Length - k));
			parentCategory.Write(array6, 0, array6.Length);
			stream = parentCategory;
			stream.Position = 0L;
			memoryStream = parentCategory;
		}
		if ((num & 8u) != 0)
		{
			if (rootName == null)
			{
				if (previousCaption == int.MinValue)
				{
					rootName.Capacity = (int)stream.Length * 2;
				}
				else
				{
					rootName.Capacity = previousCaption;
				}
			}
			rootName.Position = 0L;
			DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress);
			int num2 = 1000;
			byte[] buffer = new byte[1000];
			int num3;
			do
			{
				num3 = deflateStream.Read(buffer, 0, num2);
				if (num3 > 0)
				{
					rootName.Write(buffer, 0, num3);
				}
			}
			while (num3 >= num2);
			memoryStream = rootName;
		}
		if (memoryStream != null)
		{
			return memoryStream.ToArray();
		}
		byte[] array7 = new byte[logList.Length - logList.Position];
		logList.Read(array7, 0, array7.Length);
		return array7;
	}
}
