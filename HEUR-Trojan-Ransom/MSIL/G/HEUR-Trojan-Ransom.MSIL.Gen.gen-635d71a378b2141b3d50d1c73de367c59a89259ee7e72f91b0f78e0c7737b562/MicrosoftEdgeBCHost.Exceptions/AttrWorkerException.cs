using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AttrWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		CalcContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcContext()
	{
	}
}
