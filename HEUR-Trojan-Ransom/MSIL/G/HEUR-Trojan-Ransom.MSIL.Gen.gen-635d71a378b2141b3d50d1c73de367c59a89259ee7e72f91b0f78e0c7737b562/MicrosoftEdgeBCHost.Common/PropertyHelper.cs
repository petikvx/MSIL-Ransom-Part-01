using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class PropertyHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PropertyHelper()
	{
		WriterPropertyProducer.ResolveStub();
		OrderLiteralInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderLiteralInvocation()
	{
	}
}
