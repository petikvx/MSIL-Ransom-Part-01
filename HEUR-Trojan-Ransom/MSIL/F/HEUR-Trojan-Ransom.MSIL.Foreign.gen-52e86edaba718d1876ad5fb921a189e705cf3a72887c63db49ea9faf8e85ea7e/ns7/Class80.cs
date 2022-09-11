using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ns7;

internal sealed class Class80 : TaskScheduler
{
	[CompilerGenerated]
	private sealed class Class81
	{
		public Task task_0;

		public Class80 class80_0;

		[NonSerialized]
		internal static GetString getString_0;

		internal void method_0(object object_0)
		{
			lock (class80_0.object_0)
			{
				Thread.CurrentThread.Name = getString_0(107407024);
				class80_0.TryExecuteTask(task_0);
			}
		}

		static Class81()
		{
			Strings.CreateGetStringDelegate(typeof(Class81));
		}
	}

	private readonly object object_0 = new object();

	IEnumerable<Task> TaskScheduler.GetScheduledTasks()
	{
		throw new NotImplementedException();
	}

	void TaskScheduler.QueueTask(Task task)
	{
		ThreadPool.QueueUserWorkItem(delegate
		{
			lock (this.object_0)
			{
				Thread.CurrentThread.Name = Class81.getString_0(107407024);
				TryExecuteTask(task);
			}
		});
	}

	bool TaskScheduler.TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
	{
		throw new NotImplementedException();
	}
}
