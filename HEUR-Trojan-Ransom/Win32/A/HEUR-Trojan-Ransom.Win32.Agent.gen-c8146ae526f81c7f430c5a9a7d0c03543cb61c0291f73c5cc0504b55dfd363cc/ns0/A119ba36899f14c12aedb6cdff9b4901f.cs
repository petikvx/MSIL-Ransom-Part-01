using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace ns0;

internal static class A119ba36899f14c12aedb6cdff9b4901f
{
	private static readonly object object_0 = new object();

	private static Dictionary<int, string> dictionary_0;

	internal static string Af5a2eb4e3a8140eda81414d2e545ed28(int Key, int Start, int Length)
	{
		lock (object_0)
		{
			int num = Key ^ 0x265D4DB0;
			if (dictionary_0 != null && dictionary_0.ContainsKey(num))
			{
				return dictionary_0[num];
			}
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			byte[] array;
			using (Stream stream = executingAssembly.GetManifestResourceStream(A73f1bce2869f4e2cb5dbcf51ace149af.A14026da185bb427fb07d9bfbb321f402(1513911265, 570608722, 867347050)))
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
				num2 ^= 0x1F85CCF5;
			}
			int num5 = Length ^ 0x49315038;
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
