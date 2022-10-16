using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AdapterSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		RunLiteralGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunLiteralGetter()
	{
	}
}
