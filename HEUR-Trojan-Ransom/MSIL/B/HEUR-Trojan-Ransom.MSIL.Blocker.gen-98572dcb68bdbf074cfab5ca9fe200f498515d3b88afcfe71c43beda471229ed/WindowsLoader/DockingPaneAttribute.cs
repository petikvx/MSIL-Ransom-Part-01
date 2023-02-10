using System;
using System.Reflection;
using System.Reflection.Emit;

namespace WindowsLoader;

internal class DockingPaneAttribute
{
	private static readonly int idEnabled;

	private static readonly int nextUri;

	private static readonly int messageSet;

	private static readonly int parentFont;

	private static readonly int filterCache;

	private static readonly int logHeader;

	private static readonly int nextTimer;

	private static readonly int namesDisposed;

	private static readonly int variableID;

	private static readonly int generatorEnabled;

	private static readonly int previousHandler;

	private static readonly int lastReason;

	private static readonly int rootOptions;

	private static readonly int caption;

	private static readonly ModuleHandle idEnabled;

	private int RemovePane => 1;

	static DockingPaneAttribute()
	{
		if ((object)typeof(MulticastDelegate) == null)
		{
			return;
		}
		while (true)
		{
			switch (3)
			{
			case 0:
				continue;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			idEnabled = Assembly.GetExecutingAssembly().GetModules()[0].ModuleHandle;
			return;
		}
	}

	public static void RemovePane(int idEnabled, int nextUri, int messageSet)
	{
		Type typeFromHandle;
		System.Reflection.MethodInfo methodInfo;
		try
		{
			typeFromHandle = Type.GetTypeFromHandle(DockingPaneAttribute.idEnabled.ResolveTypeHandle(idEnabled));
			object methodFromHandle;
			if (messageSet == 16777215)
			{
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				if (1 == 0)
				{
					/*OpCode not supported: LdMemberToken*/;
				}
				methodFromHandle = MethodBase.GetMethodFromHandle(DockingPaneAttribute.idEnabled.ResolveMethodHandle(nextUri));
			}
			else
			{
				methodFromHandle = MethodBase.GetMethodFromHandle(DockingPaneAttribute.idEnabled.ResolveMethodHandle(nextUri), DockingPaneAttribute.idEnabled.ResolveTypeHandle(messageSet));
			}
			methodInfo = (System.Reflection.MethodInfo)methodFromHandle;
		}
		catch (Exception)
		{
			throw;
		}
		FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
		foreach (FieldInfo fieldInfo in fields)
		{
			try
			{
				Delegate value;
				if (methodInfo.IsStatic)
				{
					while (true)
					{
						switch (6)
						{
						case 0:
							continue;
						}
						break;
					}
					value = Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo);
				}
				else
				{
					ParameterInfo[] parameters = methodInfo.GetParameters();
					int num = parameters.Length + 1;
					Type[] array = new Type[num];
					if (methodInfo.DeclaringType!.IsValueType)
					{
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
						array[0] = methodInfo.DeclaringType!.MakeByRefType();
					}
					else
					{
						array[0] = typeof(object);
					}
					for (int j = 1; j < num; j++)
					{
						array[j] = parameters[j - 1].ParameterType;
					}
					while (true)
					{
						switch (5)
						{
						case 0:
							continue;
						}
						break;
					}
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array, typeFromHandle, skipVisibility: true);
					ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
					iLGenerator.Emit(OpCodes.Ldarg_0);
					if (num > 1)
					{
						while (true)
						{
							switch (4)
							{
							case 0:
								continue;
							}
							break;
						}
						iLGenerator.Emit(OpCodes.Ldarg_1);
					}
					if (num > 2)
					{
						while (true)
						{
							switch (7)
							{
							case 0:
								continue;
							}
							break;
						}
						iLGenerator.Emit(OpCodes.Ldarg_2);
					}
					if (num > 3)
					{
						while (true)
						{
							switch (6)
							{
							case 0:
								continue;
							}
							break;
						}
						iLGenerator.Emit(OpCodes.Ldarg_3);
					}
					if (num > 4)
					{
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
						for (int k = 4; k < num; k++)
						{
							iLGenerator.Emit(OpCodes.Ldarg_S, k);
						}
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
					}
					OpCode opcode;
					if (!fieldInfo.IsFamilyOrAssembly)
					{
						while (true)
						{
							switch (7)
							{
							case 0:
								continue;
							}
							break;
						}
						opcode = OpCodes.Call;
					}
					else
					{
						opcode = OpCodes.Callvirt;
					}
					iLGenerator.Emit(opcode, methodInfo);
					iLGenerator.Emit(OpCodes.Ret);
					value = dynamicMethod.CreateDelegate(typeFromHandle);
				}
				fieldInfo.SetValue(null, value);
			}
			catch (Exception)
			{
			}
		}
		while (true)
		{
			switch (4)
			{
			case 0:
				break;
			default:
				return;
			}
		}
	}
}
