using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class FilterValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		FillLiteralValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillLiteralValue()
	{
	}
}
