namespace jgfjkggkiiy;

internal interface iep
{
	byte[] CreateEncryptionKey();

	byte[] GetEncryptionKey();

	byte[] EncryptBytes(byte[] fileBytes, byte[] encryptionKey);
}
