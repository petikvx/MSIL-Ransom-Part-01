namespace SharpAESCrypt;

public static class Strings
{
	public static string CommandlineUsage = "SharpAESCrypt e|d password fromPath toPath";

	public static string CommandlineError = "Error: {0}";

	public static string CommandlineUnknownMode = "Invalid operation, must be (e)crypt or (d)ecrypt";

	public static string UnsupportedHashAlgorithmReuse = "The hash algortihm does not support reuse";

	public static string UnsupportedHashAlgorithmBlocks = "The hash algortihm does not support multiple blocks";

	public static string UnsupportedHashAlgorithmBlocksize = "Unable to digest {0} bytes, as the hash algorithm only returns {1} bytes";

	public static string UnexpectedEndOfStream = "The stream was exhausted unexpectedly";

	public static string StreamMustBeWriteAble = "When encrypting, the stream must be writeable";

	public static string StreamMustBeReadAble = "When decrypting, the stream must be readable";

	public static string InvalidOperationMode = "Invalid mode supplied";

	public static string InvalidFileFormat = "Invalid file format";

	public static string InvalidHeaderMarker = "Invalid header marker";

	public static string InvalidReservedFieldValue = "Reserved field is not zero";

	public static string UnsupportedFileVersion = "Unsuported file version: {0}";

	public static string InvalidExtensionData = "Invalid extension data, separator (0x00) not found";

	public static string InvalidPassword = "Invalid password or corrupted data";

	public static string InvalidFileLength = "File length is invalid";

	public static string VersionReadonlyForDecryption = "Version is readonly when decrypting";

	public static string VersionReadonly = "Version cannot be changed after encryption has started";

	public static string VersionUnsupported = "The maximum allowed version is {0}";

	public static string StreamMustSupportSeeking = "The stream must be seekable writing version 0 files";

	public static string CannotReadWhileEncrypting = "Cannot read while encrypting";

	public static string CannotWriteWhileDecrypting = "Cannot read while decrypting";

	public static string DataHMACMismatch = "Message has been altered, do not trust content";

	public static string DataHMACMismatch_v0 = "Invalid password or content has been altered";

	public static string EncodingNotSupported = "The required encoding (UTF-16LE) is not supported on this system";
}
