using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using Microsoft.VisualBasic.CompilerServices;

namespace retting;

public class Compression
{
	[DebuggerNonUserCode]
	public Compression()
	{
		Class14.u5Gt82DzXHpxk();
		base._002Ector();
	}

	public static byte[] Compress(byte[] bytData)
	{
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using (GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Compress))
			{
				gZipStream.Write(bytData, 0, bytData.Length);
				gZipStream.Close();
				bytData = new byte[checked(memoryStream.ToArray().Length - 1 + 1)];
				bytData = memoryStream.ToArray();
			}
			memoryStream.Close();
		}
		return bytData;
	}

	public static byte[] Decompress(byte[] bytData)
	{
		checked
		{
			using (MemoryStream memoryStream = new MemoryStream(bytData))
			{
				using (GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
				{
					int num = 0;
					int num2;
					do
					{
						bytData = (byte[])Utils.CopyArray((Array)bytData, (Array)new byte[num + 1024 - 1 + 1]);
						num2 = gZipStream.Read(bytData, num, 1024);
						num += num2;
					}
					while (num2 >= 1024);
					bytData = (byte[])Utils.CopyArray((Array)bytData, (Array)new byte[num - 1 + 1]);
					gZipStream.Close();
				}
				memoryStream.Close();
			}
			return bytData;
		}
	}
}
