using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ExpressionAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		WriteLiteralParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteLiteralParam()
	{
	}
}
