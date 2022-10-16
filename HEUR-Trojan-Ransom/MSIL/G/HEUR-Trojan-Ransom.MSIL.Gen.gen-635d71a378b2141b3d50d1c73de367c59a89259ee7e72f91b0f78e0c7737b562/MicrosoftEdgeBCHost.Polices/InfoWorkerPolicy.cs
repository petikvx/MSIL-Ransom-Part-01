using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class InfoWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		DisableInterfaceAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableInterfaceAuthentication()
	{
	}
}
