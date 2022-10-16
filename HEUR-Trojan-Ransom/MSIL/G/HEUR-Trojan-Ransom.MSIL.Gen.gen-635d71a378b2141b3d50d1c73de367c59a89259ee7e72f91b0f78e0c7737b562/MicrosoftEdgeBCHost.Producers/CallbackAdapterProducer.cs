using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class CallbackAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		DefineLiteralConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineLiteralConfiguration()
	{
	}
}
