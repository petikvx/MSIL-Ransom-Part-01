using System;
using System.Reflection;
using System.Reflection.Emit;

namespace A;

internal class cbcbf4ee877b7292b0d21f85ea43cc8ed
{
	private static readonly int c0dd610406b8f168b7ace90e74c3a1433;

	private static readonly int cda774489f39dfa1b039feafb88c0c65c;

	private static readonly int c3c49a554401238a75d740a7ec204b138;

	private static readonly int c40b0114848f665b8442deda324972f79;

	private static readonly int c2612104b7b32e068d7f2ad10a4c64da2;

	private static readonly int cd65b27094522cd4471bf094fcd00f5a0;

	private static readonly int c6f3903526c545e6a13971d84e3d2c550;

	private static readonly int c11805cd2d121f513c11197af51e7db16;

	private static readonly int cbb9111fa937273730b4440482df810a8;

	private static readonly int c8b3c80f0551ae2d3355c8653872bd6c1;

	private static readonly int ce1d3aeed0d30edf35fd683a6ac8a2484;

	private static readonly int c19a666d4de2f3a0b1d76ff2fb560e797;

	private static readonly int c3252957b0ae9fe03d75ccb7fe54f6efb;

	private static readonly int ceb72d431550a56c4287d1f3e1eccd270;

	private static readonly int c9aa8d8fe4984ee12206d3844ab14ce65;

	private static readonly int c3b356b7aa7d44b7aeaa65f181fceb1c6;

	private static readonly int cebdf427eccb5e5b217793c9ca451eb66;

	private static readonly int c051623c2de178e44836a937ebd22d173;

	private static readonly int c3b096fe5be4903b4552b6fca5f150e11;

	private static readonly int cadab702dff26b66375ea8b8ff9dca1a3;

	private static readonly ModuleHandle c5de873a2bf8e0c94d33225fdf883d006;

	static cbcbf4ee877b7292b0d21f85ea43cc8ed()
	{
		if ((object)typeof(MulticastDelegate) == null)
		{
			return;
		}
		while (true)
		{
			switch (4)
			{
			case 0:
				continue;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			c5de873a2bf8e0c94d33225fdf883d006 = Assembly.GetExecutingAssembly().GetModules()[0].ModuleHandle;
			return;
		}
	}

	public static void ca0daada28d92eec483a850967dade067(int c0828a18b368851890723b2af8f9983e8, int c208b67677fd74135154965b030f95957, int c6ac5a2bf9ee16309dc1ed4082163ac61)
	{
		Type typeFromHandle;
		ConstructorInfo constructorInfo;
		try
		{
			typeFromHandle = Type.GetTypeFromHandle(c5de873a2bf8e0c94d33225fdf883d006.ResolveTypeHandle(c0828a18b368851890723b2af8f9983e8));
			object methodFromHandle;
			if (c6ac5a2bf9ee16309dc1ed4082163ac61 == 16777215)
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
				methodFromHandle = MethodBase.GetMethodFromHandle(c5de873a2bf8e0c94d33225fdf883d006.ResolveMethodHandle(c208b67677fd74135154965b030f95957));
			}
			else
			{
				methodFromHandle = MethodBase.GetMethodFromHandle(c5de873a2bf8e0c94d33225fdf883d006.ResolveMethodHandle(c208b67677fd74135154965b030f95957), c5de873a2bf8e0c94d33225fdf883d006.ResolveTypeHandle(c6ac5a2bf9ee16309dc1ed4082163ac61));
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
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, null, array, typeFromHandle, skipVisibility: true);
				ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
				if (num > 0)
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
					iLGenerator.Emit(OpCodes.Ldarg_0);
				}
				if (num > 1)
				{
					iLGenerator.Emit(OpCodes.Ldarg_1);
				}
				if (num > 2)
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
				iLGenerator.Emit(OpCodes.Call, constructorInfo);
				iLGenerator.Emit(OpCodes.Ret);
				Delegate value = dynamicMethod.CreateDelegate(typeFromHandle);
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
