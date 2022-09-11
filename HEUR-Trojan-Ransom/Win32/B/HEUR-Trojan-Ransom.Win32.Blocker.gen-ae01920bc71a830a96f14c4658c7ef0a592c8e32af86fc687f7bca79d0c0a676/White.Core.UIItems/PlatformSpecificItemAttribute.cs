using System;

namespace White.Core.UIItems;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public class PlatformSpecificItemAttribute : Attribute
{
	private Type referAsType;

	public virtual Type ReferAsType
	{
		get
		{
			return referAsType;
		}
		set
		{
			referAsType = value;
		}
	}

	public static Type BaseType(Type type)
	{
		object[] customAttributes = type.GetCustomAttributes(typeof(PlatformSpecificItemAttribute), inherit: false);
		if (customAttributes.Length == 0)
		{
			return type;
		}
		PlatformSpecificItemAttribute platformSpecificItemAttribute = (PlatformSpecificItemAttribute)customAttributes[0];
		return platformSpecificItemAttribute.referAsType ?? BaseType(type.BaseType);
	}
}
