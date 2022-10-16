using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class FacadeVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeVal()
	{
		WriterPropertyProducer.ResolveStub();
		LoginPredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginPredicate()
	{
	}
}
