using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;

public sealed class GClass42
{
	private sealed class Class18 : IDisposable
	{
		private bool bool_0 = false;

		private int int_0 = 1;

		private Class20 class20_0 = new Class20(IntPtr.Zero);

		private bool bool_1 = false;

		private static Class20 class20_1 = new Class20(IntPtr.Zero);

		private static readonly object object_0 = new object();

		public int Int32_0
		{
			get
			{
				int result = default(int);
				while (true)
				{
					int num = 122033318;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x59F2DDFFu) % 4u)
						{
						case 3u:
							num = (int)(num2 * 102196733) ^ -939647354;
							continue;
						case 1u:
							result = int_0;
							num = ((int)num2 * -708808850) ^ 0x202E45B6;
							continue;
						case 0u:
							break;
						default:
							return result;
						}
						break;
					}
				}
			}
		}

		public Class20 Class20_0 => class20_0;

		public bool Boolean_0
		{
			get
			{
				bool result = default(bool);
				while (true)
				{
					int num = -1537448824;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x93D837BCu) % 3u)
						{
						case 1u:
							goto IL_0003;
						case 0u:
							break;
						default:
							return result;
						}
						break;
						IL_0003:
						result = bool_1;
						num = ((int)num2 * -372924785) ^ -2030653150;
					}
				}
			}
		}

		public Class18()
		{
			int num = 0;
			int num2 = 0;
			bool flag = true;
			if (class20_1.IsInvalid)
			{
				lock (object_0)
				{
					if (class20_1.IsInvalid && !Class17.OpenProcessToken(Class17.GetCurrentProcess(), TokenAccessLevels.Duplicate, ref class20_1))
					{
						num2 = Marshal.GetLastWin32Error();
						flag = false;
					}
				}
			}
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
				if (!Class17.OpenThreadToken(Class17.GetCurrentThread(), TokenAccessLevels.Query | TokenAccessLevels.AdjustPrivileges, bool_0: true, ref class20_0))
				{
					if (flag)
					{
						num = Marshal.GetLastWin32Error();
						if (num != 1008)
						{
							flag = false;
						}
						if (flag)
						{
							num = 0;
							if (!Class17.DuplicateTokenEx(class20_1, TokenAccessLevels.Impersonate | TokenAccessLevels.Query | TokenAccessLevels.AdjustPrivileges, IntPtr.Zero, Class17.Enum4.Impersonation, Class17.Enum5.Impersonation, ref class20_0))
							{
								num = Marshal.GetLastWin32Error();
								flag = false;
							}
						}
						if (flag && !Class17.SetThreadToken(IntPtr.Zero, class20_0))
						{
							num = Marshal.GetLastWin32Error();
							flag = false;
						}
						if (flag)
						{
							bool_1 = true;
						}
					}
					else
					{
						num = num2;
					}
				}
				else
				{
					flag = true;
				}
			}
			finally
			{
				if (!flag)
				{
					Dispose();
				}
			}
			switch (num)
			{
			case 8:
				throw new OutOfMemoryException();
			default:
				if (num != 1347)
				{
					if (num != 0)
					{
						throw new Win32Exception(num);
					}
					break;
				}
				goto case 5;
			case 5:
				throw new UnauthorizedAccessException("The caller does not have the rights to perform the operation");
			}
		}

		void object.Finalize()
		{
			try
			{
				while (true)
				{
					int num = 391248511;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x4C795F11u) % 6u)
						{
						case 5u:
							num = (int)(num2 * 1355198220) ^ -1587959430;
							continue;
						case 4u:
						{
							int num3;
							int num4;
							if (bool_0)
							{
								num3 = -1602383536;
								num4 = -1602383536;
							}
							else
							{
								num3 = -1611135351;
								num4 = -1611135351;
							}
							num = num3 ^ (int)(num2 * 216969201);
							continue;
						}
						case 3u:
							method_0(bool_2: false);
							num = ((int)num2 * -1591293980) ^ -837903018;
							continue;
						case 2u:
							num = ((int)num2 * -12501210) ^ 0x6FA32674;
							continue;
						default:
							return;
						case 0u:
							break;
						case 1u:
							return;
						}
						break;
					}
				}
			}
			finally
			{
				base.Finalize();
			}
		}

		public void Dispose()
		{
			while (true)
			{
				int num = -181456147;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8038E38Du) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 2u:
						break;
					default:
						GC.SuppressFinalize(this);
						return;
					}
					break;
					IL_0003:
					method_0(bool_2: true);
					num = ((int)num2 * -833136231) ^ 0x5C5F2A6;
				}
			}
		}

		private void method_0(bool bool_2)
		{
			bool flag = bool_0;
			bool flag2 = default(bool);
			while (true)
			{
				int num = -474615075;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBC50CF42u) % 13u)
					{
					case 12u:
						class20_0 = null;
						num = (int)(num2 * 1489430773) ^ -275959130;
						continue;
					case 11u:
					{
						int num5;
						if (bool_1)
						{
							num = -1454431796;
							num5 = -1454431796;
						}
						else
						{
							num = -2144641919;
							num5 = -2144641919;
						}
						continue;
					}
					case 10u:
						bool_0 = true;
						num = -1760594804;
						continue;
					case 9u:
					{
						int num6;
						int num7;
						if (flag2)
						{
							num6 = -960977346;
							num7 = -960977346;
						}
						else
						{
							num6 = -2073611080;
							num7 = -2073611080;
						}
						num = num6 ^ (int)(num2 * 841618303);
						continue;
					}
					case 8u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1352470253;
							num4 = -1352470253;
						}
						else
						{
							num3 = -193595829;
							num4 = -193595829;
						}
						num = num3 ^ ((int)num2 * -1432012226);
						continue;
					}
					case 6u:
						Class17.RevertToSelf();
						num = ((int)num2 * -1026090225) ^ 0x1062A8D3;
						continue;
					case 4u:
						class20_0.Dispose();
						num = (int)((num2 * 1950226703) ^ 0x3418749C);
						continue;
					case 3u:
						num = (int)(num2 * 1428024667) ^ -332279975;
						continue;
					case 2u:
						num = ((int)num2 * -509018200) ^ 0x3A93E3F4;
						continue;
					case 1u:
						num = (int)((num2 * 533532804) ^ 0x3033ABA7);
						continue;
					case 0u:
						flag2 = class20_0 != null;
						num = -749318069;
						continue;
					default:
						return;
					case 5u:
						break;
					case 7u:
						return;
					}
					break;
				}
			}
		}

		public void method_1()
		{
			while (true)
			{
				int num = -1217405649;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9FE36977u) % 3u)
					{
					case 1u:
						goto IL_0003;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
					IL_0003:
					int_0++;
					num = ((int)num2 * -72121575) ^ -1452183624;
				}
			}
		}

		public int method_2()
		{
			int num3 = default(int);
			int result = default(int);
			while (true)
			{
				int num = 1456649040;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6F3EBD38u) % 7u)
					{
					case 6u:
						Dispose();
						num = ((int)num2 * -1025275634) ^ 0x21ABD7EE;
						continue;
					case 4u:
					{
						int num4;
						int num5;
						if (num3 != 0)
						{
							num4 = -2044769745;
							num5 = -2044769745;
						}
						else
						{
							num4 = -2015456628;
							num5 = -2015456628;
						}
						num = num4 ^ ((int)num2 * -2037382174);
						continue;
					}
					case 3u:
						num3 = --int_0;
						num = ((int)num2 * -857917465) ^ 0x15E03735;
						continue;
					case 2u:
						num = (int)(num2 * 834568636) ^ -1467587683;
						continue;
					case 1u:
						result = num3;
						num = 1571219306;
						continue;
					case 0u:
						break;
					default:
						return result;
					}
					break;
				}
			}
		}
	}

	private static LocalDataStoreSlot localDataStoreSlot_0 = Thread.AllocateDataSlot();

	private static HybridDictionary hybridDictionary_0 = new HybridDictionary();

	private static HybridDictionary hybridDictionary_1;

	private static ReaderWriterLock readerWriterLock_0;

	private bool bool_0 = false;

	private bool bool_1 = false;

	private bool bool_2 = false;

	private Class17.Struct8 struct8_0;

	private readonly Thread thread_0 = Thread.CurrentThread;

	private Class18 class18_0 = null;

	public const string string_0 = "SeCreateTokenPrivilege";

	public const string string_1 = "SeAssignPrimaryTokenPrivilege";

	public const string string_2 = "SeLockMemoryPrivilege";

	public const string string_3 = "SeIncreaseQuotaPrivilege";

	public const string string_4 = "SeUnsolicitedInputPrivilege";

	public const string string_5 = "SeMachineAccountPrivilege";

	public const string string_6 = "SeTcbPrivilege";

	public const string string_7 = "SeSecurityPrivilege";

	public const string string_8 = "SeTakeOwnershipPrivilege";

	public const string string_9 = "SeLoadDriverPrivilege";

	public const string string_10 = "SeSystemProfilePrivilege";

	public const string string_11 = "SeSystemtimePrivilege";

	public const string string_12 = "SeProfileSingleProcessPrivilege";

	public const string string_13 = "SeIncreaseBasePriorityPrivilege";

	public const string string_14 = "SeCreatePagefilePrivilege";

	public const string string_15 = "SeCreatePermanentPrivilege";

	public const string string_16 = "SeBackupPrivilege";

	public const string string_17 = "SeRestorePrivilege";

	public const string string_18 = "SeShutdownPrivilege";

	public const string string_19 = "SeDebugPrivilege";

	public const string string_20 = "SeAuditPrivilege";

	public const string string_21 = "SeSystemEnvironmentPrivilege";

	public const string string_22 = "SeChangeNotifyPrivilege";

	public const string string_23 = "SeRemoteShutdownPrivilege";

	public const string string_24 = "SeUndockPrivilege";

	public const string string_25 = "SeSyncAgentPrivilege";

	public const string string_26 = "SeEnableDelegationPrivilege";

	public const string string_27 = "SeManageVolumePrivilege";

	public const string string_28 = "SeImpersonatePrivilege";

	public const string string_29 = "SeCreateGlobalPrivilege";

	public const string string_30 = "SeTrustedCredManAccessPrivilege";

	public const string string_31 = "SeReserveProcessorPrivilege";

	public bool Boolean_0
	{
		get
		{
			bool result = default(bool);
			while (true)
			{
				int num = -1306288137;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEE485EC2u) % 4u)
					{
					case 1u:
						result = bool_0;
						num = (int)((num2 * 1208253153) ^ 0x5572306F);
						continue;
					case 0u:
						num = (int)(num2 * 659976219) ^ -1687919496;
						continue;
					case 3u:
						break;
					default:
						return result;
					}
					break;
				}
			}
		}
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	private static Class17.Struct8 smethod_0(string string_32)
	{
		Class17.Struct8 @struct = default(Class17.Struct8);
		bool flag4 = default(bool);
		int lastWin32Error = default(int);
		bool flag = default(bool);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		bool flag5 = default(bool);
		bool isWriterLockHeld = default(bool);
		while (true)
		{
			int num = -1410831778;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC5D53B43u) % 4u)
				{
				case 2u:
					RuntimeHelpers.PrepareConstrainedRegions();
					num = (int)((num2 * 896337909) ^ 0x9E36F9E);
					continue;
				case 1u:
					@struct.uint_0 = 0u;
					@struct.uint_1 = 0u;
					num = ((int)num2 * -1656035308) ^ -1966214999;
					continue;
				case 0u:
					break;
				default:
				{
					try
					{
						readerWriterLock_0.AcquireReaderLock(-1);
						while (true)
						{
							IL_02ed:
							int num3 = -1958752061;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xC5D53B43u) % 26u)
								{
								case 25u:
									flag4 = lastWin32Error == 1313;
									num3 = -1201501610;
									continue;
								case 24u:
									@struct = (Class17.Struct8)hybridDictionary_1[string_32];
									num3 = ((int)num2 * -706376877) ^ 0x17F59C07;
									continue;
								case 23u:
									num3 = -1199484924;
									continue;
								case 22u:
									num3 = -799784348;
									continue;
								case 21u:
									num3 = -1660764429;
									continue;
								case 20u:
									flag = hybridDictionary_1.Contains(string_32);
									num3 = (int)((num2 * 319670362) ^ 0x5B014624);
									continue;
								case 17u:
								{
									int num7;
									int num8;
									if (flag3)
									{
										num7 = 757513669;
										num8 = 757513669;
									}
									else
									{
										num7 = 889107339;
										num8 = 889107339;
									}
									num3 = num7 ^ ((int)num2 * -2017407851);
									continue;
								}
								case 16u:
									readerWriterLock_0.ReleaseReaderLock();
									num3 = ((int)num2 * -281875446) ^ 0x5A011133;
									continue;
								case 15u:
									readerWriterLock_0.ReleaseReaderLock();
									num3 = ((int)num2 * -646633014) ^ -295607139;
									continue;
								case 14u:
									lastWin32Error = Marshal.GetLastWin32Error();
									num3 = (int)((num2 * 1337088885) ^ 0x2D7393A1);
									continue;
								case 13u:
								{
									int num11;
									int num12;
									if (flag4)
									{
										num11 = 65275871;
										num12 = 65275871;
									}
									else
									{
										num11 = 2124161089;
										num12 = 2124161089;
									}
									num3 = num11 ^ ((int)num2 * -122950459);
									continue;
								}
								case 12u:
								{
									int num9;
									int num10;
									if (flag2)
									{
										num9 = -78031579;
										num10 = -78031579;
									}
									else
									{
										num9 = -1289158201;
										num10 = -1289158201;
									}
									num3 = num9 ^ (int)(num2 * 559982990);
									continue;
								}
								case 11u:
									num3 = ((int)num2 * -445431799) ^ -2038931157;
									continue;
								case 10u:
									num3 = ((int)num2 * -398380747) ^ -1328305755;
									continue;
								case 8u:
									flag3 = lastWin32Error == 8;
									num3 = ((int)num2 * -1301214192) ^ 0x3027662;
									continue;
								case 6u:
									readerWriterLock_0.AcquireWriterLock(-1);
									num3 = -251269172;
									continue;
								case 5u:
								{
									int num6;
									if (lastWin32Error != 5)
									{
										num3 = -1498669036;
										num6 = -1498669036;
									}
									else
									{
										num3 = -832318411;
										num6 = -832318411;
									}
									continue;
								}
								case 4u:
									flag2 = !Class17.LookupPrivilegeValueW(null, string_32, ref @struct);
									num3 = (int)((num2 * 1366283026) ^ 0x783D8A13);
									continue;
								case 3u:
								{
									int num4;
									int num5;
									if (flag)
									{
										num4 = 1023818877;
										num5 = 1023818877;
									}
									else
									{
										num4 = 1534410437;
										num5 = 1534410437;
									}
									num3 = num4 ^ (int)(num2 * 1830320186);
									continue;
								}
								case 2u:
									num3 = (int)((num2 * 534405839) ^ 0x6C2BF8F4);
									continue;
								default:
									goto end_IL_0272;
								case 9u:
									break;
								case 0u:
									throw new Win32Exception(lastWin32Error);
								case 1u:
									throw new OutOfMemoryException();
								case 18u:
									throw new UnauthorizedAccessException("Caller does not have the rights to look up privilege local unique identifier");
								case 19u:
									throw new ArgumentException($"{string_32} is not a valid privilege name", "privilege");
								case 7u:
									goto end_IL_0272;
								}
								goto IL_02ed;
								continue;
								end_IL_0272:
								break;
							}
							break;
						}
					}
					finally
					{
						while (true)
						{
							IL_0511:
							int num13 = -1861781282;
							while (true)
							{
								switch ((num2 = (uint)num13 ^ 0xC5D53B43u) % 17u)
								{
								case 14u:
									num13 = ((int)num2 * -1280494081) ^ -1635859424;
									continue;
								case 13u:
									readerWriterLock_0.ReleaseWriterLock();
									num13 = -1350227910;
									continue;
								case 12u:
									flag5 = !hybridDictionary_1.Contains(string_32);
									num13 = (int)((num2 * 1456887975) ^ 0x6E43B4D0);
									continue;
								case 11u:
									readerWriterLock_0.ReleaseReaderLock();
									num13 = (int)(num2 * 2054197827) ^ -633263471;
									continue;
								case 10u:
									hybridDictionary_0[@struct] = string_32;
									num13 = ((int)num2 * -1812997750) ^ -840763543;
									continue;
								case 9u:
									num13 = ((int)num2 * -610440243) ^ 0x6E08CDE7;
									continue;
								case 8u:
								{
									int num18;
									int num19;
									if (!readerWriterLock_0.IsReaderLockHeld)
									{
										num18 = 1544690560;
										num19 = 1544690560;
									}
									else
									{
										num18 = 1370735576;
										num19 = 1370735576;
									}
									num13 = num18 ^ (int)(num2 * 1917778390);
									continue;
								}
								case 7u:
									num13 = (int)((num2 * 221354957) ^ 0x47422ACC);
									continue;
								case 6u:
									isWriterLockHeld = readerWriterLock_0.IsWriterLockHeld;
									num13 = -1106737673;
									continue;
								case 5u:
									hybridDictionary_1[string_32] = @struct;
									num13 = ((int)num2 * -1400340724) ^ -948438567;
									continue;
								case 4u:
									num13 = (int)(num2 * 2129544408) ^ -1814893721;
									continue;
								case 3u:
									num13 = -1763541785;
									continue;
								case 2u:
									num13 = ((int)num2 * -1405467417) ^ 0xED2E445;
									continue;
								case 1u:
								{
									int num16;
									int num17;
									if (flag5)
									{
										num16 = 2098027696;
										num17 = 2098027696;
									}
									else
									{
										num16 = 2072894032;
										num17 = 2072894032;
									}
									num13 = num16 ^ ((int)num2 * -112769836);
									continue;
								}
								case 0u:
								{
									int num14;
									int num15;
									if (isWriterLockHeld)
									{
										num14 = 993642847;
										num15 = 993642847;
									}
									else
									{
										num14 = 1188106762;
										num15 = 1188106762;
									}
									num13 = num14 ^ (int)(num2 * 1990634044);
									continue;
								}
								default:
									goto end_IL_04ba;
								case 15u:
									break;
								case 16u:
									goto end_IL_04ba;
								}
								goto IL_0511;
								continue;
								end_IL_04ba:
								break;
							}
							break;
						}
					}
					Class17.Struct8 result = @struct;
					while (true)
					{
						int num20 = -770878200;
						while (true)
						{
							switch ((num2 = (uint)num20 ^ 0xC5D53B43u) % 3u)
							{
							case 1u:
								goto IL_051e;
							case 2u:
								break;
							default:
								return result;
							}
							break;
							IL_051e:
							num20 = ((int)num2 * -1455860635) ^ -1957355504;
						}
					}
				}
				}
				break;
			}
		}
	}

	public GClass42(string string_32)
	{
		if (string_32 == null)
		{
			throw new ArgumentNullException("privilegeName");
		}
		struct8_0 = smethod_0(string_32);
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public void method_0()
	{
		method_2(bool_3: true);
		while (true)
		{
			int num = 315552248;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4EE8F5A1u) % 3u)
				{
				case 1u:
					goto IL_0009;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0009:
				num = (int)((num2 * 1300738612) ^ 0x332D409C);
			}
		}
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public void method_1()
	{
		bool flag6 = default(bool);
		int num9 = default(int);
		bool flag2 = default(bool);
		Class17.Struct10 struct10_ = default(Class17.Struct10);
		Class17.Struct10 struct10_2 = default(Class17.Struct10);
		uint uint_ = default(uint);
		bool flag3 = default(bool);
		bool flag5 = default(bool);
		while (true)
		{
			int num = 818975824;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x794211B9u) % 8u)
				{
				case 6u:
					flag6 = !thread_0.Equals(Thread.CurrentThread);
					num = (int)(num2 * 845221448) ^ -206751749;
					continue;
				case 3u:
				{
					int num19;
					if (Boolean_0)
					{
						num = 2042200981;
						num19 = 2042200981;
					}
					else
					{
						num = 1761416598;
						num19 = 1761416598;
					}
					continue;
				}
				case 2u:
				{
					int num20;
					int num21;
					if (!flag6)
					{
						num20 = -1989766854;
						num21 = -1989766854;
					}
					else
					{
						num20 = -1737811511;
						num21 = -1737811511;
					}
					num = num20 ^ (int)(num2 * 1672521168);
					continue;
				}
				case 1u:
					num9 = 0;
					num = (int)(num2 * 1581622938) ^ -1048173099;
					continue;
				case 5u:
					break;
				case 0u:
					throw new InvalidOperationException("Operation must take place on the thread that created the object");
				default:
				{
					RuntimeHelpers.PrepareConstrainedRegions();
					try
					{
					}
					finally
					{
						bool flag = true;
						try
						{
							while (true)
							{
								IL_02dc:
								int num3 = 2079880003;
								while (true)
								{
									int num6;
									switch ((num2 = (uint)num3 ^ 0x794211B9u) % 16u)
									{
									case 14u:
									{
										int num4;
										int num5;
										if (!flag2)
										{
											num4 = -1081368145;
											num5 = -1081368145;
										}
										else
										{
											num4 = -758236514;
											num5 = -758236514;
										}
										num3 = num4 ^ (int)(num2 * 1354490349);
										continue;
									}
									case 13u:
									{
										int num7;
										int num8;
										if (!Class17.AdjustTokenPrivileges(class18_0.Class20_0, bool_0: false, ref struct10_, (uint)Marshal.SizeOf((object)struct10_2), ref struct10_2, ref uint_))
										{
											num7 = -1237386997;
											num8 = -1237386997;
										}
										else
										{
											num7 = -499897874;
											num8 = -499897874;
										}
										num3 = num7 ^ ((int)num2 * -1483505130);
										continue;
									}
									case 12u:
										num3 = (int)((num2 * 1460406515) ^ 0x156ED276);
										continue;
									case 11u:
										num9 = Marshal.GetLastWin32Error();
										num3 = (int)(num2 * 1606851529) ^ -112576418;
										continue;
									case 10u:
										if (bool_2)
										{
											num3 = ((int)num2 * -1274811994) ^ 0x7903C090;
											continue;
										}
										num6 = 0;
										goto IL_0197;
									case 9u:
										num3 = 1713941225;
										continue;
									case 8u:
										struct10_.uint_0 = 1u;
										num3 = ((int)num2 * -1306456589) ^ -135809306;
										continue;
									case 7u:
										struct10_.struct9_0.struct8_0 = struct8_0;
										num3 = ((int)num2 * -791346544) ^ 0x252F1DB;
										continue;
									case 6u:
										num3 = ((int)num2 * -566578189) ^ 0x23D421A2;
										continue;
									case 5u:
										if (class18_0.Int32_0 <= 1)
										{
											num3 = (int)(num2 * 658627546) ^ -1165943016;
											continue;
										}
										num6 = 1;
										goto IL_0197;
									case 4u:
										flag = false;
										num3 = ((int)num2 * -1060417794) ^ -1238172121;
										continue;
									case 3u:
										num6 = ((!class18_0.Boolean_0) ? 1 : 0);
										goto IL_0197;
									case 2u:
										struct10_.struct9_0.uint_0 = (bool_1 ? 2u : 0u);
										struct10_2 = default(Class17.Struct10);
										uint_ = 0u;
										num3 = 749228468;
										continue;
									case 1u:
										struct10_ = default(Class17.Struct10);
										num3 = ((int)num2 * -1686148661) ^ -528642726;
										continue;
									default:
										goto end_IL_0289;
									case 15u:
										break;
									case 0u:
										goto end_IL_0289;
										IL_0197:
										flag2 = (byte)num6 != 0;
										num3 = 700364327;
										continue;
									}
									goto IL_02dc;
									continue;
									end_IL_0289:
									break;
								}
								break;
							}
						}
						finally
						{
							while (true)
							{
								IL_0389:
								int num10 = 573805722;
								while (true)
								{
									switch ((num2 = (uint)num10 ^ 0x794211B9u) % 7u)
									{
									case 6u:
										num10 = ((int)num2 * -2115929822) ^ 0x389AA5EA;
										continue;
									case 5u:
									{
										int num11;
										int num12;
										if (flag3)
										{
											num11 = -408737908;
											num12 = -408737908;
										}
										else
										{
											num11 = -457988373;
											num12 = -457988373;
										}
										num10 = num11 ^ (int)(num2 * 84543073);
										continue;
									}
									case 4u:
										num10 = (int)((num2 * 352817937) ^ 0x53D82D8F);
										continue;
									case 2u:
										flag3 = flag;
										num10 = (int)((num2 * 43928557) ^ 0x57F96F41);
										continue;
									case 0u:
										method_3();
										num10 = (int)(num2 * 505150744) ^ -1765088970;
										continue;
									default:
										goto end_IL_035b;
									case 3u:
										break;
									case 1u:
										goto end_IL_035b;
									}
									goto IL_0389;
									continue;
									end_IL_035b:
									break;
								}
								break;
							}
						}
					}
					bool flag4 = num9 == 8;
					while (true)
					{
						int num13 = 1827101132;
						while (true)
						{
							switch ((num2 = (uint)num13 ^ 0x794211B9u) % 11u)
							{
							case 10u:
								num13 = (int)((num2 * 1434621873) ^ 0x1612DBA7);
								continue;
							case 9u:
							{
								int num15;
								int num16;
								if (!flag4)
								{
									num15 = -878628435;
									num16 = -878628435;
								}
								else
								{
									num15 = -1835864003;
									num16 = -1835864003;
								}
								num13 = num15 ^ (int)(num2 * 1878368354);
								continue;
							}
							case 8u:
							{
								int num17;
								int num18;
								if (flag5)
								{
									num17 = 2018157527;
									num18 = 2018157527;
								}
								else
								{
									num17 = 194745416;
									num18 = 194745416;
								}
								num13 = num17 ^ (int)(num2 * 2105041517);
								continue;
							}
							case 7u:
								num13 = ((int)num2 * -1177843208) ^ -1207554702;
								continue;
							case 6u:
							{
								int num14;
								if (num9 != 0)
								{
									num13 = 1555371230;
									num14 = 1555371230;
								}
								else
								{
									num13 = 883146372;
									num14 = 883146372;
								}
								continue;
							}
							case 0u:
								flag5 = num9 == 5;
								num13 = 1721870495;
								continue;
							default:
								return;
							case 3u:
								break;
							case 1u:
								throw new UnauthorizedAccessException("Caller does not have the permission to change the privilege");
							case 2u:
								throw new OutOfMemoryException();
							case 5u:
								throw new Win32Exception(num9);
							case 4u:
								return;
							}
							break;
						}
					}
				}
				case 7u:
					return;
				}
				break;
			}
		}
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	private void method_2(bool bool_3)
	{
		int num = 0;
		Class17.Struct10 struct10_ = default(Class17.Struct10);
		Class17.Struct10 struct10_2 = default(Class17.Struct10);
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num2 = 779176151;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x6AA4B497u) % 9u)
				{
				case 8u:
					num2 = (int)(num3 * 1690857491) ^ -615721930;
					continue;
				case 6u:
					RuntimeHelpers.PrepareConstrainedRegions();
					num2 = 498082018;
					continue;
				case 3u:
				{
					int num18;
					int num19;
					if (!thread_0.Equals(Thread.CurrentThread))
					{
						num18 = 2319545;
						num19 = 2319545;
					}
					else
					{
						num18 = 1651994284;
						num19 = 1651994284;
					}
					num2 = num18 ^ ((int)num3 * -1716487279);
					continue;
				}
				case 2u:
				{
					int num20;
					if (Boolean_0)
					{
						num2 = 474369126;
						num20 = 474369126;
					}
					else
					{
						num2 = 2000516620;
						num20 = 2000516620;
					}
					continue;
				}
				case 1u:
					num2 = ((int)num3 * -1232560218) ^ -1719736583;
					continue;
				case 0u:
					break;
				case 4u:
					throw new InvalidOperationException("Operation must take place on the thread that created the object");
				default:
				{
					try
					{
						while (true)
						{
							IL_0102:
							int num4 = 657192708;
							while (true)
							{
								switch ((num3 = (uint)num4 ^ 0x6AA4B497u) % 3u)
								{
								case 2u:
									goto IL_00d6;
								default:
									goto end_IL_00e4;
								case 0u:
									break;
								case 1u:
									goto end_IL_00e4;
								}
								goto IL_0102;
								IL_00d6:
								num4 = ((int)num3 * -2088166065) ^ -1666912851;
								continue;
								end_IL_00e4:
								break;
							}
							break;
						}
					}
					finally
					{
						try
						{
							class18_0 = Thread.GetData(localDataStoreSlot_0) as Class18;
							if (class18_0 == null)
							{
								goto IL_0312;
							}
							goto IL_03f5;
							IL_03f5:
							class18_0.method_1();
							int num5 = 1651947940;
							goto IL_0386;
							IL_0386:
							while (true)
							{
								switch ((num3 = (uint)num5 ^ 0x6AA4B497u) % 23u)
								{
								case 22u:
									bool_2 = bool_1 != bool_3;
									num5 = (int)((num3 * 1613618030) ^ 0x6C65715B);
									continue;
								case 20u:
									num5 = ((int)num3 * -1469630376) ^ 0x78C463F8;
									continue;
								case 19u:
									num5 = (int)(num3 * 163521737) ^ -1400132505;
									continue;
								case 18u:
									struct10_.struct9_0.uint_0 = (bool_3 ? 2u : 0u);
									struct10_2 = default(Class17.Struct10);
									num5 = 1595370782;
									continue;
								case 17u:
									num = 1300;
									num5 = ((int)num3 * -2147443684) ^ -234012375;
									continue;
								case 16u:
									struct10_.uint_0 = 1u;
									num5 = (int)((num3 * 1714459884) ^ 0x563C89F8);
									continue;
								case 14u:
									struct10_ = default(Class17.Struct10);
									num5 = 24418012;
									continue;
								case 13u:
									num5 = 927322962;
									continue;
								case 12u:
								{
									uint uint_ = 0u;
									flag = !Class17.AdjustTokenPrivileges(class18_0.Class20_0, bool_0: false, ref struct10_, (uint)Marshal.SizeOf((object)struct10_2), ref struct10_2, ref uint_);
									num5 = (int)((num3 * 261895854) ^ 0x1F737C08);
									continue;
								}
								case 11u:
									num5 = ((int)num3 * -998394312) ^ -826053249;
									continue;
								case 10u:
									class18_0 = new Class18();
									Thread.SetData(localDataStoreSlot_0, class18_0);
									num5 = ((int)num3 * -1621172910) ^ 0x6F69E887;
									continue;
								case 9u:
									num5 = ((int)num3 * -1538435333) ^ 0x35A7E648;
									continue;
								case 8u:
									break;
								case 7u:
									struct10_.struct9_0.struct8_0 = struct8_0;
									num5 = (int)(num3 * 1870118363) ^ -418089214;
									continue;
								case 6u:
									num5 = (int)(num3 * 563226439) ^ -363931175;
									continue;
								case 5u:
									bool_1 = (struct10_2.struct9_0.uint_0 & 2) != 0;
									num5 = (int)(num3 * 200928923) ^ -1376358699;
									continue;
								case 4u:
									goto end_IL_0386;
								case 3u:
								{
									int num6;
									int num7;
									if (!flag)
									{
										num6 = -272526145;
										num7 = -272526145;
									}
									else
									{
										num6 = -31142045;
										num7 = -31142045;
									}
									num5 = num6 ^ ((int)num3 * -2048982861);
									continue;
								}
								case 2u:
									num5 = ((int)num3 * -1321958247) ^ 0x44803864;
									continue;
								case 1u:
									bool_0 = class18_0.Boolean_0 || bool_2;
									num5 = 2047891730;
									continue;
								case 0u:
									num = Marshal.GetLastWin32Error();
									num5 = (int)(num3 * 1234075865) ^ -582557835;
									continue;
								default:
									goto end_IL_010f;
								case 15u:
									goto IL_03f5;
								case 21u:
									goto end_IL_010f;
								}
								int num8;
								if (1300 != Marshal.GetLastWin32Error())
								{
									num5 = 62501977;
									num8 = 62501977;
								}
								else
								{
									num5 = 994506989;
									num8 = 994506989;
								}
								continue;
								end_IL_0386:
								break;
							}
							goto IL_0312;
							IL_0312:
							num5 = 1978956626;
							goto IL_0386;
							end_IL_010f:;
						}
						finally
						{
							while (true)
							{
								IL_04c3:
								int num9 = 248465758;
								while (true)
								{
									switch ((num3 = (uint)num9 ^ 0x6AA4B497u) % 8u)
									{
									case 7u:
										num9 = 1139919823;
										continue;
									case 6u:
									{
										int num10;
										int num11;
										if (!flag2)
										{
											num10 = -259316430;
											num11 = -259316430;
										}
										else
										{
											num10 = -2088595560;
											num11 = -2088595560;
										}
										num9 = num10 ^ (int)(num3 * 1175353547);
										continue;
									}
									case 5u:
										num9 = (int)((num3 * 2031520350) ^ 0x5B9F2305);
										continue;
									case 4u:
										method_3();
										num9 = (int)(num3 * 1476781197) ^ -1543993687;
										continue;
									case 2u:
										num9 = (int)((num3 * 683393971) ^ 0x7BA5775E);
										continue;
									case 1u:
										flag2 = !bool_0;
										num9 = ((int)num3 * -66518749) ^ -1876712182;
										continue;
									default:
										goto end_IL_0491;
									case 3u:
										break;
									case 0u:
										goto end_IL_0491;
									}
									goto IL_04c3;
									continue;
									end_IL_0491:
									break;
								}
								break;
							}
						}
					}
					bool flag3 = num == 1300;
					while (true)
					{
						int num12 = 85909194;
						while (true)
						{
							int num16;
							switch ((num3 = (uint)num12 ^ 0x6AA4B497u) % 14u)
							{
							case 13u:
							{
								int num14;
								int num15;
								if (flag3)
								{
									num14 = -1283812594;
									num15 = -1283812594;
								}
								else
								{
									num14 = -347697470;
									num15 = -347697470;
								}
								num12 = num14 ^ (int)(num3 * 172370357);
								continue;
							}
							case 12u:
							{
								int num17;
								if (num != 0)
								{
									num12 = 221587596;
									num17 = 221587596;
								}
								else
								{
									num12 = 1941597478;
									num17 = 1941597478;
								}
								continue;
							}
							case 11u:
								if (num != 5)
								{
									num12 = 1146716953;
									continue;
								}
								goto IL_0531;
							case 8u:
								num12 = (int)((num3 * 415877343) ^ 0x66F8CF28);
								continue;
							case 6u:
								num12 = ((int)num3 * -837186150) ^ -1468134747;
								continue;
							case 4u:
								if (num != 1347)
								{
									num12 = 1337146327;
									num16 = 1337146327;
									continue;
								}
								goto IL_0531;
							case 2u:
							{
								int num13;
								if (num != 8)
								{
									num12 = 1861900550;
									num13 = 1861900550;
								}
								else
								{
									num12 = 2109669321;
									num13 = 2109669321;
								}
								continue;
							}
							case 0u:
								num12 = (int)(num3 * 1176441878) ^ -1003863754;
								continue;
							default:
								return;
							case 9u:
								break;
							case 1u:
								throw new Win32Exception(num);
							case 5u:
								throw new OutOfMemoryException();
							case 7u:
								throw new UnauthorizedAccessException("The caller does not have the right to change the privilege");
							case 10u:
								throw new PrivilegeNotHeldException(hybridDictionary_0[struct8_0] as string);
							case 3u:
								return;
								IL_0531:
								num12 = 1976198843;
								num16 = 1976198843;
								continue;
							}
							break;
						}
					}
				}
				case 7u:
					throw new InvalidOperationException("Must revert the privilege prior to attempting this operation");
				}
				break;
			}
		}
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private void method_3()
	{
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			while (true)
			{
				int num = -521704765;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC5BA5B30u) % 3u)
					{
					case 2u:
						goto IL_0008;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_0008:
					num = (int)(num2 * 1450735284) ^ -2080867757;
				}
			}
		}
		finally
		{
			bool_2 = false;
			bool flag = default(bool);
			while (true)
			{
				IL_016a:
				int num3 = -122714742;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num3 ^ 0xC5BA5B30u) % 11u)
					{
					case 10u:
						num3 = -1343744965;
						continue;
					case 7u:
						class18_0 = null;
						Thread.SetData(localDataStoreSlot_0, null);
						num3 = (int)(num2 * 1283892171) ^ -1391272657;
						continue;
					case 6u:
						num3 = ((int)num2 * -113891363) ^ 0x520DC56B;
						continue;
					case 5u:
						flag = class18_0.method_2() == 0;
						num3 = (int)(num2 * 2068331300) ^ -443576201;
						continue;
					case 4u:
						bool_1 = false;
						bool_0 = false;
						num3 = (int)((num2 * 1656941729) ^ 0x6A7C4894);
						continue;
					case 3u:
						num3 = ((int)num2 * -750611835) ^ -715942230;
						continue;
					case 2u:
						num3 = -2009560183;
						continue;
					case 1u:
					{
						int num6;
						int num7;
						if (!flag)
						{
							num6 = -1316354735;
							num7 = -1316354735;
						}
						else
						{
							num6 = -1548121552;
							num7 = -1548121552;
						}
						num3 = num6 ^ (int)(num2 * 1968735356);
						continue;
					}
					case 0u:
					{
						int num4;
						int num5;
						if (class18_0 == null)
						{
							num4 = -677249723;
							num5 = -677249723;
						}
						else
						{
							num4 = -2072173494;
							num5 = -2072173494;
						}
						num3 = num4 ^ (int)(num2 * 318558330);
						continue;
					}
					default:
						goto end_IL_012c;
					case 8u:
						break;
					case 9u:
						goto end_IL_012c;
					}
					goto IL_016a;
					continue;
					end_IL_012c:
					break;
				}
				break;
			}
		}
	}

	static GClass42()
	{
		while (true)
		{
			int num = 649591104;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x53668F99u) % 3u)
				{
				case 1u:
					goto IL_0016;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0016:
				hybridDictionary_1 = new HybridDictionary();
				readerWriterLock_0 = new ReaderWriterLock();
				num = ((int)num2 * -928299690) ^ -2085564099;
			}
		}
	}
}
