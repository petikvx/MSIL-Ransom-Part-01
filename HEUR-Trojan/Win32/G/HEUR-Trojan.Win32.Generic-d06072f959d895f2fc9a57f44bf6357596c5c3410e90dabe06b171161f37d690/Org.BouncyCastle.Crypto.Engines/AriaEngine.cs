using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Crypto.Engines;

public class AriaEngine : IBlockCipher
{
	private static readonly byte[][] C = new byte[3][]
	{
		Hex.DecodeStrict("517cc1b727220a94fe13abe8fa9a6ee0"),
		Hex.DecodeStrict("6db14acc9e21c820ff28b1d5ef5de2b0"),
		Hex.DecodeStrict("db92371d2126e9700324977504e8c90e")
	};

	private static readonly byte[] SB1_sbox = new byte[256]
	{
		99, 124, 119, 123, 242, 107, 111, 197, 48, 1,
		103, 43, 254, 215, 171, 118, 202, 130, 201, 125,
		250, 89, 71, 240, 173, 212, 162, 175, 156, 164,
		114, 192, 183, 253, 147, 38, 54, 63, 247, 204,
		52, 165, 229, 241, 113, 216, 49, 21, 4, 199,
		35, 195, 24, 150, 5, 154, 7, 18, 128, 226,
		235, 39, 178, 117, 9, 131, 44, 26, 27, 110,
		90, 160, 82, 59, 214, 179, 41, 227, 47, 132,
		83, 209, 0, 237, 32, 252, 177, 91, 106, 203,
		190, 57, 74, 76, 88, 207, 208, 239, 170, 251,
		67, 77, 51, 133, 69, 249, 2, 127, 80, 60,
		159, 168, 81, 163, 64, 143, 146, 157, 56, 245,
		188, 182, 218, 33, 16, 255, 243, 210, 205, 12,
		19, 236, 95, 151, 68, 23, 196, 167, 126, 61,
		100, 93, 25, 115, 96, 129, 79, 220, 34, 42,
		144, 136, 70, 238, 184, 20, 222, 94, 11, 219,
		224, 50, 58, 10, 73, 6, 36, 92, 194, 211,
		172, 98, 145, 149, 228, 121, 231, 200, 55, 109,
		141, 213, 78, 169, 108, 86, 244, 234, 101, 122,
		174, 8, 186, 120, 37, 46, 28, 166, 180, 198,
		232, 221, 116, 31, 75, 189, 139, 138, 112, 62,
		181, 102, 72, 3, 246, 14, 97, 53, 87, 185,
		134, 193, 29, 158, 225, 248, 152, 17, 105, 217,
		142, 148, 155, 30, 135, 233, 206, 85, 40, 223,
		140, 161, 137, 13, 191, 230, 66, 104, 65, 153,
		45, 15, 176, 84, 187, 22
	};

	private static readonly byte[] SB2_sbox = new byte[256]
	{
		226, 78, 84, 252, 148, 194, 74, 204, 98, 13,
		106, 70, 60, 77, 139, 209, 94, 250, 100, 203,
		180, 151, 190, 43, 188, 119, 46, 3, 211, 25,
		89, 193, 29, 6, 65, 107, 85, 240, 153, 105,
		234, 156, 24, 174, 99, 223, 231, 187, 0, 115,
		102, 251, 150, 76, 133, 228, 58, 9, 69, 170,
		15, 238, 16, 235, 45, 127, 244, 41, 172, 207,
		173, 145, 141, 120, 200, 149, 249, 47, 206, 205,
		8, 122, 136, 56, 92, 131, 42, 40, 71, 219,
		184, 199, 147, 164, 18, 83, 255, 135, 14, 49,
		54, 33, 88, 72, 1, 142, 55, 116, 50, 202,
		233, 177, 183, 171, 12, 215, 196, 86, 66, 38,
		7, 152, 96, 217, 182, 185, 17, 64, 236, 32,
		140, 189, 160, 201, 132, 4, 73, 35, 241, 79,
		80, 31, 19, 220, 216, 192, 158, 87, 227, 195,
		123, 101, 59, 2, 143, 62, 232, 37, 146, 229,
		21, 221, 253, 23, 169, 191, 212, 154, 126, 197,
		57, 103, 254, 118, 157, 67, 167, 225, 208, 245,
		104, 242, 27, 52, 112, 5, 163, 138, 213, 121,
		134, 168, 48, 198, 81, 75, 30, 166, 39, 246,
		53, 210, 110, 36, 22, 130, 95, 218, 230, 117,
		162, 239, 44, 178, 28, 159, 93, 111, 128, 10,
		114, 68, 155, 108, 144, 11, 91, 51, 125, 90,
		82, 243, 97, 161, 247, 176, 214, 63, 124, 109,
		237, 20, 224, 165, 61, 34, 179, 248, 137, 222,
		113, 26, 175, 186, 181, 129
	};

	private static readonly byte[] SB3_sbox = new byte[256]
	{
		82, 9, 106, 213, 48, 54, 165, 56, 191, 64,
		163, 158, 129, 243, 215, 251, 124, 227, 57, 130,
		155, 47, 255, 135, 52, 142, 67, 68, 196, 222,
		233, 203, 84, 123, 148, 50, 166, 194, 35, 61,
		238, 76, 149, 11, 66, 250, 195, 78, 8, 46,
		161, 102, 40, 217, 36, 178, 118, 91, 162, 73,
		109, 139, 209, 37, 114, 248, 246, 100, 134, 104,
		152, 22, 212, 164, 92, 204, 93, 101, 182, 146,
		108, 112, 72, 80, 253, 237, 185, 218, 94, 21,
		70, 87, 167, 141, 157, 132, 144, 216, 171, 0,
		140, 188, 211, 10, 247, 228, 88, 5, 184, 179,
		69, 6, 208, 44, 30, 143, 202, 63, 15, 2,
		193, 175, 189, 3, 1, 19, 138, 107, 58, 145,
		17, 65, 79, 103, 220, 234, 151, 242, 207, 206,
		240, 180, 230, 115, 150, 172, 116, 34, 231, 173,
		53, 133, 226, 249, 55, 232, 28, 117, 223, 110,
		71, 241, 26, 113, 29, 41, 197, 137, 111, 183,
		98, 14, 170, 24, 190, 27, 252, 86, 62, 75,
		198, 210, 121, 32, 154, 219, 192, 254, 120, 205,
		90, 244, 31, 221, 168, 51, 136, 7, 199, 49,
		177, 18, 16, 89, 39, 128, 236, 95, 96, 81,
		127, 169, 25, 181, 74, 13, 45, 229, 122, 159,
		147, 201, 156, 239, 160, 224, 59, 77, 174, 42,
		245, 176, 200, 235, 187, 60, 131, 83, 153, 97,
		23, 43, 4, 126, 186, 119, 214, 38, 225, 105,
		20, 99, 85, 33, 12, 125
	};

	private static readonly byte[] SB4_sbox = new byte[256]
	{
		48, 104, 153, 27, 135, 185, 33, 120, 80, 57,
		219, 225, 114, 9, 98, 60, 62, 126, 94, 142,
		241, 160, 204, 163, 42, 29, 251, 182, 214, 32,
		196, 141, 129, 101, 245, 137, 203, 157, 119, 198,
		87, 67, 86, 23, 212, 64, 26, 77, 192, 99,
		108, 227, 183, 200, 100, 106, 83, 170, 56, 152,
		12, 244, 155, 237, 127, 34, 118, 175, 221, 58,
		11, 88, 103, 136, 6, 195, 53, 13, 1, 139,
		140, 194, 230, 95, 2, 36, 117, 147, 102, 30,
		229, 226, 84, 216, 16, 206, 122, 232, 8, 44,
		18, 151, 50, 171, 180, 39, 10, 35, 223, 239,
		202, 217, 184, 250, 220, 49, 107, 209, 173, 25,
		73, 189, 81, 150, 238, 228, 168, 65, 218, 255,
		205, 85, 134, 54, 190, 97, 82, 248, 187, 14,
		130, 72, 105, 154, 224, 71, 158, 92, 4, 75,
		52, 21, 121, 38, 167, 222, 41, 174, 146, 215,
		132, 233, 210, 186, 93, 243, 197, 176, 191, 164,
		59, 113, 68, 70, 43, 252, 235, 111, 213, 246,
		20, 254, 124, 112, 90, 125, 253, 47, 24, 131,
		22, 165, 145, 31, 5, 149, 116, 169, 193, 91,
		74, 133, 109, 19, 7, 79, 78, 69, 178, 15,
		201, 28, 166, 188, 236, 115, 144, 123, 207, 89,
		143, 161, 249, 45, 242, 177, 0, 148, 55, 159,
		208, 46, 156, 110, 40, 63, 128, 240, 61, 211,
		37, 138, 181, 231, 66, 179, 199, 234, 247, 76,
		17, 51, 3, 162, 172, 96
	};

	protected const int BlockSize = 16;

	private byte[][] m_roundKeys;

	public virtual string AlgorithmName => "ARIA";

	public virtual bool IsPartialBlockOkay => false;

	public virtual void Init(bool forEncryption, ICipherParameters parameters)
	{
		if (!(parameters is KeyParameter keyParameter))
		{
			throw new ArgumentException("invalid parameter passed to ARIA init - " + Platform.GetTypeName(parameters));
		}
		m_roundKeys = KeySchedule(forEncryption, keyParameter.GetKey());
	}

	public virtual int GetBlockSize()
	{
		return 16;
	}

	public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
	{
		if (m_roundKeys == null)
		{
			throw new InvalidOperationException("ARIA engine not initialised");
		}
		Check.DataLength(input, inOff, 16, "input buffer too short");
		Check.OutputLength(output, outOff, 16, "output buffer too short");
		byte[] array = new byte[16];
		Array.Copy(input, inOff, array, 0, 16);
		int num = 0;
		int num2 = m_roundKeys.Length - 3;
		while (num < num2)
		{
			FO(array, m_roundKeys[num++]);
			FE(array, m_roundKeys[num++]);
		}
		FO(array, m_roundKeys[num++]);
		Xor(array, m_roundKeys[num++]);
		SL2(array);
		Xor(array, m_roundKeys[num]);
		Array.Copy(array, 0, output, outOff, 16);
		return 16;
	}

	public virtual void Reset()
	{
	}

	protected static void A(byte[] z)
	{
		byte b = z[0];
		byte b2 = z[1];
		byte b3 = z[2];
		byte b4 = z[3];
		byte b5 = z[4];
		byte b6 = z[5];
		byte b7 = z[6];
		byte b8 = z[7];
		byte b9 = z[8];
		byte b10 = z[9];
		byte b11 = z[10];
		byte b12 = z[11];
		byte b13 = z[12];
		byte b14 = z[13];
		byte b15 = z[14];
		byte b16 = z[15];
		z[0] = (byte)(b4 ^ b5 ^ b7 ^ b9 ^ b10 ^ b14 ^ b15);
		z[1] = (byte)(b3 ^ b6 ^ b8 ^ b9 ^ b10 ^ b13 ^ b16);
		z[2] = (byte)(b2 ^ b5 ^ b7 ^ b11 ^ b12 ^ b13 ^ b16);
		z[3] = (byte)(b ^ b6 ^ b8 ^ b11 ^ b12 ^ b14 ^ b15);
		z[4] = (byte)(b ^ b3 ^ b6 ^ b9 ^ b12 ^ b15 ^ b16);
		z[5] = (byte)(b2 ^ b4 ^ b5 ^ b10 ^ b11 ^ b15 ^ b16);
		z[6] = (byte)(b ^ b3 ^ b8 ^ b10 ^ b11 ^ b13 ^ b14);
		z[7] = (byte)(b2 ^ b4 ^ b7 ^ b9 ^ b12 ^ b13 ^ b14);
		z[8] = (byte)(b ^ b2 ^ b5 ^ b8 ^ b11 ^ b14 ^ b16);
		z[9] = (byte)(b ^ b2 ^ b6 ^ b7 ^ b12 ^ b13 ^ b15);
		z[10] = (byte)(b3 ^ b4 ^ b6 ^ b7 ^ b9 ^ b14 ^ b16);
		z[11] = (byte)(b3 ^ b4 ^ b5 ^ b8 ^ b10 ^ b13 ^ b15);
		z[12] = (byte)(b2 ^ b3 ^ b7 ^ b8 ^ b10 ^ b12 ^ b13);
		z[13] = (byte)(b ^ b4 ^ b7 ^ b8 ^ b9 ^ b11 ^ b14);
		z[14] = (byte)(b ^ b4 ^ b5 ^ b6 ^ b10 ^ b12 ^ b15);
		z[15] = (byte)(b2 ^ b3 ^ b5 ^ b6 ^ b9 ^ b11 ^ b16);
	}

	protected static void FE(byte[] D, byte[] RK)
	{
		Xor(D, RK);
		SL2(D);
		A(D);
	}

	protected static void FO(byte[] D, byte[] RK)
	{
		Xor(D, RK);
		SL1(D);
		A(D);
	}

	protected static byte[][] KeySchedule(bool forEncryption, byte[] K)
	{
		int num = K.Length;
		if (num >= 16 && num <= 32 && (num & 7) == 0)
		{
			int num2 = (num >> 3) - 2;
			byte[] rK = C[num2];
			byte[] rK2 = C[(num2 + 1) % 3];
			byte[] rK3 = C[(num2 + 2) % 3];
			byte[] array = new byte[16];
			byte[] array2 = new byte[16];
			Array.Copy(K, 0, array, 0, 16);
			Array.Copy(K, 16, array2, 0, num - 16);
			byte[] array3 = new byte[16];
			byte[] array4 = new byte[16];
			byte[] array5 = new byte[16];
			byte[] array6 = new byte[16];
			Array.Copy(array, 0, array3, 0, 16);
			Array.Copy(array3, 0, array4, 0, 16);
			FO(array4, rK);
			Xor(array4, array2);
			Array.Copy(array4, 0, array5, 0, 16);
			FE(array5, rK2);
			Xor(array5, array3);
			Array.Copy(array5, 0, array6, 0, 16);
			FO(array6, rK3);
			Xor(array6, array4);
			int num3 = 12 + num2 * 2;
			byte[][] array7 = new byte[num3 + 1][];
			array7[0] = KeyScheduleRound(array3, array4, 19);
			array7[1] = KeyScheduleRound(array4, array5, 19);
			array7[2] = KeyScheduleRound(array5, array6, 19);
			array7[3] = KeyScheduleRound(array6, array3, 19);
			array7[4] = KeyScheduleRound(array3, array4, 31);
			array7[5] = KeyScheduleRound(array4, array5, 31);
			array7[6] = KeyScheduleRound(array5, array6, 31);
			array7[7] = KeyScheduleRound(array6, array3, 31);
			array7[8] = KeyScheduleRound(array3, array4, 67);
			array7[9] = KeyScheduleRound(array4, array5, 67);
			array7[10] = KeyScheduleRound(array5, array6, 67);
			array7[11] = KeyScheduleRound(array6, array3, 67);
			array7[12] = KeyScheduleRound(array3, array4, 97);
			if (num3 > 12)
			{
				array7[13] = KeyScheduleRound(array4, array5, 97);
				array7[14] = KeyScheduleRound(array5, array6, 97);
				if (num3 > 14)
				{
					array7[15] = KeyScheduleRound(array6, array3, 97);
					array7[16] = KeyScheduleRound(array3, array4, 109);
				}
			}
			if (!forEncryption)
			{
				ReverseKeys(array7);
				for (int i = 1; i < num3; i++)
				{
					A(array7[i]);
				}
			}
			return array7;
		}
		throw new ArgumentException("Key length not 128/192/256 bits.");
	}

	protected static byte[] KeyScheduleRound(byte[] w, byte[] wr, int n)
	{
		byte[] array = new byte[16];
		int num = n >> 3;
		int num2 = n & 7;
		int num3 = 8 - num2;
		int num4 = wr[15 - num] & 0xFF;
		for (int i = 0; i < 16; i++)
		{
			int num5 = wr[(i - num) & 0xF] & 0xFF;
			int num6 = (num4 << num3) | (num5 >> num2);
			num6 ^= w[i] & 0xFF;
			array[i] = (byte)num6;
			num4 = num5;
		}
		return array;
	}

	protected static void ReverseKeys(byte[][] keys)
	{
		int num = keys.Length;
		int num2 = num / 2;
		int num3 = num - 1;
		for (int i = 0; i < num2; i++)
		{
			byte[] array = keys[i];
			keys[i] = keys[num3 - i];
			keys[num3 - i] = array;
		}
	}

	protected static byte SB1(byte x)
	{
		return SB1_sbox[x & 0xFF];
	}

	protected static byte SB2(byte x)
	{
		return SB2_sbox[x & 0xFF];
	}

	protected static byte SB3(byte x)
	{
		return SB3_sbox[x & 0xFF];
	}

	protected static byte SB4(byte x)
	{
		return SB4_sbox[x & 0xFF];
	}

	protected static void SL1(byte[] z)
	{
		z[0] = SB1(z[0]);
		z[1] = SB2(z[1]);
		z[2] = SB3(z[2]);
		z[3] = SB4(z[3]);
		z[4] = SB1(z[4]);
		z[5] = SB2(z[5]);
		z[6] = SB3(z[6]);
		z[7] = SB4(z[7]);
		z[8] = SB1(z[8]);
		z[9] = SB2(z[9]);
		z[10] = SB3(z[10]);
		z[11] = SB4(z[11]);
		z[12] = SB1(z[12]);
		z[13] = SB2(z[13]);
		z[14] = SB3(z[14]);
		z[15] = SB4(z[15]);
	}

	protected static void SL2(byte[] z)
	{
		z[0] = SB3(z[0]);
		z[1] = SB4(z[1]);
		z[2] = SB1(z[2]);
		z[3] = SB2(z[3]);
		z[4] = SB3(z[4]);
		z[5] = SB4(z[5]);
		z[6] = SB1(z[6]);
		z[7] = SB2(z[7]);
		z[8] = SB3(z[8]);
		z[9] = SB4(z[9]);
		z[10] = SB1(z[10]);
		z[11] = SB2(z[11]);
		z[12] = SB3(z[12]);
		z[13] = SB4(z[13]);
		z[14] = SB1(z[14]);
		z[15] = SB2(z[15]);
	}

	protected static void Xor(byte[] z, byte[] x)
	{
		for (int i = 0; i < 16; i++)
		{
			z[i] ^= x[i];
		}
	}
}
