using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class DescriptorOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectLiteralSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectLiteralSpecification()
	{
	}
}
