using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MerchantAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		LoginLiteralMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginLiteralMap()
	{
	}
}
