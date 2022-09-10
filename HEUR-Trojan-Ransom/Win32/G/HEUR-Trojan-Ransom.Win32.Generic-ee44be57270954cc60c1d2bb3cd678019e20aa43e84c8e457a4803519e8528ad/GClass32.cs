using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.Win32.SafeHandles;

public class GClass32 : IDisposable
{
	private enum Enum2 : byte
	{
		LEDs = 17,
		Type = 18,
		IR = 19,
		Status = 21,
		WriteMemory = 22,
		ReadMemory = 23,
		IR2 = 26
	}

	internal delegate bool Delegate0(string devicePath);

	private const int int_0 = 1406;

	private const int int_1 = 774;

	private const int int_2 = 22;

	private const int int_3 = 78643248;

	private const int int_4 = 78643200;

	private const int int_5 = 78643226;

	private const int int_6 = 78643251;

	private const int int_7 = 77857008;

	private const int int_8 = 77857019;

	private const int int_9 = 77857018;

	private const int int_10 = 77856800;

	private const int int_11 = 43;

	private const int int_12 = 24;

	private const float float_0 = 2.2046225f;

	private EventHandler<GEventArgs1> eventHandler_0;

	private EventHandler<GEventArgs0> eventHandler_1;

	private SafeFileHandle safeFileHandle_0;

	private FileStream fileStream_0;

	private readonly byte[] byte_0 = new byte[22];

	private byte[] byte_1;

	private int int_13;

	private short short_0;

	private readonly GClass31 gclass31_0 = new GClass31();

	private readonly AutoResetEvent autoResetEvent_0 = new AutoResetEvent(initialState: false);

	private readonly AutoResetEvent autoResetEvent_1 = new AutoResetEvent(initialState: false);

	private readonly AutoResetEvent autoResetEvent_2 = new AutoResetEvent(initialState: false);

	private bool bool_0;

	private string string_0 = string.Empty;

	private readonly Guid guid_0 = Guid.NewGuid();

	public GClass31 GClass31_0 => gclass31_0;

	public Guid Guid_0 => guid_0;

	public string String_0 => string_0;

	public event EventHandler<GEventArgs1> Event_0
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_0 = (EventHandler<GEventArgs1>)Delegate.Combine(eventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_0 = (EventHandler<GEventArgs1>)Delegate.Remove(eventHandler_0, value);
		}
	}

	public event EventHandler<GEventArgs0> Event_1
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_1 = (EventHandler<GEventArgs0>)Delegate.Combine(eventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_1 = (EventHandler<GEventArgs0>)Delegate.Remove(eventHandler_1, value);
		}
	}

	public GClass32()
	{
	}

	internal GClass32(string string_1)
	{
		while (true)
		{
			int num = -1580613160;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAF2E58F4u) % 3u)
				{
				case 1u:
					goto IL_005a;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_005a:
				string_0 = string_1;
				num = (int)(num2 * 1845811259) ^ -1721322158;
			}
		}
	}

	public void method_0()
	{
		if (string.IsNullOrEmpty(string_0))
		{
			while (true)
			{
				int num = -1461449739;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x816A0DF0u) % 4u)
					{
					case 1u:
						smethod_0(method_1);
						num = ((int)num2 * -992073504) ^ 0xBF3991B;
						continue;
					case 0u:
						break;
					case 3u:
						return;
					default:
						goto end_IL_004e;
					}
					break;
				}
				continue;
				end_IL_004e:
				break;
			}
		}
		method_2(string_0);
	}

	internal static void smethod_0(Delegate0 delegate0_0)
	{
		int num = 0;
		Class11.Struct3 struct3_ = default(Class11.Struct3);
		bool flag = default(bool);
		Class11.Struct2 struct2_ = default(Class11.Struct2);
		IntPtr intptr_ = default(IntPtr);
		Class11.Struct1 struct1_ = default(Class11.Struct1);
		uint uint_ = default(uint);
		SafeFileHandle safeFileHandle = default(SafeFileHandle);
		Guid guid = default(Guid);
		while (true)
		{
			int num2 = -800802199;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x95A7A33Au) % 22u)
				{
				case 21u:
				{
					int num11;
					int num12;
					if (struct3_.short_1 == 774)
					{
						num11 = -1971744982;
						num12 = -1971744982;
					}
					else
					{
						num11 = -1690383151;
						num12 = -1690383151;
					}
					num2 = num11 ^ ((int)num3 * -1534897656);
					continue;
				}
				case 20u:
				{
					flag = true;
					int num9;
					int num10;
					if (!delegate0_0(struct2_.string_0))
					{
						num9 = -2065066376;
						num10 = -2065066376;
					}
					else
					{
						num9 = -731870671;
						num10 = -731870671;
					}
					num2 = num9 ^ ((int)num3 * -1649845473);
					continue;
				}
				case 18u:
				{
					int num13;
					int num14;
					if (struct3_.short_0 != 1406)
					{
						num13 = -214148647;
						num14 = -214148647;
					}
					else
					{
						num13 = -1511751813;
						num14 = -1511751813;
					}
					num2 = num13 ^ ((int)num3 * -147889064);
					continue;
				}
				case 17u:
					Class11.SetupDiGetDeviceInterfaceDetail(intptr_, ref struct1_, IntPtr.Zero, 0u, out uint_, IntPtr.Zero);
					num2 = -757350771;
					continue;
				case 16u:
					struct3_.int_0 = Marshal.SizeOf((object)struct3_);
					num2 = ((int)num3 * -873541946) ^ 0x32862096;
					continue;
				case 15u:
				{
					int num7;
					int num8;
					if (!flag)
					{
						num7 = 1952857161;
						num8 = 1952857161;
					}
					else
					{
						num7 = 1375271977;
						num8 = 1375271977;
					}
					num2 = num7 ^ (int)(num3 * 901893300);
					continue;
				}
				case 14u:
					Class11.SetupDiDestroyDeviceInfoList(intptr_);
					num2 = -1935543057;
					continue;
				case 11u:
					safeFileHandle = Class11.CreateFile(struct2_.string_0, FileAccess.ReadWrite, FileShare.ReadWrite, IntPtr.Zero, FileMode.Open, Class11.Enum1.Overlapped, IntPtr.Zero);
					num2 = (int)(num3 * 35285095) ^ -907822300;
					continue;
				case 10u:
					num2 = (int)(num3 * 1516857451) ^ -1562240920;
					continue;
				case 9u:
					safeFileHandle.Close();
					num2 = -1080422786;
					continue;
				case 8u:
				{
					int num15;
					if (Class11.SetupDiEnumDeviceInterfaces(intptr_, IntPtr.Zero, ref guid, num, ref struct1_))
					{
						num2 = -1259462611;
						num15 = -1259462611;
					}
					else
					{
						num2 = -1579897712;
						num15 = -1579897712;
					}
					continue;
				}
				case 7u:
					struct3_ = default(Class11.Struct3);
					num2 = ((int)num3 * -349662902) ^ 0x5978A8E;
					continue;
				case 6u:
					Class11.HidD_GetHidGuid(out guid);
					intptr_ = Class11.SetupDiGetClassDevs(ref guid, null, IntPtr.Zero, 16u);
					struct1_ = default(Class11.Struct1);
					struct1_.int_0 = Marshal.SizeOf((object)struct1_);
					num2 = ((int)num3 * -117388566) ^ -2140051034;
					continue;
				case 5u:
					flag = false;
					num2 = (int)((num3 * 155265867) ^ 0x57493959);
					continue;
				case 4u:
					num2 = ((int)num3 * -1817077291) ^ 0x4FF185C9;
					continue;
				case 3u:
				{
					struct2_ = default(Class11.Struct2);
					struct2_.uint_0 = ((IntPtr.Size == 8) ? 8u : 5u);
					int num6;
					if (!Class11.SetupDiGetDeviceInterfaceDetail_1(intptr_, ref struct1_, ref struct2_, uint_, out uint_, IntPtr.Zero))
					{
						num2 = -112426102;
						num6 = -112426102;
					}
					else
					{
						num2 = -889688893;
						num6 = -889688893;
					}
					continue;
				}
				case 1u:
					num++;
					num2 = -1741638192;
					continue;
				case 0u:
				{
					int num4;
					int num5;
					if (!Class11.HidD_GetAttributes(safeFileHandle.DangerousGetHandle(), ref struct3_))
					{
						num4 = -124941303;
						num5 = -124941303;
					}
					else
					{
						num4 = -1503058806;
						num5 = -1503058806;
					}
					num2 = num4 ^ (int)(num3 * 1772359934);
					continue;
				}
				default:
					return;
				case 2u:
					break;
				case 12u:
					throw new GException1("SetupDiGetDeviceInterfaceDetail failed on index " + num);
				case 19u:
					throw new GException0("No Wiimotes found in HID device list.");
				case 13u:
					return;
				}
				break;
			}
		}
	}

	private bool method_1(string string_1)
	{
		string_0 = string_1;
		method_2(string_0);
		return false;
	}

	private void method_2(string string_1)
	{
		safeFileHandle_0 = Class11.CreateFile(string_1, FileAccess.ReadWrite, FileShare.ReadWrite, IntPtr.Zero, FileMode.Open, Class11.Enum1.Overlapped, IntPtr.Zero);
		Class11.Struct3 struct3_ = default(Class11.Struct3);
		while (true)
		{
			int num = 1949975402;
			while (true)
			{
				int num3;
				uint num2;
				switch ((num2 = (uint)num ^ 0x317099B4u) % 7u)
				{
				case 6u:
					fileStream_0 = new FileStream(safeFileHandle_0, FileAccess.ReadWrite, 22, isAsync: true);
					num = (int)((num2 * 1903705513) ^ 0x40BB568D);
					continue;
				case 5u:
					if (struct3_.short_0 == 1406)
					{
						num = (int)((num2 * 1490917482) ^ 0x25577B6C);
						continue;
					}
					goto IL_0159;
				case 4u:
					if (Class11.HidD_GetAttributes(safeFileHandle_0.DangerousGetHandle(), ref struct3_))
					{
						num = ((int)num2 * -1093558877) ^ -687382129;
						continue;
					}
					return;
				case 2u:
					struct3_ = default(Class11.Struct3);
					struct3_.int_0 = Marshal.SizeOf((object)struct3_);
					num = ((int)num2 * -1652170886) ^ 0x7D43AE6D;
					continue;
				case 1u:
					if (struct3_.short_1 == 774)
					{
						num = ((int)num2 * -687687369) ^ -1261067641;
						continue;
					}
					goto IL_0159;
				case 3u:
					break;
				default:
					{
						method_4();
						try
						{
							method_16();
						}
						catch
						{
							bool_0 = true;
							method_16();
						}
						method_22();
						goto IL_012f;
					}
					IL_0159:
					safeFileHandle_0.Close();
					num3 = 1975335165;
					goto IL_0134;
					IL_0134:
					switch ((num2 = (uint)num3 ^ 0x317099B4u) % 5u)
					{
					case 0u:
						break;
					default:
						return;
					case 4u:
						goto IL_0159;
					case 1u:
						return;
					case 2u:
						throw new GException1("Attempted to open a non-Wiimote device.");
					case 3u:
						return;
					}
					goto IL_012f;
					IL_012f:
					num3 = 905139569;
					goto IL_0134;
				}
				break;
			}
		}
	}

	public void method_3()
	{
		if (fileStream_0 != null)
		{
			goto IL_0017;
		}
		goto IL_0081;
		IL_0081:
		int num;
		int num2;
		if (safeFileHandle_0 == null)
		{
			num = 1539044352;
			num2 = 1539044352;
		}
		else
		{
			num = 800674394;
			num2 = 800674394;
		}
		goto IL_0050;
		IL_0050:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0x42D2F83u) % 5u)
			{
			case 4u:
				break;
			case 3u:
				safeFileHandle_0.Close();
				num = (int)(num3 * 167500354) ^ -275918862;
				continue;
			case 2u:
				fileStream_0.Close();
				num = (int)(num3 * 372549607) ^ -1422933361;
				continue;
			default:
				return;
			case 1u:
				goto IL_0081;
			case 0u:
				return;
			}
			break;
		}
		goto IL_0017;
		IL_0017:
		num = 1247551185;
		goto IL_0050;
	}

	private void method_4()
	{
		if (fileStream_0 == null)
		{
			return;
		}
		byte[] array = default(byte[]);
		while (true)
		{
			int num = 341820043;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x370F8289u) % 5u)
				{
				case 4u:
					array = new byte[22];
					num = (int)(num2 * 247856719) ^ -943931234;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!fileStream_0.CanRead)
					{
						num3 = -1707895232;
						num4 = -1707895232;
					}
					else
					{
						num3 = -620651855;
						num4 = -620651855;
					}
					num = num3 ^ (int)(num2 * 1053769426);
					continue;
				}
				case 0u:
					fileStream_0.BeginRead(array, 0, 22, method_5, array);
					num = ((int)num2 * -487732910) ^ 0x28F946B2;
					continue;
				default:
					return;
				case 3u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private void method_5(IAsyncResult iasyncResult_0)
	{
		byte[] byte_ = (byte[])iasyncResult_0.AsyncState;
		try
		{
			fileStream_0.EndRead(iasyncResult_0);
			while (true)
			{
				int num = -1309626111;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF8BAC624u) % 6u)
					{
					case 5u:
					{
						int num5;
						int num6;
						if (eventHandler_0 == null)
						{
							num5 = 1353172090;
							num6 = 1353172090;
						}
						else
						{
							num5 = 435614333;
							num6 = 435614333;
						}
						num = num5 ^ (int)(num2 * 1551352352);
						continue;
					}
					case 3u:
					{
						int num3;
						int num4;
						if (!method_6(byte_))
						{
							num3 = 1299960923;
							num4 = 1299960923;
						}
						else
						{
							num3 = 716799668;
							num4 = 716799668;
						}
						num = num3 ^ ((int)num2 * -893099859);
						continue;
					}
					case 2u:
						method_4();
						num = -1106085376;
						continue;
					case 1u:
						eventHandler_0(this, new GEventArgs1(gclass31_0));
						num = (int)((num2 * 1484584597) ^ 0x37E67C37);
						continue;
					default:
						return;
					case 4u:
						break;
					case 0u:
						return;
					}
					break;
				}
			}
		}
		catch (OperationCanceledException)
		{
		}
	}

	private bool method_6(byte[] byte_2)
	{
		GEnum11 gEnum = (GEnum11)byte_2[0];
		bool flag = default(bool);
		GEnum11 gEnum2 = default(GEnum11);
		while (true)
		{
			int num = 181816032;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4CC6CBBCu) % 40u)
				{
				case 38u:
					gclass31_0.LEDState.LED1 = (byte_2[3] & 0x10) != 0;
					num = ((int)num2 * -1359391800) ^ -1316050453;
					continue;
				case 37u:
					method_10(byte_2);
					num = (int)((num2 * 1466233082) ^ 0x579E1412);
					continue;
				case 36u:
					num = (int)(num2 * 1333218350) ^ -859051523;
					continue;
				case 35u:
					autoResetEvent_1.Set();
					num = 102647338;
					continue;
				case 34u:
					autoResetEvent_2.Set();
					num = 151912969;
					continue;
				case 33u:
					gclass31_0.LEDState.LED4 = (byte_2[3] & 0x80) != 0;
					num = (int)(num2 * 54500141) ^ -2004172732;
					continue;
				case 32u:
					num = (int)((num2 * 2106160108) ^ 0x58E7DB73);
					continue;
				case 31u:
					method_9(byte_2);
					num = 644629273;
					continue;
				case 30u:
					gclass31_0.Extension = flag;
					num = (int)(num2 * 1792757028) ^ -745442966;
					continue;
				case 29u:
					flag = (byte_2[3] & 2) != 0;
					num = ((int)num2 * -1570018490) ^ 0x55603C77;
					continue;
				case 28u:
					switch (gEnum2)
					{
					case GEnum11.OutputReportAck:
						break;
					default:
						goto IL_0133;
					case GEnum11.Status:
						goto IL_0145;
					case GEnum11.ReadData:
						goto IL_0186;
					}
					goto case 35u;
				case 10u:
					goto IL_0145;
				case 3u:
					goto IL_0186;
				case 27u:
				{
					int num8;
					int num9;
					if (gclass31_0.ExtensionType == GEnum9.BalanceBoard)
					{
						num8 = -1661227745;
						num9 = -1661227745;
					}
					else
					{
						num8 = -1095089971;
						num9 = -1095089971;
					}
					num = num8 ^ (int)(num2 * 608171299);
					continue;
				}
				case 26u:
					num = ((int)num2 * -620422662) ^ -385223858;
					continue;
				case 25u:
					method_10(byte_2);
					method_12(byte_2, 6);
					num = (int)(num2 * 2020585646) ^ -2127372744;
					continue;
				case 24u:
					eventHandler_1(this, new GEventArgs0(gclass31_0.ExtensionType, gclass31_0.Extension));
					num = (int)((num2 * 1799520167) ^ 0x5CD70FEE);
					continue;
				case 23u:
					method_4();
					method_7();
					num = ((int)num2 * -1899961795) ^ -441995613;
					continue;
				case 22u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = -1719807975;
						num7 = -1719807975;
					}
					else
					{
						num6 = -403198545;
						num7 = -403198545;
					}
					num = num6 ^ (int)(num2 * 1080397466);
					continue;
				}
				case 21u:
					num = ((int)num2 * -807083462) ^ 0x17DD3B28;
					continue;
				case 20u:
					goto IL_029b;
				case 19u:
					goto IL_02ac;
				case 18u:
					num = ((int)num2 * -1739975444) ^ 0x5D456492;
					continue;
				case 17u:
					gclass31_0.ExtensionType = GEnum9.None;
					num = 876547957;
					continue;
				case 16u:
					num = ((int)num2 * -799931594) ^ -238854534;
					continue;
				case 15u:
					gclass31_0.LEDState.LED2 = (byte_2[3] & 0x20) != 0;
					gclass31_0.LEDState.LED3 = (byte_2[3] & 0x40) != 0;
					num = (int)((num2 * 2113969943) ^ 0x1762AA44);
					continue;
				case 14u:
					num = (int)(num2 * 1409256055) ^ -2085850368;
					continue;
				case 13u:
				{
					int num4;
					int num5;
					if (gclass31_0.Extension == flag)
					{
						num4 = 1243437740;
						num5 = 1243437740;
					}
					else
					{
						num4 = 1972962680;
						num5 = 1972962680;
					}
					num = num4 ^ ((int)num2 * -377024038);
					continue;
				}
				case 12u:
					gEnum2 = gEnum;
					num = ((int)num2 * -652354522) ^ 0x6752E148;
					continue;
				case 11u:
					goto IL_03a1;
				case 9u:
					switch (gEnum2)
					{
					case GEnum11.IRExtensionAccel:
						break;
					case GEnum11.ExtensionAccel:
						goto IL_029b;
					case GEnum11.Buttons:
						goto IL_02ac;
					case GEnum11.IRAccel:
						goto IL_03a1;
					default:
						goto IL_03e2;
					case GEnum11.ButtonsAccel:
						goto IL_03f4;
					case GEnum11.ButtonsExtension:
						goto IL_0409;
					case (GEnum11)50:
					case (GEnum11)54:
						goto IL_0540;
					}
					goto case 31u;
				case 0u:
					goto IL_03f4;
				case 5u:
					goto IL_0409;
				case 8u:
					method_11(byte_2);
					num = ((int)num2 * -2076510283) ^ -1391360196;
					continue;
				case 4u:
					method_11(byte_2);
					num = (int)(num2 * 1001300531) ^ -1433444286;
					continue;
				case 2u:
					method_12(byte_2, 16);
					num = ((int)num2 * -1907751471) ^ 0x5E1A1B10;
					continue;
				case 1u:
				{
					int num3;
					if (eventHandler_1 == null)
					{
						num = 1303245230;
						num3 = 1303245230;
					}
					else
					{
						num = 935419303;
						num3 = 935419303;
					}
					continue;
				}
				case 39u:
					break;
				default:
					return true;
				case 7u:
					goto IL_0540;
					IL_0133:
					num = ((int)num2 * -1786719443) ^ 0x73137681;
					continue;
					IL_0540:
					return false;
					IL_0409:
					method_9(byte_2);
					method_12(byte_2, 3);
					num = 102647338;
					continue;
					IL_03f4:
					method_9(byte_2);
					method_10(byte_2);
					num = 1869954198;
					continue;
					IL_03e2:
					num = (int)((num2 * 67783587) ^ 0x1B47C027);
					continue;
					IL_03a1:
					method_9(byte_2);
					method_10(byte_2);
					num = 76258340;
					continue;
					IL_02ac:
					method_9(byte_2);
					num = 102647338;
					continue;
					IL_029b:
					method_9(byte_2);
					num = 1457234805;
					continue;
					IL_0186:
					method_9(byte_2);
					method_14(byte_2);
					num = 1386561306;
					continue;
					IL_0145:
					method_9(byte_2);
					gclass31_0.BatteryRaw = byte_2[6];
					gclass31_0.Battery = 4800f * ((float)(int)byte_2[6] / 48f) / 192f;
					num = 1183785970;
					continue;
				}
				break;
			}
		}
	}

	private void method_7()
	{
		method_28(77857008, 85);
		method_28(77857019, 0);
		byte[] array = default(byte[]);
		GEnum9 gEnum = default(GEnum9);
		GEnum9 extensionType = default(GEnum9);
		long num10 = default(long);
		while (true)
		{
			int num = -1024012260;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9308FE21u) % 58u)
				{
				case 56u:
					gclass31_0.BalanceBoardState.CalibrationInfo.Kg34.TopRight = (short)((array[20] << 8) | array[21]);
					num = (int)((num2 * 1834549174) ^ 0x742F8CA4);
					continue;
				case 55u:
					gclass31_0.Extension = false;
					gclass31_0.ExtensionType = GEnum9.None;
					num = -658993529;
					continue;
				case 53u:
					gclass31_0.NunchukState.CalibrationInfo.MidX = array[10];
					num = (int)(num2 * 1648599997) ^ -918955270;
					continue;
				case 52u:
					gclass31_0.ClassicControllerState.CalibrationInfo.MaxTriggerL = 31;
					num = ((int)num2 * -343135732) ^ 0x3E870A30;
					continue;
				case 51u:
				{
					int num8;
					int num9;
					if (gEnum != GEnum9.Nunchuk)
					{
						num8 = 732929592;
						num9 = 732929592;
					}
					else
					{
						num8 = 1537538524;
						num9 = 1537538524;
					}
					num = num8 ^ (int)(num2 * 1448836831);
					continue;
				}
				case 49u:
					gclass31_0.NunchukState.CalibrationInfo.AccelCalibration.Z0 = array[2];
					gclass31_0.NunchukState.CalibrationInfo.AccelCalibration.XG = array[4];
					num = ((int)num2 * -1997350083) ^ 0x3D234085;
					continue;
				case 48u:
					gclass31_0.ClassicControllerState.CalibrationInfo.MaxYL = (byte)(array[3] >> 2);
					gclass31_0.ClassicControllerState.CalibrationInfo.MinYL = (byte)(array[4] >> 2);
					gclass31_0.ClassicControllerState.CalibrationInfo.MidYL = (byte)(array[5] >> 2);
					num = ((int)num2 * -2036825153) ^ -2036256593;
					continue;
				case 47u:
					gclass31_0.ClassicControllerState.CalibrationInfo.MidYR = (byte)(array[11] >> 3);
					num = (int)(num2 * 328646585) ^ -563244297;
					continue;
				case 46u:
				{
					int num20;
					int num21;
					if (extensionType > GEnum9.Guitar)
					{
						num20 = -367296830;
						num21 = -367296830;
					}
					else
					{
						num20 = -1024449960;
						num21 = -1024449960;
					}
					num = num20 ^ ((int)num2 * -1480417343);
					continue;
				}
				case 45u:
					gclass31_0.ClassicControllerState.CalibrationInfo.MinXR = (byte)(array[7] >> 3);
					gclass31_0.ClassicControllerState.CalibrationInfo.MidXR = (byte)(array[8] >> 3);
					gclass31_0.ClassicControllerState.CalibrationInfo.MaxYR = (byte)(array[9] >> 3);
					num = ((int)num2 * -1968765750) ^ -829711630;
					continue;
				case 44u:
					gclass31_0.ClassicControllerState.CalibrationInfo.MaxXR = (byte)(array[6] >> 3);
					num = (int)((num2 * 1925838750) ^ 0x58357F34);
					continue;
				case 43u:
					gclass31_0.NunchukState.CalibrationInfo.AccelCalibration.X0 = array[0];
					num = (int)((num2 * 615474184) ^ 0x8FAE589);
					continue;
				case 42u:
				{
					int num28;
					int num29;
					if (gEnum <= GEnum9.Guitar)
					{
						num28 = -2070193944;
						num29 = -2070193944;
					}
					else
					{
						num28 = -491928147;
						num29 = -491928147;
					}
					num = num28 ^ ((int)num2 * -2122651863);
					continue;
				}
				case 41u:
					gclass31_0.BalanceBoardState.CalibrationInfo.Kg17.BottomRight = (short)((array[14] << 8) | array[15]);
					num = (int)(num2 * 292289323) ^ -402716049;
					continue;
				case 40u:
				{
					int num24;
					int num25;
					if (gEnum > GEnum9.Guitar)
					{
						num24 = 1315241019;
						num25 = 1315241019;
					}
					else
					{
						num24 = 755468568;
						num25 = 755468568;
					}
					num = num24 ^ (int)(num2 * 566818019);
					continue;
				}
				case 39u:
					gclass31_0.ClassicControllerState.CalibrationInfo.MinTriggerR = 0;
					num = ((int)num2 * -566809997) ^ 0x2CF41A43;
					continue;
				case 38u:
				{
					int num16;
					int num17;
					if (extensionType <= GEnum9.Guitar)
					{
						num16 = 2050993025;
						num17 = 2050993025;
					}
					else
					{
						num16 = 285480011;
						num17 = 285480011;
					}
					num = num16 ^ (int)(num2 * 613670213);
					continue;
				}
				case 37u:
				{
					int num12;
					int num13;
					if (extensionType < GEnum9.ClassicController)
					{
						num12 = 961095395;
						num13 = 961095395;
					}
					else
					{
						num12 = 1278268204;
						num13 = 1278268204;
					}
					num = num12 ^ (int)(num2 * 1446496057);
					continue;
				}
				case 36u:
				{
					int num4;
					int num5;
					if (extensionType == GEnum9.Nunchuk)
					{
						num4 = -268686648;
						num5 = -268686648;
					}
					else
					{
						num4 = -1783269731;
						num5 = -1783269731;
					}
					num = num4 ^ ((int)num2 * -20318547);
					continue;
				}
				case 35u:
					gclass31_0.ClassicControllerState.CalibrationInfo.MinYR = (byte)(array[10] >> 3);
					num = ((int)num2 * -1822805094) ^ -1404598914;
					continue;
				case 34u:
					switch (gEnum - 2753560833L)
					{
					case GEnum9.None:
					case (GEnum9)2L:
						goto IL_0492;
					case (GEnum9)1L:
						goto IL_0ba6;
					}
					num = (int)((num2 * 28080255) ^ 0x644FBC53);
					continue;
				case 12u:
					goto IL_0492;
				case 33u:
				{
					int num26;
					int num27;
					if (extensionType == GEnum9.Drums)
					{
						num26 = -904665653;
						num27 = -904665653;
					}
					else
					{
						num26 = -61339652;
						num27 = -61339652;
					}
					num = num26 ^ (int)(num2 * 229791195);
					continue;
				}
				case 31u:
					gclass31_0.BalanceBoardState.CalibrationInfo.Kg34.BottomRight = (short)((array[22] << 8) | array[23]);
					gclass31_0.BalanceBoardState.CalibrationInfo.Kg34.TopLeft = (short)((array[24] << 8) | array[25]);
					gclass31_0.BalanceBoardState.CalibrationInfo.Kg34.BottomLeft = (short)((array[26] << 8) | array[27]);
					num = (int)((num2 * 124498985) ^ 0x5DC6C7A1);
					continue;
				case 30u:
				{
					int num22;
					int num23;
					if (gEnum != GEnum9.Drums)
					{
						num22 = -1453360706;
						num23 = -1453360706;
					}
					else
					{
						num22 = -964161819;
						num23 = -964161819;
					}
					num = num22 ^ (int)(num2 * 1254144914);
					continue;
				}
				case 29u:
					method_4();
					array = method_27(77857018, 6);
					num = ((int)num2 * -2002549643) ^ -1468626493;
					continue;
				case 28u:
					switch (extensionType - 2753560833L)
					{
					default:
						num = ((int)num2 * -524990332) ^ 0x425019F;
						continue;
					case GEnum9.None:
						break;
					case (GEnum9)1L:
					case (GEnum9)2L:
						return;
					}
					goto case 16u;
				case 16u:
					array = method_27(77856800, 16);
					gclass31_0.ClassicControllerState.CalibrationInfo.MaxXL = (byte)(array[0] >> 2);
					num = -2134125988;
					continue;
				case 27u:
					gclass31_0.ClassicControllerState.CalibrationInfo.MinXL = (byte)(array[1] >> 2);
					gclass31_0.ClassicControllerState.CalibrationInfo.MidXL = (byte)(array[2] >> 2);
					num = ((int)num2 * -1914851016) ^ 0x7BEDF651;
					continue;
				case 26u:
					gclass31_0.BalanceBoardState.CalibrationInfo.Kg17.TopRight = (short)((array[12] << 8) | array[13]);
					num = ((int)num2 * -1279883152) ^ -816192920;
					continue;
				case 23u:
					array = method_27(77856800, 16);
					num = -1983889714;
					continue;
				case 22u:
					gclass31_0.NunchukState.CalibrationInfo.MaxX = array[8];
					gclass31_0.NunchukState.CalibrationInfo.MinX = array[9];
					num = (int)((num2 * 1484479663) ^ 0x5E33D322);
					continue;
				case 21u:
					gclass31_0.BalanceBoardState.CalibrationInfo.Kg17.TopLeft = (short)((array[16] << 8) | array[17]);
					num = ((int)num2 * -1519972100) ^ 0x1364878C;
					continue;
				case 20u:
					method_17(GEnum11.ButtonsExtension, bool_1: true);
					num = ((int)num2 * -1595446324) ^ 0x40198700;
					continue;
				case 19u:
					extensionType = gclass31_0.ExtensionType;
					num = -1861930037;
					continue;
				case 18u:
					gclass31_0.NunchukState.CalibrationInfo.AccelCalibration.Y0 = array[1];
					num = ((int)num2 * -1279384792) ^ -1531365096;
					continue;
				case 17u:
					gclass31_0.BalanceBoardState.CalibrationInfo.Kg17.BottomLeft = (short)((array[18] << 8) | array[19]);
					num = ((int)num2 * -2036435857) ^ 0x2B54A122;
					continue;
				case 13u:
				{
					int num18;
					int num19;
					if (gEnum != GEnum9.ParitallyInserted)
					{
						num18 = 1684302437;
						num19 = 1684302437;
					}
					else
					{
						num18 = 1060427254;
						num19 = 1060427254;
					}
					num = num18 ^ (int)(num2 * 1255772232);
					continue;
				}
				case 11u:
				{
					int num14;
					int num15;
					if (gEnum == GEnum9.None)
					{
						num14 = -1463363103;
						num15 = -1463363103;
					}
					else
					{
						num14 = -1759611463;
						num15 = -1759611463;
					}
					num = num14 ^ (int)(num2 * 488934545);
					continue;
				}
				case 10u:
					gclass31_0.BalanceBoardState.CalibrationInfo.Kg0.BottomRight = (short)((array[6] << 8) | array[7]);
					gclass31_0.BalanceBoardState.CalibrationInfo.Kg0.TopLeft = (short)((array[8] << 8) | array[9]);
					gclass31_0.BalanceBoardState.CalibrationInfo.Kg0.BottomLeft = (short)((array[10] << 8) | array[11]);
					num = ((int)num2 * -248396987) ^ -1740488909;
					continue;
				case 9u:
					gclass31_0.ClassicControllerState.CalibrationInfo.MinTriggerL = 0;
					num = (int)((num2 * 29412255) ^ 0xCA94AB4);
					continue;
				case 8u:
					num = (int)((num2 * 1084944019) ^ 0x200D5CA3);
					continue;
				case 7u:
					num = ((int)num2 * -1635553525) ^ 0x46CB5547;
					continue;
				case 6u:
				{
					int num11;
					if (extensionType != GEnum9.BalanceBoard)
					{
						num = -1415745524;
						num11 = -1415745524;
					}
					else
					{
						num = -537804957;
						num11 = -537804957;
					}
					continue;
				}
				case 5u:
					num10 = (long)(((ulong)array[0] << 40) | ((ulong)array[1] << 32) | ((ulong)array[2] << 24) | ((ulong)array[3] << 16) | ((ulong)array[4] << 8) | array[5]);
					gEnum = (GEnum9)num10;
					num = (int)((num2 * 1942812216) ^ 0x10EA09CB);
					continue;
				case 4u:
					array = method_27(77856800, 32);
					gclass31_0.BalanceBoardState.CalibrationInfo.Kg0.TopRight = (short)((array[4] << 8) | array[5]);
					num = -1352476171;
					continue;
				case 3u:
				{
					int num6;
					int num7;
					if (gEnum >= GEnum9.ClassicController)
					{
						num6 = -39724534;
						num7 = -39724534;
					}
					else
					{
						num6 = -1837485506;
						num7 = -1837485506;
					}
					num = num6 ^ ((int)num2 * -185338245);
					continue;
				}
				case 2u:
				{
					int num3;
					if (gEnum == GEnum9.BalanceBoard)
					{
						num = -830554699;
						num3 = -830554699;
					}
					else
					{
						num = -1220297143;
						num3 = -1220297143;
					}
					continue;
				}
				case 1u:
					gclass31_0.NunchukState.CalibrationInfo.AccelCalibration.YG = array[5];
					gclass31_0.NunchukState.CalibrationInfo.AccelCalibration.ZG = array[6];
					num = ((int)num2 * -817549566) ^ -885081399;
					continue;
				case 0u:
					gclass31_0.NunchukState.CalibrationInfo.MaxY = array[11];
					gclass31_0.NunchukState.CalibrationInfo.MinY = array[12];
					num = (int)(num2 * 1630280020) ^ -240838383;
					continue;
				default:
					return;
				case 25u:
					break;
				case 24u:
					gclass31_0.NunchukState.CalibrationInfo.MidY = array[13];
					return;
				case 15u:
					return;
				case 32u:
					return;
				case 14u:
					goto IL_0ba6;
				case 50u:
					return;
				case 54u:
					return;
				case 57u:
					{
						gclass31_0.ClassicControllerState.CalibrationInfo.MaxTriggerR = 31;
						return;
					}
					IL_0ba6:
					throw new GException1("Unknown extension controller found: " + num10.ToString("x"));
					IL_0492:
					gclass31_0.ExtensionType = (GEnum9)num10;
					num = -745778919;
					continue;
				}
				break;
			}
		}
	}

	private byte[] method_8(byte[] byte_2)
	{
		int num = 0;
		while (true)
		{
			int num2 = -2005700514;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xA5B030CAu) % 5u)
				{
				case 2u:
					num2 = (int)(num3 * 521142682) ^ -546698814;
					continue;
				case 1u:
					byte_2[num] = (byte)((uint)((byte_2[num] ^ 0x17) + 23) & 0xFFu);
					num++;
					num2 = -526424886;
					continue;
				case 0u:
				{
					int num4;
					if (num >= byte_2.Length)
					{
						num2 = -527874488;
						num4 = -527874488;
					}
					else
					{
						num2 = -2050109846;
						num4 = -2050109846;
					}
					continue;
				}
				case 3u:
					break;
				default:
					return byte_2;
				}
				break;
			}
		}
	}

	private void method_9(byte[] byte_2)
	{
		gclass31_0.ButtonState.A = (byte_2[2] & 8) != 0;
		gclass31_0.ButtonState.B = (byte_2[2] & 4) != 0;
		gclass31_0.ButtonState.Minus = (byte_2[2] & 0x10) != 0;
		while (true)
		{
			int num = 747518530;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x53D4DAF5u) % 6u)
				{
				case 4u:
					gclass31_0.ButtonState.Two = (byte_2[2] & 1) != 0;
					num = (int)(num2 * 459187969) ^ -1891063324;
					continue;
				case 3u:
					gclass31_0.ButtonState.Home = (byte_2[2] & 0x80) != 0;
					gclass31_0.ButtonState.Plus = (byte_2[1] & 0x10) != 0;
					gclass31_0.ButtonState.One = (byte_2[2] & 2) != 0;
					num = ((int)num2 * -993844259) ^ -543356574;
					continue;
				case 2u:
					gclass31_0.ButtonState.Left = (byte_2[1] & 1) != 0;
					num = (int)(num2 * 1791902317) ^ -1677455090;
					continue;
				case 1u:
					gclass31_0.ButtonState.Up = (byte_2[1] & 8) != 0;
					gclass31_0.ButtonState.Down = (byte_2[1] & 4) != 0;
					num = ((int)num2 * -940763548) ^ 0x6D472997;
					continue;
				case 0u:
					break;
				default:
					gclass31_0.ButtonState.Right = (byte_2[1] & 2) != 0;
					return;
				}
				break;
			}
		}
	}

	private void method_10(byte[] byte_2)
	{
		gclass31_0.AccelState.RawValues.X = byte_2[3];
		gclass31_0.AccelState.RawValues.Y = byte_2[4];
		while (true)
		{
			int num = -1534921346;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC9E63E98u) % 4u)
				{
				case 2u:
					gclass31_0.AccelState.RawValues.Z = byte_2[5];
					gclass31_0.AccelState.Values.X = ((float)gclass31_0.AccelState.RawValues.X - (float)(int)gclass31_0.AccelCalibrationInfo.X0) / ((float)(int)gclass31_0.AccelCalibrationInfo.XG - (float)(int)gclass31_0.AccelCalibrationInfo.X0);
					num = ((int)num2 * -1801089915) ^ -2046794661;
					continue;
				case 1u:
					gclass31_0.AccelState.Values.Y = ((float)gclass31_0.AccelState.RawValues.Y - (float)(int)gclass31_0.AccelCalibrationInfo.Y0) / ((float)(int)gclass31_0.AccelCalibrationInfo.YG - (float)(int)gclass31_0.AccelCalibrationInfo.Y0);
					num = ((int)num2 * -1664177931) ^ 0x5DC17C3D;
					continue;
				case 3u:
					break;
				default:
					gclass31_0.AccelState.Values.Z = ((float)gclass31_0.AccelState.RawValues.Z - (float)(int)gclass31_0.AccelCalibrationInfo.Z0) / ((float)(int)gclass31_0.AccelCalibrationInfo.ZG - (float)(int)gclass31_0.AccelCalibrationInfo.Z0);
					return;
				}
				break;
			}
		}
	}

	private void method_11(byte[] byte_2)
	{
		gclass31_0.IRState.IRSensors[0].RawPosition.X = byte_2[6] | (((byte_2[8] >> 4) & 3) << 8);
		while (true)
		{
			int num = 2134427135;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x69D4984Fu) % 36u)
				{
				case 35u:
					gclass31_0.IRState.IRSensors[1].Size = byte_2[11] & 0xF;
					num = ((int)num2 * -960149361) ^ 0x44FD727B;
					continue;
				case 34u:
					gclass31_0.IRState.IRSensors[1].RawPosition.Y = byte_2[10] | (((byte_2[11] >> 6) & 3) << 8);
					gclass31_0.IRState.IRSensors[2].RawPosition.X = byte_2[12] | (((byte_2[14] >> 4) & 3) << 8);
					num = (int)(num2 * 569371519) ^ -61271777;
					continue;
				case 33u:
					gclass31_0.IRState.IRSensors[0].Found = byte_2[6] != byte.MaxValue || byte_2[7] != byte.MaxValue || byte_2[8] != byte.MaxValue;
					num = 1989369561;
					continue;
				case 32u:
					gclass31_0.IRState.IRSensors[2].Found = byte_2[12] != byte.MaxValue || byte_2[13] != byte.MaxValue || byte_2[14] != byte.MaxValue;
					gclass31_0.IRState.IRSensors[3].Found = byte_2[15] != byte.MaxValue || byte_2[16] != byte.MaxValue || byte_2[17] != byte.MaxValue;
					num = 470017639;
					continue;
				case 30u:
					gclass31_0.IRState.IRSensors[1].Found = byte_2[9] != byte.MaxValue || byte_2[10] != byte.MaxValue || byte_2[11] != byte.MaxValue;
					num = 1376631223;
					continue;
				case 29u:
					gclass31_0.IRState.IRSensors[1].Size = 0;
					num = ((int)num2 * -1700009649) ^ 0x4EA6E66D;
					continue;
				case 28u:
					gclass31_0.IRState.IRSensors[3].Size = 0;
					num = (int)((num2 * 862025075) ^ 0x2BECD894);
					continue;
				case 27u:
				{
					int num5;
					int num6;
					if (!gclass31_0.IRState.IRSensors[0].Found)
					{
						num5 = -551516291;
						num6 = -551516291;
					}
					else
					{
						num5 = -1208391144;
						num6 = -1208391144;
					}
					num = num5 ^ ((int)num2 * -515083720);
					continue;
				}
				case 26u:
					gclass31_0.IRState.IRSensors[0].Position.Y = (float)gclass31_0.IRState.IRSensors[0].RawPosition.Y / 767.5f;
					num = ((int)num2 * -543419115) ^ -1415788149;
					continue;
				case 25u:
					gclass31_0.IRState.IRSensors[2].Size = byte_2[14] & 0xF;
					gclass31_0.IRState.IRSensors[3].Size = byte_2[17] & 0xF;
					num = ((int)num2 * -817618398) ^ -484463476;
					continue;
				case 24u:
					gclass31_0.IRState.IRSensors[0].Position.X = (float)gclass31_0.IRState.IRSensors[0].RawPosition.X / 1023.5f;
					num = 972709015;
					continue;
				case 23u:
					gclass31_0.IRState.RawMidpoint.X = (gclass31_0.IRState.IRSensors[1].RawPosition.X + gclass31_0.IRState.IRSensors[0].RawPosition.X) / 2;
					gclass31_0.IRState.RawMidpoint.Y = (gclass31_0.IRState.IRSensors[1].RawPosition.Y + gclass31_0.IRState.IRSensors[0].RawPosition.Y) / 2;
					gclass31_0.IRState.Midpoint.X = (gclass31_0.IRState.IRSensors[1].Position.X + gclass31_0.IRState.IRSensors[0].Position.X) / 2f;
					num = (int)((num2 * 185680729) ^ 0x873E2E1);
					continue;
				case 22u:
					gclass31_0.IRState.IRSensors[2].Position.X = (float)gclass31_0.IRState.IRSensors[2].RawPosition.X / 1023.5f;
					gclass31_0.IRState.IRSensors[3].Position.X = (float)gclass31_0.IRState.IRSensors[3].RawPosition.X / 1023.5f;
					num = (int)((num2 * 243713319) ^ 0x1D256793);
					continue;
				case 21u:
					gclass31_0.IRState.IRSensors[2].Size = 0;
					num = ((int)num2 * -624504652) ^ -1108789181;
					continue;
				case 20u:
					gclass31_0.IRState.IRSensors[2].RawPosition.X = byte_2[11] | (((byte_2[13] >> 4) & 3) << 8);
					num = ((int)num2 * -1236558958) ^ 0x1ACD5B97;
					continue;
				case 19u:
					gclass31_0.IRState.IRSensors[3].RawPosition.Y = byte_2[16] | (((byte_2[17] >> 6) & 3) << 8);
					gclass31_0.IRState.IRSensors[0].Size = byte_2[8] & 0xF;
					num = ((int)num2 * -814425195) ^ 0x206A6F87;
					continue;
				case 18u:
					gclass31_0.IRState.IRSensors[1].Position.Y = (float)gclass31_0.IRState.IRSensors[1].RawPosition.Y / 767.5f;
					num = ((int)num2 * -1608768331) ^ -1267004329;
					continue;
				case 17u:
					goto IL_0683;
				case 16u:
					gclass31_0.IRState.IRSensors[1].Position.X = (float)gclass31_0.IRState.IRSensors[1].RawPosition.X / 1023.5f;
					num = (int)((num2 * 555384005) ^ 0x218A60F1);
					continue;
				case 15u:
					gclass31_0.IRState.IRSensors[0].Found = byte_2[6] != byte.MaxValue || byte_2[7] != byte.MaxValue;
					gclass31_0.IRState.IRSensors[1].Found = byte_2[9] != byte.MaxValue || byte_2[10] != byte.MaxValue;
					gclass31_0.IRState.IRSensors[2].Found = byte_2[11] != byte.MaxValue || byte_2[12] != byte.MaxValue;
					num = 2022987424;
					continue;
				case 14u:
				{
					ref GStruct0 midpoint = ref gclass31_0.IRState.Midpoint;
					ref GStruct0 midpoint2 = ref gclass31_0.IRState.Midpoint;
					float x = 0f;
					midpoint2.Y = 0f;
					midpoint.X = x;
					num = 1462485624;
					continue;
				}
				case 13u:
					gclass31_0.IRState.Midpoint.Y = (gclass31_0.IRState.IRSensors[1].Position.Y + gclass31_0.IRState.IRSensors[0].Position.Y) / 2f;
					num = (int)((num2 * 701671540) ^ 0x5D9F0B2);
					continue;
				case 12u:
					num = (int)((num2 * 904411771) ^ 0x820A9F);
					continue;
				case 11u:
				{
					int num3;
					int num4;
					if (gclass31_0.IRState.IRSensors[1].Found)
					{
						num3 = 1699729324;
						num4 = 1699729324;
					}
					else
					{
						num3 = 905481729;
						num4 = 905481729;
					}
					num = num3 ^ ((int)num2 * -1456497908);
					continue;
				}
				case 10u:
					gclass31_0.IRState.IRSensors[2].RawPosition.Y = byte_2[13] | (((byte_2[14] >> 6) & 3) << 8);
					gclass31_0.IRState.IRSensors[3].RawPosition.X = byte_2[15] | (((byte_2[17] >> 4) & 3) << 8);
					num = ((int)num2 * -1803696559) ^ 0x7AF1107E;
					continue;
				case 9u:
					goto IL_0934;
				case 8u:
					gclass31_0.IRState.IRSensors[0].RawPosition.Y = byte_2[7] | (((byte_2[8] >> 6) & 3) << 8);
					num = (int)((num2 * 853017733) ^ 0x55E272E1);
					continue;
				case 7u:
					gclass31_0.IRState.IRSensors[3].Found = byte_2[14] != byte.MaxValue || byte_2[15] != byte.MaxValue;
					num = 470017639;
					continue;
				case 6u:
					gclass31_0.IRState.IRSensors[2].Position.Y = (float)gclass31_0.IRState.IRSensors[2].RawPosition.Y / 767.5f;
					num = (int)(num2 * 1234337521) ^ -1472932687;
					continue;
				case 4u:
					gclass31_0.IRState.IRSensors[2].RawPosition.Y = byte_2[12] | (((byte_2[13] >> 6) & 3) << 8);
					gclass31_0.IRState.IRSensors[3].RawPosition.X = byte_2[14] | ((byte_2[13] & 3) << 8);
					gclass31_0.IRState.IRSensors[3].RawPosition.Y = byte_2[15] | (((byte_2[13] >> 2) & 3) << 8);
					num = (int)((num2 * 786645435) ^ 0x2ED51E6A);
					continue;
				case 2u:
					switch (gclass31_0.IRState.Mode)
					{
					case (GEnum10)2:
						break;
					case GEnum10.Extended:
						goto IL_0683;
					case GEnum10.Basic:
						goto IL_0934;
					default:
						goto IL_0b34;
					}
					goto case 24u;
				case 1u:
					gclass31_0.IRState.IRSensors[0].Size = 0;
					num = (int)(num2 * 125358917) ^ -337708921;
					continue;
				case 0u:
					gclass31_0.IRState.IRSensors[3].Position.Y = (float)gclass31_0.IRState.IRSensors[3].RawPosition.Y / 767.5f;
					num = ((int)num2 * -705754147) ^ 0x453B39C;
					continue;
				default:
					return;
				case 31u:
					break;
				case 3u:
					return;
				case 5u:
					return;
					IL_0b34:
					num = (int)((num2 * 26719428) ^ 0x484DD0DF);
					continue;
					IL_0934:
					gclass31_0.IRState.IRSensors[1].RawPosition.X = byte_2[9] | ((byte_2[8] & 3) << 8);
					gclass31_0.IRState.IRSensors[1].RawPosition.Y = byte_2[10] | (((byte_2[8] >> 2) & 3) << 8);
					num = 111999567;
					continue;
					IL_0683:
					gclass31_0.IRState.IRSensors[1].RawPosition.X = byte_2[9] | (((byte_2[11] >> 4) & 3) << 8);
					num = 1747228153;
					continue;
				}
				break;
			}
		}
	}

	private void method_12(byte[] byte_2, int int_14)
	{
		GEnum9 extensionType = gclass31_0.ExtensionType;
		if (extensionType <= GEnum9.Guitar)
		{
			goto IL_1969;
		}
		goto IL_1d60;
		IL_1d60:
		int num;
		int num2;
		if (extensionType != GEnum9.BalanceBoard)
		{
			num = -422131621;
			num2 = -422131621;
		}
		else
		{
			num = -725719651;
			num2 = -725719651;
		}
		goto IL_1b6f;
		IL_1b6f:
		int num12 = default(int);
		int num11 = default(int);
		int num21 = default(int);
		int num4 = default(int);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0xC6D82328u) % 115u)
			{
			case 114u:
			{
				int num19;
				int num20;
				if (num12 == 31)
				{
					num19 = -190004047;
					num20 = -190004047;
				}
				else
				{
					num19 = -65247156;
					num20 = -65247156;
				}
				num = num19 ^ (int)(num3 * 2115270515);
				continue;
			}
			case 113u:
				num11 = num21;
				num = ((int)num3 * -1092967630) ^ -1660329389;
				continue;
			case 112u:
				break;
			case 111u:
				gclass31_0.ClassicControllerState.RawJoystickR.X = (byte)((byte_2[int_14 + 2] >> 7) | ((byte_2[int_14 + 1] & 0xC0) >> 5) | ((byte_2[int_14] & 0xC0) >> 3));
				num = ((int)num3 * -1500336911) ^ -955400992;
				continue;
			case 110u:
				gclass31_0.GuitarState.ButtonState.Minus = (byte_2[int_14 + 4] & 0x10) == 0;
				num = ((int)num3 * -330362240) ^ -1594129016;
				continue;
			case 109u:
				goto IL_0120;
			case 107u:
				gclass31_0.GuitarState.TouchbarState.Blue = false;
				num = ((int)num3 * -1167406485) ^ -1429631343;
				continue;
			case 106u:
				gclass31_0.ClassicControllerState.ButtonState.TriggerL = (byte_2[int_14 + 4] & 0x20) == 0;
				gclass31_0.ClassicControllerState.ButtonState.Down = (byte_2[int_14 + 4] & 0x40) == 0;
				num = (int)(num3 * 51267351) ^ -1870316624;
				continue;
			case 105u:
				gclass31_0.GuitarState.RawJoystick.Y = byte_2[int_14 + 1] & 0x3F;
				gclass31_0.GuitarState.RawWhammyBar = (byte)(byte_2[int_14 + 3] & 0x1Fu);
				num = (int)(num3 * 1499703523) ^ -2126504322;
				continue;
			case 104u:
				gclass31_0.ClassicControllerState.TriggerL = (float)(int)gclass31_0.ClassicControllerState.RawTriggerL / (float)(gclass31_0.ClassicControllerState.CalibrationInfo.MaxTriggerL - gclass31_0.ClassicControllerState.CalibrationInfo.MinTriggerL);
				num = (int)(num3 * 297943258) ^ -1434350410;
				continue;
			case 103u:
				gclass31_0.GuitarState.Joystick.X = (float)(gclass31_0.GuitarState.RawJoystick.X - 31) / 63f;
				num = (int)((num3 * 524108383) ^ 0x4372BDC4);
				continue;
			case 102u:
				gclass31_0.GuitarState.FretButtonState.Yellow = (byte_2[int_14 + 5] & 8) == 0;
				gclass31_0.GuitarState.FretButtonState.Green = (byte_2[int_14 + 5] & 0x10) == 0;
				num = (int)((num3 * 1535284897) ^ 0x40D05FB6);
				continue;
			case 100u:
				gclass31_0.GuitarState.TouchbarState.Blue = true;
				num = -1675951169;
				continue;
			case 97u:
				gclass31_0.BalanceBoardState.SensorValuesLb.BottomLeft = gclass31_0.BalanceBoardState.SensorValuesKg.BottomLeft * 2.2046225f;
				gclass31_0.BalanceBoardState.SensorValuesLb.BottomRight = gclass31_0.BalanceBoardState.SensorValuesKg.BottomRight * 2.2046225f;
				num = ((int)num3 * -796672999) ^ 0x3F8F62F4;
				continue;
			case 96u:
				num21 = (byte_2[int_14 + 2] >> 1) & 0x1F;
				num = ((int)num3 * -1028717602) ^ -973474361;
				continue;
			case 95u:
				gclass31_0.GuitarState.WhammyBar = (float)(int)gclass31_0.GuitarState.RawWhammyBar / 10f;
				num = (int)((num3 * 743563533) ^ 0x6BCA1812);
				continue;
			case 94u:
				gclass31_0.GuitarState.TouchbarState.Red = false;
				num = (int)(num3 * 603126807) ^ -927985082;
				continue;
			case 93u:
			{
				int num15;
				int num16;
				if (extensionType > GEnum9.Guitar)
				{
					num15 = -1121663788;
					num16 = -1121663788;
				}
				else
				{
					num15 = -1027884915;
					num16 = -1027884915;
				}
				num = num15 ^ ((int)num3 * -1542909629);
				continue;
			}
			case 91u:
				gclass31_0.DrumsState.OrangeVelocity = num4;
				num = -1401864650;
				continue;
			case 89u:
				gclass31_0.DrumsState.RawJoystick.Y = byte_2[int_14 + 1] & 0x3F;
				num = (int)((num3 * 7569801) ^ 0x7A05FFFB);
				continue;
			case 88u:
				gclass31_0.DrumsState.Minus = (byte_2[int_14 + 4] & 0x10) == 0;
				gclass31_0.DrumsState.Pedal = (byte_2[int_14 + 5] & 4) == 0;
				gclass31_0.DrumsState.Blue = (byte_2[int_14 + 5] & 8) == 0;
				gclass31_0.DrumsState.Green = (byte_2[int_14 + 5] & 0x10) == 0;
				gclass31_0.DrumsState.Yellow = (byte_2[int_14 + 5] & 0x20) == 0;
				num = ((int)num3 * -904470049) ^ 0x360542A2;
				continue;
			case 87u:
				gclass31_0.DrumsState.Joystick.Y = (float)(gclass31_0.DrumsState.RawJoystick.Y - 31) / 63f;
				num = (int)(num3 * 904534668) ^ -323390915;
				continue;
			case 86u:
			{
				int num7;
				int num8;
				if (gclass31_0.NunchukState.CalibrationInfo.MaxX != 0)
				{
					num7 = 2081861222;
					num8 = 2081861222;
				}
				else
				{
					num7 = 1675369428;
					num8 = 1675369428;
				}
				num = num7 ^ ((int)num3 * -1204116412);
				continue;
			}
			case 85u:
				gclass31_0.NunchukState.AccelState.Values.X = ((float)gclass31_0.NunchukState.AccelState.RawValues.X - (float)(int)gclass31_0.NunchukState.CalibrationInfo.AccelCalibration.X0) / ((float)(int)gclass31_0.NunchukState.CalibrationInfo.AccelCalibration.XG - (float)(int)gclass31_0.NunchukState.CalibrationInfo.AccelCalibration.X0);
				gclass31_0.NunchukState.AccelState.Values.Y = ((float)gclass31_0.NunchukState.AccelState.RawValues.Y - (float)(int)gclass31_0.NunchukState.CalibrationInfo.AccelCalibration.Y0) / ((float)(int)gclass31_0.NunchukState.CalibrationInfo.AccelCalibration.YG - (float)(int)gclass31_0.NunchukState.CalibrationInfo.AccelCalibration.Y0);
				gclass31_0.NunchukState.AccelState.Values.Z = ((float)gclass31_0.NunchukState.AccelState.RawValues.Z - (float)(int)gclass31_0.NunchukState.CalibrationInfo.AccelCalibration.Z0) / ((float)(int)gclass31_0.NunchukState.CalibrationInfo.AccelCalibration.ZG - (float)(int)gclass31_0.NunchukState.CalibrationInfo.AccelCalibration.Z0);
				num = ((int)num3 * -601973663) ^ -1201502361;
				continue;
			case 83u:
				gclass31_0.ClassicControllerState.RawJoystickL.X = (byte)(byte_2[int_14] & 0x3F);
				num = -1121110185;
				continue;
			case 82u:
				gclass31_0.ClassicControllerState.ButtonState.Right = (byte_2[int_14 + 4] & 0x80) == 0;
				gclass31_0.ClassicControllerState.ButtonState.Up = (byte_2[int_14 + 5] & 1) == 0;
				num = (int)(num3 * 1479529875) ^ -1466891170;
				continue;
			case 81u:
			{
				float num26 = (gclass31_0.BalanceBoardState.SensorValuesKg.TopLeft + gclass31_0.BalanceBoardState.SensorValuesKg.BottomLeft) / (gclass31_0.BalanceBoardState.SensorValuesKg.TopRight + gclass31_0.BalanceBoardState.SensorValuesKg.BottomRight);
				float num27 = (gclass31_0.BalanceBoardState.SensorValuesKg.TopLeft + gclass31_0.BalanceBoardState.SensorValuesKg.TopRight) / (gclass31_0.BalanceBoardState.SensorValuesKg.BottomLeft + gclass31_0.BalanceBoardState.SensorValuesKg.BottomRight);
				gclass31_0.BalanceBoardState.CenterOfGravity.X = (num26 - 1f) / (num26 + 1f) * -21f;
				gclass31_0.BalanceBoardState.CenterOfGravity.Y = (num27 - 1f) / (num27 + 1f) * -12f;
				num = ((int)num3 * -2001647727) ^ 0x5F16149E;
				continue;
			}
			case 79u:
				goto IL_090a;
			case 78u:
				goto IL_092a;
			case 77u:
				goto IL_0960;
			case 76u:
				gclass31_0.ClassicControllerState.ButtonState.Left = (byte_2[int_14 + 5] & 2) == 0;
				num = ((int)num3 * -1372395810) ^ 0x7839CE0D;
				continue;
			case 74u:
				gclass31_0.ClassicControllerState.ButtonState.ZR = (byte_2[int_14 + 5] & 4) == 0;
				num = (int)((num3 * 691341585) ^ 0x28E3BEF1);
				continue;
			case 73u:
				gclass31_0.BalanceBoardState.SensorValuesKg.BottomRight = method_13(gclass31_0.BalanceBoardState.SensorValuesRaw.BottomRight, gclass31_0.BalanceBoardState.CalibrationInfo.Kg0.BottomRight, gclass31_0.BalanceBoardState.CalibrationInfo.Kg17.BottomRight, gclass31_0.BalanceBoardState.CalibrationInfo.Kg34.BottomRight);
				gclass31_0.BalanceBoardState.SensorValuesLb.TopLeft = gclass31_0.BalanceBoardState.SensorValuesKg.TopLeft * 2.2046225f;
				gclass31_0.BalanceBoardState.SensorValuesLb.TopRight = gclass31_0.BalanceBoardState.SensorValuesKg.TopRight * 2.2046225f;
				num = (int)((num3 * 2073827375) ^ 0x56569E23);
				continue;
			case 72u:
				gclass31_0.NunchukState.AccelState.RawValues.X = byte_2[int_14 + 2];
				gclass31_0.NunchukState.AccelState.RawValues.Y = byte_2[int_14 + 3];
				num = (int)((num3 * 297625000) ^ 0x1CBC4622);
				continue;
			case 71u:
				gclass31_0.GuitarState.FretButtonState.Orange = (byte_2[int_14 + 5] & 0x80) == 0;
				gclass31_0.GuitarState.RawJoystick.X = byte_2[int_14] & 0x3F;
				num = (int)(num3 * 1633951728) ^ -1684508662;
				continue;
			case 70u:
				gclass31_0.ClassicControllerState.RawJoystickR.Y = (byte)(byte_2[int_14 + 2] & 0x1F);
				num = (int)(num3 * 1483871868) ^ -1209645842;
				continue;
			case 68u:
				gclass31_0.NunchukState.Joystick.Y = ((float)gclass31_0.NunchukState.RawJoystick.Y - (float)(int)gclass31_0.NunchukState.CalibrationInfo.MidY) / ((float)(int)gclass31_0.NunchukState.CalibrationInfo.MaxY - (float)(int)gclass31_0.NunchukState.CalibrationInfo.MinY);
				num = ((int)num3 * -1579467801) ^ 0x4039539E;
				continue;
			case 67u:
				gclass31_0.GuitarState.FretButtonState.Blue = (byte_2[int_14 + 5] & 0x20) == 0;
				gclass31_0.GuitarState.FretButtonState.Red = (byte_2[int_14 + 5] & 0x40) == 0;
				num = ((int)num3 * -1239785339) ^ 0x714E22B;
				continue;
			case 63u:
				gclass31_0.GuitarState.Joystick.Y = (float)(gclass31_0.GuitarState.RawJoystick.Y - 31) / 63f;
				num = ((int)num3 * -1217126595) ^ 0x16F51F2F;
				continue;
			case 62u:
				goto IL_0cd9;
			case 61u:
				gclass31_0.GuitarState.TouchbarState.Yellow = false;
				gclass31_0.GuitarState.TouchbarState.Green = false;
				num = ((int)num3 * -1659054236) ^ 0x683C3D58;
				continue;
			case 60u:
				goto IL_0d4b;
			case 59u:
				gclass31_0.ClassicControllerState.RawTriggerL = (byte)(((byte_2[int_14 + 2] & 0x60) >> 2) | (byte_2[int_14 + 3] >> 5));
				num = (int)(num3 * 944943637) ^ -444944583;
				continue;
			case 58u:
				gclass31_0.ClassicControllerState.ButtonState.X = (byte_2[int_14 + 5] & 8) == 0;
				num = (int)((num3 * 67570031) ^ 0x53042589);
				continue;
			case 57u:
				gclass31_0.BalanceBoardState.SensorValuesRaw.TopLeft = (short)((byte_2[int_14 + 4] << 8) | byte_2[int_14 + 5]);
				gclass31_0.BalanceBoardState.SensorValuesRaw.BottomLeft = (short)((byte_2[int_14 + 6] << 8) | byte_2[int_14 + 7]);
				gclass31_0.BalanceBoardState.SensorValuesKg.TopLeft = method_13(gclass31_0.BalanceBoardState.SensorValuesRaw.TopLeft, gclass31_0.BalanceBoardState.CalibrationInfo.Kg0.TopLeft, gclass31_0.BalanceBoardState.CalibrationInfo.Kg17.TopLeft, gclass31_0.BalanceBoardState.CalibrationInfo.Kg34.TopLeft);
				num = (int)(num3 * 1274515268) ^ -1464803127;
				continue;
			case 55u:
				gclass31_0.ClassicControllerState.RawJoystickL.Y = (byte)(byte_2[int_14 + 1] & 0x3F);
				num = (int)((num3 * 1018579709) ^ 0x48D2E124);
				continue;
			case 54u:
				gclass31_0.DrumsState.RawJoystick.X = byte_2[int_14] & 0x3F;
				num = -946637991;
				continue;
			case 53u:
				goto IL_0f28;
			case 51u:
				goto IL_0f43;
			case 50u:
				switch (extensionType - 2753560833L)
				{
				case GEnum9.None:
					break;
				case (GEnum9)2L:
					goto IL_0d4b;
				default:
					goto IL_0f93;
				case (GEnum9)1L:
					return;
				}
				goto case 83u;
			case 49u:
				gclass31_0.ClassicControllerState.JoystickL.Y = ((float)gclass31_0.ClassicControllerState.RawJoystickL.Y - (float)(int)gclass31_0.ClassicControllerState.CalibrationInfo.MidYL) / (float)(gclass31_0.ClassicControllerState.CalibrationInfo.MaxYL - gclass31_0.ClassicControllerState.CalibrationInfo.MinYL);
				num = (int)((num3 * 497529188) ^ 0x19E8D0CA);
				continue;
			case 48u:
				goto IL_1029;
			case 47u:
				gclass31_0.BalanceBoardState.SensorValuesKg.TopRight = method_13(gclass31_0.BalanceBoardState.SensorValuesRaw.TopRight, gclass31_0.BalanceBoardState.CalibrationInfo.Kg0.TopRight, gclass31_0.BalanceBoardState.CalibrationInfo.Kg17.TopRight, gclass31_0.BalanceBoardState.CalibrationInfo.Kg34.TopRight);
				gclass31_0.BalanceBoardState.SensorValuesKg.BottomLeft = method_13(gclass31_0.BalanceBoardState.SensorValuesRaw.BottomLeft, gclass31_0.BalanceBoardState.CalibrationInfo.Kg0.BottomLeft, gclass31_0.BalanceBoardState.CalibrationInfo.Kg17.BottomLeft, gclass31_0.BalanceBoardState.CalibrationInfo.Kg34.BottomLeft);
				num = (int)(num3 * 1331407479) ^ -1827401450;
				continue;
			case 46u:
				goto IL_1153;
			case 45u:
			{
				int num24;
				int num25;
				if ((byte_2[int_14 + 2] & 0x40u) != 0)
				{
					num24 = -311944410;
					num25 = -311944410;
				}
				else
				{
					num24 = -563605182;
					num25 = -563605182;
				}
				num = num24 ^ (int)(num3 * 1567216815);
				continue;
			}
			case 44u:
				gclass31_0.ClassicControllerState.TriggerR = (float)(int)gclass31_0.ClassicControllerState.RawTriggerR / (float)(gclass31_0.ClassicControllerState.CalibrationInfo.MaxTriggerR - gclass31_0.ClassicControllerState.CalibrationInfo.MinTriggerR);
				num = (int)(num3 * 626562945) ^ -1433518397;
				continue;
			case 42u:
			{
				int num22;
				int num23;
				if (gclass31_0.ClassicControllerState.CalibrationInfo.MaxXL != 0)
				{
					num22 = 41806272;
					num23 = 41806272;
				}
				else
				{
					num22 = 1128428057;
					num23 = 1128428057;
				}
				num = num22 ^ (int)(num3 * 1510785470);
				continue;
			}
			case 41u:
			{
				int num17;
				int num18;
				if (extensionType < GEnum9.ClassicController)
				{
					num17 = -1566348143;
					num18 = -1566348143;
				}
				else
				{
					num17 = -776684305;
					num18 = -776684305;
				}
				num = num17 ^ ((int)num3 * -574221187);
				continue;
			}
			case 40u:
				goto IL_1270;
			case 39u:
				gclass31_0.DrumsState.Plus = (byte_2[int_14 + 4] & 4) == 0;
				num = ((int)num3 * -953899831) ^ -1192328741;
				continue;
			case 38u:
				gclass31_0.GuitarState.TouchbarState.Red = true;
				num = ((int)num3 * -1280675565) ^ -108315350;
				continue;
			case 37u:
				switch (num11)
				{
				case 14:
					break;
				case 15:
					goto IL_0f28;
				case 17:
					goto IL_1029;
				default:
					goto IL_1317;
				case 18:
					goto IL_1e01;
				case 16:
					return;
				}
				goto case 91u;
			case 36u:
				gclass31_0.NunchukState.AccelState.RawValues.Z = byte_2[int_14 + 4];
				num = (int)((num3 * 1907293434) ^ 0x4BAFB5E5);
				continue;
			case 34u:
				gclass31_0.GuitarState.ButtonState.StrumDown = (byte_2[int_14 + 4] & 0x40) == 0;
				num = (int)((num3 * 131504504) ^ 0xA3B01E5);
				continue;
			case 33u:
				gclass31_0.BalanceBoardState.WeightLb = (gclass31_0.BalanceBoardState.SensorValuesLb.TopLeft + gclass31_0.BalanceBoardState.SensorValuesLb.TopRight + gclass31_0.BalanceBoardState.SensorValuesLb.BottomLeft + gclass31_0.BalanceBoardState.SensorValuesLb.BottomRight) / 4f;
				num = ((int)num3 * -280055085) ^ -1060552216;
				continue;
			case 32u:
				gclass31_0.NunchukState.Z = (byte_2[int_14 + 5] & 1) == 0;
				num = ((int)num3 * -1079791026) ^ 0xDB44B29;
				continue;
			case 31u:
			{
				int num13;
				int num14;
				if (extensionType == GEnum9.Nunchuk)
				{
					num13 = 1334811837;
					num14 = 1334811837;
				}
				else
				{
					num13 = 177141849;
					num14 = 177141849;
				}
				num = num13 ^ (int)(num3 * 1279292553);
				continue;
			}
			case 30u:
				gclass31_0.GuitarState.ButtonState.StrumUp = (byte_2[int_14 + 5] & 1) == 0;
				num = (int)((num3 * 1382702527) ^ 0x7921DC9);
				continue;
			case 29u:
				gclass31_0.GuitarState.TouchbarState.Orange = false;
				num12 = byte_2[int_14 + 2] & 0x1F;
				switch (num12)
				{
				case 26:
					break;
				case 12:
				case 13:
					goto IL_090a;
				case 20:
				case 21:
					goto IL_092a;
				case 4:
					goto IL_1153;
				default:
					goto IL_1522;
				case 7:
					goto IL_1535;
				case 10:
					goto IL_1d9a;
				case 18:
				case 19:
					goto IL_1db1;
				case 23:
				case 24:
					goto IL_1dc8;
				case 5:
				case 6:
				case 8:
				case 9:
				case 11:
				case 14:
				case 15:
				case 16:
				case 17:
				case 22:
				case 25:
					return;
				}
				goto case 100u;
			case 0u:
				goto IL_1535;
			case 27u:
				gclass31_0.ClassicControllerState.ButtonState.A = (byte_2[int_14 + 5] & 0x10) == 0;
				num = (int)(num3 * 600943989) ^ -450138885;
				continue;
			case 26u:
				gclass31_0.ClassicControllerState.JoystickR.X = ((float)gclass31_0.ClassicControllerState.RawJoystickR.X - (float)(int)gclass31_0.ClassicControllerState.CalibrationInfo.MidXR) / (float)(gclass31_0.ClassicControllerState.CalibrationInfo.MaxXR - gclass31_0.ClassicControllerState.CalibrationInfo.MinXR);
				num = (int)(num3 * 2061371682) ^ -750019550;
				continue;
			case 25u:
				gclass31_0.ClassicControllerState.RawTriggerR = (byte)(byte_2[int_14 + 3] & 0x1Fu);
				gclass31_0.ClassicControllerState.ButtonState.TriggerR = (byte_2[int_14 + 4] & 2) == 0;
				gclass31_0.ClassicControllerState.ButtonState.Plus = (byte_2[int_14 + 4] & 4) == 0;
				num = ((int)num3 * -165341360) ^ -287169071;
				continue;
			case 24u:
				gclass31_0.BalanceBoardState.WeightKg = (gclass31_0.BalanceBoardState.SensorValuesKg.TopLeft + gclass31_0.BalanceBoardState.SensorValuesKg.TopRight + gclass31_0.BalanceBoardState.SensorValuesKg.BottomLeft + gclass31_0.BalanceBoardState.SensorValuesKg.BottomRight) / 4f;
				num = (int)(num3 * 9290134) ^ -850356075;
				continue;
			case 22u:
				gclass31_0.NunchukState.RawJoystick.X = byte_2[int_14];
				num = -1623282321;
				continue;
			case 21u:
				gclass31_0.DrumsState.PedalVelocity = num4;
				num = -339463358;
				continue;
			case 20u:
				switch (num11)
				{
				case 27:
					break;
				default:
					goto IL_1748;
				case 25:
					goto IL_1d71;
				case 26:
					return;
				}
				goto case 21u;
			case 19u:
				gclass31_0.ClassicControllerState.ButtonState.B = (byte_2[int_14 + 5] & 0x40) == 0;
				gclass31_0.ClassicControllerState.ButtonState.ZL = (byte_2[int_14 + 5] & 0x80) == 0;
				num = ((int)num3 * -647143089) ^ -725707298;
				continue;
			case 18u:
				num4 = byte_2[int_14 + 3] >> 5;
				num = (int)((num3 * 136311733) ^ 0x762D4640);
				continue;
			case 17u:
				gclass31_0.NunchukState.C = (byte_2[int_14 + 5] & 2) == 0;
				num = ((int)num3 * -1766932998) ^ 0x13AD023A;
				continue;
			case 16u:
			{
				int num9;
				int num10;
				if (extensionType != GEnum9.Drums)
				{
					num9 = -1091566477;
					num10 = -1091566477;
				}
				else
				{
					num9 = -1220577511;
					num10 = -1220577511;
				}
				num = num9 ^ ((int)num3 * -761238373);
				continue;
			}
			case 15u:
				gclass31_0.ClassicControllerState.JoystickR.Y = ((float)gclass31_0.ClassicControllerState.RawJoystickR.Y - (float)(int)gclass31_0.ClassicControllerState.CalibrationInfo.MidYR) / (float)(gclass31_0.ClassicControllerState.CalibrationInfo.MaxYR - gclass31_0.ClassicControllerState.CalibrationInfo.MinYR);
				num = ((int)num3 * -2131274301) ^ 0x1B9868AB;
				continue;
			case 14u:
				gclass31_0.DrumsState.Orange = (byte_2[int_14 + 5] & 0x80) == 0;
				gclass31_0.DrumsState.Joystick.X = (float)(gclass31_0.DrumsState.RawJoystick.X - 31) / 63f;
				num = (int)((num3 * 1296181050) ^ 0x5CED111F);
				continue;
			case 11u:
				gclass31_0.DrumsState.Red = (byte_2[int_14 + 5] & 0x40) == 0;
				num = ((int)num3 * -884404354) ^ 0x101FA4EE;
				continue;
			case 10u:
			{
				int num5;
				int num6;
				if (num4 == 7)
				{
					num5 = -825296194;
					num6 = -825296194;
				}
				else
				{
					num5 = -93105757;
					num6 = -93105757;
				}
				num = num5 ^ ((int)num3 * -439962325);
				continue;
			}
			case 9u:
				goto end_IL_1b6f;
			case 8u:
				gclass31_0.ClassicControllerState.ButtonState.Y = (byte_2[int_14 + 5] & 0x20) == 0;
				num = (int)((num3 * 747376464) ^ 0x791DBCD9);
				continue;
			case 6u:
				gclass31_0.ClassicControllerState.JoystickL.X = ((float)gclass31_0.ClassicControllerState.RawJoystickL.X - (float)(int)gclass31_0.ClassicControllerState.CalibrationInfo.MidXL) / (float)(gclass31_0.ClassicControllerState.CalibrationInfo.MaxXL - gclass31_0.ClassicControllerState.CalibrationInfo.MinXL);
				num = (int)((num3 * 245398731) ^ 0x6AFD2B35);
				continue;
			case 4u:
				gclass31_0.NunchukState.Joystick.X = ((float)gclass31_0.NunchukState.RawJoystick.X - (float)(int)gclass31_0.NunchukState.CalibrationInfo.MidX) / ((float)(int)gclass31_0.NunchukState.CalibrationInfo.MaxX - (float)(int)gclass31_0.NunchukState.CalibrationInfo.MinX);
				num = ((int)num3 * -426674260) ^ 0x1FE0C7E4;
				continue;
			case 3u:
				gclass31_0.ClassicControllerState.ButtonState.Home = (byte_2[int_14 + 4] & 8) == 0;
				gclass31_0.ClassicControllerState.ButtonState.Minus = (byte_2[int_14 + 4] & 0x10) == 0;
				num = ((int)num3 * -632454269) ^ 0x71741119;
				continue;
			case 2u:
				gclass31_0.NunchukState.RawJoystick.Y = byte_2[int_14 + 1];
				num = (int)(num3 * 891691855) ^ -389084378;
				continue;
			case 1u:
				gclass31_0.BalanceBoardState.SensorValuesRaw.TopRight = (short)((byte_2[int_14] << 8) | byte_2[int_14 + 1]);
				gclass31_0.BalanceBoardState.SensorValuesRaw.BottomRight = (short)((byte_2[int_14 + 2] << 8) | byte_2[int_14 + 3]);
				num = -2103992952;
				continue;
			default:
				return;
			case 12u:
				goto IL_1d60;
			case 7u:
				goto IL_1d71;
			case 23u:
				gclass31_0.GuitarState.TouchbarState.Yellow = true;
				return;
			case 13u:
				goto IL_1d9a;
			case 28u:
				goto IL_1db1;
			case 5u:
				goto IL_1dc8;
			case 35u:
				return;
			case 43u:
				return;
			case 52u:
				return;
			case 56u:
				return;
			case 64u:
				gclass31_0.GuitarState.TouchbarState.Orange = true;
				return;
			case 65u:
				return;
			case 66u:
				return;
			case 69u:
				return;
			case 75u:
				return;
			case 80u:
				return;
			case 84u:
				return;
			case 90u:
				return;
			case 92u:
				goto IL_1e01;
			case 98u:
				return;
			case 99u:
				return;
			case 101u:
				return;
			case 108u:
				{
					gclass31_0.GuitarState.TouchbarState.Orange = true;
					return;
				}
				IL_1d71:
				gclass31_0.DrumsState.RedVelocity = num4;
				return;
				IL_1748:
				num = ((int)num3 * -1006475004) ^ 0x72A261EA;
				continue;
				IL_1dc8:
				gclass31_0.GuitarState.TouchbarState.Blue = true;
				return;
				IL_1db1:
				gclass31_0.GuitarState.TouchbarState.Yellow = true;
				return;
				IL_1d9a:
				gclass31_0.GuitarState.TouchbarState.Red = true;
				return;
				IL_1535:
				gclass31_0.GuitarState.TouchbarState.Green = true;
				num = -1017982335;
				continue;
				IL_1522:
				num = ((int)num3 * -636185865) ^ -475596706;
				continue;
				IL_1e01:
				gclass31_0.DrumsState.GreenVelocity = num4;
				return;
				IL_1317:
				num = ((int)num3 * -1561724898) ^ -11673988;
				continue;
				IL_1153:
				gclass31_0.GuitarState.TouchbarState.Green = true;
				num = -2080073910;
				continue;
				IL_1029:
				gclass31_0.DrumsState.YellowVelocity = num4;
				num = -1234283805;
				continue;
				IL_0f93:
				num = (int)((num3 * 2108516289) ^ 0x40647560);
				continue;
				IL_0f28:
				gclass31_0.DrumsState.BlueVelocity = num4;
				num = -2049110737;
				continue;
				IL_0d4b:
				gclass31_0.GuitarState.GuitarType = (((byte_2[int_14] & 0x80) == 0) ? GEnum13.GuitarHeroWorldTour : GEnum13.GuitarHero3);
				gclass31_0.GuitarState.ButtonState.Plus = (byte_2[int_14 + 4] & 4) == 0;
				num = -1085922499;
				continue;
				IL_092a:
				gclass31_0.GuitarState.TouchbarState.Yellow = true;
				gclass31_0.GuitarState.TouchbarState.Blue = true;
				num = -1106585955;
				continue;
				IL_090a:
				gclass31_0.GuitarState.TouchbarState.Red = true;
				num = -527442177;
				continue;
			}
			int num28;
			if (gclass31_0.NunchukState.CalibrationInfo.MaxY == 0)
			{
				num = -885126007;
				num28 = -885126007;
			}
			else
			{
				num = -1491405866;
				num28 = -1491405866;
			}
			continue;
			IL_1270:
			int num29;
			if (gclass31_0.ClassicControllerState.CalibrationInfo.MaxTriggerR != 0)
			{
				num = -1604413167;
				num29 = -1604413167;
			}
			else
			{
				num = -885126007;
				num29 = -885126007;
			}
			continue;
			IL_0cd9:
			int num30;
			if (gclass31_0.ClassicControllerState.CalibrationInfo.MaxXR == 0)
			{
				num = -1469391724;
				num30 = -1469391724;
			}
			else
			{
				num = -589086973;
				num30 = -589086973;
			}
			continue;
			IL_0960:
			int num31;
			if (gclass31_0.ClassicControllerState.CalibrationInfo.MaxTriggerL != 0)
			{
				num = -1469045329;
				num31 = -1469045329;
			}
			else
			{
				num = -1937456576;
				num31 = -1937456576;
			}
			continue;
			IL_0f43:
			int num32;
			if (gclass31_0.ClassicControllerState.CalibrationInfo.MaxYR != 0)
			{
				num = -1492546670;
				num32 = -1492546670;
			}
			else
			{
				num = -256430331;
				num32 = -256430331;
			}
			continue;
			IL_0120:
			int num33;
			if (gclass31_0.ClassicControllerState.CalibrationInfo.MaxYL == 0)
			{
				num = -887549170;
				num33 = -887549170;
			}
			else
			{
				num = -1016425103;
				num33 = -1016425103;
			}
			continue;
			end_IL_1b6f:
			break;
		}
		goto IL_1969;
		IL_1969:
		num = -363795818;
		goto IL_1b6f;
	}

	private float method_13(short short_1, short short_2, short short_3, short short_4)
	{
		if (short_4 != short_3)
		{
			while (true)
			{
				int num = -1304825730;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFC76D4EEu) % 6u)
					{
					case 4u:
					{
						int num3;
						int num4;
						if (short_3 != short_2)
						{
							num3 = 850795200;
							num4 = 850795200;
						}
						else
						{
							num3 = 263680471;
							num4 = 263680471;
						}
						num = num3 ^ (int)(num2 * 1368940671);
						continue;
					}
					case 2u:
						break;
					case 0u:
						goto end_IL_004a;
					default:
						return 68f * ((float)(short_1 - short_3) / (float)(short_4 - short_3)) + 68f;
					case 5u:
						return 68f * ((float)(short_1 - short_2) / (float)(short_3 - short_2));
					case 1u:
						goto end_IL_0073;
					}
					int num5;
					if (short_1 >= short_3)
					{
						num = -205790641;
						num5 = -205790641;
					}
					else
					{
						num = -1246874465;
						num5 = -1246874465;
					}
					continue;
					end_IL_004a:
					break;
				}
				continue;
				end_IL_0073:
				break;
			}
		}
		return 0f;
	}

	private void method_14(byte[] byte_2)
	{
		if ((byte_2[3] & 8u) != 0)
		{
			goto IL_003a;
		}
		goto IL_0108;
		IL_0108:
		int num;
		int num2;
		if ((byte_2[3] & 7) == 0)
		{
			num = -588820065;
			num2 = -588820065;
		}
		else
		{
			num = -372390631;
			num2 = -372390631;
		}
		goto IL_00bf;
		IL_00bf:
		int num5 = default(int);
		int num4 = default(int);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0x8CD38E3Fu) % 10u)
			{
			case 8u:
				autoResetEvent_0.Set();
				num = (int)(num3 * 999056102) ^ -99272372;
				continue;
			case 6u:
				break;
			case 5u:
				num5 = (byte_2[4] << 8) | byte_2[5];
				num = (int)(num3 * 1537656918) ^ -1480949412;
				continue;
			case 3u:
				Array.Copy(byte_2, 6, byte_1, num5 - int_13, num4);
				num = ((int)num3 * -813621697) ^ 0x303CD404;
				continue;
			case 2u:
			{
				int num6;
				int num7;
				if (int_13 + short_0 == num5 + num4)
				{
					num6 = -27860185;
					num7 = -27860185;
				}
				else
				{
					num6 = -332673968;
					num7 = -332673968;
				}
				num = num6 ^ (int)(num3 * 2098162919);
				continue;
			}
			case 0u:
				num4 = (byte_2[3] >> 4) + 1;
				num = -1351396768;
				continue;
			default:
				return;
			case 9u:
				goto IL_0108;
			case 4u:
				throw new GException1("Error reading data from Wiimote: Attempt to read from write-only registers.");
			case 7u:
				throw new GException1("Error reading data from Wiimote: Bytes do not exist.");
			case 1u:
				return;
			}
			break;
		}
		goto IL_003a;
		IL_003a:
		num = -1117463434;
		goto IL_00bf;
	}

	private byte method_15()
	{
		return (byte)(gclass31_0.Rumble ? 1u : 0u);
	}

	private void method_16()
	{
		byte[] array = method_27(22, 7);
		gclass31_0.AccelCalibrationInfo.X0 = array[0];
		gclass31_0.AccelCalibrationInfo.Y0 = array[1];
		while (true)
		{
			int num = -1121183262;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9CF66BFCu) % 3u)
				{
				case 2u:
					goto IL_0032;
				case 0u:
					break;
				default:
					gclass31_0.AccelCalibrationInfo.XG = array[4];
					gclass31_0.AccelCalibrationInfo.YG = array[5];
					gclass31_0.AccelCalibrationInfo.ZG = array[6];
					return;
				}
				break;
				IL_0032:
				gclass31_0.AccelCalibrationInfo.Z0 = array[2];
				num = (int)(num2 * 1744106656) ^ -1101659027;
			}
		}
	}

	public void method_17(GEnum11 genum11_0, bool bool_1)
	{
		method_18(genum11_0, GEnum12.Maximum, bool_1);
	}

	public void method_18(GEnum11 genum11_0, GEnum12 genum12_0, bool bool_1)
	{
		if (gclass31_0.ExtensionType == GEnum9.BalanceBoard)
		{
			goto IL_0019;
		}
		goto IL_013e;
		IL_013e:
		GEnum11 gEnum = genum11_0;
		int num = 1315408991;
		goto IL_00f8;
		IL_00f8:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x56E2D99u) % 13u)
			{
			case 12u:
				break;
			case 11u:
				method_24();
				num = 1979589805;
				continue;
			case 10u:
			{
				int num5;
				int num6;
				if (gEnum == GEnum11.IRExtensionAccel)
				{
					num5 = 860752251;
					num6 = 860752251;
				}
				else
				{
					num5 = 1249293277;
					num6 = 1249293277;
				}
				num = num5 ^ (int)(num2 * 222090213);
				continue;
			}
			case 9u:
				genum11_0 = GEnum11.ButtonsExtension;
				num = (int)(num2 * 1119129575) ^ -1277567202;
				continue;
			case 7u:
			{
				int num3;
				int num4;
				if (gEnum == GEnum11.IRAccel)
				{
					num3 = 1167783141;
					num4 = 1167783141;
				}
				else
				{
					num3 = 437989122;
					num4 = 437989122;
				}
				num = num3 ^ ((int)num2 * -1759309364);
				continue;
			}
			case 6u:
				num = (int)(num2 * 1780283293) ^ -1089744337;
				continue;
			case 5u:
				method_23(GEnum10.Extended, genum12_0);
				num = 829068245;
				continue;
			case 4u:
				num = (int)(num2 * 1757365636) ^ -2121351267;
				continue;
			case 3u:
				byte_0[0] = 18;
				num = (int)(num2 * 1035877181) ^ -1072538862;
				continue;
			case 1u:
				method_25();
				num = 115826406;
				continue;
			case 0u:
				method_23(GEnum10.Basic, genum12_0);
				num = 1979589805;
				continue;
			case 2u:
				goto IL_013e;
			default:
				byte_0[1] = (byte)((bool_1 ? 4u : 0u) | (byte)(gclass31_0.Rumble ? 1u : 0u));
				byte_0[2] = (byte)genum11_0;
				method_26();
				return;
			}
			break;
		}
		goto IL_0019;
		IL_0019:
		num = 532842978;
		goto IL_00f8;
	}

	public void method_19(bool bool_1, bool bool_2, bool bool_3, bool bool_4)
	{
		gclass31_0.LEDState.LED1 = bool_1;
		gclass31_0.LEDState.LED2 = bool_2;
		gclass31_0.LEDState.LED3 = bool_3;
		while (true)
		{
			int num = 1195549089;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x78E8336Bu) % 6u)
				{
				case 5u:
					method_26();
					num = ((int)num2 * -446073358) ^ 0x422784E8;
					continue;
				case 4u:
					byte_0[1] = (byte)((bool_1 ? 16u : 0u) | (bool_2 ? 32u : 0u) | (bool_3 ? 64u : 0u) | (bool_4 ? 128u : 0u) | method_15());
					num = 1045310062;
					continue;
				case 2u:
					gclass31_0.LEDState.LED4 = bool_4;
					num = ((int)num2 * -1239578730) ^ 0x21C0E1F2;
					continue;
				case 1u:
					method_25();
					byte_0[0] = 17;
					num = ((int)num2 * -809936280) ^ -1442734577;
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public void method_20(int int_14)
	{
		gclass31_0.LEDState.LED1 = (int_14 & 1) > 0;
		while (true)
		{
			int num = -1530338080;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8A6878CFu) % 7u)
				{
				case 6u:
					byte_0[0] = 17;
					num = (int)(num2 * 1777379819) ^ -1614234346;
					continue;
				case 5u:
					method_26();
					num = (int)((num2 * 1843246264) ^ 0x1404EACB);
					continue;
				case 4u:
					byte_0[1] = (byte)((((int_14 & 1) > 0) ? 16u : 0u) | (((int_14 & 2) > 0) ? 32u : 0u) | (((int_14 & 4) > 0) ? 64u : 0u) | (((int_14 & 8) > 0) ? 128u : 0u) | method_15());
					num = -429925381;
					continue;
				case 2u:
					gclass31_0.LEDState.LED3 = (int_14 & 4) > 0;
					gclass31_0.LEDState.LED4 = (int_14 & 8) > 0;
					method_25();
					num = (int)((num2 * 234743589) ^ 0x18A2B9CE);
					continue;
				case 1u:
					gclass31_0.LEDState.LED2 = (int_14 & 2) > 0;
					num = ((int)num2 * -789568992) ^ 0x2E20A08F;
					continue;
				default:
					return;
				case 3u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public void method_21(bool bool_1)
	{
		gclass31_0.Rumble = bool_1;
		while (true)
		{
			int num = 793296607;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x46C631BEu) % 3u)
				{
				case 1u:
					goto IL_000e;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_000e:
				method_19(gclass31_0.LEDState.LED1, gclass31_0.LEDState.LED2, gclass31_0.LEDState.LED3, gclass31_0.LEDState.LED4);
				num = ((int)num2 * -2080783142) ^ 0x124AFA89;
			}
		}
	}

	public void method_22()
	{
		method_25();
		while (true)
		{
			int num = 1715799310;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x13E0EC0Cu) % 6u)
				{
				case 4u:
					byte_0[0] = 21;
					num = ((int)num2 * -869771549) ^ 0x6D07E761;
					continue;
				case 1u:
					byte_0[1] = method_15();
					method_26();
					num = ((int)num2 * -1993455311) ^ -1235701229;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (autoResetEvent_2.WaitOne(3000, exitContext: false))
					{
						num3 = -1228031040;
						num4 = -1228031040;
					}
					else
					{
						num3 = -109697813;
						num4 = -109697813;
					}
					num = num3 ^ (int)(num2 * 1044843247);
					continue;
				}
				default:
					return;
				case 3u:
					break;
				case 5u:
					throw new GException1("Timed out waiting for status report");
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private void method_23(GEnum10 genum10_0, GEnum12 genum12_0)
	{
		gclass31_0.IRState.Mode = genum10_0;
		method_25();
		while (true)
		{
			int num = -526389241;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9A626F3Du) % 24u)
				{
				case 23u:
					method_28(78643251, (byte)genum10_0);
					num = -259966368;
					continue;
				case 22u:
					method_29(78643226, 2, new byte[2] { 179, 4 });
					num = ((int)num2 * -1230712781) ^ 0x6C6BF798;
					continue;
				case 21u:
					method_29(78643226, 2, new byte[2] { 53, 3 });
					num = ((int)num2 * -1498748581) ^ -278787635;
					continue;
				case 19u:
					method_29(78643226, 2, new byte[2] { 1, 3 });
					num = ((int)num2 * -1090866923) ^ -926724571;
					continue;
				case 18u:
					method_29(78643200, 9, new byte[9] { 2, 0, 0, 113, 1, 0, 150, 0, 180 });
					num = -366116909;
					continue;
				case 17u:
					goto IL_00f5;
				case 16u:
					byte_0[0] = 26;
					num = ((int)num2 * -664528998) ^ 0xEB9EF91;
					continue;
				case 15u:
					num = ((int)num2 * -956848016) ^ -1674561054;
					continue;
				case 13u:
					method_28(78643248, 8);
					num = ((int)num2 * -1234778864) ^ 0x7FAA9DF1;
					continue;
				case 12u:
					byte_0[1] = (byte)(4u | method_15());
					method_26();
					method_28(78643248, 8);
					num = ((int)num2 * -976040112) ^ 0x2DAE8538;
					continue;
				case 11u:
					method_29(78643226, 2, new byte[2] { 99, 3 });
					num = ((int)num2 * -1854251767) ^ 0x766AA531;
					continue;
				case 10u:
					byte_0[0] = 19;
					num = (int)((num2 * 627404056) ^ 0x4147336D);
					continue;
				case 9u:
					num = (int)(num2 * 936915689) ^ -1001439149;
					continue;
				case 8u:
					byte_0[1] = (byte)(4u | method_15());
					method_26();
					method_25();
					num = (int)(num2 * 1419633799) ^ -174192899;
					continue;
				case 7u:
					num = (int)(num2 * 772923135) ^ -560378685;
					continue;
				case 6u:
					goto IL_0262;
				case 5u:
					switch (genum12_0)
					{
					case GEnum12.WiiLevel2:
						break;
					case GEnum12.Maximum:
						goto IL_00f5;
					case GEnum12.WiiLevel1:
						goto IL_0262;
					default:
						goto IL_02cb;
					case GEnum12.WiiLevel3:
						goto IL_02de;
					case GEnum12.WiiLevel4:
						goto IL_0304;
					case GEnum12.WiiLevel5:
						goto IL_032a;
					}
					goto case 18u;
				case 1u:
					goto IL_02de;
				case 3u:
					goto IL_0304;
				case 2u:
					goto IL_032a;
				case 4u:
					num = (int)((num2 * 827380229) ^ 0x2E1C1167);
					continue;
				default:
					return;
				case 0u:
					break;
				case 14u:
					throw new ArgumentOutOfRangeException("irSensitivity");
				case 20u:
					return;
					IL_032a:
					method_29(78643200, 9, new byte[9] { 7, 0, 0, 113, 1, 0, 114, 0, 32 });
					num = -255101946;
					continue;
					IL_0304:
					method_29(78643200, 9, new byte[9] { 2, 0, 0, 113, 1, 0, 200, 0, 54 });
					num = -1478665008;
					continue;
					IL_02de:
					method_29(78643200, 9, new byte[9] { 2, 0, 0, 113, 1, 0, 170, 0, 100 });
					num = -748479402;
					continue;
					IL_02cb:
					num = ((int)num2 * -286473415) ^ -1982526708;
					continue;
					IL_0262:
					method_29(78643200, 9, new byte[9] { 2, 0, 0, 113, 1, 0, 100, 0, 254 });
					method_29(78643226, 2, new byte[2] { 253, 5 });
					num = -1366011750;
					continue;
					IL_00f5:
					method_29(78643200, 9, new byte[9] { 2, 0, 0, 113, 1, 0, 144, 0, 65 });
					method_29(78643226, 2, new byte[2] { 64, 0 });
					num = -239170620;
					continue;
				}
				break;
			}
		}
	}

	private void method_24()
	{
		gclass31_0.IRState.Mode = GEnum10.Off;
		method_25();
		while (true)
		{
			int num = -1465826928;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x88AA4058u) % 7u)
				{
				case 6u:
					byte_0[0] = 19;
					num = ((int)num2 * -715134572) ^ 0x787FF872;
					continue;
				case 5u:
					byte_0[1] = method_15();
					method_26();
					num = (int)((num2 * 1225231264) ^ 0x79E39A5D);
					continue;
				case 4u:
					method_26();
					method_25();
					num = (int)(num2 * 378681568) ^ -1582245323;
					continue;
				case 3u:
					byte_0[0] = 26;
					num = (int)((num2 * 1812541415) ^ 0x6F6528DE);
					continue;
				case 0u:
					byte_0[1] = method_15();
					num = (int)((num2 * 1608410014) ^ 0x43B985EB);
					continue;
				default:
					return;
				case 2u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	private void method_25()
	{
		Array.Clear(byte_0, 0, 22);
	}

	private void method_26()
	{
		if (bool_0)
		{
			goto IL_006c;
		}
		goto IL_0108;
		IL_0108:
		int num;
		int num2;
		if (fileStream_0 == null)
		{
			num = 879453137;
			num2 = 879453137;
		}
		else
		{
			num = 855253514;
			num2 = 855253514;
		}
		goto IL_00c8;
		IL_00c8:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0x12BBAE61u) % 8u)
			{
			case 7u:
				Class11.HidD_SetOutputReport(safeFileHandle_0.DangerousGetHandle(), byte_0, (uint)byte_0.Length);
				num = (int)(num3 * 603086922) ^ -745751106;
				continue;
			case 6u:
				autoResetEvent_1.WaitOne(1000, exitContext: false);
				num = ((int)num3 * -795768142) ^ 0x4E2E1007;
				continue;
			case 4u:
				break;
			case 3u:
				fileStream_0.Write(byte_0, 0, 22);
				num = ((int)num3 * -404612620) ^ -1664275667;
				continue;
			case 1u:
				num = ((int)num3 * -2022493291) ^ -1332176660;
				continue;
			case 0u:
				goto IL_00a5;
			default:
				return;
			case 5u:
				goto IL_0108;
			case 2u:
				return;
			}
			break;
			IL_00a5:
			int num4;
			if (byte_0[0] != 22)
			{
				num = 1695058299;
				num4 = 1695058299;
			}
			else
			{
				num = 1370512015;
				num4 = 1370512015;
			}
		}
		goto IL_006c;
		IL_006c:
		num = 895070510;
		goto IL_00c8;
	}

	public byte[] method_27(int int_14, short short_1)
	{
		method_25();
		while (true)
		{
			int num = -617439216;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9C912D6Eu) % 12u)
				{
				case 10u:
					byte_0[0] = 23;
					byte_0[1] = (byte)(((int_14 & 0xFF000000L) >> 24) | method_15());
					num = (int)((num2 * 628158163) ^ 0x481B598F);
					continue;
				case 9u:
					short_0 = short_1;
					num = ((int)num2 * -308144086) ^ 0x5B344B02;
					continue;
				case 8u:
					byte_0[5] = (byte)((short_1 & 0xFF00) >> 8);
					num = (int)(num2 * 222684381) ^ -1694634685;
					continue;
				case 7u:
					byte_0[2] = (byte)((int_14 & 0xFF0000) >> 16);
					num = ((int)num2 * -942849193) ^ 0x5AB9FFB7;
					continue;
				case 6u:
					byte_1 = new byte[short_1];
					int_13 = int_14 & 0xFFFF;
					num = ((int)num2 * -904457743) ^ -1775197887;
					continue;
				case 5u:
					byte_0[6] = (byte)((uint)short_1 & 0xFFu);
					num = ((int)num2 * -863042442) ^ -262084739;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (autoResetEvent_0.WaitOne(1000, exitContext: false))
					{
						num3 = -1922794830;
						num4 = -1922794830;
					}
					else
					{
						num3 = -1723070435;
						num4 = -1723070435;
					}
					num = num3 ^ ((int)num2 * -1706866703);
					continue;
				}
				case 1u:
					method_26();
					num = ((int)num2 * -1890003344) ^ -1346139007;
					continue;
				case 0u:
					byte_0[3] = (byte)((int_14 & 0xFF00) >> 8);
					byte_0[4] = (byte)((uint)int_14 & 0xFFu);
					num = ((int)num2 * -1794430806) ^ 0x49A13A4E;
					continue;
				case 2u:
					break;
				case 4u:
					throw new GException1("Error reading data from Wiimote...is it connected?");
				default:
					return byte_1;
				}
				break;
			}
		}
	}

	public void method_28(int int_14, byte byte_2)
	{
		method_29(int_14, 1, new byte[1] { byte_2 });
	}

	public void method_29(int int_14, byte byte_2, byte[] byte_3)
	{
		method_25();
		byte_0[0] = 22;
		while (true)
		{
			int num = 444650152;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5D84E5BCu) % 8u)
				{
				case 6u:
					byte_0[5] = byte_2;
					num = ((int)num2 * -964514029) ^ -268478930;
					continue;
				case 5u:
					byte_0[2] = (byte)((int_14 & 0xFF0000) >> 16);
					num = (int)((num2 * 1152615229) ^ 0xE23C6CE);
					continue;
				case 4u:
					byte_0[1] = (byte)(((int_14 & 0xFF000000L) >> 24) | method_15());
					num = ((int)num2 * -359757802) ^ 0x3004C611;
					continue;
				case 3u:
					byte_0[3] = (byte)((int_14 & 0xFF00) >> 8);
					num = ((int)num2 * -124531424) ^ 0x1D206385;
					continue;
				case 1u:
					byte_0[4] = (byte)((uint)int_14 & 0xFFu);
					num = (int)(num2 * 1717940749) ^ -482513969;
					continue;
				case 0u:
					Array.Copy(byte_3, 0, byte_0, 6, byte_2);
					method_26();
					num = (int)(num2 * 872989659) ^ -2053317205;
					continue;
				default:
					return;
				case 2u:
					break;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	public void Dispose()
	{
		vmethod_0(bool_1: true);
		while (true)
		{
			int num = 76274811;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2F2C1E5Fu) % 3u)
				{
				case 2u:
					goto IL_0009;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0009:
				GC.SuppressFinalize(this);
				num = ((int)num2 * -1201014042) ^ -1165714386;
			}
		}
	}

	protected virtual void vmethod_0(bool bool_1)
	{
		if (!bool_1)
		{
			return;
		}
		while (true)
		{
			int num = 172708000;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x29220021u) % 3u)
				{
				case 1u:
					goto IL_0005;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0005:
				method_3();
				num = (int)(num2 * 36749281) ^ -981879057;
			}
		}
	}
}
