using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProcWrapperStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcWrapperStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatTest()
	{
	}
}
