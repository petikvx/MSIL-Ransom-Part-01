using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using CommandLineParser;
using Microsoft.Build.Tasks.Deployment.ManifestUtilities;
using Utilities;

namespace MageCLI;

internal class Command
{
	private enum Operations
	{
		LaunchGUI = 1,
		ShowHelp = 2,
		ShowVerboseHelp = 4,
		GenerateSomething = 8,
		GenerateApplicationManifest = 0x10,
		GenerateDeploymentManifest = 0x20,
		UpdateSomething = 0x80,
		UpdateApplicationManifest = 0x100,
		UpdateDeploymentManifest = 0x200,
		SignSomething = 0x800,
		SignApplicationManifest = 0x1000,
		SignDeploymentManifest = 0x2000,
		CleanApplicationCache = 0x4000
	}

	public enum TrustLevels
	{
		None,
		FullTrust,
		LocalIntranet,
		Internet
	}

	private Operations operations;

	private string inputPath;

	[CommandLineArgument(LongName = "ToFile", ShortName = "t")]
	public string outputPath;

	[CommandLineArgument(LongName = "Version", ShortName = "v")]
	public string applicationVersionString;

	[CommandLineArgument(LongName = "Name", ShortName = "n")]
	public string applicationName;

	[CommandLineArgument(LongName = "Processor", ShortName = "p")]
	public string processorString;

	[CommandLineArgument(LongName = "FromDirectory", ShortName = "fd")]
	public string fromDirectory;

	[CommandLineArgument(LongName = "CertFile", ShortName = "cf")]
	public string certPath;

	[CommandLineArgument(LongName = "CertHash", ShortName = "ch")]
	public string certHash;

	[CommandLineArgument(LongName = "Password", ShortName = "pwd")]
	public string certPassword;

	[CommandLineArgument(LongName = "TrustLevel", ShortName = "tr")]
	public string trustLevelString;

	[CommandLineArgument(LongName = "AppManifest", ShortName = "appm")]
	public string applicationManifestPath;

	[CommandLineArgument(LongName = "AppCodeBase", ShortName = "appc")]
	public string applicationCodeBase;

	[CommandLineArgument(LongName = "ProviderUrl", ShortName = "pu")]
	public string applicationProviderUrl;

	[CommandLineArgument(LongName = "MinVersion", ShortName = "mv")]
	public string isRequiredUpdateString;

	[CommandLineArgument(LongName = "TimeStampUri", ShortName = "ti")]
	public string timestamp;

	[CommandLineArgument(LongName = "Install", ShortName = "i")]
	public string installString;

	private Version applicationVersion;

	private Processors processor = Processors.Undefined;

	private TrustLevels trustLevel;

	private string minVersion;

	private TriStateBool install = TriStateBool.Undefined;

	private ApplicationManifest cachedAppManifest;

	private DeployManifest cachedDepManifest;

	private X509Certificate2 storedCert;

	private bool signVerb;

	[DllImport("Dfshim.dll", CharSet = CharSet.Auto)]
	public static extern bool CleanOnlineAppCache();

	public Command(string[] args)
	{
		bool flag = false;
		bool flag2 = false;
		string text = null;
		string text2 = null;
		int num = -1;
		if (args.Length > 0)
		{
			text = args[0];
			args[0] = null;
			num = text.IndexOf(':');
			if (num == -1)
			{
				if (args.Length > 1)
				{
					text2 = args[1];
					args[1] = null;
				}
			}
			else
			{
				text2 = text.Substring(num + 1);
				text = text.Substring(0, num);
			}
			if (text != null && text.Length > 0)
			{
				switch (text[0])
				{
				case '-':
				case '/':
					text = text.Substring(1);
					switch (text.ToLower())
					{
					case "new":
					case "n":
						operations |= Operations.GenerateSomething;
						break;
					case "update":
					case "u":
						operations |= Operations.UpdateSomething;
						break;
					case "sign":
					case "s":
						operations |= Operations.SignSomething;
						signVerb = true;
						break;
					case "ClearApplicationCache":
					case "cc":
						operations |= Operations.CleanApplicationCache;
						break;
					case "help":
					case "h":
					case "?":
						flag = true;
						if (text2 != null && text2.ToLower() == "verbose")
						{
							flag2 = true;
						}
						break;
					}
					break;
				}
			}
			if (flag)
			{
				if (flag2)
				{
					operations |= Operations.ShowVerboseHelp;
				}
				else
				{
					operations |= Operations.ShowHelp;
				}
				return;
			}
			if (Requested(Operations.GenerateSomething))
			{
				if (text2 == null)
				{
					Application.PrintErrorMessage(ErrorMessages.InvalidFileType, "");
					return;
				}
				switch (text2.ToLower())
				{
				case "deployment":
					operations |= Operations.GenerateDeploymentManifest;
					break;
				case "application":
					operations |= Operations.GenerateApplicationManifest;
					break;
				default:
					Application.PrintErrorMessage(ErrorMessages.InvalidFileType, text2);
					operations = (Operations)0;
					return;
				}
			}
			if (Requested(Operations.UpdateSomething) || Requested(Operations.SignSomething))
			{
				inputPath = text2;
			}
			CommandLineArgumentParser commandLineArgumentParser = new CommandLineArgumentParser(GetType(), Console.Error.WriteLine);
			if (!commandLineArgumentParser.Parse(args, this))
			{
				operations |= Operations.ShowHelp;
			}
			if (certPath != null || certHash != null || certPassword != null)
			{
				operations |= Operations.SignSomething;
			}
		}
		else
		{
			operations |= Operations.LaunchGUI;
		}
	}

	private bool Requested(Operations op)
	{
		return (operations & op) > (Operations)0;
	}

	private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
	{
		string text = "";
		Assembly result = null;
		try
		{
			Assembly assembly = Assembly.GetAssembly(typeof(Assembly));
			string directoryName = Path.GetDirectoryName(new Uri(assembly.CodeBase).LocalPath);
			directoryName += "\\";
			int num = args.Name.IndexOf(',');
			if (num != -1)
			{
				string path = args.Name.Substring(0, num) + ".dll";
				text = Path.Combine(directoryName, path);
				return Assembly.LoadFrom(text);
			}
			return result;
		}
		catch (Exception)
		{
			return null;
		}
	}

	private bool CanExecuteInner()
	{
		bool flag = true;
		if (!Requested(Operations.GenerateSomething) && !Requested(Operations.UpdateSomething) && !Requested(Operations.SignSomething))
		{
			Application.PrintErrorMessage(ErrorMessages.NoVerb);
			flag = false;
		}
		if (Requested(Operations.UpdateSomething) && !CanUpdate())
		{
			return false;
		}
		if (Requested(Operations.SignSomething) && !CanSign())
		{
			return false;
		}
		if (!CheckForInvalidParameters())
		{
			flag = false;
		}
		if ((Requested(Operations.GenerateDeploymentManifest) || Requested(Operations.UpdateDeploymentManifest)) && applicationManifestPath != null)
		{
			if (File.Exists(applicationManifestPath))
			{
				OpenAndCacheManifestInputFile(applicationManifestPath);
				if (cachedAppManifest == null)
				{
					Application.PrintErrorMessage(ErrorMessages.InvalidInputFile, applicationManifestPath);
					flag = false;
				}
			}
			else
			{
				Application.PrintErrorMessage(ErrorMessages.InvalidPath, applicationManifestPath);
				flag = false;
			}
		}
		if (outputPath == null)
		{
			if (Requested(Operations.GenerateApplicationManifest))
			{
				outputPath = "application.exe.manifest";
			}
			if (Requested(Operations.GenerateDeploymentManifest))
			{
				outputPath = "deploy.application";
			}
			if (outputPath == null)
			{
				if (inputPath != null)
				{
					outputPath = inputPath;
				}
				else
				{
					Application.PrintErrorMessage(ErrorMessages.NoOutputFileSpecified, null);
					flag = false;
				}
			}
		}
		if (flag && outputPath != null)
		{
			FileStream fileStream = null;
			bool flag2 = false;
			if (!File.Exists(outputPath))
			{
				flag2 = true;
			}
			try
			{
				fileStream = File.OpenWrite(outputPath);
			}
			catch (Exception)
			{
				Application.PrintErrorMessage(ErrorMessages.FileNotWriteable, outputPath);
				flag = false;
			}
			if (fileStream != null)
			{
				fileStream.Close();
				if (flag2)
				{
					File.Delete(outputPath);
				}
			}
		}
		else
		{
			outputPath = "";
		}
		if (applicationVersionString != null)
		{
			try
			{
				applicationVersion = new Version(applicationVersionString);
			}
			catch (Exception)
			{
				flag = false;
				Application.PrintErrorMessage(ErrorMessages.InvalidVersion, applicationVersionString);
			}
		}
		if (processorString != null)
		{
			try
			{
				processor = (Processors)Enum.Parse(typeof(Processors), processorString, ignoreCase: true);
				if (processor == Processors.Undefined)
				{
					throw new Exception();
				}
			}
			catch (Exception)
			{
				flag = false;
				Application.PrintErrorMessage(ErrorMessages.InvalidProcessor, processorString);
			}
		}
		if (fromDirectory != null && !Directory.Exists(fromDirectory))
		{
			flag = false;
			Application.PrintErrorMessage(ErrorMessages.InvalidDirectory, fromDirectory);
		}
		if (trustLevelString != null)
		{
			try
			{
				trustLevelString = trustLevelString.ToLower();
				if (trustLevelString == TrustLevels.Internet.ToString().ToLower())
				{
					trustLevel = TrustLevels.Internet;
				}
				else if (trustLevelString == TrustLevels.LocalIntranet.ToString().ToLower())
				{
					trustLevel = TrustLevels.LocalIntranet;
				}
				else
				{
					if (!(trustLevelString == TrustLevels.FullTrust.ToString().ToLower()))
					{
						throw new Exception();
					}
					trustLevel = TrustLevels.FullTrust;
				}
			}
			catch (Exception)
			{
				flag = false;
				Application.PrintErrorMessage(ErrorMessages.InvalidTrustLevel, trustLevelString);
			}
		}
		if (applicationCodeBase != null && !Misc.IsValidCodebase(applicationCodeBase))
		{
			Application.PrintErrorMessage(ErrorMessages.InvalidCodebase, applicationCodeBase);
			flag = false;
		}
		if (applicationProviderUrl != null && !Misc.IsValidUrl(applicationProviderUrl))
		{
			Application.PrintErrorMessage(ErrorMessages.InvalidUrl, applicationProviderUrl);
			flag = false;
		}
		if (isRequiredUpdateString != null)
		{
			if (isRequiredUpdateString.ToLower() == "none")
			{
				minVersion = string.Empty;
			}
			else
			{
				try
				{
					new Version(isRequiredUpdateString);
					minVersion = isRequiredUpdateString;
				}
				catch (ArgumentOutOfRangeException)
				{
					Application.PrintErrorMessage(ErrorMessages.InvalidMinVersion, minVersion);
					flag = false;
				}
			}
		}
		if (installString != null)
		{
			if (!string.IsNullOrEmpty(minVersion))
			{
				Application.PrintErrorMessage(ErrorMessages.InvalidMinVersion, minVersion);
				flag = false;
			}
			else
			{
				switch (installString.ToLower())
				{
				case "false":
				case "f":
					install = TriStateBool.False;
					break;
				case "true":
				case "t":
					install = TriStateBool.True;
					break;
				default:
					flag = false;
					Application.PrintErrorMessage(ErrorMessages.InvalidInstall, installString);
					break;
				}
			}
		}
		return flag;
	}

	public bool CanExecute()
	{
		if (operations == (Operations)0)
		{
			Application.PrintErrorMessage(ErrorMessages.NoVerb);
			return false;
		}
		if (!Requested(Operations.ShowHelp) && !Requested(Operations.ShowVerboseHelp) && !Requested(Operations.LaunchGUI) && !Requested(Operations.CleanApplicationCache))
		{
			SetupAssemblyHook();
			return CanExecuteInner();
		}
		return true;
	}

	private void SetupAssemblyHook()
	{
		AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
	}

	private bool CheckForInvalidParameters()
	{
		bool result = true;
		if (Requested(Operations.GenerateApplicationManifest) || Requested(Operations.UpdateApplicationManifest))
		{
			if (applicationManifestPath != null)
			{
				Application.PrintInvalidOptionErrorMessage("AppManifest", "Deployment", null);
				result = false;
			}
			if (applicationCodeBase != null)
			{
				Application.PrintInvalidOptionErrorMessage("AppCodeBase", "Deployment", null);
				result = false;
			}
			if (applicationProviderUrl != null)
			{
				Application.PrintInvalidOptionErrorMessage("AppProviderUrl", "Deployment", null);
				result = false;
			}
			if (isRequiredUpdateString != null)
			{
				Application.PrintInvalidOptionErrorMessage("RequiredUpdate", "Deployment", null);
				result = false;
			}
			if (installString != null)
			{
				Application.PrintInvalidOptionErrorMessage("Install", "Deployment", null);
				result = false;
			}
		}
		if (Requested(Operations.GenerateDeploymentManifest) || Requested(Operations.UpdateDeploymentManifest))
		{
			if (fromDirectory != null)
			{
				Application.PrintInvalidOptionErrorMessage("FromDirectory", "Application", null);
				result = false;
			}
			if (trustLevelString != null)
			{
				Application.PrintInvalidOptionErrorMessage("TrustLevel", "Application", null);
				result = false;
			}
		}
		if (signVerb)
		{
			if (applicationVersionString != null)
			{
				result = false;
				Application.PrintErrorMessage(ErrorMessages.InvalidSignOption, "Version");
			}
			if (applicationName != null)
			{
				result = false;
				Application.PrintErrorMessage(ErrorMessages.InvalidSignOption, "Name");
			}
			if (processorString != null)
			{
				result = false;
				Application.PrintErrorMessage(ErrorMessages.InvalidSignOption, "Processor");
			}
			if (fromDirectory != null)
			{
				result = false;
				Application.PrintErrorMessage(ErrorMessages.InvalidSignOption, "FromDirectory");
			}
			if (trustLevelString != null)
			{
				result = false;
				Application.PrintErrorMessage(ErrorMessages.InvalidSignOption, "TrustLevel");
			}
			if (applicationManifestPath != null)
			{
				result = false;
				Application.PrintErrorMessage(ErrorMessages.InvalidSignOption, "AppManifest");
			}
			if (applicationCodeBase != null)
			{
				result = false;
				Application.PrintErrorMessage(ErrorMessages.InvalidSignOption, "AppCodeBase");
			}
			if (applicationProviderUrl != null)
			{
				result = false;
				Application.PrintErrorMessage(ErrorMessages.InvalidSignOption, "AppProviderUrl");
			}
			if (isRequiredUpdateString != null)
			{
				result = false;
				Application.PrintErrorMessage(ErrorMessages.InvalidSignOption, "RequiredUpdate");
			}
			if (applicationVersionString != null)
			{
				result = false;
				Application.PrintErrorMessage(ErrorMessages.InvalidSignOption, "Version");
			}
		}
		return result;
	}

	private bool CanUpdate()
	{
		bool result = true;
		if (!EnsureInputFile())
		{
			return false;
		}
		if (!OpenAndCacheManifestInputFile(inputPath))
		{
			Application.PrintErrorMessage(ErrorMessages.InvalidInputFile, inputPath);
			result = false;
		}
		else
		{
			if (cachedAppManifest != null)
			{
				operations |= Operations.UpdateApplicationManifest;
			}
			if (cachedDepManifest != null)
			{
				operations |= Operations.UpdateDeploymentManifest;
			}
		}
		return result;
	}

	private bool EnsureInputFile()
	{
		if (inputPath == null)
		{
			if (Requested(Operations.UpdateSomething))
			{
				Application.PrintErrorMessage(ErrorMessages.MissingArgument, "update");
			}
			else
			{
				if (!Requested(Operations.SignSomething))
				{
					throw new Exception("");
				}
				Application.PrintErrorMessage(ErrorMessages.MissingArgument, "sign");
			}
			return false;
		}
		inputPath = Path.GetFullPath(inputPath);
		if (!File.Exists(inputPath))
		{
			Application.PrintErrorMessage(ErrorMessages.InvalidPath, inputPath);
			return false;
		}
		return true;
	}

	private bool CanSign()
	{
		bool result = true;
		if (!Requested(Operations.GenerateSomething))
		{
			if (!EnsureInputFile())
			{
				return false;
			}
			if (!OpenAndCacheManifestInputFile(inputPath))
			{
				Application.PrintErrorMessage(ErrorMessages.InvalidInputFile, inputPath);
				return false;
			}
		}
		if (Requested(Operations.GenerateApplicationManifest) || cachedAppManifest != null)
		{
			operations |= Operations.SignApplicationManifest;
		}
		if (Requested(Operations.GenerateDeploymentManifest) || cachedDepManifest != null)
		{
			operations |= Operations.SignDeploymentManifest;
		}
		int num = 0;
		if (certPath != null)
		{
			num++;
		}
		if (certHash != null)
		{
			num++;
		}
		if (timestamp != null)
		{
			Uri uri = null;
			try
			{
				uri = new Uri(timestamp);
			}
			catch (UriFormatException)
			{
			}
			if (uri == null)
			{
				result = false;
				Application.PrintErrorMessage(ErrorMessages.InvalidTimestamp);
			}
		}
		if (num < 1)
		{
			result = false;
			Application.PrintErrorMessage(ErrorMessages.NoKeySpecified);
		}
		else if (num > 1)
		{
			result = false;
			Application.PrintErrorMessage(ErrorMessages.TooManyKeysSpecified);
		}
		else
		{
			if (certPath != null)
			{
				if (File.Exists(certPath))
				{
					try
					{
						X509Certificate2 cert = new X509Certificate2(certPath, certPassword);
						if (result = ValidateCertificate(cert, certPath))
						{
							storedCert = cert;
						}
					}
					catch (CryptographicException ex2)
					{
						Application.PrintErrorMessage(ErrorMessages.UnableToOpenCertificate, certPath);
						if (ex2.Message.EndsWith(Environment.NewLine))
						{
							Console.Write(ex2.Message);
						}
						else
						{
							Console.WriteLine(ex2.Message);
						}
						result = false;
					}
				}
				else
				{
					Application.PrintErrorMessage(ErrorMessages.InvalidPath, certPath);
					result = false;
				}
			}
			if (certHash != null)
			{
				certHash = certHash.ToLower();
				certHash = certHash.Replace(" ", "");
				X509Store x509Store = new X509Store("MY", StoreLocation.CurrentUser);
				x509Store.Open(OpenFlags.OpenExistingOnly);
				X509Certificate2Collection certificates = x509Store.Certificates;
				X509Certificate2Enumerator enumerator = certificates.GetEnumerator();
				while (enumerator.MoveNext())
				{
					X509Certificate2 current = enumerator.Current;
					string text = current.GetCertHashString().ToLower();
					if (text == certHash && (result = ValidateCertificate(current, certHash)))
					{
						storedCert = current;
					}
				}
			}
		}
		return result;
	}

	private static bool ValidateCertificate(X509Certificate2 cert, string hashOrPath)
	{
		bool result = true;
		if (!Certificate.CanSignWith(cert))
		{
			Application.PrintErrorMessage(ErrorMessages.InvalidCertUsage, hashOrPath);
			result = false;
		}
		if (!Certificate.HasPrivateKey(cert))
		{
			Application.PrintErrorMessage(ErrorMessages.InvalidCertNoPrivateKey, hashOrPath);
			result = false;
		}
		return result;
	}

	private bool OpenAndCacheManifestInputFile(string path)
	{
		bool result = false;
		try
		{
			Manifest val = ManifestReader.ReadManifest(path, true);
			if (val != null)
			{
				if (val is ApplicationManifest)
				{
					cachedAppManifest = (ApplicationManifest)(object)((val is ApplicationManifest) ? val : null);
					return true;
				}
				if (val is DeployManifest)
				{
					cachedDepManifest = (DeployManifest)(object)((val is DeployManifest) ? val : null);
					return true;
				}
				return result;
			}
			return result;
		}
		catch (Exception)
		{
			return false;
		}
	}

	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public void ExecuteManifestRelated()
	{
		Manifest val = null;
		List<string> list = new List<string>();
		if (inputPath != null)
		{
			list.Add(inputPath.ToLower());
		}
		if (outputPath != null)
		{
			list.Add(outputPath.ToLower());
		}
		if (Requested(Operations.GenerateSomething) && applicationName == null)
		{
			string fileName = Path.GetFileName(outputPath);
			int num = fileName.IndexOf('.');
			if (num == -1)
			{
				applicationName = fileName;
			}
			else
			{
				applicationName = fileName.Substring(0, num);
			}
		}
		if (Requested(Operations.GenerateApplicationManifest))
		{
			applicationName += ".exe";
			val = (Manifest)(object)Mage.GenerateApplicationManifest(list, applicationName, applicationVersion, processor, trustLevel, fromDirectory);
		}
		else if (Requested(Operations.GenerateDeploymentManifest))
		{
			applicationName += ".app";
			val = (Manifest)(object)Mage.GenerateDeploymentManifest(outputPath, applicationName, applicationVersion, processor, cachedAppManifest, applicationManifestPath, applicationCodeBase, applicationProviderUrl, minVersion, install);
		}
		if (Requested(Operations.UpdateApplicationManifest))
		{
			Mage.UpdateApplicationManifest(list, cachedAppManifest, applicationName, applicationVersion, processor, trustLevel, fromDirectory);
			val = (Manifest)(object)cachedAppManifest;
		}
		else if (Requested(Operations.UpdateDeploymentManifest))
		{
			Mage.UpdateDeploymentManifest(cachedDepManifest, outputPath, applicationName, applicationVersion, processor, cachedAppManifest, applicationManifestPath, applicationCodeBase, applicationProviderUrl, minVersion, install);
			val = (Manifest)(object)cachedDepManifest;
		}
		bool flag = false;
		if (Requested(Operations.SignApplicationManifest))
		{
			if (val == null && inputPath != outputPath)
			{
				try
				{
					File.Copy(inputPath, outputPath, overwrite: true);
					flag = true;
				}
				catch
				{
					Application.PrintErrorMessage(ErrorMessages.InvalidPath, outputPath);
				}
			}
			else
			{
				flag = true;
			}
		}
		else if (Requested(Operations.SignDeploymentManifest))
		{
			if (val == null && inputPath != outputPath)
			{
				try
				{
					File.Copy(inputPath, outputPath, overwrite: true);
					flag = true;
				}
				catch
				{
					Application.PrintErrorMessage(ErrorMessages.InvalidPath, outputPath);
				}
			}
			else
			{
				flag = true;
			}
		}
		if (val != null)
		{
			ManifestWriter.WriteManifest(val, outputPath);
		}
		if (flag)
		{
			Uri uri = null;
			if (!string.IsNullOrEmpty(timestamp))
			{
				try
				{
					uri = new Uri(timestamp);
				}
				catch (UriFormatException)
				{
				}
			}
			SecurityUtilities.SignFile(storedCert, uri, outputPath);
		}
		Validate(val);
	}

	public void Execute()
	{
		if (Requested(Operations.ShowHelp))
		{
			Application.PrintHelpMessage();
			return;
		}
		if (Requested(Operations.ShowVerboseHelp))
		{
			Application.PrintVerboseHelpMessage();
			return;
		}
		if (Requested(Operations.LaunchGUI))
		{
			LaunchGUI();
			return;
		}
		if (Requested(Operations.CleanApplicationCache))
		{
			try
			{
				CleanOnlineAppCache();
				Application.PrintOutputMessage("", Application.Resources.GetString("ApplicactionCachedCleared"));
				return;
			}
			catch (Exception)
			{
				Application.PrintOutputMessage(Application.Resources.GetString("ErrorMessage") + ":", Application.Resources.GetString("ErrorApplicactionCachedCleared"));
				return;
			}
		}
		ExecuteManifestRelated();
	}

	private void Validate(Manifest manifest)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected I4, but got Unknown
		bool flag = false;
		if (manifest != null)
		{
			if (manifest is ApplicationManifest)
			{
				((ApplicationManifest)((manifest is ApplicationManifest) ? manifest : null)).set_MaxTargetPath(100);
			}
			manifest.Validate();
			foreach (OutputMessage outputMessage in manifest.get_OutputMessages())
			{
				OutputMessage val = outputMessage;
				string text = null;
				OutputMessageType type = val.get_Type();
				Console.WriteLine((int)type switch
				{
					0 => Application.Resources.GetString("InfoMessage"), 
					2 => Application.Resources.GetString("ErrorMessage"), 
					_ => Application.Resources.GetString("WarningMessage"), 
				} + " " + val.get_Text());
			}
			flag = manifest.get_OutputMessages().get_ErrorCount() + manifest.get_OutputMessages().get_WarningCount() > 0;
		}
		string text2 = null;
		if ((operations & Operations.GenerateSomething) != 0)
		{
			text2 = Application.Resources.GetString("ResultSuccessfullyCreated");
		}
		if ((operations & Operations.UpdateSomething) != 0)
		{
			text2 = Application.Resources.GetString("ResultSuccessfullyUpdated");
		}
		if ((operations & Operations.SignSomething) != 0)
		{
			text2 = Application.Resources.GetString("ResultSuccessfullySigned");
		}
		if (text2 != null)
		{
			if (flag)
			{
				Console.WriteLine();
			}
			Application.PrintOutputMessage(Path.GetFileName(outputPath), text2 + (flag ? (". " + Application.Resources.GetString("ResultSomeErrorsEncountered")) : ""));
		}
	}

	private void LaunchGUI()
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = "MageUI.exe";
			process.StartInfo.Arguments = "";
			process.StartInfo.CreateNoWindow = false;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardError = false;
			process.StartInfo.RedirectStandardOutput = false;
			process.Start();
		}
		catch (Exception)
		{
			Application.PrintErrorMessage(ErrorMessages.UnableToStartGUI, "MageUI.exe");
		}
	}
}
