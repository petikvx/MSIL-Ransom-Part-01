using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class StructAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeLiteralWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeLiteralWrapper()
	{
	}
}
