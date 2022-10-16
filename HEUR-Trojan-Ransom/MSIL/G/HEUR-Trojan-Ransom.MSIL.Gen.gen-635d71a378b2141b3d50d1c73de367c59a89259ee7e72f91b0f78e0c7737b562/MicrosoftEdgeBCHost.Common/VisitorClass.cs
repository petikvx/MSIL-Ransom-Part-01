using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class VisitorClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorClass()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInterfaceReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInterfaceReponse()
	{
	}
}
