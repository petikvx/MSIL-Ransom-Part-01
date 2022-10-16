using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class FacadeAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CallLiteralBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallLiteralBridge()
	{
	}
}
