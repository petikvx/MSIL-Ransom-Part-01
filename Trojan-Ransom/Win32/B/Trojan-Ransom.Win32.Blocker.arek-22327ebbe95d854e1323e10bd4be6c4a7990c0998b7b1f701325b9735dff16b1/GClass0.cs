using System;
using System.Reflection;
using System.Reflection.Emit;
using PascalBasic.Properties;

public class GClass0
{
	private delegate void SendToCompiler(byte[] docs);

	private delegate uint Delegate0(Delegate1 obj);

	private delegate void Delegate1();

	private static Delegate0 delegate0_0;

	public static void smethod_0()
	{
		delegate0_0 = smethod_1;
		delegate0_0(smethod_2);
	}

	private static uint smethod_1(Delegate1 delegate1_0)
	{
		try
		{
			delegate1_0();
			return 0u;
		}
		catch
		{
			return 0u;
		}
	}

	public static void smethod_2()
	{
		DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(void), new Type[1] { typeof(byte[]) }, restrictedSkipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Call, typeof(Assembly).GetMethods()[39]);
		iLGenerator.Emit(OpCodes.Callvirt, typeof(Assembly).GetMethods()[16]);
		iLGenerator.Emit(OpCodes.Ldc_I4_0);
		iLGenerator.Emit(OpCodes.Ldelem_Ref);
		iLGenerator.Emit(OpCodes.Callvirt, typeof(Type).GetMethods()[50]);
		iLGenerator.Emit(OpCodes.Ldc_I4_0);
		iLGenerator.Emit(OpCodes.Ldelem_Ref);
		iLGenerator.Emit(OpCodes.Ldnull);
		iLGenerator.Emit(OpCodes.Ldc_I4_0);
		iLGenerator.Emit(OpCodes.Newarr, typeof(object));
		iLGenerator.Emit(OpCodes.Callvirt, typeof(MethodBase).GetMethods()[13]);
		iLGenerator.Emit(OpCodes.Pop);
		iLGenerator.Emit(OpCodes.Ret);
		((SendToCompiler)dynamicMethod.CreateDelegate(typeof(SendToCompiler)))(Resources.Byte_0);
	}
}
