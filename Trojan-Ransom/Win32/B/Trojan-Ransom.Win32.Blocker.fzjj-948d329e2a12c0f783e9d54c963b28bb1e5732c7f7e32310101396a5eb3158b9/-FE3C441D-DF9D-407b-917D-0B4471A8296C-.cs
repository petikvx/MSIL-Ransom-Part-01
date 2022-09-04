using System;
using System.Reflection;
using System.Reflection.Emit;

public class _007BFE3C441D_002DDF9D_002D407b_002D917D_002D0B4471A8296C_007D
{
	private static ModuleHandle qFM_003D;

	public static string _9iA_003D;

	static _007BFE3C441D_002DDF9D_002D407b_002D917D_002D0B4471A8296C_007D()
	{
		_9iA_003D = "{FE3C441D-DF9D-407b-917D-0B4471A8296C}";
		qFM_003D = Assembly.GetExecutingAssembly().GetModules()[0].ModuleHandle;
	}

	[Obfuscation]
	public static void icgd(int qVM_003D)
	{
		Type typeFromHandle;
		try
		{
			typeFromHandle = Type.GetTypeFromHandle(qFM_003D.ResolveTypeHandle(33554433 + qVM_003D));
		}
		catch
		{
			return;
		}
		FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
		foreach (FieldInfo fieldInfo in fields)
		{
			string text = fieldInfo.Name;
			bool flag = false;
			if (text.EndsWith("%"))
			{
				flag = true;
				text = text.TrimEnd(new char[1] { '%' });
			}
			byte[] value = Convert.FromBase64String(text);
			uint num = BitConverter.ToUInt32(value, 0);
			MethodInfo methodInfo;
			try
			{
				methodInfo = (MethodInfo)MethodBase.GetMethodFromHandle(qFM_003D.ResolveMethodHandle((int)(num + 167772161)));
			}
			catch
			{
				continue;
			}
			Delegate value2;
			if (methodInfo.IsStatic)
			{
				try
				{
					value2 = Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo);
				}
				catch (Exception)
				{
					continue;
				}
			}
			else
			{
				ParameterInfo[] parameters = methodInfo.GetParameters();
				int num2 = parameters.Length + 1;
				Type[] array = new Type[num2];
				array[0] = typeof(object);
				for (int j = 1; j < num2; j++)
				{
					array[j] = parameters[j - 1].ParameterType;
				}
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array, typeFromHandle, skipVisibility: true);
				ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
				iLGenerator.Emit(OpCodes.Ldarg_0);
				if (num2 > 1)
				{
					iLGenerator.Emit(OpCodes.Ldarg_1);
				}
				if (num2 > 2)
				{
					iLGenerator.Emit(OpCodes.Ldarg_2);
				}
				if (num2 > 3)
				{
					iLGenerator.Emit(OpCodes.Ldarg_3);
				}
				if (num2 > 4)
				{
					for (int k = 4; k < num2; k++)
					{
						iLGenerator.Emit(OpCodes.Ldarg_S, k);
					}
				}
				iLGenerator.Emit(flag ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
				iLGenerator.Emit(OpCodes.Ret);
				try
				{
					value2 = dynamicMethod.CreateDelegate(typeFromHandle);
				}
				catch (Exception)
				{
					continue;
				}
			}
			try
			{
				fieldInfo.SetValue(null, value2);
			}
			catch
			{
			}
		}
	}
}
