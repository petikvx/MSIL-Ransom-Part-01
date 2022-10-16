using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RefProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefProperty()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateInterfaceSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateInterfaceSetter()
	{
	}
}
