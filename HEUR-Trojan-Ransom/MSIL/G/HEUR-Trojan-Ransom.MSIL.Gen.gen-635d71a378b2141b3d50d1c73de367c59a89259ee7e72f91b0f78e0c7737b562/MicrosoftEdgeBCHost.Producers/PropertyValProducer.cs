using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PropertyValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PropertyValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectState()
	{
	}
}
