using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class CustomerOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		EnableLiteralGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableLiteralGlobal()
	{
	}
}
