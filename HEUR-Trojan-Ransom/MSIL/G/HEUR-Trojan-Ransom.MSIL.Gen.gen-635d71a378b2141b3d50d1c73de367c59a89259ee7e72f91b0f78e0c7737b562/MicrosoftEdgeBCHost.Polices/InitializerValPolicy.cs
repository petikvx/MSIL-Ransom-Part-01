using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class InitializerValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateBase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateBase()
	{
	}
}
