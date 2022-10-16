using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class SystemReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemReponse()
	{
		WriterPropertyProducer.ResolveStub();
		RestartLiteralServer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartLiteralServer()
	{
	}
}
