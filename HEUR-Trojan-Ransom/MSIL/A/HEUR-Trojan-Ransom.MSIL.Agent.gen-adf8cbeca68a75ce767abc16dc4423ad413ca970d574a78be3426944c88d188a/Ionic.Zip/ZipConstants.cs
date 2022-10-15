namespace Ionic.Zip;

internal static class ZipConstants
{
	public const uint PackedToRemovableMedia = 808471376u;

	public const uint Zip64EndOfCentralDirectoryRecordSignature = 101075792u;

	public const uint Zip64EndOfCentralDirectoryLocatorSignature = 117853008u;

	public const uint EndOfCentralDirectorySignature = 101010256u;

	public const int ZipEntrySignature = 67324752;

	public const int ZipEntryDataDescriptorSignature = 134695760;

	public const int SplitArchiveSignature = 134695760;

	public const int ZipDirEntrySignature = 33639248;

	public const int AesKeySize = 192;

	public const int AesBlockSize = 128;

	public const ushort AesAlgId128 = 26126;

	public const ushort AesAlgId192 = 26127;

	public const ushort AesAlgId256 = 26128;
}
