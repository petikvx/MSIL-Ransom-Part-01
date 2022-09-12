using System;
using System.Reflection;
using System.Reflection.Emit;

internal class dc314d0e
{
	private delegate void f0cd21a4(Exception exception_0, string string_0, bool bool_0);

	private static f0cd21a4 c90b9a22;

	private static readonly object object_0;

	private static bool smethod_0(Type type_0)
	{
		try
		{
			MethodInfo method = type_0.GetMethod("Capture");
			MethodInfo method2 = type_0.GetMethod("Throw");
			DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[3]
			{
				typeof(Exception),
				typeof(string),
				typeof(bool)
			});
			ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Call, method);
			iLGenerator.Emit(OpCodes.Call, method2);
			iLGenerator.Emit(OpCodes.Ret);
			c90b9a22 = (f0cd21a4)dynamicMethod.CreateDelegate(typeof(f0cd21a4));
		}
		catch
		{
			return false;
		}
		return true;
	}

	private static bool smethod_1(Type type_0)
	{
		try
		{
			string text = (string)typeof(Environment).InvokeMember("GetResourceString", BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.InvokeMethod, null, null, new object[1] { "Word_At" });
			MethodInfo method = type_0.GetMethod("InternalPreserveStackTrace", BindingFlags.Instance | BindingFlags.NonPublic);
			FieldInfo field = type_0.GetField("_remoteStackTraceString", BindingFlags.Instance | BindingFlags.NonPublic);
			MethodInfo getMethod = type_0.GetProperty("StackTrace", BindingFlags.Instance | BindingFlags.Public)!.GetGetMethod();
			MethodInfo method2 = typeof(string).GetMethod("Format", new Type[3]
			{
				typeof(string),
				typeof(object),
				typeof(object)
			});
			DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[3]
			{
				typeof(Exception),
				typeof(string),
				typeof(bool)
			}, restrictedSkipVisibility: true);
			ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
			Label label = iLGenerator.DefineLabel();
			Label label2 = iLGenerator.DefineLabel();
			Label label3 = iLGenerator.DefineLabel();
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Dup);
			iLGenerator.Emit(OpCodes.Dup);
			iLGenerator.Emit(OpCodes.Ldfld, field);
			iLGenerator.Emit(OpCodes.Brtrue, label2);
			iLGenerator.Emit(OpCodes.Callvirt, getMethod);
			iLGenerator.Emit(OpCodes.Br, label3);
			iLGenerator.MarkLabel(label2);
			iLGenerator.Emit(OpCodes.Ldfld, field);
			iLGenerator.MarkLabel(label3);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Call, method);
			iLGenerator.Emit(OpCodes.Stfld, field);
			iLGenerator.Emit(OpCodes.Ldarg_1);
			iLGenerator.Emit(OpCodes.Brfalse, label);
			iLGenerator.Emit(OpCodes.Ldarg_2);
			iLGenerator.Emit(OpCodes.Brtrue, label);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Dup);
			iLGenerator.Emit(OpCodes.Ldstr, "{1}" + Environment.NewLine + "   " + text + " DNGVM [{0}]" + Environment.NewLine);
			iLGenerator.Emit(OpCodes.Ldarg_1);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Ldfld, field);
			iLGenerator.Emit(OpCodes.Call, method2);
			iLGenerator.Emit(OpCodes.Stfld, field);
			iLGenerator.Emit(OpCodes.Throw);
			iLGenerator.MarkLabel(label);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Throw);
			c90b9a22 = (f0cd21a4)dynamicMethod.CreateDelegate(typeof(f0cd21a4));
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
			return false;
		}
		return true;
	}

	static dc314d0e()
	{
		object_0 = new object();
		if (!smethod_1(typeof(Exception)))
		{
			Type type = Type.GetType("System.Runtime.ExceptionServices.ExceptionDispatchInfo");
			if ((object)type == null || !smethod_0(type))
			{
				c90b9a22 = null;
			}
		}
	}

	public static void smethod_2(Exception exception_0, string string_0)
	{
		if (string_0 == null)
		{
			throw exception_0;
		}
		bool bool_;
		if (!(bool_ = exception_0.Data.Contains(object_0)))
		{
			exception_0.Data[object_0] = object_0;
		}
		if (c90b9a22 != null)
		{
			c90b9a22(exception_0, string_0, bool_);
		}
		throw exception_0;
	}
}
