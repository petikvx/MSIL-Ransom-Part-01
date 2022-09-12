using System;

namespace Gecko.WebIDL;

public class File : WebIDLBase
{
	public string Name => GetProperty<string>("name");

	public long LastModified => GetProperty<long>("lastModified");

	public IntPtr LastModifiedDate => GetProperty<IntPtr>("lastModifiedDate");

	public string Path => GetProperty<string>("path");

	public string MozFullPath => GetProperty<string>("mozFullPath");

	public File(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
