using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class DispatcherProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherProperty()
	{
		WriterPropertyProducer.ResolveStub();
		AssetInterfaceImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetInterfaceImporter()
	{
	}
}
