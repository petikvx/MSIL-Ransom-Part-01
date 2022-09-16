using System;
using System.IO;
using System.Security;
using System.Security.Policy;

namespace SandboxDotNet;

internal class Sandbox : MarshalByRefObject
{
	private AppDomain _sandboxDomain;

	public PermissionSet Permissions { get; set; }

	public string ProgramPath { get; set; }

	public string[] ProgramParameters { get; set; }

	public Logging Logger { get; set; }

	public Sandbox()
	{
		Log("Sandbox created!", Logging.Severity.DEBUG);
	}

	public Sandbox(string progPath, string[] parameters)
		: this()
	{
		ProgramPath = progPath;
		ProgramParameters = parameters;
	}

	public Sandbox(string progPath, string[] parameters, PermissionSet permSet)
		: this(progPath, parameters)
	{
		Permissions = permSet;
	}

	private void ConfigureSandbox()
	{
		string text = "SandBoxDotNet";
		if (Permissions == null)
		{
			throw new NullReferenceException("Permissions cannot be null! Define 'Permissions' before running the sandbox.");
		}
		AppDomainSetup appDomainSetup = new AppDomainSetup();
		appDomainSetup.set_ApplicationBase(Path.GetFullPath(ProgramPath));
		StrongName hostEvidence = typeof(Sandbox).Assembly.get_Evidence().GetHostEvidence<StrongName>();
		_sandboxDomain = AppDomain.CreateDomain(text, (Evidence)null, appDomainSetup, Permissions, (StrongName[])(object)new StrongName[1] { hostEvidence });
		Log($"Sandbox configured with name '{GenerateUniqueSandboxName(text)}'", Logging.Severity.DEBUG);
	}

	private void Log(string message, Logging.Severity severity)
	{
		if (Logger != null)
		{
			Logger.Log(message, severity);
		}
	}

	private string GenerateUniqueSandboxName(string name)
	{
		return "";
	}

	public int ExecuteUntrustedExecutable()
	{
		if (string.IsNullOrWhiteSpace(ProgramPath))
		{
			throw new ArgumentException("Program path not provided!", "ProgramPath");
		}
		ConfigureSandbox();
		Log($"Sandbox is launching the application: '{ProgramPath}'", Logging.Severity.DEBUG);
		return _sandboxDomain.ExecuteAssembly(ProgramPath, ProgramParameters);
	}
}
