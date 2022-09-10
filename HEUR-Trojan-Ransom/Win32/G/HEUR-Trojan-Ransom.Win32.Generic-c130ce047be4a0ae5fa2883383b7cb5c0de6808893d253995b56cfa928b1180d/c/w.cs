using System;
using System.IO;
using System.Security;
using System.Security.Cryptography;

namespace c;

internal sealed class w
{
	public static byte[] c(byte[] byte_0)
	{
		char[] k = e.e.k;
		int[] x = default(int[]);
		while (true)
		{
			int num = 693401934;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1C90863Eu) % 3u)
				{
				case 1u:
					goto IL_0008;
				case 2u:
					break;
				default:
				{
					IDisposable disposable = h.g(y.g);
					Array array;
					try
					{
						IDisposable disposable2 = d.o(h.g(y.g), '\u0378', 795);
						try
						{
							object obj = w.smethod_0();
							try
							{
								array = global::c.p.c(new t(byte_0, w.smethod_0(), d.o(h.g(y.g), 'ñ', 146)));
							}
							finally
							{
								int num3 = 3;
								while (true)
								{
									IL_0149:
									int num4 = 1720567500;
									while (true)
									{
										int num5;
										switch ((num2 = (uint)num4 ^ 0x1C90863Eu) % 6u)
										{
										case 4u:
											switch (num3)
											{
											default:
												num4 = 770446331;
												continue;
											case 0:
											case 3:
											case 5:
												break;
											case 1:
											case 2:
												w.smethod_1((IDisposable)(obj as MemoryStream));
												goto end_IL_0120;
											case 4:
												goto end_IL_0120;
											}
											goto case 3u;
										case 3u:
										{
											int num6;
											if ((MemoryStream)obj != null)
											{
												num4 = 1266348629;
												num6 = 1266348629;
											}
											else
											{
												num4 = 1720042106;
												num6 = 1720042106;
											}
											continue;
										}
										case 2u:
											num4 = ((int)num2 * -161894709) ^ -555317962;
											continue;
										case 1u:
											num5 = x[194] - 5280;
											goto IL_0108;
										default:
											num5 = x[151] - 15451;
											goto IL_0108;
										case 5u:
											break;
											IL_0108:
											num3 = num5;
											num4 = 870196368;
											continue;
										}
										goto IL_0149;
										continue;
										end_IL_0120:
										break;
									}
									break;
								}
							}
						}
						finally
						{
							int num7 = 1;
							while (true)
							{
								IL_01f8:
								int num8 = 497032459;
								while (true)
								{
									int num9;
									switch ((num2 = (uint)num8 ^ 0x1C90863Eu) % 6u)
									{
									case 5u:
										switch (num7)
										{
										default:
											num8 = 547565540;
											continue;
										case 1:
											break;
										case 0:
										case 3:
										case 5:
											w.smethod_1((IDisposable)(disposable2 as ICryptoTransform));
											goto end_IL_01cf;
										case 2:
										case 4:
											goto end_IL_01cf;
										}
										goto case 0u;
									case 0u:
									{
										int num10;
										if ((ICryptoTransform)disposable2 == null)
										{
											num8 = 2033171280;
											num10 = 2033171280;
										}
										else
										{
											num8 = 595582908;
											num10 = 595582908;
										}
										continue;
									}
									default:
										num9 = 2;
										goto IL_01ae;
									case 2u:
										num9 = x[82] - x[82];
										goto IL_01ae;
									case 1u:
										num8 = (int)((num2 * 26632781) ^ 0x58364C96);
										continue;
									case 3u:
										break;
										IL_01ae:
										num7 = num9;
										num8 = 52802223;
										continue;
									}
									goto IL_01f8;
									continue;
									end_IL_01cf:
									break;
								}
								break;
							}
						}
					}
					finally
					{
						int num11 = 2;
						while (true)
						{
							IL_029c:
							int num12 = 1616111064;
							while (true)
							{
								int num13;
								switch ((num2 = (uint)num12 ^ 0x1C90863Eu) % 5u)
								{
								default:
									num13 = 0;
									goto IL_0215;
								case 3u:
									switch (num11)
									{
									default:
										num12 = 862876363;
										continue;
									case 2:
									case 3:
									case 4:
										break;
									case 1:
									case 5:
										w.smethod_1((IDisposable)(SymmetricAlgorithm)disposable);
										goto end_IL_0274;
									case 0:
										goto end_IL_0274;
									}
									goto case 0u;
								case 0u:
								{
									int num14;
									if ((SymmetricAlgorithm)disposable == null)
									{
										num12 = 2074097202;
										num14 = 2074097202;
									}
									else
									{
										num12 = 1492974201;
										num14 = 1492974201;
									}
									continue;
								}
								case 1u:
									num13 = k[508] - 25440;
									goto IL_0215;
								case 2u:
									break;
									IL_0215:
									num11 = num13;
									num12 = 1616111064;
									continue;
								}
								goto IL_029c;
								continue;
								end_IL_0274:
								break;
							}
							break;
						}
					}
					return (byte[])array;
				}
				}
				break;
				IL_0008:
				x = l.x;
				num = (int)((num2 * 387072980) ^ 0x5D3C1E7F);
			}
		}
	}

	[SecuritySafeCritical]
	internal static int p(int int_0, int int_1, short short_0, int int_2)
	{
		int[] x = l.x;
		int result = default(int);
		char[] k = default(char[]);
		int num5 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = -1386000567;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xF3DF2CB0u) % 10u)
				{
				case 9u:
					while (true)
					{
						switch (num4)
						{
						case 3:
						case 4:
						case 8:
							result = w.smethod_2(int_0, int_1);
							num4 = k[74] - 1223;
							continue;
						case 6:
							result = int_2;
							num4 = k[510] - 62377;
							continue;
						case 5:
							num4 = x[91] - 7719;
							continue;
						case 1:
							goto IL_007f;
						case 7:
							num4 = 11;
							goto IL_0097;
						case 2:
						case 10:
							goto IL_008e;
						case 11:
							goto IL_0097;
						case 9:
							num5++;
							e.e.k[73] = (char)((e.e.k[73] ^ e.e.k[261]) & 'ì');
							num4 = 0;
							goto case 0;
						case 0:
							return result;
						}
						break;
					}
					num = -47907229;
					continue;
				case 2u:
					goto IL_007f;
				case 1u:
					goto IL_008e;
				case 4u:
					goto IL_0097;
				default:
					num3 = x[98] - 54164;
					goto IL_00ba;
				case 8u:
					num4 = x[106] - 18221;
					num = (int)(num2 * 232270955) ^ -713930577;
					continue;
				case 7u:
					num3 = 6;
					goto IL_00ba;
				case 6u:
					num = ((int)num2 * -1818783697) ^ -975932368;
					continue;
				case 5u:
					k = e.e.k;
					num = (int)((num2 * 1875287055) ^ 0x1F986AA1);
					continue;
				case 0u:
					break;
					IL_008e:
					num4 = 1;
					num = -545108081;
					continue;
					IL_0097:
					switch (((int_2 ^ short_0) - 97) ^ num5)
					{
					default:
						num = -1282622985;
						continue;
					case 0:
						break;
					}
					goto default;
					IL_00ba:
					num4 = num3;
					num = -545108081;
					continue;
					IL_007f:
					num5 = 0;
					num = -2020937264;
					continue;
				}
				break;
			}
		}
	}

	static MemoryStream smethod_0()
	{
		return new MemoryStream();
	}

	static void smethod_1(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static int smethod_2(int int_0, int int_1)
	{
		return Math.Max(int_0, int_1);
	}
}
