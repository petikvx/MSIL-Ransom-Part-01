using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TestAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeLiteralConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeLiteralConfig()
	{
	}
}
