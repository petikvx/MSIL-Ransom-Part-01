using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using Microsoft.Win32.TaskScheduler.V1Interop;
using Microsoft.Win32.TaskScheduler.V2Interop;

namespace Microsoft.Win32.TaskScheduler;

[XmlType(IncludeInSchema = false)]
[ComVisible(false)]
public sealed class RunningTask : Task
{
	private IRunningTask v2RunningTask;

	public string CurrentAction
	{
		get
		{
			if (v2RunningTask != null)
			{
				return v2RunningTask.CurrentAction;
			}
			return v1Task.GetApplicationName();
		}
	}

	public uint EnginePID
	{
		get
		{
			if (v2RunningTask == null)
			{
				throw new NotV1SupportedException();
			}
			return v2RunningTask.EnginePID;
		}
	}

	public Guid InstanceGuid
	{
		get
		{
			if (v2RunningTask != null)
			{
				return new Guid(v2RunningTask.InstanceGuid);
			}
			return Guid.Empty;
		}
	}

	public override TaskState State
	{
		get
		{
			if (v2RunningTask != null)
			{
				return v2RunningTask.State;
			}
			return base.State;
		}
	}

	internal RunningTask(TaskService svc, IRegisteredTask iTask, IRunningTask iRunningTask)
		: base(svc, iTask)
	{
		v2RunningTask = iRunningTask;
	}

	internal RunningTask(TaskService svc, ITask iTask)
		: base(svc, iTask)
	{
	}

	public new void Dispose()
	{
		base.Dispose();
		if (v2RunningTask != null)
		{
			Marshal.ReleaseComObject(v2RunningTask);
		}
	}

	public void Refresh()
	{
		if (v2RunningTask != null)
		{
			v2RunningTask.Refresh();
		}
	}
}
