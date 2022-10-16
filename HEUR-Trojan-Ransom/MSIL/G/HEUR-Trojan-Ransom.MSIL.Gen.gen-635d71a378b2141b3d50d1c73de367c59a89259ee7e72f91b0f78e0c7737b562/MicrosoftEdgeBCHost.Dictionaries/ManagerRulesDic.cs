using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ManagerRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInterfaceList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInterfaceList()
	{
	}
}
