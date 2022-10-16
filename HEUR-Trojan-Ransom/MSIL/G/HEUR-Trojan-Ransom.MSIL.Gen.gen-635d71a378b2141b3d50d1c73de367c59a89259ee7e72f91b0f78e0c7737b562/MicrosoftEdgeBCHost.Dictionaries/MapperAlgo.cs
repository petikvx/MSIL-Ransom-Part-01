using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MapperAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		ReadLiteralParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadLiteralParam()
	{
	}
}
