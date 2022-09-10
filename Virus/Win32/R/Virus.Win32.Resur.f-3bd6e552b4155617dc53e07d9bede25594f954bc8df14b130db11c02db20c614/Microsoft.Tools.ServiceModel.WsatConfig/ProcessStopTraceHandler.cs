using System.Collections.Generic;
using System.Management;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

internal class ProcessStopTraceHandler
{
	private bool isArrived;

	private uint processID;

	private uint returnCode;

	private Dictionary<uint, uint> processesExited = new Dictionary<uint, uint>();

	public uint ProcessId
	{
		get
		{
			return processID;
		}
		set
		{
			processID = value;
			if (value == 0)
			{
				return;
			}
			lock (processesExited)
			{
				uint value2 = 0u;
				if (processesExited.TryGetValue(value, out value2))
				{
					isArrived = true;
					returnCode = value2;
				}
			}
		}
	}

	internal bool IsArrived => isArrived;

	internal uint ReturnCode => returnCode;

	internal void Arrived(object sender, EventArrivedEventArgs e)
	{
		uint num = (uint)e.get_NewEvent().get_Properties().get_Item("ProcessID")
			.get_Value();
		uint value = (uint)e.get_NewEvent().get_Properties().get_Item("ExitStatus")
			.get_Value();
		if (ProcessId == 0)
		{
			lock (processesExited)
			{
				processesExited[num] = value;
				return;
			}
		}
		if (num == ProcessId)
		{
			returnCode = value;
			isArrived = true;
		}
	}
}
