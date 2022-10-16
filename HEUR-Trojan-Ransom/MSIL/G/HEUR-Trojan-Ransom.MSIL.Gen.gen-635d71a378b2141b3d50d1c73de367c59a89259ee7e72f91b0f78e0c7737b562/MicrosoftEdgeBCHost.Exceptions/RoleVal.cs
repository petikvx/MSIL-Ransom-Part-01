using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RoleVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleVal()
	{
		WriterPropertyProducer.ResolveStub();
		CollectAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectAnnotation()
	{
	}
}
