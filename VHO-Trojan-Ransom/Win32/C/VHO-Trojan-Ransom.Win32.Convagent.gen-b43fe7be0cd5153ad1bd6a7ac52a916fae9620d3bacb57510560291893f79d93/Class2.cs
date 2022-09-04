using System;

internal class Class2
{
	public static string smethod_0(Type type_0)
	{
		object[] customAttributes = type_0.GetCustomAttributes(typeof(GClass3.InterfaceVersionAttribute), inherit: false);
		int num = 0;
		if (0 >= customAttributes.Length)
		{
			throw new Exception("Version identifier not found for class " + type_0);
		}
		GClass3.InterfaceVersionAttribute interfaceVersionAttribute = (GClass3.InterfaceVersionAttribute)customAttributes[num];
		return interfaceVersionAttribute.method_0();
	}
}
