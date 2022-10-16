using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RepositoryUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryUtils()
	{
		WriterPropertyProducer.ResolveStub();
		AssetInterfaceCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetInterfaceCollection()
	{
	}
}
