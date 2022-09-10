namespace OpenNETCF.Desktop.Communication;

public struct MEMORYSTATUS
{
	internal uint dwLength;

	public int dwMemoryLoad;

	public int dwTotalPhys;

	public int dwAvailPhys;

	public int dwTotalPageFile;

	public int dwAvailPageFile;

	public int dwTotalVirtual;

	public int dwAvailVirtual;
}
