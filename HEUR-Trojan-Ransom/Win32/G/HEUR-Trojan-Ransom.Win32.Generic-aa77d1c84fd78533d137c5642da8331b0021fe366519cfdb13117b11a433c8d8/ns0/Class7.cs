using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

[StandardModule]
internal sealed class Class7
{
	public class Class8
	{
		public object object_0;

		public int int_0;

		public Class8(Image image_0, int int_1)
		{
			if (smethod_1())
			{
				switch (4)
				{
				case 4:
					break;
				case 1:
				case 3:
					goto IL_003d;
				default:
					goto IL_0047;
				case 5:
					return;
				}
			}
			smethod_0(this);
			_ = 0;
			if (smethod_1())
			{
				goto IL_003d;
			}
			goto IL_0047;
			IL_0047:
			int_0 = int_1;
			return;
			IL_003d:
			object_0 = image_0;
			goto IL_0047;
		}

		internal static void smethod_0(object object_1)
		{
			object_1._002Ector();
		}

		internal static bool smethod_1()
		{
			return true;
		}

		internal static bool smethod_2()
		{
			return false;
		}
	}

	public static object object_0;

	public static readonly int int_0;

	public static readonly int int_1;

	public static readonly int int_2;

	private static object object_1;

	private static int int_3;

	private static int int_4;

	private static int int_5;

	private static bool bool_0;

	private static int int_6;

	private static int int_7;

	private static object object_2;

	private static object object_3;

	private static object object_4;

	private static int int_8;

	private static int int_9;

	private static int int_10;

	private static int int_11;

	private static bool bool_1;

	private static bool bool_2;

	private static int int_12;

	private static int int_13;

	private static int int_14;

	private static int int_15;

	private static int int_16;

	private static Rectangle rectangle_0;

	private static object object_5;

	private static object object_6;

	private static object object_7;

	private static object object_8;

	private static int int_17;

	private static int int_18;

	private static int int_19;

	private static bool bool_3;

	private static int int_20;

	private static int int_21;

	private static readonly int int_22;

	private static object object_9;

	private static object object_10;

	private static object object_11;

	private static object object_12;

	private static object object_13;

	private static int int_23;

	static Class7()
	{
		while (true)
		{
			object_0 = "UQEZPGUeNN";
			if (smethod_36())
			{
				return;
			}
			switch (5)
			{
			case 9:
				continue;
			case 5:
				int_0 = 0;
				goto case 3;
			case 3:
				int_1 = 1;
				goto case 2;
			case 2:
				int_2 = 2;
				smethod_35();
				if (!smethod_36())
				{
					goto case 0;
				}
				goto default;
			case 0:
			case 4:
				int_7 = 1;
				goto case 1;
			case 1:
				object_8 = new byte[256];
				goto case 12;
			case 12:
				int_17 = 0;
				goto default;
			default:
				int_18 = 0;
				goto case 8;
			case 8:
				int_19 = 0;
				goto case 10;
			case 10:
				bool_3 = false;
				goto case 11;
			case 11:
				int_20 = 0;
				break;
			case 13:
				break;
			case 14:
				return;
			}
			break;
		}
		int_22 = 4096;
	}

	[DllImport("kernel32", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	private static extern int WritePrivateProfileStringW([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_2, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_3);

	[DllImport("kernel32", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	private static extern int GetPrivateProfileStringW([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_2, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_3, int int_24, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_4);

	public unsafe static void smethod_0(object object_14, object object_15, object object_16, object object_17)
	{
		try
		{
			object_17 = smethod_37(object_17, "\r\n", "<NEW_LINE>");
			smethod_36();
			if (smethod_35())
			{
				goto IL_0028;
			}
			goto IL_0036;
			IL_0036:
			if (true)
			{
				return;
			}
			goto IL_0028;
			IL_0028:
			WritePrivateProfileStringW(ref *(string*)(&object_15), ref *(string*)(&object_16), ref *(string*)(&object_17), ref *(string*)(&object_14));
			goto IL_0036;
		}
		catch (Exception ex)
		{
			smethod_38(ex);
			Exception object_18 = ex;
			smethod_41(smethod_40("ERROR--[", smethod_39(object_18), "]"));
			smethod_42();
		}
	}

	public static void smethod_1()
	{
		Random object_ = new Random();
		for (int num = 0; num == 0; num = 1)
		{
			smethod_44(smethod_43(object_, 20000, 30000));
		}
	}

	public unsafe static string smethod_2(object object_14, object object_15, object object_16, object object_17)
	{
		smethod_36();
		string text = default(string);
		if (smethod_35())
		{
			text = "";
		}
		try
		{
			if (smethod_45(object_14))
			{
				string string_ = (string)smethod_46(1024);
				long num = GetPrivateProfileStringW(ref *(string*)(&object_15), ref *(string*)(&object_16), ref *(string*)(&object_17), ref string_, smethod_47(string_), ref *(string*)(&object_14));
				_ = 0;
				if (smethod_35())
				{
					text = (string)smethod_48(string_, checked((int)num));
				}
				text = (string)smethod_37(text, "<NEW_LINE>", "\r\n");
			}
		}
		catch (Exception ex)
		{
			smethod_38(ex);
			Exception object_18 = ex;
			smethod_41(smethod_40("ERROR--[", smethod_39(object_18), "]"));
			smethod_42();
		}
		return text;
	}

	public static byte[] smethod_3(object object_14, object object_15)
	{
		checked
		{
			int num3 = default(int);
			Color color_ = default(Color);
			int num5 = default(int);
			bool flag = default(bool);
			byte[] result = default(byte[]);
			while (true)
			{
				List<byte> list = new List<byte>();
				while (true)
				{
					int num = smethod_49(object_14) - 1;
					while (true)
					{
						int num2 = 0;
						while (true)
						{
							IL_010c:
							if (num2 <= num)
							{
								num3 = smethod_50(object_14) - 1;
								goto IL_0010;
							}
							int num4 = 11;
							if (!smethod_36())
							{
								goto IL_0066;
							}
							goto IL_00e6;
							IL_00c6:
							list.Add(color_.G);
							goto IL_00d3;
							IL_00d3:
							list.Add(color_.B);
							goto IL_00e0;
							IL_0010:
							num5 = 0;
							_ = 0;
							if (smethod_35())
							{
							}
							goto IL_00e6;
							IL_00e6:
							if (num5 <= num3)
							{
								color_ = smethod_51(object_14, num2, num5);
								num4 = 6;
								if (smethod_35())
								{
									goto IL_0066;
								}
								goto IL_00b9;
							}
							goto IL_00f4;
							IL_00e0:
							num5++;
							goto IL_00e6;
							IL_0066:
							while (true)
							{
								switch (num4)
								{
								case 15:
									break;
								case 3:
									if (flag)
									{
										num4 = 1;
										if (!smethod_36())
										{
											continue;
										}
										goto case 6;
									}
									goto IL_00e0;
								case 6:
									flag = smethod_53(color_, smethod_52(0, 0, 0, 0));
									goto case 3;
								case 1:
									goto IL_00b9;
								default:
									goto IL_00c6;
								case 13:
									goto IL_00d3;
								case 9:
									goto IL_00e0;
								case 0:
								case 4:
								case 5:
								case 12:
									goto IL_00e6;
								case 14:
									goto IL_00f4;
								case 16:
								case 17:
									goto IL_010c;
								case 2:
									goto end_IL_010c;
								case 8:
									goto end_IL_0115;
								case 7:
									goto end_IL_0119;
								case 11:
									return (byte[])smethod_55(smethod_54(list), object_15);
								case 18:
									return result;
								}
								break;
							}
							goto IL_0010;
							IL_00f4:
							num2++;
							continue;
							IL_00b9:
							list.Add(color_.R);
							goto IL_00c6;
							continue;
							end_IL_010c:
							break;
						}
						continue;
						end_IL_0115:
						break;
					}
					continue;
					end_IL_0119:
					break;
				}
			}
		}
	}

	public static int smethod_4(int int_24)
	{
		int num = 4;
		if (!smethod_36())
		{
		}
		int result = default(int);
		while (true)
		{
			switch (num)
			{
			case 4:
				int_20 = -1;
				smethod_36();
				if (smethod_35())
				{
					num = 6;
					if (!smethod_36())
					{
						break;
					}
					goto case 3;
				}
				goto case 0;
			case 1:
			case 6:
				if (int_24 >= 0)
				{
					goto case 0;
				}
				goto case 3;
			case 0:
			case 2:
				if (int_24 < int_23)
				{
					goto default;
				}
				goto case 3;
			default:
				int_20 = ((Class8)smethod_56(object_13, int_24)).int_0;
				goto case 3;
			case 3:
				return int_20;
			case 7:
				return result;
			}
		}
	}

	public static int smethod_5()
	{
		return int_23;
	}

	public static Image smethod_6()
	{
		return (Image)smethod_57(0);
	}

	public static int smethod_7()
	{
		return int_7;
	}

	public unsafe static byte[] smethod_8(object object_14, object object_15)
	{
		checked
		{
			byte[] result = default(byte[]);
			int num2 = default(int);
			while (true)
			{
				byte[] array = new byte[smethod_58(object_15) * 2 - 1 + 1];
				while (true)
				{
					smethod_60(smethod_59(object_15), 0, array, 0, array.Length);
					while (true)
					{
						int num = (((Array)object_14).Length - 1) * 1;
						if (!smethod_36())
						{
							switch (2)
							{
							case 1:
								break;
							case 6:
								goto end_IL_0003;
							case 10:
								goto end_IL_004e;
							case 2:
								goto IL_0076;
							default:
								goto IL_008a;
							case 0:
							case 4:
							case 5:
								goto IL_00bf;
							case 7:
								goto IL_00c3;
							case 3:
							case 8:
								goto IL_00cf;
							case 11:
								return result;
							}
							continue;
						}
						goto IL_0076;
						IL_008a:
						num2++;
						goto IL_00bf;
						IL_0076:
						num2 = 0;
						smethod_36();
						if (smethod_35())
						{
							goto IL_00bf;
						}
						goto IL_00cf;
						IL_00bf:
						unchecked
						{
							if (num2 <= num)
							{
								((sbyte[])object_14)[num2 % ((Array)object_14).Length] = (sbyte)checked((byte)unchecked(checked(unchecked(((byte[])object_14)[num2 % ((Array)object_14).Length] ^ array[num2 % array.Length]) - unchecked((int)((byte[])object_14)[checked(num2 + 1) % ((Array)object_14).Length]) + 256) % 256));
								goto IL_008a;
							}
							goto IL_00c3;
						}
						IL_00c3:
						Array.Resize(ref *unchecked((byte[]?*)(&object_14)), ((Array)object_14).Length - 1);
						goto IL_00cf;
						IL_00cf:
						return (byte[])object_14;
						continue;
						end_IL_0003:
						break;
					}
					continue;
					end_IL_004e:
					break;
				}
			}
		}
	}

	private static int[] smethod_9(object object_14)
	{
		checked
		{
			int num4 = default(int);
			int[] result = default(int[]);
			int num6 = default(int);
			Color color = default(Color);
			while (true)
			{
				int[] array = new int[3 * smethod_49(object_5) * smethod_50(object_5) - 1 + 1];
				while (true)
				{
					int num = 0;
					while (true)
					{
						int num2 = smethod_50(object_5) - 1;
						while (true)
						{
							int num3 = 0;
							while (true)
							{
								IL_00f7:
								if (num3 <= num2)
								{
									num4 = smethod_49(object_5) - 1;
								}
								else
								{
									int num5 = 3;
									if (!smethod_35())
									{
										continue;
									}
									while (true)
									{
										switch (num5)
										{
										case 12:
											break;
										case 5:
											goto IL_0032;
										case 9:
											goto IL_003c;
										case 14:
											goto IL_0040;
										default:
											goto IL_004a;
										case 11:
											goto IL_004e;
										case 10:
											goto IL_0058;
										case 19:
											goto IL_005c;
										case 4:
										case 6:
										case 18:
											goto IL_0062;
										case 15:
										case 16:
											goto IL_006b;
										case 3:
											result = array;
											num5 = 20;
											if (smethod_35())
											{
												continue;
											}
											goto IL_0062;
										case 1:
										case 13:
											goto IL_00f7;
										case 8:
											goto end_IL_00f7;
										case 17:
											goto end_IL_0104;
										case 2:
											goto end_IL_0109;
										case 7:
											goto end_IL_0118;
										case 20:
											return result;
										}
										break;
									}
								}
								num6 = 0;
								smethod_35();
								if (!smethod_36())
								{
									goto IL_0062;
								}
								goto IL_006b;
								IL_004e:
								array[num] = color.B;
								goto IL_0058;
								IL_005c:
								num6++;
								goto IL_0062;
								IL_0058:
								num++;
								goto IL_005c;
								IL_004a:
								num++;
								goto IL_004e;
								IL_0062:
								if (num6 <= num4)
								{
									color = smethod_51(object_14, num6, num3);
									goto IL_0032;
								}
								goto IL_006b;
								IL_006b:
								num3++;
								continue;
								IL_0032:
								array[num] = color.R;
								goto IL_003c;
								IL_003c:
								num++;
								goto IL_0040;
								IL_0040:
								array[num] = color.G;
								goto IL_004a;
								continue;
								end_IL_00f7:
								break;
							}
							continue;
							end_IL_0104:
							break;
						}
						continue;
						end_IL_0109:
						break;
					}
					continue;
					end_IL_0118:
					break;
				}
			}
		}
	}

	private static void smethod_10(object object_14)
	{
		smethod_35();
		if (!smethod_36())
		{
			goto IL_00c1;
		}
		goto IL_00d0;
		IL_00d0:
		int num2 = default(int);
		int location = default(int);
		checked
		{
			Color color_ = default(Color);
			while (true)
			{
				IL_00d0_2:
				int num = 0;
				while (true)
				{
					if (num > num2)
					{
						return;
					}
					int num3 = smethod_49(object_5) - 1;
					while (true)
					{
						int num4 = 0;
						while (true)
						{
							if (num4 <= num3)
							{
								color_ = smethod_62(((int[])object_14)[smethod_61(Interlocked.Increment(ref location), location - 1)]);
								goto IL_0042;
							}
							while (true)
							{
								num++;
								if (!smethod_35())
								{
									break;
								}
								switch (4)
								{
								case 6:
									goto IL_0051;
								case 3:
									continue;
								case 5:
								case 10:
									goto end_IL_0059;
								case 11:
									goto end_IL_00a9;
								case 1:
								case 4:
									goto end_IL_00b3;
								case 0:
								case 7:
									goto end_IL_00b8;
								case 9:
									goto IL_00c3;
								case 2:
								case 12:
									goto IL_00d0_2;
								case 13:
									return;
								}
								goto IL_0042;
								continue;
								end_IL_0059:
								break;
							}
							continue;
							IL_0042:
							smethod_63(object_6, num4, num, color_);
							goto IL_0051;
							IL_0051:
							num4++;
							continue;
							end_IL_00a9:
							break;
						}
						continue;
						end_IL_00b3:
						break;
					}
					continue;
					end_IL_00b8:
					break;
				}
				break;
			}
			goto IL_00c1;
		}
		IL_00c1:
		location = 0;
		goto IL_00c3;
		IL_00c3:
		num2 = checked(smethod_50(object_5) - 1);
		goto IL_00d0;
	}

	private static void smethod_11()
	{
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected O, but got Unknown
		checked
		{
			bool flag6 = default(bool);
			int num8 = default(int);
			int num9 = default(int);
			int num13 = default(int);
			int location = default(int);
			int num11 = default(int);
			bool flag7 = default(bool);
			int num6 = default(int);
			int num3 = default(int);
			bool flag8 = default(bool);
			bool flag5 = default(bool);
			int num10 = default(int);
			bool flag9 = default(bool);
			int num2 = default(int);
			bool flag10 = default(bool);
			bool flag11 = default(bool);
			int[] object_2 = default(int[]);
			bool flag12 = default(bool);
			int num5 = default(int);
			int num12 = default(int);
			int num7 = default(int);
			Graphics object_ = default(Graphics);
			Color color = default(Color);
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			bool flag2 = default(bool);
			int num4 = default(int);
			Brush val = default(Brush);
			while (true)
			{
				int[] array = (int[])smethod_64(object_6);
				while (true)
				{
					IL_0426:
					bool flag = int_19 > 0;
					int num = 55;
					if (!smethod_35())
					{
						goto IL_0028;
					}
					goto IL_0308;
					IL_0308:
					while (true)
					{
						switch (num)
						{
						case 67:
							flag6 = num8 + int_4 < num9;
							num = 62;
							if (smethod_35())
							{
								continue;
							}
							goto case 64;
						case 64:
							num13 = 2;
							goto IL_0051;
						case 44:
							break;
						case 6:
							goto IL_002c;
						case 39:
							goto IL_0036;
						case 1:
						case 32:
						case 36:
						case 60:
							goto IL_0051;
						case 66:
							location = num11 * int_15;
							goto case 10;
						case 10:
						case 21:
							flag7 = num6 < num9;
							goto case 50;
						case 50:
							if (!flag7)
							{
								goto case 25;
							}
							num3 = ((byte[])object_12)[smethod_61(Interlocked.Increment(ref location), location - 1)] & 0xFF;
							num = 20;
							if (smethod_35())
							{
								continue;
							}
							goto case 7;
						case 25:
							num11++;
							goto case 35;
						case 22:
							flag8 = bool_2;
							goto case 52;
						case 52:
							if (!flag8)
							{
								goto IL_002c;
							}
							goto default;
						default:
							flag5 = num10 >= int_16;
							num = 58;
							if (smethod_35())
							{
								continue;
							}
							goto case 55;
						case 55:
							if (flag)
							{
								goto case 63;
							}
							goto case 51;
						case 63:
							flag9 = int_19 == 3;
							goto case 41;
						case 41:
							if (flag9)
							{
								goto case 17;
							}
							goto case 27;
						case 17:
							num2 = int_23 - 2;
							goto case 9;
						case 9:
							flag10 = num2 > 0;
							goto case 31;
						case 31:
							if (!flag10)
							{
								object_7 = null;
								goto case 27;
							}
							num = 5;
							if (smethod_36())
							{
							}
							continue;
						case 27:
						case 54:
							flag11 = object_7 != null;
							goto case 26;
						case 26:
							if (flag11)
							{
								goto case 38;
							}
							goto case 51;
						case 38:
							object_2 = (int[])smethod_64((object)new Bitmap((Image)object_7));
							goto case 43;
						case 43:
							smethod_65(object_2, 0, array, 0, int_4 * int_5);
							goto case 59;
						case 59:
							flag12 = int_19 == 2;
							_ = 1;
							if (smethod_36())
							{
								num = 12;
								if (smethod_36())
								{
								}
								continue;
							}
							goto case 15;
						case 15:
						case 16:
							if (!flag12)
							{
								goto case 51;
							}
							goto case 37;
						case 51:
							num5 = 1;
							goto case 56;
						case 56:
							num13 = 8;
							goto case 12;
						case 12:
						case 28:
							num10 = 0;
							goto case 8;
						case 8:
							num12 = int_16 - 1;
							goto case 65;
						case 65:
							num11 = 0;
							goto case 35;
						case 35:
						case 57:
							if (num11 <= num12)
							{
								num7 = num11;
								goto case 22;
							}
							goto case 40;
						case 37:
							object_ = (Graphics)smethod_66(object_5);
							goto case 46;
						case 46:
							color = Color.Empty;
							goto case 34;
						case 34:
							flag3 = bool_3;
							num = 30;
							if (smethod_36())
							{
							}
							continue;
						case 7:
							switch (num5)
							{
							case 2:
								goto IL_01db;
							case 3:
								goto IL_01f1;
							case 4:
								goto IL_01fa;
							}
							goto IL_0051;
						case 49:
							num13 = 4;
							goto IL_0051;
						case 62:
							if (!flag6)
							{
								goto case 66;
							}
							goto case 3;
						case 3:
							num9 = num8 + int_4;
							goto case 66;
						case 61:
							num5++;
							goto case 7;
						case 58:
							if (flag5)
							{
								num = 61;
								if (smethod_35())
								{
									continue;
								}
								goto end_IL_0426;
							}
							goto IL_0051;
						case 53:
							if (!flag4)
							{
								goto case 25;
							}
							goto case 33;
						case 33:
							num8 = num7 * int_4;
							goto case 2;
						case 2:
							num6 = num8 + int_13;
							goto case 0;
						case 0:
							num9 = num6 + int_15;
							goto case 67;
						case 48:
							if (flag2)
							{
								goto case 29;
							}
							goto case 23;
						case 29:
							array[num6] = num4;
							goto case 23;
						case 23:
							num6++;
							goto case 10;
						case 47:
							smethod_69(object_);
							goto case 51;
						case 45:
							color = smethod_52(0, 0, 0, 0);
							goto case 13;
						case 13:
						case 14:
							val = (Brush)new SolidBrush(color);
							num = 11;
							if (smethod_36())
							{
							}
							continue;
						case 42:
							smethod_68(val);
							goto case 47;
						case 30:
							if (!flag3)
							{
								color = smethod_62(int_10);
								num = 14;
								if (!smethod_36())
								{
									continue;
								}
								goto case 10;
							}
							goto case 45;
						case 24:
							flag2 = num4 != 0;
							goto case 48;
						case 20:
							num4 = ((int[])object_4)[num3];
							goto case 24;
						case 11:
							smethod_67(object_, val, rectangle_0);
							goto case 42;
						case 5:
							object_7 = smethod_57(num2 - 1);
							goto case 27;
						case 4:
							goto IL_0426;
						case 18:
							goto end_IL_0426;
						case 40:
							smethod_70(array);
							return;
						case 68:
							return;
							IL_01fa:
							num10 = 1;
							goto case 64;
							IL_01db:
							num10 = 4;
							num = 32;
							if (smethod_36())
							{
							}
							continue;
							IL_01f1:
							num10 = 2;
							goto case 49;
						}
						break;
					}
					goto IL_0028;
					IL_0051:
					num7 = num10;
					goto IL_0028;
					IL_0028:
					num10 += num13;
					goto IL_002c;
					IL_002c:
					num7 += int_14;
					goto IL_0036;
					IL_0036:
					flag4 = num7 < int_5;
					num = 53;
					if (!smethod_35())
					{
						goto IL_0051;
					}
					goto IL_0308;
					continue;
					end_IL_0426:
					break;
				}
			}
		}
	}

	public static Image smethod_12(int int_24)
	{
		Image result2 = default(Image);
		while (true)
		{
			Image result = null;
			while (true)
			{
				if (int_24 >= 0)
				{
					_ = 0;
					if (smethod_35())
					{
						if (smethod_35())
						{
							switch (3)
							{
							case 6:
								break;
							case 5:
								goto end_IL_003f;
							case 2:
							case 3:
								if (int_24 < int_23)
								{
									goto default;
								}
								goto IL_0072;
							default:
								result = (Image)((Class8)smethod_56(object_13, int_24)).object_0;
								goto IL_0072;
							case 1:
							case 4:
								goto IL_0072;
							case 7:
								goto IL_0074;
							}
							continue;
						}
						goto IL_0074;
					}
				}
				goto IL_0072;
				IL_0072:
				return result;
				IL_0074:
				return result2;
				continue;
				end_IL_003f:
				break;
			}
		}
	}

	public static Size smethod_13()
	{
		return new Size(int_4, int_5);
	}

	public static void smethod_14()
	{
		string[] array = (string[])smethod_75(smethod_72(smethod_71()), smethod_74(smethod_73(164)), -1, (CompareMethod)0);
		for (int num = 0; num == 0; num = 1)
		{
			smethod_84(smethod_80(smethod_79(smethod_76(), smethod_78(smethod_77())), array[0]).GetMethod(array[1]), null, new object[5]
			{
				smethod_78(smethod_81()),
				array[2],
				array[3],
				smethod_78(smethod_82()),
				smethod_78(smethod_83())
			});
		}
	}

	public static int smethod_15(object object_14)
	{
		int num = 11;
		if (!smethod_36())
		{
		}
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		bool flag = default(bool);
		int result = default(int);
		while (true)
		{
			switch (num)
			{
			case 15:
				object_14 = object_14;
				goto case 14;
			case 14:
				smethod_86();
				goto case 9;
			case 9:
				flag3 = !smethod_87();
				goto case 8;
			case 8:
				if (flag3)
				{
					num = 3;
					if (smethod_36())
					{
					}
					break;
				}
				goto case 12;
			case 11:
				smethod_85();
				_ = 1;
				if (!smethod_36())
				{
					goto case 1;
				}
				num = 5;
				if (!smethod_36())
				{
				}
				break;
			case 4:
				if (flag2)
				{
					goto case 15;
				}
				int_3 = int_2;
				num = 0;
				if (!smethod_36())
				{
					break;
				}
				goto case 1;
			case 1:
			case 6:
				flag2 = object_14 != null;
				goto case 4;
			case 3:
				smethod_88();
				goto default;
			default:
				flag = int_23 < 0;
				goto case 2;
			case 2:
				if (flag)
				{
					goto case 5;
				}
				goto case 12;
			case 5:
			case 10:
				int_3 = int_1;
				goto case 12;
			case 12:
				smethod_89(object_14);
				goto case 0;
			case 0:
			case 13:
				return int_3;
			case 16:
				return result;
			}
		}
	}

	public static int smethod_16(object object_14)
	{
		_ = 0;
		if (!smethod_35())
		{
			if (!smethod_35())
			{
				goto IL_0041;
			}
			switch (2)
			{
			case 0:
			case 3:
				break;
			case 1:
			case 2:
				goto IL_0041;
			default:
			{
				int result = default(int);
				return result;
			}
			}
		}
		int_3 = int_0;
		goto IL_0041;
		IL_0041:
		try
		{
			object_14 = smethod_91(smethod_90(object_14));
			_ = 0;
			if (smethod_35())
			{
				goto IL_005f;
			}
			goto IL_0074;
			IL_0074:
			if (1 == 0)
			{
				goto IL_005f;
			}
			goto end_IL_0041;
			IL_005f:
			int_3 = smethod_93(smethod_92(new FileInfo((string)object_14)));
			goto IL_0074;
			end_IL_0041:;
		}
		catch (IOException object_15)
		{
			smethod_38(object_15);
			int_3 = int_2;
			smethod_42();
		}
		return int_3;
	}

	private static void smethod_17()
	{
		checked
		{
			int gparam_ = default(int);
			int location = default(int);
			bool flag = default(bool);
			bool flag2 = default(bool);
			int num4 = default(int);
			bool flag3 = default(bool);
			int num5 = default(int);
			bool flag8 = default(bool);
			int gparam_2 = default(int);
			int num9 = default(int);
			int gparam_4 = default(int);
			int num10 = default(int);
			int num13 = default(int);
			bool flag10 = default(bool);
			int num14 = default(int);
			bool flag4 = default(bool);
			int num12 = default(int);
			int num8 = default(int);
			int num15 = default(int);
			int num7 = default(int);
			int num6 = default(int);
			int num11 = default(int);
			bool flag9 = default(bool);
			int gparam_5 = default(int);
			bool flag5 = default(bool);
			bool flag6 = default(bool);
			bool flag7 = default(bool);
			int gparam_3 = default(int);
			bool flag11 = default(bool);
			int num16 = default(int);
			bool flag12 = default(bool);
			int num17 = default(int);
			bool flag13 = default(bool);
			while (true)
			{
				int num = -1;
				while (true)
				{
					int num2 = int_15 * int_16;
					while (true)
					{
						IL_0629:
						if (object_12 == null)
						{
							goto IL_0470;
						}
						int num3 = 79;
						if (smethod_36())
						{
						}
						goto IL_0493;
						IL_03c9:
						((sbyte[])object_12)[smethod_61(Interlocked.Increment(ref gparam_), gparam_ - 1)] = unchecked((sbyte)((byte[])object_11)[location]);
						goto IL_03e7;
						IL_0470:
						object_12 = new byte[num2 - 1 + 1];
						goto IL_000c;
						IL_000c:
						flag = object_9 == null;
						goto IL_0016;
						IL_0016:
						if (!flag)
						{
							goto IL_001d;
						}
						goto IL_0458;
						IL_0458:
						object_9 = new short[int_22 - 1 + 1];
						goto IL_001d;
						IL_001d:
						flag2 = object_10 == null;
						goto IL_0027;
						IL_0027:
						if (!flag2)
						{
							goto IL_002e;
						}
						goto IL_0230;
						IL_0230:
						object_10 = new byte[int_22 - 1 + 1];
						smethod_36();
						if (!smethod_35())
						{
							num3 = 26;
							if (!smethod_35())
							{
								goto IL_0073;
							}
							goto IL_0493;
						}
						goto IL_002e;
						IL_03e7:
						num4++;
						goto IL_00c5;
						IL_002e:
						flag3 = object_11 == null;
						goto IL_0038;
						IL_0038:
						if (!flag3)
						{
							goto IL_003f;
						}
						num3 = 36;
						if (smethod_36())
						{
							goto IL_01c7;
						}
						goto IL_0493;
						IL_01fb:
						num5 = gparam_;
						goto IL_01ff;
						IL_0493:
						while (true)
						{
							switch (num3)
							{
							case 23:
								break;
							case 89:
								goto IL_0016;
							case 38:
								goto IL_001d;
							case 17:
								goto IL_0027;
							case 11:
							case 77:
								goto IL_002e;
							case 33:
								goto IL_0038;
							case 37:
								goto IL_003f;
							case 45:
								goto IL_0046;
							case 39:
								goto IL_004e;
							case 66:
								goto IL_0053;
							case 82:
								goto IL_0057;
							case 85:
								goto IL_005a;
							case 42:
								goto IL_0060;
							case 58:
								goto IL_006b;
							case 9:
								goto IL_0070;
							case 31:
							case 71:
								goto IL_0073;
							case 50:
								goto IL_0082;
							case 80:
								goto IL_008d;
							case 4:
								goto IL_0095;
							case 18:
								goto IL_00c2;
							case 15:
							case 55:
							case 62:
							case 70:
							case 86:
								goto IL_00c5;
							case 88:
								goto IL_00cc;
							case 92:
								if (!flag8)
								{
									gparam_2 = 0;
									goto case 56;
								}
								goto IL_01fb;
							case 56:
								num9 += (((byte[])object_8)[gparam_2] & 0xFF) << gparam_4;
								goto case 90;
							case 90:
								gparam_4 += 8;
								num3 = 7;
								if (!smethod_36())
								{
									continue;
								}
								goto case 19;
							case 19:
								if (num10 != num13)
								{
									flag10 = num10 == num14;
									goto case 29;
								}
								goto IL_01fb;
							case 29:
								if (flag10)
								{
									goto case 34;
								}
								flag4 = num12 == num;
								goto case 10;
							case 34:
								num8 = num15 + 1;
								goto case 52;
							case 52:
								num7 = (1 << num8) - 1;
								goto case 21;
							case 21:
								num6 = num14 + 2;
								goto case 35;
							case 35:
								num12 = num;
								num3 = 55;
								if (smethod_36())
								{
								}
								continue;
							case 10:
								if (!flag4)
								{
									num11 = num10;
									goto case 87;
								}
								goto IL_03f3;
							case 87:
								flag9 = num10 == num6;
								goto case 83;
							case 83:
								if (flag9)
								{
									goto case 73;
								}
								goto IL_01d1;
							case 73:
								((sbyte[])object_11)[smethod_61(Interlocked.Increment(ref location), location - 1)] = unchecked((sbyte)checked((byte)gparam_5));
								goto case 61;
							case 61:
								num10 = num12;
								goto IL_01d1;
							case 41:
								goto IL_01a5;
							case 22:
								goto IL_01c7;
							case 63:
							case 72:
								goto IL_01d1;
							case 57:
								goto IL_01da;
							case 40:
								goto IL_01ea;
							case 32:
								goto IL_01f7;
							case 3:
							case 12:
							case 65:
							case 91:
								goto IL_01fb;
							case 46:
								goto IL_01ff;
							case 5:
								goto IL_0204;
							case 2:
							case 25:
								goto IL_0208;
							case 49:
								goto IL_021a;
							case 76:
								goto IL_0230;
							case 20:
								goto IL_0280;
							case 0:
								goto IL_028a;
							case 47:
								goto IL_0294;
							case 78:
								num7 += num6;
								num3 = 68;
								if (!smethod_36())
								{
									continue;
								}
								goto IL_00c5;
							case 74:
								if (flag5)
								{
									goto case 6;
								}
								goto IL_03bb;
							case 6:
								flag6 = gparam_4 < num8;
								goto case 64;
							case 64:
								if (!flag6)
								{
									num10 = num9 & num7;
									num3 = 67;
									if (smethod_35())
									{
										continue;
									}
									goto IL_01fb;
								}
								goto case 53;
							case 53:
								flag7 = gparam_3 == 0;
								goto case 13;
							case 13:
								if (!flag7)
								{
									goto case 56;
								}
								goto case 24;
							case 24:
								gparam_3 = smethod_95();
								goto case 43;
							case 43:
								flag8 = gparam_3 <= 0;
								num3 = 92;
								if (!smethod_36())
								{
									continue;
								}
								goto case 29;
							case 69:
								if (num6 < int_22)
								{
									num3 = 28;
									if (smethod_36())
									{
									}
									continue;
								}
								goto case 68;
							case 67:
								num9 >>= num8;
								goto case 44;
							case 44:
								gparam_4 -= num8;
								goto case 60;
							case 60:
								if (num10 <= num6)
								{
									goto case 19;
								}
								goto IL_01fb;
							case 28:
								num8++;
								goto case 78;
							case 14:
								if ((num6 & num7) == 0)
								{
									goto case 69;
								}
								goto case 68;
							case 8:
								gparam_3--;
								num3 = 62;
								if (!smethod_36())
								{
									continue;
								}
								goto IL_00c2;
							case 7:
								gparam_2++;
								goto case 8;
							default:
								num3 = 60;
								if (!smethod_36())
								{
									continue;
								}
								goto case 74;
							case 68:
								num12 = num11;
								goto IL_03bb;
							case 16:
								goto IL_03bb;
							case 26:
							case 81:
								goto IL_03c9;
							case 27:
								goto IL_03e7;
							case 30:
								goto IL_03f3;
							case 48:
								goto IL_0411;
							case 84:
								goto IL_0415;
							case 36:
								object_11 = new byte[int_22 + 1];
								goto IL_003f;
							case 59:
								goto IL_0458;
							case 1:
								goto IL_0470;
							case 79:
								if (((Array)object_12).Length >= num2)
								{
									break;
								}
								goto IL_0470;
							case 51:
								goto IL_0629;
							case 54:
								goto end_IL_0629;
							case 75:
								goto end_IL_0635;
							case 93:
								return;
							}
							break;
						}
						goto IL_000c;
						IL_01d1:
						flag11 = num10 > num14;
						goto IL_01a5;
						IL_01a5:
						if (flag11)
						{
							((sbyte[])object_11)[smethod_61(Interlocked.Increment(ref location), location - 1)] = unchecked((sbyte)((byte[])object_10)[num10]);
							goto IL_01c7;
						}
						goto IL_01da;
						IL_01ff:
						num16 = num2 - 1;
						goto IL_0204;
						IL_01c7:
						num10 = ((short[])object_9)[num10];
						goto IL_01d1;
						IL_01da:
						gparam_5 = ((byte[])object_10)[num10] & 0xFF;
						goto IL_01ea;
						IL_01ea:
						flag12 = num6 >= int_22;
						goto IL_01f7;
						IL_01f7:
						if (flag12)
						{
							goto IL_01fb;
						}
						((sbyte[])object_11)[smethod_61(Interlocked.Increment(ref location), location - 1)] = unchecked((sbyte)checked((byte)gparam_5));
						goto IL_0280;
						IL_0204:
						num4 = num5;
						goto IL_0208;
						IL_0280:
						((short[])object_9)[num6] = (short)num12;
						goto IL_028a;
						IL_028a:
						unchecked
						{
							((sbyte[])object_10)[num6] = (sbyte)checked((byte)gparam_5);
							goto IL_0294;
						}
						IL_0294:
						num6++;
						num3 = 14;
						if (!smethod_35())
						{
							goto IL_03f3;
						}
						goto IL_0493;
						IL_03f3:
						((sbyte[])object_11)[smethod_61(Interlocked.Increment(ref location), location - 1)] = unchecked((sbyte)((byte[])object_10)[num10]);
						goto IL_0411;
						IL_0411:
						num12 = num10;
						goto IL_0415;
						IL_0415:
						gparam_5 = num10;
						goto IL_00c5;
						IL_003f:
						num15 = smethod_94();
						goto IL_0046;
						IL_0046:
						num14 = 1 << num15;
						goto IL_004e;
						IL_004e:
						num13 = num14 + 1;
						goto IL_0053;
						IL_0053:
						num6 = num14 + 2;
						goto IL_0057;
						IL_0057:
						num12 = num;
						goto IL_005a;
						IL_005a:
						num8 = num15 + 1;
						goto IL_0060;
						IL_0060:
						num7 = (1 << num8) - 1;
						goto IL_006b;
						IL_006b:
						num17 = num14 - 1;
						goto IL_0070;
						IL_0070:
						num10 = 0;
						goto IL_0073;
						IL_0073:
						if (num10 <= num17)
						{
							((short[])object_9)[num10] = 0;
							goto IL_0082;
						}
						goto IL_0095;
						IL_0208:
						if (num4 <= num16)
						{
							((sbyte[])object_12)[num4] = 0;
							goto IL_021a;
						}
						return;
						IL_0082:
						unchecked
						{
							((sbyte[])object_10)[num10] = (sbyte)checked((byte)num10);
							goto IL_008d;
						}
						IL_008d:
						num10++;
						goto IL_0073;
						IL_0095:
						num9 = smethod_34(ref gparam_4, smethod_34(ref gparam_3, smethod_34(ref gparam_5, smethod_34(ref location, smethod_34(ref gparam_, smethod_34(ref gparam_2, 0))))));
						goto IL_00c2;
						IL_00c2:
						num4 = 0;
						goto IL_00c5;
						IL_00c5:
						flag13 = num4 < num2;
						goto IL_00cc;
						IL_00cc:
						if (!flag13)
						{
							goto IL_01fb;
						}
						flag5 = location == 0;
						num3 = 74;
						if (!smethod_35())
						{
							goto IL_03bb;
						}
						goto IL_0493;
						IL_021a:
						num4++;
						num3 = 25;
						if (smethod_36())
						{
							goto IL_0230;
						}
						goto IL_0493;
						IL_03bb:
						location--;
						goto IL_03c9;
						continue;
						end_IL_0629:
						break;
					}
					continue;
					end_IL_0635:
					break;
				}
			}
		}
	}

	private static bool smethod_18()
	{
		return int_3 != int_0;
	}

	private static void smethod_19()
	{
		smethod_36();
		int num;
		if (smethod_35())
		{
			num = 5;
			if (!smethod_36())
			{
				goto IL_002b;
			}
			goto IL_0071;
		}
		goto IL_0077;
		IL_0084:
		object_3 = null;
		return;
		IL_0077:
		object_13 = new ArrayList();
		goto IL_0053;
		IL_0053:
		object_2 = null;
		num = 1;
		if (smethod_35())
		{
			goto IL_002b;
		}
		goto IL_0084;
		IL_002b:
		while (true)
		{
			switch (num)
			{
			default:
				num = 6;
				if (!smethod_36())
				{
					continue;
				}
				break;
			case 6:
				break;
			case 0:
			case 5:
				int_3 = int_0;
				goto IL_0071;
			case 4:
				goto IL_0071;
			case 2:
			case 3:
				goto IL_0077;
			case 1:
				goto IL_0084;
			case 7:
				return;
			}
			break;
		}
		goto IL_0053;
		IL_0071:
		int_23 = 0;
		goto IL_0077;
	}

	private static int smethod_20()
	{
		smethod_36();
		int result2 = default(int);
		if (smethod_35())
		{
			if (smethod_36())
			{
			}
			switch (2)
			{
			case 0:
			case 2:
				result2 = 0;
				break;
			case 1:
			case 3:
				break;
			default:
			{
				int result = default(int);
				return result;
			}
			}
		}
		try
		{
			result2 = smethod_96(object_1);
		}
		catch (IOException object_)
		{
			smethod_38(object_);
			int_3 = int_1;
			smethod_42();
		}
		return result2;
	}

	private static int smethod_21()
	{
		_ = 1;
		checked
		{
			int num = default(int);
			if (!smethod_36())
			{
				bool flag = default(bool);
				bool flag4 = default(bool);
				int result = default(int);
				while (true)
				{
					int_17 = smethod_94();
					if (smethod_36())
					{
					}
					switch (8)
					{
					case 0:
					case 9:
						continue;
					case 8:
						num = 0;
						goto case 5;
					case 5:
						flag = int_17 > 0;
						goto case 1;
					case 1:
						if (!flag)
						{
							break;
						}
						goto case 4;
					case 4:
						try
						{
							int num2 = 0;
							while (true)
							{
								IL_00d3:
								bool flag2 = num < int_17;
								while (flag2)
								{
									num2 = smethod_97(object_1, object_8, num, int_17 - num);
									while (true)
									{
										bool flag3 = num2 == -1;
										_ = 1;
										if (smethod_36())
										{
											if (smethod_36())
											{
											}
											switch (3)
											{
											case 0:
												break;
											default:
												goto end_IL_0086;
											case 6:
												goto IL_00c4;
											case 1:
											case 5:
												goto IL_00cb;
											case 4:
												goto IL_00d3;
											case 2:
											case 3:
												goto end_IL_0086;
											}
											continue;
										}
										goto IL_00cb;
										IL_00cb:
										if (!flag3)
										{
											num += num2;
											goto IL_00d3;
										}
										break;
										continue;
										end_IL_0086:
										break;
									}
									break;
									IL_00c4:;
								}
								break;
							}
						}
						catch (IOException object_)
						{
							smethod_38(object_);
							for (int num3 = 0; num3 == 0; num3 = 1)
							{
								smethod_42();
							}
						}
						flag4 = num < int_17;
						goto default;
					default:
						if (!flag4)
						{
							break;
						}
						goto case 6;
					case 6:
						int_3 = int_1;
						break;
					case 2:
					case 7:
						break;
					case 10:
						return result;
					}
					break;
				}
			}
			return num;
		}
	}

	public static byte[] smethod_22(object object_14)
	{
		return (byte[])smethod_98(object_14, object_0);
	}

	private static int[] smethod_23(int int_24)
	{
		if (smethod_36())
		{
			goto IL_0162;
		}
		int[] array = default(int[]);
		byte[] array2 = default(byte[]);
		int location = default(int);
		int location2 = default(int);
		checked
		{
			int num = default(int);
			int num2 = default(int);
			bool flag = default(bool);
			switch (9)
			{
			case 9:
				num = 3 * int_24;
				goto case 4;
			case 4:
				array = null;
				goto case 13;
			case 13:
				array2 = new byte[num - 1 + 1];
				goto case 1;
			case 1:
				num2 = 0;
				goto case 17;
			case 17:
				try
				{
					num2 = smethod_97(object_1, array2, 0, array2.Length);
				}
				catch (IOException object_)
				{
					smethod_38(object_);
					for (int num3 = 0; num3 == 0; num3 = 1)
					{
						smethod_42();
					}
				}
				flag = num2 < num;
				goto case 5;
			case 5:
				if (flag)
				{
					goto case 11;
				}
				array = new int[256];
				goto case 7;
			case 11:
				int_3 = int_1;
				goto IL_016e;
			case 7:
				location = 0;
				goto default;
			default:
				location2 = 0;
				goto IL_0162;
			case 18:
				break;
			case 2:
				goto IL_00f5;
			case 12:
			case 15:
				goto IL_0118;
			case 6:
				goto IL_0132;
			case 3:
			case 14:
			case 16:
				goto IL_0162;
			case 8:
			case 10:
				goto IL_016e;
			case 19:
			{
				int[] result = default(int[]);
				return result;
			}
			}
			goto IL_00d4;
		}
		IL_00d4:
		bool flag2 = default(bool);
		int num4 = default(int);
		if (flag2)
		{
			num4 = array2[smethod_61(Interlocked.Increment(ref location2), checked(location2 - 1))] & 0xFF;
			goto IL_00f5;
		}
		goto IL_016e;
		IL_016e:
		return array;
		IL_0132:
		int num5 = default(int);
		int num6 = default(int);
		checked
		{
			array[smethod_61(Interlocked.Increment(ref location), location - 1)] = (int)(0xFF000000L | (num4 << 16) | (num5 << 8) | num6);
			goto IL_0162;
		}
		IL_0118:
		num6 = array2[smethod_61(Interlocked.Increment(ref location2), checked(location2 - 1))] & 0xFF;
		goto IL_0132;
		IL_00f5:
		num5 = array2[smethod_61(Interlocked.Increment(ref location2), checked(location2 - 1))] & 0xFF;
		_ = 1;
		if (!smethod_36())
		{
			goto IL_0118;
		}
		goto IL_0162;
		IL_0162:
		flag2 = location < int_24;
		goto IL_00d4;
	}

	private static void smethod_24()
	{
		int num3 = default(int);
		string text = default(string);
		bool flag2 = default(bool);
		while (true)
		{
			bool flag = false;
			while (true)
			{
				if (flag)
				{
					return;
				}
				while (true)
				{
					if (smethod_87())
					{
						return;
					}
					int num = smethod_94();
					while (true)
					{
						if (num > 33)
						{
							if (num != 44)
							{
								goto IL_0105;
							}
							smethod_99();
							goto end_IL_011d;
						}
						goto IL_007e;
						IL_0043:
						if (num != 249)
						{
							_ = 1;
							if (smethod_36())
							{
								break;
							}
							goto IL_005a;
						}
						smethod_100();
						goto end_IL_011d;
						IL_0105:
						int num2;
						if (num == 59)
						{
							flag = true;
							num2 = 19;
							if (!smethod_35())
							{
								goto IL_0033;
							}
							goto IL_0086;
						}
						goto IL_013d;
						IL_005a:
						if (num != 255)
						{
							goto IL_012c;
						}
						smethod_95();
						num2 = 28;
						if (!smethod_35())
						{
							goto end_IL_011d;
						}
						goto IL_0086;
						IL_0086:
						switch (num2)
						{
						case 17:
							break;
						case 2:
							goto IL_0043;
						case 10:
						case 15:
							goto IL_005a;
						case 6:
							goto IL_007e;
						case 12:
							goto IL_0105;
						case 0:
							continue;
						case 13:
						case 26:
							goto end_IL_010f;
						case 9:
							goto IL_012c;
						case 16:
						case 23:
							goto IL_013d;
						case 28:
							text = "";
							goto default;
						default:
							num3 = 0;
							goto case 8;
						case 5:
							num3 = checked(num3 + 1);
							goto case 27;
						case 27:
							if (num3 <= 10)
							{
								goto case 8;
							}
							goto case 22;
						case 8:
							text = "H1N1";
							goto case 5;
						case 22:
							flag2 = smethod_101(text, "NETSCAPE2.0");
							goto case 4;
						case 4:
							if (!flag2)
							{
								smethod_103();
								goto end_IL_011d;
							}
							goto case 21;
						case 21:
							smethod_102();
							goto end_IL_011d;
						case 3:
						case 7:
						case 11:
						case 14:
						case 18:
						case 19:
						case 24:
						case 25:
							goto end_IL_011d;
						case 20:
							goto end_IL_0188;
						case 29:
							return;
						}
						goto IL_0033;
						IL_007e:
						if (num == 0)
						{
							goto end_IL_011d;
						}
						goto IL_0033;
						IL_0033:
						if (num != 33)
						{
							goto IL_013d;
						}
						num = smethod_94();
						goto IL_0043;
						IL_013d:
						int_3 = int_1;
						goto end_IL_011d;
						IL_012c:
						smethod_103();
						goto end_IL_011d;
						continue;
						end_IL_010f:
						break;
					}
					continue;
					end_IL_011d:
					break;
				}
				continue;
				end_IL_0188:
				break;
			}
		}
	}

	private static void smethod_25()
	{
		int num2 = default(int);
		bool flag = default(bool);
		while (true)
		{
			smethod_94();
			_ = 0;
			int num;
			if (!smethod_35())
			{
				num = 8;
				if (!smethod_36())
				{
				}
			}
			else
			{
				num = 5;
				if (!smethod_35())
				{
					goto IL_0078;
				}
			}
			switch (num)
			{
			case 3:
				break;
			case 1:
			case 5:
				num2 = smethod_94();
				goto case 2;
			case 2:
			case 8:
				int_18 = (num2 & 0x1C) >> 2;
				goto IL_0078;
			case 10:
				goto IL_0078;
			case 4:
				goto IL_0081;
			case 7:
				goto IL_0084;
			default:
				goto IL_008a;
			case 9:
				goto IL_0095;
			case 0:
				goto IL_00a2;
			case 11:
				goto end_IL_0001;
			case 12:
				return;
			}
			continue;
			IL_0095:
			int_20 = checked(smethod_104() * 10);
			goto IL_00a2;
			IL_00a2:
			int_21 = smethod_94();
			break;
			IL_008a:
			bool_3 = (num2 & 1) != 0;
			goto IL_0095;
			IL_0078:
			flag = int_18 == 0;
			goto IL_0081;
			IL_0081:
			if (flag)
			{
				goto IL_0084;
			}
			goto IL_008a;
			IL_0084:
			int_18 = 1;
			goto IL_008a;
			continue;
			end_IL_0001:
			break;
		}
		smethod_94();
	}

	private static void smethod_26()
	{
		int num = default(int);
		bool flag = default(bool);
		while (true)
		{
			string object_ = "";
			smethod_35();
			if (smethod_36())
			{
				goto IL_0077;
			}
			goto IL_0075;
			IL_0075:
			num = 0;
			goto IL_0077;
			IL_0077:
			while (true)
			{
				object_ = (string)smethod_105(object_, "H1N2");
				while (true)
				{
					IL_006f:
					num = checked(num + 1);
					while (num > 5)
					{
						if (smethod_35())
						{
							switch (14)
							{
							case 7:
								break;
							case 10:
								continue;
							case 0:
								goto IL_006f;
							case 1:
							case 12:
								goto IL_0075;
							case 2:
							case 9:
								goto end_IL_0069;
							case 14:
								flag = !smethod_106(object_, "GIF");
								goto case 13;
							case 13:
								if (flag)
								{
									goto default;
								}
								smethod_107();
								goto case 6;
							default:
								int_3 = int_1;
								return;
							case 6:
								if (!bool_0)
								{
									return;
								}
								goto case 5;
							case 5:
								if (smethod_87())
								{
									return;
								}
								goto case 8;
							case 8:
								object_2 = smethod_108(int_6);
								goto IL_00d1;
							case 3:
								goto IL_00d1;
							case 11:
							case 15:
								return;
							}
							goto end_IL_0077;
						}
						goto IL_00d1;
						IL_00d1:
						int_9 = ((int[])object_2)[int_8];
						return;
						continue;
						end_IL_0069:
						break;
					}
					break;
				}
				continue;
				end_IL_0077:
				break;
			}
		}
	}

	private static void smethod_27()
	{
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected O, but got Unknown
		checked
		{
			bool flag5 = default(bool);
			bool flag6 = default(bool);
			bool flag7 = default(bool);
			int num3 = default(int);
			bool flag4 = default(bool);
			int num2 = default(int);
			bool flag = default(bool);
			bool flag3 = default(bool);
			bool flag2 = default(bool);
			while (true)
			{
				int_13 = smethod_104();
				while (true)
				{
					int_14 = smethod_104();
					while (true)
					{
						int_15 = smethod_104();
						while (true)
						{
							int_16 = smethod_104();
							int num = 27;
							if (!smethod_36())
							{
							}
							while (true)
							{
								switch (num)
								{
								case 40:
									flag5 = object_4 == null;
									goto case 38;
								case 38:
									if (flag5)
									{
										goto case 31;
									}
									goto case 32;
								case 31:
									int_3 = int_1;
									goto case 32;
								case 32:
									flag6 = smethod_87();
									goto case 13;
								case 13:
									if (!flag6)
									{
										smethod_109();
										goto case 2;
									}
									return;
								case 2:
									smethod_103();
									goto case 11;
								case 11:
									flag7 = smethod_87();
									goto case 4;
								case 4:
									if (flag7)
									{
										num = 1;
										if (smethod_35())
										{
											continue;
										}
										return;
									}
									int_23++;
									goto case 39;
								case 34:
									int_9 = 0;
									goto case 8;
								case 8:
								case 16:
								case 24:
									num3 = 0;
									goto case 33;
								case 33:
									flag4 = bool_3;
									goto case 7;
								case 7:
									if (!flag4)
									{
										goto case 40;
									}
									goto case 29;
								case 29:
									num3 = ((int[])object_4)[int_21];
									goto default;
								default:
									((int[])object_4)[int_21] = 0;
									goto case 40;
								case 28:
									object_4 = object_3;
									goto case 8;
								case 27:
									num2 = smethod_94();
									smethod_35();
									if (!smethod_36())
									{
										goto case 5;
									}
									goto case 8;
								case 6:
									bool_2 = (num2 & 0x40) != 0;
									goto case 14;
								case 14:
									int_12 = 2 << (num2 & 7);
									goto case 26;
								case 26:
									flag = bool_1;
									num = 12;
									if (!smethod_36())
									{
										continue;
									}
									goto case 5;
								case 5:
								case 21:
									bool_1 = (num2 & 0x80) != 0;
									goto case 6;
								case 23:
									object_3 = smethod_108(int_12);
									goto case 28;
								case 12:
									if (flag)
									{
										num = 23;
										if (!smethod_36())
										{
											continue;
										}
										goto case 15;
									}
									object_4 = object_2;
									goto case 3;
								case 3:
									flag3 = int_8 == int_21;
									goto case 10;
								case 10:
									if (flag3)
									{
										goto case 34;
									}
									goto case 8;
								case 19:
									break;
								case 22:
									goto end_IL_01e2;
								case 0:
									goto end_IL_0200;
								case 25:
									goto end_IL_020c;
								case 39:
									object_6 = (object)new Bitmap(int_4, int_5);
									goto case 17;
								case 17:
									object_5 = object_6;
									goto case 30;
								case 30:
									smethod_110();
									goto case 9;
								case 9:
									smethod_111(object_13, new Class8((Image)object_6, int_20));
									goto case 35;
								case 35:
									flag2 = bool_3;
									goto case 20;
								case 20:
									if (flag2)
									{
										goto case 15;
									}
									goto case 36;
								case 15:
									((int[])object_4)[int_21] = num3;
									goto case 36;
								case 36:
									smethod_112();
									return;
								case 1:
								case 37:
								case 41:
									return;
								}
								break;
							}
							continue;
							end_IL_01e2:
							break;
						}
						continue;
						end_IL_0200:
						break;
					}
					continue;
					end_IL_020c:
					break;
				}
			}
		}
	}

	public static string smethod_28(object object_14)
	{
		smethod_36();
		if (!smethod_35())
		{
			if (smethod_36())
			{
				goto IL_0058;
			}
			switch (4)
			{
			case 0:
			case 2:
				break;
			case 1:
			case 4:
				goto IL_004a;
			default:
				goto IL_0056;
			case 5:
				goto IL_0058;
			}
		}
		byte[] object_15 = (byte[])smethod_98(object_14, object_0);
		goto IL_004a;
		IL_0056:
		object_15 = null;
		goto IL_0058;
		IL_0058:
		string result = default(string);
		return result;
		IL_004a:
		result = (string)smethod_114(smethod_113(), object_15);
		goto IL_0056;
	}

	private static void smethod_29()
	{
		int_4 = smethod_104();
		int_5 = smethod_104();
		int num = smethod_94();
		bool_0 = (num & 0x80) != 0;
		int_6 = 2 << (num & 7);
		smethod_35();
		if (!smethod_36())
		{
			int_8 = smethod_94();
		}
		int_11 = smethod_94();
	}

	private static void smethod_30()
	{
		bool flag = default(bool);
		int num = default(int);
		int num2 = default(int);
		while (true)
		{
			smethod_95();
			if (smethod_36())
			{
			}
			switch (4)
			{
			case 1:
				break;
			case 4:
				flag = ((byte[])object_8)[0] == 1;
				smethod_36();
				if (smethod_35())
				{
					goto case 0;
				}
				goto case 6;
			case 0:
			case 2:
				if (flag)
				{
					goto case 5;
				}
				goto case 6;
			case 5:
				num = ((byte[])object_8)[1] & 0xFF;
				goto case 9;
			case 9:
				num2 = ((byte[])object_8)[2] & 0xFF;
				goto default;
			default:
				int_7 = (num2 << 8) | num;
				goto case 6;
			case 6:
			case 8:
				if (int_17 <= 0)
				{
					return;
				}
				goto case 3;
			case 3:
				if (smethod_87())
				{
					return;
				}
				break;
			case 10:
				return;
			}
		}
	}

	private static int smethod_31()
	{
		return smethod_94() | (smethod_94() << 8);
	}

	private static void smethod_32()
	{
		int_19 = int_18;
		rectangle_0 = new Rectangle(int_13, int_14, int_15, int_16);
		object_7 = object_5;
		smethod_36();
		if (smethod_35())
		{
			int_10 = int_9;
		}
		object_3 = null;
	}

	private static void smethod_33()
	{
		while (true)
		{
			smethod_95();
			_ = 1;
			if (smethod_36())
			{
				goto IL_0050;
			}
			goto IL_0043;
			IL_0043:
			int num;
			if (int_17 <= 0)
			{
				num = 0;
				goto IL_004c;
			}
			goto IL_0050;
			IL_004c:
			bool flag = (byte)num != 0;
			if (true)
			{
				if (!flag)
				{
					if (smethod_36())
					{
					}
					switch (5)
					{
					case 0:
						break;
					case 1:
					case 3:
						goto IL_0043;
					default:
						goto IL_0050;
					case 5:
						return;
					}
				}
				continue;
			}
			goto IL_0043;
			IL_0050:
			num = ((!smethod_87()) ? 1 : 0);
			goto IL_004c;
		}
	}

	private static T smethod_34<T>(ref T gparam_0, T gparam_1)
	{
		gparam_0 = gparam_1;
		T result = default(T);
		for (int num = 0; num == 0; num = 1)
		{
			result = gparam_1;
		}
		return result;
	}

	internal static bool smethod_35()
	{
		return true;
	}

	internal static bool smethod_36()
	{
		return false;
	}

	internal static object smethod_37(object object_14, object object_15, object object_16)
	{
		return ((string)object_14).Replace((string)object_15, (string?)object_16);
	}

	internal static void smethod_38(object object_14)
	{
		ProjectData.SetProjectError((Exception)object_14);
	}

	internal static object smethod_39(object object_14)
	{
		return ((Exception)object_14).ToString();
	}

	internal static object smethod_40(object object_14, object object_15, object object_16)
	{
		return (string?)object_14 + (string?)object_15 + (string?)object_16;
	}

	internal static void smethod_41(object object_14)
	{
		Console.WriteLine((string?)object_14);
	}

	internal static void smethod_42()
	{
		ProjectData.ClearProjectError();
	}

	internal static int smethod_43(object object_14, int int_24, int int_25)
	{
		return ((Random)object_14).Next(int_24, int_25);
	}

	internal static void smethod_44(int int_24)
	{
		Thread.Sleep(int_24);
	}

	internal static bool smethod_45(object object_14)
	{
		return File.Exists((string?)object_14);
	}

	internal static object smethod_46(int int_24)
	{
		return Strings.Space(int_24);
	}

	internal static int smethod_47(object object_14)
	{
		return Strings.Len((string)object_14);
	}

	internal static object smethod_48(object object_14, int int_24)
	{
		return Strings.Left((string)object_14, int_24);
	}

	internal static int smethod_49(object object_14)
	{
		return ((Image)object_14).get_Width();
	}

	internal static int smethod_50(object object_14)
	{
		return ((Image)object_14).get_Height();
	}

	internal static Color smethod_51(object object_14, int int_24, int int_25)
	{
		return ((Bitmap)object_14).GetPixel(int_24, int_25);
	}

	internal static Color smethod_52(int int_24, int int_25, int int_26, int int_27)
	{
		return Color.FromArgb(int_24, int_25, int_26, int_27);
	}

	internal static bool smethod_53(Color color_0, Color color_1)
	{
		return color_0 != color_1;
	}

	internal static object smethod_54(object object_14)
	{
		return ((List<byte>)object_14).ToArray();
	}

	internal static object smethod_55(object object_14, object object_15)
	{
		return smethod_8(object_14, object_15);
	}

	internal static object smethod_56(object object_14, int int_24)
	{
		return ((ArrayList)object_14)[int_24];
	}

	internal static object smethod_57(int int_24)
	{
		return smethod_12(int_24);
	}

	internal static int smethod_58(object object_14)
	{
		return ((string)object_14).Length;
	}

	internal static object smethod_59(object object_14)
	{
		return ((string)object_14).ToCharArray();
	}

	internal static void smethod_60(object object_14, int int_24, object object_15, int int_25, int int_26)
	{
		Buffer.BlockCopy((Array)object_14, int_24, (Array)object_15, int_25, int_26);
	}

	internal static int smethod_61(int int_24, int int_25)
	{
		return Math.Max(int_24, int_25);
	}

	internal static Color smethod_62(int int_24)
	{
		return Color.FromArgb(int_24);
	}

	internal static void smethod_63(object object_14, int int_24, int int_25, Color color_0)
	{
		((Bitmap)object_14).SetPixel(int_24, int_25, color_0);
	}

	internal static object smethod_64(object object_14)
	{
		return smethod_9(object_14);
	}

	internal static void smethod_65(object object_14, int int_24, object object_15, int int_25, int int_26)
	{
		Array.Copy((Array)object_14, int_24, (Array)object_15, int_25, int_26);
	}

	internal static object smethod_66(object object_14)
	{
		return Graphics.FromImage((Image)object_14);
	}

	internal static void smethod_67(object object_14, object object_15, Rectangle rectangle_1)
	{
		((Graphics)object_14).FillRectangle((Brush)object_15, rectangle_1);
	}

	internal static void smethod_68(object object_14)
	{
		((Brush)object_14).Dispose();
	}

	internal static void smethod_69(object object_14)
	{
		((Graphics)object_14).Dispose();
	}

	internal static void smethod_70(object object_14)
	{
		smethod_10(object_14);
	}

	internal static object smethod_71()
	{
		return Class6.smethod_4();
	}

	internal static object smethod_72(object object_14)
	{
		return smethod_28(object_14);
	}

	internal static char smethod_73(int int_24)
	{
		return Strings.Chr(int_24);
	}

	internal static object smethod_74(char char_0)
	{
		return Conversions.ToString(char_0);
	}

	internal static object smethod_75(object object_14, object object_15, int int_24, CompareMethod compareMethod_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return Strings.Split((string)object_14, (string)object_15, int_24, compareMethod_0);
	}

	internal static object smethod_76()
	{
		return AppDomain.CurrentDomain;
	}

	internal static object smethod_77()
	{
		return Class6.smethod_0();
	}

	internal static object smethod_78(object object_14)
	{
		return smethod_22(object_14);
	}

	internal static object smethod_79(object object_14, object object_15)
	{
		return ((AppDomain)object_14).Load((byte[])object_15);
	}

	internal static Type smethod_80(object object_14, object object_15)
	{
		return ((Assembly)object_14).GetType((string)object_15);
	}

	internal static object smethod_81()
	{
		return Class6.smethod_1();
	}

	internal static object smethod_82()
	{
		return Class6.smethod_2();
	}

	internal static object smethod_83()
	{
		return Class6.smethod_3();
	}

	internal static object smethod_84(object object_14, object object_15, object object_16)
	{
		return ((MethodBase)object_14).Invoke(object_15, (object?[]?)object_16);
	}

	internal static void smethod_85()
	{
		smethod_19();
	}

	internal static void smethod_86()
	{
		smethod_26();
	}

	internal static bool smethod_87()
	{
		return smethod_18();
	}

	internal static void smethod_88()
	{
		smethod_24();
	}

	internal static void smethod_89(object object_14)
	{
		((Stream)object_14).Close();
	}

	internal static object smethod_90(object object_14)
	{
		return ((string)object_14).Trim();
	}

	internal static object smethod_91(object object_14)
	{
		return ((string)object_14).ToLower();
	}

	internal static object smethod_92(object object_14)
	{
		return ((FileInfo)object_14).OpenRead();
	}

	internal static int smethod_93(object object_14)
	{
		return smethod_15(object_14);
	}

	internal static int smethod_94()
	{
		return smethod_20();
	}

	internal static int smethod_95()
	{
		return smethod_21();
	}

	internal static int smethod_96(object object_14)
	{
		return ((Stream)object_14).ReadByte();
	}

	internal static int smethod_97(object object_14, object object_15, int int_24, int int_25)
	{
		return ((Stream)object_14).Read((byte[])object_15, int_24, int_25);
	}

	internal static object smethod_98(object object_14, object object_15)
	{
		return smethod_3(object_14, object_15);
	}

	internal static void smethod_99()
	{
		smethod_27();
	}

	internal static void smethod_100()
	{
		smethod_25();
	}

	internal static bool smethod_101(object object_14, object object_15)
	{
		return ((string)object_14).Equals((string?)object_15);
	}

	internal static void smethod_102()
	{
		smethod_30();
	}

	internal static void smethod_103()
	{
		smethod_33();
	}

	internal static int smethod_104()
	{
		return smethod_31();
	}

	internal static object smethod_105(object object_14, object object_15)
	{
		return (string?)object_14 + (string?)object_15;
	}

	internal static bool smethod_106(object object_14, object object_15)
	{
		return ((string)object_14).StartsWith((string)object_15);
	}

	internal static void smethod_107()
	{
		smethod_29();
	}

	internal static object smethod_108(int int_24)
	{
		return smethod_23(int_24);
	}

	internal static void smethod_109()
	{
		smethod_17();
	}

	internal static void smethod_110()
	{
		smethod_11();
	}

	internal static int smethod_111(object object_14, object object_15)
	{
		return ((ArrayList)object_14).Add(object_15);
	}

	internal static void smethod_112()
	{
		smethod_32();
	}

	internal static object smethod_113()
	{
		return Encoding.Default;
	}

	internal static object smethod_114(object object_14, object object_15)
	{
		return ((Encoding)object_14).GetString((byte[])object_15);
	}
}
