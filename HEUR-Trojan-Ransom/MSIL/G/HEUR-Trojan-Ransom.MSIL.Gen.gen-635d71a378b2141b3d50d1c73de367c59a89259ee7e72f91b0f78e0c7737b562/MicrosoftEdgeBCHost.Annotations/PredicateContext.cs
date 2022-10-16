using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PredicateContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateContext()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeInterfaceToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeInterfaceToken()
	{
	}
}
