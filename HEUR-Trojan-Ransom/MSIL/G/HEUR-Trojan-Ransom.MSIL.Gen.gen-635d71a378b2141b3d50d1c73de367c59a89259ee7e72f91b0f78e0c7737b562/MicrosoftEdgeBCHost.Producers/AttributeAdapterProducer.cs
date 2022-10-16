using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AttributeAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CollectLiteralRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectLiteralRequest()
	{
	}
}
