using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ExpressionWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PostInterfaceAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostInterfaceAdapter()
	{
	}
}
