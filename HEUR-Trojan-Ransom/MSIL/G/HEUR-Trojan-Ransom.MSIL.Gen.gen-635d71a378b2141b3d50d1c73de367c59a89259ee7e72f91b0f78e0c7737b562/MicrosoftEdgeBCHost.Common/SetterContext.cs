using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class SetterContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterContext()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveInterfaceWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveInterfaceWrapper()
	{
	}
}
