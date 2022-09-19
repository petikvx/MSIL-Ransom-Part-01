using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.TaskScheduler.V1Interop;
using Microsoft.Win32.TaskScheduler.V2Interop;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
public sealed class RunningTaskCollection : IDisposable, IEnumerable<RunningTask>, IEnumerable
{
	internal class V1RunningTaskEnumerator : IDisposable, IEnumerator<RunningTask>, IEnumerator
	{
		private TaskService svc;

		private TaskCollection.V1TaskEnumerator tEnum;

		public RunningTask Current => new RunningTask(svc, tEnum.ICurrent);

		object IEnumerator.Current => Current;

		internal V1RunningTaskEnumerator(TaskService svc)
		{
			this.svc = svc;
			tEnum = new TaskCollection.V1TaskEnumerator(svc);
		}

		public bool MoveNext()
		{
			if (tEnum.MoveNext())
			{
				if (tEnum.Current.State == TaskState.Running)
				{
					return true;
				}
				return MoveNext();
			}
			return false;
		}

		public void Dispose()
		{
			tEnum.Dispose();
		}

		public void Reset()
		{
			tEnum.Reset();
		}
	}

	internal class RunningTaskEnumerator : IDisposable, IEnumerator<RunningTask>, IEnumerator
	{
		private TaskService svc;

		private ITaskService v2Svc;

		private IEnumerator iEnum;

		public RunningTask Current
		{
			get
			{
				IRunningTask runningTask = (IRunningTask)iEnum.Current;
				IRegisteredTask registeredTask = null;
				try
				{
					registeredTask = TaskService.GetTask(v2Svc, runningTask.Path);
				}
				catch
				{
				}
				if (registeredTask == null)
				{
					return null;
				}
				return new RunningTask(svc, registeredTask, runningTask);
			}
		}

		object IEnumerator.Current => Current;

		internal RunningTaskEnumerator(TaskService svc, IRunningTaskCollection iTaskColl)
		{
			this.svc = svc;
			v2Svc = svc.v2TaskService;
			iEnum = iTaskColl.GetEnumerator();
		}

		public void Dispose()
		{
			v2Svc = null;
			iEnum = null;
		}

		public bool MoveNext()
		{
			return iEnum.MoveNext();
		}

		public void Reset()
		{
			iEnum.Reset();
		}
	}

	private TaskService svc;

	private ITaskScheduler v1TS;

	private ITaskService v2Svc;

	private IRunningTaskCollection v2Coll;

	public int Count
	{
		get
		{
			if (v2Coll != null)
			{
				return v2Coll.Count;
			}
			int num = 0;
			V1RunningTaskEnumerator v1RunningTaskEnumerator = new V1RunningTaskEnumerator(svc);
			while (v1RunningTaskEnumerator.MoveNext())
			{
				num++;
			}
			return num;
		}
	}

	public RunningTask this[int index]
	{
		get
		{
			if (v2Coll != null)
			{
				IRunningTask runningTask = v2Coll[++index];
				return new RunningTask(svc, TaskService.GetTask(svc.v2TaskService, runningTask.Path), runningTask);
			}
			int num = 0;
			V1RunningTaskEnumerator v1RunningTaskEnumerator = new V1RunningTaskEnumerator(svc);
			do
			{
				if (!v1RunningTaskEnumerator.MoveNext())
				{
					throw new ArgumentOutOfRangeException();
				}
			}
			while (num++ != index);
			return v1RunningTaskEnumerator.Current;
		}
	}

	internal RunningTaskCollection(TaskService svc)
	{
		this.svc = svc;
		v1TS = svc.v1TaskScheduler;
	}

	internal RunningTaskCollection(TaskService svc, IRunningTaskCollection iTaskColl)
	{
		this.svc = svc;
		v2Svc = svc.v2TaskService;
		v2Coll = iTaskColl;
	}

	public void Dispose()
	{
		v1TS = null;
		v2Svc = null;
		if (v2Coll != null)
		{
			Marshal.ReleaseComObject(v2Coll);
		}
	}

	public IEnumerator<RunningTask> GetEnumerator()
	{
		if (v2Coll != null)
		{
			return new RunningTaskEnumerator(svc, v2Coll);
		}
		return new V1RunningTaskEnumerator(svc);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
