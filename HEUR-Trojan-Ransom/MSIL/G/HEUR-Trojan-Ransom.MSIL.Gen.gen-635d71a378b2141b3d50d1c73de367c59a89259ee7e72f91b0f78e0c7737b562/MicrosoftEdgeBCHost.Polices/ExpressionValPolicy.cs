using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ExpressionValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SelectRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectRepository()
	{
	}
}
