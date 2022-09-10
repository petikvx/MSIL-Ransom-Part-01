using System;
using System.ComponentModel;

namespace FC2ServerLauncher;

public class TDMRankedPropertySortTypeConverter : TypeConverter
{
	public override bool GetPropertiesSupported(ITypeDescriptorContext context)
	{
		return true;
	}

	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
	{
		PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(ServerSettingsTDMRanked), attributes);
		return properties.Sort(ServerSettings.PropertySortOrder);
	}
}
