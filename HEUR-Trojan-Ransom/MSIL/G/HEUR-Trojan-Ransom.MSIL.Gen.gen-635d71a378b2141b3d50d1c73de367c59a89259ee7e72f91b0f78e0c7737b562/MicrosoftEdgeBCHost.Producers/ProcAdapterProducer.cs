using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ProcAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		InitLiteralRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitLiteralRequest()
	{
	}
}
