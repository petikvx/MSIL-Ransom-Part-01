using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

internal class Class6 : c955c655
{
	[SpecialName]
	public byte imethod_0()
	{
		return fb3c043f.byte_54;
	}

	private static object eb172308(fdc40966 fdc40966_0, Type type_0, ref uint uint_0)
	{
		Struct3 @struct = fdc40966_0.class58_0.method_0(uint_0--);
		if (Type.GetTypeCode(type_0) == TypeCode.String && @struct.c9550f69() == null)
		{
			return fdc40966_0.class2_0.method_0().method_4(@struct.method_1());
		}
		return @struct.e3ce4628(type_0);
	}

	private unsafe static Interface1 d058eac7(fdc40966 fdc40966_0, Type type_0, ref uint uint_0)
	{
		Struct3 struct3_ = fdc40966_0.class58_0.method_0(uint_0);
		if (type_0.IsByRef)
		{
			uint_0--;
			type_0 = type_0.GetElementType();
			if (struct3_.c9550f69() is Pointer)
			{
				void* pVoid_ = Pointer.Unbox(struct3_.c9550f69());
				return new a764e9fd(pVoid_);
			}
			if (struct3_.c9550f69() is Interface1)
			{
				return (Interface1)struct3_.c9550f69();
			}
			return new a764e9fd((void*)struct3_.ba535d1d());
		}
		if (Type.GetTypeCode(type_0) == TypeCode.String && struct3_.c9550f69() == null)
		{
			struct3_.db2591b4(fdc40966_0.class2_0.method_0().method_4(struct3_.method_1()));
			fdc40966_0.class58_0.b53f41f9(uint_0, struct3_);
		}
		return new dcd2092a(uint_0--);
	}

	private static bool smethod_0(fdc40966 fdc40966_0, uint uint_0, MethodBase methodBase_0, bool bool_0)
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

	public void imethod_1(fdc40966 fdc40966_0, out Enum0 enum0_0)
	{
		uint uint_ = fdc40966_0.struct3_0[fb3c043f.c55b5391].method_1();
		Struct3 @struct = fdc40966_0.class58_0.method_0(uint_--);
		uint uint_2 = @struct.method_1() & 0x3FFFFFFFu;
		byte b = (byte)(@struct.method_1() >> 30);
		MethodBase methodBase_ = (MethodBase)fdc40966_0.class2_0.method_0().method_3(uint_2);
		bool flag;
		if (!(flag = b == fb3c043f.byte_71))
		{
			flag = smethod_0(fdc40966_0, uint_, methodBase_, b == fb3c043f.byte_70);
		}
		if (flag)
		{
			method_1(fdc40966_0, methodBase_, b, ref uint_, out enum0_0);
		}
		else
		{
			method_0(fdc40966_0, methodBase_, b, ref uint_, out enum0_0);
		}
	}

	private void method_0(fdc40966 fdc40966_0, MethodBase methodBase_0, byte byte_0, ref uint uint_0, out Enum0 enum0_0)
	{
		uint uint_ = uint_0;
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		object obj = null;
		object[] array = new object[parameters.Length];
		if (byte_0 == fb3c043f.af27f690 && methodBase_0.IsVirtual)
		{
			int num = ((!methodBase_0.IsStatic) ? 1 : 0);
			array = new object[parameters.Length + num];
			for (int num2 = parameters.Length - 1; num2 >= 0; num2--)
			{
				array[num2 + num] = eb172308(fdc40966_0, parameters[num2].ParameterType, ref uint_0);
			}
			if (!methodBase_0.IsStatic)
			{
				array[0] = eb172308(fdc40966_0, methodBase_0.DeclaringType, ref uint_0);
			}
			methodBase_0 = fb3b0854.smethod_0(methodBase_0);
		}
		else
		{
			array = new object[parameters.Length];
			for (int num3 = parameters.Length - 1; num3 >= 0; num3--)
			{
				array[num3] = eb172308(fdc40966_0, parameters[num3].ParameterType, ref uint_0);
			}
			if (!methodBase_0.IsStatic && byte_0 != fb3c043f.byte_70)
			{
				obj = eb172308(fdc40966_0, methodBase_0.DeclaringType, ref uint_0);
				if (obj != null && !methodBase_0.DeclaringType!.IsInstanceOfType(obj))
				{
					method_1(fdc40966_0, methodBase_0, byte_0, ref uint_, out enum0_0);
					return;
				}
			}
		}
		object object_;
		if (byte_0 == fb3c043f.byte_70)
		{
			try
			{
				object_ = ((ConstructorInfo)methodBase_0).Invoke(array);
			}
			catch (TargetInvocationException ex)
			{
				dc314d0e.smethod_2(ex.InnerException, null);
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
				Class59.ce1637af(type_0: (array[0] != null) ? array[0].GetType() : type.GetElementType(), array_0: (Array)obj, int_0: (int)array[1], object_0: array[0], type_1: type.GetElementType());
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
					Class57.smethod_3(fdc40966_0, ex2.InnerException);
					throw;
				}
			}
		}
		if (methodBase_0 is MethodInfo && (object)((MethodInfo)methodBase_0).ReturnType != typeof(void))
		{
			fdc40966_0.class58_0.b53f41f9(++uint_0, Struct3.smethod_0(object_, ((MethodInfo)methodBase_0).ReturnType));
		}
		else if (byte_0 == fb3c043f.byte_70)
		{
			fdc40966_0.class58_0.b53f41f9(++uint_0, Struct3.smethod_0(object_, methodBase_0.DeclaringType));
		}
		fdc40966_0.class58_0.method_1(uint_0);
		fdc40966_0.struct3_0[fb3c043f.c55b5391].e63a4aca(uint_0);
		enum0_0 = (Enum0)0;
	}

	private void method_1(fdc40966 fdc40966_0, MethodBase methodBase_0, byte byte_0, ref uint uint_0, out Enum0 enum0_0)
	{
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		int num = parameters.Length;
		if (!methodBase_0.IsStatic && byte_0 != fb3c043f.byte_70)
		{
			num++;
		}
		Type type = null;
		if (byte_0 == fb3c043f.byte_71)
		{
			type = (Type)fdc40966_0.class2_0.method_0().method_3(fdc40966_0.class58_0.method_0(uint_0--).method_1());
		}
		if (!methodBase_0.IsStatic && byte_0 != fb3c043f.byte_70)
		{
			_ = 1;
		}
		else
			_ = 0;
		Interface1[] array = new Interface1[num];
		Type[] array2 = new Type[num];
		for (int num2 = num - 1; num2 >= 0; num2--)
		{
			Type type2;
			if (!methodBase_0.IsStatic && byte_0 != fb3c043f.byte_70)
			{
				if (num2 == 0)
				{
					if (!methodBase_0.IsStatic)
					{
						Struct3 @struct = fdc40966_0.class58_0.method_0(uint_0);
						if (@struct.c9550f69() is ValueType && !methodBase_0.DeclaringType!.IsValueType)
						{
							type = @struct.c9550f69().GetType();
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
			array[num2] = d058eac7(fdc40966_0, type2, ref uint_0);
			if (type2.IsByRef)
			{
				type2 = type2.GetElementType();
			}
			array2[num2] = type2;
		}
		OpCode opCode_;
		Type type3;
		if (byte_0 == fb3c043f.af27f690)
		{
			opCode_ = OpCodes.Call;
			type3 = ((methodBase_0 is MethodInfo) ? ((MethodInfo)methodBase_0).ReturnType : typeof(void));
		}
		else if (byte_0 == fb3c043f.byte_69 || byte_0 == fb3c043f.byte_71)
		{
			opCode_ = OpCodes.Callvirt;
			type3 = ((methodBase_0 is MethodInfo) ? ((MethodInfo)methodBase_0).ReturnType : typeof(void));
		}
		else
		{
			if (byte_0 != fb3c043f.byte_70)
			{
				throw new InvalidProgramException();
			}
			opCode_ = OpCodes.Newobj;
			type3 = methodBase_0.DeclaringType;
		}
		fb3b0854.da832bab da832bab = fb3b0854.b6a6d8a6(methodBase_0, opCode_, type);
		object object_ = da832bab(fdc40966_0, array, array2);
		if ((object)type3 != typeof(void))
		{
			fdc40966_0.class58_0.b53f41f9(++uint_0, Struct3.smethod_0(object_, type3));
		}
		else if (byte_0 == fb3c043f.byte_70)
		{
			fdc40966_0.class58_0.b53f41f9(++uint_0, Struct3.smethod_0(object_, type3));
		}
		fdc40966_0.class58_0.method_1(uint_0);
		fdc40966_0.struct3_0[fb3c043f.c55b5391].e63a4aca(uint_0);
		enum0_0 = (Enum0)0;
	}
}
