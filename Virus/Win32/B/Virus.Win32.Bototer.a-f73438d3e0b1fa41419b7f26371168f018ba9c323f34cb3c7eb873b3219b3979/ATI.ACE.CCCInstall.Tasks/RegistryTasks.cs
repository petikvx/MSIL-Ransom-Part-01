using System;
using System.IO;
using System.Reflection;
using System.Xml;

namespace ATI.ACE.CCCInstall.Tasks;

internal class RegistryTasks : BaseTask, ITask
{
	private Action action;

	public RegistryTasks(CCCInstallLog log, Action action)
		: base(log)
	{
		this.action = action;
	}

	public void Run(string filePath)
	{
		if (action == Action.CreateReg)
		{
			StreamWriter streamWriter = null;
			try
			{
				string text = MassagePath(filePath);
				string directoryName = Path.GetDirectoryName(text);
				XmlDocument xmlDocument = LoadXmlDocument(text);
				if (xmlDocument == null)
				{
					return;
				}
				Logger.LogMessage("Successfully loaded XML file " + text);
				XmlNodeList xmlNodeList = xmlDocument.SelectNodes("Package/Include");
				streamWriter = new StreamWriter(text.Replace(".xml", ".reg"));
				streamWriter.WriteLine("Windows Registry Editor Version 5.00");
				streamWriter.WriteLine("");
				bool flag = true;
				foreach (XmlNode item in xmlNodeList)
				{
					try
					{
						XmlAttributeCollection attributes = item.Attributes;
						string innerText = attributes["file"]!.InnerText;
						string innerText2 = attributes["extension"]!.InnerText;
						bool flag2 = bool.Parse(attributes["GAC"]!.InnerText);
						string text2 = directoryName + "\\" + innerText + "." + innerText2;
						try
						{
							if (!flag2)
							{
								continue;
							}
							if (File.Exists(text2))
							{
								string value = "\"" + innerText + "\"=\"" + Assembly.ReflectionOnlyLoadFrom(text2).FullName + "\"";
								if (IntPtr.Size == 8)
								{
									streamWriter.WriteLine("[HKEY_LOCAL_MACHINE\\Software\\Wow6432Node\\ATI\\ACE\\Assemblies]");
								}
								else
								{
									streamWriter.WriteLine("[HKEY_LOCAL_MACHINE\\Software\\ATI\\ACE\\Assemblies]");
								}
								streamWriter.WriteLine(value);
								streamWriter.WriteLine();
							}
							else
							{
								Logger.LogMessage("Assembly file not found: " + text2);
							}
						}
						catch (Exception e)
						{
							Logger.LogException(e, "Error loading " + innerText + "." + innerText2);
							flag = false;
						}
					}
					catch (Exception e2)
					{
						Logger.LogException(e2);
						flag = false;
					}
				}
				if (flag)
				{
					Logger.LogMessage("Install.reg file successfully created.");
				}
				else
				{
					Logger.LogMessage("Install.reg file created. Some assemblies had errors.");
				}
				return;
			}
			catch (Exception e3)
			{
				Logger.LogException(e3);
				return;
			}
			finally
			{
				streamWriter?.Close();
			}
		}
		Logger.LogMessage("Debug: Wrong parameter passed");
	}
}
