using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class IdentifierWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		SortDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortDescriptor()
	{
	}
}
