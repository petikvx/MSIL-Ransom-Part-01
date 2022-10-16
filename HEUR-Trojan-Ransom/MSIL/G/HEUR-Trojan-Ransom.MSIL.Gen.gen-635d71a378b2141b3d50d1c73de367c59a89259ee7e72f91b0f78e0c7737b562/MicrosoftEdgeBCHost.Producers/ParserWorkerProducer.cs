using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ParserWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		OrderInterfaceDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderInterfaceDic()
	{
	}
}
