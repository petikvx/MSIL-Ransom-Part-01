using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Ionic.Zip;

[Serializable]
[Guid("ebc25cf6-9120-4283-b972-0e5520d00007")]
public class BadStateException : ZipException
{
	public extern BadStateException();

	public extern BadStateException(string message);

	public extern BadStateException(string message, Exception innerException);

	protected extern BadStateException(SerializationInfo info, StreamingContext context);
}
