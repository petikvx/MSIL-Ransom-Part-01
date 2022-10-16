using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class InstanceAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralConfig()
	{
	}
}
