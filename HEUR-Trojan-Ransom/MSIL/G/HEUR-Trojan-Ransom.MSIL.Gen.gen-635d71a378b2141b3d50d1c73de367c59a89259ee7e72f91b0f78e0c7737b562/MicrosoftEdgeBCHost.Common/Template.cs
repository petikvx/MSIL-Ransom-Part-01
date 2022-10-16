using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class Template
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Template()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeEvent()
	{
	}
}
