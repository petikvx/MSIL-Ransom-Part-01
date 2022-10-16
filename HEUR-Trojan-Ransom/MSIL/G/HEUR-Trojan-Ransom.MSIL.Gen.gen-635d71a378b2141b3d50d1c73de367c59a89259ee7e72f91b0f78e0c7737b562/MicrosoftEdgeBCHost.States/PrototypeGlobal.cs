using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PrototypeGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		InsertInterfaceAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertInterfaceAuthentication()
	{
	}
}
