using System.IO;
using System.Security;
using System.ServiceProcess;
using System.Threading;

namespace MS.Internal.FontCache.Service;

[SecurityCritical(SecurityCriticalScope.Everything)]
internal class FontCacheService : ServiceBase
{
	private Thread _cacheManagerThread;

	private LPCServer _server;

	private ConnectionInstance _shutdownConn;

	private Protocol _shutdownProtocol;

	private int _shutdownTimeout = 250;

	private static FontCacheConfig FontCacheConfig => FontCacheConfig.get_Current();

	public FontCacheService()
	{
		((ServiceBase)this).set_ServiceName("FontCache3.0.0.0");
		((ServiceBase)this).set_AutoLog(false);
		((ServiceBase)this).set_CanShutdown(true);
		_shutdownConn = null;
		_shutdownProtocol = null;
		_server = null;
	}

	private static void Main()
	{
		FontCacheConfig.set_IsServer(true);
		ServiceBase[] array = (ServiceBase[])(object)new ServiceBase[1]
		{
			new FontCacheService()
		};
		ServiceBase.Run(array);
	}

	protected override void OnStart(string[] args)
	{
		ServiceCacheManager.InitializeSharedCache();
		_cacheManagerThread = new Thread(ThreadMain);
		_server = (LPCServer)(object)new FontCacheSinglePortLPCServer();
		_shutdownTimeout = FontCacheConfig.get_ShutdownTimeout();
		int num = 0;
		_server.TryCreatePort(ref num);
		if (num == 0)
		{
			_cacheManagerThread.Start(this);
			_shutdownProtocol = FontCacheConfig.get_ClientProtocol();
			_shutdownConn = _shutdownProtocol.TryConnectToServer(int.MaxValue, ref num);
		}
	}

	private static void ThreadMain(object state)
	{
		((FontCacheService)state).MainPortListen();
	}

	private void MainPortListen()
	{
		_server.Run();
	}

	private void RealStop()
	{
		int errorCode = 0;
		if (_shutdownConn != null)
		{
			FontCacheAdapter.SendShutdownMessage(_shutdownProtocol, _shutdownConn, out errorCode);
			int num = 0;
			_shutdownProtocol.TryCloseInstance(_shutdownConn, ref num);
		}
		if (_cacheManagerThread != null)
		{
			if (_shutdownConn != null && errorCode == 0)
			{
				_cacheManagerThread.Join(_shutdownTimeout);
			}
			try
			{
				ServiceCacheManager.PersistCache();
			}
			catch (IOException)
			{
			}
			_server.TryClosePort(ref errorCode);
		}
	}

	protected override void OnStop()
	{
		RealStop();
	}

	protected override void OnShutdown()
	{
		RealStop();
	}
}
