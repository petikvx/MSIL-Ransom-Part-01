using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

internal class f0672ab6 : d88be11e
{
	[SpecialName]
	public byte b4b1262()
	{
		return b13312b0.byte_62;
	}

	private static object b876a29d(Class58 class58_0, Type type_0, ref uint uint_0)
	{
		facef383 facef384 = class58_0.c73f45d8.a9bb6dff(uint_0--);
		if (Type.GetTypeCode(type_0) == TypeCode.String && facef384.method_8() == null)
		{
			return class58_0.a3d704e3.method_0().method_3(facef384.df1ed028());
		}
		return facef384.f3c5123d(type_0);
	}

	private unsafe static Interface0 c094c358(Class58 class58_0, Type type_0, ref uint uint_0)
	{
		facef383 facef383_ = class58_0.c73f45d8.a9bb6dff(uint_0);
		if (type_0.IsByRef)
		{
			uint_0--;
			type_0 = type_0.GetElementType();
			if (facef383_.method_8() is Pointer)
			{
				void* pVoid_ = Pointer.Unbox(facef383_.method_8());
				return new Class56(pVoid_);
			}
			if (facef383_.method_8() is Interface0)
			{
				return (Interface0)facef383_.method_8();
			}
			return new Class56((void*)facef383_.method_0());
		}
		if (Type.GetTypeCode(type_0) == TypeCode.String && facef383_.method_8() == null)
		{
			facef383_.method_9(class58_0.a3d704e3.method_0().method_3(facef383_.df1ed028()));
			class58_0.c73f45d8.method_0(uint_0, facef383_);
		}
		return new dc3c6d47(uint_0--);
	}

	private static bool smethod_0(Class58 class58_0, uint uint_0, MethodBase methodBase_0, bool bool_0)
	{
		if (!bool_0 && !methodBase_0.IsStatic && methodBase_0.DeclaringType!.IsValueType)
		{
			return true;
		}
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		int num = 0;
		while (true)
		{
			if (num < parameters.Length)
			{
				ParameterInfo parameterInfo = parameters[num];
				if (parameterInfo.ParameterType.IsByRef)
				{
					break;
				}
				num++;
				continue;
			}
			if (methodBase_0 is MethodInfo && ((MethodInfo)methodBase_0).ReturnType.IsByRef)
			{
				return true;
			}
			return false;
		}
		return true;
	}

	public void df3f437a(Class58 class58_0, out Enum0 enum0_0)
	{
		uint uint_ = class58_0.a6890f1d[b13312b0.byte_7].df1ed028();
		facef383 facef384 = class58_0.c73f45d8.a9bb6dff(uint_--);
		uint uint_2 = facef384.df1ed028() & 0x3FFFFFFFu;
		byte b = (byte)(facef384.df1ed028() >> 30);
		MethodBase methodBase_ = (MethodBase)class58_0.a3d704e3.method_0().method_2(uint_2);
		bool flag;
		if (!(flag = b == b13312b0.byte_76))
		{
			flag = smethod_0(class58_0, uint_, methodBase_, b == b13312b0.byte_75);
		}
		if (flag)
		{
			method_1(class58_0, methodBase_, b, ref uint_, out enum0_0);
		}
		else
		{
			method_0(class58_0, methodBase_, b, ref uint_, out enum0_0);
		}
	}

	private void method_0(Class58 class58_0, MethodBase methodBase_0, byte byte_0, ref uint uint_0, out Enum0 enum0_0)
	{
		uint uint_ = uint_0;
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		object obj = null;
		object[] array = new object[parameters.Length];
		if (byte_0 == b13312b0.fa69f445 && methodBase_0.IsVirtual)
		{
			int num = ((!methodBase_0.IsStatic) ? 1 : 0);
			array = new object[parameters.Length + num];
			for (int num2 = parameters.Length - 1; num2 >= 0; num2--)
			{
				array[num2 + num] = b876a29d(class58_0, parameters[num2].ParameterType, ref uint_0);
			}
			if (!methodBase_0.IsStatic)
			{
				array[0] = b876a29d(class58_0, methodBase_0.DeclaringType, ref uint_0);
			}
			methodBase_0 = Class62.a11b8ba4(methodBase_0);
		}
		else
		{
			array = new object[parameters.Length];
			for (int num3 = parameters.Length - 1; num3 >= 0; num3--)
			{
				array[num3] = b876a29d(class58_0, parameters[num3].ParameterType, ref uint_0);
			}
			if (!methodBase_0.IsStatic && byte_0 != b13312b0.byte_75)
			{
				obj = b876a29d(class58_0, methodBase_0.DeclaringType, ref uint_0);
				if (obj != null && !methodBase_0.DeclaringType!.IsInstanceOfType(obj))
				{
					method_1(class58_0, methodBase_0, byte_0, ref uint_, out enum0_0);
					return;
				}
			}
		}
		object object_;
		if (byte_0 == b13312b0.byte_75)
		{
			try
			{
				object_ = ((ConstructorInfo)methodBase_0).Invoke(array);
			}
			catch (TargetInvocationException ex)
			{
				aad18bb.add6a9c0(ex.InnerException, null);
				throw;
			}
		}
		else
		{
			if (!methodBase_0.IsStatic && obj == null)
			{
				throw new NullReferenceException();
			}
			Type type;
			if (obj != null && (type = obj.GetType()).IsArray && methodBase_0.Name == "SetValue")
			{
				Class61.c076b3e0(type_0: (array[0] != null) ? array[0].GetType() : type.GetElementType(), array_0: (Array)obj, int_0: (int)array[1], object_0: array[0], type_1: type.GetElementType());
				object_ = null;
			}
			else
			{
				try
				{
					object_ = methodBase_0.Invoke(obj, array);
				}
				catch (TargetInvocationException ex2)
				{
					d4f30da1.smethod_2(class58_0, ex2.InnerException);
					throw;
				}
			}
		}
		if (methodBase_0 is MethodInfo && (object)((MethodInfo)methodBase_0).ReturnType != typeof(void))
		{
			class58_0.c73f45d8.method_0(++uint_0, facef383.b3e8ed04(object_, ((MethodInfo)methodBase_0).ReturnType));
		}
		else if (byte_0 == b13312b0.byte_75)
		{
			class58_0.c73f45d8.method_0(++uint_0, facef383.b3e8ed04(object_, methodBase_0.DeclaringType));
		}
		class58_0.c73f45d8.a85b6a89(uint_0);
		class58_0.a6890f1d[b13312b0.byte_7].method_2(uint_0);
		enum0_0 = (Enum0)0;
	}

	private void method_1(Class58 class58_0, MethodBase methodBase_0, byte byte_0, ref uint uint_0, out Enum0 enum0_0)
	{
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		int num = parameters.Length;
		if (!methodBase_0.IsStatic && byte_0 != b13312b0.byte_75)
		{
			num++;
		}
		Type type = null;
		if (byte_0 == b13312b0.byte_76)
		{
			type = (Type)class58_0.a3d704e3.method_0().method_2(class58_0.c73f45d8.a9bb6dff(uint_0--).df1ed028());
		}
		if (!methodBase_0.IsStatic && byte_0 != b13312b0.byte_75)
		{
			_ = 1;
		}
		else
			_ = 0;
		Interface0[] array = new Interface0[num];
		Type[] array2 = new Type[num];
		for (int num2 = num - 1; num2 >= 0; num2--)
		{
			Type type2;
			if (!methodBase_0.IsStatic && byte_0 != b13312b0.byte_75)
			{
				if (num2 == 0)
				{
					if (!methodBase_0.IsStatic)
					{
						facef383 facef384 = class58_0.c73f45d8.a9bb6dff(uint_0);
						if (facef384.method_8() is ValueType && !methodBase_0.DeclaringType!.IsValueType)
						{
							type = facef384.method_8().GetType();
						}
					}
					type2 = (((object)type != null) ? type.MakeByRefType() : ((!methodBase_0.DeclaringType!.IsValueType) ? methodBase_0.DeclaringType : methodBase_0.DeclaringType!.MakeByRefType()));
				}
				else
				{
					type2 = parameters[num2 - 1].ParameterType;
				}
			}
			else
			{
				type2 = parameters[num2].ParameterType;
			}
			array[num2] = c094c358(class58_0, type2, ref uint_0);
			if (type2.IsByRef)
			{
				type2 = type2.GetElementType();
			}
			array2[num2] = type2;
		}
		OpCode opCode_;
		Type type3;
		if (byte_0 == b13312b0.fa69f445)
		{
			opCode_ = OpCodes.Call;
			type3 = ((methodBase_0 is MethodInfo) ? ((MethodInfo)methodBase_0).ReturnType : typeof(void));
		}
		else if (byte_0 == b13312b0.byte_74 || byte_0 == b13312b0.byte_76)
		{
			opCode_ = OpCodes.Callvirt;
			type3 = ((methodBase_0 is MethodInfo) ? ((MethodInfo)methodBase_0).ReturnType : typeof(void));
		}
		else
		{
			if (byte_0 != b13312b0.byte_75)
			{
				throw new InvalidProgramException();
			}
			opCode_ = OpCodes.Newobj;
			type3 = methodBase_0.DeclaringType;
		}
		Class62.b2a5fcc b2a5fcc = Class62.smethod_0(methodBase_0, opCode_, type);
		object object_ = b2a5fcc(class58_0, array, array2);
		if ((object)type3 != typeof(void))
		{
			class58_0.c73f45d8.method_0(++uint_0, facef383.b3e8ed04(object_, type3));
		}
		else if (byte_0 == b13312b0.byte_75)
		{
			class58_0.c73f45d8.method_0(++uint_0, facef383.b3e8ed04(object_, type3));
		}
		class58_0.c73f45d8.a85b6a89(uint_0);
		class58_0.a6890f1d[b13312b0.byte_7].method_2(uint_0);
		enum0_0 = (Enum0)0;
	}
}
