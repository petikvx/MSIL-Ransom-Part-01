using System;
using System.ComponentModel;

namespace FC2ServerLauncher;

public class DMOnlinePropertySortTypeConverter : TypeConverter
{
	public override bool GetPropertiesSupported(ITypeDescriptorContext context)
	{
		return true;
	}

	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
	{
		PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(ServerSettingsDMOnline), attributes);
		return properties.Sort(ServerSettings.PropertySortOrder);
	}
}
