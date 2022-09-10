using System.ComponentModel;

namespace System.Configuration.InstallUtilResources;

[AttributeUsage(AttributeTargets.All)]
internal sealed class ResCategoryAttribute : CategoryAttribute
{
	public ResCategoryAttribute(string category)
		: base(category)
	{
	}

	protected override string GetLocalizedString(string value)
	{
		return Res.GetString(value);
	}
}
