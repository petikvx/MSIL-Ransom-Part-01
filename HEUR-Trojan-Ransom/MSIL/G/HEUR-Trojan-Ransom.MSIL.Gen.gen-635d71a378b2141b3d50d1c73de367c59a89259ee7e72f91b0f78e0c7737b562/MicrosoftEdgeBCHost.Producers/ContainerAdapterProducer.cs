using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ContainerAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		PopLiteralAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopLiteralAuthentication()
	{
	}
}
