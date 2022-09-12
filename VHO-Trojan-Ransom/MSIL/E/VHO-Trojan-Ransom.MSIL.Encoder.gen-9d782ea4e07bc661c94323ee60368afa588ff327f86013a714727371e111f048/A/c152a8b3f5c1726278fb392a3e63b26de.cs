using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security.Cryptography;

namespace A;

internal class c152a8b3f5c1726278fb392a3e63b26de
{
	private static readonly object cf9931aa8985c6202628949183249a997;

	private static readonly int c77bb2c78e17573783a3ddabbd709426b;

	private static readonly int cb98fcf04ec4a7155685c21a49b483142;

	private static readonly MemoryStream c1ea5f35acab1acd8a87536c4f06e2387;

	private static readonly MemoryStream c2058e9676d5f84cfbcea9658896a702d;

	private static readonly byte c0dd610406b8f168b7ace90e74c3a1433;

	static c152a8b3f5c1726278fb392a3e63b26de()
	{
		c1ea5f35acab1acd8a87536c4f06e2387 = null;
		c2058e9676d5f84cfbcea9658896a702d = null;
		c77bb2c78e17573783a3ddabbd709426b = int.MaxValue;
		cb98fcf04ec4a7155685c21a49b483142 = int.MinValue;
		c1ea5f35acab1acd8a87536c4f06e2387 = cdeeecfd96ef0e5d246812299c438abc3.c0a0a027f52dbb53b7a992b50e32f26b6(0);
		c2058e9676d5f84cfbcea9658896a702d = cdeeecfd96ef0e5d246812299c438abc3.c0a0a027f52dbb53b7a992b50e32f26b6(0);
		cf9931aa8985c6202628949183249a997 = cb361a425fe428d6f0a46f238a832a97e.c0a0a027f52dbb53b7a992b50e32f26b6();
	}

	private static string c024ceeaa0e6c685cd9deb8c114492844(Assembly cd1aaf5c45e6a8acbd9022775ee5585b6)
	{
		string text = c3581fa725c90b0c2d192efb786a6c6b7.cb820d091707fb0ff42c9a92b27592d9f(cd1aaf5c45e6a8acbd9022775ee5585b6);
		int num = c6b2352194745c32a43ce3a0876483f5f.cb820d091707fb0ff42c9a92b27592d9f(text, ',');
		if (num >= 0)
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
			text = c7582d7a17ded0bed40043f03efadaa6c.cb820d091707fb0ff42c9a92b27592d9f(text, 0, num);
		}
		return text;
	}

	private static byte[] ca2f81fb45e510d0d21916fa904ee0b3b(Assembly cd1aaf5c45e6a8acbd9022775ee5585b6)
	{
		try
		{
			string cbf979afd484fde812cf185a3a = c3581fa725c90b0c2d192efb786a6c6b7.cb820d091707fb0ff42c9a92b27592d9f(cd1aaf5c45e6a8acbd9022775ee5585b6);
			int num = c5fde0afb943e4efa35dfc96cbece7426.cb820d091707fb0ff42c9a92b27592d9f(cbf979afd484fde812cf185a3a, "PublicKeyToken=");
			if (num < 0)
			{
				while (true)
				{
					switch (1)
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
				num = c5fde0afb943e4efa35dfc96cbece7426.cb820d091707fb0ff42c9a92b27592d9f(cbf979afd484fde812cf185a3a, "publickeytoken=");
			}
			if (num < 0)
			{
				return null;
			}
			num += 15;
			if (c2f3cd2894cd43ea4ca47fa075b6c0306.cb820d091707fb0ff42c9a92b27592d9f(cbf979afd484fde812cf185a3a, num) == 'n' || c2f3cd2894cd43ea4ca47fa075b6c0306.cb820d091707fb0ff42c9a92b27592d9f(cbf979afd484fde812cf185a3a, num) == 'N')
			{
				return null;
			}
			string cbf979afd484fde812cf185a3a2 = c7582d7a17ded0bed40043f03efadaa6c.cb820d091707fb0ff42c9a92b27592d9f(cbf979afd484fde812cf185a3a, num, 16);
			long cbf979afd484fde812cf185a3a3 = c8ec86d9703304b34f12764c217b25195.c0a0a027f52dbb53b7a992b50e32f26b6(cbf979afd484fde812cf185a3a2, NumberStyles.HexNumber);
			byte[] array = ce0e8c6abeb30007d1ab64fa2ba07a350.c0a0a027f52dbb53b7a992b50e32f26b6(cbf979afd484fde812cf185a3a3);
			c2537ae5f0a1dea36b3f2bf77d9db25c6.c0a0a027f52dbb53b7a992b50e32f26b6(array);
			return array;
		}
		catch
		{
		}
		return null;
	}

	internal static byte[] c16f8e02f7b19e8f01f68bd5cd499f5cd(Stream c2f9a278dca2c512cfc39b0283464f3fe)
	{
		object cbf979afd484fde812cf185a3a;
		ca37f520ff9e093994a89754538e749dc.c0a0a027f52dbb53b7a992b50e32f26b6(cbf979afd484fde812cf185a3a = cf9931aa8985c6202628949183249a997);
		try
		{
			return c5116fb9b0673edf1ec1773ab9970255e(97L, c2f9a278dca2c512cfc39b0283464f3fe);
		}
		finally
		{
			c920a3eff99d1710f7d31a309fcaf1a4a.c0a0a027f52dbb53b7a992b50e32f26b6(cbf979afd484fde812cf185a3a);
		}
	}

	internal static byte[] c35529615ba4c81daae3d0364107e364a(long c0dd610406b8f168b7ace90e74c3a1433, Stream c2f9a278dca2c512cfc39b0283464f3fe)
	{
		try
		{
			return c16f8e02f7b19e8f01f68bd5cd499f5cd(c2f9a278dca2c512cfc39b0283464f3fe);
		}
		catch
		{
			return c5116fb9b0673edf1ec1773ab9970255e(97L, c2f9a278dca2c512cfc39b0283464f3fe);
		}
	}

	internal static byte[] c5116fb9b0673edf1ec1773ab9970255e(long c0dd610406b8f168b7ace90e74c3a1433, object c69b82ffbcb477df23bb80b58b1410d35)
	{
		Stream stream = c69b82ffbcb477df23bb80b58b1410d35 as Stream;
		Stream cbf979afd484fde812cf185a3a = stream;
		MemoryStream memoryStream = null;
		for (int i = 1; i < 4; i++)
		{
			c55988a3cd11a7b4517d4ba567b19544f.cb820d091707fb0ff42c9a92b27592d9f(stream);
		}
		while (true)
		{
			switch (4)
			{
			case 0:
				continue;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			ushort num = (ushort)c55988a3cd11a7b4517d4ba567b19544f.cb820d091707fb0ff42c9a92b27592d9f(stream);
			num = (ushort)(~num);
			if ((num & 2u) != 0)
			{
				DESCryptoServiceProvider cbf979afd484fde812cf185a3a2 = cfb36e96bd0ffc5f36b14ef089ddee493.c0a0a027f52dbb53b7a992b50e32f26b6();
				byte[] cbf979afd484fde812cf185a3a3 = new byte[8];
				c9a34e2d11c5d0c5bb4cb0160549f9dd6.cb820d091707fb0ff42c9a92b27592d9f(stream, cbf979afd484fde812cf185a3a3, 0, 8);
				cab2bcdd7c4cd2889d20a3eb95ca66732.cb820d091707fb0ff42c9a92b27592d9f(cbf979afd484fde812cf185a3a2, cbf979afd484fde812cf185a3a3);
				byte[] array = new byte[8];
				c9a34e2d11c5d0c5bb4cb0160549f9dd6.cb820d091707fb0ff42c9a92b27592d9f(stream, array, 0, 8);
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
								switch (7)
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
						switch (1)
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
						switch (5)
						{
						case 0:
							continue;
						}
						break;
					}
					array = ca2f81fb45e510d0d21916fa904ee0b3b(cba9d70dae6cc75c78bceed8a8419e33f.c0a0a027f52dbb53b7a992b50e32f26b6());
				}
				caea1981aabcc578c7f8aa9958be3f261.cb820d091707fb0ff42c9a92b27592d9f(cbf979afd484fde812cf185a3a2, array);
				if (c1ea5f35acab1acd8a87536c4f06e2387 == null)
				{
					if (c77bb2c78e17573783a3ddabbd709426b == int.MaxValue)
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
						c798f3511c32f95ce67f408b62e9cdad7.cb820d091707fb0ff42c9a92b27592d9f(c1ea5f35acab1acd8a87536c4f06e2387, (int)cbe46e101ef999e8bef62fbc5dabe5720.cb820d091707fb0ff42c9a92b27592d9f(stream));
					}
					else
					{
						c798f3511c32f95ce67f408b62e9cdad7.cb820d091707fb0ff42c9a92b27592d9f(c1ea5f35acab1acd8a87536c4f06e2387, c77bb2c78e17573783a3ddabbd709426b);
					}
				}
				c4851c76dff3c68269c2f88c388225769.cb820d091707fb0ff42c9a92b27592d9f(c1ea5f35acab1acd8a87536c4f06e2387, 0L);
				ICryptoTransform cbf979afd484fde812cf185a3a4 = c87bf351e7a2179477fcc7f02c938bd92.cb820d091707fb0ff42c9a92b27592d9f(cbf979afd484fde812cf185a3a2);
				int num3 = c58a3dfc2b96e2724bd67cdfcff315f5c.cb820d091707fb0ff42c9a92b27592d9f(cbf979afd484fde812cf185a3a4);
				cd2325110b09897bbc38d0c219e6fc5c9.cb820d091707fb0ff42c9a92b27592d9f(cbf979afd484fde812cf185a3a4);
				byte[] cbf979afd484fde812cf185a3a5 = new byte[cd2325110b09897bbc38d0c219e6fc5c9.cb820d091707fb0ff42c9a92b27592d9f(cbf979afd484fde812cf185a3a4)];
				byte[] cbf979afd484fde812cf185a3a6 = new byte[c58a3dfc2b96e2724bd67cdfcff315f5c.cb820d091707fb0ff42c9a92b27592d9f(cbf979afd484fde812cf185a3a4)];
				int j;
				for (j = (int)c53f246fd39a574cbe9866ef69a6a20ad.cb820d091707fb0ff42c9a92b27592d9f(stream); j + num3 < cbe46e101ef999e8bef62fbc5dabe5720.cb820d091707fb0ff42c9a92b27592d9f(stream); j += num3)
				{
					c9a34e2d11c5d0c5bb4cb0160549f9dd6.cb820d091707fb0ff42c9a92b27592d9f(stream, cbf979afd484fde812cf185a3a6, 0, num3);
					int cbf979afd484fde812cf185a3a7 = cb9703c7b09881dd7cf80cb19eb441a90.cb820d091707fb0ff42c9a92b27592d9f(cbf979afd484fde812cf185a3a4, cbf979afd484fde812cf185a3a6, 0, num3, cbf979afd484fde812cf185a3a5, 0);
					cd5ab067c7b0374b0997eff8fcdcead57.cb820d091707fb0ff42c9a92b27592d9f(c1ea5f35acab1acd8a87536c4f06e2387, cbf979afd484fde812cf185a3a5, 0, cbf979afd484fde812cf185a3a7);
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
				c9a34e2d11c5d0c5bb4cb0160549f9dd6.cb820d091707fb0ff42c9a92b27592d9f(stream, cbf979afd484fde812cf185a3a6, 0, (int)(cbe46e101ef999e8bef62fbc5dabe5720.cb820d091707fb0ff42c9a92b27592d9f(stream) - j));
				byte[] array3 = ce6c3c94af262b6967b908dc1327390a8.cb820d091707fb0ff42c9a92b27592d9f(cbf979afd484fde812cf185a3a4, cbf979afd484fde812cf185a3a6, 0, (int)(cbe46e101ef999e8bef62fbc5dabe5720.cb820d091707fb0ff42c9a92b27592d9f(stream) - j));
				cd5ab067c7b0374b0997eff8fcdcead57.cb820d091707fb0ff42c9a92b27592d9f(c1ea5f35acab1acd8a87536c4f06e2387, array3, 0, array3.Length);
				cbf979afd484fde812cf185a3a = c1ea5f35acab1acd8a87536c4f06e2387;
				c4851c76dff3c68269c2f88c388225769.cb820d091707fb0ff42c9a92b27592d9f(cbf979afd484fde812cf185a3a, 0L);
				memoryStream = c1ea5f35acab1acd8a87536c4f06e2387;
			}
			if ((num & 8u) != 0)
			{
				while (true)
				{
					switch (4)
					{
					case 0:
						continue;
					}
					break;
				}
				if (c2058e9676d5f84cfbcea9658896a702d == null)
				{
					while (true)
					{
						switch (1)
						{
						case 0:
							continue;
						}
						break;
					}
					if (cb98fcf04ec4a7155685c21a49b483142 == int.MinValue)
					{
						while (true)
						{
							switch (4)
							{
							case 0:
								continue;
							}
							break;
						}
						c798f3511c32f95ce67f408b62e9cdad7.cb820d091707fb0ff42c9a92b27592d9f(c2058e9676d5f84cfbcea9658896a702d, (int)cbe46e101ef999e8bef62fbc5dabe5720.cb820d091707fb0ff42c9a92b27592d9f(cbf979afd484fde812cf185a3a) * 2);
					}
					else
					{
						c798f3511c32f95ce67f408b62e9cdad7.cb820d091707fb0ff42c9a92b27592d9f(c2058e9676d5f84cfbcea9658896a702d, cb98fcf04ec4a7155685c21a49b483142);
					}
				}
				c4851c76dff3c68269c2f88c388225769.cb820d091707fb0ff42c9a92b27592d9f(c2058e9676d5f84cfbcea9658896a702d, 0L);
				DeflateStream cbf979afd484fde812cf185a3a8 = cb332003c90da1aac6fd65b59893c5e56.c0a0a027f52dbb53b7a992b50e32f26b6(cbf979afd484fde812cf185a3a, CompressionMode.Decompress);
				int num4 = 1000;
				byte[] cbf979afd484fde812cf185a3a9 = new byte[num4];
				int num5;
				do
				{
					num5 = c9a34e2d11c5d0c5bb4cb0160549f9dd6.cb820d091707fb0ff42c9a92b27592d9f(cbf979afd484fde812cf185a3a8, cbf979afd484fde812cf185a3a9, 0, num4);
					if (num5 <= 0)
					{
						continue;
					}
					while (true)
					{
						switch (4)
						{
						case 0:
							continue;
						}
						break;
					}
					cd5ab067c7b0374b0997eff8fcdcead57.cb820d091707fb0ff42c9a92b27592d9f(c2058e9676d5f84cfbcea9658896a702d, cbf979afd484fde812cf185a3a9, 0, num5);
				}
				while (num5 >= num4);
				memoryStream = c2058e9676d5f84cfbcea9658896a702d;
			}
			if (memoryStream != null)
			{
				while (true)
				{
					switch (7)
					{
					case 0:
						break;
					default:
						return cbdf7d2492d8226964f6ad73c3ee201a1.cb820d091707fb0ff42c9a92b27592d9f(memoryStream);
					}
				}
			}
			byte[] array4 = new byte[cbe46e101ef999e8bef62fbc5dabe5720.cb820d091707fb0ff42c9a92b27592d9f(stream) - c53f246fd39a574cbe9866ef69a6a20ad.cb820d091707fb0ff42c9a92b27592d9f(stream)];
			c9a34e2d11c5d0c5bb4cb0160549f9dd6.cb820d091707fb0ff42c9a92b27592d9f(stream, array4, 0, array4.Length);
			return array4;
		}
	}
}
