using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PredicateGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveInterfaceFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveInterfaceFacade()
	{
	}
}
