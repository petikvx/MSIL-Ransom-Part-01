using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Stealer_Php.My.Resources;

[CompilerGenerated]
[HideModuleName]
[StandardModule]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
internal sealed class Resources
{
	private static ResourceManager PBnEoueM4tPi0o1IaSidBHVpLAszwfcIQBh3IFAszwfcIQBh3IFA5TSzV4INs1VA;

	private static CultureInfo BQt3KI7NiEeB1BQt3KI7NiEeBAxGcPu4qCVDDSAsck5uhhCGPykAsck5uhhCGPy0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (object.ReferenceEquals(PBnEoueM4tPi0o1IaSidBHVpLAszwfcIQBh3IFAszwfcIQBh3IFA5TSzV4INs1VA, null))
			{
				ResourceManager resourceManager = (PBnEoueM4tPi0o1IaSidBHVpLAszwfcIQBh3IFAszwfcIQBh3IFA5TSzV4INs1VA = new ResourceManager("Stealer_Php.Resources", typeof(Resources).Assembly));
			}
			return PBnEoueM4tPi0o1IaSidBHVpLAszwfcIQBh3IFAszwfcIQBh3IFA5TSzV4INs1VA;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return BQt3KI7NiEeB1BQt3KI7NiEeBAxGcPu4qCVDDSAsck5uhhCGPykAsck5uhhCGPy0;
		}
		set
		{
			BQt3KI7NiEeB1BQt3KI7NiEeBAxGcPu4qCVDDSAsck5uhhCGPykAsck5uhhCGPy0 = value;
		}
	}

	internal static Bitmap login
	{
		get
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("login", BQt3KI7NiEeB1BQt3KI7NiEeBAxGcPu4qCVDDSAsck5uhhCGPykAsck5uhhCGPy0));
			return (Bitmap)objectValue;
		}
	}
}
