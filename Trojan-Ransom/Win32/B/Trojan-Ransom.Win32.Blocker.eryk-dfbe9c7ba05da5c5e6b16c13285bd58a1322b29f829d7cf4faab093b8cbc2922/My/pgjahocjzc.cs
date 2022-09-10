using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.ApplicationServices;

namespace My;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal sealed class pgjahocjzc : ApplicationBase
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 57788)]
	private struct Struct0
	{
	}

	internal sealed class Class0
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 256)]
		private struct Struct1
		{
		}

		private static readonly object object_0;

		private static readonly Array array_0;

		private static readonly Array array_1;

		internal static byte byte_0/* Not supported: data(00) */;

		static Class0()
		{
			array_0 = new char[128];
			byte[] publicKeyToken;
			int num = (publicKeyToken = Assembly.GetExecutingAssembly().GetName().GetPublicKeyToken()).Length;
			char[] array = new char[num];
			for (int i = 0; i < num; i++)
			{
				int num2 = i;
				int num3 = publicKeyToken[i] & 0xFF;
				array[num2] = (char)(num3 ^ (num3 << 2));
			}
			object_0 = array;
			array_1 = new string[14];
		}
	}

	internal static byte zlrghsxmry/* Not supported: data(00) */;
}
