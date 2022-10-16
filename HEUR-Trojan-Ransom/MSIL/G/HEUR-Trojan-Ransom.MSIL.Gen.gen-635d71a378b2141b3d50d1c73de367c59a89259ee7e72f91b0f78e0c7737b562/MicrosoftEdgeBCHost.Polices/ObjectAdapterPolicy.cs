using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ObjectAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		StopLiteralContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopLiteralContext()
	{
	}
}
