using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class MapFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		InsertParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertParser()
	{
	}
}
