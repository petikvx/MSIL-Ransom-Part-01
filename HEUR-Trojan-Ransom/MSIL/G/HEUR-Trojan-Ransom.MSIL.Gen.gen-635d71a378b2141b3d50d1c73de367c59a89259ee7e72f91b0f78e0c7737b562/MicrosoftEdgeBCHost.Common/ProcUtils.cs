using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ProcUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcUtils()
	{
		WriterPropertyProducer.ResolveStub();
		AssetInterfaceResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetInterfaceResolver()
	{
	}
}
