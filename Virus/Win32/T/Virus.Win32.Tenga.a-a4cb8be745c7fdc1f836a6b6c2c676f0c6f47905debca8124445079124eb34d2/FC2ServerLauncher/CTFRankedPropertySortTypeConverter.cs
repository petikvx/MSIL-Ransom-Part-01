using System;
using System.ComponentModel;

namespace FC2ServerLauncher;

public class CTFRankedPropertySortTypeConverter : TypeConverter
{
	public override bool GetPropertiesSupported(ITypeDescriptorContext context)
	{
		return true;
	}

	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
	{
		PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(ServerSettingsCTFRanked), attributes);
		return properties.Sort(ServerSettings.PropertySortOrder);
	}
}
