using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class GetterBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterBridge()
	{
		WriterPropertyProducer.ResolveStub();
		InitDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitDefinition()
	{
	}
}
