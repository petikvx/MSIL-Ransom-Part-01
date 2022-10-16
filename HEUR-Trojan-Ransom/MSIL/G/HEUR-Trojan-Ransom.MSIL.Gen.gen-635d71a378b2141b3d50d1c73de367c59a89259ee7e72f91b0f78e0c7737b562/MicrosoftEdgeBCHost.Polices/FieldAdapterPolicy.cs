using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class FieldAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralWrapper()
	{
	}
}
