using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class MapperOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SearchLiteralRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchLiteralRecord()
	{
	}
}
