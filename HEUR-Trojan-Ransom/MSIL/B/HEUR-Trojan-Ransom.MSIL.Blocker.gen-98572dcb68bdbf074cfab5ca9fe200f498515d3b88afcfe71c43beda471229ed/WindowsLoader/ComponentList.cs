using System;
using System.Reflection;
using System.Reflection.Emit;

namespace WindowsLoader;

internal class ComponentList
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

	static ComponentList()
	{
		if ((object)typeof(MulticastDelegate) == null)
		{
			return;
		}
		while (true)
		{
			switch (5)
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
		ConstructorInfo constructorInfo;
		try
		{
			typeFromHandle = Type.GetTypeFromHandle(ComponentList.idEnabled.ResolveTypeHandle(idEnabled));
			object methodFromHandle;
			if (messageSet == 16777215)
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
				if (1 == 0)
				{
					/*OpCode not supported: LdMemberToken*/;
				}
				methodFromHandle = MethodBase.GetMethodFromHandle(ComponentList.idEnabled.ResolveMethodHandle(nextUri));
			}
			else
			{
				methodFromHandle = MethodBase.GetMethodFromHandle(ComponentList.idEnabled.ResolveMethodHandle(nextUri), ComponentList.idEnabled.ResolveTypeHandle(messageSet));
			}
			constructorInfo = (ConstructorInfo)methodFromHandle;
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
				ParameterInfo[] parameters = constructorInfo.GetParameters();
				int num = parameters.Length + 1;
				Type[] array = new Type[num];
				array[0] = constructorInfo.DeclaringType!.MakeByRefType();
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
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, null, array, typeFromHandle, skipVisibility: true);
					ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
					if (num > 0)
					{
						while (true)
						{
							switch (5)
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
							switch (1)
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
							switch (1)
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
							switch (1)
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
							switch (5)
							{
							case 0:
								continue;
							}
							break;
						}
					}
					iLGenerator.Emit(OpCodes.Call, constructorInfo);
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
