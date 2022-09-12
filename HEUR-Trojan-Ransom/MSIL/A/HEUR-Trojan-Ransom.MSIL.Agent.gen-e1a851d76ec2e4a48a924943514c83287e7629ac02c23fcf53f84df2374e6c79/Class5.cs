using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

internal class Class5 : bae6a63f
{
	[SpecialName]
	public byte e9bf20d3()
	{
		return Class69.byte_53;
	}

	private static object smethod_0(Class62 class62_0, Type type_0, ref uint uint_0)
	{
		ebd9b488 ebd9b489 = class62_0.class64_0.method_0(uint_0--);
		if (Type.GetTypeCode(type_0) == TypeCode.String && ebd9b489.ec0d6773() == null)
		{
			return class62_0.da79a168.de5d16da().method_4(ebd9b489.b585a11());
		}
		return ebd9b489.method_5(type_0);
	}

	private unsafe static Interface1 smethod_1(Class62 class62_0, Type type_0, ref uint uint_0)
	{
		ebd9b488 ebd9b488_ = class62_0.class64_0.method_0(uint_0);
		if (type_0.IsByRef)
		{
			uint_0--;
			type_0 = type_0.GetElementType();
			if (ebd9b488_.ec0d6773() is Pointer)
			{
				void* pVoid_ = Pointer.Unbox(ebd9b488_.ec0d6773());
				return new Class60(pVoid_);
			}
			if (ebd9b488_.ec0d6773() is Interface1)
			{
				return (Interface1)ebd9b488_.ec0d6773();
			}
			return new Class60((void*)ebd9b488_.method_0());
		}
		if (Type.GetTypeCode(type_0) == TypeCode.String && ebd9b488_.ec0d6773() == null)
		{
			ebd9b488_.aa900636(class62_0.da79a168.de5d16da().method_4(ebd9b488_.b585a11()));
			class62_0.class64_0.method_1(uint_0, ebd9b488_);
		}
		return new Class61(uint_0--);
	}

	private static bool e06b826c(Class62 class62_0, uint uint_0, MethodBase methodBase_0, bool bool_0)
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

	public void imethod_0(Class62 class62_0, out Enum1 enum1_0)
	{
		uint uint_ = class62_0.ebd9b488_0[Class69.byte_4].b585a11();
		ebd9b488 ebd9b489 = class62_0.class64_0.method_0(uint_--);
		uint uint_2 = ebd9b489.b585a11() & 0x3FFFFFFFu;
		byte b7500187 = (byte)(ebd9b489.b585a11() >> 30);
		MethodBase methodBase_ = (MethodBase)class62_0.da79a168.de5d16da().method_3(uint_2);
		bool flag;
		if (!(flag = b7500187 == Class69.byte_62))
		{
			flag = e06b826c(class62_0, uint_, methodBase_, b7500187 == Class69.d317c874);
		}
		if (flag)
		{
			method_1(class62_0, methodBase_, b7500187, ref uint_, out enum1_0);
		}
		else
		{
			method_0(class62_0, methodBase_, b7500187, ref uint_, out enum1_0);
		}
	}

	private void method_0(Class62 class62_0, MethodBase methodBase_0, byte byte_0, ref uint uint_0, out Enum1 enum1_0)
	{
		uint uint_ = uint_0;
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		object obj = null;
		object[] array = new object[parameters.Length];
		if (byte_0 == Class69.byte_60 && methodBase_0.IsVirtual)
		{
			int num = ((!methodBase_0.IsStatic) ? 1 : 0);
			array = new object[parameters.Length + num];
			for (int num2 = parameters.Length - 1; num2 >= 0; num2--)
			{
				array[num2 + num] = smethod_0(class62_0, parameters[num2].ParameterType, ref uint_0);
			}
			if (!methodBase_0.IsStatic)
			{
				array[0] = smethod_0(class62_0, methodBase_0.DeclaringType, ref uint_0);
			}
			methodBase_0 = Class65.smethod_0(methodBase_0);
		}
		else
		{
			array = new object[parameters.Length];
			for (int num3 = parameters.Length - 1; num3 >= 0; num3--)
			{
				array[num3] = smethod_0(class62_0, parameters[num3].ParameterType, ref uint_0);
			}
			if (!methodBase_0.IsStatic && byte_0 != Class69.d317c874)
			{
				obj = smethod_0(class62_0, methodBase_0.DeclaringType, ref uint_0);
				if (obj != null && !methodBase_0.DeclaringType!.IsInstanceOfType(obj))
				{
					method_1(class62_0, methodBase_0, byte_0, ref uint_, out enum1_0);
					return;
				}
			}
		}
		object object_;
		if (byte_0 == Class69.d317c874)
		{
			try
			{
				object_ = ((ConstructorInfo)methodBase_0).Invoke(array);
			}
			catch (TargetInvocationException ex)
			{
				Class66.smethod_2(ex.InnerException, null);
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
				e4935382.e44a2829(type_0: (array[0] != null) ? array[0].GetType() : type.GetElementType(), array_0: (Array)obj, int_0: (int)array[1], object_0: array[0], type_1: type.GetElementType());
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
					Class63.cef3d149(class62_0, ex2.InnerException);
					throw;
				}
			}
		}
		if (methodBase_0 is MethodInfo && (object)((MethodInfo)methodBase_0).ReturnType != typeof(void))
		{
			class62_0.class64_0.method_1(++uint_0, ebd9b488.e37ec81d(object_, ((MethodInfo)methodBase_0).ReturnType));
		}
		else if (byte_0 == Class69.d317c874)
		{
			class62_0.class64_0.method_1(++uint_0, ebd9b488.e37ec81d(object_, methodBase_0.DeclaringType));
		}
		class62_0.class64_0.method_2(uint_0);
		class62_0.ebd9b488_0[Class69.byte_4].cf774c3c(uint_0);
		enum1_0 = (Enum1)0;
	}

	private void method_1(Class62 class62_0, MethodBase methodBase_0, byte byte_0, ref uint uint_0, out Enum1 enum1_0)
	{
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		int num = parameters.Length;
		if (!methodBase_0.IsStatic && byte_0 != Class69.d317c874)
		{
			num++;
		}
		Type type = null;
		if (byte_0 == Class69.byte_62)
		{
			type = (Type)class62_0.da79a168.de5d16da().method_3(class62_0.class64_0.method_0(uint_0--).b585a11());
		}
		if (!methodBase_0.IsStatic && byte_0 != Class69.d317c874)
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
			if (!methodBase_0.IsStatic && byte_0 != Class69.d317c874)
			{
				if (num2 == 0)
				{
					if (!methodBase_0.IsStatic)
					{
						ebd9b488 ebd9b489 = class62_0.class64_0.method_0(uint_0);
						if (ebd9b489.ec0d6773() is ValueType && !methodBase_0.DeclaringType!.IsValueType)
						{
							type = ebd9b489.ec0d6773().GetType();
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
			array[num2] = smethod_1(class62_0, type2, ref uint_0);
			if (type2.IsByRef)
			{
				type2 = type2.GetElementType();
			}
			array2[num2] = type2;
		}
		OpCode opCode_;
		Type type3;
		if (byte_0 == Class69.byte_60)
		{
			opCode_ = OpCodes.Call;
			type3 = ((methodBase_0 is MethodInfo) ? ((MethodInfo)methodBase_0).ReturnType : typeof(void));
		}
		else if (byte_0 == Class69.byte_61 || byte_0 == Class69.byte_62)
		{
			opCode_ = OpCodes.Callvirt;
			type3 = ((methodBase_0 is MethodInfo) ? ((MethodInfo)methodBase_0).ReturnType : typeof(void));
		}
		else
		{
			if (byte_0 != Class69.d317c874)
			{
				throw new InvalidProgramException();
			}
			opCode_ = OpCodes.Newobj;
			type3 = methodBase_0.DeclaringType;
		}
		Class65.Delegate1 @delegate = Class65.eb851378(methodBase_0, opCode_, type);
		object object_ = @delegate(class62_0, array, array2);
		if ((object)type3 != typeof(void))
		{
			class62_0.class64_0.method_1(++uint_0, ebd9b488.e37ec81d(object_, type3));
		}
		else if (byte_0 == Class69.d317c874)
		{
			class62_0.class64_0.method_1(++uint_0, ebd9b488.e37ec81d(object_, type3));
		}
		class62_0.class64_0.method_2(uint_0);
		class62_0.ebd9b488_0[Class69.byte_4].cf774c3c(uint_0);
		enum1_0 = (Enum1)0;
	}
}
