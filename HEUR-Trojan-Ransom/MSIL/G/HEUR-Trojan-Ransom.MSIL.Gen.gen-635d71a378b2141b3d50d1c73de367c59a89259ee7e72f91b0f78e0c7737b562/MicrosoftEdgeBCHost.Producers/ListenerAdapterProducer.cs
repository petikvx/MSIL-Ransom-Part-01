using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ListenerAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		StartLiteralAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartLiteralAdapter()
	{
	}
}
