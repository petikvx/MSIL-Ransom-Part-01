using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

namespace ns0;

internal class Class9
{
	public sealed class Class10
	{
		private static OpCode[] opCode_0;

		private static OpCode[] opCode_1;

		private int int_0;

		private byte[] byte_0;

		private DynamicILInfo dynamicILInfo_0;

		private Module module_0;

		private Type[] type_0;

		private Type[] type_1;

		static Class10()
		{
			opCode_0 = new OpCode[256];
			opCode_1 = new OpCode[256];
			FieldInfo[] fields = typeof(OpCodes).GetFields(BindingFlags.Static | BindingFlags.Public);
			foreach (FieldInfo fieldInfo in fields)
			{
				OpCode opCode = (OpCode)fieldInfo.GetValue(null);
				ushort num = (ushort)opCode.Value;
				if (num < 256)
				{
					opCode_0[num] = opCode;
				}
				else if ((num & 0xFF00) == 65024)
				{
					opCode_1[num & 0xFF] = opCode;
				}
			}
		}

		public Class10(MethodBase methodBase_0, byte[] byte_1, DynamicILInfo dynamicILInfo_1)
		{
			dynamicILInfo_0 = dynamicILInfo_1;
			byte_0 = byte_1;
			int_0 = 0;
			module_0 = methodBase_0.Module;
			type_0 = ((methodBase_0 is ConstructorInfo) ? null : methodBase_0.GetGenericArguments());
			type_1 = (((object)methodBase_0.DeclaringType == null) ? null : methodBase_0.DeclaringType!.GetGenericArguments());
		}

		internal void method_0()
		{
			while (int_0 < byte_0.Length)
			{
				method_1();
			}
		}

		private object method_1()
		{
			int num = int_0;
			OpCode nop = OpCodes.Nop;
			int num2 = 0;
			byte b = method_3();
			if (b != 254)
			{
				nop = opCode_0[b];
			}
			else
			{
				b = method_3();
				nop = opCode_1[b];
			}
			switch (nop.OperandType)
			{
			case OperandType.InlineBrTarget:
				method_2(4);
				return null;
			case OperandType.InlineField:
			{
				num2 = method_4();
				FieldInfo fieldInfo2 = module_0.ResolveField(num2, type_1, type_0);
				method_5(dynamicILInfo_0.GetTokenFor(fieldInfo2.FieldHandle), num + nop.Size);
				return null;
			}
			case OperandType.InlineI:
				method_2(4);
				return null;
			case OperandType.InlineI8:
				method_2(8);
				return null;
			case OperandType.InlineMethod:
			{
				num2 = method_4();
				MethodBase methodBase2 = module_0.ResolveMethod(num2, type_1, type_0);
				method_5(dynamicILInfo_0.GetTokenFor(methodBase2.MethodHandle, methodBase2.DeclaringType!.TypeHandle), num + nop.Size);
				return null;
			}
			case OperandType.InlineNone:
				return null;
			case OperandType.InlineR:
				method_2(8);
				return null;
			default:
				throw new BadImageFormatException("unexpected OperandType " + nop.OperandType);
			case OperandType.InlineSig:
				num2 = method_4();
				method_5(dynamicILInfo_0.GetTokenFor(module_0.ResolveSignature(num2)), num + nop.Size);
				return null;
			case OperandType.InlineString:
				num2 = method_4();
				method_5(dynamicILInfo_0.GetTokenFor(module_0.ResolveString(num2)), num + nop.Size);
				return null;
			case OperandType.InlineSwitch:
			{
				int num3 = method_4();
				method_2(num3 * 4);
				return null;
			}
			case OperandType.InlineTok:
			{
				num2 = method_4();
				MemberInfo memberInfo = module_0.ResolveMember(num2, type_1, type_0);
				if (memberInfo.MemberType != MemberTypes.TypeInfo && memberInfo.MemberType != MemberTypes.NestedType)
				{
					if (memberInfo.MemberType != MemberTypes.Method && memberInfo.MemberType != MemberTypes.Constructor)
					{
						if (memberInfo.MemberType == MemberTypes.Field)
						{
							FieldInfo fieldInfo = memberInfo as FieldInfo;
							num2 = dynamicILInfo_0.GetTokenFor(fieldInfo.FieldHandle);
						}
					}
					else
					{
						MethodBase methodBase = memberInfo as MethodBase;
						num2 = dynamicILInfo_0.GetTokenFor(methodBase.MethodHandle, methodBase.DeclaringType!.TypeHandle);
					}
				}
				else
				{
					Type type2 = memberInfo as Type;
					num2 = dynamicILInfo_0.GetTokenFor(type2.TypeHandle);
				}
				method_5(num2, num + nop.Size);
				return null;
			}
			case OperandType.InlineType:
			{
				num2 = method_4();
				Type type = module_0.ResolveType(num2, type_1, type_0);
				method_5(dynamicILInfo_0.GetTokenFor(type.TypeHandle), num + nop.Size);
				return null;
			}
			case OperandType.InlineVar:
				method_2(2);
				return null;
			case OperandType.ShortInlineBrTarget:
				method_2(1);
				return null;
			case OperandType.ShortInlineI:
				method_2(1);
				return null;
			case OperandType.ShortInlineR:
				method_2(4);
				return null;
			case OperandType.ShortInlineVar:
				method_2(1);
				return null;
			}
		}

		private void method_2(int int_1)
		{
			int_0 += int_1;
		}

		private byte method_3()
		{
			return byte_0[int_0++];
		}

		private int method_4()
		{
			int startIndex = int_0;
			int_0 += 4;
			return BitConverter.ToInt32(byte_0, startIndex);
		}

		private void method_5(int int_1, int int_2)
		{
			byte_0[int_2++] = (byte)int_1;
			byte_0[int_2++] = (byte)(int_1 >> 8);
			byte_0[int_2++] = (byte)(int_1 >> 16);
			byte_0[int_2++] = (byte)(int_1 >> 24);
		}
	}

	internal static readonly byte[] byte_0;

	internal static readonly Dictionary<int, int> dictionary_0;

	private static readonly ModuleHandle moduleHandle_0;

	internal readonly int int_0;

	static Class9()
	{
		if (byte_0 == null)
		{
			string s = "UGV0eWEgYW5kIEdvbGRlbkV5ZSBCVUlMREVSKg==";
			byte[] array = Convert.FromBase64String(s);
			s = Encoding.UTF8.GetString(array, 0, array.Length);
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(s);
			byte_0 = Class5.smethod_3(97L, manifestResourceStream);
			dictionary_0 = new Dictionary<int, int>();
			using BinaryReader binaryReader = new BinaryReader(new MemoryStream(byte_0, writable: false));
			int num = binaryReader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				int key = binaryReader.ReadInt32();
				int value = binaryReader.ReadInt32();
				dictionary_0[key] = value;
			}
		}
		if ((object)typeof(MulticastDelegate) != null)
		{
			moduleHandle_0 = Assembly.GetExecutingAssembly().GetModules()[0].ModuleHandle;
		}
	}

	internal static void smethod_0(int int_1, int int_2, int int_3)
	{
		Type typeFromHandle;
		MethodBase methodBase;
		try
		{
			typeFromHandle = Type.GetTypeFromHandle(moduleHandle_0.ResolveTypeHandle(int_1));
			object methodFromHandle = MethodBase.GetMethodFromHandle(moduleHandle_0.ResolveMethodHandle(int_2), moduleHandle_0.ResolveTypeHandle(int_3));
			methodBase = (MethodBase)methodFromHandle;
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
				DynamicMethod dynamicMethod = null;
				MethodBody methodBody = methodBase.GetMethodBody();
				Type[] parameterTypes = smethod_5(methodBase);
				dynamicMethod = new DynamicMethod(methodBase.DeclaringType!.FullName + "." + methodBase.Name + "_Encrypted$", (methodBase is ConstructorInfo) ? null : ((MethodInfo)methodBase).ReturnType, parameterTypes, methodBase.DeclaringType, skipVisibility: true);
				dictionary_0.TryGetValue(int_1, out var value);
				DynamicILInfo dynamicILInfo = dynamicMethod.GetDynamicILInfo();
				smethod_2(methodBody, dynamicILInfo);
				smethod_1(ref value, methodBase, dynamicILInfo);
				smethod_3(ref value, dynamicILInfo);
				Delegate value2 = dynamicMethod.CreateDelegate(typeFromHandle);
				fieldInfo.SetValue(null, value2);
			}
			catch (Exception)
			{
			}
		}
	}

	private static void smethod_1(ref int int_1, MethodBase methodBase_0, DynamicILInfo dynamicILInfo_0)
	{
		int maxStackSize = BitConverter.ToInt32(byte_0, int_1);
		int_1 += 4;
		int num = BitConverter.ToInt32(byte_0, int_1);
		int_1 += 4;
		byte[] array = new byte[num];
		Buffer.BlockCopy(byte_0, int_1, array, 0, num);
		Class10 @class = new Class10(methodBase_0, array, dynamicILInfo_0);
		@class.method_0();
		dynamicILInfo_0.SetCode(array, maxStackSize);
		int_1 += num;
	}

	private static void smethod_2(MethodBody methodBody_0, DynamicILInfo dynamicILInfo_0)
	{
		SignatureHelper localVarSigHelper = SignatureHelper.GetLocalVarSigHelper();
		foreach (LocalVariableInfo localVariable in methodBody_0.LocalVariables)
		{
			localVarSigHelper.AddArgument(localVariable.LocalType, localVariable.IsPinned);
		}
		dynamicILInfo_0.SetLocalSignature(localVarSigHelper.GetSignature());
	}

	private static void smethod_3(ref int int_1, DynamicILInfo dynamicILInfo_0)
	{
		int num = BitConverter.ToInt32(byte_0, int_1);
		int_1 += 4;
		if (num == 0)
		{
			return;
		}
		byte[] array = new byte[num];
		Buffer.BlockCopy(byte_0, int_1, array, 0, num);
		int num2 = 4;
		int num3 = (num - 4) / 24;
		for (int i = 0; i < num3; i++)
		{
			ExceptionHandlingClauseOptions exceptionHandlingClauseOptions = (ExceptionHandlingClauseOptions)BitConverter.ToInt32(array, num2);
			num2 += 20;
			switch (exceptionHandlingClauseOptions)
			{
			case ExceptionHandlingClauseOptions.Clause:
			{
				RuntimeTypeHandle type = moduleHandle_0.ResolveTypeHandle(BitConverter.ToInt32(array, num2));
				int tokenFor = dynamicILInfo_0.GetTokenFor(type);
				smethod_4(tokenFor, num2, array);
				break;
			}
			case ExceptionHandlingClauseOptions.Fault:
				throw new NotSupportedException("dynamic method does not support fault clause");
			}
			num2 += 4;
		}
		dynamicILInfo_0.SetExceptions(array);
	}

	public static void smethod_4(int int_1, int int_2, byte[] byte_1)
	{
		byte_1[int_2++] = (byte)int_1;
		byte_1[int_2++] = (byte)(int_1 >> 8);
		byte_1[int_2++] = (byte)(int_1 >> 16);
		byte_1[int_2++] = (byte)(int_1 >> 24);
	}

	private static Type[] smethod_5(MethodBase methodBase_0)
	{
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		int num = parameters.Length;
		if (!methodBase_0.IsStatic)
		{
			num++;
		}
		Type[] array = new Type[num];
		int num2 = 0;
		if (!methodBase_0.IsStatic)
		{
			if (methodBase_0.DeclaringType!.IsValueType)
			{
				array[0] = methodBase_0.DeclaringType!.MakeByRefType();
			}
			else
			{
				array[0] = methodBase_0.DeclaringType;
			}
			num2++;
		}
		int num3 = 0;
		while (num3 < parameters.Length)
		{
			array[num2] = parameters[num3].ParameterType;
			num3++;
			num2++;
		}
		return array;
	}
}
