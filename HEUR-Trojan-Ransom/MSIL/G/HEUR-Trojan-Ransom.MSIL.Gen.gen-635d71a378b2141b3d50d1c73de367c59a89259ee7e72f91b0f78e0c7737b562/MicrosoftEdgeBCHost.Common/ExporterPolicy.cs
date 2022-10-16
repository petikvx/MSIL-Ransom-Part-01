using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ExporterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyInterfaceList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyInterfaceList()
	{
	}
}
