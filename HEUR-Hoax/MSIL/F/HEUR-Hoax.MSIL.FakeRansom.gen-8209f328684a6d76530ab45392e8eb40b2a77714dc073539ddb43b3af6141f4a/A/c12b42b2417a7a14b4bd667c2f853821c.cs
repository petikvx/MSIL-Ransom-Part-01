using System;
using System.Reflection;
using System.Reflection.Emit;

namespace A;

internal class c12b42b2417a7a14b4bd667c2f853821c
{
	private static readonly int c76b8365e2974856c7e977bad4b191af4;

	private static readonly int c7b3e8cbc5f00f18a6ea7672a52c73277;

	private static readonly int c10886878d62f13b750e4b3ed918eeba6;

	private static readonly int cd60215fa82763bd0005d3f75145a061c;

	private static readonly int c403a77a38204b71a7de0026c504850ba;

	private static readonly int ce9d17734dfb09c27e27fdd428325f572;

	private static readonly int c2137fabfb5edb5868ea243bf5887d029;

	private static readonly int c7c4f5737d96ad358f5f595c19e7f6af2;

	private static readonly int cbd270045c4db5bcb35ff1041fa6f1286;

	private static readonly int c1b9fbc0cc4a48de7b5b15b4b8bb492a7;

	private static readonly int caaf7fc405ae83c772da5b3ac8231f6e4;

	private static readonly int c8896d80f119520d843d93c776e7fc328;

	private static readonly int ce648688e223575c4ff1ac4d8ba058c2a;

	private static readonly int c4c26604c57ba6c41fa53818b8e7402ec;

	private static readonly int c8b9b8876269eb3a6d95b97960e0822ff;

	private static readonly int c8143dcfdcce38a282b8533757954b2b4;

	private static readonly int cb980d4879da548b5c104aa566d275d8a;

	private static readonly int c698cf664da8c72ff12dcd7715eb63eb3;

	private static readonly int c9ceee02037430909403ffeb1616a2b06;

	private static readonly int c8eaa1bd80da1ce8a0dee9ca5346663f4;

	private static readonly ModuleHandle c129f5401112643e426bdcc7a2f525ade;

	private int ccee21b470b2c21685dc6b11d829246db => 1;

	static c12b42b2417a7a14b4bd667c2f853821c()
	{
		if ((object)typeof(MulticastDelegate) != null)
		{
			c129f5401112643e426bdcc7a2f525ade = Assembly.GetExecutingAssembly().GetModules()[0].ModuleHandle;
		}
	}

	public static void c6b9207f61eefbab9ab23e17c3952be61(int c9daf0b63b971dda0ae21f319850aa310, int c245c980cb58cb8d1daf221b392b5b9a3, int cb0cd0f5dbc0651785bd37699780ed289)
	{
		Type typeFromHandle;
		MethodInfo methodInfo;
		try
		{
			typeFromHandle = Type.GetTypeFromHandle(c129f5401112643e426bdcc7a2f525ade.ResolveTypeHandle(c9daf0b63b971dda0ae21f319850aa310));
			object obj = ((cb0cd0f5dbc0651785bd37699780ed289 != 16777215) ? MethodBase.GetMethodFromHandle(c129f5401112643e426bdcc7a2f525ade.ResolveMethodHandle(c245c980cb58cb8d1daf221b392b5b9a3), c129f5401112643e426bdcc7a2f525ade.ResolveTypeHandle(cb0cd0f5dbc0651785bd37699780ed289)) : MethodBase.GetMethodFromHandle(c129f5401112643e426bdcc7a2f525ade.ResolveMethodHandle(c245c980cb58cb8d1daf221b392b5b9a3)));
			methodInfo = (MethodInfo)obj;
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
					value = Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo);
				}
				else
				{
					ParameterInfo[] parameters = methodInfo.GetParameters();
					int num = parameters.Length + 1;
					Type[] array = new Type[num];
					if (methodInfo.DeclaringType!.IsValueType)
					{
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
