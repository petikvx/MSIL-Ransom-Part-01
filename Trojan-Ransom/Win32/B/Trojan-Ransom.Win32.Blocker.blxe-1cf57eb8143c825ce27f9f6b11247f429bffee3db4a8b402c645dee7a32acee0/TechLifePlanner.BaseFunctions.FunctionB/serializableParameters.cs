using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace TechLifePlanner.BaseFunctions.FunctionB;

[Serializable]
public class serializableParameters
{
	[DebuggerNonUserCode]
	public serializableParameters()
	{
	}

	public static void Begin(MethodInfo Input1, bool ParamsFound, ref string Param = null)
	{
		try
		{
			if (ParamsFound)
			{
				Input1.Invoke(RuntimeHelpers.GetObjectValue(new object()), new object[1] { Param });
			}
			else
			{
				Input1.Invoke(RuntimeHelpers.GetObjectValue(new object()), new object[0]);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
