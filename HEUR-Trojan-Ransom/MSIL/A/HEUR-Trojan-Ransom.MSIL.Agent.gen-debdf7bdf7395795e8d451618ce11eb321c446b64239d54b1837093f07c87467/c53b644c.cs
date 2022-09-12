using System;

internal class c53b644c : da5e0024
{
	private struct Struct1
	{
		public IntPtr d09b640;

		public IntPtr intptr_0;
	}

	private fe387972? b5d5533b;

	private Struct1 struct1_0;

	public c53b644c(fe387972 fe387972_0)
	{
		b5d5533b = fe387972_0;
	}

	public unsafe c53b644c(TypedReference typedReference_0)
	{
		b5d5533b = null;
		struct1_0 = *(Struct1*)(&typedReference_0);
	}

	public unsafe Struct2 imethod_0(Class49 class49_0, Enum2 enum2_0)
	{
		TypedReference typedReference = default(TypedReference);
		if (b5d5533b.HasValue)
		{
			typedReference = *(TypedReference*)fe387972.smethod_1(b5d5533b.Value);
		}
		else
		{
			*(Struct1*)(&typedReference) = struct1_0;
		}
		return Struct2.a5dd3349(TypedReference.ToObject(typedReference), __reftype(typedReference));
	}

	public unsafe void bf75e195(Class49 class49_0, Struct2 struct2_0, Enum2 enum2_0)
	{
		TypedReference typedReference = default(TypedReference);
		if (b5d5533b.HasValue)
		{
			typedReference = *(TypedReference*)fe387972.smethod_1(b5d5533b.Value);
		}
		else
		{
			*(Struct1*)(&typedReference) = struct1_0;
		}
		Type typeFromHandle = __reftype(typedReference);
		object object_ = struct2_0.method_8(typeFromHandle);
		Class55.smethod_2(object_, fe387972.smethod_0(&typedReference));
	}

	public da5e0024 f4d9c5f0(uint uint_0)
	{
		return this;
	}

	public da5e0024 f4d9c5f0(ulong ulong_0)
	{
		return this;
	}

	public unsafe void c4cba08f(Class49 class49_0, fe387972 fe387972_0, Type type_0)
	{
		if (b5d5533b.HasValue)
		{
			*(TypedReference*)fe387972.smethod_1(fe387972_0) = *(TypedReference*)fe387972.smethod_1(b5d5533b.Value);
		}
		else
		{
			*(Struct1*)fe387972.smethod_1(fe387972_0) = struct1_0;
		}
	}
}
