using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DicReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicReponse()
	{
		WriterPropertyProducer.ResolveStub();
		PostInterfaceConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostInterfaceConsumer()
	{
	}
}
