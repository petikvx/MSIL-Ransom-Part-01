using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AuthenticationValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CollectAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectAdapter()
	{
	}
}
