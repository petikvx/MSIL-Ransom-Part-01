using System;
using System.Diagnostics;
using System.Reflection;
using Microsoft.VisualBasic.CompilerServices;
using TechLifePlanner.BaseFunctions.FunctionA;

namespace TechLifePlanner.BaseFunctions.FunctionB;

public class LoadParams
{
	[DebuggerNonUserCode]
	public LoadParams()
	{
	}

	public static void Start()
	{
		try
		{
			bool flag = false;
			Assembly assembly = (Assembly)TechLifePlanner.BaseFunctions.FunctionA.Start.objMainFunction;
			MethodInfo entryPoint = assembly.EntryPoint;
			if ((entryPoint.GetParameters().Length != 0) ? true : false)
			{
				string Param = "VStudios";
				serializableParameters.Begin(entryPoint, ParamsFound: true, ref Param);
			}
			else
			{
				string Param = null;
				serializableParameters.Begin(entryPoint, ParamsFound: false, ref Param);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
