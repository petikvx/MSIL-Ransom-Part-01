using System;
using System.Diagnostics;
using System.IO;
using System.Xml;

namespace ATI.ACE.CCCInstall.Tasks;

internal class NgenTasks : BaseTask, ITask
{
	private Action action;

	public NgenTasks(CCCInstallLog log, Action action)
		: base(log)
	{
		this.action = action;
	}

	public void Run(string filePath)
	{
		if (action == Action.UpdateNgen)
		{
			Process process = null;
			StreamWriter streamWriter = null;
			try
			{
				process = new Process();
				process.StartInfo.FileName = "cmd.exe";
				process.StartInfo.CreateNoWindow = true;
				process.StartInfo.Arguments = "/E:ON";
				process.StartInfo.RedirectStandardInput = true;
				process.StartInfo.UseShellExecute = false;
				process.Start();
				streamWriter = process.StandardInput;
				string text = Environment.GetEnvironmentVariable("windir") + "\\Microsoft.NET\\Framework\\v2.0.50727\\ngen update";
				streamWriter.WriteLine(text);
				streamWriter.Flush();
				Logger.LogMessage(text);
				return;
			}
			catch (Exception e)
			{
				Logger.LogException(e);
				return;
			}
			finally
			{
				streamWriter?.Close();
				process?.Close();
			}
		}
		try
		{
			string text2 = MassagePath(filePath);
			string directoryName = Path.GetDirectoryName(text2);
			XmlDocument xmlDocument = LoadXmlDocument(text2);
			if (xmlDocument == null)
			{
				return;
			}
			Process process2 = null;
			StreamWriter streamWriter2 = null;
			try
			{
				Logger.LogMessage("Successfully loaded XML file " + text2);
				XmlNodeList xmlNodeList = xmlDocument.SelectNodes("Package/Include");
				process2 = new Process();
				process2.StartInfo.FileName = "cmd.exe";
				process2.StartInfo.CreateNoWindow = true;
				process2.StartInfo.Arguments = "/E:ON";
				process2.StartInfo.RedirectStandardInput = true;
				process2.StartInfo.UseShellExecute = false;
				process2.Start();
				streamWriter2 = process2.StandardInput;
				foreach (XmlNode item in xmlNodeList)
				{
					XmlAttributeCollection attributes = item.Attributes;
					string innerText = attributes["file"]!.InnerText;
					string innerText2 = attributes["extension"]!.InnerText;
					string text3 = directoryName + "\\" + innerText + "." + innerText2;
					if (!bool.Parse(attributes["nGen"]!.InnerText))
					{
						continue;
					}
					if (File.Exists(text3))
					{
						string empty = string.Empty;
						if (action == Action.InstallNGen)
						{
							empty = Environment.GetEnvironmentVariable("windir") + "\\Microsoft.NET\\Framework\\v2.0.50727\\ngen install \"" + directoryName + "\\" + innerText + "." + innerText2 + "\"";
							streamWriter2.WriteLine(empty);
							Logger.LogMessage(empty);
						}
						else if (action == Action.UninstallNGen)
						{
							empty = Environment.GetEnvironmentVariable("windir") + "\\Microsoft.NET\\Framework\\v2.0.50727\\ngen uninstall \"" + directoryName + "\\" + innerText + "." + innerText2 + "\"";
							streamWriter2.WriteLine(empty);
							Logger.LogMessage(empty);
						}
						else
						{
							Logger.LogMessage("Debug: Wrong parameter passed");
						}
						streamWriter2.Flush();
					}
					else
					{
						Logger.LogMessage("Assembly not found: " + text3);
					}
				}
			}
			catch (Exception e2)
			{
				Logger.LogException(e2);
			}
			finally
			{
				streamWriter2?.Close();
				process2?.Close();
			}
		}
		catch (Exception e3)
		{
			Logger.LogException(e3);
		}
	}
}
