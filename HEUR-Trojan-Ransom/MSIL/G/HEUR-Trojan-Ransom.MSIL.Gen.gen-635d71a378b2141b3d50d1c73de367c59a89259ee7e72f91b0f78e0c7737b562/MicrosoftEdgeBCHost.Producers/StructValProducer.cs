using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class StructValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyAuthentication()
	{
	}
}
