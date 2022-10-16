using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AdapterPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateLiteralProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateLiteralProcess()
	{
	}
}
