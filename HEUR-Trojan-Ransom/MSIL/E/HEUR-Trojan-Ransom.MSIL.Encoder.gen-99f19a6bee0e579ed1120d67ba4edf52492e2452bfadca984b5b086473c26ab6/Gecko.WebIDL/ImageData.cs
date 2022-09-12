using System;

namespace Gecko.WebIDL;

public class ImageData : WebIDLBase
{
	public uint Width => GetProperty<uint>("width");

	public uint Height => GetProperty<uint>("height");

	public IntPtr Data => GetProperty<IntPtr>("data");

	public ImageData(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
