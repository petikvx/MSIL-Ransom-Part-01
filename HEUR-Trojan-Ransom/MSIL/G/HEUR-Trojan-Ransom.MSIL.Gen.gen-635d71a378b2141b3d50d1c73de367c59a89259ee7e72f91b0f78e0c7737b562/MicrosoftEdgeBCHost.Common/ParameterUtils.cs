using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ParameterUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterUtils()
	{
		WriterPropertyProducer.ResolveStub();
		FillInterfaceQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillInterfaceQueue()
	{
	}
}
