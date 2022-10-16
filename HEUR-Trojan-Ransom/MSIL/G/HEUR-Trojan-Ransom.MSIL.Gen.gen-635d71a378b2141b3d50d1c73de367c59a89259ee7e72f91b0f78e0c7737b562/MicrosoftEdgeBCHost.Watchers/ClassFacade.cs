using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ClassFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassFacade()
	{
		WriterPropertyProducer.ResolveStub();
		CompareLiteralPolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareLiteralPolicy()
	{
	}
}
