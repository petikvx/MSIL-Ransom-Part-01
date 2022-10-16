using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MapperVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperVal()
	{
		WriterPropertyProducer.ResolveStub();
		InitInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitInfo()
	{
	}
}
