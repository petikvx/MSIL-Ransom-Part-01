using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ExpressionPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ReadInterfaceRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadInterfaceRepository()
	{
	}
}
