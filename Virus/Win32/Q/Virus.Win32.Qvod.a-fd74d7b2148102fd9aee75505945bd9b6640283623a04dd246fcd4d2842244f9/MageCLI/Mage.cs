using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security;
using Microsoft.Build.Tasks.Deployment.ManifestUtilities;
using Utilities;

namespace MageCLI;

internal class Mage
{
	private const string defaultCulture = "neutral";

	private static Version defaultVersion = new Version(1, 0, 0, 0);

	public static ApplicationManifest GenerateApplicationManifest(List<string> filesToIgnore, string appName, Version version, Processors processor, Command.TrustLevels trustLevel, string fromDirectory)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		ApplicationManifest val = new ApplicationManifest();
		if (trustLevel == Command.TrustLevels.None)
		{
			trustLevel = Command.TrustLevels.FullTrust;
		}
		if (appName == null)
		{
			appName = Application.Resources.GetString("DefaultAppName");
		}
		if (version == null)
		{
			version = defaultVersion;
		}
		if (processor == Processors.Undefined)
		{
			processor = Processors.msil;
		}
		val.set_IconFile("");
		UpdateApplicationManifest(filesToIgnore, val, appName, version, processor, trustLevel, fromDirectory);
		return val;
	}

	public static DeployManifest GenerateDeploymentManifest(string deploymentManifestPath, string appName, Version version, Processors processor, ApplicationManifest applicationManifest, string applicationManifestPath, string appCodeBase, string appProviderUrl, string minVersion, TriStateBool install)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		DeployManifest val = new DeployManifest();
		if (install == TriStateBool.True)
		{
			val.set_Install(true);
			val.set_UpdateEnabled(true);
			val.set_UpdateMode((UpdateMode)0);
		}
		else
		{
			val.set_Install(false);
		}
		val.set_Publisher(Misc.GetRegisteredOrganization());
		if (appName == null)
		{
			appName = Application.Resources.GetString("DefaultAppName");
		}
		if (version == null)
		{
			version = defaultVersion;
		}
		if (processor == Processors.Undefined)
		{
			processor = Processors.msil;
		}
		if (appProviderUrl == null)
		{
			appProviderUrl = "";
		}
		UpdateDeploymentManifest(val, deploymentManifestPath, appName, version, processor, applicationManifest, applicationManifestPath, appCodeBase, appProviderUrl, minVersion, install);
		return val;
	}

	public static void UpdateApplicationManifest(List<string> filesToIgnore, ApplicationManifest manifest, string appName, Version version, Processors processor, Command.TrustLevels trustLevel, string fromDirectory)
	{
		if (appName != null)
		{
			((Manifest)manifest).get_AssemblyIdentity().set_Name(appName);
		}
		if (version != null)
		{
			((Manifest)manifest).get_AssemblyIdentity().set_Version(version.ToString());
		}
		if (processor != Processors.Undefined)
		{
			((Manifest)manifest).get_AssemblyIdentity().set_ProcessorArchitecture(processor.ToString());
		}
		if (((Manifest)manifest).get_AssemblyIdentity().get_Culture() == null || ((Manifest)manifest).get_AssemblyIdentity().get_Culture().Length == 0)
		{
			((Manifest)manifest).get_AssemblyIdentity().set_Culture("neutral");
		}
		if (trustLevel != 0)
		{
			SetTrustLevel(manifest, trustLevel);
		}
		if (fromDirectory != null)
		{
			AppMan.AddReferences(manifest, addDeploy: false, fromDirectory, filesToIgnore, LockedFileReporter, null, null, null, new ArrayList());
			((Manifest)manifest).get_OutputMessages().Clear();
			((Manifest)manifest).ResolveFiles();
			((Manifest)manifest).UpdateFileInfo();
			AppMan.SetSpecialFiles(manifest);
		}
		else
		{
			AppMan.UpdateReferenceInfo((Manifest)(object)manifest, "", null, null);
		}
	}

	public static void UpdateDeploymentManifest(DeployManifest manifest, string deploymentManifestPath, string appName, Version version, Processors processor, ApplicationManifest applicationManifest, string applicationManifestPath, string appCodeBase, string appProviderUrl, string minVersion, TriStateBool install)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		switch (install)
		{
		case TriStateBool.False:
			manifest.set_Install(false);
			manifest.set_DisallowUrlActivation(false);
			break;
		default:
			manifest.set_Install(true);
			manifest.set_UpdateEnabled(true);
			manifest.set_UpdateMode((UpdateMode)0);
			manifest.set_UpdateInterval(manifest.get_UpdateInterval());
			manifest.set_UpdateUnit(manifest.get_UpdateUnit());
			break;
		case TriStateBool.Undefined:
			break;
		}
		if (appName != null)
		{
			((Manifest)manifest).get_AssemblyIdentity().set_Name(appName);
			if (appName.EndsWith(".app") && appName.Length > 4)
			{
				manifest.set_Product(appName.Substring(0, appName.Length - 4));
			}
			else
			{
				manifest.set_Product(appName);
			}
		}
		if (version != null)
		{
			((Manifest)manifest).get_AssemblyIdentity().set_Version(version.ToString());
		}
		if (processor != Processors.Undefined)
		{
			((Manifest)manifest).get_AssemblyIdentity().set_ProcessorArchitecture(processor.ToString());
		}
		if (((Manifest)manifest).get_AssemblyIdentity().get_Culture() == null || ((Manifest)manifest).get_AssemblyIdentity().get_Culture().Length == 0)
		{
			((Manifest)manifest).get_AssemblyIdentity().set_Culture("neutral");
		}
		if (appProviderUrl != null)
		{
			manifest.set_DeploymentUrl(appProviderUrl);
		}
		if (minVersion != null)
		{
			if (minVersion != string.Empty)
			{
				manifest.set_Install(true);
				manifest.set_MinimumRequiredVersion(minVersion);
			}
			else
			{
				manifest.set_MinimumRequiredVersion((string)null);
			}
		}
		if (applicationManifest != null)
		{
			SetApplicationManifestReference(manifest, deploymentManifestPath, applicationManifest, applicationManifestPath);
		}
		if (appCodeBase != null)
		{
			SetApplicationCodeBase(manifest, appCodeBase);
		}
	}

	public static void LockedFileReporter(string filePath)
	{
		Application.PrintErrorMessage(ErrorMessages.LockedFile, filePath);
	}

	private static void SetApplicationManifestReference(DeployManifest deploymentManifest, string deploymentManifestPath, ApplicationManifest applicationManifest, string applicationManifestPath)
	{
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		if (deploymentManifest != null && applicationManifest != null && deploymentManifestPath != null && applicationManifestPath != null)
		{
			if (!Path.IsPathRooted(deploymentManifestPath))
			{
				deploymentManifestPath = Path.Combine(Environment.CurrentDirectory, deploymentManifestPath);
			}
			if (!Path.IsPathRooted(applicationManifestPath))
			{
				applicationManifestPath = Path.Combine(Environment.CurrentDirectory, applicationManifestPath);
			}
			string directoryName = Path.GetDirectoryName(deploymentManifestPath);
			string directoryName2 = Path.GetDirectoryName(applicationManifestPath);
			string text = ((Manifest)applicationManifest).get_AssemblyIdentity().get_Version() + "\\" + ((Manifest)applicationManifest).get_AssemblyIdentity().get_Name() + ".manifest";
			if (directoryName2.StartsWith(directoryName))
			{
				text = applicationManifestPath.Substring(directoryName.Length);
				if (text.StartsWith("\\"))
				{
					text = text.Substring(1);
				}
			}
			AssemblyReference val = new AssemblyReference(applicationManifestPath);
			val.set_AssemblyIdentity(((Manifest)applicationManifest).get_AssemblyIdentity());
			((Manifest)deploymentManifest).get_AssemblyReferences().Clear();
			((Manifest)deploymentManifest).get_AssemblyReferences().Add(val);
			((Manifest)deploymentManifest).set_EntryPoint(val);
			((Manifest)deploymentManifest).ResolveFiles();
			((Manifest)deploymentManifest).UpdateFileInfo();
			((BaseReference)val).set_TargetPath(text);
		}
		else
		{
			Application.PrintErrorMessage(ErrorMessages.InternalError);
		}
	}

	private static void SetApplicationCodeBase(DeployManifest deploymentManifest, string appCodeBase)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		if (deploymentManifest != null)
		{
			AssemblyReferenceCollection assemblyReferences = ((Manifest)deploymentManifest).get_AssemblyReferences();
			AssemblyReference val = null;
			if (assemblyReferences.get_Count() > 0)
			{
				val = assemblyReferences.get_Item(0);
				((BaseReference)val).set_TargetPath(appCodeBase);
			}
			else
			{
				val = new AssemblyReference(appCodeBase);
				((BaseReference)val).set_TargetPath(appCodeBase);
				assemblyReferences.Add(val);
			}
		}
	}

	private static void SetTrustLevel(ApplicationManifest manifest, Command.TrustLevels trustLevel)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		if (trustLevel != 0)
		{
			TrustInfo val = new TrustInfo();
			manifest.set_TrustInfo(val);
			if (trustLevel == Command.TrustLevels.FullTrust)
			{
				val.set_IsFullTrust(true);
				return;
			}
			val.set_PermissionSet(SecurityUtilities.ComputeZonePermissionSet(trustLevel.ToString(), (PermissionSet)null, (string[])null));
			val.set_IsFullTrust(false);
		}
	}
}
