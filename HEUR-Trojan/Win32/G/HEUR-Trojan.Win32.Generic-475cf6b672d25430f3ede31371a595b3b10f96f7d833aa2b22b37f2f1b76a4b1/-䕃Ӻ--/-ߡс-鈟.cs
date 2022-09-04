using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace _FFFD䕃Ӻ_FFFD_FFFD;

public class _0739ߡс_02E8鈟
{
	private struct record_header_field
	{
		public long size;

		public long type;
	}

	private struct table_entry
	{
		public long row_id;

		public string[] content;
	}

	private struct sqlite_master_entry
	{
		public long row_id;

		public string item_type;

		public string item_name;

		public string astable_name;

		public long root_num;

		public string sql_statement;
	}

	private byte[] _F0B9_FFFD_FFFDŲé;

	private ushort _00BE_05C9ƜƟ_FFFD;

	private ulong _FFFDƉ_FFFDŁ콪;

	private sqlite_master_entry[] չɩ_06DA_FFFD_0657;

	private byte[] _0333å_FFFD_FFFD蠺;

	private table_entry[] ӓՕΑŚΑ;

	private string[] ӓUOչc;

	private int _0026_FFFDӤɢ_FFFD(int 盀Ӥ_02E8ʤӚ)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		int result = default(int);
		int num6 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_000b;
					case 222:
						{
							num2 = num;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_000b;
							case 3:
								goto IL_001e;
							case 4:
								goto IL_0024;
							case 5:
								goto IL_0034;
							case 6:
								goto IL_004a;
							case 8:
								goto IL_0053;
							case 9:
								goto IL_0074;
							case 7:
							case 10:
							case 11:
								goto IL_007d;
							case 12:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 13:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_0053:
						num = 8;
						if ((_F0B9_FFFD_FFFDŲé[num5] & 0x80) != 128)
						{
							goto IL_0074;
						}
						goto IL_007d;
						IL_0074:
						num = 9;
						result = num5;
						goto end_IL_0001_3;
						IL_004a:
						num = 6;
						result = 0;
						goto end_IL_0001_3;
						IL_007d:
						num = 11;
						num5++;
						goto IL_0086;
						IL_000b:
						num = 2;
						if (盀Ӥ_02E8ʤӚ > _F0B9_FFFD_FFFDŲé.Length)
						{
							goto IL_001e;
						}
						goto IL_0024;
						IL_001e:
						num = 3;
						result = 0;
						goto end_IL_0001_3;
						IL_0024:
						num = 4;
						num6 = 盀Ӥ_02E8ʤӚ + 8;
						num5 = 盀Ӥ_02E8ʤӚ;
						goto IL_0086;
						IL_0086:
						if (num5 > num6)
						{
							break;
						}
						goto IL_0034;
						IL_0034:
						num = 5;
						if (num5 > _F0B9_FFFD_FFFDŲé.Length - 1)
						{
							goto IL_004a;
						}
						goto IL_0053;
						end_IL_0001_2:
						break;
					}
					num = 12;
					result = 盀Ӥ_02E8ʤӚ + 8;
					break;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 222;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private long _FFFD_061Cã_FFFD蠺(int _002Dɮ丐A_FFFD, int _06E8㠰ǎ_FFFD_0332)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		bool flag = default(bool);
		byte[] array = default(byte[]);
		int num5 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		int num8 = default(int);
		int num9 = default(int);
		long result = default(long);
		int num11 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					int num10;
					switch (try0001_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_000b;
					case 578:
						{
							num2 = num;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_000b;
							case 3:
								goto IL_0012;
							case 4:
								goto IL_001c;
							case 5:
								goto IL_0023;
							case 6:
								goto IL_0028;
							case 7:
								goto IL_003c;
							case 8:
								goto IL_0046;
							case 9:
								goto IL_0053;
							case 10:
								goto IL_0066;
							case 11:
							case 12:
								goto IL_0079;
							case 13:
								goto IL_0088;
							case 14:
							case 15:
								goto IL_0090;
							case 16:
								goto IL_0096;
							case 17:
								goto IL_009c;
							case 18:
								goto IL_00a2;
							case 19:
								goto IL_00ad;
							case 20:
								goto IL_00be;
							case 21:
								goto IL_00c6;
							case 22:
							case 23:
								goto IL_00ce;
							case 24:
								goto IL_00e2;
							case 25:
								goto IL_00f5;
							case 26:
								goto IL_012d;
							case 27:
								goto IL_0136;
							case 28:
								goto IL_013f;
							case 30:
								goto IL_014c;
							case 31:
								goto IL_015a;
							case 29:
							case 32:
							case 33:
								goto IL_0181;
							case 34:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 35:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_014c:
						num = 30;
						if (!flag)
						{
							goto IL_015a;
						}
						goto IL_0181;
						IL_015a:
						num = 31;
						array[num5] = (byte)(unchecked((byte)((uint)_F0B9_FFFD_FFFDŲé[num6] >> (checked(num7 - 1) & 7))) & (255 >> num7));
						goto IL_0181;
						IL_013f:
						num = 28;
						num8--;
						goto IL_0181;
						IL_0181:
						num = 33;
						num6 += -1;
						goto IL_018a;
						IL_000b:
						num = 2;
						_06E8㠰ǎ_FFFD_0332++;
						goto IL_0012;
						IL_0012:
						num = 3;
						array = new byte[8];
						goto IL_001c;
						IL_001c:
						num = 4;
						num9 = _06E8㠰ǎ_FFFD_0332 - _002Dɮ丐A_FFFD;
						goto IL_0023;
						IL_0023:
						num = 5;
						flag = false;
						goto IL_0028;
						IL_0028:
						num = 6;
						if (unchecked(num9 == 0 || num9 > 9))
						{
							goto IL_003c;
						}
						goto IL_0046;
						IL_003c:
						num = 7;
						result = 0L;
						goto end_IL_0001_3;
						IL_0046:
						num = 8;
						if (num9 == 1)
						{
							goto IL_0053;
						}
						goto IL_0079;
						IL_0053:
						num = 9;
						array[0] = (byte)(_F0B9_FFFD_FFFDŲé[_002Dɮ丐A_FFFD] & 0x7F);
						goto IL_0066;
						IL_0066:
						num = 10;
						result = BitConverter.ToInt64(array, 0);
						goto end_IL_0001_3;
						IL_0079:
						num = 12;
						if (num9 == 9)
						{
							goto IL_0088;
						}
						goto IL_0090;
						IL_0088:
						num = 13;
						flag = true;
						goto IL_0090;
						IL_0090:
						num = 15;
						num7 = 1;
						goto IL_0096;
						IL_0096:
						num = 16;
						num8 = 7;
						goto IL_009c;
						IL_009c:
						num = 17;
						num5 = 0;
						goto IL_00a2;
						IL_00a2:
						num = 18;
						if (flag)
						{
							goto IL_00ad;
						}
						goto IL_00ce;
						IL_00ad:
						num = 19;
						array[0] = _F0B9_FFFD_FFFDŲé[_06E8㠰ǎ_FFFD_0332 - 1];
						goto IL_00be;
						IL_00be:
						num = 20;
						_06E8㠰ǎ_FFFD_0332--;
						goto IL_00c6;
						IL_00c6:
						num = 21;
						num5 = 1;
						goto IL_00ce;
						IL_00ce:
						num = 23;
						num10 = _06E8㠰ǎ_FFFD_0332 - 1;
						num11 = _002Dɮ丐A_FFFD;
						num6 = num10;
						goto IL_018a;
						IL_018a:
						if (num6 < num11)
						{
							break;
						}
						goto IL_00e2;
						IL_00e2:
						num = 24;
						if (num6 - 1 >= _002Dɮ丐A_FFFD)
						{
							goto IL_00f5;
						}
						goto IL_014c;
						IL_00f5:
						num = 25;
						array[num5] = (byte)unchecked(((byte)((uint)_F0B9_FFFD_FFFDŲé[num6] >> (checked(num7 - 1) & 7)) & (255 >> num7)) | (byte)(_F0B9_FFFD_FFFDŲé[checked(num6 - 1)] << (num8 & 7)));
						goto IL_012d;
						IL_012d:
						num = 26;
						num7++;
						goto IL_0136;
						IL_0136:
						num = 27;
						num5++;
						goto IL_013f;
						end_IL_0001_2:
						break;
					}
					num = 34;
					result = BitConverter.ToInt64(array, 0);
					break;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 578;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private bool _FFFDKЮzĪ(long ﾭW_FFFD_07FBӤ)
	{
		return (ﾭW_FFFD_07FBӤ & 1) == 1;
	}

	private ulong _0306Թ_FFFD_FFFD_FFFD(int _FFFDЮ뜸_060C퓜, int _0739_FFFD똛鈟_1CFC)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		int num6 = default(int);
		ulong num7 = default(ulong);
		ulong result = default(ulong);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000b;
				case 149:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000b;
						case 3:
							goto IL_001c;
						case 4:
							goto IL_0023;
						case 5:
							goto IL_0029;
						case 6:
							goto IL_0035;
						case 7:
							goto IL_004a;
						case 8:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 9:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0052:
					if (num5 > num6)
					{
						break;
					}
					goto IL_0035;
					IL_0035:
					num = 6;
					num7 = (num7 << 8) | _F0B9_FFFD_FFFDŲé[checked(_FFFDЮ뜸_060C퓜 + num5)];
					goto IL_004a;
					IL_0029:
					num = 5;
					num6 = checked(_0739_FFFD똛鈟_1CFC - 1);
					num5 = 0;
					goto IL_0052;
					IL_004a:
					num = 7;
					num5 = checked(num5 + 1);
					goto IL_0052;
					IL_000b:
					num = 2;
					if (_0739_FFFD똛鈟_1CFC > 8 || _0739_FFFD똛鈟_1CFC == 0)
					{
						goto IL_001c;
					}
					goto IL_0023;
					IL_001c:
					num = 3;
					result = 0uL;
					goto end_IL_0001_3;
					IL_0023:
					num = 4;
					num7 = 0uL;
					goto IL_0029;
					end_IL_0001_2:
					break;
				}
				num = 8;
				result = num7;
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 149;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void _0331_FFFD_FFFD_0331_FFFD(ulong _07B9_FFFD_0609tŴ)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		ushort num5 = default(ushort);
		int num6 = default(int);
		ushort num7 = default(ushort);
		int num8 = default(int);
		int num9 = default(int);
		int num10 = default(int);
		ulong num11 = default(ulong);
		int num12 = default(int);
		int num14 = default(int);
		long value = default(long);
		long[] array = default(long[]);
		int num15 = default(int);
		ushort num16 = default(ushort);
		int num17 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					ref sqlite_master_entry[] reference;
					long num13;
					switch (try0001_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_000b;
					case 2793:
						{
							num2 = num;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_000b;
							case 3:
								goto IL_0021;
							case 4:
								goto IL_0057;
							case 5:
								goto IL_005c;
							case 6:
								goto IL_006d;
							case 7:
								goto IL_0079;
							case 9:
								goto IL_00a8;
							case 8:
							case 10:
							case 11:
								goto IL_00bb;
							case 12:
								goto IL_00ca;
							case 13:
								goto IL_00fb;
							case 14:
								goto IL_011a;
							case 15:
								goto IL_0123;
							case 16:
								goto IL_0131;
							case 17:
								goto IL_0141;
							case 18:
								goto IL_017a;
							case 19:
								goto IL_01c8;
							case 20:
								goto IL_01fb;
							case 21:
								goto IL_0209;
							case 22:
								goto IL_0210;
							case 23:
								goto IL_0220;
							case 24:
								goto IL_022b;
							case 25:
								goto IL_0231;
							case 26:
								goto IL_023a;
							case 27:
								goto IL_0247;
							case 28:
								goto IL_0259;
							case 29:
								goto IL_026c;
							case 30:
								goto IL_0280;
							case 32:
								goto IL_02a6;
							case 35:
								goto IL_02cd;
							case 31:
							case 33:
							case 34:
							case 36:
							case 37:
								goto IL_02e4;
							case 38:
								goto IL_02f5;
							case 39:
								goto IL_0316;
							case 41:
								goto IL_0361;
							case 42:
								goto IL_0384;
							case 44:
								goto IL_03cc;
							case 45:
								goto IL_03ef;
							case 40:
							case 43:
							case 46:
							case 47:
								goto IL_0435;
							case 48:
								goto IL_0456;
							case 50:
								goto IL_04af;
							case 51:
								goto IL_04d2;
							case 53:
								goto IL_0528;
							case 54:
								goto IL_054b;
							case 49:
							case 52:
							case 55:
							case 56:
								goto IL_059f;
							case 57:
								goto IL_0605;
							case 58:
								goto IL_0629;
							case 60:
								goto IL_06ac;
							case 61:
								goto IL_06d2;
							case 63:
								goto IL_0755;
							case 64:
								goto IL_0778;
							case 59:
							case 62:
							case 65:
							case 66:
								goto IL_07f6;
							case 68:
								goto IL_080e;
							case 69:
								goto IL_0826;
							case 70:
								goto IL_085d;
							case 71:
								goto IL_086c;
							case 72:
								goto IL_089f;
							case 73:
								goto IL_08be;
							case 75:
								goto IL_08f9;
							case 74:
							case 76:
							case 77:
								goto IL_0935;
							case 78:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 67:
							case 79:
							case 80:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_08be:
						num = 73;
						_0331_FFFD_FFFD_0331_FFFD(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(_0306Թ_FFFD_FFFD_FFFD(num5, 4)), 1m), new decimal(_00BE_05C9ƜƟ_FFFD))));
						goto IL_0935;
						IL_08f9:
						num = 75;
						_0331_FFFD_FFFD_0331_FFFD(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(_0306Թ_FFFD_FFFD_FFFD((int)(_07B9_FFFD_0609tŴ + num5), 4)), 1m), new decimal(_00BE_05C9ƜƟ_FFFD))));
						goto IL_0935;
						IL_089f:
						num = 72;
						if (decimal.Compare(new decimal(_07B9_FFFD_0609tŴ), new decimal(100L)) == 0)
						{
							goto IL_08be;
						}
						goto IL_08f9;
						IL_0935:
						num = 77;
						num6++;
						goto IL_093e;
						IL_000b:
						num = 2;
						if (_F0B9_FFFD_FFFDŲé[(int)_07B9_FFFD_0609tŴ] == 13)
						{
							goto IL_0021;
						}
						goto IL_080e;
						IL_0021:
						num = 3;
						num7 = Convert.ToUInt16(decimal.Subtract(new decimal(_0306Թ_FFFD_FFFD_FFFD(Convert.ToInt32(decimal.Add(new decimal(_07B9_FFFD_0609tŴ), new decimal(3L))), 2)), 1m));
						goto IL_0057;
						IL_0057:
						num = 4;
						num8 = 0;
						goto IL_005c;
						IL_005c:
						num = 5;
						if (չɩ_06DA_FFFD_0657 != null)
						{
							goto IL_006d;
						}
						goto IL_00a8;
						IL_006d:
						num = 6;
						num8 = չɩ_06DA_FFFD_0657.Length;
						goto IL_0079;
						IL_0079:
						num = 7;
						reference = ref չɩ_06DA_FFFD_0657;
						reference = (sqlite_master_entry[])Utils.CopyArray((Array)reference, (Array)new sqlite_master_entry[չɩ_06DA_FFFD_0657.Length + unchecked((int)num7) + 1]);
						goto IL_00bb;
						IL_00a8:
						num = 9;
						չɩ_06DA_FFFD_0657 = new sqlite_master_entry[unchecked((int)num7) + 1];
						goto IL_00bb;
						IL_00bb:
						num = 11;
						num9 = num7;
						num10 = 0;
						goto IL_07ff;
						IL_07ff:
						if (num10 > num9)
						{
							goto end_IL_0001_3;
						}
						goto IL_00ca;
						IL_00ca:
						num = 12;
						num11 = _0306Թ_FFFD_FFFD_FFFD(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(_07B9_FFFD_0609tŴ), new decimal(8L)), new decimal(num10 * 2))), 2);
						goto IL_00fb;
						IL_00fb:
						num = 13;
						if (decimal.Compare(new decimal(_07B9_FFFD_0609tŴ), new decimal(100L)) != 0)
						{
							goto IL_011a;
						}
						goto IL_0123;
						IL_011a:
						num = 14;
						num11 += _07B9_FFFD_0609tŴ;
						goto IL_0123;
						IL_0123:
						num = 15;
						num12 = _0026_FFFDӤɢ_FFFD((int)num11);
						goto IL_0131;
						IL_0131:
						num = 16;
						num13 = _FFFD_061Cã_FFFD蠺((int)num11, num12);
						goto IL_0141;
						IL_0141:
						num = 17;
						num14 = _0026_FFFDӤɢ_FFFD(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num11), decimal.Subtract(new decimal(num12), new decimal(num11))), 1m)));
						goto IL_017a;
						IL_017a:
						num = 18;
						չɩ_06DA_FFFD_0657[num8 + num10].row_id = _FFFD_061Cã_FFFD蠺(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num11), decimal.Subtract(new decimal(num12), new decimal(num11))), 1m)), num14);
						goto IL_01c8;
						IL_01c8:
						num = 19;
						num11 = Convert.ToUInt64(decimal.Add(decimal.Add(new decimal(num11), decimal.Subtract(new decimal(num14), new decimal(num11))), 1m));
						goto IL_01fb;
						IL_01fb:
						num = 20;
						num12 = _0026_FFFDӤɢ_FFFD((int)num11);
						goto IL_0209;
						IL_0209:
						num = 21;
						num14 = num12;
						goto IL_0210;
						IL_0210:
						num = 22;
						value = _FFFD_061Cã_FFFD蠺((int)num11, num12);
						goto IL_0220;
						IL_0220:
						num = 23;
						array = new long[5];
						goto IL_022b;
						IL_022b:
						num = 24;
						num15 = 0;
						goto IL_0231;
						IL_0231:
						num = 25;
						num12 = num14 + 1;
						goto IL_023a;
						IL_023a:
						num = 26;
						num14 = _0026_FFFDӤɢ_FFFD(num12);
						goto IL_0247;
						IL_0247:
						num = 27;
						array[num15] = _FFFD_061Cã_FFFD蠺(num12, num14);
						goto IL_0259;
						IL_0259:
						num = 28;
						if (array[num15] > 9)
						{
							goto IL_026c;
						}
						goto IL_02cd;
						IL_026c:
						num = 29;
						if (_FFFDKЮzĪ(array[num15]))
						{
							goto IL_0280;
						}
						goto IL_02a6;
						IL_0280:
						num = 30;
						array[num15] = (long)Math.Round((double)(array[num15] - 13) / 2.0);
						goto IL_02e4;
						IL_02a6:
						num = 32;
						array[num15] = (long)Math.Round((double)(array[num15] - 12) / 2.0);
						goto IL_02e4;
						IL_02cd:
						num = 35;
						array[num15] = _0333å_FFFD_FFFD蠺[(int)array[num15]];
						goto IL_02e4;
						IL_02e4:
						num = 37;
						num15++;
						if (num15 <= 4)
						{
							goto IL_0231;
						}
						goto IL_02f5;
						IL_02f5:
						num = 38;
						if (decimal.Compare(new decimal(_FFFDƉ_FFFDŁ콪), 1m) == 0)
						{
							goto IL_0316;
						}
						goto IL_0361;
						IL_0316:
						num = 39;
						չɩ_06DA_FFFD_0657[num8 + num10].item_type = Encoding.Default.GetString(_F0B9_FFFD_FFFDŲé, Convert.ToInt32(decimal.Add(new decimal(num11), new decimal(value))), (int)array[0]);
						goto IL_0435;
						IL_0361:
						num = 41;
						if (decimal.Compare(new decimal(_FFFDƉ_FFFDŁ콪), new decimal(2L)) == 0)
						{
							goto IL_0384;
						}
						goto IL_03cc;
						IL_0384:
						num = 42;
						չɩ_06DA_FFFD_0657[num8 + num10].item_type = Encoding.Unicode.GetString(_F0B9_FFFD_FFFDŲé, Convert.ToInt32(decimal.Add(new decimal(num11), new decimal(value))), (int)array[0]);
						goto IL_0435;
						IL_03cc:
						num = 44;
						if (decimal.Compare(new decimal(_FFFDƉ_FFFDŁ콪), new decimal(3L)) == 0)
						{
							goto IL_03ef;
						}
						goto IL_0435;
						IL_03ef:
						num = 45;
						չɩ_06DA_FFFD_0657[num8 + num10].item_type = Encoding.BigEndianUnicode.GetString(_F0B9_FFFD_FFFDŲé, Convert.ToInt32(decimal.Add(new decimal(num11), new decimal(value))), (int)array[0]);
						goto IL_0435;
						IL_0435:
						num = 47;
						if (decimal.Compare(new decimal(_FFFDƉ_FFFDŁ콪), 1m) == 0)
						{
							goto IL_0456;
						}
						goto IL_04af;
						IL_0456:
						num = 48;
						չɩ_06DA_FFFD_0657[num8 + num10].item_name = Encoding.Default.GetString(_F0B9_FFFD_FFFDŲé, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num11), new decimal(value)), new decimal(array[0]))), (int)array[1]);
						goto IL_059f;
						IL_04af:
						num = 50;
						if (decimal.Compare(new decimal(_FFFDƉ_FFFDŁ콪), new decimal(2L)) == 0)
						{
							goto IL_04d2;
						}
						goto IL_0528;
						IL_04d2:
						num = 51;
						չɩ_06DA_FFFD_0657[num8 + num10].item_name = Encoding.Unicode.GetString(_F0B9_FFFD_FFFDŲé, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num11), new decimal(value)), new decimal(array[0]))), (int)array[1]);
						goto IL_059f;
						IL_0528:
						num = 53;
						if (decimal.Compare(new decimal(_FFFDƉ_FFFDŁ콪), new decimal(3L)) == 0)
						{
							goto IL_054b;
						}
						goto IL_059f;
						IL_054b:
						num = 54;
						չɩ_06DA_FFFD_0657[num8 + num10].item_name = Encoding.BigEndianUnicode.GetString(_F0B9_FFFD_FFFDŲé, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num11), new decimal(value)), new decimal(array[0]))), (int)array[1]);
						goto IL_059f;
						IL_059f:
						num = 56;
						չɩ_06DA_FFFD_0657[num8 + num10].root_num = (long)_0306Թ_FFFD_FFFD_FFFD(Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num11), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2]))), (int)array[3]);
						goto IL_0605;
						IL_0605:
						num = 57;
						if (decimal.Compare(new decimal(_FFFDƉ_FFFDŁ콪), 1m) == 0)
						{
							goto IL_0629;
						}
						goto IL_06ac;
						IL_0629:
						num = 58;
						չɩ_06DA_FFFD_0657[num8 + num10].sql_statement = Encoding.Default.GetString(_F0B9_FFFD_FFFDŲé, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num11), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
						goto IL_07f6;
						IL_06ac:
						num = 60;
						if (decimal.Compare(new decimal(_FFFDƉ_FFFDŁ콪), new decimal(2L)) == 0)
						{
							goto IL_06d2;
						}
						goto IL_0755;
						IL_06d2:
						num = 61;
						չɩ_06DA_FFFD_0657[num8 + num10].sql_statement = Encoding.Unicode.GetString(_F0B9_FFFD_FFFDŲé, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num11), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
						goto IL_07f6;
						IL_0755:
						num = 63;
						if (decimal.Compare(new decimal(_FFFDƉ_FFFDŁ콪), new decimal(3L)) == 0)
						{
							goto IL_0778;
						}
						goto IL_07f6;
						IL_0778:
						num = 64;
						չɩ_06DA_FFFD_0657[num8 + num10].sql_statement = Encoding.BigEndianUnicode.GetString(_F0B9_FFFD_FFFDŲé, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num11), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
						goto IL_07f6;
						IL_07f6:
						num = 66;
						num10++;
						goto IL_07ff;
						IL_080e:
						num = 68;
						if (_F0B9_FFFD_FFFDŲé[(int)_07B9_FFFD_0609tŴ] != 5)
						{
							goto end_IL_0001_3;
						}
						goto IL_0826;
						IL_0826:
						num = 69;
						num16 = Convert.ToUInt16(decimal.Subtract(new decimal(_0306Թ_FFFD_FFFD_FFFD(Convert.ToInt32(decimal.Add(new decimal(_07B9_FFFD_0609tŴ), new decimal(3L))), 2)), 1m));
						goto IL_085d;
						IL_085d:
						num = 70;
						num17 = num16;
						num6 = 0;
						goto IL_093e;
						IL_093e:
						if (num6 > num17)
						{
							break;
						}
						goto IL_086c;
						IL_086c:
						num = 71;
						num5 = (ushort)_0306Թ_FFFD_FFFD_FFFD(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(_07B9_FFFD_0609tŴ), new decimal(12L)), new decimal(num6 * 2))), 2);
						goto IL_089f;
						end_IL_0001_2:
						break;
					}
					num = 78;
					_0331_FFFD_FFFD_0331_FFFD(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(_0306Թ_FFFD_FFFD_FFFD(Convert.ToInt32(decimal.Add(new decimal(_07B9_FFFD_0609tŴ), new decimal(8L))), 4)), 1m), new decimal(_00BE_05C9ƜƟ_FFFD))));
					break;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 2793;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private bool ҟŎ_FFFD_FFFD_FFFD(ulong Юē_060Cc_005E)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		ushort num6 = default(ushort);
		int num5 = default(int);
		ushort num7 = default(ushort);
		int num8 = default(int);
		int num9 = default(int);
		int num10 = default(int);
		ulong num11 = default(ulong);
		int num12 = default(int);
		int num14 = default(int);
		long num15 = default(long);
		long num16 = default(long);
		int num17 = default(int);
		record_header_field[] array = default(record_header_field[]);
		int num18 = default(int);
		int num19 = default(int);
		int num20 = default(int);
		ushort num21 = default(ushort);
		int num22 = default(int);
		bool result = default(bool);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					ref table_entry[] reference;
					long num13;
					switch (try0001_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_000b;
					case 2340:
						{
							num2 = num;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_000b;
							case 3:
								goto IL_0023;
							case 4:
								goto IL_0059;
							case 5:
								goto IL_005e;
							case 6:
								goto IL_006f;
							case 7:
								goto IL_007b;
							case 9:
								goto IL_00aa;
							case 8:
							case 10:
							case 11:
								goto IL_00bd;
							case 12:
								goto IL_00cc;
							case 13:
								goto IL_00fd;
							case 14:
								goto IL_011c;
							case 15:
								goto IL_0125;
							case 16:
								goto IL_0133;
							case 17:
								goto IL_0143;
							case 18:
								goto IL_017c;
							case 19:
								goto IL_01ca;
							case 20:
								goto IL_01fd;
							case 21:
								goto IL_020b;
							case 22:
								goto IL_0212;
							case 23:
								goto IL_0222;
							case 24:
								goto IL_0249;
							case 27:
								goto IL_0254;
							case 28:
								goto IL_026e;
							case 29:
								goto IL_0277;
							case 30:
								goto IL_0284;
							case 31:
								goto IL_029f;
							case 32:
								goto IL_02be;
							case 33:
								goto IL_02db;
							case 35:
								goto IL_0313;
							case 38:
								goto IL_034c;
							case 34:
							case 36:
							case 37:
							case 39:
							case 40:
								goto IL_0375;
							case 41:
								goto IL_0386;
							case 25:
							case 26:
							case 42:
								goto IL_0390;
							case 43:
								goto IL_03a2;
							case 44:
								goto IL_03c7;
							case 45:
								goto IL_03cd;
							case 46:
								goto IL_03e0;
							case 47:
								goto IL_03ff;
							case 48:
								goto IL_0422;
							case 49:
								goto IL_0443;
							case 51:
								goto IL_04a7;
							case 52:
								goto IL_04ca;
							case 54:
								goto IL_052e;
							case 55:
								goto IL_0551;
							case 58:
								goto IL_05b4;
							case 61:
								goto IL_0617;
							case 50:
							case 53:
							case 56:
							case 57:
							case 59:
							case 60:
							case 62:
							case 63:
								goto IL_0671;
							case 64:
								goto IL_0689;
							case 65:
								goto IL_069b;
							case 67:
								goto IL_06b3;
							case 68:
								goto IL_06cb;
							case 69:
								goto IL_0702;
							case 70:
								goto IL_070e;
							case 71:
								goto IL_0741;
							case 72:
								goto IL_077c;
							case 73:
								goto IL_078b;
							case 66:
							case 74:
							case 75:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 76:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_070e:
						num = 70;
						num6 = (ushort)_0306Թ_FFFD_FFFD_FFFD(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(Юē_060Cc_005E), new decimal(12L)), new decimal(num5 * 2))), 2);
						goto IL_0741;
						IL_0741:
						num = 71;
						ҟŎ_FFFD_FFFD_FFFD(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(_0306Թ_FFFD_FFFD_FFFD((int)(Юē_060Cc_005E + num6), 4)), 1m), new decimal(_00BE_05C9ƜƟ_FFFD))));
						goto IL_077c;
						IL_078b:
						num = 73;
						ҟŎ_FFFD_FFFD_FFFD(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(_0306Թ_FFFD_FFFD_FFFD(Convert.ToInt32(decimal.Add(new decimal(Юē_060Cc_005E), new decimal(8L))), 4)), 1m), new decimal(_00BE_05C9ƜƟ_FFFD))));
						break;
						IL_077c:
						num = 72;
						num5++;
						goto IL_0785;
						IL_000b:
						num = 2;
						if (_F0B9_FFFD_FFFDŲé[(int)Юē_060Cc_005E] == 13)
						{
							goto IL_0023;
						}
						goto IL_06b3;
						IL_0023:
						num = 3;
						num7 = Convert.ToUInt16(decimal.Subtract(new decimal(_0306Թ_FFFD_FFFD_FFFD(Convert.ToInt32(decimal.Add(new decimal(Юē_060Cc_005E), new decimal(3L))), 2)), 1m));
						goto IL_0059;
						IL_0059:
						num = 4;
						num8 = 0;
						goto IL_005e;
						IL_005e:
						num = 5;
						if (ӓՕΑŚΑ != null)
						{
							goto IL_006f;
						}
						goto IL_00aa;
						IL_006f:
						num = 6;
						num8 = ӓՕΑŚΑ.Length;
						goto IL_007b;
						IL_007b:
						num = 7;
						reference = ref ӓՕΑŚΑ;
						reference = (table_entry[])Utils.CopyArray((Array)reference, (Array)new table_entry[ӓՕΑŚΑ.Length + unchecked((int)num7) + 1]);
						goto IL_00bd;
						IL_00aa:
						num = 9;
						ӓՕΑŚΑ = new table_entry[unchecked((int)num7) + 1];
						goto IL_00bd;
						IL_00bd:
						num = 11;
						num9 = num7;
						num10 = 0;
						goto IL_06a4;
						IL_06a4:
						if (num10 > num9)
						{
							break;
						}
						goto IL_00cc;
						IL_00cc:
						num = 12;
						num11 = _0306Թ_FFFD_FFFD_FFFD(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(Юē_060Cc_005E), new decimal(8L)), new decimal(num10 * 2))), 2);
						goto IL_00fd;
						IL_00fd:
						num = 13;
						if (decimal.Compare(new decimal(Юē_060Cc_005E), new decimal(100L)) != 0)
						{
							goto IL_011c;
						}
						goto IL_0125;
						IL_011c:
						num = 14;
						num11 += Юē_060Cc_005E;
						goto IL_0125;
						IL_0125:
						num = 15;
						num12 = _0026_FFFDӤɢ_FFFD((int)num11);
						goto IL_0133;
						IL_0133:
						num = 16;
						num13 = _FFFD_061Cã_FFFD蠺((int)num11, num12);
						goto IL_0143;
						IL_0143:
						num = 17;
						num14 = _0026_FFFDӤɢ_FFFD(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num11), decimal.Subtract(new decimal(num12), new decimal(num11))), 1m)));
						goto IL_017c;
						IL_017c:
						num = 18;
						ӓՕΑŚΑ[num8 + num10].row_id = _FFFD_061Cã_FFFD蠺(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num11), decimal.Subtract(new decimal(num12), new decimal(num11))), 1m)), num14);
						goto IL_01ca;
						IL_01ca:
						num = 19;
						num11 = Convert.ToUInt64(decimal.Add(decimal.Add(new decimal(num11), decimal.Subtract(new decimal(num14), new decimal(num11))), 1m));
						goto IL_01fd;
						IL_01fd:
						num = 20;
						num12 = _0026_FFFDӤɢ_FFFD((int)num11);
						goto IL_020b;
						IL_020b:
						num = 21;
						num14 = num12;
						goto IL_0212;
						IL_0212:
						num = 22;
						num15 = _FFFD_061Cã_FFFD蠺((int)num11, num12);
						goto IL_0222;
						IL_0222:
						num = 23;
						num16 = Convert.ToInt64(decimal.Add(decimal.Subtract(new decimal(num11), new decimal(num12)), 1m));
						goto IL_0249;
						IL_0249:
						num = 24;
						num17 = 0;
						goto IL_0390;
						IL_0390:
						num = 26;
						if (num16 < num15)
						{
							goto IL_0254;
						}
						goto IL_03a2;
						IL_03a2:
						num = 43;
						ӓՕΑŚΑ[num8 + num10].content = new string[array.Length - 1 + 1];
						goto IL_03c7;
						IL_03c7:
						num = 44;
						num18 = 0;
						goto IL_03cd;
						IL_03cd:
						num = 45;
						num19 = array.Length - 1;
						num20 = 0;
						goto IL_0692;
						IL_0692:
						if (num20 <= num19)
						{
							goto IL_03e0;
						}
						goto IL_069b;
						IL_069b:
						num = 65;
						num10++;
						goto IL_06a4;
						IL_03e0:
						num = 46;
						if (array[num20].type > 9)
						{
							goto IL_03ff;
						}
						goto IL_0617;
						IL_03ff:
						num = 47;
						if (!_FFFDKЮzĪ(array[num20].type))
						{
							goto IL_0422;
						}
						goto IL_05b4;
						IL_0422:
						num = 48;
						if (decimal.Compare(new decimal(_FFFDƉ_FFFDŁ콪), 1m) == 0)
						{
							goto IL_0443;
						}
						goto IL_04a7;
						IL_0443:
						num = 49;
						ӓՕΑŚΑ[num8 + num10].content[num20] = Encoding.Default.GetString(_F0B9_FFFD_FFFDŲé, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num11), new decimal(num15)), new decimal(num18))), (int)array[num20].size);
						goto IL_0671;
						IL_04a7:
						num = 51;
						if (decimal.Compare(new decimal(_FFFDƉ_FFFDŁ콪), new decimal(2L)) == 0)
						{
							goto IL_04ca;
						}
						goto IL_052e;
						IL_04ca:
						num = 52;
						ӓՕΑŚΑ[num8 + num10].content[num20] = Encoding.Unicode.GetString(_F0B9_FFFD_FFFDŲé, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num11), new decimal(num15)), new decimal(num18))), (int)array[num20].size);
						goto IL_0671;
						IL_052e:
						num = 54;
						if (decimal.Compare(new decimal(_FFFDƉ_FFFDŁ콪), new decimal(3L)) == 0)
						{
							goto IL_0551;
						}
						goto IL_0671;
						IL_0551:
						num = 55;
						ӓՕΑŚΑ[num8 + num10].content[num20] = Encoding.BigEndianUnicode.GetString(_F0B9_FFFD_FFFDŲé, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num11), new decimal(num15)), new decimal(num18))), (int)array[num20].size);
						goto IL_0671;
						IL_05b4:
						num = 58;
						ӓՕΑŚΑ[num8 + num10].content[num20] = Encoding.Default.GetString(_F0B9_FFFD_FFFDŲé, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num11), new decimal(num15)), new decimal(num18))), (int)array[num20].size);
						goto IL_0671;
						IL_0617:
						num = 61;
						ӓՕΑŚΑ[num8 + num10].content[num20] = Conversions.ToString(_0306Թ_FFFD_FFFD_FFFD(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num11), new decimal(num15)), new decimal(num18))), (int)array[num20].size));
						goto IL_0671;
						IL_0671:
						num = 63;
						num18 = (int)(num18 + array[num20].size);
						goto IL_0689;
						IL_0689:
						num = 64;
						num20++;
						goto IL_0692;
						IL_0254:
						num = 27;
						array = (record_header_field[])Utils.CopyArray((Array)array, (Array)new record_header_field[num17 + 1]);
						goto IL_026e;
						IL_026e:
						num = 28;
						num12 = num14 + 1;
						goto IL_0277;
						IL_0277:
						num = 29;
						num14 = _0026_FFFDӤɢ_FFFD(num12);
						goto IL_0284;
						IL_0284:
						num = 30;
						array[num17].type = _FFFD_061Cã_FFFD蠺(num12, num14);
						goto IL_029f;
						IL_029f:
						num = 31;
						if (array[num17].type > 9)
						{
							goto IL_02be;
						}
						goto IL_034c;
						IL_02be:
						num = 32;
						if (_FFFDKЮzĪ(array[num17].type))
						{
							goto IL_02db;
						}
						goto IL_0313;
						IL_02db:
						num = 33;
						array[num17].size = (long)Math.Round((double)(array[num17].type - 13) / 2.0);
						goto IL_0375;
						IL_0313:
						num = 35;
						array[num17].size = (long)Math.Round((double)(array[num17].type - 12) / 2.0);
						goto IL_0375;
						IL_034c:
						num = 38;
						array[num17].size = _0333å_FFFD_FFFD蠺[(int)array[num17].type];
						goto IL_0375;
						IL_0375:
						num = 40;
						num16 = num16 + (num14 - num12) + 1;
						goto IL_0386;
						IL_0386:
						num = 41;
						num17++;
						goto IL_0390;
						IL_06b3:
						num = 67;
						if (_F0B9_FFFD_FFFDŲé[(int)Юē_060Cc_005E] != 5)
						{
							break;
						}
						goto IL_06cb;
						IL_06cb:
						num = 68;
						num21 = Convert.ToUInt16(decimal.Subtract(new decimal(_0306Թ_FFFD_FFFD_FFFD(Convert.ToInt32(decimal.Add(new decimal(Юē_060Cc_005E), new decimal(3L))), 2)), 1m));
						goto IL_0702;
						IL_0702:
						num = 69;
						num22 = num21;
						num5 = 0;
						goto IL_0785;
						IL_0785:
						if (num5 <= num22)
						{
							goto IL_070e;
						}
						goto IL_078b;
						end_IL_0001_2:
						break;
					}
					num = 75;
					result = true;
					break;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 2340;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public bool @_FFFDœ_FFFD_FFFD(string ζ㹃퓜Αٷ)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		string[] array = default(string[]);
		int num6 = default(int);
		int num7 = default(int);
		int num8 = default(int);
		bool result = default(bool);
		int num9 = default(int);
		int num10 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					ref string[] reference;
					switch (try0001_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_000b;
					case 559:
						{
							num2 = num;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_000b;
							case 3:
								goto IL_0010;
							case 4:
								goto IL_0021;
							case 5:
								goto IL_004e;
							case 7:
							case 8:
								goto IL_0058;
							case 6:
							case 9:
								goto IL_0066;
							case 10:
								goto IL_0074;
							case 11:
								goto IL_007e;
							case 12:
								goto IL_00c8;
							case 13:
								goto IL_00db;
							case 14:
								goto IL_00ed;
							case 15:
								goto IL_0101;
							case 16:
								goto IL_010f;
							case 17:
								goto IL_0124;
							case 20:
								goto IL_0145;
							case 21:
								goto IL_0168;
							case 19:
							case 22:
							case 23:
								goto IL_017a;
							case 18:
							case 24:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 25:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_0168:
						num = 21;
						ӓUOչc[num5] = array[num5];
						goto IL_017a;
						IL_017a:
						num = 23;
						num5++;
						goto IL_0183;
						IL_0145:
						num = 20;
						reference = ref ӓUOչc;
						reference = (string[])Utils.CopyArray((Array)reference, (Array)new string[num5 + 1]);
						goto IL_0168;
						IL_0058:
						num = 8;
						num6++;
						goto IL_0060;
						IL_000b:
						num = 2;
						num7 = -1;
						goto IL_0010;
						IL_0010:
						num = 3;
						num8 = չɩ_06DA_FFFD_0657.Length;
						num6 = 0;
						goto IL_0060;
						IL_0060:
						if (num6 <= num8)
						{
							goto IL_0021;
						}
						goto IL_0066;
						IL_0021:
						num = 4;
						if (չɩ_06DA_FFFD_0657[num6].item_name.ToLower().CompareTo(ζ㹃퓜Αٷ.ToLower()) == 0)
						{
							goto IL_004e;
						}
						goto IL_0058;
						IL_004e:
						num = 5;
						num7 = num6;
						goto IL_0066;
						IL_0066:
						num = 9;
						if (num7 == -1)
						{
							goto IL_0074;
						}
						goto IL_007e;
						IL_0074:
						num = 10;
						result = false;
						goto end_IL_0001_3;
						IL_007e:
						num = 11;
						array = չɩ_06DA_FFFD_0657[num7].sql_statement.Substring(չɩ_06DA_FFFD_0657[num7].sql_statement.IndexOf("(") + 1).Split(new char[1] { ',' });
						goto IL_00c8;
						IL_00c8:
						num = 12;
						num9 = array.Length - 1;
						num5 = 0;
						goto IL_0183;
						IL_0183:
						if (num5 > num9)
						{
							break;
						}
						goto IL_00db;
						IL_00db:
						num = 13;
						array[num5] = Strings.LTrim(array[num5]);
						goto IL_00ed;
						IL_00ed:
						num = 14;
						num10 = array[num5].IndexOf(" ");
						goto IL_0101;
						IL_0101:
						num = 15;
						if (num10 > 0)
						{
							goto IL_010f;
						}
						goto IL_0124;
						IL_010f:
						num = 16;
						array[num5] = array[num5].Substring(0, num10);
						goto IL_0124;
						IL_0124:
						num = 17;
						if (array[num5].IndexOf("UNIQUE") == 0)
						{
							break;
						}
						goto IL_0145;
						end_IL_0001_2:
						break;
					}
					num = 24;
					result = ҟŎ_FFFD_FFFD_FFFD((ulong)((չɩ_06DA_FFFD_0657[num7].root_num - 1) * unchecked((long)_00BE_05C9ƜƟ_FFFD)));
					break;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 559;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public int іٵ_FFFDՄ_005E()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int result = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					break;
				case 54:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 3:
							goto end_IL_0001_3;
						}
						goto default;
					}
					end_IL_0001_2:
					break;
				}
				num = 2;
				result = ӓՕΑŚΑ.Length;
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 54;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string ή_06E8丐_00ABų(int _FFFD_1CFC_05C1Kc, int _07A8_05C9蠺iܪ)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string result = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000b;
				case 148:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000b;
						case 3:
							goto IL_0021;
						case 4:
							goto IL_0027;
						case 5:
							goto IL_0048;
						case 6:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 7:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0021:
					num = 3;
					result = null;
					goto end_IL_0001_3;
					IL_0027:
					num = 4;
					if (_07A8_05C9蠺iܪ < ӓՕΑŚΑ[_FFFD_1CFC_05C1Kc].content.Length)
					{
						break;
					}
					goto IL_0048;
					IL_000b:
					num = 2;
					if (_FFFD_1CFC_05C1Kc >= ӓՕΑŚΑ.Length)
					{
						goto IL_0021;
					}
					goto IL_0027;
					IL_0048:
					num = 5;
					result = null;
					goto end_IL_0001_3;
					end_IL_0001_2:
					break;
				}
				num = 6;
				result = ӓՕΑŚΑ[_FFFD_1CFC_05C1Kc].content[_07A8_05C9蠺iܪ];
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 148;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string یϱ_00AB_FFFDZ(int _FFFDŴ_FFFD_07A8ϫ, string Ų_FFFDӛ_FFFD_FFFD)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		string result = default(string);
		int num6 = default(int);
		int num7 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000b;
				case 198:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000b;
						case 3:
							goto IL_0010;
						case 4:
							goto IL_0021;
						case 5:
							goto IL_0045;
						case 7:
						case 8:
							goto IL_004f;
						case 6:
						case 9:
							goto IL_005d;
						case 10:
							goto IL_006b;
						case 11:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 12:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_005d:
					num = 9;
					if (num5 != -1)
					{
						break;
					}
					goto IL_006b;
					IL_006b:
					num = 10;
					result = null;
					goto end_IL_0001_3;
					IL_0045:
					num = 5;
					num5 = num6;
					goto IL_005d;
					IL_004f:
					num = 8;
					num6 = checked(num6 + 1);
					goto IL_0057;
					IL_000b:
					num = 2;
					num5 = -1;
					goto IL_0010;
					IL_0010:
					num = 3;
					num7 = ӓUOչc.Length;
					num6 = 0;
					goto IL_0057;
					IL_0057:
					if (num6 <= num7)
					{
						goto IL_0021;
					}
					goto IL_005d;
					IL_0021:
					num = 4;
					if (ӓUOչc[num6].ToLower().CompareTo(Ų_FFFDӛ_FFFD_FFFD.ToLower()) == 0)
					{
						goto IL_0045;
					}
					goto IL_004f;
					end_IL_0001_2:
					break;
				}
				num = 11;
				result = ή_06E8丐_00ABų(_FFFDŴ_FFFD_07A8ϫ, num5);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 198;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string[] _02E8ܣ_FFFD_FFFD꼺()
	{
		int num = 0;
		checked
		{
			int num2 = չɩ_06DA_FFFD_0657.Length - 1;
			string[] array = default(string[]);
			for (int i = 0; i <= num2; i++)
			{
				if (Operators.CompareString(չɩ_06DA_FFFD_0657[i].item_type, "table", false) == 0)
				{
					array = (string[])Utils.CopyArray((Array)array, (Array)new string[num + 1]);
					array[num] = չɩ_06DA_FFFD_0657[i].item_name;
					num++;
				}
			}
			return array;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public _0739ߡс_02E8鈟(string _FFFD_FFFD_FFFDЅŎ)
	{
		_0333å_FFFD_FFFD蠺 = new byte[10] { 0, 1, 2, 3, 4, 6, 8, 8, 0, 0 };
		int try0020_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string s = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0020_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_002a;
				case 312:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0020;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_002a;
						case 3:
							goto IL_0039;
						case 4:
							goto IL_0048;
						case 5:
							goto IL_0058;
						case 6:
							goto IL_0066;
						case 7:
							goto IL_0078;
						case 8:
							goto IL_008c;
						case 9:
							goto IL_009e;
						case 10:
							goto IL_00b0;
						case 11:
							goto IL_00d1;
						case 12:
							goto end_IL_0020_2;
						default:
							goto end_IL_0020;
						case 13:
						case 14:
							goto end_IL_0020_3;
						}
						goto default;
					}
					IL_009e:
					num = 9;
					_FFFDƉ_FFFDŁ콪 = _0306Թ_FFFD_FFFD_FFFD(56, 4);
					goto IL_00b0;
					IL_00b0:
					num = 10;
					if (decimal.Compare(new decimal(_FFFDƉ_FFFDŁ콪), 0m) != 0)
					{
						break;
					}
					goto IL_00d1;
					IL_008c:
					num = 8;
					_00BE_05C9ƜƟ_FFFD = checked((ushort)_0306Թ_FFFD_FFFD_FFFD(16, 2));
					goto IL_009e;
					IL_00d1:
					num = 11;
					_FFFDƉ_FFFDŁ콪 = 1uL;
					break;
					IL_002a:
					num = 2;
					if (!File.Exists(_FFFD_FFFD_FFFDЅŎ))
					{
						goto end_IL_0020_3;
					}
					goto IL_0039;
					IL_0039:
					num = 3;
					FileSystem.FileOpen(1, _FFFD_FFFD_FFFDЅŎ, (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
					goto IL_0048;
					IL_0048:
					num = 4;
					s = Strings.Space(checked((int)FileSystem.LOF(1)));
					goto IL_0058;
					IL_0058:
					num = 5;
					FileSystem.FileGet(1, ref s, -1L, false);
					goto IL_0066;
					IL_0066:
					num = 6;
					FileSystem.FileClose(new int[1] { 1 });
					goto IL_0078;
					IL_0078:
					num = 7;
					_F0B9_FFFD_FFFDŲé = Encoding.Default.GetBytes(s);
					goto IL_008c;
					end_IL_0020_2:
					break;
				}
				num = 12;
				_0331_FFFD_FFFD_0331_FFFD(100uL);
				break;
				end_IL_0020:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0020_dispatch = 312;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0020_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
