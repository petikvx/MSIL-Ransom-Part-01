using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RoleObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleObject()
	{
		WriterPropertyProducer.ResolveStub();
		ListLiteralComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListLiteralComparator()
	{
	}
}
