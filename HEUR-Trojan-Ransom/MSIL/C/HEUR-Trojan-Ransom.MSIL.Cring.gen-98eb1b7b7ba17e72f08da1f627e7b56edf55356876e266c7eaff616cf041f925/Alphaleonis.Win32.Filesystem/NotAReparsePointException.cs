using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;

namespace Alphaleonis.Win32.Filesystem;

[Serializable]
public class NotAReparsePointException : IOException
{
	private static readonly int ErrorCode = Win32Errors.GetHrFromWin32Error(4390u);

	private static readonly string ErrorText = string.Format(CultureInfo.InvariantCulture, "({0}) {1}", new object[2]
	{
		4390u,
		new Win32Exception(4390).Message.Trim().TrimEnd(new char[1] { '.' }).Trim()
	});

	public NotAReparsePointException()
		: base(string.Format(CultureInfo.InvariantCulture, "{0}.", new object[1] { ErrorText }), ErrorCode)
	{
	}

	public NotAReparsePointException(string message, int lastError)
		: base(message, lastError)
	{
	}

	public NotAReparsePointException(string path)
		: base(string.Format(CultureInfo.InvariantCulture, "{0}: [{1}]", new object[2] { ErrorText, path }), ErrorCode)
	{
	}

	public NotAReparsePointException(string path, Exception innerException)
		: base(string.Format(CultureInfo.InvariantCulture, "{0}: [{1}]", new object[2] { ErrorText, path }), innerException)
	{
	}

	protected NotAReparsePointException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
