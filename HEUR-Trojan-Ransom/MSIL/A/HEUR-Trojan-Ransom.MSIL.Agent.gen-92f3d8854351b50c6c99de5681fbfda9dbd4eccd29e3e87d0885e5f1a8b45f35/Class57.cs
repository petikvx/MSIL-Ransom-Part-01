using System;

internal class Class57 : Interface0
{
	private struct fa79e030
	{
		public IntPtr intptr_0;

		public IntPtr c8d668e2;
	}

	private Struct0? a8df4fce;

	private fa79e030 fa79e030_0;

	public Class57(Struct0 struct0_0)
	{
		a8df4fce = struct0_0;
	}

	public unsafe Class57(TypedReference typedReference_0)
	{
		a8df4fce = null;
		fa79e030_0 = *(fa79e030*)(&typedReference_0);
	}

	public unsafe facef383 b3037b45(Class58 class58_0, Enum1 enum1_0)
	{
		TypedReference typedReference = default(TypedReference);
		if (a8df4fce.HasValue)
		{
			typedReference = *(TypedReference*)Struct0.smethod_1(a8df4fce.Value);
		}
		else
		{
			*(fa79e030*)(&typedReference) = fa79e030_0;
		}
		return facef383.b3e8ed04(TypedReference.ToObject(typedReference), __reftype(typedReference));
	}

	public unsafe void c076b3e0(Class58 class58_0, facef383 facef383_0, Enum1 enum1_0)
	{
		TypedReference typedReference = default(TypedReference);
		if (a8df4fce.HasValue)
		{
			typedReference = *(TypedReference*)Struct0.smethod_1(a8df4fce.Value);
		}
		else
		{
			*(fa79e030*)(&typedReference) = fa79e030_0;
		}
		Type typeFromHandle = __reftype(typedReference);
		object object_ = facef383_0.f3c5123d(typeFromHandle);
		Class63.smethod_2(object_, Struct0.smethod_0(&typedReference));
	}

	public Interface0 df0155bf(uint uint_0)
	{
		return this;
	}

	public Interface0 df0155bf(ulong ulong_0)
	{
		return this;
	}

	public unsafe void imethod_0(Class58 class58_0, Struct0 struct0_0, Type type_0)
	{
		if (a8df4fce.HasValue)
		{
			*(TypedReference*)Struct0.smethod_1(struct0_0) = *(TypedReference*)Struct0.smethod_1(a8df4fce.Value);
		}
		else
		{
			*(fa79e030*)Struct0.smethod_1(struct0_0) = fa79e030_0;
		}
	}
}
