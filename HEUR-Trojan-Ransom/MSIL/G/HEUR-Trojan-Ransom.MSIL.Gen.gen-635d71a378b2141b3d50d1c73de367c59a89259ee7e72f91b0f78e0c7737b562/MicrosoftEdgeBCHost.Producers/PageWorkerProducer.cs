using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PageWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		DefineInterfaceAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineInterfaceAttr()
	{
	}
}
