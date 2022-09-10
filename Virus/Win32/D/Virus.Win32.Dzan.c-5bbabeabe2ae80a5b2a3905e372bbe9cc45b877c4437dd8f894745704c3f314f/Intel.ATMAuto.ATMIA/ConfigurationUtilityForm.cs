using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using CliffControl;

namespace Intel.ATMAuto.ATMIA;

public class ConfigurationUtilityForm : Form
{
	public const string ENVIRONMENTS = "//Environments";

	public const string ENVIRONMENT = "Environment";

	public const string BACKENDENVINFO = "BackendEnvInfo";

	public const string SLASHSTR = "//";

	public const string CONFIGINFO = "ConfigInfo";

	public const string CLIFTAG = "IFW";

	private bool ClientAddMode = false;

	private bool ClientEditMode = false;

	private bool RouterAddMode = false;

	private bool RouterEditMode = false;

	private bool WSAddMode = false;

	private bool WSEditMode = false;

	private bool TCPIPEditMode = false;

	private bool GlendaTabAddMode = false;

	private bool GlendaTabEditMode = false;

	private bool SPEEDTabAddMode = false;

	private bool SPEEDTabEditMode = false;

	private bool IRETabAddMode = false;

	private bool IRETabEditMode = false;

	private bool SPCTabAddMode = false;

	private bool SPCTabEditMode = false;

	private XmlDocument ClientDoc;

	private XmlDocument WSInterfaceDoc;

	private XmlDocument RouterDoc;

	private XmlDocument TCPIPDoc;

	private XmlDocument GlendaDoc;

	private XmlDocument SPEEDDoc;

	private XmlDocument IREDoc;

	private XmlDocument SPCDoc;

	private Button cmdWSConfigSaveLogger;

	private Button cmdIREConfigSaveLogger;

	private Button cmdSPEEDSaveLogger;

	private Button cmdGlendaSaveLogger;

	private Button cmdRouterSaveLogger;

	private Button cmdTCPIPSaveLogger;

	private Label label38;

	private Label label39;

	private Label label40;

	private Label label41;

	private Label label42;

	private Label label43;

	private Label label44;

	private Label label45;

	private Label label46;

	private Label label47;

	private Label label48;

	private Label label49;

	private Label label50;

	private Label label51;

	private Label label52;

	private Label label53;

	private Label label54;

	private Label label55;

	private Label label56;

	private Label label57;

	private Label label58;

	private Label label59;

	private Label label60;

	private Label label61;

	private Label label62;

	private Label label63;

	private Label label64;

	private GroupBox grpBoxBackEndEnvironments;

	private TextBox txtHostName;

	private Label lblHostName;

	private TextBox txtAlternateHostName;

	private Label lblAlternateHostName;

	private GroupBox grpBoxHostInformation;

	private GroupBox grpBoxPortInformation;

	private Label lblAlternatePortName;

	private TextBox txtPortNumber;

	private Label lblPortNumber;

	private TextBox txtAlternatePortNumber;

	private GroupBox grpBoxAccountInformation;

	private Label lblPassword;

	private TextBox txtUserName;

	private Label lblUserName;

	private TextBox txtPassword;

	private Button cmdAddBackEndEnv;

	private Button cmdDeleteBackEndEnv;

	private Button cmdEditBackEndEnv;

	private Label lblBackEndEnvironment;

	private TabPage tbpgClient;

	private FolderBrowserDialog folderBrowserDialogLogFiles;

	private TabPage tbpgRouter;

	private Button cmdBackEndEnvOpCancel;

	private Label lblConfirmPassword;

	private TextBox txtConfirmPassword;

	private CheckBox checkBox1;

	private Button cmdWSConfigAdvancedOperation;

	private Button cmdWSConfigFinalSaveTofile;

	private Label lblWSEnvListWarningInformation;

	private GroupBox grpBoxRouterConfigurationInfo;

	private TextBox txtBackEndEnvironment;

	private Label label2;

	private GroupBox grpBoxBackEndEnvName;

	private Label label5;

	private Label label7;

	private Label label6;

	private Label label4;

	private Label label8;

	private Label label9;

	private GroupBox grpBoxClientProxyConfigurationInformation;

	private Label lblClientConfigATMIAEnv;

	private Label lblClientATMIAServerName;

	private GroupBox grpBoxClientOtherParameters;

	private ListBox lstBoxRouterConfigServiceNames;

	private TextBox txtRouterConfigTabInterfaceType;

	private Label lblRouterConfigTabServiceName;

	private Label lblRouterConfigTabInterfaceType;

	private Button cmdRouterConfigTabAddConfigInfo;

	private Button cmdRouterConfigTabDeleteConfigInfo;

	private Button cmdRouterConfigSaveToFile;

	private Button cmdRouterConfigExitApplication;

	private TextBox txtClientProxyATMIAServerName;

	private TextBox txtClientProxyATMIAEnvironment;

	private Label lblClientProxyATMIAServerName;

	private CheckBox chkWSConfigBEIsDefault;

	private CheckBox chkClientProxyATMIAEnvIsDefault;

	private ListBox lstBoxClientProxyEnvironments;

	private TextBox txtClientProxyConfigRetryIntervals;

	private OpenFileDialog openFileDialog1;

	private Label lblDefEnvironmentName;

	private GroupBox grpBoxRouterTabRetryParameters;

	private TextBox txtRouterConfigRetryIntervals;

	private Label lblRouterConfigRetryIntervals;

	private Label lblRetryIntervalExample;

	private Label lblClientProxyConfigRetryIntervals;

	private Label label1;

	private Label label3;

	private Button cmdClientProxyConfigCancelEnv;

	private Button cmdClientProxyConfigDeleteEnv;

	private Button cmdClientProxyConfigEditEnv;

	private Button cmdClientProxyConfigAddEnv;

	private Button cmdClientConfigExitApplication;

	private Button cmdClientConfigSaveToFile;

	private ListBox lstBoxWSBackEnds;

	private Button cmdRouterConfigTabCancel;

	private TextBox txtRouterConfigTabServiceName;

	private Label lblRouterConfigTabMethodName;

	private TextBox txtRouterConfigTabMethodName;

	private Button cmdRouterConfigTabEditConfigInfo;

	private TextBox txtClientConfigTabMethodName;

	private Label lblClientConfigTabServerInteractionInfoMethodName;

	private GroupBox grpBoxClientServerInteractionInfo;

	private GroupBox grpRouterConfigXSL;

	private Label lblReplyXsl;

	private Label lblRequestXsl;

	private Label label10;

	private GroupBox groupBox1;

	private TextBox txtRouterConfigRequestXsl;

	private TextBox txtRouterConfigReplyXsl;

	private TextBox txtWSConfigReplyXSL;

	private Label lblWSConfigReplyXSL;

	private TextBox txtWSConfigRequestXSL;

	private Label lblWSConfigRequestXSL;

	private TextBox txtWSConfigServiceName;

	private Label lblWSConfigServiceName;

	private Button cmdWSConfigAppExit;

	private TabPage tbpgWSInterface;

	private GroupBox groupBox2;

	private Label label11;

	private Label label12;

	private GroupBox groupBox3;

	private Label label14;

	private TextBox txtTCPIPConfigRetryIntervals;

	private Button cmdTCPIPConfigAppExit;

	private Button cmdTCPIPConfigFinalSaveTofile;

	private TabPage tbpgTCPIP;

	private TextBox txtTCPIPPortNum;

	private TabPage tbpgGlenda;

	private TabPage tbpgSPEED;

	private TabPage tbpgIRE;

	private GroupBox groupBox4;

	private Label label13;

	private Label label15;

	private GroupBox groupBox5;

	private Label label16;

	private Label label17;

	private GroupBox groupBox6;

	private Label label18;

	private Label label19;

	private Label label20;

	private GroupBox groupBox7;

	private Label label21;

	private Label label22;

	private GroupBox groupBox8;

	private Label label23;

	private Label label24;

	private GroupBox groupBox10;

	private Label label28;

	private Label label29;

	private GroupBox groupBox11;

	private Label label30;

	private Label label31;

	private Button cmdGlendaConfigExitApplication;

	private Button cmdGlendaConfigSaveToFile;

	private TextBox txtGlendaConfigReplyXsl;

	private TextBox txtGlendaConfigRequestXsl;

	private TextBox txtGlendaConfigRetryIntervals;

	private Button cmdGlendaConfigEdit;

	private TextBox txtGlendaConfigMethodName;

	private Button cmdGlendaConfigDelete;

	private Button cmdGlendaConfigAdd;

	private ListBox lstGlendaEnv;

	private Button cmdGlendaConfigCancel;

	private Button cmdSPEEDConfigExitApplication;

	private Button cmdSPEEDConfigSaveToFile;

	private TextBox txtSPEEDConfigReplyXsl;

	private TextBox txtSPEEDConfigRequestXsl;

	private TextBox txtSPEEDConfigRetryIntervals;

	private Button cmdIREConfigExitApplication;

	private Button cmdIREConfigSaveToFile;

	private TextBox txtIREConfigReplyXsl;

	private TextBox txtIREConfigRequestXsl;

	private TextBox txtIREConfigRetryIntervals;

	private Label lblGlendaConfigEnv;

	private TextBox txtGlendaConfigEnv;

	private CheckBox chkGlendaConfigDefault;

	private GroupBox groupBox12;

	private CheckBox chkSPEEDConfigDefault;

	private Label label32;

	private Button cmdSPEEDConfigEdit;

	private Label label33;

	private TextBox txtSPEEDConfigMethodName;

	private Button cmdSPEEDConfigDelete;

	private Button cmdSPEEDConfigAdd;

	private Label label34;

	private Label label35;

	private Button cmdSPEEDConfigCancel;

	private GroupBox groupBox9;

	private CheckBox chkIREConfigDefault;

	private Label label25;

	private Button cmdIREConfigEdit;

	private Label label26;

	private TextBox txtIREConfigMethodName;

	private Button cmdIREConfigDelete;

	private Button cmdIREConfigAdd;

	private Label label27;

	private Label label36;

	private Button cmdIREConfigCancel;

	private TextBox txtGlendaConfigServerName;

	private Label label37;

	private TextBox txtSPEEDConfigURI;

	private TextBox txtIREConfigServerName;

	private TextBox txtIREConfigEnv;

	private TextBox txtSPEEDConfigEnv;

	private ListBox lstSPEEDEnv;

	private TextBox txtSPEEDConfigTypeName;

	private TextBox txtSPEEDConfigProxyNameSpace;

	private ListBox lstIREEnv;

	private TextBox txtClientConfigTabClassID;

	private Label lblClientConfigTabClassID;

	private TextBox txtIREConfigClassID;

	private TextBox txtGlendaConfigClassID;

	private Label label65;

	private TextBox txtSPEEDConfigProxyMethodParm;

	private CliffControl ClientProxyLogger;

	private CliffControl RouterLogger;

	private CliffControl WSLogger;

	private CliffControl TCPIPLogger;

	private CliffControl GlendaLogger;

	private CliffControl SPEEDLogger;

	private CliffControl IRELogger;

	private TabPage tbpgSPC;

	private CliffControl SPCLogger;

	private Label label66;

	private Label label67;

	private Label label68;

	private Label label69;

	private Label label70;

	private Label label71;

	private Label label72;

	private Label label73;

	private Label label74;

	private Label label75;

	private Label label76;

	private Label label77;

	private Label label78;

	private Label label79;

	private TextBox txtSPCConfigRetryIntervals;

	private TextBox txtSPCConfigReplyXsl;

	private TextBox txtSPCConfigRequestXsl;

	private GroupBox grpBoxSPCXMLs;

	private GroupBox grpBoxSPCRetryParameters;

	private GroupBox grpBoxSPCEnvrionments;

	private Button cmdSPCConfigAdd;

	private ListBox lstSPCEnv;

	private Button cmdSPCConfigSaveLogger;

	private Button cmdSPCConfigSaveToFile;

	private TextBox txtSPCConfigEnv;

	private CheckBox chkSPCConfigDefault;

	private Button cmdSPCConfigEdit;

	private TextBox txtSPCConfigMethodName;

	private Button cmdSPCConfigDelete;

	private TextBox txtSPCConfigClassID;

	private TextBox txtSPCConfigServerName;

	private Button cmdSPCConfigCancel;

	private TabControl tbctrlClientServerRouter;

	private Button cmdSPCConfigExitApplication;

	private Label label80;

	private Label label81;

	private Label label82;

	private Button ErrorConfigBtn;

	private Container components = null;

	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.DoEvents();
		ConfigurationUtilityForm configurationUtilityForm = new ConfigurationUtilityForm();
		if (configurationUtilityForm.CheckClientOrServer())
		{
			Application.Run((Form)(object)configurationUtilityForm);
		}
	}

	public ConfigurationUtilityForm()
	{
		InitializeComponent();
	}

	public bool CheckClientOrServer()
	{
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		bool Active = false;
		bool Active2 = false;
		if (InitialzeDocument(File.Exists("..\\config\\ClientProxy.config"), ref Active, out ClientDoc, "..\\config\\ClientProxy.config", tbpgClient))
		{
			PopulateAllClientProxyConfigTabFields();
		}
		if (InitialzeDocument(File.Exists("..\\config\\ATMIA-WSInterface.config"), ref Active2, out WSInterfaceDoc, "..\\config\\ATMIA-WSInterface.config", tbpgWSInterface))
		{
			PopulateAllWSConfigTabFields();
		}
		if (InitialzeDocument(File.Exists("..\\config\\Router.config"), ref Active2, out RouterDoc, "..\\config\\Router.config", tbpgRouter))
		{
			PopulateAllRouterConfigTabFields();
		}
		if (InitialzeDocument(File.Exists("..\\\\Config\\ATMIA-TCPIP.config"), ref Active2, out TCPIPDoc, "..\\\\Config\\ATMIA-TCPIP.config", tbpgTCPIP))
		{
			PopulateAllTCPIPConfigTabFields();
		}
		if (InitialzeDocument(File.Exists("..\\config\\ATMIA-GlendaInterface.config"), ref Active2, out GlendaDoc, "..\\config\\ATMIA-GlendaInterface.config", tbpgGlenda))
		{
			PopulateAllGlendaConfigTabFields();
		}
		if (InitialzeDocument(File.Exists("..\\config\\ATMIA-SPEEDInterface.config"), ref Active2, out SPEEDDoc, "..\\config\\ATMIA-SPEEDInterface.config", tbpgSPEED))
		{
			PopulateAllSPEEDConfigTabFields();
		}
		if (InitialzeDocument(File.Exists("..\\config\\ATMIA-IREInterface.config"), ref Active2, out IREDoc, "..\\config\\ATMIA-IREInterface.config", tbpgIRE))
		{
			PopulateAllIREConfigTabFields();
		}
		if (InitialzeDocument(File.Exists("..\\config\\ATMIA-SPCInterface.config"), ref Active2, out SPCDoc, "..\\config\\ATMIA-SPCInterface.config", tbpgSPC))
		{
			PopulateAllSPCConfigTabFields();
		}
		if (!Active2 && !Active)
		{
			MessageBox.Show("The config Files do not Exist. please make sure the files are in the Directory", "File Not Found Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			return false;
		}
		return true;
	}

	private void cmdExitApplication()
	{
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Invalid comparison between I4 and Unknown
		bool flag = false;
		string text = "The following component:";
		if (tbctrlClientServerRouter.get_TabPages().Contains(tbpgClient) && (ClientAddMode || ClientEditMode || ClientProxyLogger.get_IsEditMode()))
		{
			flag = true;
			text = " Client Proxy";
		}
		if (tbctrlClientServerRouter.get_TabPages().Contains(tbpgRouter) && (RouterAddMode || RouterEditMode || RouterLogger.get_IsEditMode()))
		{
			flag = true;
			text += " Router";
		}
		if (tbctrlClientServerRouter.get_TabPages().Contains(tbpgWSInterface) && (WSAddMode || WSEditMode || WSLogger.get_IsEditMode()))
		{
			flag = true;
			text += " Workstream-Interface";
		}
		if (tbctrlClientServerRouter.get_TabPages().Contains(tbpgTCPIP) && (TCPIPEditMode || TCPIPLogger.get_IsEditMode()))
		{
			flag = true;
			text += " TCPIP";
		}
		if (tbctrlClientServerRouter.get_TabPages().Contains(tbpgGlenda) && (GlendaTabAddMode || GlendaTabEditMode || GlendaLogger.get_IsEditMode()))
		{
			flag = true;
			text += "Glenda-Interface";
		}
		if (tbctrlClientServerRouter.get_TabPages().Contains(tbpgSPEED) && (SPEEDTabAddMode || SPEEDTabEditMode || SPEEDLogger.get_IsEditMode()))
		{
			flag = true;
			text += "SPEED-Interface";
		}
		if (tbctrlClientServerRouter.get_TabPages().Contains(tbpgIRE) && (IRETabAddMode || IRETabEditMode || IRELogger.get_IsEditMode()))
		{
			flag = true;
			text += "IRE-Interface";
		}
		if (tbctrlClientServerRouter.get_TabPages().Contains(tbpgSPC) && (SPCTabAddMode || SPCTabEditMode || SPCLogger.get_IsEditMode()))
		{
			flag = true;
			text += "SPC-Interface";
		}
		if (!flag || 7 != (int)MessageBox.Show("There were some changes made to " + text + " tab, are you sure you want to Exit", "Warning", (MessageBoxButtons)4, (MessageBoxIcon)48))
		{
			((Form)this).Close();
			Application.Exit();
		}
	}

	private void SaveAllLogger(XmlDocument doc, CliffControl DocLogger, CliffControl FirstLogger, CliffControl SecondLogger, CliffControl ThirdLogger, CliffControl FourthLogger, CliffControl FifthLogger, CliffControl SixthLogger)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		XmlNode xmlNode = doc.SelectSingleNode("//IFW")!.Clone();
		if (!DocLogger.get_IsEditMode())
		{
			MessageBox.Show("Unable to update other logger because there is no change to the logger section.  ", "Logger is not changed", (MessageBoxButtons)0, (MessageBoxIcon)16);
			return;
		}
		DocLogger.GetLogInformationFieldValues(ref xmlNode);
		FirstLogger.RefreshControlFields(xmlNode, true, false);
		FirstLogger.SetEditModeOn();
		SecondLogger.RefreshControlFields(xmlNode, true, false);
		SecondLogger.SetEditModeOn();
		ThirdLogger.RefreshControlFields(xmlNode, true, false);
		ThirdLogger.SetEditModeOn();
		FourthLogger.RefreshControlFields(xmlNode, true, false);
		FourthLogger.SetEditModeOn();
		FifthLogger.RefreshControlFields(xmlNode, true, false);
		FifthLogger.SetEditModeOn();
		SixthLogger.RefreshControlFields(xmlNode, true, false);
		SixthLogger.SetEditModeOn();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private bool InitialzeDocument(bool IsShow, ref bool Active, out XmlDocument Doc, string XmlFile, TabPage page)
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		Active |= IsShow;
		Doc = null;
		try
		{
			if (IsShow)
			{
				Doc = new XmlDocument();
				Doc.Load(XmlFile);
				return true;
			}
			tbctrlClientServerRouter.get_TabPages().Remove(page);
			return false;
		}
		catch (Exception ex)
		{
			MessageBox.Show("Error in Loading the Config files. Check the files are valid. Error Description :  " + ex.Message, "Load XML Exception", (MessageBoxButtons)0, (MessageBoxIcon)16);
			return false;
		}
	}

	private void PopulateLogger(XmlDocument Doc, CliffControl logger)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			logger.RefreshControlFields(Doc.SelectSingleNode("//IFW"), true, true);
		}
		catch (ArgumentOutOfRangeException ex)
		{
			MessageBox.Show("PopulateLogger error: " + ex.Message + " Default Value is Taken", "Argument Out of Range Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		catch (Exception ex2)
		{
			MessageBox.Show("PopulateLogger error: " + ex2.ToString());
		}
	}

	private void PopulateBackendEnv(XmlDocument Doc, ListBox lstBoxBackends)
	{
		string text = "";
		XmlNodeList elementsByTagName = Doc.GetElementsByTagName("BackendEnvInfo");
		foreach (XmlNode item in elementsByTagName)
		{
			if (item.Attributes!.Count > 0)
			{
				if (item.Attributes!.GetNamedItem("default")!.Value == "true")
				{
					text = item.SelectSingleNode("BackendEnv")!.InnerText;
				}
				else
				{
					lstBoxBackends.get_Items().Add((object)item.SelectSingleNode("BackendEnv")!.InnerText);
				}
			}
			else
			{
				lstBoxBackends.get_Items().Add((object)item.SelectSingleNode("BackendEnv")!.InnerText);
			}
		}
		if (text != "")
		{
			lstBoxBackends.get_Items().Insert(0, (object)text);
		}
		((Control)lstBoxBackends).Focus();
		lstBoxBackends.SetSelected(0, true);
		((ListControl)lstBoxBackends).set_SelectedIndex(0);
	}

	private void PopulateConfigRetryParameters(XmlDocument Doc, TextBox txtRetry)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			XmlNode xmlNode = Doc.SelectSingleNode("//RetryInterval");
			if (xmlNode != null)
			{
				((Control)txtRetry).set_Text(xmlNode.InnerText);
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show("PopulateConfigRetryParameters error: " + ex.ToString());
		}
	}

	private void PopulateConfigXSLParameters(XmlDocument Doc, TextBox txtReq, TextBox txtRep)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			XmlNode xmlNode = Doc.SelectSingleNode("//XSL/RequestXSL");
			if (xmlNode != null)
			{
				((Control)txtReq).set_Text(xmlNode.InnerText);
			}
			xmlNode = Doc.SelectSingleNode("//XSL/ReplyXSL");
			if (xmlNode != null)
			{
				((Control)txtRep).set_Text(xmlNode.InnerText);
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show("PopulateConfigXSLParameters error: " + ex.ToString());
		}
	}

	private void PopulateConfigServiceNameParameters(XmlDocument Doc, TextBox txtSvc)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			XmlNode xmlNode = Doc.SelectSingleNode("//ServiceName");
			if (xmlNode != null)
			{
				((Control)txtSvc).set_Text(xmlNode.InnerText);
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show("PopulateConfigServiceNameParameters error: " + ex.ToString());
		}
	}

	private bool SaveLogger(ref XmlDocument Doc, ref CliffControl logger, ref bool ChangeOcurred)
	{
		if (logger.get_IsEditMode())
		{
			XmlNode xmlNode = Doc.SelectSingleNode("//IFW");
			if (!logger.GetLogInformationFieldValues(ref xmlNode))
			{
				ChangeOcurred = false;
				return false;
			}
			logger.set_IsEditMode(false);
			logger.ModifyStateOfFieldsOnControl(false);
			logger.ModifyButtonState(true);
			ChangeOcurred = true;
			return true;
		}
		ChangeOcurred = false;
		return true;
	}

	private bool CheckFileReadOnly(string FileName)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		FileAttributes attributes = File.GetAttributes(FileName);
		if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
		{
			MessageBox.Show("The File cannot be saved since its Read only. please change the Read-Only property to false. ", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			return true;
		}
		return false;
	}

	private bool IsNum(TextBox number, string Name)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			int.Parse(((Control)number).get_Text());
		}
		catch (FormatException)
		{
			MessageBox.Show("Please type a Number in for the" + Name + " Information Fields", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			return false;
		}
		return true;
	}

	private bool IsFieldChange(ref XmlDocument Doc, TextBox field, string fieldName)
	{
		XmlNode xmlNode = Doc.SelectSingleNode(fieldName);
		string innerText = xmlNode.InnerText;
		if (innerText != ((Control)field).get_Text())
		{
			xmlNode.InnerText = ((Control)field).get_Text();
			return true;
		}
		return false;
	}

	private XmlElement CreateBackEndEnvNode(XmlDocument Doc, string name, string serverName, string methodName, string classID)
	{
		XmlElement xmlElement = Doc.CreateElement("BackendEnvInfo");
		xmlElement.SetAttribute("default", "false");
		XmlElement xmlElement2 = Doc.CreateElement("BackendEnv");
		xmlElement2.InnerText = name;
		XmlElement xmlElement3 = Doc.CreateElement("ServerName");
		xmlElement3.InnerText = serverName;
		XmlElement xmlElement4 = Doc.CreateElement("MethodName");
		xmlElement4.InnerText = methodName;
		XmlElement xmlElement5 = Doc.CreateElement("ClassID");
		xmlElement5.InnerText = classID;
		xmlElement.AppendChild(xmlElement2);
		xmlElement.AppendChild(xmlElement3);
		xmlElement.AppendChild(xmlElement4);
		xmlElement.AppendChild(xmlElement5);
		return xmlElement;
	}

	private void ProcessToChangeDefaultNode(XmlDocument Doc, XmlNode node, ListBox list, string defaultName, bool addMode)
	{
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		XmlNode xmlNode = Doc.SelectSingleNode("//BackendEnvInfo[@default=\"true\"]");
		if (node != null)
		{
			if (node.Attributes!.Count == 0)
			{
				node.Attributes!.Append(Doc.CreateAttribute("default"));
			}
			node.Attributes!.GetNamedItem("default")!.Value = "true";
			xmlNode.Attributes!.GetNamedItem("default")!.Value = "false";
			string text = list.get_Items().get_Item(0).ToString();
			list.get_Items().set_Item(0, (object)defaultName);
			if (addMode)
			{
				list.get_Items().Add((object)text);
			}
			else
			{
				list.get_Items().set_Item(((ListControl)list).get_SelectedIndex(), (object)text);
			}
			((Control)list).Refresh();
			((ListControl)list).set_SelectedIndex(0);
		}
		else
		{
			MessageBox.Show("File has been corrupted, please contact ATMIA support");
		}
	}

	private void PopulateEnvironmentField(XmlDocument Doc, string name, TextBox configEnv, TextBox serverName, TextBox methodName, TextBox classID)
	{
		XmlNodeList xmlNodeList = Doc.SelectNodes("//BackendEnvInfo");
		if (xmlNodeList.Count == 0)
		{
			return;
		}
		foreach (XmlNode item in xmlNodeList)
		{
			if (item.SelectSingleNode("BackendEnv")!.InnerText == name)
			{
				((Control)configEnv).set_Text(item.SelectSingleNode("BackendEnv")!.InnerText);
				((Control)serverName).set_Text(item.SelectSingleNode("ServerName")!.InnerText);
				((Control)methodName).set_Text(item.SelectSingleNode("MethodName")!.InnerText);
				((Control)classID).set_Text(item.SelectSingleNode("ClassID")!.InnerText);
			}
		}
	}

	private void PopulateAllWSConfigTabFields()
	{
		PopulateLogger(WSInterfaceDoc, WSLogger);
		PopulateConfigServiceNameParameters(WSInterfaceDoc, txtWSConfigServiceName);
		PopulateConfigXSLParameters(WSInterfaceDoc, txtWSConfigRequestXSL, txtWSConfigReplyXSL);
		PopulateBackendEnv(WSInterfaceDoc, lstBoxWSBackEnds);
		WSEditMode = false;
		WSAddMode = false;
	}

	private void PopulateBackEndEnvironmentFields(string backEndEnvironment)
	{
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			XmlNodeList elementsByTagName = WSInterfaceDoc.GetElementsByTagName("BackendEnvInfo");
			if (elementsByTagName.Count == 0)
			{
				return;
			}
			foreach (XmlNode item in elementsByTagName)
			{
				XmlNode xmlNode2 = item.SelectSingleNode("BackendEnv");
				string innerText = xmlNode2.InnerText;
				if (innerText == backEndEnvironment)
				{
					((Control)txtBackEndEnvironment).set_Text(item.SelectSingleNode("BackendEnv")!.InnerText);
					((Control)txtHostName).set_Text(item.SelectSingleNode("HostName")!.InnerText);
					((Control)txtPortNumber).set_Text(item.SelectSingleNode("PortNum")!.InnerText);
					((Control)txtAlternateHostName).set_Text(item.SelectSingleNode("AltHostName")!.InnerText);
					((Control)txtAlternatePortNumber).set_Text(item.SelectSingleNode("AltPortNum")!.InnerText);
					((Control)txtUserName).set_Text(item.SelectSingleNode("Username")!.InnerText);
					((Control)txtPassword).set_Text(item.SelectSingleNode("Password")!.InnerText);
					((Control)txtConfirmPassword).set_Text(item.SelectSingleNode("Password")!.InnerText);
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void lstBoxBackEnds_SelectedIndexChanged(object sender, EventArgs e)
	{
		WSAddMode = false;
		WSEditMode = false;
		ModifyBackEndEnvironmentFieldState(stateValue: false);
		ModifyWSConfigTabInfoButtonState(stateValue: true);
		PopulateBackEndEnvironmentFields(((Control)lstBoxWSBackEnds).get_Text());
		if (((ListControl)lstBoxWSBackEnds).get_SelectedIndex() == 0)
		{
			((Control)cmdDeleteBackEndEnv).set_Enabled(false);
			chkWSConfigBEIsDefault.set_Checked(true);
		}
		else
		{
			((Control)cmdDeleteBackEndEnv).set_Enabled(true);
			chkWSConfigBEIsDefault.set_Checked(false);
		}
	}

	private void cmdBackEndEnvOpCancel_Click(object sender, EventArgs e)
	{
		lstBoxWSBackEnds.SetSelected(0, true);
		ModifyBackEndEnvironmentFieldState(stateValue: false);
		ModifyWSConfigTabInfoButtonState(stateValue: true);
		((Control)cmdDeleteBackEndEnv).set_Enabled(false);
		chkWSConfigBEIsDefault.set_Checked(true);
		WSAddMode = false;
		WSEditMode = false;
	}

	private void cmdAddBackEndEnv_Click(object sender, EventArgs e)
	{
		lstBoxWSBackEnds.SetSelected(0, false);
		ModifyBackEndEnvironmentFieldState(stateValue: true);
		ModifyWSConfigTabInfoButtonState(stateValue: false);
		((Control)txtAlternateHostName).set_Text("");
		((Control)txtHostName).set_Text("");
		((Control)txtPortNumber).set_Text("");
		((Control)txtAlternatePortNumber).set_Text("");
		((Control)txtPassword).set_Text("");
		((Control)txtUserName).set_Text("");
		((Control)txtBackEndEnvironment).set_Text("");
		((Control)txtConfirmPassword).set_Text("");
		chkWSConfigBEIsDefault.set_Checked(false);
		WSAddMode = true;
	}

	private void cmdEditBackEndEnv_Click(object sender, EventArgs e)
	{
		WSEditMode = true;
		ModifyBackEndEnvironmentFieldState(stateValue: true);
		if (((ListControl)lstBoxWSBackEnds).get_SelectedIndex() == 0)
		{
			((Control)chkWSConfigBEIsDefault).set_Enabled(false);
		}
		ModifyWSConfigTabInfoButtonState(stateValue: false);
	}

	private void cmdDeleteBackEndEnv_Click(object sender, EventArgs e)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Invalid comparison between Unknown and I4
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		FileAttributes attributes = File.GetAttributes("..\\config\\ATMIA-WSInterface.config");
		if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
		{
			MessageBox.Show("The File cannot be Modified since its Read only. please change the Read-Only property to false. ", "Warning", (MessageBoxButtons)0, (MessageBoxIcon)48);
			return;
		}
		DialogResult val = MessageBox.Show("Are you Sure you want to Delete ? The file will automatically be saved after deletion", "Deletion of File", (MessageBoxButtons)1, (MessageBoxIcon)48);
		if ((int)val == 1)
		{
			string xpath = "//Service[ServiceName='WIP']/BackendEnvironment/BackendEnvInfo[BackendEnv='" + ((Control)txtBackEndEnvironment).get_Text() + "']";
			XmlNode xmlNode = WSInterfaceDoc.SelectSingleNode(xpath);
			XmlNode parentNode = xmlNode.ParentNode;
			parentNode.RemoveChild(xmlNode);
			WSInterfaceDoc.Save("..\\config\\ATMIA-WSInterface.config");
			ModifyWSConfigTabInfoButtonState(stateValue: false);
			lstBoxWSBackEnds.get_Items().Remove((object)((Control)txtBackEndEnvironment).get_Text());
			((Control)lstBoxWSBackEnds).Refresh();
			((ListControl)lstBoxWSBackEnds).set_SelectedIndex(0);
			MessageBox.Show("The BackEnd Environment has been Successfully deleted", "Deletion of File", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
	}

	private void txtWSConfigServiceName_TextChanged(object sender, EventArgs e)
	{
		WSEditMode = true;
	}

	private void txtWSConfigRequestXSL_TextChanged(object sender, EventArgs e)
	{
		WSEditMode = true;
	}

	private void txtWSConfigReplyXSL_TextChanged(object sender, EventArgs e)
	{
		WSEditMode = true;
	}

	private XmlElement CreateWSBackEndEnvNode()
	{
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			XmlElement xmlElement = WSInterfaceDoc.CreateElement("BackendEnvInfo");
			xmlElement.SetAttribute("default", "false");
			XmlElement xmlElement2 = WSInterfaceDoc.CreateElement("BackendEnv");
			xmlElement2.InnerText = ((Control)txtBackEndEnvironment).get_Text();
			XmlElement xmlElement3 = WSInterfaceDoc.CreateElement("HostName");
			xmlElement3.InnerText = ((Control)txtHostName).get_Text();
			XmlElement xmlElement4 = WSInterfaceDoc.CreateElement("PortNum");
			xmlElement4.InnerText = ((Control)txtPortNumber).get_Text();
			XmlElement xmlElement5 = WSInterfaceDoc.CreateElement("AltHostName");
			xmlElement5.InnerText = ((Control)txtAlternateHostName).get_Text();
			XmlElement xmlElement6 = WSInterfaceDoc.CreateElement("AltPortNum");
			xmlElement6.InnerText = ((Control)txtAlternatePortNumber).get_Text();
			XmlElement xmlElement7 = WSInterfaceDoc.CreateElement("Username");
			xmlElement7.InnerText = ((Control)txtUserName).get_Text();
			XmlElement xmlElement8 = WSInterfaceDoc.CreateElement("Password");
			xmlElement8.InnerText = XMLHelper.Encrypt(((Control)txtPassword).get_Text());
			xmlElement.AppendChild(xmlElement2);
			xmlElement.AppendChild(xmlElement3);
			xmlElement.AppendChild(xmlElement4);
			xmlElement.AppendChild(xmlElement5);
			xmlElement.AppendChild(xmlElement6);
			xmlElement.AppendChild(xmlElement7);
			xmlElement.AppendChild(xmlElement8);
			return xmlElement;
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
			return null;
		}
	}

	private void processToChangeDefaultWSBackEndEnvironment(XmlNode node)
	{
		XmlNode xmlNode = WSInterfaceDoc.SelectSingleNode("//BackendEnvInfo[@default=\"true\"]");
		if (node.Attributes!.Count == 0)
		{
			node.Attributes!.Append(WSInterfaceDoc.CreateAttribute("default"));
		}
		node.Attributes!.GetNamedItem("default")!.Value = "true";
		xmlNode.Attributes!.GetNamedItem("default")!.Value = "false";
		string text = lstBoxWSBackEnds.get_Items().get_Item(0).ToString();
		lstBoxWSBackEnds.get_Items().set_Item(0, (object)((Control)txtBackEndEnvironment).get_Text());
		if (WSAddMode)
		{
			lstBoxWSBackEnds.get_Items().Add((object)text);
		}
		else
		{
			lstBoxWSBackEnds.get_Items().set_Item(((ListControl)lstBoxWSBackEnds).get_SelectedIndex(), (object)text);
		}
		((Control)lstBoxWSBackEnds).Refresh();
		((ListControl)lstBoxWSBackEnds).set_SelectedIndex(0);
	}

	private void ModifyWSConfigTabInfoButtonState(bool stateValue)
	{
		((Control)cmdAddBackEndEnv).set_Visible(stateValue);
		((Control)cmdEditBackEndEnv).set_Visible(stateValue);
		if (((ListControl)lstBoxWSBackEnds).get_SelectedIndex() != 0)
		{
			((Control)cmdDeleteBackEndEnv).set_Visible(stateValue);
		}
	}

	private void ModifyBackEndEnvironmentFieldState(bool stateValue)
	{
		((Control)txtAlternateHostName).set_Enabled(stateValue);
		((Control)txtHostName).set_Enabled(stateValue);
		((Control)txtPortNumber).set_Enabled(stateValue);
		((Control)txtAlternatePortNumber).set_Enabled(stateValue);
		((Control)txtPassword).set_Enabled(stateValue);
		((Control)txtUserName).set_Enabled(stateValue);
		((Control)txtBackEndEnvironment).set_Enabled(stateValue);
		((Control)txtConfirmPassword).set_Enabled(stateValue);
		((Control)chkWSConfigBEIsDefault).set_Enabled(stateValue);
	}

	private void cmdWSConfigAdvancedOperation_Click(object sender, EventArgs e)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Invalid comparison between I4 and Unknown
		FileAttributes attributes = File.GetAttributes("..\\config\\ATMIA-WSInterface.config");
		if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
		{
			MessageBox.Show("The File cannot be Modifed since it is Read only. please change the Read-Only property to false. ", "Warning", (MessageBoxButtons)0, (MessageBoxIcon)48);
			return;
		}
		string xpath = "//Service[ServiceName='WIP']/Operations";
		XmlNode xmlNode = WSInterfaceDoc.SelectSingleNode(xpath);
		AdvancedInformationForm advancedInformationForm = new AdvancedInformationForm(xmlNode);
		if (2 != (int)((Form)advancedInformationForm).ShowDialog())
		{
			return;
		}
		ArrayList operationsList = advancedInformationForm.OperationsList;
		xmlNode.RemoveAll();
		foreach (string item in operationsList)
		{
			XmlElement xmlElement = WSInterfaceDoc.CreateElement("OperationName");
			xmlElement.InnerText = item;
			xmlNode.AppendChild(xmlElement);
		}
		WSInterfaceDoc.Save("..\\config\\ATMIA-WSInterface.config");
	}

	private void cmdWSConfigSaveLogger_Click(object sender, EventArgs e)
	{
		SaveAllLogger(WSInterfaceDoc, WSLogger, RouterLogger, TCPIPLogger, IRELogger, GlendaLogger, SPEEDLogger, SPCLogger);
	}

	private void cmdWSConfigFinalSaveTofile_Click(object sender, EventArgs e)
	{
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		bool ChangeOcurred = false;
		if (CheckFileReadOnly("..\\config\\ATMIA-WSInterface.config"))
		{
			return;
		}
		if (WSAddMode || WSEditMode)
		{
			if (((Control)txtBackEndEnvironment).get_Text().Length == 0 || ((Control)txtHostName).get_Text().Length == 0 || ((Control)txtPortNumber).get_Text().Length == 0 || ((Control)txtUserName).get_Text().Length == 0 || ((Control)txtPassword).get_Text().Length == 0 || ((Control)txtConfirmPassword).get_Text().Length == 0)
			{
				MessageBox.Show("Please make sure all the Mandatory tags (*) are filled", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
				return;
			}
			if (!IsNum(txtPortNumber, "PortNumber") || (((Control)txtAlternatePortNumber).get_Text().Length != 0 && !IsNum(txtAlternatePortNumber, "Altername PortNumber")))
			{
				return;
			}
			if (((Control)txtPassword).get_Text() != ((Control)txtConfirmPassword).get_Text())
			{
				MessageBox.Show("Please make sure you typed the same password in both fields", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
				return;
			}
		}
		try
		{
			Cursor current = Cursor.get_Current();
			Cursor.set_Current(Cursors.get_WaitCursor());
			if (!SaveLogger(ref WSInterfaceDoc, ref WSLogger, ref ChangeOcurred))
			{
				return;
			}
			ChangeOcurred = (ChangeOcurred = (ChangeOcurred |= IsFieldChange(ref WSInterfaceDoc, txtWSConfigServiceName, "//ServiceName")) | IsFieldChange(ref WSInterfaceDoc, txtWSConfigRequestXSL, "//XSL/RequestXSL")) | IsFieldChange(ref WSInterfaceDoc, txtWSConfigReplyXSL, "//XSL/ReplyXSL");
			if (WSAddMode)
			{
				if (lstBoxWSBackEnds.get_Items().Contains((object)((Control)txtBackEndEnvironment).get_Text()))
				{
					MessageBox.Show("This environment already exists", "Warning", (MessageBoxButtons)0, (MessageBoxIcon)48);
					return;
				}
				XmlNodeList elementsByTagName = WSInterfaceDoc.GetElementsByTagName("BackendEnvInfo");
				if (elementsByTagName.Count == 0)
				{
					return;
				}
				XmlNode xmlNode = WSInterfaceDoc.SelectSingleNode("//BackendEnvironment");
				XmlElement xmlElement = CreateWSBackEndEnvNode();
				if (chkWSConfigBEIsDefault.get_Checked() && ((Control)chkWSConfigBEIsDefault).get_Enabled())
				{
					processToChangeDefaultWSBackEndEnvironment(xmlElement);
					xmlNode.PrependChild(xmlElement);
				}
				else
				{
					xmlNode.AppendChild(xmlElement);
					lstBoxWSBackEnds.get_Items().Add((object)((Control)txtBackEndEnvironment).get_Text());
					((Control)lstBoxWSBackEnds).Refresh();
					((ListControl)lstBoxWSBackEnds).set_SelectedIndex(lstBoxWSBackEnds.get_Items().get_Count() - 1);
					ModifyWSConfigTabInfoButtonState(stateValue: true);
					ChangeOcurred = true;
					WSAddMode = false;
				}
			}
			if (WSEditMode)
			{
				string xpath = "//Service/BackendEnvironment/BackendEnvInfo[BackendEnv='" + lstBoxWSBackEnds.get_SelectedItem().ToString() + "']";
				XmlNode xmlNode2 = WSInterfaceDoc.SelectSingleNode(xpath);
				xmlNode2.SelectSingleNode("BackendEnv")!.InnerText = ((Control)txtBackEndEnvironment).get_Text();
				xmlNode2.SelectSingleNode("HostName")!.InnerText = ((Control)txtHostName).get_Text();
				xmlNode2.SelectSingleNode("PortNum")!.InnerText = ((Control)txtPortNumber).get_Text();
				xmlNode2.SelectSingleNode("AltHostName")!.InnerText = ((Control)txtAlternateHostName).get_Text();
				xmlNode2.SelectSingleNode("AltPortNum")!.InnerText = ((Control)txtAlternatePortNumber).get_Text();
				xmlNode2.SelectSingleNode("Username")!.InnerText = ((Control)txtUserName).get_Text();
				string innerText = xmlNode2.SelectSingleNode("Password")!.InnerText;
				if (innerText != ((Control)txtPassword).get_Text())
				{
					xmlNode2.SelectSingleNode("Password")!.InnerText = XMLHelper.Encrypt(((Control)txtPassword).get_Text());
				}
				if (chkWSConfigBEIsDefault.get_Checked() && ((Control)chkWSConfigBEIsDefault).get_Enabled())
				{
					processToChangeDefaultWSBackEndEnvironment(xmlNode2);
				}
				else
				{
					lstBoxWSBackEnds.get_Items().set_Item(((ListControl)lstBoxWSBackEnds).get_SelectedIndex(), (object)((Control)txtBackEndEnvironment).get_Text());
					((Control)lstBoxWSBackEnds).Refresh();
					((ListControl)lstBoxWSBackEnds).set_SelectedIndex(0);
				}
				ChangeOcurred = true;
			}
			if (ChangeOcurred)
			{
				WSInterfaceDoc.Save("..\\config\\ATMIA-WSInterface.config");
				MessageBox.Show("The values have been saved to the File", "Confirmation", (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
			WSAddMode = false;
			WSEditMode = false;
			Cursor.set_Current(current);
		}
		catch (Exception ex)
		{
			MessageBox.Show("cmdWSConfigFinalSaveTofile_Click error " + ex.Message);
		}
	}

	private void cmdWSConfigAppExit_Click(object sender, EventArgs e)
	{
		cmdExitApplication();
	}

	private void PopulateAllRouterConfigTabFields()
	{
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			PopulateLogger(RouterDoc, RouterLogger);
			PopulateConfigRetryParameters(RouterDoc, txtRouterConfigRetryIntervals);
			PopulateConfigXSLParameters(RouterDoc, txtRouterConfigRequestXsl, txtRouterConfigReplyXsl);
			XmlNodeList xmlNodeList = RouterDoc.SelectNodes("//ServiceName");
			if (xmlNodeList == null || (xmlNodeList != null && xmlNodeList.Count == 0))
			{
				return;
			}
			foreach (XmlNode item in xmlNodeList)
			{
				lstBoxRouterConfigServiceNames.get_Items().Add((object)item.InnerText);
			}
			((Control)lstBoxRouterConfigServiceNames).Focus();
			lstBoxRouterConfigServiceNames.SetSelected(0, true);
			((ListControl)lstBoxRouterConfigServiceNames).set_SelectedIndex(0);
			RouterEditMode = false;
			RouterAddMode = false;
		}
		catch (Exception ex)
		{
			MessageBox.Show("PopulateAllRouterConfigTabFields error: " + ex.Message);
		}
	}

	private void lstBoxRouterConfigServiceNames_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		RouterAddMode = false;
		try
		{
			XmlNodeList xmlNodeList = RouterDoc.SelectNodes("//ConfigInfo");
			foreach (XmlNode item in xmlNodeList)
			{
				if (item.SelectSingleNode("ServiceName")!.InnerText == ((Control)lstBoxRouterConfigServiceNames).get_Text())
				{
					((Control)txtRouterConfigTabMethodName).set_Text(item.SelectSingleNode("MethodName")!.InnerText);
					((Control)txtRouterConfigTabInterfaceType).set_Text(item.SelectSingleNode("InterfaceType")!.InnerText);
					((Control)txtRouterConfigTabServiceName).set_Text(item.SelectSingleNode("ServiceName")!.InnerText);
				}
			}
			ModifyRouterConfigInfoFieldState(stateValue: false);
			ModifyRouterConfigInfoButtonState(stateValue: true);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.ToString());
		}
	}

	private void cmdRouterConfigTabAddConfigInfo_Click(object sender, EventArgs e)
	{
		((Control)cmdRouterConfigTabCancel).set_Enabled(true);
		if (lstBoxRouterConfigServiceNames.get_Items().get_Count() != 0)
		{
			lstBoxRouterConfigServiceNames.SetSelected(0, false);
		}
		ModifyRouterConfigInfoButtonState(stateValue: false);
		ModifyRouterConfigInfoFieldState(stateValue: true);
		((Control)txtRouterConfigTabMethodName).set_Text("");
		((Control)txtRouterConfigTabInterfaceType).set_Text("");
		((Control)txtRouterConfigTabServiceName).set_Text("");
		RouterAddMode = true;
	}

	private void cmdRouterConfigTabCancel_Click(object sender, EventArgs e)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			lstBoxRouterConfigServiceNames.SetSelected(0, true);
			ModifyRouterConfigInfoButtonState(stateValue: true);
			RouterAddMode = false;
			RouterEditMode = false;
		}
		catch (Exception ex)
		{
			MessageBox.Show("cmdRouterConfigTabCancel_Click Error: " + ex.ToString());
		}
	}

	private void cmdRouterConfigTabDeleteConfigInfo_Click(object sender, EventArgs e)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between I4 and Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (CheckFileReadOnly("..\\config\\Router.config"))
			{
				return;
			}
			RouterDoc.SelectNodes("//ConfigInfo");
			if (1 == (int)MessageBox.Show("Are you Sure you want to Delete ? The file will automatically be saved after deletion", "Deletion of File", (MessageBoxButtons)1, (MessageBoxIcon)48))
			{
				string xpath = "//ConfigInfo[ServiceName='" + ((Control)txtRouterConfigTabServiceName).get_Text() + "']";
				XmlNode xmlNode = RouterDoc.SelectSingleNode(xpath);
				XmlNode parentNode = xmlNode.ParentNode;
				parentNode.RemoveChild(xmlNode);
				RouterDoc.Save("..\\config\\Router.config");
				lstBoxRouterConfigServiceNames.get_Items().Remove((object)((Control)txtRouterConfigTabServiceName).get_Text());
				if (lstBoxRouterConfigServiceNames.get_Items().get_Count() != 0)
				{
					((Control)lstBoxRouterConfigServiceNames).Refresh();
					((ListControl)lstBoxRouterConfigServiceNames).set_SelectedIndex(0);
				}
				MessageBox.Show("The Configuration Information has been Successfully deleted", "Information", (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show("cmdRouterConfigTabDeleteConfigInfo_Click error " + ex.ToString());
		}
	}

	private void cmdRouterConfigTabEditConfigInfo_Click(object sender, EventArgs e)
	{
		RouterEditMode = true;
		((Control)cmdRouterConfigTabCancel).set_Enabled(true);
		ModifyRouterConfigInfoButtonState(stateValue: false);
		ModifyRouterConfigInfoFieldState(stateValue: true);
	}

	private void txtRouterConfigRetryIntervals_TextChanged(object sender, EventArgs e)
	{
		RouterEditMode = true;
	}

	private void txtRequestXsl_TextChanged(object sender, EventArgs e)
	{
		RouterEditMode = true;
	}

	private void txtReplyXsl_TextChanged(object sender, EventArgs e)
	{
		RouterEditMode = true;
	}

	private void ModifyRouterConfigInfoFieldState(bool stateValue)
	{
		((Control)txtRouterConfigTabInterfaceType).set_Enabled(stateValue);
		((Control)txtRouterConfigTabMethodName).set_Enabled(stateValue);
		((Control)txtRouterConfigTabServiceName).set_Enabled(stateValue);
	}

	private void ModifyRouterConfigInfoButtonState(bool stateValue)
	{
		((Control)cmdRouterConfigTabAddConfigInfo).set_Enabled(stateValue);
		((Control)cmdRouterConfigTabDeleteConfigInfo).set_Enabled(stateValue);
		((Control)cmdRouterConfigTabEditConfigInfo).set_Enabled(stateValue);
	}

	private void cmdRouterSaveLogger_Click(object sender, EventArgs e)
	{
		SaveAllLogger(RouterDoc, RouterLogger, WSLogger, TCPIPLogger, IRELogger, GlendaLogger, SPEEDLogger, SPCLogger);
	}

	private void cmdRouterConfigSaveToFile_Click(object sender, EventArgs e)
	{
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		bool ChangeOcurred = false;
		if (CheckFileReadOnly("..\\config\\Router.config"))
		{
			return;
		}
		if ((!RouterAddMode && !RouterEditMode) || (((Control)txtRouterConfigTabMethodName).get_Text().Length != 0 && ((Control)txtRouterConfigTabInterfaceType).get_Text().Length != 0 && ((Control)txtRouterConfigTabServiceName).get_Text().Length != 0))
		{
			try
			{
				Cursor current = Cursor.get_Current();
				Cursor.set_Current(Cursors.get_WaitCursor());
				if (SaveLogger(ref RouterDoc, ref RouterLogger, ref ChangeOcurred))
				{
					ChangeOcurred = (ChangeOcurred = (ChangeOcurred |= IsFieldChange(ref RouterDoc, txtRouterConfigRetryIntervals, "//RetryInterval")) | IsFieldChange(ref RouterDoc, txtRouterConfigRequestXsl, "//XSL/RequestXSL")) | IsFieldChange(ref RouterDoc, txtRouterConfigReplyXsl, "//XSL/ReplyXSL");
					if (RouterAddMode)
					{
						if (lstBoxRouterConfigServiceNames.get_Items().Contains((object)((Control)txtRouterConfigTabServiceName).get_Text()))
						{
							MessageBox.Show("This environment already exists, no saving is made", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
							return;
						}
						lstBoxRouterConfigServiceNames.get_Items().Add((object)((Control)txtRouterConfigTabServiceName).get_Text());
						((Control)lstBoxRouterConfigServiceNames).Refresh();
						((ListControl)lstBoxRouterConfigServiceNames).set_SelectedIndex(lstBoxRouterConfigServiceNames.get_Items().get_Count() - 1);
						ModifyRouterConfigInfoButtonState(stateValue: true);
						XmlElement xmlElement = RouterDoc.CreateElement("ConfigInfo");
						XmlElement xmlElement2 = RouterDoc.CreateElement("MethodName");
						xmlElement2.InnerText = ((Control)txtRouterConfigTabMethodName).get_Text();
						XmlElement xmlElement3 = RouterDoc.CreateElement("InterfaceType");
						xmlElement3.InnerText = ((Control)txtRouterConfigTabInterfaceType).get_Text();
						XmlElement xmlElement4 = RouterDoc.CreateElement("ServiceName");
						xmlElement4.InnerText = ((Control)txtRouterConfigTabServiceName).get_Text();
						xmlElement.AppendChild(xmlElement2);
						xmlElement.AppendChild(xmlElement3);
						xmlElement.AppendChild(xmlElement4);
						XmlNode xmlNode = RouterDoc.SelectSingleNode("//RouterConfig");
						xmlNode.AppendChild(xmlElement);
						ChangeOcurred = true;
						RouterAddMode = false;
					}
					if (RouterEditMode)
					{
						ModifyRouterConfigInfoButtonState(stateValue: false);
						string xpath = "//ConfigInfo[ServiceName='" + lstBoxRouterConfigServiceNames.get_SelectedItem().ToString() + "']";
						XmlNode xmlNode2 = RouterDoc.SelectSingleNode(xpath);
						xmlNode2.SelectSingleNode("MethodName")!.InnerText = ((Control)txtRouterConfigTabMethodName).get_Text();
						xmlNode2.SelectSingleNode("InterfaceType")!.InnerText = ((Control)txtRouterConfigTabInterfaceType).get_Text();
						xmlNode2.SelectSingleNode("ServiceName")!.InnerText = ((Control)txtRouterConfigTabServiceName).get_Text();
						lstBoxRouterConfigServiceNames.get_Items().set_Item(((ListControl)lstBoxRouterConfigServiceNames).get_SelectedIndex(), (object)((Control)txtRouterConfigTabServiceName).get_Text());
						((Control)lstBoxRouterConfigServiceNames).Refresh();
						((ListControl)lstBoxRouterConfigServiceNames).set_SelectedIndex(0);
						ChangeOcurred = true;
					}
					if (ChangeOcurred)
					{
						RouterDoc.Save("..\\config\\Router.config");
						((ListControl)lstBoxRouterConfigServiceNames).set_SelectedIndex(0);
						MessageBox.Show("The Router Config file has been saved", "Information", (MessageBoxButtons)0, (MessageBoxIcon)64);
					}
					RouterEditMode = false;
					RouterAddMode = false;
					Cursor.set_Current(current);
				}
				return;
			}
			catch (Exception ex)
			{
				MessageBox.Show("cmdRouterConfigSaveToFile_Click error: " + ex.Message);
				return;
			}
		}
		MessageBox.Show("Please make sure all the fields are filled in", "Warning", (MessageBoxButtons)0, (MessageBoxIcon)48);
	}

	private void cmdRouterConfigExitApplication_Click(object sender, EventArgs e)
	{
		cmdExitApplication();
	}

	private void PopulateAllClientProxyConfigTabFields()
	{
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		try
		{
			PopulateLogger(ClientDoc, ClientProxyLogger);
			PopulateConfigRetryParameters(ClientDoc, txtClientProxyConfigRetryIntervals);
			XmlNode xmlNode;
			if ((xmlNode = ClientDoc.SelectSingleNode("//ClassID")) != null)
			{
				((Control)txtClientConfigTabClassID).set_Text(xmlNode.InnerText);
			}
			if ((xmlNode = ClientDoc.SelectSingleNode("//MethodName")) != null)
			{
				((Control)txtClientConfigTabMethodName).set_Text(xmlNode.InnerText);
			}
			XmlNodeList xmlNodeList = ClientDoc.SelectNodes("//Environment");
			foreach (XmlNode item in xmlNodeList)
			{
				string innerText = item.SelectSingleNode("ATMIAEnv")!.InnerText;
				if (item.Attributes!.Count > 0)
				{
					if (item.Attributes!.GetNamedItem("default")!.Value == "true")
					{
						text = innerText;
					}
					else
					{
						lstBoxClientProxyEnvironments.get_Items().Add((object)innerText);
					}
				}
				else
				{
					lstBoxClientProxyEnvironments.get_Items().Add((object)innerText);
				}
			}
			if (text != "")
			{
				lstBoxClientProxyEnvironments.get_Items().Insert(0, (object)text);
			}
			((Control)lstBoxClientProxyEnvironments).Focus();
			lstBoxClientProxyEnvironments.SetSelected(0, true);
			((ListControl)lstBoxClientProxyEnvironments).set_SelectedIndex(0);
			ClientEditMode = false;
			ClientAddMode = false;
		}
		catch (Exception ex)
		{
			MessageBox.Show("Exception in setting Client proxy tab. " + ex.Message);
		}
	}

	private XmlElement CreateATMIAConfigurationEnvironmentNodeForClientProxy()
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			XmlElement xmlElement = ClientDoc.CreateElement("Environment");
			xmlElement.SetAttribute("default", "false");
			XmlElement xmlElement2 = ClientDoc.CreateElement("ATMIAEnv");
			xmlElement2.InnerText = ((Control)txtClientProxyATMIAEnvironment).get_Text();
			XmlElement xmlElement3 = ClientDoc.CreateElement("ATMIAServerName");
			xmlElement3.InnerText = ((Control)txtClientProxyATMIAServerName).get_Text();
			xmlElement.AppendChild(xmlElement2);
			xmlElement.AppendChild(xmlElement3);
			return xmlElement;
		}
		catch (Exception ex)
		{
			MessageBox.Show("CreateATMIAConfigurationEnvironmentNodeForClientProxy error: " + ex.ToString());
			return null;
		}
	}

	private void ModifyClientProxyConfigInfoFieldState(bool stateValue)
	{
		((Control)txtClientProxyATMIAEnvironment).set_Enabled(stateValue);
		((Control)txtClientProxyATMIAServerName).set_Enabled(stateValue);
		((Control)chkClientProxyATMIAEnvIsDefault).set_Enabled(stateValue);
	}

	private void ModifyClientProxyConfigInfoButtonState(bool stateValue)
	{
		((Control)cmdClientProxyConfigAddEnv).set_Enabled(stateValue);
		((Control)cmdClientProxyConfigEditEnv).set_Enabled(stateValue);
		if (((ListControl)lstBoxClientProxyEnvironments).get_SelectedIndex() != 0)
		{
			((Control)cmdClientProxyConfigDeleteEnv).set_Enabled(stateValue);
		}
	}

	private void txtClientProxyConfigRetryIntervals_TextChanged(object sender, EventArgs e)
	{
		ClientEditMode = true;
	}

	private void processToChangeDefaultClientProxyATMIAEnvironment(XmlNode node)
	{
		XmlNode xmlNode = ClientDoc.SelectSingleNode("//Environment[@default='true']");
		if (node.Attributes!.Count == 0)
		{
			node.Attributes!.Append(ClientDoc.CreateAttribute("default"));
		}
		node.Attributes!.GetNamedItem("default")!.Value = "true";
		xmlNode.Attributes!.GetNamedItem("default")!.Value = "false";
		string text = lstBoxClientProxyEnvironments.get_Items().get_Item(0).ToString();
		lstBoxClientProxyEnvironments.get_Items().set_Item(0, (object)((Control)txtClientProxyATMIAEnvironment).get_Text());
		if (ClientAddMode)
		{
			lstBoxClientProxyEnvironments.get_Items().Add((object)text);
		}
		else
		{
			lstBoxClientProxyEnvironments.get_Items().set_Item(((ListControl)lstBoxClientProxyEnvironments).get_SelectedIndex(), (object)text);
		}
		((Control)lstBoxClientProxyEnvironments).Refresh();
		((ListControl)lstBoxClientProxyEnvironments).set_SelectedIndex(0);
	}

	private void lstBoxClientProxyEnvironments_SelectedIndexChanged(object sender, EventArgs e)
	{
		ClientAddMode = false;
		ClientEditMode = false;
		ModifyClientProxyConfigInfoFieldState(stateValue: false);
		ModifyClientProxyConfigInfoButtonState(stateValue: true);
		PopulateClientProxyEnvironmentFields(((Control)lstBoxClientProxyEnvironments).get_Text());
		if (((ListControl)lstBoxClientProxyEnvironments).get_SelectedIndex() == 0)
		{
			((Control)cmdClientProxyConfigDeleteEnv).set_Enabled(false);
			chkClientProxyATMIAEnvIsDefault.set_Checked(true);
		}
		else
		{
			((Control)cmdClientProxyConfigDeleteEnv).set_Enabled(true);
			chkClientProxyATMIAEnvIsDefault.set_Checked(false);
		}
	}

	private void txtClientConfigTabMethodName_TextChanged(object sender, EventArgs e)
	{
		ClientEditMode = true;
	}

	private void txtClientConfigTabClassID_TextChanged(object sender, EventArgs e)
	{
		ClientEditMode = true;
	}

	private void PopulateClientProxyEnvironmentFields(string atmiaEnv)
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			XmlNodeList xmlNodeList = ClientDoc.SelectNodes("//Environment");
			if (xmlNodeList.Count == 0)
			{
				return;
			}
			foreach (XmlNode item in xmlNodeList)
			{
				if (item.SelectSingleNode("ATMIAEnv")!.InnerText == atmiaEnv)
				{
					((Control)txtClientProxyATMIAEnvironment).set_Text(item.SelectSingleNode("ATMIAEnv")!.InnerText);
					((Control)txtClientProxyATMIAServerName).set_Text(item.SelectSingleNode("ATMIAServerName")!.InnerText);
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show("PopulateClientProxyEnvironmentFields error " + ex.ToString());
		}
	}

	private void cmdClientProxyConfigAddEnv_Click(object sender, EventArgs e)
	{
		lstBoxClientProxyEnvironments.SetSelected(0, false);
		ModifyClientProxyConfigInfoFieldState(stateValue: true);
		ModifyClientProxyConfigInfoButtonState(stateValue: false);
		((Control)txtClientProxyATMIAEnvironment).set_Text("");
		((Control)txtClientProxyATMIAServerName).set_Text("");
		chkClientProxyATMIAEnvIsDefault.set_Checked(false);
		ClientAddMode = true;
	}

	private void cmdClientProxyConfigEditEnv_Click(object sender, EventArgs e)
	{
		ClientEditMode = true;
		ModifyClientProxyConfigInfoFieldState(stateValue: true);
		if (((ListControl)lstBoxClientProxyEnvironments).get_SelectedIndex() == 0)
		{
			((Control)chkClientProxyATMIAEnvIsDefault).set_Enabled(false);
		}
		ModifyClientProxyConfigInfoButtonState(stateValue: false);
	}

	private void cmdClientProxyConfigDeleteEnv_Click(object sender, EventArgs e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between I4 and Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		if (!CheckFileReadOnly("..\\config\\ClientProxy.config") && 1 == (int)MessageBox.Show("Are you Sure you want to Delete ? The file will automatically be saved after deletion", "Deletion of File", (MessageBoxButtons)1, (MessageBoxIcon)48))
		{
			string xpath = "//Environments/Environment[ATMIAEnv='" + ((Control)txtClientProxyATMIAEnvironment).get_Text() + "']";
			XmlNode xmlNode = ClientDoc.SelectSingleNode(xpath);
			XmlNode parentNode = xmlNode.ParentNode;
			parentNode.RemoveChild(xmlNode);
			ClientDoc.Save("..\\config\\ClientProxy.config");
			ModifyClientProxyConfigInfoButtonState(stateValue: false);
			lstBoxClientProxyEnvironments.get_Items().Remove((object)((Control)txtClientProxyATMIAEnvironment).get_Text());
			((Control)lstBoxClientProxyEnvironments).Refresh();
			((ListControl)lstBoxClientProxyEnvironments).set_SelectedIndex(0);
			MessageBox.Show("The ATMIA Environment has been Successfully deleted", "Information", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
	}

	private void cmdClientProxyConfigCancelEnv_Click(object sender, EventArgs e)
	{
		lstBoxClientProxyEnvironments.SetSelected(0, true);
		ModifyClientProxyConfigInfoFieldState(stateValue: false);
		ModifyClientProxyConfigInfoButtonState(stateValue: true);
		((Control)cmdClientProxyConfigDeleteEnv).set_Enabled(false);
		chkClientProxyATMIAEnvIsDefault.set_Checked(true);
		ClientAddMode = false;
		ClientEditMode = false;
	}

	private void cmdClientConfigSaveToFile_Click(object sender, EventArgs e)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		bool ChangeOcurred = false;
		if (CheckFileReadOnly("..\\config\\ClientProxy.config"))
		{
			return;
		}
		if ((!ClientAddMode && !ClientEditMode) || (((Control)txtClientProxyATMIAEnvironment).get_Text().Length != 0 && ((Control)txtClientProxyATMIAServerName).get_Text().Length != 0))
		{
			Cursor current = Cursor.get_Current();
			Cursor.set_Current(Cursors.get_WaitCursor());
			if (!SaveLogger(ref ClientDoc, ref ClientProxyLogger, ref ChangeOcurred))
			{
				return;
			}
			try
			{
				if (IsFieldChange(ref ClientDoc, txtClientProxyConfigRetryIntervals, "//RetryInterval"))
				{
					ChangeOcurred = true;
				}
				if (ClientAddMode)
				{
					if (lstBoxClientProxyEnvironments.get_Items().Contains((object)((Control)txtClientProxyATMIAEnvironment).get_Text()))
					{
						MessageBox.Show("This environment already exists, no saving is made", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
						return;
					}
					XmlNode xmlNode = ClientDoc.SelectSingleNode("//Environments");
					XmlElement xmlElement = CreateATMIAConfigurationEnvironmentNodeForClientProxy();
					if (chkClientProxyATMIAEnvIsDefault.get_Checked() && ((Control)chkClientProxyATMIAEnvIsDefault).get_Enabled())
					{
						processToChangeDefaultClientProxyATMIAEnvironment(xmlElement);
						xmlNode.PrependChild(xmlElement);
					}
					else
					{
						xmlNode.AppendChild(xmlElement);
						lstBoxClientProxyEnvironments.get_Items().Add((object)((Control)txtClientProxyATMIAEnvironment).get_Text());
						((Control)lstBoxClientProxyEnvironments).Refresh();
						((ListControl)lstBoxClientProxyEnvironments).set_SelectedIndex(lstBoxClientProxyEnvironments.get_Items().get_Count() - 1);
					}
					ModifyClientProxyConfigInfoButtonState(stateValue: true);
					ChangeOcurred = true;
					ClientAddMode = false;
				}
				if (ClientEditMode)
				{
					string xpath = "//Environments/Environment[ATMIAEnv='" + lstBoxClientProxyEnvironments.get_SelectedItem().ToString() + "']";
					XmlNode xmlNode2 = ClientDoc.SelectSingleNode(xpath);
					xmlNode2.SelectSingleNode("ATMIAEnv")!.InnerText = ((Control)txtClientProxyATMIAEnvironment).get_Text();
					xmlNode2.SelectSingleNode("ATMIAServerName")!.InnerText = ((Control)txtClientProxyATMIAServerName).get_Text();
					((Control)lstBoxClientProxyEnvironments).Refresh();
					if (chkClientProxyATMIAEnvIsDefault.get_Checked() && ((Control)chkClientProxyATMIAEnvIsDefault).get_Enabled())
					{
						processToChangeDefaultClientProxyATMIAEnvironment(xmlNode2);
					}
					else
					{
						lstBoxClientProxyEnvironments.get_Items().set_Item(((ListControl)lstBoxClientProxyEnvironments).get_SelectedIndex(), (object)((Control)txtClientProxyATMIAEnvironment).get_Text());
					}
					((ListControl)lstBoxClientProxyEnvironments).set_SelectedIndex(0);
					lstBoxClientProxyEnvironments.SetSelected(0, true);
					((Control)lstBoxClientProxyEnvironments).Refresh();
					ChangeOcurred = true;
				}
				if (ChangeOcurred)
				{
					ClientDoc.Save("..\\config\\ClientProxy.config");
					MessageBox.Show("The Changes have been Saved to the File", "Information", (MessageBoxButtons)0, (MessageBoxIcon)64);
				}
				ClientEditMode = false;
				ClientAddMode = false;
				Cursor.set_Current(current);
				return;
			}
			catch (Exception ex)
			{
				MessageBox.Show("cmdClientConfigSaveToFile_Click error: " + ex.Message);
				return;
			}
		}
		MessageBox.Show("Please make sure all the Mandatory tags (*) are filled", "Warning", (MessageBoxButtons)0, (MessageBoxIcon)48);
	}

	private void cmdClientConfigExitApplication_Click(object sender, EventArgs e)
	{
		cmdExitApplication();
	}

	private void ErrorConfigBtn_Click(object sender, EventArgs e)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between I4 and Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Invalid comparison between I4 and Unknown
		if (7 == (int)MessageBox.Show("Any change made will be saved automatically unless you click on Cancel button in the next window.  Are you sure to continue? ", "Warning", (MessageBoxButtons)4, (MessageBoxIcon)48))
		{
			return;
		}
		FileAttributes attributes = File.GetAttributes("..\\config\\ClientProxy.config");
		if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
		{
			MessageBox.Show("The File cannot be Modifed since it is Read only. please change the Read-Only property to false. ", "Warning", (MessageBoxButtons)0, (MessageBoxIcon)48);
			return;
		}
		XmlNode xmlNode = ClientDoc.SelectSingleNode("//ExceptionTypes");
		XmlNode xmlNode2 = ClientDoc.SelectSingleNode("//ErrorTypes");
		XmlNode xmlNode3 = ClientDoc.SelectSingleNode("//NumErrorRetries");
		RetryErrorForm retryErrorForm = new RetryErrorForm(xmlNode, xmlNode2, xmlNode3);
		if (1 == (int)((Form)retryErrorForm).ShowDialog())
		{
			xmlNode3.InnerText = retryErrorForm.RetryNode.InnerText;
			xmlNode.RemoveAll();
			for (int i = 0; i < retryErrorForm.ExceptionNode.ChildNodes.Count; i++)
			{
				xmlNode.AppendChild(retryErrorForm.ExceptionNode.ChildNodes[i]!.Clone());
			}
			xmlNode2.RemoveAll();
			XmlNodeList xmlNodeList = retryErrorForm.ErrorNode.SelectNodes("ErrorType");
			for (int j = 0; j < xmlNodeList.Count; j++)
			{
				xmlNode2.AppendChild(xmlNodeList.Item(j)!.Clone());
			}
			ClientDoc.Save("..\\config\\ClientProxy.config");
		}
	}

	private void PopulateAllTCPIPConfigTabFields()
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			PopulateLogger(TCPIPDoc, TCPIPLogger);
			PopulateConfigRetryParameters(TCPIPDoc, txtTCPIPConfigRetryIntervals);
			XmlNode xmlNode = TCPIPDoc.SelectSingleNode("//Port");
			if (xmlNode != null)
			{
				((Control)txtTCPIPPortNum).set_Text(xmlNode.InnerText);
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show("PopulateAllTCPIPConfigTabFields Error " + ex.ToString());
		}
		TCPIPEditMode = false;
	}

	private void txtPortNum_TextChanged(object sender, EventArgs e)
	{
		TCPIPEditMode = true;
	}

	private void txtTCPIPConfigRetryIntervals_TextChanged(object sender, EventArgs e)
	{
		TCPIPEditMode = true;
	}

	private void cmdTCPIPSaveLogger_Click(object sender, EventArgs e)
	{
		SaveAllLogger(TCPIPDoc, TCPIPLogger, RouterLogger, WSLogger, IRELogger, GlendaLogger, SPEEDLogger, SPCLogger);
	}

	private void cmdTCPIPConfigFinalSaveTofile_Click(object sender, EventArgs e)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		bool ChangeOcurred = false;
		if (CheckFileReadOnly("..\\\\Config\\ATMIA-TCPIP.config"))
		{
			return;
		}
		if (TCPIPEditMode)
		{
			if (((Control)txtTCPIPPortNum).get_Text().Length == 0)
			{
				MessageBox.Show("Please make sure the Mandatory Port Number is filled", "Warning", (MessageBoxButtons)0, (MessageBoxIcon)48);
				return;
			}
			if (!IsNum(txtTCPIPPortNum, "PortNumber"))
			{
				return;
			}
		}
		try
		{
			Cursor current = Cursor.get_Current();
			Cursor.set_Current(Cursors.get_WaitCursor());
			if (SaveLogger(ref TCPIPDoc, ref TCPIPLogger, ref ChangeOcurred))
			{
				if (ChangeOcurred = (ChangeOcurred |= IsFieldChange(ref TCPIPDoc, txtTCPIPPortNum, "//Port")) | IsFieldChange(ref TCPIPDoc, txtTCPIPConfigRetryIntervals, "//RetryInterval"))
				{
					TCPIPDoc.Save("..\\\\Config\\ATMIA-TCPIP.config");
					MessageBox.Show("The values have been saved to the File", "Confirmation", (MessageBoxButtons)0, (MessageBoxIcon)64);
				}
				TCPIPEditMode = false;
				Cursor.set_Current(current);
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show("cmdTCPIPConfigFinalSaveTofile_Click error " + ex.Message);
		}
	}

	private void cmdTCPIPConfigAppExit_Click(object sender, EventArgs e)
	{
		cmdExitApplication();
	}

	private void PopulateAllGlendaConfigTabFields()
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			PopulateLogger(GlendaDoc, GlendaLogger);
			PopulateConfigRetryParameters(GlendaDoc, txtGlendaConfigRetryIntervals);
			PopulateConfigXSLParameters(GlendaDoc, txtGlendaConfigRequestXsl, txtGlendaConfigReplyXsl);
			PopulateBackendEnv(GlendaDoc, lstGlendaEnv);
			GlendaTabEditMode = false;
			GlendaTabAddMode = false;
		}
		catch (Exception ex)
		{
			MessageBox.Show("PopulateAllGlendaConfigTabFields error: " + ex.Message);
		}
	}

	private XmlElement CreateBackendEnvironmentNodeForGlenda()
	{
		return CreateBackEndEnvNode(GlendaDoc, ((Control)txtGlendaConfigEnv).get_Text(), ((Control)txtGlendaConfigServerName).get_Text(), ((Control)txtGlendaConfigMethodName).get_Text(), ((Control)txtGlendaConfigClassID).get_Text());
	}

	private void ModifyGlendaConfigInfoFieldState(bool stateValue)
	{
		((Control)txtGlendaConfigEnv).set_Enabled(stateValue);
		((Control)txtGlendaConfigServerName).set_Enabled(stateValue);
		((Control)txtGlendaConfigMethodName).set_Enabled(stateValue);
		((Control)txtGlendaConfigClassID).set_Enabled(stateValue);
		((Control)chkGlendaConfigDefault).set_Enabled(stateValue);
	}

	private void ModifyGlendaConfigInfoButtonState(bool stateValue)
	{
		((Control)cmdGlendaConfigAdd).set_Enabled(stateValue);
		((Control)cmdGlendaConfigEdit).set_Enabled(stateValue);
		if (((ListControl)lstGlendaEnv).get_SelectedIndex() != 0)
		{
			((Control)cmdGlendaConfigDelete).set_Enabled(stateValue);
		}
	}

	private void ProcessToChangeDefaultGlendaConfigEnvironment(XmlNode node)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ProcessToChangeDefaultNode(GlendaDoc, node, lstGlendaEnv, ((Control)txtGlendaConfigEnv).get_Text(), GlendaTabAddMode);
		}
		catch (Exception ex)
		{
			MessageBox.Show("ProcessToChangeDefaultGlendaConfigEnvironment error: " + ex.Message);
		}
	}

	private void PopulateGlendaEnvironmentFields(string name)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			PopulateEnvironmentField(GlendaDoc, name, txtGlendaConfigEnv, txtGlendaConfigServerName, txtGlendaConfigMethodName, txtGlendaConfigClassID);
		}
		catch (Exception ex)
		{
			MessageBox.Show("PopulateGlendaEnvironmentFields error " + ex.ToString());
		}
	}

	private void txtGlendatConfigRetryIntervals_TextChanged(object sender, EventArgs e)
	{
		GlendaTabEditMode = true;
	}

	private void txtGlendaConfigRequestXsl_TextChanged(object sender, EventArgs e)
	{
		GlendaTabEditMode = true;
	}

	private void txtGlendaConfigReplyXsl_TextChanged(object sender, EventArgs e)
	{
		GlendaTabEditMode = true;
	}

	private void lstGlendaEnv_SelectedIndexChanged(object sender, EventArgs e)
	{
		GlendaTabAddMode = false;
		GlendaTabEditMode = false;
		ModifyGlendaConfigInfoFieldState(stateValue: false);
		ModifyGlendaConfigInfoButtonState(stateValue: true);
		PopulateGlendaEnvironmentFields(((Control)lstGlendaEnv).get_Text());
		if (((ListControl)lstGlendaEnv).get_SelectedIndex() == 0)
		{
			((Control)cmdGlendaConfigDelete).set_Enabled(false);
			chkGlendaConfigDefault.set_Checked(true);
		}
		else
		{
			((Control)cmdGlendaConfigDelete).set_Enabled(true);
			chkGlendaConfigDefault.set_Checked(false);
		}
	}

	private void cmdGlendaConfigAdd_Click(object sender, EventArgs e)
	{
		if (lstGlendaEnv.get_Items().get_Count() != 0)
		{
			lstGlendaEnv.SetSelected(0, false);
		}
		ModifyGlendaConfigInfoFieldState(stateValue: true);
		ModifyGlendaConfigInfoButtonState(stateValue: false);
		((Control)txtGlendaConfigEnv).set_Text("");
		((Control)txtGlendaConfigServerName).set_Text("");
		((Control)txtGlendaConfigMethodName).set_Text("");
		((Control)txtGlendaConfigClassID).set_Text("");
		chkGlendaConfigDefault.set_Checked(false);
		GlendaTabAddMode = true;
	}

	private void cmdGlendaConfigEdit_Click(object sender, EventArgs e)
	{
		GlendaTabEditMode = true;
		ModifyGlendaConfigInfoFieldState(stateValue: true);
		if (((ListControl)lstGlendaEnv).get_SelectedIndex() == 0)
		{
			((Control)chkGlendaConfigDefault).set_Enabled(false);
		}
		ModifyGlendaConfigInfoButtonState(stateValue: false);
	}

	private void cmdGlendaConfigDelete_Click(object sender, EventArgs e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between I4 and Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		if (!CheckFileReadOnly("..\\config\\ATMIA-GlendaInterface.config") && 1 == (int)MessageBox.Show("Are you Sure you want to Delete ? The file will automatically be saved after deletion", "Deletion of File", (MessageBoxButtons)1, (MessageBoxIcon)48))
		{
			string xpath = "//GlendaEnvironments/BackendEnvInfo[BackendEnv='" + ((Control)txtGlendaConfigEnv).get_Text() + "']";
			XmlNode xmlNode = GlendaDoc.SelectSingleNode(xpath);
			XmlNode parentNode = xmlNode.ParentNode;
			parentNode.RemoveChild(xmlNode);
			GlendaDoc.Save("..\\config\\ATMIA-GlendaInterface.config");
			ModifyGlendaConfigInfoButtonState(stateValue: false);
			lstGlendaEnv.get_Items().Remove((object)((Control)txtGlendaConfigEnv).get_Text());
			((Control)lstGlendaEnv).Refresh();
			((ListControl)lstGlendaEnv).set_SelectedIndex(0);
			MessageBox.Show("The ATMIA Environment has been Successfully deleted", "Information", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
	}

	private void cmdGlendaConfigCancel_Click(object sender, EventArgs e)
	{
		lstGlendaEnv.SetSelected(0, true);
		ModifyGlendaConfigInfoFieldState(stateValue: false);
		ModifyGlendaConfigInfoButtonState(stateValue: true);
		((Control)cmdGlendaConfigDelete).set_Enabled(false);
		chkGlendaConfigDefault.set_Checked(true);
		GlendaTabAddMode = false;
		GlendaTabEditMode = false;
	}

	private void cmdGlendaSaveLogger_Click(object sender, EventArgs e)
	{
		SaveAllLogger(GlendaDoc, GlendaLogger, RouterLogger, TCPIPLogger, IRELogger, WSLogger, SPEEDLogger, SPCLogger);
	}

	private void cmdGlendaConfigSaveToFile_Click(object sender, EventArgs e)
	{
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		bool ChangeOcurred = false;
		if (CheckFileReadOnly("..\\config\\ATMIA-GlendaInterface.config"))
		{
			return;
		}
		if ((!GlendaTabAddMode && !GlendaTabEditMode) || (((Control)txtGlendaConfigEnv).get_Text().Length != 0 && ((Control)txtGlendaConfigServerName).get_Text().Length != 0 && ((Control)txtGlendaConfigMethodName).get_Text().Length != 0 && ((Control)txtGlendaConfigClassID).get_Text().Length != 0))
		{
			Cursor current = Cursor.get_Current();
			Cursor.set_Current(Cursors.get_WaitCursor());
			if (!SaveLogger(ref GlendaDoc, ref GlendaLogger, ref ChangeOcurred))
			{
				return;
			}
			try
			{
				ChangeOcurred = (ChangeOcurred = (ChangeOcurred |= IsFieldChange(ref GlendaDoc, txtGlendaConfigRetryIntervals, "//RetryInterval")) | IsFieldChange(ref GlendaDoc, txtGlendaConfigRequestXsl, "//XSL/RequestXSL")) | IsFieldChange(ref GlendaDoc, txtGlendaConfigReplyXsl, "//XSL/ReplyXSL");
				if (GlendaTabAddMode)
				{
					if (lstGlendaEnv.get_Items().Contains((object)((Control)txtGlendaConfigEnv).get_Text()))
					{
						MessageBox.Show("This environment already exists, no saving is made", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
						return;
					}
					XmlNode xmlNode = GlendaDoc.SelectSingleNode("//GlendaEnvironments");
					XmlElement xmlElement = CreateBackendEnvironmentNodeForGlenda();
					if (chkGlendaConfigDefault.get_Checked() && ((Control)chkGlendaConfigDefault).get_Enabled())
					{
						ProcessToChangeDefaultGlendaConfigEnvironment(xmlElement);
						xmlNode.PrependChild(xmlElement);
					}
					else
					{
						xmlNode.AppendChild(xmlElement);
						lstGlendaEnv.get_Items().Add((object)((Control)txtGlendaConfigEnv).get_Text());
						((Control)lstGlendaEnv).Refresh();
						((ListControl)lstGlendaEnv).set_SelectedIndex(lstGlendaEnv.get_Items().get_Count() - 1);
					}
					ModifyGlendaConfigInfoButtonState(stateValue: true);
					ChangeOcurred = true;
				}
				if (GlendaTabEditMode)
				{
					string xpath = "//GlendaEnvironments/BackendEnvInfo[BackendEnv='" + lstGlendaEnv.get_SelectedItem().ToString() + "']";
					XmlNode xmlNode2 = GlendaDoc.SelectSingleNode(xpath);
					xmlNode2.SelectSingleNode("BackendEnv")!.InnerText = ((Control)txtGlendaConfigEnv).get_Text();
					xmlNode2.SelectSingleNode("ServerName")!.InnerText = ((Control)txtGlendaConfigServerName).get_Text();
					xmlNode2.SelectSingleNode("MethodName")!.InnerText = ((Control)txtGlendaConfigMethodName).get_Text();
					xmlNode2.SelectSingleNode("ClassID")!.InnerText = ((Control)txtGlendaConfigClassID).get_Text();
					((Control)lstGlendaEnv).Refresh();
					if (chkGlendaConfigDefault.get_Checked() && ((Control)chkGlendaConfigDefault).get_Enabled())
					{
						ProcessToChangeDefaultGlendaConfigEnvironment(xmlNode2);
					}
					else
					{
						lstGlendaEnv.get_Items().set_Item(((ListControl)lstGlendaEnv).get_SelectedIndex(), (object)((Control)txtGlendaConfigEnv).get_Text());
					}
					((ListControl)lstGlendaEnv).set_SelectedIndex(0);
					lstGlendaEnv.SetSelected(0, true);
					((Control)lstGlendaEnv).Refresh();
					ChangeOcurred = true;
				}
				if (ChangeOcurred)
				{
					GlendaDoc.Save("..\\config\\ATMIA-GlendaInterface.config");
					MessageBox.Show("The Changes have been Saved to the File", "Information", (MessageBoxButtons)0, (MessageBoxIcon)64);
				}
				GlendaTabEditMode = false;
				GlendaTabAddMode = false;
				Cursor.set_Current(current);
				return;
			}
			catch (Exception ex)
			{
				MessageBox.Show("cmdGlendaConfigSaveToFile_Click error: " + ex.Message);
				return;
			}
		}
		MessageBox.Show("Please make sure all the Mandatory tags (*) are filled", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private void cmdGlendaConfigExitApplication_Click(object sender, EventArgs e)
	{
		cmdExitApplication();
	}

	private void PopulateAllIREConfigTabFields()
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			PopulateLogger(IREDoc, IRELogger);
			PopulateConfigRetryParameters(IREDoc, txtIREConfigRetryIntervals);
			PopulateConfigXSLParameters(IREDoc, txtIREConfigRequestXsl, txtIREConfigReplyXsl);
			PopulateBackendEnv(IREDoc, lstIREEnv);
			IRETabEditMode = false;
			IRETabAddMode = false;
		}
		catch (Exception ex)
		{
			MessageBox.Show("PopulateAllIREConfigTabFields error: " + ex.Message);
		}
	}

	private XmlElement CreateBackendEnvironmentNodeForIRE()
	{
		return CreateBackEndEnvNode(IREDoc, ((Control)txtIREConfigEnv).get_Text(), ((Control)txtIREConfigServerName).get_Text(), ((Control)txtIREConfigMethodName).get_Text(), ((Control)txtIREConfigClassID).get_Text());
	}

	private void ModifyIREConfigInfoFieldState(bool stateValue)
	{
		((Control)txtIREConfigEnv).set_Enabled(stateValue);
		((Control)txtIREConfigServerName).set_Enabled(stateValue);
		((Control)txtIREConfigMethodName).set_Enabled(stateValue);
		((Control)txtIREConfigClassID).set_Enabled(stateValue);
		((Control)chkIREConfigDefault).set_Enabled(stateValue);
	}

	private void ModifyIREConfigInfoButtonState(bool stateValue)
	{
		((Control)cmdIREConfigAdd).set_Enabled(stateValue);
		((Control)cmdIREConfigEdit).set_Enabled(stateValue);
		if (((ListControl)lstIREEnv).get_SelectedIndex() != 0)
		{
			((Control)cmdIREConfigDelete).set_Enabled(stateValue);
		}
	}

	private void ProcessToChangeDefaultIREConfigEnvironment(XmlNode node)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ProcessToChangeDefaultNode(IREDoc, node, lstIREEnv, ((Control)txtIREConfigEnv).get_Text(), IRETabAddMode);
		}
		catch (Exception ex)
		{
			MessageBox.Show("ProcessToChangeDefaultIREConfigEnvironment error: " + ex.Message);
		}
	}

	private void PopulateIREEnvironmentFields(string name)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			PopulateEnvironmentField(IREDoc, name, txtIREConfigEnv, txtIREConfigServerName, txtIREConfigMethodName, txtIREConfigClassID);
		}
		catch (Exception ex)
		{
			MessageBox.Show("PopulateIREEnvironmentFields error " + ex.ToString());
		}
	}

	private void txtIREConfigRetryIntervals_TextChanged(object sender, EventArgs e)
	{
		IRETabEditMode = true;
	}

	private void txtIREConfigRequestXsl_TextChanged(object sender, EventArgs e)
	{
		IRETabEditMode = true;
	}

	private void txtIREConfigReplyXsl_TextChanged(object sender, EventArgs e)
	{
		IRETabEditMode = true;
	}

	private void lstIREConfigBackendEnv_SelectedIndexChanged(object sender, EventArgs e)
	{
		IRETabAddMode = false;
		IRETabEditMode = false;
		ModifyIREConfigInfoFieldState(stateValue: false);
		ModifyIREConfigInfoButtonState(stateValue: true);
		PopulateIREEnvironmentFields(((Control)lstIREEnv).get_Text());
		if (((ListControl)lstIREEnv).get_SelectedIndex() == 0)
		{
			((Control)cmdIREConfigDelete).set_Enabled(false);
			chkIREConfigDefault.set_Checked(true);
		}
		else
		{
			((Control)cmdIREConfigDelete).set_Enabled(true);
			chkIREConfigDefault.set_Checked(false);
		}
	}

	private void cmdIREConfigAdd_Click(object sender, EventArgs e)
	{
		if (lstIREEnv.get_Items().get_Count() != 0)
		{
			lstIREEnv.SetSelected(0, false);
		}
		ModifyIREConfigInfoFieldState(stateValue: true);
		ModifyIREConfigInfoButtonState(stateValue: false);
		((Control)txtIREConfigEnv).set_Text("");
		((Control)txtIREConfigServerName).set_Text("");
		((Control)txtIREConfigMethodName).set_Text("");
		((Control)txtIREConfigClassID).set_Text("");
		chkIREConfigDefault.set_Checked(false);
		IRETabAddMode = true;
	}

	private void cmdIREConfigEdit_Click(object sender, EventArgs e)
	{
		IRETabEditMode = true;
		ModifyIREConfigInfoFieldState(stateValue: true);
		if (((ListControl)lstIREEnv).get_SelectedIndex() == 0)
		{
			((Control)chkIREConfigDefault).set_Enabled(false);
		}
		ModifyIREConfigInfoButtonState(stateValue: false);
	}

	private void cmdIREConfigDelete_Click(object sender, EventArgs e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between I4 and Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		if (!CheckFileReadOnly("..\\config\\ATMIA-IREInterface.config") && 1 == (int)MessageBox.Show("Are you Sure you want to Delete ? The file will automatically be saved after deletion", "Deletion of File", (MessageBoxButtons)1, (MessageBoxIcon)48))
		{
			string xpath = "//IREEnvironments/BackendEnvInfo[BackendEnv='" + ((Control)txtIREConfigEnv).get_Text() + "']";
			XmlNode xmlNode = IREDoc.SelectSingleNode(xpath);
			XmlNode parentNode = xmlNode.ParentNode;
			parentNode.RemoveChild(xmlNode);
			IREDoc.Save("..\\config\\ATMIA-IREInterface.config");
			ModifyIREConfigInfoButtonState(stateValue: false);
			lstIREEnv.get_Items().Remove((object)((Control)txtIREConfigEnv).get_Text());
			((Control)lstIREEnv).Refresh();
			((ListControl)lstIREEnv).set_SelectedIndex(0);
			MessageBox.Show("The ATMIA Environment has been Successfully deleted", "Information", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
	}

	private void cmdIREConfigCancel_Click(object sender, EventArgs e)
	{
		lstIREEnv.SetSelected(0, true);
		ModifyIREConfigInfoFieldState(stateValue: false);
		ModifyIREConfigInfoButtonState(stateValue: true);
		((Control)cmdIREConfigDelete).set_Enabled(false);
		chkIREConfigDefault.set_Checked(true);
		IRETabAddMode = false;
		IRETabEditMode = false;
	}

	private void cmdIREConfigSaveLogger_Click(object sender, EventArgs e)
	{
		SaveAllLogger(IREDoc, IRELogger, RouterLogger, TCPIPLogger, WSLogger, GlendaLogger, SPEEDLogger, SPCLogger);
	}

	private void cmdIREConfigSaveToFile_Click(object sender, EventArgs e)
	{
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		bool ChangeOcurred = false;
		if (CheckFileReadOnly("..\\config\\ATMIA-IREInterface.config"))
		{
			return;
		}
		if ((!IRETabAddMode && !IRETabEditMode) || (((Control)txtIREConfigEnv).get_Text().Length != 0 && ((Control)txtIREConfigServerName).get_Text().Length != 0 && ((Control)txtIREConfigMethodName).get_Text().Length != 0 && ((Control)txtIREConfigClassID).get_Text().Length != 0))
		{
			Cursor current = Cursor.get_Current();
			Cursor.set_Current(Cursors.get_WaitCursor());
			if (!SaveLogger(ref IREDoc, ref IRELogger, ref ChangeOcurred))
			{
				return;
			}
			try
			{
				ChangeOcurred = (ChangeOcurred = (ChangeOcurred |= IsFieldChange(ref IREDoc, txtIREConfigRetryIntervals, "//RetryInterval")) | IsFieldChange(ref IREDoc, txtIREConfigRequestXsl, "//XSL/RequestXSL")) | IsFieldChange(ref IREDoc, txtIREConfigReplyXsl, "//XSL/ReplyXSL");
				if (IRETabAddMode)
				{
					if (lstIREEnv.get_Items().Contains((object)((Control)txtIREConfigEnv).get_Text()))
					{
						MessageBox.Show("This environment already exists, no saving is made", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
						return;
					}
					XmlNode xmlNode = IREDoc.SelectSingleNode("//IREEnvironments");
					XmlElement xmlElement = CreateBackendEnvironmentNodeForIRE();
					if (chkIREConfigDefault.get_Checked() && ((Control)chkIREConfigDefault).get_Enabled())
					{
						ProcessToChangeDefaultIREConfigEnvironment(xmlElement);
						xmlNode.PrependChild(xmlElement);
					}
					else
					{
						xmlNode.AppendChild(xmlElement);
						lstIREEnv.get_Items().Add((object)((Control)txtIREConfigEnv).get_Text());
						((Control)lstIREEnv).Refresh();
						((ListControl)lstIREEnv).set_SelectedIndex(lstIREEnv.get_Items().get_Count() - 1);
					}
					ModifyIREConfigInfoButtonState(stateValue: true);
					ChangeOcurred = true;
				}
				if (IRETabEditMode)
				{
					((Control)lstIREEnv).Refresh();
					string xpath = "//IREEnvironments/BackendEnvInfo[BackendEnv='" + lstIREEnv.get_SelectedItem().ToString() + "']";
					XmlNode xmlNode2 = IREDoc.SelectSingleNode(xpath);
					xmlNode2.SelectSingleNode("BackendEnv")!.InnerText = ((Control)txtIREConfigEnv).get_Text();
					xmlNode2.SelectSingleNode("ServerName")!.InnerText = ((Control)txtIREConfigServerName).get_Text();
					xmlNode2.SelectSingleNode("MethodName")!.InnerText = ((Control)txtIREConfigMethodName).get_Text();
					xmlNode2.SelectSingleNode("ClassID")!.InnerText = ((Control)txtIREConfigClassID).get_Text();
					if (chkIREConfigDefault.get_Checked() && ((Control)chkIREConfigDefault).get_Enabled())
					{
						ProcessToChangeDefaultIREConfigEnvironment(xmlNode2);
					}
					else
					{
						lstIREEnv.get_Items().set_Item(((ListControl)lstIREEnv).get_SelectedIndex(), (object)((Control)txtIREConfigEnv).get_Text());
					}
					((ListControl)lstIREEnv).set_SelectedIndex(0);
					lstIREEnv.SetSelected(0, true);
					((Control)lstIREEnv).Refresh();
					ChangeOcurred = true;
				}
				if (ChangeOcurred)
				{
					IREDoc.Save("..\\config\\ATMIA-IREInterface.config");
					MessageBox.Show("The Changes have been Saved to the File", "Information", (MessageBoxButtons)0, (MessageBoxIcon)64);
				}
				IRETabEditMode = false;
				IRETabAddMode = false;
				Cursor.set_Current(current);
				return;
			}
			catch (Exception ex)
			{
				MessageBox.Show("cmdIREConfigSaveToFile_Click error: " + ex.Message);
				return;
			}
		}
		MessageBox.Show("Please make sure all the Mandatory tags (*) are filled", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private void cmdIREConfigExitApplication_Click(object sender, EventArgs e)
	{
		cmdExitApplication();
	}

	private void PopulateAllSPEEDConfigTabFields()
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			PopulateLogger(SPEEDDoc, SPEEDLogger);
			PopulateConfigRetryParameters(SPEEDDoc, txtSPEEDConfigRetryIntervals);
			PopulateConfigXSLParameters(SPEEDDoc, txtSPEEDConfigRequestXsl, txtSPEEDConfigReplyXsl);
			PopulateBackendEnv(SPEEDDoc, lstSPEEDEnv);
			SPEEDTabEditMode = false;
			SPEEDTabAddMode = false;
		}
		catch (Exception ex)
		{
			MessageBox.Show("PopulateAllSPEEDConfigTabFields error: " + ex.Message);
		}
	}

	private XmlElement CreateBackendEnvironmentNodeForSPEED()
	{
		XmlElement xmlElement = SPEEDDoc.CreateElement("BackendEnvInfo");
		xmlElement.SetAttribute("default", "false");
		XmlElement xmlElement2 = SPEEDDoc.CreateElement("BackendEnv");
		xmlElement2.InnerText = ((Control)txtSPEEDConfigEnv).get_Text();
		XmlElement xmlElement3 = SPEEDDoc.CreateElement("MethodName");
		xmlElement3.InnerText = ((Control)txtSPEEDConfigMethodName).get_Text();
		XmlElement xmlElement4 = SPEEDDoc.CreateElement("TypeName");
		xmlElement4.InnerText = ((Control)txtSPEEDConfigTypeName).get_Text();
		XmlElement xmlElement5 = SPEEDDoc.CreateElement("URI");
		xmlElement5.InnerText = ((Control)txtSPEEDConfigURI).get_Text();
		XmlElement xmlElement6 = SPEEDDoc.CreateElement("ProxyNameSpace");
		xmlElement6.InnerText = ((Control)txtSPEEDConfigProxyNameSpace).get_Text();
		XmlElement xmlElement7 = SPEEDDoc.CreateElement("MethodParameter");
		xmlElement7.InnerText = ((Control)txtSPEEDConfigProxyMethodParm).get_Text();
		xmlElement.AppendChild(xmlElement2);
		xmlElement.AppendChild(xmlElement3);
		xmlElement.AppendChild(xmlElement4);
		xmlElement.AppendChild(xmlElement5);
		xmlElement.AppendChild(xmlElement6);
		xmlElement.AppendChild(xmlElement7);
		return xmlElement;
	}

	private void ModifySPEEDConfigInfoFieldState(bool stateValue)
	{
		((Control)txtSPEEDConfigEnv).set_Enabled(stateValue);
		((Control)txtSPEEDConfigTypeName).set_Enabled(stateValue);
		((Control)txtSPEEDConfigMethodName).set_Enabled(stateValue);
		((Control)txtSPEEDConfigProxyNameSpace).set_Enabled(stateValue);
		((Control)txtSPEEDConfigProxyMethodParm).set_Enabled(stateValue);
		((Control)txtSPEEDConfigURI).set_Enabled(stateValue);
		((Control)chkSPEEDConfigDefault).set_Enabled(stateValue);
	}

	private void ModifySPEEDConfigInfoButtonState(bool stateValue)
	{
		((Control)cmdSPEEDConfigAdd).set_Enabled(stateValue);
		((Control)cmdSPEEDConfigEdit).set_Enabled(stateValue);
		if (((ListControl)lstSPEEDEnv).get_SelectedIndex() != 0)
		{
			((Control)cmdSPEEDConfigDelete).set_Enabled(stateValue);
		}
	}

	private void ProcessToChangeDefaultSPEEDConfigEnvironment(XmlNode node)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ProcessToChangeDefaultNode(SPEEDDoc, node, lstSPEEDEnv, ((Control)txtSPEEDConfigEnv).get_Text(), SPEEDTabAddMode);
		}
		catch (Exception ex)
		{
			MessageBox.Show("ProcessToChangeDefaultSPEEDConfigEnvironment error: " + ex.Message);
		}
	}

	private void PopulateSPEEDEnvironmentFields(string name)
	{
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			XmlNodeList xmlNodeList = SPEEDDoc.SelectNodes("//BackendEnvInfo");
			if (xmlNodeList.Count == 0)
			{
				return;
			}
			foreach (XmlNode item in xmlNodeList)
			{
				if (item.SelectSingleNode("BackendEnv")!.InnerText == name)
				{
					((Control)txtSPEEDConfigEnv).set_Text(item.SelectSingleNode("BackendEnv")!.InnerText);
					((Control)txtSPEEDConfigMethodName).set_Text(item.SelectSingleNode("MethodName")!.InnerText);
					((Control)txtSPEEDConfigTypeName).set_Text(item.SelectSingleNode("TypeName")!.InnerText);
					((Control)txtSPEEDConfigURI).set_Text(item.SelectSingleNode("URI")!.InnerText);
					((Control)txtSPEEDConfigProxyNameSpace).set_Text(item.SelectSingleNode("ProxyNameSpace")!.InnerText);
					((Control)txtSPEEDConfigProxyMethodParm).set_Text(item.SelectSingleNode("MethodParameter")!.InnerText);
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show("PopulateSPEEDEnvironmentFields error " + ex.ToString());
		}
	}

	private void txtSPEEDConfigRetryIntervals_TextChanged(object sender, EventArgs e)
	{
		SPEEDTabEditMode = false;
	}

	private void txtSPEEDConfigRequestXsl_TextChanged(object sender, EventArgs e)
	{
		SPEEDTabEditMode = false;
	}

	private void txtSPEEDConfigReplyXsl_TextChanged(object sender, EventArgs e)
	{
		SPEEDTabEditMode = false;
	}

	private void lstSPEEDConfigBackendEnv_SelectedIndexChanged(object sender, EventArgs e)
	{
		SPEEDTabAddMode = false;
		SPEEDTabEditMode = false;
		ModifySPEEDConfigInfoFieldState(stateValue: false);
		ModifySPEEDConfigInfoButtonState(stateValue: true);
		PopulateSPEEDEnvironmentFields(((Control)lstSPEEDEnv).get_Text());
		if (((ListControl)lstSPEEDEnv).get_SelectedIndex() == 0)
		{
			((Control)cmdSPEEDConfigDelete).set_Enabled(false);
			chkSPEEDConfigDefault.set_Checked(true);
		}
		else
		{
			((Control)cmdSPEEDConfigDelete).set_Enabled(true);
			chkSPEEDConfigDefault.set_Checked(false);
		}
	}

	private void cmdSPEEDConfigAdd_Click(object sender, EventArgs e)
	{
		if (lstSPEEDEnv.get_Items().get_Count() != 0)
		{
			lstSPEEDEnv.SetSelected(0, false);
		}
		ModifySPEEDConfigInfoFieldState(stateValue: true);
		ModifySPEEDConfigInfoButtonState(stateValue: false);
		((Control)txtSPEEDConfigEnv).set_Text("");
		((Control)txtSPEEDConfigTypeName).set_Text("");
		((Control)txtSPEEDConfigMethodName).set_Text("");
		((Control)txtSPEEDConfigURI).set_Text("");
		((Control)txtSPEEDConfigProxyNameSpace).set_Text("");
		((Control)txtSPEEDConfigProxyMethodParm).set_Text("");
		chkSPEEDConfigDefault.set_Checked(false);
		SPEEDTabAddMode = true;
	}

	private void cmdSPEEDConfigEdit_Click(object sender, EventArgs e)
	{
		SPEEDTabEditMode = true;
		ModifySPEEDConfigInfoFieldState(stateValue: true);
		if (((ListControl)lstSPEEDEnv).get_SelectedIndex() == 0)
		{
			((Control)chkSPEEDConfigDefault).set_Enabled(false);
		}
		ModifySPEEDConfigInfoButtonState(stateValue: false);
	}

	private void cmdSPEEDConfigDelete_Click(object sender, EventArgs e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between I4 and Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		if (!CheckFileReadOnly("..\\config\\ATMIA-SPEEDInterface.config") && 1 == (int)MessageBox.Show("Are you Sure you want to Delete ? The file will automatically be saved after deletion", "Deletion of File", (MessageBoxButtons)1, (MessageBoxIcon)48))
		{
			string xpath = "//SPEEDEnvironments/BackendEnvInfo[BackendEnv='" + ((Control)txtSPEEDConfigEnv).get_Text() + "']";
			XmlNode xmlNode = SPEEDDoc.SelectSingleNode(xpath);
			XmlNode parentNode = xmlNode.ParentNode;
			parentNode.RemoveChild(xmlNode);
			SPEEDDoc.Save("..\\config\\ATMIA-SPEEDInterface.config");
			ModifySPEEDConfigInfoButtonState(stateValue: false);
			lstSPEEDEnv.get_Items().Remove((object)((Control)txtSPEEDConfigEnv).get_Text());
			((Control)lstSPEEDEnv).Refresh();
			((ListControl)lstSPEEDEnv).set_SelectedIndex(0);
			MessageBox.Show("The ATMIA Environment has been Successfully deleted", "Information", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
	}

	private void cmdSPEEDConfigCancel_Click(object sender, EventArgs e)
	{
		lstSPEEDEnv.SetSelected(0, true);
		ModifySPEEDConfigInfoFieldState(stateValue: false);
		ModifySPEEDConfigInfoButtonState(stateValue: true);
		((Control)cmdSPEEDConfigDelete).set_Enabled(false);
		chkSPEEDConfigDefault.set_Checked(true);
		SPEEDTabAddMode = false;
		SPEEDTabEditMode = false;
	}

	private void cmdSPEEDSaveLogger_Click(object sender, EventArgs e)
	{
		SaveAllLogger(SPEEDDoc, SPEEDLogger, RouterLogger, TCPIPLogger, IRELogger, GlendaLogger, WSLogger, SPCLogger);
	}

	private void cmdSPEEDConfigSaveToFile_Click(object sender, EventArgs e)
	{
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		bool ChangeOcurred = false;
		if (CheckFileReadOnly("..\\config\\ATMIA-SPEEDInterface.config"))
		{
			return;
		}
		if ((!SPEEDTabAddMode && !SPEEDTabEditMode) || (((Control)txtSPEEDConfigEnv).get_Text().Length != 0 && ((Control)txtSPEEDConfigTypeName).get_Text().Length != 0 && ((Control)txtSPEEDConfigMethodName).get_Text().Length != 0 && ((Control)txtSPEEDConfigProxyNameSpace).get_Text().Length != 0 && ((Control)txtSPEEDConfigProxyMethodParm).get_Text().Length != 0 && ((Control)txtSPEEDConfigURI).get_Text().Length != 0))
		{
			Cursor current = Cursor.get_Current();
			Cursor.set_Current(Cursors.get_WaitCursor());
			if (!SaveLogger(ref SPEEDDoc, ref SPEEDLogger, ref ChangeOcurred))
			{
				return;
			}
			try
			{
				ChangeOcurred = (ChangeOcurred = (ChangeOcurred |= IsFieldChange(ref SPEEDDoc, txtSPEEDConfigRetryIntervals, "//RetryInterval")) | IsFieldChange(ref SPEEDDoc, txtSPEEDConfigRequestXsl, "//XSL/RequestXSL")) | IsFieldChange(ref SPEEDDoc, txtSPEEDConfigReplyXsl, "//XSL/ReplyXSL");
				if (SPEEDTabAddMode)
				{
					if (lstSPEEDEnv.get_Items().Contains((object)((Control)txtSPEEDConfigEnv).get_Text()))
					{
						MessageBox.Show("This environment already exists, no saving is made", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
						return;
					}
					XmlNode xmlNode = SPEEDDoc.SelectSingleNode("//SPEEDEnvironments");
					XmlElement xmlElement = CreateBackendEnvironmentNodeForSPEED();
					if (chkSPEEDConfigDefault.get_Checked() && ((Control)chkSPEEDConfigDefault).get_Enabled())
					{
						ProcessToChangeDefaultSPEEDConfigEnvironment(xmlElement);
						xmlNode.PrependChild(xmlElement);
					}
					else
					{
						xmlNode.AppendChild(xmlElement);
						lstSPEEDEnv.get_Items().Add((object)((Control)txtSPEEDConfigEnv).get_Text());
						((Control)lstSPEEDEnv).Refresh();
						((ListControl)lstSPEEDEnv).set_SelectedIndex(lstSPEEDEnv.get_Items().get_Count() - 1);
					}
					ModifySPEEDConfigInfoButtonState(stateValue: true);
					ChangeOcurred = true;
				}
				if (SPEEDTabEditMode)
				{
					((Control)lstSPEEDEnv).Refresh();
					string xpath = "//SPEEDEnvironments/BackendEnvInfo[BackendEnv='" + lstSPEEDEnv.get_SelectedItem().ToString() + "']";
					XmlNode xmlNode2 = SPEEDDoc.SelectSingleNode(xpath);
					xmlNode2.SelectSingleNode("BackendEnv")!.InnerText = ((Control)txtSPEEDConfigEnv).get_Text();
					xmlNode2.SelectSingleNode("TypeName")!.InnerText = ((Control)txtSPEEDConfigTypeName).get_Text();
					xmlNode2.SelectSingleNode("MethodName")!.InnerText = ((Control)txtSPEEDConfigMethodName).get_Text();
					xmlNode2.SelectSingleNode("URI")!.InnerText = ((Control)txtSPEEDConfigURI).get_Text();
					xmlNode2.SelectSingleNode("ProxyNameSpace")!.InnerText = ((Control)txtSPEEDConfigProxyNameSpace).get_Text();
					xmlNode2.SelectSingleNode("MethodParameter")!.InnerText = ((Control)txtSPEEDConfigProxyMethodParm).get_Text();
					if (chkSPEEDConfigDefault.get_Checked() && ((Control)chkSPEEDConfigDefault).get_Enabled())
					{
						ProcessToChangeDefaultSPEEDConfigEnvironment(xmlNode2);
					}
					else
					{
						lstSPEEDEnv.get_Items().set_Item(((ListControl)lstSPEEDEnv).get_SelectedIndex(), (object)((Control)txtSPEEDConfigEnv).get_Text());
					}
					((ListControl)lstSPEEDEnv).set_SelectedIndex(0);
					lstSPEEDEnv.SetSelected(0, true);
					((Control)lstSPEEDEnv).Refresh();
					ChangeOcurred = true;
				}
				if (ChangeOcurred)
				{
					SPEEDDoc.Save("..\\config\\ATMIA-SPEEDInterface.config");
					MessageBox.Show("The Changes have been Saved to the File", "Information", (MessageBoxButtons)0, (MessageBoxIcon)64);
				}
				SPEEDTabEditMode = false;
				SPEEDTabAddMode = false;
				Cursor.set_Current(current);
				return;
			}
			catch (Exception ex)
			{
				MessageBox.Show("cmdSPEEDConfigSaveToFile_Click error: " + ex.Message);
				return;
			}
		}
		MessageBox.Show("Please make sure all the Mandatory tags (*) are filled", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private void cmdSPEEDConfigExitApplication_Click(object sender, EventArgs e)
	{
		cmdExitApplication();
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected O, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected O, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected O, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected O, but got Unknown
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected O, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected O, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected O, but got Unknown
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected O, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected O, but got Unknown
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected O, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected O, but got Unknown
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected O, but got Unknown
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected O, but got Unknown
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected O, but got Unknown
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected O, but got Unknown
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected O, but got Unknown
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected O, but got Unknown
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected O, but got Unknown
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected O, but got Unknown
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected O, but got Unknown
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected O, but got Unknown
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected O, but got Unknown
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected O, but got Unknown
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Expected O, but got Unknown
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected O, but got Unknown
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Expected O, but got Unknown
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected O, but got Unknown
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Expected O, but got Unknown
		//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected O, but got Unknown
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected O, but got Unknown
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected O, but got Unknown
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Expected O, but got Unknown
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected O, but got Unknown
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Expected O, but got Unknown
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Expected O, but got Unknown
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Expected O, but got Unknown
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Expected O, but got Unknown
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Expected O, but got Unknown
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Expected O, but got Unknown
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected O, but got Unknown
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Expected O, but got Unknown
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Expected O, but got Unknown
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Expected O, but got Unknown
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_055f: Expected O, but got Unknown
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Expected O, but got Unknown
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0575: Expected O, but got Unknown
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Expected O, but got Unknown
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_058b: Expected O, but got Unknown
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected O, but got Unknown
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Expected O, but got Unknown
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ac: Expected O, but got Unknown
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Expected O, but got Unknown
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Expected O, but got Unknown
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Expected O, but got Unknown
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Expected O, but got Unknown
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Expected O, but got Unknown
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Expected O, but got Unknown
		//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Expected O, but got Unknown
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0604: Expected O, but got Unknown
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Expected O, but got Unknown
		//IL_0610: Unknown result type (might be due to invalid IL or missing references)
		//IL_061a: Expected O, but got Unknown
		//IL_061b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0625: Expected O, but got Unknown
		//IL_0626: Unknown result type (might be due to invalid IL or missing references)
		//IL_0630: Expected O, but got Unknown
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_063b: Expected O, but got Unknown
		//IL_063c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Expected O, but got Unknown
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_0651: Expected O, but got Unknown
		//IL_0652: Unknown result type (might be due to invalid IL or missing references)
		//IL_065c: Expected O, but got Unknown
		//IL_065d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0667: Expected O, but got Unknown
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_0672: Expected O, but got Unknown
		//IL_0673: Unknown result type (might be due to invalid IL or missing references)
		//IL_067d: Expected O, but got Unknown
		//IL_067e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0688: Expected O, but got Unknown
		//IL_0689: Unknown result type (might be due to invalid IL or missing references)
		//IL_0693: Expected O, but got Unknown
		//IL_0694: Unknown result type (might be due to invalid IL or missing references)
		//IL_069e: Expected O, but got Unknown
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a9: Expected O, but got Unknown
		//IL_06aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b4: Expected O, but got Unknown
		//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bf: Expected O, but got Unknown
		//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ca: Expected O, but got Unknown
		//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d5: Expected O, but got Unknown
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Expected O, but got Unknown
		//IL_06e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06eb: Expected O, but got Unknown
		//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f6: Expected O, but got Unknown
		//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0701: Expected O, but got Unknown
		//IL_0702: Unknown result type (might be due to invalid IL or missing references)
		//IL_070c: Expected O, but got Unknown
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0717: Expected O, but got Unknown
		//IL_0718: Unknown result type (might be due to invalid IL or missing references)
		//IL_0722: Expected O, but got Unknown
		//IL_0723: Unknown result type (might be due to invalid IL or missing references)
		//IL_072d: Expected O, but got Unknown
		//IL_072e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0738: Expected O, but got Unknown
		//IL_0739: Unknown result type (might be due to invalid IL or missing references)
		//IL_0743: Expected O, but got Unknown
		//IL_0744: Unknown result type (might be due to invalid IL or missing references)
		//IL_074e: Expected O, but got Unknown
		//IL_074f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0759: Expected O, but got Unknown
		//IL_075a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0764: Expected O, but got Unknown
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_076f: Expected O, but got Unknown
		//IL_0770: Unknown result type (might be due to invalid IL or missing references)
		//IL_077a: Expected O, but got Unknown
		//IL_077b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0785: Expected O, but got Unknown
		//IL_0786: Unknown result type (might be due to invalid IL or missing references)
		//IL_0790: Expected O, but got Unknown
		//IL_0791: Unknown result type (might be due to invalid IL or missing references)
		//IL_079b: Expected O, but got Unknown
		//IL_079c: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a6: Expected O, but got Unknown
		//IL_07a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b1: Expected O, but got Unknown
		//IL_07b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bc: Expected O, but got Unknown
		//IL_07bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c7: Expected O, but got Unknown
		//IL_07c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d2: Expected O, but got Unknown
		//IL_07d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dd: Expected O, but got Unknown
		//IL_07de: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Expected O, but got Unknown
		//IL_07e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f3: Expected O, but got Unknown
		//IL_07f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fe: Expected O, but got Unknown
		//IL_07ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0809: Expected O, but got Unknown
		//IL_080a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0814: Expected O, but got Unknown
		//IL_0815: Unknown result type (might be due to invalid IL or missing references)
		//IL_081f: Expected O, but got Unknown
		//IL_0820: Unknown result type (might be due to invalid IL or missing references)
		//IL_082a: Expected O, but got Unknown
		//IL_082b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0835: Expected O, but got Unknown
		//IL_0836: Unknown result type (might be due to invalid IL or missing references)
		//IL_0840: Expected O, but got Unknown
		//IL_0841: Unknown result type (might be due to invalid IL or missing references)
		//IL_084b: Expected O, but got Unknown
		//IL_084c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0856: Expected O, but got Unknown
		//IL_0857: Unknown result type (might be due to invalid IL or missing references)
		//IL_0861: Expected O, but got Unknown
		//IL_0862: Unknown result type (might be due to invalid IL or missing references)
		//IL_086c: Expected O, but got Unknown
		//IL_086d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0877: Expected O, but got Unknown
		//IL_0878: Unknown result type (might be due to invalid IL or missing references)
		//IL_0882: Expected O, but got Unknown
		//IL_0883: Unknown result type (might be due to invalid IL or missing references)
		//IL_088d: Expected O, but got Unknown
		//IL_088e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0898: Expected O, but got Unknown
		//IL_0899: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a3: Expected O, but got Unknown
		//IL_08a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ae: Expected O, but got Unknown
		//IL_08af: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b9: Expected O, but got Unknown
		//IL_08ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c4: Expected O, but got Unknown
		//IL_08c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cf: Expected O, but got Unknown
		//IL_08d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08da: Expected O, but got Unknown
		//IL_08db: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e5: Expected O, but got Unknown
		//IL_08e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f0: Expected O, but got Unknown
		//IL_08f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fb: Expected O, but got Unknown
		//IL_08fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0906: Expected O, but got Unknown
		//IL_0907: Unknown result type (might be due to invalid IL or missing references)
		//IL_0911: Expected O, but got Unknown
		//IL_0912: Unknown result type (might be due to invalid IL or missing references)
		//IL_091c: Expected O, but got Unknown
		//IL_091d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0927: Expected O, but got Unknown
		//IL_0928: Unknown result type (might be due to invalid IL or missing references)
		//IL_0932: Expected O, but got Unknown
		//IL_0933: Unknown result type (might be due to invalid IL or missing references)
		//IL_093d: Expected O, but got Unknown
		//IL_093e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0948: Expected O, but got Unknown
		//IL_0949: Unknown result type (might be due to invalid IL or missing references)
		//IL_0953: Expected O, but got Unknown
		//IL_0954: Unknown result type (might be due to invalid IL or missing references)
		//IL_095e: Expected O, but got Unknown
		//IL_095f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0969: Expected O, but got Unknown
		//IL_096a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0974: Expected O, but got Unknown
		//IL_0975: Unknown result type (might be due to invalid IL or missing references)
		//IL_097f: Expected O, but got Unknown
		//IL_0980: Unknown result type (might be due to invalid IL or missing references)
		//IL_098a: Expected O, but got Unknown
		//IL_098b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0995: Expected O, but got Unknown
		//IL_0996: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a0: Expected O, but got Unknown
		//IL_09a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ab: Expected O, but got Unknown
		//IL_09ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b6: Expected O, but got Unknown
		//IL_09b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c1: Expected O, but got Unknown
		//IL_09c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cc: Expected O, but got Unknown
		//IL_09cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d7: Expected O, but got Unknown
		//IL_09d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e2: Expected O, but got Unknown
		//IL_09e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ed: Expected O, but got Unknown
		//IL_09ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f8: Expected O, but got Unknown
		//IL_09f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a03: Expected O, but got Unknown
		//IL_0a04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0e: Expected O, but got Unknown
		//IL_0a0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a19: Expected O, but got Unknown
		//IL_0a1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a24: Expected O, but got Unknown
		//IL_0a25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2f: Expected O, but got Unknown
		//IL_0a30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3a: Expected O, but got Unknown
		//IL_0a3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a45: Expected O, but got Unknown
		//IL_0a46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a50: Expected O, but got Unknown
		//IL_0a51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5b: Expected O, but got Unknown
		//IL_0a5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a66: Expected O, but got Unknown
		//IL_0a67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a71: Expected O, but got Unknown
		//IL_0a72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7c: Expected O, but got Unknown
		//IL_0a7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a87: Expected O, but got Unknown
		//IL_0a88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a92: Expected O, but got Unknown
		//IL_0a93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9d: Expected O, but got Unknown
		//IL_0a9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa8: Expected O, but got Unknown
		//IL_0aa9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab3: Expected O, but got Unknown
		//IL_0ab4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abe: Expected O, but got Unknown
		//IL_0abf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac9: Expected O, but got Unknown
		//IL_0aca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad4: Expected O, but got Unknown
		//IL_0ad5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adf: Expected O, but got Unknown
		//IL_0ae0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aea: Expected O, but got Unknown
		//IL_0aeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af5: Expected O, but got Unknown
		//IL_0af6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b00: Expected O, but got Unknown
		//IL_0b01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0b: Expected O, but got Unknown
		//IL_0b0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b16: Expected O, but got Unknown
		//IL_0b17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b21: Expected O, but got Unknown
		//IL_0b22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2c: Expected O, but got Unknown
		//IL_0b2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b37: Expected O, but got Unknown
		//IL_0b38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b42: Expected O, but got Unknown
		//IL_0b43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4d: Expected O, but got Unknown
		//IL_0b4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b58: Expected O, but got Unknown
		//IL_0b59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b63: Expected O, but got Unknown
		//IL_0b64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6e: Expected O, but got Unknown
		//IL_0b6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b79: Expected O, but got Unknown
		//IL_0b7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b84: Expected O, but got Unknown
		//IL_0b85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8f: Expected O, but got Unknown
		//IL_0b90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9a: Expected O, but got Unknown
		//IL_0b9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba5: Expected O, but got Unknown
		//IL_0ba6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb0: Expected O, but got Unknown
		//IL_0bb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbb: Expected O, but got Unknown
		//IL_0bbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc6: Expected O, but got Unknown
		//IL_0bc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd1: Expected O, but got Unknown
		//IL_0e1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e25: Expected O, but got Unknown
		//IL_0ea1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eab: Expected O, but got Unknown
		//IL_0f32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3c: Expected O, but got Unknown
		//IL_0fcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd7: Expected O, but got Unknown
		//IL_1074: Unknown result type (might be due to invalid IL or missing references)
		//IL_107e: Expected O, but got Unknown
		//IL_110f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1119: Expected O, but got Unknown
		//IL_12a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ac: Expected O, but got Unknown
		//IL_1330: Unknown result type (might be due to invalid IL or missing references)
		//IL_133a: Expected O, but got Unknown
		//IL_13a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ae: Expected O, but got Unknown
		//IL_142e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1438: Expected O, but got Unknown
		//IL_1577: Unknown result type (might be due to invalid IL or missing references)
		//IL_1581: Expected O, but got Unknown
		//IL_1601: Unknown result type (might be due to invalid IL or missing references)
		//IL_160b: Expected O, but got Unknown
		//IL_1676: Unknown result type (might be due to invalid IL or missing references)
		//IL_1680: Expected O, but got Unknown
		//IL_1700: Unknown result type (might be due to invalid IL or missing references)
		//IL_170a: Expected O, but got Unknown
		//IL_1775: Unknown result type (might be due to invalid IL or missing references)
		//IL_177f: Expected O, but got Unknown
		//IL_1933: Unknown result type (might be due to invalid IL or missing references)
		//IL_193d: Expected O, but got Unknown
		//IL_19bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c7: Expected O, but got Unknown
		//IL_1a1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a28: Expected O, but got Unknown
		//IL_1aa8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ab2: Expected O, but got Unknown
		//IL_1b09: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b13: Expected O, but got Unknown
		//IL_1b93: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b9d: Expected O, but got Unknown
		//IL_1bf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bfe: Expected O, but got Unknown
		//IL_1c82: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c8c: Expected O, but got Unknown
		//IL_1d10: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d1a: Expected O, but got Unknown
		//IL_1d9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1da8: Expected O, but got Unknown
		//IL_1e2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e35: Expected O, but got Unknown
		//IL_1f86: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f90: Expected O, but got Unknown
		//IL_2056: Unknown result type (might be due to invalid IL or missing references)
		//IL_2060: Expected O, but got Unknown
		//IL_20d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_20e1: Expected O, but got Unknown
		//IL_222c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2236: Expected O, but got Unknown
		//IL_25cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_25d7: Expected O, but got Unknown
		//IL_2650: Unknown result type (might be due to invalid IL or missing references)
		//IL_265a: Expected O, but got Unknown
		//IL_26de: Unknown result type (might be due to invalid IL or missing references)
		//IL_26e8: Expected O, but got Unknown
		//IL_276b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2775: Expected O, but got Unknown
		//IL_27f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2800: Expected O, but got Unknown
		//IL_29b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_29c2: Expected O, but got Unknown
		//IL_2a3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a45: Expected O, but got Unknown
		//IL_2abf: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ac9: Expected O, but got Unknown
		//IL_2b4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b57: Expected O, but got Unknown
		//IL_2ceb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cf5: Expected O, but got Unknown
		//IL_2d71: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d7b: Expected O, but got Unknown
		//IL_2e02: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e0c: Expected O, but got Unknown
		//IL_2e9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ea9: Expected O, but got Unknown
		//IL_2f2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f35: Expected O, but got Unknown
		//IL_2fd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fdb: Expected O, but got Unknown
		//IL_3048: Unknown result type (might be due to invalid IL or missing references)
		//IL_3052: Expected O, but got Unknown
		//IL_30d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_30e0: Expected O, but got Unknown
		//IL_316e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3178: Expected O, but got Unknown
		//IL_3206: Unknown result type (might be due to invalid IL or missing references)
		//IL_3210: Expected O, but got Unknown
		//IL_3292: Unknown result type (might be due to invalid IL or missing references)
		//IL_329c: Expected O, but got Unknown
		//IL_3309: Unknown result type (might be due to invalid IL or missing references)
		//IL_3313: Expected O, but got Unknown
		//IL_337d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3387: Expected O, but got Unknown
		//IL_33fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_3408: Expected O, but got Unknown
		//IL_389b: Unknown result type (might be due to invalid IL or missing references)
		//IL_38a5: Expected O, but got Unknown
		//IL_3921: Unknown result type (might be due to invalid IL or missing references)
		//IL_392b: Expected O, but got Unknown
		//IL_3a0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a17: Expected O, but got Unknown
		//IL_3a82: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a8c: Expected O, but got Unknown
		//IL_3b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b1d: Expected O, but got Unknown
		//IL_3ba4: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bae: Expected O, but got Unknown
		//IL_3c35: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c3f: Expected O, but got Unknown
		//IL_3cc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cd0: Expected O, but got Unknown
		//IL_3d57: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d61: Expected O, but got Unknown
		//IL_3ddc: Unknown result type (might be due to invalid IL or missing references)
		//IL_3de6: Expected O, but got Unknown
		//IL_3e6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e74: Expected O, but got Unknown
		//IL_3f06: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f10: Expected O, but got Unknown
		//IL_403b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4045: Expected O, but got Unknown
		//IL_40b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_40c0: Expected O, but got Unknown
		//IL_4143: Unknown result type (might be due to invalid IL or missing references)
		//IL_414d: Expected O, but got Unknown
		//IL_41c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_41d1: Expected O, but got Unknown
		//IL_424e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4258: Expected O, but got Unknown
		//IL_42c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_42d3: Expected O, but got Unknown
		//IL_434a: Unknown result type (might be due to invalid IL or missing references)
		//IL_4354: Expected O, but got Unknown
		//IL_43d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_43e1: Expected O, but got Unknown
		//IL_445b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4465: Expected O, but got Unknown
		//IL_44d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_44dc: Expected O, but got Unknown
		//IL_4556: Unknown result type (might be due to invalid IL or missing references)
		//IL_4560: Expected O, but got Unknown
		//IL_4739: Unknown result type (might be due to invalid IL or missing references)
		//IL_4743: Expected O, but got Unknown
		//IL_47bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_47c6: Expected O, but got Unknown
		//IL_484a: Unknown result type (might be due to invalid IL or missing references)
		//IL_4854: Expected O, but got Unknown
		//IL_48cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_48d5: Expected O, but got Unknown
		//IL_4956: Unknown result type (might be due to invalid IL or missing references)
		//IL_4960: Expected O, but got Unknown
		//IL_4a16: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a20: Expected O, but got Unknown
		//IL_4a99: Unknown result type (might be due to invalid IL or missing references)
		//IL_4aa3: Expected O, but got Unknown
		//IL_4b1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b27: Expected O, but got Unknown
		//IL_4bab: Unknown result type (might be due to invalid IL or missing references)
		//IL_4bb5: Expected O, but got Unknown
		//IL_4ef5: Unknown result type (might be due to invalid IL or missing references)
		//IL_4eff: Expected O, but got Unknown
		//IL_4f79: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f83: Expected O, but got Unknown
		//IL_5007: Unknown result type (might be due to invalid IL or missing references)
		//IL_5011: Expected O, but got Unknown
		//IL_5092: Unknown result type (might be due to invalid IL or missing references)
		//IL_509c: Expected O, but got Unknown
		//IL_510f: Unknown result type (might be due to invalid IL or missing references)
		//IL_5119: Expected O, but got Unknown
		//IL_519d: Unknown result type (might be due to invalid IL or missing references)
		//IL_51a7: Expected O, but got Unknown
		//IL_521e: Unknown result type (might be due to invalid IL or missing references)
		//IL_5228: Expected O, but got Unknown
		//IL_52ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_52b6: Expected O, but got Unknown
		//IL_5339: Unknown result type (might be due to invalid IL or missing references)
		//IL_5343: Expected O, but got Unknown
		//IL_5821: Unknown result type (might be due to invalid IL or missing references)
		//IL_582b: Expected O, but got Unknown
		//IL_58a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_58ae: Expected O, but got Unknown
		//IL_5932: Unknown result type (might be due to invalid IL or missing references)
		//IL_593c: Expected O, but got Unknown
		//IL_59b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_59bd: Expected O, but got Unknown
		//IL_5a3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_5a48: Expected O, but got Unknown
		//IL_5afe: Unknown result type (might be due to invalid IL or missing references)
		//IL_5b08: Expected O, but got Unknown
		//IL_5b81: Unknown result type (might be due to invalid IL or missing references)
		//IL_5b8b: Expected O, but got Unknown
		//IL_5c05: Unknown result type (might be due to invalid IL or missing references)
		//IL_5c0f: Expected O, but got Unknown
		//IL_5c7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_5c86: Expected O, but got Unknown
		//IL_5e9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_5ea8: Expected O, but got Unknown
		//IL_5f24: Unknown result type (might be due to invalid IL or missing references)
		//IL_5f2e: Expected O, but got Unknown
		//IL_5fb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_5fbf: Expected O, but got Unknown
		//IL_6046: Unknown result type (might be due to invalid IL or missing references)
		//IL_6050: Expected O, but got Unknown
		//IL_60d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_60e1: Expected O, but got Unknown
		//IL_6168: Unknown result type (might be due to invalid IL or missing references)
		//IL_6172: Expected O, but got Unknown
		//IL_6211: Unknown result type (might be due to invalid IL or missing references)
		//IL_621b: Expected O, but got Unknown
		//IL_6346: Unknown result type (might be due to invalid IL or missing references)
		//IL_6350: Expected O, but got Unknown
		//IL_63c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_63cb: Expected O, but got Unknown
		//IL_644e: Unknown result type (might be due to invalid IL or missing references)
		//IL_6458: Expected O, but got Unknown
		//IL_64d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_64dc: Expected O, but got Unknown
		//IL_6559: Unknown result type (might be due to invalid IL or missing references)
		//IL_6563: Expected O, but got Unknown
		//IL_65d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_65de: Expected O, but got Unknown
		//IL_6655: Unknown result type (might be due to invalid IL or missing references)
		//IL_665f: Expected O, but got Unknown
		//IL_66e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_66ec: Expected O, but got Unknown
		//IL_6766: Unknown result type (might be due to invalid IL or missing references)
		//IL_6770: Expected O, but got Unknown
		//IL_67dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_67e7: Expected O, but got Unknown
		//IL_6861: Unknown result type (might be due to invalid IL or missing references)
		//IL_686b: Expected O, but got Unknown
		//IL_6cd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_6ce2: Expected O, but got Unknown
		//IL_6d5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_6d68: Expected O, but got Unknown
		//IL_6def: Unknown result type (might be due to invalid IL or missing references)
		//IL_6df9: Expected O, but got Unknown
		//IL_6e80: Unknown result type (might be due to invalid IL or missing references)
		//IL_6e8a: Expected O, but got Unknown
		//IL_6f11: Unknown result type (might be due to invalid IL or missing references)
		//IL_6f1b: Expected O, but got Unknown
		//IL_6fa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_6fac: Expected O, but got Unknown
		//IL_704b: Unknown result type (might be due to invalid IL or missing references)
		//IL_7055: Expected O, but got Unknown
		//IL_7180: Unknown result type (might be due to invalid IL or missing references)
		//IL_718a: Expected O, but got Unknown
		//IL_720f: Unknown result type (might be due to invalid IL or missing references)
		//IL_7219: Expected O, but got Unknown
		//IL_729c: Unknown result type (might be due to invalid IL or missing references)
		//IL_72a6: Expected O, but got Unknown
		//IL_7320: Unknown result type (might be due to invalid IL or missing references)
		//IL_732a: Expected O, but got Unknown
		//IL_73bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_73c5: Expected O, but got Unknown
		//IL_744a: Unknown result type (might be due to invalid IL or missing references)
		//IL_7454: Expected O, but got Unknown
		//IL_74cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_74d5: Expected O, but got Unknown
		//IL_7558: Unknown result type (might be due to invalid IL or missing references)
		//IL_7562: Expected O, but got Unknown
		//IL_75dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_75e6: Expected O, but got Unknown
		//IL_7653: Unknown result type (might be due to invalid IL or missing references)
		//IL_765d: Expected O, but got Unknown
		//IL_76d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_76e1: Expected O, but got Unknown
		//IL_78ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_78c4: Expected O, but got Unknown
		//IL_793d: Unknown result type (might be due to invalid IL or missing references)
		//IL_7947: Expected O, but got Unknown
		//IL_79cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_79d5: Expected O, but got Unknown
		//IL_7a4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_7a56: Expected O, but got Unknown
		//IL_7ad7: Unknown result type (might be due to invalid IL or missing references)
		//IL_7ae1: Expected O, but got Unknown
		//IL_7b97: Unknown result type (might be due to invalid IL or missing references)
		//IL_7ba1: Expected O, but got Unknown
		//IL_7c1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_7c24: Expected O, but got Unknown
		//IL_7c9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_7ca8: Expected O, but got Unknown
		//IL_7d2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_7d36: Expected O, but got Unknown
		//IL_8146: Unknown result type (might be due to invalid IL or missing references)
		//IL_8150: Expected O, but got Unknown
		//IL_81c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_81d3: Expected O, but got Unknown
		//IL_8240: Unknown result type (might be due to invalid IL or missing references)
		//IL_824a: Expected O, but got Unknown
		//IL_82c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_82cb: Expected O, but got Unknown
		//IL_8335: Unknown result type (might be due to invalid IL or missing references)
		//IL_833f: Expected O, but got Unknown
		//IL_83f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_83ff: Expected O, but got Unknown
		//IL_8478: Unknown result type (might be due to invalid IL or missing references)
		//IL_8482: Expected O, but got Unknown
		//IL_84fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_8506: Expected O, but got Unknown
		//IL_8573: Unknown result type (might be due to invalid IL or missing references)
		//IL_857d: Expected O, but got Unknown
		//IL_8795: Unknown result type (might be due to invalid IL or missing references)
		//IL_879f: Expected O, but got Unknown
		//IL_8876: Unknown result type (might be due to invalid IL or missing references)
		//IL_8880: Expected O, but got Unknown
		//IL_8907: Unknown result type (might be due to invalid IL or missing references)
		//IL_8911: Expected O, but got Unknown
		//IL_8998: Unknown result type (might be due to invalid IL or missing references)
		//IL_89a2: Expected O, but got Unknown
		//IL_8a29: Unknown result type (might be due to invalid IL or missing references)
		//IL_8a33: Expected O, but got Unknown
		//IL_8aba: Unknown result type (might be due to invalid IL or missing references)
		//IL_8ac4: Expected O, but got Unknown
		//IL_8b63: Unknown result type (might be due to invalid IL or missing references)
		//IL_8b6d: Expected O, but got Unknown
		//IL_8c3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_8c48: Expected O, but got Unknown
		//IL_8cb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_8cc3: Expected O, but got Unknown
		//IL_8d46: Unknown result type (might be due to invalid IL or missing references)
		//IL_8d50: Expected O, but got Unknown
		//IL_8dca: Unknown result type (might be due to invalid IL or missing references)
		//IL_8dd4: Expected O, but got Unknown
		//IL_8e51: Unknown result type (might be due to invalid IL or missing references)
		//IL_8e5b: Expected O, but got Unknown
		//IL_8ecc: Unknown result type (might be due to invalid IL or missing references)
		//IL_8ed6: Expected O, but got Unknown
		//IL_8f4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_8f57: Expected O, but got Unknown
		//IL_8fda: Unknown result type (might be due to invalid IL or missing references)
		//IL_8fe4: Expected O, but got Unknown
		//IL_905e: Unknown result type (might be due to invalid IL or missing references)
		//IL_9068: Expected O, but got Unknown
		//IL_90d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_90df: Expected O, but got Unknown
		//IL_9159: Unknown result type (might be due to invalid IL or missing references)
		//IL_9163: Expected O, but got Unknown
		//IL_9554: Unknown result type (might be due to invalid IL or missing references)
		//IL_955e: Expected O, but got Unknown
		//IL_95d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_95e1: Expected O, but got Unknown
		//IL_9668: Unknown result type (might be due to invalid IL or missing references)
		//IL_9672: Expected O, but got Unknown
		//IL_96f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_9700: Expected O, but got Unknown
		//IL_97b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_97c2: Expected O, but got Unknown
		//IL_983b: Unknown result type (might be due to invalid IL or missing references)
		//IL_9845: Expected O, but got Unknown
		//IL_98bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_98c9: Expected O, but got Unknown
		//IL_994d: Unknown result type (might be due to invalid IL or missing references)
		//IL_9957: Expected O, but got Unknown
		//IL_9cc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_9cca: Expected O, but got Unknown
		//IL_9d43: Unknown result type (might be due to invalid IL or missing references)
		//IL_9d4d: Expected O, but got Unknown
		//IL_9dd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_9ddb: Expected O, but got Unknown
		//IL_9e52: Unknown result type (might be due to invalid IL or missing references)
		//IL_9e5c: Expected O, but got Unknown
		//IL_9edd: Unknown result type (might be due to invalid IL or missing references)
		//IL_9ee7: Expected O, but got Unknown
		//IL_9f9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_9fa7: Expected O, but got Unknown
		//IL_a020: Unknown result type (might be due to invalid IL or missing references)
		//IL_a02a: Expected O, but got Unknown
		//IL_a0a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_a0ae: Expected O, but got Unknown
		//IL_a132: Unknown result type (might be due to invalid IL or missing references)
		//IL_a13c: Expected O, but got Unknown
		//IL_a3e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_a3ec: Expected O, but got Unknown
		//IL_a468: Unknown result type (might be due to invalid IL or missing references)
		//IL_a472: Expected O, but got Unknown
		//IL_a4f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_a503: Expected O, but got Unknown
		//IL_a58a: Unknown result type (might be due to invalid IL or missing references)
		//IL_a594: Expected O, but got Unknown
		//IL_a627: Unknown result type (might be due to invalid IL or missing references)
		//IL_a631: Expected O, but got Unknown
		//IL_a6b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_a6c0: Expected O, but got Unknown
		//IL_a743: Unknown result type (might be due to invalid IL or missing references)
		//IL_a74d: Expected O, but got Unknown
		//IL_a7c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_a7d0: Expected O, but got Unknown
		//IL_a861: Unknown result type (might be due to invalid IL or missing references)
		//IL_a86b: Expected O, but got Unknown
		//IL_a8f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_a8fa: Expected O, but got Unknown
		//IL_a971: Unknown result type (might be due to invalid IL or missing references)
		//IL_a97b: Expected O, but got Unknown
		//IL_a9fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_aa08: Expected O, but got Unknown
		//IL_aa81: Unknown result type (might be due to invalid IL or missing references)
		//IL_aa8b: Expected O, but got Unknown
		//IL_aaf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_ab02: Expected O, but got Unknown
		//IL_ab7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_ab89: Expected O, but got Unknown
		grpBoxBackEndEnvironments = new GroupBox();
		lblDefEnvironmentName = new Label();
		cmdBackEndEnvOpCancel = new Button();
		cmdEditBackEndEnv = new Button();
		cmdDeleteBackEndEnv = new Button();
		cmdAddBackEndEnv = new Button();
		grpBoxHostInformation = new GroupBox();
		lblAlternateHostName = new Label();
		txtHostName = new TextBox();
		lblHostName = new Label();
		txtAlternateHostName = new TextBox();
		grpBoxPortInformation = new GroupBox();
		lblAlternatePortName = new Label();
		txtPortNumber = new TextBox();
		lblPortNumber = new Label();
		txtAlternatePortNumber = new TextBox();
		label6 = new Label();
		grpBoxAccountInformation = new GroupBox();
		lblConfirmPassword = new Label();
		txtConfirmPassword = new TextBox();
		lblPassword = new Label();
		txtUserName = new TextBox();
		lblUserName = new Label();
		txtPassword = new TextBox();
		label9 = new Label();
		label8 = new Label();
		label4 = new Label();
		label5 = new Label();
		lstBoxWSBackEnds = new ListBox();
		grpBoxBackEndEnvName = new GroupBox();
		chkWSConfigBEIsDefault = new CheckBox();
		txtBackEndEnvironment = new TextBox();
		label2 = new Label();
		label7 = new Label();
		label10 = new Label();
		lblWSEnvListWarningInformation = new Label();
		checkBox1 = new CheckBox();
		lblBackEndEnvironment = new Label();
		tbctrlClientServerRouter = new TabControl();
		tbpgClient = new TabPage();
		label64 = new Label();
		ClientProxyLogger = new CliffControl();
		grpBoxClientServerInteractionInfo = new GroupBox();
		txtClientConfigTabMethodName = new TextBox();
		lblClientConfigTabServerInteractionInfoMethodName = new Label();
		txtClientConfigTabClassID = new TextBox();
		lblClientConfigTabClassID = new Label();
		cmdClientConfigExitApplication = new Button();
		cmdClientConfigSaveToFile = new Button();
		grpBoxClientOtherParameters = new GroupBox();
		label1 = new Label();
		txtClientProxyConfigRetryIntervals = new TextBox();
		lblClientProxyConfigRetryIntervals = new Label();
		grpBoxClientProxyConfigurationInformation = new GroupBox();
		label82 = new Label();
		label81 = new Label();
		cmdClientProxyConfigAddEnv = new Button();
		label3 = new Label();
		chkClientProxyATMIAEnvIsDefault = new CheckBox();
		lblClientProxyATMIAServerName = new Label();
		cmdClientProxyConfigCancelEnv = new Button();
		cmdClientProxyConfigDeleteEnv = new Button();
		cmdClientProxyConfigEditEnv = new Button();
		txtClientProxyATMIAServerName = new TextBox();
		txtClientProxyATMIAEnvironment = new TextBox();
		lblClientConfigATMIAEnv = new Label();
		lstBoxClientProxyEnvironments = new ListBox();
		tbpgSPEED = new TabPage();
		cmdSPEEDSaveLogger = new Button();
		label41 = new Label();
		groupBox12 = new GroupBox();
		label80 = new Label();
		txtSPEEDConfigProxyMethodParm = new TextBox();
		label65 = new Label();
		label59 = new Label();
		label58 = new Label();
		label57 = new Label();
		label56 = new Label();
		label55 = new Label();
		label44 = new Label();
		label37 = new Label();
		txtSPEEDConfigURI = new TextBox();
		chkSPEEDConfigDefault = new CheckBox();
		txtSPEEDConfigEnv = new TextBox();
		label32 = new Label();
		cmdSPEEDConfigEdit = new Button();
		label33 = new Label();
		txtSPEEDConfigMethodName = new TextBox();
		cmdSPEEDConfigDelete = new Button();
		cmdSPEEDConfigAdd = new Button();
		label34 = new Label();
		label35 = new Label();
		txtSPEEDConfigProxyNameSpace = new TextBox();
		txtSPEEDConfigTypeName = new TextBox();
		lstSPEEDEnv = new ListBox();
		cmdSPEEDConfigCancel = new Button();
		cmdSPEEDConfigExitApplication = new Button();
		cmdSPEEDConfigSaveToFile = new Button();
		groupBox10 = new GroupBox();
		txtSPEEDConfigReplyXsl = new TextBox();
		label28 = new Label();
		txtSPEEDConfigRequestXsl = new TextBox();
		label29 = new Label();
		groupBox11 = new GroupBox();
		label30 = new Label();
		txtSPEEDConfigRetryIntervals = new TextBox();
		label31 = new Label();
		SPEEDLogger = new CliffControl();
		tbpgWSInterface = new TabPage();
		cmdWSConfigSaveLogger = new Button();
		WSLogger = new CliffControl();
		groupBox1 = new GroupBox();
		label46 = new Label();
		txtWSConfigServiceName = new TextBox();
		lblWSConfigServiceName = new Label();
		txtWSConfigReplyXSL = new TextBox();
		lblWSConfigReplyXSL = new Label();
		txtWSConfigRequestXSL = new TextBox();
		lblWSConfigRequestXSL = new Label();
		cmdWSConfigAdvancedOperation = new Button();
		cmdWSConfigAppExit = new Button();
		cmdWSConfigFinalSaveTofile = new Button();
		tbpgGlenda = new TabPage();
		cmdGlendaSaveLogger = new Button();
		label40 = new Label();
		cmdGlendaConfigExitApplication = new Button();
		cmdGlendaConfigSaveToFile = new Button();
		groupBox4 = new GroupBox();
		txtGlendaConfigReplyXsl = new TextBox();
		label13 = new Label();
		txtGlendaConfigRequestXsl = new TextBox();
		label15 = new Label();
		groupBox5 = new GroupBox();
		label16 = new Label();
		txtGlendaConfigRetryIntervals = new TextBox();
		label17 = new Label();
		groupBox6 = new GroupBox();
		label54 = new Label();
		label53 = new Label();
		label52 = new Label();
		label51 = new Label();
		label43 = new Label();
		chkGlendaConfigDefault = new CheckBox();
		txtGlendaConfigEnv = new TextBox();
		lblGlendaConfigEnv = new Label();
		cmdGlendaConfigEdit = new Button();
		label18 = new Label();
		txtGlendaConfigMethodName = new TextBox();
		cmdGlendaConfigDelete = new Button();
		cmdGlendaConfigAdd = new Button();
		label19 = new Label();
		label20 = new Label();
		txtGlendaConfigClassID = new TextBox();
		txtGlendaConfigServerName = new TextBox();
		lstGlendaEnv = new ListBox();
		cmdGlendaConfigCancel = new Button();
		GlendaLogger = new CliffControl();
		tbpgIRE = new TabPage();
		cmdIREConfigSaveLogger = new Button();
		label42 = new Label();
		groupBox9 = new GroupBox();
		label63 = new Label();
		label62 = new Label();
		label61 = new Label();
		label60 = new Label();
		label45 = new Label();
		chkIREConfigDefault = new CheckBox();
		txtIREConfigEnv = new TextBox();
		label25 = new Label();
		cmdIREConfigEdit = new Button();
		label26 = new Label();
		txtIREConfigMethodName = new TextBox();
		cmdIREConfigDelete = new Button();
		cmdIREConfigAdd = new Button();
		label27 = new Label();
		label36 = new Label();
		txtIREConfigClassID = new TextBox();
		txtIREConfigServerName = new TextBox();
		lstIREEnv = new ListBox();
		cmdIREConfigCancel = new Button();
		cmdIREConfigExitApplication = new Button();
		cmdIREConfigSaveToFile = new Button();
		groupBox7 = new GroupBox();
		txtIREConfigReplyXsl = new TextBox();
		label21 = new Label();
		txtIREConfigRequestXsl = new TextBox();
		label22 = new Label();
		groupBox8 = new GroupBox();
		label23 = new Label();
		txtIREConfigRetryIntervals = new TextBox();
		label24 = new Label();
		IRELogger = new CliffControl();
		tbpgSPC = new TabPage();
		cmdSPCConfigSaveLogger = new Button();
		label66 = new Label();
		cmdSPCConfigExitApplication = new Button();
		cmdSPCConfigSaveToFile = new Button();
		grpBoxSPCXMLs = new GroupBox();
		txtSPCConfigReplyXsl = new TextBox();
		label67 = new Label();
		txtSPCConfigRequestXsl = new TextBox();
		label68 = new Label();
		grpBoxSPCRetryParameters = new GroupBox();
		label69 = new Label();
		txtSPCConfigRetryIntervals = new TextBox();
		label70 = new Label();
		grpBoxSPCEnvrionments = new GroupBox();
		txtSPCConfigEnv = new TextBox();
		label71 = new Label();
		label72 = new Label();
		label73 = new Label();
		label74 = new Label();
		label75 = new Label();
		chkSPCConfigDefault = new CheckBox();
		label76 = new Label();
		cmdSPCConfigEdit = new Button();
		label77 = new Label();
		txtSPCConfigMethodName = new TextBox();
		cmdSPCConfigDelete = new Button();
		cmdSPCConfigAdd = new Button();
		label78 = new Label();
		label79 = new Label();
		txtSPCConfigClassID = new TextBox();
		txtSPCConfigServerName = new TextBox();
		lstSPCEnv = new ListBox();
		cmdSPCConfigCancel = new Button();
		SPCLogger = new CliffControl();
		tbpgTCPIP = new TabPage();
		cmdTCPIPSaveLogger = new Button();
		label38 = new Label();
		cmdTCPIPConfigAppExit = new Button();
		cmdTCPIPConfigFinalSaveTofile = new Button();
		groupBox3 = new GroupBox();
		label47 = new Label();
		txtTCPIPPortNum = new TextBox();
		label14 = new Label();
		groupBox2 = new GroupBox();
		label11 = new Label();
		txtTCPIPConfigRetryIntervals = new TextBox();
		label12 = new Label();
		TCPIPLogger = new CliffControl();
		tbpgRouter = new TabPage();
		cmdRouterSaveLogger = new Button();
		label39 = new Label();
		RouterLogger = new CliffControl();
		grpRouterConfigXSL = new GroupBox();
		txtRouterConfigReplyXsl = new TextBox();
		lblReplyXsl = new Label();
		txtRouterConfigRequestXsl = new TextBox();
		lblRequestXsl = new Label();
		grpBoxRouterTabRetryParameters = new GroupBox();
		lblRetryIntervalExample = new Label();
		txtRouterConfigRetryIntervals = new TextBox();
		lblRouterConfigRetryIntervals = new Label();
		cmdRouterConfigExitApplication = new Button();
		cmdRouterConfigSaveToFile = new Button();
		grpBoxRouterConfigurationInfo = new GroupBox();
		label50 = new Label();
		label49 = new Label();
		label48 = new Label();
		cmdRouterConfigTabEditConfigInfo = new Button();
		lblRouterConfigTabMethodName = new Label();
		txtRouterConfigTabMethodName = new TextBox();
		cmdRouterConfigTabDeleteConfigInfo = new Button();
		cmdRouterConfigTabAddConfigInfo = new Button();
		lblRouterConfigTabInterfaceType = new Label();
		lblRouterConfigTabServiceName = new Label();
		txtRouterConfigTabInterfaceType = new TextBox();
		txtRouterConfigTabServiceName = new TextBox();
		lstBoxRouterConfigServiceNames = new ListBox();
		cmdRouterConfigTabCancel = new Button();
		lblClientATMIAServerName = new Label();
		folderBrowserDialogLogFiles = new FolderBrowserDialog();
		openFileDialog1 = new OpenFileDialog();
		ErrorConfigBtn = new Button();
		((Control)grpBoxBackEndEnvironments).SuspendLayout();
		((Control)grpBoxHostInformation).SuspendLayout();
		((Control)grpBoxPortInformation).SuspendLayout();
		((Control)grpBoxAccountInformation).SuspendLayout();
		((Control)grpBoxBackEndEnvName).SuspendLayout();
		((Control)tbctrlClientServerRouter).SuspendLayout();
		((Control)tbpgClient).SuspendLayout();
		((Control)grpBoxClientServerInteractionInfo).SuspendLayout();
		((Control)grpBoxClientOtherParameters).SuspendLayout();
		((Control)grpBoxClientProxyConfigurationInformation).SuspendLayout();
		((Control)tbpgSPEED).SuspendLayout();
		((Control)groupBox12).SuspendLayout();
		((Control)groupBox10).SuspendLayout();
		((Control)groupBox11).SuspendLayout();
		((Control)tbpgWSInterface).SuspendLayout();
		((Control)groupBox1).SuspendLayout();
		((Control)tbpgGlenda).SuspendLayout();
		((Control)groupBox4).SuspendLayout();
		((Control)groupBox5).SuspendLayout();
		((Control)groupBox6).SuspendLayout();
		((Control)tbpgIRE).SuspendLayout();
		((Control)groupBox9).SuspendLayout();
		((Control)groupBox7).SuspendLayout();
		((Control)groupBox8).SuspendLayout();
		((Control)tbpgSPC).SuspendLayout();
		((Control)grpBoxSPCXMLs).SuspendLayout();
		((Control)grpBoxSPCRetryParameters).SuspendLayout();
		((Control)grpBoxSPCEnvrionments).SuspendLayout();
		((Control)tbpgTCPIP).SuspendLayout();
		((Control)groupBox3).SuspendLayout();
		((Control)groupBox2).SuspendLayout();
		((Control)tbpgRouter).SuspendLayout();
		((Control)grpRouterConfigXSL).SuspendLayout();
		((Control)grpBoxRouterTabRetryParameters).SuspendLayout();
		((Control)grpBoxRouterConfigurationInfo).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)grpBoxBackEndEnvironments).get_Controls().Add((Control)(object)lblDefEnvironmentName);
		((Control)grpBoxBackEndEnvironments).get_Controls().Add((Control)(object)cmdBackEndEnvOpCancel);
		((Control)grpBoxBackEndEnvironments).get_Controls().Add((Control)(object)cmdEditBackEndEnv);
		((Control)grpBoxBackEndEnvironments).get_Controls().Add((Control)(object)cmdDeleteBackEndEnv);
		((Control)grpBoxBackEndEnvironments).get_Controls().Add((Control)(object)cmdAddBackEndEnv);
		((Control)grpBoxBackEndEnvironments).get_Controls().Add((Control)(object)grpBoxHostInformation);
		((Control)grpBoxBackEndEnvironments).get_Controls().Add((Control)(object)lstBoxWSBackEnds);
		((Control)grpBoxBackEndEnvironments).get_Controls().Add((Control)(object)grpBoxBackEndEnvName);
		((Control)grpBoxBackEndEnvironments).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)grpBoxBackEndEnvironments).set_Location(new Point(16, 224));
		((Control)grpBoxBackEndEnvironments).set_Name("grpBoxBackEndEnvironments");
		((Control)grpBoxBackEndEnvironments).set_Size(new Size(656, 264));
		((Control)grpBoxBackEndEnvironments).set_TabIndex(1);
		grpBoxBackEndEnvironments.set_TabStop(false);
		((Control)grpBoxBackEndEnvironments).set_Text("BackEnd Environments");
		((Control)lblDefEnvironmentName).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblDefEnvironmentName).set_ForeColor(Color.Brown);
		((Control)lblDefEnvironmentName).set_Location(new Point(16, 184));
		((Control)lblDefEnvironmentName).set_Name("lblDefEnvironmentName");
		((Control)lblDefEnvironmentName).set_Size(new Size(120, 32));
		((Control)lblDefEnvironmentName).set_TabIndex(27);
		((Control)lblDefEnvironmentName).set_Text("First Environment is Default ");
		((ButtonBase)cmdBackEndEnvOpCancel).set_FlatStyle((FlatStyle)3);
		((Control)cmdBackEndEnvOpCancel).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cmdBackEndEnvOpCancel).set_Location(new Point(536, 232));
		((Control)cmdBackEndEnvOpCancel).set_Name("cmdBackEndEnvOpCancel");
		((Control)cmdBackEndEnvOpCancel).set_Size(new Size(72, 24));
		((Control)cmdBackEndEnvOpCancel).set_TabIndex(18);
		((Control)cmdBackEndEnvOpCancel).set_Text("Cancel");
		((Control)cmdBackEndEnvOpCancel).add_Click((EventHandler)cmdBackEndEnvOpCancel_Click);
		((ButtonBase)cmdEditBackEndEnv).set_FlatStyle((FlatStyle)3);
		((Control)cmdEditBackEndEnv).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cmdEditBackEndEnv).set_Location(new Point(280, 232));
		((Control)cmdEditBackEndEnv).set_Name("cmdEditBackEndEnv");
		((Control)cmdEditBackEndEnv).set_Size(new Size(72, 24));
		((Control)cmdEditBackEndEnv).set_TabIndex(16);
		((Control)cmdEditBackEndEnv).set_Text("Edit");
		((Control)cmdEditBackEndEnv).add_Click((EventHandler)cmdEditBackEndEnv_Click);
		((Control)cmdDeleteBackEndEnv).set_Enabled(false);
		((ButtonBase)cmdDeleteBackEndEnv).set_FlatStyle((FlatStyle)3);
		((Control)cmdDeleteBackEndEnv).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cmdDeleteBackEndEnv).set_Location(new Point(408, 232));
		((Control)cmdDeleteBackEndEnv).set_Name("cmdDeleteBackEndEnv");
		((Control)cmdDeleteBackEndEnv).set_Size(new Size(72, 24));
		((Control)cmdDeleteBackEndEnv).set_TabIndex(17);
		((Control)cmdDeleteBackEndEnv).set_Text("Delete");
		((Control)cmdDeleteBackEndEnv).add_Click((EventHandler)cmdDeleteBackEndEnv_Click);
		((ButtonBase)cmdAddBackEndEnv).set_FlatStyle((FlatStyle)3);
		((Control)cmdAddBackEndEnv).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cmdAddBackEndEnv).set_Location(new Point(160, 232));
		((Control)cmdAddBackEndEnv).set_Name("cmdAddBackEndEnv");
		((Control)cmdAddBackEndEnv).set_Size(new Size(72, 24));
		((Control)cmdAddBackEndEnv).set_TabIndex(15);
		((Control)cmdAddBackEndEnv).set_Text("Add");
		((Control)cmdAddBackEndEnv).add_Click((EventHandler)cmdAddBackEndEnv_Click);
		((Control)grpBoxHostInformation).get_Controls().Add((Control)(object)lblAlternateHostName);
		((Control)grpBoxHostInformation).get_Controls().Add((Control)(object)txtHostName);
		((Control)grpBoxHostInformation).get_Controls().Add((Control)(object)lblHostName);
		((Control)grpBoxHostInformation).get_Controls().Add((Control)(object)txtAlternateHostName);
		((Control)grpBoxHostInformation).get_Controls().Add((Control)(object)grpBoxPortInformation);
		((Control)grpBoxHostInformation).get_Controls().Add((Control)(object)grpBoxAccountInformation);
		((Control)grpBoxHostInformation).get_Controls().Add((Control)(object)label5);
		((Control)grpBoxHostInformation).set_Location(new Point(136, 72));
		((Control)grpBoxHostInformation).set_Name("grpBoxHostInformation");
		((Control)grpBoxHostInformation).set_Size(new Size(512, 160));
		((Control)grpBoxHostInformation).set_TabIndex(17);
		grpBoxHostInformation.set_TabStop(false);
		((Control)grpBoxHostInformation).set_Text("Host Information");
		((Control)lblAlternateHostName).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblAlternateHostName).set_Location(new Point(272, 24));
		((Control)lblAlternateHostName).set_Name("lblAlternateHostName");
		((Control)lblAlternateHostName).set_Size(new Size(72, 24));
		((Control)lblAlternateHostName).set_TabIndex(10);
		((Control)lblAlternateHostName).set_Text("Alternate WS Host Name");
		lblAlternateHostName.set_TextAlign((ContentAlignment)16);
		((Control)txtHostName).set_Enabled(false);
		((Control)txtHostName).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)txtHostName).set_Location(new Point(104, 24));
		((Control)txtHostName).set_Name("txtHostName");
		((Control)txtHostName).set_Size(new Size(136, 20));
		((Control)txtHostName).set_TabIndex(8);
		((Control)txtHostName).set_Text("");
		((Control)lblHostName).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblHostName).set_Location(new Point(8, 24));
		((Control)lblHostName).set_Name("lblHostName");
		((Control)lblHostName).set_Size(new Size(72, 32));
		((Control)lblHostName).set_TabIndex(9);
		((Control)lblHostName).set_Text("WorkStream Host Name");
		lblHostName.set_TextAlign((ContentAlignment)16);
		((Control)txtAlternateHostName).set_Enabled(false);
		((Control)txtAlternateHostName).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)txtAlternateHostName).set_Location(new Point(352, 24));
		((Control)txtAlternateHostName).set_Name("txtAlternateHostName");
		((Control)txtAlternateHostName).set_Size(new Size(152, 20));
		((Control)txtAlternateHostName).set_TabIndex(9);
		((Control)txtAlternateHostName).set_Text("");
		((Control)grpBoxPortInformation).get_Controls().Add((Control)(object)lblAlternatePortName);
		((Control)grpBoxPortInformation).get_Controls().Add((Control)(object)txtPortNumber);
		((Control)grpBoxPortInformation).get_Controls().Add((Control)(object)lblPortNumber);
		((Control)grpBoxPortInformation).get_Controls().Add((Control)(object)txtAlternatePortNumber);
		((Control)grpBoxPortInformation).get_Controls().Add((Control)(object)label6);
		((Control)grpBoxPortInformation).set_Location(new Point(8, 56));
		((Control)grpBoxPortInformation).set_Name("grpBoxPortInformation");
		((Control)grpBoxPortInformation).set_Size(new Size(248, 96));
		((Control)grpBoxPortInformation).set_TabIndex(18);
		grpBoxPortInformation.set_TabStop(false);
		((Control)grpBoxPortInformation).set_Text("Port Information");
		((Control)lblAlternatePortName).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblAlternatePortName).set_Location(new Point(8, 56));
		((Control)lblAlternatePortName).set_Name("lblAlternatePortName");
		((Control)lblAlternatePortName).set_Size(new Size(104, 23));
		((Control)lblAlternatePortName).set_TabIndex(10);
		((Control)lblAlternatePortName).set_Text("Alternate Port Num");
		lblAlternatePortName.set_TextAlign((ContentAlignment)16);
		((Control)txtPortNumber).set_Enabled(false);
		((Control)txtPortNumber).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)txtPortNumber).set_Location(new Point(152, 16));
		((Control)txtPortNumber).set_Name("txtPortNumber");
		((Control)txtPortNumber).set_Size(new Size(64, 20));
		((Control)txtPortNumber).set_TabIndex(10);
		((Control)txtPortNumber).set_Text("");
		((Control)lblPortNumber).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblPortNumber).set_Location(new Point(8, 16));
		((Control)lblPortNumber).set_Name("lblPortNumber");
		((Control)lblPortNumber).set_Size(new Size(104, 24));
		((Control)lblPortNumber).set_TabIndex(9);
		((Control)lblPortNumber).set_Text("Port Number");
		lblPortNumber.set_TextAlign((ContentAlignment)16);
		((Control)txtAlternatePortNumber).set_Enabled(false);
		((Control)txtAlternatePortNumber).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)txtAlternatePortNumber).set_Location(new Point(152, 56));
		((Control)txtAlternatePortNumber).set_Name("txtAlternatePortNumber");
		((Control)txtAlternatePortNumber).set_Size(new Size(64, 20));
		((Control)txtAlternatePortNumber).set_TabIndex(11);
		((Control)txtAlternatePortNumber).set_Text("");
		((Control)label6).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label6).set_ForeColor(Color.Red);
		((Control)label6).set_Location(new Point(136, 16));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(8, 24));
		((Control)label6).set_TabIndex(34);
		((Control)label6).set_Text("*");
		label6.set_TextAlign((ContentAlignment)32);
		((Control)grpBoxAccountInformation).get_Controls().Add((Control)(object)lblConfirmPassword);
		((Control)grpBoxAccountInformation).get_Controls().Add((Control)(object)txtConfirmPassword);
		((Control)grpBoxAccountInformation).get_Controls().Add((Control)(object)lblPassword);
		((Control)grpBoxAccountInformation).get_Controls().Add((Control)(object)txtUserName);
		((Control)grpBoxAccountInformation).get_Controls().Add((Control)(object)lblUserName);
		((Control)grpBoxAccountInformation).get_Controls().Add((Control)(object)txtPassword);
		((Control)grpBoxAccountInformation).get_Controls().Add((Control)(object)label9);
		((Control)grpBoxAccountInformation).get_Controls().Add((Control)(object)label8);
		((Control)grpBoxAccountInformation).get_Controls().Add((Control)(object)label4);
		((Control)grpBoxAccountInformation).set_Location(new Point(264, 56));
		((Control)grpBoxAccountInformation).set_Name("grpBoxAccountInformation");
		((Control)grpBoxAccountInformation).set_Size(new Size(240, 96));
		((Control)grpBoxAccountInformation).set_TabIndex(19);
		grpBoxAccountInformation.set_TabStop(false);
		((Control)grpBoxAccountInformation).set_Text("Account Info to connect to Workstream");
		((Control)lblConfirmPassword).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblConfirmPassword).set_Location(new Point(8, 64));
		((Control)lblConfirmPassword).set_Name("lblConfirmPassword");
		((Control)lblConfirmPassword).set_Size(new Size(104, 23));
		((Control)lblConfirmPassword).set_TabIndex(12);
		((Control)lblConfirmPassword).set_Text("Confirm Password");
		lblConfirmPassword.set_TextAlign((ContentAlignment)16);
		((Control)txtConfirmPassword).set_Enabled(false);
		((Control)txtConfirmPassword).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)txtConfirmPassword).set_Location(new Point(128, 64));
		((Control)txtConfirmPassword).set_Name("txtConfirmPassword");
		((Control)txtConfirmPassword).set_TabIndex(14);
		((Control)txtConfirmPassword).set_Text("");
		((Control)lblPassword).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblPassword).set_Location(new Point(8, 40));
		((Control)lblPassword).set_Name("lblPassword");
		((Control)lblPassword).set_Size(new Size(104, 23));
		((Control)lblPassword).set_TabIndex(10);
		((Control)lblPassword).set_Text("Password");
		lblPassword.set_TextAlign((ContentAlignment)16);
		((Control)txtUserName).set_Enabled(false);
		((Control)txtUserName).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)txtUserName).set_Location(new Point(128, 16));
		((Control)txtUserName).set_Name("txtUserName");
		((Control)txtUserName).set_TabIndex(12);
		((Control)txtUserName).set_Text("");
		((Control)lblUserName).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblUserName).set_Location(new Point(8, 16));
		((Control)lblUserName).set_Name("lblUserName");
		((Control)lblUserName).set_Size(new Size(104, 24));
		((Control)lblUserName).set_TabIndex(9);
		((Control)lblUserName).set_Text("UserName");
		lblUserName.set_TextAlign((ContentAlignment)16);
		((Control)txtPassword).set_Enabled(false);
		((Control)txtPassword).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)txtPassword).set_Location(new Point(128, 40));
		((Control)txtPassword).set_Name("txtPassword");
		((Control)txtPassword).set_TabIndex(13);
		((Control)txtPassword).set_Text("");
		((Control)label9).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label9).set_ForeColor(Color.Red);
		((Control)label9).set_Location(new Point(112, 64));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(8, 24));
		((Control)label9).set_TabIndex(38);
		((Control)label9).set_Text("*");
		label9.set_TextAlign((ContentAlignment)32);
		((Control)label8).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label8).set_ForeColor(Color.Red);
		((Control)label8).set_Location(new Point(112, 40));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(8, 24));
		((Control)label8).set_TabIndex(37);
		((Control)label8).set_Text("*");
		label8.set_TextAlign((ContentAlignment)32);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.Red);
		((Control)label4).set_Location(new Point(112, 16));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(8, 24));
		((Control)label4).set_TabIndex(36);
		((Control)label4).set_Text("*");
		label4.set_TextAlign((ContentAlignment)32);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(Color.Red);
		((Control)label5).set_Location(new Point(88, 24));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(8, 24));
		((Control)label5).set_TabIndex(7);
		((Control)label5).set_Text("*");
		label5.set_TextAlign((ContentAlignment)32);
		((Control)lstBoxWSBackEnds).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		lstBoxWSBackEnds.set_ItemHeight(16);
		((Control)lstBoxWSBackEnds).set_Location(new Point(16, 24));
		((Control)lstBoxWSBackEnds).set_Name("lstBoxWSBackEnds");
		((Control)lstBoxWSBackEnds).set_Size(new Size(112, 148));
		((Control)lstBoxWSBackEnds).set_TabIndex(5);
		lstBoxWSBackEnds.add_SelectedIndexChanged((EventHandler)lstBoxBackEnds_SelectedIndexChanged);
		((Control)grpBoxBackEndEnvName).get_Controls().Add((Control)(object)chkWSConfigBEIsDefault);
		((Control)grpBoxBackEndEnvName).get_Controls().Add((Control)(object)txtBackEndEnvironment);
		((Control)grpBoxBackEndEnvName).get_Controls().Add((Control)(object)label2);
		((Control)grpBoxBackEndEnvName).get_Controls().Add((Control)(object)label7);
		((Control)grpBoxBackEndEnvName).set_Location(new Point(136, 16));
		((Control)grpBoxBackEndEnvName).set_Name("grpBoxBackEndEnvName");
		((Control)grpBoxBackEndEnvName).set_Size(new Size(512, 48));
		((Control)grpBoxBackEndEnvName).set_TabIndex(30);
		grpBoxBackEndEnvName.set_TabStop(false);
		chkWSConfigBEIsDefault.set_Checked(true);
		chkWSConfigBEIsDefault.set_CheckState((CheckState)1);
		((Control)chkWSConfigBEIsDefault).set_Enabled(false);
		((Control)chkWSConfigBEIsDefault).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)chkWSConfigBEIsDefault).set_Location(new Point(352, 8));
		((Control)chkWSConfigBEIsDefault).set_Name("chkWSConfigBEIsDefault");
		((Control)chkWSConfigBEIsDefault).set_Size(new Size(144, 32));
		((Control)chkWSConfigBEIsDefault).set_TabIndex(7);
		((Control)chkWSConfigBEIsDefault).set_Text("Check here if this is the Default Environment");
		((Control)txtBackEndEnvironment).set_Location(new Point(160, 16));
		((Control)txtBackEndEnvironment).set_Name("txtBackEndEnvironment");
		((Control)txtBackEndEnvironment).set_Size(new Size(176, 20));
		((Control)txtBackEndEnvironment).set_TabIndex(6);
		((Control)txtBackEndEnvironment).set_Text("");
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_Location(new Point(8, 16));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(136, 23));
		((Control)label2).set_TabIndex(29);
		((Control)label2).set_Text("WorkStream Environment");
		label2.set_TextAlign((ContentAlignment)16);
		((Control)label7).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label7).set_ForeColor(Color.Red);
		((Control)label7).set_Location(new Point(144, 16));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(8, 24));
		((Control)label7).set_TabIndex(34);
		((Control)label7).set_Text("*");
		label7.set_TextAlign((ContentAlignment)32);
		((Control)label10).set_ForeColor(Color.Red);
		((Control)label10).set_Location(new Point(32, 496));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(112, 24));
		((Control)label10).set_TabIndex(33);
		((Control)label10).set_Text("*   Represents  Mandatory Fields");
		((Control)lblWSEnvListWarningInformation).set_Location(new Point(0, 0));
		((Control)lblWSEnvListWarningInformation).set_Name("lblWSEnvListWarningInformation");
		((Control)lblWSEnvListWarningInformation).set_TabIndex(0);
		((Control)checkBox1).set_Location(new Point(0, 0));
		((Control)checkBox1).set_Name("checkBox1");
		((Control)checkBox1).set_TabIndex(0);
		((Control)lblBackEndEnvironment).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblBackEndEnvironment).set_Location(new Point(8, 16));
		((Control)lblBackEndEnvironment).set_Name("lblBackEndEnvironment");
		((Control)lblBackEndEnvironment).set_Size(new Size(112, 24));
		((Control)lblBackEndEnvironment).set_TabIndex(26);
		((Control)lblBackEndEnvironment).set_Text("Back End Env");
		lblBackEndEnvironment.set_TextAlign((ContentAlignment)16);
		((Control)tbctrlClientServerRouter).get_Controls().Add((Control)(object)tbpgClient);
		((Control)tbctrlClientServerRouter).get_Controls().Add((Control)(object)tbpgWSInterface);
		((Control)tbctrlClientServerRouter).get_Controls().Add((Control)(object)tbpgSPEED);
		((Control)tbctrlClientServerRouter).get_Controls().Add((Control)(object)tbpgGlenda);
		((Control)tbctrlClientServerRouter).get_Controls().Add((Control)(object)tbpgIRE);
		((Control)tbctrlClientServerRouter).get_Controls().Add((Control)(object)tbpgSPC);
		((Control)tbctrlClientServerRouter).get_Controls().Add((Control)(object)tbpgTCPIP);
		((Control)tbctrlClientServerRouter).get_Controls().Add((Control)(object)tbpgRouter);
		((Control)tbctrlClientServerRouter).set_Location(new Point(8, 16));
		((Control)tbctrlClientServerRouter).set_Name("tbctrlClientServerRouter");
		tbctrlClientServerRouter.set_SelectedIndex(0);
		((Control)tbctrlClientServerRouter).set_Size(new Size(696, 552));
		((Control)tbctrlClientServerRouter).set_TabIndex(2);
		((Control)tbpgClient).get_Controls().Add((Control)(object)ErrorConfigBtn);
		((Control)tbpgClient).get_Controls().Add((Control)(object)label64);
		((Control)tbpgClient).get_Controls().Add((Control)(object)ClientProxyLogger);
		((Control)tbpgClient).get_Controls().Add((Control)(object)grpBoxClientServerInteractionInfo);
		((Control)tbpgClient).get_Controls().Add((Control)(object)cmdClientConfigExitApplication);
		((Control)tbpgClient).get_Controls().Add((Control)(object)cmdClientConfigSaveToFile);
		((Control)tbpgClient).get_Controls().Add((Control)(object)grpBoxClientOtherParameters);
		((Control)tbpgClient).get_Controls().Add((Control)(object)grpBoxClientProxyConfigurationInformation);
		((Control)tbpgClient).set_Location(new Point(4, 22));
		((Control)tbpgClient).set_Name("tbpgClient");
		((Control)tbpgClient).set_Size(new Size(688, 526));
		tbpgClient.set_TabIndex(0);
		((Control)tbpgClient).set_Text(" Client Configuration ");
		((Control)label64).set_ForeColor(Color.Red);
		((Control)label64).set_Location(new Point(48, 472));
		((Control)label64).set_Name("label64");
		((Control)label64).set_Size(new Size(112, 24));
		((Control)label64).set_TabIndex(35);
		((Control)label64).set_Text("*   Represents  Mandatory Fields");
		ClientProxyLogger.set_IsEditMode(false);
		((Control)ClientProxyLogger).set_Location(new Point(8, -8));
		((Control)ClientProxyLogger).set_Name("ClientProxyLogger");
		((Control)ClientProxyLogger).set_Size(new Size(712, 168));
		((Control)ClientProxyLogger).set_TabIndex(8);
		((Control)grpBoxClientServerInteractionInfo).get_Controls().Add((Control)(object)txtClientConfigTabMethodName);
		((Control)grpBoxClientServerInteractionInfo).get_Controls().Add((Control)(object)lblClientConfigTabServerInteractionInfoMethodName);
		((Control)grpBoxClientServerInteractionInfo).get_Controls().Add((Control)(object)txtClientConfigTabClassID);
		((Control)grpBoxClientServerInteractionInfo).get_Controls().Add((Control)(object)lblClientConfigTabClassID);
		((Control)grpBoxClientServerInteractionInfo).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)grpBoxClientServerInteractionInfo).set_Location(new Point(16, 224));
		((Control)grpBoxClientServerInteractionInfo).set_Name("grpBoxClientServerInteractionInfo");
		((Control)grpBoxClientServerInteractionInfo).set_Size(new Size(656, 56));
		((Control)grpBoxClientServerInteractionInfo).set_TabIndex(7);
		grpBoxClientServerInteractionInfo.set_TabStop(false);
		((Control)grpBoxClientServerInteractionInfo).set_Text("Interface Information");
		((Control)txtClientConfigTabMethodName).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtClientConfigTabMethodName).set_Location(new Point(448, 24));
		((Control)txtClientConfigTabMethodName).set_Name("txtClientConfigTabMethodName");
		((Control)txtClientConfigTabMethodName).set_Size(new Size(152, 20));
		((Control)txtClientConfigTabMethodName).set_TabIndex(4);
		((Control)txtClientConfigTabMethodName).set_Text("");
		((Control)txtClientConfigTabMethodName).add_TextChanged((EventHandler)txtClientConfigTabMethodName_TextChanged);
		((Control)lblClientConfigTabServerInteractionInfoMethodName).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblClientConfigTabServerInteractionInfoMethodName).set_Location(new Point(368, 24));
		((Control)lblClientConfigTabServerInteractionInfoMethodName).set_Name("lblClientConfigTabServerInteractionInfoMethodName");
		((Control)lblClientConfigTabServerInteractionInfoMethodName).set_Size(new Size(80, 23));
		((Control)lblClientConfigTabServerInteractionInfoMethodName).set_TabIndex(3);
		((Control)lblClientConfigTabServerInteractionInfoMethodName).set_Text("Method Name");
		lblClientConfigTabServerInteractionInfoMethodName.set_TextAlign((ContentAlignment)16);
		((Control)txtClientConfigTabClassID).set_Enabled(false);
		((Control)txtClientConfigTabClassID).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtClientConfigTabClassID).set_Location(new Point(96, 24));
		((Control)txtClientConfigTabClassID).set_Name("txtClientConfigTabClassID");
		((Control)txtClientConfigTabClassID).set_Size(new Size(256, 20));
		((Control)txtClientConfigTabClassID).set_TabIndex(3);
		((Control)txtClientConfigTabClassID).set_Text("");
		((Control)txtClientConfigTabClassID).add_TextChanged((EventHandler)txtClientConfigTabClassID_TextChanged);
		((Control)lblClientConfigTabClassID).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblClientConfigTabClassID).set_Location(new Point(16, 24));
		((Control)lblClientConfigTabClassID).set_Name("lblClientConfigTabClassID");
		((Control)lblClientConfigTabClassID).set_Size(new Size(80, 23));
		((Control)lblClientConfigTabClassID).set_TabIndex(1);
		((Control)lblClientConfigTabClassID).set_Text("Class ID");
		lblClientConfigTabClassID.set_TextAlign((ContentAlignment)16);
		((ButtonBase)cmdClientConfigExitApplication).set_FlatStyle((FlatStyle)3);
		((Control)cmdClientConfigExitApplication).set_Location(new Point(520, 480));
		((Control)cmdClientConfigExitApplication).set_Name("cmdClientConfigExitApplication");
		((Control)cmdClientConfigExitApplication).set_Size(new Size(144, 32));
		((Control)cmdClientConfigExitApplication).set_TabIndex(14);
		((Control)cmdClientConfigExitApplication).set_Text("Exit Application");
		((Control)cmdClientConfigExitApplication).add_Click((EventHandler)cmdClientConfigExitApplication_Click);
		((ButtonBase)cmdClientConfigSaveToFile).set_FlatStyle((FlatStyle)3);
		((Control)cmdClientConfigSaveToFile).set_Location(new Point(344, 480));
		((Control)cmdClientConfigSaveToFile).set_Name("cmdClientConfigSaveToFile");
		((Control)cmdClientConfigSaveToFile).set_Size(new Size(144, 32));
		((Control)cmdClientConfigSaveToFile).set_TabIndex(13);
		((Control)cmdClientConfigSaveToFile).set_Text("SaveToFile");
		((Control)cmdClientConfigSaveToFile).add_Click((EventHandler)cmdClientConfigSaveToFile_Click);
		((Control)grpBoxClientOtherParameters).get_Controls().Add((Control)(object)label1);
		((Control)grpBoxClientOtherParameters).get_Controls().Add((Control)(object)txtClientProxyConfigRetryIntervals);
		((Control)grpBoxClientOtherParameters).get_Controls().Add((Control)(object)lblClientProxyConfigRetryIntervals);
		((Control)grpBoxClientOtherParameters).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)grpBoxClientOtherParameters).set_Location(new Point(16, 160));
		((Control)grpBoxClientOtherParameters).set_Name("grpBoxClientOtherParameters");
		((Control)grpBoxClientOtherParameters).set_Size(new Size(656, 64));
		((Control)grpBoxClientOtherParameters).set_TabIndex(4);
		grpBoxClientOtherParameters.set_TabStop(false);
		((Control)grpBoxClientOtherParameters).set_Text("Other Parameters");
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.Red);
		((Control)label1).set_Location(new Point(8, 48));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(240, 16));
		((Control)label1).set_TabIndex(34);
		((Control)label1).set_Text("ex: 5000 or 6000,5000 or 4000,3000,5000, ...");
		((Control)txtClientProxyConfigRetryIntervals).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtClientProxyConfigRetryIntervals).set_Location(new Point(256, 24));
		((Control)txtClientProxyConfigRetryIntervals).set_Name("txtClientProxyConfigRetryIntervals");
		((Control)txtClientProxyConfigRetryIntervals).set_Size(new Size(176, 20));
		((Control)txtClientProxyConfigRetryIntervals).set_TabIndex(2);
		((Control)txtClientProxyConfigRetryIntervals).set_Text("");
		((Control)txtClientProxyConfigRetryIntervals).add_TextChanged((EventHandler)txtClientProxyConfigRetryIntervals_TextChanged);
		((Control)lblClientProxyConfigRetryIntervals).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblClientProxyConfigRetryIntervals).set_Location(new Point(8, 24));
		((Control)lblClientProxyConfigRetryIntervals).set_Name("lblClientProxyConfigRetryIntervals");
		((Control)lblClientProxyConfigRetryIntervals).set_Size(new Size(136, 23));
		((Control)lblClientProxyConfigRetryIntervals).set_TabIndex(3);
		((Control)lblClientProxyConfigRetryIntervals).set_Text("Retry Intervals in milliSec");
		lblClientProxyConfigRetryIntervals.set_TextAlign((ContentAlignment)16);
		((Control)grpBoxClientProxyConfigurationInformation).get_Controls().Add((Control)(object)label82);
		((Control)grpBoxClientProxyConfigurationInformation).get_Controls().Add((Control)(object)label81);
		((Control)grpBoxClientProxyConfigurationInformation).get_Controls().Add((Control)(object)cmdClientProxyConfigAddEnv);
		((Control)grpBoxClientProxyConfigurationInformation).get_Controls().Add((Control)(object)label3);
		((Control)grpBoxClientProxyConfigurationInformation).get_Controls().Add((Control)(object)chkClientProxyATMIAEnvIsDefault);
		((Control)grpBoxClientProxyConfigurationInformation).get_Controls().Add((Control)(object)lblClientProxyATMIAServerName);
		((Control)grpBoxClientProxyConfigurationInformation).get_Controls().Add((Control)(object)cmdClientProxyConfigCancelEnv);
		((Control)grpBoxClientProxyConfigurationInformation).get_Controls().Add((Control)(object)cmdClientProxyConfigDeleteEnv);
		((Control)grpBoxClientProxyConfigurationInformation).get_Controls().Add((Control)(object)cmdClientProxyConfigEditEnv);
		((Control)grpBoxClientProxyConfigurationInformation).get_Controls().Add((Control)(object)txtClientProxyATMIAServerName);
		((Control)grpBoxClientProxyConfigurationInformation).get_Controls().Add((Control)(object)txtClientProxyATMIAEnvironment);
		((Control)grpBoxClientProxyConfigurationInformation).get_Controls().Add((Control)(object)lblClientConfigATMIAEnv);
		((Control)grpBoxClientProxyConfigurationInformation).get_Controls().Add((Control)(object)lstBoxClientProxyEnvironments);
		((Control)grpBoxClientProxyConfigurationInformation).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)grpBoxClientProxyConfigurationInformation).set_Location(new Point(16, 296));
		((Control)grpBoxClientProxyConfigurationInformation).set_Name("grpBoxClientProxyConfigurationInformation");
		((Control)grpBoxClientProxyConfigurationInformation).set_Size(new Size(656, 152));
		((Control)grpBoxClientProxyConfigurationInformation).set_TabIndex(2);
		grpBoxClientProxyConfigurationInformation.set_TabStop(false);
		((Control)grpBoxClientProxyConfigurationInformation).set_Text("Environment Information");
		((Control)label82).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label82).set_ForeColor(Color.Red);
		((Control)label82).set_Location(new Point(256, 56));
		((Control)label82).set_Name("label82");
		((Control)label82).set_Size(new Size(8, 24));
		((Control)label82).set_TabIndex(39);
		((Control)label82).set_Text("*");
		label82.set_TextAlign((ContentAlignment)32);
		((Control)label81).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label81).set_ForeColor(Color.Red);
		((Control)label81).set_Location(new Point(256, 24));
		((Control)label81).set_Name("label81");
		((Control)label81).set_Size(new Size(8, 24));
		((Control)label81).set_TabIndex(38);
		((Control)label81).set_Text("*");
		label81.set_TextAlign((ContentAlignment)32);
		((ButtonBase)cmdClientProxyConfigAddEnv).set_FlatStyle((FlatStyle)3);
		((Control)cmdClientProxyConfigAddEnv).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cmdClientProxyConfigAddEnv).set_Location(new Point(168, 104));
		((Control)cmdClientProxyConfigAddEnv).set_Name("cmdClientProxyConfigAddEnv");
		((Control)cmdClientProxyConfigAddEnv).set_Size(new Size(72, 23));
		((Control)cmdClientProxyConfigAddEnv).set_TabIndex(9);
		((Control)cmdClientProxyConfigAddEnv).set_Text("Add");
		((Control)cmdClientProxyConfigAddEnv).add_Click((EventHandler)cmdClientProxyConfigAddEnv_Click);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.Brown);
		((Control)label3).set_Location(new Point(16, 112));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(120, 32));
		((Control)label3).set_TabIndex(28);
		((Control)label3).set_Text("First Environment is Default ");
		chkClientProxyATMIAEnvIsDefault.set_Checked(true);
		chkClientProxyATMIAEnvIsDefault.set_CheckState((CheckState)1);
		((Control)chkClientProxyATMIAEnvIsDefault).set_Enabled(false);
		((Control)chkClientProxyATMIAEnvIsDefault).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)chkClientProxyATMIAEnvIsDefault).set_Location(new Point(392, 24));
		((Control)chkClientProxyATMIAEnvIsDefault).set_Name("chkClientProxyATMIAEnvIsDefault");
		((Control)chkClientProxyATMIAEnvIsDefault).set_Size(new Size(168, 24));
		((Control)chkClientProxyATMIAEnvIsDefault).set_TabIndex(7);
		((Control)chkClientProxyATMIAEnvIsDefault).set_Text("Check It If this is the Default");
		((Control)lblClientProxyATMIAServerName).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblClientProxyATMIAServerName).set_Location(new Point(152, 56));
		((Control)lblClientProxyATMIAServerName).set_Name("lblClientProxyATMIAServerName");
		((Control)lblClientProxyATMIAServerName).set_Size(new Size(112, 23));
		((Control)lblClientProxyATMIAServerName).set_TabIndex(9);
		((Control)lblClientProxyATMIAServerName).set_Text("ATMIA Server Name");
		lblClientProxyATMIAServerName.set_TextAlign((ContentAlignment)16);
		((ButtonBase)cmdClientProxyConfigCancelEnv).set_FlatStyle((FlatStyle)3);
		((Control)cmdClientProxyConfigCancelEnv).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cmdClientProxyConfigCancelEnv).set_Location(new Point(480, 104));
		((Control)cmdClientProxyConfigCancelEnv).set_Name("cmdClientProxyConfigCancelEnv");
		((Control)cmdClientProxyConfigCancelEnv).set_Size(new Size(72, 23));
		((Control)cmdClientProxyConfigCancelEnv).set_TabIndex(12);
		((Control)cmdClientProxyConfigCancelEnv).set_Text("Cancel");
		((Control)cmdClientProxyConfigCancelEnv).add_Click((EventHandler)cmdClientProxyConfigCancelEnv_Click);
		((ButtonBase)cmdClientProxyConfigDeleteEnv).set_FlatStyle((FlatStyle)3);
		((Control)cmdClientProxyConfigDeleteEnv).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cmdClientProxyConfigDeleteEnv).set_Location(new Point(376, 104));
		((Control)cmdClientProxyConfigDeleteEnv).set_Name("cmdClientProxyConfigDeleteEnv");
		((Control)cmdClientProxyConfigDeleteEnv).set_Size(new Size(72, 23));
		((Control)cmdClientProxyConfigDeleteEnv).set_TabIndex(11);
		((Control)cmdClientProxyConfigDeleteEnv).set_Text("Delete");
		((Control)cmdClientProxyConfigDeleteEnv).add_Click((EventHandler)cmdClientProxyConfigDeleteEnv_Click);
		((ButtonBase)cmdClientProxyConfigEditEnv).set_FlatStyle((FlatStyle)3);
		((Control)cmdClientProxyConfigEditEnv).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cmdClientProxyConfigEditEnv).set_Location(new Point(272, 104));
		((Control)cmdClientProxyConfigEditEnv).set_Name("cmdClientProxyConfigEditEnv");
		((Control)cmdClientProxyConfigEditEnv).set_Size(new Size(72, 23));
		((Control)cmdClientProxyConfigEditEnv).set_TabIndex(10);
		((Control)cmdClientProxyConfigEditEnv).set_Text("Edit");
		((Control)cmdClientProxyConfigEditEnv).add_Click((EventHandler)cmdClientProxyConfigEditEnv_Click);
		((Control)txtClientProxyATMIAServerName).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtClientProxyATMIAServerName).set_Location(new Point(264, 56));
		((Control)txtClientProxyATMIAServerName).set_Name("txtClientProxyATMIAServerName");
		((Control)txtClientProxyATMIAServerName).set_Size(new Size(288, 20));
		((Control)txtClientProxyATMIAServerName).set_TabIndex(8);
		((Control)txtClientProxyATMIAServerName).set_Text("");
		((Control)txtClientProxyATMIAEnvironment).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtClientProxyATMIAEnvironment).set_Location(new Point(264, 24));
		((Control)txtClientProxyATMIAEnvironment).set_Name("txtClientProxyATMIAEnvironment");
		((Control)txtClientProxyATMIAEnvironment).set_Size(new Size(112, 20));
		((Control)txtClientProxyATMIAEnvironment).set_TabIndex(6);
		((Control)txtClientProxyATMIAEnvironment).set_Text("");
		((Control)lblClientConfigATMIAEnv).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblClientConfigATMIAEnv).set_Location(new Point(152, 24));
		((Control)lblClientConfigATMIAEnv).set_Name("lblClientConfigATMIAEnv");
		((Control)lblClientConfigATMIAEnv).set_Size(new Size(112, 23));
		((Control)lblClientConfigATMIAEnv).set_TabIndex(1);
		((Control)lblClientConfigATMIAEnv).set_Text("ATMIA Environment");
		lblClientConfigATMIAEnv.set_TextAlign((ContentAlignment)16);
		((Control)lstBoxClientProxyEnvironments).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		lstBoxClientProxyEnvironments.set_ItemHeight(16);
		((Control)lstBoxClientProxyEnvironments).set_Location(new Point(16, 24));
		((Control)lstBoxClientProxyEnvironments).set_Name("lstBoxClientProxyEnvironments");
		((Control)lstBoxClientProxyEnvironments).set_Size(new Size(120, 84));
		((Control)lstBoxClientProxyEnvironments).set_TabIndex(5);
		lstBoxClientProxyEnvironments.add_SelectedIndexChanged((EventHandler)lstBoxClientProxyEnvironments_SelectedIndexChanged);
		((Control)tbpgSPEED).get_Controls().Add((Control)(object)cmdSPEEDSaveLogger);
		((Control)tbpgSPEED).get_Controls().Add((Control)(object)label41);
		((Control)tbpgSPEED).get_Controls().Add((Control)(object)groupBox12);
		((Control)tbpgSPEED).get_Controls().Add((Control)(object)cmdSPEEDConfigExitApplication);
		((Control)tbpgSPEED).get_Controls().Add((Control)(object)cmdSPEEDConfigSaveToFile);
		((Control)tbpgSPEED).get_Controls().Add((Control)(object)groupBox10);
		((Control)tbpgSPEED).get_Controls().Add((Control)(object)groupBox11);
		((Control)tbpgSPEED).get_Controls().Add((Control)(object)SPEEDLogger);
		((Control)tbpgSPEED).set_Location(new Point(4, 22));
		((Control)tbpgSPEED).set_Name("tbpgSPEED");
		((Control)tbpgSPEED).set_Size(new Size(688, 526));
		tbpgSPEED.set_TabIndex(5);
		((Control)tbpgSPEED).set_Text("SPEED Configuration");
		((ButtonBase)cmdSPEEDSaveLogger).set_FlatStyle((FlatStyle)3);
		((Control)cmdSPEEDSaveLogger).set_Location(new Point(200, 488));
		((Control)cmdSPEEDSaveLogger).set_Name("cmdSPEEDSaveLogger");
		((Control)cmdSPEEDSaveLogger).set_Size(new Size(136, 24));
		((Control)cmdSPEEDSaveLogger).set_TabIndex(36);
		((Control)cmdSPEEDSaveLogger).set_Text("SaveLoggerForAll");
		((Control)cmdSPEEDSaveLogger).add_Click((EventHandler)cmdSPEEDSaveLogger_Click);
		((Control)label41).set_ForeColor(Color.Red);
		((Control)label41).set_Location(new Point(40, 488));
		((Control)label41).set_Name("label41");
		((Control)label41).set_Size(new Size(112, 24));
		((Control)label41).set_TabIndex(34);
		((Control)label41).set_Text("*   Represents  Mandatory Fields");
		((Control)groupBox12).get_Controls().Add((Control)(object)label80);
		((Control)groupBox12).get_Controls().Add((Control)(object)txtSPEEDConfigProxyMethodParm);
		((Control)groupBox12).get_Controls().Add((Control)(object)label65);
		((Control)groupBox12).get_Controls().Add((Control)(object)label59);
		((Control)groupBox12).get_Controls().Add((Control)(object)label58);
		((Control)groupBox12).get_Controls().Add((Control)(object)label57);
		((Control)groupBox12).get_Controls().Add((Control)(object)label56);
		((Control)groupBox12).get_Controls().Add((Control)(object)label55);
		((Control)groupBox12).get_Controls().Add((Control)(object)label44);
		((Control)groupBox12).get_Controls().Add((Control)(object)label37);
		((Control)groupBox12).get_Controls().Add((Control)(object)txtSPEEDConfigURI);
		((Control)groupBox12).get_Controls().Add((Control)(object)chkSPEEDConfigDefault);
		((Control)groupBox12).get_Controls().Add((Control)(object)txtSPEEDConfigEnv);
		((Control)groupBox12).get_Controls().Add((Control)(object)label32);
		((Control)groupBox12).get_Controls().Add((Control)(object)cmdSPEEDConfigEdit);
		((Control)groupBox12).get_Controls().Add((Control)(object)label33);
		((Control)groupBox12).get_Controls().Add((Control)(object)txtSPEEDConfigMethodName);
		((Control)groupBox12).get_Controls().Add((Control)(object)cmdSPEEDConfigDelete);
		((Control)groupBox12).get_Controls().Add((Control)(object)cmdSPEEDConfigAdd);
		((Control)groupBox12).get_Controls().Add((Control)(object)label34);
		((Control)groupBox12).get_Controls().Add((Control)(object)label35);
		((Control)groupBox12).get_Controls().Add((Control)(object)txtSPEEDConfigProxyNameSpace);
		((Control)groupBox12).get_Controls().Add((Control)(object)txtSPEEDConfigTypeName);
		((Control)groupBox12).get_Controls().Add((Control)(object)lstSPEEDEnv);
		((Control)groupBox12).get_Controls().Add((Control)(object)cmdSPEEDConfigCancel);
		((Control)groupBox12).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)groupBox12).set_Location(new Point(8, 304));
		((Control)groupBox12).set_Name("groupBox12");
		((Control)groupBox12).set_Size(new Size(664, 176));
		((Control)groupBox12).set_TabIndex(14);
		groupBox12.set_TabStop(false);
		((Control)groupBox12).set_Text("SPEED Configuration Information");
		((Control)label80).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label80).set_ForeColor(Color.Red);
		((Control)label80).set_Location(new Point(464, 80));
		((Control)label80).set_Name("label80");
		((Control)label80).set_Size(new Size(8, 24));
		((Control)label80).set_TabIndex(42);
		((Control)label80).set_Text("*");
		label80.set_TextAlign((ContentAlignment)32);
		((Control)txtSPEEDConfigProxyMethodParm).set_Location(new Point(472, 80));
		((Control)txtSPEEDConfigProxyMethodParm).set_Name("txtSPEEDConfigProxyMethodParm");
		((Control)txtSPEEDConfigProxyMethodParm).set_Size(new Size(168, 20));
		((Control)txtSPEEDConfigProxyMethodParm).set_TabIndex(41);
		((Control)txtSPEEDConfigProxyMethodParm).set_Text("");
		((Control)label65).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label65).set_Location(new Point(392, 80));
		((Control)label65).set_Name("label65");
		((Control)label65).set_Size(new Size(80, 24));
		((Control)label65).set_TabIndex(40);
		((Control)label65).set_Text("Method Parameter");
		((Control)label59).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label59).set_ForeColor(Color.Red);
		((Control)label59).set_Location(new Point(216, 80));
		((Control)label59).set_Name("label59");
		((Control)label59).set_Size(new Size(8, 24));
		((Control)label59).set_TabIndex(39);
		((Control)label59).set_Text("*");
		label59.set_TextAlign((ContentAlignment)32);
		((Control)label58).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label58).set_ForeColor(Color.Red);
		((Control)label58).set_Location(new Point(216, 112));
		((Control)label58).set_Name("label58");
		((Control)label58).set_Size(new Size(8, 24));
		((Control)label58).set_TabIndex(38);
		((Control)label58).set_Text("*");
		label58.set_TextAlign((ContentAlignment)32);
		((Control)label57).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label57).set_ForeColor(Color.Red);
		((Control)label57).set_Location(new Point(464, 48));
		((Control)label57).set_Name("label57");
		((Control)label57).set_Size(new Size(8, 24));
		((Control)label57).set_TabIndex(37);
		((Control)label57).set_Text("*");
		label57.set_TextAlign((ContentAlignment)32);
		((Control)label56).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label56).set_ForeColor(Color.Red);
		((Control)label56).set_Location(new Point(216, 48));
		((Control)label56).set_Name("label56");
		((Control)label56).set_Size(new Size(8, 24));
		((Control)label56).set_TabIndex(36);
		((Control)label56).set_Text("*");
		label56.set_TextAlign((ContentAlignment)32);
		((Control)label55).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label55).set_ForeColor(Color.Red);
		((Control)label55).set_Location(new Point(216, 16));
		((Control)label55).set_Name("label55");
		((Control)label55).set_Size(new Size(8, 24));
		((Control)label55).set_TabIndex(35);
		((Control)label55).set_Text("*");
		label55.set_TextAlign((ContentAlignment)32);
		((Control)label44).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label44).set_ForeColor(Color.Brown);
		((Control)label44).set_Location(new Point(16, 136));
		((Control)label44).set_Name("label44");
		((Control)label44).set_Size(new Size(120, 32));
		((Control)label44).set_TabIndex(28);
		((Control)label44).set_Text("First Environment is Default ");
		((Control)label37).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label37).set_Location(new Point(144, 112));
		((Control)label37).set_Name("label37");
		((Control)label37).set_Size(new Size(40, 23));
		((Control)label37).set_TabIndex(13);
		((Control)label37).set_Text("URI");
		label37.set_TextAlign((ContentAlignment)16);
		((Control)txtSPEEDConfigURI).set_Enabled(false);
		((Control)txtSPEEDConfigURI).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtSPEEDConfigURI).set_Location(new Point(224, 112));
		((Control)txtSPEEDConfigURI).set_Name("txtSPEEDConfigURI");
		((Control)txtSPEEDConfigURI).set_Size(new Size(416, 20));
		((Control)txtSPEEDConfigURI).set_TabIndex(11);
		((Control)txtSPEEDConfigURI).set_Text("");
		chkSPEEDConfigDefault.set_Checked(true);
		chkSPEEDConfigDefault.set_CheckState((CheckState)1);
		((Control)chkSPEEDConfigDefault).set_Enabled(false);
		((Control)chkSPEEDConfigDefault).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)chkSPEEDConfigDefault).set_Location(new Point(472, 16));
		((Control)chkSPEEDConfigDefault).set_Name("chkSPEEDConfigDefault");
		((Control)chkSPEEDConfigDefault).set_Size(new Size(168, 24));
		((Control)chkSPEEDConfigDefault).set_TabIndex(7);
		((Control)chkSPEEDConfigDefault).set_Text("Check It If this is the Default");
		((Control)txtSPEEDConfigEnv).set_Location(new Point(224, 16));
		((Control)txtSPEEDConfigEnv).set_Name("txtSPEEDConfigEnv");
		((Control)txtSPEEDConfigEnv).set_Size(new Size(208, 20));
		((Control)txtSPEEDConfigEnv).set_TabIndex(6);
		((Control)txtSPEEDConfigEnv).set_Text("");
		((Control)label32).set_Location(new Point(144, 16));
		((Control)label32).set_Name("label32");
		((Control)label32).set_Size(new Size(80, 24));
		((Control)label32).set_TabIndex(10);
		((Control)label32).set_Text("SPEED Environment");
		((ButtonBase)cmdSPEEDConfigEdit).set_FlatStyle((FlatStyle)3);
		((Control)cmdSPEEDConfigEdit).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cmdSPEEDConfigEdit).set_Location(new Point(336, 144));
		((Control)cmdSPEEDConfigEdit).set_Name("cmdSPEEDConfigEdit");
		((Control)cmdSPEEDConfigEdit).set_TabIndex(13);
		((Control)cmdSPEEDConfigEdit).set_Text("Edit");
		((Control)cmdSPEEDConfigEdit).add_Click((EventHandler)cmdSPEEDConfigEdit_Click);
		((Control)label33).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label33).set_Location(new Point(392, 48));
		((Control)label33).set_Name("label33");
		((Control)label33).set_Size(new Size(72, 23));
		((Control)label33).set_TabIndex(8);
		((Control)label33).set_Text("MethodName");
		label33.set_TextAlign((ContentAlignment)16);
		((Control)txtSPEEDConfigMethodName).set_Enabled(false);
		((Control)txtSPEEDConfigMethodName).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtSPEEDConfigMethodName).set_Location(new Point(472, 48));
		((Control)txtSPEEDConfigMethodName).set_Name("txtSPEEDConfigMethodName");
		((Control)txtSPEEDConfigMethodName).set_Size(new Size(168, 22));
		((Control)txtSPEEDConfigMethodName).set_TabIndex(9);
		((Control)txtSPEEDConfigMethodName).set_Text("");
		((ButtonBase)cmdSPEEDConfigDelete).set_FlatStyle((FlatStyle)3);
		((Control)cmdSPEEDConfigDelete).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cmdSPEEDConfigDelete).set_Location(new Point(440, 144));
		((Control)cmdSPEEDConfigDelete).set_Name("cmdSPEEDConfigDelete");
		((Control)cmdSPEEDConfigDelete).set_TabIndex(14);
		((Control)cmdSPEEDConfigDelete).set_Text("Delete");
		((Control)cmdSPEEDConfigDelete).add_Click((EventHandler)cmdSPEEDConfigDelete_Click);
		((ButtonBase)cmdSPEEDConfigAdd).set_FlatStyle((FlatStyle)3);
		((Control)cmdSPEEDConfigAdd).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cmdSPEEDConfigAdd).set_Location(new Point(232, 144));
		((Control)cmdSPEEDConfigAdd).set_Name("cmdSPEEDConfigAdd");
		((Control)cmdSPEEDConfigAdd).set_TabIndex(12);
		((Control)cmdSPEEDConfigAdd).set_Text("Add");
		((Control)cmdSPEEDConfigAdd).add_Click((EventHandler)cmdSPEEDConfigAdd_Click);
		((Control)label34).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label34).set_Location(new Point(144, 80));
		((Control)label34).set_Name("label34");
		((Control)label34).set_Size(new Size(72, 23));
		((Control)label34).set_TabIndex(4);
		((Control)label34).set_Text("Proxy Name Space");
		label34.set_TextAlign((ContentAlignment)16);
		((Control)label35).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label35).set_Location(new Point(144, 48));
		((Control)label35).set_Name("label35");
		((Control)label35).set_Size(new Size(64, 23));
		((Control)label35).set_TabIndex(3);
		((Control)label35).set_Text("TypeName");
		label35.set_TextAlign((ContentAlignment)16);
		((Control)txtSPEEDConfigProxyNameSpace).set_Enabled(false);
		((Control)txtSPEEDConfigProxyNameSpace).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtSPEEDConfigProxyNameSpace).set_Location(new Point(224, 80));
		((Control)txtSPEEDConfigProxyNameSpace).set_Name("txtSPEEDConfigProxyNameSpace");
		((Control)txtSPEEDConfigProxyNameSpace).set_Size(new Size(144, 20));
		((Control)txtSPEEDConfigProxyNameSpace).set_TabIndex(10);
		((Control)txtSPEEDConfigProxyNameSpace).set_Text("");
		((Control)txtSPEEDConfigTypeName).set_Enabled(false);
		((Control)txtSPEEDConfigTypeName).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtSPEEDConfigTypeName).set_Location(new Point(224, 48));
		((Control)txtSPEEDConfigTypeName).set_Name("txtSPEEDConfigTypeName");
		((Control)txtSPEEDConfigTypeName).set_Size(new Size(144, 22));
		((Control)txtSPEEDConfigTypeName).set_TabIndex(8);
		((Control)txtSPEEDConfigTypeName).set_Text("");
		((Control)lstSPEEDEnv).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lstSPEEDEnv).set_Location(new Point(16, 24));
		((Control)lstSPEEDEnv).set_Name("lstSPEEDEnv");
		((Control)lstSPEEDEnv).set_Size(new Size(112, 95));
		((Control)lstSPEEDEnv).set_TabIndex(5);
		lstSPEEDEnv.add_SelectedIndexChanged((EventHandler)lstSPEEDConfigBackendEnv_SelectedIndexChanged);
		((ButtonBase)cmdSPEEDConfigCancel).set_FlatStyle((FlatStyle)3);
		((Control)cmdSPEEDConfigCancel).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cmdSPEEDConfigCancel).set_Location(new Point(536, 144));
		((Control)cmdSPEEDConfigCancel).set_Name("cmdSPEEDConfigCancel");
		((Control)cmdSPEEDConfigCancel).set_Size(new Size(72, 24));
		((Control)cmdSPEEDConfigCancel).set_TabIndex(15);
		((Control)cmdSPEEDConfigCancel).set_Text("Cancel");
		((Control)cmdSPEEDConfigCancel).add_Click((EventHandler)cmdSPEEDConfigCancel_Click);
		((ButtonBase)cmdSPEEDConfigExitApplication).set_FlatStyle((FlatStyle)3);
		((Control)cmdSPEEDConfigExitApplication).set_Location(new Point(496, 488));
		((Control)cmdSPEEDConfigExitApplication).set_Name("cmdSPEEDConfigExitApplication");
		((Control)cmdSPEEDConfigExitApplication).set_Size(new Size(104, 24));
		((Control)cmdSPEEDConfigExitApplication).set_TabIndex(17);
		((Control)cmdSPEEDConfigExitApplication).set_Text("Exit Application");
		((Control)cmdSPEEDConfigExitApplication).add_Click((EventHandler)cmdSPEEDConfigExitApplication_Click);
		((ButtonBase)cmdSPEEDConfigSaveToFile).set_FlatStyle((FlatStyle)3);
		((Control)cmdSPEEDConfigSaveToFile).set_Location(new Point(360, 488));
		((Control)cmdSPEEDConfigSaveToFile).set_Name("cmdSPEEDConfigSaveToFile");
		((Control)cmdSPEEDConfigSaveToFile).set_Size(new Size(112, 24));
		((Control)cmdSPEEDConfigSaveToFile).set_TabIndex(16);
		((Control)cmdSPEEDConfigSaveToFile).set_Text("SaveToFile");
		((Control)cmdSPEEDConfigSaveToFile).add_Click((EventHandler)cmdSPEEDConfigSaveToFile_Click);
		((Control)groupBox10).get_Controls().Add((Control)(object)txtSPEEDConfigReplyXsl);
		((Control)groupBox10).get_Controls().Add((Control)(object)label28);
		((Control)groupBox10).get_Controls().Add((Control)(object)txtSPEEDConfigRequestXsl);
		((Control)groupBox10).get_Controls().Add((Control)(object)label29);
		((Control)groupBox10).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)groupBox10).set_Location(new Point(8, 240));
		((Control)groupBox10).set_Name("groupBox10");
		((Control)groupBox10).set_Size(new Size(656, 56));
		((Control)groupBox10).set_TabIndex(11);
		groupBox10.set_TabStop(false);
		((Control)groupBox10).set_Text("XSL Information");
		((Control)txtSPEEDConfigReplyXsl).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtSPEEDConfigReplyXsl).set_Location(new Point(400, 24));
		((Control)txtSPEEDConfigReplyXsl).set_Name("txtSPEEDConfigReplyXsl");
		((Control)txtSPEEDConfigReplyXsl).set_Size(new Size(224, 20));
		((Control)txtSPEEDConfigReplyXsl).set_TabIndex(4);
		((Control)txtSPEEDConfigReplyXsl).set_Text("");
		((Control)txtSPEEDConfigReplyXsl).add_TextChanged((EventHandler)txtSPEEDConfigReplyXsl_TextChanged);
		((Control)label28).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label28).set_Location(new Point(352, 24));
		((Control)label28).set_Name("label28");
		((Control)label28).set_Size(new Size(40, 23));
		((Control)label28).set_TabIndex(3);
		((Control)label28).set_Text("Reply");
		label28.set_TextAlign((ContentAlignment)16);
		((Control)txtSPEEDConfigRequestXsl).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtSPEEDConfigRequestXsl).set_Location(new Point(96, 24));
		((Control)txtSPEEDConfigRequestXsl).set_Name("txtSPEEDConfigRequestXsl");
		((Control)txtSPEEDConfigRequestXsl).set_Size(new Size(224, 20));
		((Control)txtSPEEDConfigRequestXsl).set_TabIndex(3);
		((Control)txtSPEEDConfigRequestXsl).set_Text("");
		((Control)txtSPEEDConfigRequestXsl).add_TextChanged((EventHandler)txtSPEEDConfigRequestXsl_TextChanged);
		((Control)label29).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label29).set_Location(new Point(16, 24));
		((Control)label29).set_Name("label29");
		((Control)label29).set_Size(new Size(80, 23));
		((Control)label29).set_TabIndex(1);
		((Control)label29).set_Text("Request");
		label29.set_TextAlign((ContentAlignment)16);
		((Control)groupBox11).get_Controls().Add((Control)(object)label30);
		((Control)groupBox11).get_Controls().Add((Control)(object)txtSPEEDConfigRetryIntervals);
		((Control)groupBox11).get_Controls().Add((Control)(object)label31);
		((Control)groupBox11).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)groupBox11).set_Location(new Point(8, 168));
		((Control)groupBox11).set_Name("groupBox11");
		((Control)groupBox11).set_Size(new Size(656, 64));
		((Control)groupBox11).set_TabIndex(10);
		groupBox11.set_TabStop(false);
		((Control)groupBox11).set_Text("Retry Parameter");
		((Control)label30).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label30).set_ForeColor(Color.Red);
		((Control)label30).set_Location(new Point(8, 48));
		((Control)label30).set_Name("label30");
		((Control)label30).set_Size(new Size(232, 16));
		((Control)label30).set_TabIndex(33);
		((Control)label30).set_Text("ex: 5000 or 6000,5000 or 4000,3000,5000, ...");
		((Control)txtSPEEDConfigRetryIntervals).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtSPEEDConfigRetryIntervals).set_Location(new Point(248, 24));
		((Control)txtSPEEDConfigRetryIntervals).set_Name("txtSPEEDConfigRetryIntervals");
		((Control)txtSPEEDConfigRetryIntervals).set_Size(new Size(160, 20));
		((Control)txtSPEEDConfigRetryIntervals).set_TabIndex(2);
		((Control)txtSPEEDConfigRetryIntervals).set_Text("");
		((Control)txtSPEEDConfigRetryIntervals).add_TextChanged((EventHandler)txtSPEEDConfigRetryIntervals_TextChanged);
		((Control)label31).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label31).set_Location(new Point(8, 24));
		((Control)label31).set_Name("label31");
		((Control)label31).set_Size(new Size(136, 23));
		((Control)label31).set_TabIndex(3);
		((Control)label31).set_Text("Retry Intervals in milliSec");
		label31.set_TextAlign((ContentAlignment)16);
		SPEEDLogger.set_IsEditMode(false);
		((Control)SPEEDLogger).set_Location(new Point(0, 0));
		((Control)SPEEDLogger).set_Name("SPEEDLogger");
		((Control)SPEEDLogger).set_Size(new Size(704, 176));
		((Control)SPEEDLogger).set_TabIndex(0);
		((Control)tbpgWSInterface).get_Controls().Add((Control)(object)cmdWSConfigSaveLogger);
		((Control)tbpgWSInterface).get_Controls().Add((Control)(object)WSLogger);
		((Control)tbpgWSInterface).get_Controls().Add((Control)(object)groupBox1);
		((Control)tbpgWSInterface).get_Controls().Add((Control)(object)cmdWSConfigAdvancedOperation);
		((Control)tbpgWSInterface).get_Controls().Add((Control)(object)cmdWSConfigAppExit);
		((Control)tbpgWSInterface).get_Controls().Add((Control)(object)cmdWSConfigFinalSaveTofile);
		((Control)tbpgWSInterface).get_Controls().Add((Control)(object)grpBoxBackEndEnvironments);
		((Control)tbpgWSInterface).get_Controls().Add((Control)(object)label10);
		((Control)tbpgWSInterface).set_Location(new Point(4, 22));
		((Control)tbpgWSInterface).set_Name("tbpgWSInterface");
		((Control)tbpgWSInterface).set_Size(new Size(688, 526));
		tbpgWSInterface.set_TabIndex(1);
		((Control)tbpgWSInterface).set_Text(" WSConfiguration ");
		((ButtonBase)cmdWSConfigSaveLogger).set_FlatStyle((FlatStyle)3);
		((Control)cmdWSConfigSaveLogger).set_Location(new Point(168, 496));
		((Control)cmdWSConfigSaveLogger).set_Name("cmdWSConfigSaveLogger");
		((Control)cmdWSConfigSaveLogger).set_Size(new Size(120, 24));
		((Control)cmdWSConfigSaveLogger).set_TabIndex(34);
		((Control)cmdWSConfigSaveLogger).set_Text("SaveLoggerToAll");
		((Control)cmdWSConfigSaveLogger).add_Click((EventHandler)cmdWSConfigSaveLogger_Click);
		WSLogger.set_IsEditMode(false);
		((Control)WSLogger).set_Location(new Point(0, 0));
		((Control)WSLogger).set_Name("WSLogger");
		((Control)WSLogger).set_Size(new Size(704, 160));
		((Control)WSLogger).set_TabIndex(11);
		((Control)groupBox1).get_Controls().Add((Control)(object)label46);
		((Control)groupBox1).get_Controls().Add((Control)(object)txtWSConfigServiceName);
		((Control)groupBox1).get_Controls().Add((Control)(object)lblWSConfigServiceName);
		((Control)groupBox1).get_Controls().Add((Control)(object)txtWSConfigReplyXSL);
		((Control)groupBox1).get_Controls().Add((Control)(object)lblWSConfigReplyXSL);
		((Control)groupBox1).get_Controls().Add((Control)(object)txtWSConfigRequestXSL);
		((Control)groupBox1).get_Controls().Add((Control)(object)lblWSConfigRequestXSL);
		((Control)groupBox1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)groupBox1).set_Location(new Point(16, 160));
		((Control)groupBox1).set_Name("groupBox1");
		((Control)groupBox1).set_Size(new Size(656, 64));
		((Control)groupBox1).set_TabIndex(10);
		groupBox1.set_TabStop(false);
		((Control)groupBox1).set_Text("Other Information");
		((Control)label46).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label46).set_ForeColor(Color.Red);
		((Control)label46).set_Location(new Point(56, 24));
		((Control)label46).set_Name("label46");
		((Control)label46).set_Size(new Size(8, 24));
		((Control)label46).set_TabIndex(35);
		((Control)label46).set_Text("*");
		label46.set_TextAlign((ContentAlignment)32);
		((Control)txtWSConfigServiceName).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtWSConfigServiceName).set_Location(new Point(64, 24));
		((Control)txtWSConfigServiceName).set_Name("txtWSConfigServiceName");
		((Control)txtWSConfigServiceName).set_Size(new Size(144, 20));
		((Control)txtWSConfigServiceName).set_TabIndex(2);
		((Control)txtWSConfigServiceName).set_Text("");
		((Control)txtWSConfigServiceName).add_TextChanged((EventHandler)txtWSConfigServiceName_TextChanged);
		((Control)lblWSConfigServiceName).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblWSConfigServiceName).set_Location(new Point(8, 24));
		((Control)lblWSConfigServiceName).set_Name("lblWSConfigServiceName");
		((Control)lblWSConfigServiceName).set_Size(new Size(48, 24));
		((Control)lblWSConfigServiceName).set_TabIndex(5);
		((Control)lblWSConfigServiceName).set_Text("Service Name");
		lblWSConfigServiceName.set_TextAlign((ContentAlignment)16);
		((Control)txtWSConfigReplyXSL).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtWSConfigReplyXSL).set_Location(new Point(496, 24));
		((Control)txtWSConfigReplyXSL).set_Name("txtWSConfigReplyXSL");
		((Control)txtWSConfigReplyXSL).set_Size(new Size(144, 20));
		((Control)txtWSConfigReplyXSL).set_TabIndex(4);
		((Control)txtWSConfigReplyXSL).set_Text("");
		((Control)txtWSConfigReplyXSL).add_TextChanged((EventHandler)txtWSConfigReplyXSL_TextChanged);
		((Control)lblWSConfigReplyXSL).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblWSConfigReplyXSL).set_Location(new Point(456, 24));
		((Control)lblWSConfigReplyXSL).set_Name("lblWSConfigReplyXSL");
		((Control)lblWSConfigReplyXSL).set_Size(new Size(40, 23));
		((Control)lblWSConfigReplyXSL).set_TabIndex(3);
		((Control)lblWSConfigReplyXSL).set_Text("Reply XSL");
		lblWSConfigReplyXSL.set_TextAlign((ContentAlignment)16);
		((Control)txtWSConfigRequestXSL).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtWSConfigRequestXSL).set_Location(new Point(296, 24));
		((Control)txtWSConfigRequestXSL).set_Name("txtWSConfigRequestXSL");
		((Control)txtWSConfigRequestXSL).set_Size(new Size(144, 20));
		((Control)txtWSConfigRequestXSL).set_TabIndex(3);
		((Control)txtWSConfigRequestXSL).set_Text("");
		((Control)txtWSConfigRequestXSL).add_TextChanged((EventHandler)txtWSConfigRequestXSL_TextChanged);
		((Control)lblWSConfigRequestXSL).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblWSConfigRequestXSL).set_Location(new Point(240, 24));
		((Control)lblWSConfigRequestXSL).set_Name("lblWSConfigRequestXSL");
		((Control)lblWSConfigRequestXSL).set_Size(new Size(48, 24));
		((Control)lblWSConfigRequestXSL).set_TabIndex(1);
		((Control)lblWSConfigRequestXSL).set_Text("Request XSL");
		lblWSConfigRequestXSL.set_TextAlign((ContentAlignment)16);
		((ButtonBase)cmdWSConfigAdvancedOperation).set_FlatStyle((FlatStyle)3);
		((Control)cmdWSConfigAdvancedOperation).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cmdWSConfigAdvancedOperation).set_ForeColor(Color.FromArgb(192, 0, 0));
		((Control)cmdWSConfigAdvancedOperation).set_Location(new Point(328, 496));
		((Control)cmdWSConfigAdvancedOperation).set_Name("cmdWSConfigAdvancedOperation");
		((Control)cmdWSConfigAdvancedOperation).set_Size(new Size(96, 24));
		((Control)cmdWSConfigAdvancedOperation).set_TabIndex(19);
		((Control)cmdWSConfigAdvancedOperation).set_Text("Advanced");
		((Control)cmdWSConfigAdvancedOperation).add_Click((EventHandler)cmdWSConfigAdvancedOperation_Click);
		((ButtonBase)cmdWSConfigAppExit).set_FlatStyle((FlatStyle)3);
		((Control)cmdWSConfigAppExit).set_Location(new Point(568, 496));
		((Control)cmdWSConfigAppExit).set_Name("cmdWSConfigAppExit");
		((Control)cmdWSConfigAppExit).set_Size(new Size(96, 24));
		((Control)cmdWSConfigAppExit).set_TabIndex(21);
		((Control)cmdWSConfigAppExit).set_Text("Exit Application");
		((Control)cmdWSConfigAppExit).add_Click((EventHandler)cmdWSConfigAppExit_Click);
		((ButtonBase)cmdWSConfigFinalSaveTofile).set_FlatStyle((FlatStyle)3);
		((Control)cmdWSConfigFinalSaveTofile).set_Location(new Point(448, 496));
		((Control)cmdWSConfigFinalSaveTofile).set_Name("cmdWSConfigFinalSaveTofile");
		((Control)cmdWSConfigFinalSaveTofile).set_Size(new Size(96, 24));
		((Control)cmdWSConfigFinalSaveTofile).set_TabIndex(20);
		((Control)cmdWSConfigFinalSaveTofile).set_Text("SaveToFile");
		((Control)cmdWSConfigFinalSaveTofile).add_Click((EventHandler)cmdWSConfigFinalSaveTofile_Click);
		((Control)tbpgGlenda).get_Controls().Add((Control)(object)cmdGlendaSaveLogger);
		((Control)tbpgGlenda).get_Controls().Add((Control)(object)label40);
		((Control)tbpgGlenda).get_Controls().Add((Control)(object)cmdGlendaConfigExitApplication);
		((Control)tbpgGlenda).get_Controls().Add((Control)(object)cmdGlendaConfigSaveToFile);
		((Control)tbpgGlenda).get_Controls().Add((Control)(object)groupBox4);
		((Control)tbpgGlenda).get_Controls().Add((Control)(object)groupBox5);
		((Control)tbpgGlenda).get_Controls().Add((Control)(object)groupBox6);
		((Control)tbpgGlenda).get_Controls().Add((Control)(object)GlendaLogger);
		((Control)tbpgGlenda).set_Location(new Point(4, 22));
		((Control)tbpgGlenda).set_Name("tbpgGlenda");
		((Control)tbpgGlenda).set_Size(new Size(688, 526));
		tbpgGlenda.set_TabIndex(4);
		((Control)tbpgGlenda).set_Text("Glenda Configuration");
		((ButtonBase)cmdGlendaSaveLogger).set_FlatStyle((FlatStyle)3);
		((Control)cmdGlendaSaveLogger).set_Location(new Point(200, 488));
		((Control)cmdGlendaSaveLogger).set_Name("cmdGlendaSaveLogger");
		((Control)cmdGlendaSaveLogger).set_Size(new Size(136, 24));
		((Control)cmdGlendaSaveLogger).set_TabIndex(36);
		((Control)cmdGlendaSaveLogger).set_Text("SaveLoggerForAll");
		((Control)cmdGlendaSaveLogger).add_Click((EventHandler)cmdGlendaSaveLogger_Click);
		((Control)label40).set_ForeColor(Color.Red);
		((Control)label40).set_Location(new Point(40, 480));
		((Control)label40).set_Name("label40");
		((Control)label40).set_Size(new Size(112, 24));
		((Control)label40).set_TabIndex(34);
		((Control)label40).set_Text("*   Represents  Mandatory Fields");
		((ButtonBase)cmdGlendaConfigExitApplication).set_FlatStyle((FlatStyle)3);
		((Control)cmdGlendaConfigExitApplication).set_Location(new Point(504, 488));
		((Control)cmdGlendaConfigExitApplication).set_Name("cmdGlendaConfigExitApplication");
		((Control)cmdGlendaConfigExitApplication).set_Size(new Size(112, 24));
		((Control)cmdGlendaConfigExitApplication).set_TabIndex(16);
		((Control)cmdGlendaConfigExitApplication).set_Text("Exit Application");
		((Control)cmdGlendaConfigExitApplication).add_Click((EventHandler)cmdGlendaConfigExitApplication_Click);
		((ButtonBase)cmdGlendaConfigSaveToFile).set_FlatStyle((FlatStyle)3);
		((Control)cmdGlendaConfigSaveToFile).set_Location(new Point(360, 488));
		((Control)cmdGlendaConfigSaveToFile).set_Name("cmdGlendaConfigSaveToFile");
		((Control)cmdGlendaConfigSaveToFile).set_Size(new Size(112, 24));
		((Control)cmdGlendaConfigSaveToFile).set_TabIndex(15);
		((Control)cmdGlendaConfigSaveToFile).set_Text("SaveToFile");
		((Control)cmdGlendaConfigSaveToFile).add_Click((EventHandler)cmdGlendaConfigSaveToFile_Click);
		((Control)groupBox4).get_Controls().Add((Control)(object)txtGlendaConfigReplyXsl);
		((Control)groupBox4).get_Controls().Add((Control)(object)label13);
		((Control)groupBox4).get_Controls().Add((Control)(object)txtGlendaConfigRequestXsl);
		((Control)groupBox4).get_Controls().Add((Control)(object)label15);
		((Control)groupBox4).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)groupBox4).set_Location(new Point(8, 240));
		((Control)groupBox4).set_Name("groupBox4");
		((Control)groupBox4).set_Size(new Size(656, 56));
		((Control)groupBox4).set_TabIndex(11);
		groupBox4.set_TabStop(false);
		((Control)groupBox4).set_Text("XSL Information");
		((Control)txtGlendaConfigReplyXsl).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtGlendaConfigReplyXsl).set_Location(new Point(400, 24));
		((Control)txtGlendaConfigReplyXsl).set_Name("txtGlendaConfigReplyXsl");
		((Control)txtGlendaConfigReplyXsl).set_Size(new Size(224, 20));
		((Control)txtGlendaConfigReplyXsl).set_TabIndex(4);
		((Control)txtGlendaConfigReplyXsl).set_Text("");
		((Control)txtGlendaConfigReplyXsl).add_TextChanged((EventHandler)txtGlendaConfigReplyXsl_TextChanged);
		((Control)label13).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label13).set_Location(new Point(352, 24));
		((Control)label13).set_Name("label13");
		((Control)label13).set_Size(new Size(40, 23));
		((Control)label13).set_TabIndex(3);
		((Control)label13).set_Text("Reply");
		label13.set_TextAlign((ContentAlignment)16);
		((Control)txtGlendaConfigRequestXsl).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtGlendaConfigRequestXsl).set_Location(new Point(96, 24));
		((Control)txtGlendaConfigRequestXsl).set_Name("txtGlendaConfigRequestXsl");
		((Control)txtGlendaConfigRequestXsl).set_Size(new Size(224, 20));
		((Control)txtGlendaConfigRequestXsl).set_TabIndex(3);
		((Control)txtGlendaConfigRequestXsl).set_Text("");
		((Control)txtGlendaConfigRequestXsl).add_TextChanged((EventHandler)txtGlendaConfigRequestXsl_TextChanged);
		((Control)label15).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label15).set_Location(new Point(16, 24));
		((Control)label15).set_Name("label15");
		((Control)label15).set_Size(new Size(80, 23));
		((Control)label15).set_TabIndex(1);
		((Control)label15).set_Text("Request");
		label15.set_TextAlign((ContentAlignment)16);
		((Control)groupBox5).get_Controls().Add((Control)(object)label16);
		((Control)groupBox5).get_Controls().Add((Control)(object)txtGlendaConfigRetryIntervals);
		((Control)groupBox5).get_Controls().Add((Control)(object)label17);
		((Control)groupBox5).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)groupBox5).set_Location(new Point(8, 168));
		((Control)groupBox5).set_Name("groupBox5");
		((Control)groupBox5).set_Size(new Size(656, 64));
		((Control)groupBox5).set_TabIndex(10);
		groupBox5.set_TabStop(false);
		((Control)groupBox5).set_Text("Retry Parameter");
		((Control)label16).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label16).set_ForeColor(Color.Red);
		((Control)label16).set_Location(new Point(8, 48));
		((Control)label16).set_Name("label16");
		((Control)label16).set_Size(new Size(232, 16));
		((Control)label16).set_TabIndex(33);
		((Control)label16).set_Text("ex: 5000 or 6000,5000 or 4000,3000,5000, ...");
		((Control)txtGlendaConfigRetryIntervals).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtGlendaConfigRetryIntervals).set_Location(new Point(248, 24));
		((Control)txtGlendaConfigRetryIntervals).set_Name("txtGlendaConfigRetryIntervals");
		((Control)txtGlendaConfigRetryIntervals).set_Size(new Size(160, 20));
		((Control)txtGlendaConfigRetryIntervals).set_TabIndex(2);
		((Control)txtGlendaConfigRetryIntervals).set_Text("");
		((Control)label17).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label17).set_Location(new Point(8, 24));
		((Control)label17).set_Name("label17");
		((Control)label17).set_Size(new Size(136, 23));
		((Control)label17).set_TabIndex(3);
		((Control)label17).set_Text("Retry Intervals in milliSec");
		label17.set_TextAlign((ContentAlignment)16);
		((Control)groupBox6).get_Controls().Add((Control)(object)label54);
		((Control)groupBox6).get_Controls().Add((Control)(object)label53);
		((Control)groupBox6).get_Controls().Add((Control)(object)label52);
		((Control)groupBox6).get_Controls().Add((Control)(object)label51);
		((Control)groupBox6).get_Controls().Add((Control)(object)label43);
		((Control)groupBox6).get_Controls().Add((Control)(object)chkGlendaConfigDefault);
		((Control)groupBox6).get_Controls().Add((Control)(object)txtGlendaConfigEnv);
		((Control)groupBox6).get_Controls().Add((Control)(object)lblGlendaConfigEnv);
		((Control)groupBox6).get_Controls().Add((Control)(object)cmdGlendaConfigEdit);
		((Control)groupBox6).get_Controls().Add((Control)(object)label18);
		((Control)groupBox6).get_Controls().Add((Control)(object)txtGlendaConfigMethodName);
		((Control)groupBox6).get_Controls().Add((Control)(object)cmdGlendaConfigDelete);
		((Control)groupBox6).get_Controls().Add((Control)(object)cmdGlendaConfigAdd);
		((Control)groupBox6).get_Controls().Add((Control)(object)label19);
		((Control)groupBox6).get_Controls().Add((Control)(object)label20);
		((Control)groupBox6).get_Controls().Add((Control)(object)txtGlendaConfigClassID);
		((Control)groupBox6).get_Controls().Add((Control)(object)txtGlendaConfigServerName);
		((Control)groupBox6).get_Controls().Add((Control)(object)lstGlendaEnv);
		((Control)groupBox6).get_Controls().Add((Control)(object)cmdGlendaConfigCancel);
		((Control)groupBox6).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)groupBox6).set_Location(new Point(8, 296));
		((Control)groupBox6).set_Name("groupBox6");
		((Control)groupBox6).set_Size(new Size(664, 176));
		((Control)groupBox6).set_TabIndex(9);
		groupBox6.set_TabStop(false);
		((Control)groupBox6).set_Text("Glenda Configuration Information");
		((Control)label54).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label54).set_ForeColor(Color.Red);
		((Control)label54).set_Location(new Point(216, 104));
		((Control)label54).set_Name("label54");
		((Control)label54).set_Size(new Size(8, 24));
		((Control)label54).set_TabIndex(38);
		((Control)label54).set_Text("*");
		label54.set_TextAlign((ContentAlignment)32);
		((Control)label53).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label53).set_ForeColor(Color.Red);
		((Control)label53).set_Location(new Point(480, 64));
		((Control)label53).set_Name("label53");
		((Control)label53).set_Size(new Size(8, 24));
		((Control)label53).set_TabIndex(37);
		((Control)label53).set_Text("*");
		label53.set_TextAlign((ContentAlignment)32);
		((Control)label52).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label52).set_ForeColor(Color.Red);
		((Control)label52).set_Location(new Point(216, 64));
		((Control)label52).set_Name("label52");
		((Control)label52).set_Size(new Size(8, 24));
		((Control)label52).set_TabIndex(36);
		((Control)label52).set_Text("*");
		label52.set_TextAlign((ContentAlignment)32);
		((Control)label51).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label51).set_ForeColor(Color.Red);
		((Control)label51).set_Location(new Point(216, 32));
		((Control)label51).set_Name("label51");
		((Control)label51).set_Size(new Size(8, 24));
		((Control)label51).set_TabIndex(35);
		((Control)label51).set_Text("*");
		label51.set_TextAlign((ContentAlignment)32);
		((Control)label43).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label43).set_ForeColor(Color.Brown);
		((Control)label43).set_Location(new Point(16, 136));
		((Control)label43).set_Name("label43");
		((Control)label43).set_Size(new Size(120, 32));
		((Control)label43).set_TabIndex(28);
		((Control)label43).set_Text("First Environment is Default ");
		chkGlendaConfigDefault.set_Checked(true);
		chkGlendaConfigDefault.set_CheckState((CheckState)1);
		((Control)chkGlendaConfigDefault).set_Enabled(false);
		((Control)chkGlendaConfigDefault).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)chkGlendaConfigDefault).set_Location(new Point(472, 32));
		((Control)chkGlendaConfigDefault).set_Name("chkGlendaConfigDefault");
		((Control)chkGlendaConfigDefault).set_Size(new Size(168, 24));
		((Control)chkGlendaConfigDefault).set_TabIndex(7);
		((Control)chkGlendaConfigDefault).set_Text("Check It If this is the Default");
		((Control)txtGlendaConfigEnv).set_Location(new Point(224, 32));
		((Control)txtGlendaConfigEnv).set_Name("txtGlendaConfigEnv");
		((Control)txtGlendaConfigEnv).set_Size(new Size(208, 20));
		((Control)txtGlendaConfigEnv).set_TabIndex(6);
		((Control)txtGlendaConfigEnv).set_Text("");
		((Control)lblGlendaConfigEnv).set_Location(new Point(144, 32));
		((Control)lblGlendaConfigEnv).set_Name("lblGlendaConfigEnv");
		((Control)lblGlendaConfigEnv).set_Size(new Size(80, 24));
		((Control)lblGlendaConfigEnv).set_TabIndex(10);
		((Control)lblGlendaConfigEnv).set_Text("Glenda Environment");
		((ButtonBase)cmdGlendaConfigEdit).set_FlatStyle((FlatStyle)3);
		((Control)cmdGlendaConfigEdit).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cmdGlendaConfigEdit).set_Location(new Point(336, 144));
		((Control)cmdGlendaConfigEdit).set_Name("cmdGlendaConfigEdit");
		((Control)cmdGlendaConfigEdit).set_TabIndex(12);
		((Control)cmdGlendaConfigEdit).set_Text("Edit");
		((Control)cmdGlendaConfigEdit).add_Click((EventHandler)cmdGlendaConfigEdit_Click);
		((Control)label18).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label18).set_Location(new Point(408, 64));
		((Control)label18).set_Name("label18");
		((Control)label18).set_Size(new Size(72, 23));
		((Control)label18).set_TabIndex(8);
		((Control)label18).set_Text("MethodName");
		label18.set_TextAlign((ContentAlignment)16);
		((Control)txtGlendaConfigMethodName).set_Enabled(false);
		((Control)txtGlendaConfigMethodName).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtGlendaConfigMethodName).set_Location(new Point(488, 64));
		((Control)txtGlendaConfigMethodName).set_Name("txtGlendaConfigMethodName");
		((Control)txtGlendaConfigMethodName).set_Size(new Size(152, 22));
		((Control)txtGlendaConfigMethodName).set_TabIndex(9);
		((Control)txtGlendaConfigMethodName).set_Text("");
		((ButtonBase)cmdGlendaConfigDelete).set_FlatStyle((FlatStyle)3);
		((Control)cmdGlendaConfigDelete).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cmdGlendaConfigDelete).set_Location(new Point(440, 144));
		((Control)cmdGlendaConfigDelete).set_Name("cmdGlendaConfigDelete");
		((Control)cmdGlendaConfigDelete).set_TabIndex(13);
		((Control)cmdGlendaConfigDelete).set_Text("Delete");
		((Control)cmdGlendaConfigDelete).add_Click((EventHandler)cmdGlendaConfigDelete_Click);
		((ButtonBase)cmdGlendaConfigAdd).set_FlatStyle((FlatStyle)3);
		((Control)cmdGlendaConfigAdd).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cmdGlendaConfigAdd).set_Location(new Point(232, 144));
		((Control)cmdGlendaConfigAdd).set_Name("cmdGlendaConfigAdd");
		((Control)cmdGlendaConfigAdd).set_TabIndex(11);
		((Control)cmdGlendaConfigAdd).set_Text("Add");
		((Control)cmdGlendaConfigAdd).add_Click((EventHandler)cmdGlendaConfigAdd_Click);
		((Control)label19).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label19).set_Location(new Point(144, 104));
		((Control)label19).set_Name("label19");
		((Control)label19).set_Size(new Size(80, 23));
		((Control)label19).set_TabIndex(4);
		((Control)label19).set_Text("ClassID");
		label19.set_TextAlign((ContentAlignment)16);
		((Control)label20).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label20).set_Location(new Point(144, 64));
		((Control)label20).set_Name("label20");
		((Control)label20).set_Size(new Size(72, 23));
		((Control)label20).set_TabIndex(3);
		((Control)label20).set_Text("ServerName");
		label20.set_TextAlign((ContentAlignment)16);
		((Control)txtGlendaConfigClassID).set_Enabled(false);
		((Control)txtGlendaConfigClassID).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtGlendaConfigClassID).set_Location(new Point(224, 104));
		((Control)txtGlendaConfigClassID).set_Name("txtGlendaConfigClassID");
		((Control)txtGlendaConfigClassID).set_Size(new Size(416, 20));
		((Control)txtGlendaConfigClassID).set_TabIndex(10);
		((Control)txtGlendaConfigClassID).set_Text("");
		((Control)txtGlendaConfigServerName).set_Enabled(false);
		((Control)txtGlendaConfigServerName).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtGlendaConfigServerName).set_Location(new Point(224, 64));
		((Control)txtGlendaConfigServerName).set_Name("txtGlendaConfigServerName");
		((Control)txtGlendaConfigServerName).set_Size(new Size(176, 22));
		((Control)txtGlendaConfigServerName).set_TabIndex(8);
		((Control)txtGlendaConfigServerName).set_Text("");
		((Control)lstGlendaEnv).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lstGlendaEnv).set_Location(new Point(16, 32));
		((Control)lstGlendaEnv).set_Name("lstGlendaEnv");
		((Control)lstGlendaEnv).set_Size(new Size(112, 95));
		((Control)lstGlendaEnv).set_TabIndex(5);
		lstGlendaEnv.add_SelectedIndexChanged((EventHandler)lstGlendaEnv_SelectedIndexChanged);
		((ButtonBase)cmdGlendaConfigCancel).set_FlatStyle((FlatStyle)3);
		((Control)cmdGlendaConfigCancel).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cmdGlendaConfigCancel).set_Location(new Point(536, 144));
		((Control)cmdGlendaConfigCancel).set_Name("cmdGlendaConfigCancel");
		((Control)cmdGlendaConfigCancel).set_Size(new Size(72, 24));
		((Control)cmdGlendaConfigCancel).set_TabIndex(14);
		((Control)cmdGlendaConfigCancel).set_Text("Cancel");
		((Control)cmdGlendaConfigCancel).add_Click((EventHandler)cmdGlendaConfigCancel_Click);
		GlendaLogger.set_IsEditMode(false);
		((Control)GlendaLogger).set_Location(new Point(0, 0));
		((Control)GlendaLogger).set_Name("GlendaLogger");
		((Control)GlendaLogger).set_Size(new Size(704, 176));
		((Control)GlendaLogger).set_TabIndex(0);
		((Control)tbpgIRE).get_Controls().Add((Control)(object)cmdIREConfigSaveLogger);
		((Control)tbpgIRE).get_Controls().Add((Control)(object)label42);
		((Control)tbpgIRE).get_Controls().Add((Control)(object)groupBox9);
		((Control)tbpgIRE).get_Controls().Add((Control)(object)cmdIREConfigExitApplication);
		((Control)tbpgIRE).get_Controls().Add((Control)(object)cmdIREConfigSaveToFile);
		((Control)tbpgIRE).get_Controls().Add((Control)(object)groupBox7);
		((Control)tbpgIRE).get_Controls().Add((Control)(object)groupBox8);
		((Control)tbpgIRE).get_Controls().Add((Control)(object)IRELogger);
		((Control)tbpgIRE).set_Location(new Point(4, 22));
		((Control)tbpgIRE).set_Name("tbpgIRE");
		((Control)tbpgIRE).set_Size(new Size(688, 526));
		tbpgIRE.set_TabIndex(6);
		((Control)tbpgIRE).set_Text("IRE Configuration");
		((ButtonBase)cmdIREConfigSaveLogger).set_FlatStyle((FlatStyle)3);
		((Control)cmdIREConfigSaveLogger).set_Location(new Point(200, 488));
		((Control)cmdIREConfigSaveLogger).set_Name("cmdIREConfigSaveLogger");
		((Control)cmdIREConfigSaveLogger).set_Size(new Size(136, 24));
		((Control)cmdIREConfigSaveLogger).set_TabIndex(35);
		((Control)cmdIREConfigSaveLogger).set_Text("SaveLoggerForAll");
		((Control)cmdIREConfigSaveLogger).add_Click((EventHandler)cmdIREConfigSaveLogger_Click);
		((Control)label42).set_ForeColor(Color.Red);
		((Control)label42).set_Location(new Point(32, 488));
		((Control)label42).set_Name("label42");
		((Control)label42).set_Size(new Size(112, 24));
		((Control)label42).set_TabIndex(34);
		((Control)label42).set_Text("*   Represents  Mandatory Fields");
		((Control)groupBox9).get_Controls().Add((Control)(object)label63);
		((Control)groupBox9).get_Controls().Add((Control)(object)label62);
		((Control)groupBox9).get_Controls().Add((Control)(object)label61);
		((Control)groupBox9).get_Controls().Add((Control)(object)label60);
		((Control)groupBox9).get_Controls().Add((Control)(object)label45);
		((Control)groupBox9).get_Controls().Add((Control)(object)chkIREConfigDefault);
		((Control)groupBox9).get_Controls().Add((Control)(object)txtIREConfigEnv);
		((Control)groupBox9).get_Controls().Add((Control)(object)label25);
		((Control)groupBox9).get_Controls().Add((Control)(object)cmdIREConfigEdit);
		((Control)groupBox9).get_Controls().Add((Control)(object)label26);
		((Control)groupBox9).get_Controls().Add((Control)(object)txtIREConfigMethodName);
		((Control)groupBox9).get_Controls().Add((Control)(object)cmdIREConfigDelete);
		((Control)groupBox9).get_Controls().Add((Control)(object)cmdIREConfigAdd);
		((Control)groupBox9).get_Controls().Add((Control)(object)label27);
		((Control)groupBox9).get_Controls().Add((Control)(object)label36);
		((Control)groupBox9).get_Controls().Add((Control)(object)txtIREConfigClassID);
		((Control)groupBox9).get_Controls().Add((Control)(object)txtIREConfigServerName);
		((Control)groupBox9).get_Controls().Add((Control)(object)lstIREEnv);
		((Control)groupBox9).get_Controls().Add((Control)(object)cmdIREConfigCancel);
		((Control)groupBox9).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)groupBox9).set_Location(new Point(8, 296));
		((Control)groupBox9).set_Name("groupBox9");
		((Control)groupBox9).set_Size(new Size(664, 176));
		((Control)groupBox9).set_TabIndex(14);
		groupBox9.set_TabStop(false);
		((Control)groupBox9).set_Text("IRE Configuration Information");
		((Control)label63).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label63).set_ForeColor(Color.Red);
		((Control)label63).set_Location(new Point(504, 64));
		((Control)label63).set_Name("label63");
		((Control)label63).set_Size(new Size(8, 24));
		((Control)label63).set_TabIndex(38);
		((Control)label63).set_Text("*");
		label63.set_TextAlign((ContentAlignment)32);
		((Control)label62).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label62).set_ForeColor(Color.Red);
		((Control)label62).set_Location(new Point(216, 104));
		((Control)label62).set_Name("label62");
		((Control)label62).set_Size(new Size(8, 24));
		((Control)label62).set_TabIndex(37);
		((Control)label62).set_Text("*");
		label62.set_TextAlign((ContentAlignment)32);
		((Control)label61).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label61).set_ForeColor(Color.Red);
		((Control)label61).set_Location(new Point(216, 64));
		((Control)label61).set_Name("label61");
		((Control)label61).set_Size(new Size(8, 24));
		((Control)label61).set_TabIndex(36);
		((Control)label61).set_Text("*");
		label61.set_TextAlign((ContentAlignment)32);
		((Control)label60).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label60).set_ForeColor(Color.Red);
		((Control)label60).set_Location(new Point(216, 32));
		((Control)label60).set_Name("label60");
		((Control)label60).set_Size(new Size(8, 24));
		((Control)label60).set_TabIndex(35);
		((Control)label60).set_Text("*");
		label60.set_TextAlign((ContentAlignment)32);
		((Control)label45).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label45).set_ForeColor(Color.Brown);
		((Control)label45).set_Location(new Point(16, 136));
		((Control)label45).set_Name("label45");
		((Control)label45).set_Size(new Size(120, 32));
		((Control)label45).set_TabIndex(28);
		((Control)label45).set_Text("First Environment is Default ");
		chkIREConfigDefault.set_Checked(true);
		chkIREConfigDefault.set_CheckState((CheckState)1);
		((Control)chkIREConfigDefault).set_Enabled(false);
		((Control)chkIREConfigDefault).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)chkIREConfigDefault).set_Location(new Point(488, 32));
		((Control)chkIREConfigDefault).set_Name("chkIREConfigDefault");
		((Control)chkIREConfigDefault).set_Size(new Size(168, 24));
		((Control)chkIREConfigDefault).set_TabIndex(7);
		((Control)chkIREConfigDefault).set_Text("Check It If this is the Default");
		((Control)txtIREConfigEnv).set_Location(new Point(224, 32));
		((Control)txtIREConfigEnv).set_Name("txtIREConfigEnv");
		((Control)txtIREConfigEnv).set_Size(new Size(192, 20));
		((Control)txtIREConfigEnv).set_TabIndex(6);
		((Control)txtIREConfigEnv).set_Text("");
		((Control)label25).set_Location(new Point(144, 32));
		((Control)label25).set_Name("label25");
		((Control)label25).set_Size(new Size(80, 24));
		((Control)label25).set_TabIndex(10);
		((Control)label25).set_Text("IRE Environment");
		((ButtonBase)cmdIREConfigEdit).set_FlatStyle((FlatStyle)3);
		((Control)cmdIREConfigEdit).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cmdIREConfigEdit).set_Location(new Point(336, 144));
		((Control)cmdIREConfigEdit).set_Name("cmdIREConfigEdit");
		((Control)cmdIREConfigEdit).set_Size(new Size(72, 24));
		((Control)cmdIREConfigEdit).set_TabIndex(12);
		((Control)cmdIREConfigEdit).set_Text("Edit");
		((Control)cmdIREConfigEdit).add_Click((EventHandler)cmdIREConfigEdit_Click);
		((Control)label26).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label26).set_Location(new Point(432, 64));
		((Control)label26).set_Name("label26");
		((Control)label26).set_Size(new Size(72, 23));
		((Control)label26).set_TabIndex(8);
		((Control)label26).set_Text("MethodName");
		label26.set_TextAlign((ContentAlignment)16);
		((Control)txtIREConfigMethodName).set_Enabled(false);
		((Control)txtIREConfigMethodName).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtIREConfigMethodName).set_Location(new Point(512, 64));
		((Control)txtIREConfigMethodName).set_Name("txtIREConfigMethodName");
		((Control)txtIREConfigMethodName).set_Size(new Size(128, 22));
		((Control)txtIREConfigMethodName).set_TabIndex(9);
		((Control)txtIREConfigMethodName).set_Text("");
		((ButtonBase)cmdIREConfigDelete).set_FlatStyle((FlatStyle)3);
		((Control)cmdIREConfigDelete).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cmdIREConfigDelete).set_Location(new Point(440, 144));
		((Control)cmdIREConfigDelete).set_Name("cmdIREConfigDelete");
		((Control)cmdIREConfigDelete).set_Size(new Size(72, 24));
		((Control)cmdIREConfigDelete).set_TabIndex(13);
		((Control)cmdIREConfigDelete).set_Text("Delete");
		((Control)cmdIREConfigDelete).add_Click((EventHandler)cmdIREConfigDelete_Click);
		((ButtonBase)cmdIREConfigAdd).set_FlatStyle((FlatStyle)3);
		((Control)cmdIREConfigAdd).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cmdIREConfigAdd).set_Location(new Point(232, 144));
		((Control)cmdIREConfigAdd).set_Name("cmdIREConfigAdd");
		((Control)cmdIREConfigAdd).set_Size(new Size(72, 24));
		((Control)cmdIREConfigAdd).set_TabIndex(11);
		((Control)cmdIREConfigAdd).set_Text("Add");
		((Control)cmdIREConfigAdd).add_Click((EventHandler)cmdIREConfigAdd_Click);
		((Control)label27).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label27).set_Location(new Point(144, 104));
		((Control)label27).set_Name("label27");
		((Control)label27).set_Size(new Size(64, 23));
		((Control)label27).set_TabIndex(4);
		((Control)label27).set_Text("ClassID");
		label27.set_TextAlign((ContentAlignment)16);
		((Control)label36).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label36).set_Location(new Point(144, 64));
		((Control)label36).set_Name("label36");
		((Control)label36).set_Size(new Size(72, 23));
		((Control)label36).set_TabIndex(3);
		((Control)label36).set_Text("ServerName");
		label36.set_TextAlign((ContentAlignment)16);
		((Control)txtIREConfigClassID).set_Enabled(false);
		((Control)txtIREConfigClassID).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtIREConfigClassID).set_Location(new Point(224, 104));
		((Control)txtIREConfigClassID).set_Name("txtIREConfigClassID");
		((Control)txtIREConfigClassID).set_Size(new Size(416, 20));
		((Control)txtIREConfigClassID).set_TabIndex(10);
		((Control)txtIREConfigClassID).set_Text("");
		((Control)txtIREConfigServerName).set_Enabled(false);
		((Control)txtIREConfigServerName).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtIREConfigServerName).set_Location(new Point(224, 64));
		((Control)txtIREConfigServerName).set_Name("txtIREConfigServerName");
		((Control)txtIREConfigServerName).set_Size(new Size(192, 22));
		((Control)txtIREConfigServerName).set_TabIndex(8);
		((Control)txtIREConfigServerName).set_Text("");
		((Control)lstIREEnv).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lstIREEnv).set_Location(new Point(16, 32));
		((Control)lstIREEnv).set_Name("lstIREEnv");
		((Control)lstIREEnv).set_Size(new Size(112, 95));
		((Control)lstIREEnv).set_TabIndex(5);
		lstIREEnv.add_SelectedIndexChanged((EventHandler)lstIREConfigBackendEnv_SelectedIndexChanged);
		((ButtonBase)cmdIREConfigCancel).set_FlatStyle((FlatStyle)3);
		((Control)cmdIREConfigCancel).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cmdIREConfigCancel).set_Location(new Point(536, 144));
		((Control)cmdIREConfigCancel).set_Name("cmdIREConfigCancel");
		((Control)cmdIREConfigCancel).set_Size(new Size(72, 24));
		((Control)cmdIREConfigCancel).set_TabIndex(14);
		((Control)cmdIREConfigCancel).set_Text("Cancel");
		((Control)cmdIREConfigCancel).add_Click((EventHandler)cmdIREConfigCancel_Click);
		((ButtonBase)cmdIREConfigExitApplication).set_FlatStyle((FlatStyle)3);
		((Control)cmdIREConfigExitApplication).set_Location(new Point(520, 488));
		((Control)cmdIREConfigExitApplication).set_Name("cmdIREConfigExitApplication");
		((Control)cmdIREConfigExitApplication).set_Size(new Size(96, 24));
		((Control)cmdIREConfigExitApplication).set_TabIndex(16);
		((Control)cmdIREConfigExitApplication).set_Text("Exit Application");
		((Control)cmdIREConfigExitApplication).add_Click((EventHandler)cmdIREConfigExitApplication_Click);
		((ButtonBase)cmdIREConfigSaveToFile).set_FlatStyle((FlatStyle)3);
		((Control)cmdIREConfigSaveToFile).set_Location(new Point(368, 488));
		((Control)cmdIREConfigSaveToFile).set_Name("cmdIREConfigSaveToFile");
		((Control)cmdIREConfigSaveToFile).set_Size(new Size(104, 24));
		((Control)cmdIREConfigSaveToFile).set_TabIndex(15);
		((Control)cmdIREConfigSaveToFile).set_Text("SaveToFile");
		((Control)cmdIREConfigSaveToFile).add_Click((EventHandler)cmdIREConfigSaveToFile_Click);
		((Control)groupBox7).get_Controls().Add((Control)(object)txtIREConfigReplyXsl);
		((Control)groupBox7).get_Controls().Add((Control)(object)label21);
		((Control)groupBox7).get_Controls().Add((Control)(object)txtIREConfigRequestXsl);
		((Control)groupBox7).get_Controls().Add((Control)(object)label22);
		((Control)groupBox7).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)groupBox7).set_Location(new Point(8, 240));
		((Control)groupBox7).set_Name("groupBox7");
		((Control)groupBox7).set_Size(new Size(656, 56));
		((Control)groupBox7).set_TabIndex(11);
		groupBox7.set_TabStop(false);
		((Control)groupBox7).set_Text("XSL Information");
		((Control)txtIREConfigReplyXsl).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtIREConfigReplyXsl).set_Location(new Point(400, 24));
		((Control)txtIREConfigReplyXsl).set_Name("txtIREConfigReplyXsl");
		((Control)txtIREConfigReplyXsl).set_Size(new Size(224, 20));
		((Control)txtIREConfigReplyXsl).set_TabIndex(4);
		((Control)txtIREConfigReplyXsl).set_Text("");
		((Control)txtIREConfigReplyXsl).add_TextChanged((EventHandler)txtIREConfigReplyXsl_TextChanged);
		((Control)label21).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label21).set_Location(new Point(352, 24));
		((Control)label21).set_Name("label21");
		((Control)label21).set_Size(new Size(40, 23));
		((Control)label21).set_TabIndex(3);
		((Control)label21).set_Text("Reply");
		label21.set_TextAlign((ContentAlignment)16);
		((Control)txtIREConfigRequestXsl).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtIREConfigRequestXsl).set_Location(new Point(96, 24));
		((Control)txtIREConfigRequestXsl).set_Name("txtIREConfigRequestXsl");
		((Control)txtIREConfigRequestXsl).set_Size(new Size(224, 20));
		((Control)txtIREConfigRequestXsl).set_TabIndex(3);
		((Control)txtIREConfigRequestXsl).set_Text("");
		((Control)txtIREConfigRequestXsl).add_TextChanged((EventHandler)txtIREConfigRequestXsl_TextChanged);
		((Control)label22).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label22).set_Location(new Point(16, 24));
		((Control)label22).set_Name("label22");
		((Control)label22).set_Size(new Size(80, 23));
		((Control)label22).set_TabIndex(1);
		((Control)label22).set_Text("Request");
		label22.set_TextAlign((ContentAlignment)16);
		((Control)groupBox8).get_Controls().Add((Control)(object)label23);
		((Control)groupBox8).get_Controls().Add((Control)(object)txtIREConfigRetryIntervals);
		((Control)groupBox8).get_Controls().Add((Control)(object)label24);
		((Control)groupBox8).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)groupBox8).set_Location(new Point(8, 168));
		((Control)groupBox8).set_Name("groupBox8");
		((Control)groupBox8).set_Size(new Size(656, 64));
		((Control)groupBox8).set_TabIndex(10);
		groupBox8.set_TabStop(false);
		((Control)groupBox8).set_Text("Retry Parameter");
		((Control)label23).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label23).set_ForeColor(Color.Red);
		((Control)label23).set_Location(new Point(8, 48));
		((Control)label23).set_Name("label23");
		((Control)label23).set_Size(new Size(232, 16));
		((Control)label23).set_TabIndex(33);
		((Control)label23).set_Text("ex: 5000 or 6000,5000 or 4000,3000,5000, ...");
		((Control)txtIREConfigRetryIntervals).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtIREConfigRetryIntervals).set_Location(new Point(248, 24));
		((Control)txtIREConfigRetryIntervals).set_Name("txtIREConfigRetryIntervals");
		((Control)txtIREConfigRetryIntervals).set_Size(new Size(160, 20));
		((Control)txtIREConfigRetryIntervals).set_TabIndex(2);
		((Control)txtIREConfigRetryIntervals).set_Text("");
		((Control)txtIREConfigRetryIntervals).add_TextChanged((EventHandler)txtIREConfigRetryIntervals_TextChanged);
		((Control)label24).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label24).set_Location(new Point(8, 24));
		((Control)label24).set_Name("label24");
		((Control)label24).set_Size(new Size(136, 23));
		((Control)label24).set_TabIndex(3);
		((Control)label24).set_Text("Retry Intervals in milliSec");
		label24.set_TextAlign((ContentAlignment)16);
		IRELogger.set_IsEditMode(false);
		((Control)IRELogger).set_Location(new Point(0, 0));
		((Control)IRELogger).set_Name("IRELogger");
		((Control)IRELogger).set_Size(new Size(704, 176));
		((Control)IRELogger).set_TabIndex(1);
		((Control)tbpgSPC).get_Controls().Add((Control)(object)cmdSPCConfigSaveLogger);
		((Control)tbpgSPC).get_Controls().Add((Control)(object)label66);
		((Control)tbpgSPC).get_Controls().Add((Control)(object)cmdSPCConfigExitApplication);
		((Control)tbpgSPC).get_Controls().Add((Control)(object)cmdSPCConfigSaveToFile);
		((Control)tbpgSPC).get_Controls().Add((Control)(object)grpBoxSPCXMLs);
		((Control)tbpgSPC).get_Controls().Add((Control)(object)grpBoxSPCRetryParameters);
		((Control)tbpgSPC).get_Controls().Add((Control)(object)grpBoxSPCEnvrionments);
		((Control)tbpgSPC).get_Controls().Add((Control)(object)SPCLogger);
		((Control)tbpgSPC).set_Location(new Point(4, 22));
		((Control)tbpgSPC).set_Name("tbpgSPC");
		((Control)tbpgSPC).set_Size(new Size(688, 526));
		tbpgSPC.set_TabIndex(7);
		((Control)tbpgSPC).set_Text("SPC Configuration");
		((ButtonBase)cmdSPCConfigSaveLogger).set_FlatStyle((FlatStyle)3);
		((Control)cmdSPCConfigSaveLogger).set_Location(new Point(200, 488));
		((Control)cmdSPCConfigSaveLogger).set_Name("cmdSPCConfigSaveLogger");
		((Control)cmdSPCConfigSaveLogger).set_Size(new Size(136, 24));
		((Control)cmdSPCConfigSaveLogger).set_TabIndex(43);
		((Control)cmdSPCConfigSaveLogger).set_Text("SaveLoggerForAll");
		((Control)cmdSPCConfigSaveLogger).add_Click((EventHandler)cmdSPCConfigSaveLogger_Click);
		((Control)label66).set_ForeColor(Color.Red);
		((Control)label66).set_Location(new Point(32, 488));
		((Control)label66).set_Name("label66");
		((Control)label66).set_Size(new Size(112, 24));
		((Control)label66).set_TabIndex(42);
		((Control)label66).set_Text("*   Represents  Mandatory Fields");
		((ButtonBase)cmdSPCConfigExitApplication).set_FlatStyle((FlatStyle)3);
		((Control)cmdSPCConfigExitApplication).set_Location(new Point(504, 488));
		((Control)cmdSPCConfigExitApplication).set_Name("cmdSPCConfigExitApplication");
		((Control)cmdSPCConfigExitApplication).set_Size(new Size(112, 24));
		((Control)cmdSPCConfigExitApplication).set_TabIndex(41);
		((Control)cmdSPCConfigExitApplication).set_Text("Exit Application");
		((Control)cmdSPCConfigExitApplication).add_Click((EventHandler)cmdSPCConfigExitApplication_Click);
		((ButtonBase)cmdSPCConfigSaveToFile).set_FlatStyle((FlatStyle)3);
		((Control)cmdSPCConfigSaveToFile).set_Location(new Point(360, 488));
		((Control)cmdSPCConfigSaveToFile).set_Name("cmdSPCConfigSaveToFile");
		((Control)cmdSPCConfigSaveToFile).set_Size(new Size(112, 24));
		((Control)cmdSPCConfigSaveToFile).set_TabIndex(40);
		((Control)cmdSPCConfigSaveToFile).set_Text("SaveToFile");
		((Control)cmdSPCConfigSaveToFile).add_Click((EventHandler)cmdSPCConfigSaveToFile_Click);
		((Control)grpBoxSPCXMLs).get_Controls().Add((Control)(object)txtSPCConfigReplyXsl);
		((Control)grpBoxSPCXMLs).get_Controls().Add((Control)(object)label67);
		((Control)grpBoxSPCXMLs).get_Controls().Add((Control)(object)txtSPCConfigRequestXsl);
		((Control)grpBoxSPCXMLs).get_Controls().Add((Control)(object)label68);
		((Control)grpBoxSPCXMLs).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)grpBoxSPCXMLs).set_Location(new Point(8, 240));
		((Control)grpBoxSPCXMLs).set_Name("grpBoxSPCXMLs");
		((Control)grpBoxSPCXMLs).set_Size(new Size(656, 56));
		((Control)grpBoxSPCXMLs).set_TabIndex(39);
		grpBoxSPCXMLs.set_TabStop(false);
		((Control)grpBoxSPCXMLs).set_Text("XSL Information");
		((Control)txtSPCConfigReplyXsl).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtSPCConfigReplyXsl).set_Location(new Point(400, 24));
		((Control)txtSPCConfigReplyXsl).set_Name("txtSPCConfigReplyXsl");
		((Control)txtSPCConfigReplyXsl).set_Size(new Size(224, 20));
		((Control)txtSPCConfigReplyXsl).set_TabIndex(4);
		((Control)txtSPCConfigReplyXsl).set_Text("");
		((Control)label67).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label67).set_Location(new Point(352, 24));
		((Control)label67).set_Name("label67");
		((Control)label67).set_Size(new Size(40, 23));
		((Control)label67).set_TabIndex(3);
		((Control)label67).set_Text("Reply");
		label67.set_TextAlign((ContentAlignment)16);
		((Control)txtSPCConfigRequestXsl).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtSPCConfigRequestXsl).set_Location(new Point(96, 24));
		((Control)txtSPCConfigRequestXsl).set_Name("txtSPCConfigRequestXsl");
		((Control)txtSPCConfigRequestXsl).set_Size(new Size(224, 20));
		((Control)txtSPCConfigRequestXsl).set_TabIndex(3);
		((Control)txtSPCConfigRequestXsl).set_Text("");
		((Control)label68).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label68).set_Location(new Point(16, 24));
		((Control)label68).set_Name("label68");
		((Control)label68).set_Size(new Size(80, 23));
		((Control)label68).set_TabIndex(1);
		((Control)label68).set_Text("Request");
		label68.set_TextAlign((ContentAlignment)16);
		((Control)grpBoxSPCRetryParameters).get_Controls().Add((Control)(object)label69);
		((Control)grpBoxSPCRetryParameters).get_Controls().Add((Control)(object)txtSPCConfigRetryIntervals);
		((Control)grpBoxSPCRetryParameters).get_Controls().Add((Control)(object)label70);
		((Control)grpBoxSPCRetryParameters).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)grpBoxSPCRetryParameters).set_Location(new Point(8, 168));
		((Control)grpBoxSPCRetryParameters).set_Name("grpBoxSPCRetryParameters");
		((Control)grpBoxSPCRetryParameters).set_Size(new Size(656, 64));
		((Control)grpBoxSPCRetryParameters).set_TabIndex(38);
		grpBoxSPCRetryParameters.set_TabStop(false);
		((Control)grpBoxSPCRetryParameters).set_Text("Retry Parameter");
		((Control)label69).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label69).set_ForeColor(Color.Red);
		((Control)label69).set_Location(new Point(8, 48));
		((Control)label69).set_Name("label69");
		((Control)label69).set_Size(new Size(232, 16));
		((Control)label69).set_TabIndex(33);
		((Control)label69).set_Text("ex: 5000 or 6000,5000 or 4000,3000,5000, ...");
		((Control)txtSPCConfigRetryIntervals).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtSPCConfigRetryIntervals).set_Location(new Point(248, 24));
		((Control)txtSPCConfigRetryIntervals).set_Name("txtSPCConfigRetryIntervals");
		((Control)txtSPCConfigRetryIntervals).set_Size(new Size(160, 20));
		((Control)txtSPCConfigRetryIntervals).set_TabIndex(2);
		((Control)txtSPCConfigRetryIntervals).set_Text("");
		((Control)label70).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label70).set_Location(new Point(8, 24));
		((Control)label70).set_Name("label70");
		((Control)label70).set_Size(new Size(136, 23));
		((Control)label70).set_TabIndex(3);
		((Control)label70).set_Text("Retry Intervals in milliSec");
		label70.set_TextAlign((ContentAlignment)16);
		((Control)grpBoxSPCEnvrionments).get_Controls().Add((Control)(object)txtSPCConfigEnv);
		((Control)grpBoxSPCEnvrionments).get_Controls().Add((Control)(object)label71);
		((Control)grpBoxSPCEnvrionments).get_Controls().Add((Control)(object)label72);
		((Control)grpBoxSPCEnvrionments).get_Controls().Add((Control)(object)label73);
		((Control)grpBoxSPCEnvrionments).get_Controls().Add((Control)(object)label74);
		((Control)grpBoxSPCEnvrionments).get_Controls().Add((Control)(object)label75);
		((Control)grpBoxSPCEnvrionments).get_Controls().Add((Control)(object)chkSPCConfigDefault);
		((Control)grpBoxSPCEnvrionments).get_Controls().Add((Control)(object)label76);
		((Control)grpBoxSPCEnvrionments).get_Controls().Add((Control)(object)cmdSPCConfigEdit);
		((Control)grpBoxSPCEnvrionments).get_Controls().Add((Control)(object)label77);
		((Control)grpBoxSPCEnvrionments).get_Controls().Add((Control)(object)txtSPCConfigMethodName);
		((Control)grpBoxSPCEnvrionments).get_Controls().Add((Control)(object)cmdSPCConfigDelete);
		((Control)grpBoxSPCEnvrionments).get_Controls().Add((Control)(object)cmdSPCConfigAdd);
		((Control)grpBoxSPCEnvrionments).get_Controls().Add((Control)(object)label78);
		((Control)grpBoxSPCEnvrionments).get_Controls().Add((Control)(object)label79);
		((Control)grpBoxSPCEnvrionments).get_Controls().Add((Control)(object)txtSPCConfigClassID);
		((Control)grpBoxSPCEnvrionments).get_Controls().Add((Control)(object)txtSPCConfigServerName);
		((Control)grpBoxSPCEnvrionments).get_Controls().Add((Control)(object)lstSPCEnv);
		((Control)grpBoxSPCEnvrionments).get_Controls().Add((Control)(object)cmdSPCConfigCancel);
		((Control)grpBoxSPCEnvrionments).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)grpBoxSPCEnvrionments).set_Location(new Point(8, 296));
		((Control)grpBoxSPCEnvrionments).set_Name("grpBoxSPCEnvrionments");
		((Control)grpBoxSPCEnvrionments).set_Size(new Size(664, 176));
		((Control)grpBoxSPCEnvrionments).set_TabIndex(37);
		grpBoxSPCEnvrionments.set_TabStop(false);
		((Control)grpBoxSPCEnvrionments).set_Text("SPCServer Configuration Information");
		((Control)txtSPCConfigEnv).set_Location(new Point(224, 32));
		((Control)txtSPCConfigEnv).set_Name("txtSPCConfigEnv");
		((Control)txtSPCConfigEnv).set_Size(new Size(192, 20));
		((Control)txtSPCConfigEnv).set_TabIndex(39);
		((Control)txtSPCConfigEnv).set_Text("");
		((Control)label71).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label71).set_ForeColor(Color.Red);
		((Control)label71).set_Location(new Point(216, 104));
		((Control)label71).set_Name("label71");
		((Control)label71).set_Size(new Size(8, 24));
		((Control)label71).set_TabIndex(38);
		((Control)label71).set_Text("*");
		label71.set_TextAlign((ContentAlignment)32);
		((Control)label72).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label72).set_ForeColor(Color.Red);
		((Control)label72).set_Location(new Point(504, 64));
		((Control)label72).set_Name("label72");
		((Control)label72).set_Size(new Size(8, 24));
		((Control)label72).set_TabIndex(37);
		((Control)label72).set_Text("*");
		label72.set_TextAlign((ContentAlignment)32);
		((Control)label73).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label73).set_ForeColor(Color.Red);
		((Control)label73).set_Location(new Point(216, 64));
		((Control)label73).set_Name("label73");
		((Control)label73).set_Size(new Size(8, 24));
		((Control)label73).set_TabIndex(36);
		((Control)label73).set_Text("*");
		label73.set_TextAlign((ContentAlignment)32);
		((Control)label74).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label74).set_ForeColor(Color.Red);
		((Control)label74).set_Location(new Point(216, 32));
		((Control)label74).set_Name("label74");
		((Control)label74).set_Size(new Size(8, 24));
		((Control)label74).set_TabIndex(35);
		((Control)label74).set_Text("*");
		label74.set_TextAlign((ContentAlignment)32);
		((Control)label75).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label75).set_ForeColor(Color.Brown);
		((Control)label75).set_Location(new Point(16, 136));
		((Control)label75).set_Name("label75");
		((Control)label75).set_Size(new Size(120, 32));
		((Control)label75).set_TabIndex(28);
		((Control)label75).set_Text("First Environment is Default ");
		chkSPCConfigDefault.set_Checked(true);
		chkSPCConfigDefault.set_CheckState((CheckState)1);
		((Control)chkSPCConfigDefault).set_Enabled(false);
		((Control)chkSPCConfigDefault).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)chkSPCConfigDefault).set_Location(new Point(488, 32));
		((Control)chkSPCConfigDefault).set_Name("chkSPCConfigDefault");
		((Control)chkSPCConfigDefault).set_Size(new Size(168, 24));
		((Control)chkSPCConfigDefault).set_TabIndex(7);
		((Control)chkSPCConfigDefault).set_Text("Check It If this is the Default");
		((Control)label76).set_Location(new Point(144, 32));
		((Control)label76).set_Name("label76");
		((Control)label76).set_Size(new Size(80, 24));
		((Control)label76).set_TabIndex(10);
		((Control)label76).set_Text("SPC Environment");
		((ButtonBase)cmdSPCConfigEdit).set_FlatStyle((FlatStyle)3);
		((Control)cmdSPCConfigEdit).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cmdSPCConfigEdit).set_Location(new Point(336, 144));
		((Control)cmdSPCConfigEdit).set_Name("cmdSPCConfigEdit");
		((Control)cmdSPCConfigEdit).set_TabIndex(12);
		((Control)cmdSPCConfigEdit).set_Text("Edit");
		((Control)cmdSPCConfigEdit).add_Click((EventHandler)cmdSPCConfigEdit_Click);
		((Control)label77).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label77).set_Location(new Point(432, 64));
		((Control)label77).set_Name("label77");
		((Control)label77).set_Size(new Size(72, 23));
		((Control)label77).set_TabIndex(8);
		((Control)label77).set_Text("MethodName");
		label77.set_TextAlign((ContentAlignment)16);
		((Control)txtSPCConfigMethodName).set_Enabled(false);
		((Control)txtSPCConfigMethodName).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtSPCConfigMethodName).set_Location(new Point(512, 64));
		((Control)txtSPCConfigMethodName).set_Name("txtSPCConfigMethodName");
		((Control)txtSPCConfigMethodName).set_Size(new Size(128, 22));
		((Control)txtSPCConfigMethodName).set_TabIndex(9);
		((Control)txtSPCConfigMethodName).set_Text("");
		((ButtonBase)cmdSPCConfigDelete).set_FlatStyle((FlatStyle)3);
		((Control)cmdSPCConfigDelete).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cmdSPCConfigDelete).set_Location(new Point(440, 144));
		((Control)cmdSPCConfigDelete).set_Name("cmdSPCConfigDelete");
		((Control)cmdSPCConfigDelete).set_TabIndex(13);
		((Control)cmdSPCConfigDelete).set_Text("Delete");
		((Control)cmdSPCConfigDelete).add_Click((EventHandler)cmdSPCConfigDelete_Click);
		((ButtonBase)cmdSPCConfigAdd).set_FlatStyle((FlatStyle)3);
		((Control)cmdSPCConfigAdd).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cmdSPCConfigAdd).set_Location(new Point(232, 144));
		((Control)cmdSPCConfigAdd).set_Name("cmdSPCConfigAdd");
		((Control)cmdSPCConfigAdd).set_TabIndex(11);
		((Control)cmdSPCConfigAdd).set_Text("Add");
		((Control)cmdSPCConfigAdd).add_Click((EventHandler)cmdSPCConfigAdd_Click);
		((Control)label78).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label78).set_Location(new Point(144, 104));
		((Control)label78).set_Name("label78");
		((Control)label78).set_Size(new Size(80, 23));
		((Control)label78).set_TabIndex(4);
		((Control)label78).set_Text("ClassID");
		label78.set_TextAlign((ContentAlignment)16);
		((Control)label79).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label79).set_Location(new Point(144, 64));
		((Control)label79).set_Name("label79");
		((Control)label79).set_Size(new Size(72, 23));
		((Control)label79).set_TabIndex(3);
		((Control)label79).set_Text("ServerName");
		label79.set_TextAlign((ContentAlignment)16);
		((Control)txtSPCConfigClassID).set_Enabled(false);
		((Control)txtSPCConfigClassID).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtSPCConfigClassID).set_Location(new Point(224, 104));
		((Control)txtSPCConfigClassID).set_Name("txtSPCConfigClassID");
		((Control)txtSPCConfigClassID).set_Size(new Size(416, 20));
		((Control)txtSPCConfigClassID).set_TabIndex(10);
		((Control)txtSPCConfigClassID).set_Text("");
		((Control)txtSPCConfigServerName).set_Enabled(false);
		((Control)txtSPCConfigServerName).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtSPCConfigServerName).set_Location(new Point(224, 64));
		((Control)txtSPCConfigServerName).set_Name("txtSPCConfigServerName");
		((Control)txtSPCConfigServerName).set_Size(new Size(192, 22));
		((Control)txtSPCConfigServerName).set_TabIndex(8);
		((Control)txtSPCConfigServerName).set_Text("");
		((Control)lstSPCEnv).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lstSPCEnv).set_Location(new Point(16, 32));
		((Control)lstSPCEnv).set_Name("lstSPCEnv");
		((Control)lstSPCEnv).set_Size(new Size(112, 95));
		((Control)lstSPCEnv).set_TabIndex(5);
		lstSPCEnv.add_SelectedIndexChanged((EventHandler)lstSPCConfigBackendEnv_SelectedIndexChanged);
		((ButtonBase)cmdSPCConfigCancel).set_FlatStyle((FlatStyle)3);
		((Control)cmdSPCConfigCancel).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cmdSPCConfigCancel).set_Location(new Point(536, 144));
		((Control)cmdSPCConfigCancel).set_Name("cmdSPCConfigCancel");
		((Control)cmdSPCConfigCancel).set_Size(new Size(72, 24));
		((Control)cmdSPCConfigCancel).set_TabIndex(14);
		((Control)cmdSPCConfigCancel).set_Text("Cancel");
		((Control)cmdSPCConfigCancel).add_Click((EventHandler)cmdSPCConfigCancel_Click);
		SPCLogger.set_IsEditMode(false);
		((Control)SPCLogger).set_Location(new Point(0, 0));
		((Control)SPCLogger).set_Name("SPCLogger");
		((Control)SPCLogger).set_Size(new Size(672, 176));
		((Control)SPCLogger).set_TabIndex(0);
		((Control)tbpgTCPIP).get_Controls().Add((Control)(object)cmdTCPIPSaveLogger);
		((Control)tbpgTCPIP).get_Controls().Add((Control)(object)label38);
		((Control)tbpgTCPIP).get_Controls().Add((Control)(object)cmdTCPIPConfigAppExit);
		((Control)tbpgTCPIP).get_Controls().Add((Control)(object)cmdTCPIPConfigFinalSaveTofile);
		((Control)tbpgTCPIP).get_Controls().Add((Control)(object)groupBox3);
		((Control)tbpgTCPIP).get_Controls().Add((Control)(object)groupBox2);
		((Control)tbpgTCPIP).get_Controls().Add((Control)(object)TCPIPLogger);
		((Control)tbpgTCPIP).set_Location(new Point(4, 22));
		((Control)tbpgTCPIP).set_Name("tbpgTCPIP");
		((Control)tbpgTCPIP).set_Size(new Size(688, 526));
		tbpgTCPIP.set_TabIndex(3);
		((Control)tbpgTCPIP).set_Text("TCPIP Configuration");
		((ButtonBase)cmdTCPIPSaveLogger).set_FlatStyle((FlatStyle)3);
		((Control)cmdTCPIPSaveLogger).set_Location(new Point(176, 448));
		((Control)cmdTCPIPSaveLogger).set_Name("cmdTCPIPSaveLogger");
		((Control)cmdTCPIPSaveLogger).set_Size(new Size(136, 24));
		((Control)cmdTCPIPSaveLogger).set_TabIndex(36);
		((Control)cmdTCPIPSaveLogger).set_Text("SaveLoggerForAll");
		((Control)cmdTCPIPSaveLogger).add_Click((EventHandler)cmdTCPIPSaveLogger_Click);
		((Control)label38).set_ForeColor(Color.Red);
		((Control)label38).set_Location(new Point(56, 440));
		((Control)label38).set_Name("label38");
		((Control)label38).set_Size(new Size(112, 24));
		((Control)label38).set_TabIndex(34);
		((Control)label38).set_Text("*   Represents  Mandatory Fields");
		((ButtonBase)cmdTCPIPConfigAppExit).set_FlatStyle((FlatStyle)3);
		((Control)cmdTCPIPConfigAppExit).set_Location(new Point(480, 448));
		((Control)cmdTCPIPConfigAppExit).set_Name("cmdTCPIPConfigAppExit");
		((Control)cmdTCPIPConfigAppExit).set_Size(new Size(104, 24));
		((Control)cmdTCPIPConfigAppExit).set_TabIndex(5);
		((Control)cmdTCPIPConfigAppExit).set_Text("Exit Application");
		((Control)cmdTCPIPConfigAppExit).add_Click((EventHandler)cmdTCPIPConfigAppExit_Click);
		((ButtonBase)cmdTCPIPConfigFinalSaveTofile).set_FlatStyle((FlatStyle)3);
		((Control)cmdTCPIPConfigFinalSaveTofile).set_Location(new Point(336, 448));
		((Control)cmdTCPIPConfigFinalSaveTofile).set_Name("cmdTCPIPConfigFinalSaveTofile");
		((Control)cmdTCPIPConfigFinalSaveTofile).set_Size(new Size(112, 24));
		((Control)cmdTCPIPConfigFinalSaveTofile).set_TabIndex(4);
		((Control)cmdTCPIPConfigFinalSaveTofile).set_Text("SaveToFile");
		((Control)cmdTCPIPConfigFinalSaveTofile).add_Click((EventHandler)cmdTCPIPConfigFinalSaveTofile_Click);
		((Control)groupBox3).get_Controls().Add((Control)(object)label47);
		((Control)groupBox3).get_Controls().Add((Control)(object)txtTCPIPPortNum);
		((Control)groupBox3).get_Controls().Add((Control)(object)label14);
		((Control)groupBox3).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)groupBox3).set_Location(new Point(16, 296));
		((Control)groupBox3).set_Name("groupBox3");
		((Control)groupBox3).set_Size(new Size(656, 64));
		((Control)groupBox3).set_TabIndex(8);
		groupBox3.set_TabStop(false);
		((Control)groupBox3).set_Text("Host Parameter");
		((Control)label47).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label47).set_ForeColor(Color.Red);
		((Control)label47).set_Location(new Point(240, 24));
		((Control)label47).set_Name("label47");
		((Control)label47).set_Size(new Size(8, 24));
		((Control)label47).set_TabIndex(35);
		((Control)label47).set_Text("*");
		label47.set_TextAlign((ContentAlignment)32);
		((Control)txtTCPIPPortNum).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtTCPIPPortNum).set_Location(new Point(248, 24));
		((Control)txtTCPIPPortNum).set_Name("txtTCPIPPortNum");
		((Control)txtTCPIPPortNum).set_Size(new Size(160, 20));
		((Control)txtTCPIPPortNum).set_TabIndex(3);
		((Control)txtTCPIPPortNum).set_Text("");
		((Control)txtTCPIPPortNum).add_TextChanged((EventHandler)txtPortNum_TextChanged);
		((Control)label14).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label14).set_Location(new Point(8, 24));
		((Control)label14).set_Name("label14");
		((Control)label14).set_Size(new Size(136, 23));
		((Control)label14).set_TabIndex(3);
		((Control)label14).set_Text("Port Number");
		label14.set_TextAlign((ContentAlignment)16);
		((Control)groupBox2).get_Controls().Add((Control)(object)label11);
		((Control)groupBox2).get_Controls().Add((Control)(object)txtTCPIPConfigRetryIntervals);
		((Control)groupBox2).get_Controls().Add((Control)(object)label12);
		((Control)groupBox2).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)groupBox2).set_Location(new Point(16, 200));
		((Control)groupBox2).set_Name("groupBox2");
		((Control)groupBox2).set_Size(new Size(656, 73));
		((Control)groupBox2).set_TabIndex(7);
		groupBox2.set_TabStop(false);
		((Control)groupBox2).set_Text("Retry Parameter");
		((Control)label11).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label11).set_ForeColor(Color.Red);
		((Control)label11).set_Location(new Point(8, 48));
		((Control)label11).set_Name("label11");
		((Control)label11).set_Size(new Size(232, 16));
		((Control)label11).set_TabIndex(33);
		((Control)label11).set_Text("ex: 5000 or 6000,5000 or 4000,3000,5000, ...");
		((Control)txtTCPIPConfigRetryIntervals).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtTCPIPConfigRetryIntervals).set_Location(new Point(248, 24));
		((Control)txtTCPIPConfigRetryIntervals).set_Name("txtTCPIPConfigRetryIntervals");
		((Control)txtTCPIPConfigRetryIntervals).set_Size(new Size(160, 20));
		((Control)txtTCPIPConfigRetryIntervals).set_TabIndex(2);
		((Control)txtTCPIPConfigRetryIntervals).set_Text("");
		((Control)txtTCPIPConfigRetryIntervals).add_TextChanged((EventHandler)txtTCPIPConfigRetryIntervals_TextChanged);
		((Control)label12).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label12).set_Location(new Point(8, 24));
		((Control)label12).set_Name("label12");
		((Control)label12).set_Size(new Size(136, 23));
		((Control)label12).set_TabIndex(3);
		((Control)label12).set_Text("Retry Intervals in milliSec");
		label12.set_TextAlign((ContentAlignment)16);
		TCPIPLogger.set_IsEditMode(false);
		((Control)TCPIPLogger).set_Location(new Point(8, 8));
		((Control)TCPIPLogger).set_Name("TCPIPLogger");
		((Control)TCPIPLogger).set_Size(new Size(704, 176));
		((Control)TCPIPLogger).set_TabIndex(0);
		((Control)tbpgRouter).get_Controls().Add((Control)(object)cmdRouterSaveLogger);
		((Control)tbpgRouter).get_Controls().Add((Control)(object)label39);
		((Control)tbpgRouter).get_Controls().Add((Control)(object)RouterLogger);
		((Control)tbpgRouter).get_Controls().Add((Control)(object)grpRouterConfigXSL);
		((Control)tbpgRouter).get_Controls().Add((Control)(object)grpBoxRouterTabRetryParameters);
		((Control)tbpgRouter).get_Controls().Add((Control)(object)cmdRouterConfigExitApplication);
		((Control)tbpgRouter).get_Controls().Add((Control)(object)cmdRouterConfigSaveToFile);
		((Control)tbpgRouter).get_Controls().Add((Control)(object)grpBoxRouterConfigurationInfo);
		((Control)tbpgRouter).set_Location(new Point(4, 22));
		((Control)tbpgRouter).set_Name("tbpgRouter");
		((Control)tbpgRouter).set_Size(new Size(688, 526));
		tbpgRouter.set_TabIndex(2);
		((Control)tbpgRouter).set_Text(" Router Configuration");
		((ButtonBase)cmdRouterSaveLogger).set_FlatStyle((FlatStyle)3);
		((Control)cmdRouterSaveLogger).set_Location(new Point(216, 488));
		((Control)cmdRouterSaveLogger).set_Name("cmdRouterSaveLogger");
		((Control)cmdRouterSaveLogger).set_Size(new Size(136, 24));
		((Control)cmdRouterSaveLogger).set_TabIndex(36);
		((Control)cmdRouterSaveLogger).set_Text("SaveLoggerForAll");
		((Control)cmdRouterSaveLogger).add_Click((EventHandler)cmdRouterSaveLogger_Click);
		((Control)label39).set_ForeColor(Color.Red);
		((Control)label39).set_Location(new Point(48, 488));
		((Control)label39).set_Name("label39");
		((Control)label39).set_Size(new Size(112, 24));
		((Control)label39).set_TabIndex(34);
		((Control)label39).set_Text("*   Represents  Mandatory Fields");
		RouterLogger.set_IsEditMode(false);
		((Control)RouterLogger).set_Location(new Point(0, 0));
		((Control)RouterLogger).set_Name("RouterLogger");
		((Control)RouterLogger).set_Size(new Size(704, 168));
		((Control)RouterLogger).set_TabIndex(9);
		((Control)grpRouterConfigXSL).get_Controls().Add((Control)(object)txtRouterConfigReplyXsl);
		((Control)grpRouterConfigXSL).get_Controls().Add((Control)(object)lblReplyXsl);
		((Control)grpRouterConfigXSL).get_Controls().Add((Control)(object)txtRouterConfigRequestXsl);
		((Control)grpRouterConfigXSL).get_Controls().Add((Control)(object)lblRequestXsl);
		((Control)grpRouterConfigXSL).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)grpRouterConfigXSL).set_Location(new Point(16, 240));
		((Control)grpRouterConfigXSL).set_Name("grpRouterConfigXSL");
		((Control)grpRouterConfigXSL).set_Size(new Size(656, 56));
		((Control)grpRouterConfigXSL).set_TabIndex(8);
		grpRouterConfigXSL.set_TabStop(false);
		((Control)grpRouterConfigXSL).set_Text("XSL Information");
		((Control)txtRouterConfigReplyXsl).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtRouterConfigReplyXsl).set_Location(new Point(400, 24));
		((Control)txtRouterConfigReplyXsl).set_Name("txtRouterConfigReplyXsl");
		((Control)txtRouterConfigReplyXsl).set_Size(new Size(224, 20));
		((Control)txtRouterConfigReplyXsl).set_TabIndex(4);
		((Control)txtRouterConfigReplyXsl).set_Text("");
		((Control)txtRouterConfigReplyXsl).add_TextChanged((EventHandler)txtReplyXsl_TextChanged);
		((Control)lblReplyXsl).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblReplyXsl).set_Location(new Point(352, 24));
		((Control)lblReplyXsl).set_Name("lblReplyXsl");
		((Control)lblReplyXsl).set_Size(new Size(40, 23));
		((Control)lblReplyXsl).set_TabIndex(3);
		((Control)lblReplyXsl).set_Text("Reply");
		lblReplyXsl.set_TextAlign((ContentAlignment)16);
		((Control)txtRouterConfigRequestXsl).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtRouterConfigRequestXsl).set_Location(new Point(96, 24));
		((Control)txtRouterConfigRequestXsl).set_Name("txtRouterConfigRequestXsl");
		((Control)txtRouterConfigRequestXsl).set_Size(new Size(224, 20));
		((Control)txtRouterConfigRequestXsl).set_TabIndex(3);
		((Control)txtRouterConfigRequestXsl).set_Text("");
		((Control)txtRouterConfigRequestXsl).add_TextChanged((EventHandler)txtRequestXsl_TextChanged);
		((Control)lblRequestXsl).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblRequestXsl).set_Location(new Point(16, 24));
		((Control)lblRequestXsl).set_Name("lblRequestXsl");
		((Control)lblRequestXsl).set_Size(new Size(80, 23));
		((Control)lblRequestXsl).set_TabIndex(1);
		((Control)lblRequestXsl).set_Text("Request");
		lblRequestXsl.set_TextAlign((ContentAlignment)16);
		((Control)grpBoxRouterTabRetryParameters).get_Controls().Add((Control)(object)lblRetryIntervalExample);
		((Control)grpBoxRouterTabRetryParameters).get_Controls().Add((Control)(object)txtRouterConfigRetryIntervals);
		((Control)grpBoxRouterTabRetryParameters).get_Controls().Add((Control)(object)lblRouterConfigRetryIntervals);
		((Control)grpBoxRouterTabRetryParameters).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)grpBoxRouterTabRetryParameters).set_Location(new Point(16, 168));
		((Control)grpBoxRouterTabRetryParameters).set_Name("grpBoxRouterTabRetryParameters");
		((Control)grpBoxRouterTabRetryParameters).set_Size(new Size(656, 64));
		((Control)grpBoxRouterTabRetryParameters).set_TabIndex(6);
		grpBoxRouterTabRetryParameters.set_TabStop(false);
		((Control)grpBoxRouterTabRetryParameters).set_Text("Retry Parameter");
		((Control)lblRetryIntervalExample).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblRetryIntervalExample).set_ForeColor(Color.Red);
		((Control)lblRetryIntervalExample).set_Location(new Point(8, 48));
		((Control)lblRetryIntervalExample).set_Name("lblRetryIntervalExample");
		((Control)lblRetryIntervalExample).set_Size(new Size(232, 16));
		((Control)lblRetryIntervalExample).set_TabIndex(33);
		((Control)lblRetryIntervalExample).set_Text("ex: 5000 or 6000,5000 or 4000,3000,5000, ...");
		((Control)txtRouterConfigRetryIntervals).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtRouterConfigRetryIntervals).set_Location(new Point(248, 24));
		((Control)txtRouterConfigRetryIntervals).set_Name("txtRouterConfigRetryIntervals");
		((Control)txtRouterConfigRetryIntervals).set_Size(new Size(160, 20));
		((Control)txtRouterConfigRetryIntervals).set_TabIndex(2);
		((Control)txtRouterConfigRetryIntervals).set_Text("");
		((Control)txtRouterConfigRetryIntervals).add_TextChanged((EventHandler)txtRouterConfigRetryIntervals_TextChanged);
		((Control)lblRouterConfigRetryIntervals).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblRouterConfigRetryIntervals).set_Location(new Point(8, 24));
		((Control)lblRouterConfigRetryIntervals).set_Name("lblRouterConfigRetryIntervals");
		((Control)lblRouterConfigRetryIntervals).set_Size(new Size(136, 23));
		((Control)lblRouterConfigRetryIntervals).set_TabIndex(3);
		((Control)lblRouterConfigRetryIntervals).set_Text("Retry Intervals in milliSec");
		lblRouterConfigRetryIntervals.set_TextAlign((ContentAlignment)16);
		((ButtonBase)cmdRouterConfigExitApplication).set_FlatStyle((FlatStyle)3);
		((Control)cmdRouterConfigExitApplication).set_Location(new Point(536, 488));
		((Control)cmdRouterConfigExitApplication).set_Name("cmdRouterConfigExitApplication");
		((Control)cmdRouterConfigExitApplication).set_Size(new Size(112, 24));
		((Control)cmdRouterConfigExitApplication).set_TabIndex(14);
		((Control)cmdRouterConfigExitApplication).set_Text("Exit Application");
		((Control)cmdRouterConfigExitApplication).add_Click((EventHandler)cmdRouterConfigExitApplication_Click);
		((ButtonBase)cmdRouterConfigSaveToFile).set_FlatStyle((FlatStyle)3);
		((Control)cmdRouterConfigSaveToFile).set_Location(new Point(400, 488));
		((Control)cmdRouterConfigSaveToFile).set_Name("cmdRouterConfigSaveToFile");
		((Control)cmdRouterConfigSaveToFile).set_Size(new Size(112, 24));
		((Control)cmdRouterConfigSaveToFile).set_TabIndex(13);
		((Control)cmdRouterConfigSaveToFile).set_Text("SaveToFile");
		((Control)cmdRouterConfigSaveToFile).add_Click((EventHandler)cmdRouterConfigSaveToFile_Click);
		((Control)grpBoxRouterConfigurationInfo).get_Controls().Add((Control)(object)label50);
		((Control)grpBoxRouterConfigurationInfo).get_Controls().Add((Control)(object)label49);
		((Control)grpBoxRouterConfigurationInfo).get_Controls().Add((Control)(object)label48);
		((Control)grpBoxRouterConfigurationInfo).get_Controls().Add((Control)(object)cmdRouterConfigTabEditConfigInfo);
		((Control)grpBoxRouterConfigurationInfo).get_Controls().Add((Control)(object)lblRouterConfigTabMethodName);
		((Control)grpBoxRouterConfigurationInfo).get_Controls().Add((Control)(object)txtRouterConfigTabMethodName);
		((Control)grpBoxRouterConfigurationInfo).get_Controls().Add((Control)(object)cmdRouterConfigTabDeleteConfigInfo);
		((Control)grpBoxRouterConfigurationInfo).get_Controls().Add((Control)(object)cmdRouterConfigTabAddConfigInfo);
		((Control)grpBoxRouterConfigurationInfo).get_Controls().Add((Control)(object)lblRouterConfigTabInterfaceType);
		((Control)grpBoxRouterConfigurationInfo).get_Controls().Add((Control)(object)lblRouterConfigTabServiceName);
		((Control)grpBoxRouterConfigurationInfo).get_Controls().Add((Control)(object)txtRouterConfigTabInterfaceType);
		((Control)grpBoxRouterConfigurationInfo).get_Controls().Add((Control)(object)txtRouterConfigTabServiceName);
		((Control)grpBoxRouterConfigurationInfo).get_Controls().Add((Control)(object)lstBoxRouterConfigServiceNames);
		((Control)grpBoxRouterConfigurationInfo).get_Controls().Add((Control)(object)cmdRouterConfigTabCancel);
		((Control)grpBoxRouterConfigurationInfo).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)grpBoxRouterConfigurationInfo).set_Location(new Point(16, 304));
		((Control)grpBoxRouterConfigurationInfo).set_Name("grpBoxRouterConfigurationInfo");
		((Control)grpBoxRouterConfigurationInfo).set_Size(new Size(664, 176));
		((Control)grpBoxRouterConfigurationInfo).set_TabIndex(2);
		grpBoxRouterConfigurationInfo.set_TabStop(false);
		((Control)grpBoxRouterConfigurationInfo).set_Text("Router Configuration Information");
		((Control)label50).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label50).set_ForeColor(Color.Red);
		((Control)label50).set_Location(new Point(232, 112));
		((Control)label50).set_Name("label50");
		((Control)label50).set_Size(new Size(8, 24));
		((Control)label50).set_TabIndex(37);
		((Control)label50).set_Text("*");
		label50.set_TextAlign((ContentAlignment)32);
		((Control)label49).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label49).set_ForeColor(Color.Red);
		((Control)label49).set_Location(new Point(232, 72));
		((Control)label49).set_Name("label49");
		((Control)label49).set_Size(new Size(8, 24));
		((Control)label49).set_TabIndex(36);
		((Control)label49).set_Text("*");
		label49.set_TextAlign((ContentAlignment)32);
		((Control)label48).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label48).set_ForeColor(Color.Red);
		((Control)label48).set_Location(new Point(232, 40));
		((Control)label48).set_Name("label48");
		((Control)label48).set_Size(new Size(8, 24));
		((Control)label48).set_TabIndex(35);
		((Control)label48).set_Text("*");
		label48.set_TextAlign((ContentAlignment)32);
		((ButtonBase)cmdRouterConfigTabEditConfigInfo).set_FlatStyle((FlatStyle)3);
		((Control)cmdRouterConfigTabEditConfigInfo).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cmdRouterConfigTabEditConfigInfo).set_Location(new Point(344, 144));
		((Control)cmdRouterConfigTabEditConfigInfo).set_Name("cmdRouterConfigTabEditConfigInfo");
		((Control)cmdRouterConfigTabEditConfigInfo).set_Size(new Size(72, 24));
		((Control)cmdRouterConfigTabEditConfigInfo).set_TabIndex(10);
		((Control)cmdRouterConfigTabEditConfigInfo).set_Text("Edit");
		((Control)cmdRouterConfigTabEditConfigInfo).add_Click((EventHandler)cmdRouterConfigTabEditConfigInfo_Click);
		((Control)lblRouterConfigTabMethodName).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblRouterConfigTabMethodName).set_Location(new Point(152, 72));
		((Control)lblRouterConfigTabMethodName).set_Name("lblRouterConfigTabMethodName");
		((Control)lblRouterConfigTabMethodName).set_Size(new Size(88, 23));
		((Control)lblRouterConfigTabMethodName).set_TabIndex(8);
		((Control)lblRouterConfigTabMethodName).set_Text("MethodName");
		lblRouterConfigTabMethodName.set_TextAlign((ContentAlignment)16);
		((Control)txtRouterConfigTabMethodName).set_Enabled(false);
		((Control)txtRouterConfigTabMethodName).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtRouterConfigTabMethodName).set_Location(new Point(240, 72));
		((Control)txtRouterConfigTabMethodName).set_Name("txtRouterConfigTabMethodName");
		((Control)txtRouterConfigTabMethodName).set_Size(new Size(168, 22));
		((Control)txtRouterConfigTabMethodName).set_TabIndex(7);
		((Control)txtRouterConfigTabMethodName).set_Text("");
		((ButtonBase)cmdRouterConfigTabDeleteConfigInfo).set_FlatStyle((FlatStyle)3);
		((Control)cmdRouterConfigTabDeleteConfigInfo).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cmdRouterConfigTabDeleteConfigInfo).set_Location(new Point(448, 144));
		((Control)cmdRouterConfigTabDeleteConfigInfo).set_Name("cmdRouterConfigTabDeleteConfigInfo");
		((Control)cmdRouterConfigTabDeleteConfigInfo).set_Size(new Size(72, 24));
		((Control)cmdRouterConfigTabDeleteConfigInfo).set_TabIndex(11);
		((Control)cmdRouterConfigTabDeleteConfigInfo).set_Text("Delete");
		((Control)cmdRouterConfigTabDeleteConfigInfo).add_Click((EventHandler)cmdRouterConfigTabDeleteConfigInfo_Click);
		((ButtonBase)cmdRouterConfigTabAddConfigInfo).set_FlatStyle((FlatStyle)3);
		((Control)cmdRouterConfigTabAddConfigInfo).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cmdRouterConfigTabAddConfigInfo).set_Location(new Point(240, 144));
		((Control)cmdRouterConfigTabAddConfigInfo).set_Name("cmdRouterConfigTabAddConfigInfo");
		((Control)cmdRouterConfigTabAddConfigInfo).set_Size(new Size(72, 24));
		((Control)cmdRouterConfigTabAddConfigInfo).set_TabIndex(9);
		((Control)cmdRouterConfigTabAddConfigInfo).set_Text("Add");
		((Control)cmdRouterConfigTabAddConfigInfo).add_Click((EventHandler)cmdRouterConfigTabAddConfigInfo_Click);
		((Control)lblRouterConfigTabInterfaceType).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblRouterConfigTabInterfaceType).set_Location(new Point(152, 112));
		((Control)lblRouterConfigTabInterfaceType).set_Name("lblRouterConfigTabInterfaceType");
		((Control)lblRouterConfigTabInterfaceType).set_Size(new Size(88, 23));
		((Control)lblRouterConfigTabInterfaceType).set_TabIndex(4);
		((Control)lblRouterConfigTabInterfaceType).set_Text("Interface Type");
		lblRouterConfigTabInterfaceType.set_TextAlign((ContentAlignment)16);
		((Control)lblRouterConfigTabServiceName).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblRouterConfigTabServiceName).set_Location(new Point(152, 40));
		((Control)lblRouterConfigTabServiceName).set_Name("lblRouterConfigTabServiceName");
		((Control)lblRouterConfigTabServiceName).set_Size(new Size(88, 23));
		((Control)lblRouterConfigTabServiceName).set_TabIndex(3);
		((Control)lblRouterConfigTabServiceName).set_Text("ServiceName");
		lblRouterConfigTabServiceName.set_TextAlign((ContentAlignment)16);
		((Control)txtRouterConfigTabInterfaceType).set_Enabled(false);
		((Control)txtRouterConfigTabInterfaceType).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtRouterConfigTabInterfaceType).set_Location(new Point(240, 112));
		((Control)txtRouterConfigTabInterfaceType).set_Name("txtRouterConfigTabInterfaceType");
		((Control)txtRouterConfigTabInterfaceType).set_Size(new Size(376, 20));
		((Control)txtRouterConfigTabInterfaceType).set_TabIndex(8);
		((Control)txtRouterConfigTabInterfaceType).set_Text("");
		((Control)txtRouterConfigTabServiceName).set_Enabled(false);
		((Control)txtRouterConfigTabServiceName).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtRouterConfigTabServiceName).set_Location(new Point(240, 40));
		((Control)txtRouterConfigTabServiceName).set_Name("txtRouterConfigTabServiceName");
		((Control)txtRouterConfigTabServiceName).set_Size(new Size(168, 22));
		((Control)txtRouterConfigTabServiceName).set_TabIndex(6);
		((Control)txtRouterConfigTabServiceName).set_Text("");
		((Control)lstBoxRouterConfigServiceNames).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lstBoxRouterConfigServiceNames).set_Location(new Point(16, 32));
		((Control)lstBoxRouterConfigServiceNames).set_Name("lstBoxRouterConfigServiceNames");
		((Control)lstBoxRouterConfigServiceNames).set_Size(new Size(112, 134));
		((Control)lstBoxRouterConfigServiceNames).set_TabIndex(5);
		lstBoxRouterConfigServiceNames.add_SelectedIndexChanged((EventHandler)lstBoxRouterConfigServiceNames_SelectedIndexChanged);
		((ButtonBase)cmdRouterConfigTabCancel).set_FlatStyle((FlatStyle)3);
		((Control)cmdRouterConfigTabCancel).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cmdRouterConfigTabCancel).set_Location(new Point(544, 144));
		((Control)cmdRouterConfigTabCancel).set_Name("cmdRouterConfigTabCancel");
		((Control)cmdRouterConfigTabCancel).set_Size(new Size(72, 24));
		((Control)cmdRouterConfigTabCancel).set_TabIndex(12);
		((Control)cmdRouterConfigTabCancel).set_Text("Cancel");
		((Control)cmdRouterConfigTabCancel).add_Click((EventHandler)cmdRouterConfigTabCancel_Click);
		((Control)lblClientATMIAServerName).set_Location(new Point(0, 0));
		((Control)lblClientATMIAServerName).set_Name("lblClientATMIAServerName");
		((Control)lblClientATMIAServerName).set_TabIndex(0);
		folderBrowserDialogLogFiles.set_SelectedPath("C:\\");
		((FileDialog)openFileDialog1).set_InitialDirectory("c:\\ProgramFiles\\");
		((ButtonBase)ErrorConfigBtn).set_FlatStyle((FlatStyle)3);
		((Control)ErrorConfigBtn).set_Location(new Point(192, 480));
		((Control)ErrorConfigBtn).set_Name("ErrorConfigBtn");
		((Control)ErrorConfigBtn).set_Size(new Size(120, 32));
		((Control)ErrorConfigBtn).set_TabIndex(36);
		((Control)ErrorConfigBtn).set_Text("ErrorConfig");
		((Control)ErrorConfigBtn).add_Click((EventHandler)ErrorConfigBtn_Click);
		((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)this).set_ClientSize(new Size(712, 582));
		((Control)this).get_Controls().Add((Control)(object)tbctrlClientServerRouter);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MaximumSize(new Size(720, 616));
		((Form)this).set_MinimumSize(new Size(720, 616));
		((Control)this).set_Name("ConfigurationUtilityForm");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("ATMIA Configuration Utility");
		((Control)grpBoxBackEndEnvironments).ResumeLayout(false);
		((Control)grpBoxHostInformation).ResumeLayout(false);
		((Control)grpBoxPortInformation).ResumeLayout(false);
		((Control)grpBoxAccountInformation).ResumeLayout(false);
		((Control)grpBoxBackEndEnvName).ResumeLayout(false);
		((Control)tbctrlClientServerRouter).ResumeLayout(false);
		((Control)tbpgClient).ResumeLayout(false);
		((Control)grpBoxClientServerInteractionInfo).ResumeLayout(false);
		((Control)grpBoxClientOtherParameters).ResumeLayout(false);
		((Control)grpBoxClientProxyConfigurationInformation).ResumeLayout(false);
		((Control)tbpgSPEED).ResumeLayout(false);
		((Control)groupBox12).ResumeLayout(false);
		((Control)groupBox10).ResumeLayout(false);
		((Control)groupBox11).ResumeLayout(false);
		((Control)tbpgWSInterface).ResumeLayout(false);
		((Control)groupBox1).ResumeLayout(false);
		((Control)tbpgGlenda).ResumeLayout(false);
		((Control)groupBox4).ResumeLayout(false);
		((Control)groupBox5).ResumeLayout(false);
		((Control)groupBox6).ResumeLayout(false);
		((Control)tbpgIRE).ResumeLayout(false);
		((Control)groupBox9).ResumeLayout(false);
		((Control)groupBox7).ResumeLayout(false);
		((Control)groupBox8).ResumeLayout(false);
		((Control)tbpgSPC).ResumeLayout(false);
		((Control)grpBoxSPCXMLs).ResumeLayout(false);
		((Control)grpBoxSPCRetryParameters).ResumeLayout(false);
		((Control)grpBoxSPCEnvrionments).ResumeLayout(false);
		((Control)tbpgTCPIP).ResumeLayout(false);
		((Control)groupBox3).ResumeLayout(false);
		((Control)groupBox2).ResumeLayout(false);
		((Control)tbpgRouter).ResumeLayout(false);
		((Control)grpRouterConfigXSL).ResumeLayout(false);
		((Control)grpBoxRouterTabRetryParameters).ResumeLayout(false);
		((Control)grpBoxRouterConfigurationInfo).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void PopulateAllSPCConfigTabFields()
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			PopulateLogger(SPCDoc, SPCLogger);
			PopulateConfigRetryParameters(SPCDoc, txtSPCConfigRetryIntervals);
			PopulateConfigXSLParameters(SPCDoc, txtSPCConfigRequestXsl, txtSPCConfigReplyXsl);
			PopulateBackendEnv(SPCDoc, lstSPCEnv);
			SPCTabEditMode = false;
			SPCTabAddMode = false;
		}
		catch (Exception ex)
		{
			MessageBox.Show("PopulateAllSPCConfigTabFields error: " + ex.Message);
		}
	}

	private XmlElement CreateBackendEnvironmentNodeForSPC()
	{
		return CreateBackEndEnvNode(SPCDoc, ((Control)txtSPCConfigEnv).get_Text(), ((Control)txtSPCConfigServerName).get_Text(), ((Control)txtSPCConfigMethodName).get_Text(), ((Control)txtSPCConfigClassID).get_Text());
	}

	private void ModifySPCConfigInfoFieldState(bool stateValue)
	{
		((Control)txtSPCConfigEnv).set_Enabled(stateValue);
		((Control)txtSPCConfigServerName).set_Enabled(stateValue);
		((Control)txtSPCConfigMethodName).set_Enabled(stateValue);
		((Control)txtSPCConfigClassID).set_Enabled(stateValue);
		((Control)chkSPCConfigDefault).set_Enabled(stateValue);
	}

	private void ModifySPCConfigInfoButtonState(bool stateValue)
	{
		((Control)cmdSPCConfigAdd).set_Enabled(stateValue);
		((Control)cmdSPCConfigEdit).set_Enabled(stateValue);
		if (((ListControl)lstSPCEnv).get_SelectedIndex() != 0)
		{
			((Control)cmdSPCConfigDelete).set_Enabled(stateValue);
		}
	}

	private void ProcessToChangeDefaultSPCConfigEnvironment(XmlNode node)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ProcessToChangeDefaultNode(SPCDoc, node, lstSPCEnv, ((Control)txtSPCConfigEnv).get_Text(), SPCTabAddMode);
		}
		catch (Exception ex)
		{
			MessageBox.Show("ProcessToChangeDefaultSPCConfigEnvironment error: " + ex.Message);
		}
	}

	private void PopulateSPCEnvironmentFields(string name)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			PopulateEnvironmentField(SPCDoc, name, txtSPCConfigEnv, txtSPCConfigServerName, txtSPCConfigMethodName, txtSPCConfigClassID);
		}
		catch (Exception ex)
		{
			MessageBox.Show("PopulateSPCEnvironmentFields error " + ex.ToString());
		}
	}

	private void txtSPCConfigRetryIntervals_TextChanged(object sender, EventArgs e)
	{
		SPCTabEditMode = true;
	}

	private void txtSPCConfigRequestXsl_TextChanged(object sender, EventArgs e)
	{
		SPCTabEditMode = true;
	}

	private void txtSPCConfigReplyXsl_TextChanged(object sender, EventArgs e)
	{
		SPCTabEditMode = true;
	}

	private void lstSPCConfigBackendEnv_SelectedIndexChanged(object sender, EventArgs e)
	{
		SPCTabAddMode = false;
		SPCTabEditMode = false;
		ModifySPCConfigInfoFieldState(stateValue: false);
		ModifySPCConfigInfoButtonState(stateValue: true);
		PopulateSPCEnvironmentFields(((Control)lstSPCEnv).get_Text());
		if (((ListControl)lstSPCEnv).get_SelectedIndex() == 0)
		{
			((Control)cmdSPCConfigDelete).set_Enabled(false);
			chkSPCConfigDefault.set_Checked(true);
		}
		else
		{
			((Control)cmdSPCConfigDelete).set_Enabled(true);
			chkSPCConfigDefault.set_Checked(false);
		}
	}

	private void cmdSPCConfigAdd_Click(object sender, EventArgs e)
	{
		if (lstSPCEnv.get_Items().get_Count() != 0)
		{
			lstSPCEnv.SetSelected(0, false);
		}
		ModifySPCConfigInfoFieldState(stateValue: true);
		ModifySPCConfigInfoButtonState(stateValue: false);
		((Control)txtSPCConfigEnv).set_Text("");
		((Control)txtSPCConfigServerName).set_Text("");
		((Control)txtSPCConfigMethodName).set_Text("");
		((Control)txtSPCConfigClassID).set_Text("");
		chkSPCConfigDefault.set_Checked(false);
		SPCTabAddMode = true;
	}

	private void cmdSPCConfigEdit_Click(object sender, EventArgs e)
	{
		SPCTabEditMode = true;
		ModifySPCConfigInfoFieldState(stateValue: true);
		if (((ListControl)lstSPCEnv).get_SelectedIndex() == 0)
		{
			((Control)chkSPCConfigDefault).set_Enabled(false);
		}
		ModifySPCConfigInfoButtonState(stateValue: false);
	}

	private void cmdSPCConfigDelete_Click(object sender, EventArgs e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between I4 and Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		if (!CheckFileReadOnly("..\\config\\ATMIA-SPCInterface.config") && 1 == (int)MessageBox.Show("Are you Sure you want to Delete ? The file will automatically be saved after deletion", "Deletion of File", (MessageBoxButtons)1, (MessageBoxIcon)48))
		{
			string xpath = "//SPCEnvironments/BackendEnvInfo[BackendEnv='" + ((Control)txtSPCConfigEnv).get_Text() + "']";
			XmlNode xmlNode = SPCDoc.SelectSingleNode(xpath);
			XmlNode parentNode = xmlNode.ParentNode;
			parentNode.RemoveChild(xmlNode);
			SPCDoc.Save("..\\config\\ATMIA-SPCInterface.config");
			ModifySPCConfigInfoButtonState(stateValue: false);
			lstSPCEnv.get_Items().Remove((object)((Control)txtSPCConfigEnv).get_Text());
			((Control)lstSPCEnv).Refresh();
			((ListControl)lstSPCEnv).set_SelectedIndex(0);
			MessageBox.Show("The ATMIA Environment has been Successfully deleted", "Information", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
	}

	private void cmdSPCConfigCancel_Click(object sender, EventArgs e)
	{
		lstSPCEnv.SetSelected(0, true);
		ModifySPCConfigInfoFieldState(stateValue: false);
		ModifySPCConfigInfoButtonState(stateValue: true);
		((Control)cmdSPCConfigDelete).set_Enabled(false);
		chkSPCConfigDefault.set_Checked(true);
		SPCTabAddMode = false;
		SPCTabEditMode = false;
	}

	private void cmdSPCConfigSaveLogger_Click(object sender, EventArgs e)
	{
		SaveAllLogger(SPCDoc, SPCLogger, RouterLogger, TCPIPLogger, WSLogger, GlendaLogger, SPEEDLogger, IRELogger);
	}

	private void cmdSPCConfigSaveToFile_Click(object sender, EventArgs e)
	{
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		bool ChangeOcurred = false;
		if (CheckFileReadOnly("..\\config\\ATMIA-SPCInterface.config"))
		{
			return;
		}
		if ((!SPCTabAddMode && !SPCTabEditMode) || (((Control)txtSPCConfigEnv).get_Text().Length != 0 && ((Control)txtSPCConfigServerName).get_Text().Length != 0 && ((Control)txtSPCConfigMethodName).get_Text().Length != 0 && ((Control)txtSPCConfigClassID).get_Text().Length != 0))
		{
			Cursor current = Cursor.get_Current();
			Cursor.set_Current(Cursors.get_WaitCursor());
			if (!SaveLogger(ref SPCDoc, ref SPCLogger, ref ChangeOcurred))
			{
				return;
			}
			try
			{
				ChangeOcurred = (ChangeOcurred = (ChangeOcurred |= IsFieldChange(ref SPCDoc, txtSPCConfigRetryIntervals, "//RetryInterval")) | IsFieldChange(ref SPCDoc, txtSPCConfigRequestXsl, "//XSL/RequestXSL")) | IsFieldChange(ref SPCDoc, txtSPCConfigReplyXsl, "//XSL/ReplyXSL");
				if (SPCTabAddMode)
				{
					if (lstSPCEnv.get_Items().Contains((object)((Control)txtSPCConfigEnv).get_Text()))
					{
						MessageBox.Show("This environment already exists, no saving is made", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
						return;
					}
					XmlNode xmlNode = SPCDoc.SelectSingleNode("//SPCEnvironments");
					XmlElement xmlElement = CreateBackendEnvironmentNodeForSPC();
					if (chkSPCConfigDefault.get_Checked() && ((Control)chkSPCConfigDefault).get_Enabled())
					{
						ProcessToChangeDefaultSPCConfigEnvironment(xmlElement);
						xmlNode.PrependChild(xmlElement);
					}
					else
					{
						xmlNode.AppendChild(xmlElement);
						lstSPCEnv.get_Items().Add((object)((Control)txtSPCConfigEnv).get_Text());
						((Control)lstSPCEnv).Refresh();
						((ListControl)lstSPCEnv).set_SelectedIndex(lstSPCEnv.get_Items().get_Count() - 1);
					}
					ModifySPCConfigInfoButtonState(stateValue: true);
					ChangeOcurred = true;
				}
				if (SPCTabEditMode)
				{
					((Control)lstSPCEnv).Refresh();
					string xpath = "//SPCEnvironments/BackendEnvInfo[BackendEnv='" + lstSPCEnv.get_SelectedItem().ToString() + "']";
					XmlNode xmlNode2 = SPCDoc.SelectSingleNode(xpath);
					xmlNode2.SelectSingleNode("BackendEnv")!.InnerText = ((Control)txtSPCConfigEnv).get_Text();
					xmlNode2.SelectSingleNode("ServerName")!.InnerText = ((Control)txtSPCConfigServerName).get_Text();
					xmlNode2.SelectSingleNode("MethodName")!.InnerText = ((Control)txtSPCConfigMethodName).get_Text();
					xmlNode2.SelectSingleNode("ClassID")!.InnerText = ((Control)txtSPCConfigClassID).get_Text();
					if (chkSPCConfigDefault.get_Checked() && ((Control)chkSPCConfigDefault).get_Enabled())
					{
						ProcessToChangeDefaultSPCConfigEnvironment(xmlNode2);
					}
					else
					{
						lstSPCEnv.get_Items().set_Item(((ListControl)lstSPCEnv).get_SelectedIndex(), (object)((Control)txtSPCConfigEnv).get_Text());
					}
					((ListControl)lstSPCEnv).set_SelectedIndex(0);
					lstSPCEnv.SetSelected(0, true);
					((Control)lstSPCEnv).Refresh();
					ChangeOcurred = true;
				}
				if (ChangeOcurred)
				{
					SPCDoc.Save("..\\config\\ATMIA-SPCInterface.config");
					MessageBox.Show("The Changes have been Saved to the File", "Information", (MessageBoxButtons)0, (MessageBoxIcon)64);
				}
				SPCTabEditMode = false;
				SPCTabAddMode = false;
				Cursor.set_Current(current);
				return;
			}
			catch (Exception ex)
			{
				MessageBox.Show("cmdSPCConfigSaveToFile_Click error: " + ex.Message);
				return;
			}
		}
		MessageBox.Show("Please make sure all the Mandatory tags (*) are filled", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private void cmdSPCConfigExitApplication_Click(object sender, EventArgs e)
	{
		cmdExitApplication();
	}
}
