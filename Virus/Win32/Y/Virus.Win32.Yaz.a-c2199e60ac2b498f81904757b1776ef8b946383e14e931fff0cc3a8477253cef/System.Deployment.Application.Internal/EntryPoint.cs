namespace System.Deployment.Application.Internal;

internal static class EntryPoint
{
	[MTAThread]
	public static int Main(string[] args)
	{
		DFServiceEntryPoint.Initialize(args);
		return 0;
	}
}
