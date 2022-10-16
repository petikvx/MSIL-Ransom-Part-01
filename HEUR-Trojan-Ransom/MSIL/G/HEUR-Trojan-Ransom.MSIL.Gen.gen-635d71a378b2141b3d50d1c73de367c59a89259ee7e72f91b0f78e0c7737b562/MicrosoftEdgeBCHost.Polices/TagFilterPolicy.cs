using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TagFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		MapParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapParams()
	{
	}
}
