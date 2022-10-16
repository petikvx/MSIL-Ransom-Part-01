using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class DefinitionWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		StartPrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartPrototype()
	{
	}
}
