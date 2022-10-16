using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TemplateSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		RunLiteralState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunLiteralState()
	{
	}
}
