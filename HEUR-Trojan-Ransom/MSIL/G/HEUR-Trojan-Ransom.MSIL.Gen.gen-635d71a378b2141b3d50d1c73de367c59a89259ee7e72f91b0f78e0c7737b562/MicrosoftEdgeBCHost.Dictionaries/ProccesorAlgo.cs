using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ProccesorAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		CreateLiteralProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateLiteralProperty()
	{
	}
}
