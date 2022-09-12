using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MySqlX.Sessions;

internal class QueueTaskScheduler : TaskScheduler
{
	private readonly object lockObject = new object();

	protected override IEnumerable<Task> GetScheduledTasks()
	{
		throw new NotImplementedException();
	}

	protected override void QueueTask(Task task)
	{
		ThreadPool.QueueUserWorkItem(delegate
		{
			lock (lockObject)
			{
				Thread.CurrentThread.Name = "mysqlx";
				TryExecuteTask(task);
			}
		});
	}

	protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
	{
		throw new NotImplementedException();
	}
}
