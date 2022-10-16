using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class IteratorAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatInterfaceIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatInterfaceIdentifier()
	{
	}
}
