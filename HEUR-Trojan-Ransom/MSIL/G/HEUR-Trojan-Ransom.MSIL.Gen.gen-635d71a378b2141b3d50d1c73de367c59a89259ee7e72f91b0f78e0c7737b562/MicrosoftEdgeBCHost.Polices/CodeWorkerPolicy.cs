using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class CodeWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CloneInterfaceAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneInterfaceAuthentication()
	{
	}
}
