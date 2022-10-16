using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TemplateAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateLiteralPredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateLiteralPredicate()
	{
	}
}
