using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MessageFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageFilter()
	{
		WriterPropertyProducer.ResolveStub();
		CalcAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcAuthentication()
	{
	}
}
