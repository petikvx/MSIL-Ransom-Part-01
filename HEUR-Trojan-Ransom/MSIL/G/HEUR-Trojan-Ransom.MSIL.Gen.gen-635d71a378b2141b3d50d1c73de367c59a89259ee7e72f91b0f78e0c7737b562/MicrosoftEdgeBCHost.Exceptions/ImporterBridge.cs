using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ImporterBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterBridge()
	{
		WriterPropertyProducer.ResolveStub();
		PopVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopVal()
	{
	}
}
