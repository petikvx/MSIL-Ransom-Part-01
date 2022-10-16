using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ListenerReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerReponse()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyLiteralManager();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyLiteralManager()
	{
	}
}
