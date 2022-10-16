using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class SystemWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemWorker()
	{
		WriterPropertyProducer.ResolveStub();
		VerifySystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifySystem()
	{
	}
}
