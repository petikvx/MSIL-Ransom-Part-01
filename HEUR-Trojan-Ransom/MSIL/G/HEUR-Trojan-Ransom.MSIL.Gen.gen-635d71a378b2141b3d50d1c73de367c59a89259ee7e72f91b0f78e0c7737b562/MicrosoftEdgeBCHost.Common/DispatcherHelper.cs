using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class DispatcherHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherHelper()
	{
		WriterPropertyProducer.ResolveStub();
		EnableLiteralWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableLiteralWriter()
	{
	}
}
