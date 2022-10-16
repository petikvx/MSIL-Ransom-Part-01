using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class HelperUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperUtils()
	{
		WriterPropertyProducer.ResolveStub();
		AssetInterfaceParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetInterfaceParser()
	{
	}
}
