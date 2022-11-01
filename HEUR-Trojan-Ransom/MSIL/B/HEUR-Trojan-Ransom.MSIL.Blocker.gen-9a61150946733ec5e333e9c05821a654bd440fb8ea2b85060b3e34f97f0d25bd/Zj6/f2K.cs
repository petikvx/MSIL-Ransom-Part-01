using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Ak8;
using Cg6;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace Zj6;

[DesignerGenerated]
public class f2K : Form
{
	[AccessedThroughProperty("Logbox")]
	private RichTextBox _Logbox;

	private Pa1.a8T a8T_0;

	internal virtual RichTextBox Logbox
	{
		get
		{
			return _Logbox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Logbox = value;
		}
	}

	internal virtual ContextMenuStrip LogController
	{
		get
		{
			return a8T_0.contextMenuStrip_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			a8T_0.contextMenuStrip_0 = ((value is ContextMenuStrip) ? value : null);
		}
	}

	internal virtual ToolStripMenuItem Logdel
	{
		get
		{
			return a8T_0.toolStripMenuItem_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			object obj = new EventHandler(g3S);
			ToolStripDropDownItem toolStripMenuItem_ = (ToolStripDropDownItem)(object)a8T_0.toolStripMenuItem_0;
			if ((int)(ToolStripMenuItem)toolStripMenuItem_ != 0)
			{
				((ToolStripItem)((toolStripMenuItem_ is ToolStripMenuItem) ? toolStripMenuItem_ : null)).remove_Click((EventHandler)obj);
			}
			a8T_0.toolStripMenuItem_0 = ((value is ToolStripMenuItem) ? value : null);
			toolStripMenuItem_ = (ToolStripDropDownItem)(object)a8T_0.toolStripMenuItem_0;
			if ((int)(ToolStripMenuItem)toolStripMenuItem_ != 0)
			{
				((ToolStripItem)(ToolStripMenuItem)toolStripMenuItem_).add_Click((EventHandler)obj);
			}
		}
	}

	internal virtual ToolStripMenuItem Ref
	{
		get
		{
			return a8T_0.toolStripMenuItem_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			MulticastDelegate multicastDelegate = new EventHandler(Wf0);
			object toolStripMenuItem_ = a8T_0.toolStripMenuItem_1;
			if ((int)(ToolStripMenuItem)toolStripMenuItem_ != 0)
			{
				((ToolStripItem)((toolStripMenuItem_ is ToolStripMenuItem) ? toolStripMenuItem_ : null)).remove_Click(multicastDelegate as EventHandler);
			}
			a8T_0.toolStripMenuItem_1 = ((value is ToolStripMenuItem) ? value : null);
			toolStripMenuItem_ = a8T_0.toolStripMenuItem_1;
			if (toolStripMenuItem_ is ToolStripMenuItem)
			{
				((ToolStripItem)(ToolStripMenuItem)toolStripMenuItem_).add_Click(multicastDelegate as EventHandler);
			}
		}
	}

	public f2K()
	{
		((Form)this).add_Load((EventHandler)Sj9);
		Gx1();
	}

	protected override void Jj6(bool Rm5)
	{
		try
		{
			if (Rm5 && a8T_0.icontainer_0 != null)
			{
				a8T_0.icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Rm5);
		}
	}

	private void Gx1()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		object obj = new Container();
		a8T_0.icontainer_0 = (IContainer)obj;
		Logbox = new RichTextBox();
		LogController = new ContextMenuStrip(a8T_0.icontainer_0);
		Logdel = new ToolStripMenuItem();
		Ref = new ToolStripMenuItem();
		((Control)LogController).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Logbox).set_ContextMenuStrip(LogController);
		((Control)Logbox).set_Dock((DockStyle)5);
		Logbox.set_Font(new Font("맑은 고딕", 11f));
		((Control)Logbox).set_Location(new Point(0, 0));
		((Control)Logbox).set_Name("Logbox");
		((TextBoxBase)Logbox).set_ReadOnly(true);
		((Control)Logbox).set_Size(new Size(444, 531));
		((Control)Logbox).set_TabIndex(0);
		Logbox.set_Text("");
		((ToolStrip)LogController).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)Logdel,
			(ToolStripItem)Ref
		});
		((Control)LogController).set_Name("LogController");
		((Control)LogController).set_Size(new Size(183, 48));
		((ToolStripItem)Logdel).set_Name("Logdel");
		((ToolStripItem)Logdel).set_Size(new Size(182, 22));
		((ToolStripItem)Logdel).set_Text("모든 실행 기록 삭제");
		((ToolStripItem)Ref).set_Name("Ref");
		((ToolStripItem)Ref).set_Size(new Size(182, 22));
		((ToolStripItem)Ref).set_Text("새로고침");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(7f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(444, 531));
		((Control)this).get_Controls().Add((Control)(object)Logbox);
		((Control)this).set_Name("LogViewer");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("실행 기록");
		((Form)this).set_TopMost(true);
		((Control)LogController).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void Sj9(object sender, EventArgs e)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		IConvertible convertible = Path.Combine(((ServerComputer)Cx9.Computer).get_FileSystem().get_SpecialDirectories().get_CurrentUserApplicationData(), "ApplicationLog.log");
		if (File.Exists(convertible as string))
		{
			Logbox.set_Text(File.ReadAllText(convertible as string));
			return;
		}
		Logbox.set_Font(new Font(Logbox.get_Font(), (FontStyle)(Logbox.get_Font().get_Style() | 2)));
		Logbox.set_Text("\r\r\r\r\r\r\r\r\r                                아직 기록이 없음");
	}

	private void g3S(object sender, EventArgs e)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		object obj = Path.Combine(((ServerComputer)Cx9.Computer).get_FileSystem().get_SpecialDirectories().get_CurrentUserApplicationData(), "ApplicationLog.log");
		File.Delete(obj as string);
		Logbox.set_Font(new Font(Logbox.get_Font(), (FontStyle)(Logbox.get_Font().get_Style() | 2)));
		Logbox.set_Text("\r\r\r\r\r\r\r\r\r                                아직 기록이 없음");
	}

	private void Wf0(object sender, EventArgs e)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		IEnumerable<char> enumerable = Path.Combine(((ServerComputer)Cx9.Computer).get_FileSystem().get_SpecialDirectories().get_CurrentUserApplicationData(), "ApplicationLog.log");
		if (!File.Exists(enumerable as string))
		{
			Logbox.set_Text("\r\r\r\r\r\r\r\r\r                                아직 기록이 없음");
			return;
		}
		Logbox.set_Font(new Font(Logbox.get_Font(), (FontStyle)(Logbox.get_Font().get_Style() & 0)));
		Logbox.set_Text(File.ReadAllText(enumerable as string));
	}

	internal static int Ea2()
	{
		while (true)
		{
			try
			{
				object obj = (HttpWebRequest)WebRequest.Create("https://www.google.com");
				((HttpWebRequest)obj).KeepAlive = false;
				(obj as HttpWebRequest).Timeout = 10000;
				WebResponse webResponse = (HttpWebResponse)(obj as HttpWebRequest).GetResponse();
				try
				{
					return 100;
				}
				finally
				{
					if ((HttpWebResponse)webResponse != null)
					{
						((IDisposable)(HttpWebResponse)webResponse).Dispose();
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}
}
