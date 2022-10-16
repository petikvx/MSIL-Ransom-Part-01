using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TemplateValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateInfo()
	{
	}
}
