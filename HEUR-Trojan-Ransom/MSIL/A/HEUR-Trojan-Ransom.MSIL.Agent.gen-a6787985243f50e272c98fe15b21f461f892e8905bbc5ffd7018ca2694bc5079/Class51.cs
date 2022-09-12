using System;

internal class Class51 : Interface1
{
	private struct Struct0
	{
		public IntPtr intptr_0;

		public IntPtr intptr_1;
	}

	private Struct1? nullable_0;

	private Struct0 b9258ab5;

	public Class51(Struct1 struct1_0)
	{
		nullable_0 = struct1_0;
	}

	public unsafe Class51(TypedReference typedReference_0)
	{
		nullable_0 = null;
		b9258ab5 = *(Struct0*)(&typedReference_0);
	}

	public unsafe Struct2 a421f925(Class52 class52_0, cf6ebfe8 cf6ebfe8_0)
	{
		TypedReference typedReference = default(TypedReference);
		if (nullable_0.HasValue)
		{
			typedReference = *(TypedReference*)Struct1.d9a770c4(nullable_0.Value);
		}
		else
		{
			*(Struct0*)(&typedReference) = b9258ab5;
		}
		return Struct2.smethod_0(TypedReference.ToObject(typedReference), __reftype(typedReference));
	}

	public unsafe void imethod_0(Class52 class52_0, Struct2 struct2_0, cf6ebfe8 cf6ebfe8_0)
	{
		TypedReference typedReference = default(TypedReference);
		if (nullable_0.HasValue)
		{
			typedReference = *(TypedReference*)Struct1.d9a770c4(nullable_0.Value);
		}
		else
		{
			*(Struct0*)(&typedReference) = b9258ab5;
		}
		Type typeFromHandle = __reftype(typedReference);
		object object_ = struct2_0.method_9(typeFromHandle);
		Class57.e8c6cd7c(object_, Struct1.d9a770c4(&typedReference));
	}

	public Interface1 aa5eee9f(uint uint_0)
	{
		return this;
	}

	public Interface1 aa5eee9f(ulong ulong_0)
	{
		return this;
	}

	public unsafe void imethod_1(Class52 class52_0, Struct1 struct1_0, Type type_0)
	{
		if (nullable_0.HasValue)
		{
			*(TypedReference*)Struct1.d9a770c4(struct1_0) = *(TypedReference*)Struct1.d9a770c4(nullable_0.Value);
		}
		else
		{
			*(Struct0*)Struct1.d9a770c4(struct1_0) = b9258ab5;
		}
	}
}
