using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PolicyValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RunToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunToken()
	{
	}
}
