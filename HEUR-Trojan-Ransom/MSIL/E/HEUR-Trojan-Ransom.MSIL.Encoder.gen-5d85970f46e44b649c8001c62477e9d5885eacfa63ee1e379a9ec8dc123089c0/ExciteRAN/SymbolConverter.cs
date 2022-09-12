using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace ExciteRAN;

internal sealed class SymbolConverter
{
	private static readonly int lastHandler;

	private static readonly int urlHeader;

	private static readonly int logCollection;

	private static readonly int handlerDisposed;

	private static readonly int childLine;

	private static readonly int colorAvailable;

	private static readonly int managerHeader;

	private static readonly int activeSyncObject;

	private static readonly int propStoreToken;

	private static readonly int nodeHeader;

	private static readonly int lastReason;

	private static readonly int currentFilter;

	private static readonly int wrapperInstance;

	private static readonly int parentLine;

	private static readonly int timerDisposed;

	private static readonly int propStoreList;

	private static readonly int queryInitialized;

	private static readonly int rootVersion;

	private static readonly int urlInstance;

	private static readonly int lineInstance;

	private static readonly ModuleHandle managerCache;

	static SymbolConverter()
	{
		if ((object)Type.GetTypeFromHandle(NetworkAttribute.ResolveFile()) == null)
		{
			return;
		}
		while (true)
		{
			switch (2)
			{
			case 0:
				continue;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			managerCache = Assembly.GetExecutingAssembly().GetModules()[0].ModuleHandle;
			return;
		}
	}

	[SpecialName]
	private int get_SaveQueue()
	{
		return 1;
	}

	public static void SplitVector(int P_0, int P_1, int P_2)
	{
		Type typeFromHandle;
		MethodInfo methodInfo;
		try
		{
			typeFromHandle = Type.GetTypeFromHandle(managerCache.ResolveTypeHandle(P_0));
			object methodFromHandle;
			if (P_2 == 16777215)
			{
				while (true)
				{
					switch (1)
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
				methodFromHandle = MethodBase.GetMethodFromHandle(managerCache.ResolveMethodHandle(P_1));
			}
			else
			{
				methodFromHandle = MethodBase.GetMethodFromHandle(managerCache.ResolveMethodHandle(P_1), managerCache.ResolveTypeHandle(P_2));
			}
			methodInfo = FunctionConverter.ResolveFile(methodFromHandle);
		}
		catch (Exception)
		{
			throw;
		}
		FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
		for (int i = 0; i < (int)(nuint)CommandResolver.ResolveFile(fields); i++)
		{
			FieldInfo fieldInfo = fields[i];
			try
			{
				Delegate value;
				if (methodInfo.IsStatic)
				{
					while (true)
					{
						switch (1)
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
					int num = (int)(nuint)ComponentConverter.ResolveFile(parameters) + 1;
					Type[] array = SymbolLayout.ResolveFile(num);
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
						array[0] = Type.GetTypeFromHandle(ControlDesigner.ResolveFile());
					}
					for (int j = 1; j < num; j++)
					{
						array[j] = parameters[j - 1].ParameterType;
					}
					while (true)
					{
						switch (1)
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
							switch (3)
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
							switch (2)
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
							switch (1)
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
							switch (1)
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
							switch (1)
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
			switch (6)
			{
			case 0:
				break;
			default:
				return;
			}
		}
	}
}
