using System;
using System.ComponentModel;

namespace Microsoft.VisualStudio.Tools.Applications.ExternalProcess;

[AttributeUsage(AttributeTargets.All)]
internal sealed class StringResourcesCategoryAttribute : CategoryAttribute
{
	public StringResourcesCategoryAttribute(string category)
		: base(category)
	{
	}

	protected override string GetLocalizedString(string value)
	{
		return StringResources.GetString(value);
	}
}
