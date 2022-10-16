using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class BaseGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		ManageInterfaceComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageInterfaceComparator()
	{
	}
}
