using Aspect;
using Entity;
using Entity.Attribute;

[LogAspect]
[CanExecute]
public class GClass10
{
	[CanExecute]
	public WarrantyInfo method_0(string string_0)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		return (WarrantyInfo)Class29.smethod_0(7463893, this, string_0);
	}

	[CanExecute]
	public ProductRegistrationInfo method_1(string string_0)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		return (ProductRegistrationInfo)Class29.smethod_0(7463269, this, string_0);
	}

	[CanExecute]
	public ConfigurationHistoryInfo method_2()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		return (ConfigurationHistoryInfo)Class29.smethod_0(7466730, this, null);
	}
}
