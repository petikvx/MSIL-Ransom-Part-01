using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class MapperAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		FillLiteralPool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillLiteralPool()
	{
	}
}
