using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class BaseReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseReponse()
	{
		WriterPropertyProducer.ResolveStub();
		DefineLiteralServer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineLiteralServer()
	{
	}
}
