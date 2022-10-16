using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class TaskValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CalcLiteralVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcLiteralVal()
	{
	}
}
