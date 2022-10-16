using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RegValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutInterfaceManager();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutInterfaceManager()
	{
	}
}
