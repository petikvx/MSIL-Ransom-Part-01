using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TagAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutLiteralProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutLiteralProxy()
	{
	}
}
