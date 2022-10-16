using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ResolverUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverUtils()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutInterfaceQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutInterfaceQueue()
	{
	}
}
