using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Ionic.Zip;

[Serializable]
[Guid("ebc25cf6-9120-4283-b972-0e5520d00008")]
public class SfxGenerationException : ZipException
{
	public extern SfxGenerationException();

	public extern SfxGenerationException(string message);

	protected extern SfxGenerationException(SerializationInfo info, StreamingContext context);
}
