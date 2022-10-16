using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class CollectionFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ResetImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetImporter()
	{
	}
}
