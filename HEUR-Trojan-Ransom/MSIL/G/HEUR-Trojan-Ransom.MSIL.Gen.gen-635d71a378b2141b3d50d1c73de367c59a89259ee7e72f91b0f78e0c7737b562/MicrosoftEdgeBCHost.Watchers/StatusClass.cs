using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class StatusClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusClass()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutInterfaceReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutInterfaceReponse()
	{
	}
}
