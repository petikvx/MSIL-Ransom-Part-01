using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ContainerOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerOrder()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveRule()
	{
	}
}
