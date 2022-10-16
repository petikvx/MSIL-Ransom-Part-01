using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class CollectionRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionRules()
	{
		WriterPropertyProducer.ResolveStub();
		DefineDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineDispatcher()
	{
	}
}
