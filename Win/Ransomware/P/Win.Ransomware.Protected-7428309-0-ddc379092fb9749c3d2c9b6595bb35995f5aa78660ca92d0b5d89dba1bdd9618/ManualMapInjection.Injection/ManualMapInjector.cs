using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using ConversionBack;
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
		object[] array = new object[2] { this, address };
		return (PIMAGE_DOS_HEADER)ConvertBack.Runner(640, 176, 2, array);
	}

	private PIMAGE_NT_HEADERS32 GetNtHeader(IntPtr address)
	{
		object[] array = new object[2] { this, address };
		return (PIMAGE_NT_HEADERS32)ConvertBack.Runner(816, 288, 3, array);
	}

	private IntPtr RemoteAllocateMemory(uint size)
	{
		object[] array = new object[2] { this, size };
		return (IntPtr)ConvertBack.Runner(1104, 112, 4, array);
	}

	private IntPtr AllocateMemory(uint size)
	{
		object[] array = new object[2] { this, size };
		return (IntPtr)ConvertBack.Runner(1216, 96, 5, array);
	}

	private IntPtr RvaToPointer(uint rva, IntPtr baseAddress)
	{
		object[] array = new object[3] { this, rva, baseAddress };
		return (IntPtr)ConvertBack.Runner(1312, 192, 6, array);
	}

	private bool InjectDependency(string dependency)
	{
		object[] array = new object[2] { this, dependency };
		return (bool)ConvertBack.Runner(1504, 880, 7, array);
	}

	private IntPtr GetRemoteModuleHandleA(string module)
	{
		object[] array = new object[2] { this, module };
		return (IntPtr)ConvertBack.Runner(2384, 1792, 8, array);
	}

	private IntPtr GetDependencyProcAddressA(IntPtr moduleBase, PCHAR procName)
	{
		object[] array = new object[3] { this, moduleBase, procName };
		return (IntPtr)ConvertBack.Runner(4176, 2336, 9, array);
	}

	private bool ProcessImportTable(IntPtr baseAddress)
	{
		object[] array = new object[2] { this, baseAddress };
		return (bool)ConvertBack.Runner(6512, 1968, 10, array);
	}

	private bool ProcessDelayedImportTable(IntPtr baseAddress, IntPtr remoteAddress)
	{
		object[] array = new object[3] { this, baseAddress, remoteAddress };
		return (bool)ConvertBack.Runner(8480, 1840, 11, array);
	}

	private bool ProcessRelocation(uint imageBaseDelta, ushort data, PBYTE relocationBase)
	{
		object[] array = new object[4] { this, imageBaseDelta, data, relocationBase };
		return (bool)ConvertBack.Runner(10320, 736, 12, array);
	}

	private bool ProcessRelocations(IntPtr baseAddress, IntPtr remoteAddress)
	{
		object[] array = new object[3] { this, baseAddress, remoteAddress };
		return (bool)ConvertBack.Runner(11056, 1072, 13, array);
	}

	private uint GetSectionProtection(DataSectionFlags characteristics)
	{
		object[] array = new object[2] { this, characteristics };
		return (uint)ConvertBack.Runner(12128, 848, 14, array);
	}

	private bool ProcessSection(char[] name, IntPtr baseAddress, IntPtr remoteAddress, ulong rawData, ulong virtualAddress, ulong rawSize, ulong virtualSize, uint protectFlag)
	{
		object[] array = new object[9] { this, name, baseAddress, remoteAddress, rawData, virtualAddress, rawSize, virtualSize, protectFlag };
		return (bool)ConvertBack.Runner(12976, 368, 15, array);
	}

	private bool ProcessSections(IntPtr baseAddress, IntPtr remoteAddress)
	{
		object[] array = new object[3] { this, baseAddress, remoteAddress };
		return (bool)ConvertBack.Runner(13344, 896, 16, array);
	}

	private bool ExecuteRemoteThreadBuffer(byte[] threadData, bool async)
	{
		object[] array = new object[3] { this, threadData, async };
		return (bool)ConvertBack.Runner(14240, 672, 17, array);
	}

	private bool CallEntryPoint(IntPtr baseAddress, uint entrypoint, bool async)
	{
		object[] array = new object[4] { this, baseAddress, entrypoint, async };
		return (bool)ConvertBack.Runner(14912, 512, 18, array);
	}

	private bool ProcessTlsEntries(IntPtr baseAddress, IntPtr remoteAddress)
	{
		object[] array = new object[3] { this, baseAddress, remoteAddress };
		return (bool)ConvertBack.Runner(15424, 864, 19, array);
	}

	private IntPtr LoadImageToMemory(IntPtr baseAddress)
	{
		object[] array = new object[2] { this, baseAddress };
		return (IntPtr)ConvertBack.Runner(16288, 2512, 20, array);
	}

	private GCHandle PinBuffer(byte[] buffer)
	{
		object[] array = new object[2] { this, buffer };
		return (GCHandle)ConvertBack.Runner(18800, 64, 21, array);
	}

	private void FreeHandle(GCHandle handle)
	{
		object[] array = new object[2] { this, handle };
		ConvertBack.Runner(18864, 80, 22, array);
	}

	private void OpenTarget()
	{
		object[] array = new object[1] { this };
		ConvertBack.Runner(18944, 192, 23, array);
	}

	private void CloseTarget()
	{
		object[] array = new object[1] { this };
		ConvertBack.Runner(19136, 128, 24, array);
	}

	public IntPtr Inject(byte[] buffer)
	{
		object[] array = new object[2] { this, buffer };
		return (IntPtr)ConvertBack.Runner(19264, 496, 25, array);
	}

	public IntPtr Inject(string file)
	{
		object[] array = new object[2] { this, file };
		return (IntPtr)ConvertBack.Runner(19760, 80, 26, array);
	}

	public ManualMapInjector(Process p)
	{
		_process = p;
	}
}
