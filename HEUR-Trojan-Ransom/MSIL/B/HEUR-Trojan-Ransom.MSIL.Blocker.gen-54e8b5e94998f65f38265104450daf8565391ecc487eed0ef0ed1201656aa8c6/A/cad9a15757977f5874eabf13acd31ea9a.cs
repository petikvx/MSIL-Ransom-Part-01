using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security.Cryptography;

namespace A;

internal class cad9a15757977f5874eabf13acd31ea9a
{
	private static readonly object c7ce17f39183b0092efb8d80f1b48394b;

	private static readonly int c97362bc906c4df7e51ae0f4899351b4d;

	private static readonly int c1938d9c1bb1a8518aadd253fa7fe4944;

	private static readonly MemoryStream c706cf7761ab5b335e22ac9a4c83f9deb;

	private static readonly MemoryStream ce8fecbda5fc5f02bbae8d7f55c12e8d4;

	private static readonly byte c51bd1276ca8af9049cdfa06cc2d6717f;

	static cad9a15757977f5874eabf13acd31ea9a()
	{
		c706cf7761ab5b335e22ac9a4c83f9deb = c8411e5672018ce19113f97df1e3f3aeb.cca5a58b606bc5fdfdaa6a40f1314e993;
		ce8fecbda5fc5f02bbae8d7f55c12e8d4 = c8411e5672018ce19113f97df1e3f3aeb.cca5a58b606bc5fdfdaa6a40f1314e993;
		c97362bc906c4df7e51ae0f4899351b4d = int.MaxValue;
		c1938d9c1bb1a8518aadd253fa7fe4944 = int.MinValue;
		c706cf7761ab5b335e22ac9a4c83f9deb = c53c152444b220e3be8af13bb33492811.c3cc683a96c091ed21435f901d9bf9036(0);
		ce8fecbda5fc5f02bbae8d7f55c12e8d4 = c53c152444b220e3be8af13bb33492811.c3cc683a96c091ed21435f901d9bf9036(0);
		c7ce17f39183b0092efb8d80f1b48394b = c28e2ae1ef3cfb16e2cb30ca381961e0c.c3cc683a96c091ed21435f901d9bf9036();
	}

	private static string ceba5331b6cd6d156aae1b70aeb7964d7(Assembly c33a76aab2b85c965a2112fd0280a749d)
	{
		string text = c98e775df088e83df9b4fc4d3f292905e.c4a2e262fbd085be403de8e51df6b9e34(c33a76aab2b85c965a2112fd0280a749d);
		int num = c189dcd4e75a5100e1b073c928cd528a2.c4a2e262fbd085be403de8e51df6b9e34(text, ',');
		if (num >= 0)
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
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			text = c0dcf60c5069c914aaacf214ff807ba78.c4a2e262fbd085be403de8e51df6b9e34(text, 0, num);
		}
		return text;
	}

	private static byte[] c11722d29cc3222de772a96670a75c8aa(Assembly c33a76aab2b85c965a2112fd0280a749d)
	{
		try
		{
			string ce66c4d544db036b300564c888912aa6e = c98e775df088e83df9b4fc4d3f292905e.c4a2e262fbd085be403de8e51df6b9e34(c33a76aab2b85c965a2112fd0280a749d);
			int num = cfd105829a47553d7cbb7e26fd6c36321.c4a2e262fbd085be403de8e51df6b9e34(ce66c4d544db036b300564c888912aa6e, "PublicKeyToken=");
			if (num < 0)
			{
				while (true)
				{
					switch (3)
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
				num = cfd105829a47553d7cbb7e26fd6c36321.c4a2e262fbd085be403de8e51df6b9e34(ce66c4d544db036b300564c888912aa6e, "publickeytoken=");
			}
			if (num < 0)
			{
				while (true)
				{
					switch (4)
					{
					case 0:
						break;
					default:
						return c6fd1197c583112c41bfb2d17fa23cf39.cca5a58b606bc5fdfdaa6a40f1314e993;
					}
				}
			}
			num += 15;
			if (c40d9bdc61ddbb7bfbd34afabd8236af1.c4a2e262fbd085be403de8e51df6b9e34(ce66c4d544db036b300564c888912aa6e, num) != 'n')
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
				if (c40d9bdc61ddbb7bfbd34afabd8236af1.c4a2e262fbd085be403de8e51df6b9e34(ce66c4d544db036b300564c888912aa6e, num) != 'N')
				{
					string ce66c4d544db036b300564c888912aa6e2 = c0dcf60c5069c914aaacf214ff807ba78.c4a2e262fbd085be403de8e51df6b9e34(ce66c4d544db036b300564c888912aa6e, num, 16);
					long ce66c4d544db036b300564c888912aa6e3 = c2c140d8610b6328ec129c84c906f38e7.c3cc683a96c091ed21435f901d9bf9036(ce66c4d544db036b300564c888912aa6e2, NumberStyles.HexNumber);
					byte[] array = c32e60b26fba24fa274007649f6efdef0.c3cc683a96c091ed21435f901d9bf9036(ce66c4d544db036b300564c888912aa6e3);
					ce889dc7f21e3b0a6b0c5ea10a67be96b.c3cc683a96c091ed21435f901d9bf9036(array);
					return array;
				}
				while (true)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					break;
				}
			}
			return c6fd1197c583112c41bfb2d17fa23cf39.cca5a58b606bc5fdfdaa6a40f1314e993;
		}
		catch
		{
		}
		return null;
	}

	internal static byte[] c4b2dde569f0f01a3413afcde4c213e62(Stream c637a83f38a4213a8031600bc70b9c316)
	{
		object ce66c4d544db036b300564c888912aa6e;
		c61c29d8b854aa8e55d41348447333ffd.c3cc683a96c091ed21435f901d9bf9036(ce66c4d544db036b300564c888912aa6e = c7ce17f39183b0092efb8d80f1b48394b);
		try
		{
			return cccf21f959de28b871b332c2d0876b400(97L, c637a83f38a4213a8031600bc70b9c316);
		}
		finally
		{
			c345c552f9e7b21cad71a3c7b15c8f309.c3cc683a96c091ed21435f901d9bf9036(ce66c4d544db036b300564c888912aa6e);
		}
	}

	internal static byte[] c74478c8008c8c6dbef9395462fb1ed67(long c51bd1276ca8af9049cdfa06cc2d6717f, Stream c637a83f38a4213a8031600bc70b9c316)
	{
		try
		{
			return c4b2dde569f0f01a3413afcde4c213e62(c637a83f38a4213a8031600bc70b9c316);
		}
		catch
		{
			return cccf21f959de28b871b332c2d0876b400(97L, c637a83f38a4213a8031600bc70b9c316);
		}
	}

	internal static byte[] cccf21f959de28b871b332c2d0876b400(long c51bd1276ca8af9049cdfa06cc2d6717f, object ccaee87ea62331fde7713435e7d1f65a8)
	{
		Stream stream = ccf40939d2487f83b35e589c3f551f00b.cd8e02a84d6f3a75cc47264eb2bc3d19b(ccaee87ea62331fde7713435e7d1f65a8);
		Stream ce66c4d544db036b300564c888912aa6e = stream;
		MemoryStream cca5a58b606bc5fdfdaa6a40f1314e = c8411e5672018ce19113f97df1e3f3aeb.cca5a58b606bc5fdfdaa6a40f1314e993;
		for (int i = 1; i < 4; i++)
		{
			ca93b75a638af7d95d18671bab8a1837f.c4a2e262fbd085be403de8e51df6b9e34(stream);
		}
		while (true)
		{
			switch (2)
			{
			case 0:
				continue;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			ushort num = (ushort)ca93b75a638af7d95d18671bab8a1837f.c4a2e262fbd085be403de8e51df6b9e34(stream);
			num = (ushort)(~num);
			if ((num & 2u) != 0)
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
				DESCryptoServiceProvider ce66c4d544db036b300564c888912aa6e2 = c285e2f5956b3ad059430b37dd673687b.c3cc683a96c091ed21435f901d9bf9036();
				byte[] ce66c4d544db036b300564c888912aa6e3 = c04199ffe8347a3e4c66cf5aca7f8078a.c14b0fe9389c01cff3c55fc9a5b6f5649(8);
				c592f2d562525c66ec91a21dd10587b7c.c4a2e262fbd085be403de8e51df6b9e34(stream, ce66c4d544db036b300564c888912aa6e3, 0, 8);
				c6c53100364b83888a8977ec90afebee3.c4a2e262fbd085be403de8e51df6b9e34(ce66c4d544db036b300564c888912aa6e2, ce66c4d544db036b300564c888912aa6e3);
				byte[] array = c04199ffe8347a3e4c66cf5aca7f8078a.c14b0fe9389c01cff3c55fc9a5b6f5649(8);
				c592f2d562525c66ec91a21dd10587b7c.c4a2e262fbd085be403de8e51df6b9e34(stream, array, 0, 8);
				bool flag = true;
				byte[] array2 = array;
				int num2 = 0;
				while (true)
				{
					if (num2 < (int)(nuint)c620767177a92368bda08b1b06c114203.c314668365be25953c8434680343a3754(array2))
					{
						if (array2[num2] != 0)
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
							flag = false;
							break;
						}
						num2++;
						continue;
					}
					while (true)
					{
						switch (5)
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
						switch (4)
						{
						case 0:
							continue;
						}
						break;
					}
					array = c11722d29cc3222de772a96670a75c8aa(cfe67a32b3e22c0ca7104e5e130f95058.c3cc683a96c091ed21435f901d9bf9036());
				}
				cc43bc437eadd8b011a814dfcec02f4f8.c4a2e262fbd085be403de8e51df6b9e34(ce66c4d544db036b300564c888912aa6e2, array);
				if (c706cf7761ab5b335e22ac9a4c83f9deb == null)
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
					if (c97362bc906c4df7e51ae0f4899351b4d == int.MaxValue)
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
						c603a22e83adfe7ec0d07a339c1eb5c3a.c4a2e262fbd085be403de8e51df6b9e34(c706cf7761ab5b335e22ac9a4c83f9deb, (int)c7db8e7401bf942be866f23b2a274c04a.c4a2e262fbd085be403de8e51df6b9e34(stream));
					}
					else
					{
						c603a22e83adfe7ec0d07a339c1eb5c3a.c4a2e262fbd085be403de8e51df6b9e34(c706cf7761ab5b335e22ac9a4c83f9deb, c97362bc906c4df7e51ae0f4899351b4d);
					}
				}
				c7f66dbb3a3163b0cc43372ccff7acd8b.c4a2e262fbd085be403de8e51df6b9e34(c706cf7761ab5b335e22ac9a4c83f9deb, 0L);
				ICryptoTransform ce66c4d544db036b300564c888912aa6e4 = c0a13d456b63e6b9e0cb8b8792507d478.c4a2e262fbd085be403de8e51df6b9e34(ce66c4d544db036b300564c888912aa6e2);
				int num3 = c1d6ebb008db5c6753975fb385a9fdb3b.c4a2e262fbd085be403de8e51df6b9e34(ce66c4d544db036b300564c888912aa6e4);
				c6acc9f31df71fab0a4889aeee257e04e.c4a2e262fbd085be403de8e51df6b9e34(ce66c4d544db036b300564c888912aa6e4);
				byte[] ce66c4d544db036b300564c888912aa6e5 = c04199ffe8347a3e4c66cf5aca7f8078a.c14b0fe9389c01cff3c55fc9a5b6f5649(c6acc9f31df71fab0a4889aeee257e04e.c4a2e262fbd085be403de8e51df6b9e34(ce66c4d544db036b300564c888912aa6e4));
				byte[] ce66c4d544db036b300564c888912aa6e6 = c04199ffe8347a3e4c66cf5aca7f8078a.c14b0fe9389c01cff3c55fc9a5b6f5649(c1d6ebb008db5c6753975fb385a9fdb3b.c4a2e262fbd085be403de8e51df6b9e34(ce66c4d544db036b300564c888912aa6e4));
				int j;
				for (j = (int)c3a00c2512558c4d51bc016557a19ed10.c4a2e262fbd085be403de8e51df6b9e34(stream); j + num3 < c7db8e7401bf942be866f23b2a274c04a.c4a2e262fbd085be403de8e51df6b9e34(stream); j += num3)
				{
					c592f2d562525c66ec91a21dd10587b7c.c4a2e262fbd085be403de8e51df6b9e34(stream, ce66c4d544db036b300564c888912aa6e6, 0, num3);
					int ce66c4d544db036b300564c888912aa6e7 = c547ed5dfa0eaf4bd49c823a0476c0763.c4a2e262fbd085be403de8e51df6b9e34(ce66c4d544db036b300564c888912aa6e4, ce66c4d544db036b300564c888912aa6e6, 0, num3, ce66c4d544db036b300564c888912aa6e5, 0);
					c52813af88d00109de5aa53424bbc94cb.c4a2e262fbd085be403de8e51df6b9e34(c706cf7761ab5b335e22ac9a4c83f9deb, ce66c4d544db036b300564c888912aa6e5, 0, ce66c4d544db036b300564c888912aa6e7);
				}
				while (true)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					break;
				}
				c592f2d562525c66ec91a21dd10587b7c.c4a2e262fbd085be403de8e51df6b9e34(stream, ce66c4d544db036b300564c888912aa6e6, 0, (int)(c7db8e7401bf942be866f23b2a274c04a.c4a2e262fbd085be403de8e51df6b9e34(stream) - j));
				byte[] ce66c4d544db036b300564c888912aa6e8 = c53ecd1b38e65a6330f931a2f2b31daf4.c4a2e262fbd085be403de8e51df6b9e34(ce66c4d544db036b300564c888912aa6e4, ce66c4d544db036b300564c888912aa6e6, 0, (int)(c7db8e7401bf942be866f23b2a274c04a.c4a2e262fbd085be403de8e51df6b9e34(stream) - j));
				c52813af88d00109de5aa53424bbc94cb.c4a2e262fbd085be403de8e51df6b9e34(c706cf7761ab5b335e22ac9a4c83f9deb, ce66c4d544db036b300564c888912aa6e8, 0, (int)(nuint)c620767177a92368bda08b1b06c114203.c314668365be25953c8434680343a3754(ce66c4d544db036b300564c888912aa6e8));
				ce66c4d544db036b300564c888912aa6e = c706cf7761ab5b335e22ac9a4c83f9deb;
				c7f66dbb3a3163b0cc43372ccff7acd8b.c4a2e262fbd085be403de8e51df6b9e34(ce66c4d544db036b300564c888912aa6e, 0L);
				cca5a58b606bc5fdfdaa6a40f1314e = c706cf7761ab5b335e22ac9a4c83f9deb;
			}
			if ((num & 8u) != 0)
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
				if (ce8fecbda5fc5f02bbae8d7f55c12e8d4 == null)
				{
					while (true)
					{
						switch (3)
						{
						case 0:
							continue;
						}
						break;
					}
					if (c1938d9c1bb1a8518aadd253fa7fe4944 == int.MinValue)
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
						c603a22e83adfe7ec0d07a339c1eb5c3a.c4a2e262fbd085be403de8e51df6b9e34(ce8fecbda5fc5f02bbae8d7f55c12e8d4, (int)c7db8e7401bf942be866f23b2a274c04a.c4a2e262fbd085be403de8e51df6b9e34(ce66c4d544db036b300564c888912aa6e) * 2);
					}
					else
					{
						c603a22e83adfe7ec0d07a339c1eb5c3a.c4a2e262fbd085be403de8e51df6b9e34(ce8fecbda5fc5f02bbae8d7f55c12e8d4, c1938d9c1bb1a8518aadd253fa7fe4944);
					}
				}
				c7f66dbb3a3163b0cc43372ccff7acd8b.c4a2e262fbd085be403de8e51df6b9e34(ce8fecbda5fc5f02bbae8d7f55c12e8d4, 0L);
				DeflateStream ce66c4d544db036b300564c888912aa6e9 = c084fe051411185d0080dd411c5d63522.c3cc683a96c091ed21435f901d9bf9036(ce66c4d544db036b300564c888912aa6e, CompressionMode.Decompress);
				int num4 = 1000;
				byte[] ce66c4d544db036b300564c888912aa6e10 = c04199ffe8347a3e4c66cf5aca7f8078a.c14b0fe9389c01cff3c55fc9a5b6f5649(num4);
				int num5;
				do
				{
					num5 = c592f2d562525c66ec91a21dd10587b7c.c4a2e262fbd085be403de8e51df6b9e34(ce66c4d544db036b300564c888912aa6e9, ce66c4d544db036b300564c888912aa6e10, 0, num4);
					if (num5 <= 0)
					{
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
					c52813af88d00109de5aa53424bbc94cb.c4a2e262fbd085be403de8e51df6b9e34(ce8fecbda5fc5f02bbae8d7f55c12e8d4, ce66c4d544db036b300564c888912aa6e10, 0, num5);
				}
				while (num5 >= num4);
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				cca5a58b606bc5fdfdaa6a40f1314e = ce8fecbda5fc5f02bbae8d7f55c12e8d4;
			}
			if (cca5a58b606bc5fdfdaa6a40f1314e != null)
			{
				while (true)
				{
					switch (1)
					{
					case 0:
						break;
					default:
						return c0d940bbbdb24f6c5b4eee16241d99efa.c4a2e262fbd085be403de8e51df6b9e34(cca5a58b606bc5fdfdaa6a40f1314e);
					}
				}
			}
			byte[] array3 = c04199ffe8347a3e4c66cf5aca7f8078a.c14b0fe9389c01cff3c55fc9a5b6f5649((int)checked((nint)unchecked(c7db8e7401bf942be866f23b2a274c04a.c4a2e262fbd085be403de8e51df6b9e34(stream) - c3a00c2512558c4d51bc016557a19ed10.c4a2e262fbd085be403de8e51df6b9e34(stream))));
			c592f2d562525c66ec91a21dd10587b7c.c4a2e262fbd085be403de8e51df6b9e34(stream, array3, 0, (int)(nuint)c620767177a92368bda08b1b06c114203.c314668365be25953c8434680343a3754(array3));
			return array3;
		}
	}
}
