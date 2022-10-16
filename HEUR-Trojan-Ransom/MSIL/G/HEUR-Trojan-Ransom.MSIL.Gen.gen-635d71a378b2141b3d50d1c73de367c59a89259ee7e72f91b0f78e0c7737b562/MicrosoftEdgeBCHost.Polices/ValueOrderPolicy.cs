using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ValueOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		FlushLiteralServer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushLiteralServer()
	{
	}
}
