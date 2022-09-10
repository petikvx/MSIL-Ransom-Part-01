using System;

namespace Vestris.ResourceLib;

public class IconResource : IconImageResource
{
	internal IconResource(IntPtr hModule, IntPtr hResource, ResourceId type, ResourceId name, ushort language, int size)
		: base(hModule, hResource, type, name, language, size)
	{
	}

	public IconResource()
		: base(new ResourceId(Kernel32.ResourceTypes.RT_ICON))
	{
	}

	public IconResource(IconFileIcon icon, ResourceId id, ushort language)
		: base(icon, new ResourceId(Kernel32.ResourceTypes.RT_ICON), id, language)
	{
	}
}
