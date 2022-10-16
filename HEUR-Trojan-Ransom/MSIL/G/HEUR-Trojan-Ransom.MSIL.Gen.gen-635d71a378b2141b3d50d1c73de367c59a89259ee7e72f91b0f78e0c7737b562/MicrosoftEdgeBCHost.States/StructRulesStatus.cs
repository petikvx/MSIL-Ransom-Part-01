using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class StructRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CheckInterfaceRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckInterfaceRef()
	{
	}
}
