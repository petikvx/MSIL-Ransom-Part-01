using System;
using System.IO;
using System.IO.Compression;

internal class UgAXVnPcxoAqkEgtzaxPwcokIeXqA
{
	public class vmVDbgfuljKuYzdeSJjOlfMsLASDA
	{
		public byte[] IQrEtRAmJyijGHkfXvLIjPvIuajab(byte[] input)
		{
			using MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(input, 0, input.Length);
			memoryStream.Position = 0L;
			MemoryStream memoryStream2 = new MemoryStream();
			using (GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress, leaveOpen: true))
			{
				for (int num = gZipStream.ReadByte(); num != -1; num = gZipStream.ReadByte())
				{
					memoryStream2.WriteByte((byte)num);
				}
				gZipStream.Close();
				memoryStream.Close();
			}
			byte[] result = memoryStream2.ToArray();
			memoryStream2.Close();
			return result;
		}

		public byte[] vJgFwuBYCuEiJAfxgfhpgvSfeGDkB(string s)
		{
			return Convert.FromBase64String(s);
		}

		public byte[] qbflSjyYJBSgVMUxjdcEEoHyoUdA(byte[] buffer)
		{
			byte[] array = new byte[256]
			{
				126, 137, 220, 120, 127, 75, 182, 79, 125, 13,
				8, 22, 124, 207, 98, 33, 121, 128, 116, 164,
				120, 66, 30, 147, 122, 4, 160, 202, 123, 198,
				202, 253, 108, 188, 46, 176, 109, 126, 68, 135,
				111, 56, 250, 222, 110, 250, 144, 233, 107, 181,
				134, 108, 106, 119, 236, 91, 104, 49, 82, 2,
				105, 243, 56, 53, 98, 175, 127, 8, 99, 109,
				21, 63, 97, 43, 171, 102, 96, 233, 193, 81,
				101, 166, 215, 212, 100, 100, 189, 227, 102, 34,
				3, 186, 103, 224, 105, 141, 72, 215, 203, 32,
				73, 21, 161, 23, 75, 83, 31, 78, 74, 145,
				117, 121, 79, 222, 99, 252, 78, 28, 9, 203,
				76, 90, 183, 146, 77, 152, 221, 165, 70, 196,
				154, 152, 71, 6, 240, 175, 69, 64, 78, 246,
				68, 130, 36, 193, 65, 205, 50, 68, 64, 15,
				88, 115, 66, 73, 230, 42, 67, 139, 140, 29,
				84, 241, 104, 80, 85, 51, 2, 103, 87, 117,
				188, 62, 86, 183, 214, 9, 83, 248, 192, 140,
				82, 58, 170, 187, 80, 124, 20, 226, 81, 190,
				126, 213, 90, 226, 57, 232, 91, 32, 83, 223,
				89, 102, 237, 134, 88, 164, 135, 177, 93, 235,
				145, 52, 92, 41, 251, 3, 94, 111, 69, 90,
				95, 173, 47, 109, 225, 53, 27, 128, 224, 247,
				113, 183, 226, 177, 207, 238, 227, 115, 165, 217,
				230, 60, 179, 92, 231, 254, 217, 107, 229, 184,
				103, 50, 228, 122, 13, 5
			};
			byte[] array2 = new byte[4];
			Array.Copy(buffer, array2, array2.Length);
			byte[] array3 = new byte[buffer.Length - 4];
			Array.Copy(buffer, 4, array3, 0, array3.Length);
			for (int i = 0; i < 256; i++)
			{
				byte[] array4 = array;
				int num = i;
				array4[num] ^= array2[i % 4];
			}
			for (int j = 0; j < array3.Length; j++)
			{
				byte[] array5 = array3;
				int num2 = j;
				array5[num2] ^= array[j % 256];
			}
			return array3;
		}
	}
}
