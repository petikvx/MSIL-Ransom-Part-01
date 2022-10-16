using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class OrderHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderHelper()
	{
		WriterPropertyProducer.ResolveStub();
		PatchLiteralInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchLiteralInvocation()
	{
	}
}
