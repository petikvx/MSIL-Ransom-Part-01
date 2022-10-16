using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class WriterFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterFilter()
	{
		WriterPropertyProducer.ResolveStub();
		LoginConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginConfig()
	{
	}
}
