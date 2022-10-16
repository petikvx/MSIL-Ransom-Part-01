using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class EventUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventUtils()
	{
		WriterPropertyProducer.ResolveStub();
		SelectInterfaceGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectInterfaceGlobal()
	{
	}
}
