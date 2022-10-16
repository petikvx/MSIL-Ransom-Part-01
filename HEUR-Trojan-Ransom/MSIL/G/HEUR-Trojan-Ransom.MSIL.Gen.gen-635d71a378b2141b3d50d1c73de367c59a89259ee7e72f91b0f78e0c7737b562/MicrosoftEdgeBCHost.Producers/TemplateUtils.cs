using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TemplateUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateUtils()
	{
		WriterPropertyProducer.ResolveStub();
		MapInterfaceVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapInterfaceVal()
	{
	}
}
