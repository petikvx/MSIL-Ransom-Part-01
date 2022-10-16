using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class WrapperVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperVal()
	{
		WriterPropertyProducer.ResolveStub();
		LoginRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginRules()
	{
	}
}
