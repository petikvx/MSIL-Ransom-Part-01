using System;
using System.IO;
using System.Security.Cryptography;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal sealed class RsaKeyGen
{
	private const int Xpq12Length = 14;

	private const int XpqLength = 128;

	private const int NumberOfSha1Hashes = 16;

	private const int InfoCardKeyLength = 2048;

	private const int HnLength = 20;

	private const int PublicExponentValue = 65537;

	private const string Aes128EncryptionKey = "f561e58b-3ebc-4e0c-940d-0a6ddc219dfd";

	private const int ByteForHundredthBit = 12;

	private static int[] hashesToWriteP;

	private static int[] numBytesToWriteP;

	private static int[] srcIndexBytesToWriteP;

	private static int[] hashesToWriteQ;

	private static int[] numBytesToWriteQ;

	private static int[] srcIndexBytesToWriteQ;

	private static RijndaelManaged s_rjAes128;

	static RsaKeyGen()
	{
		hashesToWriteP = new int[8] { 2, 12, 11, 10, 0, 6, 5, 4 };
		numBytesToWriteP = new int[8] { 4, 20, 20, 20, 4, 20, 20, 20 };
		srcIndexBytesToWriteP = new int[8] { 16, 0, 0, 0, 16, 0, 0, 0 };
		hashesToWriteQ = new int[8] { 3, 15, 14, 13, 1, 9, 8, 7 };
		numBytesToWriteQ = numBytesToWriteP;
		srcIndexBytesToWriteQ = srcIndexBytesToWriteP;
		s_rjAes128 = new RijndaelManaged();
		s_rjAes128.Mode = CipherMode.ECB;
		s_rjAes128.Padding = PaddingMode.Zeros;
		s_rjAes128.Key = new Guid("f561e58b-3ebc-4e0c-940d-0a6ddc219dfd").ToByteArray();
	}

	public static byte[] CreateRsaKeyPairX931(byte[] masterKey, byte[] targetId)
	{
		InfoCardTrace.Assert(true, "Only 2048 bit key sizes supported", new object[0]);
		byte[][] array = CalculateHn(masterKey, targetId);
		byte[] array2 = null;
		byte[] array3 = new byte[14];
		byte[] array4 = new byte[14];
		byte[] array5 = new byte[14];
		byte[] array6 = new byte[14];
		byte[] array7 = new byte[128];
		byte[] array8 = new byte[128];
		Array.Copy(array[0], 0, array3, 0, array3.Length);
		Array.Copy(array[1], 0, array4, 0, array4.Length);
		Array.Copy(array[2], 0, array5, 0, array5.Length);
		Array.Copy(array[3], 0, array6, 0, array6.Length);
		WriteToArray(hashesToWriteP, numBytesToWriteP, srcIndexBytesToWriteP, array, array7);
		WriteToArray(hashesToWriteQ, numBytesToWriteQ, srcIndexBytesToWriteQ, array, array8);
		try
		{
			KeyGenRestartCodes restartCode = KeyGenRestartCodes.X931RestartNone;
			do
			{
				array7[127] |= 192;
				array8[127] |= 192;
				array3[12] |= 16;
				array4[12] |= 16;
				array5[12] |= 16;
				array6[12] |= 16;
				array2 = NativeMcppMethods.X931KeyGenWrapper(array3, array4, array5, array6, array7, array8, 65537, ref restartCode);
				switch (restartCode)
				{
				case KeyGenRestartCodes.X931RestartXpXqClose:
					InfoCardTrace.Assert(null == array2, "Cryptoblob should be null", new object[0]);
					InfoCardRegenerateParam(array8);
					break;
				case KeyGenRestartCodes.X931RestartPQ12OverFlow:
					InfoCardTrace.Assert(null == array2, "Cryptoblob should be null", new object[0]);
					InfoCardRegenerateParam(array3);
					InfoCardRegenerateParam(array4);
					InfoCardRegenerateParam(array5);
					InfoCardRegenerateParam(array6);
					break;
				case KeyGenRestartCodes.X931RestartPQOverflow:
					InfoCardTrace.Assert(null == array2, "Cryptoblob should be null", new object[0]);
					InfoCardRegenerateParam(array7);
					InfoCardRegenerateParam(array8);
					break;
				case KeyGenRestartCodes.X931RestartNonTrivialGcd:
					InfoCardTrace.Assert(null == array2, "Cryptoblob should be null", new object[0]);
					InfoCardRegenerateParam(array3);
					InfoCardRegenerateParam(array4);
					InfoCardRegenerateParam(array5);
					InfoCardRegenerateParam(array6);
					break;
				case KeyGenRestartCodes.X931RestartDTooSmall:
					InfoCardTrace.Assert(null == array2, "Cryptoblob should be null", new object[0]);
					InfoCardTrace.Assert(false, "Not expected for d < 2^1024 with e = 65537", new object[0]);
					InfoCardRegenerateParam(array5);
					InfoCardRegenerateParam(array6);
					InfoCardRegenerateParam(array8);
					break;
				case KeyGenRestartCodes.X931RestartNone:
					InfoCardTrace.Assert(null != array2, "Cryptoblob should not be null since API succeeded", new object[0]);
					break;
				}
			}
			while (restartCode != 0);
			InfoCardTrace.Assert(null != array2, "Cryptoblob should NOT be null outside while loop", new object[0]);
			return array2;
		}
		finally
		{
			Array.Clear(array3, 0, array3.Length);
			Array.Clear(array4, 0, array4.Length);
			Array.Clear(array5, 0, array5.Length);
			Array.Clear(array6, 0, array6.Length);
			Array.Clear(array7, 0, array7.Length);
			Array.Clear(array8, 0, array8.Length);
		}
	}

	private static void WriteToArray(int[] hashesToWrite, int[] numBytesToWrite, int[] srcIndexBytesToWrite, byte[][] sourceArrayOfHashes, byte[] destArray)
	{
		InfoCardTrace.Assert(hashesToWrite.Length == numBytesToWrite.Length, "Size must be equal", new object[0]);
		InfoCardTrace.Assert(numBytesToWrite.Length == srcIndexBytesToWrite.Length, "Size must be equal", new object[0]);
		int num = 0;
		for (int i = 0; i < hashesToWrite.Length; i++)
		{
			int num2 = hashesToWrite[i];
			Array.Copy(sourceArrayOfHashes[num2], srcIndexBytesToWrite[i], destArray, num, numBytesToWrite[i]);
			num += numBytesToWrite[i];
		}
	}

	private static byte[][] CalculateHn(byte[] masterKey, byte[] subjectEntropy)
	{
		byte[][] array = new byte[16][];
		int num = masterKey.Length + subjectEntropy.Length + 4;
		byte[] array2 = new byte[num];
		Array.Copy(masterKey, 0, array2, 0, masterKey.Length);
		Array.Copy(subjectEntropy, 0, array2, masterKey.Length, subjectEntropy.Length);
		for (uint num2 = 0u; num2 < array.Length; num2++)
		{
			InfoCardTrace.Assert(num2 <= 255, "n must fit in a byte.", new object[0]);
			InfoCardTrace.Assert(array2.Length - 1 == masterKey.Length + subjectEntropy.Length + 3, "Index location of n must be last element of array.", new object[0]);
			array2[^1] = (byte)num2;
			array[num2] = SHA1.Create().ComputeHash(array2);
			Array.Reverse((Array)array[num2]);
		}
		Array.Clear(array2, 0, array2.Length);
		return array;
	}

	private static void InfoCardRegenerateParam(byte[] prevBytes)
	{
		byte[] array = AESEncryptECB(prevBytes);
		Array.Copy(array, 0, prevBytes, 0, prevBytes.Length);
		Array.Clear(array, 0, array.Length);
	}

	private static byte[] AESEncryptECB(byte[] plaintextbyte)
	{
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, s_rjAes128.CreateEncryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(plaintextbyte, 0, plaintextbyte.Length);
		cryptoStream.Close();
		byte[] result = memoryStream.ToArray();
		memoryStream.Close();
		return result;
	}

	private RsaKeyGen()
	{
	}
}
