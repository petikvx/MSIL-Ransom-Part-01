namespace OpenNETCF.Desktop.Communication;

public struct SYSTEM_INFO
{
	public ProcessorArchitecture wProcessorArchitecture;

	internal ushort wReserved;

	public int dwPageSize;

	public int lpMinimumApplicationAddress;

	public int lpMaximumApplicationAddress;

	public int dwActiveProcessorMask;

	public int dwNumberOfProcessors;

	public ProcessorType dwProcessorType;

	public int dwAllocationGranularity;

	public short wProcessorLevel;

	public short wProcessorRevision;
}
