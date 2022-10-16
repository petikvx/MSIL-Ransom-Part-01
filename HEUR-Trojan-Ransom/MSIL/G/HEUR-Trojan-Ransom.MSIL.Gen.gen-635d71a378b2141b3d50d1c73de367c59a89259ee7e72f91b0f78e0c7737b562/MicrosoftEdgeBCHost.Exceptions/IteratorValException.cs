using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class IteratorValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorValException()
	{
		WriterPropertyProducer.ResolveStub();
		QueryCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryCode()
	{
	}
}
