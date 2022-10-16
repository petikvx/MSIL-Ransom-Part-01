using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ComparatorGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		FindInterfacePage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindInterfacePage()
	{
	}
}
