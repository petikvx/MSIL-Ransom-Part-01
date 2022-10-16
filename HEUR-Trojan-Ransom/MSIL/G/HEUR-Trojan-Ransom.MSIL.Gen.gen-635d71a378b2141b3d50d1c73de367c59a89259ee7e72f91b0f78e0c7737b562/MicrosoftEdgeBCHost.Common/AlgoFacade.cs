using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AlgoFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoFacade()
	{
		WriterPropertyProducer.ResolveStub();
		FillLiteralClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillLiteralClass()
	{
	}
}
