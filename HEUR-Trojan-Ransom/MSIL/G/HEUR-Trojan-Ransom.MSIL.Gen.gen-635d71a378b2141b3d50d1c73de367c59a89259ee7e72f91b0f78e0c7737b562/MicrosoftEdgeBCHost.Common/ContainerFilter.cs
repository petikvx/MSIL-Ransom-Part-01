using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ContainerFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerFilter()
	{
		WriterPropertyProducer.ResolveStub();
		MoveIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveIterator()
	{
	}
}
