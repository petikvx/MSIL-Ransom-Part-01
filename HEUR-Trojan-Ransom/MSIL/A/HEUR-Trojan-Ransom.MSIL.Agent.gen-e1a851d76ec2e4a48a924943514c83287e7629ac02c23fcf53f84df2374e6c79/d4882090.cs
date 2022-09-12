using System;

internal class d4882090 : Interface1
{
	private struct Struct1
	{
		public IntPtr intptr_0;

		public IntPtr intptr_1;
	}

	private f06aee96? nullable_0;

	private Struct1 struct1_0;

	public d4882090(f06aee96 f06aee96_0)
	{
		nullable_0 = f06aee96_0;
	}

	public unsafe d4882090(TypedReference typedReference_0)
	{
		nullable_0 = null;
		struct1_0 = *(Struct1*)(&typedReference_0);
	}

	public unsafe ebd9b488 imethod_0(Class62 class62_0, Enum2 enum2_0)
	{
		TypedReference typedReference = default(TypedReference);
		if (nullable_0.HasValue)
		{
			typedReference = *(TypedReference*)f06aee96.smethod_1(nullable_0.Value);
		}
		else
		{
			*(Struct1*)(&typedReference) = struct1_0;
		}
		return ebd9b488.e37ec81d(TypedReference.ToObject(typedReference), __reftype(typedReference));
	}

	public unsafe void e44a2829(Class62 class62_0, ebd9b488 ebd9b488_0, Enum2 enum2_0)
	{
		TypedReference typedReference = default(TypedReference);
		if (nullable_0.HasValue)
		{
			typedReference = *(TypedReference*)f06aee96.smethod_1(nullable_0.Value);
		}
		else
		{
			*(Struct1*)(&typedReference) = struct1_0;
		}
		Type typeFromHandle = __reftype(typedReference);
		object object_ = ebd9b488_0.method_5(typeFromHandle);
		bc2a451.smethod_4(object_, f06aee96.smethod_0(&typedReference));
	}

	public Interface1 imethod_1(uint uint_0)
	{
		return this;
	}

	public Interface1 imethod_2(ulong ulong_0)
	{
		return this;
	}

	public unsafe void imethod_3(Class62 class62_0, f06aee96 f06aee96_0, Type type_0)
	{
		if (nullable_0.HasValue)
		{
			*(TypedReference*)f06aee96.smethod_1(f06aee96_0) = *(TypedReference*)f06aee96.smethod_1(nullable_0.Value);
		}
		else
		{
			*(Struct1*)f06aee96.smethod_1(f06aee96_0) = struct1_0;
		}
	}
}
