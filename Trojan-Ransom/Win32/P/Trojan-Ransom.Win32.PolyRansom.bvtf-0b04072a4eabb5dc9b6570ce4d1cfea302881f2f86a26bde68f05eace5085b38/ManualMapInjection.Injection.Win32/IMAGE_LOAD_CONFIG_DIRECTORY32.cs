namespace ManualMapInjection.Injection.Win32;

public struct IMAGE_LOAD_CONFIG_DIRECTORY32
{
	public uint Size;

	public uint TimeDateStamp;

	public ushort MajorVersion;

	public ushort MinorVersion;

	public uint GlobalFlagsClear;

	public uint GlobalFlagsSet;

	public uint CriticalSectionDefaultTimeout;

	public uint DeCommitFreeBlockThreshold;

	public uint DeCommitTotalFreeThreshold;

	public uint LockPrefixTable;

	public uint MaximumAllocationSize;

	public uint VirtualMemoryThreshold;

	public uint ProcessHeapFlags;

	public uint ProcessAffinityMask;

	public ushort CSDVersion;

	public ushort Reserved1;

	public uint EditList;

	public uint SecurityCookie;

	public uint SEHandlerTable;

	public uint SEHandlerCount;

	public uint GuardCFCheckFunctionPointer;

	public uint Reserved2;

	public uint GuardCFFunctionTable;

	public uint GuardCFFunctionCount;

	public uint GuardFlags;
}
