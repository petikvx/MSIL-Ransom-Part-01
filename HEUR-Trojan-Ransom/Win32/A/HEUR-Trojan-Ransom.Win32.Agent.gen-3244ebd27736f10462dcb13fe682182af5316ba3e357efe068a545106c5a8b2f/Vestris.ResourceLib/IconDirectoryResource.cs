using System;

namespace Vestris.ResourceLib;

public class IconDirectoryResource : DirectoryResource<IconResource>
{
	internal IconDirectoryResource(IntPtr hModule, IntPtr hResource, ResourceId type, ResourceId name, ushort language, int size)
		: base(hModule, hResource, type, name, language, size)
	{
	}

	public IconDirectoryResource()
		: base(Kernel32.ResourceTypes.RT_GROUP_ICON)
	{
	}

	public IconDirectoryResource(IconFile iconFile)
		: base(Kernel32.ResourceTypes.RT_GROUP_ICON)
	{
		for (ushort num = 0; num < iconFile.Icons.Count; num = (ushort)(num + 1))
		{
			IconResource item = new IconResource(iconFile.Icons[num], new ResourceId(num), _language);
			base.Icons.Add(item);
		}
	}
}
