using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class SystemClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemClass()
	{
		WriterPropertyProducer.ResolveStub();
		PatchInterfacePolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchInterfacePolicy()
	{
	}
}
