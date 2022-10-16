using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class VisitorHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorHelper()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeLiteralHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeLiteralHelper()
	{
	}
}
