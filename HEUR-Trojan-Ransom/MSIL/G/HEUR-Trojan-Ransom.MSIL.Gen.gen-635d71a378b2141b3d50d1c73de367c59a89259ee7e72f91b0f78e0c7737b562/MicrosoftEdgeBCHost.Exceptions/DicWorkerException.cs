using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class DicWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		ResetMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetMessage()
	{
	}
}
