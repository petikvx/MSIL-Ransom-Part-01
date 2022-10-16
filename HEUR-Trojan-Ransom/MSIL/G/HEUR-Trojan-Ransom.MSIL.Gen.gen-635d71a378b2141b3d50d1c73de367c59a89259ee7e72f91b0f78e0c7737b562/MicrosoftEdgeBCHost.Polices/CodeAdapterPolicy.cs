using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class CodeAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeLiteralRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeLiteralRules()
	{
	}
}
