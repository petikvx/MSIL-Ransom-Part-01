using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;

namespace Alphaleonis.Win32.Filesystem;

[Serializable]
public class AlreadyExistsException : IOException
{
	private static readonly int ErrorCode = Win32Errors.GetHrFromWin32Error(183u);

	private static readonly string ErrorText = string.Format(CultureInfo.InvariantCulture, "({0}) {1}", new object[2]
	{
		183u,
		new Win32Exception(183).Message.Trim().TrimEnd(new char[1] { '.' }).Trim()
	});

	public AlreadyExistsException()
		: base(string.Format(CultureInfo.InvariantCulture, "{0}.", new object[1] { ErrorText }), ErrorCode)
	{
	}

	public AlreadyExistsException(string message)
		: base(message, ErrorCode)
	{
	}

	[SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "isPath")]
	public AlreadyExistsException(string path, bool isPath)
		: base(string.Format(CultureInfo.InvariantCulture, "{0}: [{1}]", new object[2] { ErrorText, path }), ErrorCode)
	{
	}

	public AlreadyExistsException(string path, Exception innerException)
		: base(string.Format(CultureInfo.InvariantCulture, "{0}: [{1}]", new object[2] { ErrorText, path }), innerException)
	{
	}

	protected AlreadyExistsException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
