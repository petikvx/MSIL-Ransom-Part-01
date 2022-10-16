using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class StatusOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		StopLiteralManager();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopLiteralManager()
	{
	}
}
