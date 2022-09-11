using System;
using System.Reflection;
using System.Reflection.Emit;

namespace A;

internal class c02bddd2aa5f21fd428f66bf15ba2cf1e
{
	private static readonly int c06cacdbbf6735926c0c61767fa4f94e9;

	private static readonly int c0fa677156b6fcb91e999ed3d0cc165b6;

	private static readonly int c386dc7ce45dcd14df80b1b1cb1dd06d9;

	private static readonly int c78922caf0d63ba3056c91ce036dc5ed2;

	private static readonly int c54f288efb2c6c57113565abb15bdadc8;

	private static readonly int cc5c09764e1a44c8f445228f072ea1407;

	private static readonly int c3cc89817b8809cc9006e03958528cefb;

	private static readonly int c2cf0c03cc887ea9c33271ea1ebf06930;

	private static readonly int cc1e8fa8ff24d7fb9d092a30a65e6781c;

	private static readonly int c66846ba6d934f7d68b0a5410f01a5445;

	private static readonly int ccd692c06fb5be600635b0f27886c2445;

	private static readonly int c216cc0d260fe208ed6c3a880e3addb0e;

	private static readonly int cf34fdcb2066b553c1f91ced15fa2fd29;

	private static readonly int cb7d8d8db6adbf4529048faebb1e3d4da;

	private static readonly int ce05061afa8629a69eb7a7a0875dbdc2d;

	private static readonly int cd944f69506b969db4c5d4488ef639b73;

	private static readonly int c987d08d626be431bccd591d1afae2017;

	private static readonly int cfe7ad7cc25346484c60b2d8c90e0e422;

	private static readonly int c9db4ecbc9f2bc9ac6d52728f3ce6938f;

	private static readonly int cac2695cf6a61dabbf0b3fe42d2dbdbd8;

	private static readonly ModuleHandle c3cb5d5c523c776737de60b904d4b9c00;

	static c02bddd2aa5f21fd428f66bf15ba2cf1e()
	{
		if ((object)Type.GetTypeFromHandle(cc1d6e0dbec02477c2d8a1f6555abf005.c5eff9f4e0e00839642f7cd30b37cbf7b()) == null)
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
			c3cb5d5c523c776737de60b904d4b9c00 = Assembly.GetExecutingAssembly().GetModules()[0].ModuleHandle;
			return;
		}
	}

	public static void cb504e8ac1419f55c1db71287503fae3b(int P_0, int P_1, int P_2)
	{
		Type typeFromHandle;
		ConstructorInfo constructorInfo;
		try
		{
			typeFromHandle = Type.GetTypeFromHandle(c3cb5d5c523c776737de60b904d4b9c00.ResolveTypeHandle(P_0));
			object methodFromHandle;
			if (P_2 == 16777215)
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
				methodFromHandle = MethodBase.GetMethodFromHandle(c3cb5d5c523c776737de60b904d4b9c00.ResolveMethodHandle(P_1));
			}
			else
			{
				methodFromHandle = MethodBase.GetMethodFromHandle(c3cb5d5c523c776737de60b904d4b9c00.ResolveMethodHandle(P_1), c3cb5d5c523c776737de60b904d4b9c00.ResolveTypeHandle(P_2));
			}
			constructorInfo = c95101d7e74bda0587ed9bf7d258b393e.c04dbfb842e70e0e92df466ba766e97cb(methodFromHandle);
		}
		catch (Exception)
		{
			throw;
		}
		FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
		for (int i = 0; i < (int)(nuint)ca5e68eac35cb82dd485f195f5bc085c8.ce52fc13bd0b1cfec401eb6a87239469b(fields); i++)
		{
			FieldInfo fieldInfo = fields[i];
			try
			{
				ParameterInfo[] parameters = constructorInfo.GetParameters();
				int num = (int)(nuint)c1c17d9917fb823a98932da1dc6957dc2.ce52fc13bd0b1cfec401eb6a87239469b(parameters) + 1;
				Type[] array = c93b5d15cc08f6bdaf1bdfeddeb33d248.c4500622dc42ff2dc98fed926f40f1228(num);
				array[0] = constructorInfo.DeclaringType!.MakeByRefType();
				for (int j = 1; j < num; j++)
				{
					array[j] = parameters[j - 1].ParameterType;
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
						switch (5)
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
						switch (7)
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
			switch (3)
			{
			case 0:
				break;
			default:
				return;
			}
		}
	}
}
