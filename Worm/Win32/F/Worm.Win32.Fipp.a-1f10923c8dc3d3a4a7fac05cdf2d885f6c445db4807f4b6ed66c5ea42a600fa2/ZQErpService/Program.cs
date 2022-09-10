using System.ServiceProcess;

namespace ZQErpService;

internal static class Program
{
	private static void Main()
	{
		ServiceBase[] array = (ServiceBase[])(object)new ServiceBase[1]
		{
			new ZQErpServer()
		};
		ServiceBase.Run(array);
	}
}
