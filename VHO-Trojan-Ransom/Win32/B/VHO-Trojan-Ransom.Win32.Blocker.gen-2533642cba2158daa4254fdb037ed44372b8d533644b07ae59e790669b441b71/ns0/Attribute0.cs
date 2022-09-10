using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.InteropServices;

namespace ns0;

internal sealed class Attribute0 : Attribute
{
	internal sealed class Class0
	{
		private static bool bool_0;

		internal static Assembly smethod_0(object object_0, ResolveEventArgs resolveEventArgs_0)
		{
			string text = "149875820344EED3CA10D13973D2367CC2B00636";
			string text2 = text;
			string name = text2 + '1';
			AppDomain currentDomain = AppDomain.CurrentDomain;
			Dictionary<string, string> dictionary = (Dictionary<string, string>)currentDomain.GetData(name);
			Assembly assembly;
			if (dictionary == null)
			{
				dictionary = new Dictionary<string, string>();
				currentDomain.SetData(name, dictionary);
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(text);
				if (manifestResourceStream == null)
				{
					return null;
				}
				byte[] array = new byte[manifestResourceStream.Length - 1L];
				int num = manifestResourceStream.ReadByte();
				manifestResourceStream.Read(array, 0, array.Length);
				for (int i = 0; i < array.Length; i++)
				{
					array[i] ^= (byte)((i + num) & 0xFF);
				}
				MemoryStream memoryStream = new MemoryStream();
				using (DeflateStream deflateStream = new DeflateStream(new MemoryStream(array), CompressionMode.Decompress, leaveOpen: true))
				{
					byte[] array2 = new byte[1024];
					int count;
					while ((count = deflateStream.Read(array2, 0, array2.Length)) > 0)
					{
						memoryStream.Write(array2, 0, count);
					}
				}
				assembly = Assembly.Load(memoryStream.ToArray(), (byte[])null, executingAssembly.get_Evidence());
				currentDomain.SetData(text2, assembly);
				string[] manifestResourceNames = assembly.GetManifestResourceNames();
				foreach (string text3 in manifestResourceNames)
				{
					dictionary[text3] = text3;
				}
			}
			else
			{
				assembly = (Assembly)currentDomain.GetData(text2);
			}
			if (dictionary.ContainsKey(resolveEventArgs_0.Name))
			{
				return assembly;
			}
			return null;
		}

		internal static void smethod_1()
		{
			if (bool_0)
			{
				return;
			}
			lock (typeof(Class0))
			{
				if (!bool_0)
				{
					bool_0 = true;
					AppDomain.CurrentDomain.ResourceResolve += smethod_0;
				}
			}
		}
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 188)]
	private struct Struct0
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	static Attribute0()
	{
		Class0.smethod_1();
		char_1 = new char[94];
		char[] array = new char[8];
		array[7] = 'ჲ';
		array[6] = '\u1f47';
		array[1] = '㥋';
		array[2] = 'ڍ';
		array[4] = '\u0327';
		array[0] = '㪴';
		array[5] = '⽻';
		array[3] = 'Ḉ';
		string_0 = new string[2];
		char_0 = array;
	}
}
