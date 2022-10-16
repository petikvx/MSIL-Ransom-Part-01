using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class TestProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestProperty()
	{
		WriterPropertyProducer.ResolveStub();
		PublishInterfaceBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishInterfaceBridge()
	{
	}
}
