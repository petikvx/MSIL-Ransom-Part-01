using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AdvisorContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorContext()
	{
		WriterPropertyProducer.ResolveStub();
		ReadInterfaceRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadInterfaceRequest()
	{
	}
}
