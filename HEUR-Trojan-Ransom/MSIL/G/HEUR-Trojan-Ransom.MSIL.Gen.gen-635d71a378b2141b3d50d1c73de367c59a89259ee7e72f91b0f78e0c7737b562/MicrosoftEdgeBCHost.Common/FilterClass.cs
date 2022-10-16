using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class FilterClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterClass()
	{
		WriterPropertyProducer.ResolveStub();
		RestartInterfaceWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartInterfaceWriter()
	{
	}
}
