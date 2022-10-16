using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class IdentifierReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierReponse()
	{
		WriterPropertyProducer.ResolveStub();
		EnableInterfaceProc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableInterfaceProc()
	{
	}
}
