using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ParamWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamWorker()
	{
		WriterPropertyProducer.ResolveStub();
		CancelCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelCallback()
	{
	}
}
