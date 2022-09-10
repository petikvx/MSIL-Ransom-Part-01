namespace ManualMapInjection.Injection.Win32;

public struct IMAGE_TLS_DIRECTORY32
{
	public uint StartAddressOfRawData;

	public uint EndAddressOfRawData;

	public uint AddressOfIndex;

	public uint AddressOfCallBacks;

	public uint SizeOfZeroFill;

	public uint Characteristics;
}
