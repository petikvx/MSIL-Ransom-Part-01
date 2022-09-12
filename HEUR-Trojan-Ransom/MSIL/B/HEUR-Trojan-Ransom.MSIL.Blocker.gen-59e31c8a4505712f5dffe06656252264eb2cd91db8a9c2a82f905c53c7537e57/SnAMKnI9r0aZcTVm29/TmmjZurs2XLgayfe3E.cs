using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Principal;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;
using fJpF6sGRwSPY0tjIER;
using zjWSh2Z73jBs4TcJ0x;

namespace SnAMKnI9r0aZcTVm29;

internal class TmmjZurs2XLgayfe3E
{
	private class HdWLUcbdnpMJkfuIqi : IDisposable
	{
		private enum FmrWqXuORmFf6dBm5i : uint
		{

		}

		private object vGAivvtb8Y;

		internal static object UWkwpM7lsHHyEEP6No4;

		public HdWLUcbdnpMJkfuIqi(char char_0)
		{
			Gvl5Zg7eTmvbTD8G2d2();
			Wx3GWx7LNkS5BCMpnlm();
			base._002Ector();
			IntPtr preexistingHandle = CreateFile(string.Format((string)OTQQnT75U7SXeZvp85W(33936), char_0), FileAccess.ReadWrite, FileShare.ReadWrite, IntPtr.Zero, FileMode.Open, 0, IntPtr.Zero);
			vGAivvtb8Y = new SafeFileHandle(preexistingHandle, ownsHandle: true);
			if (p1vw2V7gG85u6iHBRg2(vGAivvtb8Y))
			{
				B0cbBC7VXMgmyQ8xSRg(Marshal.GetHRForLastWin32Error());
			}
		}

		public void h4LikMvHNt(uint uint_0, byte[] byte_0)
		{
			int num = 2;
			bool flag2 = default(bool);
			uint uint_ = default(uint);
			bool flag4 = default(bool);
			bool flag3 = default(bool);
			while (true)
			{
				bool flag = byte_0 == null;
				int num2 = 1;
				if (!IBdNHO7AbABOT6ZoPrH())
				{
					goto IL_0036;
				}
				goto IL_00b5;
				IL_00b5:
				while (true)
				{
					switch (num2)
					{
					case 10:
						B0cbBC7VXMgmyQ8xSRg(s7QWwu7yMGMbvDxeKKZ());
						goto case 5;
					case 5:
						flag2 = uint_ != byte_0.Length;
						num2 = 12;
						if (IBdNHO7AbABOT6ZoPrH())
						{
							continue;
						}
						goto IL_0036;
					case 8:
					case 9:
						flag4 = !ReadFile((SafeFileHandle)vGAivvtb8Y, byte_0, byte_0.Length, out uint_, IntPtr.Zero);
						num2 = 0;
						if (rxP8EN7Zg2ZLkvmA4ml() != null)
						{
							continue;
						}
						goto default;
					default:
						if (!flag4)
						{
							goto case 5;
						}
						num2 = 10;
						if (rxP8EN7Zg2ZLkvmA4ml() == null)
						{
							continue;
						}
						goto IL_0036;
					case 7:
						flag3 = SetFilePointer((SafeFileHandle)vGAivvtb8Y, uint_0, IntPtr.Zero, (FmrWqXuORmFf6dBm5i)0u) == uint.MaxValue;
						num2 = 3;
						if (rxP8EN7Zg2ZLkvmA4ml() == null)
						{
							continue;
						}
						goto IL_0036;
					case 4:
						B0cbBC7VXMgmyQ8xSRg(s7QWwu7yMGMbvDxeKKZ());
						goto case 8;
					case 3:
						if (!flag3)
						{
							goto case 8;
						}
						goto case 4;
					case 1:
						if (!flag)
						{
							goto case 7;
						}
						goto case 6;
					case 2:
						break;
					case 6:
						throw new ArgumentNullException((string?)OTQQnT75U7SXeZvp85W(33956));
					case 12:
						if (!flag2)
						{
							return;
						}
						goto case 11;
					case 11:
						throw new IOException();
					}
					break;
				}
				continue;
				IL_0036:
				num2 = num;
				goto IL_00b5;
			}
		}

		public void tbbixbxtxi(uint uint_0, byte[] byte_0)
		{
			int num = 5;
			bool flag4 = default(bool);
			uint uint_ = default(uint);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			while (true)
			{
				bool flag = byte_0 == null;
				int num2 = 4;
				if (!IBdNHO7AbABOT6ZoPrH())
				{
					goto IL_0083;
				}
				goto IL_00a6;
				IL_00a6:
				while (true)
				{
					switch (num2)
					{
					case 11:
						if (flag4)
						{
							num2 = 6;
							if (IBdNHO7AbABOT6ZoPrH())
							{
								continue;
							}
							return;
						}
						goto case 1;
					case 10:
						flag4 = !WriteFile((SafeFileHandle)vGAivvtb8Y, byte_0, byte_0.Length, out uint_, IntPtr.Zero);
						num = 11;
						goto case 11;
					case 8:
						if (!flag2)
						{
							goto case 10;
						}
						num2 = 0;
						if (IBdNHO7AbABOT6ZoPrH())
						{
							continue;
						}
						goto default;
					default:
						B0cbBC7VXMgmyQ8xSRg(s7QWwu7yMGMbvDxeKKZ());
						goto case 10;
					case 6:
						break;
					case 4:
						if (!flag)
						{
							flag2 = SetFilePointer((SafeFileHandle)vGAivvtb8Y, uint_0, IntPtr.Zero, (FmrWqXuORmFf6dBm5i)0u) == uint.MaxValue;
							goto case 8;
						}
						goto case 9;
					case 5:
						goto end_IL_00a6;
					case 9:
						throw new ArgumentNullException(XaXlykERDhtdRwMnBY.oXbWkAhpNa(33956));
					case 1:
						flag3 = uint_ != byte_0.Length;
						goto case 7;
					case 7:
						if (!flag3)
						{
							return;
						}
						goto case 3;
					case 3:
						throw new IOException();
					case 2:
						return;
					}
					B0cbBC7VXMgmyQ8xSRg(Marshal.GetHRForLastWin32Error());
					num2 = 1;
					if (IBdNHO7AbABOT6ZoPrH())
					{
						continue;
					}
					goto IL_0083;
					continue;
					end_IL_00a6:
					break;
				}
				continue;
				IL_0083:
				num2 = num;
				goto IL_00a6;
			}
		}

		public void Dispose()
		{
			int num = 2;
			while (true)
			{
				A5dGis74ffWCQMQQMGQ(this, bool_0: true);
				int num2 = 0;
				if (IBdNHO7AbABOT6ZoPrH())
				{
					goto IL_000b;
				}
				goto IL_0022;
				IL_0022:
				switch (num2)
				{
				case 1:
					break;
				default:
					return;
				case 2:
					continue;
				case 0:
					return;
				}
				goto IL_000b;
				IL_000b:
				Bx9UQE7Jf2p2GNk7JoM(this);
				num2 = 0;
				if (rxP8EN7Zg2ZLkvmA4ml() != null)
				{
					num2 = num;
				}
				goto IL_0022;
			}
		}

		protected virtual void Dispose(bool bool_0)
		{
			int num = 5;
			while (true)
			{
				IL_0069:
				if (!bool_0)
				{
					goto IL_004e;
				}
				goto IL_005e;
				IL_005e:
				int num2 = ((vGAivvtb8Y != null) ? 1 : 0);
				goto IL_004f;
				IL_004f:
				bool flag = (byte)num2 != 0;
				int num3 = 2;
				if (IBdNHO7AbABOT6ZoPrH())
				{
					while (true)
					{
						switch (num3)
						{
						case 3:
							((SafeHandle)vGAivvtb8Y).Dispose();
							num3 = 1;
							if (!IBdNHO7AbABOT6ZoPrH())
							{
								num3 = num;
							}
							continue;
						case 2:
							if (flag)
							{
								goto case 3;
							}
							return;
						case 4:
							break;
						default:
							goto IL_005e;
						case 5:
							goto IL_0069;
						case 1:
							return;
						}
						break;
					}
					goto IL_004e;
				}
				goto IL_005e;
				IL_004e:
				num2 = 0;
				goto IL_004f;
			}
		}

		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr CreateFile(string string_0, [MarshalAs(UnmanagedType.U4)] FileAccess fileAccess_0, [MarshalAs(UnmanagedType.U4)] FileShare fileShare_0, IntPtr intptr_0, [MarshalAs(UnmanagedType.U4)] FileMode fileMode_0, int int_0, IntPtr intptr_1);

		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern uint SetFilePointer([In] SafeFileHandle safeFileHandle_0, [In] uint uint_0, [In] IntPtr intptr_0, [In] FmrWqXuORmFf6dBm5i fmrWqXuORmFf6dBm5i_0);

		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool ReadFile(SafeFileHandle safeFileHandle_0, [Out] byte[] byte_0, int int_0, out uint uint_0, IntPtr intptr_0);

		[DllImport("kernel32.dll")]
		private static extern bool WriteFile(SafeFileHandle safeFileHandle_0, [In] byte[] byte_0, int int_0, out uint uint_0, [In] IntPtr intptr_0);

		internal static void Gvl5Zg7eTmvbTD8G2d2()
		{
			XaXlykERDhtdRwMnBY.jXRWMU6APG();
		}

		internal static void Wx3GWx7LNkS5BCMpnlm()
		{
			zB3PVH9hASM2TtLqpf.unC5KZCzPQ9Xt();
		}

		internal static object OTQQnT75U7SXeZvp85W(int int_0)
		{
			return XaXlykERDhtdRwMnBY.oXbWkAhpNa(int_0);
		}

		internal static bool p1vw2V7gG85u6iHBRg2(object object_0)
		{
			return ((SafeHandle)object_0).IsInvalid;
		}

		internal static void B0cbBC7VXMgmyQ8xSRg(int int_0)
		{
			Marshal.ThrowExceptionForHR(int_0);
		}

		internal static bool IBdNHO7AbABOT6ZoPrH()
		{
			return UWkwpM7lsHHyEEP6No4 == null;
		}

		internal static HdWLUcbdnpMJkfuIqi rxP8EN7Zg2ZLkvmA4ml()
		{
			return (HdWLUcbdnpMJkfuIqi)UWkwpM7lsHHyEEP6No4;
		}

		internal static int s7QWwu7yMGMbvDxeKKZ()
		{
			return Marshal.GetHRForLastWin32Error();
		}

		internal static void A5dGis74ffWCQMQQMGQ(object object_0, bool bool_0)
		{
			((HdWLUcbdnpMJkfuIqi)object_0).Dispose(bool_0);
		}

		internal static void Bx9UQE7Jf2p2GNk7JoM(object object_0)
		{
			GC.SuppressFinalize(object_0);
		}
	}

	public static object XgqiKUbaOe;

	public static object psfiMQmEuK;

	private static object n4tmXvIU0pfCE5bImDj;

	public static bool pFDiDkR6x1()
	{
		int num = 1;
		while (true)
		{
			bool result = RB2dwTIuTjiBykEwfHc(new WindowsPrincipal((WindowsIdentity)ElY5vaIbmCQv6wdCdIU()), WindowsBuiltInRole.Administrator);
			int num2 = 0;
			if (nRkGyvIk2y2ubaJvwkf() != null)
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			return result;
		}
	}

	public static string yp7i44q6B0(int int_0)
	{
		int num = 1;
		bool flag = default(bool);
		int num3 = default(int);
		string result = default(string);
		while (true)
		{
			char[] array = new char[int_0];
			int num2 = 0;
			if (!nlWxxcIKe8t7ejrb6Al())
			{
				goto IL_0055;
			}
			goto IL_0076;
			IL_0076:
			while (true)
			{
				switch (num2)
				{
				case 9:
					if (flag)
					{
						goto case 6;
					}
					goto case 5;
				case 6:
					array[num3] = ((string)ou8xDhIz0oR1PHjPT7j(32386))[QQU2du7BSeMfYi16gy2(XgqiKUbaOe, TGnp9r7FStvlDg0qIh7(ou8xDhIz0oR1PHjPT7j(32386)))];
					goto case 8;
				case 8:
					num3++;
					num2 = 2;
					if (nlWxxcIKe8t7ejrb6Al())
					{
						continue;
					}
					goto IL_0055;
				case 2:
				case 7:
					flag = num3 < int_0;
					goto case 9;
				default:
					num3 = 0;
					num2 = 7;
					if (nRkGyvIk2y2ubaJvwkf() == null)
					{
						continue;
					}
					goto IL_0055;
				case 1:
					break;
				case 5:
					return new string(array);
				case 3:
				case 4:
					return result;
				}
				break;
			}
			continue;
			IL_0055:
			num2 = num;
			goto IL_0076;
		}
	}

	public static void Dk6iUUVjIs()
	{
		int num = 7;
		RegistryKey registryKey = default(RegistryKey);
		string value = default(string);
		while (true)
		{
			U88Fbg7WqnN0Nh53h1t("");
			int num2 = 6;
			if (!nlWxxcIKe8t7ejrb6Al())
			{
				goto IL_0097;
			}
			goto IL_0143;
			IL_0143:
			while (true)
			{
				switch (num2)
				{
				case 15:
					KL0CfM7hqyxXKQZ7f9Q(ou8xDhIz0oR1PHjPT7j(32422));
					goto case 13;
				case 13:
					bZHujn7rOdYOllEyxWi(ConsoleColor.Magenta);
					num2 = 3;
					if (nRkGyvIk2y2ubaJvwkf() != null)
					{
						continue;
					}
					goto case 9;
				case 9:
					KL0CfM7hqyxXKQZ7f9Q(gNhUnZ7OQmuURTUBXJU(ou8xDhIz0oR1PHjPT7j(32438), ntjGsq7jR41lolHEdV0()));
					num = 10;
					goto case 10;
				case 10:
					Console.WriteLine("");
					num2 = 4;
					if (nlWxxcIKe8t7ejrb6Al())
					{
						continue;
					}
					goto case 1;
				case 1:
					registryKey = (RegistryKey)PX100N77D1WyZNWCTj1(Registry.LocalMachine, XaXlykERDhtdRwMnBY.oXbWkAhpNa(32492), bool_0: true);
					num2 = 8;
					if (nRkGyvIk2y2ubaJvwkf() == null)
					{
						continue;
					}
					goto IL_0097;
				case 14:
					bZHujn7rOdYOllEyxWi(ConsoleColor.Red);
					goto case 5;
				case 5:
					KL0CfM7hqyxXKQZ7f9Q(ou8xDhIz0oR1PHjPT7j(32422));
					goto case 12;
				case 12:
					bZHujn7rOdYOllEyxWi(ConsoleColor.Magenta);
					num2 = 0;
					if (nRkGyvIk2y2ubaJvwkf() == null)
					{
						continue;
					}
					goto IL_0097;
				case 8:
					registryKey.SetValue((string?)ou8xDhIz0oR1PHjPT7j(32660), value);
					goto case 3;
				case 3:
					JUDkHZ7XLfy8nTaP7bD(registryKey);
					goto case 14;
				case 6:
					bZHujn7rOdYOllEyxWi(ConsoleColor.Red);
					goto case 15;
				case 4:
					value = (string)gNhUnZ7OQmuURTUBXJU(ou8xDhIz0oR1PHjPT7j(32484), SssFrU7IhVXCoCZCI5o(10));
					num2 = 1;
					if (nlWxxcIKe8t7ejrb6Al())
					{
						continue;
					}
					goto IL_0097;
				default:
					Console.Write((string?)gNhUnZ7OQmuURTUBXJU(ou8xDhIz0oR1PHjPT7j(32692), ntjGsq7jR41lolHEdV0()));
					num2 = 0;
					if (!nlWxxcIKe8t7ejrb6Al())
					{
						continue;
					}
					goto case 11;
				case 7:
					break;
				case 11:
					Console.WriteLine("");
					return;
				case 2:
					return;
				}
				break;
			}
			continue;
			IL_0097:
			num2 = num;
			goto IL_0143;
		}
	}

	public static string evwiBvf6tj()
	{
		int num = 4;
		string result2 = default(string);
		string result = default(string);
		while (true)
		{
			RegistryKey object_ = (RegistryKey)PX100N77D1WyZNWCTj1(Registry.LocalMachine, ou8xDhIz0oR1PHjPT7j(32492), bool_0: true);
			int num2 = 3;
			if (!nlWxxcIKe8t7ejrb6Al())
			{
				goto IL_0044;
			}
			goto IL_0048;
			IL_0048:
			while (true)
			{
				switch (num2)
				{
				case 3:
					result2 = (string)WG83eL7M3ciFfeqibY1(object_, ou8xDhIz0oR1PHjPT7j(32660));
					num2 = 0;
					if (nlWxxcIKe8t7ejrb6Al())
					{
						continue;
					}
					goto default;
				default:
					JUDkHZ7XLfy8nTaP7bD(object_);
					num2 = 5;
					if (nRkGyvIk2y2ubaJvwkf() == null)
					{
						continue;
					}
					goto IL_0044;
				case 4:
					break;
				case 5:
					return result2;
				case 1:
				case 2:
					return result;
				}
				break;
			}
			continue;
			IL_0044:
			num2 = num;
			goto IL_0048;
		}
	}

	public static void OdMihjDgn8()
	{
		int num = 11;
		string object_ = default(string);
		Guid guid = default(Guid);
		RegistryKey object_2 = default(RegistryKey);
		while (true)
		{
			U88Fbg7WqnN0Nh53h1t("");
			int num2 = 10;
			if (!nlWxxcIKe8t7ejrb6Al())
			{
				goto IL_00d4;
			}
			goto IL_0154;
			IL_0154:
			while (true)
			{
				switch (num2)
				{
				case 16:
					object_ = guid.ToString();
					num = 2;
					goto case 2;
				case 2:
					object_2 = (RegistryKey)aPnfCN7DsPZkL9MrXZY(RegistryHive.LocalMachine, RegistryView.Registry64);
					num2 = 0;
					if (nRkGyvIk2y2ubaJvwkf() != null)
					{
						continue;
					}
					goto default;
				default:
					object_2 = (RegistryKey)PX100N77D1WyZNWCTj1(object_2, XaXlykERDhtdRwMnBY.oXbWkAhpNa(32776), bool_0: true);
					goto case 4;
				case 4:
					J4jMsA7GaC9Cd02N8t0(object_2, XaXlykERDhtdRwMnBY.oXbWkAhpNa(32842), object_);
					num2 = 2;
					if (!nlWxxcIKe8t7ejrb6Al())
					{
						continue;
					}
					goto case 14;
				case 14:
					Console.ForegroundColor = ConsoleColor.Red;
					goto case 15;
				case 15:
					Console.Write((string?)ou8xDhIz0oR1PHjPT7j(32422));
					goto case 5;
				case 5:
					bZHujn7rOdYOllEyxWi(ConsoleColor.Magenta);
					num2 = 1;
					if (nRkGyvIk2y2ubaJvwkf() != null)
					{
						continue;
					}
					goto case 1;
				case 1:
					Console.Write((string?)gNhUnZ7OQmuURTUBXJU(ou8xDhIz0oR1PHjPT7j(32868), GoeWVo7tS5eGI03gal6()));
					num2 = 6;
					if (nlWxxcIKe8t7ejrb6Al())
					{
						continue;
					}
					goto IL_00d4;
				case 13:
					Console.Write((string?)ou8xDhIz0oR1PHjPT7j(32422));
					goto case 3;
				case 3:
					bZHujn7rOdYOllEyxWi(ConsoleColor.Magenta);
					num2 = 2;
					if (!nlWxxcIKe8t7ejrb6Al())
					{
						continue;
					}
					goto case 9;
				case 9:
					Console.Write(XaXlykERDhtdRwMnBY.oXbWkAhpNa(32744) + (string?)GoeWVo7tS5eGI03gal6());
					goto case 7;
				case 7:
					Console.WriteLine("");
					goto case 12;
				case 12:
					guid = Guid.NewGuid();
					goto case 16;
				case 10:
					bZHujn7rOdYOllEyxWi(ConsoleColor.Red);
					num = 13;
					goto case 13;
				case 6:
					U88Fbg7WqnN0Nh53h1t("");
					num2 = 4;
					if (!nlWxxcIKe8t7ejrb6Al())
					{
						continue;
					}
					return;
				case 11:
					break;
				case 8:
					return;
				}
				break;
			}
			continue;
			IL_00d4:
			num2 = num;
			goto IL_0154;
		}
	}

	public static string eyVi5Fojc7()
	{
		int num = 1;
		RegistryKey registryKey = default(RegistryKey);
		int num4 = default(int);
		string text = default(string);
		int num6 = default(int);
		bool flag2 = default(bool);
		string result2 = default(string);
		int num8 = default(int);
		int num10 = default(int);
		string result = default(string);
		while (true)
		{
			string object_ = XaXlykERDhtdRwMnBY.oXbWkAhpNa(32776);
			int num2 = 0;
			if (nRkGyvIk2y2ubaJvwkf() != null)
			{
				goto IL_0029;
			}
			goto IL_004a;
			IL_004a:
			while (true)
			{
				switch (num2)
				{
				case 3:
					break;
				default:
					goto IL_002f;
				case 1:
					goto end_IL_004a;
				case 6:
					try
					{
						RegistryKey registryKey2 = (RegistryKey)wxhCtT7q5RhFG35EqtQ(registryKey, object_);
						int num3 = 1;
						if (!nlWxxcIKe8t7ejrb6Al())
						{
							num3 = num4;
						}
						switch (num3)
						{
						case 1:
							try
							{
								bool flag = registryKey2 == null;
								while (true)
								{
									object obj;
									int num5;
									if (!flag)
									{
										obj = WG83eL7M3ciFfeqibY1(registryKey2, text);
										num5 = 6;
										if (!nlWxxcIKe8t7ejrb6Al())
										{
											goto IL_00f3;
										}
										goto IL_010e;
									}
									goto IL_013a;
									IL_00f3:
									num5 = num6;
									goto IL_010e;
									IL_010e:
									while (true)
									{
										switch (num5)
										{
										case 6:
											flag2 = obj == null;
											goto case 5;
										case 5:
											if (!flag2)
											{
												goto IL_00e6;
											}
											goto case 1;
										default:
											result2 = obj.ToString();
											num5 = 0;
											if (!nlWxxcIKe8t7ejrb6Al())
											{
												continue;
											}
											goto end_IL_0131;
										case 4:
											break;
										case 3:
											goto IL_013a;
										case 1:
											throw new IndexOutOfRangeException(string.Format((string)ou8xDhIz0oR1PHjPT7j(32946), text));
										case 2:
											goto end_IL_0131;
										}
										break;
										IL_00e6:
										num5 = 0;
										if (nRkGyvIk2y2ubaJvwkf() == null)
										{
											continue;
										}
										goto IL_00f3;
									}
									continue;
									IL_013a:
									throw new KeyNotFoundException((string?)yZcoa37E4FYhUpcpS9T(ou8xDhIz0oR1PHjPT7j(32906), object_));
									continue;
									end_IL_0131:
									break;
								}
							}
							finally
							{
								if (registryKey2 != null)
								{
									goto IL_0190;
								}
								int num7 = 1;
								if (nRkGyvIk2y2ubaJvwkf() == null)
								{
									goto IL_017d;
								}
								goto IL_01a4;
								IL_017d:
								switch (num7)
								{
								default:
									goto end_IL_016a;
								case 2:
									break;
								case 0:
								case 1:
									goto end_IL_016a;
								}
								goto IL_0190;
								IL_0190:
								I3XXrV7Yt0ynYwZPVvV(registryKey2);
								num7 = 0;
								if (nRkGyvIk2y2ubaJvwkf() == null)
								{
									goto IL_017d;
								}
								goto IL_01a4;
								IL_01a4:
								num7 = num8;
								goto IL_017d;
								end_IL_016a:;
							}
							break;
						case 0:
							break;
						}
					}
					finally
					{
						if (registryKey != null)
						{
							while (true)
							{
								I3XXrV7Yt0ynYwZPVvV(registryKey);
								int num9 = 0;
								if (nRkGyvIk2y2ubaJvwkf() != null)
								{
									num9 = num10;
								}
								switch (num9)
								{
								case 1:
									break;
								default:
									goto end_IL_01b1;
								case 0:
								case 2:
									goto end_IL_01b1;
								}
								continue;
								end_IL_01b1:
								break;
							}
						}
					}
					goto case 2;
				case 2:
					return result2;
				case 4:
				case 5:
					return result;
				}
				registryKey = (RegistryKey)aPnfCN7DsPZkL9MrXZY(RegistryHive.LocalMachine, RegistryView.Registry64);
				num2 = 6;
				if (nRkGyvIk2y2ubaJvwkf() == null)
				{
					continue;
				}
				goto IL_0029;
				IL_002f:
				text = (string)ou8xDhIz0oR1PHjPT7j(32842);
				num2 = 3;
				if (nlWxxcIKe8t7ejrb6Al())
				{
					continue;
				}
				goto IL_0029;
				continue;
				end_IL_004a:
				break;
			}
			continue;
			IL_0029:
			num2 = num;
			goto IL_004a;
		}
	}

	public static void ThViexeYoC()
	{
		int num = 14;
		RegistryKey registryKey = default(RegistryKey);
		string value = default(string);
		while (true)
		{
			U88Fbg7WqnN0Nh53h1t("");
			while (true)
			{
				bZHujn7rOdYOllEyxWi(ConsoleColor.Red);
				while (true)
				{
					Console.Write((string?)ou8xDhIz0oR1PHjPT7j(32422));
					while (true)
					{
						bZHujn7rOdYOllEyxWi(ConsoleColor.Magenta);
						int num2 = 3;
						if (!nlWxxcIKe8t7ejrb6Al())
						{
							goto IL_0041;
						}
						goto IL_0184;
						IL_0184:
						while (true)
						{
							switch (num2)
							{
							case 15:
								KL0CfM7hqyxXKQZ7f9Q(gNhUnZ7OQmuURTUBXJU(ou8xDhIz0oR1PHjPT7j(33152), KhWiE0ZLk6()));
								goto case 2;
							case 2:
								U88Fbg7WqnN0Nh53h1t("");
								num2 = 8;
								if (nRkGyvIk2y2ubaJvwkf() == null)
								{
									continue;
								}
								goto IL_0041;
							case 12:
								registryKey = (RegistryKey)aPnfCN7DsPZkL9MrXZY(RegistryHive.LocalMachine, RegistryView.Registry64);
								num2 = 9;
								if (nRkGyvIk2y2ubaJvwkf() == null)
								{
									continue;
								}
								goto IL_0041;
							case 11:
								JUDkHZ7XLfy8nTaP7bD(registryKey);
								num2 = 1;
								if (nlWxxcIKe8t7ejrb6Al())
								{
									continue;
								}
								goto IL_0041;
							case 10:
								registryKey.SetValue((string?)ou8xDhIz0oR1PHjPT7j(33130), value);
								num2 = 11;
								if (nRkGyvIk2y2ubaJvwkf() == null)
								{
									continue;
								}
								goto IL_0041;
							case 9:
								registryKey = registryKey.OpenSubKey((string)ou8xDhIz0oR1PHjPT7j(33038), writable: true);
								goto case 10;
							case 7:
								Console.WriteLine("");
								goto case 5;
							case 5:
								value = (string)tX9pV170SENXnkRUAQv(new string[7]
								{
									(string)SssFrU7IhVXCoCZCI5o(5),
									(string)ou8xDhIz0oR1PHjPT7j(33032),
									(string)SssFrU7IhVXCoCZCI5o(5),
									XaXlykERDhtdRwMnBY.oXbWkAhpNa(33032),
									(string)SssFrU7IhVXCoCZCI5o(5),
									(string)ou8xDhIz0oR1PHjPT7j(33032),
									(string)SssFrU7IhVXCoCZCI5o(5)
								});
								goto case 12;
							case 4:
								bZHujn7rOdYOllEyxWi(ConsoleColor.Magenta);
								goto case 15;
							case 3:
								KL0CfM7hqyxXKQZ7f9Q(gNhUnZ7OQmuURTUBXJU(ou8xDhIz0oR1PHjPT7j(32990), KhWiE0ZLk6()));
								num2 = 7;
								if (nlWxxcIKe8t7ejrb6Al())
								{
									continue;
								}
								goto IL_0041;
							case 1:
								bZHujn7rOdYOllEyxWi(ConsoleColor.Red);
								num2 = 0;
								if (nRkGyvIk2y2ubaJvwkf() == null)
								{
									continue;
								}
								goto default;
							default:
								KL0CfM7hqyxXKQZ7f9Q(ou8xDhIz0oR1PHjPT7j(32422));
								goto case 4;
							case 16:
								break;
							case 6:
								goto end_IL_01cf;
							case 13:
								goto end_IL_01e8;
							case 14:
								goto end_IL_01f9;
							case 8:
								return;
							}
							break;
						}
						continue;
						IL_0041:
						num2 = num;
						goto IL_0184;
						continue;
						end_IL_01cf:
						break;
					}
					continue;
					end_IL_01e8:
					break;
				}
				continue;
				end_IL_01f9:
				break;
			}
		}
	}

	public static string KhWiE0ZLk6()
	{
		int num = 6;
		string text2 = default(string);
		RegistryKey registryKey = default(RegistryKey);
		int num4 = default(int);
		bool flag2 = default(bool);
		string text3 = default(string);
		int num8 = default(int);
		int num10 = default(int);
		string result = default(string);
		while (true)
		{
			string text = XaXlykERDhtdRwMnBY.oXbWkAhpNa(33038);
			int num2 = 5;
			if (!nlWxxcIKe8t7ejrb6Al())
			{
				goto IL_01a4;
			}
			goto IL_01a8;
			IL_01a8:
			while (true)
			{
				switch (num2)
				{
				case 5:
					text2 = (string)ou8xDhIz0oR1PHjPT7j(33130);
					goto case 4;
				case 4:
					registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
					goto case 3;
				case 3:
					try
					{
						RegistryKey registryKey2 = registryKey.OpenSubKey(text);
						int num3 = 0;
						if (nRkGyvIk2y2ubaJvwkf() != null)
						{
							num3 = num4;
						}
						switch (num3)
						{
						default:
							try
							{
								bool flag = registryKey2 == null;
								int num5 = 6;
								while (true)
								{
									IL_00db:
									object value;
									int num6;
									if (!flag)
									{
										value = registryKey2.GetValue(text2);
										num6 = 1;
										if (nRkGyvIk2y2ubaJvwkf() != null)
										{
											goto IL_00a9;
										}
										goto IL_00b8;
									}
									goto IL_00df;
									IL_00a9:
									num6 = num5;
									goto IL_00b8;
									IL_00b8:
									while (true)
									{
										switch (num6)
										{
										case 3:
											if (!flag2)
											{
												num6 = 1;
												if (nRkGyvIk2y2ubaJvwkf() != null)
												{
													continue;
												}
												goto case 2;
											}
											goto case 5;
										case 2:
											text3 = value.ToString();
											num6 = 0;
											if (nRkGyvIk2y2ubaJvwkf() == null)
											{
												continue;
											}
											goto IL_00a9;
										case 1:
											flag2 = value == null;
											goto case 3;
										case 6:
											goto IL_00db;
										case 4:
											goto IL_00df;
										case 5:
											throw new IndexOutOfRangeException((string?)yZcoa37E4FYhUpcpS9T(ou8xDhIz0oR1PHjPT7j(32946), text2));
										case 0:
											break;
										}
										break;
									}
									break;
									IL_00df:
									throw new KeyNotFoundException((string?)yZcoa37E4FYhUpcpS9T(XaXlykERDhtdRwMnBY.oXbWkAhpNa(32906), text));
								}
							}
							finally
							{
								if (registryKey2 != null)
								{
									goto IL_0135;
								}
								int num7 = 1;
								if (nlWxxcIKe8t7ejrb6Al())
								{
									goto IL_0122;
								}
								goto IL_0149;
								IL_0122:
								switch (num7)
								{
								default:
									goto end_IL_010f;
								case 2:
									break;
								case 0:
								case 1:
									goto end_IL_010f;
								}
								goto IL_0135;
								IL_0135:
								((IDisposable)registryKey2).Dispose();
								num7 = 0;
								if (nRkGyvIk2y2ubaJvwkf() == null)
								{
									goto IL_0122;
								}
								goto IL_0149;
								IL_0149:
								num7 = num8;
								goto IL_0122;
								end_IL_010f:;
							}
							break;
						case 1:
							break;
						}
					}
					finally
					{
						if (registryKey != null)
						{
							goto IL_0178;
						}
						int num9 = 0;
						if (nlWxxcIKe8t7ejrb6Al())
						{
							goto IL_0165;
						}
						goto IL_018c;
						IL_0165:
						switch (num9)
						{
						default:
							goto end_IL_0152;
						case 2:
							break;
						case 0:
						case 1:
							goto end_IL_0152;
						}
						goto IL_0178;
						IL_0178:
						I3XXrV7Yt0ynYwZPVvV(registryKey);
						num9 = 1;
						if (nRkGyvIk2y2ubaJvwkf() == null)
						{
							goto IL_0165;
						}
						goto IL_018c;
						IL_018c:
						num9 = num10;
						goto IL_0165;
						end_IL_0152:;
					}
					goto IL_0193;
				case 2:
					goto IL_0193;
				case 6:
					break;
				default:
					return result;
				}
				break;
				IL_0193:
				result = text3;
				num2 = 1;
				if (nlWxxcIKe8t7ejrb6Al())
				{
					continue;
				}
				goto IL_01a4;
			}
			continue;
			IL_01a4:
			num2 = num;
			goto IL_01a8;
		}
	}

	public static string IwBiGcX6RW(int int_0)
	{
		int num = 5;
		bool flag = default(bool);
		int num3 = default(int);
		string result = default(string);
		while (true)
		{
			char[] array = new char[int_0];
			int num2 = 4;
			if (nRkGyvIk2y2ubaJvwkf() != null)
			{
				goto IL_006b;
			}
			goto IL_008b;
			IL_008b:
			while (true)
			{
				switch (num2)
				{
				case 2:
				case 8:
					flag = num3 < int_0;
					goto case 3;
				case 3:
					if (!flag)
					{
						goto case 7;
					}
					goto case 1;
				case 7:
					do
					{
						result = new string(array);
						num2 = 9;
					}
					while (!nlWxxcIKe8t7ejrb6Al());
					continue;
				case 1:
					array[num3] = LBdKtr7HocZNbiHZsdP(ou8xDhIz0oR1PHjPT7j(33200), QQU2du7BSeMfYi16gy2(psfiMQmEuK, ((string)ou8xDhIz0oR1PHjPT7j(33200)).Length));
					num2 = 6;
					if (nRkGyvIk2y2ubaJvwkf() == null)
					{
						continue;
					}
					goto IL_006b;
				case 6:
					num3++;
					goto case 2;
				case 4:
					num3 = 0;
					num2 = 1;
					if (nRkGyvIk2y2ubaJvwkf() != null)
					{
						continue;
					}
					goto case 2;
				case 5:
					break;
				default:
					return result;
				}
				break;
			}
			continue;
			IL_006b:
			num2 = num;
			goto IL_008b;
		}
	}

	public static void envifufad3()
	{
		int num = 5;
		string object_ = default(string);
		RegistryKey object_2 = default(RegistryKey);
		while (true)
		{
			IL_011e:
			U88Fbg7WqnN0Nh53h1t("");
			int num2 = 4;
			if (nRkGyvIk2y2ubaJvwkf() != null)
			{
				goto IL_00b0;
			}
			goto IL_00d0;
			IL_00d0:
			while (true)
			{
				switch (num2)
				{
				case 16:
					Console.Write((string?)ou8xDhIz0oR1PHjPT7j(32422));
					num2 = 11;
					if (nlWxxcIKe8t7ejrb6Al())
					{
						continue;
					}
					goto IL_002d;
				case 12:
					U88Fbg7WqnN0Nh53h1t("");
					num2 = 0;
					if (nRkGyvIk2y2ubaJvwkf() == null)
					{
						continue;
					}
					goto default;
				default:
					object_ = (string)UNsDH67dvjP1mEnSL3m(15);
					num = 6;
					goto case 6;
				case 6:
					object_2 = (RegistryKey)aPnfCN7DsPZkL9MrXZY(RegistryHive.LocalMachine, RegistryView.Registry64);
					num2 = 1;
					if (nlWxxcIKe8t7ejrb6Al())
					{
						continue;
					}
					goto IL_002d;
				case 11:
					bZHujn7rOdYOllEyxWi(ConsoleColor.Magenta);
					goto case 3;
				case 3:
					KL0CfM7hqyxXKQZ7f9Q(gNhUnZ7OQmuURTUBXJU(ou8xDhIz0oR1PHjPT7j(33236), oR2ynY7PhpOxKb5LqUj()));
					goto case 12;
				case 4:
					bZHujn7rOdYOllEyxWi(ConsoleColor.Red);
					goto case 16;
				case 1:
					break;
				case 5:
					goto IL_011e;
				case 10:
					goto IL_013b;
				case 7:
					goto IL_014e;
				case 14:
					goto IL_0155;
				case 13:
					goto IL_015c;
				case 8:
					goto IL_016b;
				case 15:
					goto IL_0172;
				case 9:
					goto end_IL_011e;
				case 2:
					return;
					IL_002d:
					num2 = num;
					continue;
				}
				break;
			}
			goto IL_00b0;
			IL_00b0:
			object_2 = (RegistryKey)PX100N77D1WyZNWCTj1(object_2, ou8xDhIz0oR1PHjPT7j(33038), bool_0: true);
			num2 = 5;
			if (nRkGyvIk2y2ubaJvwkf() != null)
			{
				goto IL_00d0;
			}
			goto IL_013b;
			IL_013b:
			J4jMsA7GaC9Cd02N8t0(object_2, XaXlykERDhtdRwMnBY.oXbWkAhpNa(33284), object_);
			goto IL_014e;
			IL_014e:
			JUDkHZ7XLfy8nTaP7bD(object_2);
			goto IL_0155;
			IL_0155:
			Console.ForegroundColor = ConsoleColor.Red;
			goto IL_015c;
			IL_015c:
			KL0CfM7hqyxXKQZ7f9Q(ou8xDhIz0oR1PHjPT7j(32422));
			goto IL_016b;
			IL_016b:
			Console.ForegroundColor = ConsoleColor.Magenta;
			goto IL_0172;
			IL_0172:
			KL0CfM7hqyxXKQZ7f9Q((string?)ou8xDhIz0oR1PHjPT7j(33310) + OOGimapeRS());
			break;
			continue;
			end_IL_011e:
			break;
		}
		U88Fbg7WqnN0Nh53h1t("");
	}

	public static string OOGimapeRS()
	{
		string result = default(string);
		string result2 = default(string);
		RegistryKey registryKey = default(RegistryKey);
		int num2 = default(int);
		object obj = default(object);
		bool flag2 = default(bool);
		int num4 = default(int);
		int num6 = default(int);
		int num8 = default(int);
		while (true)
		{
			string text = (string)ou8xDhIz0oR1PHjPT7j(33038);
			while (true)
			{
				string object_ = XaXlykERDhtdRwMnBY.oXbWkAhpNa(33284);
				if (!nlWxxcIKe8t7ejrb6Al())
				{
					switch (3)
					{
					case 3:
						continue;
					case 4:
						goto end_IL_0003;
					case 6:
						goto IL_0050;
					case 2:
						goto IL_0061;
					case 1:
						goto IL_01c0;
					}
					return result;
				}
				goto IL_0050;
				IL_01c0:
				return result2;
				IL_0050:
				registryKey = (RegistryKey)aPnfCN7DsPZkL9MrXZY(RegistryHive.LocalMachine, RegistryView.Registry64);
				goto IL_0061;
				IL_0061:
				try
				{
					RegistryKey registryKey2 = registryKey.OpenSubKey(text);
					int num = 0;
					if (!nlWxxcIKe8t7ejrb6Al())
					{
						num = num2;
					}
					switch (num)
					{
					default:
						try
						{
							bool flag = registryKey2 == null;
							while (true)
							{
								IL_0109:
								int num3;
								if (!flag)
								{
									num3 = 5;
									if (!nlWxxcIKe8t7ejrb6Al())
									{
										goto IL_00c3;
									}
									goto IL_00e2;
								}
								goto IL_0129;
								IL_0129:
								throw new KeyNotFoundException((string?)yZcoa37E4FYhUpcpS9T(ou8xDhIz0oR1PHjPT7j(32906), text));
								IL_00e2:
								while (true)
								{
									switch (num3)
									{
									case 5:
										obj = WG83eL7M3ciFfeqibY1(registryKey2, object_);
										goto case 2;
									case 2:
										flag2 = obj == null;
										num3 = 4;
										if (nlWxxcIKe8t7ejrb6Al())
										{
											continue;
										}
										goto IL_00c3;
									case 4:
										if (!flag2)
										{
											goto case 3;
										}
										goto case 1;
									case 3:
										result2 = obj.ToString();
										num3 = 0;
										if (nRkGyvIk2y2ubaJvwkf() == null)
										{
											continue;
										}
										break;
									case 6:
										goto IL_0109;
									case 1:
										throw new IndexOutOfRangeException((string?)yZcoa37E4FYhUpcpS9T(ou8xDhIz0oR1PHjPT7j(32946), object_));
									case 7:
										goto IL_0129;
									case 0:
										break;
									}
									break;
								}
								break;
								IL_00c3:
								num3 = num4;
								goto IL_00e2;
							}
						}
						finally
						{
							if (registryKey2 != null)
							{
								int num5 = 1;
								if (nRkGyvIk2y2ubaJvwkf() != null)
								{
									num5 = num6;
								}
								while (true)
								{
									switch (num5)
									{
									case 1:
										I3XXrV7Yt0ynYwZPVvV(registryKey2);
										num5 = 0;
										if (nRkGyvIk2y2ubaJvwkf() == null)
										{
											continue;
										}
										break;
									case 0:
										break;
									}
									break;
								}
							}
						}
						break;
					case 1:
						break;
					}
				}
				finally
				{
					if (registryKey != null)
					{
						goto IL_01a5;
					}
					int num7 = 1;
					if (nlWxxcIKe8t7ejrb6Al())
					{
						goto IL_0192;
					}
					goto IL_01b9;
					IL_0192:
					switch (num7)
					{
					default:
						goto end_IL_017f;
					case 2:
						break;
					case 0:
					case 1:
						goto end_IL_017f;
					}
					goto IL_01a5;
					IL_01a5:
					((IDisposable)registryKey).Dispose();
					num7 = 0;
					if (nRkGyvIk2y2ubaJvwkf() == null)
					{
						goto IL_0192;
					}
					goto IL_01b9;
					IL_01b9:
					num7 = num8;
					goto IL_0192;
					end_IL_017f:;
				}
				goto IL_01c0;
				continue;
				end_IL_0003:
				break;
			}
		}
	}

	public static void xAciHwDPtG()
	{
		int num = 14;
		RegistryKey object_ = default(RegistryKey);
		string object_2 = default(string);
		while (true)
		{
			U88Fbg7WqnN0Nh53h1t("");
			while (true)
			{
				bZHujn7rOdYOllEyxWi(ConsoleColor.Red);
				int num2 = 0;
				if (nRkGyvIk2y2ubaJvwkf() != null)
				{
					goto IL_0034;
				}
				goto IL_015f;
				IL_015f:
				while (true)
				{
					switch (num2)
					{
					case 16:
						KL0CfM7hqyxXKQZ7f9Q(ou8xDhIz0oR1PHjPT7j(32422));
						goto case 4;
					case 4:
						Console.ForegroundColor = ConsoleColor.Magenta;
						num2 = 5;
						if (nRkGyvIk2y2ubaJvwkf() == null)
						{
							continue;
						}
						goto IL_0034;
					case 15:
						Console.WriteLine("");
						num2 = 9;
						if (nlWxxcIKe8t7ejrb6Al())
						{
							continue;
						}
						goto IL_0034;
					case 12:
						bZHujn7rOdYOllEyxWi(ConsoleColor.Red);
						goto case 16;
					case 7:
						JUDkHZ7XLfy8nTaP7bD(object_);
						num2 = 12;
						if (nRkGyvIk2y2ubaJvwkf() == null)
						{
							continue;
						}
						goto case 6;
					case 6:
						object_ = (RegistryKey)PX100N77D1WyZNWCTj1(object_, XaXlykERDhtdRwMnBY.oXbWkAhpNa(33038), bool_0: true);
						goto case 11;
					case 11:
						J4jMsA7GaC9Cd02N8t0(object_, ou8xDhIz0oR1PHjPT7j(33412), object_2);
						goto case 7;
					case 10:
						U88Fbg7WqnN0Nh53h1t("");
						goto case 8;
					case 8:
						object_2 = (string)UNsDH67dvjP1mEnSL3m(8);
						num2 = 3;
						if (nlWxxcIKe8t7ejrb6Al())
						{
							continue;
						}
						goto IL_0034;
					case 5:
						KL0CfM7hqyxXKQZ7f9Q(gNhUnZ7OQmuURTUBXJU(ou8xDhIz0oR1PHjPT7j(33438), zPq1hW7wotgS1epQAdw()));
						num2 = 15;
						if (nRkGyvIk2y2ubaJvwkf() == null)
						{
							continue;
						}
						goto IL_0034;
					case 3:
						object_ = (RegistryKey)aPnfCN7DsPZkL9MrXZY(RegistryHive.LocalMachine, RegistryView.Registry64);
						num2 = 6;
						if (nRkGyvIk2y2ubaJvwkf() == null)
						{
							continue;
						}
						goto IL_0034;
					case 2:
						Console.ForegroundColor = ConsoleColor.Magenta;
						num2 = 1;
						if (nlWxxcIKe8t7ejrb6Al())
						{
							continue;
						}
						goto IL_0034;
					case 1:
						Console.Write((string?)gNhUnZ7OQmuURTUBXJU(XaXlykERDhtdRwMnBY.oXbWkAhpNa(33364), zPq1hW7wotgS1epQAdw()));
						goto case 10;
					default:
						KL0CfM7hqyxXKQZ7f9Q(ou8xDhIz0oR1PHjPT7j(32422));
						goto case 2;
					case 13:
						break;
					case 14:
						goto end_IL_01aa;
					case 9:
						return;
					}
					break;
				}
				continue;
				IL_0034:
				num2 = num;
				goto IL_015f;
				continue;
				end_IL_01aa:
				break;
			}
		}
	}

	public static string iJSiPsC4Fv()
	{
		int num = 2;
		RegistryKey registryKey = default(RegistryKey);
		string result = default(string);
		string text2 = default(string);
		int num4 = default(int);
		int num6 = default(int);
		bool flag2 = default(bool);
		object obj = default(object);
		string text = default(string);
		int num8 = default(int);
		int num10 = default(int);
		while (true)
		{
			string object_ = (string)ou8xDhIz0oR1PHjPT7j(33038);
			int num2 = 1;
			if (nRkGyvIk2y2ubaJvwkf() != null)
			{
				goto IL_002f;
			}
			goto IL_01c2;
			IL_01c2:
			while (true)
			{
				switch (num2)
				{
				case 6:
					registryKey = (RegistryKey)aPnfCN7DsPZkL9MrXZY(RegistryHive.LocalMachine, RegistryView.Registry64);
					num2 = 3;
					if (nlWxxcIKe8t7ejrb6Al())
					{
						continue;
					}
					goto IL_002f;
				case 5:
					result = text2;
					num2 = 0;
					if (nRkGyvIk2y2ubaJvwkf() == null)
					{
						continue;
					}
					goto default;
				case 3:
					try
					{
						RegistryKey registryKey2 = (RegistryKey)wxhCtT7q5RhFG35EqtQ(registryKey, object_);
						int num3 = 1;
						if (!nlWxxcIKe8t7ejrb6Al())
						{
							num3 = num4;
						}
						switch (num3)
						{
						case 1:
							try
							{
								bool flag = registryKey2 == null;
								int num5 = 0;
								if (nRkGyvIk2y2ubaJvwkf() != null)
								{
									num5 = num6;
								}
								while (true)
								{
									switch (num5)
									{
									case 4:
										flag2 = obj == null;
										num5 = 1;
										if (nRkGyvIk2y2ubaJvwkf() == null)
										{
											continue;
										}
										goto default;
									default:
										if (!flag)
										{
											obj = WG83eL7M3ciFfeqibY1(registryKey2, text);
											num6 = 4;
											goto case 4;
										}
										break;
									case 1:
										if (!flag2)
										{
											text2 = obj.ToString();
											goto end_IL_00cc;
										}
										goto case 3;
									case 3:
										throw new IndexOutOfRangeException(string.Format(XaXlykERDhtdRwMnBY.oXbWkAhpNa(32946), text));
									case 5:
										break;
									case 2:
										goto end_IL_00cc;
									}
									throw new KeyNotFoundException((string?)yZcoa37E4FYhUpcpS9T(ou8xDhIz0oR1PHjPT7j(32906), object_));
									continue;
									end_IL_00cc:
									break;
								}
							}
							finally
							{
								if (registryKey2 != null)
								{
									goto IL_0150;
								}
								int num7 = 1;
								if (nRkGyvIk2y2ubaJvwkf() == null)
								{
									goto IL_013d;
								}
								goto IL_0164;
								IL_013d:
								switch (num7)
								{
								default:
									goto end_IL_012a;
								case 2:
									break;
								case 0:
								case 1:
									goto end_IL_012a;
								}
								goto IL_0150;
								IL_0150:
								I3XXrV7Yt0ynYwZPVvV(registryKey2);
								num7 = 0;
								if (nlWxxcIKe8t7ejrb6Al())
								{
									goto IL_013d;
								}
								goto IL_0164;
								IL_0164:
								num7 = num8;
								goto IL_013d;
								end_IL_012a:;
							}
							break;
						case 0:
							break;
						}
					}
					finally
					{
						if (registryKey != null)
						{
							goto IL_0196;
						}
						int num9 = 2;
						if (nlWxxcIKe8t7ejrb6Al())
						{
							goto IL_0183;
						}
						goto IL_01aa;
						IL_0183:
						switch (num9)
						{
						default:
							goto end_IL_0170;
						case 1:
							break;
						case 0:
						case 2:
							goto end_IL_0170;
						}
						goto IL_0196;
						IL_0196:
						I3XXrV7Yt0ynYwZPVvV(registryKey);
						num9 = 0;
						if (nlWxxcIKe8t7ejrb6Al())
						{
							goto IL_0183;
						}
						goto IL_01aa;
						IL_01aa:
						num9 = num10;
						goto IL_0183;
						end_IL_0170:;
					}
					goto case 5;
				case 1:
					text = (string)ou8xDhIz0oR1PHjPT7j(33412);
					goto case 6;
				case 2:
					break;
				default:
					return result;
				}
				break;
			}
			continue;
			IL_002f:
			num2 = num;
			goto IL_01c2;
		}
	}

	public static void DVviTY3wKV()
	{
		int num = 15;
		RegistryKey registryKey = default(RegistryKey);
		string value = default(string);
		while (true)
		{
			U88Fbg7WqnN0Nh53h1t("");
			int num2 = 14;
			if (nRkGyvIk2y2ubaJvwkf() != null)
			{
				goto IL_0025;
			}
			goto IL_0183;
			IL_0183:
			while (true)
			{
				switch (num2)
				{
				case 16:
					bZHujn7rOdYOllEyxWi(ConsoleColor.Magenta);
					num2 = 0;
					if (nRkGyvIk2y2ubaJvwkf() == null)
					{
						continue;
					}
					goto IL_0025;
				case 14:
					bZHujn7rOdYOllEyxWi(ConsoleColor.Red);
					goto case 7;
				case 7:
					Console.Write((string?)ou8xDhIz0oR1PHjPT7j(32422));
					num2 = 8;
					if (nRkGyvIk2y2ubaJvwkf() == null)
					{
						continue;
					}
					goto IL_0025;
				case 13:
					KL0CfM7hqyxXKQZ7f9Q(XaXlykERDhtdRwMnBY.oXbWkAhpNa(32422));
					goto case 16;
				case 12:
					registryKey = (RegistryKey)aPnfCN7DsPZkL9MrXZY(RegistryHive.LocalMachine, RegistryView.Registry64);
					num2 = 11;
					if (nlWxxcIKe8t7ejrb6Al())
					{
						continue;
					}
					goto IL_0025;
				case 11:
					registryKey = (RegistryKey)PX100N77D1WyZNWCTj1(registryKey, XaXlykERDhtdRwMnBY.oXbWkAhpNa(3414), bool_0: true);
					goto case 4;
				case 4:
					registryKey.SetValue(XaXlykERDhtdRwMnBY.oXbWkAhpNa(33540), value);
					num2 = 1;
					if (nRkGyvIk2y2ubaJvwkf() != null)
					{
						continue;
					}
					goto case 5;
				case 5:
					JUDkHZ7XLfy8nTaP7bD(registryKey);
					num = 6;
					goto case 6;
				case 6:
					bZHujn7rOdYOllEyxWi(ConsoleColor.Red);
					num = 13;
					goto case 13;
				case 8:
					bZHujn7rOdYOllEyxWi(ConsoleColor.Magenta);
					num2 = 1;
					if (nRkGyvIk2y2ubaJvwkf() == null)
					{
						continue;
					}
					goto IL_0025;
				case 3:
					value = (string)EJsaKP7ocolEYy5VUwO(ou8xDhIz0oR1PHjPT7j(33528), wt71bG72E9Y2aT2ETum().ToString(), ou8xDhIz0oR1PHjPT7j(33534));
					num2 = 12;
					if (nlWxxcIKe8t7ejrb6Al())
					{
						continue;
					}
					goto IL_0025;
				case 2:
					Console.WriteLine("");
					num2 = 3;
					if (nRkGyvIk2y2ubaJvwkf() == null)
					{
						continue;
					}
					goto IL_0025;
				case 1:
					KL0CfM7hqyxXKQZ7f9Q(gNhUnZ7OQmuURTUBXJU(ou8xDhIz0oR1PHjPT7j(33478), tyUFun7i6KXr5ZCJaCc()));
					num = 2;
					goto case 2;
				case 15:
					break;
				default:
					Console.Write((string?)ou8xDhIz0oR1PHjPT7j(33570) + (string?)tyUFun7i6KXr5ZCJaCc());
					goto case 9;
				case 9:
					U88Fbg7WqnN0Nh53h1t("");
					return;
				case 10:
					return;
				}
				break;
			}
			continue;
			IL_0025:
			num2 = num;
			goto IL_0183;
		}
	}

	public static string tomi8oMKO3()
	{
		RegistryKey registryKey = default(RegistryKey);
		int num3 = default(int);
		bool flag2 = default(bool);
		string text2 = default(string);
		object value = default(object);
		int num5 = default(int);
		int num7 = default(int);
		string result = default(string);
		while (true)
		{
			string object_ = (string)ou8xDhIz0oR1PHjPT7j(3414);
			while (true)
			{
				string text = XaXlykERDhtdRwMnBY.oXbWkAhpNa(33540);
				int num = 0;
				if (nRkGyvIk2y2ubaJvwkf() == null)
				{
					goto IL_0191;
				}
				goto IL_01b4;
				IL_01b4:
				switch (num)
				{
				case 6:
					break;
				case 5:
					goto IL_001e;
				case 1:
					goto IL_0191;
				case 2:
					continue;
				case 3:
					goto end_IL_01d7;
				default:
					goto IL_0201;
				}
				goto IL_0006;
				IL_0191:
				registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
				num = 5;
				if (!nlWxxcIKe8t7ejrb6Al())
				{
					goto IL_001e;
				}
				goto IL_01b4;
				IL_001e:
				try
				{
					RegistryKey registryKey2 = (RegistryKey)wxhCtT7q5RhFG35EqtQ(registryKey, object_);
					int num2 = 0;
					if (!nlWxxcIKe8t7ejrb6Al())
					{
						num2 = num3;
					}
					switch (num2)
					{
					default:
						try
						{
							bool flag = registryKey2 == null;
							int num4 = 0;
							if (nlWxxcIKe8t7ejrb6Al())
							{
								goto IL_00a9;
							}
							goto IL_00c1;
							IL_00c1:
							while (true)
							{
								switch (num4)
								{
								case 6:
									break;
								case 5:
									if (flag2)
									{
										num4 = 0;
										if (nRkGyvIk2y2ubaJvwkf() == null)
										{
											continue;
										}
										goto default;
									}
									text2 = value.ToString();
									num4 = 1;
									if (!nlWxxcIKe8t7ejrb6Al())
									{
										num4 = num5;
									}
									continue;
								case 3:
									goto IL_00a9;
								case 2:
									flag2 = value == null;
									num5 = 5;
									goto case 5;
								case 4:
									goto IL_00e4;
								default:
									throw new IndexOutOfRangeException((string?)yZcoa37E4FYhUpcpS9T(ou8xDhIz0oR1PHjPT7j(32946), text));
								case 1:
									goto end_IL_0049;
								}
								break;
							}
							goto IL_005f;
							IL_00a9:
							if (!flag)
							{
								goto IL_005f;
							}
							goto IL_00e4;
							IL_005f:
							value = registryKey2.GetValue(text);
							num4 = 2;
							if (nlWxxcIKe8t7ejrb6Al())
							{
								goto IL_00c1;
							}
							goto end_IL_0049;
							IL_00e4:
							throw new KeyNotFoundException((string?)yZcoa37E4FYhUpcpS9T(ou8xDhIz0oR1PHjPT7j(32906), object_));
							end_IL_0049:;
						}
						finally
						{
							if (registryKey2 != null)
							{
								int num6 = 1;
								if (nRkGyvIk2y2ubaJvwkf() != null)
								{
									num6 = num7;
								}
								while (true)
								{
									switch (num6)
									{
									case 1:
										I3XXrV7Yt0ynYwZPVvV(registryKey2);
										num6 = 0;
										if (nRkGyvIk2y2ubaJvwkf() == null)
										{
											continue;
										}
										break;
									case 0:
										break;
									}
									break;
								}
							}
						}
						break;
					case 1:
						break;
					}
				}
				finally
				{
					if (registryKey != null)
					{
						goto IL_017c;
					}
					int num8 = 0;
					if (nlWxxcIKe8t7ejrb6Al())
					{
						goto IL_0169;
					}
					goto end_IL_0156;
					IL_0169:
					switch (num8)
					{
					default:
						goto end_IL_0156;
					case 2:
						break;
					case 0:
					case 1:
						goto end_IL_0156;
					}
					goto IL_017c;
					IL_017c:
					I3XXrV7Yt0ynYwZPVvV(registryKey);
					num8 = 1;
					if (nRkGyvIk2y2ubaJvwkf() == null)
					{
						goto IL_0169;
					}
					end_IL_0156:;
				}
				goto IL_0006;
				IL_0006:
				result = text2;
				num = 0;
				if (nRkGyvIk2y2ubaJvwkf() == null)
				{
					goto IL_01b4;
				}
				goto IL_0201;
				IL_0201:
				return result;
				continue;
				end_IL_01d7:
				break;
			}
		}
	}

	public static bool MjsiohlCZm(object object_0, object object_1, int int_0)
	{
		int num = 5;
		bool flag = default(bool);
		bool result = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			IL_00a0:
			int num2 = 0;
			int num3 = 4;
			if (nlWxxcIKe8t7ejrb6Al())
			{
				goto IL_002e;
			}
			goto IL_0061;
			IL_0061:
			while (true)
			{
				switch (num3)
				{
				case 1:
				case 13:
					flag = ((byte[])object_1)[num2 + int_0] != (byte)XVFhto7T7NPquHhUaDw(object_0, num2);
					goto case 10;
				case 10:
					if (!flag)
					{
						goto case 2;
					}
					goto case 11;
				case 2:
				case 12:
					num2++;
					break;
				case 4:
				case 9:
					break;
				case 7:
					goto IL_003a;
				case 11:
					result = false;
					num3 = 0;
					if (nlWxxcIKe8t7ejrb6Al())
					{
						continue;
					}
					goto IL_005d;
				case 5:
					goto IL_00a0;
				case 3:
					goto IL_00b5;
				default:
					goto end_IL_00a0;
				}
				break;
			}
			goto IL_002e;
			IL_002e:
			flag2 = num2 < ((string)object_0).Length;
			goto IL_003a;
			IL_003a:
			if (flag2)
			{
				num3 = 1;
				if (nRkGyvIk2y2ubaJvwkf() != null)
				{
					goto IL_005d;
				}
				goto IL_0061;
			}
			goto IL_00b5;
			IL_005d:
			num3 = num;
			goto IL_0061;
			IL_00b5:
			result = true;
			break;
			continue;
			end_IL_00a0:
			break;
		}
		return result;
	}

	public static void AUOi2XYFa0()
	{
		int num = 6;
		while (true)
		{
			string text = (string)SssFrU7IhVXCoCZCI5o(8);
			num = 5;
			while (true)
			{
				uint num2 = uint.Parse(text, NumberStyles.HexNumber);
				int num3 = 1;
				if (!nlWxxcIKe8t7ejrb6Al())
				{
					goto IL_0034;
				}
				goto IL_008f;
				IL_008f:
				while (true)
				{
					switch (num3)
					{
					case 8:
						Console.WriteLine("");
						goto case 3;
					case 3:
						KL0CfM7hqyxXKQZ7f9Q(ou8xDhIz0oR1PHjPT7j(32422));
						num3 = 2;
						if (nRkGyvIk2y2ubaJvwkf() == null)
						{
							continue;
						}
						goto IL_0034;
					case 2:
						bZHujn7rOdYOllEyxWi(ConsoleColor.Magenta);
						num3 = 0;
						if (nRkGyvIk2y2ubaJvwkf() == null)
						{
							continue;
						}
						goto IL_0034;
					case 1:
						bZHujn7rOdYOllEyxWi(ConsoleColor.Red);
						goto case 8;
					default:
						Console.Write((string?)ou8xDhIz0oR1PHjPT7j(33612) + text + (string?)ou8xDhIz0oR1PHjPT7j(33664) + num2);
						num3 = 7;
						if (nRkGyvIk2y2ubaJvwkf() == null)
						{
							continue;
						}
						goto case 2;
					case 5:
						break;
					case 6:
						goto end_IL_00ba;
					case 7:
						U88Fbg7WqnN0Nh53h1t("");
						return;
					case 4:
						return;
					}
					break;
				}
				continue;
				IL_0034:
				num3 = num;
				goto IL_008f;
				continue;
				end_IL_00ba:
				break;
			}
		}
	}

	public static void Af1iVioIaK()
	{
		int num = 14;
		RegistryKey object_ = default(RegistryKey);
		while (true)
		{
			Console.WriteLine("");
			while (true)
			{
				bZHujn7rOdYOllEyxWi(ConsoleColor.Red);
				while (true)
				{
					KL0CfM7hqyxXKQZ7f9Q(ou8xDhIz0oR1PHjPT7j(32422));
					int num2 = 0;
					if (nRkGyvIk2y2ubaJvwkf() != null)
					{
						goto IL_0070;
					}
					goto IL_013f;
					IL_013f:
					while (true)
					{
						switch (num2)
						{
						case 15:
							object_ = (RegistryKey)PX100N77D1WyZNWCTj1(object_, ou8xDhIz0oR1PHjPT7j(33712), bool_0: true);
							goto case 6;
						case 6:
							J4jMsA7GaC9Cd02N8t0(object_, ou8xDhIz0oR1PHjPT7j(33844), XaXlykERDhtdRwMnBY.oXbWkAhpNa(33872) + (string?)SssFrU7IhVXCoCZCI5o(15));
							num2 = 1;
							if (nRkGyvIk2y2ubaJvwkf() != null)
							{
								continue;
							}
							goto case 1;
						case 1:
							JUDkHZ7XLfy8nTaP7bD(object_);
							num2 = 10;
							if (nlWxxcIKe8t7ejrb6Al())
							{
								continue;
							}
							goto IL_0070;
						case 12:
							U88Fbg7WqnN0Nh53h1t("");
							goto case 2;
						case 2:
							object_ = (RegistryKey)aPnfCN7DsPZkL9MrXZY(RegistryHive.LocalMachine, RegistryView.Registry64);
							num2 = 15;
							if (nRkGyvIk2y2ubaJvwkf() == null)
							{
								continue;
							}
							goto case 1;
						case 10:
							bZHujn7rOdYOllEyxWi(ConsoleColor.Red);
							num2 = 8;
							if (nRkGyvIk2y2ubaJvwkf() == null)
							{
								continue;
							}
							goto case 7;
						case 7:
							KL0CfM7hqyxXKQZ7f9Q((string?)ou8xDhIz0oR1PHjPT7j(33674) + (string?)UnSAiN7abF34AlyZwUi());
							goto case 12;
						case 8:
							KL0CfM7hqyxXKQZ7f9Q(XaXlykERDhtdRwMnBY.oXbWkAhpNa(32422));
							goto case 3;
						case 3:
							bZHujn7rOdYOllEyxWi(ConsoleColor.Magenta);
							num2 = 3;
							if (nRkGyvIk2y2ubaJvwkf() != null)
							{
								continue;
							}
							goto case 5;
						case 5:
							KL0CfM7hqyxXKQZ7f9Q(gNhUnZ7OQmuURTUBXJU(ou8xDhIz0oR1PHjPT7j(33892), UnSAiN7abF34AlyZwUi()));
							num2 = 9;
							if (nlWxxcIKe8t7ejrb6Al())
							{
								continue;
							}
							goto IL_0070;
						default:
							bZHujn7rOdYOllEyxWi(ConsoleColor.Magenta);
							num2 = 7;
							if (nRkGyvIk2y2ubaJvwkf() == null)
							{
								continue;
							}
							goto IL_0070;
						case 4:
							break;
						case 13:
							goto end_IL_0186;
						case 14:
							goto end_IL_01a7;
						case 9:
							Console.WriteLine("");
							return;
						case 11:
							return;
						}
						break;
					}
					continue;
					IL_0070:
					num2 = num;
					goto IL_013f;
					continue;
					end_IL_0186:
					break;
				}
				continue;
				end_IL_01a7:
				break;
			}
		}
	}

	public static string QnXiFic29T()
	{
		int num = 5;
		RegistryKey registryKey = default(RegistryKey);
		int num4 = default(int);
		object value = default(object);
		bool flag2 = default(bool);
		string result2 = default(string);
		int num7 = default(int);
		int num9 = default(int);
		string result = default(string);
		while (true)
		{
			string text = XaXlykERDhtdRwMnBY.oXbWkAhpNa(33712);
			while (true)
			{
				string text2 = XaXlykERDhtdRwMnBY.oXbWkAhpNa(33844);
				int num2 = 0;
				if (nRkGyvIk2y2ubaJvwkf() != null)
				{
					goto IL_0029;
				}
				goto IL_002d;
				IL_002d:
				while (true)
				{
					switch (num2)
					{
					case 4:
						goto end_IL_002d;
					case 5:
						goto end_IL_0050;
					case 6:
						try
						{
							RegistryKey registryKey2 = (RegistryKey)wxhCtT7q5RhFG35EqtQ(registryKey, text);
							int num3 = 1;
							if (!nlWxxcIKe8t7ejrb6Al())
							{
								num3 = num4;
							}
							switch (num3)
							{
							case 1:
								try
								{
									bool flag = registryKey2 == null;
									int num5 = 0;
									if (nRkGyvIk2y2ubaJvwkf() == null)
									{
										goto IL_00bd;
									}
									goto IL_00cd;
									IL_00cd:
									switch (num5)
									{
									case 1:
										break;
									default:
										goto IL_00f1;
									case 6:
										goto IL_0113;
									case 3:
										goto IL_011a;
									case 5:
										goto IL_011e;
									case 2:
										goto IL_0129;
									case 4:
										goto end_IL_00a9;
									}
									goto IL_00bd;
									IL_00bd:
									if (flag)
									{
										num5 = 0;
										if (!nlWxxcIKe8t7ejrb6Al())
										{
											goto IL_00cd;
										}
										goto IL_00f1;
									}
									value = registryKey2.GetValue(text2);
									goto IL_0113;
									IL_0129:
									throw new IndexOutOfRangeException((string?)yZcoa37E4FYhUpcpS9T(XaXlykERDhtdRwMnBY.oXbWkAhpNa(32946), text2));
									IL_00f1:
									throw new KeyNotFoundException(string.Format((string)ou8xDhIz0oR1PHjPT7j(32906), text));
									IL_0113:
									flag2 = value == null;
									goto IL_011a;
									IL_011a:
									if (!flag2)
									{
										goto IL_011e;
									}
									goto IL_0129;
									IL_011e:
									result2 = value.ToString();
									end_IL_00a9:;
								}
								finally
								{
									if (registryKey2 != null)
									{
										goto IL_0166;
									}
									int num6 = 2;
									if (nlWxxcIKe8t7ejrb6Al())
									{
										goto IL_0155;
									}
									goto IL_017a;
									IL_0155:
									switch (num6)
									{
									case 1:
									case 2:
										goto end_IL_0142;
									}
									goto IL_0166;
									IL_0166:
									I3XXrV7Yt0ynYwZPVvV(registryKey2);
									num6 = 1;
									if (nRkGyvIk2y2ubaJvwkf() == null)
									{
										goto IL_0155;
									}
									goto IL_017a;
									IL_017a:
									num6 = num7;
									goto IL_0155;
									end_IL_0142:;
								}
								break;
							case 0:
								break;
							}
						}
						finally
						{
							if (registryKey != null)
							{
								int num8 = 1;
								if (!nlWxxcIKe8t7ejrb6Al())
								{
									num8 = num9;
								}
								while (true)
								{
									switch (num8)
									{
									case 1:
										I3XXrV7Yt0ynYwZPVvV(registryKey);
										num8 = 0;
										if (nlWxxcIKe8t7ejrb6Al())
										{
											continue;
										}
										break;
									case 0:
										break;
									}
									break;
								}
							}
						}
						goto case 2;
					case 2:
						return result2;
					case 1:
					case 3:
						return result;
					}
					registryKey = (RegistryKey)aPnfCN7DsPZkL9MrXZY(RegistryHive.LocalMachine, RegistryView.Registry64);
					num2 = 6;
					if (nlWxxcIKe8t7ejrb6Al())
					{
						continue;
					}
					goto IL_0029;
					continue;
					end_IL_002d:
					break;
				}
				continue;
				IL_0029:
				num2 = num;
				goto IL_002d;
				continue;
				end_IL_0050:
				break;
			}
		}
	}

	public TmmjZurs2XLgayfe3E()
	{
		nHAIH57vEtpnCdJ02yv();
		zB3PVH9hASM2TtLqpf.unC5KZCzPQ9Xt();
		base._002Ector();
	}

	static TmmjZurs2XLgayfe3E()
	{
		nHAIH57vEtpnCdJ02yv();
		zB3PVH9hASM2TtLqpf.unC5KZCzPQ9Xt();
		XgqiKUbaOe = new Random();
		psfiMQmEuK = new Random();
	}

	internal static object ElY5vaIbmCQv6wdCdIU()
	{
		return WindowsIdentity.GetCurrent();
	}

	internal static bool RB2dwTIuTjiBykEwfHc(object object_0, WindowsBuiltInRole windowsBuiltInRole_0)
	{
		return ((WindowsPrincipal)object_0).IsInRole(windowsBuiltInRole_0);
	}

	internal static bool nlWxxcIKe8t7ejrb6Al()
	{
		return n4tmXvIU0pfCE5bImDj == null;
	}

	internal static TmmjZurs2XLgayfe3E nRkGyvIk2y2ubaJvwkf()
	{
		return (TmmjZurs2XLgayfe3E)n4tmXvIU0pfCE5bImDj;
	}

	internal static object ou8xDhIz0oR1PHjPT7j(int int_0)
	{
		return XaXlykERDhtdRwMnBY.oXbWkAhpNa(int_0);
	}

	internal static int TGnp9r7FStvlDg0qIh7(object object_0)
	{
		return ((string)object_0).Length;
	}

	internal static int QQU2du7BSeMfYi16gy2(object object_0, int int_0)
	{
		return ((Random)object_0).Next(int_0);
	}

	internal static void U88Fbg7WqnN0Nh53h1t(object object_0)
	{
		Console.WriteLine((string?)object_0);
	}

	internal static void bZHujn7rOdYOllEyxWi(ConsoleColor consoleColor_0)
	{
		Console.ForegroundColor = consoleColor_0;
	}

	internal static void KL0CfM7hqyxXKQZ7f9Q(object object_0)
	{
		Console.Write((string?)object_0);
	}

	internal static object ntjGsq7jR41lolHEdV0()
	{
		return evwiBvf6tj();
	}

	internal static object gNhUnZ7OQmuURTUBXJU(object object_0, object object_1)
	{
		return (string?)object_0 + (string?)object_1;
	}

	internal static object SssFrU7IhVXCoCZCI5o(int int_0)
	{
		return yp7i44q6B0(int_0);
	}

	internal static object PX100N77D1WyZNWCTj1(object object_0, object object_1, bool bool_0)
	{
		return ((RegistryKey)object_0).OpenSubKey((string)object_1, bool_0);
	}

	internal static void JUDkHZ7XLfy8nTaP7bD(object object_0)
	{
		((RegistryKey)object_0).Close();
	}

	internal static object WG83eL7M3ciFfeqibY1(object object_0, object object_1)
	{
		return ((RegistryKey)object_0).GetValue((string?)object_1);
	}

	internal static object GoeWVo7tS5eGI03gal6()
	{
		return eyVi5Fojc7();
	}

	internal static object aPnfCN7DsPZkL9MrXZY(RegistryHive registryHive_0, RegistryView registryView_0)
	{
		return RegistryKey.OpenBaseKey(registryHive_0, registryView_0);
	}

	internal static void J4jMsA7GaC9Cd02N8t0(object object_0, object object_1, object object_2)
	{
		((RegistryKey)object_0).SetValue((string?)object_1, object_2);
	}

	internal static object wxhCtT7q5RhFG35EqtQ(object object_0, object object_1)
	{
		return ((RegistryKey)object_0).OpenSubKey((string)object_1);
	}

	internal static object yZcoa37E4FYhUpcpS9T(object object_0, object object_1)
	{
		return string.Format((string)object_0, object_1);
	}

	internal static void I3XXrV7Yt0ynYwZPVvV(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}

	internal static object tX9pV170SENXnkRUAQv(object object_0)
	{
		return string.Concat((string?[])object_0);
	}

	internal static char LBdKtr7HocZNbiHZsdP(object object_0, int int_0)
	{
		return ((string)object_0)[int_0];
	}

	internal static object oR2ynY7PhpOxKb5LqUj()
	{
		return OOGimapeRS();
	}

	internal static object UNsDH67dvjP1mEnSL3m(int int_0)
	{
		return IwBiGcX6RW(int_0);
	}

	internal static object zPq1hW7wotgS1epQAdw()
	{
		return iJSiPsC4Fv();
	}

	internal static object tyUFun7i6KXr5ZCJaCc()
	{
		return tomi8oMKO3();
	}

	internal static Guid wt71bG72E9Y2aT2ETum()
	{
		return Guid.NewGuid();
	}

	internal static object EJsaKP7ocolEYy5VUwO(object object_0, object object_1, object object_2)
	{
		return (string?)object_0 + (string?)object_1 + (string?)object_2;
	}

	internal static char XVFhto7T7NPquHhUaDw(object object_0, int int_0)
	{
		return ((string)object_0)[int_0];
	}

	internal static object UnSAiN7abF34AlyZwUi()
	{
		return QnXiFic29T();
	}

	internal static void nHAIH57vEtpnCdJ02yv()
	{
		XaXlykERDhtdRwMnBY.jXRWMU6APG();
	}
}
