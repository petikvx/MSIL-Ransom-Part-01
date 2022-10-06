namespace ManualMapInjection.Injection.Win32;

public struct IMAGE_EXPORT_DIRECTORY
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
