using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace ns0;

internal static class Aa2cb451f982a45b4abe9dcb0db238d21
{
	private static readonly object object_0 = new object();

	private static Dictionary<int, string> dictionary_0;

	internal static string Aa3a6041b8ad641809b428bd16f67c9df(int Key, int Start, int Length)
	{
		lock (object_0)
		{
			int num = Key ^ 0x12A39B6B;
			if (dictionary_0 != null && dictionary_0.ContainsKey(num))
			{
				return dictionary_0[num];
			}
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			byte[] array;
			using (Stream stream = executingAssembly.GetManifestResourceStream("77f074c2e43c4c0abb5254749270d6f0"))
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
				num2 ^= 0x65790003;
			}
			int num5 = Length ^ 0x31C76516;
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