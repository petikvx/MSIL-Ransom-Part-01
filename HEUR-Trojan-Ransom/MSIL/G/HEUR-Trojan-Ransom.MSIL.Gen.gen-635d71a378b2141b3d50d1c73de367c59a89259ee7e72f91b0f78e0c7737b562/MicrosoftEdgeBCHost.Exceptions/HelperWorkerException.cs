using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class HelperWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		ViewMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewMessage()
	{
	}
}
