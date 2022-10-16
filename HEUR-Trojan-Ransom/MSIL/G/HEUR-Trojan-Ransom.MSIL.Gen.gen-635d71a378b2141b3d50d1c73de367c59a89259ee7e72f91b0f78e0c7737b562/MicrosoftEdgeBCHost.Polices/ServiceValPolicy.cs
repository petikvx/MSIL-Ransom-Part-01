using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ServiceValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PatchInterfaceFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchInterfaceFactory()
	{
	}
}
