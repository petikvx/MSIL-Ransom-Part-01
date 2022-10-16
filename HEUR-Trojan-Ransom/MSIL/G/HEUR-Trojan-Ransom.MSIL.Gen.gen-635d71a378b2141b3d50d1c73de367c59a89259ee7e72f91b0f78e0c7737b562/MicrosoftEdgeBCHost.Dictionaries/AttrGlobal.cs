using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AttrGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		SetInterfacePage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetInterfacePage()
	{
	}
}
