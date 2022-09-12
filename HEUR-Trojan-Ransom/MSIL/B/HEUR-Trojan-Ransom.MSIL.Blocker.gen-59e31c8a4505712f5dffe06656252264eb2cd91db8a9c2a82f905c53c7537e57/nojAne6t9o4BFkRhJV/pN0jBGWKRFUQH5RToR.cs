using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;

namespace nojAne6t9o4BFkRhJV;

internal static class pN0jBGWKRFUQH5RToR
{
	internal static object PKpbRnIqdyMR2kNM4Qh;

	public static LinearGradientBrush gd1iAWqrZp(Point point_0, Point point_1)
	{
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		LinearGradientBrush result = default(LinearGradientBrush);
		while (true)
		{
			LinearGradientBrush val = new LinearGradientBrush(point_0, point_1, Color.Red, KN4jDtI0QTJT52U2CAH());
			while (true)
			{
				ColorBlend val2 = new ColorBlend();
				int num = 1;
				if (IE9CE9IYY8TKiCMiFxk() == null)
				{
					goto IL_004f;
				}
				goto IL_00ef;
				IL_00ef:
				switch (num)
				{
				case 7:
					break;
				case 5:
					goto IL_002e;
				case 2:
					goto IL_0037;
				case 1:
					goto IL_004f;
				case 3:
					continue;
				case 4:
					goto end_IL_0116;
				default:
					goto IL_0145;
				}
				goto IL_0006;
				IL_004f:
				niIvgSIPCGZXCQVd6o6(val2, new Color[7]
				{
					APG3nhIHQZmixRlZSyX(54, 40, 135),
					Color.FromArgb(71, 25, 122),
					APG3nhIHQZmixRlZSyX(80, 33, 113),
					APG3nhIHQZmixRlZSyX(93, 30, 101),
					Color.FromArgb(99, 32, 97),
					APG3nhIHQZmixRlZSyX(115, 42, 100),
					APG3nhIHQZmixRlZSyX(125, 22, 95)
				});
				num = 7;
				if (!pu9WDbIEcThkvgiRdqr())
				{
					goto IL_0006;
				}
				goto IL_00ef;
				IL_0006:
				float[] array = new float[7];
				cosRfVIdTbyW36OYiZv(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
				OLGcOrIwaCOdbTZCejj(val2, array);
				num = 0;
				if (pu9WDbIEcThkvgiRdqr())
				{
					goto IL_002e;
				}
				goto IL_00ef;
				IL_002e:
				rPlTOrIiHOoRKKjOyEc(val, val2);
				goto IL_0037;
				IL_0037:
				result = val;
				num = 2;
				if (IE9CE9IYY8TKiCMiFxk() != null)
				{
					goto IL_00ef;
				}
				goto IL_0145;
				IL_0145:
				return result;
				continue;
				end_IL_0116:
				break;
			}
		}
	}

	public static LinearGradientBrush zQqijL3D87(Point point_0, Point point_1)
	{
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		int num = 2;
		ColorBlend val2 = default(ColorBlend);
		LinearGradientBrush result = default(LinearGradientBrush);
		while (true)
		{
			LinearGradientBrush val = new LinearGradientBrush(point_0, point_1, KN4jDtI0QTJT52U2CAH(), Color.Red);
			int num2 = 1;
			if (!pu9WDbIEcThkvgiRdqr())
			{
				goto IL_00a9;
			}
			goto IL_00ee;
			IL_00ee:
			while (true)
			{
				switch (num2)
				{
				case 5:
					val2.set_Colors(new Color[7]
					{
						Color.FromArgb(125, 22, 95),
						APG3nhIHQZmixRlZSyX(54, 40, 135),
						APG3nhIHQZmixRlZSyX(71, 25, 122),
						APG3nhIHQZmixRlZSyX(80, 33, 113),
						Color.FromArgb(93, 30, 101),
						APG3nhIHQZmixRlZSyX(99, 32, 97),
						Color.FromArgb(115, 42, 100)
					});
					num2 = 3;
					if (pu9WDbIEcThkvgiRdqr())
					{
						continue;
					}
					goto IL_00a9;
				case 3:
					OLGcOrIwaCOdbTZCejj(val2, new float[7]
					{
						0f,
						1f / 6f,
						1f / 3f,
						0.5f,
						2f / 3f,
						5f / 6f,
						1f
					});
					num2 = 0;
					if (IE9CE9IYY8TKiCMiFxk() == null)
					{
						continue;
					}
					goto default;
				case 1:
					val2 = new ColorBlend();
					num2 = 4;
					if (IE9CE9IYY8TKiCMiFxk() != null)
					{
						continue;
					}
					goto case 5;
				case 2:
					break;
				default:
					rPlTOrIiHOoRKKjOyEc(val, val2);
					num = 4;
					goto case 4;
				case 4:
					return val;
				case 6:
				case 7:
					return result;
				}
				break;
			}
			continue;
			IL_00a9:
			num2 = num;
			goto IL_00ee;
		}
	}

	public static float FsJi1oY7Rk(Color color_0)
	{
		int num = 14;
		int num5 = default(int);
		bool flag5 = default(bool);
		float result = default(float);
		bool flag4 = default(bool);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num2 = color_0.R;
			num = 13;
			while (true)
			{
				int num3 = color_0.G;
				int num4 = 0;
				if (!pu9WDbIEcThkvgiRdqr())
				{
					goto IL_0032;
				}
				goto IL_0214;
				IL_0214:
				while (true)
				{
					int num7;
					int num6;
					switch (num4)
					{
					case 19:
					case 36:
						if (num3 <= num2)
						{
							goto case 10;
						}
						num7 = 0;
						goto IL_0020;
					case 10:
						num7 = ((num3 <= num5) ? 1 : 0);
						goto IL_0020;
					case 35:
						num3 -= num2;
						goto case 22;
					case 22:
						num5 -= num2;
						num4 = 26;
						if (pu9WDbIEcThkvgiRdqr())
						{
							continue;
						}
						goto case 16;
					case 34:
						flag5 = num2 + num3 == 0;
						goto case 12;
					case 12:
						if (flag5)
						{
							goto case 32;
						}
						num4 = 18;
						if (pu9WDbIEcThkvgiRdqr())
						{
							continue;
						}
						goto case 1;
					case 33:
						result = (1f * (float)num2 + 2f / 3f * (float)num5) / (float)(num2 + num5);
						num4 = 10;
						if (!pu9WDbIEcThkvgiRdqr())
						{
							continue;
						}
						goto case 1;
					case 30:
						if (flag4)
						{
							num4 = 11;
							if (IE9CE9IYY8TKiCMiFxk() != null)
							{
								continue;
							}
							goto case 27;
						}
						goto case 21;
					case 27:
						num2 -= num3;
						num4 = 9;
						if (IE9CE9IYY8TKiCMiFxk() == null)
						{
							continue;
						}
						goto IL_0032;
					case 21:
						num2 -= num5;
						num = 28;
						goto case 28;
					case 28:
						num3 -= num5;
						num4 = 34;
						if (pu9WDbIEcThkvgiRdqr())
						{
							continue;
						}
						goto end_IL_02b2;
					case 18:
					case 29:
						result = (0f * (float)num2 + 1f / 3f * (float)num3) / (float)(num2 + num3);
						num4 = 5;
						if (IE9CE9IYY8TKiCMiFxk() == null)
						{
							continue;
						}
						goto case 3;
					case 3:
						num6 = ((num2 <= num5) ? 1 : 0);
						goto IL_0142;
					case 15:
						if (!flag3)
						{
							num4 = 19;
							if (pu9WDbIEcThkvgiRdqr())
							{
								continue;
							}
							goto IL_0032;
						}
						goto case 35;
					case 26:
						flag2 = num3 + num5 == 0;
						num4 = 3;
						if (IE9CE9IYY8TKiCMiFxk() != null)
						{
							continue;
						}
						goto case 24;
					case 24:
						if (flag2)
						{
							goto case 31;
						}
						num4 = 6;
						if (IE9CE9IYY8TKiCMiFxk() == null)
						{
							continue;
						}
						goto case 1;
					case 25:
						if (num2 <= num3)
						{
							num4 = 3;
							if (pu9WDbIEcThkvgiRdqr())
							{
								continue;
							}
							goto IL_0032;
						}
						num6 = 0;
						goto IL_0142;
					case 6:
					case 23:
						result = (1f / 3f * (float)num3 + 2f / 3f * (float)num5) / (float)(num3 + num5);
						num4 = 1;
						if (IE9CE9IYY8TKiCMiFxk() == null)
						{
							continue;
						}
						goto IL_0032;
					case 20:
						flag = num2 + num5 == 0;
						goto case 4;
					case 4:
						if (!flag)
						{
							goto case 33;
						}
						num4 = 16;
						if (pu9WDbIEcThkvgiRdqr())
						{
							continue;
						}
						goto case 1;
					case 9:
						num5 -= num3;
						goto case 20;
					default:
						num5 = color_0.B;
						goto case 25;
					case 13:
						break;
					case 14:
						goto end_IL_02b2;
					case 31:
						result = 0f;
						goto case 1;
					case 32:
						result = 0f;
						goto case 1;
					case 16:
						result = 0f;
						goto case 1;
					case 1:
					case 2:
					case 5:
					case 7:
					case 8:
					case 11:
					case 17:
						{
							return result;
						}
						IL_0142:
						flag3 = (byte)num6 != 0;
						goto case 15;
						IL_0020:
						flag4 = (byte)num7 != 0;
						num4 = 30;
						if (IE9CE9IYY8TKiCMiFxk() == null)
						{
							continue;
						}
						goto IL_0032;
					}
					break;
				}
				continue;
				IL_0032:
				num4 = num;
				goto IL_0214;
				continue;
				end_IL_02b2:
				break;
			}
		}
	}

	public static Color XTPiwwbAC5(float float_0)
	{
		int num = 28;
		bool flag2 = default(bool);
		bool flag5 = default(bool);
		byte b2 = default(byte);
		byte b3 = default(byte);
		bool flag3 = default(bool);
		bool flag4 = default(bool);
		bool flag = default(bool);
		Color result = default(Color);
		while (true)
		{
			byte b = 0;
			int num2 = 27;
			if (!pu9WDbIEcThkvgiRdqr())
			{
				goto IL_008b;
			}
			goto IL_0176;
			IL_0176:
			while (true)
			{
				switch (num2)
				{
				case 35:
					if (flag2)
					{
						break;
					}
					num = 18;
					goto case 18;
				case 18:
				case 30:
					flag5 = float_0 < 0.5f;
					goto case 34;
				case 34:
					if (flag5)
					{
						goto case 11;
					}
					goto case 9;
				case 11:
					b2 = byte.MaxValue;
					goto case 5;
				case 5:
					b3 = (byte)((float)(int)b2 * (1f / 3f - float_0) / (float_0 - 2f / 3f));
					num2 = 2;
					if (IE9CE9IYY8TKiCMiFxk() == null)
					{
						continue;
					}
					goto IL_008b;
				case 9:
					flag3 = float_0 < 2f / 3f;
					num2 = 8;
					if (pu9WDbIEcThkvgiRdqr())
					{
						continue;
					}
					goto IL_008b;
				case 1:
					break;
				case 33:
					b = (byte)((float)(int)b2 * (1f / 3f - float_0) / (float_0 - 0f));
					num2 = 3;
					if (IE9CE9IYY8TKiCMiFxk() == null)
					{
						continue;
					}
					goto IL_008b;
				case 29:
					b = byte.MaxValue;
					num2 = 19;
					if (IE9CE9IYY8TKiCMiFxk() == null)
					{
						continue;
					}
					goto case 8;
				case 8:
					if (!flag3)
					{
						goto case 16;
					}
					goto case 26;
				case 16:
				case 20:
					flag4 = float_0 < 5f / 6f;
					num2 = 5;
					if (IE9CE9IYY8TKiCMiFxk() != null)
					{
						continue;
					}
					goto case 6;
				case 6:
					if (!flag4)
					{
						num2 = 0;
						if (!pu9WDbIEcThkvgiRdqr())
						{
							continue;
						}
						goto default;
					}
					goto case 25;
				case 27:
					b2 = 0;
					goto case 13;
				case 13:
					b3 = 0;
					num2 = 24;
					if (IE9CE9IYY8TKiCMiFxk() == null)
					{
						continue;
					}
					goto IL_008b;
				case 24:
					flag = float_0 < 1f / 6f;
					goto case 17;
				case 17:
					if (flag)
					{
						goto case 29;
					}
					goto case 4;
				case 4:
					flag2 = float_0 < 1f / 3f;
					num2 = 35;
					if (IE9CE9IYY8TKiCMiFxk() == null)
					{
						continue;
					}
					goto IL_008b;
				case 19:
					b2 = (byte)((float)(int)b * (float_0 - 0f) / (1f / 3f - float_0));
					num2 = 31;
					if (pu9WDbIEcThkvgiRdqr())
					{
						continue;
					}
					goto IL_008b;
				case 28:
					goto end_IL_0176;
				default:
					b = byte.MaxValue;
					goto case 21;
				case 21:
					b3 = (byte)((float)(int)b * (float_0 - 1f) / (2f / 3f - float_0));
					goto case 2;
				case 25:
					b3 = byte.MaxValue;
					num = 12;
					goto case 12;
				case 12:
					b = (byte)((float)(int)b3 * (2f / 3f - float_0) / (float_0 - 1f));
					goto case 2;
				case 26:
					b3 = byte.MaxValue;
					goto case 14;
				case 14:
					b2 = (byte)((float)(int)b3 * (float_0 - 2f / 3f) / (1f / 3f - float_0));
					goto case 2;
				case 2:
				case 3:
				case 10:
				case 15:
				case 23:
				case 31:
					return APG3nhIHQZmixRlZSyX(b, b2, b3);
				case 7:
				case 32:
					return result;
				}
				b2 = byte.MaxValue;
				num2 = 33;
				if (IE9CE9IYY8TKiCMiFxk() == null)
				{
					continue;
				}
				goto IL_008b;
				continue;
				end_IL_0176:
				break;
			}
			continue;
			IL_008b:
			num2 = num;
			goto IL_0176;
		}
	}

	internal static Color KN4jDtI0QTJT52U2CAH()
	{
		return Color.Red;
	}

	internal static Color APG3nhIHQZmixRlZSyX(int int_0, int int_1, int int_2)
	{
		return Color.FromArgb(int_0, int_1, int_2);
	}

	internal static void niIvgSIPCGZXCQVd6o6(object object_0, object object_1)
	{
		((ColorBlend)object_0).set_Colors((Color[])object_1);
	}

	internal static void cosRfVIdTbyW36OYiZv(object object_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray((Array)object_0, runtimeFieldHandle_0);
	}

	internal static void OLGcOrIwaCOdbTZCejj(object object_0, object object_1)
	{
		((ColorBlend)object_0).set_Positions((float[])object_1);
	}

	internal static void rPlTOrIiHOoRKKjOyEc(object object_0, object object_1)
	{
		((LinearGradientBrush)object_0).set_InterpolationColors((ColorBlend)object_1);
	}

	internal static bool pu9WDbIEcThkvgiRdqr()
	{
		return PKpbRnIqdyMR2kNM4Qh == null;
	}

	internal static pN0jBGWKRFUQH5RToR IE9CE9IYY8TKiCMiFxk()
	{
		return (pN0jBGWKRFUQH5RToR)PKpbRnIqdyMR2kNM4Qh;
	}
}
