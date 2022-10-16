using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ExceptionWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		CheckBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckBridge()
	{
	}
}
