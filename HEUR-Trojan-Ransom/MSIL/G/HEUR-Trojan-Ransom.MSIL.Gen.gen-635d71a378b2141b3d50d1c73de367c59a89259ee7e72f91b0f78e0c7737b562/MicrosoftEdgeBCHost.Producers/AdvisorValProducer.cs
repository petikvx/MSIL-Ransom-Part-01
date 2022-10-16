using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AdvisorValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		FillClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillClient()
	{
	}
}
