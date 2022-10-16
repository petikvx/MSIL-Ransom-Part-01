using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TokenUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenUtils()
	{
		WriterPropertyProducer.ResolveStub();
		CollectInterfaceMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectInterfaceMapper()
	{
	}
}
