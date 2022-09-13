using System;
using System.Runtime.Serialization;

namespace Ionic.Zip;

[Serializable]
public class BadCrcException : ZipException
{
	public extern BadCrcException();

	public extern BadCrcException(string message);

	protected extern BadCrcException(SerializationInfo info, StreamingContext context);
}
