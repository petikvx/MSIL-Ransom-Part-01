using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ExceptionPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		MoveInterfaceProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveInterfaceProcess()
	{
	}
}
