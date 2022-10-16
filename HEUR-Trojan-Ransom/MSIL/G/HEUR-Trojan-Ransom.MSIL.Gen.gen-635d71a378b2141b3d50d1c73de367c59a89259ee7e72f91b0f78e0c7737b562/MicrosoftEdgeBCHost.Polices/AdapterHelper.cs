using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AdapterHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterHelper()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeLiteralInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeLiteralInvocation()
	{
	}
}
