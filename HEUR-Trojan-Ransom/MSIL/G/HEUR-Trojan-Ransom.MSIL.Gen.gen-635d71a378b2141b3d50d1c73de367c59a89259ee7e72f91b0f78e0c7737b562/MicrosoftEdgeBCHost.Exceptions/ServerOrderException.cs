using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ServerOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		SearchProc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchProc()
	{
	}
}
