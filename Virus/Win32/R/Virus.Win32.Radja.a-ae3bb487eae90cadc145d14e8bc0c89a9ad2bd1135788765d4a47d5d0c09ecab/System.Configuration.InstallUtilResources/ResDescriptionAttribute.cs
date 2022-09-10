using System.ComponentModel;

namespace System.Configuration.InstallUtilResources;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.ReturnValue)]
internal sealed class ResDescriptionAttribute : DescriptionAttribute
{
	private bool replaced = false;

	public override string Description
	{
		get
		{
			if (!replaced)
			{
				replaced = true;
				base.DescriptionValue = Res.GetString(base.Description);
			}
			return base.Description;
		}
	}

	public ResDescriptionAttribute(string description)
		: base(description)
	{
	}
}
