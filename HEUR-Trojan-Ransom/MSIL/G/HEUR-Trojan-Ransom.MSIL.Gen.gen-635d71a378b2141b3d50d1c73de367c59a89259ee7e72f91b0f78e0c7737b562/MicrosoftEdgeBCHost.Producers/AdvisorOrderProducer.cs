using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AdvisorOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyInterfaceReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyInterfaceReponse()
	{
	}
}
