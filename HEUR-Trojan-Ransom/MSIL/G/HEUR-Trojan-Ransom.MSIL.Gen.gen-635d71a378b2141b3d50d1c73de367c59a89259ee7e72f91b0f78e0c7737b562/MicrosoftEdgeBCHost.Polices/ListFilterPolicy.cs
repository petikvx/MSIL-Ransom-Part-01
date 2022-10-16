using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ListFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SelectSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectSchema()
	{
	}
}
