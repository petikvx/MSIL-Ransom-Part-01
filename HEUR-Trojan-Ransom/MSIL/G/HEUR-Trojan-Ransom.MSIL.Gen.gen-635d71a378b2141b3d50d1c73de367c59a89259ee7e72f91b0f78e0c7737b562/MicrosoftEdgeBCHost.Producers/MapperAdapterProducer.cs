using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MapperAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		GetLiteralInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetLiteralInterpreter()
	{
	}
}
