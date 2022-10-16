using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SetterUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterUtils()
	{
		WriterPropertyProducer.ResolveStub();
		InsertInterfaceGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertInterfaceGlobal()
	{
	}
}
