using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace ns0;

internal static class Class43
{
	private static readonly object object_0 = new object();

	private static Dictionary<int, string> dictionary_0;

	internal static string smethod_0(int int_0, int int_1, int int_2)
	{
		lock (object_0)
		{
			int num = int_0 ^ 0x6CB24A06;
			if (dictionary_0 == null || !dictionary_0.ContainsKey(num))
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				byte[] array;
				using (Stream stream = executingAssembly.GetManifestResourceStream(GClass0.smethod_0("FŻɼ\u032dЮԨةݽ\u087cध\u0a70ତఠ൵ฤ༤\u1071ᄶሷጸᐹᕩᘺ\u173aᠽ\u1932ᨵ\u1b35ᱡᴷḲἰ")))
				{
					array = new byte[stream.Length];
					stream.Read(array, 0, Convert.ToInt32(stream.Length));
				}
				int num2 = int_1;
				byte[] publicKeyToken = executingAssembly.GetName().GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length == 8)
				{
					int num3 = BitConverter.ToInt32(publicKeyToken, 0);
					int num4 = BitConverter.ToInt32(publicKeyToken, 4);
					num2 ^= num3 ^ num4;
				}
				else
				{
					num2 ^= 0x10F046AC;
				}
				int num5 = int_2 ^ 0x5F736952;
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
			return dictionary_0[num];
		}
	}
}
