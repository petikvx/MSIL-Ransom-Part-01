using System;

namespace Renci.SshNet.Security.Cryptography.Ciphers;

public sealed class SerpentCipher : BlockCipher
{
	private const int Rounds = 32;

	private const int Phi = -1640531527;

	private readonly int[] _workingKey;

	private int _x0;

	private int _x1;

	private int _x2;

	private int _x3;

	public SerpentCipher(byte[] key, CipherMode mode, CipherPadding padding)
		: base(key, 16, mode, padding)
	{
		int num = key.Length * 8;
		if (num != 128 && num != 192 && num != 256)
		{
			throw new ArgumentException($"KeySize '{num}' is not valid for this algorithm.");
		}
		_workingKey = MakeWorkingKey(key);
	}

	public override int EncryptBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
	{
		if (inputCount != base.BlockSize)
		{
			throw new ArgumentException("inputCount");
		}
		_x3 = BytesToWord(inputBuffer, inputOffset);
		_x2 = BytesToWord(inputBuffer, inputOffset + 4);
		_x1 = BytesToWord(inputBuffer, inputOffset + 8);
		_x0 = BytesToWord(inputBuffer, inputOffset + 12);
		Sb0(_workingKey[0] ^ _x0, _workingKey[1] ^ _x1, _workingKey[2] ^ _x2, _workingKey[3] ^ _x3);
		LT();
		Sb1(_workingKey[4] ^ _x0, _workingKey[5] ^ _x1, _workingKey[6] ^ _x2, _workingKey[7] ^ _x3);
		LT();
		Sb2(_workingKey[8] ^ _x0, _workingKey[9] ^ _x1, _workingKey[10] ^ _x2, _workingKey[11] ^ _x3);
		LT();
		Sb3(_workingKey[12] ^ _x0, _workingKey[13] ^ _x1, _workingKey[14] ^ _x2, _workingKey[15] ^ _x3);
		LT();
		Sb4(_workingKey[16] ^ _x0, _workingKey[17] ^ _x1, _workingKey[18] ^ _x2, _workingKey[19] ^ _x3);
		LT();
		Sb5(_workingKey[20] ^ _x0, _workingKey[21] ^ _x1, _workingKey[22] ^ _x2, _workingKey[23] ^ _x3);
		LT();
		Sb6(_workingKey[24] ^ _x0, _workingKey[25] ^ _x1, _workingKey[26] ^ _x2, _workingKey[27] ^ _x3);
		LT();
		Sb7(_workingKey[28] ^ _x0, _workingKey[29] ^ _x1, _workingKey[30] ^ _x2, _workingKey[31] ^ _x3);
		LT();
		Sb0(_workingKey[32] ^ _x0, _workingKey[33] ^ _x1, _workingKey[34] ^ _x2, _workingKey[35] ^ _x3);
		LT();
		Sb1(_workingKey[36] ^ _x0, _workingKey[37] ^ _x1, _workingKey[38] ^ _x2, _workingKey[39] ^ _x3);
		LT();
		Sb2(_workingKey[40] ^ _x0, _workingKey[41] ^ _x1, _workingKey[42] ^ _x2, _workingKey[43] ^ _x3);
		LT();
		Sb3(_workingKey[44] ^ _x0, _workingKey[45] ^ _x1, _workingKey[46] ^ _x2, _workingKey[47] ^ _x3);
		LT();
		Sb4(_workingKey[48] ^ _x0, _workingKey[49] ^ _x1, _workingKey[50] ^ _x2, _workingKey[51] ^ _x3);
		LT();
		Sb5(_workingKey[52] ^ _x0, _workingKey[53] ^ _x1, _workingKey[54] ^ _x2, _workingKey[55] ^ _x3);
		LT();
		Sb6(_workingKey[56] ^ _x0, _workingKey[57] ^ _x1, _workingKey[58] ^ _x2, _workingKey[59] ^ _x3);
		LT();
		Sb7(_workingKey[60] ^ _x0, _workingKey[61] ^ _x1, _workingKey[62] ^ _x2, _workingKey[63] ^ _x3);
		LT();
		Sb0(_workingKey[64] ^ _x0, _workingKey[65] ^ _x1, _workingKey[66] ^ _x2, _workingKey[67] ^ _x3);
		LT();
		Sb1(_workingKey[68] ^ _x0, _workingKey[69] ^ _x1, _workingKey[70] ^ _x2, _workingKey[71] ^ _x3);
		LT();
		Sb2(_workingKey[72] ^ _x0, _workingKey[73] ^ _x1, _workingKey[74] ^ _x2, _workingKey[75] ^ _x3);
		LT();
		Sb3(_workingKey[76] ^ _x0, _workingKey[77] ^ _x1, _workingKey[78] ^ _x2, _workingKey[79] ^ _x3);
		LT();
		Sb4(_workingKey[80] ^ _x0, _workingKey[81] ^ _x1, _workingKey[82] ^ _x2, _workingKey[83] ^ _x3);
		LT();
		Sb5(_workingKey[84] ^ _x0, _workingKey[85] ^ _x1, _workingKey[86] ^ _x2, _workingKey[87] ^ _x3);
		LT();
		Sb6(_workingKey[88] ^ _x0, _workingKey[89] ^ _x1, _workingKey[90] ^ _x2, _workingKey[91] ^ _x3);
		LT();
		Sb7(_workingKey[92] ^ _x0, _workingKey[93] ^ _x1, _workingKey[94] ^ _x2, _workingKey[95] ^ _x3);
		LT();
		Sb0(_workingKey[96] ^ _x0, _workingKey[97] ^ _x1, _workingKey[98] ^ _x2, _workingKey[99] ^ _x3);
		LT();
		Sb1(_workingKey[100] ^ _x0, _workingKey[101] ^ _x1, _workingKey[102] ^ _x2, _workingKey[103] ^ _x3);
		LT();
		Sb2(_workingKey[104] ^ _x0, _workingKey[105] ^ _x1, _workingKey[106] ^ _x2, _workingKey[107] ^ _x3);
		LT();
		Sb3(_workingKey[108] ^ _x0, _workingKey[109] ^ _x1, _workingKey[110] ^ _x2, _workingKey[111] ^ _x3);
		LT();
		Sb4(_workingKey[112] ^ _x0, _workingKey[113] ^ _x1, _workingKey[114] ^ _x2, _workingKey[115] ^ _x3);
		LT();
		Sb5(_workingKey[116] ^ _x0, _workingKey[117] ^ _x1, _workingKey[118] ^ _x2, _workingKey[119] ^ _x3);
		LT();
		Sb6(_workingKey[120] ^ _x0, _workingKey[121] ^ _x1, _workingKey[122] ^ _x2, _workingKey[123] ^ _x3);
		LT();
		Sb7(_workingKey[124] ^ _x0, _workingKey[125] ^ _x1, _workingKey[126] ^ _x2, _workingKey[127] ^ _x3);
		WordToBytes(_workingKey[131] ^ _x3, outputBuffer, outputOffset);
		WordToBytes(_workingKey[130] ^ _x2, outputBuffer, outputOffset + 4);
		WordToBytes(_workingKey[129] ^ _x1, outputBuffer, outputOffset + 8);
		WordToBytes(_workingKey[128] ^ _x0, outputBuffer, outputOffset + 12);
		return base.BlockSize;
	}

	public override int DecryptBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
	{
		if (inputCount != base.BlockSize)
		{
			throw new ArgumentException("inputCount");
		}
		_x3 = _workingKey[131] ^ BytesToWord(inputBuffer, inputOffset);
		_x2 = _workingKey[130] ^ BytesToWord(inputBuffer, inputOffset + 4);
		_x1 = _workingKey[129] ^ BytesToWord(inputBuffer, inputOffset + 8);
		_x0 = _workingKey[128] ^ BytesToWord(inputBuffer, inputOffset + 12);
		Ib7(_x0, _x1, _x2, _x3);
		_x0 ^= _workingKey[124];
		_x1 ^= _workingKey[125];
		_x2 ^= _workingKey[126];
		_x3 ^= _workingKey[127];
		InverseLT();
		Ib6(_x0, _x1, _x2, _x3);
		_x0 ^= _workingKey[120];
		_x1 ^= _workingKey[121];
		_x2 ^= _workingKey[122];
		_x3 ^= _workingKey[123];
		InverseLT();
		Ib5(_x0, _x1, _x2, _x3);
		_x0 ^= _workingKey[116];
		_x1 ^= _workingKey[117];
		_x2 ^= _workingKey[118];
		_x3 ^= _workingKey[119];
		InverseLT();
		Ib4(_x0, _x1, _x2, _x3);
		_x0 ^= _workingKey[112];
		_x1 ^= _workingKey[113];
		_x2 ^= _workingKey[114];
		_x3 ^= _workingKey[115];
		InverseLT();
		Ib3(_x0, _x1, _x2, _x3);
		_x0 ^= _workingKey[108];
		_x1 ^= _workingKey[109];
		_x2 ^= _workingKey[110];
		_x3 ^= _workingKey[111];
		InverseLT();
		Ib2(_x0, _x1, _x2, _x3);
		_x0 ^= _workingKey[104];
		_x1 ^= _workingKey[105];
		_x2 ^= _workingKey[106];
		_x3 ^= _workingKey[107];
		InverseLT();
		Ib1(_x0, _x1, _x2, _x3);
		_x0 ^= _workingKey[100];
		_x1 ^= _workingKey[101];
		_x2 ^= _workingKey[102];
		_x3 ^= _workingKey[103];
		InverseLT();
		Ib0(_x0, _x1, _x2, _x3);
		_x0 ^= _workingKey[96];
		_x1 ^= _workingKey[97];
		_x2 ^= _workingKey[98];
		_x3 ^= _workingKey[99];
		InverseLT();
		Ib7(_x0, _x1, _x2, _x3);
		_x0 ^= _workingKey[92];
		_x1 ^= _workingKey[93];
		_x2 ^= _workingKey[94];
		_x3 ^= _workingKey[95];
		InverseLT();
		Ib6(_x0, _x1, _x2, _x3);
		_x0 ^= _workingKey[88];
		_x1 ^= _workingKey[89];
		_x2 ^= _workingKey[90];
		_x3 ^= _workingKey[91];
		InverseLT();
		Ib5(_x0, _x1, _x2, _x3);
		_x0 ^= _workingKey[84];
		_x1 ^= _workingKey[85];
		_x2 ^= _workingKey[86];
		_x3 ^= _workingKey[87];
		InverseLT();
		Ib4(_x0, _x1, _x2, _x3);
		_x0 ^= _workingKey[80];
		_x1 ^= _workingKey[81];
		_x2 ^= _workingKey[82];
		_x3 ^= _workingKey[83];
		InverseLT();
		Ib3(_x0, _x1, _x2, _x3);
		_x0 ^= _workingKey[76];
		_x1 ^= _workingKey[77];
		_x2 ^= _workingKey[78];
		_x3 ^= _workingKey[79];
		InverseLT();
		Ib2(_x0, _x1, _x2, _x3);
		_x0 ^= _workingKey[72];
		_x1 ^= _workingKey[73];
		_x2 ^= _workingKey[74];
		_x3 ^= _workingKey[75];
		InverseLT();
		Ib1(_x0, _x1, _x2, _x3);
		_x0 ^= _workingKey[68];
		_x1 ^= _workingKey[69];
		_x2 ^= _workingKey[70];
		_x3 ^= _workingKey[71];
		InverseLT();
		Ib0(_x0, _x1, _x2, _x3);
		_x0 ^= _workingKey[64];
		_x1 ^= _workingKey[65];
		_x2 ^= _workingKey[66];
		_x3 ^= _workingKey[67];
		InverseLT();
		Ib7(_x0, _x1, _x2, _x3);
		_x0 ^= _workingKey[60];
		_x1 ^= _workingKey[61];
		_x2 ^= _workingKey[62];
		_x3 ^= _workingKey[63];
		InverseLT();
		Ib6(_x0, _x1, _x2, _x3);
		_x0 ^= _workingKey[56];
		_x1 ^= _workingKey[57];
		_x2 ^= _workingKey[58];
		_x3 ^= _workingKey[59];
		InverseLT();
		Ib5(_x0, _x1, _x2, _x3);
		_x0 ^= _workingKey[52];
		_x1 ^= _workingKey[53];
		_x2 ^= _workingKey[54];
		_x3 ^= _workingKey[55];
		InverseLT();
		Ib4(_x0, _x1, _x2, _x3);
		_x0 ^= _workingKey[48];
		_x1 ^= _workingKey[49];
		_x2 ^= _workingKey[50];
		_x3 ^= _workingKey[51];
		InverseLT();
		Ib3(_x0, _x1, _x2, _x3);
		_x0 ^= _workingKey[44];
		_x1 ^= _workingKey[45];
		_x2 ^= _workingKey[46];
		_x3 ^= _workingKey[47];
		InverseLT();
		Ib2(_x0, _x1, _x2, _x3);
		_x0 ^= _workingKey[40];
		_x1 ^= _workingKey[41];
		_x2 ^= _workingKey[42];
		_x3 ^= _workingKey[43];
		InverseLT();
		Ib1(_x0, _x1, _x2, _x3);
		_x0 ^= _workingKey[36];
		_x1 ^= _workingKey[37];
		_x2 ^= _workingKey[38];
		_x3 ^= _workingKey[39];
		InverseLT();
		Ib0(_x0, _x1, _x2, _x3);
		_x0 ^= _workingKey[32];
		_x1 ^= _workingKey[33];
		_x2 ^= _workingKey[34];
		_x3 ^= _workingKey[35];
		InverseLT();
		Ib7(_x0, _x1, _x2, _x3);
		_x0 ^= _workingKey[28];
		_x1 ^= _workingKey[29];
		_x2 ^= _workingKey[30];
		_x3 ^= _workingKey[31];
		InverseLT();
		Ib6(_x0, _x1, _x2, _x3);
		_x0 ^= _workingKey[24];
		_x1 ^= _workingKey[25];
		_x2 ^= _workingKey[26];
		_x3 ^= _workingKey[27];
		InverseLT();
		Ib5(_x0, _x1, _x2, _x3);
		_x0 ^= _workingKey[20];
		_x1 ^= _workingKey[21];
		_x2 ^= _workingKey[22];
		_x3 ^= _workingKey[23];
		InverseLT();
		Ib4(_x0, _x1, _x2, _x3);
		_x0 ^= _workingKey[16];
		_x1 ^= _workingKey[17];
		_x2 ^= _workingKey[18];
		_x3 ^= _workingKey[19];
		InverseLT();
		Ib3(_x0, _x1, _x2, _x3);
		_x0 ^= _workingKey[12];
		_x1 ^= _workingKey[13];
		_x2 ^= _workingKey[14];
		_x3 ^= _workingKey[15];
		InverseLT();
		Ib2(_x0, _x1, _x2, _x3);
		_x0 ^= _workingKey[8];
		_x1 ^= _workingKey[9];
		_x2 ^= _workingKey[10];
		_x3 ^= _workingKey[11];
		InverseLT();
		Ib1(_x0, _x1, _x2, _x3);
		_x0 ^= _workingKey[4];
		_x1 ^= _workingKey[5];
		_x2 ^= _workingKey[6];
		_x3 ^= _workingKey[7];
		InverseLT();
		Ib0(_x0, _x1, _x2, _x3);
		WordToBytes(_x3 ^ _workingKey[3], outputBuffer, outputOffset);
		WordToBytes(_x2 ^ _workingKey[2], outputBuffer, outputOffset + 4);
		WordToBytes(_x1 ^ _workingKey[1], outputBuffer, outputOffset + 8);
		WordToBytes(_x0 ^ _workingKey[0], outputBuffer, outputOffset + 12);
		return base.BlockSize;
	}

	private int[] MakeWorkingKey(byte[] key)
	{
		int[] array = new int[16];
		int num = 0;
		int num2;
		for (num2 = key.Length - 4; num2 > 0; num2 -= 4)
		{
			array[num++] = BytesToWord(key, num2);
		}
		if (num2 == 0)
		{
			array[num++] = BytesToWord(key, 0);
			if (num < 8)
			{
				array[num] = 1;
			}
			int[] array2 = new int[132];
			for (int i = 8; i < 16; i++)
			{
				array[i] = RotateLeft(array[i - 8] ^ array[i - 5] ^ array[i - 3] ^ array[i - 1] ^ -1640531527 ^ (i - 8), 11);
			}
			Buffer.BlockCopy(array, 8, array2, 0, 8);
			for (int j = 8; j < 132; j++)
			{
				array2[j] = RotateLeft(array2[j - 8] ^ array2[j - 5] ^ array2[j - 3] ^ array2[j - 1] ^ -1640531527 ^ j, 11);
			}
			Sb3(array2[0], array2[1], array2[2], array2[3]);
			array2[0] = _x0;
			array2[1] = _x1;
			array2[2] = _x2;
			array2[3] = _x3;
			Sb2(array2[4], array2[5], array2[6], array2[7]);
			array2[4] = _x0;
			array2[5] = _x1;
			array2[6] = _x2;
			array2[7] = _x3;
			Sb1(array2[8], array2[9], array2[10], array2[11]);
			array2[8] = _x0;
			array2[9] = _x1;
			array2[10] = _x2;
			array2[11] = _x3;
			Sb0(array2[12], array2[13], array2[14], array2[15]);
			array2[12] = _x0;
			array2[13] = _x1;
			array2[14] = _x2;
			array2[15] = _x3;
			Sb7(array2[16], array2[17], array2[18], array2[19]);
			array2[16] = _x0;
			array2[17] = _x1;
			array2[18] = _x2;
			array2[19] = _x3;
			Sb6(array2[20], array2[21], array2[22], array2[23]);
			array2[20] = _x0;
			array2[21] = _x1;
			array2[22] = _x2;
			array2[23] = _x3;
			Sb5(array2[24], array2[25], array2[26], array2[27]);
			array2[24] = _x0;
			array2[25] = _x1;
			array2[26] = _x2;
			array2[27] = _x3;
			Sb4(array2[28], array2[29], array2[30], array2[31]);
			array2[28] = _x0;
			array2[29] = _x1;
			array2[30] = _x2;
			array2[31] = _x3;
			Sb3(array2[32], array2[33], array2[34], array2[35]);
			array2[32] = _x0;
			array2[33] = _x1;
			array2[34] = _x2;
			array2[35] = _x3;
			Sb2(array2[36], array2[37], array2[38], array2[39]);
			array2[36] = _x0;
			array2[37] = _x1;
			array2[38] = _x2;
			array2[39] = _x3;
			Sb1(array2[40], array2[41], array2[42], array2[43]);
			array2[40] = _x0;
			array2[41] = _x1;
			array2[42] = _x2;
			array2[43] = _x3;
			Sb0(array2[44], array2[45], array2[46], array2[47]);
			array2[44] = _x0;
			array2[45] = _x1;
			array2[46] = _x2;
			array2[47] = _x3;
			Sb7(array2[48], array2[49], array2[50], array2[51]);
			array2[48] = _x0;
			array2[49] = _x1;
			array2[50] = _x2;
			array2[51] = _x3;
			Sb6(array2[52], array2[53], array2[54], array2[55]);
			array2[52] = _x0;
			array2[53] = _x1;
			array2[54] = _x2;
			array2[55] = _x3;
			Sb5(array2[56], array2[57], array2[58], array2[59]);
			array2[56] = _x0;
			array2[57] = _x1;
			array2[58] = _x2;
			array2[59] = _x3;
			Sb4(array2[60], array2[61], array2[62], array2[63]);
			array2[60] = _x0;
			array2[61] = _x1;
			array2[62] = _x2;
			array2[63] = _x3;
			Sb3(array2[64], array2[65], array2[66], array2[67]);
			array2[64] = _x0;
			array2[65] = _x1;
			array2[66] = _x2;
			array2[67] = _x3;
			Sb2(array2[68], array2[69], array2[70], array2[71]);
			array2[68] = _x0;
			array2[69] = _x1;
			array2[70] = _x2;
			array2[71] = _x3;
			Sb1(array2[72], array2[73], array2[74], array2[75]);
			array2[72] = _x0;
			array2[73] = _x1;
			array2[74] = _x2;
			array2[75] = _x3;
			Sb0(array2[76], array2[77], array2[78], array2[79]);
			array2[76] = _x0;
			array2[77] = _x1;
			array2[78] = _x2;
			array2[79] = _x3;
			Sb7(array2[80], array2[81], array2[82], array2[83]);
			array2[80] = _x0;
			array2[81] = _x1;
			array2[82] = _x2;
			array2[83] = _x3;
			Sb6(array2[84], array2[85], array2[86], array2[87]);
			array2[84] = _x0;
			array2[85] = _x1;
			array2[86] = _x2;
			array2[87] = _x3;
			Sb5(array2[88], array2[89], array2[90], array2[91]);
			array2[88] = _x0;
			array2[89] = _x1;
			array2[90] = _x2;
			array2[91] = _x3;
			Sb4(array2[92], array2[93], array2[94], array2[95]);
			array2[92] = _x0;
			array2[93] = _x1;
			array2[94] = _x2;
			array2[95] = _x3;
			Sb3(array2[96], array2[97], array2[98], array2[99]);
			array2[96] = _x0;
			array2[97] = _x1;
			array2[98] = _x2;
			array2[99] = _x3;
			Sb2(array2[100], array2[101], array2[102], array2[103]);
			array2[100] = _x0;
			array2[101] = _x1;
			array2[102] = _x2;
			array2[103] = _x3;
			Sb1(array2[104], array2[105], array2[106], array2[107]);
			array2[104] = _x0;
			array2[105] = _x1;
			array2[106] = _x2;
			array2[107] = _x3;
			Sb0(array2[108], array2[109], array2[110], array2[111]);
			array2[108] = _x0;
			array2[109] = _x1;
			array2[110] = _x2;
			array2[111] = _x3;
			Sb7(array2[112], array2[113], array2[114], array2[115]);
			array2[112] = _x0;
			array2[113] = _x1;
			array2[114] = _x2;
			array2[115] = _x3;
			Sb6(array2[116], array2[117], array2[118], array2[119]);
			array2[116] = _x0;
			array2[117] = _x1;
			array2[118] = _x2;
			array2[119] = _x3;
			Sb5(array2[120], array2[121], array2[122], array2[123]);
			array2[120] = _x0;
			array2[121] = _x1;
			array2[122] = _x2;
			array2[123] = _x3;
			Sb4(array2[124], array2[125], array2[126], array2[127]);
			array2[124] = _x0;
			array2[125] = _x1;
			array2[126] = _x2;
			array2[127] = _x3;
			Sb3(array2[128], array2[129], array2[130], array2[131]);
			array2[128] = _x0;
			array2[129] = _x1;
			array2[130] = _x2;
			array2[131] = _x3;
			return array2;
		}
		throw new ArgumentException("key must be a multiple of 4 bytes");
	}

	private static int RotateLeft(int x, int bits)
	{
		return (x << bits) | (int)((uint)x >> 32 - bits);
	}

	private static int RotateRight(int x, int bits)
	{
		return (int)((uint)x >> bits) | (x << 32 - bits);
	}

	private static int BytesToWord(byte[] src, int srcOff)
	{
		return ((src[srcOff] & 0xFF) << 24) | ((src[srcOff + 1] & 0xFF) << 16) | ((src[srcOff + 2] & 0xFF) << 8) | (src[srcOff + 3] & 0xFF);
	}

	private static void WordToBytes(int word, byte[] dst, int dstOff)
	{
		dst[dstOff + 3] = (byte)word;
		dst[dstOff + 2] = (byte)((uint)word >> 8);
		dst[dstOff + 1] = (byte)((uint)word >> 16);
		dst[dstOff] = (byte)((uint)word >> 24);
	}

	private void Sb0(int a, int b, int c, int d)
	{
		int num = a ^ d;
		int num2 = c ^ num;
		int num3 = b ^ num2;
		_x3 = (a & d) ^ num3;
		int num4 = a ^ (b & num);
		_x2 = num3 ^ (c | num4);
		int num5 = _x3 & (num2 ^ num4);
		_x1 = ~num2 ^ num5;
		_x0 = num5 ^ ~num4;
	}

	private void Ib0(int a, int b, int c, int d)
	{
		int num = ~a;
		int num2 = a ^ b;
		int num3 = d ^ (num | num2);
		int num4 = c ^ num3;
		_x2 = num2 ^ num4;
		int num5 = num ^ (d & num2);
		_x1 = num3 ^ (_x2 & num5);
		_x3 = (a & num3) ^ (num4 | _x1);
		_x0 = _x3 ^ (num4 ^ num5);
	}

	private void Sb1(int a, int b, int c, int d)
	{
		int num = b ^ ~a;
		int num2 = c ^ (a | num);
		_x2 = d ^ num2;
		int num3 = b ^ (d | num);
		int num4 = num ^ _x2;
		_x3 = num4 ^ (num2 & num3);
		int num5 = num2 ^ num3;
		_x1 = _x3 ^ num5;
		_x0 = num2 ^ (num4 & num5);
	}

	private void Ib1(int a, int b, int c, int d)
	{
		int num = b ^ d;
		int num2 = a ^ (b & num);
		int num3 = num ^ num2;
		_x3 = c ^ num3;
		int num4 = b ^ (num & num2);
		int num5 = _x3 | num4;
		_x1 = num2 ^ num5;
		int num6 = ~_x1;
		int num7 = _x3 ^ num4;
		_x0 = num6 ^ num7;
		_x2 = num3 ^ (num6 | num7);
	}

	private void Sb2(int a, int b, int c, int d)
	{
		int num = ~a;
		int num2 = b ^ d;
		int num3 = c & num;
		_x0 = num2 ^ num3;
		int num4 = c ^ num;
		int num5 = c ^ _x0;
		int num6 = b & num5;
		_x3 = num4 ^ num6;
		_x2 = a ^ ((d | num6) & (_x0 | num4));
		_x1 = num2 ^ _x3 ^ (_x2 ^ (d | num));
	}

	private void Ib2(int a, int b, int c, int d)
	{
		int num = b ^ d;
		int num2 = ~num;
		int num3 = a ^ c;
		int num4 = c ^ num;
		int num5 = b & num4;
		_x0 = num3 ^ num5;
		int num6 = a | num2;
		int num7 = d ^ num6;
		int num8 = num3 | num7;
		_x3 = num ^ num8;
		int num9 = ~num4;
		int num10 = _x0 | _x3;
		_x1 = num9 ^ num10;
		_x2 = (d & num9) ^ (num3 ^ num10);
	}

	private void Sb3(int a, int b, int c, int d)
	{
		int num = a ^ b;
		int num2 = a & c;
		int num3 = a | d;
		int num4 = c ^ d;
		int num5 = num & num3;
		int num6 = num2 | num5;
		_x2 = num4 ^ num6;
		int num7 = b ^ num3;
		int num8 = num6 ^ num7;
		int num9 = num4 & num8;
		_x0 = num ^ num9;
		int num10 = _x2 & _x0;
		_x1 = num8 ^ num10;
		_x3 = (b | d) ^ (num4 ^ num10);
	}

	private void Ib3(int a, int b, int c, int d)
	{
		int num = a | b;
		int num2 = b ^ c;
		int num3 = b & num2;
		int num4 = a ^ num3;
		int num5 = c ^ num4;
		int num6 = d | num4;
		_x0 = num2 ^ num6;
		int num7 = num2 | num6;
		int num8 = d ^ num7;
		_x2 = num5 ^ num8;
		int num9 = num ^ num8;
		int num10 = _x0 & num9;
		_x3 = num4 ^ num10;
		_x1 = _x3 ^ (_x0 ^ num9);
	}

	private void Sb4(int a, int b, int c, int d)
	{
		int num = a ^ d;
		int num2 = d & num;
		int num3 = c ^ num2;
		int num4 = b | num3;
		_x3 = num ^ num4;
		int num5 = ~b;
		int num6 = num | num5;
		_x0 = num3 ^ num6;
		int num7 = a & _x0;
		int num8 = num ^ num5;
		int num9 = num4 & num8;
		_x2 = num7 ^ num9;
		_x1 = a ^ num3 ^ (num8 & _x2);
	}

	private void Ib4(int a, int b, int c, int d)
	{
		int num = c | d;
		int num2 = a & num;
		int num3 = b ^ num2;
		int num4 = a & num3;
		int num5 = c ^ num4;
		_x1 = d ^ num5;
		int num6 = ~a;
		int num7 = num5 & _x1;
		_x3 = num3 ^ num7;
		int num8 = _x1 | num6;
		int num9 = d ^ num8;
		_x0 = _x3 ^ num9;
		_x2 = (num3 & num9) ^ (_x1 ^ num6);
	}

	private void Sb5(int a, int b, int c, int d)
	{
		int num = ~a;
		int num2 = a ^ b;
		int num3 = a ^ d;
		int num4 = c ^ num;
		int num5 = num2 | num3;
		_x0 = num4 ^ num5;
		int num6 = d & _x0;
		int num7 = num2 ^ _x0;
		_x1 = num6 ^ num7;
		int num8 = num | _x0;
		int num9 = num2 | num6;
		int num10 = num3 ^ num8;
		_x2 = num9 ^ num10;
		_x3 = b ^ num6 ^ (_x1 & num10);
	}

	private void Ib5(int a, int b, int c, int d)
	{
		int num = ~c;
		int num2 = b & num;
		int num3 = d ^ num2;
		int num4 = a & num3;
		int num5 = b ^ num;
		_x3 = num4 ^ num5;
		int num6 = b | _x3;
		int num7 = a & num6;
		_x1 = num3 ^ num7;
		int num8 = a | d;
		int num9 = num ^ num6;
		_x0 = num8 ^ num9;
		_x2 = (b & num8) ^ (num4 | (a ^ c));
	}

	private void Sb6(int a, int b, int c, int d)
	{
		int num = ~a;
		int num2 = a ^ d;
		int num3 = b ^ num2;
		int num4 = num | num2;
		int num5 = c ^ num4;
		_x1 = b ^ num5;
		int num6 = num2 | _x1;
		int num7 = d ^ num6;
		int num8 = num5 & num7;
		_x2 = num3 ^ num8;
		int num9 = num5 ^ num7;
		_x0 = _x2 ^ num9;
		_x3 = ~num5 ^ (num3 & num9);
	}

	private void Ib6(int a, int b, int c, int d)
	{
		int num = ~a;
		int num2 = a ^ b;
		int num3 = c ^ num2;
		int num4 = c | num;
		int num5 = d ^ num4;
		_x1 = num3 ^ num5;
		int num6 = num3 & num5;
		int num7 = num2 ^ num6;
		int num8 = b | num7;
		_x3 = num5 ^ num8;
		int num9 = b | _x3;
		_x0 = num7 ^ num9;
		_x2 = (d & num) ^ (num3 ^ num9);
	}

	private void Sb7(int a, int b, int c, int d)
	{
		int num = b ^ c;
		int num2 = c & num;
		int num3 = d ^ num2;
		int num4 = a ^ num3;
		int num5 = d | num;
		int num6 = num4 & num5;
		_x1 = b ^ num6;
		int num7 = num3 | _x1;
		int num8 = a & num4;
		_x3 = num ^ num8;
		int num9 = num4 ^ num7;
		int num10 = _x3 & num9;
		_x2 = num3 ^ num10;
		_x0 = ~num9 ^ (_x3 & _x2);
	}

	private void Ib7(int a, int b, int c, int d)
	{
		int num = c | (a & b);
		int num2 = d & (a | b);
		_x3 = num ^ num2;
		int num3 = ~d;
		int num4 = b ^ num2;
		int num5 = num4 | (_x3 ^ num3);
		_x1 = a ^ num5;
		_x0 = c ^ num4 ^ (d | _x1);
		_x2 = num ^ _x1 ^ (_x0 ^ (a & _x3));
	}

	private void LT()
	{
		int num = RotateLeft(_x0, 13);
		int num2 = RotateLeft(_x2, 3);
		int x = _x1 ^ num ^ num2;
		int x2 = _x3 ^ num2 ^ (num << 3);
		_x1 = RotateLeft(x, 1);
		_x3 = RotateLeft(x2, 7);
		_x0 = RotateLeft(num ^ _x1 ^ _x3, 5);
		_x2 = RotateLeft(num2 ^ _x3 ^ (_x1 << 7), 22);
	}

	private void InverseLT()
	{
		int num = RotateRight(_x2, 22) ^ _x3 ^ (_x1 << 7);
		int num2 = RotateRight(_x0, 5) ^ _x1 ^ _x3;
		int num3 = RotateRight(_x3, 7);
		int num4 = RotateRight(_x1, 1);
		_x3 = num3 ^ num ^ (num2 << 3);
		_x1 = num4 ^ num2 ^ num;
		_x2 = RotateRight(num, 3);
		_x0 = RotateRight(num2, 13);
	}
}
