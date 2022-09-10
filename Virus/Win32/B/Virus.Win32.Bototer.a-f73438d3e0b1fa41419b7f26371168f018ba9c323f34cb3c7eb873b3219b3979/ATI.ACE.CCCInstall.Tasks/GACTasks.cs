using System;
using System.EnterpriseServices.Internal;
using System.IO;
using System.Reflection;
using System.Xml;

namespace ATI.ACE.CCCInstall.Tasks;

internal class GACTasks : BaseTask, ITask
{
	private const string ARG_BRANDING = "Branding";

	private Publish pub;

	private Action action;

	public GACTasks(CCCInstallLog log, Action action)
		: base(log)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		pub = new Publish();
		this.action = action;
	}

	public void Run(string filePath)
	{
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
			foreach (XmlNode item in xmlNodeList)
			{
				try
				{
					XmlAttributeCollection attributes = item.Attributes;
					string innerText = attributes["file"]!.InnerText;
					string innerText2 = attributes["extension"]!.InnerText;
					bool flag = bool.Parse(attributes["GAC"]!.InnerText);
					string text2 = directoryName + "\\" + innerText + "." + innerText2;
					if (!flag)
					{
						continue;
					}
					try
					{
						Assembly.ReflectionOnlyLoadFrom(text2);
						if (action == Action.InstallGAC)
						{
							pub.GacInstall(text2);
							Logger.LogMessage(innerText + "." + innerText2 + " successfully installed into the GAC");
						}
						else if (action == Action.UninstallGAC)
						{
							pub.GacRemove(text2);
							Logger.LogMessage(innerText + "." + innerText2 + " successfully removed from the GAC");
						}
						else
						{
							Logger.LogMessage("Debug: Wrong parameter passed");
						}
					}
					catch (Exception e)
					{
						Logger.LogException(e, innerText + "." + innerText2);
					}
				}
				catch (Exception e2)
				{
					Logger.LogException(e2);
				}
			}
		}
		catch (Exception e3)
		{
			Logger.LogException(e3);
		}
	}
}
