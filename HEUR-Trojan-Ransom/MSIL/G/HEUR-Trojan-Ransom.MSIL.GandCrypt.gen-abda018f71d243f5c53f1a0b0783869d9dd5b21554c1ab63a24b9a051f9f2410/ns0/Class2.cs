using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;

namespace ns0;

internal sealed class Class2 : ColorConverter
{
	public override bool vmethod_0(ITypeDescriptorContext itypeDescriptorContext_0, Type type_0)
	{
		return CanConvertFrom(itypeDescriptorContext_0, type_0);
	}

	public override bool vmethod_1(ITypeDescriptorContext itypeDescriptorContext_0, Type type_0)
	{
		return CanConvertTo(itypeDescriptorContext_0, type_0);
	}

	public override object vmethod_2(ITypeDescriptorContext itypeDescriptorContext_0, CultureInfo cultureInfo_0, object object_0)
	{
		return ConvertFrom(itypeDescriptorContext_0, cultureInfo_0, object_0);
	}

	public override object vmethod_3(ITypeDescriptorContext itypeDescriptorContext_0, CultureInfo cultureInfo_0, object object_0, Type type_0)
	{
		return ConvertTo(itypeDescriptorContext_0, cultureInfo_0, object_0, type_0);
	}

	public override object vmethod_4(ITypeDescriptorContext itypeDescriptorContext_0, IDictionary idictionary_0)
	{
		return base.CreateInstance(itypeDescriptorContext_0, idictionary_0);
	}

	public override bool vmethod_5(object object_0)
	{
		return base.Equals(object_0);
	}

	public override bool vmethod_6(ITypeDescriptorContext itypeDescriptorContext_0)
	{
		return base.GetCreateInstanceSupported(itypeDescriptorContext_0);
	}

	public override int vmethod_7()
	{
		return base.GetHashCode();
	}

	public override PropertyDescriptorCollection vmethod_8(ITypeDescriptorContext itypeDescriptorContext_0, object object_0, Attribute[] attribute_0)
	{
		return base.GetProperties(itypeDescriptorContext_0, object_0, attribute_0);
	}

	public override bool vmethod_9(ITypeDescriptorContext itypeDescriptorContext_0)
	{
		return base.GetPropertiesSupported(itypeDescriptorContext_0);
	}

	public override StandardValuesCollection vmethod_10(ITypeDescriptorContext itypeDescriptorContext_0)
	{
		return GetStandardValues(itypeDescriptorContext_0);
	}

	public override bool vmethod_11(ITypeDescriptorContext itypeDescriptorContext_0)
	{
		return base.GetStandardValuesExclusive(itypeDescriptorContext_0);
	}

	public override bool vmethod_12(ITypeDescriptorContext itypeDescriptorContext_0)
	{
		return GetStandardValuesSupported(itypeDescriptorContext_0);
	}

	public override bool vmethod_13(ITypeDescriptorContext itypeDescriptorContext_0, object object_0)
	{
		return base.IsValid(itypeDescriptorContext_0, object_0);
	}

	public override string vmethod_14()
	{
		return base.ToString();
	}
}
