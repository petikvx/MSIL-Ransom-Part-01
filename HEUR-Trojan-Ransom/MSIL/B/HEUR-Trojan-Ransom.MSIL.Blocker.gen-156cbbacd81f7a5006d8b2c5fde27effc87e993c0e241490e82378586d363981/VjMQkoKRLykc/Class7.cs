using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Fm;

namespace VjMQkoKRLykc;

internal sealed class Class7
{
	private sealed class Class8
	{
		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private byte[] byte_0;

		public int Int32_0
		{
			[CompilerGenerated]
			get
			{
				return int_0;
			}
			[CompilerGenerated]
			private set
			{
				int_0 = value;
			}
		}

		protected byte[] Byte_0
		{
			[CompilerGenerated]
			get
			{
				return byte_0;
			}
			[CompilerGenerated]
			private set
			{
				byte_0 = value;
			}
		}

		protected Class8(byte[] byte_1, int int_1)
		{
			Byte_0 = byte_1;
			Int32_0 = int_1;
		}

		public int method_0(byte[] byte_1, int int_1, int int_2, byte[] byte_2, int int_3)
		{
			throw new NotImplementedException();
		}

		public byte[] method_1(byte[] byte_1, int int_1, int int_2)
		{
			throw new NotImplementedException();
		}

		public virtual void vmethod_0()
		{
			vmethod_1(bool_0: true);
			GC.SuppressFinalize(this);
		}

		protected virtual void vmethod_1(bool bool_0)
		{
			if (bool_0 && Byte_0 != null)
			{
				Array.Clear(Byte_0, 0, Byte_0.Length);
				Byte_0 = null;
			}
		}
	}

	internal int int_0;

	static Class7()
	{
		Class4.smethod_2();
	}

	private static string smethod_0()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat(" ");
		stringBuilder.Append(Environment.NewLine + Class9.String_0 + Environment.NewLine);
		stringBuilder.AppendLine();
		foreach (string item in smethod_1(" "))
		{
			stringBuilder.AppendLine(item);
		}
		stringBuilder.AppendLine();
		foreach (string item2 in smethod_1(" "))
		{
			stringBuilder.AppendLine(item2);
		}
		stringBuilder.AppendLine();
		return stringBuilder.ToString();
	}

	private static IEnumerable<string> smethod_1(string string_0)
	{
		List<string> list = new List<string>();
		int num = 80;
		try
		{
			num = Console.BufferWidth;
		}
		catch (IOException)
		{
		}
		StringBuilder stringBuilder = new StringBuilder();
		string[] array = string_0.Split(new char[1] { ' ' });
		foreach (string text in array)
		{
			if (stringBuilder.Length + text.Length + 1 >= num)
			{
				list.Add(stringBuilder.ToString());
				stringBuilder = new StringBuilder();
			}
			stringBuilder.Append(text);
			stringBuilder.Append(' ');
		}
		if (stringBuilder.Length > 0)
		{
			list.Add(stringBuilder.ToString());
		}
		return list;
	}

	[STAThread]
	public static int Main()
	{
		Program.Main();
		return 0;
	}
}
