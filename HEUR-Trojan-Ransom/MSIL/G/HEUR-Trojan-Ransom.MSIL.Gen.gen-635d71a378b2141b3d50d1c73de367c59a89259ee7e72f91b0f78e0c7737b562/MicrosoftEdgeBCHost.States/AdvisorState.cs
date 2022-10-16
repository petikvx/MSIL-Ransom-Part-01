using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AdvisorState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorState()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyInterfaceInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyInterfaceInitializer()
	{
	}
}
