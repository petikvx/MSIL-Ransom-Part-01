using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RoleOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		VisitLiteralToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitLiteralToken()
	{
	}
}
