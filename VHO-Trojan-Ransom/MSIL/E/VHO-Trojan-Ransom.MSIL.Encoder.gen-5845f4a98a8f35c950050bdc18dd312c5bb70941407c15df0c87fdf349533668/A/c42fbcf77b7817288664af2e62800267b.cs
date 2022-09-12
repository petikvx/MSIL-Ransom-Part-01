using System;
using System.Reflection;
using System.Reflection.Emit;

namespace A;

internal class c42fbcf77b7817288664af2e62800267b
{
	private static readonly int cb8b941afaa58981f3de624ae435ab880;

	private static readonly int cdeaf619de48af7747dbcff8ae96a6f2a;

	private static readonly int c9bfdc09ea5477156410cf33d184d7f4b;

	private static readonly int c8e94c3fe4ea4f91fbd28bd1c8f620fc2;

	private static readonly int cff732ae1152f816fe27d9a24ef8288a8;

	private static readonly int ce2bb3ce830c33bf3fce1ccae093c10cf;

	private static readonly int c3e6bfc57f61af92c15ab2936e1040ae0;

	private static readonly int cbb48409c13ce5598bea630889db1053e;

	private static readonly int c3ae929d1c44b493d1fd9b5a38de40624;

	private static readonly int c2a6ebd897b51bdb1e015dfcc830ee611;

	private static readonly int c9dec5e9b658fde6c13c24e3cc5335396;

	private static readonly int cc97a05e2c16e631720a7a9a1d044a782;

	private static readonly int cf041a8838faae608bace349a8038c10d;

	private static readonly int ceecdad45a46bc2e60a2301910f311818;

	private static readonly int c3e5ffe14681b360664a381e346f9f0f5;

	private static readonly int ce976f1b6ac5ce7759a7793bf35f1d89b;

	private static readonly int c418ee119b07534e608f3a0f583e3aa80;

	private static readonly int c013bea740f34f771d58b8f5a911a6486;

	private static readonly int ce458ab177c1158930b8f539d6fc08e15;

	private static readonly int c7a8b1307128a365ca3ccb5071af78ce5;

	private static readonly ModuleHandle c2dfaf5911ef747c9fc05f551d52c78f4;

	static c42fbcf77b7817288664af2e62800267b()
	{
		if ((object)typeof(MulticastDelegate) == null)
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
			c2dfaf5911ef747c9fc05f551d52c78f4 = Assembly.GetExecutingAssembly().GetModules()[0].ModuleHandle;
			return;
		}
	}

	public static void c1cb14e14eaceb3eaec4cea02631162a9(int cb218ee1093fb46a4c1c1ba229c850b17, int cdd236abbb6015587ae8f3550f36494fc, int c13e04a1d3f8f942f9d4791344947cc86)
	{
		Type typeFromHandle;
		ConstructorInfo constructorInfo;
		try
		{
			typeFromHandle = Type.GetTypeFromHandle(c2dfaf5911ef747c9fc05f551d52c78f4.ResolveTypeHandle(cb218ee1093fb46a4c1c1ba229c850b17));
			object methodFromHandle;
			if (c13e04a1d3f8f942f9d4791344947cc86 == 16777215)
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
				if (1 == 0)
				{
					/*OpCode not supported: LdMemberToken*/;
				}
				methodFromHandle = MethodBase.GetMethodFromHandle(c2dfaf5911ef747c9fc05f551d52c78f4.ResolveMethodHandle(cdd236abbb6015587ae8f3550f36494fc));
			}
			else
			{
				methodFromHandle = MethodBase.GetMethodFromHandle(c2dfaf5911ef747c9fc05f551d52c78f4.ResolveMethodHandle(cdd236abbb6015587ae8f3550f36494fc), c2dfaf5911ef747c9fc05f551d52c78f4.ResolveTypeHandle(c13e04a1d3f8f942f9d4791344947cc86));
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
						iLGenerator.Emit(OpCodes.Ldarg_0);
					}
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
							switch (5)
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
							switch (6)
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
