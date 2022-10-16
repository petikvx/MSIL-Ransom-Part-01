using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class OrderPropertyPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderPropertyPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RevertLiteralRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertLiteralRule()
	{
	}
}
