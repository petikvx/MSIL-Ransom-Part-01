using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security.Cryptography;

namespace A;

internal class c14f4fdfe28b860a849e4380de9b9f125
{
	private static readonly object ce39019272d721ae3350f74f63d421305;

	private static readonly int c6ceb98b001274d9d73f2bbc25e0fc785;

	private static readonly int c387f34a354081cb710e02e522d46bba3;

	private static readonly MemoryStream cc49204cba6faac6dd2f78efd55b940c9;

	private static readonly MemoryStream c35f98718e417b0c87ffba672e651a56c;

	private static readonly byte cb8b941afaa58981f3de624ae435ab880;

	static c14f4fdfe28b860a849e4380de9b9f125()
	{
		cc49204cba6faac6dd2f78efd55b940c9 = null;
		c35f98718e417b0c87ffba672e651a56c = null;
		c6ceb98b001274d9d73f2bbc25e0fc785 = int.MaxValue;
		c387f34a354081cb710e02e522d46bba3 = int.MinValue;
		cc49204cba6faac6dd2f78efd55b940c9 = c23f9cb5019c449ec49797d058dd04475.c47310f72a4c995643ae16cec4f007301(0);
		c35f98718e417b0c87ffba672e651a56c = c23f9cb5019c449ec49797d058dd04475.c47310f72a4c995643ae16cec4f007301(0);
		ce39019272d721ae3350f74f63d421305 = c104a9cf48192e01ca79a9b6d01136f9a.c47310f72a4c995643ae16cec4f007301();
	}

	private static string c1d9935dacbe062fb99f64e9be7a9f997(Assembly c26a6969aef1d57b1ef9c99d443b8ca45)
	{
		string text = cdc6c764ac3e278d30fbddfbcbdffbdcb.cb8051d031a8f62d8a0274b9341e967c8(c26a6969aef1d57b1ef9c99d443b8ca45);
		int num = c4120d82cc18a265e1df2ecf616ead588.cb8051d031a8f62d8a0274b9341e967c8(text, ',');
		if (num >= 0)
		{
			while (true)
			{
				switch (2)
				{
				case 0:
					continue;
				}
				break;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			text = ccc7f0ee4c6a05a60ca5218df65d39cf7.cb8051d031a8f62d8a0274b9341e967c8(text, 0, num);
		}
		return text;
	}

	private static byte[] c7df8cf3c364e4e40820fc307a011e2e5(Assembly c26a6969aef1d57b1ef9c99d443b8ca45)
	{
		try
		{
			string c2316c2504b2172363cc0e32e2b2dd4ba = cdc6c764ac3e278d30fbddfbcbdffbdcb.cb8051d031a8f62d8a0274b9341e967c8(c26a6969aef1d57b1ef9c99d443b8ca45);
			int num = c7b385369b105777486572fa20ac30add.cb8051d031a8f62d8a0274b9341e967c8(c2316c2504b2172363cc0e32e2b2dd4ba, "PublicKeyToken=");
			if (num < 0)
			{
				while (true)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					break;
				}
				if (1 == 0)
				{
					/*OpCode not supported: LdMemberToken*/;
				}
				num = c7b385369b105777486572fa20ac30add.cb8051d031a8f62d8a0274b9341e967c8(c2316c2504b2172363cc0e32e2b2dd4ba, "publickeytoken=");
			}
			if (num < 0)
			{
				while (true)
				{
					switch (5)
					{
					case 0:
						break;
					default:
						return null;
					}
				}
			}
			num += 15;
			if (c466a42661613091417e485dbb505fd8c.cb8051d031a8f62d8a0274b9341e967c8(c2316c2504b2172363cc0e32e2b2dd4ba, num) != 'n')
			{
				while (true)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					break;
				}
				if (c466a42661613091417e485dbb505fd8c.cb8051d031a8f62d8a0274b9341e967c8(c2316c2504b2172363cc0e32e2b2dd4ba, num) != 'N')
				{
					string c2316c2504b2172363cc0e32e2b2dd4ba2 = ccc7f0ee4c6a05a60ca5218df65d39cf7.cb8051d031a8f62d8a0274b9341e967c8(c2316c2504b2172363cc0e32e2b2dd4ba, num, 16);
					long c2316c2504b2172363cc0e32e2b2dd4ba3 = c69956b663da125ac8d7b33d074c7b8a7.c47310f72a4c995643ae16cec4f007301(c2316c2504b2172363cc0e32e2b2dd4ba2, NumberStyles.HexNumber);
					byte[] array = c38eb4b7c491d229564cef3bc3d666b41.c47310f72a4c995643ae16cec4f007301(c2316c2504b2172363cc0e32e2b2dd4ba3);
					c204f9c2fd572c9b73806febc937f2e50.c47310f72a4c995643ae16cec4f007301(array);
					return array;
				}
				while (true)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					break;
				}
			}
			return null;
		}
		catch
		{
		}
		return null;
	}

	internal static byte[] cda80e8398bb78a5bf4506bd48718f989(Stream c4c82dad5d5d32f69d470a96f3739e8c0)
	{
		object c2316c2504b2172363cc0e32e2b2dd4ba;
		c61cdbb5e7bc08d0f2cf33b8383091f0d.c47310f72a4c995643ae16cec4f007301(c2316c2504b2172363cc0e32e2b2dd4ba = ce39019272d721ae3350f74f63d421305);
		try
		{
			return c9cf6b17697d23ba99f98a27f0836f59d(97L, c4c82dad5d5d32f69d470a96f3739e8c0);
		}
		finally
		{
			c3edac8ab5f1f35a62bf9a90b66bae615.c47310f72a4c995643ae16cec4f007301(c2316c2504b2172363cc0e32e2b2dd4ba);
		}
	}

	internal static byte[] cb9b84783b9c89d6d4ffab0fe79627c3a(long cb8b941afaa58981f3de624ae435ab880, Stream c4c82dad5d5d32f69d470a96f3739e8c0)
	{
		try
		{
			return cda80e8398bb78a5bf4506bd48718f989(c4c82dad5d5d32f69d470a96f3739e8c0);
		}
		catch
		{
			return c9cf6b17697d23ba99f98a27f0836f59d(97L, c4c82dad5d5d32f69d470a96f3739e8c0);
		}
	}

	internal static byte[] c9cf6b17697d23ba99f98a27f0836f59d(long cb8b941afaa58981f3de624ae435ab880, object c91567b5d9325ce6be277bf1d2c8bf3b0)
	{
		Stream stream = c91567b5d9325ce6be277bf1d2c8bf3b0 as Stream;
		Stream c2316c2504b2172363cc0e32e2b2dd4ba = stream;
		MemoryStream memoryStream = null;
		for (int i = 1; i < 4; i++)
		{
			c3ff3ed46b2528060585b1c4df1bf1360.cb8051d031a8f62d8a0274b9341e967c8(stream);
		}
		while (true)
		{
			switch (3)
			{
			case 0:
				continue;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			ushort num = (ushort)c3ff3ed46b2528060585b1c4df1bf1360.cb8051d031a8f62d8a0274b9341e967c8(stream);
			num = (ushort)(~num);
			if ((num & 2u) != 0)
			{
				DESCryptoServiceProvider c2316c2504b2172363cc0e32e2b2dd4ba2 = c634865a02b45dabaaef6414c7d5dda46.c47310f72a4c995643ae16cec4f007301();
				byte[] c2316c2504b2172363cc0e32e2b2dd4ba3 = new byte[8];
				c8c9fee092d8a10f2de521be1266543bd.cb8051d031a8f62d8a0274b9341e967c8(stream, c2316c2504b2172363cc0e32e2b2dd4ba3, 0, 8);
				c90bed1caa0e605dcd2459d062c7ad5a8.cb8051d031a8f62d8a0274b9341e967c8(c2316c2504b2172363cc0e32e2b2dd4ba2, c2316c2504b2172363cc0e32e2b2dd4ba3);
				byte[] array = new byte[8];
				c8c9fee092d8a10f2de521be1266543bd.cb8051d031a8f62d8a0274b9341e967c8(stream, array, 0, 8);
				bool flag = true;
				byte[] array2 = array;
				int num2 = 0;
				while (true)
				{
					if (num2 < array2.Length)
					{
						if (array2[num2] != 0)
						{
							while (true)
							{
								switch (6)
								{
								case 0:
									continue;
								}
								break;
							}
							flag = false;
							break;
						}
						num2++;
						continue;
					}
					while (true)
					{
						switch (7)
						{
						case 0:
							continue;
						}
						break;
					}
					break;
				}
				if (flag)
				{
					while (true)
					{
						switch (2)
						{
						case 0:
							continue;
						}
						break;
					}
					array = c7df8cf3c364e4e40820fc307a011e2e5(c20871d5ae6af7e49c103ece4e57e1404.c47310f72a4c995643ae16cec4f007301());
				}
				c1328d7d1a59a1b86cdeac7eec494f766.cb8051d031a8f62d8a0274b9341e967c8(c2316c2504b2172363cc0e32e2b2dd4ba2, array);
				if (cc49204cba6faac6dd2f78efd55b940c9 == null)
				{
					while (true)
					{
						switch (5)
						{
						case 0:
							continue;
						}
						break;
					}
					if (c6ceb98b001274d9d73f2bbc25e0fc785 == int.MaxValue)
					{
						while (true)
						{
							switch (6)
							{
							case 0:
								continue;
							}
							break;
						}
						c972f3534bb7fd978c3c8b14284c21a44.cb8051d031a8f62d8a0274b9341e967c8(cc49204cba6faac6dd2f78efd55b940c9, (int)c3eb071b541877eb74651d42002b3ba73.cb8051d031a8f62d8a0274b9341e967c8(stream));
					}
					else
					{
						c972f3534bb7fd978c3c8b14284c21a44.cb8051d031a8f62d8a0274b9341e967c8(cc49204cba6faac6dd2f78efd55b940c9, c6ceb98b001274d9d73f2bbc25e0fc785);
					}
				}
				ceface61d3d5f2abe449f94d42f808dce.cb8051d031a8f62d8a0274b9341e967c8(cc49204cba6faac6dd2f78efd55b940c9, 0L);
				ICryptoTransform c2316c2504b2172363cc0e32e2b2dd4ba4 = c508948c8e96de5aac0d3ddc83a3195b9.cb8051d031a8f62d8a0274b9341e967c8(c2316c2504b2172363cc0e32e2b2dd4ba2);
				int num3 = cb611f71a5d590eee4dc864173a1d042f.cb8051d031a8f62d8a0274b9341e967c8(c2316c2504b2172363cc0e32e2b2dd4ba4);
				cdb3cc5a10d75e53e2ae5e86fb9f028a3.cb8051d031a8f62d8a0274b9341e967c8(c2316c2504b2172363cc0e32e2b2dd4ba4);
				byte[] c2316c2504b2172363cc0e32e2b2dd4ba5 = new byte[cdb3cc5a10d75e53e2ae5e86fb9f028a3.cb8051d031a8f62d8a0274b9341e967c8(c2316c2504b2172363cc0e32e2b2dd4ba4)];
				byte[] c2316c2504b2172363cc0e32e2b2dd4ba6 = new byte[cb611f71a5d590eee4dc864173a1d042f.cb8051d031a8f62d8a0274b9341e967c8(c2316c2504b2172363cc0e32e2b2dd4ba4)];
				int j;
				for (j = (int)c09f8fc9d88ef0db6ed2ec7026f5a9fdd.cb8051d031a8f62d8a0274b9341e967c8(stream); j + num3 < c3eb071b541877eb74651d42002b3ba73.cb8051d031a8f62d8a0274b9341e967c8(stream); j += num3)
				{
					c8c9fee092d8a10f2de521be1266543bd.cb8051d031a8f62d8a0274b9341e967c8(stream, c2316c2504b2172363cc0e32e2b2dd4ba6, 0, num3);
					int c2316c2504b2172363cc0e32e2b2dd4ba7 = c05f3901a826b7bf51c2c4c92da597044.cb8051d031a8f62d8a0274b9341e967c8(c2316c2504b2172363cc0e32e2b2dd4ba4, c2316c2504b2172363cc0e32e2b2dd4ba6, 0, num3, c2316c2504b2172363cc0e32e2b2dd4ba5, 0);
					c8cd3c6c63ac0c31a755189a0ab1eb4a7.cb8051d031a8f62d8a0274b9341e967c8(cc49204cba6faac6dd2f78efd55b940c9, c2316c2504b2172363cc0e32e2b2dd4ba5, 0, c2316c2504b2172363cc0e32e2b2dd4ba7);
				}
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				c8c9fee092d8a10f2de521be1266543bd.cb8051d031a8f62d8a0274b9341e967c8(stream, c2316c2504b2172363cc0e32e2b2dd4ba6, 0, (int)(c3eb071b541877eb74651d42002b3ba73.cb8051d031a8f62d8a0274b9341e967c8(stream) - j));
				byte[] array3 = c1eb398d8fdcb4899f0a092b3e7e6d4bc.cb8051d031a8f62d8a0274b9341e967c8(c2316c2504b2172363cc0e32e2b2dd4ba4, c2316c2504b2172363cc0e32e2b2dd4ba6, 0, (int)(c3eb071b541877eb74651d42002b3ba73.cb8051d031a8f62d8a0274b9341e967c8(stream) - j));
				c8cd3c6c63ac0c31a755189a0ab1eb4a7.cb8051d031a8f62d8a0274b9341e967c8(cc49204cba6faac6dd2f78efd55b940c9, array3, 0, array3.Length);
				c2316c2504b2172363cc0e32e2b2dd4ba = cc49204cba6faac6dd2f78efd55b940c9;
				ceface61d3d5f2abe449f94d42f808dce.cb8051d031a8f62d8a0274b9341e967c8(c2316c2504b2172363cc0e32e2b2dd4ba, 0L);
				memoryStream = cc49204cba6faac6dd2f78efd55b940c9;
			}
			if ((num & 8u) != 0)
			{
				if (c35f98718e417b0c87ffba672e651a56c == null)
				{
					if (c387f34a354081cb710e02e522d46bba3 == int.MinValue)
					{
						c972f3534bb7fd978c3c8b14284c21a44.cb8051d031a8f62d8a0274b9341e967c8(c35f98718e417b0c87ffba672e651a56c, (int)c3eb071b541877eb74651d42002b3ba73.cb8051d031a8f62d8a0274b9341e967c8(c2316c2504b2172363cc0e32e2b2dd4ba) * 2);
					}
					else
					{
						c972f3534bb7fd978c3c8b14284c21a44.cb8051d031a8f62d8a0274b9341e967c8(c35f98718e417b0c87ffba672e651a56c, c387f34a354081cb710e02e522d46bba3);
					}
				}
				ceface61d3d5f2abe449f94d42f808dce.cb8051d031a8f62d8a0274b9341e967c8(c35f98718e417b0c87ffba672e651a56c, 0L);
				DeflateStream c2316c2504b2172363cc0e32e2b2dd4ba8 = c0e9bd19a1528e2b9b60eb399b779d033.c47310f72a4c995643ae16cec4f007301(c2316c2504b2172363cc0e32e2b2dd4ba, CompressionMode.Decompress);
				int num4 = 1000;
				byte[] c2316c2504b2172363cc0e32e2b2dd4ba9 = new byte[num4];
				int num5;
				do
				{
					num5 = c8c9fee092d8a10f2de521be1266543bd.cb8051d031a8f62d8a0274b9341e967c8(c2316c2504b2172363cc0e32e2b2dd4ba8, c2316c2504b2172363cc0e32e2b2dd4ba9, 0, num4);
					if (num5 <= 0)
					{
						continue;
					}
					while (true)
					{
						switch (3)
						{
						case 0:
							continue;
						}
						break;
					}
					c8cd3c6c63ac0c31a755189a0ab1eb4a7.cb8051d031a8f62d8a0274b9341e967c8(c35f98718e417b0c87ffba672e651a56c, c2316c2504b2172363cc0e32e2b2dd4ba9, 0, num5);
				}
				while (num5 >= num4);
				while (true)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					break;
				}
				memoryStream = c35f98718e417b0c87ffba672e651a56c;
			}
			if (memoryStream != null)
			{
				return c5b7bb383c93f07e1d28fecd86e596bce.cb8051d031a8f62d8a0274b9341e967c8(memoryStream);
			}
			byte[] array4 = new byte[c3eb071b541877eb74651d42002b3ba73.cb8051d031a8f62d8a0274b9341e967c8(stream) - c09f8fc9d88ef0db6ed2ec7026f5a9fdd.cb8051d031a8f62d8a0274b9341e967c8(stream)];
			c8c9fee092d8a10f2de521be1266543bd.cb8051d031a8f62d8a0274b9341e967c8(stream, array4, 0, array4.Length);
			return array4;
		}
	}
}
