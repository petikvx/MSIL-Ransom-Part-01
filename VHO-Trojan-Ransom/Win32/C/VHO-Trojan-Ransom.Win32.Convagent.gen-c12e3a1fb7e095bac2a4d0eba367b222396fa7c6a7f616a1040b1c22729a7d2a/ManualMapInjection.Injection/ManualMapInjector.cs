#define DEBUG
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using ManualMapInjection.Injection.Win32;

namespace ManualMapInjection.Injection;

internal class ManualMapInjector
{
	private readonly Process _process;

	private IntPtr _hProcess;

	public bool AsyncInjection { get; set; } = false;


	public uint TimeOut { get; set; } = 5000u;


	private PIMAGE_DOS_HEADER GetDosHeader(IntPtr address)
	{
		PIMAGE_DOS_HEADER pIMAGE_DOS_HEADER = (PIMAGE_DOS_HEADER)address;
		if (!pIMAGE_DOS_HEADER.Value.isValid)
		{
			return null;
		}
		return pIMAGE_DOS_HEADER;
	}

	private PIMAGE_NT_HEADERS32 GetNtHeader(IntPtr address)
	{
		PIMAGE_DOS_HEADER dosHeader = GetDosHeader(address);
		if (dosHeader == null)
		{
			return null;
		}
		PIMAGE_NT_HEADERS32 pIMAGE_NT_HEADERS = (PIMAGE_NT_HEADERS32)(address + dosHeader.Value.e_lfanew);
		if (!pIMAGE_NT_HEADERS.Value.isValid)
		{
			return null;
		}
		return pIMAGE_NT_HEADERS;
	}

	private IntPtr RemoteAllocateMemory(uint size)
	{
		return Imports.VirtualAllocEx(_hProcess, UIntPtr.Zero, new IntPtr(size), Imports.AllocationType.Commit | Imports.AllocationType.Reserve, Imports.MemoryProtection.ExecuteReadWrite);
	}

	private IntPtr AllocateMemory(uint size)
	{
		return Imports.VirtualAlloc(IntPtr.Zero, new UIntPtr(size), Imports.AllocationType.Commit | Imports.AllocationType.Reserve, Imports.MemoryProtection.ExecuteReadWrite);
	}

	private IntPtr RvaToPointer(uint rva, IntPtr baseAddress)
	{
		PIMAGE_NT_HEADERS32 ntHeader = GetNtHeader(baseAddress);
		if (ntHeader == null)
		{
			return IntPtr.Zero;
		}
		return Imports.ImageRvaToVa(ntHeader.Address, baseAddress, new UIntPtr(rva), IntPtr.Zero);
	}

	private bool InjectDependency(string dependency)
	{
		IntPtr procAddress = Imports.GetProcAddress(Imports.GetModuleHandle("kernel32.dll"), "LoadLibraryA");
		if (procAddress == IntPtr.Zero)
		{
			Debug.WriteLine("[InjectDependency] GetProcAddress failed");
			return false;
		}
		IntPtr intPtr = RemoteAllocateMemory((uint)dependency.Length);
		if (intPtr == IntPtr.Zero)
		{
			Debug.WriteLine("[InjectDependency] RemoteAllocateMemory failed");
			return false;
		}
		byte[] bytes = Encoding.ASCII.GetBytes(dependency);
		bool result;
		if (result = Imports.WriteProcessMemory(_hProcess, intPtr, bytes, bytes.Length, out var _))
		{
			IntPtr hHandle = Imports.CreateRemoteThread(_hProcess, IntPtr.Zero, 0u, procAddress, intPtr, 0u, IntPtr.Zero);
			if (Imports.WaitForSingleObject(hHandle, TimeOut) != 0)
			{
				Debug.WriteLine("[InjectDependency] remote thread not signaled");
				return false;
			}
		}
		else
		{
			Debug.WriteLine("[InjectDependency] WriteProcessMemory failed");
		}
		Imports.VirtualFreeEx(_hProcess, intPtr, 0, Imports.FreeType.Release);
		return result;
	}

	private IntPtr GetRemoteModuleHandleA(string module)
	{
		IntPtr result = IntPtr.Zero;
		IntPtr processHeap = Imports.GetProcessHeap();
		uint num = (uint)Marshal.SizeOf(typeof(PROCESS_BASIC_INFORMATION));
		PPROCESS_BASIC_INFORMATION pPROCESS_BASIC_INFORMATION = (PPROCESS_BASIC_INFORMATION)Imports.HeapAlloc(processHeap, 8u, new UIntPtr(num));
		uint pSize;
		int num2 = Imports.NtQueryInformationProcess(_hProcess, 0, pPROCESS_BASIC_INFORMATION.Address, num, out pSize);
		if (num2 >= 0 && num < pSize)
		{
			if (pPROCESS_BASIC_INFORMATION != null)
			{
				Imports.HeapFree(processHeap, 0u, pPROCESS_BASIC_INFORMATION.Address);
			}
			pPROCESS_BASIC_INFORMATION = (PPROCESS_BASIC_INFORMATION)Imports.HeapAlloc(processHeap, 8u, new UIntPtr(num));
			if (pPROCESS_BASIC_INFORMATION == null)
			{
				Debug.WriteLine("[GetRemoteModuleHandleA] Couldn't allocate heap buffer");
				return IntPtr.Zero;
			}
			num2 = Imports.NtQueryInformationProcess(_hProcess, 0, pPROCESS_BASIC_INFORMATION.Address, pSize, out pSize);
		}
		if (num2 >= 0 && pPROCESS_BASIC_INFORMATION.Value.PebBaseAddress != IntPtr.Zero && Imports.ReadProcessMemory(_hProcess, pPROCESS_BASIC_INFORMATION.Value.PebBaseAddress + 12, out var lpBuffer, out var lpNumberOfBytesRead))
		{
			uint num3 = lpBuffer + 12;
			uint num4 = lpBuffer + 12;
			do
			{
				if (!Imports.ReadProcessMemory(_hProcess, new IntPtr(num4), out var lpBuffer2, out lpNumberOfBytesRead))
				{
					Imports.HeapFree(processHeap, 0u, pPROCESS_BASIC_INFORMATION.Address);
				}
				num4 = lpBuffer2;
				Imports.ReadProcessMemory(_hProcess, new IntPtr(lpBuffer2) + 44, out UNICODE_STRING lpBuffer3, out lpNumberOfBytesRead);
				string a = string.Empty;
				if (lpBuffer3.Length > 0)
				{
					byte[] array = new byte[lpBuffer3.Length];
					Imports.ReadProcessMemory(_hProcess, lpBuffer3.Buffer, array, out lpNumberOfBytesRead);
					a = Encoding.Unicode.GetString(array);
				}
				Imports.ReadProcessMemory(_hProcess, new IntPtr(lpBuffer2) + 24, out var lpBuffer4, out lpNumberOfBytesRead);
				Imports.ReadProcessMemory(_hProcess, new IntPtr(lpBuffer2) + 32, out var lpBuffer5, out lpNumberOfBytesRead);
				if (lpBuffer4 != 0 && lpBuffer5 != 0 && string.Equals(a, module, StringComparison.OrdinalIgnoreCase))
				{
					result = new IntPtr(lpBuffer4);
					break;
				}
			}
			while (num3 != num4);
		}
		if (pPROCESS_BASIC_INFORMATION != null)
		{
			Imports.HeapFree(processHeap, 0u, pPROCESS_BASIC_INFORMATION.Address);
		}
		return result;
	}

	private IntPtr GetDependencyProcAddressA(IntPtr moduleBase, PCHAR procName)
	{
		IntPtr intPtr = IntPtr.Zero;
		Imports.ReadProcessMemory(_hProcess, moduleBase, out IMAGE_DOS_HEADER lpBuffer, out UIntPtr lpNumberOfBytesRead);
		if (!lpBuffer.isValid)
		{
			return IntPtr.Zero;
		}
		Imports.ReadProcessMemory(_hProcess, moduleBase + lpBuffer.e_lfanew, out IMAGE_NT_HEADERS32 lpBuffer2, out lpNumberOfBytesRead);
		if (!lpBuffer2.isValid)
		{
			return IntPtr.Zero;
		}
		uint virtualAddress = lpBuffer2.OptionalHeader.ExportTable.VirtualAddress;
		if (virtualAddress != 0)
		{
			uint size = lpBuffer2.OptionalHeader.ExportTable.Size;
			PIMAGE_EXPORT_DIRECTORY pIMAGE_EXPORT_DIRECTORY = (PIMAGE_EXPORT_DIRECTORY)AllocateMemory(size);
			Imports.ReadProcessMemory(_hProcess, moduleBase + (int)virtualAddress, pIMAGE_EXPORT_DIRECTORY.Address, (int)size, out lpNumberOfBytesRead);
			PWORD pWORD = (PWORD)(pIMAGE_EXPORT_DIRECTORY.Address + (int)pIMAGE_EXPORT_DIRECTORY.Value.AddressOfNameOrdinals - (int)virtualAddress);
			PDWORD pDWORD = (PDWORD)(pIMAGE_EXPORT_DIRECTORY.Address + (int)pIMAGE_EXPORT_DIRECTORY.Value.AddressOfNames - (int)virtualAddress);
			PDWORD pDWORD2 = (PDWORD)(pIMAGE_EXPORT_DIRECTORY.Address + (int)pIMAGE_EXPORT_DIRECTORY.Value.AddressOfFunctions - (int)virtualAddress);
			for (uint num = 0u; num < pIMAGE_EXPORT_DIRECTORY.Value.NumberOfFunctions; num++)
			{
				PCHAR pCHAR = null;
				ushort num2;
				if (new PDWORD(procName.Address).Value <= 65535)
				{
					num2 = (ushort)num;
				}
				else
				{
					if (new PDWORD(procName.Address).Value <= 65535 || num >= pIMAGE_EXPORT_DIRECTORY.Value.NumberOfNames)
					{
						return IntPtr.Zero;
					}
					pCHAR = (PCHAR)new IntPtr(pDWORD[num] + pIMAGE_EXPORT_DIRECTORY.Address.ToInt32() - virtualAddress);
					num2 = pWORD[num];
				}
				if ((new PDWORD(procName.Address).Value > 65535 || new PDWORD(procName.Address).Value != num2 + pIMAGE_EXPORT_DIRECTORY.Value.Base) && (new PDWORD(procName.Address).Value <= 65535 || !(pCHAR.ToString() == procName.ToString())))
				{
					continue;
				}
				intPtr = moduleBase + (int)pDWORD2[num2];
				if (intPtr.ToInt64() >= (moduleBase + (int)virtualAddress).ToInt64() && intPtr.ToInt64() <= (moduleBase + (int)virtualAddress + (int)size).ToInt64())
				{
					byte[] array = new byte[255];
					Imports.ReadProcessMemory(_hProcess, intPtr, array, out lpNumberOfBytesRead);
					string text = Helpers.ToStringAnsi(array);
					string text2 = text.Substring(0, text.IndexOf(".")) + ".dll";
					string text3 = text.Substring(text.IndexOf(".") + 1);
					IntPtr remoteModuleHandleA = GetRemoteModuleHandleA(text2);
					if (remoteModuleHandleA == IntPtr.Zero)
					{
						InjectDependency(text2);
					}
					intPtr = ((!text3.StartsWith("#")) ? GetDependencyProcAddressA(remoteModuleHandleA, new PCHAR(text3)) : GetDependencyProcAddressA(remoteModuleHandleA, new PCHAR(text3) + 1));
				}
				break;
			}
			Imports.VirtualFree(pIMAGE_EXPORT_DIRECTORY.Address, 0, Imports.FreeType.Release);
		}
		return intPtr;
	}

	private bool ProcessImportTable(IntPtr baseAddress)
	{
		PIMAGE_NT_HEADERS32 ntHeader = GetNtHeader(baseAddress);
		if (ntHeader == null)
		{
			return false;
		}
		if (ntHeader.Value.OptionalHeader.ImportTable.Size != 0)
		{
			PIMAGE_IMPORT_DESCRIPTOR pIMAGE_IMPORT_DESCRIPTOR = (PIMAGE_IMPORT_DESCRIPTOR)RvaToPointer(ntHeader.Value.OptionalHeader.ImportTable.VirtualAddress, baseAddress);
			if (pIMAGE_IMPORT_DESCRIPTOR != null)
			{
				for (; pIMAGE_IMPORT_DESCRIPTOR.Value.Name != 0; ++pIMAGE_IMPORT_DESCRIPTOR)
				{
					PCHAR pCHAR = (PCHAR)RvaToPointer(pIMAGE_IMPORT_DESCRIPTOR.Value.Name, baseAddress);
					if (pCHAR == null)
					{
						continue;
					}
					if (pCHAR.ToString().Contains("-ms-win-crt-"))
					{
						pCHAR = new PCHAR("ucrtbase.dll");
					}
					IntPtr remoteModuleHandleA = GetRemoteModuleHandleA(pCHAR.ToString());
					if (remoteModuleHandleA == IntPtr.Zero)
					{
						InjectDependency(pCHAR.ToString());
						remoteModuleHandleA = GetRemoteModuleHandleA(pCHAR.ToString());
						if (remoteModuleHandleA == IntPtr.Zero)
						{
							Debug.WriteLine("[ProcessImportTable] failed to obtain module handle");
							continue;
						}
					}
					PIMAGE_THUNK_DATA pIMAGE_THUNK_DATA;
					PIMAGE_THUNK_DATA pIMAGE_THUNK_DATA2;
					if (pIMAGE_IMPORT_DESCRIPTOR.Value.OriginalFirstThunk != 0)
					{
						pIMAGE_THUNK_DATA = (PIMAGE_THUNK_DATA)RvaToPointer(pIMAGE_IMPORT_DESCRIPTOR.Value.OriginalFirstThunk, baseAddress);
						pIMAGE_THUNK_DATA2 = (PIMAGE_THUNK_DATA)RvaToPointer(pIMAGE_IMPORT_DESCRIPTOR.Value.FirstThunk, baseAddress);
					}
					else
					{
						pIMAGE_THUNK_DATA = (PIMAGE_THUNK_DATA)RvaToPointer(pIMAGE_IMPORT_DESCRIPTOR.Value.FirstThunk, baseAddress);
						pIMAGE_THUNK_DATA2 = (PIMAGE_THUNK_DATA)RvaToPointer(pIMAGE_IMPORT_DESCRIPTOR.Value.FirstThunk, baseAddress);
					}
					while (pIMAGE_THUNK_DATA.Value.AddressOfData != 0)
					{
						IntPtr dependencyProcAddressA;
						if ((pIMAGE_THUNK_DATA.Value.Ordinal & 0x80000000u) != 0)
						{
							short num = (short)(pIMAGE_THUNK_DATA.Value.Ordinal & 0xFFFF);
							dependencyProcAddressA = GetDependencyProcAddressA(remoteModuleHandleA, new PCHAR(num));
							if (dependencyProcAddressA == IntPtr.Zero)
							{
								return false;
							}
						}
						else
						{
							PIMAGE_IMPORT_BY_NAME pIMAGE_IMPORT_BY_NAME = (PIMAGE_IMPORT_BY_NAME)RvaToPointer(pIMAGE_THUNK_DATA2.Value.Ordinal, baseAddress);
							PCHAR procName = (PCHAR)pIMAGE_IMPORT_BY_NAME.Address + 2;
							dependencyProcAddressA = GetDependencyProcAddressA(remoteModuleHandleA, procName);
						}
						Marshal.WriteInt32(pIMAGE_THUNK_DATA2.Address, dependencyProcAddressA.ToInt32());
						++pIMAGE_THUNK_DATA;
						++pIMAGE_THUNK_DATA2;
					}
				}
				return true;
			}
			Debug.WriteLine("[ProcessImportTable] Size of table confirmed but pointer to data invalid");
			return false;
		}
		Debug.WriteLine("[ProcessImportTable] no imports");
		return true;
	}

	private bool ProcessDelayedImportTable(IntPtr baseAddress, IntPtr remoteAddress)
	{
		PIMAGE_NT_HEADERS32 ntHeader = GetNtHeader(baseAddress);
		if (ntHeader == null)
		{
			return false;
		}
		if (ntHeader.Value.OptionalHeader.DelayImportDescriptor.Size != 0)
		{
			PIMAGE_IMPORT_DESCRIPTOR pIMAGE_IMPORT_DESCRIPTOR = (PIMAGE_IMPORT_DESCRIPTOR)RvaToPointer(ntHeader.Value.OptionalHeader.DelayImportDescriptor.VirtualAddress, baseAddress);
			if (pIMAGE_IMPORT_DESCRIPTOR != null)
			{
				for (; pIMAGE_IMPORT_DESCRIPTOR.Value.Name != 0; ++pIMAGE_IMPORT_DESCRIPTOR)
				{
					PCHAR pCHAR = (PCHAR)RvaToPointer(pIMAGE_IMPORT_DESCRIPTOR.Value.Name, baseAddress);
					if (pCHAR == null)
					{
						continue;
					}
					IntPtr remoteModuleHandleA = GetRemoteModuleHandleA(pCHAR.ToString());
					if (remoteModuleHandleA == IntPtr.Zero)
					{
						InjectDependency(pCHAR.ToString());
						remoteModuleHandleA = GetRemoteModuleHandleA(pCHAR.ToString());
						if (remoteModuleHandleA == IntPtr.Zero)
						{
							Debug.WriteLine("[ProcessDelayedImportTable] no imports");
							continue;
						}
					}
					PIMAGE_THUNK_DATA pIMAGE_THUNK_DATA = null;
					PIMAGE_THUNK_DATA pIMAGE_THUNK_DATA2 = null;
					if (pIMAGE_IMPORT_DESCRIPTOR.Value.OriginalFirstThunk != 0)
					{
						pIMAGE_THUNK_DATA = (PIMAGE_THUNK_DATA)RvaToPointer(pIMAGE_IMPORT_DESCRIPTOR.Value.OriginalFirstThunk, baseAddress);
						pIMAGE_THUNK_DATA2 = (PIMAGE_THUNK_DATA)RvaToPointer(pIMAGE_IMPORT_DESCRIPTOR.Value.FirstThunk, baseAddress);
					}
					else
					{
						pIMAGE_THUNK_DATA = (PIMAGE_THUNK_DATA)RvaToPointer(pIMAGE_IMPORT_DESCRIPTOR.Value.FirstThunk, baseAddress);
						pIMAGE_THUNK_DATA2 = (PIMAGE_THUNK_DATA)RvaToPointer(pIMAGE_IMPORT_DESCRIPTOR.Value.FirstThunk, baseAddress);
					}
					while (pIMAGE_THUNK_DATA.Value.AddressOfData != 0)
					{
						IntPtr dependencyProcAddressA;
						if ((pIMAGE_THUNK_DATA.Value.Ordinal & 0x80000000u) != 0)
						{
							short num = (short)(pIMAGE_THUNK_DATA.Value.Ordinal & 0xFFFF);
							dependencyProcAddressA = GetDependencyProcAddressA(remoteModuleHandleA, new PCHAR(num));
							if (dependencyProcAddressA == IntPtr.Zero)
							{
								return false;
							}
						}
						else
						{
							PIMAGE_IMPORT_BY_NAME pIMAGE_IMPORT_BY_NAME = (PIMAGE_IMPORT_BY_NAME)RvaToPointer(pIMAGE_THUNK_DATA2.Value.Ordinal, baseAddress);
							PCHAR procName = (PCHAR)pIMAGE_IMPORT_BY_NAME.Address + 2;
							dependencyProcAddressA = GetDependencyProcAddressA(remoteModuleHandleA, procName);
						}
						Marshal.WriteInt32(pIMAGE_THUNK_DATA2.Address, dependencyProcAddressA.ToInt32());
						++pIMAGE_THUNK_DATA;
						++pIMAGE_THUNK_DATA2;
					}
				}
				return true;
			}
			Debug.WriteLine("[ProcessDelayedImportTable] Size of table confirmed but pointer to data invalid");
			return false;
		}
		return true;
	}

	private bool ProcessRelocation(uint imageBaseDelta, ushort data, PBYTE relocationBase)
	{
		bool result = true;
		switch ((data >> 12) & 0xF)
		{
		case 1:
		{
			PSHORT pSHORT = (PSHORT)(relocationBase + (data & 0xFFF)).Address;
			Marshal.WriteInt16(pSHORT.Address, (short)((long)pSHORT.Value + (long)(ushort)((imageBaseDelta >> 16) & 0xFFFF)));
			break;
		}
		case 2:
		{
			PSHORT pSHORT = (PSHORT)(relocationBase + (data & 0xFFF)).Address;
			Marshal.WriteInt16(pSHORT.Address, (short)((long)pSHORT.Value + (long)(ushort)(imageBaseDelta & 0xFFFF)));
			break;
		}
		case 3:
		{
			PDWORD pDWORD = (PDWORD)(relocationBase + (data & 0xFFF)).Address;
			Marshal.WriteInt32(pDWORD.Address, (int)(pDWORD.Value + imageBaseDelta));
			break;
		}
		default:
			result = false;
			break;
		case 10:
		{
			PDWORD pDWORD = (PDWORD)(relocationBase + (data & 0xFFF)).Address;
			Marshal.WriteInt32(pDWORD.Address, (int)(pDWORD.Value + imageBaseDelta));
			break;
		}
		case 0:
		case 4:
			break;
		}
		return result;
	}

	private bool ProcessRelocations(IntPtr baseAddress, IntPtr remoteAddress)
	{
		PIMAGE_NT_HEADERS32 ntHeader = GetNtHeader(baseAddress);
		if (ntHeader == null)
		{
			return false;
		}
		if ((ntHeader.Value.FileHeader.Characteristics & 1) > 0)
		{
			return true;
		}
		uint imageBaseDelta = (uint)(remoteAddress.ToInt32() - ntHeader.Value.OptionalHeader.ImageBase);
		uint size = ntHeader.Value.OptionalHeader.BaseRelocationTable.Size;
		if (size != 0)
		{
			PIMAGE_BASE_RELOCATION pIMAGE_BASE_RELOCATION = (PIMAGE_BASE_RELOCATION)RvaToPointer(ntHeader.Value.OptionalHeader.BaseRelocationTable.VirtualAddress, baseAddress);
			if (pIMAGE_BASE_RELOCATION == null)
			{
				return false;
			}
			PBYTE pBYTE = (PBYTE)pIMAGE_BASE_RELOCATION.Address + (int)size;
			while (pIMAGE_BASE_RELOCATION.Address.ToInt64() < pBYTE.Address.ToInt64())
			{
				PBYTE relocationBase = (PBYTE)RvaToPointer(pIMAGE_BASE_RELOCATION.Value.VirtualAddress, baseAddress);
				uint num = pIMAGE_BASE_RELOCATION.Value.SizeOfBlock - 8 >> 1;
				PWORD pWORD = (PWORD)(pIMAGE_BASE_RELOCATION + 1).Address;
				uint num2 = 0u;
				while (num2 < num)
				{
					ProcessRelocation(imageBaseDelta, pWORD.Value, relocationBase);
					num2++;
					++pWORD;
				}
				pIMAGE_BASE_RELOCATION = (PIMAGE_BASE_RELOCATION)pWORD.Address;
			}
		}
		return true;
	}

	private uint GetSectionProtection(DataSectionFlags characteristics)
	{
		uint num = 0u;
		if (characteristics.HasFlag(DataSectionFlags.MemoryNotCached))
		{
			num |= 0x200u;
		}
		if (characteristics.HasFlag(DataSectionFlags.MemoryExecute))
		{
			if (characteristics.HasFlag(DataSectionFlags.MemoryRead))
			{
				if (characteristics.HasFlag(DataSectionFlags.MemoryWrite))
				{
					return num | 0x40u;
				}
				return num | 0x20u;
			}
			if (characteristics.HasFlag(DataSectionFlags.MemoryWrite))
			{
				return num | 0x80u;
			}
			return num | 0x10u;
		}
		if (characteristics.HasFlag(DataSectionFlags.MemoryRead))
		{
			if (characteristics.HasFlag(DataSectionFlags.MemoryWrite))
			{
				return num | 4u;
			}
			return num | 2u;
		}
		if (characteristics.HasFlag(DataSectionFlags.MemoryWrite))
		{
			return num | 8u;
		}
		return num | 1u;
	}

	private bool ProcessSection(char[] name, IntPtr baseAddress, IntPtr remoteAddress, ulong rawData, ulong virtualAddress, ulong rawSize, ulong virtualSize, uint protectFlag)
	{
		if (!Imports.WriteProcessMemory(_hProcess, new IntPtr(remoteAddress.ToInt64() + (long)virtualAddress), new IntPtr(baseAddress.ToInt64() + (long)rawData), new IntPtr((long)rawSize), out var _))
		{
			return false;
		}
		if (!Imports.VirtualProtectEx(_hProcess, new IntPtr(remoteAddress.ToInt64() + (long)virtualAddress), new UIntPtr(virtualSize), protectFlag, out var _))
		{
			return false;
		}
		return true;
	}

	private bool ProcessSections(IntPtr baseAddress, IntPtr remoteAddress)
	{
		PIMAGE_NT_HEADERS32 ntHeader = GetNtHeader(baseAddress);
		if (ntHeader == null)
		{
			return false;
		}
		PIMAGE_SECTION_HEADER pIMAGE_SECTION_HEADER = (PIMAGE_SECTION_HEADER)(ntHeader.Address + 24 + ntHeader.Value.FileHeader.SizeOfOptionalHeader);
		for (ushort num = 0; num < ntHeader.Value.FileHeader.NumberOfSections; num = (ushort)(num + 1))
		{
			if (!Helpers._stricmp(".reloc".ToCharArray(), pIMAGE_SECTION_HEADER[num].Name))
			{
				DataSectionFlags characteristics = pIMAGE_SECTION_HEADER[num].Characteristics;
				if (characteristics.HasFlag(DataSectionFlags.MemoryRead) || characteristics.HasFlag(DataSectionFlags.MemoryWrite) || characteristics.HasFlag(DataSectionFlags.MemoryExecute))
				{
					uint sectionProtection = GetSectionProtection(pIMAGE_SECTION_HEADER[num].Characteristics);
					ProcessSection(pIMAGE_SECTION_HEADER[num].Name, baseAddress, remoteAddress, pIMAGE_SECTION_HEADER[num].PointerToRawData, pIMAGE_SECTION_HEADER[num].VirtualAddress, pIMAGE_SECTION_HEADER[num].SizeOfRawData, pIMAGE_SECTION_HEADER[num].VirtualSize, sectionProtection);
				}
			}
		}
		return true;
	}

	private bool ExecuteRemoteThreadBuffer(byte[] threadData, bool async)
	{
		IntPtr lpAddress = RemoteAllocateMemory((uint)threadData.Length);
		if (lpAddress == IntPtr.Zero)
		{
			return false;
		}
		bool result;
		if (result = Imports.WriteProcessMemory(_hProcess, lpAddress, threadData, threadData.Length, out var _))
		{
			IntPtr hHandle = Imports.CreateRemoteThread(_hProcess, IntPtr.Zero, 0u, lpAddress, IntPtr.Zero, 0u, IntPtr.Zero);
			if (async)
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					Imports.WaitForSingleObject(hHandle, 5000u);
					Imports.VirtualFreeEx(_hProcess, lpAddress, 0, Imports.FreeType.Release);
				})
				{
					IsBackground = true
				};
				thread.Start();
			}
			else
			{
				Imports.WaitForSingleObject(hHandle, 4000u);
				Imports.VirtualFreeEx(_hProcess, lpAddress, 0, Imports.FreeType.Release);
			}
		}
		return result;
	}

	private bool CallEntryPoint(IntPtr baseAddress, uint entrypoint, bool async)
	{
		List<byte> list = new List<byte>();
		list.Add(104);
		list.AddRange(BitConverter.GetBytes(baseAddress.ToInt32()));
		list.Add(104);
		list.AddRange(BitConverter.GetBytes(1));
		list.Add(104);
		list.AddRange(BitConverter.GetBytes(0));
		list.Add(184);
		list.AddRange(BitConverter.GetBytes(entrypoint));
		list.Add(byte.MaxValue);
		list.Add(208);
		list.Add(51);
		list.Add(192);
		list.Add(194);
		list.Add(4);
		list.Add(0);
		return ExecuteRemoteThreadBuffer(list.ToArray(), async);
	}

	private bool ProcessTlsEntries(IntPtr baseAddress, IntPtr remoteAddress)
	{
		PIMAGE_NT_HEADERS32 ntHeader = GetNtHeader(baseAddress);
		if (ntHeader == null)
		{
			return false;
		}
		if (ntHeader.Value.OptionalHeader.TLSTable.Size == 0)
		{
			return true;
		}
		PIMAGE_TLS_DIRECTORY32 pIMAGE_TLS_DIRECTORY = (PIMAGE_TLS_DIRECTORY32)RvaToPointer(ntHeader.Value.OptionalHeader.TLSTable.VirtualAddress, baseAddress);
		if (pIMAGE_TLS_DIRECTORY == null)
		{
			return true;
		}
		if (pIMAGE_TLS_DIRECTORY.Value.AddressOfCallBacks == 0)
		{
			return true;
		}
		byte[] array = new byte[1020];
		if (!Imports.ReadProcessMemory(_hProcess, new IntPtr(pIMAGE_TLS_DIRECTORY.Value.AddressOfCallBacks), array, out var _))
		{
			return false;
		}
		PDWORD pDWORD = new PDWORD(array);
		bool result = true;
		for (uint num = 0u; pDWORD[num] != 0; num++)
		{
			if (!(result = CallEntryPoint(remoteAddress, pDWORD[num], async: false)))
			{
				break;
			}
		}
		return result;
	}

	private IntPtr LoadImageToMemory(IntPtr baseAddress)
	{
		PIMAGE_NT_HEADERS32 ntHeader = GetNtHeader(baseAddress);
		if (ntHeader == null)
		{
			Debug.WriteLine("[LoadImageToMemory] Invalid Image: No IMAGE_NT_HEADERS");
			return IntPtr.Zero;
		}
		if (ntHeader.Value.FileHeader.NumberOfSections == 0)
		{
			Debug.WriteLine("[LoadImageToMemory] Invalid Image: No Sections");
			return IntPtr.Zero;
		}
		uint num = uint.MaxValue;
		uint num2 = 0u;
		PIMAGE_SECTION_HEADER pIMAGE_SECTION_HEADER = (PIMAGE_SECTION_HEADER)(ntHeader.Address + 24 + ntHeader.Value.FileHeader.SizeOfOptionalHeader);
		for (uint num3 = 0u; num3 < ntHeader.Value.FileHeader.NumberOfSections; num3++)
		{
			if (pIMAGE_SECTION_HEADER[num3].VirtualSize != 0)
			{
				if (pIMAGE_SECTION_HEADER[num3].VirtualAddress < num)
				{
					num = pIMAGE_SECTION_HEADER[num3].VirtualAddress;
				}
				if (pIMAGE_SECTION_HEADER[num3].VirtualAddress + pIMAGE_SECTION_HEADER[num3].VirtualSize > num2)
				{
					num2 = pIMAGE_SECTION_HEADER[num3].VirtualAddress + pIMAGE_SECTION_HEADER[num3].VirtualSize;
				}
			}
		}
		uint size = num2 - num;
		if (ntHeader.Value.OptionalHeader.ImageBase % 4096u != 0)
		{
			Debug.WriteLine("[LoadImageToMemory] Invalid Image: Not Page Aligned");
			return IntPtr.Zero;
		}
		if (ntHeader.Value.OptionalHeader.DelayImportDescriptor.Size != 0)
		{
			Debug.WriteLine("[LoadImageToMemory] This method is not supported for Managed executables");
			return IntPtr.Zero;
		}
		IntPtr intPtr = RemoteAllocateMemory(size);
		if (intPtr == IntPtr.Zero)
		{
			Debug.WriteLine("[LoadImageToMemory] Failed to allocate remote memory for module");
			return IntPtr.Zero;
		}
		if (!ProcessImportTable(baseAddress))
		{
			Debug.WriteLine("[LoadImageToMemory] Failed to fix imports");
			return IntPtr.Zero;
		}
		if (!ProcessDelayedImportTable(baseAddress, intPtr))
		{
			Debug.WriteLine("[LoadImageToMemory] Failed to fix delayed imports");
			return IntPtr.Zero;
		}
		if (!ProcessRelocations(baseAddress, intPtr))
		{
			Debug.WriteLine("[LoadImageToMemory] Failed to process relocations");
			return IntPtr.Zero;
		}
		if (!ProcessSections(baseAddress, intPtr))
		{
			Debug.WriteLine("[LoadImageToMemory] Failed to process sections");
			return IntPtr.Zero;
		}
		if (!ProcessTlsEntries(baseAddress, intPtr))
		{
			Debug.WriteLine("[LoadImageToMemory] ProcessTlsEntries Failed");
			return IntPtr.Zero;
		}
		if (ntHeader.Value.OptionalHeader.AddressOfEntryPoint != 0)
		{
			int entrypoint = intPtr.ToInt32() + (int)ntHeader.Value.OptionalHeader.AddressOfEntryPoint;
			if (!CallEntryPoint(intPtr, (uint)entrypoint, AsyncInjection))
			{
				Debug.WriteLine("[LoadImageToMemory] Failed to call entrypoint");
				return IntPtr.Zero;
			}
		}
		return intPtr;
	}

	private GCHandle PinBuffer(byte[] buffer)
	{
		return GCHandle.Alloc(buffer, GCHandleType.Pinned);
	}

	private void FreeHandle(GCHandle handle)
	{
		if (handle.IsAllocated)
		{
			handle.Free();
		}
	}

	private void OpenTarget()
	{
		_hProcess = Imports.OpenProcess(_process, Imports.ProcessAccessFlags.All);
		if (_hProcess == IntPtr.Zero)
		{
			throw new Exception($"Failed to open handle. Error {Marshal.GetLastWin32Error()}");
		}
	}

	private void CloseTarget()
	{
		if (_hProcess != IntPtr.Zero)
		{
			Imports.CloseHandle(_hProcess);
			_hProcess = IntPtr.Zero;
		}
	}

	public IntPtr Inject(byte[] buffer)
	{
		GCHandle handle = default(GCHandle);
		buffer = buffer.ToArray();
		IntPtr result = IntPtr.Zero;
		try
		{
			if (_process == null || _process.HasExited)
			{
				return result;
			}
			handle = PinBuffer(buffer);
			OpenTarget();
			result = LoadImageToMemory(handle.AddrOfPinnedObject());
		}
		catch (Exception arg)
		{
			Debug.WriteLine($"Unexpected error {arg}");
		}
		finally
		{
			FreeHandle(handle);
			CloseTarget();
		}
		return result;
	}

	public IntPtr Inject(string file)
	{
		return Inject(File.ReadAllBytes(file));
	}

	public ManualMapInjector(Process p)
	{
		_process = p;
	}
}
