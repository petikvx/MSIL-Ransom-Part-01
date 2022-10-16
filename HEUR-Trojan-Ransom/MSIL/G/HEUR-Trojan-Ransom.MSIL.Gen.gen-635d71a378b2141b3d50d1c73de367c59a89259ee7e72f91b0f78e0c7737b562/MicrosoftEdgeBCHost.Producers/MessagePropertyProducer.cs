using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MessagePropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessagePropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		SetupLiteralObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupLiteralObserver()
	{
	}
}
