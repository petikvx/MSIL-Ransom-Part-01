using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class IteratorRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorRules()
	{
		WriterPropertyProducer.ResolveStub();
		DefineModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineModel()
	{
	}
}
