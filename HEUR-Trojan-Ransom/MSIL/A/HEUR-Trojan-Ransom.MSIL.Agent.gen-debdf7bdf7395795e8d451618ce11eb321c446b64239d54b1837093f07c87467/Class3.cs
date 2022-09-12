using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

internal class Class3 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return cb1fcba5.byte_54;
	}

	private static object smethod_0(Class49 class49_0, Type type_0, ref uint uint_0)
	{
		Struct2 @struct = class49_0.ec45936d.a59d7f30(uint_0--);
		if (Type.GetTypeCode(type_0) == TypeCode.String && @struct.method_6() == null)
		{
			return class49_0.class2_0.c73a3276().method_3(@struct.method_2());
		}
		return @struct.method_8(type_0);
	}

	private unsafe static da5e0024 a5d486ed(Class49 class49_0, Type type_0, ref uint uint_0)
	{
		Struct2 struct2_ = class49_0.ec45936d.a59d7f30(uint_0);
		if (type_0.IsByRef)
		{
			uint_0--;
			type_0 = type_0.GetElementType();
			if (struct2_.method_6() is Pointer)
			{
				void* pVoid_ = Pointer.Unbox(struct2_.method_6());
				return new cac74d33(pVoid_);
			}
			if (struct2_.method_6() is da5e0024)
			{
				return (da5e0024)struct2_.method_6();
			}
			return new cac74d33((void*)struct2_.method_0());
		}
		if (Type.GetTypeCode(type_0) == TypeCode.String && struct2_.method_6() == null)
		{
			struct2_.method_7(class49_0.class2_0.c73a3276().method_3(struct2_.method_2()));
			class49_0.ec45936d.d1cb88cf(uint_0, struct2_);
		}
		return new Class48(uint_0--);
	}

	private static bool smethod_1(Class49 class49_0, uint uint_0, MethodBase methodBase_0, bool bool_0)
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

	public void imethod_1(Class49 class49_0, out Enum1 enum1_0)
	{
		uint uint_ = class49_0.struct2_0[cb1fcba5.byte_8].method_2();
		Struct2 @struct = class49_0.ec45936d.a59d7f30(uint_--);
		uint uint_2 = @struct.method_2() & 0x3FFFFFFFu;
		byte b = (byte)(@struct.method_2() >> 30);
		MethodBase methodBase_ = (MethodBase)class49_0.class2_0.c73a3276().a9b0159f(uint_2);
		bool flag;
		if (!(flag = b == cb1fcba5.e0e4c18f))
		{
			flag = smethod_1(class49_0, uint_, methodBase_, b == cb1fcba5.byte_65);
		}
		if (flag)
		{
			method_0(class49_0, methodBase_, b, ref uint_, out enum1_0);
		}
		else
		{
			eff267a7(class49_0, methodBase_, b, ref uint_, out enum1_0);
		}
	}

	private void eff267a7(Class49 class49_0, MethodBase methodBase_0, byte byte_0, ref uint uint_0, out Enum1 enum1_0)
	{
		uint uint_ = uint_0;
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		object obj = null;
		object[] array = new object[parameters.Length];
		if (byte_0 == cb1fcba5.byte_64 && methodBase_0.IsVirtual)
		{
			int num = ((!methodBase_0.IsStatic) ? 1 : 0);
			array = new object[parameters.Length + num];
			for (int num2 = parameters.Length - 1; num2 >= 0; num2--)
			{
				array[num2 + num] = smethod_0(class49_0, parameters[num2].ParameterType, ref uint_0);
			}
			if (!methodBase_0.IsStatic)
			{
				array[0] = smethod_0(class49_0, methodBase_0.DeclaringType, ref uint_0);
			}
			methodBase_0 = b9c094b2.ebd76c69(methodBase_0);
		}
		else
		{
			array = new object[parameters.Length];
			for (int num3 = parameters.Length - 1; num3 >= 0; num3--)
			{
				array[num3] = smethod_0(class49_0, parameters[num3].ParameterType, ref uint_0);
			}
			if (!methodBase_0.IsStatic && byte_0 != cb1fcba5.byte_65)
			{
				obj = smethod_0(class49_0, methodBase_0.DeclaringType, ref uint_0);
				if (obj != null && !methodBase_0.DeclaringType!.IsInstanceOfType(obj))
				{
					method_0(class49_0, methodBase_0, byte_0, ref uint_, out enum1_0);
					return;
				}
			}
		}
		object object_;
		if (byte_0 == cb1fcba5.byte_65)
		{
			try
			{
				object_ = ((ConstructorInfo)methodBase_0).Invoke(array);
			}
			catch (TargetInvocationException ex)
			{
				Class53.a30f0ef5(ex.InnerException, null);
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
				Class52.bf75e195(type_0: (array[0] != null) ? array[0].GetType() : type.GetElementType(), array_0: (Array)obj, int_0: (int)array[1], object_0: array[0], type_1: type.GetElementType());
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
					Class50.a02660b5(class49_0, ex2.InnerException);
					throw;
				}
			}
		}
		if (methodBase_0 is MethodInfo && (object)((MethodInfo)methodBase_0).ReturnType != typeof(void))
		{
			class49_0.ec45936d.d1cb88cf(++uint_0, Struct2.a5dd3349(object_, ((MethodInfo)methodBase_0).ReturnType));
		}
		else if (byte_0 == cb1fcba5.byte_65)
		{
			class49_0.ec45936d.d1cb88cf(++uint_0, Struct2.a5dd3349(object_, methodBase_0.DeclaringType));
		}
		class49_0.ec45936d.method_0(uint_0);
		class49_0.struct2_0[cb1fcba5.byte_8].c85fac38(uint_0);
		enum1_0 = (Enum1)0;
	}

	private void method_0(Class49 class49_0, MethodBase methodBase_0, byte byte_0, ref uint uint_0, out Enum1 enum1_0)
	{
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		int num = parameters.Length;
		if (!methodBase_0.IsStatic && byte_0 != cb1fcba5.byte_65)
		{
			num++;
		}
		Type type = null;
		if (byte_0 == cb1fcba5.e0e4c18f)
		{
			type = (Type)class49_0.class2_0.c73a3276().a9b0159f(class49_0.ec45936d.a59d7f30(uint_0--).method_2());
		}
		if (!methodBase_0.IsStatic && byte_0 != cb1fcba5.byte_65)
		{
			_ = 1;
		}
		else
			_ = 0;
		da5e0024[] array = new da5e0024[num];
		Type[] array2 = new Type[num];
		for (int num2 = num - 1; num2 >= 0; num2--)
		{
			Type type2;
			if (!methodBase_0.IsStatic && byte_0 != cb1fcba5.byte_65)
			{
				if (num2 == 0)
				{
					if (!methodBase_0.IsStatic)
					{
						Struct2 @struct = class49_0.ec45936d.a59d7f30(uint_0);
						if (@struct.method_6() is ValueType && !methodBase_0.DeclaringType!.IsValueType)
						{
							type = @struct.method_6().GetType();
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
			array[num2] = a5d486ed(class49_0, type2, ref uint_0);
			if (type2.IsByRef)
			{
				type2 = type2.GetElementType();
			}
			array2[num2] = type2;
		}
		OpCode opCode_;
		Type type3;
		if (byte_0 == cb1fcba5.byte_64)
		{
			opCode_ = OpCodes.Call;
			type3 = ((methodBase_0 is MethodInfo) ? ((MethodInfo)methodBase_0).ReturnType : typeof(void));
		}
		else if (byte_0 == cb1fcba5.c2619a95 || byte_0 == cb1fcba5.e0e4c18f)
		{
			opCode_ = OpCodes.Callvirt;
			type3 = ((methodBase_0 is MethodInfo) ? ((MethodInfo)methodBase_0).ReturnType : typeof(void));
		}
		else
		{
			if (byte_0 != cb1fcba5.byte_65)
			{
				throw new InvalidProgramException();
			}
			opCode_ = OpCodes.Newobj;
			type3 = methodBase_0.DeclaringType;
		}
		b9c094b2.Delegate1 @delegate = b9c094b2.a1d24ab4(methodBase_0, opCode_, type);
		object object_ = @delegate(class49_0, array, array2);
		if ((object)type3 != typeof(void))
		{
			class49_0.ec45936d.d1cb88cf(++uint_0, Struct2.a5dd3349(object_, type3));
		}
		else if (byte_0 == cb1fcba5.byte_65)
		{
			class49_0.ec45936d.d1cb88cf(++uint_0, Struct2.a5dd3349(object_, type3));
		}
		class49_0.ec45936d.method_0(uint_0);
		class49_0.struct2_0[cb1fcba5.byte_8].c85fac38(uint_0);
		enum1_0 = (Enum1)0;
	}
}
