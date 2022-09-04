using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace ns0;

internal static class A4e0c51787b6649d7b1928e46c0a6eb29
{
	private static readonly object object_0 = new object();

	private static Dictionary<int, string> dictionary_0;

	internal static string A7c92b22c255042f5a66a5ce6c6957143(int Key, int Start, int Length)
	{
		lock (object_0)
		{
			int num = Key ^ 0x1F89F58A;
			if (dictionary_0 != null && dictionary_0.ContainsKey(num))
			{
				return dictionary_0[num];
			}
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			byte[] array;
			using (Stream stream = executingAssembly.GetManifestResourceStream(Acc91c720e49d4905b6ec47430ef942e3.A126f160f66ef4e6698557dae5b18e763(374465461, 766753562, 88002631)))
			{
				array = new byte[stream.Length];
				stream.Read(array, 0, Convert.ToInt32(stream.Length));
			}
			int num2 = Start;
			byte[] publicKeyToken = executingAssembly.GetName().GetPublicKeyToken();
			if (publicKeyToken != null && publicKeyToken.Length == 8)
			{
				int num3 = BitConverter.ToInt32(publicKeyToken, 0);
				int num4 = BitConverter.ToInt32(publicKeyToken, 4);
				num2 ^= num3 ^ num4;
			}
			else
			{
				num2 ^= 0xE494466;
			}
			int num5 = Length ^ 0x601FEB89;
			byte[] array2 = new byte[num5];
			int num6 = 0;
			for (int i = num2; i < num2 + num5; i++)
			{
				array2[num6++] = array[i];
			}
			byte[] array3 = new byte[num5];
			Random random = new Random(num);
			random.NextBytes(array3);
			for (int j = 0; j < num5; j++)
			{
				array2[j] ^= array3[j];
			}
			string @string = Encoding.Unicode.GetString(array2);
			if (dictionary_0 == null)
			{
				dictionary_0 = new Dictionary<int, string>();
			}
			dictionary_0.Add(num, @string);
			return @string;
		}
	}
}
