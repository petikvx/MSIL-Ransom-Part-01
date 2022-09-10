using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace hack.My.Resources;

[CompilerGenerated]
[StandardModule]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
[HideModuleName]
internal sealed class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (object.ReferenceEquals(resourceMan, null))
			{
				ResourceManager resourceManager = (resourceMan = new ResourceManager("hack.Resources", typeof(Resources).Assembly));
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static Bitmap background2
	{
		get
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("background2", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	internal static byte[] contumi
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("contumi", resourceCulture));
			return (byte[])objectValue;
		}
	}

	internal static Bitmap hack_it_button
	{
		get
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("hack_it_button", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	internal static byte[] Java_Update
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Java_Update", resourceCulture));
			return (byte[])objectValue;
		}
	}

	internal static Bitmap lolhack_project
	{
		get
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("lolhack project", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	internal static Bitmap progressbar
	{
		get
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("progressbar", resourceCulture));
			return (Bitmap)objectValue;
		}
	}
}
