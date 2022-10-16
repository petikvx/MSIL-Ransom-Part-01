using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class DescriptorOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CalcLiteralExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcLiteralExporter()
	{
	}
}
