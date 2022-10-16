using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class StructRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		PopInterfaceInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopInterfaceInterpreter()
	{
	}
}
