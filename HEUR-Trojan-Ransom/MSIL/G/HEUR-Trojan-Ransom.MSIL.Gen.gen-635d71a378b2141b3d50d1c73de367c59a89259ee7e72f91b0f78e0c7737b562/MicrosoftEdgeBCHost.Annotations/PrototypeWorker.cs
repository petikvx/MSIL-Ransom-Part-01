using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PrototypeWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeWorker()
	{
		WriterPropertyProducer.ResolveStub();
		DisableInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableInvocation()
	{
	}
}
