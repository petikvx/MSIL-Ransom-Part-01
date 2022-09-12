using System;
using System.Reflection;
using System.Reflection.Emit;

namespace A;

internal class c023a88c98711885468f55cfb2d4f7a7d
{
	private static readonly int c82664c3e6d592cd89755d4da96dc0835;

	private static readonly int c0e3a2462a4bb45efe4752feee7d5c5e5;

	private static readonly int ca2a22da728a4b0ce11f7c1735eed127b;

	private static readonly int c9ac76e2008b9c1cf47251c27d70d669f;

	private static readonly int c8a0547841933c32ae5b70b9b08e1386e;

	private static readonly int ca7b7df7f9b21eec829c158fcbdfaf877;

	private static readonly int c9df6b5b9722259eb263ff70bd11a713c;

	private static readonly int cdc450182e89a553f57d673164a5faf3e;

	private static readonly int c099598e247fe4cd985df6701ae2bcf8c;

	private static readonly int cc16d62a02f7667d416f9f6601874ea41;

	private static readonly int c6371b1c83943b1861f76891c3cde50eb;

	private static readonly int c9c4ee885c4280a44283860a9f012d15c;

	private static readonly int cd7b3f8e858ba3c9562065f4ade066366;

	private static readonly int c9b6180ea17b9ab7aebfe32a221e33b09;

	private static readonly int c4706864d5e9233bd451e5f9591975ed1;

	private static readonly int c107a3a93604c660f6a714e7f0d679fc3;

	private static readonly int c4f9667d44b9c7a2cdf4f93fa81eaff31;

	private static readonly int c65138ba40c9a4f99f14171b77b1bc0d5;

	private static readonly int ccdc7e96720b922c1cadf96433c1a9868;

	private static readonly int c061a434e71f39d8cae78d61888333a90;

	private static readonly ModuleHandle c8b7a171e37128282db0309663fbc6329;

	private int cfba4eb4268b6d676feaa4f50c4d997ce => 1;

	static c023a88c98711885468f55cfb2d4f7a7d()
	{
		if ((object)Type.GetTypeFromHandle(ce5d28e0d14c98c7a36ee441bab01451d.c621e8081827d89978082f11893ea5271()) == null)
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
			c8b7a171e37128282db0309663fbc6329 = Assembly.GetExecutingAssembly().GetModules()[0].ModuleHandle;
			return;
		}
	}

	public static void cf8d311399ae216ec9c658b7e17e67c17(int c727cad64e1e44ade1e8983a5cfd74af2, int c21332eeb2442f93bf8af856dcdfa6f87, int c0823930b6e65c7cc2ed8389e02f5de96)
	{
		Type typeFromHandle;
		MethodInfo methodInfo;
		try
		{
			typeFromHandle = Type.GetTypeFromHandle(c8b7a171e37128282db0309663fbc6329.ResolveTypeHandle(c727cad64e1e44ade1e8983a5cfd74af2));
			object cae378af460ca66e363ba38b380c = ((c0823930b6e65c7cc2ed8389e02f5de96 != 16777215) ? MethodBase.GetMethodFromHandle(c8b7a171e37128282db0309663fbc6329.ResolveMethodHandle(c21332eeb2442f93bf8af856dcdfa6f87), c8b7a171e37128282db0309663fbc6329.ResolveTypeHandle(c0823930b6e65c7cc2ed8389e02f5de96)) : MethodBase.GetMethodFromHandle(c8b7a171e37128282db0309663fbc6329.ResolveMethodHandle(c21332eeb2442f93bf8af856dcdfa6f87)));
			methodInfo = cd09fa07b33cc34098c7a4eea9cf27947.c007ef8c7a55379475f176c60263ab3fe(cae378af460ca66e363ba38b380c);
		}
		catch (Exception)
		{
			throw;
		}
		FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
		for (int i = 0; i < (int)(nuint)c55b3ef4ac575f0d81567348147585acf.c8d798c339232c1b6b575ebd272b15269(fields); i++)
		{
			FieldInfo fieldInfo = fields[i];
			try
			{
				Delegate value;
				if (methodInfo.IsStatic)
				{
					value = Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo);
				}
				else
				{
					ParameterInfo[] parameters = methodInfo.GetParameters();
					int num = (int)(nuint)cb75cca3057b4a726dc0efe8b96509252.c8d798c339232c1b6b575ebd272b15269(parameters) + 1;
					Type[] array = cca030cbfc7c3aaf63f908d051871cf8f.c7cb1f716b787714951ca7b99e7c9eec5(num);
					if (methodInfo.DeclaringType!.IsValueType)
					{
						array[0] = methodInfo.DeclaringType!.MakeByRefType();
					}
					else
					{
						array[0] = Type.GetTypeFromHandle(cfcd0479b0ce6d3c49498eb70f66ae0e8.c621e8081827d89978082f11893ea5271());
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
					if (1 == 0)
					{
						/*OpCode not supported: LdMemberToken*/;
					}
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array, typeFromHandle, skipVisibility: true);
					ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
					iLGenerator.Emit(OpCodes.Ldarg_0);
					if (num > 1)
					{
						iLGenerator.Emit(OpCodes.Ldarg_1);
					}
					if (num > 2)
					{
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
					}
					iLGenerator.Emit(fieldInfo.IsFamilyOrAssembly ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
					iLGenerator.Emit(OpCodes.Ret);
					value = dynamicMethod.CreateDelegate(typeFromHandle);
				}
				fieldInfo.SetValue(null, value);
			}
			catch (Exception)
			{
			}
		}
	}
}
