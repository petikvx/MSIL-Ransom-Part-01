using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Resources;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using ade;

internal sealed class _E008
{
	private delegate string _E000();

	private class _E001
	{
		private static readonly _E000 m__E000;

		internal static readonly _E001 _E001;

		internal int[] _E002;

		internal long[] _E003;

		internal float[] _E004;

		internal double[] _E005;

		static _E001()
		{
			_E009._E000();
			while (true)
			{
				int num = 2;
				while (true)
				{
					switch (num ^ 0x10)
					{
					case 12:
						num = 31;
						continue;
					case 13:
						num = 3;
						continue;
					case 14:
						num = 28;
						continue;
					case 15:
						num = 29;
						continue;
					case 16:
						num = 5;
						continue;
					case 17:
						_E008._E001._E001 = new _E001();
						num = 6;
						continue;
					case 18:
						num = 4;
						continue;
					case 19:
						num = 0;
						continue;
					case 20:
						num = 30;
						continue;
					case 21:
						_E008._E001.m__E000 = _E008._E005;
						num = 1;
						continue;
					case 22:
						return;
					}
					break;
				}
			}
		}

		private _E001()
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Stream stream = default(Stream);
			while (true)
			{
				int num = 15;
				while (true)
				{
					switch (num ^ 0x1A)
					{
					case 21:
						stream = _E00B._E000(executingAssembly.GetManifestResourceStream(_E008._E001.m__E000()));
						num = 12;
						continue;
					case 22:
						_E000(stream);
						num = 13;
						continue;
					case 23:
						return;
					}
					break;
				}
			}
		}

		private void _E000(Stream _E000)
		{
			BinaryReader binaryReader = new BinaryReader(_E000);
			int num2 = default(int);
			while (true)
			{
				int num = -14;
				while (true)
				{
					switch (num ^ 0x19)
					{
					case -21:
						num2 = binaryReader.ReadInt32() ^ 0x73FA080E;
						num = -12;
						continue;
					case -20:
						_E002 = new int[num2];
						num = -9;
						continue;
					case -19:
						if (num2 > 0)
						{
							num = -11;
							continue;
						}
						goto IL_0075;
					case -18:
						{
							while (--num2 >= 0)
							{
								_E002[num2] = binaryReader.ReadInt32() ^ 0xD651683;
							}
							goto IL_0075;
						}
						IL_0075:
						num2 = binaryReader.ReadInt32() ^ 0x492CD369;
						while (true)
						{
							IL_00e7:
							if (num2 > 0)
							{
								_E003 = new long[num2];
								while (--num2 >= 0)
								{
									_E003[num2] = binaryReader.ReadInt64() ^ 0x537F7358;
								}
								goto IL_00ce;
							}
							int num3 = -16;
							goto IL_00b1;
							IL_00b1:
							while (true)
							{
								switch (num3 ^ 0x16)
								{
								case -26:
									num2 = binaryReader.ReadInt32() ^ 0x551E5385;
									num3 = -2;
									continue;
								case -25:
									goto IL_00e7;
								case -24:
									while (num2 > 0)
									{
										_E004 = new float[num2];
										while (--num2 >= 0)
										{
											byte[] array = binaryReader.ReadBytes(4);
											array[0] = (byte)(array[0] ^ 0x8Du);
											_E004[num2] = BitConverter.ToSingle(array, 0);
										}
									}
									num2 = binaryReader.ReadInt32() ^ 0x3D7FEC41;
									while (num2 > 0)
									{
										_E005 = new double[num2];
										while (--num2 >= 0)
										{
											byte[] array2 = binaryReader.ReadBytes(8);
											while (true)
											{
												int num4 = -32;
												while (true)
												{
													switch (num4 ^ 0xF)
													{
													case -18:
														_E005[num2] = BitConverter.ToDouble(array2, 0);
														num4 = -1;
														continue;
													case -17:
														array2[2] = (byte)(array2[2] ^ 0x2D502811u);
														num4 = -31;
														continue;
													case -16:
														goto end_IL_017b;
													}
													break;
												}
												continue;
												end_IL_017b:
												break;
											}
										}
									}
									return;
								}
								break;
							}
							goto IL_00ce;
							IL_00ce:
							num3 = -15;
							goto IL_00b1;
						}
					}
					break;
				}
			}
		}

		internal static Array _E001(byte[] _E000)
		{
			MemoryStream memoryStream = new MemoryStream(_E000);
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			MemoryStream memoryStream2 = _E00B._E000(memoryStream);
			try
			{
				return (Array)binaryFormatter.Deserialize(memoryStream2);
			}
			finally
			{
				if (memoryStream2 != null || 1 == 0)
				{
					((IDisposable)memoryStream2).Dispose();
				}
			}
		}
	}

	public static int _E000(int _E000)
	{
		return _E008._E001._E001._E002[_E000];
	}

	public static long _E001(int _E000)
	{
		return _E008._E001._E001._E003[_E000];
	}

	public static float _E002(int _E000)
	{
		return _E008._E001._E001._E004[_E000];
	}

	public static double _E003(int _E000)
	{
		return _E008._E001._E001._E005[_E000];
	}

	public static Array _E004(byte[] _E000)
	{
		return _E008._E001._E001(_E000);
	}

	public static string _E005()
	{
		char[] array = "-\u001d1=\u001e".ToCharArray();
		int num = array.Length;
		while (--num >= 0)
		{
			array[num] = (char)(array[num] ^ 0x57u);
		}
		return new string(array);
	}

	static _E008()
	{
	}
}
internal sealed class _E009
{
	private delegate string _E000();

	private static Assembly m__E000;

	private static object m__E001;

	private static int m__E002;

	private static string[] m__E003;

	private static _E000 m__E004;

	static _E009()
	{
		_E009.m__E001 = new object();
		_E009.m__E004 = _E001;
	}

	public static void _E000()
	{
		//Discarded unreachable code: IL_0002, IL_0003, IL_0006
		//IL_0007: Incompatible stack heights: 0 vs 1
		if (_E009.m__E002 != 0 || 1 == 0 || (false ? true : false))
		{
			return;
		}
		try
		{
			Monitor.Enter(_E009.m__E001);
			if (_E009.m__E002 == 0 && true && 0 == 0 && 0 == 0)
			{
				AppDomain.CurrentDomain.ResourceResolve += _E002;
				_E009.m__E002 = 1;
			}
		}
		finally
		{
			Monitor.Exit(_E009.m__E001);
		}
	}

	public static string _E001()
	{
		//Discarded unreachable code: IL_0002, IL_0003, IL_0006
		//IL_0007: Incompatible stack heights: 0 vs 1
		char[] array = "üøÅÏì".ToCharArray();
		int num = array.Length;
		while (--num >= 0)
		{
			array[num] = (char)(array[num] ^ 0x96u);
		}
		return new string(array);
	}

	public static Assembly _E002(object _E000, ResolveEventArgs _E000)
	{
		//Discarded unreachable code: IL_0002, IL_0003, IL_0006
		//IL_0007: Incompatible stack heights: 0 vs 1
		if (_E009.m__E003 == null && true && 0 == 0 && 0 == 0)
		{
			try
			{
				Monitor.Enter(_E009.m__E001);
				if (_E009.m__E003 == null && true && 0 == 0 && 0 == 0)
				{
					Stream manifestResourceStream = default(Stream);
					while (true)
					{
						IL_0062:
						int num = 59;
						while (true)
						{
							switch (num ^ 0x19)
							{
							case 34:
								manifestResourceStream = typeof(_E009).Assembly.GetManifestResourceStream(_E009.m__E004());
								num = 58;
								continue;
							case 35:
								if (manifestResourceStream != null)
								{
									num = 60;
									continue;
								}
								if (1 == 0 || 1 == 0)
								{
									goto case 37;
								}
								goto end_IL_0056;
							case 36:
								/*OpCode not supported: LdMemberToken*/;
								num = 61;
								continue;
							case 37:
								if (0 == 0)
								{
									_E009.m__E000 = _E003(manifestResourceStream);
								}
								goto end_IL_0056;
							}
							goto IL_0062;
							continue;
							end_IL_0056:
							break;
						}
						break;
					}
				}
			}
			catch
			{
			}
			finally
			{
				Monitor.Exit(_E009.m__E001);
			}
		}
		if ((_E004(_E000.Name) || 1 == 0 || 1 == 0) && 0 == 0)
		{
			return _E009.m__E000;
		}
		return null;
	}

	private static Assembly _E003(Stream _E000)
	{
		//Discarded unreachable code: IL_0002, IL_0003, IL_0006
		//IL_0007: Incompatible stack heights: 0 vs 1
		MemoryStream input = _E00B._E000(_E000);
		BinaryReader binaryReader = new BinaryReader(input);
		string text = default(string);
		int num2 = default(int);
		char[] array = default(char[]);
		int num4 = default(int);
		int num13 = default(int);
		string[] array2 = default(string[]);
		while (true)
		{
			int num = 3;
			if (num != 0)
			{
				goto IL_001c;
			}
			goto IL_003d;
			IL_001c:
			num ^= 0x51;
			switch (num)
			{
			case 76:
				goto IL_003d;
			case 77:
				goto IL_0055;
			case 78:
				goto IL_0069;
			case 79:
				goto IL_0080;
			case 80:
				goto IL_0096;
			case 81:
				goto IL_00a4;
			case 82:
				goto IL_02ac;
			case 83:
				goto IL_0346;
			case 84:
				goto IL_0353;
			case 85:
				goto IL_03cb;
			}
			continue;
			IL_003d:
			text = binaryReader.ReadString();
			num = 0;
			if (num == 0)
			{
				goto IL_001c;
			}
			goto IL_0055;
			IL_0055:
			num2 = 0;
			num = 31;
			if (num != 0)
			{
				goto IL_001c;
			}
			goto IL_0069;
			IL_0069:
			if (num2 != 0 || 1 == 0)
			{
				num = 29;
				if (num != 0)
				{
					goto IL_001c;
				}
				goto IL_0080;
			}
			goto IL_03ed;
			IL_02e3:
			int num3;
			while (true)
			{
				switch (num3 ^ 0x19)
				{
				case 31:
					goto IL_031a;
				case 32:
					num = 2;
					num3 = 56;
					continue;
				case 33:
					goto IL_0330;
				case 34:
					num = 28;
					num3 = 6;
					continue;
				case 35:
					goto IL_0346;
				case 36:
					goto IL_0353;
				case 37:
					/*OpCode not supported: LdMemberToken*/;
					num3 = 60;
					continue;
				case 38:
					goto IL_03a3;
				}
				break;
				IL_0330:
				if (num == 0)
				{
					num3 = 58;
					continue;
				}
				goto IL_001c;
				IL_031a:
				if (num == 0)
				{
					num3 = 61;
					continue;
				}
				goto IL_001c;
			}
			goto IL_0314;
			IL_0353:
			array[num4] = (char)(text[num4] ^ 0xE5Cu);
			num3 = 63;
			goto IL_02e3;
			IL_0080:
			if (num4 != 0 || 1 == 0)
			{
				num = 5;
				if (num != 0)
				{
					goto IL_001c;
				}
				goto IL_0096;
			}
			goto IL_03d1;
			IL_03cb:
			num4++;
			goto IL_03d1;
			IL_03a3:
			while (true)
			{
				int num5 = -60;
				while (true)
				{
					switch (num5 ^ 0x20)
					{
					case -28:
						num = 4;
						num5 = -59;
						continue;
					case -27:
						goto IL_03b2;
					case -26:
						/*OpCode not supported: LdMemberToken*/;
						num5 = -58;
						continue;
					case -25:
						goto end_IL_03a3;
					}
					break;
					IL_03b2:
					if (num == 0)
					{
						num5 = -57;
						continue;
					}
					goto IL_001c;
				}
				continue;
				end_IL_03a3:
				break;
			}
			goto IL_03cb;
			IL_0096:
			num4 = 0;
			num = 30;
			if (num != 0)
			{
				goto IL_001c;
			}
			goto IL_00a4;
			IL_00a4:
			array = new char[text.Length];
			goto IL_0258;
			IL_0258:
			int num6 = -5;
			int num7 = 57;
			goto IL_00c3;
			IL_00c3:
			num7 ^= 0x22;
			goto IL_01e3;
			IL_01e3:
			int num8 = 0;
			int num9 = 57;
			goto IL_00db;
			IL_00db:
			num9 ^= 0x1B;
			goto IL_0183;
			IL_0183:
			int num10 = 7;
			int num11 = 60;
			goto IL_00f0;
			IL_00f0:
			num11 ^= 0x21;
			goto IL_011a;
			IL_011a:
			int num12 = 1;
			goto IL_00f9;
			IL_00f9:
			while (true)
			{
				switch (num12 ^ 0x18)
				{
				case 28:
					break;
				default:
					goto IL_011a;
				case 25:
					goto IL_011f;
				case 26:
					/*OpCode not supported: LdMemberToken*/;
					num12 = 2;
					continue;
				case 27:
					goto IL_0149;
				}
				break;
				IL_011f:
				switch (num11)
				{
				case 29:
					break;
				default:
					goto IL_0139;
				case 26:
					goto IL_0154;
				case 27:
					goto IL_0160;
				case 28:
					goto IL_0183;
				}
				goto IL_00e7;
				IL_0154:
				/*OpCode not supported: LdMemberToken*/;
				num11 = 59;
				break;
				IL_0139:
				num12 = 3;
			}
			goto IL_00f0;
			IL_0160:
			switch (num10)
			{
			case 31:
				break;
			default:
				goto IL_017a;
			case 28:
				goto IL_0194;
			case 29:
				goto IL_01a0;
			case 30:
				goto IL_01ae;
			}
			goto IL_00db;
			IL_01ae:
			switch (num9)
			{
			case 34:
				break;
			default:
				goto IL_01c8;
			case 31:
				goto IL_01d5;
			case 32:
				goto IL_01e3;
			case 33:
				goto IL_01ef;
			}
			goto IL_00cf;
			IL_01ef:
			switch (num8)
			{
			case 31:
				break;
			default:
				goto IL_0209;
			case 28:
				goto IL_0217;
			case 29:
				goto IL_0223;
			case 30:
				goto IL_0245;
			}
			goto IL_00c3;
			IL_0245:
			/*OpCode not supported: LdMemberToken*/;
			num8 = 3;
			goto IL_00cf;
			IL_0223:
			switch (num7)
			{
			case 27:
				break;
			default:
				goto IL_023d;
			case 24:
				goto IL_0258;
			case 25:
				goto IL_0265;
			case 26:
				goto IL_0274;
			}
			goto IL_00b7;
			IL_0274:
			switch (num6)
			{
			case -26:
				goto IL_02a0;
			case -25:
				goto IL_02ac;
			case -24:
				goto IL_02c2;
			case -23:
				goto IL_02d1;
			case -22:
				goto IL_0314;
			}
			num7 = 58;
			goto IL_00c3;
			IL_02d1:
			if (num != 0)
			{
				goto IL_001c;
			}
			num6 = -6;
			goto IL_00b7;
			IL_0314:
			num3 = 57;
			goto IL_02e3;
			IL_02c2:
			/*OpCode not supported: LdMemberToken*/;
			num6 = -11;
			goto IL_00b7;
			IL_02ac:
			num13 = binaryReader.ReadInt32() ^ 0x1ED5775B;
			num6 = -9;
			goto IL_00b7;
			IL_02a0:
			num = 1;
			num6 = -12;
			goto IL_00b7;
			IL_0346:
			array2 = new string[num13];
			num3 = 59;
			goto IL_02e3;
			IL_0265:
			/*OpCode not supported: LdMemberToken*/;
			num7 = 59;
			goto IL_00c3;
			IL_023d:
			num8 = 1;
			goto IL_00cf;
			IL_00b7:
			num6 ^= 0x1D;
			goto IL_0217;
			IL_0217:
			num7 = 56;
			num8 = 2;
			goto IL_00cf;
			IL_0209:
			num9 = 59;
			goto IL_00db;
			IL_01d5:
			/*OpCode not supported: LdMemberToken*/;
			num9 = 4;
			goto IL_00db;
			IL_01c8:
			num10 = 5;
			goto IL_00e7;
			IL_00cf:
			num8 ^= 0x1D;
			goto IL_0194;
			IL_01a0:
			/*OpCode not supported: LdMemberToken*/;
			num10 = 4;
			goto IL_00e7;
			IL_0194:
			num9 = 58;
			num10 = 6;
			goto IL_00e7;
			IL_017a:
			num11 = 61;
			goto IL_00f0;
			IL_00e7:
			num10 ^= 0x19;
			goto IL_0149;
			IL_0149:
			num11 = 58;
			num12 = 4;
			goto IL_00f9;
			IL_03d1:
			if (num4 < array.Length)
			{
				goto IL_0353;
			}
			array2[num2] = new string(array);
			num2++;
			goto IL_03ed;
			IL_03ed:
			if (num2 >= num13)
			{
				break;
			}
			goto IL_003d;
		}
		_E009.m__E003 = array2;
		byte[] array3 = default(byte[]);
		while (true)
		{
			int num14 = -6;
			if (num14 == 0)
			{
				goto IL_043d;
			}
			goto IL_03fd;
			IL_03fd:
			switch (num14 ^ 0x4D)
			{
			case -74:
				goto IL_043d;
			case -73:
				goto IL_046d;
			case -72:
				goto IL_04a5;
			case -71:
				goto end_IL_041e;
			}
			continue;
			IL_043d:
			array3 = new byte[num13];
			num14 = -11;
			if (num14 == 0)
			{
				goto IL_046d;
			}
			goto IL_03fd;
			IL_046d:
			num13 = binaryReader.ReadInt32() ^ 0x25F65889;
			num14 = -5;
			if (num14 == 0)
			{
				goto IL_04a5;
			}
			goto IL_03fd;
			IL_04a5:
			binaryReader.Read(array3, 0, num13);
			num14 = -12;
			if (num14 == 0)
			{
				break;
			}
			goto IL_03fd;
			continue;
			end_IL_041e:
			break;
		}
		return Assembly.Load(array3);
	}

	private static bool _E004(string _E000)
	{
		//Discarded unreachable code: IL_0002, IL_0003, IL_0006
		//IL_0007: Incompatible stack heights: 0 vs 1
		if ((_E009.m__E003 != null || 1 == 0 || 1 == 0) && 0 == 0)
		{
			string[] array = _E009.m__E003;
			int num3 = default(int);
			string value = default(string);
			while (true)
			{
				int num = -5;
				int num2 = -32;
				if (num2 == 0)
				{
					goto IL_002d;
				}
				goto IL_0036;
				IL_0036:
				switch (num2 ^ 0x51)
				{
				case -79:
					break;
				default:
					goto IL_004a;
				case -81:
					goto IL_0058;
				case -80:
					continue;
				}
				goto IL_002d;
				IL_002d:
				num ^= 0x50;
				goto IL_004a;
				IL_004a:
				num2 = -2;
				if (num2 != 0)
				{
					goto IL_0036;
				}
				goto IL_0058;
				IL_0058:
				int num4;
				int num5;
				int num6;
				int num7;
				int num8;
				int num9;
				int num10;
				int num11;
				int num12;
				switch (num)
				{
				case -85:
					num3 = 0;
					num = -2;
					if (num != 0)
					{
						goto IL_002d;
					}
					goto case -84;
				case -84:
					value = array[num3];
					goto IL_02dc;
				case -83:
					goto IL_036b;
				case -82:
					if (num3 != 0 || 1 == 0)
					{
						num = -4;
						if (num == 0)
						{
							goto case -81;
						}
						goto IL_002d;
					}
					goto IL_0433;
				case -81:
					{
						if (0 == 0)
						{
							return true;
						}
						goto IL_0426;
					}
					IL_02dc:
					num4 = -3;
					num5 = -63;
					goto IL_00a7;
					IL_00a7:
					num5 ^= 0x20;
					goto IL_0286;
					IL_0286:
					num6 = 58;
					num7 = -6;
					goto IL_00bf;
					IL_00bf:
					num7 ^= 0x1D;
					goto IL_0202;
					IL_0202:
					num8 = 7;
					num9 = 63;
					goto IL_00d7;
					IL_00d7:
					num9 ^= 0x1C;
					goto IL_017e;
					IL_017e:
					num10 = 7;
					num11 = 62;
					goto IL_00ec;
					IL_00ec:
					num11 ^= 0x1F;
					goto IL_0116;
					IL_0116:
					num12 = 5;
					goto IL_00f5;
					IL_00f5:
					while (true)
					{
						switch (num12 ^ 0x1B)
						{
						case 32:
							break;
						default:
							goto IL_0116;
						case 29:
							goto IL_011b;
						case 30:
							goto IL_0124;
						case 31:
							/*OpCode not supported: LdMemberToken*/;
							num12 = 4;
							continue;
						}
						break;
						IL_0124:
						switch (num11)
						{
						case 33:
							break;
						default:
							goto IL_013e;
						case 30:
							goto IL_0150;
						case 31:
							goto IL_015b;
						case 32:
							goto IL_017e;
						}
						goto IL_00e3;
						IL_0150:
						/*OpCode not supported: LdMemberToken*/;
						num11 = 1;
						break;
						IL_013e:
						num12 = 6;
					}
					goto IL_00ec;
					IL_015b:
					switch (num10)
					{
					case 29:
						break;
					default:
						goto IL_0175;
					case 26:
						goto IL_018f;
					case 27:
						goto IL_01b1;
					case 28:
						goto IL_01bd;
					}
					goto IL_00d7;
					IL_01bd:
					/*OpCode not supported: LdMemberToken*/;
					num10 = 1;
					goto IL_00e3;
					IL_018f:
					switch (num9)
					{
					case 35:
						break;
					default:
						goto IL_01a9;
					case 32:
						goto IL_01d0;
					case 33:
						goto IL_01f3;
					case 34:
						goto IL_0202;
					}
					goto IL_00cb;
					IL_01f3:
					/*OpCode not supported: LdMemberToken*/;
					num9 = 61;
					goto IL_00d7;
					IL_01d0:
					switch (num8)
					{
					case 29:
						break;
					default:
						goto IL_01ea;
					case 26:
						goto IL_0213;
					case 27:
						goto IL_0235;
					case 28:
						goto IL_0243;
					}
					goto IL_00bf;
					IL_0235:
					/*OpCode not supported: LdMemberToken*/;
					num8 = 6;
					goto IL_00cb;
					IL_0213:
					switch (num7)
					{
					case -25:
						break;
					default:
						goto IL_022d;
					case -28:
						goto IL_0254;
					case -27:
						goto IL_0263;
					case -26:
						goto IL_0286;
					}
					goto IL_00b3;
					IL_0263:
					switch (num6)
					{
					case 37:
						break;
					default:
						goto IL_027d;
					case 34:
						goto IL_0298;
					case 35:
						goto IL_02a5;
					case 36:
						goto IL_02b4;
					}
					goto IL_00a7;
					IL_02b4:
					switch (num5)
					{
					case -31:
						break;
					default:
						goto IL_02ce;
					case -34:
						goto IL_02dc;
					case -33:
						goto IL_02e9;
					case -32:
						goto IL_02f7;
					}
					goto IL_009b;
					IL_02f7:
					switch (num4)
					{
					case -34:
						goto IL_0323;
					case -33:
						goto IL_033d;
					case -32:
						goto IL_0353;
					case -31:
						goto IL_036b;
					case -30:
						goto IL_0396;
					}
					num5 = -2;
					goto IL_00a7;
					IL_036b:
					if (_E000.Equals(value))
					{
						num4 = -64;
						goto IL_009b;
					}
					if (1 == 0)
					{
						goto IL_0396;
					}
					if (1 == 0)
					{
						goto case -81;
					}
					goto IL_0426;
					IL_01a9:
					num10 = 6;
					goto IL_00e3;
					IL_00cb:
					num8 ^= 0x1D;
					goto IL_01b1;
					IL_0396:
					num = -1;
					if (num == 0)
					{
						goto case -82;
					}
					goto IL_002d;
					IL_00e3:
					num10 ^= 0x1D;
					goto IL_011b;
					IL_0175:
					num11 = 63;
					goto IL_00ec;
					IL_01b1:
					num9 = 60;
					num10 = 0;
					goto IL_00e3;
					IL_011b:
					num11 = 0;
					num12 = 59;
					goto IL_00f5;
					IL_0426:
					num3++;
					goto IL_0433;
					IL_0433:
					if (num3 >= array.Length)
					{
						goto end_IL_0070;
					}
					goto case -84;
					IL_0353:
					/*OpCode not supported: LdMemberToken*/;
					num4 = -62;
					goto IL_009b;
					IL_033d:
					num = -3;
					num4 = -4;
					goto IL_009b;
					IL_0323:
					if (num != 0)
					{
						goto IL_002d;
					}
					num4 = -61;
					goto IL_009b;
					IL_01ea:
					num9 = 62;
					goto IL_00d7;
					IL_0243:
					num7 = -8;
					num8 = 0;
					goto IL_00cb;
					IL_02e9:
					/*OpCode not supported: LdMemberToken*/;
					num5 = -1;
					goto IL_00a7;
					IL_02ce:
					num6 = 60;
					goto IL_00b3;
					IL_009b:
					num4 ^= 0x22;
					goto IL_0298;
					IL_02a5:
					/*OpCode not supported: LdMemberToken*/;
					num6 = 61;
					goto IL_00b3;
					IL_0298:
					num5 = -64;
					num6 = 59;
					goto IL_00b3;
					IL_027d:
					num7 = -5;
					goto IL_00bf;
					IL_0254:
					/*OpCode not supported: LdMemberToken*/;
					num7 = -7;
					goto IL_00bf;
					IL_022d:
					num8 = 1;
					goto IL_00cb;
					IL_00b3:
					num6 ^= 0x1E;
					goto IL_0243;
				}
				num2 = -31;
				if (num2 == 0)
				{
					continue;
				}
				goto IL_0036;
				continue;
				end_IL_0070:
				break;
			}
		}
		return false;
	}
}
internal sealed class _E00A
{
	private static ModuleHandle m__E000;

	static _E00A()
	{
		//Discarded unreachable code: IL_0002, IL_0003, IL_0006
		//IL_0007: Incompatible stack heights: 0 vs 1
		while (true)
		{
			int num = -59;
			while (true)
			{
				switch (num ^ 0x21)
				{
				case -28:
					num = -53;
					continue;
				case -27:
					num = -55;
					continue;
				case -26:
					_E00A.m__E000 = Assembly.GetExecutingAssembly().ManifestModule.ModuleHandle;
					num = -54;
					continue;
				case -25:
					/*OpCode not supported: LdMemberToken*/;
					num = -58;
					continue;
				case -24:
					num = -56;
					continue;
				case -23:
					num = -57;
					continue;
				case -22:
					num = -60;
					continue;
				case -21:
					return;
				}
				break;
			}
		}
	}

	public static void _E000(RuntimeTypeHandle _E000, int _E000, RuntimeFieldHandle _E000)
	{
		//Discarded unreachable code: IL_0002, IL_0003, IL_0006
		//IL_0007: Incompatible stack heights: 0 vs 1
		FieldInfo fieldFromHandle = FieldInfo.GetFieldFromHandle(_E000);
		Type typeFromHandle = default(Type);
		MethodInfo methodInfo = default(MethodInfo);
		while (true)
		{
			int num = -22;
			if (num != 0)
			{
				goto IL_0012;
			}
			goto IL_0031;
			IL_0012:
			num ^= 0x53;
			switch (num)
			{
			case -72:
				goto IL_0031;
			case -71:
				goto IL_00f3;
			case -70:
				goto IL_019a;
			case -69:
				return;
			}
			continue;
			IL_0031:
			_E004(fieldFromHandle, typeFromHandle, methodInfo);
			goto IL_008f;
			IL_008f:
			int num2 = -6;
			int num3 = -54;
			goto IL_0044;
			IL_0044:
			num3 ^= 0x22;
			goto IL_0061;
			IL_0061:
			int num4 = 3;
			goto IL_004d;
			IL_004d:
			while (true)
			{
				switch (num4 ^ 0x20)
				{
				case 38:
					break;
				default:
					goto IL_0061;
				case 35:
					goto IL_0066;
				case 36:
					goto IL_0075;
				case 37:
					/*OpCode not supported: LdMemberToken*/;
					num4 = 5;
					continue;
				}
				break;
				IL_0066:
				switch (num3)
				{
				case -24:
					break;
				default:
					goto IL_0070;
				case -27:
					goto IL_008f;
				case -26:
					goto IL_0099;
				case -25:
					goto IL_00ab;
				}
				goto IL_003b;
				IL_0099:
				/*OpCode not supported: LdMemberToken*/;
				num3 = -60;
				break;
				IL_0070:
				num4 = 4;
			}
			goto IL_0044;
			IL_00ab:
			switch (num2)
			{
			case -28:
				goto IL_00dc;
			case -27:
				goto IL_00f3;
			case -26:
				goto IL_011f;
			case -25:
				goto IL_014a;
			case -24:
				goto IL_017b;
			}
			num3 = -57;
			goto IL_0044;
			IL_017b:
			num = -23;
			if (num == 0)
			{
				goto IL_019a;
			}
			goto IL_0012;
			IL_019a:
			methodInfo = (MethodInfo)MethodBase.GetMethodFromHandle(_E00A.m__E000.ResolveMethodHandle(_E000 ^ 0x2CA7BD56));
			num = -21;
			goto IL_0012;
			IL_014a:
			num = -24;
			num2 = -7;
			goto IL_003b;
			IL_011f:
			/*OpCode not supported: LdMemberToken*/;
			num2 = -5;
			goto IL_003b;
			IL_00f3:
			typeFromHandle = Type.GetTypeFromHandle(_E000);
			num2 = -11;
			goto IL_003b;
			IL_00dc:
			if (num != 0)
			{
				goto IL_0012;
			}
			num2 = -8;
			goto IL_003b;
			IL_0075:
			num3 = -59;
			num4 = 6;
			goto IL_004d;
			IL_003b:
			num2 ^= 0x1D;
			goto IL_0075;
		}
	}

	public static void _E001(RuntimeTypeHandle _E000, int _E000, int _E000, RuntimeFieldHandle _E000)
	{
		//Discarded unreachable code: IL_0002, IL_0003, IL_0006
		//IL_0007: Incompatible stack heights: 0 vs 1
		FieldInfo fieldFromHandle = FieldInfo.GetFieldFromHandle(_E000);
		Type typeFromHandle = default(Type);
		MethodInfo methodInfo = default(MethodInfo);
		while (true)
		{
			int num = 4;
			if (num != 0)
			{
				goto IL_0012;
			}
			goto IL_0030;
			IL_0012:
			num ^= 0x4A;
			switch (num)
			{
			case 78:
				goto IL_0030;
			case 79:
				goto IL_00f5;
			case 80:
				goto IL_01c6;
			case 81:
				return;
			}
			continue;
			IL_0030:
			typeFromHandle = Type.GetTypeFromHandle(_E000);
			goto IL_00a1;
			IL_00a1:
			int num2 = -2;
			int num3 = -54;
			goto IL_0045;
			IL_0045:
			num3 ^= 0x21;
			goto IL_0062;
			IL_0062:
			int num4 = 60;
			goto IL_004e;
			IL_004e:
			while (true)
			{
				switch (num4 ^ 0x19)
				{
				case 38:
					break;
				default:
					goto IL_0062;
				case 35:
					/*OpCode not supported: LdMemberToken*/;
					num4 = 58;
					continue;
				case 36:
					goto IL_0078;
				case 37:
					goto IL_0085;
				}
				break;
				IL_0085:
				switch (num3)
				{
				case -21:
					break;
				default:
					goto IL_008c;
				case -24:
					goto IL_0094;
				case -23:
					goto IL_00a1;
				case -22:
					goto IL_00b0;
				}
				goto IL_003c;
				IL_0094:
				/*OpCode not supported: LdMemberToken*/;
				num3 = -55;
				break;
				IL_008c:
				num4 = 61;
			}
			goto IL_0045;
			IL_00b0:
			switch (num2)
			{
			case -32:
				goto IL_00f5;
			case -31:
				goto IL_0134;
			case -30:
				goto IL_014b;
			case -29:
				goto IL_0171;
			case -28:
				goto IL_01a7;
			}
			num3 = -56;
			goto IL_0045;
			IL_01a7:
			num = 26;
			if (num == 0)
			{
				goto IL_01c6;
			}
			goto IL_0012;
			IL_01c6:
			_E004(fieldFromHandle, typeFromHandle, methodInfo);
			num = 27;
			goto IL_0012;
			IL_0171:
			if (num != 0)
			{
				goto IL_0012;
			}
			num2 = -4;
			goto IL_003c;
			IL_0078:
			num3 = -53;
			num4 = 63;
			goto IL_004e;
			IL_014b:
			num = 5;
			num2 = -1;
			goto IL_003c;
			IL_0134:
			/*OpCode not supported: LdMemberToken*/;
			num2 = -3;
			goto IL_003c;
			IL_00f5:
			methodInfo = (MethodInfo)MethodBase.GetMethodFromHandle(_E00A.m__E000.ResolveMethodHandle(_E000 ^ 0x2CA7BD56), _E00A.m__E000.ResolveTypeHandle(_E000 ^ 0x61867222));
			num2 = -8;
			goto IL_003c;
			IL_003c:
			num2 ^= 0x1C;
			goto IL_0078;
		}
	}

	public static void _E002(RuntimeTypeHandle _E000, int _E000, RuntimeFieldHandle _E000)
	{
		//Discarded unreachable code: IL_0002, IL_0003, IL_0006
		//IL_0007: Incompatible stack heights: 0 vs 1
		FieldInfo fieldFromHandle = FieldInfo.GetFieldFromHandle(_E000);
		Type typeFromHandle = default(Type);
		ConstructorInfo constructorInfo = default(ConstructorInfo);
		while (true)
		{
			int num = -30;
			if (num != 0)
			{
				goto IL_0012;
			}
			goto IL_0031;
			IL_0012:
			num ^= 0x52;
			switch (num)
			{
			case -80:
				goto IL_0031;
			case -79:
				goto IL_00f6;
			case -78:
				goto IL_01a0;
			case -77:
				return;
			}
			continue;
			IL_0031:
			typeFromHandle = Type.GetTypeFromHandle(_E000);
			goto IL_00cb;
			IL_00cb:
			int num2 = -14;
			int num3 = 61;
			goto IL_0046;
			IL_0046:
			num3 ^= 0x1D;
			goto IL_0063;
			IL_0063:
			int num4 = -5;
			goto IL_004f;
			IL_004f:
			while (true)
			{
				switch (num4 ^ 0x1F)
				{
				case -25:
					break;
				default:
					goto IL_0063;
				case -28:
					goto IL_0069;
				case -27:
					/*OpCode not supported: LdMemberToken*/;
					num4 = -6;
					continue;
				case -26:
					goto IL_0089;
				}
				break;
				IL_0069:
				switch (num3)
				{
				case 32:
					break;
				default:
					goto IL_0073;
				case 29:
					goto IL_0094;
				case 30:
					goto IL_00a0;
				case 31:
					goto IL_00cb;
				}
				goto IL_003d;
				IL_00a0:
				/*OpCode not supported: LdMemberToken*/;
				num3 = 3;
				break;
				IL_0073:
				num4 = -7;
			}
			goto IL_0046;
			IL_0094:
			switch (num2)
			{
			case -25:
				goto IL_00e3;
			case -24:
				goto IL_00f6;
			case -23:
				goto IL_0123;
			case -22:
				goto IL_0150;
			case -21:
				goto IL_0181;
			}
			num3 = 2;
			goto IL_0046;
			IL_0181:
			num = -31;
			if (num == 0)
			{
				goto IL_01a0;
			}
			goto IL_0012;
			IL_01a0:
			constructorInfo = (ConstructorInfo)MethodBase.GetMethodFromHandle(_E00A.m__E000.ResolveMethodHandle(_E000 ^ 0x2F8FED));
			num = -29;
			goto IL_0012;
			IL_0150:
			num = -32;
			num2 = -15;
			goto IL_003d;
			IL_0123:
			if (num != 0)
			{
				goto IL_0012;
			}
			num2 = -16;
			goto IL_003d;
			IL_0089:
			num3 = 0;
			num4 = -8;
			goto IL_004f;
			IL_00f6:
			_E005(fieldFromHandle, typeFromHandle, constructorInfo);
			num2 = -13;
			goto IL_003d;
			IL_00e3:
			/*OpCode not supported: LdMemberToken*/;
			num2 = -1;
			goto IL_003d;
			IL_003d:
			num2 ^= 0x18;
			goto IL_0089;
		}
	}

	public static void _E003(RuntimeTypeHandle _E000, int _E000, int _E000, RuntimeFieldHandle _E000)
	{
		//Discarded unreachable code: IL_0002, IL_0003, IL_0006
		//IL_0007: Incompatible stack heights: 0 vs 1
		FieldInfo fieldFromHandle = FieldInfo.GetFieldFromHandle(_E000);
		Type typeFromHandle = default(Type);
		ConstructorInfo constructorInfo = default(ConstructorInfo);
		while (true)
		{
			int num = 7;
			if (num != 0)
			{
				goto IL_0012;
			}
			goto IL_0030;
			IL_0012:
			num ^= 0x4F;
			switch (num)
			{
			case 72:
				goto IL_0030;
			case 73:
				goto IL_00fb;
			case 74:
				goto IL_01a1;
			case 75:
				return;
			}
			continue;
			IL_0030:
			typeFromHandle = Type.GetTypeFromHandle(_E000);
			goto IL_00a1;
			IL_00a1:
			int num2 = -12;
			int num3 = -11;
			goto IL_0045;
			IL_0045:
			num3 ^= 0x1F;
			goto IL_0062;
			IL_0062:
			int num4 = -58;
			goto IL_004e;
			IL_004e:
			while (true)
			{
				switch (num4 ^ 0x21)
				{
				case -22:
					break;
				default:
					goto IL_0062;
				case -25:
					goto IL_0068;
				case -24:
					goto IL_0078;
				case -23:
					/*OpCode not supported: LdMemberToken*/;
					num4 = -56;
					continue;
				}
				break;
				IL_0068:
				switch (num3)
				{
				case -22:
					break;
				default:
					goto IL_0072;
				case -25:
					goto IL_0094;
				case -24:
					goto IL_00a1;
				case -23:
					goto IL_00cb;
				}
				goto IL_003c;
				IL_00cb:
				/*OpCode not supported: LdMemberToken*/;
				num3 = -10;
				break;
				IL_0072:
				num4 = -55;
			}
			goto IL_0045;
			IL_0094:
			switch (num2)
			{
			case -25:
				goto IL_00e4;
			case -24:
				goto IL_00fb;
			case -23:
				goto IL_0128;
			case -22:
				goto IL_014f;
			case -21:
				goto IL_0183;
			}
			num3 = -9;
			goto IL_0045;
			IL_0183:
			num = 4;
			if (num == 0)
			{
				goto IL_01a1;
			}
			goto IL_0012;
			IL_01a1:
			constructorInfo = (constructorInfo = (ConstructorInfo)MethodBase.GetMethodFromHandle(_E00A.m__E000.ResolveMethodHandle(_E000 ^ 0x2F8FED), _E00A.m__E000.ResolveTypeHandle(_E000 ^ 0x61867222)));
			num = 6;
			goto IL_0012;
			IL_014f:
			/*OpCode not supported: LdMemberToken*/;
			num2 = -9;
			goto IL_003c;
			IL_0128:
			num = 5;
			num2 = -6;
			goto IL_003c;
			IL_00fb:
			_E005(fieldFromHandle, typeFromHandle, constructorInfo);
			num2 = -10;
			goto IL_003c;
			IL_00e4:
			if (num != 0)
			{
				goto IL_0012;
			}
			num2 = -11;
			goto IL_003c;
			IL_0078:
			num3 = -8;
			num4 = -53;
			goto IL_004e;
			IL_003c:
			num2 ^= 0x1D;
			goto IL_0078;
		}
	}

	private static void _E004(FieldInfo _E000, Type _E000, MethodInfo _E000)
	{
		//Discarded unreachable code: IL_0002, IL_0003, IL_0006
		//IL_0007: Incompatible stack heights: 0 vs 1
		Delegate @delegate = null;
		if ((_E000.IsStatic || 1 == 0 || 1 == 0) && 0 == 0)
		{
			@delegate = Delegate.CreateDelegate(_E000.FieldType, _E000);
		}
		else
		{
			ParameterInfo[] parameters = _E000.GetParameters();
			int num4 = default(int);
			Type[] array = default(Type[]);
			while (true)
			{
				int num = 4;
				int num2 = -6;
				if (num2 != 0)
				{
					goto IL_004d;
				}
				goto IL_0083;
				IL_004d:
				switch (num2 ^ 0x4A)
				{
				case -80:
					break;
				default:
					goto IL_0061;
				case -82:
					continue;
				case -81:
					goto IL_0083;
				}
				goto IL_0044;
				IL_0083:
				int num3;
				int num5;
				int num6;
				int num7;
				int num8;
				int num9;
				int num10;
				int num11;
				int num12;
				int num13;
				switch (num)
				{
				case 72:
					if (_E000.DeclaringType!.IsValueType || 1 == 0)
					{
						num = 6;
						if (num != 0)
						{
							goto IL_0044;
						}
						goto case 73;
					}
					if (1 == 0)
					{
						goto IL_03c0;
					}
					goto IL_03d5;
				case 73:
					num4 = parameters.Length + 1;
					goto IL_034c;
				case 74:
					goto IL_038d;
				case 75:
					goto IL_03c0;
					IL_03c0:
					if (false)
					{
						goto IL_03d5;
					}
					array[0] = _E000.DeclaringType!.MakeByRefType();
					goto IL_03e2;
					IL_0406:
					if (num3 >= num4)
					{
						goto end_IL_006f;
					}
					goto IL_03f1;
					IL_034c:
					num5 = -9;
					num6 = 62;
					goto IL_00d3;
					IL_00d3:
					num6 ^= 0x1F;
					goto IL_0297;
					IL_0297:
					num7 = 59;
					num8 = 56;
					goto IL_00eb;
					IL_00eb:
					num8 ^= 0x1A;
					goto IL_0227;
					IL_0227:
					num9 = 1;
					num10 = 56;
					goto IL_0103;
					IL_0103:
					num10 ^= 0x1A;
					goto IL_018c;
					IL_018c:
					num11 = -7;
					num12 = -61;
					goto IL_0118;
					IL_0118:
					num12 ^= 0x23;
					goto IL_0142;
					IL_0142:
					num13 = -57;
					goto IL_0121;
					IL_0121:
					while (true)
					{
						switch (num13 ^ 0x22)
						{
						case -26:
							break;
						default:
							goto IL_0142;
						case -29:
							goto IL_0148;
						case -28:
							/*OpCode not supported: LdMemberToken*/;
							num13 = -58;
							continue;
						case -27:
							goto IL_015e;
						}
						break;
						IL_015e:
						switch (num12)
						{
						case -32:
							break;
						default:
							goto IL_0178;
						case -35:
							goto IL_0180;
						case -34:
							goto IL_018c;
						case -33:
							goto IL_0199;
						}
						goto IL_010f;
						IL_0180:
						/*OpCode not supported: LdMemberToken*/;
						num12 = -2;
						break;
						IL_0178:
						num13 = -63;
					}
					goto IL_0118;
					IL_0199:
					switch (num11)
					{
					case -29:
						break;
					default:
						goto IL_01b3;
					case -32:
						goto IL_01c1;
					case -31:
						goto IL_01d0;
					case -30:
						goto IL_01f3;
					}
					goto IL_0103;
					IL_01d0:
					switch (num10)
					{
					case 34:
						break;
					default:
						goto IL_01ea;
					case 31:
						goto IL_0204;
					case 32:
						goto IL_0227;
					case 33:
						goto IL_0233;
					}
					goto IL_00f7;
					IL_0233:
					/*OpCode not supported: LdMemberToken*/;
					num10 = 59;
					goto IL_0103;
					IL_0204:
					switch (num9)
					{
					case 34:
						break;
					default:
						goto IL_021e;
					case 31:
						goto IL_0247;
					case 32:
						goto IL_0253;
					case 33:
						goto IL_0261;
					}
					goto IL_00eb;
					IL_0261:
					switch (num8)
					{
					case 34:
						break;
					default:
						goto IL_027b;
					case 31:
						goto IL_0289;
					case 32:
						goto IL_0297;
					case 33:
						goto IL_02a4;
					}
					goto IL_00df;
					IL_02a4:
					switch (num7)
					{
					case 27:
						break;
					default:
						goto IL_02be;
					case 24:
						goto IL_02cc;
					case 25:
						goto IL_02d8;
					case 26:
						goto IL_02fb;
					}
					goto IL_00d3;
					IL_02fb:
					/*OpCode not supported: LdMemberToken*/;
					num7 = 56;
					goto IL_00df;
					IL_02d8:
					switch (num6)
					{
					case 33:
						break;
					default:
						goto IL_02f2;
					case 30:
						goto IL_030f;
					case 31:
						goto IL_033e;
					case 32:
						goto IL_034c;
					}
					goto IL_00c7;
					IL_033e:
					/*OpCode not supported: LdMemberToken*/;
					num6 = 0;
					goto IL_00d3;
					IL_030f:
					switch (num5)
					{
					case -25:
						goto IL_035e;
					case -24:
						goto IL_036d;
					case -23:
						goto IL_037d;
					case -22:
						goto IL_038d;
					case -21:
						goto IL_039d;
					case -20:
						goto IL_03a9;
					case -19:
						goto IL_03c0;
					}
					num6 = 63;
					goto IL_00d3;
					IL_03a9:
					num = 5;
					num5 = -12;
					goto IL_00c7;
					IL_039d:
					num = 7;
					num5 = -11;
					goto IL_00c7;
					IL_038d:
					array = new Type[num4];
					num5 = -16;
					goto IL_00c7;
					IL_037d:
					if (num != 0)
					{
						goto IL_0044;
					}
					num5 = -10;
					goto IL_00c7;
					IL_03e2:
					num3 = 1;
					if (num3 == 0 && 0 == 0)
					{
						goto IL_03f1;
					}
					goto IL_0406;
					IL_036d:
					if (num != 0)
					{
						goto IL_0044;
					}
					num5 = -15;
					goto IL_00c7;
					IL_03f1:
					array[num3] = parameters[num3 - 1].ParameterType;
					num3++;
					goto IL_0406;
					IL_035e:
					/*OpCode not supported: LdMemberToken*/;
					num5 = -5;
					goto IL_00c7;
					IL_03d5:
					array[0] = typeof(object);
					goto IL_03e2;
					IL_02f2:
					num7 = 58;
					goto IL_00df;
					IL_00c7:
					num5 ^= 0x1C;
					goto IL_02cc;
					IL_02cc:
					num6 = 1;
					num7 = 57;
					goto IL_00df;
					IL_02be:
					num8 = 58;
					goto IL_00eb;
					IL_0289:
					/*OpCode not supported: LdMemberToken*/;
					num8 = 5;
					goto IL_00eb;
					IL_027b:
					num9 = 63;
					goto IL_00f7;
					IL_00df:
					num7 ^= 0x22;
					goto IL_0247;
					IL_0253:
					/*OpCode not supported: LdMemberToken*/;
					num9 = 0;
					goto IL_00f7;
					IL_0247:
					num8 = 59;
					num9 = 2;
					goto IL_00f7;
					IL_021e:
					num10 = 58;
					goto IL_0103;
					IL_01ea:
					num11 = -6;
					goto IL_010f;
					IL_00f7:
					num9 ^= 0x20;
					goto IL_01f3;
					IL_01f3:
					num10 = 5;
					num11 = -5;
					goto IL_010f;
					IL_01c1:
					/*OpCode not supported: LdMemberToken*/;
					num11 = -8;
					goto IL_010f;
					IL_01b3:
					num12 = -3;
					goto IL_0118;
					IL_010f:
					num11 ^= 0x18;
					goto IL_0148;
					IL_0148:
					num12 = -4;
					num13 = -60;
					goto IL_0121;
				}
				num2 = -28;
				if (num2 == 0)
				{
					goto IL_0044;
				}
				goto IL_004d;
				IL_0061:
				num2 = -27;
				if (num2 == 0)
				{
					continue;
				}
				goto IL_004d;
				IL_0044:
				num ^= 0x4D;
				goto IL_0061;
				continue;
				end_IL_006f:
				break;
			}
			DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, _E000.ReturnType, array, _E000, skipVisibility: true);
			int num15 = default(int);
			ILGenerator iLGenerator = default(ILGenerator);
			int num16 = default(int);
			while (true)
			{
				int num14 = -5;
				if (num14 != 0)
				{
					goto IL_0422;
				}
				goto IL_0457;
				IL_0422:
				switch (num14 ^ 0x47)
				{
				case -73:
					goto IL_0457;
				case -72:
					goto IL_0474;
				case -71:
					goto IL_0488;
				case -70:
					goto IL_0494;
				case -69:
					goto IL_04bc;
				case -68:
					goto IL_04fd;
				case -67:
					goto IL_054e;
				}
				continue;
				IL_0457:
				switch (num15)
				{
				case 1:
					goto IL_0524;
				case 2:
					goto IL_0532;
				case 3:
					goto IL_0540;
				}
				num14 = -6;
				if (num14 != 0)
				{
					goto IL_0422;
				}
				goto IL_0474;
				IL_0540:
				iLGenerator.Emit(OpCodes.Ldarg_3);
				goto IL_0568;
				IL_0532:
				iLGenerator.Emit(OpCodes.Ldarg_2);
				goto IL_0568;
				IL_0524:
				iLGenerator.Emit(OpCodes.Ldarg_1);
				goto IL_0568;
				IL_054e:
				iLGenerator.Emit(OpCodes.Ldarg_S, num16);
				goto IL_0568;
				IL_0474:
				iLGenerator.Emit(OpCodes.Ldarg_0);
				num14 = -4;
				if (num14 != 0)
				{
					goto IL_0422;
				}
				goto IL_0488;
				IL_0488:
				num15 = num16;
				num14 = -16;
				if (num14 != 0)
				{
					goto IL_0422;
				}
				goto IL_0494;
				IL_0494:
				if (num16 == 0 && 0 == 0)
				{
					num14 = -2;
					if (num14 == 0)
					{
						goto IL_04bc;
					}
					goto IL_0422;
				}
				goto IL_0577;
				IL_0568:
				num16++;
				goto IL_0577;
				IL_0577:
				if (num16 >= num4)
				{
					break;
				}
				goto IL_0488;
				IL_04bc:
				num16 = 1;
				num14 = -3;
				if (num14 == 0)
				{
					goto IL_04fd;
				}
				goto IL_0422;
				IL_04fd:
				iLGenerator = dynamicMethod.GetILGenerator();
				num14 = -1;
				if (num14 != 0)
				{
					goto IL_0422;
				}
				goto IL_054e;
			}
			iLGenerator.Emit((_E000.IsAssembly || 1 == 0 || (false ? true : false)) ? OpCodes.Callvirt : OpCodes.Call, _E000);
			iLGenerator.Emit(OpCodes.Ret);
			@delegate = dynamicMethod.CreateDelegate(_E000);
		}
		_E000.SetValue(null, @delegate);
	}

	private static void _E005(FieldInfo _E000, Type _E000, ConstructorInfo _E000)
	{
		//Discarded unreachable code: IL_0002, IL_0003, IL_0006
		//IL_0007: Incompatible stack heights: 0 vs 1
		ParameterInfo[] parameters = _E000.GetParameters();
		int num = parameters.Length;
		Type[] array = new Type[num];
		int num2 = 0;
		if (num2 != 0 || 1 == 0)
		{
			goto IL_003a;
		}
		goto IL_0051;
		IL_003a:
		array[num2] = parameters[num2].ParameterType;
		num2++;
		goto IL_0051;
		IL_0051:
		if (num2 >= num)
		{
			DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, _E000.DeclaringType, array, _E000, skipVisibility: true);
			int num10 = default(int);
			int num12 = default(int);
			int num11 = default(int);
			ILGenerator iLGenerator = default(ILGenerator);
			Delegate value = default(Delegate);
			while (true)
			{
				int num3 = -9;
				int num4 = 8;
				while (true)
				{
					num4 ^= 0x22;
					while (true)
					{
						int num5 = -1;
						int num6 = 1;
						while (true)
						{
							num6 ^= 0x22;
							while (true)
							{
								int num7 = 61;
								int num8 = -7;
								while (true)
								{
									num8 ^= 0x19;
									while (true)
									{
										IL_00d4:
										int num9 = -11;
										while (true)
										{
											switch (num9 ^ 0x1D)
											{
											case -21:
												break;
											default:
												goto IL_00d4;
											case -24:
												goto IL_00da;
											case -23:
												/*OpCode not supported: LdMemberToken*/;
												num9 = -12;
												continue;
											case -22:
												goto IL_00fa;
											}
											break;
											IL_00da:
											switch (num8)
											{
											case -32:
												break;
											default:
												goto IL_00e4;
											case -35:
												goto IL_0106;
											case -34:
												goto IL_0112;
											case -33:
												goto end_IL_00b7;
											}
											goto IL_00ae;
											IL_0112:
											switch (num7)
											{
											case 33:
												break;
											default:
												goto IL_012c;
											case 30:
												goto IL_0144;
											case 31:
												goto IL_014f;
											case 32:
												goto IL_0172;
											}
											goto end_IL_0132;
											IL_0172:
											/*OpCode not supported: LdMemberToken*/;
											num7 = 2;
											goto IL_00ae;
											IL_014f:
											switch (num6)
											{
											case 35:
												break;
											default:
												goto IL_0169;
											case 32:
												goto IL_0185;
											case 33:
												goto IL_01a7;
											case 34:
												goto end_IL_00a2;
											}
											goto IL_0096;
											IL_01a7:
											/*OpCode not supported: LdMemberToken*/;
											num6 = 3;
											goto end_IL_0132;
											IL_0185:
											switch (num5)
											{
											case -23:
												break;
											default:
												goto IL_019f;
											case -26:
												goto IL_01c5;
											case -25:
												goto IL_0204;
											case -24:
												goto IL_0213;
											}
											goto end_IL_01b5;
											IL_0204:
											/*OpCode not supported: LdMemberToken*/;
											num5 = -2;
											goto IL_0096;
											IL_01c5:
											switch (num4)
											{
											case 45:
												break;
											default:
												goto IL_01fb;
											case 35:
												goto end_IL_008a;
											case 36:
												goto IL_0231;
											case 37:
												goto IL_023d;
											case 38:
												goto IL_024a;
											case 39:
												goto IL_0274;
											case 40:
												goto IL_0284;
											case 41:
												goto IL_0293;
											case 42:
												goto IL_02a2;
											case 43:
												goto IL_02af;
											case 44:
												goto IL_02cd;
											}
											goto IL_0072;
											IL_02cd:
											/*OpCode not supported: LdMemberToken*/;
											num4 = 14;
											goto end_IL_01b5;
											IL_02af:
											switch (num10)
											{
											case -77:
												break;
											case -79:
												goto end_IL_008a;
											case -78:
												goto IL_024a;
											default:
												goto IL_02c5;
											}
											goto IL_0072;
											IL_02c5:
											num4 = 7;
											goto end_IL_01b5;
											IL_02a2:
											num10 = -5;
											num4 = 11;
											goto end_IL_01b5;
											IL_0293:
											if (num10 == 0)
											{
												num4 = 4;
												goto end_IL_01b5;
											}
											goto IL_007e;
											IL_00e4:
											num9 = -9;
											continue;
											IL_0284:
											if (num10 == 0)
											{
												num4 = 1;
												goto end_IL_01b5;
											}
											goto IL_007e;
											IL_00ae:
											num7 ^= 0x22;
											goto IL_00fa;
											IL_0274:
											if (num10 == 0)
											{
												num4 = 15;
												goto end_IL_01b5;
											}
											goto IL_007e;
											IL_00fa:
											num8 = -57;
											num9 = -10;
											continue;
											IL_007e:
											num10 ^= 0x48;
											goto IL_0213;
											IL_0213:
											num4 = 9;
											num5 = -16;
											goto IL_0096;
											IL_024a:
											switch (num3)
											{
											default:
												num4 = 6;
												goto end_IL_01b5;
											case -73:
												num12 = num11;
												num3 = -10;
												if (num3 != 0)
												{
													break;
												}
												goto case -72;
											case -72:
												if (num11 != 0 || 1 == 0)
												{
													num3 = -5;
													if (num3 != 0)
													{
														break;
													}
													goto case -71;
												}
												goto IL_039c;
											case -71:
												num11 = 0;
												num3 = -12;
												if (num3 != 0)
												{
													break;
												}
												goto case -70;
											case -70:
												switch (num12)
												{
												case 0:
													goto IL_0350;
												case 1:
													goto IL_035e;
												case 2:
													goto IL_036c;
												case 3:
													goto IL_037a;
												}
												num3 = -16;
												if (num3 != 0)
												{
													break;
												}
												goto case -69;
											case -69:
												iLGenerator = dynamicMethod.GetILGenerator();
												num3 = -11;
												if (num3 != 0)
												{
													break;
												}
												goto case -68;
											case -68:
												{
													iLGenerator.Emit(OpCodes.Ldarg_S, num11);
													goto IL_0396;
												}
												IL_039c:
												if (num11 >= num)
												{
													iLGenerator.Emit(OpCodes.Newobj, _E000);
													while (true)
													{
														int num13 = 25;
														int num14 = 2;
														while (true)
														{
															num14 ^= 0x20;
															while (true)
															{
																int num15 = -59;
																int num16 = 62;
																while (true)
																{
																	switch (num16 ^ 0x22)
																	{
																	case 28:
																		break;
																	default:
																		goto IL_03f5;
																	case 25:
																		/*OpCode not supported: LdMemberToken*/;
																		num16 = 59;
																		continue;
																	case 26:
																		goto IL_0407;
																	case 27:
																		goto end_IL_03d4;
																	}
																	goto IL_03cb;
																	IL_0407:
																	switch (num15)
																	{
																	case -31:
																		break;
																	default:
																		goto IL_0421;
																	case -34:
																		goto IL_0433;
																	case -33:
																		goto IL_0456;
																	case -32:
																		goto IL_0462;
																	}
																	goto end_IL_0427;
																	IL_0462:
																	/*OpCode not supported: LdMemberToken*/;
																	num15 = -5;
																	goto IL_03cb;
																	IL_0433:
																	switch (num14)
																	{
																	case 31:
																		goto end_IL_03c2;
																	case 32:
																		goto IL_048a;
																	case 33:
																		goto IL_04c9;
																	case 34:
																		goto IL_04fc;
																	}
																	num15 = -60;
																	goto IL_03cb;
																	IL_04fc:
																	if (num13 == 0)
																	{
																		goto IL_0511;
																	}
																	goto IL_03b6;
																	IL_04c9:
																	/*OpCode not supported: LdMemberToken*/;
																	num14 = 1;
																	goto end_IL_0427;
																	IL_048a:
																	switch (num13)
																	{
																	case 83:
																		goto IL_0511;
																	case 84:
																		goto IL_0542;
																	case 85:
																		goto IL_0574;
																	case 86:
																		return;
																	}
																	num14 = 63;
																	goto end_IL_0427;
																	IL_0511:
																	iLGenerator.Emit(OpCodes.Ret);
																	num13 = 31;
																	if (num13 == 0)
																	{
																		goto IL_0542;
																	}
																	goto IL_03b6;
																	IL_0542:
																	_E000.SetValue(null, value);
																	num13 = 28;
																	if (num13 == 0)
																	{
																		goto IL_0574;
																	}
																	goto IL_03b6;
																	IL_0574:
																	value = dynamicMethod.CreateDelegate(_E000);
																	num13 = 30;
																	goto IL_03b6;
																	IL_03b6:
																	num13 ^= 0x4A;
																	goto IL_0456;
																	IL_0456:
																	num14 = 0;
																	num15 = -6;
																	goto IL_03cb;
																	IL_03f5:
																	num16 = 56;
																	continue;
																	IL_03cb:
																	num15 ^= 0x1B;
																	goto IL_03f5;
																	IL_0421:
																	num16 = 57;
																	continue;
																	end_IL_03d4:
																	break;
																}
																continue;
																end_IL_0427:
																break;
															}
															continue;
															end_IL_03c2:
															break;
														}
													}
												}
												goto case -73;
												IL_0396:
												num11++;
												goto IL_039c;
												IL_037a:
												iLGenerator.Emit(OpCodes.Ldarg_3);
												goto IL_0396;
												IL_036c:
												iLGenerator.Emit(OpCodes.Ldarg_2);
												goto IL_0396;
												IL_035e:
												iLGenerator.Emit(OpCodes.Ldarg_1);
												goto IL_0396;
												IL_0350:
												iLGenerator.Emit(OpCodes.Ldarg_0);
												goto IL_0396;
											}
											goto IL_0072;
											IL_0231:
											num10 = -7;
											num4 = 5;
											goto end_IL_01b5;
											IL_01fb:
											num5 = -15;
											goto IL_0096;
											IL_0072:
											num3 ^= 0x4C;
											goto IL_023d;
											IL_023d:
											num10 = -6;
											num4 = 10;
											goto end_IL_01b5;
											IL_019f:
											num6 = 0;
											goto end_IL_0132;
											IL_0169:
											num7 = 60;
											goto IL_00ae;
											IL_0096:
											num5 ^= 0x19;
											goto IL_0144;
											IL_0144:
											num6 = 2;
											num7 = 3;
											goto IL_00ae;
											IL_012c:
											num8 = -58;
											break;
											IL_0106:
											/*OpCode not supported: LdMemberToken*/;
											num8 = -60;
											break;
										}
										break;
									}
									continue;
									end_IL_00b7:
									break;
								}
								continue;
								end_IL_0132:
								break;
							}
							continue;
							end_IL_00a2:
							break;
						}
						continue;
						end_IL_01b5:
						break;
					}
					continue;
					end_IL_008a:
					break;
				}
			}
		}
		goto IL_003a;
	}
}
internal sealed class _E00B
{
	private static byte[] m__E000;

	private static byte[] m__E001;

	static _E00B()
	{
		_E00B.m__E000 = new byte[4];
		_E00B.m__E001 = new byte[4];
		_E00B.m__E000[0] = (_E00B.m__E001[0] = 82);
		_E00B.m__E000[1] = (_E00B.m__E001[1] = 83);
		_E00B.m__E000[2] = (_E00B.m__E001[2] = 65);
		_E00B.m__E000[3] = 49;
		_E00B.m__E001[3] = 50;
	}

	public static MemoryStream _E000(Stream _E000)
	{
		BinaryReader binaryReader = new BinaryReader(_E000);
		DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		int num = binaryReader.ReadUInt16();
		byte[] array = new byte[num];
		binaryReader.Read(array, 0, num);
		byte[] array2 = new byte[4];
		binaryReader.Read(array2, 0, 4);
		for (int i = 0; i < num; i++)
		{
			array[i] = (byte)(array[i] ^ array2[i % 4]);
		}
		BinaryReader binaryReader2 = new BinaryReader(new MemoryStream(array, writable: false));
		binaryReader2.ReadString();
		bool flag = binaryReader2.ReadBoolean();
		bool flag2 = binaryReader2.ReadBoolean();
		int num2 = binaryReader2.ReadInt32();
		byte[] array3 = new byte[num2];
		binaryReader2.Read(array3, 0, num2);
		bool flag3 = binaryReader2.ReadBoolean();
		int num3 = binaryReader2.ReadByte();
		byte[] array4 = new byte[num3];
		RSACryptoServiceProvider rSACryptoServiceProvider = null;
		if (!flag3)
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			AssemblyName name = executingAssembly.GetName();
			byte[] publicKey = name.GetPublicKey();
			if (publicKey == null || publicKey.Length != 160)
			{
				throw new InvalidOperationException();
			}
			Buffer.BlockCopy(publicKey, 12, array4, 0, num3);
			array4[5] |= 128;
			rSACryptoServiceProvider = new RSACryptoServiceProvider();
			rSACryptoServiceProvider.ImportParameters(_E003(publicKey));
		}
		if (flag)
		{
			if (flag3)
			{
				binaryReader2.Read(array4, 0, num3);
			}
			int num4 = binaryReader2.ReadByte();
			byte[] array5 = new byte[num4];
			binaryReader2.Read(array5, 0, num4);
			dESCryptoServiceProvider.IV = array5;
			dESCryptoServiceProvider.Key = array4;
		}
		MemoryStream memoryStream = new MemoryStream();
		if (flag)
		{
			using CryptoStream cryptoStream = new CryptoStream(binaryReader.BaseStream, dESCryptoServiceProvider.CreateDecryptor(), CryptoStreamMode.Read);
			if (flag2)
			{
				_E011._E000(cryptoStream, memoryStream);
			}
			else
			{
				_E002(cryptoStream, memoryStream);
			}
		}
		else if (flag2)
		{
			_E011._E000(binaryReader.BaseStream, memoryStream);
		}
		else
		{
			_E002(binaryReader.BaseStream, memoryStream);
		}
		if (rSACryptoServiceProvider != null)
		{
			memoryStream.Position = 0L;
			if (!_E005(rSACryptoServiceProvider, memoryStream, array3))
			{
				throw new InvalidOperationException();
			}
		}
		memoryStream.Position = 0L;
		return memoryStream;
	}

	private static byte[] _E001(byte[] _E000, int _E000, int _E000)
	{
		if (_E000 == null || _E000.Length < _E000 + _E000)
		{
			return null;
		}
		byte[] array = new byte[_E000];
		Array.Copy(_E000, _E000, array, 0, _E000);
		return array;
	}

	private static void _E002(Stream _E000, Stream _E000)
	{
		byte[] array = new byte[4096];
		while (true)
		{
			int num = _E000.Read(array, 0, array.Length);
			if (num <= 0)
			{
				break;
			}
			_E000.Write(array, 0, num);
		}
	}

	private static RSAParameters _E003(byte[] _E000)
	{
		bool flag = _E000.Length == 160;
		if (flag && !_E004(_E000, _E00B.m__E000, 20))
		{
			return default(RSAParameters);
		}
		if (!flag && !_E004(_E000, _E00B.m__E001, 8))
		{
			return default(RSAParameters);
		}
		RSAParameters result = default(RSAParameters);
		int num = (flag ? 20 : 8);
		num += 8;
		int num2 = 4;
		result.Exponent = _E001(_E000, num, num2);
		Array.Reverse((Array)result.Exponent);
		num += num2;
		num2 = 128;
		result.Modulus = _E001(_E000, num, num2);
		Array.Reverse((Array)result.Modulus);
		if (flag)
		{
			return result;
		}
		num += num2;
		num2 = 64;
		result.P = _E001(_E000, num, num2);
		Array.Reverse((Array)result.P);
		num += num2;
		num2 = 64;
		result.Q = _E001(_E000, num, num2);
		Array.Reverse((Array)result.Q);
		num += num2;
		num2 = 64;
		result.DP = _E001(_E000, num, num2);
		Array.Reverse((Array)result.DP);
		num += num2;
		num2 = 64;
		result.DQ = _E001(_E000, num, num2);
		Array.Reverse((Array)result.DQ);
		num += num2;
		num2 = 64;
		result.InverseQ = _E001(_E000, num, num2);
		Array.Reverse((Array)result.InverseQ);
		num += num2;
		num2 = 128;
		result.D = _E001(_E000, num, num2);
		Array.Reverse((Array)result.D);
		return result;
	}

	private static bool _E004(byte[] _E000, byte[] _E000, int _E000)
	{
		for (int i = 0; i < _E000.Length; i++)
		{
			if (_E000[i + _E000] != _E000[i])
			{
				return false;
			}
		}
		return true;
	}

	private static bool _E005(RSACryptoServiceProvider _E000, Stream _E000, byte[] _E000)
	{
		SHA1CryptoServiceProvider sHA1CryptoServiceProvider = new SHA1CryptoServiceProvider();
		byte[] array = (array = sHA1CryptoServiceProvider.ComputeHash(_E000));
		string text = new string('S', 1);
		text += 'H';
		text += 'A';
		text += '1';
		return _E000.VerifyHash(array, CryptoConfig.MapNameToOID(text), _E000);
	}
}
internal sealed class _E00C
{
	private sealed class _E000
	{
		internal static int[] _E000(int[] _E000, int _E000)
		{
			int[] array = new int[_E000.Length];
			int[] array2 = new int[_E000.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = i;
			}
			Array.Copy(_E000, array2, _E000.Length);
			Array.Sort(array2, array);
			int j;
			for (j = 0; j < array2.Length && array2[j] == 0; j++)
			{
			}
			int[] array3 = new int[array2.Length - j];
			Array.Copy(array2, j, array3, 0, array3.Length);
			int[] array4 = ((array3.Length == 0) ? new int[0] : ((array3.Length != 1) ? _E001(array3, _E000) : new int[1] { 1 }));
			int[] array5 = new int[_E000.Length];
			for (int k = 0; k < array4.Length; k++)
			{
				array5[array[k + j]] = array4[k];
			}
			return array5;
		}

		private static int[] _E001(int[] _E000, int _E000)
		{
			int num = _E000.Length;
			int[][] array = new int[_E000][];
			array[0] = _E000;
			int[] array2 = new int[_E000.Length / 2];
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = _E000[i * 2] + _E000[i * 2 + 1];
			}
			for (int j = 1; j < _E000; j++)
			{
				int[] array3 = (array[j] = _E002(array2, _E000));
				array2 = new int[array3.Length / 2];
				for (int k = 0; k < array2.Length; k++)
				{
					array2[k] = array3[k * 2] + array3[k * 2 + 1];
				}
			}
			int[] array4 = new int[num];
			int num2 = num - 1;
			for (int num3 = _E000 - 1; num3 >= 0; num3--)
			{
				int[] array5 = array[num3];
				int num4 = 0;
				int num5 = 0;
				for (int l = 0; l < num2 * 2; l++)
				{
					if (num5 < _E000.Length && _E000[num5] == array5[l])
					{
						array4[num5]++;
						num5++;
					}
					else
					{
						num4++;
					}
				}
				num2 = num4;
			}
			return array4;
		}

		private static int[] _E002(int[] _E000, int[] _E000)
		{
			int[] array = new int[_E000.Length + _E000.Length];
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			while (num < _E000.Length && num2 < _E000.Length)
			{
				if (_E000[num] < _E000[num2])
				{
					array[num3++] = _E000[num++];
				}
				else
				{
					array[num3++] = _E000[num2++];
				}
			}
			while (num < _E000.Length)
			{
				array[num3++] = _E000[num++];
			}
			while (num2 < _E000.Length)
			{
				array[num3++] = _E000[num2++];
			}
			return array;
		}

		static _E000()
		{
		}
	}

	private struct _E001
	{
		internal _E00E _E000;

		internal ushort _E001;
	}

	internal static _E00E[] _E000;

	internal static _E00E[] _E001;

	internal static _E010 _E002;

	internal static readonly int[] _E003;

	internal static readonly int[] _E004;

	internal static readonly int[] _E005;

	internal static readonly int[] _E006;

	internal static readonly int[] _E007;

	static _E00C()
	{
		global::_E00C._E000 = new _E00E[288];
		global::_E00C._E001 = new _E00E[32];
		global::_E00C._E003 = new int[19];
		global::_E00C._E003[0] = 16;
		global::_E00C._E003[1] = 17;
		global::_E00C._E003[2] = 18;
		global::_E00C._E003[4] = 8;
		global::_E00C._E003[5] = 7;
		global::_E00C._E003[6] = 9;
		global::_E00C._E003[7] = 6;
		global::_E00C._E003[8] = 10;
		global::_E00C._E003[9] = 5;
		global::_E00C._E003[10] = 11;
		global::_E00C._E003[11] = 4;
		global::_E00C._E003[12] = 12;
		global::_E00C._E003[13] = 3;
		global::_E00C._E003[14] = 13;
		global::_E00C._E003[15] = 2;
		global::_E00C._E003[16] = 14;
		global::_E00C._E003[17] = 1;
		global::_E00C._E003[18] = 15;
		global::_E00C._E004 = new int[29];
		global::_E00C._E004[0] = 3;
		global::_E00C._E004[1] = 4;
		global::_E00C._E004[2] = 5;
		global::_E00C._E004[3] = 6;
		global::_E00C._E004[4] = 7;
		global::_E00C._E004[5] = 8;
		global::_E00C._E004[6] = 9;
		global::_E00C._E004[7] = 10;
		global::_E00C._E004[8] = 11;
		global::_E00C._E004[9] = 13;
		global::_E00C._E004[10] = 15;
		global::_E00C._E004[11] = 17;
		global::_E00C._E004[12] = 19;
		global::_E00C._E004[13] = 23;
		global::_E00C._E004[14] = 27;
		global::_E00C._E004[15] = 31;
		global::_E00C._E004[16] = 35;
		global::_E00C._E004[17] = 43;
		global::_E00C._E004[18] = 51;
		global::_E00C._E004[19] = 59;
		global::_E00C._E004[20] = 67;
		global::_E00C._E004[21] = 83;
		global::_E00C._E004[22] = 99;
		global::_E00C._E004[23] = 115;
		global::_E00C._E004[24] = 131;
		global::_E00C._E004[25] = 163;
		global::_E00C._E004[26] = 195;
		global::_E00C._E004[27] = 227;
		global::_E00C._E004[28] = 258;
		global::_E00C._E005 = new int[29];
		int i = 8;
		int num = 0;
		for (; i < 28; i++)
		{
			if (i % 4 == 0)
			{
				num++;
			}
			global::_E00C._E005[i] = num;
		}
		global::_E00C._E006 = new int[30];
		global::_E00C._E006[0] = 1;
		global::_E00C._E006[1] = 2;
		global::_E00C._E006[2] = 3;
		global::_E00C._E006[3] = 4;
		global::_E00C._E006[4] = 5;
		global::_E00C._E006[5] = 7;
		global::_E00C._E006[6] = 9;
		global::_E00C._E006[7] = 13;
		global::_E00C._E006[8] = 17;
		global::_E00C._E006[9] = 25;
		global::_E00C._E006[10] = 33;
		global::_E00C._E006[11] = 49;
		global::_E00C._E006[12] = 65;
		global::_E00C._E006[13] = 97;
		global::_E00C._E006[14] = 129;
		global::_E00C._E006[15] = 193;
		global::_E00C._E006[16] = 257;
		global::_E00C._E006[17] = 385;
		global::_E00C._E006[18] = 513;
		global::_E00C._E006[19] = 769;
		global::_E00C._E006[20] = 1025;
		global::_E00C._E006[21] = 1537;
		global::_E00C._E006[22] = 2049;
		global::_E00C._E006[23] = 3073;
		global::_E00C._E006[24] = 4097;
		global::_E00C._E006[25] = 6145;
		global::_E00C._E006[26] = 8193;
		global::_E00C._E006[27] = 12289;
		global::_E00C._E006[28] = 16385;
		global::_E00C._E006[29] = 24577;
		global::_E00C._E007 = new int[30];
		int j = 4;
		int num2 = 0;
		for (; j < 30; j++)
		{
			if (j % 2 == 0)
			{
				num2++;
			}
			global::_E00C._E007[j] = num2;
		}
		for (int k = 0; k <= 143; k++)
		{
			global::_E00C._E000[k]._E000 = 48 + k;
			global::_E00C._E000[k]._E001 = 8;
		}
		for (int l = 144; l <= 255; l++)
		{
			global::_E00C._E000[l]._E000 = 400 + l - 144;
			global::_E00C._E000[l]._E001 = 9;
		}
		for (int m = 256; m <= 279; m++)
		{
			global::_E00C._E000[m]._E000 = m - 256;
			global::_E00C._E000[m]._E001 = 7;
		}
		for (int n = 280; n <= 287; n++)
		{
			global::_E00C._E000[n]._E000 = 192 + n - 280;
			global::_E00C._E000[n]._E001 = 8;
		}
		for (int num3 = 0; num3 <= 31; num3++)
		{
			global::_E00C._E001[num3]._E000 = num3;
			global::_E00C._E001[num3]._E001 = 5;
		}
		global::_E00C._E002 = _E004(global::_E00C._E000, global::_E00C._E001);
	}

	internal static int _E000(int[] _E000, int[] _E000)
	{
		int num = 0;
		for (int i = 0; i < _E000.Length; i++)
		{
			num += _E000[i] * _E000[i];
		}
		return num;
	}

	internal static int _E001(int[] _E000, int[] _E000)
	{
		int num = 0;
		for (int i = 0; i < _E000.Length; i++)
		{
			num += _E000[i] * global::_E00C._E000[i]._E001;
		}
		for (int j = 0; j < _E000.Length; j++)
		{
			num += _E000[j] * global::_E00C._E001[j]._E001;
		}
		return num;
	}

	internal static _E00E[] _E002(int[] _E000)
	{
		_E00E[] array = new _E00E[_E000.Length];
		for (int i = 0; i < _E000.Length; i++)
		{
			array[i]._E001 = _E000[i];
		}
		_E003(array);
		return array;
	}

	internal static void _E003(_E00E[] _E000)
	{
		int num = _E000[0]._E001;
		for (int i = 1; i < _E000.Length; i++)
		{
			if (num < _E000[i]._E001)
			{
				num = _E000[i]._E001;
			}
		}
		int[] array = new int[num + 1];
		for (int j = 0; j < _E000.Length; j++)
		{
			array[_E000[j]._E001]++;
		}
		int[] array2 = new int[num + 1];
		int num2 = 0;
		array[0] = 0;
		for (int k = 1; k <= num; k++)
		{
			num2 = (array2[k] = num2 + array[k - 1] << 1);
		}
		for (int l = 0; l < _E000.Length; l++)
		{
			int num3 = _E000[l]._E001;
			if (num3 != 0)
			{
				_E000[l]._E000 = array2[num3];
				array2[num3]++;
			}
		}
	}

	internal static _E010 _E004(_E00E[] _E000, _E00E[] _E000)
	{
		_E010 obj = new _E010();
		obj._E000 = _E005(_E000);
		obj._E001 = _E005(_E000);
		return obj;
	}

	internal static _E00F _E005(_E00E[] _E000)
	{
		_E001[] array = new _E001[_E000.Length];
		int num = 0;
		for (int i = 0; i < _E000.Length; i++)
		{
			if (_E000[i]._E001 > 0)
			{
				_E001 obj = default(_E001);
				obj._E000 = _E000[i];
				obj._E001 = (ushort)i;
				array[num++] = obj;
			}
		}
		return _E006(array, num, 0, 0);
	}

	private static _E00F _E006(_E001[] _E000, int _E000, int _E000, int _E000)
	{
		_E001[] array = new _E001[_E000];
		_E001[] array2 = new _E001[_E000];
		_E00F obj = new _E00F();
		obj._E000 = false;
		int num;
		int num2 = (num = 0);
		for (int i = 0; i < _E000; i++)
		{
			_E001 obj2 = _E000[i];
			if (obj2._E000._E001 == _E000 && obj2._E000._E000 == _E000)
			{
				obj._E000 = true;
				obj._E001 = obj2._E001;
			}
			else if (((uint)(obj2._E000._E000 >> obj2._E000._E001 - _E000 - 1) & (true ? 1u : 0u)) != 0)
			{
				array2[num2++] = obj2;
			}
			else
			{
				array[num++] = obj2;
			}
		}
		if (!obj._E000)
		{
			if (num > 0)
			{
				obj._E002 = _E006(array, num, _E000 << 1, _E000 + 1);
			}
			if (num2 > 0)
			{
				obj._E003 = _E006(array2, num2, (_E000 << 1) | 1, _E000 + 1);
			}
		}
		return obj;
	}

	internal static void _E007(int _E000, out int _E000, out int _E000)
	{
		_E000 = global::_E00C._E004[_E000 - 257];
		_E000 = global::_E00C._E005[_E000 - 257];
	}

	internal static void _E008(int _E000, out int _E000, out int _E000, out int _E000)
	{
		int num = Array.BinarySearch(global::_E00C._E004, _E000);
		if (num < 0)
		{
			num = ~num - 1;
		}
		_E000 = num + 257;
		_E000 -= global::_E00C._E004[num];
		_E000 = global::_E00C._E005[num];
	}

	internal static void _E009(int _E000, out int _E000, out int _E000, out int _E000)
	{
		int num = Array.BinarySearch(global::_E00C._E006, _E000);
		if (num < 0)
		{
			num = ~num - 1;
		}
		_E000 = num;
		_E000 -= global::_E00C._E006[num];
		_E000 = global::_E00C._E007[num];
	}

	internal static int[] _E00A(int[] _E000, int _E000)
	{
		return global::_E00C._E000._E000(_E000, _E000);
	}

	internal static int[] _E00B(int[] _E000)
	{
		return global::_E00C._E000._E000(_E000, 15);
	}

	internal static int _E00C(int _E000)
	{
		return _E000 switch
		{
			16 => 2, 
			17 => 3, 
			18 => 7, 
			_ => 0, 
		};
	}

	internal static int[] _E00D(int[] _E000, int _E000, int _E000)
	{
		_E00D obj = new _E00D();
		int num = 0;
		while (num < _E000)
		{
			if (_E000[_E000 + num] == 0)
			{
				int num2 = 0;
				do
				{
					num2++;
				}
				while (num + num2 < _E000 && num2 < 138 && _E000[_E000 + num + num2] == 0);
				if (num2 < 3)
				{
					if (num2 >= 1)
					{
						obj._E000(0);
					}
					if (num2 >= 2)
					{
						obj._E000(0);
					}
				}
				else if (num2 < 11)
				{
					obj._E000(17);
					obj._E000(num2 - 3);
				}
				else
				{
					obj._E000(18);
					obj._E000(num2 - 11);
				}
				num += num2;
			}
			else
			{
				int num3 = _E000[_E000 + num++];
				obj._E000(num3);
				int i;
				for (i = 0; num + i < _E000 && i < 6 && _E000[_E000 + num + i] == num3; i++)
				{
				}
				if (i >= 3)
				{
					obj._E000(16);
					obj._E000(i - 3);
					num += i;
				}
			}
		}
		return obj._E001();
	}
}
[DefaultMember("Item")]
internal sealed class _E00D
{
	private int[] m__E000;

	private int m__E001;

	public int _E000 => this.m__E001;

	public int _E001 => this.m__E000[index];

	public _E00D()
	{
		this.m__E000 = new int[16];
	}

	public int _E000(int _E000)
	{
		if (this.m__E001 == this.m__E000.Length)
		{
			int[] array = new int[this.m__E001 * 2];
			Array.Copy(this.m__E000, 0, array, 0, this.m__E001);
			this.m__E000 = array;
		}
		this.m__E000[this.m__E001] = _E000;
		return this.m__E001++;
	}

	public int[] _E001()
	{
		int[] array = new int[this.m__E001];
		Array.Copy(this.m__E000, 0, array, 0, this.m__E001);
		return array;
	}

	static _E00D()
	{
	}
}
internal struct _E00E
{
	public int _E000;

	public int _E001;
}
internal sealed class _E00F
{
	internal bool _E000;

	internal ushort _E001;

	internal _E00F _E002;

	internal _E00F _E003;

	static _E00F()
	{
	}
}
internal sealed class _E010
{
	internal _E00F _E000;

	internal _E00F _E001;

	static _E010()
	{
	}
}
internal sealed class _E011
{
	public sealed class _E000
	{
		private _E002 m__E000 = new _E002(32769);

		private _E001 m__E001;

		private _E010 m__E002;

		private int m__E003 = -1;

		private int m__E004 = -1;

		private bool m__E005;

		private int m__E006;

		private long m__E007;

		private long m__E008;

		private bool m__E009;

		private int m__E00A;

		private bool _E00B;

		public _E000(Stream _E000)
		{
			this.m__E001 = new _E001(_E000);
		}

		public int _E000(byte[] _E000, int _E000, int _E000)
		{
			if (((_E000 == 0) ? true : false) || this.m__E009 || 1 == 0)
			{
				return 0;
			}
			int num = 0;
			if (num != 0)
			{
				goto IL_002f;
			}
			goto IL_00c5;
			IL_00da:
			return num;
			IL_003e:
			if (this.m__E003 < 0 && ((!this.m__E009) ? true : false))
			{
				goto IL_002f;
			}
			if (!this.m__E009 && 0 == 0)
			{
				int num2 = _E002(_E000, _E000 + num, _E000 - num);
				while (true)
				{
					int num3 = _E011._E001(95);
					while (true)
					{
						switch (num3)
						{
						case 0:
							num += num2;
							num3 = 2;
							continue;
						case 1:
							goto IL_009e;
						case 2:
							goto end_IL_008c;
						}
						break;
						IL_009e:
						if (num2 > 0)
						{
							num3 = 0;
							continue;
						}
						this.m__E003 = -1;
						goto end_IL_008c;
					}
					continue;
					end_IL_008c:
					break;
				}
				goto IL_00c5;
			}
			goto IL_00da;
			IL_00c5:
			if (num >= _E000)
			{
				goto IL_00da;
			}
			goto IL_003e;
			IL_002f:
			this.m__E009 = !_E001();
			goto IL_003e;
		}

		private bool _E001()
		{
			if (this.m__E005 || 1 == 0)
			{
				return false;
			}
			this.m__E007 = this.m__E001._E004;
			int num2 = default(int);
			while (true)
			{
				int num = _E011._E001(94);
				while (true)
				{
					switch (num)
					{
					case 0:
						if (this.m__E003 == 1)
						{
							num = 6;
							continue;
						}
						if (this.m__E003 == 14)
						{
							_E00E[] array = _E00C._E000;
							while (true)
							{
								int num3 = _E011._E001(94);
								while (true)
								{
									switch (num3)
									{
									case 0:
										this.m__E002 = _E00C._E002;
										num3 = 3;
										continue;
									case 1:
										this.m__E006 = 0;
										num3 = 0;
										continue;
									case 2:
									{
										_E00E[] array2 = _E00C._E001;
										num3 = 1;
										continue;
									}
									case 3:
										_E00B = false;
										num3 = 4;
										continue;
									case 4:
										goto end_IL_00fd;
									}
									break;
								}
								continue;
								end_IL_00fd:
								break;
							}
						}
						else if (this.m__E003 == 3)
						{
							_E009(this.m__E001, out var array, out var array2);
							while (true)
							{
								int num4 = _E011._E001(92);
								while (true)
								{
									switch (num4)
									{
									case 0:
										this.m__E006 = 0;
										num4 = 1;
										continue;
									case 1:
										this.m__E002 = _E00C._E004(array, array2);
										num4 = 2;
										continue;
									case 2:
										goto end_IL_0171;
									}
									break;
								}
								continue;
								end_IL_0171:
								break;
							}
							_E00B = false;
						}
						goto case 8;
					case 1:
						_E00B = true;
						num = 8;
						continue;
					case 2:
						this.m__E005 = this.m__E001._E000(1) > 0;
						num = 7;
						continue;
					case 3:
						this.m__E006 = num2;
						num = 5;
						continue;
					case 4:
						num2 = this.m__E001._E000(16) ^ 0xB64A;
						num = 3;
						continue;
					case 5:
						this.m__E002 = null;
						num = 1;
						continue;
					case 6:
						this.m__E001._E001();
						num = _E011._E001(96);
						continue;
					case 7:
						this.m__E003 = this.m__E001._E000(4);
						num = 0;
						continue;
					case 8:
						this.m__E008 = this.m__E001._E004;
						return true;
					}
					break;
				}
			}
		}

		private int _E002(byte[] _E000, int _E000, int _E000)
		{
			int num = _E000;
			if (this.m__E003 == 1)
			{
				if (this.m__E006 > 0)
				{
					int num2 = Math.Min(_E000, this.m__E006);
					while (true)
					{
						int num3 = _E011._E001(89);
						while (true)
						{
							switch (num3)
							{
							case 0:
								_E000 += num2;
								num3 = 5;
								continue;
							case 1:
								this.m__E006 -= num2;
								num3 = 2;
								continue;
							case 2:
								_E000 -= num2;
								num3 = 0;
								continue;
							case 3:
								this.m__E001._E002(_E000, _E000, num2);
								num3 = _E011._E001(96);
								continue;
							case 4:
								this.m__E000._E001(_E000, _E000, num2);
								num3 = 1;
								continue;
							case 5:
								goto end_IL_004c;
							}
							break;
						}
						continue;
						end_IL_004c:
						break;
					}
				}
			}
			else if (!_E00B && 0 == 0)
			{
				if (this.m__E00A > 0)
				{
					_E003(_E000, ref _E000, ref _E000);
				}
				if (_E000 > 0)
				{
					int num8 = default(int);
					do
					{
						int num4 = _E006(this.m__E001, this.m__E002._E000);
						_E00B = num4 == 256;
						if (_E00B ? true : false)
						{
							break;
						}
						if (num4 < 256)
						{
							_E000[_E000++] = (byte)num4;
							while (true)
							{
								int num5 = _E011._E001(92);
								while (true)
								{
									switch (num5)
									{
									case 0:
										this.m__E000._E000((byte)num4);
										num5 = 1;
										continue;
									case 1:
										_E000--;
										num5 = 2;
										continue;
									case 2:
										goto end_IL_0145;
									}
									break;
								}
								continue;
								end_IL_0145:
								break;
							}
						}
						else
						{
							if (num4 > 285)
							{
								continue;
							}
							int num6 = _E007(this.m__E001, num4);
							while (true)
							{
								int num7 = _E011._E001(94);
								while (true)
								{
									switch (num7)
									{
									case 0:
										this.m__E004 = num8;
										num7 = 1;
										continue;
									case 1:
										this.m__E00A = num6;
										num7 = 3;
										continue;
									case 2:
										num8 = _E008(this.m__E001, this.m__E002._E001);
										num7 = 0;
										continue;
									case 3:
										goto end_IL_01a4;
									}
									break;
								}
								continue;
								end_IL_01a4:
								break;
							}
							_E003(_E000, ref _E000, ref _E000);
						}
					}
					while (_E000 > 0);
				}
			}
			this.m__E008 = this.m__E001._E004;
			return _E000 - num;
		}

		private void _E003(byte[] _E000, ref int _E000, ref int _E000)
		{
			int num = Math.Min(this.m__E00A, _E000);
			byte[] array = this.m__E000._E002(this.m__E004, Math.Min(num, this.m__E004));
			while (true)
			{
				int num2 = _E011._E001(95);
				while (true)
				{
					switch (num2)
					{
					case 0:
						this.m__E00A -= num;
						num2 = 2;
						continue;
					case 1:
						_E000 -= num;
						num2 = 0;
						continue;
					case 2:
						while (num > array.Length)
						{
							Array.Copy(array, 0, _E000, _E000, array.Length);
							while (true)
							{
								int num3 = _E011._E001(92);
								while (true)
								{
									switch (num3)
									{
									case 0:
										_E000 += array.Length;
										num3 = 1;
										continue;
									case 1:
										num -= array.Length;
										num3 = 2;
										continue;
									case 2:
										goto end_IL_0081;
									}
									break;
								}
								continue;
								end_IL_0081:
								break;
							}
							this.m__E000._E001(array, 0, array.Length);
						}
						Array.Copy(array, 0, _E000, _E000, num);
						_E000 += num;
						this.m__E000._E001(array, 0, num);
						return;
					}
					break;
				}
			}
		}

		public bool _E004(int _E000)
		{
			byte[] array = new byte[1024];
			int num;
			while (_E000 > 0 && (num = this._E000(array, 0, Math.Min(1024, _E000))) > 0)
			{
				_E000 -= num;
			}
			return _E000 <= 0;
		}

		public void _E005()
		{
			byte[] array = new byte[1024];
			while (_E000(array, 0, 1024) > 0)
			{
			}
		}

		private static int _E006(_E001 _E000, _E00F _E000)
		{
			while (_E000 != null && ((!_E000._E000) ? true : false))
			{
				_E000 = ((_E000._E000(1) > 0) ? _E000._E003 : _E000._E002);
			}
			return _E000._E001;
		}

		private static int _E007(_E001 _E000, int _E000)
		{
			_E00C._E007(_E000, out var num, out var num2);
			if (num2 > 0)
			{
				return num + _E000._E000(num2);
			}
			return num;
		}

		private static int _E008(_E001 _E000, _E00F _E000)
		{
			int num = _E006(_E000, _E000);
			int num3 = default(int);
			int num5 = default(int);
			int num4 = default(int);
			while (true)
			{
				int num2 = _E011._E001(92);
				while (true)
				{
					switch (num2)
					{
					case 0:
						num3 = _E00C._E006[num];
						num2 = 3;
						continue;
					case 1:
						if (num5 > 0)
						{
							num2 = _E011._E001(94);
							continue;
						}
						return num3;
					case 2:
						num4 = _E000._E000(num5);
						num2 = 4;
						continue;
					case 3:
						num5 = _E00C._E007[num];
						num2 = 1;
						continue;
					case 4:
						return num3 + num4;
					}
					break;
				}
			}
		}

		private void _E009(_E001 _E000, out _E00E[] _E000, out _E00E[] _E000)
		{
			int num = _E000._E000(5) + 257;
			int[] array = default(int[]);
			int[] array4 = default(int[]);
			int num3 = default(int);
			int num5 = default(int);
			int num4 = default(int);
			int[] array3 = default(int[]);
			_E00F obj = default(_E00F);
			int num7 = default(int);
			int num9 = default(int);
			while (true)
			{
				int num2 = _E011._E001(94);
				while (true)
				{
					switch (num2)
					{
					case 0:
						array[array4[num3]] = _E000._E000(3);
						num2 = 7;
						continue;
					case 1:
						array = new int[19];
						num2 = 5;
						continue;
					case 2:
						num5 = _E000._E000(5) + 1;
						num2 = _E011._E001(88);
						continue;
					case 3:
						array4 = _E00C._E003;
						num2 = 1;
						continue;
					case 4:
						if (num3 != 0)
						{
							num2 = 0;
							continue;
						}
						goto IL_0091;
					case 5:
						num3 = 0;
						num2 = 4;
						continue;
					case 6:
						num4 = _E000._E000(4) + 4;
						num2 = 3;
						continue;
					case 7:
						{
							num3++;
							goto IL_0091;
						}
						IL_0091:
						if (num3 >= num4)
						{
							_E00E[] array2 = _E00C._E002(array);
							while (true)
							{
								int num6 = _E011._E001(94);
								while (true)
								{
									switch (num6)
									{
									case 0:
										array3 = _E00A(_E000, obj, num + num5);
										num6 = 3;
										continue;
									case 1:
										num7 = 0;
										num6 = 5;
										continue;
									case 2:
										obj = _E00C._E005(array2);
										num6 = 0;
										continue;
									case 3:
										_E000 = new _E00E[num];
										num6 = 1;
										continue;
									case 4:
										_E000[num7]._E001 = array3[num7];
										num6 = _E011._E001(88);
										continue;
									case 5:
										if (num7 != 0)
										{
											num6 = 4;
											continue;
										}
										goto IL_0137;
									case 6:
										{
											num7++;
											goto IL_0137;
										}
										IL_0137:
										if (num7 >= num)
										{
											_E00C._E003(_E000);
											while (true)
											{
												int num8 = _E011._E001(89);
												while (true)
												{
													switch (num8)
													{
													case 0:
														num9++;
														num8 = 5;
														continue;
													case 1:
														num9 = 0;
														num8 = _E011._E001(94);
														continue;
													case 2:
														if (num9 != 0)
														{
															num8 = 4;
															continue;
														}
														goto case 5;
													case 3:
														_E000 = new _E00E[num5];
														num8 = 1;
														continue;
													case 4:
														_E000[num9]._E001 = array3[num9 + num];
														num8 = 0;
														continue;
													case 5:
														if (num9 < num5)
														{
															goto case 4;
														}
														_E00C._E003(_E000);
														return;
													}
													break;
												}
											}
										}
										goto case 4;
									}
									break;
								}
							}
						}
						goto case 0;
					}
					break;
				}
			}
		}

		private static int[] _E00A(_E001 _E000, _E00F _E000, int _E000)
		{
			int[] array = new int[_E000];
			int num = 0;
			if (num != 0)
			{
				goto IL_0017;
			}
			goto IL_0137;
			IL_0137:
			if (num < _E000)
			{
				goto IL_0017;
			}
			return array;
			IL_0017:
			int num2 = _E006(_E000, _E000);
			int num6 = default(int);
			int num8 = default(int);
			while (true)
			{
				int num3 = _E011._E001(95);
				while (true)
				{
					switch (num3)
					{
					case 0:
						array[num] = num2;
						num3 = 2;
						continue;
					case 1:
						goto IL_0048;
					case 2:
						goto IL_012b;
					}
					break;
					IL_0048:
					if (num2 < 16)
					{
						num3 = 0;
						continue;
					}
					if (num2 == 16)
					{
						int num4 = _E000._E000(2) + 3;
						while (true)
						{
							int num5 = _E011._E001(95);
							while (true)
							{
								switch (num5)
								{
								case 0:
									array[num + num6] = array[num - 1];
									num5 = 3;
									continue;
								case 1:
									num6 = 0;
									num5 = 2;
									continue;
								case 2:
									if (num6 != 0)
									{
										num5 = _E011._E001(92);
										continue;
									}
									goto IL_00ba;
								case 3:
									{
										num6++;
										goto IL_00ba;
									}
									IL_00ba:
									if (num6 >= num4)
									{
										goto end_IL_0082;
									}
									goto case 0;
								}
								break;
							}
							continue;
							end_IL_0082:
							break;
						}
						num += num4 - 1;
					}
					else if (num2 == 17)
					{
						while (true)
						{
							int num7 = _E011._E001(95);
							while (true)
							{
								switch (num7)
								{
								case 0:
									num += num8 - 1;
									num7 = 2;
									continue;
								case 1:
									num8 = _E000._E000(3) + 3;
									num7 = 0;
									continue;
								case 2:
									goto end_IL_00e1;
								}
								break;
							}
							continue;
							end_IL_00e1:
							break;
						}
					}
					else if (num2 == 18)
					{
						int num9 = _E000._E000(7) + 11;
						num += num9 - 1;
					}
					goto IL_012b;
					IL_012b:
					num++;
					goto end_IL_0034;
				}
				continue;
				end_IL_0034:
				break;
			}
			goto IL_0137;
		}

		static _E000()
		{
		}
	}

	private sealed class _E001
	{
		private uint m__E000;

		private int m__E001;

		private int m__E002;

		private Stream _E003;

		internal long _E004;

		internal _E001(Stream _E000)
		{
			_E003 = _E000;
		}

		internal int _E000(int _E000)
		{
			_E004 += _E000;
			for (int num = _E000 - (this.m__E002 - this.m__E001); num > 0; num -= 8)
			{
				this.m__E000 |= checked((uint)_E003.ReadByte()) << this.m__E002;
				this.m__E002 += 8;
			}
			int result = (int)(this.m__E000 >> this.m__E001) & ((1 << _E000) - 1);
			while (true)
			{
				int num2 = _E011._E001(89);
				while (true)
				{
					switch (num2)
					{
					case 0:
						if (this.m__E002 == this.m__E001)
						{
							num2 = 2;
							continue;
						}
						if (this.m__E001 >= 8)
						{
							this.m__E000 >>= this.m__E001;
							while (true)
							{
								int num3 = _E011._E001(92);
								while (true)
								{
									switch (num3)
									{
									case 0:
										this.m__E002 -= this.m__E001;
										num3 = 1;
										continue;
									case 1:
										this.m__E001 = 0;
										num3 = 2;
										continue;
									case 2:
										goto end_IL_011f;
									}
									break;
								}
								continue;
								end_IL_011f:
								break;
							}
						}
						goto case 4;
					case 1:
						this.m__E000 = 0u;
						num2 = _E011._E001(96);
						continue;
					case 2:
						this.m__E002 = (this.m__E001 = 0);
						num2 = 1;
						continue;
					case 3:
						this.m__E001 += _E000;
						num2 = 0;
						continue;
					case 4:
						return result;
					}
					break;
				}
			}
		}

		internal void _E001()
		{
			if (this.m__E002 != this.m__E001)
			{
				_E004 += this.m__E002 - this.m__E001;
			}
			this.m__E002 = (this.m__E001 = 0);
			this.m__E000 = 0u;
		}

		internal void _E002(byte[] _E000, int _E000, int _E000)
		{
			int num = _E003.Read(_E000, _E000, _E000);
			_E004 += num << 3;
		}

		static _E001()
		{
		}
	}

	private sealed class _E002
	{
		private byte[] m__E000;

		private int m__E001;

		internal int _E002;

		internal long _E003;

		internal _E002(int _E000)
		{
			this._E002 = _E000;
			this.m__E000 = new byte[_E000];
		}

		internal void _E000(byte _E000)
		{
			this.m__E000[this.m__E001++] = _E000;
			if (this.m__E001 >= this._E002)
			{
				this.m__E001 = 0;
			}
			_E003++;
		}

		internal void _E001(byte[] _E000, int _E000, int _E000)
		{
			_E003 += _E000;
			if (_E000 >= this._E002)
			{
				Array.Copy(_E000, _E000, this.m__E000, 0, this._E002);
				this.m__E001 = 0;
				return;
			}
			if (this.m__E001 + _E000 > this._E002)
			{
				int num = this._E002 - this.m__E001;
				int num3 = default(int);
				while (true)
				{
					int num2 = _E011._E001(89);
					while (true)
					{
						switch (num2)
						{
						case 0:
							this.m__E001 = num3;
							num2 = 4;
							continue;
						case 1:
							Array.Copy(_E000, _E000, this.m__E000, this.m__E001, num);
							num2 = 2;
							continue;
						case 2:
							Array.Copy(_E000, _E000 + num, this.m__E000, 0, num3);
							num2 = 0;
							continue;
						case 3:
							num3 = this.m__E001 + _E000 - this._E002;
							num2 = 1;
							continue;
						case 4:
							return;
						}
						break;
					}
				}
			}
			Array.Copy(_E000, _E000, this.m__E000, this.m__E001, _E000);
			while (true)
			{
				int num4 = _E011._E001(92);
				while (true)
				{
					switch (num4)
					{
					case 0:
						this.m__E001 += _E000;
						num4 = 1;
						continue;
					case 1:
						if (this.m__E001 != this._E002)
						{
							return;
						}
						num4 = 2;
						continue;
					case 2:
						this.m__E001 = 0;
						return;
					}
					break;
				}
			}
		}

		internal byte[] _E002(int _E000, int _E000)
		{
			byte[] array = new byte[_E000];
			if (this.m__E001 >= _E000)
			{
				Array.Copy(this.m__E000, this.m__E001 - _E000, array, 0, _E000);
			}
			else
			{
				int num = _E000 - this.m__E001;
				while (true)
				{
					int num2 = _E011._E001(95);
					while (true)
					{
						switch (num2)
						{
						case 0:
							Array.Copy(this.m__E000, 0, array, num, _E000 - num);
							num2 = 3;
							continue;
						case 1:
							goto IL_005f;
						case 2:
							Array.Copy(this.m__E000, this._E002 - num, array, 0, num);
							num2 = _E011._E001(92);
							continue;
						case 3:
							goto end_IL_0040;
						}
						break;
						IL_005f:
						if (num < _E000)
						{
							num2 = 2;
							continue;
						}
						Array.Copy(this.m__E000, this._E002 - num, array, 0, _E000);
						goto end_IL_0040;
					}
					continue;
					end_IL_0040:
					break;
				}
			}
			return array;
		}

		static _E002()
		{
		}
	}

	public static void _E000(Stream _E000, Stream _E000)
	{
		byte[] array = new byte[4096];
		_E000 obj = new _E000(_E000);
		while (true)
		{
			int num = obj._E000(array, 0, array.Length);
			if (num <= 0)
			{
				break;
			}
			_E000.Write(array, 0, num);
		}
	}

	internal static int _E001(int _E000)
	{
		return _E000 switch
		{
			89 => 3, 
			96 => 4, 
			92 => 0, 
			95 => 1, 
			94 => 2, 
			88 => 6, 
			_ => -1, 
		};
	}

	static _E011()
	{
	}
}
internal sealed class _E012
{
	public sealed class _E000 : Stream, IDisposable
	{
		private Stream m__E000;

		private bool m__E001;

		private bool m__E002;

		private _E001 _E003;

		private byte[] _E004;

		private int _E005;

		public Stream _E000 => this.m__E000;

		public override bool CanSeek => false;

		public override bool CanRead => false;

		public override bool CanWrite => true;

		public override long Length => 0L;

		public override long Position
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public _E000(Stream _E000)
			: this(_E000, _E000: false)
		{
		}

		public _E000(Stream _E000, bool _E000)
		{
			this.m__E000 = _E000;
			this.m__E001 = _E000;
			this.m__E002 = true;
			_E004 = new byte[8192];
			_E003 = new _E001(_E000);
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		public override void SetLength(long value)
		{
		}

		private void _E000()
		{
			if (!this.m__E002)
			{
				throw new InvalidOperationException("Stream is closed.");
			}
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
			_E000();
			if (_E005 + count > 8192)
			{
				_E001();
			}
			if (count >= 8192)
			{
				int i;
				for (i = 0; count - i > 32768; i += 32768)
				{
					_E003._E003(buffer, offset + i, 32768, _E000: false);
				}
				_E003._E003(buffer, offset + i, count - i, _E000: false);
				return;
			}
			Array.Copy(buffer, offset, _E004, _E005, count);
			_E005 += count;
			if (_E005 == 8192)
			{
				_E001();
			}
		}

		private void _E001()
		{
			if (_E005 > 0)
			{
				_E003._E003(_E004, 0, _E005, _E000: false);
				_E005 = 0;
			}
		}

		public override void Flush()
		{
			_E000();
			if (_E005 > 0)
			{
				_E001();
			}
			_E003._E001(_E000: true, _E000: false);
			this._E000.Flush();
		}

		private void _E002()
		{
			if (_E005 > 0)
			{
				_E003._E003(_E004, 0, _E005, _E000: true);
			}
			else
			{
				_E003._E001(_E000: false, _E000: true);
			}
		}

		void IDisposable.Dispose()
		{
			if (this.m__E002)
			{
				_E002();
				_E004 = null;
				_E003 = null;
				if (!this.m__E001)
				{
					this.m__E000.Close();
					this.m__E000 = null;
				}
				this.m__E002 = false;
			}
			base.Close();
		}

		static _E000()
		{
		}
	}

	public sealed class _E001
	{
		private Stream m__E000;

		private _E007 m__E001;

		private _E003 m__E002;

		private static int m__E003;

		private static int m__E004;

		private static int m__E005;

		private static int m__E006;

		private static int m__E007;

		public Stream _E000 => this.m__E000;

		public static int _E001
		{
			get
			{
				if (_E012._E001.m__E003 == -1)
				{
					return 4;
				}
				return _E012._E001.m__E003;
			}
			set
			{
				_E012._E001.m__E003 = value;
			}
		}

		public static int _E002
		{
			get
			{
				if (_E012._E001.m__E004 == -1)
				{
					return 46666;
				}
				return _E012._E001.m__E004;
			}
			set
			{
				_E012._E001.m__E004 = value;
			}
		}

		public static int _E003
		{
			get
			{
				if (_E012._E001.m__E005 == -1)
				{
					return 1;
				}
				return _E012._E001.m__E005;
			}
			set
			{
				_E012._E001.m__E005 = value;
			}
		}

		public static int _E004
		{
			get
			{
				if (_E012._E001.m__E006 == -1)
				{
					return 14;
				}
				return _E012._E001.m__E006;
			}
			set
			{
				_E012._E001.m__E006 = value;
			}
		}

		public static int _E005
		{
			get
			{
				if (_E012._E001.m__E007 == -1)
				{
					return 3;
				}
				return _E012._E001.m__E007;
			}
			set
			{
				_E012._E001.m__E007 = value;
			}
		}

		public _E001(Stream _E000)
		{
			this.m__E000 = _E000;
			this.m__E001 = new _E007(_E000);
			this.m__E002 = new _E003();
		}

		internal void _E000(_E006 _E000, out int[] _E000, out int[] _E000, out int _E000)
		{
			_E000 = new int[286];
			_E000 = new int[30];
			_E000 = 0;
			int num = 0;
			int num2 = 0;
			while (num < _E000._E000._E000)
			{
				ushort num3 = (ushort)_E000._E000.get__E001(num);
				if (num3 <= 256)
				{
					_E000[num3]++;
					num++;
					continue;
				}
				_E000[num3]++;
				_E000[(ushort)_E000._E000.get__E001(num + 2)]++;
				num += 4;
				_E000 += _E000._E001.get__E001(num2) + _E000._E001.get__E001(num2 + 1);
				num2 += 2;
			}
		}

		public void _E001(bool _E000, bool _E000)
		{
			this.m__E001._E000(_E000);
			if (_E000)
			{
				this.m__E001._E001(_E012._E001._E003, _E012._E001._E001);
				this.m__E001._E003();
				this.m__E001._E001(0, 16);
			}
			else
			{
				this.m__E001._E001(_E012._E001._E004, _E012._E001._E001);
				_E00E obj = _E00C._E000[256];
				this.m__E001._E002(obj._E000, obj._E001);
			}
			if (_E000)
			{
				this.m__E001._E003();
			}
		}

		public void _E002(byte[] _E000, int _E000, int _E000, bool _E000)
		{
			this.m__E001._E000(_E000);
			this.m__E001._E001(_E012._E001._E003, _E012._E001._E001);
			this.m__E001._E003();
			int num = _E000 ^ _E012._E001._E002;
			this.m__E001._E001((ushort)num, 16);
			_E006(_E000, _E000, _E000);
		}

		public void _E003(byte[] _E000, int _E000, int _E000, bool _E000)
		{
			_E006 obj = this.m__E002._E000(_E000, _E000, _E000);
			obj._E002();
			this._E000(obj, out var array, out var array2, out var num);
			int[] array3 = _E00C._E00B(array);
			int[] array4 = _E00C._E00B(array2);
			int num2 = (4 + _E000) * 8;
			num2 = ((this.m__E001._E001 >= 3) ? (num2 + (this.m__E001._E001 - 3)) : (num2 + (5 + this.m__E001._E001)));
			int num3 = _E00C._E000(array3, array) + _E00C._E000(array4, array2) + num;
			int num4 = _E00C._E001(array3, array4) + num;
			bool flag = num4 <= num3 || num2 <= num3;
			if (!flag)
			{
				int num5 = num3 + _E008(array3, array4);
				flag = num4 <= num5 || num2 <= num5;
			}
			bool flag2 = num2 < num4;
			this.m__E001._E000(_E000);
			if (flag2 && flag)
			{
				this.m__E001._E001(_E012._E001._E003, _E012._E001._E001);
				this.m__E001._E003();
				int num6 = _E000 ^ _E012._E001._E002;
				this.m__E001._E001(num6, 16);
				this.m__E001._E003();
				_E006(_E000, _E000, _E000);
			}
			else
			{
				_E00E[] array5;
				_E00E[] array6;
				if (flag)
				{
					this.m__E001._E001(_E012._E001._E004, _E012._E001._E001);
					array5 = _E00C._E000;
					array6 = _E00C._E001;
				}
				else
				{
					this.m__E001._E001(_E012._E001._E005, _E012._E001._E001);
					_E007(array3, array4);
					array5 = _E00C._E002(array3);
					array6 = _E00C._E002(array4);
				}
				_E005(obj, array5, array6);
			}
			if (_E000)
			{
				this.m__E001._E003();
			}
		}

		public void _E004()
		{
			this.m__E002 = new _E003();
		}

		private void _E005(_E006 _E000, _E00E[] _E000, _E00E[] _E000)
		{
			int num = 0;
			int num2 = 0;
			while (num < _E000._E000._E000)
			{
				int num3 = (ushort)_E000._E000.get__E001(num);
				if (num3 <= 256)
				{
					_E00E obj = _E000[num3];
					this.m__E001._E002(obj._E000, obj._E001);
					num++;
					continue;
				}
				_E00E obj2 = _E000[num3];
				this.m__E001._E002(obj2._E000, obj2._E001);
				if (_E000._E001.get__E001(num2) > 0)
				{
					this.m__E001._E001((ushort)_E000._E000.get__E001(num + 1), _E000._E001.get__E001(num2));
				}
				num += 2;
				num2++;
				obj2 = _E000[(ushort)_E000._E000.get__E001(num)];
				this.m__E001._E002(obj2._E000, obj2._E001);
				if (_E000._E001.get__E001(num2) > 0)
				{
					this.m__E001._E001((ushort)_E000._E000.get__E001(num + 1), _E000._E001.get__E001(num2));
				}
				num += 2;
				num2++;
			}
		}

		private void _E006(byte[] _E000, int _E000, int _E000)
		{
			this._E000.Write(_E000, _E000, _E000);
		}

		private void _E007(int[] _E000, int[] _E000)
		{
			int[] array = new int[19];
			int num = 286;
			while (num > 257 && _E000[num - 1] == 0)
			{
				num--;
			}
			int num2 = 30;
			while (num2 > 1 && _E000[num2 - 1] == 0)
			{
				num2--;
			}
			int[] array2 = new int[num + num2];
			Array.Copy(_E000, 0, array2, 0, num);
			Array.Copy(_E000, 0, array2, num, num2);
			int[] array3 = _E00C._E00D(array2, 0, array2.Length);
			for (int i = 0; i < array3.Length; i++)
			{
				array[array3[i]]++;
				if (array3[i] >= 16)
				{
					i++;
				}
			}
			int[] array4 = _E00C._E00A(array, 7);
			int[] array5 = _E00C._E003;
			int num3 = 19;
			while (num3 > 4 && array4[array5[num3 - 1]] == 0)
			{
				num3--;
			}
			int num4 = num - 257;
			int num5 = num2 - 1;
			int num6 = num3 - 4;
			_E00E[] array6 = _E00C._E002(array4);
			this.m__E001._E001(num4, 5);
			this.m__E001._E001(num5, 5);
			this.m__E001._E001(num6, 4);
			for (int j = 0; j < num3; j++)
			{
				this.m__E001._E001(array4[array5[j]], 3);
			}
			for (int k = 0; k < array3.Length; k++)
			{
				int num7 = array3[k];
				_E00E obj = array6[num7];
				this.m__E001._E002(obj._E000, obj._E001);
				if (num7 >= 16)
				{
					k++;
					this.m__E001._E001(array3[k], _E00C._E00C(num7));
				}
			}
		}

		private int _E008(int[] _E000, int[] _E000)
		{
			int[] array = new int[19];
			int num = 0;
			int num2 = 286;
			while (num2 > 257 && _E000[num2 - 1] == 0)
			{
				num2--;
			}
			int[] array2 = _E00C._E00D(_E000, 0, num2);
			for (int i = 0; i < array2.Length; i++)
			{
				array[array2[i]]++;
				if (array2[i] >= 16)
				{
					num += _E00C._E00C(array2[i]);
					i++;
				}
			}
			int num3 = 30;
			while (num3 > 1 && _E000[num3 - 1] == 0)
			{
				num3--;
			}
			int[] array3 = _E00C._E00D(_E000, 0, num3);
			for (int j = 0; j < array3.Length; j++)
			{
				array[array3[j]]++;
				if (array3[j] >= 16)
				{
					num += _E00C._E00C(array3[j]);
					j++;
				}
			}
			int[] array4 = _E00C._E00B(array);
			int num4 = _E00C._E000(array, array4);
			int[] array5 = _E00C._E003;
			int num5 = 19;
			while (num5 > 4 && array4[array5[num5 - 1]] == 0)
			{
				num5--;
			}
			int num6 = num5 - 4;
			return 14 + (num6 + 4) * 3 + num4 + num;
		}

		static _E001()
		{
			_E012._E001.m__E003 = -1;
			_E012._E001.m__E004 = -1;
			_E012._E001.m__E005 = -1;
			_E012._E001.m__E006 = -1;
			_E012._E001.m__E007 = -1;
		}
	}

	private sealed class _E002
	{
		public static readonly _E002 _E000;

		public int _E001;

		public int _E002;

		public int _E003;

		public int _E004;

		static _E002()
		{
			_E000 = new _E002
			{
				_E001 = 8,
				_E002 = 32,
				_E003 = 128,
				_E004 = 256
			};
		}
	}

	private sealed class _E003
	{
		private struct _E000
		{
			public int _E000;

			public int _E001;
		}

		private _E005 m__E000;

		private _E004 m__E001;

		private _E002 m__E002;

		private int m__E003;

		internal _E002 _E000 => this.m__E002;

		internal _E003()
			: this(_E012._E002._E000)
		{
		}

		internal _E003(_E002 _E000)
		{
			this.m__E002 = _E000;
			this.m__E000 = new _E005(65536);
			this.m__E001 = new _E004(32768);
			this.m__E003 = 0;
		}

		public _E006 _E000(byte[] _E000, int _E000, int _E000)
		{
			if (this.m__E000._E002 + _E000 > this.m__E000._E001)
			{
				int num = this.m__E000._E002 - 32768;
				this.m__E000._E001(num);
				if (this.m__E003 >= num)
				{
					this.m__E003 -= num;
				}
				else
				{
					this.m__E001._E003(num - this.m__E003);
					this.m__E003 = 0;
				}
			}
			int num2 = this.m__E000._E002;
			this.m__E000._E000(_E000, _E000, _E000);
			if (this.m__E003 < num2)
			{
				this.m__E001._E002(this.m__E000._E000, this.m__E003, num2 - this.m__E003);
			}
			if (this._E000._E003 > 0)
			{
				return _E002(this.m__E001, this.m__E000._E000, num2, _E000, out this.m__E003);
			}
			return _E001(this.m__E000._E000, num2, _E000);
		}

		private _E006 _E001(byte[] _E000, int _E000, int _E000)
		{
			_E006 obj = new _E006();
			for (int i = 0; i < _E000; i++)
			{
				obj._E000(_E000[i]);
			}
			return obj;
		}

		private _E006 _E002(_E004 _E000, byte[] _E000, int _E000, int _E000, out int _E000)
		{
			_E006 obj = new _E006();
			object obj2 = null;
			int i = 0;
			while (i < _E000 - 2)
			{
				_E004._E000 obj3 = _E000._E000(_E000, _E000 + i);
				if (obj3 != null)
				{
					object obj4;
					if (obj2 != null)
					{
						obj4 = obj2;
						obj2 = null;
					}
					else
					{
						obj4 = _E003(_E000, _E000, _E000, i, obj3, 3);
					}
					_E000 obj5 = (_E000)obj4;
					bool flag = obj5._E001 >= 3;
					if (flag && i < _E000 - 3 && obj5._E001 < this.m__E002._E002)
					{
						_E004._E000 obj6 = _E000._E000(_E000, _E000 + i + 1);
						if (obj6 != null)
						{
							_E000 obj7 = _E003(_E000, _E000, _E000, i + 1, obj6, obj5._E001 + 1);
							if (obj7._E001 > obj5._E001)
							{
								obj2 = obj7;
								flag = false;
							}
						}
					}
					if (flag)
					{
						obj._E001(i - obj5._E000, obj5._E001);
						_E000._E001(_E000, _E000 + i);
						i += obj5._E001;
						_E000._E003(obj5._E001 - 1);
					}
					else
					{
						obj._E000(_E000[_E000 + i]);
						_E000._E001(_E000, _E000 + i);
						i++;
					}
				}
				else
				{
					obj._E000(_E000[_E000 + i]);
					_E000._E001(_E000, _E000 + i);
					i++;
				}
			}
			_E000 += i;
			for (; i < _E000; i++)
			{
				obj._E000(_E000[_E000 + i]);
			}
			return obj;
		}

		private _E000 _E003(byte[] _E000, int _E000, int _E000, int _E000, _E004._E000 _E000, int _E000)
		{
			int num = this.m__E002._E004;
			int num2 = 0;
			int num3 = -1;
			int num4 = 0;
			int num5 = _E000 - 1;
			int num6 = _E000 + _E000;
			while (_E000._E000())
			{
				int i = 0;
				int num7 = _E000 - _E000._E000;
				if (_E000 + num5 >= _E000)
				{
					break;
				}
				int num8 = _E000 + num7;
				if (_E000[num8 + num5] == _E000[num6 + num5])
				{
					for (; i < 258 && _E000 + i < _E000 && _E000[num8 + i] == _E000[num6 + i]; i++)
					{
					}
					if (i >= num2)
					{
						num2 = i;
						num5 = i;
						num3 = num7;
						if (num2 >= this.m__E002._E003)
						{
							break;
						}
					}
					if (num2 >= this.m__E002._E001)
					{
						num >>= 2;
					}
				}
				if (++num4 >= num)
				{
					break;
				}
			}
			_E000 result = default(_E000);
			result._E001 = num2;
			result._E000 = num3;
			return result;
		}

		static _E003()
		{
		}
	}

	private sealed class _E004
	{
		internal sealed class _E000
		{
			private _E004 m__E000;

			private int _E001;

			private int _E002;

			internal int _E000 => _E001;

			internal _E000(_E004 _E000, int _E000)
			{
				//Discarded unreachable code: IL_0002, IL_0003, IL_0006
				//IL_0007: Incompatible stack heights: 0 vs 1
				this.m__E000 = _E000;
				_E001 = _E000;
			}

			internal bool _E000()
			{
				//Discarded unreachable code: IL_0002, IL_0003, IL_0006
				//IL_0007: Incompatible stack heights: 0 vs 1
				if (_E002 == 0 && 0 == 0)
				{
					_E002 = _E008._E000(1);
					return (byte)_E008._E000(1) != 0;
				}
				if (_E002 == _E008._E000(1))
				{
					ushort num = this.m__E000.m__E001[(this.m__E000.m__E003 - _E001) % this.m__E000.m__E000];
					if (num != 0 || 1 == 0)
					{
						while (true)
						{
							int num2 = Installer8._E001(31);
							int num3 = -6;
							while (true)
							{
								num3 ^= _E008._E000(9);
								while (true)
								{
									int num4 = _E008._E000(10);
									int num5 = 60;
									while (true)
									{
										num5 ^= _E008._E000(9);
										while (true)
										{
											int num6 = Installer8._E001(24);
											int num7 = 7;
											while (true)
											{
												switch (num7 ^ _E008._E000(13))
												{
												case 27:
													break;
												default:
													goto IL_00e4;
												case 24:
													goto end_IL_00cb;
												case 25:
													goto IL_00ff;
												case 26:
													/*OpCode not supported: LdMemberToken*/;
													num7 = 6;
													continue;
												}
												goto IL_00bd;
												IL_00ff:
												switch (num6)
												{
												case -28:
													break;
												default:
													goto IL_0109;
												case -31:
													goto IL_0120;
												case -30:
													goto IL_0143;
												case -29:
													goto IL_0157;
												}
												goto end_IL_00ee;
												IL_0143:
												/*OpCode not supported: LdMemberToken*/;
												num6 = Installer8._E001(26);
												goto IL_00bd;
												IL_0120:
												switch (num5)
												{
												case 34:
													break;
												default:
													goto IL_013a;
												case 31:
													goto IL_016e;
												case 32:
													goto IL_0181;
												case 33:
													goto end_IL_00af;
												}
												goto IL_00a1;
												IL_0181:
												switch (num4)
												{
												case 38:
													break;
												default:
													goto IL_019a;
												case 35:
													goto IL_01b9;
												case 36:
													goto IL_01c7;
												case 37:
													goto IL_0209;
												}
												goto end_IL_01a3;
												IL_01c7:
												switch (num3)
												{
												case -28:
													break;
												default:
													goto IL_01fc;
												case -31:
													goto IL_0227;
												case -30:
													goto end_IL_0092;
												case -29:
													goto IL_027d;
												}
												goto IL_0084;
												IL_027d:
												/*OpCode not supported: LdMemberToken*/;
												num3 = Installer8._E001(31);
												goto end_IL_01a3;
												IL_0227:
												switch (num2)
												{
												case -27:
													goto IL_02a1;
												case -26:
													goto IL_02be;
												case -25:
													goto IL_02d5;
												case -24:
													return (byte)_E008._E000(1) != 0;
												}
												num3 = -4;
												goto end_IL_01a3;
												IL_02d5:
												if (_E001 > this.m__E000.m__E000)
												{
													goto end_IL_0264;
												}
												num2 = Installer8._E001(32);
												goto IL_0084;
												IL_00e4:
												num7 = _E008._E000(6);
												continue;
												IL_02be:
												/*OpCode not supported: LdMemberToken*/;
												num2 = -2;
												goto IL_0084;
												IL_02a1:
												_E001 += num;
												num2 = -1;
												goto IL_0084;
												IL_00bd:
												num6 ^= _E008._E000(9);
												goto IL_00e4;
												IL_01fc:
												num4 = _E008._E000(11);
												goto IL_00a1;
												IL_0084:
												num2 ^= _E008._E000(8);
												goto IL_0209;
												IL_0209:
												num3 = Installer8._E001(24);
												num4 = 62;
												goto IL_00a1;
												IL_01b9:
												/*OpCode not supported: LdMemberToken*/;
												num4 = 59;
												goto IL_00a1;
												IL_019a:
												num5 = 63;
												goto end_IL_00ee;
												IL_016e:
												/*OpCode not supported: LdMemberToken*/;
												num5 = _E008._E000(1);
												goto end_IL_00ee;
												IL_013a:
												num6 = -3;
												goto IL_00bd;
												IL_00a1:
												num4 ^= _E008._E000(8);
												goto IL_0157;
												IL_0157:
												num5 = _E008._E000(12);
												num6 = -6;
												goto IL_00bd;
												IL_0109:
												num7 = _E008._E000(4);
												continue;
												end_IL_00cb:
												break;
											}
											continue;
											end_IL_00ee:
											break;
										}
										continue;
										end_IL_00af:
										break;
									}
									continue;
									end_IL_01a3:
									break;
								}
								continue;
								end_IL_0092:
								break;
							}
							continue;
							end_IL_0264:
							break;
						}
					}
					_E002 = _E008._E000(5);
				}
				return (byte)_E008._E000(0) != 0;
			}

			static _E000()
			{
			}//Discarded unreachable code: IL_0002, IL_0003, IL_0006
			//IL_0007: Incompatible stack heights: 0 vs 1

		}

		private int m__E000;

		private ushort[] m__E001;

		private int[] m__E002;

		private int m__E003;

		internal _E004(int _E000)
		{
			this.m__E000 = _E000;
			this.m__E001 = new ushort[this.m__E000];
			this.m__E002 = new int[256];
			for (int i = 0; i < 256; i++)
			{
				this.m__E002[i] = 65535;
			}
		}

		internal _E000 _E000(byte[] _E000, int _E000)
		{
			int num = _E004(_E000, _E000);
			if (this.m__E002[num] == 65535 || this.m__E003 - this.m__E002[num] > this.m__E000)
			{
				return null;
			}
			return new _E000(this, this.m__E003 - this.m__E002[num]);
		}

		internal void _E001(byte[] _E000, int _E000)
		{
			int num = _E004(_E000, _E000);
			int num2 = this.m__E003 % this.m__E000;
			if (this.m__E002[num] == 65535 || this.m__E003 - this.m__E002[num] >= this.m__E000)
			{
				this.m__E001[num2] = 0;
			}
			else
			{
				this.m__E001[num2] = (ushort)(this.m__E003 - this.m__E002[num]);
			}
			this.m__E002[num] = this.m__E003;
			if (++this.m__E003 < 16777216)
			{
				return;
			}
			int num3 = this.m__E003 - this.m__E000;
			num3 -= num3 % this.m__E000;
			for (int i = 0; i < this.m__E002.Length; i++)
			{
				if (this.m__E002[i] >= num3)
				{
					this.m__E002[i] -= num3;
				}
				else
				{
					this.m__E002[i] = 0;
				}
			}
			this.m__E003 -= num3;
		}

		internal void _E002(byte[] _E000, int _E000, int _E000)
		{
			for (int i = 0; i < _E000; i++)
			{
				_E001(_E000, _E000 + i);
			}
		}

		internal void _E003(int _E000)
		{
			this.m__E003 += _E000;
		}

		private static int _E004(byte[] _E000, int _E000)
		{
			return (byte)(_E000[_E000] + _E000[_E000 + 1] + _E000[_E000 + 2]);
		}

		static _E004()
		{
		}
	}

	private sealed class _E005
	{
		private int m__E000;

		private byte[] m__E001;

		private int m__E002;

		public byte[] _E000 => this.m__E001;

		public int _E001 => this.m__E000;

		public int _E002 => this.m__E002;

		public _E005(int _E000)
		{
			this.m__E000 = _E000;
			this.m__E001 = new byte[_E000];
			this.m__E002 = 0;
		}

		public void _E000(byte[] _E000, int _E000, int _E000)
		{
			Array.Copy(_E000, _E000, this.m__E001, this.m__E002, _E000);
			this.m__E002 += _E000;
		}

		public void _E001(int _E000)
		{
			Array.Copy(this.m__E001, _E000, this.m__E001, 0, _E002 - _E000);
			this.m__E002 -= _E000;
		}

		static _E005()
		{
		}
	}

	public sealed class _E006
	{
		internal _E00D _E000 = new _E00D();

		internal _E00D _E001 = new _E00D();

		internal int _E002;

		public void _E000(byte _E000)
		{
			this._E000._E000(_E000);
			this._E002++;
		}

		public void _E001(int _E000, int _E000)
		{
			_E00C._E008(_E000, out var num, out var num2, out var num3);
			_E00C._E009(_E000, out var num4, out var num5, out var num6);
			this._E000._E000((ushort)num);
			this._E000._E000((ushort)num2);
			this._E001._E000((byte)num3);
			this._E000._E000((ushort)num4);
			this._E000._E000((ushort)num5);
			this._E001._E000((byte)num6);
			this._E002 += _E000;
		}

		internal void _E002()
		{
			this._E000._E000(256);
		}

		static _E006()
		{
		}
	}

	private sealed class _E007
	{
		private uint m__E000;

		private int m__E001;

		private Stream m__E002;

		internal Stream _E000 => this.m__E002;

		internal int _E001 => (32 - this.m__E001) % 8;

		internal _E007(Stream _E000)
		{
			this.m__E002 = _E000;
		}

		internal void _E000(bool _E000)
		{
			_E001(_E000 ? 1 : 0, 1);
		}

		internal void _E001(int _E000, int _E000)
		{
			uint num = this.m__E000 | (checked((uint)_E000) << this.m__E001);
			int num2;
			for (num2 = this.m__E001 + _E000; num2 >= 8; num2 -= 8)
			{
				this._E000.WriteByte((byte)num);
				num >>= 8;
			}
			this.m__E000 = num;
			this.m__E001 = num2;
		}

		internal void _E002(int _E000, int _E000)
		{
			int num = 0;
			for (int num2 = _E000 - 1; num2 >= 0; num2--)
			{
				num <<= 1;
				num |= _E000 & 1;
				_E000 >>= 1;
			}
			_E001(num, _E000);
		}

		internal void _E003()
		{
			if (this.m__E001 > 0)
			{
				this._E000.WriteByte((byte)this.m__E000);
				this.m__E000 = 0u;
				this.m__E001 = 0;
			}
		}

		static _E007()
		{
		}
	}

	static _E012()
	{
	}
}
internal delegate void _E013(object _E000);
internal delegate Random _E014();
internal delegate void _E015(object _E000);
internal delegate void _E016(object _E000, bool _E000);
internal delegate Container _E017();
internal delegate Random _E018();
internal delegate void _E019(object _E000);
internal delegate int _E01A();
internal delegate void _E01B(object _E000);
internal delegate Type _E01C(RuntimeTypeHandle _E000);
internal delegate string _E01D();
internal delegate MethodInfo _E01E(object _E000, string _E000);
internal delegate Delegate _E01F(Type _E000, MethodInfo _E000);
internal delegate byte[] _E020();
internal delegate float? _E021();
internal delegate void _E022(object _E000);
internal delegate void _E023(object _E000);
internal delegate int _E024(object _E000, byte[] _E000, int _E000);
internal delegate void _E025(object _E000);
internal delegate void _E026(object _E000);
internal delegate int _E027();
internal delegate void _E028(object _E000);
internal delegate void _E029(object _E000);
internal delegate void _E02A(object _E000);
internal delegate int _E02B();
internal delegate byte _E02C(object _E000, int _E000);
internal delegate void _E02D(object _E000);
internal delegate void _E02E(object _E000);
internal delegate int _E02F();
internal delegate int _E030();
internal delegate void _E031(object _E000);
internal delegate int _E032();
internal delegate void _E033(object _E000);
internal delegate Type _E034();
internal delegate string _E035();
internal delegate Delegate _E036(Type _E000, Type _E000, string _E000);
internal delegate void _E037(object _E000);
internal delegate void _E038();
internal delegate void _E039(object _E000);
internal delegate int _E03A();
internal delegate Random _E03B(int _E000);
internal delegate void _E03C(object _E000);
internal delegate void _E03D(object _E000);
internal delegate byte _E03E();
internal delegate byte _E03F();
internal delegate string _E040();
internal delegate void _E041(object _E000);
internal delegate void _E042(object _E000);
internal delegate void _E043(object _E000);
internal delegate string _E044();
internal delegate void _E045(object _E000);
internal delegate void _E046(object _E000);
internal delegate byte[] _E047();
internal delegate string _E048();
internal delegate void _E049(object _E000);
internal delegate string _E04A();
internal delegate void _E04B(object _E000);
internal delegate byte[] _E04C();
internal delegate Assembly _E04D(byte[] _E000);
internal delegate void _E04E(object _E000);
internal delegate void _E04F(object _E000);
internal delegate void _E050(object _E000);
internal delegate Assembly _E051();
internal delegate string _E052();
internal delegate Type _E053(object _E000, string _E000);
internal delegate void _E054(object _E000);
internal delegate string _E055();
internal delegate byte[] _E056(object _E000, string _E000);
internal delegate void _E057(object _E000);
internal delegate void _E058(object _E000);
internal delegate byte[] _E059();
internal delegate void _E05A(object _E000);
internal delegate int _E05B();
internal delegate void _E05C();
internal delegate int _E05D();
internal delegate bool _E05E();
internal delegate void _E05F();
internal delegate void _E060(object _E000);
internal delegate void _E061(object _E000);
internal delegate void _E062(object _E000);
internal delegate string _E063();
internal delegate void _E064(object _E000);
internal delegate void _E065(object _E000);
internal delegate void _E066(object _E000);
internal delegate string _E067();
internal delegate MethodInfo _E068(object _E000, string _E000, Type[] _E000);
internal delegate void _E069(object _E000);
internal delegate int _E06A();
internal delegate void _E06B(object _E000);
internal delegate int _E06C();
internal delegate int _E06D();
internal delegate void _E06E(object _E000);
internal delegate void _E06F();
internal delegate int _E070();
internal delegate byte _E071();
internal delegate void _E072(object _E000);
internal delegate int _E073();
internal delegate int _E074(object _E000, int _E000);
internal delegate int _E075();
internal delegate void _E076(object _E000);
internal delegate Assembly _E077();
internal delegate void _E078(object _E000);
internal delegate string _E079();
internal delegate void _E07A(object _E000);
internal delegate void _E07B(object _E000);
internal delegate Encoding _E07C();
internal delegate string _E07D();
internal delegate Delegate _E07E(Type _E000, object _E000, MethodInfo _E000);
internal delegate string _E07F();
internal delegate byte[] _E080(object _E000, string _E000);
internal delegate Assembly _E081();
internal delegate void _E082(object _E000);
internal delegate void _E083(object _E000);
internal delegate int _E084();
internal delegate void _E085(object _E000);
internal delegate void _E086(object _E000);
internal delegate string _E087();
internal delegate void _E088(object _E000);
internal delegate bool _E089(object _E000, object _E000);
internal delegate Assembly _E08A(object _E000);
internal delegate ResourceManager _E08B(string _E000, Assembly _E000);
internal delegate ResourceManager _E08C();
internal delegate string _E08D(object _E000, string _E000, CultureInfo _E000);
