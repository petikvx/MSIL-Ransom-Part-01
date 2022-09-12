using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

internal class ca22d0f6 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return c34ccaf0.byte_62;
	}

	private static object c77b93dd(Class54 class54_0, Type type_0, ref uint uint_0)
	{
		feeb32c3 feeb32c4 = class54_0.class55_0.ff4c393f(uint_0--);
		if (Type.GetTypeCode(type_0) == TypeCode.String && feeb32c4.cc3408c2() == null)
		{
			return class54_0.class1_0.method_0().method_3(feeb32c4.method_0());
		}
		return feeb32c4.method_9(type_0);
	}

	private unsafe static Interface2 b348398(Class54 class54_0, Type type_0, ref uint uint_0)
	{
		feeb32c3 feeb32c3_ = class54_0.class55_0.ff4c393f(uint_0);
		if (type_0.IsByRef)
		{
			uint_0--;
			type_0 = type_0.GetElementType();
			if (feeb32c3_.cc3408c2() is Pointer)
			{
				void* pVoid_ = Pointer.Unbox(feeb32c3_.cc3408c2());
				return new b30119a6(pVoid_);
			}
			if (feeb32c3_.cc3408c2() is Interface2)
			{
				return (Interface2)feeb32c3_.cc3408c2();
			}
			return new b30119a6((void*)feeb32c3_.d9a53946());
		}
		if (Type.GetTypeCode(type_0) == TypeCode.String && feeb32c3_.cc3408c2() == null)
		{
			feeb32c3_.method_7(class54_0.class1_0.method_0().method_3(feeb32c3_.method_0()));
			class54_0.class55_0.method_0(uint_0, feeb32c3_);
		}
		return new d6c76087(uint_0--);
	}

	private static bool smethod_0(Class54 class54_0, uint uint_0, MethodBase methodBase_0, bool bool_0)
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

	public void imethod_1(Class54 class54_0, out a0aa499b a0aa499b_0)
	{
		uint uint_ = class54_0.feeb32c3_0[c34ccaf0.byte_3].method_0();
		feeb32c3 feeb32c4 = class54_0.class55_0.ff4c393f(uint_--);
		uint uint_2 = feeb32c4.method_0() & 0x3FFFFFFFu;
		byte b = (byte)(feeb32c4.method_0() >> 30);
		MethodBase methodBase_ = (MethodBase)class54_0.class1_0.method_0().method_2(uint_2);
		bool flag;
		if (!(flag = b == c34ccaf0.byte_72))
		{
			flag = smethod_0(class54_0, uint_, methodBase_, b == c34ccaf0.byte_71);
		}
		if (flag)
		{
			d2d97e61(class54_0, methodBase_, b, ref uint_, out a0aa499b_0);
		}
		else
		{
			fd85a88a(class54_0, methodBase_, b, ref uint_, out a0aa499b_0);
		}
	}

	private void fd85a88a(Class54 class54_0, MethodBase methodBase_0, byte byte_0, ref uint uint_0, out a0aa499b a0aa499b_0)
	{
		uint uint_ = uint_0;
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		object obj = null;
		object[] array = new object[parameters.Length];
		if (byte_0 == c34ccaf0.byte_69 && methodBase_0.IsVirtual)
		{
			int num = ((!methodBase_0.IsStatic) ? 1 : 0);
			array = new object[parameters.Length + num];
			for (int num2 = parameters.Length - 1; num2 >= 0; num2--)
			{
				array[num2 + num] = c77b93dd(class54_0, parameters[num2].ParameterType, ref uint_0);
			}
			if (!methodBase_0.IsStatic)
			{
				array[0] = c77b93dd(class54_0, methodBase_0.DeclaringType, ref uint_0);
			}
			methodBase_0 = e6aa6259.smethod_0(methodBase_0);
		}
		else
		{
			array = new object[parameters.Length];
			for (int num3 = parameters.Length - 1; num3 >= 0; num3--)
			{
				array[num3] = c77b93dd(class54_0, parameters[num3].ParameterType, ref uint_0);
			}
			if (!methodBase_0.IsStatic && byte_0 != c34ccaf0.byte_71)
			{
				obj = c77b93dd(class54_0, methodBase_0.DeclaringType, ref uint_0);
				if (obj != null && !methodBase_0.DeclaringType!.IsInstanceOfType(obj))
				{
					d2d97e61(class54_0, methodBase_0, byte_0, ref uint_, out a0aa499b_0);
					return;
				}
			}
		}
		object object_;
		if (byte_0 == c34ccaf0.byte_71)
		{
			try
			{
				object_ = ((ConstructorInfo)methodBase_0).Invoke(array);
			}
			catch (TargetInvocationException ex)
			{
				Class57.a09b3200(ex.InnerException, null);
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
				Class56.edfcdc20(type_0: (array[0] != null) ? array[0].GetType() : type.GetElementType(), array_0: (Array)obj, int_0: (int)array[1], object_0: array[0], type_1: type.GetElementType());
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
					e52f2e1.smethod_3(class54_0, ex2.InnerException);
					throw;
				}
			}
		}
		if (methodBase_0 is MethodInfo && (object)((MethodInfo)methodBase_0).ReturnType != typeof(void))
		{
			class54_0.class55_0.method_0(++uint_0, feeb32c3.smethod_0(object_, ((MethodInfo)methodBase_0).ReturnType));
		}
		else if (byte_0 == c34ccaf0.byte_71)
		{
			class54_0.class55_0.method_0(++uint_0, feeb32c3.smethod_0(object_, methodBase_0.DeclaringType));
		}
		class54_0.class55_0.method_1(uint_0);
		class54_0.feeb32c3_0[c34ccaf0.byte_3].method_1(uint_0);
		a0aa499b_0 = (a0aa499b)0;
	}

	private void d2d97e61(Class54 class54_0, MethodBase methodBase_0, byte byte_0, ref uint uint_0, out a0aa499b a0aa499b_0)
	{
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		int num = parameters.Length;
		if (!methodBase_0.IsStatic && byte_0 != c34ccaf0.byte_71)
		{
			num++;
		}
		Type type = null;
		if (byte_0 == c34ccaf0.byte_72)
		{
			type = (Type)class54_0.class1_0.method_0().method_2(class54_0.class55_0.ff4c393f(uint_0--).method_0());
		}
		if (!methodBase_0.IsStatic && byte_0 != c34ccaf0.byte_71)
		{
			_ = 1;
		}
		else
			_ = 0;
		Interface2[] array = new Interface2[num];
		Type[] array2 = new Type[num];
		for (int num2 = num - 1; num2 >= 0; num2--)
		{
			Type type2;
			if (!methodBase_0.IsStatic && byte_0 != c34ccaf0.byte_71)
			{
				if (num2 == 0)
				{
					if (!methodBase_0.IsStatic)
					{
						feeb32c3 feeb32c4 = class54_0.class55_0.ff4c393f(uint_0);
						if (feeb32c4.cc3408c2() is ValueType && !methodBase_0.DeclaringType!.IsValueType)
						{
							type = feeb32c4.cc3408c2().GetType();
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
			array[num2] = b348398(class54_0, type2, ref uint_0);
			if (type2.IsByRef)
			{
				type2 = type2.GetElementType();
			}
			array2[num2] = type2;
		}
		OpCode opCode_;
		Type type3;
		if (byte_0 == c34ccaf0.byte_69)
		{
			opCode_ = OpCodes.Call;
			type3 = ((methodBase_0 is MethodInfo) ? ((MethodInfo)methodBase_0).ReturnType : typeof(void));
		}
		else if (byte_0 == c34ccaf0.byte_70 || byte_0 == c34ccaf0.byte_72)
		{
			opCode_ = OpCodes.Callvirt;
			type3 = ((methodBase_0 is MethodInfo) ? ((MethodInfo)methodBase_0).ReturnType : typeof(void));
		}
		else
		{
			if (byte_0 != c34ccaf0.byte_71)
			{
				throw new InvalidProgramException();
			}
			opCode_ = OpCodes.Newobj;
			type3 = methodBase_0.DeclaringType;
		}
		e6aa6259.Delegate1 @delegate = e6aa6259.smethod_1(methodBase_0, opCode_, type);
		object object_ = @delegate(class54_0, array, array2);
		if ((object)type3 != typeof(void))
		{
			class54_0.class55_0.method_0(++uint_0, feeb32c3.smethod_0(object_, type3));
		}
		else if (byte_0 == c34ccaf0.byte_71)
		{
			class54_0.class55_0.method_0(++uint_0, feeb32c3.smethod_0(object_, type3));
		}
		class54_0.class55_0.method_1(uint_0);
		class54_0.feeb32c3_0[c34ccaf0.byte_3].method_1(uint_0);
		a0aa499b_0 = (a0aa499b)0;
	}
}
