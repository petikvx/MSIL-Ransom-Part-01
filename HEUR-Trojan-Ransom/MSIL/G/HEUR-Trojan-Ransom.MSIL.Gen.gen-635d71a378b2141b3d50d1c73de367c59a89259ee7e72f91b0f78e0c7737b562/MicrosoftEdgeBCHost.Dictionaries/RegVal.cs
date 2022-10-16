using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RegVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegVal()
	{
		WriterPropertyProducer.ResolveStub();
		DefineRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineRequest()
	{
	}
}
