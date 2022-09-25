using System;

namespace Ionic.Zlib;

public class ZlibException : Exception
{
	public ZlibException()
	{
	}

	public ZlibException(string s)
		: base(s)
	{
	}
}
