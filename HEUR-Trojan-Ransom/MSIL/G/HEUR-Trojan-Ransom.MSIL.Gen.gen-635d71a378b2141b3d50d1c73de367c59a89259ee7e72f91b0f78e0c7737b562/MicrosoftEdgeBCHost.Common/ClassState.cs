using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ClassState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassState()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeInterfaceRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeInterfaceRecord()
	{
	}
}
