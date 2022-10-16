using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ReponseOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutInterfaceFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutInterfaceFilter()
	{
	}
}
