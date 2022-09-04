using System;
using System.Reflection;
using System.Reflection.Emit;

namespace _003F1_003F;

internal class _003F25_003F
{
	private static readonly int _003F174_003F;

	private static readonly int _003F285_003F;

	private static readonly int _003F286_003F;

	private static readonly int _003F287_003F;

	private static readonly int _003F288_003F;

	private static readonly int _003F289_003F;

	private static readonly int _003F290_003F;

	private static readonly int _003F291_003F;

	private static readonly int _003F292_003F;

	private static readonly int _003F293_003F;

	private static readonly ModuleHandle _003F294_003F;

	private int cf740df5af4625c51a0737a0d387740bd => 1;

	static _003F25_003F()
	{
		if ((object)typeof(MulticastDelegate) == null)
		{
			return;
		}
		while (true)
		{
			switch (1)
			{
			case 0:
				continue;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			_003F294_003F = Assembly.GetExecutingAssembly().GetModules()[0].ModuleHandle;
			return;
		}
	}

	public static void _003F145_003F(int _003F205_003F, int _003F206_003F, int _003F207_003F)
	{
		//IL_02ef: Incompatible stack heights: 0 vs 1
		//IL_030d: Incompatible stack heights: 0 vs 1
		//IL_0312: Incompatible stack heights: 0 vs 1
		Type typeFromHandle;
		MethodInfo methodInfo;
		try
		{
			typeFromHandle = Type.GetTypeFromHandle(_003F294_003F.ResolveTypeHandle(_003F205_003F));
			object methodFromHandle;
			if (_003F207_003F == 16777215)
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
				if (1 == 0)
				{
					/*OpCode not supported: LdMemberToken*/;
				}
				methodFromHandle = MethodBase.GetMethodFromHandle(_003F294_003F.ResolveMethodHandle(_003F206_003F));
			}
			else
			{
				methodFromHandle = MethodBase.GetMethodFromHandle(_003F294_003F.ResolveMethodHandle(_003F206_003F), _003F294_003F.ResolveTypeHandle(_003F207_003F));
			}
			methodInfo = (MethodInfo)methodFromHandle;
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
						switch (5)
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
							switch (3)
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
						switch (7)
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
							switch (7)
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
							switch (6)
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
							switch (5)
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
							switch (7)
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
						_ = OpCodes.Call;
					}
					else
					{
						_ = OpCodes.Callvirt;
					}
					((ILGenerator)/*Error near IL_031d: Stack underflow*/).Emit((OpCode)/*Error near IL_031d: Stack underflow*/, methodInfo);
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
			switch (1)
			{
			case 0:
				break;
			default:
				return;
			}
		}
	}
}
