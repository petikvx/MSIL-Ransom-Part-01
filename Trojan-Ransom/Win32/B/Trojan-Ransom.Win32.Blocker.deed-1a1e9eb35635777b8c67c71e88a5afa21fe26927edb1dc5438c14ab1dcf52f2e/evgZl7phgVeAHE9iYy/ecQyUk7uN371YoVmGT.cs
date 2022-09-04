using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using e1t9ZoIMs7pU1MfVBaV;
using e8LTutU7xPVoEGMHwY;
using e9tidtTOy7XQsxPlB3;

namespace evgZl7phgVeAHE9iYy;

[eQ4lsmegMDQXG3pADB]
[eeNgOOoJI24v6FIq7w]
internal static class ecQyUk7uN371YoVmGT
{
	private static ModuleHandle eKb3AYt8Z;

	private static char[] exwyp4bAY;

	[eQ4lsmegMDQXG3pADB]
	[eeNgOOoJI24v6FIq7w]
	public static void e4ZIbpnTa(int int_0)
	{
		Type type = default(Type);
		FieldInfo[] fields = default(FieldInfo[]);
		int i = default(int);
		FieldInfo fieldInfo = default(FieldInfo);
		string text = default(string);
		bool flag = default(bool);
		int num = default(int);
		int num2 = default(int);
		char c = default(char);
		int j = default(int);
		MethodInfo methodInfo = default(MethodInfo);
		Delegate @delegate = default(Delegate);
		ParameterInfo[] array = default(ParameterInfo[]);
		int num3 = default(int);
		Type[] array2 = default(Type[]);
		int k = default(int);
		DynamicMethod dynamicMethod = default(DynamicMethod);
		ILGenerator iLGenerator = default(ILGenerator);
		int l = default(int);
		try
		{
			try
			{
				type = eiqak49xVGsEPxXHlFd(eKb3AYt8Z.ResolveTypeHandle(33554433 + int_0));
			}
			catch
			{
				return;
			}
			fields = type.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			for (i = 0; i < fields.Length; i++)
			{
				fieldInfo = fields[i];
				text = (string)ek1lse9zXqnBvp3Vafp(fieldInfo);
				flag = false;
				num = 0;
				num2 = eZ9yhXk7knW57wwu4Um(text) - 1;
				while (num2 >= 0)
				{
					c = etBP31k9LTFBWEovhEx(text, num2);
					if (c != '~')
					{
						for (j = 0; j < 58; j++)
						{
							if (exwyp4bAY[j] == c)
							{
								num = num * 58 + j;
								break;
							}
						}
						num2--;
						continue;
					}
					flag = true;
					break;
				}
				try
				{
					methodInfo = (MethodInfo)eaR6RikkrtSgfLHJVK6(eKb3AYt8Z.ResolveMethodHandle(num + 167772161));
				}
				catch
				{
					continue;
				}
				if (ejaiQVkQoPi96f3qulP(methodInfo))
				{
					try
					{
						@delegate = (Delegate)e7RH18kJJu4jL2Epyi6(eopGnnkL3KfrN5QNIOF(fieldInfo), methodInfo);
					}
					catch (Exception)
					{
						continue;
					}
				}
				else
				{
					array = (ParameterInfo[])eVg41Zkj9hiqYCLQr3M(methodInfo);
					num3 = array.Length + 1;
					array2 = new Type[num3];
					array2[0] = eiqak49xVGsEPxXHlFd(typeof(object).TypeHandle);
					for (k = 1; k < num3; k++)
					{
						array2[k] = elGfAWk5GrvTgoW5hye(array[k - 1]);
					}
					dynamicMethod = new DynamicMethod(string.Empty, e2uy3TkC3a1XS6QUX0c(methodInfo), array2, type, skipVisibility: true);
					iLGenerator = (ILGenerator)eOXpB7kZEqGmfPHvVo2(dynamicMethod);
					e3Hgo9kgeW7QhuwiBta(iLGenerator, OpCodes.Ldarg_0);
					if (num3 > 1)
					{
						e3Hgo9kgeW7QhuwiBta(iLGenerator, OpCodes.Ldarg_1);
					}
					if (num3 > 2)
					{
						e3Hgo9kgeW7QhuwiBta(iLGenerator, OpCodes.Ldarg_2);
					}
					if (num3 > 3)
					{
						e3Hgo9kgeW7QhuwiBta(iLGenerator, OpCodes.Ldarg_3);
					}
					if (num3 > 4)
					{
						for (l = 4; l < num3; l++)
						{
							eBmGpAk22TOnU6vqmhW(iLGenerator, OpCodes.Ldarg_S, l);
						}
					}
					evY6Jnki6VS47MMYGLt(iLGenerator, flag ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
					e3Hgo9kgeW7QhuwiBta(iLGenerator, OpCodes.Ret);
					try
					{
						@delegate = (Delegate)eiUamskEvTEtwYPr4ZN(dynamicMethod, type);
					}
					catch
					{
						continue;
					}
				}
				try
				{
					eS256pkYQ8CySgPauph(fieldInfo, null, @delegate);
				}
				catch
				{
				}
			}
		}
		catch (Exception object_)
		{
			euj63wkfSmsCVqAPsYE(object_, new object[20]
			{
				type, fieldInfo, text, flag, num, num2, c, j, methodInfo, @delegate,
				array, num3, array2, k, dynamicMethod, iLGenerator, l, fields, i, int_0
			});
			throw;
		}
	}

	static ecQyUk7uN371YoVmGT()
	{
		Type type = default(Type);
		try
		{
			char[] object_ = new char[58];
			eMSXi8kdqlX1Tbgf86L(object_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			exwyp4bAY = object_;
			type = eiqak49xVGsEPxXHlFd(typeof(MulticastDelegate).TypeHandle);
			if ((object)type != null)
			{
				eKb3AYt8Z = eTkl2ik6vGL7WJyfqmE(((object[])eXdE7ZkXJXh5VKSfbb5(ewm1pwkobunuAs3VYFM()))[0]);
			}
		}
		catch (Exception object_2)
		{
			eLeDEykaZKPZJHnPkbT(object_2, type);
			throw;
		}
	}

	internal static Type eiqak49xVGsEPxXHlFd(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object ek1lse9zXqnBvp3Vafp(object object_0)
	{
		return ((MemberInfo)object_0).Name;
	}

	internal static int eZ9yhXk7knW57wwu4Um(object object_0)
	{
		return ((string)object_0).Length;
	}

	internal static char etBP31k9LTFBWEovhEx(object object_0, int int_0)
	{
		return ((string)object_0)[int_0];
	}

	internal static object eaR6RikkrtSgfLHJVK6(RuntimeMethodHandle runtimeMethodHandle_0)
	{
		return MethodBase.GetMethodFromHandle(runtimeMethodHandle_0);
	}

	internal static bool ejaiQVkQoPi96f3qulP(object object_0)
	{
		return ((MethodBase)object_0).IsStatic;
	}

	internal static Type eopGnnkL3KfrN5QNIOF(object object_0)
	{
		return ((FieldInfo)object_0).FieldType;
	}

	internal static object e7RH18kJJu4jL2Epyi6(Type type_0, object object_0)
	{
		return Delegate.CreateDelegate(type_0, (MethodInfo)object_0);
	}

	internal static object eVg41Zkj9hiqYCLQr3M(object object_0)
	{
		return ((MethodBase)object_0).GetParameters();
	}

	internal static Type elGfAWk5GrvTgoW5hye(object object_0)
	{
		return ((ParameterInfo)object_0).ParameterType;
	}

	internal static Type e2uy3TkC3a1XS6QUX0c(object object_0)
	{
		return ((MethodInfo)object_0).ReturnType;
	}

	internal static object eOXpB7kZEqGmfPHvVo2(object object_0)
	{
		return ((DynamicMethod)object_0).GetILGenerator();
	}

	internal static void e3Hgo9kgeW7QhuwiBta(object object_0, OpCode opCode_0)
	{
		((ILGenerator)object_0).Emit(opCode_0);
	}

	internal static void eBmGpAk22TOnU6vqmhW(object object_0, OpCode opCode_0, int int_0)
	{
		((ILGenerator)object_0).Emit(opCode_0, int_0);
	}

	internal static void evY6Jnki6VS47MMYGLt(object object_0, OpCode opCode_0, object object_1)
	{
		((ILGenerator)object_0).Emit(opCode_0, (MethodInfo)object_1);
	}

	internal static object eiUamskEvTEtwYPr4ZN(object object_0, Type type_0)
	{
		return ((DynamicMethod)object_0).CreateDelegate(type_0);
	}

	internal static void eS256pkYQ8CySgPauph(object object_0, object object_1, object object_2)
	{
		((FieldInfo)object_0).SetValue(object_1, object_2);
	}

	internal static void euj63wkfSmsCVqAPsYE(object object_0, object object_1)
	{
		eEJNauItTVW1j8pluTb.ep2oBURlk((Exception)object_0, (object[])object_1);
	}

	internal static bool eK2pBR9PZ30j0dEOb6B()
	{
		return true;
	}

	internal static bool e4vnmY9mC5pYOAEPJiQ()
	{
		return false;
	}

	internal static object ewm1pwkobunuAs3VYFM()
	{
		return Assembly.GetExecutingAssembly();
	}

	internal static object eXdE7ZkXJXh5VKSfbb5(object object_0)
	{
		return ((Assembly)object_0).GetModules();
	}

	internal static ModuleHandle eTkl2ik6vGL7WJyfqmE(object object_0)
	{
		return ((Module)object_0).ModuleHandle;
	}

	internal static void eMSXi8kdqlX1Tbgf86L(object object_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray((Array)object_0, runtimeFieldHandle_0);
	}

	internal static void eLeDEykaZKPZJHnPkbT(object object_0, object object_1)
	{
		eEJNauItTVW1j8pluTb.ecs0D1Zdd((Exception)object_0, object_1);
	}
}
