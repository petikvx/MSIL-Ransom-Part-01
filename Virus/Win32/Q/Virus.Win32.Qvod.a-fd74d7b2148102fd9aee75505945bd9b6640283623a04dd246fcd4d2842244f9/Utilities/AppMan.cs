using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Microsoft.Build.Tasks.Deployment.ManifestUtilities;

namespace Utilities;

internal sealed class AppMan
{
	public delegate void LockedFileReporter(string filePath);

	public delegate void UpdateProgressEventHandler(object sender, UpdateProgressEventArgs e);

	public enum Action
	{
		Begin,
		AlreadyPresent,
		Added,
		Updated,
		SearchComplete,
		Renaming,
		Complete
	}

	public class UpdateProgressEventArgs : EventArgs
	{
		private Action action;

		private string path;

		private ArrayList errors;

		public Action Action => action;

		public string Path => path;

		public ArrayList Errors => errors;

		public UpdateProgressEventArgs(Action action, string path)
		{
			this.action = action;
			this.path = path;
			errors = new ArrayList();
		}

		public UpdateProgressEventArgs(Action action, string path, ArrayList errors)
		{
			this.action = action;
			this.path = path;
			this.errors = errors;
		}
	}

	public delegate bool OverwriteEventHandler(string fileName);

	public static void AddReferences(ApplicationManifest manifest, bool addDeploy, string fromDirectory, List<string> filesToIgnore, LockedFileReporter lockedFileReporter, object sender, UpdateProgressEventHandler updateProgress, OverwriteEventHandler overwrite, ArrayList errors)
	{
		if (manifest != null && fromDirectory != null)
		{
			if (fromDirectory.Length >= 2 && fromDirectory.Substring(0, 2) == ".\\")
			{
				fromDirectory = fromDirectory.Substring(2);
			}
			if (fromDirectory == "")
			{
				fromDirectory = ".";
			}
			if (fromDirectory.LastIndexOf('\\') != fromDirectory.Length - 1)
			{
				fromDirectory += '\\';
			}
			string text = (((Manifest)manifest).get_AssemblyIdentity().get_Name() + ".manifest").ToLower();
			filesToIgnore.Add(text);
			filesToIgnore.Add(((Manifest)manifest).get_SourcePath() + text);
			if (addDeploy)
			{
				filesToIgnore.Add(text + ".deploy");
				filesToIgnore.Add(((Manifest)manifest).get_SourcePath() + text + ".deploy");
			}
			((Manifest)manifest).set_SourcePath(fromDirectory);
			updateProgress?.Invoke(sender, new UpdateProgressEventArgs(Action.Begin, ""));
			AddReferences(manifest, addDeploy, fromDirectory, fromDirectory, "", filesToIgnore, lockedFileReporter, sender, updateProgress, overwrite, errors);
			updateProgress?.Invoke(sender, new UpdateProgressEventArgs(Action.SearchComplete, ""));
		}
	}

	public static string[] AppendDeploy(List<string> filesToIgnore, string[] files, OverwriteEventHandler overwrite, ArrayList errors)
	{
		ArrayList arrayList = new ArrayList();
		string[] array = new string[files.Length];
		for (int i = 0; i < files.Length; i++)
		{
			string text = files[i];
			if (text == null || !File.Exists(text))
			{
				continue;
			}
			if (!text.ToLower().EndsWith(".deploy") && !filesToIgnore.Contains(text.ToLower()))
			{
				try
				{
					string text2 = text + ".deploy";
					if (!File.Exists(text2))
					{
						goto IL_0083;
					}
					if (overwrite != null && overwrite(text2))
					{
						File.Delete(text2);
						arrayList.Add(text2);
						goto IL_0083;
					}
					goto end_IL_004c;
					IL_0083:
					File.Move(text, text2);
					array[i] = text2;
					end_IL_004c:;
				}
				catch (IOException)
				{
					errors.Add(text);
				}
			}
			else if (!arrayList.Contains(text))
			{
				array[i] = text;
			}
		}
		return array;
	}

	public static void AddReferences(ApplicationManifest manifest, bool addDeploy, string root, string searchDirectory, string relativePath, List<string> filesToIgnore, LockedFileReporter lockedFileReporter, object sender, UpdateProgressEventHandler updateProgress, OverwriteEventHandler overwrite, ArrayList errors)
	{
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected O, but got Unknown
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		if (manifest == null || searchDirectory == null)
		{
			return;
		}
		string[] array = Directory.GetFiles(searchDirectory);
		if (addDeploy)
		{
			array = AppendDeploy(filesToIgnore, array, overwrite, errors);
		}
		List<BaseReference> list = new List<BaseReference>();
		List<BaseReference> list2 = new List<BaseReference>();
		string[] array2 = array;
		foreach (string text in array2)
		{
			bool flag = false;
			string text2 = text;
			string text3 = Path.GetExtension(text2)!.ToLower();
			if (text2 == null)
			{
				continue;
			}
			if (text2.Length >= 2 && text2.Substring(0, 2) == ".\\")
			{
				flag = true;
				text2 = text2.Substring(2);
			}
			if (filesToIgnore.Contains(text2.ToLower()) || (flag && text3 == ".manifest" && filesToIgnore.Contains(Path.GetFullPath(text2).ToLower())))
			{
				continue;
			}
			if (text2.StartsWith(root))
			{
				text2 = text2.Substring(root.Length);
			}
			if (filesToIgnore.Contains(text2.ToLower()) || Path.GetExtension(text2)!.ToLower() == ".netmodule" || (Path.GetExtension(text2)!.ToLower() == ".deploy" && Path.GetExtension(text2.Substring(0, text2.Length - 7))!.ToLower() == ".netmodule"))
			{
				continue;
			}
			AssemblyIdentity val = null;
			try
			{
				val = AssemblyIdentity.FromFile(text);
			}
			catch (BadImageFormatException)
			{
			}
			bool flag2 = val != null;
			try
			{
				FileInfo fileInfo = new FileInfo(text);
				Stream stream = fileInfo.OpenRead();
				stream.Close();
			}
			catch (Exception)
			{
				lockedFileReporter?.Invoke(text);
				continue;
			}
			Action action = Action.AlreadyPresent;
			if (flag2)
			{
				if (!CollectionContains((IEnumerable)((Manifest)manifest).get_AssemblyReferences(), text2, addDeploy, list))
				{
					AssemblyReference val2 = new AssemblyReference();
					((BaseReference)val2).set_TargetPath(text2);
					((Manifest)manifest).get_AssemblyReferences().Add(val2);
					action = Action.Added;
					string text4 = text2;
					if (text4.ToLower().EndsWith(".deploy"))
					{
						text4 = text4.Substring(0, text2.Length - 7).ToLower();
					}
					if (((Manifest)manifest).get_EntryPoint() != null && string.Compare(((BaseReference)((Manifest)manifest).get_EntryPoint()).get_TargetPath(), text4, ignoreCase: true, CultureInfo.InvariantCulture) == 0)
					{
						((Manifest)manifest).set_EntryPoint(val2);
					}
				}
			}
			else if (!CollectionContains((IEnumerable)((Manifest)manifest).get_FileReferences(), text2, addDeploy, list2))
			{
				FileReference val3 = new FileReference();
				((BaseReference)val3).set_TargetPath(text2);
				((Manifest)manifest).get_FileReferences().Add(val3);
				action = Action.Added;
			}
			updateProgress?.Invoke(sender, new UpdateProgressEventArgs(action, text2));
		}
		foreach (BaseReference item in list)
		{
			((Manifest)manifest).get_AssemblyReferences().Remove((AssemblyReference)(object)((item is AssemblyReference) ? item : null));
		}
		foreach (BaseReference item2 in list2)
		{
			((Manifest)manifest).get_FileReferences().Remove((FileReference)(object)((item2 is FileReference) ? item2 : null));
		}
		string[] directories = Directory.GetDirectories(searchDirectory);
		string[] array3 = directories;
		foreach (string text5 in array3)
		{
			string fileName = Path.GetFileName(text5);
			string text6 = null;
			text6 = ((relativePath.Length == 0 || relativePath == ".") ? fileName : (relativePath + "\\" + fileName));
			AddReferences(manifest, addDeploy, root, text5, text6, filesToIgnore, lockedFileReporter, sender, updateProgress, overwrite, errors);
		}
	}

	private static bool CollectionContains(IEnumerable collection, string targetPath, bool addDeploy, List<BaseReference> renamed)
	{
		string text = null;
		if (targetPath.ToLower().EndsWith(".deploy") && renamed != null)
		{
			text = targetPath.Substring(0, targetPath.Length - 7).ToLower();
		}
		foreach (object item in collection)
		{
			BaseReference val = (BaseReference)((item is BaseReference) ? item : null);
			if (val != null && val.get_TargetPath() != null)
			{
				if (text != null && val.get_TargetPath().ToLower() == text)
				{
					renamed.Add(val);
				}
				if (val.get_TargetPath().ToLower() == targetPath.ToLower())
				{
					return true;
				}
			}
		}
		return false;
	}

	public static void SetSpecialFiles(ApplicationManifest manifest)
	{
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		AssemblyReference val = null;
		AssemblyReference val2 = null;
		if (manifest == null)
		{
			return;
		}
		string text = "";
		if (manifest != null && ((Manifest)manifest).get_AssemblyIdentity() != null && ((Manifest)manifest).get_AssemblyIdentity().get_Name() != null)
		{
			text = ((Manifest)manifest).get_AssemblyIdentity().get_Name().ToLower();
			if (!text.EndsWith("exe"))
			{
				text += ".exe";
			}
		}
		if (((Manifest)manifest).get_EntryPoint() == null)
		{
			int num = 0;
			int num2 = 0;
			AssemblyReference entryPoint = null;
			foreach (AssemblyReference assemblyReference in ((Manifest)manifest).get_AssemblyReferences())
			{
				AssemblyReference val3 = assemblyReference;
				if (((BaseReference)val3).get_TargetPath() == null)
				{
					continue;
				}
				string text2 = ((BaseReference)val3).get_TargetPath().ToLower();
				if ((text2.EndsWith("exe") || text2.EndsWith("exe.deploy")) && !text2.EndsWith(".vshost.exe") && !text2.EndsWith(".vshost.exe.deploy"))
				{
					num2++;
					if (num2 == 1)
					{
						entryPoint = val3;
						if (val2 == null)
						{
							val2 = val3;
						}
					}
					else
					{
						entryPoint = null;
					}
					if (val == null && ((Manifest)manifest).get_EntryPoint() != null && ((Manifest)manifest).get_EntryPoint().get_AssemblyIdentity() != null && ((Manifest)manifest).get_EntryPoint().get_AssemblyIdentity().get_Name()
						.ToLower() + ".exe" == text2)
					{
						val = val3;
					}
				}
				if (Path.GetFileName(((BaseReference)val3).get_TargetPath())!.ToLower() == text)
				{
					((Manifest)manifest).set_EntryPoint(val3);
					num++;
				}
			}
			if (num > 1)
			{
				((Manifest)manifest).set_EntryPoint((AssemblyReference)null);
			}
			if (num2 == 1)
			{
				((Manifest)manifest).set_EntryPoint(entryPoint);
			}
			else
			{
				((Manifest)manifest).set_EntryPoint(val2);
			}
		}
		if (((Manifest)manifest).get_EntryPoint() == null)
		{
			((Manifest)manifest).set_EntryPoint(val);
		}
		string text3 = "";
		if (((Manifest)manifest).get_EntryPoint() != null)
		{
			text3 = (((BaseReference)((Manifest)manifest).get_EntryPoint()).get_TargetPath() + ".config").ToLower();
		}
		if ((manifest.get_ConfigFile() != null && !(manifest.get_ConfigFile() == "")) || text3.Length <= 0)
		{
			return;
		}
		foreach (FileReference fileReference in ((Manifest)manifest).get_FileReferences())
		{
			FileReference val4 = fileReference;
			if (((BaseReference)val4).get_TargetPath() != null && Path.GetFileName(((BaseReference)val4).get_TargetPath())!.ToLower() == text3)
			{
				manifest.set_ConfigFile(((BaseReference)val4).get_TargetPath());
				break;
			}
		}
	}

	public static bool ResolveReferences(Manifest manifest, string basePath)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		bool result = true;
		foreach (FileReference fileReference in manifest.get_FileReferences())
		{
			FileReference val = fileReference;
			EnsurePath((BaseReference)(object)val);
			((BaseReference)val).set_SourcePath(Path.Combine(basePath, ((BaseReference)val).get_SourcePath()));
		}
		foreach (AssemblyReference assemblyReference in manifest.get_AssemblyReferences())
		{
			AssemblyReference val2 = assemblyReference;
			EnsurePath((BaseReference)(object)val2);
			((BaseReference)val2).set_SourcePath(Path.Combine(basePath, ((BaseReference)val2).get_SourcePath()));
		}
		manifest.get_OutputMessages().Clear();
		try
		{
			manifest.ResolveFiles();
		}
		catch (ArgumentException)
		{
			result = false;
		}
		try
		{
			manifest.UpdateFileInfo();
		}
		catch (ArgumentException)
		{
			result = false;
		}
		if (manifest.get_OutputMessages().get_ErrorCount() > 0)
		{
			result = false;
		}
		return result;
	}

	public static void UpdateReferenceInfo(Manifest manifest, string basePath, object sender, UpdateProgressEventHandler updateProgress)
	{
		ResolveReferences(manifest, basePath);
		manifest.UpdateFileInfo();
	}

	public static void AddAndUpdateReferences(ApplicationManifest manifest, bool addDeploy, string fromDirectory, List<string> filesToIgnore, object sender, UpdateProgressEventHandler updateProgress, OverwriteEventHandler overwrite)
	{
		ArrayList errors = new ArrayList();
		AddReferences(manifest, addDeploy, fromDirectory, filesToIgnore, null, sender, updateProgress, overwrite, errors);
		SetSpecialFiles(manifest);
		UpdateReferenceInfo((Manifest)(object)manifest, fromDirectory, sender, updateProgress);
		updateProgress?.Invoke(sender, new UpdateProgressEventArgs(Action.Complete, "", errors));
	}

	public static void EnsurePath(BaseReference reference)
	{
		if (reference.get_SourcePath() == null)
		{
			reference.set_SourcePath(reference.get_TargetPath());
		}
		if (reference.get_TargetPath() == null)
		{
			reference.set_TargetPath(reference.get_SourcePath());
		}
		if (reference.get_TargetPath() == null)
		{
			string targetPath;
			reference.set_SourcePath(targetPath = "");
			reference.set_TargetPath(targetPath);
		}
	}
}
