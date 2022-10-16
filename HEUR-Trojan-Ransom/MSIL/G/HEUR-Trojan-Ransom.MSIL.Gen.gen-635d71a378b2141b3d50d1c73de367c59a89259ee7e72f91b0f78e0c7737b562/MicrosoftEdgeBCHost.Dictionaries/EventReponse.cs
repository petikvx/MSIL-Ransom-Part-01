using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class EventReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventReponse()
	{
		WriterPropertyProducer.ResolveStub();
		PushLiteralConnection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushLiteralConnection()
	{
	}
}
