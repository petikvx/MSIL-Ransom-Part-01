using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class Interceptor
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Interceptor()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateValue()
	{
	}
}
