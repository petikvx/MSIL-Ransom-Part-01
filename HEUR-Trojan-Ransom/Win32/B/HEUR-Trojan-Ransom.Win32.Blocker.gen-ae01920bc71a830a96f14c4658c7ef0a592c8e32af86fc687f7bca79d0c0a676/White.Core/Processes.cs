using System.Collections.Generic;
using System.Diagnostics;

namespace White.Core;

public class Processes : List<Process>
{
	public Processes(Process[] processes)
	{
		foreach (Process item in processes)
		{
			Add(item);
		}
	}
}
