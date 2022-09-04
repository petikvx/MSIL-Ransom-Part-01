using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;

namespace ns0;

internal static class Class12
{
	private static readonly object object_0 = new object();

	private static Dictionary<int, string> dictionary_0;

	internal static string smethod_0(int int_0, int int_1, int int_2)
	{
		object obj = default(object);
		int num = default(int);
		string text = default(string);
		Assembly executingAssembly = default(Assembly);
		Stream manifestResourceStream = default(Stream);
		byte[] array = default(byte[]);
		int num2 = default(int);
		byte[] publicKeyToken = default(byte[]);
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		byte[] array2 = default(byte[]);
		int num6 = default(int);
		int i = default(int);
		byte[] array3 = default(byte[]);
		Random random = default(Random);
		int j = default(int);
		string @string = default(string);
		try
		{
			Monitor.Enter(obj = object_0);
			try
			{
				num = int_0 ^ 0x590783BA;
				if (dictionary_0 != null && dictionary_0.ContainsKey(num))
				{
					text = dictionary_0[num];
					return text;
				}
				executingAssembly = Assembly.GetExecutingAssembly();
				manifestResourceStream = executingAssembly.GetManifestResourceStream("8063aaa4941f45d8aabba1d1d794d482");
				try
				{
					array = new byte[manifestResourceStream.Length];
					manifestResourceStream.Read(array, 0, Convert.ToInt32(manifestResourceStream.Length));
				}
				finally
				{
					((IDisposable)manifestResourceStream)?.Dispose();
				}
				num2 = int_1;
				publicKeyToken = executingAssembly.GetName().GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length == 8)
				{
					num3 = BitConverter.ToInt32(publicKeyToken, 0);
					num4 = BitConverter.ToInt32(publicKeyToken, 4);
					num2 ^= num3 ^ num4;
				}
				else
				{
					num2 ^= 0x6452CF2E;
				}
				num5 = int_2 ^ 0x372399B9;
				array2 = new byte[num5];
				num6 = 0;
				for (i = num2; i < num2 + num5; i++)
				{
					array2[num6++] = array[i];
				}
				array3 = new byte[num5];
				random = new Random(num);
				random.NextBytes(array3);
				for (j = 0; j < num5; j++)
				{
					array2[j] ^= array3[j];
				}
				@string = Encoding.Unicode.GetString(array2);
				if (dictionary_0 == null)
				{
					dictionary_0 = new Dictionary<int, string>();
				}
				dictionary_0.Add(num, @string);
				text = @string;
				return text;
			}
			finally
			{
				Monitor.Exit(obj);
			}
		}
		catch (Exception exception_)
		{
			Class14.smethod_32(exception_, new object[21]
			{
				int_0, int_1, int_2, num, array, executingAssembly, manifestResourceStream, num2, publicKeyToken, num3,
				num4, num5, array2, num6, i, array3, random, j, @string, text,
				obj
			});
			throw;
		}
	}
}
