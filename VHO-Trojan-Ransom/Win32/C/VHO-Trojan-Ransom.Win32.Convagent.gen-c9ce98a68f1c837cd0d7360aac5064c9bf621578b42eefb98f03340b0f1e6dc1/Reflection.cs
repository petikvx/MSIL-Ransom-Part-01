using System;
using System.Reflection;

public static class Reflection
{
	public static void CopyProperties(this object source, object destination)
	{
		if (source != null && destination != null)
		{
			Type type = destination.GetType();
			PropertyInfo[] properties = source.GetType().GetProperties();
			foreach (PropertyInfo propertyInfo in properties)
			{
				if (propertyInfo.CanRead)
				{
					PropertyInfo property = type.GetProperty(propertyInfo.Name);
					if (!(property == null) && property.CanWrite && (!(property.GetSetMethod(nonPublic: true) != null) || !property.GetSetMethod(nonPublic: true)!.IsPrivate) && (property.GetSetMethod()!.Attributes & MethodAttributes.Static) == 0 && property.PropertyType.IsAssignableFrom(propertyInfo.PropertyType))
					{
						property.SetValue(destination, propertyInfo.GetValue(source, null), null);
					}
				}
			}
			return;
		}
		throw new Exception("Source or/and Destination Objects are null");
	}
}
