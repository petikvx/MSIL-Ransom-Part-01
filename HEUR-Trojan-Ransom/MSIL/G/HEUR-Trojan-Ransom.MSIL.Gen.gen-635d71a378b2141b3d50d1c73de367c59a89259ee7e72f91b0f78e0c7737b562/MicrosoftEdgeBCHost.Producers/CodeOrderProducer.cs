using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class CodeOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		InsertInterfaceProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertInterfaceProducer()
	{
	}
}
