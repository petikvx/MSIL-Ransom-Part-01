using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class MapGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		StartInterfaceTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartInterfaceTemplate()
	{
	}
}
