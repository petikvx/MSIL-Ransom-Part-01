using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ClientReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientReponse()
	{
		WriterPropertyProducer.ResolveStub();
		DisableLiteralInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableLiteralInstance()
	{
	}
}
