using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Orcus.Utilities;

public static class ProcessExtensions
{
	public static List<Process> GetProcessByFilename(string fileName)
	{
		List<Process> list = new List<Process>();
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			try
			{
				if (process.MainModule!.FileName == fileName)
				{
					list.Add(process);
				}
			}
			catch (Exception)
			{
			}
		}
		return list;
	}
}
