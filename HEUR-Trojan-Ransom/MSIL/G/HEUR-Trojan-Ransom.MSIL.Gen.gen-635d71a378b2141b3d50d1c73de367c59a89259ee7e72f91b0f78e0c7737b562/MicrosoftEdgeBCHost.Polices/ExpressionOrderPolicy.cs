using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ExpressionOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CollectInterfaceTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectInterfaceTokenizer()
	{
	}
}
