using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace ATI.ACE.CCCInstall.Tasks;

internal class VersionTasks : BaseTask, ITask
{
	private Action action;

	public VersionTasks(CCCInstallLog log, Action action)
		: base(log)
	{
		this.action = action;
	}

	public void Run(string filePath_)
	{
		if (action == Action.CreateVersion)
		{
			string directoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			directoryName = directoryName.Substring(0, directoryName.LastIndexOf(Path.DirectorySeparatorChar) + 1);
			object obj = directoryName;
			directoryName = string.Concat(obj, "Core-Implementation", Path.DirectorySeparatorChar, "CLI.Component.Wizard.dll");
			if (File.Exists(directoryName))
			{
				FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(directoryName);
				string text = string.Format("{0}.{1}", DateTime.Now.ToString("yyyy.MMdd.HHmm"), versionInfo.FilePrivatePart);
				string text2 = filePath_.Replace("/", "\\");
				char[] trimChars = new char[1] { '"' };
				text2 = text2.Trim(trimChars);
				if (!Path.IsPathRooted(text2))
				{
					text2 = Path.GetFullPath(text2);
				}
				StreamWriter streamWriter = null;
				try
				{
					streamWriter = new StreamWriter(text2, append: false);
					streamWriter.WriteLine("Version={0}", text);
					Logger.LogMessage("Version=" + text);
					return;
				}
				catch (Exception e)
				{
					Logger.LogException(e, "CreateVersion");
					return;
				}
				finally
				{
					streamWriter?.Close();
				}
			}
			Logger.LogMessage("Assembly file not found: " + directoryName);
		}
		else
		{
			Logger.LogMessage("Debug: Wrong parameter passed");
		}
	}
}
