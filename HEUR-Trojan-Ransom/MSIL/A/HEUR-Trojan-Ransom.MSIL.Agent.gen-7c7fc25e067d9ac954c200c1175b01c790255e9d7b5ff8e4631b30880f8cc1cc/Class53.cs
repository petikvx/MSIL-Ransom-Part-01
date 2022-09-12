using System;

internal class Class53 : Interface2
{
	private struct Struct0
	{
		public IntPtr intptr_0;

		public IntPtr d38b8b22;
	}

	private Struct1? nullable_0;

	private Struct0 d9e65e15;

	public Class53(Struct1 struct1_0)
	{
		nullable_0 = struct1_0;
	}

	public unsafe Class53(TypedReference typedReference_0)
	{
		nullable_0 = null;
		d9e65e15 = *(Struct0*)(&typedReference_0);
	}

	public unsafe feeb32c3 imethod_0(Class54 class54_0, Enum1 enum1_0)
	{
		TypedReference typedReference = default(TypedReference);
		if (nullable_0.HasValue)
		{
			typedReference = *(TypedReference*)Struct1.smethod_1(nullable_0.Value);
		}
		else
		{
			*(Struct0*)(&typedReference) = d9e65e15;
		}
		return feeb32c3.smethod_0(TypedReference.ToObject(typedReference), __reftype(typedReference));
	}

	public unsafe void edfcdc20(Class54 class54_0, feeb32c3 feeb32c3_0, Enum1 enum1_0)
	{
		TypedReference typedReference = default(TypedReference);
		if (nullable_0.HasValue)
		{
			typedReference = *(TypedReference*)Struct1.smethod_1(nullable_0.Value);
		}
		else
		{
			*(Struct0*)(&typedReference) = d9e65e15;
		}
		Type typeFromHandle = __reftype(typedReference);
		object object_ = feeb32c3_0.method_9(typeFromHandle);
		Class59.c380ab5c(object_, Struct1.smethod_0(&typedReference));
	}

	public Interface2 imethod_1(uint uint_0)
	{
		return this;
	}

	public Interface2 imethod_2(ulong ulong_0)
	{
		return this;
	}

	public unsafe void imethod_3(Class54 class54_0, Struct1 struct1_0, Type type_0)
	{
		if (nullable_0.HasValue)
		{
			*(TypedReference*)Struct1.smethod_1(struct1_0) = *(TypedReference*)Struct1.smethod_1(nullable_0.Value);
		}
		else
		{
			*(Struct0*)Struct1.smethod_1(struct1_0) = d9e65e15;
		}
	}
}
