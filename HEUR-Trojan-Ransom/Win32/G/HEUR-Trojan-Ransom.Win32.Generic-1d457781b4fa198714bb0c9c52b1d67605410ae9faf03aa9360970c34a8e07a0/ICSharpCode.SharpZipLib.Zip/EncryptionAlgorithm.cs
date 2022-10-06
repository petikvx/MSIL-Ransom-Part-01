namespace ICSharpCode.SharpZipLib.Zip;

public enum EncryptionAlgorithm
{
	None = 0,
	PkzipClassic = 1,
	Des = 26113,
	RC2 = 26114,
	TripleDes168 = 26115,
	TripleDes112 = 26121,
	Aes128 = 26126,
	Aes192 = 26127,
	Aes256 = 26128,
	RC2Corrected = 26370,
	Blowfish = 26400,
	Twofish = 26401,
	RC4 = 26625,
	Unknown = 65535
}
