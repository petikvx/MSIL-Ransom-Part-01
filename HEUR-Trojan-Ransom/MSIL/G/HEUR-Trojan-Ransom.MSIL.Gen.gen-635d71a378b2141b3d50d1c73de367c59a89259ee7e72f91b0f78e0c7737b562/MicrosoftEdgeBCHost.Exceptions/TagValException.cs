using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class TagValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagValException()
	{
		WriterPropertyProducer.ResolveStub();
		SortAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortAlgo()
	{
	}
}
