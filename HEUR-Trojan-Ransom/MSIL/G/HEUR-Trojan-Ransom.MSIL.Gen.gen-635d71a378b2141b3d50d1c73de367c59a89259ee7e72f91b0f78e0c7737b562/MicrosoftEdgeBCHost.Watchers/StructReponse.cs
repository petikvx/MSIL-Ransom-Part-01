using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class StructReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructReponse()
	{
		WriterPropertyProducer.ResolveStub();
		LoginLiteralServer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginLiteralServer()
	{
	}
}
