using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ClassRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RevertItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertItem()
	{
	}
}
