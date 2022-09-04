using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

[SuppressIldasm]
public static class GClass0
{
	private static ModuleHandle moduleHandle_0;

	private static char[] char_0;

	[Attribute1]
	public static void smethod_0(int int_0)
	{
		Type typeFromHandle;
		try
		{
			typeFromHandle = Type.GetTypeFromHandle(moduleHandle_0.ResolveTypeHandle(33554433 + int_0));
		}
		catch
		{
			return;
		}
		FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
		foreach (FieldInfo fieldInfo in fields)
		{
			string name = fieldInfo.Name;
			bool flag = false;
			int num = 0;
			int num2 = name.Length - 1;
			while (num2 >= 0)
			{
				char c = name[num2];
				if (c != '~')
				{
					for (int j = 0; j < 58; j++)
					{
						if (char_0[j] == c)
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
			MethodInfo methodInfo;
			try
			{
				methodInfo = (MethodInfo)MethodBase.GetMethodFromHandle(moduleHandle_0.ResolveMethodHandle(num + 167772161));
			}
			catch
			{
				continue;
			}
			Delegate value;
			if (methodInfo.IsStatic)
			{
				try
				{
					value = Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo);
				}
				catch (Exception)
				{
					continue;
				}
			}
			else
			{
				ParameterInfo[] parameters = methodInfo.GetParameters();
				int num3 = parameters.Length + 1;
				Type[] array = new Type[num3];
				array[0] = typeof(object);
				for (int k = 1; k < num3; k++)
				{
					array[k] = parameters[k - 1].ParameterType;
				}
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array, typeFromHandle, skipVisibility: true);
				ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
				iLGenerator.Emit(OpCodes.Ldarg_0);
				if (num3 > 1)
				{
					iLGenerator.Emit(OpCodes.Ldarg_1);
				}
				if (num3 > 2)
				{
					iLGenerator.Emit(OpCodes.Ldarg_2);
				}
				if (num3 > 3)
				{
					iLGenerator.Emit(OpCodes.Ldarg_3);
				}
				if (num3 > 4)
				{
					for (int l = 4; l < num3; l++)
					{
						iLGenerator.Emit(OpCodes.Ldarg_S, l);
					}
				}
				iLGenerator.Emit(OpCodes.Tailcall);
				iLGenerator.Emit(flag ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
				iLGenerator.Emit(OpCodes.Ret);
				try
				{
					value = dynamicMethod.CreateDelegate(typeFromHandle);
				}
				catch
				{
					continue;
				}
			}
			try
			{
				fieldInfo.SetValue(null, value);
			}
			catch
			{
			}
		}
	}

	static GClass0()
	{
		char_0 = new char[58]
		{
			'\u0001', '\u0002', '\u0003', '\u0004', '\u0005', '\u0006', '\a', '\b', '\u000e', '\u000f',
			'\u0010', '\u0011', '\u0012', '\u0013', '\u0014', '\u0015', '\u0016', '\u0017', '\u0018', '\u0019',
			'\u001a', '\u001b', '\u001c', '\u001d', '\u001e', '\u001f', '\u007f', '\u0080', '\u0081', '\u0082',
			'\u0083', '\u0084', '\u0086', '\u0087', '\u0088', '\u0089', '\u008a', '\u008b', '\u008c', '\u008d',
			'\u008e', '\u008f', '\u0090', '\u0091', '\u0092', '\u0093', '\u0094', '\u0095', '\u0096', '\u0097',
			'\u0098', '\u0099', '\u009a', '\u009b', '\u009c', '\u009d', '\u009e', '\u009f'
		};
		Type typeFromHandle = typeof(MulticastDelegate);
		if ((object)typeFromHandle != null)
		{
			moduleHandle_0 = Assembly.GetExecutingAssembly().GetModules()[0].ModuleHandle;
		}
	}
}
