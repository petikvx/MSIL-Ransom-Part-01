using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

internal class Class5 : f788ae7e
{
	[SpecialName]
	public byte f998adc2()
	{
		return fae0f10.byte_47;
	}

	public void imethod_0(Class52 class52_0, out a82ced3b a82ced3b_0)
	{
		uint uint_ = class52_0.struct2_0[fae0f10.byte_5].b5683088();
		Struct2 @struct = class52_0.c6a36180_0.f113e6df(uint_--);
		Struct2 struct2 = class52_0.c6a36180_0.f113e6df(uint_--);
		Type type = (Type)class52_0.c8dafbc3.method_0().d3f1f142(@struct.b5683088());
		if (struct2.a90ed1e2() is Interface1)
		{
			Interface1 @interface = (Interface1)struct2.a90ed1e2();
			Struct2 struct2_ = default(Struct2);
			if (type.IsValueType)
			{
				object object_ = null;
				if ((object)Nullable.GetUnderlyingType(type) == null)
				{
					object_ = FormatterServices.GetUninitializedObject(type);
				}
				struct2_.method_7(Class59.smethod_0(object_, type));
			}
			else
			{
				struct2_.method_7(null);
			}
			@interface.imethod_0(class52_0, struct2_, (cf6ebfe8)4);
			class52_0.c6a36180_0.method_0(uint_);
			class52_0.struct2_0[fae0f10.byte_5].b3579a47(uint_);
			a82ced3b_0 = (a82ced3b)0;
			return;
		}
		throw new NotSupportedException();
	}
}
