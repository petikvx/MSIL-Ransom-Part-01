using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class VisitorWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInterfaceInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInterfaceInitializer()
	{
	}
}
