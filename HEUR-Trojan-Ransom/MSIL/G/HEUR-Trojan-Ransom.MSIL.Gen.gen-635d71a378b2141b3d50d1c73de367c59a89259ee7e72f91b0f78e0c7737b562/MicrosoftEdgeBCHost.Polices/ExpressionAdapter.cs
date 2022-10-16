using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ExpressionAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		SortInterfaceManager();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortInterfaceManager()
	{
	}
}
