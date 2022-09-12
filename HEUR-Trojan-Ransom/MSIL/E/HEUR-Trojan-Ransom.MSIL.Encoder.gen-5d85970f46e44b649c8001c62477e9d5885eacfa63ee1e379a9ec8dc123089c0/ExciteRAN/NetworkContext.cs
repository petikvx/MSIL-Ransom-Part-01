using System;
using System.Reflection;
using System.Reflection.Emit;

namespace ExciteRAN;

internal sealed class NetworkContext
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

	static NetworkContext()
	{
		if ((object)Type.GetTypeFromHandle(NetworkAttribute.ResolveFile()) == null)
		{
			return;
		}
		while (true)
		{
			switch (7)
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

	public static void SaveQueue(int P_0, int P_1, int P_2)
	{
		Type typeFromHandle;
		ConstructorInfo constructorInfo;
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
			constructorInfo = ServerSettings.ResolveFile(methodFromHandle);
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
				ParameterInfo[] parameters = constructorInfo.GetParameters();
				int num = (int)(nuint)ComponentConverter.ResolveFile(parameters);
				Type[] array = SymbolLayout.ResolveFile(num);
				for (int j = 0; j < num; j++)
				{
					array[j] = parameters[j].ParameterType;
				}
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, constructorInfo.DeclaringType, array, typeFromHandle, skipVisibility: true);
					ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
					if (num > 0)
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
						iLGenerator.Emit(OpCodes.Ldarg_0);
					}
					if (num > 1)
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
						iLGenerator.Emit(OpCodes.Ldarg_1);
					}
					if (num > 2)
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
						iLGenerator.Emit(OpCodes.Ldarg_2);
					}
					if (num > 3)
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
						iLGenerator.Emit(OpCodes.Ldarg_3);
					}
					if (num > 4)
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
						for (int k = 4; k < num; k++)
						{
							iLGenerator.Emit(OpCodes.Ldarg_S, k);
						}
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
					}
					iLGenerator.Emit(OpCodes.Newobj, constructorInfo);
					iLGenerator.Emit(OpCodes.Ret);
					Delegate value = dynamicMethod.CreateDelegate(typeFromHandle);
					fieldInfo.SetValue(null, value);
					break;
				}
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
