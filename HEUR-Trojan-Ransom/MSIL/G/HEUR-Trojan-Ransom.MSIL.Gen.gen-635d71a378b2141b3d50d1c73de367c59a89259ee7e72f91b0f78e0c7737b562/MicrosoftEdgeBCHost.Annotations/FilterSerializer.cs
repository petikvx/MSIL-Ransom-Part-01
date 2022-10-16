using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class FilterSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		DefineLiteralGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineLiteralGetter()
	{
	}
}
