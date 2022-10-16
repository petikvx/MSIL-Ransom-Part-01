using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class MethodVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodVal()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectAnnotation()
	{
	}
}
