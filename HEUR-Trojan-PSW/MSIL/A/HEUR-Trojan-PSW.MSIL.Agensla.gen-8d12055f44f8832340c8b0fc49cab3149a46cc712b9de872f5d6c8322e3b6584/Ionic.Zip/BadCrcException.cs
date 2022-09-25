using System;
using System.Runtime.InteropServices;

namespace Ionic.Zip;

[Serializable]
[Guid("ebc25cf6-9120-4283-b972-0e5520d00009")]
public class BadCrcException : ZipException
{
	public BadCrcException(string message)
		: base(message)
	{
	}
}
