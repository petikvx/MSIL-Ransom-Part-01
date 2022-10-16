using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RegistryWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		SearchPrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchPrototype()
	{
	}
}
