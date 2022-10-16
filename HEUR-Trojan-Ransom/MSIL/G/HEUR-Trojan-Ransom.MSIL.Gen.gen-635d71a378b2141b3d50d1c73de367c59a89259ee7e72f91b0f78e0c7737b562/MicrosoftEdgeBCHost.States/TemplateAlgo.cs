using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class TemplateAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeLiteralParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeLiteralParam()
	{
	}
}
