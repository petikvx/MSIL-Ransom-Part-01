using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AlgoValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutReader();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutReader()
	{
	}
}
