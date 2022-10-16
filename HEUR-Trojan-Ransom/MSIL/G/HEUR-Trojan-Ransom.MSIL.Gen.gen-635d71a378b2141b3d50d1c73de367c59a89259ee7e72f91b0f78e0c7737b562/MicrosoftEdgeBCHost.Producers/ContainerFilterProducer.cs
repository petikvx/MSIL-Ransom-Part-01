using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal sealed class ContainerFilterProducer
{
	internal static object m_Utils;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerFilterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		DisableServer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableServer()
	{
	}
}
