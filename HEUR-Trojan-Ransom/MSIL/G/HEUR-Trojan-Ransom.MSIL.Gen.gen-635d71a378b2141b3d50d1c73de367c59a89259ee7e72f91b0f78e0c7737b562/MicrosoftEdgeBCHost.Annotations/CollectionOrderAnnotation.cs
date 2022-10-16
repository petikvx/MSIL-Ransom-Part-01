using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class CollectionOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteLiteralPolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteLiteralPolicy()
	{
	}
}
