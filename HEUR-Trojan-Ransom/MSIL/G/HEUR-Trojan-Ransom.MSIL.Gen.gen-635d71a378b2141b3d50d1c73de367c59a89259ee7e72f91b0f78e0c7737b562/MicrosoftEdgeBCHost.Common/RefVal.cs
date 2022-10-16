using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RefVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefVal()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterInfo()
	{
	}
}
