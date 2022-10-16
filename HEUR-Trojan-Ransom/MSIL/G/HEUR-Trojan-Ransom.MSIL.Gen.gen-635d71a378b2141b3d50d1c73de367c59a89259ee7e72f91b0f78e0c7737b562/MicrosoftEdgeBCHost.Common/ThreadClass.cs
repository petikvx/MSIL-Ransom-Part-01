using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ThreadClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadClass()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeInterfacePolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeInterfacePolicy()
	{
	}
}
