using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;

namespace Alphaleonis.Win32.Filesystem;

[Serializable]
public class DeviceNotReadyException : IOException
{
	private static readonly int ErrorCode = Win32Errors.GetHrFromWin32Error(21u);

	private static readonly string ErrorText = string.Format(CultureInfo.InvariantCulture, "({0}) {1}", new object[2]
	{
		21u,
		new Win32Exception(21).Message.Trim().TrimEnd(new char[1] { '.' }).Trim()
	});

	public DeviceNotReadyException()
		: base(string.Format(CultureInfo.InvariantCulture, "{0}.", new object[1] { ErrorText }), ErrorCode)
	{
	}

	public DeviceNotReadyException(string message)
		: base(message, ErrorCode)
	{
	}

	[SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "isPath")]
	public DeviceNotReadyException(string path, bool isPath)
		: base(string.Format(CultureInfo.InvariantCulture, "{0}: [{1}]", new object[2]
		{
			ErrorText,
			Path.GetCleanExceptionPath(path)
		}), ErrorCode)
	{
	}

	public DeviceNotReadyException(string path, Exception innerException)
		: base(string.Format(CultureInfo.InvariantCulture, "{0}: [{1}]", new object[2]
		{
			ErrorText,
			Path.GetCleanExceptionPath(path)
		}), innerException)
	{
	}

	protected DeviceNotReadyException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
