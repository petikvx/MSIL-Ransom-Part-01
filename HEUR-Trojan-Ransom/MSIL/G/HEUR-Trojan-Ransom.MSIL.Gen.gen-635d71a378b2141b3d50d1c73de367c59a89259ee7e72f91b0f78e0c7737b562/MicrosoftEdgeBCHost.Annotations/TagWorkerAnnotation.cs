using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class TagWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CompareLiteralIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareLiteralIterator()
	{
	}
}
