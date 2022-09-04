using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using TechLifePlanner.BaseFunctions.FunctionB;

namespace TechLifePlanner.BaseFunctions.FunctionA;

public class Start
{
	public static object objMainFunction;

	public static Thread NoFreezeThread = new Thread(LoadParams.Start);

	[DebuggerNonUserCode]
	public Start()
	{
	}

	public static object Setup(Assembly Inputs)
	{
		try
		{
			if ((object)Inputs != null)
			{
				objMainFunction = Inputs;
			}
			else
			{
				Environment.Exit(0);
			}
			NoFreezeThread.IsBackground = true;
			NoFreezeThread.SetApartmentState(ApartmentState.STA);
			NoFreezeThread.Priority = ThreadPriority.Normal;
			NoFreezeThread.Start();
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
