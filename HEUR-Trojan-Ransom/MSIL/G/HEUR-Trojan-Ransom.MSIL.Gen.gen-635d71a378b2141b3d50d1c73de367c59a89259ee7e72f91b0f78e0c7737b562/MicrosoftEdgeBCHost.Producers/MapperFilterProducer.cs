using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MapperFilterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperFilterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CalcProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcProccesor()
	{
	}
}
