using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace YoutubeFeedUpdater.Classes;

public sealed class TaskSystem
{
	private readonly Queue<ITask> queue_0 = new Queue<ITask>();

	private ITask itask_0;

	public Log LogCallBack;

	private TasksFinished tasksFinished_0;

	public WebBrowser HostWebBrowser;

	public event TasksFinished OnTasksFinished
	{
		add
		{
			TasksFinished tasksFinished = tasksFinished_0;
			TasksFinished tasksFinished2;
			do
			{
				tasksFinished2 = tasksFinished;
				TasksFinished value2 = (TasksFinished)Delegate.Combine(tasksFinished2, value);
				tasksFinished = Interlocked.CompareExchange(ref tasksFinished_0, value2, tasksFinished2);
			}
			while ((object)tasksFinished != tasksFinished2);
		}
		remove
		{
			TasksFinished tasksFinished = tasksFinished_0;
			TasksFinished tasksFinished2;
			do
			{
				tasksFinished2 = tasksFinished;
				TasksFinished value2 = (TasksFinished)Delegate.Remove(tasksFinished2, value);
				tasksFinished = Interlocked.CompareExchange(ref tasksFinished_0, value2, tasksFinished2);
			}
			while ((object)tasksFinished != tasksFinished2);
		}
	}

	public TaskSystem(Log logCallBack, WebBrowser hostWebBrowser)
	{
		HostWebBrowser = hostWebBrowser;
		LogCallBack = logCallBack;
		new Thread(method_0).Start();
	}

	public T AddTask<T>(T task) where T : ITask
	{
		queue_0.Enqueue(task);
		return task;
	}

	private void method_0()
	{
		while (true)
		{
			_ = 1;
			method_1();
			if (itask_0 != null)
			{
				itask_0.Run(this);
			}
		}
	}

	private void method_1()
	{
		if (queue_0.Count == 0)
		{
			if (itask_0 != null)
			{
				if (tasksFinished_0 != null)
				{
					tasksFinished_0(this);
				}
				itask_0 = null;
			}
		}
		else
		{
			itask_0 = queue_0.Dequeue();
		}
	}

	public void Clear()
	{
		queue_0.Clear();
		if (tasksFinished_0 != null)
		{
			tasksFinished_0(this);
		}
	}
}
