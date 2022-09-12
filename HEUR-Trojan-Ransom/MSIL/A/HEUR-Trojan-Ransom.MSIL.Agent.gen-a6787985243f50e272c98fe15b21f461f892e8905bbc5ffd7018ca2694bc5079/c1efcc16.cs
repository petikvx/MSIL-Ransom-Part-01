using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

internal class c1efcc16 : f788ae7e
{
	[SpecialName]
	public byte f998adc2()
	{
		return fae0f10.byte_44;
	}

	private static object smethod_0(Class52 class52_0, Type type_0, ref uint uint_0)
	{
		Struct2 @struct = class52_0.c6a36180_0.f113e6df(uint_0--);
		if (Type.GetTypeCode(type_0) == TypeCode.String && @struct.a90ed1e2() == null)
		{
			return class52_0.c8dafbc3.method_0().f54a7fb9(@struct.b5683088());
		}
		return @struct.method_9(type_0);
	}

	private unsafe static Interface1 smethod_1(Class52 class52_0, Type type_0, ref uint uint_0)
	{
		Struct2 struct2_ = class52_0.c6a36180_0.f113e6df(uint_0);
		if (type_0.IsByRef)
		{
			uint_0--;
			type_0 = type_0.GetElementType();
			if (struct2_.a90ed1e2() is Pointer)
			{
				void* pVoid_ = Pointer.Unbox(struct2_.a90ed1e2());
				return new a3170cc6(pVoid_);
			}
			if (struct2_.a90ed1e2() is Interface1)
			{
				return (Interface1)struct2_.a90ed1e2();
			}
			return new a3170cc6((void*)struct2_.method_0());
		}
		if (Type.GetTypeCode(type_0) == TypeCode.String && struct2_.a90ed1e2() == null)
		{
			struct2_.method_7(class52_0.c8dafbc3.method_0().f54a7fb9(struct2_.b5683088()));
			class52_0.c6a36180_0.f43586b2(uint_0, struct2_);
		}
		return new a32d2227(uint_0--);
	}

	private static bool smethod_2(Class52 class52_0, uint uint_0, MethodBase methodBase_0, bool bool_0)
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

	public void imethod_0(Class52 class52_0, out a82ced3b a82ced3b_0)
	{
		uint uint_ = class52_0.struct2_0[fae0f10.byte_5].b5683088();
		Struct2 @struct = class52_0.c6a36180_0.f113e6df(uint_--);
		uint uint_2 = @struct.b5683088() & 0x3FFFFFFFu;
		byte b7056385 = (byte)(@struct.b5683088() >> 30);
		MethodBase methodBase_ = (MethodBase)class52_0.c8dafbc3.method_0().d3f1f142(uint_2);
		bool flag;
		if (!(flag = b7056385 == fae0f10.byte_53))
		{
			flag = smethod_2(class52_0, uint_, methodBase_, b7056385 == fae0f10.f5ac4f9f);
		}
		if (flag)
		{
			method_1(class52_0, methodBase_, b7056385, ref uint_, out a82ced3b_0);
		}
		else
		{
			method_0(class52_0, methodBase_, b7056385, ref uint_, out a82ced3b_0);
		}
	}

	private void method_0(Class52 class52_0, MethodBase methodBase_0, byte byte_0, ref uint uint_0, out a82ced3b a82ced3b_0)
	{
		uint uint_ = uint_0;
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		object obj = null;
		object[] array = new object[parameters.Length];
		if (byte_0 == fae0f10.byte_52 && methodBase_0.IsVirtual)
		{
			int num = ((!methodBase_0.IsStatic) ? 1 : 0);
			array = new object[parameters.Length + num];
			for (int num2 = parameters.Length - 1; num2 >= 0; num2--)
			{
				array[num2 + num] = smethod_0(class52_0, parameters[num2].ParameterType, ref uint_0);
			}
			if (!methodBase_0.IsStatic)
			{
				array[0] = smethod_0(class52_0, methodBase_0.DeclaringType, ref uint_0);
			}
			methodBase_0 = Class55.smethod_0(methodBase_0);
		}
		else
		{
			array = new object[parameters.Length];
			for (int num3 = parameters.Length - 1; num3 >= 0; num3--)
			{
				array[num3] = smethod_0(class52_0, parameters[num3].ParameterType, ref uint_0);
			}
			if (!methodBase_0.IsStatic && byte_0 != fae0f10.f5ac4f9f)
			{
				obj = smethod_0(class52_0, methodBase_0.DeclaringType, ref uint_0);
				if (obj != null && !methodBase_0.DeclaringType!.IsInstanceOfType(obj))
				{
					method_1(class52_0, methodBase_0, byte_0, ref uint_, out a82ced3b_0);
					return;
				}
			}
		}
		object object_;
		if (byte_0 == fae0f10.f5ac4f9f)
		{
			try
			{
				object_ = ((ConstructorInfo)methodBase_0).Invoke(array);
			}
			catch (TargetInvocationException ex)
			{
				ac56c39b.smethod_0(ex.InnerException, null);
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
				Class54.smethod_0(type_0: (array[0] != null) ? array[0].GetType() : type.GetElementType(), array_0: (Array)obj, int_0: (int)array[1], object_0: array[0], type_1: type.GetElementType());
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
					Class53.f0a834e0(class52_0, ex2.InnerException);
					throw;
				}
			}
		}
		if (methodBase_0 is MethodInfo && (object)((MethodInfo)methodBase_0).ReturnType != typeof(void))
		{
			class52_0.c6a36180_0.f43586b2(++uint_0, Struct2.smethod_0(object_, ((MethodInfo)methodBase_0).ReturnType));
		}
		else if (byte_0 == fae0f10.f5ac4f9f)
		{
			class52_0.c6a36180_0.f43586b2(++uint_0, Struct2.smethod_0(object_, methodBase_0.DeclaringType));
		}
		class52_0.c6a36180_0.method_0(uint_0);
		class52_0.struct2_0[fae0f10.byte_5].b3579a47(uint_0);
		a82ced3b_0 = (a82ced3b)0;
	}

	private void method_1(Class52 class52_0, MethodBase methodBase_0, byte byte_0, ref uint uint_0, out a82ced3b a82ced3b_0)
	{
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		int num = parameters.Length;
		if (!methodBase_0.IsStatic && byte_0 != fae0f10.f5ac4f9f)
		{
			num++;
		}
		Type type = null;
		if (byte_0 == fae0f10.byte_53)
		{
			type = (Type)class52_0.c8dafbc3.method_0().d3f1f142(class52_0.c6a36180_0.f113e6df(uint_0--).b5683088());
		}
		if (!methodBase_0.IsStatic && byte_0 != fae0f10.f5ac4f9f)
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
			if (!methodBase_0.IsStatic && byte_0 != fae0f10.f5ac4f9f)
			{
				if (num2 == 0)
				{
					if (!methodBase_0.IsStatic)
					{
						Struct2 @struct = class52_0.c6a36180_0.f113e6df(uint_0);
						if (@struct.a90ed1e2() is ValueType && !methodBase_0.DeclaringType!.IsValueType)
						{
							type = @struct.a90ed1e2().GetType();
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
			array[num2] = smethod_1(class52_0, type2, ref uint_0);
			if (type2.IsByRef)
			{
				type2 = type2.GetElementType();
			}
			array2[num2] = type2;
		}
		OpCode opCode_;
		Type type3;
		if (byte_0 == fae0f10.byte_52)
		{
			opCode_ = OpCodes.Call;
			type3 = ((methodBase_0 is MethodInfo) ? ((MethodInfo)methodBase_0).ReturnType : typeof(void));
		}
		else if (byte_0 == fae0f10.dbedfd40 || byte_0 == fae0f10.byte_53)
		{
			opCode_ = OpCodes.Callvirt;
			type3 = ((methodBase_0 is MethodInfo) ? ((MethodInfo)methodBase_0).ReturnType : typeof(void));
		}
		else
		{
			if (byte_0 != fae0f10.f5ac4f9f)
			{
				throw new InvalidProgramException();
			}
			opCode_ = OpCodes.Newobj;
			type3 = methodBase_0.DeclaringType;
		}
		Class55.Delegate1 @delegate = Class55.f94c3193(methodBase_0, opCode_, type);
		object object_ = @delegate(class52_0, array, array2);
		if ((object)type3 != typeof(void))
		{
			class52_0.c6a36180_0.f43586b2(++uint_0, Struct2.smethod_0(object_, type3));
		}
		else if (byte_0 == fae0f10.f5ac4f9f)
		{
			class52_0.c6a36180_0.f43586b2(++uint_0, Struct2.smethod_0(object_, type3));
		}
		class52_0.c6a36180_0.method_0(uint_0);
		class52_0.struct2_0[fae0f10.byte_5].b3579a47(uint_0);
		a82ced3b_0 = (a82ced3b)0;
	}
}
