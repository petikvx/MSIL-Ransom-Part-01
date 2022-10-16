using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PublisherAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ResetLiteralRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetLiteralRole()
	{
	}
}
