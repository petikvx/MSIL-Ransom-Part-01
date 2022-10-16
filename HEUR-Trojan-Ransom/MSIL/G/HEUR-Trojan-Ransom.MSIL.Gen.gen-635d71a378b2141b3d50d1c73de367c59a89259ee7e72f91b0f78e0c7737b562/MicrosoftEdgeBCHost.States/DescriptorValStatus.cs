using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class DescriptorValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		VisitLiteralModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitLiteralModel()
	{
	}
}
