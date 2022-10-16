using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ServerFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutAlgo()
	{
	}
}
