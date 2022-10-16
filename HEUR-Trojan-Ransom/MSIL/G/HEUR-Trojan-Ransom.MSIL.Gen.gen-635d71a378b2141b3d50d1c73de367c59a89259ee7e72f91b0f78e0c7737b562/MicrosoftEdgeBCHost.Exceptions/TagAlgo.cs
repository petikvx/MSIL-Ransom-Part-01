using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class TagAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		WriteLiteralDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteLiteralDispatcher()
	{
	}
}
