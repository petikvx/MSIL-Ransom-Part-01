using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ModelPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		DisableInterfaceInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableInterfaceInvocation()
	{
	}
}
