using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class SetterFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatInterfaceStub();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatInterfaceStub()
	{
	}
}
