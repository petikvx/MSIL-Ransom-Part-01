using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class CodeContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeContext()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeInterfaceWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeInterfaceWrapper()
	{
	}
}
