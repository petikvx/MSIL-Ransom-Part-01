using System;
using System.ComponentModel;

namespace Microsoft.VisualStudio.Tools.Applications.ExternalProcess;

[AttributeUsage(AttributeTargets.All)]
internal sealed class StringResourcesDescriptionAttribute : DescriptionAttribute
{
	private bool replaced;

	public override string Description
	{
		get
		{
			if (!replaced)
			{
				replaced = true;
				base.DescriptionValue = StringResources.GetString(base.Description);
			}
			return base.Description;
		}
	}

	public StringResourcesDescriptionAttribute(string description)
		: base(description)
	{
	}
}
