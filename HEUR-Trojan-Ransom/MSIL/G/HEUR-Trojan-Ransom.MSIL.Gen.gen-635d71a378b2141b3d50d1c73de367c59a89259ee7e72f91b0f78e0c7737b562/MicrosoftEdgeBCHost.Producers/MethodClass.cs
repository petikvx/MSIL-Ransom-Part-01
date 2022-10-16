using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MethodClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodClass()
	{
		WriterPropertyProducer.ResolveStub();
		RevertInterfaceItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertInterfaceItem()
	{
	}
}
