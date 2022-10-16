using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class UtilsBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsBridge()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeExporter()
	{
	}
}
