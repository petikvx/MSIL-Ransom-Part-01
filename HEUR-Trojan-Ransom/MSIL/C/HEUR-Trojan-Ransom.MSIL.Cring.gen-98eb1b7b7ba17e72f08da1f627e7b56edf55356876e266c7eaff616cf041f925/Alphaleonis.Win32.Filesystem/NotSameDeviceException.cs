using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;

namespace Alphaleonis.Win32.Filesystem;

[Serializable]
public class NotSameDeviceException : IOException
{
	private static readonly int ErrorCode = Win32Errors.GetHrFromWin32Error(17u);

	private static readonly string ErrorText = string.Format(CultureInfo.InvariantCulture, "({0}) {1}", new object[2]
	{
		17u,
		new Win32Exception(17).Message.Trim().TrimEnd(new char[1] { '.' }).Trim()
	});

	public NotSameDeviceException()
		: base(Resources.File_Or_Directory_Already_Exists, ErrorCode)
	{
	}

	public NotSameDeviceException(string message)
		: base(message, ErrorCode)
	{
	}

	public NotSameDeviceException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	[SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "isPath")]
	public NotSameDeviceException(string path, bool isPath)
		: base(string.Format(CultureInfo.InvariantCulture, "{0}: [{1}]", new object[2] { ErrorText, path }), ErrorCode)
	{
	}

	protected NotSameDeviceException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
