using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;

namespace Loader;

internal sealed class PartitionService
{
	private static readonly object previousId;

	private static readonly int previousId;

	private static readonly int userData;

	private static readonly MemoryStream previousId;

	private static readonly MemoryStream userData;

	private static readonly byte previousId;

	static PartitionService()
	{
		PartitionService.previousId = null;
		userData = null;
		PartitionService.previousId = int.MaxValue;
		PartitionService.userData = 10108;
		PartitionService.previousId = new MemoryStream(0);
		userData = new MemoryStream(0);
		PartitionService.previousId = new object();
	}

	private static string CloneWindow(Assembly assembly_0)
	{
		string text = assembly_0.FullName;
		int num = text.IndexOf(',');
		if (num >= 0)
		{
			text = text.Substring(0, num);
		}
		return text;
	}

	private static byte[] CloneWindow(Assembly assembly_0)
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

	internal static byte[] CloneWindow(Stream stream_0)
	{
		lock (PartitionService.previousId)
		{
			return SortMethod(97L, stream_0);
		}
	}

	internal static byte[] CloneWindow(long long_0, Stream stream_0)
	{
		try
		{
			return CloneWindow(stream_0);
		}
		catch (HostProtectionException)
		{
			return SortMethod(97L, stream_0);
		}
	}

	internal static byte[] SortMethod(long long_0, Stream stream_0)
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
				array2 = PartitionService.CloneWindow(Assembly.GetExecutingAssembly());
			}
			dESCryptoServiceProvider.Key = array2;
			if (PartitionService.previousId == null)
			{
				if (PartitionService.previousId == int.MaxValue)
				{
					PartitionService.previousId.Capacity = (int)stream_0.Length;
				}
				else
				{
					PartitionService.previousId.Capacity = PartitionService.previousId;
				}
			}
			PartitionService.previousId.Position = 0L;
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
				PartitionService.previousId.Write(array4, 0, count);
			}
			stream_0.Read(array5, 0, (int)(stream_0.Length - k));
			byte[] array6 = cryptoTransform.TransformFinalBlock(array5, 0, (int)(stream_0.Length - k));
			PartitionService.previousId.Write(array6, 0, array6.Length);
			stream = PartitionService.previousId;
			stream.Position = 0L;
			memoryStream = PartitionService.previousId;
		}
		if ((num & 8u) != 0)
		{
			try
			{
				if (userData == null)
				{
					if (PartitionService.userData == int.MinValue)
					{
						userData.Capacity = (int)stream.Length * 2;
					}
					else
					{
						userData.Capacity = PartitionService.userData;
					}
				}
				userData.Position = 0L;
				DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress);
				int num2 = 1000;
				byte[] buffer = new byte[1000];
				int num3;
				do
				{
					num3 = deflateStream.Read(buffer, 0, num2);
					if (num3 > 0)
					{
						userData.Write(buffer, 0, num3);
					}
				}
				while (num3 >= num2);
				memoryStream = userData;
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
