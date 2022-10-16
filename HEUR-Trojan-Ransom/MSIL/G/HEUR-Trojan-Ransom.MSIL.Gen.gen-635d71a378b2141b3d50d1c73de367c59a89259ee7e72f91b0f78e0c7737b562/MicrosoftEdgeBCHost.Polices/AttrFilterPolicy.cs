using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AttrFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SearchSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchSetter()
	{
	}
}
