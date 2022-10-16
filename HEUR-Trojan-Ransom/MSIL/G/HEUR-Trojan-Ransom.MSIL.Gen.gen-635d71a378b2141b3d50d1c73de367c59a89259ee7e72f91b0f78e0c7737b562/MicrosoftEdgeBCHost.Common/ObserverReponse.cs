using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ObserverReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverReponse()
	{
		WriterPropertyProducer.ResolveStub();
		LoginLiteralIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginLiteralIssuer()
	{
	}
}
