using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ServiceReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceReponse()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateLiteralFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateLiteralFactory()
	{
	}
}
