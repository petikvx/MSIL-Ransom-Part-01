using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class BaseRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		ListInterfaceInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListInterfaceInterpreter()
	{
	}
}
