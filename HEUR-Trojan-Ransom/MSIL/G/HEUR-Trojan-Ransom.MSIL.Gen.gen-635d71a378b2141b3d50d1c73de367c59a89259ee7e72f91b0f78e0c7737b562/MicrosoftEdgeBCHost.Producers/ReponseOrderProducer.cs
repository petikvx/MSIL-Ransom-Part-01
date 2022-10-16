using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ReponseOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		FlushInterfaceParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushInterfaceParam()
	{
	}
}
