using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class CallbackFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		VisitProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitProxy()
	{
	}
}
