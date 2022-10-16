using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DicOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteInterfaceListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteInterfaceListener()
	{
	}
}
