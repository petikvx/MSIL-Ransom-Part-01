using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DescriptorOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ManageInterfaceReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageInterfaceReponse()
	{
	}
}
