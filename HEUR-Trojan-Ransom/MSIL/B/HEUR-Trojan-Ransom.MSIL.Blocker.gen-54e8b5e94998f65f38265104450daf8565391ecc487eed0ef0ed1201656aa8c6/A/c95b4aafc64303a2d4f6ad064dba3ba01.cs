using System;
using System.Reflection;
using System.Reflection.Emit;

namespace A;

internal class c95b4aafc64303a2d4f6ad064dba3ba01
{
	private static readonly int c51bd1276ca8af9049cdfa06cc2d6717f;

	private static readonly int c3c015adce09b2c636f4b2e2ac48b944d;

	private static readonly int cb669baa2517aa699a9400e295a26e082;

	private static readonly int cceb8bdb67893dd562a7d457a1fc71222;

	private static readonly int cf1e3ca276a0e62e9c7ee05858739e508;

	private static readonly int c15199c5ec5a429f562ebb4955db798f2;

	private static readonly int cd9d0a7937721295a5d60badc62e57071;

	private static readonly int c0cbbee4e2c3ae078d2e4ff93ef7f605e;

	private static readonly int c4ef2459108e4dd29d5667cacc175d1b0;

	private static readonly int c0e1d84fbd9d2ec42395e5c07739c9b0f;

	private static readonly int caaaa4f9538b92be6275f49a1b962de9b;

	private static readonly int c063130de740f55c1ba237162453322eb;

	private static readonly int cfd2c0ef2fa1e920b8c66ae136db52584;

	private static readonly int c63081270fa1c3457b8d81925ce50a15b;

	private static readonly int c211137ac9bff6a61d8b8c8b1e460a196;

	private static readonly int c6ffcbb1a70e6c8df344d27c7a15f5c1c;

	private static readonly int cf8040ef88eb44e16e7f06b33f5931cf8;

	private static readonly int c8e1e3f80ec29be89ce94676302c5200a;

	private static readonly int c67d94af6e2b59ec4443eac07b3c565ed;

	private static readonly int cb5dc487a3da1abfaa12234de9ee0ac37;

	private static readonly ModuleHandle cc016608ac73a88c4fa792174012941d2;

	static c95b4aafc64303a2d4f6ad064dba3ba01()
	{
		if ((object)Type.GetTypeFromHandle(c205ff87a154eae417cfce242ba0438da.cbb9ffb20fb7090941b3e71194f5366ad()) == null)
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
			cc016608ac73a88c4fa792174012941d2 = Assembly.GetExecutingAssembly().GetModules()[0].ModuleHandle;
			return;
		}
	}

	public static void cfada2b09b2164b1d154c5f0687e6391e(int cad723b75dd19aafe6f276a6235bfd834, int cf30fbdabd87f9dbf10cab436c61386f5, int cdaa4b0c38c2e04bcbb9b2f5167476002)
	{
		Type typeFromHandle;
		ConstructorInfo constructorInfo;
		try
		{
			typeFromHandle = Type.GetTypeFromHandle(cc016608ac73a88c4fa792174012941d2.ResolveTypeHandle(cad723b75dd19aafe6f276a6235bfd834));
			object methodFromHandle;
			if (cdaa4b0c38c2e04bcbb9b2f5167476002 == 16777215)
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
				if (1 == 0)
				{
					/*OpCode not supported: LdMemberToken*/;
				}
				methodFromHandle = MethodBase.GetMethodFromHandle(cc016608ac73a88c4fa792174012941d2.ResolveMethodHandle(cf30fbdabd87f9dbf10cab436c61386f5));
			}
			else
			{
				methodFromHandle = MethodBase.GetMethodFromHandle(cc016608ac73a88c4fa792174012941d2.ResolveMethodHandle(cf30fbdabd87f9dbf10cab436c61386f5), cc016608ac73a88c4fa792174012941d2.ResolveTypeHandle(cdaa4b0c38c2e04bcbb9b2f5167476002));
			}
			constructorInfo = c866b4071d29162f3624eca3dc31d5934.c1761cdd290896150463b4220ff313f19(methodFromHandle);
		}
		catch (Exception)
		{
			throw;
		}
		FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
		for (int i = 0; i < (int)(nuint)cc826b1af9d06b00322de7f91779c2d8b.c314668365be25953c8434680343a3754(fields); i++)
		{
			FieldInfo fieldInfo = fields[i];
			try
			{
				ParameterInfo[] parameters = constructorInfo.GetParameters();
				int num = (int)(nuint)c4ae68fcd23c12341df09825154355edb.c314668365be25953c8434680343a3754(parameters);
				Type[] array = c54b2d1960929a5b9b2b26524c8620663.c14b0fe9389c01cff3c55fc9a5b6f5649(num);
				for (int j = 0; j < num; j++)
				{
					array[j] = parameters[j].ParameterType;
				}
				while (true)
				{
					switch (1)
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
							switch (1)
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
							switch (5)
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
							switch (4)
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
							switch (6)
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
