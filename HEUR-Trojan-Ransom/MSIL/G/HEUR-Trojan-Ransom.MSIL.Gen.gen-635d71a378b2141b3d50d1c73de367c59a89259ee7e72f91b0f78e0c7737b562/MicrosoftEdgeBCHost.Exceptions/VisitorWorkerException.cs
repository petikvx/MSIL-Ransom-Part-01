using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class VisitorWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeComposer()
	{
	}
}
