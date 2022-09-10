using System.Runtime.Serialization;

namespace Microsoft.InfoCards;

internal class UIAgentInitializationException : InfoCardBaseException
{
	private const int HRESULT = -1073413862;

	public UIAgentInitializationException()
		: base(-1073413862)
	{
	}

	protected UIAgentInitializationException(SerializationInfo si, StreamingContext sc)
		: base(-1073413862, si, sc)
	{
	}
}
