using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ValWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PostInterfaceRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostInterfaceRole()
	{
	}
}
