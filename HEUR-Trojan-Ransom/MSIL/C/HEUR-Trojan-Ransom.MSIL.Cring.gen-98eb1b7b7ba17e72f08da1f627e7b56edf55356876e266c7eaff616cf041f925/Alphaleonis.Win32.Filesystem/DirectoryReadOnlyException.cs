using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;

namespace Alphaleonis.Win32.Filesystem;

[Serializable]
public class DirectoryReadOnlyException : UnauthorizedAccessException
{
	private static readonly string ErrorText = string.Format(CultureInfo.InvariantCulture, "({0}) {1}", new object[2]
	{
		6009u,
		new Win32Exception(6009).Message.Trim().TrimEnd(new char[1] { '.' }).Trim()
	});

	public DirectoryReadOnlyException()
		: base(string.Format(CultureInfo.InvariantCulture, "{0}.", new object[1] { ErrorText }))
	{
	}

	public DirectoryReadOnlyException(string path)
		: base(string.Format(CultureInfo.InvariantCulture, "{0}: [{1}]", new object[2] { ErrorText, path }))
	{
	}

	public DirectoryReadOnlyException(string path, Exception innerException)
		: base(string.Format(CultureInfo.InvariantCulture, "{0}: [{1}]", new object[2] { ErrorText, path }), innerException)
	{
	}

	protected DirectoryReadOnlyException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
