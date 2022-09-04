using System;
using System.IO;
using System.IO.Compression;
using Microsoft.VisualBasic.CompilerServices;

public class GClass3
{
	public static byte[] smethod_0(byte[] byte_0)
	{
		checked
		{
			using MemoryStream memoryStream = new MemoryStream(byte_0);
			using (GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
			{
				int num = 0;
				int num2;
				do
				{
					byte_0 = (byte[])Utils.CopyArray((Array)byte_0, (Array)new byte[num + 1024 - 1 + 1]);
					num2 = gZipStream.Read(byte_0, num, 1024);
					num += num2;
				}
				while (num2 >= 1024);
				byte_0 = (byte[])Utils.CopyArray((Array)byte_0, (Array)new byte[num - 1 + 1]);
				gZipStream.Close();
			}
			memoryStream.Close();
			return byte_0;
		}
	}
}
