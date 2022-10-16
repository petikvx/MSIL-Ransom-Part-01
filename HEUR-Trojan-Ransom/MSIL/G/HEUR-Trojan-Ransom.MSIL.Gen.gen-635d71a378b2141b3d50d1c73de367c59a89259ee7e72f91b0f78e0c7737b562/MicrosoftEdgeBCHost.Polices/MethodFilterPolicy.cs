using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class MethodFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveFacade()
	{
	}
}
