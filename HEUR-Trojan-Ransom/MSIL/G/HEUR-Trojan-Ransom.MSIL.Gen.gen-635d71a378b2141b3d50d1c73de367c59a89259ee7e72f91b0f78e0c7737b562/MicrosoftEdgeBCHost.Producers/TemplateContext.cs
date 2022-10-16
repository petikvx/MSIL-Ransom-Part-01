using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TemplateContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateContext()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateInterfaceTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateInterfaceTask()
	{
	}
}
