using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class FacadeContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeContext()
	{
		WriterPropertyProducer.ResolveStub();
		ManageInterfacePublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageInterfacePublisher()
	{
	}
}
