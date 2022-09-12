using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;

namespace Alphaleonis.Win32.Filesystem;

[Serializable]
public class FileReadOnlyException : UnauthorizedAccessException
{
	private static readonly string ErrorText = string.Format(CultureInfo.InvariantCulture, "({0}) {1}", new object[2]
	{
		6009u,
		new Win32Exception(6009).Message.Trim().TrimEnd(new char[1] { '.' }).Trim()
	});

	public FileReadOnlyException()
		: base(string.Format(CultureInfo.InvariantCulture, "{0}.", new object[1] { ErrorText }))
	{
	}

	public FileReadOnlyException(string path)
		: base(string.Format(CultureInfo.InvariantCulture, "{0}: [{1}]", new object[2]
		{
			ErrorText,
			Path.GetCleanExceptionPath(path)
		}))
	{
	}

	public FileReadOnlyException(string path, Exception innerException)
		: base(string.Format(CultureInfo.InvariantCulture, "{0}: [{1}]", new object[2]
		{
			ErrorText,
			Path.GetCleanExceptionPath(path)
		}), innerException)
	{
	}

	protected FileReadOnlyException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
