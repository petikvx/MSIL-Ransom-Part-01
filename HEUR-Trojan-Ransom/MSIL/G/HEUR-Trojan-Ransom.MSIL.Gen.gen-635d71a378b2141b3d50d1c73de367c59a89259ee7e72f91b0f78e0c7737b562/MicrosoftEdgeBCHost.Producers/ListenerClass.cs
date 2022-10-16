using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ListenerClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerClass()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateInterfaceReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateInterfaceReponse()
	{
	}
}
