using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PropertyAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PropertyAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		PostLiteralEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostLiteralEvent()
	{
	}
}
