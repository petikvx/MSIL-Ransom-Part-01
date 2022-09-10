using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

internal sealed class Class41
{
	private delegate string Delegate2(int int_0);

	private sealed class Class42
	{
		public MethodBuilder method_0(TypeBuilder typeBuilder_0)
		{
			byte[] array = Convert.FromBase64String("WT8zY3IKPK5JDEszF24CAUmUPg9zSXSqJVQ0qj1rbhwTfG9dBhVoNX9cMzcLTRTsQE47R2VZVHlwZUZyb21IYW5kbAM7Z2V0X05hbWU7SW5kZXhPZjtFeGl0O2dldF9GcmFtZUNvdW50O2dldF9MZW5ndGg7UmVhZFN0cmluZztBZGQ7Z2V0X1Bvc2l0aW9uO2dldF9DdXJyZW50RG9tYWluO1NldERhdGE7UnVudGltZU1ldGhvZDtTeXN0ZW0uRGlhZ25vc3RpY3MuU3RhY2tUcmFjZTtTeXN0ZW0uRGlhZ25vc3RpY3MuU3RhY2tGcmFtZTsyNzEzNjtTeXN0ZW0uRW52aXJvbm1lbnQ7ZGU0ZG90O1NpbXBsZUFzc2VtYmx5RXhwbG9yZXI7YmFiZWx2bTtzbW9rZXRlc3Q=");
			array[0] = (byte)(array[0] ^ 0x1Eu);
			array[1] = (byte)(array[1] ^ 0x5Au);
			array[2] = (byte)(array[2] ^ 0x47u);
			array[3] = (byte)(array[3] ^ 0x25u);
			array[4] = (byte)(array[4] ^ 0u);
			array[5] = (byte)(array[5] ^ 0x6Bu);
			array[6] = (byte)(array[6] ^ 0x51u);
			array[7] = (byte)(array[7] ^ 0xCBu);
			array[8] = (byte)(array[8] ^ 0x72u);
			array[9] = (byte)(array[9] ^ 0x4Bu);
			array[10] = (byte)(array[10] ^ 0x2Eu);
			array[11] = (byte)(array[11] ^ 0x47u);
			array[12] = (byte)(array[12] ^ 0x5Au);
			array[13] = (byte)(array[13] ^ 0xBu);
			array[14] = (byte)(array[14] ^ 0x76u);
			array[15] = (byte)(array[15] ^ 0x69u);
			array[16] = (byte)(array[16] ^ 0x26u);
			array[17] = (byte)(array[17] ^ 0xF0u);
			array[18] = (byte)(array[18] ^ 5u);
			array[19] = (byte)(array[19] ^ 0x68u);
			array[20] = (byte)(array[20] ^ 0x16u);
			array[21] = (byte)(array[21] ^ 0x3Du);
			array[22] = (byte)(array[22] ^ 0x2Bu);
			array[23] = (byte)(array[23] ^ 0xEEu);
			array[24] = (byte)(array[24] ^ 0x40u);
			array[25] = (byte)(array[25] ^ 0x37u);
			array[26] = (byte)(array[26] ^ 0x58u);
			array[27] = (byte)(array[27] ^ 0xCBu);
			array[28] = (byte)(array[28] ^ 0x4Fu);
			array[29] = (byte)(array[29] ^ 2u);
			array[53] = (byte)(array[53] ^ 0x2Du);
			array[31] = (byte)(array[31] ^ 0x7Bu);
			array[32] = (byte)(array[32] ^ 0x47u);
			array[33] = (byte)(array[33] ^ 5u);
			array[34] = (byte)(array[34] ^ 0x1Fu);
			array[35] = (byte)(array[35] ^ 0x38u);
			array[36] = (byte)(array[36] ^ 0x3Du);
			array[37] = (byte)(array[37] ^ 0x2Eu);
			array[38] = (byte)(array[38] ^ 0xFu);
			array[39] = (byte)(array[39] ^ 0x50u);
			array[40] = (byte)(array[40] ^ 0xBu);
			array[41] = (byte)(array[41] ^ 3u);
			array[42] = (byte)(array[42] ^ 0x75u);
			array[43] = (byte)(array[43] ^ 0x42u);
			array[44] = (byte)(array[44] ^ 0x67u);
			array[45] = (byte)(array[45] ^ 0x21u);
			array[46] = (byte)(array[46] ^ 0x5Au);
			array[47] = (byte)(array[47] ^ 0x8Du);
			array[48] = (byte)(array[48] ^ 0x2Du);
			array[49] = (byte)(array[49] ^ 0x2Bu);
			array[67] = (byte)(array[67] ^ 0x66u);
			string[] array2 = Encoding.UTF8.GetString(array).Split(new char[1] { ';' });
			MethodBuilder methodBuilder = typeBuilder_0.DefineMethod("?", MethodAttributes.Public | MethodAttributes.Static | MethodAttributes.HideBySig);
			Type type = Type.GetType(array2[17]);
			ConstructorInfo constructor = type.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);
			MethodInfo method = type.GetMethod(array2[0], BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[1] { typeof(int) }, null);
			MethodInfo method2 = Type.GetType(array2[18])!.GetMethod(array2[1], BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);
			MethodInfo method3 = typeof(MemberInfo).GetMethod(array2[2], BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);
			MethodInfo method4 = typeof(Type).GetMethod(array2[4], BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);
			MethodInfo method5 = typeof(string).GetMethod("IndexOf", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[2]
			{
				typeof(string),
				typeof(StringComparison)
			}, null);
			MethodInfo method6 = typeof(Environment).GetMethod(array2[8], BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[1] { typeof(int) }, null);
			MethodInfo method7 = typeof(StackTrace).GetMethod(array2[9], BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);
			MethodInfo method8 = typeof(Stream).GetMethod(array2[10], BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);
			ConstructorInfo constructor2 = typeof(BinaryReader).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[1] { typeof(Stream) }, null);
			ConstructorInfo constructor3 = typeof(Hashtable).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);
			MethodInfo method9 = typeof(BinaryReader).GetMethod(array2[11], BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);
			MethodInfo method10 = typeof(Hashtable).GetMethod(array2[12], BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[2]
			{
				typeof(object),
				typeof(object)
			}, null);
			MethodInfo method11 = typeof(Stream).GetMethod(array2[13], BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);
			MethodInfo method12 = typeof(AppDomain).GetMethod(array2[14], BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);
			MethodInfo method13 = typeof(AppDomain).GetMethod(array2[15], BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[2]
			{
				typeof(string),
				typeof(object)
			}, null);
			methodBuilder.SetReturnType(typeof(string));
			methodBuilder.SetParameters(typeof(Stream));
			methodBuilder.DefineParameter(1, ParameterAttributes.None, "a");
			ILGenerator iLGenerator = methodBuilder.GetILGenerator();
			iLGenerator.DeclareLocal(type);
			iLGenerator.DeclareLocal(typeof(long));
			iLGenerator.DeclareLocal(typeof(BinaryReader));
			iLGenerator.DeclareLocal(typeof(Hashtable));
			iLGenerator.DeclareLocal(typeof(string));
			iLGenerator.DeclareLocal(typeof(int));
			iLGenerator.DeclareLocal(typeof(Type));
			iLGenerator.DeclareLocal(typeof(string));
			Label label = iLGenerator.DefineLabel();
			Label label2 = iLGenerator.DefineLabel();
			Label label3 = iLGenerator.DefineLabel();
			Label label4 = iLGenerator.DefineLabel();
			Label label5 = iLGenerator.DefineLabel();
			Label label6 = iLGenerator.DefineLabel();
			Label label7 = iLGenerator.DefineLabel();
			iLGenerator.Emit(OpCodes.Newobj, constructor);
			iLGenerator.Emit(OpCodes.Stloc_0);
			iLGenerator.Emit(OpCodes.Ldc_I4_0);
			iLGenerator.Emit(OpCodes.Stloc_S, 5);
			iLGenerator.Emit(OpCodes.Br, label);
			iLGenerator.MarkLabel(label5);
			iLGenerator.Emit(OpCodes.Ldloc_0);
			iLGenerator.Emit(OpCodes.Ldloc_S, 5);
			iLGenerator.Emit(OpCodes.Callvirt, method);
			iLGenerator.Emit(OpCodes.Callvirt, method2);
			iLGenerator.Emit(OpCodes.Callvirt, method3);
			iLGenerator.Emit(OpCodes.Stloc_S, 6);
			iLGenerator.Emit(OpCodes.Ldloc_S, 6);
			iLGenerator.Emit(OpCodes.Brfalse, label2);
			iLGenerator.Emit(OpCodes.Ldloc_S, 6);
			iLGenerator.Emit(OpCodes.Callvirt, method4);
			iLGenerator.Emit(OpCodes.Stloc_S, 7);
			iLGenerator.Emit(OpCodes.Ldloc_S, 7);
			iLGenerator.Emit(OpCodes.Ldstr, array2[21]);
			iLGenerator.Emit(OpCodes.Ldc_I4_5);
			iLGenerator.Emit(OpCodes.Callvirt, method5);
			iLGenerator.Emit(OpCodes.Ldc_I4_M1);
			iLGenerator.Emit(OpCodes.Bne_Un, label3);
			iLGenerator.Emit(OpCodes.Ldloc_S, 7);
			iLGenerator.Emit(OpCodes.Ldstr, array2[22]);
			iLGenerator.Emit(OpCodes.Ldc_I4_5);
			iLGenerator.Emit(OpCodes.Callvirt, method5);
			iLGenerator.Emit(OpCodes.Ldc_I4_M1);
			iLGenerator.Emit(OpCodes.Bne_Un, label3);
			iLGenerator.Emit(OpCodes.Ldloc_S, 7);
			iLGenerator.Emit(OpCodes.Ldstr, array2[23]);
			iLGenerator.Emit(OpCodes.Ldc_I4_5);
			iLGenerator.Emit(OpCodes.Callvirt, method5);
			iLGenerator.Emit(OpCodes.Ldc_I4_M1);
			iLGenerator.Emit(OpCodes.Bne_Un, label3);
			iLGenerator.Emit(OpCodes.Ldloc_S, 7);
			iLGenerator.Emit(OpCodes.Ldstr, array2[24]);
			iLGenerator.Emit(OpCodes.Ldc_I4_5);
			iLGenerator.Emit(OpCodes.Callvirt, method5);
			iLGenerator.Emit(OpCodes.Ldc_I4_M1);
			iLGenerator.Emit(OpCodes.Beq, label4);
			iLGenerator.MarkLabel(label3);
			iLGenerator.Emit(OpCodes.Ldc_I4_0);
			iLGenerator.Emit(OpCodes.Call, method6);
			iLGenerator.MarkLabel(label4);
			iLGenerator.Emit(OpCodes.Ldloc_S, 5);
			iLGenerator.Emit(OpCodes.Ldc_I4_1);
			iLGenerator.Emit(OpCodes.Add);
			iLGenerator.Emit(OpCodes.Stloc_S, 5);
			iLGenerator.MarkLabel(label);
			iLGenerator.Emit(OpCodes.Ldloc_S, 5);
			iLGenerator.Emit(OpCodes.Ldloc_0);
			iLGenerator.Emit(OpCodes.Callvirt, method7);
			iLGenerator.Emit(OpCodes.Blt, label5);
			iLGenerator.MarkLabel(label2);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Callvirt, method8);
			iLGenerator.Emit(OpCodes.Stloc_1);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Newobj, constructor2);
			iLGenerator.Emit(OpCodes.Stloc_2);
			iLGenerator.Emit(OpCodes.Newobj, constructor3);
			iLGenerator.Emit(OpCodes.Stloc_3);
			iLGenerator.Emit(OpCodes.Ldloc_2);
			iLGenerator.Emit(OpCodes.Callvirt, method9);
			iLGenerator.Emit(OpCodes.Stloc_S, 4);
			iLGenerator.Emit(OpCodes.Ldloc_3);
			iLGenerator.Emit(OpCodes.Ldc_I4_M1);
			iLGenerator.Emit(OpCodes.Box, typeof(int));
			iLGenerator.Emit(OpCodes.Ldloc_S, 4);
			iLGenerator.Emit(OpCodes.Callvirt, method10);
			iLGenerator.Emit(OpCodes.Br, label6);
			iLGenerator.MarkLabel(label7);
			iLGenerator.Emit(OpCodes.Ldloc_3);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Callvirt, method11);
			iLGenerator.Emit(OpCodes.Conv_I4);
			iLGenerator.Emit(OpCodes.Ldc_I4, 62);
			iLGenerator.Emit(OpCodes.Add);
			iLGenerator.Emit(arg: int.Parse(array2[19]), opcode: OpCodes.Ldc_I4);
			iLGenerator.Emit(OpCodes.Xor);
			iLGenerator.Emit(OpCodes.Box, typeof(int));
			iLGenerator.Emit(OpCodes.Ldloc_2);
			iLGenerator.Emit(OpCodes.Callvirt, method9);
			iLGenerator.Emit(OpCodes.Callvirt, method10);
			iLGenerator.MarkLabel(label6);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Callvirt, method11);
			iLGenerator.Emit(OpCodes.Ldloc_1);
			iLGenerator.Emit(OpCodes.Blt, label7);
			iLGenerator.Emit(OpCodes.Call, method12);
			iLGenerator.Emit(OpCodes.Ldloc_S, 4);
			iLGenerator.Emit(OpCodes.Ldloc_3);
			iLGenerator.Emit(OpCodes.Callvirt, method13);
			iLGenerator.Emit(OpCodes.Ldloc_S, 4);
			iLGenerator.Emit(OpCodes.Ret);
			return methodBuilder;
		}

		public string method_1(Stream stream_0)
		{
			TypeBuilder typeBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(new AssemblyName
			{
				Name = "?"
			}, AssemblyBuilderAccess.Run).DefineDynamicModule("?").DefineType("?", TypeAttributes.NotPublic);
			method_0(typeBuilder);
			return (string)typeBuilder.CreateType()!.InvokeMember("?", BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, new object[1] { stream_0 });
		}
	}

	private static string string_0;

	private static Delegate2 delegate2_0;

	static Class41()
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		delegate2_0 = smethod_1;
		Stream stream_ = Class47.smethod_0(executingAssembly.GetManifestResourceStream(delegate2_0(0)));
		string_0 = new Class42().method_1(stream_);
	}

	public static string smethod_0(int int_0)
	{
		return (string)((Hashtable)AppDomain.CurrentDomain.GetData(string_0))[int_0];
	}

	public static string smethod_1(int int_0)
	{
		char[] array = "\u00171\u00188".ToCharArray();
		int num = array.Length;
		while (--num >= 0)
		{
			array[num] = (char)(array[num] ^ 0x7Cu ^ (uint)int_0);
		}
		return new string(array);
	}
}
