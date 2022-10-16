using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ProcessWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		ListRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListRole()
	{
	}
}
