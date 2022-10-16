using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ParameterFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		SetInterfaceProc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetInterfaceProc()
	{
	}
}
