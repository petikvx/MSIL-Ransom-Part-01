using System;

namespace AES_EnDecryptor.Basement;

public class AES
{
	public enum KeySize
	{
		Bits128,
		Bits192,
		Bits256
	}

	private int Nb;

	private int Nk;

	private int Nr;

	private byte[] key;

	private byte[,] Sbox;

	private byte[,] iSbox;

	private byte[,] w;

	private byte[,] Rcon;

	private byte[,] State;

	public AES(KeySize keySize, byte[] keyBytes)
	{
		SetNbNkNr(keySize);
		key = new byte[Nk * 4];
		keyBytes.CopyTo(key, 0);
		BuildSbox();
		BuildInvSbox();
		BuildRcon();
		KeyExpansion();
	}

	public void Cipher(byte[] input, byte[] output)
	{
		State = new byte[4, Nb];
		for (int i = 0; i < 4 * Nb; i++)
		{
			State[i % 4, i / 4] = input[i];
		}
		AddRoundKey(0);
		for (int j = 1; j <= Nr - 1; j++)
		{
			SubBytes();
			ShiftRows();
			MixColumns();
			AddRoundKey(j);
		}
		SubBytes();
		ShiftRows();
		AddRoundKey(Nr);
		for (int k = 0; k < 4 * Nb; k++)
		{
			output[k] = State[k % 4, k / 4];
		}
	}

	public void InvCipher(byte[] input, byte[] output)
	{
		State = new byte[4, Nb];
		for (int i = 0; i < 4 * Nb; i++)
		{
			State[i % 4, i / 4] = input[i];
		}
		AddRoundKey(Nr);
		for (int num = Nr - 1; num >= 1; num--)
		{
			InvShiftRows();
			InvSubBytes();
			AddRoundKey(num);
			InvMixColumns();
		}
		InvShiftRows();
		InvSubBytes();
		AddRoundKey(0);
		for (int j = 0; j < 4 * Nb; j++)
		{
			output[j] = State[j % 4, j / 4];
		}
	}

	private void SetNbNkNr(KeySize keySize)
	{
		Nb = 4;
		switch (keySize)
		{
		case KeySize.Bits128:
			Nk = 4;
			Nr = 10;
			break;
		case KeySize.Bits192:
			Nk = 6;
			Nr = 12;
			break;
		case KeySize.Bits256:
			Nk = 8;
			Nr = 14;
			break;
		}
	}

	private void BuildSbox()
	{
		Sbox = new byte[16, 16]
		{
			{
				99, 124, 119, 123, 242, 107, 111, 197, 48, 1,
				103, 43, 254, 215, 171, 118
			},
			{
				202, 130, 201, 125, 250, 89, 71, 240, 173, 212,
				162, 175, 156, 164, 114, 192
			},
			{
				183, 253, 147, 38, 54, 63, 247, 204, 52, 165,
				229, 241, 113, 216, 49, 21
			},
			{
				4, 199, 35, 195, 24, 150, 5, 154, 7, 18,
				128, 226, 235, 39, 178, 117
			},
			{
				9, 131, 44, 26, 27, 110, 90, 160, 82, 59,
				214, 179, 41, 227, 47, 132
			},
			{
				83, 209, 0, 237, 32, 252, 177, 91, 106, 203,
				190, 57, 74, 76, 88, 207
			},
			{
				208, 239, 170, 251, 67, 77, 51, 133, 69, 249,
				2, 127, 80, 60, 159, 168
			},
			{
				81, 163, 64, 143, 146, 157, 56, 245, 188, 182,
				218, 33, 16, 255, 243, 210
			},
			{
				205, 12, 19, 236, 95, 151, 68, 23, 196, 167,
				126, 61, 100, 93, 25, 115
			},
			{
				96, 129, 79, 220, 34, 42, 144, 136, 70, 238,
				184, 20, 222, 94, 11, 219
			},
			{
				224, 50, 58, 10, 73, 6, 36, 92, 194, 211,
				172, 98, 145, 149, 228, 121
			},
			{
				231, 200, 55, 109, 141, 213, 78, 169, 108, 86,
				244, 234, 101, 122, 174, 8
			},
			{
				186, 120, 37, 46, 28, 166, 180, 198, 232, 221,
				116, 31, 75, 189, 139, 138
			},
			{
				112, 62, 181, 102, 72, 3, 246, 14, 97, 53,
				87, 185, 134, 193, 29, 158
			},
			{
				225, 248, 152, 17, 105, 217, 142, 148, 155, 30,
				135, 233, 206, 85, 40, 223
			},
			{
				140, 161, 137, 13, 191, 230, 66, 104, 65, 153,
				45, 15, 176, 84, 187, 22
			}
		};
	}

	private void BuildInvSbox()
	{
		iSbox = new byte[16, 16]
		{
			{
				82, 9, 106, 213, 48, 54, 165, 56, 191, 64,
				163, 158, 129, 243, 215, 251
			},
			{
				124, 227, 57, 130, 155, 47, 255, 135, 52, 142,
				67, 68, 196, 222, 233, 203
			},
			{
				84, 123, 148, 50, 166, 194, 35, 61, 238, 76,
				149, 11, 66, 250, 195, 78
			},
			{
				8, 46, 161, 102, 40, 217, 36, 178, 118, 91,
				162, 73, 109, 139, 209, 37
			},
			{
				114, 248, 246, 100, 134, 104, 152, 22, 212, 164,
				92, 204, 93, 101, 182, 146
			},
			{
				108, 112, 72, 80, 253, 237, 185, 218, 94, 21,
				70, 87, 167, 141, 157, 132
			},
			{
				144, 216, 171, 0, 140, 188, 211, 10, 247, 228,
				88, 5, 184, 179, 69, 6
			},
			{
				208, 44, 30, 143, 202, 63, 15, 2, 193, 175,
				189, 3, 1, 19, 138, 107
			},
			{
				58, 145, 17, 65, 79, 103, 220, 234, 151, 242,
				207, 206, 240, 180, 230, 115
			},
			{
				150, 172, 116, 34, 231, 173, 53, 133, 226, 249,
				55, 232, 28, 117, 223, 110
			},
			{
				71, 241, 26, 113, 29, 41, 197, 137, 111, 183,
				98, 14, 170, 24, 190, 27
			},
			{
				252, 86, 62, 75, 198, 210, 121, 32, 154, 219,
				192, 254, 120, 205, 90, 244
			},
			{
				31, 221, 168, 51, 136, 7, 199, 49, 177, 18,
				16, 89, 39, 128, 236, 95
			},
			{
				96, 81, 127, 169, 25, 181, 74, 13, 45, 229,
				122, 159, 147, 201, 156, 239
			},
			{
				160, 224, 59, 77, 174, 42, 245, 176, 200, 235,
				187, 60, 131, 83, 153, 97
			},
			{
				23, 43, 4, 126, 186, 119, 214, 38, 225, 105,
				20, 99, 85, 33, 12, 125
			}
		};
	}

	private void BuildRcon()
	{
		Rcon = new byte[11, 4]
		{
			{ 0, 0, 0, 0 },
			{ 1, 0, 0, 0 },
			{ 2, 0, 0, 0 },
			{ 4, 0, 0, 0 },
			{ 8, 0, 0, 0 },
			{ 16, 0, 0, 0 },
			{ 32, 0, 0, 0 },
			{ 64, 0, 0, 0 },
			{ 128, 0, 0, 0 },
			{ 27, 0, 0, 0 },
			{ 54, 0, 0, 0 }
		};
	}

	private void AddRoundKey(int round)
	{
		for (int i = 0; i < 4; i++)
		{
			for (int j = 0; j < 4; j++)
			{
				State[i, j] = (byte)(State[i, j] ^ w[round * 4 + j, i]);
			}
		}
	}

	private void SubBytes()
	{
		for (int i = 0; i < 4; i++)
		{
			for (int j = 0; j < 4; j++)
			{
				State[i, j] = Sbox[State[i, j] >> 4, State[i, j] & 0xF];
			}
		}
	}

	private void InvSubBytes()
	{
		for (int i = 0; i < 4; i++)
		{
			for (int j = 0; j < 4; j++)
			{
				State[i, j] = iSbox[State[i, j] >> 4, State[i, j] & 0xF];
			}
		}
	}

	private void ShiftRows()
	{
		byte[,] array = new byte[4, 4];
		for (int i = 0; i < 4; i++)
		{
			for (int j = 0; j < 4; j++)
			{
				array[i, j] = State[i, j];
			}
		}
		for (int k = 1; k < 4; k++)
		{
			for (int l = 0; l < 4; l++)
			{
				State[k, l] = array[k, (l + k) % Nb];
			}
		}
	}

	private void InvShiftRows()
	{
		byte[,] array = new byte[4, 4];
		for (int i = 0; i < 4; i++)
		{
			for (int j = 0; j < 4; j++)
			{
				array[i, j] = State[i, j];
			}
		}
		for (int k = 1; k < 4; k++)
		{
			for (int l = 0; l < 4; l++)
			{
				State[k, (l + k) % Nb] = array[k, l];
			}
		}
	}

	private void MixColumns()
	{
		byte[,] array = new byte[4, 4];
		for (int i = 0; i < 4; i++)
		{
			for (int j = 0; j < 4; j++)
			{
				array[i, j] = State[i, j];
			}
		}
		for (int k = 0; k < 4; k++)
		{
			State[0, k] = (byte)(gfmultby02(array[0, k]) ^ gfmultby03(array[1, k]) ^ gfmultby01(array[2, k]) ^ gfmultby01(array[3, k]));
			State[1, k] = (byte)(gfmultby01(array[0, k]) ^ gfmultby02(array[1, k]) ^ gfmultby03(array[2, k]) ^ gfmultby01(array[3, k]));
			State[2, k] = (byte)(gfmultby01(array[0, k]) ^ gfmultby01(array[1, k]) ^ gfmultby02(array[2, k]) ^ gfmultby03(array[3, k]));
			State[3, k] = (byte)(gfmultby03(array[0, k]) ^ gfmultby01(array[1, k]) ^ gfmultby01(array[2, k]) ^ gfmultby02(array[3, k]));
		}
	}

	private void InvMixColumns()
	{
		byte[,] array = new byte[4, 4];
		for (int i = 0; i < 4; i++)
		{
			for (int j = 0; j < 4; j++)
			{
				array[i, j] = State[i, j];
			}
		}
		for (int k = 0; k < 4; k++)
		{
			State[0, k] = (byte)(gfmultby0e(array[0, k]) ^ gfmultby0b(array[1, k]) ^ gfmultby0d(array[2, k]) ^ gfmultby09(array[3, k]));
			State[1, k] = (byte)(gfmultby09(array[0, k]) ^ gfmultby0e(array[1, k]) ^ gfmultby0b(array[2, k]) ^ gfmultby0d(array[3, k]));
			State[2, k] = (byte)(gfmultby0d(array[0, k]) ^ gfmultby09(array[1, k]) ^ gfmultby0e(array[2, k]) ^ gfmultby0b(array[3, k]));
			State[3, k] = (byte)(gfmultby0b(array[0, k]) ^ gfmultby0d(array[1, k]) ^ gfmultby09(array[2, k]) ^ gfmultby0e(array[3, k]));
		}
	}

	private static byte gfmultby01(byte b)
	{
		return b;
	}

	private static byte gfmultby02(byte b)
	{
		if (b < 128)
		{
			return (byte)(b << 1);
		}
		return (byte)((uint)(b << 1) ^ 0x1Bu);
	}

	private static byte gfmultby03(byte b)
	{
		return (byte)(gfmultby02(b) ^ b);
	}

	private static byte gfmultby09(byte b)
	{
		return (byte)(gfmultby02(gfmultby02(gfmultby02(b))) ^ b);
	}

	private static byte gfmultby0b(byte b)
	{
		return (byte)(gfmultby02(gfmultby02(gfmultby02(b))) ^ gfmultby02(b) ^ b);
	}

	private static byte gfmultby0d(byte b)
	{
		return (byte)(gfmultby02(gfmultby02(gfmultby02(b))) ^ gfmultby02(gfmultby02(b)) ^ b);
	}

	private static byte gfmultby0e(byte b)
	{
		return (byte)(gfmultby02(gfmultby02(gfmultby02(b))) ^ gfmultby02(gfmultby02(b)) ^ gfmultby02(b));
	}

	private void KeyExpansion()
	{
		w = new byte[Nb * (Nr + 1), 4];
		for (int i = 0; i < Nk; i++)
		{
			w[i, 0] = key[4 * i];
			w[i, 1] = key[4 * i + 1];
			w[i, 2] = key[4 * i + 2];
			w[i, 3] = key[4 * i + 3];
		}
		byte[] array = new byte[4];
		for (int j = Nk; j < Nb * (Nr + 1); j++)
		{
			array[0] = w[j - 1, 0];
			array[1] = w[j - 1, 1];
			array[2] = w[j - 1, 2];
			array[3] = w[j - 1, 3];
			if (j % Nk == 0)
			{
				array = SubWord(RotWord(array));
				array[0] = (byte)(array[0] ^ Rcon[j / Nk, 0]);
				array[1] = (byte)(array[1] ^ Rcon[j / Nk, 1]);
				array[2] = (byte)(array[2] ^ Rcon[j / Nk, 2]);
				array[3] = (byte)(array[3] ^ Rcon[j / Nk, 3]);
			}
			else if (Nk > 6 && j % Nk == 4)
			{
				array = SubWord(array);
			}
			w[j, 0] = (byte)(w[j - Nk, 0] ^ array[0]);
			w[j, 1] = (byte)(w[j - Nk, 1] ^ array[1]);
			w[j, 2] = (byte)(w[j - Nk, 2] ^ array[2]);
			w[j, 3] = (byte)(w[j - Nk, 3] ^ array[3]);
		}
	}

	private byte[] SubWord(byte[] word)
	{
		return new byte[4]
		{
			Sbox[word[0] >> 4, word[0] & 0xF],
			Sbox[word[1] >> 4, word[1] & 0xF],
			Sbox[word[2] >> 4, word[2] & 0xF],
			Sbox[word[3] >> 4, word[3] & 0xF]
		};
	}

	private byte[] RotWord(byte[] word)
	{
		return new byte[4]
		{
			word[1],
			word[2],
			word[3],
			word[0]
		};
	}

	public void Dump()
	{
		Console.WriteLine("Nb = " + Nb + " Nk = " + Nk + " Nr = " + Nr);
		Console.WriteLine("\nThe key is \n" + DumpKey());
		Console.WriteLine("\nThe Sbox is \n" + DumpTwoByTwo(Sbox));
		Console.WriteLine("\nThe w array is \n" + DumpTwoByTwo(w));
		Console.WriteLine("\nThe State array is \n" + DumpTwoByTwo(State));
	}

	public string DumpKey()
	{
		string text = "";
		for (int i = 0; i < key.Length; i++)
		{
			text = text + key[i].ToString("x2") + " ";
		}
		return text;
	}

	public string DumpTwoByTwo(byte[,] a)
	{
		string text = "";
		for (int i = 0; i < a.GetLength(0); i++)
		{
			object obj = text;
			text = string.Concat(obj, "[", i, "] ");
			for (int j = 0; j < a.GetLength(1); j++)
			{
				text = text + a[i, j].ToString("x2") + " ";
			}
			text += "\n";
		}
		return text;
	}
}
