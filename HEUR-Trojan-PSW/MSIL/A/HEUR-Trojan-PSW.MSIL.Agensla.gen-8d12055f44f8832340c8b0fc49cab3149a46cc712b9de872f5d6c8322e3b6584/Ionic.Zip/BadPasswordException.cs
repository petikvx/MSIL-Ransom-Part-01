using System;
using System.Runtime.InteropServices;

namespace Ionic.Zip;

[Serializable]
[Guid("ebc25cf6-9120-4283-b972-0e5520d0000B")]
public class BadPasswordException : ZipException
{
	public BadPasswordException()
	{
	}

	public BadPasswordException(string message)
		: base(message)
	{
	}
}
