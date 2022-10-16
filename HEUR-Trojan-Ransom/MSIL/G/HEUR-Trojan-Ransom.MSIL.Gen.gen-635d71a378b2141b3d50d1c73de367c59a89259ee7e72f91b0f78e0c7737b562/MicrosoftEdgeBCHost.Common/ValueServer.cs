using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ValueServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueServer()
	{
		WriterPropertyProducer.ResolveStub();
		EnableLiteralWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableLiteralWatcher()
	{
	}
}
