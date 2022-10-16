using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AdvisorPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		FindInterfaceSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindInterfaceSystem()
	{
	}
}
