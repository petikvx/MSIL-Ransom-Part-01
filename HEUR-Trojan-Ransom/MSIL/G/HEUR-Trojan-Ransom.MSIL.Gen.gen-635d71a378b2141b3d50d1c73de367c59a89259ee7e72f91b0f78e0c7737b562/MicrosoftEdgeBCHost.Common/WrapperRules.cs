using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class WrapperRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperRules()
	{
		WriterPropertyProducer.ResolveStub();
		InitMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitMessage()
	{
	}
}
