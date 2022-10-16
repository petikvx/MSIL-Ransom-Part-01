using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ParameterSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		FindLiteralBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindLiteralBroadcaster()
	{
	}
}
