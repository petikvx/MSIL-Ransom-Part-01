using System;
using System.Globalization;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Threading;

namespace ModuleNameSpace;

internal class MainModule : PSHost
{
	public class ConsoleColorProxy
	{
		private MainModuleUI _ui;

		public ConsoleColor ErrorForegroundColor
		{
			get
			{
				return _ui.ErrorForegroundColor;
			}
			set
			{
				_ui.ErrorForegroundColor = value;
			}
		}

		public ConsoleColor ErrorBackgroundColor
		{
			get
			{
				return _ui.ErrorBackgroundColor;
			}
			set
			{
				_ui.ErrorBackgroundColor = value;
			}
		}

		public ConsoleColor WarningForegroundColor
		{
			get
			{
				return _ui.WarningForegroundColor;
			}
			set
			{
				_ui.WarningForegroundColor = value;
			}
		}

		public ConsoleColor WarningBackgroundColor
		{
			get
			{
				return _ui.WarningBackgroundColor;
			}
			set
			{
				_ui.WarningBackgroundColor = value;
			}
		}

		public ConsoleColor DebugForegroundColor
		{
			get
			{
				return _ui.DebugForegroundColor;
			}
			set
			{
				_ui.DebugForegroundColor = value;
			}
		}

		public ConsoleColor DebugBackgroundColor
		{
			get
			{
				return _ui.DebugBackgroundColor;
			}
			set
			{
				_ui.DebugBackgroundColor = value;
			}
		}

		public ConsoleColor VerboseForegroundColor
		{
			get
			{
				return _ui.VerboseForegroundColor;
			}
			set
			{
				_ui.VerboseForegroundColor = value;
			}
		}

		public ConsoleColor VerboseBackgroundColor
		{
			get
			{
				return _ui.VerboseBackgroundColor;
			}
			set
			{
				_ui.VerboseBackgroundColor = value;
			}
		}

		public ConsoleColor ProgressForegroundColor
		{
			get
			{
				return _ui.ProgressForegroundColor;
			}
			set
			{
				_ui.ProgressForegroundColor = value;
			}
		}

		public ConsoleColor ProgressBackgroundColor
		{
			get
			{
				return _ui.ProgressBackgroundColor;
			}
			set
			{
				_ui.ProgressBackgroundColor = value;
			}
		}

		public ConsoleColorProxy(MainModuleUI ui)
		{
			if (ui == null)
			{
				throw new ArgumentNullException("ui");
			}
			_ui = ui;
		}
	}

	private MainAppInterface parent;

	private MainModuleUI ui;

	private CultureInfo originalCultureInfo = Thread.CurrentThread.CurrentCulture;

	private CultureInfo originalUICultureInfo = Thread.CurrentThread.CurrentUICulture;

	private Guid myId = Guid.NewGuid();

	private PSObject _consoleColorProxy;

	public override PSObject PrivateData
	{
		get
		{
			if (ui == null)
			{
				return null;
			}
			return _consoleColorProxy ?? (_consoleColorProxy = PSObject.AsPSObject((object)new ConsoleColorProxy(ui)));
		}
	}

	public override CultureInfo CurrentCulture => originalCultureInfo;

	public override CultureInfo CurrentUICulture => originalUICultureInfo;

	public override Guid InstanceId => myId;

	public override string Name => "PSRunspace-Host";

	public override PSHostUserInterface UI => (PSHostUserInterface)(object)ui;

	public override Version Version => new Version(0, 5, 0, 24);

	public MainModule(MainAppInterface app, MainModuleUI ui)
	{
		parent = app;
		this.ui = ui;
	}

	public override void EnterNestedPrompt()
	{
	}

	public override void ExitNestedPrompt()
	{
	}

	public override void NotifyBeginApplication()
	{
	}

	public override void NotifyEndApplication()
	{
	}

	public override void SetShouldExit(int exitCode)
	{
		parent.ShouldExit = true;
		parent.ExitCode = exitCode;
	}
}
