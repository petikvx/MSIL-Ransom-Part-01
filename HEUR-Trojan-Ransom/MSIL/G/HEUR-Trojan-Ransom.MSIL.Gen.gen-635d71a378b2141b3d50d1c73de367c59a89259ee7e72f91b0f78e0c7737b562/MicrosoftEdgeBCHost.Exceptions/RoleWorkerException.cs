using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RoleWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		SetReader();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetReader()
	{
	}
}
