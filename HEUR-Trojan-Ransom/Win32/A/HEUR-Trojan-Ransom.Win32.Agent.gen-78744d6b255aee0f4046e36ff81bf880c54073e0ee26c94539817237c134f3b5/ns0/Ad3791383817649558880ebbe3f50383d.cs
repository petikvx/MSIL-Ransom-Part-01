using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace ns0;

internal static class Ad3791383817649558880ebbe3f50383d
{
	private static readonly object object_0 = new object();

	private static Dictionary<int, string> dictionary_0;

	internal static string A8050bc97ea514fa7bf6f85af1d02fec5(int Key, int Start, int Length)
	{
		lock (object_0)
		{
			int num = Key ^ 0x2389D6A9;
			if (dictionary_0 != null && dictionary_0.ContainsKey(num))
			{
				return dictionary_0[num];
			}
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			byte[] array;
			using (Stream stream = executingAssembly.GetManifestResourceStream(A412d8d70aac74f558a7cc9d22177cab0.A1192af10e7d241b08898432a18db9698(1751274039, 141233123, 791280854)))
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
				num2 ^= 0x6A26344E;
			}
			int num5 = Length ^ 0x1864A0A2;
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
