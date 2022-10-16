using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ValValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutState()
	{
	}
}
