using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class DecoratorContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorContext()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterInterfaceTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterInterfaceTask()
	{
	}
}
