using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MapAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CallLiteralRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallLiteralRef()
	{
	}
}
