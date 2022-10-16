using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class SetterServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterServer()
	{
		WriterPropertyProducer.ResolveStub();
		DefineLiteralPublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineLiteralPublisher()
	{
	}
}
