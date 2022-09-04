using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns3;
using ns4;
using ns5;
using ns6;

namespace ns0;

internal class Class26
{
	static void smethod_0(int int_0, Class15.Class18 class18_0, byte[] byte_0, int int_1)
	{
		if (class18_0.int_3 > 0)
		{
			throw new InvalidOperationException();
		}
		if (int_1 > 32768)
		{
			int_0 += int_1 - 32768;
			int_1 = 32768;
		}
		Array.Copy(byte_0, int_0, class18_0.byte_0, 0, int_1);
		class18_0.int_2 = int_1 & 0x7FFF;
	}

	unsafe static void smethod_1(Class15.Class22.Class23 class23_0, Class15.Class22.Class23 class23_1)
	{
		void* ptr = stackalloc byte[20];
		*(int*)((byte*)ptr + 8) = -1;
		*(int*)((byte*)ptr + 12) = 0;
		while (*(int*)((byte*)ptr + 12) < class23_1.int_1)
		{
			int num = 1;
			*(int*)((byte*)ptr + 16) = class23_1.byte_0[*(int*)((byte*)ptr + 12)];
			if (*(int*)((byte*)ptr + 16) == 0)
			{
				*(int*)ptr = 138;
				*(int*)((byte*)ptr + 4) = 3;
			}
			else
			{
				*(int*)ptr = 6;
				*(int*)((byte*)ptr + 4) = 3;
				if (*(int*)((byte*)ptr + 8) != *(int*)((byte*)ptr + 16))
				{
					short[] short_;
					short[] array = (short_ = class23_0.short_0);
					int num2 = *(int*)((byte*)ptr + 16);
					nint num3 = num2;
					array[num2] = (short)(short_[num3] + 1);
					num = 0;
				}
			}
			*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 16);
			(*(int*)((byte*)ptr + 12))++;
			while (*(int*)((byte*)ptr + 12) < class23_1.int_1 && *(int*)((byte*)ptr + 8) == class23_1.byte_0[*(int*)((byte*)ptr + 12)])
			{
				(*(int*)((byte*)ptr + 12))++;
				if (++num >= *(int*)ptr)
				{
					break;
				}
			}
			if (num < *(int*)((byte*)ptr + 4))
			{
				short[] short_;
				short[] array2 = (short_ = class23_0.short_0);
				int num4 = *(int*)((byte*)ptr + 8);
				nint num3 = num4;
				array2[num4] = (short)(short_[num3] + (short)num);
			}
			else if (*(int*)((byte*)ptr + 8) != 0)
			{
				short[] short_;
				(short_ = class23_0.short_0)[16] = (short)(short_[16] + 1);
			}
			else if (num <= 10)
			{
				short[] short_;
				(short_ = class23_0.short_0)[17] = (short)(short_[17] + 1);
			}
			else
			{
				short[] short_;
				(short_ = class23_0.short_0)[18] = (short)(short_[18] + 1);
			}
		}
	}

	static void smethod_2(int int_0, byte[] byte_0, int int_1, Class15.Class17 class17_0)
	{
		if (class17_0.int_0 < class17_0.int_1)
		{
			throw new InvalidOperationException();
		}
		int num = int_0 + int_1;
		if (0 <= int_0 && int_0 <= num && num <= byte_0.Length)
		{
			if (((uint)int_1 & (true ? 1u : 0u)) != 0)
			{
				class17_0.uint_0 |= (uint)((byte_0[int_0++] & 0xFF) << class17_0.int_2);
				class17_0.int_2 += 8;
			}
			class17_0.byte_0 = byte_0;
			class17_0.int_0 = int_0;
			class17_0.int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	static Class15.Class19 smethod_3(Class15.Class20 class20_0)
	{
		byte[] array = new byte[class20_0.int_10];
		Array.Copy(class20_0.byte_1, class20_0.int_9, array, 0, class20_0.int_10);
		return new Class15.Class19(array);
	}

	unsafe static int smethod_4(int int_0, Class15.Class16 class16_0, int int_1, byte[] byte_0)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 0;
		do
		{
			if (class16_0.int_17 != 11)
			{
				*(int*)((byte*)ptr + 4) = Class26.smethod_55(byte_0, int_1, int_0, class16_0.class18_0);
				int_1 += *(int*)((byte*)ptr + 4);
				*(int*)ptr += *(int*)((byte*)ptr + 4);
				int_0 -= *(int*)((byte*)ptr + 4);
				if (int_0 == 0)
				{
					return *(int*)ptr;
				}
			}
		}
		while (Class26.smethod_52(class16_0) || (class16_0.class18_0.int_3 > 0 && class16_0.int_17 != 11));
		return *(int*)ptr;
	}

	unsafe static object smethod_5(Class6 class6_0)
	{
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		void* ptr = stackalloc byte[173];
		decimal num = new decimal(784488618L);
		*(double*)ptr = 5026281.0;
		((byte*)ptr)[172] = 1;
		if (((byte*)ptr)[172] != 0)
		{
			*(int*)((byte*)ptr + 112) = 8006698;
		}
		else
		{
			*(int*)((byte*)ptr + 116) = 325205445;
		}
		while (true)
		{
			((byte*)ptr)[172] = 0;
			if (((byte*)ptr)[172] == 0)
			{
				break;
			}
			*(double*)ptr = 67482609.0;
			*(double*)ptr = 905129313.0;
			while (true)
			{
				((byte*)ptr)[172] = 0;
				if (((byte*)ptr)[172] == 0)
				{
					break;
				}
				*(double*)ptr = 12.0;
				try
				{
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					*(long*)((byte*)ptr + 8) = 954L;
					new decimal(79729730L);
					((byte*)ptr)[172] = 0;
					if (((byte*)ptr)[172] != 0)
					{
						try
						{
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							*(double*)ptr = 16.0;
							try
							{
							}
							catch (Exception projectError3)
							{
								ProjectData.SetProjectError(projectError3);
								*(int*)((byte*)ptr + 128) = 1678;
								new decimal(164L);
								ProjectData.ClearProjectError();
							}
							*(double*)ptr = 1.0;
							*(double*)ptr = 4061.0;
							ProjectData.ClearProjectError();
						}
						new decimal(106L);
						((byte*)ptr)[168] = 1;
						*(int*)((byte*)ptr + 124) = 276123285;
						((byte*)ptr)[169] = 1;
						*(int*)((byte*)ptr + 120) = 6;
						while (true)
						{
							((byte*)ptr)[172] = 1;
							if (((byte*)ptr)[172] == 0)
							{
								break;
							}
							num = new decimal(1878L);
							*(long*)((byte*)ptr + 24) = 896616638L;
							*(long*)((byte*)ptr + 16) = 37281L;
							*(double*)((byte*)ptr + 32) = 32355481.0;
							MessageBox.Show("[\u0090l\u008f4Ao’'‰x=`\u007fc^o~xn‡3\u008d\u008dŠislD'-o{D.†PE\u008f)kf\u007f^B‘F‹&\u007f} &‰ˆHr%]an’{)T;pp-J‚oCGOj‹BzfX=,i…Nyƒq?RZh‹€u8\\+:HrR1J†g f',:yO5toSb\u007fŠ\u007fN*O4LHYmQO7`=y~\u008d>‘zx=j37t8v,&x\u008d>C\\CHu5Z>Z");
						}
						num = new decimal(7708L);
						do
						{
							((byte*)ptr)[172] = 0;
						}
						while (((byte*)ptr)[172] != 0);
						*(double*)ptr = 236028.0;
						MessageBox.Show("u{X;o=n}\u0090Z}8N‡‡.KƒjP€x\u008fmt>q7‹LX‚UYcƒ\u0081++'4\\‹S=\u008f0-qm\u0090KGŽr?![P+xaPr^R[C=I`‰Fl<$9WB`):r[V.");
						MessageBox.Show("Em’Bf+8ˆ}S");
						while (true)
						{
							((byte*)ptr)[172] = 0;
							if (((byte*)ptr)[172] == 0)
							{
								break;
							}
							while (true)
							{
								((byte*)ptr)[172] = 1;
								if (((byte*)ptr)[172] == 0)
								{
									break;
								}
								*(double*)((byte*)ptr + 56) = 6.0;
								*(int*)((byte*)ptr + 136) = 1;
								new decimal(51719L);
								try
								{
								}
								catch (Exception projectError4)
								{
									ProjectData.SetProjectError(projectError4);
									*(int*)((byte*)ptr + 144) = 33030;
									int num2;
									do
									{
										*(double*)((byte*)ptr + 72) = 259.0;
										new decimal(3L);
										checked
										{
											(*unchecked((int*)((byte*)ptr + 144)))++;
										}
										num2 = *(int*)((byte*)ptr + 144);
										*(int*)((byte*)ptr + 164) = 868454;
									}
									while (num2 <= *(int*)((byte*)ptr + 164));
									new decimal(2L);
									MessageBox.Show("P+W€7%\u008d4JsF0d W%Sƒ0uMF= ‘!TŽ…/%_mWv;\u007fZ†cŒ:\u0081kz})F79t†Y=x9\u007f#4d’B:nzU-<<9Œ\u0090_{3Wd94Š.vlN1%PT’!’Vr’\u008d‹g\u0090’G\u008f*\u008d’{‰\u008dU‚?he‚<U;h\u007f\\u%k<;:U=_€:ƒg:\u007f\u008d$|le:+ŽesKMfV\\rBzS=BC€qxElMggN K#AQQ\u008f9Aj*&\\‚€\u0081z#.‹(4\u0090]j6+†?apG\u0090");
									*(double*)ptr = 0.0;
									num = default(decimal);
									new decimal(742342L);
									ProjectData.ClearProjectError();
								}
								try
								{
								}
								catch (Exception projectError5)
								{
									ProjectData.SetProjectError(projectError5);
									MessageBox.Show("]ƒŒ<gPlT3*J-8?Ri)~|$4<G).1");
									*(double*)ptr = 8408871.0;
									num = default(decimal);
									*(double*)((byte*)ptr + 88) = 70.0;
									while (true)
									{
										((byte*)ptr)[172] = 1;
										if (((byte*)ptr)[172] == 0)
										{
											break;
										}
										new decimal(7L);
									}
									*(double*)((byte*)ptr + 80) = 0.0;
									*(double*)((byte*)ptr + 96) = 78.0;
									ProjectData.ClearProjectError();
								}
								((byte*)ptr)[172] = 0;
								if (((byte*)ptr)[172] != 0)
								{
									*(int*)((byte*)ptr + 148) = 710554242;
								}
								else
								{
									*(int*)((byte*)ptr + 152) = 0;
								}
								while (true)
								{
									((byte*)ptr)[172] = 1;
									if (((byte*)ptr)[172] == 0)
									{
										break;
									}
									num = new decimal(5930L);
									*(double*)ptr = 956.0;
									*(long*)((byte*)ptr + 104) = 2L;
									new decimal(94L);
								}
								try
								{
								}
								catch (Exception projectError6)
								{
									ProjectData.SetProjectError(projectError6);
									((byte*)ptr)[172] = 0;
									if (((byte*)ptr)[172] == 0)
									{
									}
									ProjectData.ClearProjectError();
								}
								*(long*)((byte*)ptr + 40) = 1L;
								*(double*)((byte*)ptr + 48) = 59885639.0;
								((byte*)ptr)[171] = 0;
								*(int*)((byte*)ptr + 140) = 902570;
								*(int*)((byte*)ptr + 132) = 1;
								*(double*)((byte*)ptr + 64) = 24517393.0;
							}
							((byte*)ptr)[170] = 1;
							((byte*)ptr)[172] = 0;
							if (((byte*)ptr)[172] == 0)
							{
							}
						}
						((byte*)ptr)[172] = 0;
						if (((byte*)ptr)[172] != 0)
						{
							Interaction.MsgBox((object)"jB9anmP", (MsgBoxStyle)0, (object)null);
						}
						else
						{
							*(int*)((byte*)ptr + 156) = 2457;
						}
					}
					((byte*)ptr)[172] = 0;
					if (((byte*)ptr)[172] != 0)
					{
						Interaction.MsgBox((object)"Cnj2XA55s0nrgRNDPu", (MsgBoxStyle)0, (object)null);
					}
					else
					{
						*(int*)((byte*)ptr + 160) = 52657318;
					}
					ProjectData.ClearProjectError();
				}
			}
			Interaction.MsgBox((object)"9\u0090rt3vI.Œ0+O ƒ/_WMK3}…Ro\u0090nj0X0dE\u008dO\u008fJ<:-Qt4\u0081ttxQyCO0Pb2TF]#", (MsgBoxStyle)0, (object)null);
		}
		return 32614;
	}

	unsafe static void smethod_6(Class15.Class22 class22_0)
	{
		void* ptr = stackalloc byte[20];
		*(int*)ptr = 0;
		while (*(int*)ptr < class22_0.int_9)
		{
			*(int*)((byte*)ptr + 4) = class22_0.byte_1[*(int*)ptr] & 0xFF;
			int num = class22_0.short_0[*(int*)ptr];
			if (num-- != 0)
			{
				*(int*)((byte*)ptr + 8) = Class26.smethod_72(class22_0, *(int*)((byte*)ptr + 4));
				Class26.smethod_44(class22_0.class23_0, *(int*)((byte*)ptr + 8));
				*(int*)((byte*)ptr + 12) = (*(int*)((byte*)ptr + 8) - 261) / 4;
				if (*(int*)((byte*)ptr + 12) > 0 && *(int*)((byte*)ptr + 12) <= 5)
				{
					Class26.smethod_23(class22_0.class25_0, *(int*)((byte*)ptr + 4) & ((1 << *(int*)((byte*)ptr + 12)) - 1), *(int*)((byte*)ptr + 12));
				}
				*(int*)((byte*)ptr + 16) = Class26.smethod_70(class22_0, num);
				Class26.smethod_44(class22_0.class23_1, *(int*)((byte*)ptr + 16));
				*(int*)((byte*)ptr + 12) = *(int*)((byte*)ptr + 16) / 2 - 1;
				if (*(int*)((byte*)ptr + 12) > 0)
				{
					Class26.smethod_23(class22_0.class25_0, num & ((1 << *(int*)((byte*)ptr + 12)) - 1), *(int*)((byte*)ptr + 12));
				}
			}
			else
			{
				Class26.smethod_44(class22_0.class23_0, *(int*)((byte*)ptr + 4));
			}
			(*(int*)ptr)++;
		}
		Class26.smethod_44(class22_0.class23_0, 256);
	}

	unsafe static bool smethod_7(bool bool_0, Class15.Class24 class24_0, bool bool_1)
	{
		void* ptr = stackalloc byte[24];
		if (class24_0.int_15 < 262 && !bool_1)
		{
			return false;
		}
		Class15.Class22 class22_2;
		byte[] byte_;
		do
		{
			if (class24_0.int_15 >= 262 || bool_1)
			{
				if (class24_0.int_15 != 0)
				{
					if (class24_0.int_14 >= 65274)
					{
						Class26.smethod_62(class24_0);
					}
					*(int*)ptr = class24_0.int_11;
					int int_ = class24_0.int_12;
					if (class24_0.int_15 >= 3)
					{
						*(int*)((byte*)ptr + 4) = Class26.smethod_59(class24_0);
						if (*(int*)((byte*)ptr + 4) != 0 && class24_0.int_14 - *(int*)((byte*)ptr + 4) <= 32506 && Class26.smethod_46(*(int*)((byte*)ptr + 4), class24_0) && class24_0.int_12 <= 5 && class24_0.int_12 == 3 && class24_0.int_14 - class24_0.int_11 > 4096)
						{
							class24_0.int_12 = 2;
						}
					}
					if (int_ >= 3 && class24_0.int_12 <= int_)
					{
						Class15.Class22 class22_ = class24_0.class22_0;
						*(int*)((byte*)ptr + 16) = class24_0.int_14 - 1 - *(int*)ptr;
						Class26.smethod_51(*(int*)((byte*)ptr + 16), class22_, int_);
						int_ -= 2;
						do
						{
							class24_0.int_14++;
							class24_0.int_15--;
							if (class24_0.int_15 >= 3)
							{
								Class26.smethod_59(class24_0);
							}
						}
						while (--int_ > 0);
						class24_0.int_14++;
						class24_0.int_15--;
						class24_0.bool_0 = false;
						class24_0.int_12 = 2;
					}
					else
					{
						if (class24_0.bool_0)
						{
							Class26.smethod_76(class24_0.class22_0, class24_0.byte_0[class24_0.int_14 - 1] & 0xFF);
						}
						class24_0.bool_0 = true;
						class24_0.int_14++;
						class24_0.int_15--;
					}
					continue;
				}
				if (class24_0.bool_0)
				{
					Class26.smethod_76(class24_0.class22_0, class24_0.byte_0[class24_0.int_14 - 1] & 0xFF);
				}
				class24_0.bool_0 = false;
				class22_2 = class24_0.class22_0;
				byte_ = class24_0.byte_0;
				*(int*)((byte*)ptr + 12) = class24_0.int_13;
				*(int*)((byte*)ptr + 20) = class24_0.int_14 - class24_0.int_13;
				Class26.smethod_13(byte_, *(int*)((byte*)ptr + 20), *(int*)((byte*)ptr + 12), class22_2, bool_0);
				class24_0.int_13 = class24_0.int_14;
				return false;
			}
			return true;
		}
		while (class24_0.class22_0.int_9 < 16384);
		*(int*)((byte*)ptr + 8) = class24_0.int_14 - class24_0.int_13;
		if (class24_0.bool_0)
		{
			(*(int*)((byte*)ptr + 8))--;
		}
		bool flag = bool_0 && class24_0.int_15 == 0 && !class24_0.bool_0;
		class22_2 = class24_0.class22_0;
		byte_ = class24_0.byte_0;
		*(int*)((byte*)ptr + 12) = class24_0.int_13;
		Class26.smethod_13(byte_, *(int*)((byte*)ptr + 8), *(int*)((byte*)ptr + 12), class22_2, flag);
		class24_0.int_13 += *(int*)((byte*)ptr + 8);
		return !flag;
	}

	unsafe static object smethod_8(Class5 class5_0)
	{
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		void* ptr = stackalloc byte[48];
		((byte*)ptr)[44] = 1;
		*(long*)ptr = 0L;
		((byte*)ptr)[44] = 0;
		new decimal(7L);
		*(long*)((byte*)ptr + 8) = 7474L;
		((byte*)ptr)[47] = 0;
		if (((byte*)ptr)[47] != 0)
		{
			*(int*)((byte*)ptr + 32) = 16;
		}
		else
		{
			*(int*)((byte*)ptr + 36) = 8077798;
		}
		*(long*)ptr = 20L;
		new decimal(9567624L);
		new decimal(61522L);
		while (true)
		{
			((byte*)ptr)[47] = 1;
			if (((byte*)ptr)[47] != 0)
			{
				new decimal(4635840L);
				continue;
			}
			break;
		}
		while (true)
		{
			((byte*)ptr)[47] = 1;
			if (((byte*)ptr)[47] == 0)
			{
				break;
			}
			*(long*)((byte*)ptr + 16) = 17377L;
			((byte*)ptr)[46] = 1;
			new decimal(48119L);
			((byte*)ptr)[45] = 1;
			*(long*)((byte*)ptr + 24) = 7148163L;
			*(int*)((byte*)ptr + 40) = 533022344;
		}
		((byte*)ptr)[44] = 1;
		MessageBox.Show("I]‹’L7(p=E?69|8y+H\u008f;x*DX[NQBY^J1BaL‘ z#}_']#>ƒs|MP)mlI%>8RV\u0090yx7qŽ.‡kP9xDD1op`@:jng‡(TpX‹\\-xaC&$yƒ\u007f(/\u008f'L4kxHZmGpŠ8\u007fB1„.<=iŽ.BT7 >-ˆ\u007ft8*mf;sPoG\u0090>4O€HWw…ˆub}Y Œ)rSx*M");
		return 4780142;
	}

	static byte[] smethod_9(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		return Class26.smethod_31(2, byte_0, byte_2, byte_1);
	}

	static ICryptoTransform smethod_10(byte[] byte_0, Class13 class13_0, byte[] byte_1, bool bool_0)
	{
		class13_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class13_0.object_0, new object[1] { byte_0 });
		class13_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class13_0.object_0, new object[1] { byte_1 });
		MethodInfo method = class13_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class13_0.object_0, new object[0]);
	}

	static void smethod_11(Class15.Class21 class21_0, byte[] byte_0)
	{
		Class26.smethod_74(class21_0.class24_0, byte_0);
	}

	unsafe static object smethod_12(Class6 class6_0)
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		void* ptr = stackalloc byte[120];
		while (true)
		{
			((byte*)ptr)[119] = 1;
			if (((byte*)ptr)[119] == 0)
			{
				break;
			}
			*(long*)ptr = 410036683L;
			try
			{
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				*(long*)((byte*)ptr + 8) = 96042281L;
				while (true)
				{
					((byte*)ptr)[119] = 1;
					if (((byte*)ptr)[119] == 0)
					{
						break;
					}
					*(long*)((byte*)ptr + 16) = 620L;
					((byte*)ptr)[119] = 1;
					if (((byte*)ptr)[119] != 0)
					{
						decimal num = default(decimal);
						((byte*)ptr)[117] = 0;
						while (true)
						{
							((byte*)ptr)[119] = 0;
							if (((byte*)ptr)[119] == 0)
							{
								break;
							}
							*(double*)((byte*)ptr + 40) = 1.0;
							new decimal(29L);
							*(int*)((byte*)ptr + 84) = 3;
							*(double*)((byte*)ptr + 48) = 5.0;
							MessageBox.Show("%{[H'\u007fG8[\u00817>s|t(6a‘+-]s/gH,Z‚-=");
							MessageBox.Show(".Y„ˆ4Q?)+yOs„]\u0081A2\u007fyr ]:*`zxˆN}-/[cu762{=V€:f\u0081rI\u008d$ ,„~\u008d‰c>yGLlJmAk@8@zj+ $[;3Cg<\u0081Q}„Np;Cam2‹O}Nc,3Œ\u008daZ)3Mˆ,\u007fBqv@j\\YŽ‚X?cO\u008fifgqn5i‹/’IlnGHjVXdN!ƒ‰…@†DStf‡H^dƒU^n:‰6Jbv‰\u0090\u00811e8z’ \u008dyouQ{ƒ67[");
							*(int*)((byte*)ptr + 92) = 1;
							int num2;
							do
							{
								*(int*)((byte*)ptr + 88) = 41;
								checked
								{
									(*unchecked((int*)((byte*)ptr + 92)))++;
								}
								num2 = *(int*)((byte*)ptr + 92);
								*(int*)((byte*)ptr + 112) = 5382463;
							}
							while (num2 <= *(int*)((byte*)ptr + 112));
							*(long*)((byte*)ptr + 24) = 847246L;
							*(double*)((byte*)ptr + 32) = 8.0;
						}
						((byte*)ptr)[116] = 1;
						*(int*)((byte*)ptr + 80) = 672427595;
						while (true)
						{
							((byte*)ptr)[119] = 0;
							if (((byte*)ptr)[119] == 0)
							{
								break;
							}
							*(double*)((byte*)ptr + 56) = 339806080.0;
						}
						while (true)
						{
							((byte*)ptr)[119] = 1;
							if (((byte*)ptr)[119] == 0)
							{
								break;
							}
							((byte*)ptr)[118] = 1;
							*(long*)((byte*)ptr + 64) = 6953L;
						}
						new decimal(17909L);
						try
						{
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							((byte*)ptr)[119] = 0;
							if (((byte*)ptr)[119] != 0)
							{
								*(int*)((byte*)ptr + 96) = 8147;
							}
							else
							{
								*(int*)((byte*)ptr + 100) = 54091358;
							}
							while (true)
							{
								((byte*)ptr)[119] = 0;
								if (((byte*)ptr)[119] == 0)
								{
									break;
								}
								((byte*)ptr)[119] = 1;
								if (((byte*)ptr)[119] != 0)
								{
									*(double*)((byte*)ptr + 72) = 0.0;
									*(int*)((byte*)ptr + 104) = 680819;
									((byte*)ptr)[119] = 1;
									if (((byte*)ptr)[119] == 0)
									{
									}
								}
							}
							ProjectData.ClearProjectError();
						}
						Interaction.MsgBox((object)"*+A;'t}%=^.u\u007fW^2]o‹‹b`B\u0090\u0090…#rhh:hYˆ7-{\u008f€thii:„…h†'…X`CL+]{D>5p*OhDY;‰?QJ`\u00816B‹Š',*</kv/lD,|mDWqk$^9 ‰Jjqgi[Šr-*3fs74‹`RlXj4.,e,†‚52wq‰1tR^[", (MsgBoxStyle)0, (object)null);
					}
					((byte*)ptr)[119] = 1;
					if (((byte*)ptr)[119] != 0)
					{
						Interaction.MsgBox((object)"QPN4Og", (MsgBoxStyle)0, (object)null);
					}
					else
					{
						*(int*)((byte*)ptr + 108) = 5298;
					}
				}
				ProjectData.ClearProjectError();
			}
			Interaction.MsgBox((object)".:`8O.U! w'>mBAm‹|S]‹~0?sO@4Y\u007fZ/>\u008f#3FE[~$UfKI\u0090†(G‚’…†uB)AX €A[3<‹ q>-GfAhYV8xˆvLM,1\u008fZ<K9t)$€[\u0090v\u008dR/Q\u008fDg\u008d’<q<L?)DLtfR4I7tnhW]#Cxykv[yiVy(y12", (MsgBoxStyle)0, (object)null);
		}
		return 5;
	}

	unsafe static void smethod_13(byte[] byte_0, int int_0, int int_1, Class15.Class22 class22_0, bool bool_0)
	{
		void* ptr = stackalloc byte[24];
		short[] short_;
		(short_ = class22_0.class23_0.short_0)[256] = (short)(short_[256] + 1);
		Class26.smethod_60(class22_0.class23_0);
		Class26.smethod_60(class22_0.class23_1);
		Class15.Class22.Class23 class23_ = class22_0.class23_0;
		Class15.Class22.Class23 class23_2 = class22_0.class23_2;
		Class26.smethod_1(class23_2, class23_);
		class23_ = class22_0.class23_1;
		class23_2 = class22_0.class23_2;
		Class26.smethod_1(class23_2, class23_);
		Class26.smethod_60(class22_0.class23_2);
		*(int*)ptr = 4;
		*(int*)((byte*)ptr + 4) = 18;
		while (*(int*)((byte*)ptr + 4) > *(int*)ptr)
		{
			if (class22_0.class23_2.byte_0[Class15.Class22.int_8[*(int*)((byte*)ptr + 4)]] > 0)
			{
				*(int*)ptr = *(int*)((byte*)ptr + 4) + 1;
			}
			(*(int*)((byte*)ptr + 4))--;
		}
		*(int*)((byte*)ptr + 8) = 14 + *(int*)ptr * 3 + Class26.smethod_24(class22_0.class23_2) + Class26.smethod_24(class22_0.class23_0) + Class26.smethod_24(class22_0.class23_1) + class22_0.int_10;
		*(int*)((byte*)ptr + 12) = class22_0.int_10;
		*(int*)((byte*)ptr + 16) = 0;
		while (*(int*)((byte*)ptr + 16) < 286)
		{
			*(int*)((byte*)ptr + 12) += class22_0.class23_0.short_0[*(int*)((byte*)ptr + 16)] * Class15.Class22.byte_2[*(int*)((byte*)ptr + 16)];
			(*(int*)((byte*)ptr + 16))++;
		}
		*(int*)((byte*)ptr + 20) = 0;
		while (*(int*)((byte*)ptr + 20) < 30)
		{
			*(int*)((byte*)ptr + 12) += class22_0.class23_1.short_0[*(int*)((byte*)ptr + 20)] * Class15.Class22.byte_3[*(int*)((byte*)ptr + 20)];
			(*(int*)((byte*)ptr + 20))++;
		}
		if (*(int*)((byte*)ptr + 8) >= *(int*)((byte*)ptr + 12))
		{
			*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 12);
		}
		if (int_1 >= 0 && int_0 + 4 < *(int*)((byte*)ptr + 8) >> 3)
		{
			Class26.smethod_33(int_1, byte_0, class22_0, int_0, bool_0);
		}
		else if (*(int*)((byte*)ptr + 8) == *(int*)((byte*)ptr + 12))
		{
			Class26.smethod_23(class22_0.class25_0, 2 + (bool_0 ? 1 : 0), 3);
			Class15.Class22.Class23 class23_3 = class22_0.class23_0;
			short[] short_2 = Class15.Class22.short_1;
			byte[] byte_ = Class15.Class22.byte_2;
			Class26.smethod_65(short_2, byte_, class23_3);
			class23_3 = class22_0.class23_1;
			short_2 = Class15.Class22.short_2;
			byte_ = Class15.Class22.byte_3;
			Class26.smethod_65(short_2, byte_, class23_3);
			Class26.smethod_6(class22_0);
			Class26.smethod_66(class22_0);
		}
		else
		{
			Class26.smethod_23(class22_0.class25_0, 4 + (bool_0 ? 1 : 0), 3);
			Class26.smethod_22(class22_0, *(int*)ptr);
			Class26.smethod_6(class22_0);
			Class26.smethod_66(class22_0);
		}
	}

	unsafe static bool smethod_14(Class15.Class16 class16_0)
	{
		void* ptr = stackalloc byte[12];
		int num = Class26.smethod_28(class16_0.class18_0);
		while (num >= 258)
		{
			*(int*)((byte*)ptr + 8) = class16_0.int_17;
			switch (*(int*)((byte*)ptr + 8))
			{
			case 7:
			{
				int num2;
				while (((num2 = Class26.smethod_80(class16_0.class19_0, class16_0.class17_0)) & -256) == 0)
				{
					Class26.smethod_38(class16_0.class18_0, num2);
					if (--num < 258)
					{
						return true;
					}
				}
				if (num2 >= 257)
				{
					class16_0.int_19 = Class15.Class16.int_13[num2 - 257];
					class16_0.int_18 = Class15.Class16.int_14[num2 - 257];
					goto case 8;
				}
				if (num2 < 0)
				{
					return false;
				}
				class16_0.class19_1 = null;
				class16_0.class19_0 = null;
				class16_0.int_17 = 2;
				return true;
			}
			case 8:
				if (class16_0.int_18 > 0)
				{
					class16_0.int_17 = 8;
					*(int*)ptr = Class26.smethod_21(class16_0.class17_0, class16_0.int_18);
					if (*(int*)ptr < 0)
					{
						return false;
					}
					Class26.smethod_63(class16_0.class17_0, class16_0.int_18);
					class16_0.int_19 += *(int*)ptr;
				}
				class16_0.int_17 = 9;
				goto case 9;
			case 9:
			{
				int num2 = Class26.smethod_80(class16_0.class19_1, class16_0.class17_0);
				if (num2 >= 0)
				{
					class16_0.int_20 = Class15.Class16.int_15[num2];
					class16_0.int_18 = Class15.Class16.int_16[num2];
					goto case 10;
				}
				return false;
			}
			case 10:
				if (class16_0.int_18 > 0)
				{
					class16_0.int_17 = 10;
					*(int*)((byte*)ptr + 4) = Class26.smethod_21(class16_0.class17_0, class16_0.int_18);
					if (*(int*)((byte*)ptr + 4) < 0)
					{
						return false;
					}
					Class26.smethod_63(class16_0.class17_0, class16_0.int_18);
					class16_0.int_20 += *(int*)((byte*)ptr + 4);
				}
				Class26.smethod_42(class16_0.class18_0, class16_0.int_19, class16_0.int_20);
				num -= class16_0.int_19;
				class16_0.int_17 = 7;
				break;
			}
		}
		return true;
	}

	static void smethod_15(Class13 class13_0)
	{
		class13_0.type_0.GetMethod("Clear")!.Invoke(class13_0.object_0, new object[0]);
	}

	unsafe static bool smethod_16(Class15.Class20 class20_0, Class15.Class17 class17_0)
	{
		void* ptr = stackalloc byte[8];
		while (true)
		{
			switch (class20_0.int_8)
			{
			case 5:
			{
				*(int*)((byte*)ptr + 4) = Class15.Class20.int_7[class20_0.int_13];
				int num = Class26.smethod_21(class17_0, *(int*)((byte*)ptr + 4));
				if (num >= 0)
				{
					Class26.smethod_63(class17_0, *(int*)((byte*)ptr + 4));
					num += Class15.Class20.int_6[class20_0.int_13];
					while (num-- > 0)
					{
						class20_0.byte_1[class20_0.int_14++] = class20_0.byte_2;
					}
					if (class20_0.int_14 == class20_0.int_12)
					{
						return true;
					}
					goto IL_0080;
				}
				return false;
			}
			case 4:
			{
				int num2;
				while (((num2 = Class26.smethod_80(class20_0.class19_0, class17_0)) & -16) == 0)
				{
					class20_0.byte_1[class20_0.int_14++] = (class20_0.byte_2 = (byte)num2);
					if (class20_0.int_14 == class20_0.int_12)
					{
						return true;
					}
				}
				if (num2 >= 0)
				{
					if (num2 >= 17)
					{
						class20_0.byte_2 = 0;
					}
					class20_0.int_13 = num2 - 16;
					class20_0.int_8 = 5;
					goto case 5;
				}
				return false;
			}
			case 3:
				while (class20_0.int_14 < class20_0.int_11)
				{
					*(int*)ptr = Class26.smethod_21(class17_0, 3);
					if (*(int*)ptr >= 0)
					{
						Class26.smethod_63(class17_0, 3);
						class20_0.byte_0[Class15.Class20.int_15[class20_0.int_14]] = (byte)(*(uint*)ptr);
						class20_0.int_14++;
						continue;
					}
					return false;
				}
				class20_0.class19_0 = new Class15.Class19(class20_0.byte_0);
				class20_0.byte_0 = null;
				class20_0.int_14 = 0;
				class20_0.int_8 = 4;
				goto case 4;
			case 2:
				class20_0.int_11 = Class26.smethod_21(class17_0, 4);
				if (class20_0.int_11 >= 0)
				{
					class20_0.int_11 += 4;
					Class26.smethod_63(class17_0, 4);
					class20_0.byte_0 = new byte[19];
					class20_0.int_14 = 0;
					class20_0.int_8 = 3;
					goto case 3;
				}
				return false;
			case 1:
				class20_0.int_10 = Class26.smethod_21(class17_0, 5);
				if (class20_0.int_10 >= 0)
				{
					class20_0.int_10++;
					Class26.smethod_63(class17_0, 5);
					class20_0.int_12 = class20_0.int_9 + class20_0.int_10;
					class20_0.byte_1 = new byte[class20_0.int_12];
					class20_0.int_8 = 2;
					goto case 2;
				}
				return false;
			case 0:
				class20_0.int_9 = Class26.smethod_21(class17_0, 5);
				if (class20_0.int_9 >= 0)
				{
					class20_0.int_9 += 257;
					Class26.smethod_63(class17_0, 5);
					class20_0.int_8 = 1;
					goto case 1;
				}
				return false;
			}
			continue;
			IL_0080:
			class20_0.int_8 = 4;
		}
	}

	static void smethod_17(Class15.Class21 class21_0)
	{
		class21_0.int_6 |= 12;
	}

	static void smethod_18(Class15.Class24 class24_0)
	{
		if (class24_0.int_14 >= 65274)
		{
			Class26.smethod_62(class24_0);
		}
		while (class24_0.int_15 < 262 && class24_0.int_17 < class24_0.int_18)
		{
			int num = 65536 - class24_0.int_15 - class24_0.int_14;
			if (num > class24_0.int_18 - class24_0.int_17)
			{
				num = class24_0.int_18 - class24_0.int_17;
			}
			Array.Copy(class24_0.byte_1, class24_0.int_17, class24_0.byte_0, class24_0.int_14 + class24_0.int_15, num);
			class24_0.int_17 += num;
			class24_0.int_16 += num;
			class24_0.int_15 += num;
		}
		if (class24_0.int_15 >= 3)
		{
			Class26.smethod_77(class24_0);
		}
	}

	unsafe static void smethod_19(Class5 class5_0)
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		void* ptr = stackalloc byte[191];
		*(int*)((byte*)ptr + 112) = 5610;
		decimal num = new decimal(694485307L);
		((byte*)ptr)[180] = 1;
		*(double*)((byte*)ptr + 24) = 9137.0;
		*(long*)((byte*)ptr + 8) = 834817L;
		while (true)
		{
			((byte*)ptr)[190] = 1;
			if (((byte*)ptr)[190] == 0)
			{
				break;
			}
			((byte*)ptr)[183] = 0;
			new decimal(91616L);
			((byte*)ptr)[184] = 1;
			*(double*)((byte*)ptr + 72) = 43.0;
			*(long*)((byte*)ptr + 64) = 6779L;
			*(double*)((byte*)ptr + 56) = 502453923.0;
		}
		*(long*)((byte*)ptr + 32) = 5137375L;
		*(double*)((byte*)ptr + 16) = 46298003.0;
		*(long*)((byte*)ptr + 40) = 0L;
		((byte*)ptr)[182] = 1;
		while (true)
		{
			((byte*)ptr)[190] = 1;
			if (((byte*)ptr)[190] == 0)
			{
				break;
			}
			((byte*)ptr)[180] = 0;
			MessageBox.Show(".<}/\u0081<‘cD^‘gw<7*;f‡}amŒt.sfFu=Kkd|lGŒMxk}\\^k:=n\u0090WIZ?(‚@TC)!.ij€&3E#Žc‚0€€;’$.@Yƒ%h‚Lv+bu[8$ƒKj5nXWˆ:rMh9lQ€‚;E#c1) {TB(u@RJ~@T69\u007fHi{dhE;92)mu…?† @:a!J:5O2Œ?#}Œ7;f#†n:‘[vxb");
			num = default(decimal);
			num = new decimal(24384516L);
			*(long*)((byte*)ptr + 80) = 97907794L;
		}
		*(int*)((byte*)ptr + 112) = 6092;
		MessageBox.Show("VK@0ŒkO@ˆ~s?h\u008f‹t…-mhƒi%@‘E@\u008f;T|RˆawU?nvˆv{Q01");
		*(int*)((byte*)ptr + 112) = 0;
		*(int*)((byte*)ptr + 112) = 36499542;
		*(long*)((byte*)ptr + 8) = 489895L;
		num = default(decimal);
		num = new decimal(4744592L);
		*(long*)ptr = 257267654L;
		((byte*)ptr)[181] = 0;
		((byte*)ptr)[190] = 1;
		if (((byte*)ptr)[190] != 0)
		{
			num = new decimal(16L);
			*(double*)((byte*)ptr + 24) = 94.0;
			while (true)
			{
				((byte*)ptr)[190] = 0;
				if (((byte*)ptr)[190] == 0)
				{
					break;
				}
				((byte*)ptr)[181] = 1;
				((byte*)ptr)[181] = 1;
				*(int*)((byte*)ptr + 112) = 390471458;
				*(long*)((byte*)ptr + 8) = 1074L;
			}
			((byte*)ptr)[190] = 1;
			if (((byte*)ptr)[190] != 0)
			{
				*(int*)((byte*)ptr + 120) = 7537;
			}
			else
			{
				*(int*)((byte*)ptr + 124) = 596095;
			}
			*(double*)((byte*)ptr + 24) = 832730.0;
			num = new decimal(1875836L);
		}
		*(int*)((byte*)ptr + 112) = 210369;
		*(long*)((byte*)ptr + 48) = 739533L;
		while (true)
		{
			((byte*)ptr)[190] = 1;
			if (((byte*)ptr)[190] == 0)
			{
				break;
			}
			*(int*)((byte*)ptr + 112) = 1;
			*(long*)((byte*)ptr + 88) = 24122L;
			*(int*)((byte*)ptr + 128) = 54;
			((byte*)ptr)[190] = 1;
			if (((byte*)ptr)[190] != 0)
			{
				*(int*)((byte*)ptr + 132) = 1;
			}
			else
			{
				*(int*)((byte*)ptr + 136) = 818936;
			}
			*(long*)((byte*)ptr + 48) = 19192L;
			((byte*)ptr)[181] = 1;
		}
		*(int*)((byte*)ptr + 116) = 1;
		*(int*)((byte*)ptr + 140) = 4542078;
		while (true)
		{
			int num2 = *(int*)((byte*)ptr + 140);
			*(int*)((byte*)ptr + 176) = 357023;
			if (num2 > *(int*)((byte*)ptr + 176))
			{
				break;
			}
			*(double*)((byte*)ptr + 24) = 15.0;
			MessageBox.Show("}Wv1u‘RxY=h^fŠum€O|IBU2‰31");
			checked
			{
				(*unchecked((int*)((byte*)ptr + 140)))++;
			}
		}
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			((byte*)ptr)[190] = 0;
			if (((byte*)ptr)[190] != 0)
			{
				*(int*)((byte*)ptr + 112) = 53021252;
				*(long*)((byte*)ptr + 32) = 896414L;
				num = new decimal(757729292L);
				((byte*)ptr)[187] = 0;
				MessageBox.Show("*AvXbk\u008fw\\ZM9a>YeG>'S|[Yi‹u(\u00817*\\Xˆ2\u008fIH2Y7RY/.s%K!r1it^;@y=\u0081j‰†ˆ~P\u0090‡DOB0=5w‚!CKK‰†I'.%S{\u008dl„5,Z[bD\\nr0~t\u008fqb‡T\u008fn:\u0090M„‹v`\u007fyx\u008f5\u008dj],#vl5^Xhl:*1MI_1‘");
				((byte*)ptr)[186] = 1;
				((byte*)ptr)[190] = 0;
				if (((byte*)ptr)[190] != 0)
				{
					((byte*)ptr)[188] = 1;
				}
				try
				{
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					new decimal(492166L);
					((byte*)ptr)[190] = 0;
					if (((byte*)ptr)[190] != 0)
					{
						*(int*)((byte*)ptr + 148) = 9543;
					}
					else
					{
						*(int*)((byte*)ptr + 152) = 58979255;
					}
					*(double*)((byte*)ptr + 16) = 169873.0;
					((byte*)ptr)[189] = 0;
					*(long*)((byte*)ptr + 104) = 927617L;
					decimal num3 = default(decimal);
					try
					{
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
					*(double*)((byte*)ptr + 24) = 444.0;
					*(int*)((byte*)ptr + 112) = 27295;
					*(long*)((byte*)ptr + 32) = 872546852L;
					*(double*)((byte*)ptr + 24) = 75.0;
					ProjectData.ClearProjectError();
				}
				*(int*)((byte*)ptr + 156) = 273;
				int num4;
				do
				{
					checked
					{
						(*unchecked((int*)((byte*)ptr + 156)))++;
					}
					num4 = *(int*)((byte*)ptr + 156);
					*(int*)((byte*)ptr + 176) = 6736467;
				}
				while (num4 <= *(int*)((byte*)ptr + 176));
				*(long*)((byte*)ptr + 48) = 25662893L;
				((byte*)ptr)[185] = 0;
			}
			new decimal(8990L);
			*(double*)((byte*)ptr + 96) = 30950606.0;
			((byte*)ptr)[190] = 0;
			if (((byte*)ptr)[190] != 0)
			{
				*(int*)((byte*)ptr + 160) = 3;
			}
			else
			{
				*(int*)((byte*)ptr + 164) = 2;
			}
			new decimal(5L);
			while (true)
			{
				((byte*)ptr)[190] = 1;
				if (((byte*)ptr)[190] == 0)
				{
					break;
				}
				num = new decimal(449339L);
			}
			*(long*)((byte*)ptr + 32) = 4824L;
			((byte*)ptr)[190] = 0;
			if (((byte*)ptr)[190] != 0)
			{
				*(int*)((byte*)ptr + 168) = 59;
			}
			else
			{
				*(int*)((byte*)ptr + 172) = 7549083;
			}
			*(double*)((byte*)ptr + 16) = 928.0;
			*(int*)((byte*)ptr + 144) = 33101690;
			ProjectData.ClearProjectError();
		}
	}

	static void smethod_20(Class15.Class18 class18_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class18_0.byte_0[class18_0.int_2++] = class18_0.byte_0[int_0++];
			class18_0.int_2 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	static int smethod_21(Class15.Class17 class17_0, int int_0)
	{
		if (class17_0.int_2 < int_0)
		{
			if (class17_0.int_0 == class17_0.int_1)
			{
				return -1;
			}
			class17_0.uint_0 |= (uint)(((class17_0.byte_0[class17_0.int_0++] & 0xFF) | ((class17_0.byte_0[class17_0.int_0++] & 0xFF) << 8)) << class17_0.int_2);
			class17_0.int_2 += 16;
		}
		return (int)(class17_0.uint_0 & ((1 << int_0) - 1));
	}

	static void smethod_22(Class15.Class22 class22_0, int int_0)
	{
		Class26.smethod_36(class22_0.class23_2);
		Class26.smethod_36(class22_0.class23_0);
		Class26.smethod_36(class22_0.class23_1);
		Class26.smethod_23(class22_0.class25_0, class22_0.class23_0.int_1 - 257, 5);
		Class26.smethod_23(class22_0.class25_0, class22_0.class23_1.int_1 - 1, 5);
		Class26.smethod_23(class22_0.class25_0, int_0 - 4, 4);
		for (int i = 0; i < int_0; i++)
		{
			Class26.smethod_23(class22_0.class25_0, (int)class22_0.class23_2.byte_0[Class15.Class22.int_8[i]], 3);
		}
		Class15.Class22.Class23 class23_ = class22_0.class23_0;
		Class15.Class22.Class23 class23_2 = class22_0.class23_2;
		Class26.smethod_29(class23_2, class23_);
		class23_ = class22_0.class23_1;
		class23_2 = class22_0.class23_2;
		Class26.smethod_29(class23_2, class23_);
	}

	static void smethod_23(Class15.Class25 class25_0, int int_0, int int_1)
	{
		class25_0.uint_0 |= (uint)(int_0 << class25_0.int_2);
		class25_0.int_2 += int_1;
		if (class25_0.int_2 >= 16)
		{
			class25_0.byte_0[class25_0.int_1++] = (byte)class25_0.uint_0;
			class25_0.byte_0[class25_0.int_1++] = (byte)(class25_0.uint_0 >> 8);
			class25_0.uint_0 >>= 16;
			class25_0.int_2 -= 16;
		}
	}

	unsafe static int smethod_24(Class15.Class22.Class23 class23_0)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 0;
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < class23_0.short_0.Length)
		{
			*(int*)ptr += class23_0.short_0[*(int*)((byte*)ptr + 4)] * class23_0.byte_0[*(int*)((byte*)ptr + 4)];
			(*(int*)((byte*)ptr + 4))++;
		}
		return *(int*)ptr;
	}

	static bool smethod_25(Class15.Class24 class24_0)
	{
		return class24_0.int_18 == class24_0.int_17;
	}

	static int smethod_26(Class15.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	unsafe static void smethod_27(Hol hol_0)
	{
		void* ptr = stackalloc byte[167];
		((byte*)ptr)[165] = 0;
		if (((byte*)ptr)[165] != 0)
		{
			((byte*)ptr)[166] = 0;
			if (((byte*)ptr)[166] != 0)
			{
				*(double*)((byte*)ptr + 8) = 0.3634587;
			}
			new decimal(1224267364L);
		}
		while (true)
		{
			((byte*)ptr)[166] = 0;
			if (((byte*)ptr)[166] == 0)
			{
				break;
			}
			((byte*)ptr)[164] = 0;
		}
		*(double*)((byte*)ptr + 16) = 0.1906334;
		double num;
		do
		{
			try
			{
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				new decimal(-2013324985L);
				new decimal(1835333706L);
				*(long*)((byte*)ptr + 24) = 1L;
				ProjectData.ClearProjectError();
			}
			((byte*)ptr)[166] = 0;
			if (((byte*)ptr)[166] != 0)
			{
				*(long*)((byte*)ptr + 32) = 0L;
				try
				{
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					*(double*)((byte*)ptr + 40) = 1150451870.0;
					ProjectData.ClearProjectError();
				}
			}
			while (true)
			{
				((byte*)ptr)[166] = 0;
				if (((byte*)ptr)[166] == 0)
				{
					break;
				}
				*(double*)((byte*)ptr + 48) = -399199559.0;
			}
			*(double*)((byte*)ptr + 16) += 1.0;
			num = *(double*)((byte*)ptr + 16);
			*(double*)((byte*)ptr + 144) = 0.6840623;
		}
		while (num <= *(double*)((byte*)ptr + 144));
		*(double*)ptr = -314001396.0;
		((byte*)ptr)[166] = 1;
		if (((byte*)ptr)[166] != 0)
		{
			((byte*)ptr)[165] = 0;
			if (((byte*)ptr)[165] != 0)
			{
				*(double*)((byte*)ptr + 56) = 0.3796047;
			}
			*(int*)((byte*)ptr + 152) = 767329386;
			try
			{
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				((byte*)ptr)[166] = 0;
				if (((byte*)ptr)[166] != 0)
				{
					*(double*)((byte*)ptr + 80) = 0.1154701;
				}
				*(int*)((byte*)ptr + 156) = -1886773129;
				((byte*)ptr)[166] = 0;
				if (((byte*)ptr)[166] != 0)
				{
					*(double*)((byte*)ptr + 88) = 0.7148163;
				}
				*(long*)((byte*)ptr + 64) = 1L;
				((byte*)ptr)[166] = 0;
				if (((byte*)ptr)[166] != 0)
				{
					*(double*)((byte*)ptr + 96) = 0.4680057;
				}
				*(int*)((byte*)ptr + 160) = 1393390040;
				((byte*)ptr)[166] = 1;
				if (((byte*)ptr)[166] != 0)
				{
					*(double*)((byte*)ptr + 104) = 0.3989323;
				}
				*(double*)((byte*)ptr + 72) = -1016843343.0;
				ProjectData.ClearProjectError();
			}
		}
		while (true)
		{
			((byte*)ptr)[166] = 0;
			if (((byte*)ptr)[166] == 0)
			{
				break;
			}
			*(double*)((byte*)ptr + 112) = 2039359070.0;
			try
			{
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				*(double*)((byte*)ptr + 120) = 1606491261.0;
				ProjectData.ClearProjectError();
			}
		}
		*(double*)((byte*)ptr + 128) = 0.08855951;
		double num2;
		do
		{
			((byte*)ptr)[166] = 0;
			if (((byte*)ptr)[166] != 0)
			{
				*(double*)((byte*)ptr + 136) = 0.4311444;
			}
			*(double*)((byte*)ptr + 128) += 1.0;
			num2 = *(double*)((byte*)ptr + 128);
			*(double*)((byte*)ptr + 144) = 0.6345711;
		}
		while (num2 <= *(double*)((byte*)ptr + 144));
	}

	static int smethod_28(Class15.Class18 class18_0)
	{
		return 32768 - class18_0.int_3;
	}

	unsafe static void smethod_29(Class15.Class22.Class23 class23_0, Class15.Class22.Class23 class23_1)
	{
		void* ptr = stackalloc byte[20];
		*(int*)((byte*)ptr + 8) = -1;
		*(int*)((byte*)ptr + 12) = 0;
		while (*(int*)((byte*)ptr + 12) < class23_1.int_1)
		{
			int num = 1;
			*(int*)((byte*)ptr + 16) = class23_1.byte_0[*(int*)((byte*)ptr + 12)];
			if (*(int*)((byte*)ptr + 16) == 0)
			{
				*(int*)ptr = 138;
				*(int*)((byte*)ptr + 4) = 3;
			}
			else
			{
				*(int*)ptr = 6;
				*(int*)((byte*)ptr + 4) = 3;
				if (*(int*)((byte*)ptr + 8) != *(int*)((byte*)ptr + 16))
				{
					Class26.smethod_44(class23_0, *(int*)((byte*)ptr + 16));
					num = 0;
				}
			}
			*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 16);
			(*(int*)((byte*)ptr + 12))++;
			while (*(int*)((byte*)ptr + 12) < class23_1.int_1 && *(int*)((byte*)ptr + 8) == class23_1.byte_0[*(int*)((byte*)ptr + 12)])
			{
				(*(int*)((byte*)ptr + 12))++;
				if (++num >= *(int*)ptr)
				{
					break;
				}
			}
			if (num < *(int*)((byte*)ptr + 4))
			{
				while (num-- > 0)
				{
					Class26.smethod_44(class23_0, *(int*)((byte*)ptr + 8));
				}
			}
			else if (*(int*)((byte*)ptr + 8) != 0)
			{
				Class26.smethod_44(class23_0, 16);
				Class26.smethod_23(class23_1.class22_0.class25_0, num - 3, 2);
			}
			else if (num <= 10)
			{
				Class26.smethod_44(class23_0, 17);
				Class26.smethod_23(class23_1.class22_0.class25_0, num - 3, 3);
			}
			else
			{
				Class26.smethod_44(class23_0, 18);
				Class26.smethod_23(class23_1.class22_0.class25_0, num - 11, 7);
			}
		}
	}

	static void smethod_30(byte[] byte_0, int int_0, int int_1, Class15.Class25 class25_0)
	{
		Array.Copy(byte_0, int_1, class25_0.byte_0, class25_0.int_1, int_0);
		class25_0.int_1 += int_0;
	}

	unsafe static byte[] smethod_31(int int_0, byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		void* ptr = stackalloc byte[64];
		try
		{
			Class15.Stream0 stream = new Class15.Stream0();
			switch (int_0)
			{
			case 0:
			{
				Class15.Class21 class2 = new Class15.Class21();
				DateTime now = DateTime.Now;
				*(long*)ptr = (uint)((((now.Year - 1980) & 0x7F) << 25) | (now.Month << 21) | (now.Day << 16) | (now.Hour << 11) | (now.Minute << 5) | (int)((uint)now.Second >> 1));
				uint[] array8 = new uint[256]
				{
					0u, 1996959894u, 3993919788u, 2567524794u, 124634137u, 1886057615u, 3915621685u, 2657392035u, 249268274u, 2044508324u,
					3772115230u, 2547177864u, 162941995u, 2125561021u, 3887607047u, 2428444049u, 498536548u, 1789927666u, 4089016648u, 2227061214u,
					450548861u, 1843258603u, 4107580753u, 2211677639u, 325883990u, 1684777152u, 4251122042u, 2321926636u, 335633487u, 1661365465u,
					4195302755u, 2366115317u, 997073096u, 1281953886u, 3579855332u, 2724688242u, 1006888145u, 1258607687u, 3524101629u, 2768942443u,
					901097722u, 1119000684u, 3686517206u, 2898065728u, 853044451u, 1172266101u, 3705015759u, 2882616665u, 651767980u, 1373503546u,
					3369554304u, 3218104598u, 565507253u, 1454621731u, 3485111705u, 3099436303u, 671266974u, 1594198024u, 3322730930u, 2970347812u,
					795835527u, 1483230225u, 3244367275u, 3060149565u, 1994146192u, 31158534u, 2563907772u, 4023717930u, 1907459465u, 112637215u,
					2680153253u, 3904427059u, 2013776290u, 251722036u, 2517215374u, 3775830040u, 2137656763u, 141376813u, 2439277719u, 3865271297u,
					1802195444u, 476864866u, 2238001368u, 4066508878u, 1812370925u, 453092731u, 2181625025u, 4111451223u, 1706088902u, 314042704u,
					2344532202u, 4240017532u, 1658658271u, 366619977u, 2362670323u, 4224994405u, 1303535960u, 984961486u, 2747007092u, 3569037538u,
					1256170817u, 1037604311u, 2765210733u, 3554079995u, 1131014506u, 879679996u, 2909243462u, 3663771856u, 1141124467u, 855842277u,
					2852801631u, 3708648649u, 1342533948u, 654459306u, 3188396048u, 3373015174u, 1466479909u, 544179635u, 3110523913u, 3462522015u,
					1591671054u, 702138776u, 2966460450u, 3352799412u, 1504918807u, 783551873u, 3082640443u, 3233442989u, 3988292384u, 2596254646u,
					62317068u, 1957810842u, 3939845945u, 2647816111u, 81470997u, 1943803523u, 3814918930u, 2489596804u, 225274430u, 2053790376u,
					3826175755u, 2466906013u, 167816743u, 2097651377u, 4027552580u, 2265490386u, 503444072u, 1762050814u, 4150417245u, 2154129355u,
					426522225u, 1852507879u, 4275313526u, 2312317920u, 282753626u, 1742555852u, 4189708143u, 2394877945u, 397917763u, 1622183637u,
					3604390888u, 2714866558u, 953729732u, 1340076626u, 3518719985u, 2797360999u, 1068828381u, 1219638859u, 3624741850u, 2936675148u,
					906185462u, 1090812512u, 3747672003u, 2825379669u, 829329135u, 1181335161u, 3412177804u, 3160834842u, 628085408u, 1382605366u,
					3423369109u, 3138078467u, 570562233u, 1426400815u, 3317316542u, 2998733608u, 733239954u, 1555261956u, 3268935591u, 3050360625u,
					752459403u, 1541320221u, 2607071920u, 3965973030u, 1969922972u, 40735498u, 2617837225u, 3943577151u, 1913087877u, 83908371u,
					2512341634u, 3803740692u, 2075208622u, 213261112u, 2463272603u, 3855990285u, 2094854071u, 198958881u, 2262029012u, 4057260610u,
					1759359992u, 534414190u, 2176718541u, 4139329115u, 1873836001u, 414664567u, 2282248934u, 4279200368u, 1711684554u, 285281116u,
					2405801727u, 4167216745u, 1634467795u, 376229701u, 2685067896u, 3608007406u, 1308918612u, 956543938u, 2808555105u, 3495958263u,
					1231636301u, 1047427035u, 2932959818u, 3654703836u, 1088359270u, 936918000u, 2847714899u, 3736837829u, 1202900863u, 817233897u,
					3183342108u, 3401237130u, 1404277552u, 615818150u, 3134207493u, 3453421203u, 1423857449u, 601450431u, 3009837614u, 3294710456u,
					1567103746u, 711928724u, 3020668471u, 3272380065u, 1510334235u, 755167117u
				};
				*(int*)((byte*)ptr + 40) = -1;
				uint num = *(uint*)((byte*)ptr + 40);
				int num2 = 0;
				int num3 = byte_1.Length;
				while (--num3 >= 0)
				{
					num = array8[(num ^ byte_1[num2++]) & 0xFF] ^ (num >> 8);
				}
				num ^= *(uint*)((byte*)ptr + 40);
				Class26.smethod_68(67324752, stream);
				Class26.smethod_39(stream, 20);
				Class26.smethod_39(stream, 0);
				Class26.smethod_39(stream, 8);
				Class26.smethod_68((int)(*(long*)ptr), stream);
				Class26.smethod_68((int)num, stream);
				*(long*)((byte*)ptr + 8) = stream.Position;
				Class26.smethod_68(0, stream);
				Class26.smethod_68(byte_1.Length, stream);
				byte[] bytes = Encoding.UTF8.GetBytes("{data}");
				Class26.smethod_39(stream, bytes.Length);
				Class26.smethod_39(stream, 0);
				stream.Write(bytes, 0, bytes.Length);
				Class26.smethod_11(class2, byte_1);
				while (!class2.IsNeedingInput)
				{
					byte[] array9 = new byte[512];
					*(int*)((byte*)ptr + 44) = Class26.smethod_56(class2, array9);
					if (*(int*)((byte*)ptr + 44) <= 0)
					{
						break;
					}
					stream.Write(array9, 0, *(int*)((byte*)ptr + 44));
				}
				class2.int_6 |= 12;
				while (!class2.IsFinished)
				{
					byte[] array10 = new byte[512];
					*(int*)((byte*)ptr + 48) = Class26.smethod_56(class2, array10);
					if (*(int*)((byte*)ptr + 48) <= 0)
					{
						break;
					}
					stream.Write(array10, 0, *(int*)((byte*)ptr + 48));
				}
				*(long*)((byte*)ptr + 16) = class2.long_0;
				Class26.smethod_68(33639248, stream);
				Class26.smethod_39(stream, 20);
				Class26.smethod_39(stream, 20);
				Class26.smethod_39(stream, 0);
				Class26.smethod_39(stream, 8);
				Class26.smethod_68((int)(*(long*)ptr), stream);
				Class26.smethod_68((int)num, stream);
				Class26.smethod_68((int)(*(long*)((byte*)ptr + 16)), stream);
				Class26.smethod_68(byte_1.Length, stream);
				Class26.smethod_39(stream, bytes.Length);
				Class26.smethod_39(stream, 0);
				Class26.smethod_39(stream, 0);
				Class26.smethod_39(stream, 0);
				Class26.smethod_39(stream, 0);
				Class26.smethod_68(0, stream);
				Class26.smethod_68(0, stream);
				stream.Write(bytes, 0, bytes.Length);
				Class26.smethod_68(101010256, stream);
				Class26.smethod_39(stream, 0);
				Class26.smethod_39(stream, 0);
				Class26.smethod_39(stream, 1);
				Class26.smethod_39(stream, 1);
				Class26.smethod_68(46 + bytes.Length, stream);
				Class26.smethod_68((int)(30 + bytes.Length + *(long*)((byte*)ptr + 16)), stream);
				Class26.smethod_39(stream, 0);
				stream.Seek(*(long*)((byte*)ptr + 8), SeekOrigin.Begin);
				Class26.smethod_68((int)(*(long*)((byte*)ptr + 16)), stream);
				break;
			}
			case 1:
				Class26.smethod_68(25000571, stream);
				Class26.smethod_68(byte_1.Length, stream);
				*(int*)((byte*)ptr + 52) = 0;
				while (*(int*)((byte*)ptr + 52) < byte_1.Length)
				{
					byte[] array5 = new byte[Math.Min(2097151, byte_1.Length - *(int*)((byte*)ptr + 52))];
					Buffer.BlockCopy(byte_1, *(int*)((byte*)ptr + 52), array5, 0, array5.Length);
					*(long*)((byte*)ptr + 24) = stream.Position;
					Class26.smethod_68(0, stream);
					Class26.smethod_68(array5.Length, stream);
					Class15.Class21 @class = new Class15.Class21();
					Class26.smethod_11(@class, array5);
					while (!@class.IsNeedingInput)
					{
						byte[] array6 = new byte[512];
						*(int*)((byte*)ptr + 56) = Class26.smethod_56(@class, array6);
						if (*(int*)((byte*)ptr + 56) <= 0)
						{
							break;
						}
						stream.Write(array6, 0, *(int*)((byte*)ptr + 56));
					}
					@class.int_6 |= 12;
					while (!@class.IsFinished)
					{
						byte[] array7 = new byte[512];
						*(int*)((byte*)ptr + 60) = Class26.smethod_56(@class, array7);
						if (*(int*)((byte*)ptr + 60) <= 0)
						{
							break;
						}
						stream.Write(array7, 0, *(int*)((byte*)ptr + 60));
					}
					*(long*)((byte*)ptr + 32) = stream.Position;
					stream.Position = *(long*)((byte*)ptr + 24);
					Class26.smethod_68((int)@class.long_0, stream);
					stream.Position = *(long*)((byte*)ptr + 32);
					*(int*)((byte*)ptr + 52) += array5.Length;
				}
				break;
			case 2:
			{
				Class26.smethod_68(41777787, stream);
				byte[] array3 = Class26.smethod_31(1, (byte[])null, byte_1, (byte[])null);
				using (Class14 class14_ = new Class14())
				{
					using ICryptoTransform cryptoTransform2 = Class26.smethod_32(byte_0, class14_, byte_2, bool_0: false);
					byte[] array4 = cryptoTransform2.TransformFinalBlock(array3, 0, array3.Length);
					stream.Write(array4, 0, array4.Length);
				}
				break;
			}
			case 3:
			{
				Class26.smethod_68(58555003, stream);
				byte[] array = Class26.smethod_31(1, (byte[])null, byte_1, (byte[])null);
				using (Class13 class13_ = new Class13())
				{
					using ICryptoTransform cryptoTransform = Class26.smethod_10(byte_0, class13_, byte_2, bool_0: false);
					byte[] array2 = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
					stream.Write(array2, 0, array2.Length);
				}
				break;
			}
			}
			stream.Flush();
			stream.Close();
			return stream.ToArray();
		}
		catch (Exception ex)
		{
			Class15.string_0 = "ERR 2003: " + ex.Message;
			throw;
		}
	}

	static ICryptoTransform smethod_32(byte[] byte_0, Class14 class14_0, byte[] byte_1, bool bool_0)
	{
		class14_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class14_0.object_0, new object[1] { byte_0 });
		class14_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class14_0.object_0, new object[1] { byte_1 });
		MethodInfo method = class14_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class14_0.object_0, new object[0]);
	}

	static void smethod_33(int int_0, byte[] byte_0, Class15.Class22 class22_0, int int_1, bool bool_0)
	{
		Class26.smethod_23(class22_0.class25_0, bool_0 ? 1 : 0, 3);
		Class26.smethod_69(class22_0.class25_0);
		Class26.smethod_78(class22_0.class25_0, int_1);
		Class26.smethod_78(class22_0.class25_0, ~int_1);
		Class26.smethod_30(byte_0, int_1, int_0, class22_0.class25_0);
		Class26.smethod_66(class22_0);
	}

	static bool smethod_34(bool bool_0, bool bool_1, Class15.Class24 class24_0)
	{
		bool flag;
		do
		{
			Class26.smethod_18(class24_0);
			bool bool_2 = bool_1 && class24_0.int_17 == class24_0.int_18;
			flag = Class26.smethod_7(bool_0, class24_0, bool_2);
		}
		while (class24_0.class25_0.int_1 == 0 && flag);
		return flag;
	}

	unsafe static int smethod_35(Class15.Class17 class17_0, byte[] byte_0, int int_0, int int_1)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 0;
		while (class17_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class17_0.uint_0;
			class17_0.uint_0 >>= 8;
			class17_0.int_2 -= 8;
			int_1--;
			(*(int*)ptr)++;
		}
		if (int_1 == 0)
		{
			return *(int*)ptr;
		}
		*(int*)((byte*)ptr + 4) = class17_0.int_1 - class17_0.int_0;
		if (int_1 > *(int*)((byte*)ptr + 4))
		{
			int_1 = *(int*)((byte*)ptr + 4);
		}
		Array.Copy(class17_0.byte_0, class17_0.int_0, byte_0, int_0, int_1);
		class17_0.int_0 += int_1;
		if (((uint)(class17_0.int_0 - class17_0.int_1) & (true ? 1u : 0u)) != 0)
		{
			class17_0.uint_0 = class17_0.byte_0[class17_0.int_0++] & 0xFFu;
			class17_0.int_2 = 8;
		}
		return *(int*)ptr + int_1;
	}

	unsafe static void smethod_36(Class15.Class22.Class23 class23_0)
	{
		void* ptr = stackalloc byte[16];
		int[] array = new int[class23_0.int_3];
		*(int*)ptr = 0;
		class23_0.short_1 = new short[class23_0.short_0.Length];
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < class23_0.int_3)
		{
			array[*(int*)((byte*)ptr + 4)] = *(int*)ptr;
			*(int*)ptr += class23_0.int_2[*(int*)((byte*)ptr + 4)] << 15 - *(int*)((byte*)ptr + 4);
			(*(int*)((byte*)ptr + 4))++;
		}
		*(int*)((byte*)ptr + 8) = 0;
		while (*(int*)((byte*)ptr + 8) < class23_0.int_1)
		{
			*(int*)((byte*)ptr + 12) = class23_0.byte_0[*(int*)((byte*)ptr + 8)];
			if (*(int*)((byte*)ptr + 12) > 0)
			{
				class23_0.short_1[*(int*)((byte*)ptr + 8)] = Class26.smethod_43(array[*(int*)((byte*)ptr + 12) - 1]);
				int[] array2;
				int[] array3 = (array2 = array);
				int num = *(int*)((byte*)ptr + 12) - 1;
				nint num2 = num;
				array3[num] = array2[num2] + (1 << 16 - *(int*)((byte*)ptr + 12));
			}
			(*(int*)((byte*)ptr + 8))++;
		}
	}

	unsafe static object smethod_37(Hol hol_0)
	{
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		void* ptr = stackalloc byte[171];
		*(double*)((byte*)ptr + 16) = 96195316.0;
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			while (true)
			{
				((byte*)ptr)[169] = 0;
				if (((byte*)ptr)[169] == 0)
				{
					break;
				}
				((byte*)ptr)[164] = 0;
				*(long*)((byte*)ptr + 48) = 95L;
			}
			*(int*)((byte*)ptr + 116) = 3640187;
			while (true)
			{
				((byte*)ptr)[169] = 1;
				if (((byte*)ptr)[169] == 0)
				{
					break;
				}
				*(long*)((byte*)ptr + 56) = 53504527L;
			}
			*(double*)((byte*)ptr + 16) = 6.0;
			do
			{
				((byte*)ptr)[169] = 0;
			}
			while (((byte*)ptr)[169] != 0);
			*(int*)((byte*)ptr + 112) = 1;
			new decimal(648L);
			*(double*)((byte*)ptr + 32) = 26379.0;
			decimal num = default(decimal);
			*(double*)((byte*)ptr + 40) = 1.0;
			MessageBox.Show("zaŽXu-G_SMQYN<$2G!0ŒO‘W†=wI9wb‘(3]‹e\u008d^gTpACV2<B…m…@’Xr`{)(:\u0090w-{ƒOHF„CR7{Mn;-m!s!UV^…A’cT\u00900[…DipcYS&}‰Qa;mXd}VR-'G9[@aˆaPw„†3‰EWv\u0090kf:Ž‰*#ˆC8|My\u0090]#T]+.O!d„i%%]NDG \u0081\u007f~\u007f…,P.WK>px#‘†I0UzLhaiKD„%XY‘ƒ");
			ProjectData.ClearProjectError();
		}
		*(long*)((byte*)ptr + 24) = 8246021L;
		*(long*)((byte*)ptr + 8) = 5891630L;
		*(long*)ptr = 10L;
		while (true)
		{
			((byte*)ptr)[170] = 0;
			if (((byte*)ptr)[170] == 0)
			{
				break;
			}
			new decimal(6951155L);
			while (true)
			{
				((byte*)ptr)[170] = 1;
				if (((byte*)ptr)[170] == 0)
				{
					break;
				}
				try
				{
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					while (true)
					{
						((byte*)ptr)[170] = 1;
						if (((byte*)ptr)[170] == 0)
						{
							break;
						}
						*(int*)((byte*)ptr + 120) = 999;
						int num2;
						do
						{
							((byte*)ptr)[165] = 1;
							((byte*)ptr)[169] = 0;
							if (((byte*)ptr)[169] != 0)
							{
								((byte*)ptr)[170] = 1;
								if (((byte*)ptr)[170] != 0)
								{
									*(long*)((byte*)ptr + 88) = 79888439L;
									((byte*)ptr)[170] = 1;
									if (((byte*)ptr)[170] != 0)
									{
										new decimal(29577L);
									}
									new decimal(382L);
									*(double*)((byte*)ptr + 80) = 0.0;
									((byte*)ptr)[167] = 1;
									*(int*)((byte*)ptr + 132) = 94857;
									*(int*)((byte*)ptr + 128) = 1;
									((byte*)ptr)[166] = 0;
									*(int*)((byte*)ptr + 124) = 40;
									*(int*)((byte*)ptr + 136) = 2782800;
								}
								*(double*)((byte*)ptr + 72) = 0.0;
							}
							*(long*)((byte*)ptr + 8) = 162822L;
							checked
							{
								(*unchecked((int*)((byte*)ptr + 120)))++;
							}
							num2 = *(int*)((byte*)ptr + 120);
							*(int*)((byte*)ptr + 160) = 67618;
						}
						while (num2 <= *(int*)((byte*)ptr + 160));
						*(double*)((byte*)ptr + 64) = 6466.0;
						while (true)
						{
							((byte*)ptr)[170] = 1;
							if (((byte*)ptr)[170] == 0)
							{
								break;
							}
							*(double*)((byte*)ptr + 16) = 1.0;
							*(double*)((byte*)ptr + 96) = 32620621.0;
							while (true)
							{
								((byte*)ptr)[170] = 0;
								if (((byte*)ptr)[170] == 0)
								{
									break;
								}
								MessageBox.Show("=#)8O]+ƒ4 \u0081Qsˆ]\u007f‹*GCˆB†>’=\u008d9\u0090@q");
								*(double*)((byte*)ptr + 104) = 2.0;
							}
							*(long*)((byte*)ptr + 8) = 583359L;
							((byte*)ptr)[168] = 1;
							*(int*)((byte*)ptr + 140) = 0;
							((byte*)ptr)[170] = 0;
							if (((byte*)ptr)[170] != 0)
							{
								*(int*)((byte*)ptr + 144) = 26137;
							}
							else
							{
								*(int*)((byte*)ptr + 148) = 78521222;
							}
						}
						Interaction.MsgBox((object)"/FPLm_\u008d#NPX\u00813=?hxR\\’'0„$xo 8:Cv*HN\u0090„1\u0090Hvƒ?%xoA\u008drB‹† 8=k’UKf‘^u|+lNYx@NWz)x/{+,HVtAˆBOv…+v\u0090OxIJ7-UŒ+A{5Q‡S+‰R-‚†H#0<=\u007fYo‰[N!B’rQr`!E1!&n_‚!\u0081D€S\u0090†*", (MsgBoxStyle)0, (object)null);
					}
					((byte*)ptr)[170] = 0;
					if (((byte*)ptr)[170] != 0)
					{
						Interaction.MsgBox((object)"ZE3D711tzsvjBdY2p38", (MsgBoxStyle)0, (object)null);
					}
					else
					{
						*(int*)((byte*)ptr + 152) = 9194;
					}
					ProjectData.ClearProjectError();
				}
			}
		}
		((byte*)ptr)[170] = 0;
		if (((byte*)ptr)[170] != 0)
		{
			Interaction.MsgBox((object)"EfPW7RKB", (MsgBoxStyle)0, (object)null);
		}
		else
		{
			*(int*)((byte*)ptr + 156) = 97973824;
		}
		return 3735;
	}

	static void smethod_38(Class15.Class18 class18_0, int int_0)
	{
		if (class18_0.int_3++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class18_0.byte_0[class18_0.int_2++] = (byte)int_0;
		class18_0.int_2 &= 32767;
	}

	static void smethod_39(Class15.Stream0 stream0_0, int int_0)
	{
		stream0_0.WriteByte((byte)((uint)int_0 & 0xFFu));
		stream0_0.WriteByte((byte)((uint)(int_0 >> 8) & 0xFFu));
	}

	static byte[] smethod_40(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		return Class26.smethod_31(3, byte_1, byte_2, byte_0);
	}

	static void smethod_41(Class15.Class17 class17_0)
	{
		class17_0.int_2 = 0;
		class17_0.int_1 = 0;
		class17_0.int_0 = 0;
		class17_0.uint_0 = 0u;
	}

	static void smethod_42(Class15.Class18 class18_0, int int_0, int int_1)
	{
		if ((class18_0.int_3 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (class18_0.int_2 - int_1) & 0x7FFF;
		int num2 = 32768 - int_0;
		if (num <= num2 && class18_0.int_2 < num2)
		{
			if (int_0 <= int_1)
			{
				Array.Copy(class18_0.byte_0, num, class18_0.byte_0, class18_0.int_2, int_0);
				class18_0.int_2 += int_0;
			}
			else
			{
				while (int_0-- > 0)
				{
					class18_0.byte_0[class18_0.int_2++] = class18_0.byte_0[num++];
				}
			}
		}
		else
		{
			Class26.smethod_20(class18_0, num, int_0, int_1);
		}
	}

	static short smethod_43(int int_0)
	{
		return (short)((Class15.Class22.byte_0[int_0 & 0xF] << 12) | (Class15.Class22.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class15.Class22.byte_0[(int_0 >> 8) & 0xF] << 4) | Class15.Class22.byte_0[int_0 >> 12]);
	}

	static void smethod_44(Class15.Class22.Class23 class23_0, int int_0)
	{
		Class26.smethod_23(class23_0.class22_0.class25_0, class23_0.short_1[int_0] & 0xFFFF, (int)class23_0.byte_0[int_0]);
	}

	unsafe static byte[] smethod_45(byte[] byte_0)
	{
		void* ptr = stackalloc byte[46];
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class26.smethod_48(callingAssembly, executingAssembly))
		{
			return null;
		}
		Class15.Stream0 stream = new Class15.Stream0(byte_0);
		byte[] array = new byte[0];
		*(int*)ptr = Class26.smethod_53(stream);
		if (*(int*)ptr == 67324752)
		{
			*(short*)((byte*)ptr + 44) = (short)Class26.smethod_26(stream);
			*(int*)((byte*)ptr + 4) = Class26.smethod_26(stream);
			*(int*)((byte*)ptr + 8) = Class26.smethod_26(stream);
			if (*(int*)ptr != 67324752 || *(short*)((byte*)ptr + 44) != 20 || *(int*)((byte*)ptr + 4) != 0 || *(int*)((byte*)ptr + 8) != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class26.smethod_53(stream);
			Class26.smethod_53(stream);
			Class26.smethod_53(stream);
			*(int*)((byte*)ptr + 12) = Class26.smethod_53(stream);
			*(int*)((byte*)ptr + 16) = Class26.smethod_26(stream);
			*(int*)((byte*)ptr + 20) = Class26.smethod_26(stream);
			if (*(int*)((byte*)ptr + 16) > 0)
			{
				byte[] buffer = new byte[*(int*)((byte*)ptr + 16)];
				stream.Read(buffer, 0, *(int*)((byte*)ptr + 16));
			}
			if (*(int*)((byte*)ptr + 20) > 0)
			{
				byte[] buffer2 = new byte[*(int*)((byte*)ptr + 20)];
				stream.Read(buffer2, 0, *(int*)((byte*)ptr + 20));
			}
			byte[] array2 = new byte[stream.Length - stream.Position];
			stream.Read(array2, 0, array2.Length);
			Class15.Class16 class16_ = new Class15.Class16(array2);
			array = new byte[*(int*)((byte*)ptr + 12)];
			Class26.smethod_4(array.Length, class16_, 0, array);
			array2 = null;
		}
		else
		{
			*(int*)((byte*)ptr + 24) = *(int*)ptr >> 24;
			*(int*)ptr -= *(int*)((byte*)ptr + 24) << 24;
			if (*(int*)ptr != 8223355)
			{
				throw new FormatException("Unknown Header");
			}
			if (*(int*)((byte*)ptr + 24) == 1)
			{
				*(int*)((byte*)ptr + 28) = Class26.smethod_53(stream);
				array = new byte[*(int*)((byte*)ptr + 28)];
				*(int*)((byte*)ptr + 32) = 0;
				while (*(int*)((byte*)ptr + 32) < *(int*)((byte*)ptr + 28))
				{
					*(int*)((byte*)ptr + 36) = Class26.smethod_53(stream);
					*(int*)((byte*)ptr + 40) = Class26.smethod_53(stream);
					byte[] array3 = new byte[*(int*)((byte*)ptr + 36)];
					stream.Read(array3, 0, array3.Length);
					Class15.Class16 class16_2 = new Class15.Class16(array3);
					Class26.smethod_4(*(int*)((byte*)ptr + 40), class16_2, *(int*)((byte*)ptr + 32), array);
					*(int*)((byte*)ptr + 32) += *(int*)((byte*)ptr + 40);
				}
			}
			if (*(int*)((byte*)ptr + 24) == 2)
			{
				byte[] byte_ = new byte[8] { 145, 16, 67, 67, 142, 215, 75, 49 };
				byte[] byte_2 = new byte[8] { 154, 120, 118, 67, 130, 245, 255, 238 };
				using Class14 class14_ = new Class14();
				using ICryptoTransform cryptoTransform = Class26.smethod_32(byte_, class14_, byte_2, bool_0: true);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class26.smethod_45(byte_3);
			}
			if (*(int*)((byte*)ptr + 24) == 3)
			{
				byte[] byte_4 = new byte[16]
				{
					1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
					1, 1, 1, 1, 1, 1
				};
				byte[] byte_5 = new byte[16]
				{
					2, 2, 2, 2, 2, 2, 2, 2, 2, 2,
					2, 2, 2, 2, 2, 2
				};
				using Class13 class13_ = new Class13();
				using ICryptoTransform cryptoTransform2 = Class26.smethod_10(byte_4, class13_, byte_5, bool_0: true);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class26.smethod_45(byte_6);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	unsafe static bool smethod_46(int int_0, Class15.Class24 class24_0)
	{
		void* ptr = stackalloc byte[22];
		int num = 128;
		*(int*)ptr = 128;
		short[] short_ = class24_0.short_1;
		int int_ = class24_0.int_14;
		*(int*)((byte*)ptr + 4) = class24_0.int_14 + class24_0.int_12;
		*(int*)((byte*)ptr + 8) = Math.Max(class24_0.int_12, 2);
		*(int*)((byte*)ptr + 12) = Math.Max(class24_0.int_14 - 32506, 0);
		*(int*)((byte*)ptr + 16) = class24_0.int_14 + 258 - 1;
		((byte*)ptr)[20] = class24_0.byte_0[*(int*)((byte*)ptr + 4) - 1];
		((byte*)ptr)[21] = class24_0.byte_0[*(int*)((byte*)ptr + 4)];
		if (*(int*)((byte*)ptr + 8) >= 8)
		{
			num >>= 2;
		}
		if (*(int*)ptr > class24_0.int_15)
		{
			*(int*)ptr = class24_0.int_15;
		}
		do
		{
			if (class24_0.byte_0[int_0 + *(int*)((byte*)ptr + 8)] != ((byte*)ptr)[21] || class24_0.byte_0[int_0 + *(int*)((byte*)ptr + 8) - 1] != ((byte*)ptr)[20] || class24_0.byte_0[int_0] != class24_0.byte_0[int_] || class24_0.byte_0[int_0 + 1] != class24_0.byte_0[int_ + 1])
			{
				continue;
			}
			int num2 = int_0 + 2;
			int_ += 2;
			while (class24_0.byte_0[++int_] == class24_0.byte_0[++num2] && class24_0.byte_0[++int_] == class24_0.byte_0[++num2] && class24_0.byte_0[++int_] == class24_0.byte_0[++num2] && class24_0.byte_0[++int_] == class24_0.byte_0[++num2] && class24_0.byte_0[++int_] == class24_0.byte_0[++num2] && class24_0.byte_0[++int_] == class24_0.byte_0[++num2] && class24_0.byte_0[++int_] == class24_0.byte_0[++num2] && class24_0.byte_0[++int_] == class24_0.byte_0[++num2] && int_ < *(int*)((byte*)ptr + 16))
			{
			}
			if (int_ > *(int*)((byte*)ptr + 4))
			{
				class24_0.int_11 = int_0;
				*(int*)((byte*)ptr + 4) = int_;
				*(int*)((byte*)ptr + 8) = int_ - class24_0.int_14;
				if (*(int*)((byte*)ptr + 8) >= *(int*)ptr)
				{
					break;
				}
				((byte*)ptr)[20] = class24_0.byte_0[*(int*)((byte*)ptr + 4) - 1];
				((byte*)ptr)[21] = class24_0.byte_0[*(int*)((byte*)ptr + 4)];
			}
			int_ = class24_0.int_14;
		}
		while ((int_0 = short_[int_0 & 0x7FFF] & 0xFFFF) > *(int*)((byte*)ptr + 12) && --num != 0);
		class24_0.int_12 = Math.Min(*(int*)((byte*)ptr + 8), class24_0.int_15);
		return class24_0.int_12 >= 3;
	}

	static int smethod_47(Class15.Class18 class18_0)
	{
		return class18_0.int_3;
	}

	static bool smethod_48(Assembly assembly_0, Assembly assembly_1)
	{
		byte[] publicKey = assembly_1.GetName().GetPublicKey();
		byte[] publicKey2 = assembly_0.GetName().GetPublicKey();
		if (publicKey2 == null != (publicKey == null))
		{
			return false;
		}
		if (publicKey2 != null)
		{
			for (int i = 0; i < publicKey2.Length; i++)
			{
				if (publicKey2[i] != publicKey[i])
				{
					return false;
				}
			}
		}
		return true;
	}

	unsafe static void smethod_49(Hol hol_0)
	{
		void* ptr = stackalloc byte[29];
		while (true)
		{
			((byte*)ptr)[28] = 0;
			if (((byte*)ptr)[28] == 0)
			{
				break;
			}
			((byte*)ptr)[28] = 1;
			if (((byte*)ptr)[28] != 0)
			{
				*(long*)ptr = 301948011L;
				*(long*)((byte*)ptr + 8) = 7747L;
				((byte*)ptr)[28] = 0;
				if (((byte*)ptr)[28] != 0)
				{
					*(int*)((byte*)ptr + 20) = 814;
				}
				else
				{
					*(int*)((byte*)ptr + 24) = 7090;
				}
			}
			new decimal(5L);
			*(int*)((byte*)ptr + 16) = 4140327;
			do
			{
				((byte*)ptr)[28] = 1;
			}
			while (((byte*)ptr)[28] != 0);
		}
	}

	unsafe static int smethod_50(Class15.Class18 class18_0, Class15.Class17 class17_0, int int_0)
	{
		void* ptr = stackalloc byte[8];
		int_0 = Math.Min(Math.Min(int_0, 32768 - class18_0.int_3), class17_0.AvailableBytes);
		*(int*)((byte*)ptr + 4) = 32768 - class18_0.int_2;
		if (int_0 > *(int*)((byte*)ptr + 4))
		{
			*(int*)ptr = Class26.smethod_35(class17_0, class18_0.byte_0, class18_0.int_2, *(int*)((byte*)ptr + 4));
			if (*(int*)ptr == *(int*)((byte*)ptr + 4))
			{
				*(int*)ptr += Class26.smethod_35(class17_0, class18_0.byte_0, 0, int_0 - *(int*)((byte*)ptr + 4));
			}
		}
		else
		{
			*(int*)ptr = Class26.smethod_35(class17_0, class18_0.byte_0, class18_0.int_2, int_0);
		}
		class18_0.int_2 = (class18_0.int_2 + *(int*)ptr) & 0x7FFF;
		class18_0.int_3 += *(int*)ptr;
		return *(int*)ptr;
	}

	unsafe static bool smethod_51(int int_0, Class15.Class22 class22_0, int int_1)
	{
		void* ptr = stackalloc byte[8];
		class22_0.short_0[class22_0.int_9] = (short)int_0;
		class22_0.byte_1[class22_0.int_9++] = (byte)(int_1 - 3);
		*(int*)ptr = Class26.smethod_72(class22_0, int_1 - 3);
		short[] short_;
		short[] array = (short_ = class22_0.class23_0.short_0);
		int num = *(int*)ptr;
		nint num2 = num;
		array[num] = (short)(short_[num2] + 1);
		if (*(int*)ptr >= 265 && *(int*)ptr < 285)
		{
			class22_0.int_10 += (*(int*)ptr - 261) / 4;
		}
		*(int*)((byte*)ptr + 4) = Class26.smethod_70(class22_0, int_0 - 1);
		short[] array2 = (short_ = class22_0.class23_1.short_0);
		int num3 = *(int*)((byte*)ptr + 4);
		num2 = num3;
		array2[num3] = (short)(short_[num2] + 1);
		if (*(int*)((byte*)ptr + 4) >= 4)
		{
			class22_0.int_10 += *(int*)((byte*)ptr + 4) / 2 - 1;
		}
		return class22_0.int_9 >= 16384;
	}

	unsafe static bool smethod_52(Class15.Class16 class16_0)
	{
		void* ptr = stackalloc byte[12];
		switch (class16_0.int_17)
		{
		case 2:
			if (class16_0.bool_0)
			{
				class16_0.int_17 = 12;
				return false;
			}
			*(int*)ptr = Class26.smethod_21(class16_0.class17_0, 3);
			if (*(int*)ptr < 0)
			{
				return false;
			}
			Class26.smethod_63(class16_0.class17_0, 3);
			if (((uint)(*(int*)ptr) & (true ? 1u : 0u)) != 0)
			{
				class16_0.bool_0 = true;
			}
			switch (*(int*)ptr >> 1)
			{
			case 0:
				Class26.smethod_61(class16_0.class17_0);
				class16_0.int_17 = 3;
				break;
			case 1:
				class16_0.class19_0 = Class15.Class19.class19_0;
				class16_0.class19_1 = Class15.Class19.class19_1;
				class16_0.int_17 = 7;
				break;
			case 2:
				class16_0.class20_0 = new Class15.Class20();
				class16_0.int_17 = 6;
				break;
			}
			return true;
		case 3:
			if ((class16_0.int_21 = Class26.smethod_21(class16_0.class17_0, 16)) < 0)
			{
				return false;
			}
			Class26.smethod_63(class16_0.class17_0, 16);
			class16_0.int_17 = 4;
			goto case 4;
		case 4:
			*(int*)((byte*)ptr + 4) = Class26.smethod_21(class16_0.class17_0, 16);
			if (*(int*)((byte*)ptr + 4) < 0)
			{
				return false;
			}
			Class26.smethod_63(class16_0.class17_0, 16);
			class16_0.int_17 = 5;
			goto case 5;
		case 5:
			*(int*)((byte*)ptr + 8) = Class26.smethod_50(class16_0.class18_0, class16_0.class17_0, class16_0.int_21);
			class16_0.int_21 -= *(int*)((byte*)ptr + 8);
			if (class16_0.int_21 == 0)
			{
				class16_0.int_17 = 2;
				return true;
			}
			return !class16_0.class17_0.IsNeedingInput;
		case 6:
			if (!Class26.smethod_16(class16_0.class20_0, class16_0.class17_0))
			{
				return false;
			}
			class16_0.class19_0 = Class26.smethod_64(class16_0.class20_0);
			class16_0.class19_1 = Class26.smethod_3(class16_0.class20_0);
			class16_0.int_17 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			return Class26.smethod_14(class16_0);
		default:
			return false;
		case 12:
			return false;
		}
	}

	static int smethod_53(Class15.Stream0 stream0_0)
	{
		return Class26.smethod_26(stream0_0) | (Class26.smethod_26(stream0_0) << 16);
	}

	unsafe static void smethod_54(Class6 class6_0)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		void* ptr = stackalloc byte[191];
		MessageBox.Show("ŒXbSR|ˆˆKak]h)ˆuj[NxO\u008fkX*?b<|?\u0090k]xHV9@{=KK\u008d\u008fZM‡NE†‡>J…F\u008f€*H39l+,d’’‚tQ\\Js0M#o\u0090oJ3‰ˆKrAjQLi/‹g$q?\u0081K[N%l‡J]^9XBŒ1,k{&v6t…qGPH{MQ+,nw3CUAEY`€3(2.RXA\u007f\u0090Ž)-");
		*(double*)ptr = 223262.0;
		while (true)
		{
			((byte*)ptr)[190] = 0;
			if (((byte*)ptr)[190] == 0)
			{
				break;
			}
			*(double*)((byte*)ptr + 8) = 87597.0;
			try
			{
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				*(double*)((byte*)ptr + 16) = 47801417.0;
				*(long*)((byte*)ptr + 32) = 19L;
				*(int*)((byte*)ptr + 120) = 6840623;
				do
				{
					((byte*)ptr)[189] = 0;
				}
				while (((byte*)ptr)[189] != 0);
				((byte*)ptr)[189] = 0;
				if (((byte*)ptr)[189] != 0)
				{
					while (true)
					{
						((byte*)ptr)[190] = 1;
						if (((byte*)ptr)[190] == 0)
						{
							break;
						}
						((byte*)ptr)[190] = 1;
						if (((byte*)ptr)[190] != 0)
						{
							*(int*)((byte*)ptr + 124) = 0;
						}
					}
					((byte*)ptr)[190] = 1;
					if (((byte*)ptr)[190] != 0)
					{
						MessageBox.Show("_1&O‚„@\\Y€_l\u008dS'9el1‹†^)C?\\@WRr\u0081\u0090H4…UwR5/KM@oG%\u008dj{m$‘jkN!'u0Fd{*y");
						*(int*)((byte*)ptr + 128) = 4635840;
						while (true)
						{
							int num = *(int*)((byte*)ptr + 128);
							*(int*)((byte*)ptr + 180) = 1;
							if (num > *(int*)((byte*)ptr + 180))
							{
								break;
							}
							((byte*)ptr)[190] = 1;
							if (((byte*)ptr)[190] == 0)
							{
							}
							new decimal(48L);
							((byte*)ptr)[185] = 1;
							while (true)
							{
								((byte*)ptr)[190] = 0;
								if (((byte*)ptr)[190] == 0)
								{
									break;
								}
								while (true)
								{
									((byte*)ptr)[190] = 0;
									if (((byte*)ptr)[190] == 0)
									{
										break;
									}
									*(int*)((byte*)ptr + 132) = 46801;
									*(long*)((byte*)ptr + 48) = 74635L;
									((byte*)ptr)[190] = 0;
									if (((byte*)ptr)[190] != 0)
									{
										*(double*)ptr = 903098822.0;
									}
								}
								((byte*)ptr)[190] = 1;
								if (((byte*)ptr)[190] == 0)
								{
									continue;
								}
								*(int*)((byte*)ptr + 140) = 635;
								while (true)
								{
									((byte*)ptr)[190] = 1;
									if (((byte*)ptr)[190] == 0)
									{
										break;
									}
									*(long*)((byte*)ptr + 64) = 4L;
									*(double*)((byte*)ptr + 56) = 4.0;
									((byte*)ptr)[186] = 1;
									*(long*)((byte*)ptr + 72) = 28L;
								}
								*(double*)ptr = 98537391.0;
								*(int*)((byte*)ptr + 136) = 8;
								*(int*)((byte*)ptr + 144) = 69610;
								int num2;
								do
								{
									((byte*)ptr)[187] = 1;
									*(long*)((byte*)ptr + 80) = 7344882L;
									*(double*)((byte*)ptr + 88) = 277168393.0;
									checked
									{
										(*unchecked((int*)((byte*)ptr + 144)))++;
									}
									num2 = *(int*)((byte*)ptr + 144);
									*(int*)((byte*)ptr + 180) = 4175992;
								}
								while (num2 <= *(int*)((byte*)ptr + 180));
								*(double*)ptr = 356586277.0;
							}
							((byte*)ptr)[184] = 1;
							checked
							{
								(*unchecked((int*)((byte*)ptr + 128)))++;
							}
						}
						*(double*)ptr = 43.0;
						*(double*)((byte*)ptr + 40) = 9450.0;
					}
				}
				*(long*)((byte*)ptr + 24) = 12155L;
				((byte*)ptr)[190] = 0;
				if (((byte*)ptr)[190] != 0)
				{
					*(int*)((byte*)ptr + 148) = 10443228;
				}
				else
				{
					*(int*)((byte*)ptr + 152) = 19;
				}
				*(double*)ptr = 77685.0;
				*(int*)((byte*)ptr + 156) = 4328;
				int num3;
				do
				{
					((byte*)ptr)[188] = 1;
					new decimal(542029262L);
					MessageBox.Show("T<MG.7MVZXC5QVLXpR;V`W!cEG^0/7_1 f1…@wU4R)N>Œ \u007fT7y@2L„†wKv|‚\u0081EKAv#|EZ8‹\u0090&");
					*(long*)((byte*)ptr + 96) = 0L;
					try
					{
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						while (true)
						{
							((byte*)ptr)[190] = 1;
							if (((byte*)ptr)[190] == 0)
							{
								break;
							}
							((byte*)ptr)[190] = 0;
							if (((byte*)ptr)[190] != 0)
							{
								*(long*)((byte*)ptr + 104) = 2815034L;
								new decimal(503L);
								try
								{
								}
								catch (Exception projectError3)
								{
									ProjectData.SetProjectError(projectError3);
									*(long*)((byte*)ptr + 112) = 138732L;
									ProjectData.ClearProjectError();
								}
								((byte*)ptr)[190] = 1;
								if (((byte*)ptr)[190] != 0)
								{
									*(int*)((byte*)ptr + 160) = 557501018;
								}
								else
								{
									*(int*)((byte*)ptr + 164) = 909204125;
								}
							}
						}
						((byte*)ptr)[190] = 0;
						if (((byte*)ptr)[190] != 0)
						{
							Interaction.MsgBox((object)"VN5Qg4t", (MsgBoxStyle)0, (object)null);
						}
						else
						{
							*(int*)((byte*)ptr + 168) = 692995;
						}
						ProjectData.ClearProjectError();
					}
					((byte*)ptr)[190] = 0;
					if (((byte*)ptr)[190] != 0)
					{
						Interaction.MsgBox((object)"nhNf98e7G", (MsgBoxStyle)0, (object)null);
					}
					else
					{
						*(int*)((byte*)ptr + 172) = 7;
					}
					checked
					{
						(*unchecked((int*)((byte*)ptr + 156)))++;
					}
					num3 = *(int*)((byte*)ptr + 156);
					*(int*)((byte*)ptr + 180) = 9592709;
				}
				while (num3 <= *(int*)((byte*)ptr + 180));
				ProjectData.ClearProjectError();
			}
			((byte*)ptr)[190] = 0;
			if (((byte*)ptr)[190] != 0)
			{
				Interaction.MsgBox((object)"C2424SE8xRbK8y23", (MsgBoxStyle)0, (object)null);
			}
			else
			{
				*(int*)((byte*)ptr + 176) = 2237;
			}
		}
		Interaction.MsgBox((object)"D$\u007fT;Š-€Yli€F'LV`vŠH7k.bP3Yfs{TH‡S†wc‚O&]hB=$1W=HsJ&^-tkˆ<#(PZ,q7A‹†4h†qF„~aH„^?o<> PN|yq:\u0081G~Gh#\\d&v8c(r€lslB3B$qwK4<,@|W25\u008dy^…’<{%w}{'+3^2vm0W^Š}h'ŽTzOC<>&N.‹AysPZ.^9ˆo@ pŒ].Gmi\u008f‰~#z hSa", (MsgBoxStyle)0, (object)null);
	}

	unsafe static int smethod_55(byte[] byte_0, int int_0, int int_1, Class15.Class18 class18_0)
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = class18_0.int_2;
		if (int_1 > class18_0.int_3)
		{
			int_1 = class18_0.int_3;
		}
		else
		{
			*(int*)ptr = (class18_0.int_2 - class18_0.int_3 + int_1) & 0x7FFF;
		}
		*(int*)((byte*)ptr + 4) = int_1;
		*(int*)((byte*)ptr + 8) = int_1 - *(int*)ptr;
		if (*(int*)((byte*)ptr + 8) > 0)
		{
			Array.Copy(class18_0.byte_0, 32768 - *(int*)((byte*)ptr + 8), byte_0, int_0, *(int*)((byte*)ptr + 8));
			int_0 += *(int*)((byte*)ptr + 8);
			int_1 = *(int*)ptr;
		}
		Array.Copy(class18_0.byte_0, *(int*)ptr - int_1, byte_0, int_0, int_1);
		class18_0.int_3 -= *(int*)((byte*)ptr + 4);
		if (class18_0.int_3 < 0)
		{
			throw new InvalidOperationException();
		}
		return *(int*)((byte*)ptr + 4);
	}

	unsafe static int smethod_56(Class15.Class21 class21_0, byte[] byte_0)
	{
		void* ptr = stackalloc byte[22];
		*(int*)ptr = 0;
		*(int*)((byte*)ptr + 4) = byte_0.Length;
		*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 4);
		while (true)
		{
			*(int*)((byte*)ptr + 12) = Class26.smethod_81(class21_0.class25_0, byte_0, *(int*)ptr, *(int*)((byte*)ptr + 4));
			*(int*)ptr += *(int*)((byte*)ptr + 12);
			class21_0.long_0 += *(int*)((byte*)ptr + 12);
			*(int*)((byte*)ptr + 4) -= *(int*)((byte*)ptr + 12);
			if (*(int*)((byte*)ptr + 4) == 0 || class21_0.int_6 == 30)
			{
				break;
			}
			Class15.Class24 class24_ = class21_0.class24_0;
			((byte*)ptr)[20] = (((class21_0.int_6 & 4) != 0) ? ((byte)1) : ((byte)0));
			((byte*)ptr)[21] = (((class21_0.int_6 & 8) != 0) ? ((byte)1) : ((byte)0));
			if (Class26.smethod_34(((byte*)ptr)[21] != 0, ((byte*)ptr)[20] != 0, class24_))
			{
				continue;
			}
			if (class21_0.int_6 != 16)
			{
				if (class21_0.int_6 == 20)
				{
					*(int*)((byte*)ptr + 16) = 8 + (-class21_0.class25_0.int_2 & 7);
					while (*(int*)((byte*)ptr + 16) > 0)
					{
						Class26.smethod_23(class21_0.class25_0, 2, 10);
						*(int*)((byte*)ptr + 16) -= 10;
					}
					class21_0.int_6 = 16;
				}
				else if (class21_0.int_6 == 28)
				{
					Class26.smethod_69(class21_0.class25_0);
					class21_0.int_6 = 30;
				}
				continue;
			}
			return *(int*)((byte*)ptr + 8) - *(int*)((byte*)ptr + 4);
		}
		return *(int*)((byte*)ptr + 8) - *(int*)((byte*)ptr + 4);
	}

	static void smethod_57(Class15.Class18 class18_0)
	{
		class18_0.int_2 = 0;
		class18_0.int_3 = 0;
	}

	static void smethod_58(Class14 class14_0)
	{
		class14_0.type_0.GetMethod("Clear")!.Invoke(class14_0.object_0, new object[0]);
	}

	static int smethod_59(Class15.Class24 class24_0)
	{
		int num = ((class24_0.int_10 << 5) ^ class24_0.byte_0[class24_0.int_14 + 2]) & 0x7FFF;
		short num2 = (class24_0.short_1[class24_0.int_14 & 0x7FFF] = class24_0.short_0[num]);
		class24_0.short_0[num] = (short)class24_0.int_14;
		class24_0.int_10 = num;
		return num2 & 0xFFFF;
	}

	unsafe static void smethod_60(Class15.Class22.Class23 class23_0)
	{
		void* ptr = stackalloc byte[36];
		*(int*)ptr = class23_0.short_0.Length;
		int[] array = new int[*(int*)ptr];
		int num = 0;
		int num2 = 0;
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < *(int*)ptr)
		{
			*(int*)((byte*)ptr + 8) = class23_0.short_0[*(int*)((byte*)ptr + 4)];
			if (*(int*)((byte*)ptr + 8) != 0)
			{
				int num3 = num++;
				int num4;
				while (num3 > 0 && class23_0.short_0[array[num4 = (num3 - 1) / 2]] > *(int*)((byte*)ptr + 8))
				{
					array[num3] = array[num4];
					num3 = num4;
				}
				array[num3] = *(int*)((byte*)ptr + 4);
				num2 = *(int*)((byte*)ptr + 4);
			}
			(*(int*)((byte*)ptr + 4))++;
		}
		while (num < 2)
		{
			int num5 = ((num2 < 2) ? (++num2) : 0);
			array[num++] = num5;
		}
		class23_0.int_1 = Math.Max(num2 + 1, class23_0.int_0);
		*(int*)((byte*)ptr + 12) = num;
		int[] array2 = new int[4 * num - 2];
		int[] array3 = new int[2 * num - 1];
		int num6 = *(int*)((byte*)ptr + 12);
		*(int*)((byte*)ptr + 16) = 0;
		while (*(int*)((byte*)ptr + 16) < num)
		{
			*(int*)((byte*)ptr + 20) = array[*(int*)((byte*)ptr + 16)];
			array2[2 * *(int*)((byte*)ptr + 16)] = *(int*)((byte*)ptr + 20);
			array2[2 * *(int*)((byte*)ptr + 16) + 1] = -1;
			array3[*(int*)((byte*)ptr + 16)] = class23_0.short_0[*(int*)((byte*)ptr + 20)] << 8;
			array[*(int*)((byte*)ptr + 16)] = *(int*)((byte*)ptr + 16);
			(*(int*)((byte*)ptr + 16))++;
		}
		do
		{
			*(int*)((byte*)ptr + 24) = array[0];
			int num7 = array[--num];
			int num8 = 0;
			int num9;
			for (num9 = 1; num9 < num; num9 = num9 * 2 + 1)
			{
				if (num9 + 1 < num && array3[array[num9]] > array3[array[num9 + 1]])
				{
					num9++;
				}
				array[num8] = array[num9];
				num8 = num9;
			}
			int num10 = array3[num7];
			while ((num9 = num8) > 0 && array3[array[num8 = (num9 - 1) / 2]] > num10)
			{
				array[num9] = array[num8];
			}
			array[num9] = num7;
			*(int*)((byte*)ptr + 28) = array[0];
			num7 = num6++;
			array2[2 * num7] = *(int*)((byte*)ptr + 24);
			array2[2 * num7 + 1] = *(int*)((byte*)ptr + 28);
			*(int*)((byte*)ptr + 32) = Math.Min(array3[*(int*)((byte*)ptr + 24)] & 0xFF, array3[*(int*)((byte*)ptr + 28)] & 0xFF);
			num10 = (array3[num7] = array3[*(int*)((byte*)ptr + 24)] + array3[*(int*)((byte*)ptr + 28)] - *(int*)((byte*)ptr + 32) + 1);
			num8 = 0;
			for (num9 = 1; num9 < num; num9 = num8 * 2 + 1)
			{
				if (num9 + 1 < num && array3[array[num9]] > array3[array[num9 + 1]])
				{
					num9++;
				}
				array[num8] = array[num9];
				num8 = num9;
			}
			while ((num9 = num8) > 0 && array3[array[num8 = (num9 - 1) / 2]] > num10)
			{
				array[num9] = array[num8];
			}
			array[num9] = num7;
		}
		while (num > 1);
		Class26.smethod_67(array2, class23_0);
	}

	static void smethod_61(Class15.Class17 class17_0)
	{
		class17_0.uint_0 >>= class17_0.int_2 & 7;
		class17_0.int_2 &= -8;
	}

	unsafe static void smethod_62(Class15.Class24 class24_0)
	{
		void* ptr = stackalloc byte[16];
		Array.Copy(class24_0.byte_0, 32768, class24_0.byte_0, 0, 32768);
		class24_0.int_11 -= 32768;
		class24_0.int_14 -= 32768;
		class24_0.int_13 -= 32768;
		*(int*)ptr = 0;
		while (*(int*)ptr < 32768)
		{
			*(int*)((byte*)ptr + 4) = class24_0.short_0[*(int*)ptr] & 0xFFFF;
			class24_0.short_0[*(int*)ptr] = (short)((*(int*)((byte*)ptr + 4) >= 32768) ? (*(int*)((byte*)ptr + 4) - 32768) : 0);
			(*(int*)ptr)++;
		}
		*(int*)((byte*)ptr + 8) = 0;
		while (*(int*)((byte*)ptr + 8) < 32768)
		{
			*(int*)((byte*)ptr + 12) = class24_0.short_1[*(int*)((byte*)ptr + 8)] & 0xFFFF;
			class24_0.short_1[*(int*)((byte*)ptr + 8)] = (short)((*(int*)((byte*)ptr + 12) >= 32768) ? (*(int*)((byte*)ptr + 12) - 32768) : 0);
			(*(int*)((byte*)ptr + 8))++;
		}
	}

	static void smethod_63(Class15.Class17 class17_0, int int_0)
	{
		class17_0.uint_0 >>= int_0;
		class17_0.int_2 -= int_0;
	}

	static Class15.Class19 smethod_64(Class15.Class20 class20_0)
	{
		byte[] array = new byte[class20_0.int_9];
		Array.Copy(class20_0.byte_1, 0, array, 0, class20_0.int_9);
		return new Class15.Class19(array);
	}

	static void smethod_65(short[] short_0, byte[] byte_0, Class15.Class22.Class23 class23_0)
	{
		class23_0.short_1 = short_0;
		class23_0.byte_0 = byte_0;
	}

	static void smethod_66(Class15.Class22 class22_0)
	{
		class22_0.int_9 = 0;
		class22_0.int_10 = 0;
	}

	unsafe static void smethod_67(int[] int_0, Class15.Class22.Class23 class23_0)
	{
		void* ptr = stackalloc byte[36];
		class23_0.byte_0 = new byte[class23_0.short_0.Length];
		*(int*)ptr = int_0.Length / 2;
		*(int*)((byte*)ptr + 4) = (*(int*)ptr + 1) / 2;
		*(int*)((byte*)ptr + 8) = 0;
		*(int*)((byte*)ptr + 12) = 0;
		while (*(int*)((byte*)ptr + 12) < class23_0.int_3)
		{
			class23_0.int_2[*(int*)((byte*)ptr + 12)] = 0;
			(*(int*)((byte*)ptr + 12))++;
		}
		int[] array = new int[*(int*)ptr];
		array[*(int*)ptr - 1] = 0;
		*(int*)((byte*)ptr + 16) = *(int*)ptr - 1;
		int[] int_;
		nint num2;
		while (*(int*)((byte*)ptr + 16) >= 0)
		{
			if (int_0[2 * *(int*)((byte*)ptr + 16) + 1] != -1)
			{
				*(int*)((byte*)ptr + 20) = array[*(int*)((byte*)ptr + 16)] + 1;
				if (*(int*)((byte*)ptr + 20) > class23_0.int_3)
				{
					*(int*)((byte*)ptr + 20) = class23_0.int_3;
					(*(int*)((byte*)ptr + 8))++;
				}
				array[int_0[2 * *(int*)((byte*)ptr + 16)]] = (array[int_0[2 * *(int*)((byte*)ptr + 16) + 1]] = *(int*)((byte*)ptr + 20));
			}
			else
			{
				*(int*)((byte*)ptr + 24) = array[*(int*)((byte*)ptr + 16)];
				int[] array2 = (int_ = class23_0.int_2);
				int num = *(int*)((byte*)ptr + 24) - 1;
				num2 = num;
				array2[num] = int_[num2] + 1;
				class23_0.byte_0[int_0[2 * *(int*)((byte*)ptr + 16)]] = (byte)array[*(int*)((byte*)ptr + 16)];
			}
			(*(int*)((byte*)ptr + 16))--;
		}
		if (*(int*)((byte*)ptr + 8) == 0)
		{
			return;
		}
		int num3 = class23_0.int_3 - 1;
		while (true)
		{
			if (class23_0.int_2[--num3] != 0)
			{
				do
				{
					int[] array3 = (int_ = class23_0.int_2);
					int num4 = num3;
					num2 = num4;
					array3[num4] = int_[num2] - 1;
					int[] array4 = (int_ = class23_0.int_2);
					int num5 = ++num3;
					num2 = num5;
					array4[num5] = int_[num2] + 1;
					*(int*)((byte*)ptr + 8) -= 1 << class23_0.int_3 - 1 - num3;
				}
				while (*(int*)((byte*)ptr + 8) > 0 && num3 < class23_0.int_3 - 1);
				if (*(int*)((byte*)ptr + 8) <= 0)
				{
					break;
				}
			}
		}
		int[] array5 = (int_ = class23_0.int_2);
		int num6 = class23_0.int_3 - 1;
		num2 = num6;
		array5[num6] = int_[num2] + *(int*)((byte*)ptr + 8);
		int[] array6 = (int_ = class23_0.int_2);
		int num7 = class23_0.int_3 - 2;
		num2 = num7;
		array6[num7] = int_[num2] - *(int*)((byte*)ptr + 8);
		int num8 = 2 * *(int*)((byte*)ptr + 4);
		*(int*)((byte*)ptr + 28) = class23_0.int_3;
		while (*(int*)((byte*)ptr + 28) != 0)
		{
			*(int*)((byte*)ptr + 32) = class23_0.int_2[*(int*)((byte*)ptr + 28) - 1];
			while (*(int*)((byte*)ptr + 32) > 0)
			{
				int num9 = 2 * int_0[num8++];
				if (int_0[num9 + 1] == -1)
				{
					class23_0.byte_0[int_0[num9]] = (byte)(*(uint*)((byte*)ptr + 28));
					(*(int*)((byte*)ptr + 32))--;
				}
			}
			(*(int*)((byte*)ptr + 28))--;
		}
	}

	static void smethod_68(int int_0, Class15.Stream0 stream0_0)
	{
		Class26.smethod_39(stream0_0, int_0);
		Class26.smethod_39(stream0_0, int_0 >> 16);
	}

	static void smethod_69(Class15.Class25 class25_0)
	{
		if (class25_0.int_2 > 0)
		{
			class25_0.byte_0[class25_0.int_1++] = (byte)class25_0.uint_0;
			if (class25_0.int_2 > 8)
			{
				class25_0.byte_0[class25_0.int_1++] = (byte)(class25_0.uint_0 >> 8);
			}
		}
		class25_0.uint_0 = 0u;
		class25_0.int_2 = 0;
	}

	static int smethod_70(Class15.Class22 class22_0, int int_0)
	{
		int num = 0;
		while (int_0 >= 4)
		{
			num += 2;
			int_0 >>= 1;
		}
		return num + int_0;
	}

	static bool smethod_71(Class15.Class22 class22_0)
	{
		return class22_0.int_9 >= 16384;
	}

	static int smethod_72(Class15.Class22 class22_0, int int_0)
	{
		if (int_0 == 255)
		{
			return 285;
		}
		int num = 257;
		while (int_0 >= 8)
		{
			num += 4;
			int_0 >>= 1;
		}
		return num + int_0;
	}

	unsafe static void smethod_73(Hol hol_0)
	{
		void* ptr = stackalloc byte[83];
		new decimal(1522548656L);
		((byte*)ptr)[82] = 1;
		if (((byte*)ptr)[82] != 0)
		{
			*(int*)((byte*)ptr + 72) = 1680590156;
		}
		while (true)
		{
			((byte*)ptr)[82] = 1;
			if (((byte*)ptr)[82] == 0)
			{
				break;
			}
			*(long*)ptr = 0L;
			try
			{
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				((byte*)ptr)[82] = 0;
				if (((byte*)ptr)[82] != 0)
				{
					*(double*)((byte*)ptr + 24) = 0.1790893;
				}
				*(double*)((byte*)ptr + 16) = 263467685.0;
				new decimal(-1802172552L);
				((byte*)ptr)[82] = 1;
				if (((byte*)ptr)[82] != 0)
				{
					*(double*)((byte*)ptr + 32) = 0.8146639;
				}
				*(long*)((byte*)ptr + 8) = 1L;
				((byte*)ptr)[82] = 1;
				if (((byte*)ptr)[82] != 0)
				{
					*(double*)((byte*)ptr + 40) = 0.2277816;
				}
				new decimal(761090620L);
				ProjectData.ClearProjectError();
			}
		}
		*(double*)((byte*)ptr + 48) = 0.6191876;
		while (true)
		{
			double num = *(double*)((byte*)ptr + 48);
			*(double*)((byte*)ptr + 64) = 0.4898304;
			if (num > *(double*)((byte*)ptr + 64))
			{
				break;
			}
			((byte*)ptr)[82] = 0;
			if (((byte*)ptr)[82] != 0)
			{
				*(double*)((byte*)ptr + 56) = 0.3705153;
			}
			new decimal(1446542747L);
			try
			{
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				*(int*)((byte*)ptr + 76) = -796810157;
				ProjectData.ClearProjectError();
			}
			((byte*)ptr)[82] = 1;
			if (((byte*)ptr)[82] != 0)
			{
				((byte*)ptr)[80] = 1;
				try
				{
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					((byte*)ptr)[81] = 0;
					ProjectData.ClearProjectError();
				}
			}
			*(double*)((byte*)ptr + 48) += 1.0;
		}
	}

	static void smethod_74(Class15.Class24 class24_0, byte[] byte_0)
	{
		class24_0.byte_1 = byte_0;
		class24_0.int_17 = 0;
		class24_0.int_18 = byte_0.Length;
	}

	unsafe static void smethod_75(byte[] byte_0, Class15.Class19 class19_0)
	{
		void* ptr = stackalloc byte[68];
		int[] array = new int[16];
		int[] array2 = new int[16];
		*(int*)ptr = 0;
		while (*(int*)ptr < byte_0.Length)
		{
			*(int*)((byte*)ptr + 4) = byte_0[*(int*)ptr];
			if (*(int*)((byte*)ptr + 4) > 0)
			{
				int[] array3;
				int[] array4 = (array3 = array);
				int num = *(int*)((byte*)ptr + 4);
				nint num2 = num;
				array4[num] = array3[num2] + 1;
			}
			(*(int*)ptr)++;
		}
		*(int*)((byte*)ptr + 8) = 0;
		*(int*)((byte*)ptr + 12) = 512;
		*(int*)((byte*)ptr + 16) = 1;
		while (*(int*)((byte*)ptr + 16) <= 15)
		{
			array2[*(int*)((byte*)ptr + 16)] = *(int*)((byte*)ptr + 8);
			*(int*)((byte*)ptr + 8) += array[*(int*)((byte*)ptr + 16)] << 16 - *(int*)((byte*)ptr + 16);
			if (*(int*)((byte*)ptr + 16) >= 10)
			{
				*(int*)((byte*)ptr + 20) = array2[*(int*)((byte*)ptr + 16)] & 0x1FF80;
				*(int*)((byte*)ptr + 24) = *(int*)((byte*)ptr + 8) & 0x1FF80;
				*(int*)((byte*)ptr + 12) += *(int*)((byte*)ptr + 24) - *(int*)((byte*)ptr + 20) >> 16 - *(int*)((byte*)ptr + 16);
			}
			(*(int*)((byte*)ptr + 16))++;
		}
		class19_0.short_0 = new short[*(int*)((byte*)ptr + 12)];
		*(int*)((byte*)ptr + 28) = 512;
		*(int*)((byte*)ptr + 32) = 15;
		while (*(int*)((byte*)ptr + 32) >= 10)
		{
			*(int*)((byte*)ptr + 36) = *(int*)((byte*)ptr + 8) & 0x1FF80;
			*(int*)((byte*)ptr + 8) -= array[*(int*)((byte*)ptr + 32)] << 16 - *(int*)((byte*)ptr + 32);
			*(int*)((byte*)ptr + 40) = *(int*)((byte*)ptr + 8) & 0x1FF80;
			*(int*)((byte*)ptr + 44) = *(int*)((byte*)ptr + 40);
			while (*(int*)((byte*)ptr + 44) < *(int*)((byte*)ptr + 36))
			{
				class19_0.short_0[Class26.smethod_43(*(int*)((byte*)ptr + 44))] = (short)((-(*(int*)((byte*)ptr + 28)) << 4) | *(int*)((byte*)ptr + 32));
				*(int*)((byte*)ptr + 28) += 1 << *(int*)((byte*)ptr + 32) - 9;
				*(int*)((byte*)ptr + 44) += 128;
			}
			(*(int*)((byte*)ptr + 32))--;
		}
		*(int*)((byte*)ptr + 48) = 0;
		while (*(int*)((byte*)ptr + 48) < byte_0.Length)
		{
			*(int*)((byte*)ptr + 52) = byte_0[*(int*)((byte*)ptr + 48)];
			if (*(int*)((byte*)ptr + 52) != 0)
			{
				*(int*)((byte*)ptr + 8) = array2[*(int*)((byte*)ptr + 52)];
				*(int*)((byte*)ptr + 56) = Class26.smethod_43(*(int*)((byte*)ptr + 8));
				if (*(int*)((byte*)ptr + 52) <= 9)
				{
					do
					{
						class19_0.short_0[*(int*)((byte*)ptr + 56)] = (short)((*(int*)((byte*)ptr + 48) << 4) | *(int*)((byte*)ptr + 52));
						*(int*)((byte*)ptr + 56) += 1 << *(int*)((byte*)ptr + 52);
					}
					while (*(int*)((byte*)ptr + 56) < 512);
				}
				else
				{
					*(int*)((byte*)ptr + 60) = class19_0.short_0[*(int*)((byte*)ptr + 56) & 0x1FF];
					*(int*)((byte*)ptr + 64) = 1 << (*(int*)((byte*)ptr + 60) & 0xF);
					*(int*)((byte*)ptr + 60) = -(*(int*)((byte*)ptr + 60) >> 4);
					do
					{
						class19_0.short_0[*(int*)((byte*)ptr + 60) | (*(int*)((byte*)ptr + 56) >> 9)] = (short)((*(int*)((byte*)ptr + 48) << 4) | *(int*)((byte*)ptr + 52));
						*(int*)((byte*)ptr + 56) += 1 << *(int*)((byte*)ptr + 52);
					}
					while (*(int*)((byte*)ptr + 56) < *(int*)((byte*)ptr + 64));
				}
				array2[*(int*)((byte*)ptr + 52)] = *(int*)((byte*)ptr + 8) + (1 << 16 - *(int*)((byte*)ptr + 52));
			}
			(*(int*)((byte*)ptr + 48))++;
		}
	}

	static bool smethod_76(Class15.Class22 class22_0, int int_0)
	{
		class22_0.short_0[class22_0.int_9] = 0;
		class22_0.byte_1[class22_0.int_9++] = (byte)int_0;
		short[] short_;
		short[] array = (short_ = class22_0.class23_0.short_0);
		nint num = int_0;
		array[int_0] = (short)(short_[num] + 1);
		return class22_0.int_9 >= 16384;
	}

	static void smethod_77(Class15.Class24 class24_0)
	{
		class24_0.int_10 = (class24_0.byte_0[class24_0.int_14] << 5) ^ class24_0.byte_0[class24_0.int_14 + 1];
	}

	static void smethod_78(Class15.Class25 class25_0, int int_0)
	{
		class25_0.byte_0[class25_0.int_1++] = (byte)int_0;
		class25_0.byte_0[class25_0.int_1++] = (byte)(int_0 >> 8);
	}

	static byte[] smethod_79(byte[] byte_0)
	{
		return Class26.smethod_31(1, (byte[])null, byte_0, (byte[])null);
	}

	unsafe static int smethod_80(Class15.Class19 class19_0, Class15.Class17 class17_0)
	{
		void* ptr = stackalloc byte[16];
		int num;
		int num2;
		if ((num = Class26.smethod_21(class17_0, 9)) >= 0)
		{
			if ((num2 = class19_0.short_0[num]) >= 0)
			{
				Class26.smethod_63(class17_0, num2 & 0xF);
				return num2 >> 4;
			}
			*(int*)ptr = -(num2 >> 4);
			*(int*)((byte*)ptr + 4) = num2 & 0xF;
			if ((num = Class26.smethod_21(class17_0, *(int*)((byte*)ptr + 4))) >= 0)
			{
				num2 = class19_0.short_0[*(int*)ptr | (num >> 9)];
				Class26.smethod_63(class17_0, num2 & 0xF);
				return num2 >> 4;
			}
			*(int*)((byte*)ptr + 8) = class17_0.int_2;
			num = Class26.smethod_21(class17_0, *(int*)((byte*)ptr + 8));
			num2 = class19_0.short_0[*(int*)ptr | (num >> 9)];
			if ((num2 & 0xF) <= *(int*)((byte*)ptr + 8))
			{
				Class26.smethod_63(class17_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		*(int*)((byte*)ptr + 12) = class17_0.int_2;
		num = Class26.smethod_21(class17_0, *(int*)((byte*)ptr + 12));
		num2 = class19_0.short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= *(int*)((byte*)ptr + 12))
		{
			Class26.smethod_63(class17_0, num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}

	static int smethod_81(Class15.Class25 class25_0, byte[] byte_0, int int_0, int int_1)
	{
		if (class25_0.int_2 >= 8)
		{
			class25_0.byte_0[class25_0.int_1++] = (byte)class25_0.uint_0;
			class25_0.uint_0 >>= 8;
			class25_0.int_2 -= 8;
		}
		if (int_1 > class25_0.int_1 - class25_0.int_0)
		{
			int_1 = class25_0.int_1 - class25_0.int_0;
			Array.Copy(class25_0.byte_0, class25_0.int_0, byte_0, int_0, int_1);
			class25_0.int_0 = 0;
			class25_0.int_1 = 0;
		}
		else
		{
			Array.Copy(class25_0.byte_0, class25_0.int_0, byte_0, int_0, int_1);
			class25_0.int_0 += int_1;
		}
		return int_1;
	}
}
