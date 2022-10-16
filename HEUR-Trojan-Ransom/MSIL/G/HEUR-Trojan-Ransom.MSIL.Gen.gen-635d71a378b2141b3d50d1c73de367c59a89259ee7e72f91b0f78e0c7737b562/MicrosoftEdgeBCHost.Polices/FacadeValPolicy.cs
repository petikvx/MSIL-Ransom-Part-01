using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class FacadeValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CloneCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneCallback()
	{
	}
}
