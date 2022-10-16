using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ParamsServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsServer()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeLiteralWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeLiteralWatcher()
	{
	}
}
