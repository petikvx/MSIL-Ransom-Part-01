using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.InteropServices;

namespace ns5;

internal sealed class Class12
{
	internal sealed class Class13
	{
		internal sealed class Class14
		{
			private static bool bool_0;

			internal static Assembly smethod_0(object object_0, ResolveEventArgs resolveEventArgs_0)
			{
				string text = "A245FB75EFAE631955CB7D2E317E8615BE449261";
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
				lock (typeof(Class14))
				{
					if (!bool_0)
					{
						bool_0 = true;
						AppDomain.CurrentDomain.ResourceResolve += smethod_0;
					}
				}
			}
		}
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 86)]
	private struct Struct16
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	static Class12()
	{
		char_1 = new char[43];
		char[] array = new char[8];
		array[5] = 'ṙ';
		array[0] = '⏹';
		array[7] = 'ᙲ';
		array[6] = 'ሹ';
		array[4] = 'е';
		array[2] = '⒨';
		array[1] = 'ˁ';
		array[3] = 'ṃ';
		string_0 = new string[1];
		char_0 = array;
		Class13.Class14.smethod_1();
	}
}
