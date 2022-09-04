using _0001;
using _0003;
using _0004;

namespace Ⴈ;

internal struct Ⴐ
{
	private global::_0001._0003._0001 m__0001;

	public unsafe void _0001()
	{
		//Discarded unreachable code: IL_0016
		//IL_001e: Incompatible stack heights: 0 vs 1
		//IL_0024: Incompatible stack heights: 0 vs 2
		uint num = 1024u;
		_ = &((Ⴐ*)(nint)/*Error near IL_000e: Stack underflow*/)->_0001;
		((global::_0001._0003._0001*)(nint)/*Error near IL_0015: Stack underflow*/)->_0001 = (uint)/*Error near IL_0015: Stack underflow*/;
	}

	public unsafe uint _0001(global::_0003._0003 P_0)
	{
		//IL_006d: Incompatible stack heights: 0 vs 1
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Incompatible stack heights: 1 vs 0
		//IL_00a6: Invalid comparison between Unknown and I4
		//IL_020e: Incompatible stack heights: 0 vs 1
		//IL_021a: Incompatible stack heights: 0 vs 1
		//IL_0220: Incompatible stack heights: 0 vs 1
		//IL_0226: Expected I4, but got Unknown
		//IL_0232: Incompatible stack heights: 0 vs 1
		//IL_0238: Incompatible stack heights: 0 vs 2
		while (true)
		{
			uint num = ((global::_0003._0003)/*Error near IL_006b: Stack underflow*/)._0001;
			int num2 = 11;
			while (true)
			{
				IL_006d:
				_ = num >> num2;
				while (true)
				{
					uint num3 = ((Ⴐ*)(nint)/*Error near IL_0078: Stack underflow*/)->_0001._0001;
					while (true)
					{
						IL_007d:
						uint num4 = (uint)(int)(/*Error near IL_007e: Stack underflow*/ * num3);
						int num5;
						if (0 == 0)
						{
							num5 = 4;
							goto IL_0007;
						}
						goto IL_017b;
						IL_015f:
						P_0._0001 -= num4;
						P_0._0002 -= num4;
						goto IL_017b;
						IL_017b:
						num5 = 3;
						goto IL_0007;
						IL_0007:
						while (2u != 0)
						{
							switch (/*Error near IL_0053: Stack underflow*/)
							{
							case 1L:
								goto end_IL_0073;
							case 4L:
								goto IL_0099;
							case 15L:
								goto IL_00b7;
							case 6L:
							case 7L:
								goto IL_00f7;
							case 13L:
								goto IL_011b;
							case 0L:
							case 16L:
								goto IL_0148;
							case 5L:
								return 0u;
							case 2L:
								goto IL_015f;
							case 3L:
								goto IL_0182;
							case 8L:
								goto IL_01af;
							case 14L:
								P_0._0002 = (P_0._0002 << 8) | (byte)global::_0003._0003._0001(P_0._0001, 552, 537);
								goto case 10L;
							case 10L:
								num5 = 9;
								continue;
							case 9L:
								goto IL_01f5;
							case 11L:
								return 1u;
							}
							/*OpCode not supported: LdMemberToken*/;
							num5 = 1;
							continue;
							IL_00f7:
							num = P_0._0001;
							num2 = 16777216;
							if (num2 != 0)
							{
								int num6;
								if (num < (uint)num2)
								{
									if (false)
									{
										goto IL_01f5;
									}
									num6 = 13;
								}
								else
								{
									num6 = 5;
								}
								num5 = num6;
								continue;
							}
							goto IL_006d;
							IL_01af:
							num5 = ((P_0._0001 >= 16777216) ? 11 : 14);
							continue;
							IL_0099:
							_ = ((global::_0003._0003)/*Error near IL_009e: Stack underflow*/)._0002;
							if (0 == 0)
							{
								num5 = (((int)/*Error near IL_00a8: Stack underflow*/ >= (int)num3) ? 2 : 15);
								continue;
							}
							goto IL_007d;
							IL_01f5:
							P_0._0001 <<= 8;
							num5 = 11;
							continue;
							IL_00b7:
							if ((0 == 0) ? true : false)
							{
								P_0._0001 = num4;
								uint num7 = this.m__0001._0001 + (2048 - this.m__0001._0001 >> 5);
								this.m__0001._0001 = num7;
								num5 = 7;
							}
							continue;
							IL_0182:
							uint num8 = this.m__0001._0001 - (this.m__0001._0001 >> 5);
							this.m__0001._0001 = num8;
							num5 = 8;
							continue;
							IL_0148:
							P_0._0001 <<= 8;
							num5 = 5;
							continue;
							IL_011b:
							P_0._0002 = (P_0._0002 << 8) | (byte)global::_0003._0003._0001(P_0._0001, 379, 330);
							num5 = 16;
						}
						break;
					}
					continue;
					end_IL_0073:
					break;
				}
				break;
			}
		}
	}

	static Ⴐ()
	{
		//Discarded unreachable code: IL_0003
		_0004._0001._0001();
	}
}
