using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace ns1;

internal static class A08c4b310553a40fba2b2a371a43150f7
{
	private static readonly object object_0 = new object();

	private static Dictionary<int, string> dictionary_0;

	internal static string Af68086d6b267421d8f6268ce568cb469(int Key, int Start, int Length)
	{
		lock (object_0)
		{
			int num = Key ^ 0x3BAAEDC2;
			if (dictionary_0 != null && dictionary_0.ContainsKey(num))
			{
				return dictionary_0[num];
			}
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			byte[] array;
			using (Stream stream = executingAssembly.GetManifestResourceStream(A710c7e08d53a4b03b17c33108eb33691.A8b69a99745104dc4a39184840a9a72f7(1442983401, 1674726331, 126353213)))
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
				num2 ^= 0x3FE58899;
			}
			int num5 = Length ^ 0x633477E1;
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
