using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class SchemaRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		FindInterfaceTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindInterfaceTask()
	{
	}
}
