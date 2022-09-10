using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

[StandardModule]
public sealed class GClass25
{
	public class GClass26
	{
		public object object_0;

		public object object_1;

		public object object_2;

		public object object_3;

		public object object_4;

		public object object_5;

		public object object_6;

		public object object_7;

		public object object_8;

		public object object_9;

		public GClass26()
		{
			smethod_0(this);
		}

		internal static void smethod_0(object object_10)
		{
			object_10._002Ector();
		}
	}

	private static Color color_0;

	private static object object_0;

	public static object object_1;

	public static object object_2;

	private static object object_3;

	private static object object_4;

	static GClass25()
	{
		smethod_10();
		if (!smethod_11())
		{
			goto IL_004f;
		}
		goto IL_0059;
		IL_0059:
		while (true)
		{
			IL_0059_2:
			object_2 = "C:\\Spirit\\bin\\";
			while (true)
			{
				object_3 = null;
				while (true)
				{
					object_4 = null;
					if (smethod_10())
					{
						switch (6)
						{
						case 3:
							goto end_IL_0012;
						case 0:
						case 2:
							goto end_IL_0047;
						case 1:
						case 4:
							goto IL_0059_2;
						case 6:
							return;
						}
						continue;
					}
					return;
					continue;
					end_IL_0012:
					break;
				}
				continue;
				end_IL_0047:
				break;
			}
			break;
		}
		goto IL_004f;
		IL_004f:
		object_0 = new GClass26();
		goto IL_0059;
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetPrivateProfileStringA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_2, StringBuilder stringBuilder_0, int int_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_3);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long WritePrivateProfileStringA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_2, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_3);

	public static Image smethod_0(object object_5, Size size_0, InterpolationMode interpolationMode_0)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		smethod_11();
		if (!smethod_10())
		{
			if (smethod_11())
			{
				goto IL_00cf;
			}
			switch (4)
			{
			case 0:
			case 3:
				break;
			case 1:
			case 4:
				goto IL_0059;
			default:
				goto IL_0060;
			case 5:
				goto IL_00cf;
			}
		}
		Bitmap val = new Bitmap(size_0.Width, size_0.Height);
		goto IL_0059;
		IL_0059:
		Graphics val2 = (Graphics)smethod_12(val);
		goto IL_0060;
		IL_00cf:
		Image result = default(Image);
		if (true)
		{
			return result;
		}
		goto IL_0059;
		IL_0060:
		try
		{
			smethod_13(object_5, (RotateFlipType)2);
			while (true)
			{
				smethod_13(object_5, (RotateFlipType)2);
				_ = 0;
				if (!smethod_10())
				{
					if (smethod_11())
					{
					}
					switch (3)
					{
					case 0:
						break;
					case 1:
					case 4:
						goto IL_00a3;
					default:
						goto IL_00aa;
					case 5:
						goto end_IL_0067;
					}
					continue;
				}
				goto IL_00a3;
				IL_00a3:
				smethod_14(val2, interpolationMode_0);
				goto IL_00aa;
				IL_00aa:
				smethod_15(val2, object_5, 0, 0, size_0.Width, size_0.Height);
				break;
				continue;
				end_IL_0067:
				break;
			}
		}
		finally
		{
			if (val2 != null)
			{
				smethod_16(val2);
			}
		}
		result = (Image)(object)val;
		goto IL_00cf;
	}

	public static Image smethod_1(object object_5, Rectangle rectangle_0, Color color_1)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		smethod_10();
		if (smethod_11())
		{
			if (smethod_11())
			{
				goto IL_0063;
			}
			switch (4)
			{
			case 0:
			case 3:
				break;
			case 1:
			case 4:
				goto IL_0058;
			default:
				goto IL_0063;
			case 5:
				goto IL_00b0;
			}
		}
		object_3 = (object)new Bitmap(smethod_17(object_5), smethod_18(object_5));
		goto IL_0058;
		IL_0058:
		Graphics val = (Graphics)smethod_12(object_3);
		goto IL_0063;
		IL_00b0:
		Image result = default(Image);
		if (true)
		{
			return result;
		}
		goto IL_0058;
		IL_0063:
		try
		{
			smethod_13(object_5, (RotateFlipType)2);
			smethod_13(object_5, (RotateFlipType)2);
			smethod_19(val, object_5, 0, 0);
			Pen val2 = new Pen((Brush)smethod_20(), 3f);
			try
			{
				smethod_21(val, val2, rectangle_0);
			}
			finally
			{
				if (val2 != null)
				{
					smethod_16(val2);
				}
			}
		}
		finally
		{
			if (val != null)
			{
				smethod_16(val);
			}
		}
		result = (Image)object_3;
		goto IL_00b0;
	}

	public static Image smethod_2(object object_5, Rectangle rectangle_0, Rectangle rectangle_1)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		_ = 1;
		if (!smethod_11())
		{
			object_4 = (object)new Bitmap(rectangle_1.Width, rectangle_1.Height);
		}
		Image result;
		do
		{
			Graphics val = (Graphics)smethod_12(object_4);
			try
			{
				smethod_14(val, (InterpolationMode)2);
				smethod_11();
				if (smethod_10())
				{
					goto IL_004e;
				}
				goto IL_0058;
				IL_0058:
				if (1 == 0)
				{
					goto IL_004e;
				}
				goto end_IL_0032;
				IL_004e:
				smethod_22(val, object_5, rectangle_1, rectangle_0, (GraphicsUnit)2);
				goto IL_0058;
				end_IL_0032:;
			}
			finally
			{
				if (val != null)
				{
					smethod_16(val);
				}
			}
			result = (Image)object_4;
		}
		while (1 == 0);
		return result;
	}

	public static void smethod_3(ref Image image_0, ref Rectangle rectangle_0, ref Image image_1, int int_0, ref PictureBox pictureBox_0)
	{
		checked
		{
			Rectangle rectangle_ = default(Rectangle);
			while (true)
			{
				bool flag = (image_0 != null) & (image_1 != null);
				_ = 1;
				if (smethod_11())
				{
					goto IL_011c;
				}
				goto IL_00ec;
				IL_00ec:
				if (!flag)
				{
					break;
				}
				goto IL_00ef;
				IL_00ef:
				rectangle_ = default(Rectangle);
				goto IL_00f7;
				IL_00f7:
				rectangle_.X = (int)smethod_23((double)(rectangle_0.X * smethod_17(image_0)) / (double)smethod_17(image_1));
				goto IL_011c;
				IL_011c:
				while (true)
				{
					IL_011c_2:
					rectangle_.Y = (int)smethod_23((double)(rectangle_0.Y * smethod_18(image_0)) / (double)smethod_18(image_1));
					while (true)
					{
						IL_00c5:
						rectangle_.Width = (int)smethod_23((double)(rectangle_0.Width * smethod_17(image_0)) / (double)smethod_17(image_1));
						while (true)
						{
							IL_009e:
							rectangle_.Height = (int)smethod_23((double)(rectangle_0.Height * smethod_18(image_0)) / (double)smethod_18(image_1));
							while (true)
							{
								IL_0084:
								rectangle_.Width = (int)smethod_23((double)rectangle_.Width / (double)int_0);
								while (true)
								{
									rectangle_.Height = (int)smethod_23((double)rectangle_.Height / (double)int_0);
									if (smethod_10())
									{
										switch (11)
										{
										case 10:
											break;
										case 0:
											continue;
										case 12:
											goto IL_0084;
										default:
											goto IL_009e;
										case 7:
											goto IL_00c5;
										case 1:
										case 8:
											goto IL_00ec;
										case 3:
											goto IL_00ef;
										case 5:
											goto IL_00f7;
										case 4:
										case 6:
											goto IL_011c_2;
										case 11:
											smethod_26(pictureBox_0, smethod_25(image_0, rectangle_, smethod_24(pictureBox_0)));
											goto IL_0161;
										case 2:
											goto IL_0161;
										case 13:
											return;
										}
										break;
									}
									goto IL_0161;
									IL_0161:
									smethod_27(pictureBox_0);
									return;
								}
								break;
							}
							break;
						}
						break;
					}
					break;
				}
			}
		}
	}

	public static void smethod_4(ref Rectangle rectangle_0, int int_0, ref PictureBox pictureBox_0, ref Image image_0)
	{
		Rectangle rectangle_ = default(Rectangle);
		_ = 1;
		checked
		{
			if (!smethod_11())
			{
				rectangle_.X = rectangle_0.X;
				rectangle_.Y = rectangle_0.Y;
				rectangle_.Width = (int)smethod_23((double)rectangle_0.Width / (double)int_0);
			}
			rectangle_.Height = (int)smethod_23((double)rectangle_0.Height / (double)int_0);
			smethod_26(pictureBox_0, smethod_28(image_0, rectangle_, color_0));
		}
	}

	public static void smethod_5(ref Rectangle rectangle_0, ref Form form_0, ref bool bool_0)
	{
		smethod_11();
		if (smethod_10())
		{
			smethod_29();
		}
		bool flag;
		do
		{
			flag = (object_0 != null) & (form_0 != null);
		}
		while (1 == 0);
		if (!flag)
		{
			return;
		}
		try
		{
			rectangle_0.X = smethod_30(((GClass26)object_0).object_6);
			smethod_10();
			if (smethod_11())
			{
				goto IL_0069;
			}
			int num = 2;
			if (!smethod_11())
			{
				goto IL_01a7;
			}
			goto IL_01c5;
			IL_01c5:
			rectangle_0.Y = smethod_30(((GClass26)object_0).object_5);
			goto IL_0069;
			IL_0069:
			rectangle_0.Width = ((smethod_30(((GClass26)object_0).object_8) <= 50) ? 100 : smethod_30(((GClass26)object_0).object_8));
			rectangle_0.Height = ((smethod_30(((GClass26)object_0).object_7) > 20) ? smethod_30(((GClass26)object_0).object_7) : 100);
			smethod_33(form_0, (smethod_31(((GClass26)object_0).object_2, "", bool_0: false) == 0) ? smethod_32(form_0) : smethod_30(((GClass26)object_0).object_2));
			smethod_35(form_0, (smethod_31(((GClass26)object_0).object_1, "", bool_0: false) == 0) ? smethod_34(form_0) : smethod_30(((GClass26)object_0).object_1));
			smethod_37(form_0, (smethod_31(((GClass26)object_0).object_3, "", bool_0: false) == 0) ? smethod_36(form_0) : smethod_30(((GClass26)object_0).object_3));
			smethod_39(form_0, (smethod_31(((GClass26)object_0).object_4, "", bool_0: false) == 0) ? smethod_38(form_0) : smethod_30(((GClass26)object_0).object_4));
			bool_0 = false;
			num = 4;
			if (smethod_11())
			{
				return;
			}
			goto IL_01a7;
			IL_01a7:
			switch (num)
			{
			case 0:
			case 2:
				goto IL_01c5;
			case 4:
				return;
			}
			goto IL_0069;
		}
		catch (Exception object_)
		{
			smethod_40(object_);
			rectangle_0.X = rectangle_0.X;
			rectangle_0.Y = rectangle_0.Y;
			rectangle_0.Width = 100;
			rectangle_0.Height = 100;
			smethod_33(form_0, smethod_32(form_0));
			smethod_35(form_0, smethod_34(form_0));
			smethod_37(form_0, smethod_36(form_0));
			smethod_39(form_0, smethod_38(form_0));
			bool_0 = false;
			smethod_41();
		}
	}

	public static void smethod_6()
	{
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			bool flag = object_0 == null;
			string string_4 = default(string);
			while (true)
			{
				IL_0402:
				if (flag)
				{
					goto IL_03e4;
				}
				goto IL_03ee;
				IL_03ee:
				while (true)
				{
					IL_03ee_2:
					object_1 = new StringBuilder(255);
					while (true)
					{
						string string_ = "Magnifier Window Position";
						_ = 0;
						int num;
						if (!smethod_10())
						{
							num = 23;
							if (!smethod_11())
							{
								goto IL_0340;
							}
							goto IL_0454;
						}
						goto IL_02d3;
						IL_0454:
						((GClass26)object_0).object_8 = smethod_44(smethod_43(object_1), new char[1] { ' ' });
						return;
						IL_02d3:
						string string_2 = "MagnifierWindowTop";
						string string_3 = " ";
						object stringBuilder_ = object_1;
						string_4 = (string)smethod_42(object_2, "spirit.ini");
						GetPrivateProfileStringA(ref string_, ref string_2, ref string_3, (StringBuilder)stringBuilder_, 255, ref string_4);
						goto IL_0308;
						IL_0308:
						((GClass26)object_0).object_1 = smethod_44(smethod_43(object_1), new char[1] { ' ' });
						goto IL_032c;
						IL_032c:
						object_1 = new StringBuilder(255);
						goto IL_017e;
						IL_017e:
						string_4 = "Magnifier Window Position";
						goto IL_0185;
						IL_0185:
						string_3 = "MagnifierWindowLeft";
						string_2 = " ";
						object stringBuilder_2 = object_1;
						string_ = (string)smethod_42(object_2, "spirit.ini");
						GetPrivateProfileStringA(ref string_4, ref string_3, ref string_2, (StringBuilder)stringBuilder_2, 255, ref string_);
						goto IL_01b9;
						IL_01b9:
						((GClass26)object_0).object_2 = smethod_44(smethod_43(object_1), new char[1] { ' ' });
						goto IL_01dd;
						IL_01dd:
						object_1 = new StringBuilder(255);
						goto IL_01ec;
						IL_01ec:
						string_ = "Magnifier Window Position";
						goto IL_01f2;
						IL_01f2:
						string_2 = "MagnifierWindowWidth";
						string_3 = " ";
						object stringBuilder_3 = object_1;
						string_4 = (string)smethod_42(object_2, "spirit.ini");
						GetPrivateProfileStringA(ref string_, ref string_2, ref string_3, (StringBuilder)stringBuilder_3, 255, ref string_4);
						goto IL_0227;
						IL_0227:
						((GClass26)object_0).object_3 = smethod_44(smethod_43(object_1), new char[1] { ' ' });
						goto IL_024b;
						IL_024b:
						object_1 = new StringBuilder(255);
						goto IL_025a;
						IL_025a:
						string_4 = "Magnifier Window Position";
						goto IL_0261;
						IL_0261:
						string_3 = "MagnifierWindowHeight";
						string_2 = " ";
						object stringBuilder_4 = object_1;
						string_ = (string)smethod_42(object_2, "spirit.ini");
						GetPrivateProfileStringA(ref string_4, ref string_3, ref string_2, (StringBuilder)stringBuilder_4, 255, ref string_);
						goto IL_0295;
						IL_0295:
						((GClass26)object_0).object_4 = smethod_44(smethod_43(object_1), new char[1] { ' ' });
						goto IL_02b9;
						IL_02b9:
						object_1 = new StringBuilder(255);
						goto IL_02c8;
						IL_02c8:
						string_ = "Magnifier Window Position";
						goto IL_0035;
						IL_0035:
						string_2 = "MagnifierTop";
						string_3 = " ";
						object stringBuilder_5 = object_1;
						string_4 = (string)smethod_42(object_2, "spirit.ini");
						GetPrivateProfileStringA(ref string_, ref string_2, ref string_3, (StringBuilder)stringBuilder_5, 255, ref string_4);
						goto IL_006a;
						IL_006a:
						((GClass26)object_0).object_5 = smethod_44(smethod_43(object_1), new char[1] { ' ' });
						goto IL_008e;
						IL_008e:
						object_1 = new StringBuilder(255);
						goto IL_009d;
						IL_009d:
						string_4 = "Magnifier Window Position";
						goto IL_00a4;
						IL_00a4:
						string_3 = "MagnifierLeft";
						string_2 = " ";
						object stringBuilder_6 = object_1;
						string_ = (string)smethod_42(object_2, "spirit.ini");
						GetPrivateProfileStringA(ref string_4, ref string_3, ref string_2, (StringBuilder)stringBuilder_6, 255, ref string_);
						goto IL_00d8;
						IL_00d8:
						((GClass26)object_0).object_6 = smethod_44(smethod_43(object_1), new char[1] { ' ' });
						goto IL_00fc;
						IL_00fc:
						object_1 = new StringBuilder(255);
						goto IL_010b;
						IL_010b:
						string_ = "Magnifier Window Position";
						goto IL_0111;
						IL_0111:
						string_2 = "MagnifierHeight";
						string_3 = " ";
						object stringBuilder_7 = object_1;
						string_4 = (string)smethod_42(object_2, "spirit.ini");
						GetPrivateProfileStringA(ref string_, ref string_2, ref string_3, (StringBuilder)stringBuilder_7, 255, ref string_4);
						goto IL_0146;
						IL_0146:
						((GClass26)object_0).object_7 = smethod_44(smethod_43(object_1), new char[1] { ' ' });
						num = 11;
						if (!smethod_10())
						{
							return;
						}
						goto IL_0340;
						IL_0340:
						switch (num)
						{
						case 35:
							break;
						case 34:
							goto IL_0035;
						case 10:
							goto IL_006a;
						case 29:
							goto IL_008e;
						case 24:
							goto IL_009d;
						case 30:
							goto IL_00a4;
						case 28:
							goto IL_00d8;
						case 23:
						case 26:
							goto IL_00fc;
						case 32:
							goto IL_010b;
						case 17:
							goto IL_0111;
						case 20:
							goto IL_0146;
						case 33:
							goto IL_017e;
						case 21:
							goto IL_0185;
						case 5:
							goto IL_01b9;
						case 13:
							goto IL_01dd;
						case 12:
							goto IL_01ec;
						case 7:
							goto IL_01f2;
						case 9:
							goto IL_0227;
						case 25:
							goto IL_024b;
						case 15:
							goto IL_025a;
						case 3:
							goto IL_0261;
						default:
							goto IL_0295;
						case 8:
							goto IL_02b9;
						case 16:
							goto IL_02c8;
						case 4:
						case 14:
							goto IL_02d3;
						case 0:
							goto IL_0308;
						case 2:
							goto IL_032c;
						case 18:
							goto end_IL_000f;
						case 1:
							goto IL_03ee_2;
						case 19:
							goto IL_0402;
						case 11:
							object_1 = new StringBuilder(255);
							goto case 27;
						case 27:
							string_4 = "Magnifier Window Position";
							goto case 31;
						case 31:
						{
							string_3 = "MagnifierWidth";
							string_2 = " ";
							object stringBuilder_8 = object_1;
							string_ = (string)smethod_42(object_2, "spirit.ini");
							GetPrivateProfileStringA(ref string_4, ref string_3, ref string_2, (StringBuilder)stringBuilder_8, 255, ref string_);
							goto IL_0454;
						}
						case 6:
							goto IL_0454;
						case 36:
							return;
						}
						continue;
						end_IL_000f:
						break;
					}
					break;
				}
				goto IL_03e4;
				IL_03e4:
				object_0 = new GClass26();
				goto IL_03ee;
			}
		}
		catch (Exception ex)
		{
			smethod_40(ex);
			Exception object_ = ex;
			smethod_46(smethod_45(object_), (MsgBoxStyle)0, null);
			smethod_41();
		}
	}

	public static int smethod_7()
	{
		_ = 1;
		string string_ = default(string);
		if (!smethod_11())
		{
			object_1 = new StringBuilder(255);
			string_ = "Magnifier Window Position";
		}
		string string_2 = "MagnifierZoom";
		string string_3 = " ";
		object stringBuilder_ = object_1;
		string string_4 = (string)smethod_42(object_2, "spirit.ini");
		GetPrivateProfileStringA(ref string_, ref string_2, ref string_3, (StringBuilder)stringBuilder_, 255, ref string_4);
		((GClass26)object_0).object_9 = smethod_44(smethod_43(object_1), new char[1] { ' ' });
		return smethod_30(((GClass26)object_0).object_9);
	}

	public static void smethod_8(Rectangle rectangle_0, object object_5, int int_0)
	{
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((GClass26)object_0).object_5 = smethod_47(rectangle_0.Location.Y);
			while (true)
			{
				string string_ = "Magnifier Window Position";
				while (true)
				{
					string string_2 = "MagnifierTop";
					ref object object_6 = ref ((GClass26)object_0).object_5;
					string string_3 = (string)smethod_42(object_2, "spirit.ini");
					WritePrivateProfileStringA(ref string_, ref string_2, ref System.Runtime.CompilerServices.Unsafe.As<object, string>(ref object_6), ref string_3);
					while (true)
					{
						((GClass26)object_0).object_6 = smethod_47(rectangle_0.Location.X);
						while (true)
						{
							string_3 = "Magnifier Window Position";
							while (true)
							{
								string_2 = "MagnifierLeft";
								ref object object_7 = ref ((GClass26)object_0).object_6;
								string_ = (string)smethod_42(object_2, "spirit.ini");
								WritePrivateProfileStringA(ref string_3, ref string_2, ref System.Runtime.CompilerServices.Unsafe.As<object, string>(ref object_7), ref string_);
								while (true)
								{
									((GClass26)object_0).object_7 = smethod_47(rectangle_0.Height);
									while (true)
									{
										IL_01b9:
										string_ = "Magnifier Window Position";
										int num = 17;
										if (!smethod_10())
										{
											goto IL_00e3;
										}
										goto IL_013f;
										IL_013f:
										while (true)
										{
											switch (num)
											{
											case 26:
												break;
											case 1:
												goto IL_002a;
											case 14:
												goto IL_0068;
											default:
												goto IL_006e;
											case 8:
												goto IL_009a;
											case 11:
											case 25:
												goto IL_00c4;
											case 17:
												goto IL_00e3;
											case 12:
												goto IL_010f;
											case 10:
												string_3 = "Magnifier Window Position";
												num = 3;
												if (!smethod_11())
												{
													continue;
												}
												goto case 20;
											case 19:
												goto IL_01b9;
											case 22:
												goto end_IL_01b9;
											case 15:
												goto end_IL_01d4;
											case 4:
												goto end_IL_01ec;
											case 9:
												goto end_IL_021a;
											case 0:
												goto end_IL_0222;
											case 6:
												goto end_IL_0242;
											case 3:
											{
												string_2 = "MagnifierWindowLeft";
												ref object string_4 = ref ((GClass26)object_0).object_2;
												string_ = (string)smethod_42(object_2, "spirit.ini");
												WritePrivateProfileStringA(ref string_3, ref string_2, ref System.Runtime.CompilerServices.Unsafe.As<object, string>(ref string_4), ref string_);
												goto case 7;
											}
											case 7:
												((GClass26)object_0).object_3 = smethod_47(smethod_36(object_5));
												goto case 18;
											case 18:
												string_ = "Magnifier Window Position";
												goto case 21;
											case 21:
											{
												string_2 = "MagnifierWindowWidth";
												ref object string_5 = ref ((GClass26)object_0).object_3;
												string_3 = (string)smethod_42(object_2, "spirit.ini");
												WritePrivateProfileStringA(ref string_, ref string_2, ref System.Runtime.CompilerServices.Unsafe.As<object, string>(ref string_5), ref string_3);
												goto case 5;
											}
											case 5:
												((GClass26)object_0).object_4 = smethod_47(smethod_38(object_5));
												goto case 13;
											case 13:
												string_3 = "Magnifier Window Position";
												goto case 2;
											case 2:
											{
												string_2 = "MagnifierWindowHeight";
												ref object string_6 = ref ((GClass26)object_0).object_4;
												string_ = (string)smethod_42(object_2, "spirit.ini");
												WritePrivateProfileStringA(ref string_3, ref string_2, ref System.Runtime.CompilerServices.Unsafe.As<object, string>(ref string_6), ref string_);
												goto case 20;
											}
											case 20:
												smethod_49(object_3);
												goto IL_0344;
											case 23:
											case 24:
												goto IL_0344;
											case 27:
												return;
											}
											break;
										}
										goto IL_0024;
										IL_00e3:
										string_2 = "MagnifierHeight";
										ref object object_8 = ref ((GClass26)object_0).object_7;
										string_3 = (string)smethod_42(object_2, "spirit.ini");
										WritePrivateProfileStringA(ref string_, ref string_2, ref System.Runtime.CompilerServices.Unsafe.As<object, string>(ref object_8), ref string_3);
										goto IL_010f;
										IL_010f:
										((GClass26)object_0).object_8 = smethod_47(rectangle_0.Width);
										goto IL_0024;
										IL_0024:
										string_3 = "Magnifier Window Position";
										goto IL_002a;
										IL_002a:
										string_2 = "MagnifierWidth";
										ref object object_9 = ref ((GClass26)object_0).object_8;
										string_ = (string)smethod_42(object_2, "spirit.ini");
										WritePrivateProfileStringA(ref string_3, ref string_2, ref System.Runtime.CompilerServices.Unsafe.As<object, string>(ref object_9), ref string_);
										smethod_10();
										if (!smethod_11())
										{
											goto IL_00c4;
										}
										goto IL_0344;
										IL_00c4:
										((GClass26)object_0).object_1 = smethod_47(smethod_48(object_5).Y);
										goto IL_0068;
										IL_0068:
										string_ = "Magnifier Window Position";
										goto IL_006e;
										IL_006e:
										string_2 = "MagnifierWindowTop";
										ref object string_7 = ref ((GClass26)object_0).object_1;
										string_3 = (string)smethod_42(object_2, "spirit.ini");
										WritePrivateProfileStringA(ref string_, ref string_2, ref System.Runtime.CompilerServices.Unsafe.As<object, string>(ref string_7), ref string_3);
										goto IL_009a;
										IL_009a:
										((GClass26)object_0).object_2 = smethod_47(smethod_48(object_5).X);
										num = 10;
										if (!smethod_10())
										{
											goto IL_00c4;
										}
										goto IL_013f;
										IL_0344:
										smethod_49(object_4);
										return;
										continue;
										end_IL_01b9:
										break;
									}
									continue;
									end_IL_01d4:
									break;
								}
								continue;
								end_IL_01ec:
								break;
							}
							continue;
							end_IL_021a:
							break;
						}
						continue;
						end_IL_0222:
						break;
					}
					continue;
					end_IL_0242:
					break;
				}
			}
		}
		catch (Exception ex)
		{
			smethod_40(ex);
			Exception object_10 = ex;
			smethod_46(smethod_42("Error Saving Configuration - Please Contact Spirit Support ", smethod_45(object_10)), (MsgBoxStyle)0, null);
			smethod_41();
		}
	}

	public static bool smethod_9(object object_5)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		_ = 0;
		FormCollection object_6 = default(FormCollection);
		if (smethod_10())
		{
			object_6 = (FormCollection)smethod_50();
		}
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = (IEnumerator)smethod_51(object_6);
			bool result = default(bool);
			while (smethod_54(enumerator))
			{
				Form object_7 = (Form)smethod_52(enumerator);
				if (smethod_31(smethod_53(object_7), object_5, bool_0: false) == 0)
				{
					smethod_10();
					if (!smethod_11())
					{
						return true;
					}
					return result;
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				smethod_16(enumerator as IDisposable);
			}
		}
		return false;
	}

	internal static bool smethod_10()
	{
		return true;
	}

	internal static bool smethod_11()
	{
		return false;
	}

	internal static object smethod_12(object object_5)
	{
		return Graphics.FromImage((Image)object_5);
	}

	internal static void smethod_13(object object_5, RotateFlipType rotateFlipType_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Image)object_5).RotateFlip(rotateFlipType_0);
	}

	internal static void smethod_14(object object_5, InterpolationMode interpolationMode_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Graphics)object_5).set_InterpolationMode(interpolationMode_0);
	}

	internal static void smethod_15(object object_5, object object_6, int int_0, int int_1, int int_2, int int_3)
	{
		((Graphics)object_5).DrawImage((Image)object_6, int_0, int_1, int_2, int_3);
	}

	internal static void smethod_16(object object_5)
	{
		((IDisposable)object_5).Dispose();
	}

	internal static int smethod_17(object object_5)
	{
		return ((Image)object_5).get_Width();
	}

	internal static int smethod_18(object object_5)
	{
		return ((Image)object_5).get_Height();
	}

	internal static void smethod_19(object object_5, object object_6, int int_0, int int_1)
	{
		((Graphics)object_5).DrawImage((Image)object_6, int_0, int_1);
	}

	internal static object smethod_20()
	{
		return Brushes.get_Red();
	}

	internal static void smethod_21(object object_5, object object_6, Rectangle rectangle_0)
	{
		((Graphics)object_5).DrawRectangle((Pen)object_6, rectangle_0);
	}

	internal static void smethod_22(object object_5, object object_6, Rectangle rectangle_0, Rectangle rectangle_1, GraphicsUnit graphicsUnit_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		((Graphics)object_5).DrawImage((Image)object_6, rectangle_0, rectangle_1, graphicsUnit_0);
	}

	internal static double smethod_23(double double_0)
	{
		return Math.Round(double_0);
	}

	internal static Rectangle smethod_24(object object_5)
	{
		return ((Control)object_5).get_ClientRectangle();
	}

	internal static object smethod_25(object object_5, Rectangle rectangle_0, Rectangle rectangle_1)
	{
		return smethod_2(object_5, rectangle_0, rectangle_1);
	}

	internal static void smethod_26(object object_5, object object_6)
	{
		((PictureBox)object_5).set_Image((Image)object_6);
	}

	internal static void smethod_27(object object_5)
	{
		((Control)object_5).Refresh();
	}

	internal static object smethod_28(object object_5, Rectangle rectangle_0, Color color_1)
	{
		return smethod_1(object_5, rectangle_0, color_1);
	}

	internal static void smethod_29()
	{
		smethod_6();
	}

	internal static int smethod_30(object object_5)
	{
		return Conversions.ToInteger((string)object_5);
	}

	internal static int smethod_31(object object_5, object object_6, bool bool_0)
	{
		return Operators.CompareString((string)object_5, (string)object_6, bool_0);
	}

	internal static int smethod_32(object object_5)
	{
		return ((Control)object_5).get_Left();
	}

	internal static void smethod_33(object object_5, int int_0)
	{
		((Control)object_5).set_Left(int_0);
	}

	internal static int smethod_34(object object_5)
	{
		return ((Control)object_5).get_Top();
	}

	internal static void smethod_35(object object_5, int int_0)
	{
		((Control)object_5).set_Top(int_0);
	}

	internal static int smethod_36(object object_5)
	{
		return ((Control)object_5).get_Width();
	}

	internal static void smethod_37(object object_5, int int_0)
	{
		((Control)object_5).set_Width(int_0);
	}

	internal static int smethod_38(object object_5)
	{
		return ((Control)object_5).get_Height();
	}

	internal static void smethod_39(object object_5, int int_0)
	{
		((Control)object_5).set_Height(int_0);
	}

	internal static void smethod_40(object object_5)
	{
		ProjectData.SetProjectError((Exception)object_5);
	}

	internal static void smethod_41()
	{
		ProjectData.ClearProjectError();
	}

	internal static object smethod_42(object object_5, object object_6)
	{
		return (string?)object_5 + (string?)object_6;
	}

	internal static object smethod_43(object object_5)
	{
		return ((StringBuilder)object_5).ToString();
	}

	internal static object smethod_44(object object_5, object object_6)
	{
		return ((string)object_5).Trim((char[]?)object_6);
	}

	internal static object smethod_45(object object_5)
	{
		return ((Exception)object_5).ToString();
	}

	internal static MsgBoxResult smethod_46(object object_5, MsgBoxStyle msgBoxStyle_0, object object_6)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return Interaction.MsgBox(object_5, msgBoxStyle_0, object_6);
	}

	internal static object smethod_47(int int_0)
	{
		return Convert.ToString(int_0);
	}

	internal static Point smethod_48(object object_5)
	{
		return ((Form)object_5).get_Location();
	}

	internal static void smethod_49(object object_5)
	{
		((Image)object_5).Dispose();
	}

	internal static object smethod_50()
	{
		return Application.get_OpenForms();
	}

	internal static object smethod_51(object object_5)
	{
		return ((ReadOnlyCollectionBase)object_5).GetEnumerator();
	}

	internal static object smethod_52(object object_5)
	{
		return ((IEnumerator)object_5).Current;
	}

	internal static object smethod_53(object object_5)
	{
		return ((Form)object_5).get_Text();
	}

	internal static bool smethod_54(object object_5)
	{
		return ((IEnumerator)object_5).MoveNext();
	}
}
