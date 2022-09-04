using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.IO.Packaging;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;

internal sealed class _003F8_003F
{
	internal sealed class _003F9_003F
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 86)]
		private struct _003F10_003F
		{
		}

		private static readonly char[] ㅔ_2786筱齂_0EA6ⱛव뮆;

		private static readonly char[] 퐧_F614_ABFE䑰_2245䇅앦鳌;

		private static readonly string[] 䞑ꘄ럒좓ꀛᲒ_F03E缒;

		internal static _003F10_003F _E003/* Not supported: data(00 00 28 00 00 00 0B 2A 8B 09 88 3D 4D 2A 2C 13 BF 1C 1B 2E 98 2A 0A 2A FD 09 F6 3D 38 2A 5E 13 BB 1C 69 2E 90 2A 0B 2A 8C 09 F6 3D 3C 2A 5C 13 BE 1C 1D 2E E3 2A 7C 2A 8D 09 F6 3D 3C 2A 59 13 B7 1C 18 2E 91 2A 71 2A FD 09 FB 3D 48 2A 2B 13 BE 1C 19 2E 97 2A) */;

		static _003F9_003F()
		{
			//Discarded unreachable code: IL_0103, IL_0171
			//IL_0108: Incompatible stack heights: 0 vs 1
			//IL_010d: Incompatible stack heights: 0 vs 1
			//IL_0112: Incompatible stack heights: 0 vs 1
			//IL_0117: Incompatible stack heights: 0 vs 1
			//IL_011c: Incompatible stack heights: 0 vs 3
			//IL_0126: Incompatible stack heights: 0 vs 3
			_ = 0;
			int num = (int)/*Error near IL_00f7: Stack underflow*/;
			char[] array = default(char[]);
			while (true)
			{
				switch (/*Error near IL_00e1: Stack underflow*/)
				{
				default:
					_003F51_003F._003F131_003F(new char[43], (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					퐧_F614_ABFE䑰_2245䇅앦鳌 = (char[])/*Error near IL_00a7: Stack underflow*/;
					_ = new char[8];
					array = (char[])/*Error near IL_0090: Stack underflow*/;
					_ = 2;
					_ = 15822;
					((short[])/*Error near IL_007d: Stack underflow*/)[/*Error near IL_007d: Stack underflow*/] = (short)/*Error near IL_007d: Stack underflow*/;
					num = 2;
					break;
				case 1L:
				case 2L:
				case 5L:
					_ = 5;
					_ = 7310;
					((short[])/*Error near IL_0063: Stack underflow*/)[/*Error near IL_0063: Stack underflow*/] = (short)/*Error near IL_0063: Stack underflow*/;
					array[0] = '⩉';
					array[6] = '⸫';
					num = 4;
					break;
				case 4L:
					array[3] = '⨌';
					array[7] = '⪡';
					goto case 3L;
				case 3L:
					array[1] = 'স';
					num = 6;
					break;
				case 6L:
					array[4] = 'ጟ';
					䞑ꘄ럒좓ꀛᲒ_F03E缒 = new string[1];
					ㅔ_2786筱齂_0EA6ⱛव뮆 = array;
					return;
				}
			}
		}

		internal static string _003F77_003F(int _003F77_003F, int _003F77_003F)
		{
			//IL_019b: Incompatible stack heights: 0 vs 1
			//IL_01a0: Incompatible stack heights: 0 vs 1
			//IL_01aa: Incompatible stack heights: 0 vs 1
			//IL_01af: Incompatible stack heights: 0 vs 1
			//IL_01b4: Incompatible stack heights: 0 vs 1
			//IL_01be: Incompatible stack heights: 0 vs 1
			string text = default(string);
			int num5 = default(int);
			char[] array2 = default(char[]);
			char[] array3 = default(char[]);
			int num6 = default(int);
			int num4 = default(int);
			while (true)
			{
				_ = _003F77_003F ^ 0x73120A0E ^ _003F77_003F;
				int num = (int)/*Error near IL_00ff: Stack underflow*/;
				_ = 퐧_F614_ABFE䑰_2245䇅앦鳌;
				char[] array = (char[])/*Error near IL_00e5: Stack underflow*/;
				_ = array[num];
				int num2 = (int)/*Error near IL_00ba: Stack underflow*/;
				int num3 = 13;
				while (true)
				{
					switch (/*Error near IL_018a: Stack underflow*/)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num3 = 3;
						continue;
					case 3L:
						break;
					case 13L:
						text = 䞑ꘄ럒좓ꀛᲒ_F03E缒[num2];
						num3 = (((int)/*Error near IL_01dc: Stack underflow*/ == 0) ? 7 : 9);
						continue;
					case 9L:
						return text;
					case 7L:
						num5 = array[num + 1];
						num5 = (int)((uint)array[num + 2] << 16) + num5;
						num3 = 8;
						continue;
					case 8L:
						array2 = new char[num5];
						array3 = ㅔ_2786筱齂_0EA6ⱛव뮆;
						num6 = array3.Length;
						num += 3;
						num3 = 5;
						continue;
					case 5L:
						num4 = 0;
						num3 = 10;
						continue;
					case 12L:
						array2[num4] = (char)(array[num + num4] ^ array3[(num4 + num2) % num6]);
						num3 = 11;
						continue;
					case 11L:
						num4 = 1 + num4;
						num3 = 10;
						continue;
					case 0L:
					case 10L:
						num3 = ((num4 < num5) ? 12 : 4);
						continue;
					case 4L:
						text = _003F31_003F._003F110_003F(array2);
						䞑ꘄ럒좓ꀛᲒ_F03E缒[num2] = text;
						goto case 1L;
					case 1L:
						return text;
					}
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static Stream _003F79_003F(Assembly _003F77_003F, string _003F77_003F, int _003F77_003F, int _003F77_003F)
		{
			//IL_0094: Incompatible stack heights: 0 vs 1
			while (true)
			{
				int num = (_003F77_003F ^ _003F77_003F) switch
				{
					100 => 7, 
					101 => 4, 
					_ => 5, 
				};
				while (true)
				{
					switch (/*Error near IL_0059: Stack underflow*/)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 2;
						continue;
					case 2L:
						break;
					case 5L:
					case 8L:
						num = 2;
						continue;
					case 1L:
					case 7L:
						return _003F52_003F._003F132_003F(_003F77_003F, _003F77_003F);
					case 4L:
					case 6L:
						return _003F52_003F._003F132_003F(_003F77_003F, _003F77_003F);
					case 0L:
						num = 2;
						continue;
					}
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static Type _003F80_003F(Exception _003F77_003F, int _003F77_003F, int _003F77_003F)
		{
			//IL_007d: Incompatible stack heights: 0 vs 1
			while (true)
			{
				int num = (_003F77_003F ^ _003F77_003F) switch
				{
					81 => 0, 
					_ => 2, 
				};
				while (true)
				{
					switch (/*Error near IL_0051: Stack underflow*/)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 7;
						continue;
					case 1L:
					case 7L:
						break;
					case 2L:
						num = 7;
						continue;
					case 0L:
					case 4L:
						return _003F53_003F._003F133_003F(_003F77_003F);
					case 3L:
						num = 7;
						continue;
					}
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static string _003F81_003F(int _003F77_003F, int _003F77_003F)
		{
			//IL_007c: Incompatible stack heights: 0 vs 1
			while (true)
			{
				int num = (_003F77_003F ^ _003F77_003F) switch
				{
					78 => 2, 
					_ => 3, 
				};
				while (true)
				{
					switch (/*Error near IL_0051: Stack underflow*/)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 5;
						continue;
					case 5L:
						break;
					case 3L:
						num = 5;
						continue;
					case 0L:
					case 2L:
					case 6L:
						return _003F54_003F._003F134_003F();
					case 7L:
						num = 5;
						continue;
					}
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static Stream _003F82_003F(PackagePart _003F77_003F, int _003F77_003F, int _003F77_003F)
		{
			//IL_007d: Incompatible stack heights: 0 vs 1
			while (true)
			{
				int num = (_003F77_003F ^ _003F77_003F) switch
				{
					22 => 5, 
					_ => 3, 
				};
				while (true)
				{
					switch (/*Error near IL_0051: Stack underflow*/)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 6;
						continue;
					case 6L:
						break;
					case 3L:
					case 7L:
						num = 6;
						continue;
					case 2L:
					case 4L:
					case 5L:
						return _003F55_003F._003F135_003F(_003F77_003F);
					case 0L:
						num = 6;
						continue;
					}
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static void _003F83_003F(AppDomain _003F77_003F, ResolveEventHandler _003F77_003F, int _003F77_003F, int _003F77_003F)
		{
			//Discarded unreachable code: IL_0037, IL_0060, IL_007a, IL_0085, IL_008c, IL_00aa, IL_00b4, IL_00be
			//IL_0091: Incompatible stack heights: 0 vs 1
			//IL_0096: Incompatible stack heights: 0 vs 1
			_ = 3;
			int num = (int)/*Error near IL_0080: Stack underflow*/;
			while (true)
			{
				switch (/*Error near IL_005b: Stack underflow*/)
				{
				default:
					num = (_003F77_003F ^ _003F77_003F) switch
					{
						89 => 1, 
						_ => 0, 
					};
					break;
				case 0L:
					num = 3;
					break;
				case 1L:
				case 2L:
				case 4L:
				case 5L:
					_003F50_003F._003F130_003F(_003F77_003F, _003F77_003F);
					return;
				}
			}
		}
	}

	private static bool ㅔ_2786筱齂_0EA6ⱛव뮆;

	[SecuritySafeCritical]
	static _003F8_003F()
	{
		//Discarded unreachable code: IL_0006, IL_0010
		_003F85_003F();
	}

	internal static Assembly _003F77_003F(object _003F77_003F, ResolveEventArgs _003F77_003F)
	{
		//IL_001b: Incompatible stack heights: 0 vs 1
		//IL_002f: Incompatible stack heights: 0 vs 1
		//IL_0078: Incompatible stack heights: 0 vs 1
		//IL_0096: Incompatible stack heights: 1 vs 0
		//IL_009b: Incompatible stack heights: 0 vs 1
		//IL_00b7: Incompatible stack heights: 0 vs 1
		//IL_00c7: Incompatible stack heights: 0 vs 1
		//IL_00ed: Incompatible stack heights: 0 vs 1
		//IL_01ec: Incompatible stack heights: 1 vs 0
		//IL_01f1: Incompatible stack heights: 0 vs 1
		//IL_02f6: Incompatible stack heights: 1 vs 0
		//IL_02fb: Incompatible stack heights: 0 vs 1
		//IL_03b8: Incompatible stack heights: 1 vs 0
		//IL_03bd: Incompatible stack heights: 0 vs 1
		//IL_0416: Incompatible stack heights: 1 vs 0
		//IL_041b: Incompatible stack heights: 0 vs 1
		//IL_05af: Incompatible stack heights: 1 vs 0
		//IL_05b4: Incompatible stack heights: 0 vs 1
		//IL_06c1: Incompatible stack heights: 1 vs 0
		//IL_06c6: Incompatible stack heights: 0 vs 1
		string text2 = default(string);
		string _003F167_003F = default(string);
		string text3 = default(string);
		AppDomain appDomain = default(AppDomain);
		Dictionary<string, string> dictionary = default(Dictionary<string, string>);
		Assembly assembly2 = default(Assembly);
		Stream stream = default(Stream);
		byte[] array = default(byte[]);
		int num8 = default(int);
		int num6 = default(int);
		MemoryStream memoryStream = default(MemoryStream);
		byte[] array2 = default(byte[]);
		int num3 = default(int);
		Assembly assembly = default(Assembly);
		string[] array3 = default(string[]);
		int num7 = default(int);
		while (true)
		{
			_003F11_003F._003F12_003F._003F77_003F(_003F11_003F._003F77_003F(_003F77_003F, 71, 54), _003F11_003F._003F12_003F._003F13_003F._003F77_003F(545, 534), 377, 341);
			if ((int)/*Error near IL_0588: Stack underflow*/ != 0)
			{
			}
			else
			{
				_ = 5;
			}
			int num = 16;
			while (true)
			{
				int num5;
				switch (/*Error near IL_0699: Stack underflow*/)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 0;
					continue;
				case 0L:
					break;
				case 16L:
					return null;
				case 5L:
				case 8L:
					_003F9_003F._003F77_003F(1930562063, 1);
					text2 = (string)/*Error near IL_0525: Stack underflow*/;
					_003F167_003F = (string)/*Error near IL_0500: Stack underflow*/;
					_003F79_003F(_003F167_003F, '1', 468, 403);
					text3 = (string)/*Error near IL_04d6: Stack underflow*/;
					num = 6;
					continue;
				case 6L:
					appDomain = _003F80_003F(159, 140);
					dictionary = (Dictionary<string, string>)_003F11_003F._003F12_003F._003F79_003F(appDomain, text3, 965, 986);
					num = 19;
					continue;
				case 19L:
					if (dictionary == null)
					{
						num = 11;
						continue;
					}
					goto IL_05cb;
				case 11L:
					dictionary = new Dictionary<string, string>();
					_003F82_003F(appDomain, text3, dictionary, 652, 694);
					num = 15;
					continue;
				case 15L:
					assembly2 = _003F11_003F._003F12_003F._003F13_003F._003F77_003F(152, 160);
					stream = _003F9_003F._003F79_003F(assembly2, text2, 40, 77);
					num = 18;
					continue;
				case 18L:
					if (stream == null)
					{
					}
					else
					{
						_ = 4;
					}
					num = 17;
					continue;
				case 17L:
					return null;
				case 4L:
					array = new byte[_003F11_003F._003F80_003F(stream, 239, 183) - 1];
					goto case 9L;
				case 9L:
					num = 10;
					continue;
				case 10L:
					num8 = _003F11_003F._003F12_003F._003F80_003F(stream, 171, 191);
					_003F11_003F._003F12_003F._003F13_003F._003F79_003F(stream, array, 0, array.Length, 557, 521);
					num = 14;
					continue;
				case 14L:
					num6 = 0;
					num = 1;
					continue;
				case 13L:
					array[num6] ^= (byte)((num6 + num8) & 0xFF);
					num = 12;
					continue;
				case 12L:
					num6++;
					num = 1;
					continue;
				case 1L:
					if (num6 >= array.Length)
					{
					}
					else
					{
						_ = 13;
					}
					num = 3;
					continue;
				case 3L:
					memoryStream = _003F28_003F._003F107_003F();
					goto case 7L;
				case 7L:
					{
						DeflateStream deflateStream = _003F30_003F._003F109_003F(_003F29_003F._003F108_003F(array), CompressionMode.Decompress, _003F167_003F: true);
						try
						{
							int num2 = 7;
							while (true)
							{
								switch (num2)
								{
								default:
									array2 = new byte[1024];
									goto case 6;
								case 6:
									num2 = 4;
									continue;
								case 1:
								case 2:
									_003F84_003F(memoryStream, array2, 0, num3, 410, 497);
									break;
								case 4:
								case 5:
									break;
								case 3:
									goto end_IL_031a;
								}
								if ((num3 = _003F11_003F._003F12_003F._003F13_003F._003F79_003F(deflateStream, array2, 0, array2.Length, 407, 434)) <= 0)
								{
								}
								else
								{
									_ = 2;
								}
								num2 = 3;
								continue;
								end_IL_031a:
								break;
							}
						}
						finally
						{
							int num4 = 0;
							while (true)
							{
								switch (num4)
								{
								default:
									if (deflateStream != null)
									{
									}
									else
									{
										_ = 2;
									}
									goto IL_03ff;
								case 4:
									((IDisposable)deflateStream).Dispose();
									break;
								case 2:
									break;
								}
								break;
								IL_03ff:
								num4 = 4;
							}
						}
						num5 = 5;
						goto IL_042b;
					}
					IL_05cb:
					assembly = (Assembly)_003F42_003F._003F121_003F(appDomain, _003F167_003F);
					num5 = 3;
					goto IL_042b;
					IL_042b:
					while (true)
					{
						switch (num5)
						{
						default:
							assembly = _003F39_003F._003F118_003F(_003F83_003F(memoryStream, 211, 239), null, _003F38_003F._003F117_003F(assembly2));
							goto case 10;
						case 10:
							num5 = 0;
							continue;
						case 0:
							_003F40_003F._003F119_003F(appDomain, _003F167_003F, assembly);
							array3 = _003F41_003F._003F120_003F(assembly);
							num7 = 0;
							num5 = 7;
							continue;
						case 2:
						{
							string text = array3[num7];
							dictionary[text] = text;
							num7++;
							num5 = 7;
							continue;
						}
						case 7:
							if (num7 >= array3.Length)
							{
							}
							else
							{
								_ = 2;
							}
							num5 = 1;
							continue;
						case 1:
						case 4:
							num5 = 3;
							continue;
						case 6:
							break;
						case 3:
						case 11:
							if (dictionary.ContainsKey(_003F36_003F._003F115_003F(_003F77_003F)))
							{
							}
							else
							{
								_ = 9;
							}
							num5 = 8;
							continue;
						case 8:
							return assembly;
						case 9:
							return null;
						}
						break;
					}
					goto IL_05cb;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string _003F79_003F(object _003F77_003F, object _003F77_003F, int _003F77_003F, int _003F77_003F)
	{
		//IL_0094: Incompatible stack heights: 0 vs 1
		while (true)
		{
			int num = (_003F77_003F ^ _003F77_003F) switch
			{
				71 => 6, 
				72 => 2, 
				_ => 7, 
			};
			while (true)
			{
				switch (/*Error near IL_0059: Stack underflow*/)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 8;
					continue;
				case 8L:
					break;
				case 7L:
					num = 8;
					continue;
				case 5L:
				case 6L:
					return _003F43_003F._003F122_003F(_003F77_003F, _003F77_003F);
				case 0L:
				case 2L:
				case 4L:
					return _003F43_003F._003F122_003F(_003F77_003F, _003F77_003F);
				case 1L:
					num = 8;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static AppDomain _003F80_003F(int _003F77_003F, int _003F77_003F)
	{
		//IL_0090: Incompatible stack heights: 0 vs 1
		while (true)
		{
			int num = (_003F77_003F ^ _003F77_003F) switch
			{
				19 => 6, 
				20 => 5, 
				_ => 7, 
			};
			while (true)
			{
				switch (/*Error near IL_0059: Stack underflow*/)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 2;
					continue;
				case 2L:
				case 8L:
					break;
				case 7L:
					num = 2;
					continue;
				case 6L:
					return _003F44_003F._003F123_003F();
				case 0L:
				case 1L:
				case 5L:
					return _003F44_003F._003F123_003F();
				case 3L:
					num = 2;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Assembly _003F81_003F(Type _003F77_003F, int _003F77_003F, int _003F77_003F)
	{
		//IL_007d: Incompatible stack heights: 0 vs 1
		while (true)
		{
			int num = (_003F77_003F ^ _003F77_003F) switch
			{
				24 => 3, 
				_ => 0, 
			};
			while (true)
			{
				switch (/*Error near IL_0051: Stack underflow*/)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 5;
					continue;
				case 4L:
				case 5L:
					break;
				case 0L:
					num = 5;
					continue;
				case 3L:
					return _003F45_003F._003F124_003F(_003F77_003F);
				case 1L:
				case 6L:
				case 7L:
					num = 5;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void _003F82_003F(AppDomain _003F77_003F, string _003F77_003F, object _003F77_003F, int _003F77_003F, int _003F77_003F)
	{
		//Discarded unreachable code: IL_003d, IL_0066, IL_0084, IL_008f, IL_009f, IL_00bd, IL_00c7, IL_00d1
		//IL_00a4: Incompatible stack heights: 0 vs 1
		//IL_00a9: Incompatible stack heights: 0 vs 1
		_ = 2;
		int num = (int)/*Error near IL_008a: Stack underflow*/;
		while (true)
		{
			switch (/*Error near IL_0061: Stack underflow*/)
			{
			case 1L:
				num = 2;
				continue;
			case 3L:
				_003F40_003F._003F119_003F(_003F77_003F, _003F77_003F, _003F77_003F);
				return;
			}
			int num2;
			switch (_003F77_003F ^ _003F77_003F)
			{
			default:
				num2 = 1;
				goto IL_0021;
			case 58:
				num2 = 3;
				goto IL_0021;
			case 59:
				{
					_003F40_003F._003F119_003F(_003F77_003F, _003F77_003F, _003F77_003F);
					return;
				}
				IL_0021:
				num = num2;
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static byte[] _003F83_003F(MemoryStream _003F77_003F, int _003F77_003F, int _003F77_003F)
	{
		//IL_0092: Incompatible stack heights: 0 vs 1
		while (true)
		{
			int num = (_003F77_003F ^ _003F77_003F) switch
			{
				59 => 7, 
				60 => 3, 
				_ => 8, 
			};
			while (true)
			{
				switch (/*Error near IL_0059: Stack underflow*/)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 2;
					continue;
				case 2L:
					break;
				case 8L:
					num = 2;
					continue;
				case 1L:
				case 4L:
				case 7L:
					return _003F46_003F._003F125_003F(_003F77_003F);
				case 3L:
					return _003F46_003F._003F125_003F(_003F77_003F);
				case 6L:
					num = 2;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void _003F84_003F(Stream _003F77_003F, byte[] _003F77_003F, int _003F77_003F, int _003F77_003F, int _003F77_003F, int _003F77_003F)
	{
		//Discarded unreachable code: IL_003f, IL_0068, IL_0086, IL_0091, IL_00a2, IL_00c0, IL_00ca, IL_00d4
		//IL_00a7: Incompatible stack heights: 0 vs 1
		//IL_00ac: Incompatible stack heights: 0 vs 1
		_ = 1;
		int num = (int)/*Error near IL_008c: Stack underflow*/;
		while (true)
		{
			switch (/*Error near IL_0063: Stack underflow*/)
			{
			case 2L:
			case 4L:
				num = 1;
				continue;
			case 0L:
			case 5L:
				_003F47_003F._003F126_003F(_003F77_003F, _003F77_003F, _003F77_003F, _003F77_003F);
				return;
			case 3L:
				return;
			}
			int num2;
			switch (_003F77_003F ^ _003F77_003F)
			{
			default:
				num2 = 2;
				goto IL_0022;
			case 107:
				num2 = 5;
				goto IL_0022;
			case 108:
				{
					_003F47_003F._003F126_003F(_003F77_003F, _003F77_003F, _003F77_003F, _003F77_003F);
					return;
				}
				IL_0022:
				num = num2;
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void _003F85_003F()
	{
		//Discarded unreachable code: IL_01b0
		//IL_000b: Incompatible stack heights: 0 vs 1
		//IL_001b: Incompatible stack heights: 0 vs 1
		//IL_002f: Incompatible stack heights: 0 vs 1
		//IL_00a1: Incompatible stack heights: 1 vs 0
		//IL_00a6: Incompatible stack heights: 0 vs 1
		_ = 3;
		int num = (int)/*Error near IL_018f: Stack underflow*/;
		while (true)
		{
			switch (/*Error near IL_0159: Stack underflow*/)
			{
			default:
				_ = ㅔ_2786筱齂_0EA6ⱛव뮆;
				if ((int)/*Error near IL_0104: Stack underflow*/ != 0)
				{
					return;
				}
				break;
			case 1L:
			case 2L:
			case 4L:
			{
				Type _003F167_003F;
				_003F49_003F._003F128_003F(_003F167_003F = _003F48_003F._003F127_003F(typeof(_003F8_003F).TypeHandle));
				try
				{
					int num2 = 0;
					while (true)
					{
						switch (num2)
						{
						default:
							if (!ㅔ_2786筱齂_0EA6ⱛव뮆)
							{
							}
							else
							{
								_ = 1;
							}
							num2 = 2;
							continue;
						case 2:
						case 5:
							ㅔ_2786筱齂_0EA6ⱛव뮆 = true;
							_003F50_003F._003F130_003F(_003F44_003F._003F123_003F(), _003F77_003F);
							break;
						case 3:
							break;
						case 1:
							goto end_IL_0058;
						}
						num2 = 1;
						continue;
						end_IL_0058:
						break;
					}
				}
				finally
				{
					_003F49_003F._003F129_003F(_003F167_003F);
				}
				int num3 = 5;
				while (true)
				{
					switch (num3)
					{
					default:
						num3 = 1;
						break;
					case 0:
					case 2:
						/*OpCode not supported: LdMemberToken*/;
						num3 = 1;
						break;
					case 1:
					case 3:
						return;
					}
				}
			}
			}
			num = 1;
		}
	}
}
