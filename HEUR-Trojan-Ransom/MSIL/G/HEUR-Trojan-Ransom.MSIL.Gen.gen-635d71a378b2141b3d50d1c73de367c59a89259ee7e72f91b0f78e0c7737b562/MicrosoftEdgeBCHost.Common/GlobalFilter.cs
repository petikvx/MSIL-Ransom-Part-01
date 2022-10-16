using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class GlobalFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalFilter()
	{
		WriterPropertyProducer.ResolveStub();
		AddPage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddPage()
	{
	}
}
