using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AttrPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		FindInterfaceProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindInterfaceProcess()
	{
	}
}
