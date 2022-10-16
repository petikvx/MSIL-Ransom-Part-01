using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ErrorWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		RevertBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertBridge()
	{
	}
}
