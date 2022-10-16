using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class PrototypeFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeFilter()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotConfig()
	{
	}
}
