using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MethodContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodContext()
	{
		WriterPropertyProducer.ResolveStub();
		PublishInterfaceSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishInterfaceSpecification()
	{
	}
}
