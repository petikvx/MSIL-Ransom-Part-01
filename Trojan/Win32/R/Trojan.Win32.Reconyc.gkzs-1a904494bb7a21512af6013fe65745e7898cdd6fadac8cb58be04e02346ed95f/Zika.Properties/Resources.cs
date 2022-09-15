using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Zika.Properties;

[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
internal class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (resourceMan == null)
			{
				resourceMan = new ResourceManager("Zika.Properties.Resources", typeof(Resources).Assembly);
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

	internal static byte[] AxInterop_WMPLib => (byte[])ResourceManager.GetObject("AxInterop_WMPLib", resourceCulture);

	internal static UnmanagedMemoryStream beep => ResourceManager.GetStream("beep", resourceCulture);

	internal static byte[] Interop_WMPLib => (byte[])ResourceManager.GetObject("Interop_WMPLib", resourceCulture);

	internal static UnmanagedMemoryStream NavaShield_Delete_C => ResourceManager.GetStream("NavaShield_Delete_C", resourceCulture);

	internal static UnmanagedMemoryStream NavaShield_Laugh_1 => ResourceManager.GetStream("NavaShield_Laugh_1", resourceCulture);

	internal static UnmanagedMemoryStream NavaShield_Laugh_2 => ResourceManager.GetStream("NavaShield_Laugh_2", resourceCulture);

	internal static UnmanagedMemoryStream pig => ResourceManager.GetStream("pig", resourceCulture);

	internal static byte[] ResHacker => (byte[])ResourceManager.GetObject("ResHacker", resourceCulture);

	internal static byte[] ResourceHacker => (byte[])ResourceManager.GetObject("ResourceHacker", resourceCulture);

	internal Resources()
	{
	}
}
