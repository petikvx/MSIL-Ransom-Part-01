using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class DescriptorExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorExpression()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralGlobal()
	{
	}
}
