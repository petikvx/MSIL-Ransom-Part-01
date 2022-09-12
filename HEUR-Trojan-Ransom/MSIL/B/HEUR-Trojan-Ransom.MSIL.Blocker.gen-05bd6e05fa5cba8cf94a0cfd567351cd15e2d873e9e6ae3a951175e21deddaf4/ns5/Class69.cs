using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;
using ns10;
using ns15;
using ns6;
using ns7;

namespace ns5;

internal class Class69 : Class68
{
	[CompilerGenerated]
	private sealed class Class67<T> where T : notnull
	{
		public object object_0;

		internal object? method_0(T gparam_0)
		{
			return object_0;
		}
	}

	[CompilerGenerated]
	private static readonly Class69 class69_0 = new Class69();

	internal static Class69 Instance
	{
		[CompilerGenerated]
		get
		{
			return class69_0;
		}
	}

	public override Delegate7<object> vmethod_1(MethodBase methodBase_0)
	{
		DynamicMethod dynamicMethod = Class4.smethod_181(methodBase_0.ToString(), typeof(object), new Type[1] { typeof(object[]) }, methodBase_0.DeclaringType);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		method_2(methodBase_0, iLGenerator, 0);
		return (Delegate7<object>)dynamicMethod.CreateDelegate(typeof(Delegate7<object>));
	}

	public override Delegate1<T, object?> vmethod_0<T>(MethodBase methodBase_0)
	{
		DynamicMethod dynamicMethod = Class4.smethod_181(methodBase_0.ToString(), typeof(object), new Type[2]
		{
			typeof(object),
			typeof(object[])
		}, methodBase_0.DeclaringType);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		method_2(methodBase_0, iLGenerator, 1);
		return (Delegate1<T, object>)dynamicMethod.CreateDelegate(typeof(Delegate1<T, object>));
	}

	private void method_2(MethodBase methodBase_0, ILGenerator ilgenerator_0, int int_0)
	{
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		Label label = ilgenerator_0.DefineLabel();
		ilgenerator_0.Emit(OpCodes.Ldarg, int_0);
		ilgenerator_0.Emit(OpCodes.Ldlen);
		ilgenerator_0.Emit(OpCodes.Ldc_I4, parameters.Length);
		ilgenerator_0.Emit(OpCodes.Beq, label);
		ilgenerator_0.Emit(OpCodes.Newobj, typeof(TargetParameterCountException).GetConstructor(ReflectionUtils.type_0));
		ilgenerator_0.Emit(OpCodes.Throw);
		ilgenerator_0.MarkLabel(label);
		if (!methodBase_0.IsConstructor && !methodBase_0.IsStatic)
		{
			ilgenerator_0.smethod_0(methodBase_0.DeclaringType);
		}
		LocalBuilder local = ilgenerator_0.DeclareLocal(typeof(IConvertible));
		LocalBuilder local2 = ilgenerator_0.DeclareLocal(typeof(object));
		OpCode opcode = ((parameters.Length < 256) ? OpCodes.Ldloca_S : OpCodes.Ldloca);
		OpCode opcode2 = ((parameters.Length < 256) ? OpCodes.Ldloc_S : OpCodes.Ldloc);
		for (int i = 0; i < parameters.Length; i++)
		{
			ParameterInfo parameterInfo = parameters[i];
			Type parameterType = parameterInfo.ParameterType;
			if (parameterType.IsByRef)
			{
				parameterType = parameterType.GetElementType();
				LocalBuilder local3 = ilgenerator_0.DeclareLocal(parameterType);
				if (!parameterInfo.IsOut)
				{
					ilgenerator_0.smethod_1(int_0, i);
					if (parameterType.smethod_13())
					{
						Label label2 = ilgenerator_0.DefineLabel();
						Label label3 = ilgenerator_0.DefineLabel();
						ilgenerator_0.Emit(OpCodes.Brtrue_S, label2);
						ilgenerator_0.Emit(opcode, local3);
						ilgenerator_0.Emit(OpCodes.Initobj, parameterType);
						ilgenerator_0.Emit(OpCodes.Br_S, label3);
						ilgenerator_0.MarkLabel(label2);
						ilgenerator_0.smethod_1(int_0, i);
						ilgenerator_0.smethod_3(parameterType);
						ilgenerator_0.Emit(OpCodes.Stloc_S, local3);
						ilgenerator_0.MarkLabel(label3);
					}
					else
					{
						ilgenerator_0.smethod_3(parameterType);
						ilgenerator_0.Emit(OpCodes.Stloc_S, local3);
					}
				}
				ilgenerator_0.Emit(opcode, local3);
			}
			else if (parameterType.smethod_13())
			{
				ilgenerator_0.smethod_1(int_0, i);
				ilgenerator_0.Emit(OpCodes.Stloc_S, local2);
				Label label4 = ilgenerator_0.DefineLabel();
				Label label5 = ilgenerator_0.DefineLabel();
				ilgenerator_0.Emit(OpCodes.Ldloc_S, local2);
				ilgenerator_0.Emit(OpCodes.Brtrue_S, label4);
				LocalBuilder local4 = ilgenerator_0.DeclareLocal(parameterType);
				ilgenerator_0.Emit(opcode, local4);
				ilgenerator_0.Emit(OpCodes.Initobj, parameterType);
				ilgenerator_0.Emit(opcode2, local4);
				ilgenerator_0.Emit(OpCodes.Br_S, label5);
				ilgenerator_0.MarkLabel(label4);
				if (parameterType.smethod_14())
				{
					MethodInfo method = typeof(IConvertible).GetMethod("To" + parameterType.Name, new Type[1] { typeof(IFormatProvider) });
					if (method != null)
					{
						Label label6 = ilgenerator_0.DefineLabel();
						ilgenerator_0.Emit(OpCodes.Ldloc_S, local2);
						ilgenerator_0.Emit(OpCodes.Isinst, parameterType);
						ilgenerator_0.Emit(OpCodes.Brtrue_S, label6);
						ilgenerator_0.Emit(OpCodes.Ldloc_S, local2);
						ilgenerator_0.Emit(OpCodes.Isinst, typeof(IConvertible));
						ilgenerator_0.Emit(OpCodes.Stloc_S, local);
						ilgenerator_0.Emit(OpCodes.Ldloc_S, local);
						ilgenerator_0.Emit(OpCodes.Brfalse_S, label6);
						ilgenerator_0.Emit(OpCodes.Ldloc_S, local);
						ilgenerator_0.Emit(OpCodes.Ldnull);
						ilgenerator_0.Emit(OpCodes.Callvirt, method);
						ilgenerator_0.Emit(OpCodes.Br_S, label5);
						ilgenerator_0.MarkLabel(label6);
					}
				}
				ilgenerator_0.Emit(OpCodes.Ldloc_S, local2);
				ilgenerator_0.smethod_3(parameterType);
				ilgenerator_0.MarkLabel(label5);
			}
			else
			{
				ilgenerator_0.smethod_1(int_0, i);
				ilgenerator_0.smethod_3(parameterType);
			}
		}
		if (methodBase_0.IsConstructor)
		{
			ilgenerator_0.Emit(OpCodes.Newobj, (ConstructorInfo)methodBase_0);
		}
		else
		{
			ilgenerator_0.smethod_4((MethodInfo)methodBase_0);
		}
		Type type = (methodBase_0.IsConstructor ? methodBase_0.DeclaringType : ((MethodInfo)methodBase_0).ReturnType);
		if (type != typeof(void))
		{
			ilgenerator_0.smethod_2(type);
		}
		else
		{
			ilgenerator_0.Emit(OpCodes.Ldnull);
		}
		ilgenerator_0.smethod_5();
	}

	public override Func<T> vmethod_2<T>(Type type_0)
	{
		DynamicMethod dynamicMethod = Class4.smethod_181("Create" + type_0.FullName, typeof(T), ReflectionUtils.type_0, type_0);
		dynamicMethod.InitLocals = true;
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		Class4.smethod_325(type_0, iLGenerator, this, typeof(T));
		return (Func<T>)dynamicMethod.CreateDelegate(typeof(Func<T>));
	}

	public override Func<T, object?> vmethod_3<T>(PropertyInfo propertyInfo_0)
	{
		DynamicMethod dynamicMethod = Class4.smethod_181("Get" + propertyInfo_0.Name, typeof(object), new Type[1] { typeof(T) }, propertyInfo_0.DeclaringType);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		Class4.smethod_132(iLGenerator, propertyInfo_0, this);
		return (Func<T, object>)dynamicMethod.CreateDelegate(typeof(Func<T, object>));
	}

	public override Func<T, object?> vmethod_4<T>(FieldInfo fieldInfo_0)
	{
		if (fieldInfo_0.IsLiteral)
		{
			object object_0 = fieldInfo_0.GetValue(null);
			return (T gparam_0) => object_0;
		}
		DynamicMethod dynamicMethod = Class4.smethod_181("Get" + fieldInfo_0.Name, typeof(T), new Type[1] { typeof(object) }, fieldInfo_0.DeclaringType);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		Class4.smethod_403(iLGenerator, fieldInfo_0, this);
		return (Func<T, object>)dynamicMethod.CreateDelegate(typeof(Func<T, object>));
	}

	public override Action<T, object?> vmethod_5<T>(FieldInfo fieldInfo_0)
	{
		DynamicMethod dynamicMethod = Class4.smethod_181("Set" + fieldInfo_0.Name, (Type?)null, new Type[2]
		{
			typeof(T),
			typeof(object)
		}, fieldInfo_0.DeclaringType);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		Class4.smethod_759(fieldInfo_0, iLGenerator);
		return (Action<T, object>)dynamicMethod.CreateDelegate(typeof(Action<T, object>));
	}

	public override Action<T, object?> vmethod_6<T>(PropertyInfo propertyInfo_0)
	{
		DynamicMethod dynamicMethod = Class4.smethod_181("Set" + propertyInfo_0.Name, (Type?)null, new Type[2]
		{
			typeof(T),
			typeof(object)
		}, propertyInfo_0.DeclaringType);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		Class4.smethod_724(propertyInfo_0, iLGenerator);
		return (Action<T, object>)dynamicMethod.CreateDelegate(typeof(Action<T, object>));
	}
}
