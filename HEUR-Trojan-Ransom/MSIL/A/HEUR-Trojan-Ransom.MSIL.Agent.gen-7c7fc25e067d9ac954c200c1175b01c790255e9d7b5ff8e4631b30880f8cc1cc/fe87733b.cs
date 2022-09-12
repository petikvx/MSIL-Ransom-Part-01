using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

internal class fe87733b : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return c34ccaf0.bd8ed104;
	}

	public void imethod_1(Class54 class54_0, out a0aa499b a0aa499b_0)
	{
		uint num = class54_0.feeb32c3_0[c34ccaf0.byte_3].method_0();
		feeb32c3 feeb32c4 = class54_0.class55_0.ff4c393f(num--);
		feeb32c3 feeb32c5 = class54_0.class55_0.ff4c393f(num--);
		Type type = (Type)class54_0.class1_0.method_0().method_2(feeb32c4.method_0());
		if (feeb32c5.cc3408c2() is Interface2)
		{
			Interface2 @interface = (Interface2)feeb32c5.cc3408c2();
			feeb32c3 feeb32c3_ = default(feeb32c3);
			if (type.IsValueType)
			{
				object object_ = null;
				if ((object)Nullable.GetUnderlyingType(type) == null)
				{
					object_ = FormatterServices.GetUninitializedObject(type);
				}
				feeb32c3_.method_7(Class60.smethod_0(object_, type));
			}
			else
			{
				feeb32c3_.method_7(null);
			}
			@interface.edfcdc20(class54_0, feeb32c3_, (Enum1)4);
			class54_0.class55_0.method_1(num);
			class54_0.feeb32c3_0[c34ccaf0.byte_3].method_1(num);
			a0aa499b_0 = (a0aa499b)0;
			return;
		}
		throw new NotSupportedException();
	}
}
