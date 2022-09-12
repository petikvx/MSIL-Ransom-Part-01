using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;

namespace Alphaleonis.Win32.Filesystem;

[Serializable]
public class UnrecognizedReparsePointException : IOException
{
	private static readonly int ErrorCode = Win32Errors.GetHrFromWin32Error(4392u);

	private static readonly string ErrorText = string.Format(CultureInfo.InvariantCulture, "({0}) {1}", new object[2]
	{
		4392u,
		new Win32Exception(4392).Message.Trim().TrimEnd(new char[1] { '.' }).Trim()
	});

	public UnrecognizedReparsePointException()
		: base(string.Format(CultureInfo.InvariantCulture, "{0}.", new object[1] { ErrorText }), ErrorCode)
	{
	}

	public UnrecognizedReparsePointException(string message, int lastError)
		: base(message, lastError)
	{
	}

	public UnrecognizedReparsePointException(string path)
		: base(string.Format(CultureInfo.InvariantCulture, "{0}: [{1}]", new object[2] { ErrorText, path }), ErrorCode)
	{
	}

	public UnrecognizedReparsePointException(string path, Exception innerException)
		: base(string.Format(CultureInfo.InvariantCulture, "{0}: [{1}]", new object[2] { ErrorText, path }), innerException)
	{
	}

	protected UnrecognizedReparsePointException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
