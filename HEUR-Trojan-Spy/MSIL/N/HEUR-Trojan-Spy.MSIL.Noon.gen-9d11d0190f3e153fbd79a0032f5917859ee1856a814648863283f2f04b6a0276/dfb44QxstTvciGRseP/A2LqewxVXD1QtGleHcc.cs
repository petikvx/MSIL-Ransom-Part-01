using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace dfb44QxstTvciGRseP;

public class A2LqewxVXD1QtGleHcc : oLXIBjxPfZLjvEX5tjr
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct bBW6fEcSOpEs5v1OhGD
	{
		public A2LqewxVXD1QtGleHcc tI2M0fPJqf;

		public Array gTAMjwvLMw;

		public int ftNMKh6hp8;

		public List<object> tthMY0jpZf;

		public object T65MzSe5mu;

		public object B7uCwmi73J;

		public int vwMCsynFci;
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool Mf2ScyCttw;

	protected BinaryReader TFBS7DDs1E;

	internal static A2LqewxVXD1QtGleHcc oBDJfE7Remjdt6oK07X;

	[SpecialName]
	[CompilerGenerated]
	public bool FPeS1xotfb()
	{
		return Mf2ScyCttw;
	}

	[SpecialName]
	[CompilerGenerated]
	public void aYLSZ5PDaw(bool bool_0)
	{
		Mf2ScyCttw = bool_0;
	}

	public A2LqewxVXD1QtGleHcc(Stream stream_0, VElg1KxQgKwns2H2VEa velg1KxQgKwns2H2VEa_0)
	{
		GRgbqpcvG2cupxT0496.SF54tCZzYSfdV();
		Mf2ScyCttw = false;
		base._002Ector(stream_0, velg1KxQgKwns2H2VEa_0);
	}

	public override void Dispose()
	{
		c8BSPP7565 = null;
		TFBS7DDs1E.Dispose();
	}

	public hxk6SwxjJn4feiy4Pbi mUISyaosSx(out PBo11yxJuWSePXEpLhP pbo11yxJuWSePXEpLhP_0)
	{
		bBW6fEcSOpEs5v1OhGD bBW6fEcSOpEs5v1OhGD_ = default(bBW6fEcSOpEs5v1OhGD);
		bBW6fEcSOpEs5v1OhGD_.tI2M0fPJqf = this;
		if (!c8BSPP7565.CanRead)
		{
			throw new InvalidOperationException("The stream is unreadable.");
		}
		bBW6fEcSOpEs5v1OhGD_.tthMY0jpZf = new List<object>();
		bBW6fEcSOpEs5v1OhGD_.T65MzSe5mu = null;
		bBW6fEcSOpEs5v1OhGD_.ftNMKh6hp8 = 0;
		bBW6fEcSOpEs5v1OhGD_.vwMCsynFci = 0;
		bBW6fEcSOpEs5v1OhGD_.gTAMjwvLMw = null;
		object ro6S91nO7K = Ro6S91nO7K;
		int num = 1;
		if (!LjsFV17IsNAGqwjvGnb())
		{
			goto IL_0076;
		}
		goto IL_007a;
		IL_007a:
		bool lockTaken = default(bool);
		bool flag2 = default(bool);
		hxk6SwxjJn4feiy4Pbi result = default(hxk6SwxjJn4feiy4Pbi);
		int num4 = default(int);
		do
		{
			switch (num)
			{
			case 1:
				break;
			default:
				try
				{
					Monitor.Enter(ro6S91nO7K, ref lockTaken);
					while (true)
					{
						int num2 = 0;
						byte byte_;
						bool flag = TFBS7DDs1E.OKxTiH3Hc6(out byte_) != null;
						int num3 = 1;
						if (gWMRNK7gxGqaJUmaToE() != null)
						{
							goto IL_00b5;
						}
						goto IL_0102;
						IL_0102:
						while (true)
						{
							switch (num3)
							{
							case 3:
								if (flag2)
								{
									if (byte_ != byte.MaxValue)
									{
										num3 = 0;
										if (gWMRNK7gxGqaJUmaToE() == null)
										{
											continue;
										}
										break;
									}
									AktSoT7opP(ref bBW6fEcSOpEs5v1OhGD_);
									pbo11yxJuWSePXEpLhP_0 = default(PBo11yxJuWSePXEpLhP);
									return (hxk6SwxjJn4feiy4Pbi)2;
								}
								num2 = 0;
								num3 = 6;
								if (LjsFV17IsNAGqwjvGnb())
								{
									continue;
								}
								goto case 5;
							case 1:
								if (flag)
								{
									G7vqI854MalMAxPWQ1.We7hfj9UyJ("CANT_READ: start byte");
									num3 = 2;
									if (gWMRNK7gxGqaJUmaToE() == null)
									{
										continue;
									}
									break;
								}
								flag2 = byte_ != CxVSIjjSkW().i4PuaWONq9;
								goto case 3;
							default:
								goto end_IL_0102;
							case 6:
							{
								if (TFBS7DDs1E.JLNTmPdFxn(out var _) == null)
								{
									goto case 5;
								}
								G7vqI854MalMAxPWQ1.We7hfj9UyJ("CANT_READ: command id");
								goto case 2;
							}
							case 5:
							{
								if (TFBS7DDs1E.OKxTiH3Hc6(out var byte_2) != null)
								{
									G7vqI854MalMAxPWQ1.We7hfj9UyJ("CANT_READ: end byte");
									goto case 2;
								}
								if (byte_2 != CxVSIjjSkW().JQNu5aifrj)
								{
									rcv1g17xRx6r2g767u8("INV_DATA: end byte");
								}
								AktSoT7opP(ref bBW6fEcSOpEs5v1OhGD_);
								pbo11yxJuWSePXEpLhP_0 = default(PBo11yxJuWSePXEpLhP);
								return (hxk6SwxjJn4feiy4Pbi)4;
							}
							case 2:
								AktSoT7opP(ref bBW6fEcSOpEs5v1OhGD_);
								pbo11yxJuWSePXEpLhP_0 = default(PBo11yxJuWSePXEpLhP);
								goto case 4;
							case 4:
								return (hxk6SwxjJn4feiy4Pbi)3;
							case 7:
								return result;
							}
							goto IL_00b5;
							continue;
							end_IL_0102:
							break;
						}
						num2++;
						continue;
						IL_00b5:
						num3 = num4;
						goto IL_0102;
					}
				}
				finally
				{
					if (lockTaken)
					{
						Monitor.Exit(ro6S91nO7K);
					}
				}
			}
			lockTaken = false;
			num = 0;
		}
		while (LjsFV17IsNAGqwjvGnb());
		goto IL_0076;
		IL_0076:
		int num5 = default(int);
		num = num5;
		goto IL_007a;
	}

	[CompilerGenerated]
	private int q8XSf5pBut(EdRPUvx6HtFjma48dEu edRPUvx6HtFjma48dEu_0, ref bBW6fEcSOpEs5v1OhGD bBW6fEcSOpEs5v1OhGD_0)
	{
		Exception ex = null;
		object obj = null;
		bool flag = default(bool);
		int result = default(int);
		long long_ = default(long);
		char char_ = default(char);
		short short_ = default(short);
		int num2 = default(int);
		while (true)
		{
			IL_0464:
			EdRPUvx6HtFjma48dEu edRPUvx6HtFjma48dEu = edRPUvx6HtFjma48dEu_0;
			EdRPUvx6HtFjma48dEu edRPUvx6HtFjma48dEu2 = edRPUvx6HtFjma48dEu;
			int num;
			if (edRPUvx6HtFjma48dEu2 > (EdRPUvx6HtFjma48dEu)401)
			{
				if (edRPUvx6HtFjma48dEu2 <= (EdRPUvx6HtFjma48dEu)737)
				{
					num = 2;
					if (gWMRNK7gxGqaJUmaToE() != null)
					{
						goto IL_0134;
					}
				}
				else if (edRPUvx6HtFjma48dEu2 <= (EdRPUvx6HtFjma48dEu)865)
				{
					if (edRPUvx6HtFjma48dEu2 != (EdRPUvx6HtFjma48dEu)793)
					{
						if (edRPUvx6HtFjma48dEu2 == (EdRPUvx6HtFjma48dEu)865)
						{
							ex = TFBS7DDs1E.xpwTb8JRah(out var double_);
							obj = double_;
						}
						goto IL_0113;
					}
					ex = TFBS7DDs1E.EiTTd6UjIY(out var float_);
					obj = float_;
					num = 16;
					if (gWMRNK7gxGqaJUmaToE() != null)
					{
						goto IL_0134;
					}
				}
				else
				{
					if (edRPUvx6HtFjma48dEu2 != (EdRPUvx6HtFjma48dEu)937)
					{
						if (edRPUvx6HtFjma48dEu2 != (EdRPUvx6HtFjma48dEu)993)
						{
							if (edRPUvx6HtFjma48dEu2 != (EdRPUvx6HtFjma48dEu)1065)
							{
								goto IL_0113;
							}
							goto IL_0262;
						}
						goto IL_0398;
					}
					ex = TFBS7DDs1E.uwMTOMlctU(out var decimal_);
					obj = decimal_;
					num = 5;
					if (gWMRNK7gxGqaJUmaToE() != null)
					{
						goto IL_0134;
					}
				}
			}
			else
			{
				num = 4;
				if (!LjsFV17IsNAGqwjvGnb())
				{
					goto IL_0134;
				}
			}
			goto IL_03df;
			IL_0113:
			flag = ex != null;
			goto IL_011a;
			IL_04bd:
			dNUSB7sqdG(obj, ref bBW6fEcSOpEs5v1OhGD_0);
			result = 0;
			break;
			IL_011a:
			if (flag)
			{
				result = 1;
				num = 0;
				if (!LjsFV17IsNAGqwjvGnb())
				{
					goto IL_0134;
				}
				goto IL_03df;
			}
			goto IL_047a;
			IL_03df:
			int count;
			do
			{
				IL_03df_2:
				switch (num)
				{
				case 26:
					break;
				case 5:
				case 6:
				case 7:
				case 8:
				case 15:
				case 16:
				case 18:
				case 20:
				case 21:
				case 25:
					goto end_IL_03df;
				case 14:
					goto IL_011a;
				case 24:
					obj = long_;
					num = 18;
					if (LjsFV17IsNAGqwjvGnb())
					{
						goto IL_03df_2;
					}
					goto IL_047a;
				case 23:
					if (edRPUvx6HtFjma48dEu2 != (EdRPUvx6HtFjma48dEu)201)
					{
						goto end_IL_03df;
					}
					ex = TFBS7DDs1E.KKsTWKatZV(out char_);
					goto case 17;
				case 17:
					obj = char_;
					goto end_IL_03df;
				case 22:
					goto IL_017f;
				case 19:
				{
					ex = TFBS7DDs1E.g8qTkQe0oO(out var int_);
					obj = int_;
					goto end_IL_03df;
				}
				case 13:
					obj = short_;
					goto end_IL_03df;
				case 11:
				{
					if (edRPUvx6HtFjma48dEu2 != (EdRPUvx6HtFjma48dEu)465)
					{
						if (edRPUvx6HtFjma48dEu2 != (EdRPUvx6HtFjma48dEu)537)
						{
							goto end_IL_03df;
						}
						goto case 19;
					}
					ex = TFBS7DDs1E.JLNTmPdFxn(out var ushort_);
					obj = ushort_;
					goto end_IL_03df;
				}
				case 4:
					if (edRPUvx6HtFjma48dEu2 <= (EdRPUvx6HtFjma48dEu)41)
					{
						goto IL_0204;
					}
					if (edRPUvx6HtFjma48dEu2 <= (EdRPUvx6HtFjma48dEu)201)
					{
						if (edRPUvx6HtFjma48dEu2 != (EdRPUvx6HtFjma48dEu)153)
						{
							goto case 23;
						}
						ex = TFBS7DDs1E.KU5TQXKu5D(out var bool_);
						obj = bool_;
						goto end_IL_03df;
					}
					goto IL_02ee;
				case 3:
					goto IL_0251;
				case 1:
					goto IL_02ee;
				case 2:
					if (edRPUvx6HtFjma48dEu2 <= (EdRPUvx6HtFjma48dEu)537)
					{
						goto case 11;
					}
					goto IL_0381;
				case 12:
					goto IL_0464;
				case 9:
					goto IL_047a;
				case 10:
					goto IL_04bd;
				default:
					goto end_IL_0464;
				}
				goto IL_00e0;
				IL_0381:
				if (edRPUvx6HtFjma48dEu2 != (EdRPUvx6HtFjma48dEu)601)
				{
					if (edRPUvx6HtFjma48dEu2 != (EdRPUvx6HtFjma48dEu)673)
					{
						goto IL_00e0;
					}
					goto IL_0398;
				}
				ex = TFBS7DDs1E.ro3T8wV9Ob(out var uint_);
				obj = uint_;
				num2 = 20;
				break;
				IL_017f:
				BinaryReader tFBS7DDs1E = TFBS7DDs1E;
				count = 1;
				ex = tFBS7DDs1E.LV9Tx40Pp0(in count, out var byte_);
				obj = byte_;
				break;
				IL_00e0:
				if (edRPUvx6HtFjma48dEu2 != (EdRPUvx6HtFjma48dEu)737)
				{
					num = 6;
					continue;
				}
				ex = TFBS7DDs1E.SraTV3Dkyr(out var ulong_);
				obj = ulong_;
				break;
				IL_0204:
				if (edRPUvx6HtFjma48dEu2 <= (EdRPUvx6HtFjma48dEu)17)
				{
					if (edRPUvx6HtFjma48dEu2 != (EdRPUvx6HtFjma48dEu)9)
					{
						if (edRPUvx6HtFjma48dEu2 != (EdRPUvx6HtFjma48dEu)17)
						{
							break;
						}
						BinaryReader tFBS7DDs1E2 = TFBS7DDs1E;
						count = 2;
						ex = tFBS7DDs1E2.LV9Tx40Pp0(in count, out var byte_2);
						obj = byte_2;
						num = 8;
						if (gWMRNK7gxGqaJUmaToE() == null)
						{
							goto IL_03df_2;
						}
						goto IL_0134;
					}
					goto IL_017f;
				}
				if (edRPUvx6HtFjma48dEu2 == (EdRPUvx6HtFjma48dEu)25)
				{
					BinaryReader tFBS7DDs1E3 = TFBS7DDs1E;
					count = 4;
					ex = tFBS7DDs1E3.LV9Tx40Pp0(in count, out var byte_3);
					obj = byte_3;
					break;
				}
				goto IL_0251;
				IL_02ee:
				if (edRPUvx6HtFjma48dEu2 != (EdRPUvx6HtFjma48dEu)265)
				{
					if (edRPUvx6HtFjma48dEu2 != (EdRPUvx6HtFjma48dEu)329)
					{
						if (edRPUvx6HtFjma48dEu2 != (EdRPUvx6HtFjma48dEu)401)
						{
							break;
						}
						ex = TFBS7DDs1E.blyTNMVXI8(out short_);
						num = 13;
						if (gWMRNK7gxGqaJUmaToE() == null)
						{
							goto IL_03df_2;
						}
						goto IL_0134;
					}
					ex = TFBS7DDs1E.OKxTiH3Hc6(out var byte_4);
					obj = byte_4;
					num2 = 21;
					break;
				}
				ex = TFBS7DDs1E.OGdT65DRoj(out var sbyte_);
				obj = sbyte_;
				break;
				continue;
				end_IL_03df:
				break;
			}
			while (!LjsFV17IsNAGqwjvGnb());
			goto IL_0113;
			IL_0398:
			ex = TFBS7DDs1E.BavTgkm3l9(out long_);
			num = 24;
			if (!LjsFV17IsNAGqwjvGnb())
			{
				goto IL_0134;
			}
			goto IL_03df;
			IL_0134:
			num = num2;
			goto IL_03df;
			IL_047a:
			switch (edRPUvx6HtFjma48dEu_0)
			{
			case (EdRPUvx6HtFjma48dEu)1065:
				obj = new Guid((byte[])obj);
				break;
			case (EdRPUvx6HtFjma48dEu)993:
				obj = DateTime.FromBinary((long)obj);
				break;
			}
			goto IL_04bd;
			IL_0262:
			BinaryReader tFBS7DDs1E4 = TFBS7DDs1E;
			count = 16;
			ex = tFBS7DDs1E4.LV9Tx40Pp0(in count, out var byte_5);
			obj = byte_5;
			goto IL_0113;
			IL_0251:
			if (edRPUvx6HtFjma48dEu2 != (EdRPUvx6HtFjma48dEu)33)
			{
				if (edRPUvx6HtFjma48dEu2 == (EdRPUvx6HtFjma48dEu)41)
				{
					goto IL_0262;
				}
			}
			else
			{
				BinaryReader tFBS7DDs1E5 = TFBS7DDs1E;
				count = 8;
				ex = tFBS7DDs1E5.LV9Tx40Pp0(in count, out var byte_6);
				obj = byte_6;
			}
			goto IL_0113;
			continue;
			end_IL_0464:
			break;
		}
		return result;
	}

	[CompilerGenerated]
	private int WRYSDKwPpS(EdRPUvx6HtFjma48dEu edRPUvx6HtFjma48dEu_0, ref bBW6fEcSOpEs5v1OhGD bBW6fEcSOpEs5v1OhGD_0)
	{
		int num = 2;
		EdRPUvx6HtFjma48dEu edRPUvx6HtFjma48dEu2 = default(EdRPUvx6HtFjma48dEu);
		object object_ = default(object);
		byte[] byte_ = default(byte[]);
		int result = default(int);
		byte byte_2 = default(byte);
		bool flag = default(bool);
		while (true)
		{
			int int_ = 0;
			int num2 = 1;
			if (gWMRNK7gxGqaJUmaToE() != null)
			{
				goto IL_004c;
			}
			goto IL_00bf;
			IL_00bf:
			while (true)
			{
				switch (num2)
				{
				case 6:
				{
					EdRPUvx6HtFjma48dEu edRPUvx6HtFjma48dEu = edRPUvx6HtFjma48dEu_0;
					edRPUvx6HtFjma48dEu2 = edRPUvx6HtFjma48dEu;
					if (edRPUvx6HtFjma48dEu2 != (EdRPUvx6HtFjma48dEu)1090)
					{
						num2 = 1;
						if (gWMRNK7gxGqaJUmaToE() != null)
						{
							continue;
						}
						goto case 3;
					}
					object_ = CxVSIjjSkW().MTKuXsMd6S.GetString(byte_);
					goto IL_012e;
				}
				case 4:
					goto IL_0076;
				case 1:
					goto IL_009e;
				case 2:
					goto end_IL_00bf;
				case 3:
					if (edRPUvx6HtFjma48dEu2 == (EdRPUvx6HtFjma48dEu)1218)
					{
						object_ = byte_;
					}
					goto IL_012e;
				case 5:
					{
						return result;
					}
					IL_012e:
					dNUSB7sqdG(object_, ref bBW6fEcSOpEs5v1OhGD_0);
					return 0;
				}
				if (byte_2 == CxVSIjjSkW().jiKunPtGM5)
				{
					if (TFBS7DDs1E.LV9Tx40Pp0(in int_, out byte_) == null)
					{
						object_ = null;
						num2 = 6;
						if (gWMRNK7gxGqaJUmaToE() == null)
						{
							continue;
						}
						goto IL_004c;
					}
					return 1;
				}
				return 2;
				IL_009e:
				flag = TFBS7DDs1E.g8qTkQe0oO(out int_) != null;
				num2 = 4;
				if (gWMRNK7gxGqaJUmaToE() == null)
				{
					continue;
				}
				goto IL_004c;
				IL_0076:
				if (!flag)
				{
					if (TFBS7DDs1E.OKxTiH3Hc6(out byte_2) == null)
					{
						num2 = 0;
						if (LjsFV17IsNAGqwjvGnb())
						{
							continue;
						}
						goto IL_004c;
					}
					return 1;
				}
				return 1;
				continue;
				end_IL_00bf:
				break;
			}
			continue;
			IL_004c:
			num2 = num;
			goto IL_00bf;
		}
	}

	[CompilerGenerated]
	private void dNUSB7sqdG(object object_0, ref bBW6fEcSOpEs5v1OhGD bBW6fEcSOpEs5v1OhGD_0)
	{
		if (bBW6fEcSOpEs5v1OhGD_0.gTAMjwvLMw != null)
		{
			WwCOU87iqV3PAu5cqoB(bBW6fEcSOpEs5v1OhGD_0.gTAMjwvLMw, object_0, bBW6fEcSOpEs5v1OhGD_0.ftNMKh6hp8);
			return;
		}
		bBW6fEcSOpEs5v1OhGD_0.tthMY0jpZf.Add(object_0);
		int num = 0;
		if (gWMRNK7gxGqaJUmaToE() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
	}

	[CompilerGenerated]
	private void AktSoT7opP(ref bBW6fEcSOpEs5v1OhGD bBW6fEcSOpEs5v1OhGD_0)
	{
		bBW6fEcSOpEs5v1OhGD_0.T65MzSe5mu = null;
		bBW6fEcSOpEs5v1OhGD_0.B7uCwmi73J = null;
		bBW6fEcSOpEs5v1OhGD_0.gTAMjwvLMw = null;
		bBW6fEcSOpEs5v1OhGD_0.vwMCsynFci = 0;
		bBW6fEcSOpEs5v1OhGD_0.ftNMKh6hp8 = 0;
	}

	internal static bool LjsFV17IsNAGqwjvGnb()
	{
		return oBDJfE7Remjdt6oK07X == null;
	}

	internal static A2LqewxVXD1QtGleHcc gWMRNK7gxGqaJUmaToE()
	{
		return oBDJfE7Remjdt6oK07X;
	}

	internal static void rcv1g17xRx6r2g767u8(object object_0)
	{
		G7vqI854MalMAxPWQ1.We7hfj9UyJ((string)object_0);
	}

	internal static void WwCOU87iqV3PAu5cqoB(object object_0, object object_1, int int_0)
	{
		((Array)object_0).SetValue(object_1, int_0);
	}
}
