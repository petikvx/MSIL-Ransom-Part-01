using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TaskRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveInterfaceMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveInterfaceMock()
	{
	}
}
