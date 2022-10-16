using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class MessageUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageUtils()
	{
		WriterPropertyProducer.ResolveStub();
		CalcInterfaceAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcInterfaceAdapter()
	{
	}
}
