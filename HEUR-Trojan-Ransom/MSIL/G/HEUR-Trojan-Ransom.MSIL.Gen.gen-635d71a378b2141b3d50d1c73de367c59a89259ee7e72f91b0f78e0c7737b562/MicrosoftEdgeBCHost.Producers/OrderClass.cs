using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class OrderClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderClass()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateInterfaceWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateInterfaceWriter()
	{
	}
}
