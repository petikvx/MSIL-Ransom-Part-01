using System;

internal class Class56 : Interface1
{
	private struct Struct1
	{
		public IntPtr intptr_0;

		public IntPtr intptr_1;
	}

	private Struct2? b2408945;

	private Struct1 struct1_0;

	public Class56(Struct2 struct2_0)
	{
		b2408945 = struct2_0;
	}

	public unsafe Class56(TypedReference typedReference_0)
	{
		b2408945 = null;
		struct1_0 = *(Struct1*)(&typedReference_0);
	}

	public unsafe Struct3 bb331190(fdc40966 fdc40966_0, f75d8d37 f75d8d37_0)
	{
		TypedReference typedReference = default(TypedReference);
		if (b2408945.HasValue)
		{
			typedReference = *(TypedReference*)Struct2.smethod_1(b2408945.Value);
		}
		else
		{
			*(Struct1*)(&typedReference) = struct1_0;
		}
		return Struct3.smethod_0(TypedReference.ToObject(typedReference), __reftype(typedReference));
	}

	public unsafe void ce1637af(fdc40966 fdc40966_0, Struct3 struct3_0, f75d8d37 f75d8d37_0)
	{
		TypedReference typedReference = default(TypedReference);
		if (b2408945.HasValue)
		{
			typedReference = *(TypedReference*)Struct2.smethod_1(b2408945.Value);
		}
		else
		{
			*(Struct1*)(&typedReference) = struct1_0;
		}
		Type typeFromHandle = __reftype(typedReference);
		object object_ = struct3_0.e3ce4628(typeFromHandle);
		Class61.smethod_3(object_, Struct2.smethod_0(&typedReference));
	}

	public Interface1 fdd68142(uint uint_0)
	{
		return this;
	}

	public Interface1 fdd68142(ulong ulong_0)
	{
		return this;
	}

	public unsafe void imethod_0(fdc40966 fdc40966_0, Struct2 struct2_0, Type type_0)
	{
		if (b2408945.HasValue)
		{
			*(TypedReference*)Struct2.smethod_1(struct2_0) = *(TypedReference*)Struct2.smethod_1(b2408945.Value);
		}
		else
		{
			*(Struct1*)Struct2.smethod_1(struct2_0) = struct1_0;
		}
	}
}
