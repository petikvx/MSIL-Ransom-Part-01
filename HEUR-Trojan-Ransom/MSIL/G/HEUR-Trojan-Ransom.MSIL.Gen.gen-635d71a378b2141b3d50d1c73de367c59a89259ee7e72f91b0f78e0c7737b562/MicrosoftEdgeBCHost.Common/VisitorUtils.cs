using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class VisitorUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorUtils()
	{
		WriterPropertyProducer.ResolveStub();
		PushInterfaceAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushInterfaceAttr()
	{
	}
}
