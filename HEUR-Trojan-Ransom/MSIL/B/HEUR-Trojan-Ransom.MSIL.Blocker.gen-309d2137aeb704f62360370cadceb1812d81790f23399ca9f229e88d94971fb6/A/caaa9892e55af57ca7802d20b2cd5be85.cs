using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security.Cryptography;

namespace A;

internal class caaa9892e55af57ca7802d20b2cd5be85
{
	private static readonly object ceff0570729ee582d06aa8eaf32a386fb;

	private static readonly int ca91582f940f51a3981aa94b1fbe5cfe2;

	private static readonly int cda89e0c119753694de3cf9a56b491308;

	private static readonly MemoryStream ccb9d73315865125971070baaef072e18;

	private static readonly MemoryStream c5148f1d2689ab403c5b1641f714d001a;

	private static readonly byte c06cacdbbf6735926c0c61767fa4f94e9;

	static caaa9892e55af57ca7802d20b2cd5be85()
	{
		ccb9d73315865125971070baaef072e18 = c578530ace97255ab933e95f5cc56850b.c6488dc208507e388649de9eb5b1dd886;
		c5148f1d2689ab403c5b1641f714d001a = c578530ace97255ab933e95f5cc56850b.c6488dc208507e388649de9eb5b1dd886;
		ca91582f940f51a3981aa94b1fbe5cfe2 = int.MaxValue;
		cda89e0c119753694de3cf9a56b491308 = int.MinValue;
		ccb9d73315865125971070baaef072e18 = c80861af04860a81ac62b124e1765b997.cdb5846019249e32f391691c01d390d78(0);
		c5148f1d2689ab403c5b1641f714d001a = c80861af04860a81ac62b124e1765b997.cdb5846019249e32f391691c01d390d78(0);
		ceff0570729ee582d06aa8eaf32a386fb = c1ca1def3e7b942586dc59a350b452c9f.cdb5846019249e32f391691c01d390d78();
	}

	private static string c9a15b06ee32a27aa226e1f0a5b98e617(Assembly P_0)
	{
		string text = cef980ccee7a8d051a201b885cb91853b.c77162f228f13a3506cf10e6c077c680d(P_0);
		int num = c1765ff1947f0f416b7c40cd857e90c93.c77162f228f13a3506cf10e6c077c680d(text, ',');
		if (num >= 0)
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
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			text = cf6b87a55e8fdb40f2dbe1f784968ef4f.c77162f228f13a3506cf10e6c077c680d(text, 0, num);
		}
		return text;
	}

	private static byte[] c38644d983656411ceb266b1acabb97f7(Assembly P_0)
	{
		try
		{
			string text = cef980ccee7a8d051a201b885cb91853b.c77162f228f13a3506cf10e6c077c680d(P_0);
			int num = c2b00ec3da4b0886f3bb5b208f6f8e67c.c77162f228f13a3506cf10e6c077c680d(text, "PublicKeyToken=");
			if (num < 0)
			{
				num = c2b00ec3da4b0886f3bb5b208f6f8e67c.c77162f228f13a3506cf10e6c077c680d(text, "publickeytoken=");
			}
			if (num < 0)
			{
				while (true)
				{
					switch (3)
					{
					case 0:
						break;
					default:
						if (1 == 0)
						{
							/*OpCode not supported: LdMemberToken*/;
						}
						return c1bcee5a202d8f8975afb204b086c58f7.c6488dc208507e388649de9eb5b1dd886;
					}
				}
			}
			num += 15;
			if (ce832ac91c165a68bfd3214dc808e6e66.c77162f228f13a3506cf10e6c077c680d(text, num) != 'n')
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
				if (ce832ac91c165a68bfd3214dc808e6e66.c77162f228f13a3506cf10e6c077c680d(text, num) != 'N')
				{
					string text2 = cf6b87a55e8fdb40f2dbe1f784968ef4f.c77162f228f13a3506cf10e6c077c680d(text, num, 16);
					long num2 = c62b46f2c5a422b75567bfc4e4b2bd3ea.cdb5846019249e32f391691c01d390d78(text2, NumberStyles.HexNumber);
					byte[] array = c8346b4ef8b72ad5980c73b0d12121c39.cdb5846019249e32f391691c01d390d78(num2);
					c88bdb9f82f9d6d7471fec7d2c1016359.cdb5846019249e32f391691c01d390d78(array);
					return array;
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
			}
			return c1bcee5a202d8f8975afb204b086c58f7.c6488dc208507e388649de9eb5b1dd886;
		}
		catch
		{
		}
		return null;
	}

	internal static byte[] ceb8a4736c92336be658cc07e623270b7(Stream P_0)
	{
		object obj;
		ce5afe301b895587e41917bcafbe95de7.cdb5846019249e32f391691c01d390d78(obj = ceff0570729ee582d06aa8eaf32a386fb);
		try
		{
			return cf44b10101c61b6e8d2f2c1c04622b885(97L, P_0);
		}
		finally
		{
			c02db9497217382c4a6aec467ab1d729a.cdb5846019249e32f391691c01d390d78(obj);
		}
	}

	internal static byte[] c7e8eb5a938e48808a26d839d10c2ffcf(long P_0, Stream P_1)
	{
		try
		{
			return ceb8a4736c92336be658cc07e623270b7(P_1);
		}
		catch
		{
			return cf44b10101c61b6e8d2f2c1c04622b885(97L, P_1);
		}
	}

	internal static byte[] cf44b10101c61b6e8d2f2c1c04622b885(long P_0, object P_1)
	{
		Stream stream = c5809bca001bcab369c8d5e64bea7f6cc.ce33041ee86c61d61b9e284b4b186be07(P_1);
		Stream stream2 = stream;
		MemoryStream c6488dc208507e388649de9eb5b1dd = c578530ace97255ab933e95f5cc56850b.c6488dc208507e388649de9eb5b1dd886;
		for (int i = 1; i < 4; i++)
		{
			c24360fd5b36b3d0db4d7372ddc351c8c.c77162f228f13a3506cf10e6c077c680d(stream);
		}
		while (true)
		{
			switch (7)
			{
			case 0:
				continue;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			ushort num = (ushort)c24360fd5b36b3d0db4d7372ddc351c8c.c77162f228f13a3506cf10e6c077c680d(stream);
			num = (ushort)(~num);
			if ((num & 2u) != 0)
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
				DESCryptoServiceProvider dESCryptoServiceProvider = cb573aef1b18fb673fd3e17c1a847a35f.cdb5846019249e32f391691c01d390d78();
				byte[] array = c381628ccfd933328bdd314178b651eb0.c4500622dc42ff2dc98fed926f40f1228(8);
				c83b1b3302d7203189e5c25ecbe954477.c77162f228f13a3506cf10e6c077c680d(stream, array, 0, 8);
				cb863296722460814ae04a102e91cd389.c77162f228f13a3506cf10e6c077c680d(dESCryptoServiceProvider, array);
				byte[] array2 = c381628ccfd933328bdd314178b651eb0.c4500622dc42ff2dc98fed926f40f1228(8);
				c83b1b3302d7203189e5c25ecbe954477.c77162f228f13a3506cf10e6c077c680d(stream, array2, 0, 8);
				bool flag = true;
				byte[] array3 = array2;
				int num2 = 0;
				while (true)
				{
					if (num2 < (int)(nuint)cc69c43c74f150e4fd644ba7277e68581.ce52fc13bd0b1cfec401eb6a87239469b(array3))
					{
						if (array3[num2] != 0)
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
					array2 = c38644d983656411ceb266b1acabb97f7(c991dec4139a9f6d287bd699f90d764f8.cdb5846019249e32f391691c01d390d78());
				}
				c02632980bc754b3ec58002019d72f412.c77162f228f13a3506cf10e6c077c680d(dESCryptoServiceProvider, array2);
				if (ccb9d73315865125971070baaef072e18 == null)
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
					if (ca91582f940f51a3981aa94b1fbe5cfe2 == int.MaxValue)
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
						cb24ed069fadadc698d61b76e78f2b3f5.c77162f228f13a3506cf10e6c077c680d(ccb9d73315865125971070baaef072e18, (int)cf2ab84680e92fefd94b2fa0665ce22b4.c77162f228f13a3506cf10e6c077c680d(stream));
					}
					else
					{
						cb24ed069fadadc698d61b76e78f2b3f5.c77162f228f13a3506cf10e6c077c680d(ccb9d73315865125971070baaef072e18, ca91582f940f51a3981aa94b1fbe5cfe2);
					}
				}
				ca0417ce8a0a390505dbbb313461a5b84.c77162f228f13a3506cf10e6c077c680d(ccb9d73315865125971070baaef072e18, 0L);
				ICryptoTransform cryptoTransform = c62d6a14b92378e98f99b065e229f1b45.c77162f228f13a3506cf10e6c077c680d(dESCryptoServiceProvider);
				int num3 = c534e0fa48e92361a8e9fe23ca46f39c5.c77162f228f13a3506cf10e6c077c680d(cryptoTransform);
				c5438cd722d64f3dd9f71452a961cf98e.c77162f228f13a3506cf10e6c077c680d(cryptoTransform);
				byte[] array4 = c381628ccfd933328bdd314178b651eb0.c4500622dc42ff2dc98fed926f40f1228(c5438cd722d64f3dd9f71452a961cf98e.c77162f228f13a3506cf10e6c077c680d(cryptoTransform));
				byte[] array5 = c381628ccfd933328bdd314178b651eb0.c4500622dc42ff2dc98fed926f40f1228(c534e0fa48e92361a8e9fe23ca46f39c5.c77162f228f13a3506cf10e6c077c680d(cryptoTransform));
				int j;
				for (j = (int)c29ac6165d72c4107a02d018437530827.c77162f228f13a3506cf10e6c077c680d(stream); j + num3 < cf2ab84680e92fefd94b2fa0665ce22b4.c77162f228f13a3506cf10e6c077c680d(stream); j += num3)
				{
					c83b1b3302d7203189e5c25ecbe954477.c77162f228f13a3506cf10e6c077c680d(stream, array5, 0, num3);
					int num4 = c208c18e325f80de553c09e98c4d0c3ce.c77162f228f13a3506cf10e6c077c680d(cryptoTransform, array5, 0, num3, array4, 0);
					c5286e1deefcd02ce44ca45b6f4143d22.c77162f228f13a3506cf10e6c077c680d(ccb9d73315865125971070baaef072e18, array4, 0, num4);
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
				c83b1b3302d7203189e5c25ecbe954477.c77162f228f13a3506cf10e6c077c680d(stream, array5, 0, (int)(cf2ab84680e92fefd94b2fa0665ce22b4.c77162f228f13a3506cf10e6c077c680d(stream) - j));
				byte[] array6 = cf6c153dc642addd4b76dfb7703dcbb62.c77162f228f13a3506cf10e6c077c680d(cryptoTransform, array5, 0, (int)(cf2ab84680e92fefd94b2fa0665ce22b4.c77162f228f13a3506cf10e6c077c680d(stream) - j));
				c5286e1deefcd02ce44ca45b6f4143d22.c77162f228f13a3506cf10e6c077c680d(ccb9d73315865125971070baaef072e18, array6, 0, (int)(nuint)cc69c43c74f150e4fd644ba7277e68581.ce52fc13bd0b1cfec401eb6a87239469b(array6));
				stream2 = ccb9d73315865125971070baaef072e18;
				ca0417ce8a0a390505dbbb313461a5b84.c77162f228f13a3506cf10e6c077c680d(stream2, 0L);
				c6488dc208507e388649de9eb5b1dd = ccb9d73315865125971070baaef072e18;
			}
			if ((num & 8u) != 0)
			{
				if (c5148f1d2689ab403c5b1641f714d001a == null)
				{
					if (cda89e0c119753694de3cf9a56b491308 == int.MinValue)
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
						cb24ed069fadadc698d61b76e78f2b3f5.c77162f228f13a3506cf10e6c077c680d(c5148f1d2689ab403c5b1641f714d001a, (int)cf2ab84680e92fefd94b2fa0665ce22b4.c77162f228f13a3506cf10e6c077c680d(stream2) * 2);
					}
					else
					{
						cb24ed069fadadc698d61b76e78f2b3f5.c77162f228f13a3506cf10e6c077c680d(c5148f1d2689ab403c5b1641f714d001a, cda89e0c119753694de3cf9a56b491308);
					}
				}
				ca0417ce8a0a390505dbbb313461a5b84.c77162f228f13a3506cf10e6c077c680d(c5148f1d2689ab403c5b1641f714d001a, 0L);
				DeflateStream deflateStream = ca5cddeb79d81353e5c80d4f01b148001.cdb5846019249e32f391691c01d390d78(stream2, CompressionMode.Decompress);
				int num5 = 1000;
				byte[] array7 = c381628ccfd933328bdd314178b651eb0.c4500622dc42ff2dc98fed926f40f1228(num5);
				int num6;
				do
				{
					num6 = c83b1b3302d7203189e5c25ecbe954477.c77162f228f13a3506cf10e6c077c680d(deflateStream, array7, 0, num5);
					if (num6 <= 0)
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
					c5286e1deefcd02ce44ca45b6f4143d22.c77162f228f13a3506cf10e6c077c680d(c5148f1d2689ab403c5b1641f714d001a, array7, 0, num6);
				}
				while (num6 >= num5);
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				c6488dc208507e388649de9eb5b1dd = c5148f1d2689ab403c5b1641f714d001a;
			}
			if (c6488dc208507e388649de9eb5b1dd != null)
			{
				while (true)
				{
					switch (6)
					{
					case 0:
						break;
					default:
						return c2f35d4379accc83f94da0565155c1c1a.c77162f228f13a3506cf10e6c077c680d(c6488dc208507e388649de9eb5b1dd);
					}
				}
			}
			byte[] array8 = c381628ccfd933328bdd314178b651eb0.c4500622dc42ff2dc98fed926f40f1228((int)checked((nint)unchecked(cf2ab84680e92fefd94b2fa0665ce22b4.c77162f228f13a3506cf10e6c077c680d(stream) - c29ac6165d72c4107a02d018437530827.c77162f228f13a3506cf10e6c077c680d(stream))));
			c83b1b3302d7203189e5c25ecbe954477.c77162f228f13a3506cf10e6c077c680d(stream, array8, 0, (int)(nuint)cc69c43c74f150e4fd644ba7277e68581.ce52fc13bd0b1cfec401eb6a87239469b(array8));
			return array8;
		}
	}
}
