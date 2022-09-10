using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace WebCruiserWVS;

public class FormAdmin : Form
{
	private delegate void Delegate5(string string_0);

	private IContainer icontainer_0;

	private ToolStrip toolStripAdmin;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripButton btnGetAdmin;

	private ToolStripSeparator toolStripSeparator2;

	private ToolStripButton btnSearchEngine;

	private ToolStripSeparator toolStripSeparator3;

	private ListView listViewAdminEntrance;

	private ColumnHeader columnHeader_0;

	private FormMain formMain_0;

	void Form.Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
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
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormAdmin));
		toolStripAdmin = new ToolStrip();
		toolStripSeparator1 = new ToolStripSeparator();
		btnGetAdmin = new ToolStripButton();
		toolStripSeparator2 = new ToolStripSeparator();
		btnSearchEngine = new ToolStripButton();
		toolStripSeparator3 = new ToolStripSeparator();
		listViewAdminEntrance = new ListView();
		columnHeader_0 = new ColumnHeader();
		((Control)toolStripAdmin).SuspendLayout();
		((Control)this).SuspendLayout();
		toolStripAdmin.set_BackColor(SystemColors.ButtonFace);
		((Control)toolStripAdmin).set_Dock((DockStyle)2);
		toolStripAdmin.set_GripStyle((ToolStripGripStyle)0);
		toolStripAdmin.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)toolStripSeparator1,
			(ToolStripItem)btnGetAdmin,
			(ToolStripItem)toolStripSeparator2,
			(ToolStripItem)btnSearchEngine,
			(ToolStripItem)toolStripSeparator3
		});
		((Control)toolStripAdmin).set_Location(new Point(0, 298));
		((Control)toolStripAdmin).set_Name("toolStripAdmin");
		((Control)toolStripAdmin).set_Size(new Size(485, 25));
		((Control)toolStripAdmin).set_TabIndex(0);
		((Control)toolStripAdmin).set_Text("toolStrip1");
		((ToolStripItem)toolStripSeparator1).set_Name("toolStripSeparator1");
		((ToolStripItem)toolStripSeparator1).set_Size(new Size(6, 25));
		((ToolStripItem)btnGetAdmin).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripItem)btnGetAdmin).set_Image((Image)componentResourceManager.GetObject("btnGetAdmin.Image"));
		((ToolStripItem)btnGetAdmin).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)btnGetAdmin).set_Name("btnGetAdmin");
		((ToolStripItem)btnGetAdmin).set_Size(new Size(171, 22));
		((ToolStripItem)btnGetAdmin).set_Text("Get Administration Entrance");
		((ToolStripItem)btnGetAdmin).add_Click((EventHandler)btnGetAdmin_Click);
		((ToolStripItem)toolStripSeparator2).set_Name("toolStripSeparator2");
		((ToolStripItem)toolStripSeparator2).set_Size(new Size(6, 25));
		((ToolStripItem)btnSearchEngine).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripItem)btnSearchEngine).set_Image((Image)componentResourceManager.GetObject("btnSearchEngine.Image"));
		((ToolStripItem)btnSearchEngine).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)btnSearchEngine).set_Name("btnSearchEngine");
		((ToolStripItem)btnSearchEngine).set_Size(new Size(147, 22));
		((ToolStripItem)btnSearchEngine).set_Text("Search By Search Engine");
		((ToolStripItem)btnSearchEngine).add_Click((EventHandler)btnSearchEngine_Click);
		((ToolStripItem)toolStripSeparator3).set_Name("toolStripSeparator3");
		((ToolStripItem)toolStripSeparator3).set_Size(new Size(6, 25));
		listViewAdminEntrance.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[1] { columnHeader_0 });
		((Control)listViewAdminEntrance).set_Dock((DockStyle)5);
		((Control)listViewAdminEntrance).set_Location(new Point(0, 0));
		((Control)listViewAdminEntrance).set_Name("listViewAdminEntrance");
		((Control)listViewAdminEntrance).set_Size(new Size(485, 298));
		((Control)listViewAdminEntrance).set_TabIndex(2);
		listViewAdminEntrance.set_UseCompatibleStateImageBehavior(false);
		listViewAdminEntrance.set_View((View)1);
		((Control)listViewAdminEntrance).add_MouseClick(new MouseEventHandler(listViewAdminEntrance_MouseClick));
		columnHeader_0.set_Text("Potential Adminstration Entrance");
		columnHeader_0.set_Width(710);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(485, 323));
		((Control)this).get_Controls().Add((Control)(object)listViewAdminEntrance);
		((Control)this).get_Controls().Add((Control)(object)toolStripAdmin);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("FormAdmin");
		((Control)this).set_Text("FormAdmin");
		((Control)toolStripAdmin).ResumeLayout(false);
		((Control)toolStripAdmin).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public FormAdmin(FormMain formMain_1)
	{
		InitializeComponent();
		formMain_0 = formMain_1;
	}

	private void btnGetAdmin_Click(object sender, EventArgs e)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Invalid comparison between Unknown and I4
		if (string.IsNullOrEmpty(formMain_0.method_2()))
		{
			MessageBox.Show("Please input the URL at first!", "Notice", (MessageBoxButtons)0, (MessageBoxIcon)64);
			return;
		}
		listViewAdminEntrance.get_Items().Clear();
		string value = formMain_0.gclass0_0.method_23(formMain_0.method_2());
		if (!string.IsNullOrEmpty(value) || (int)MessageBox.Show("* Open a URL with a filename will help to find the admin entrance.\r\n* Such as: http://127.0.0.1/index.asp \r\n* Continue?\r\n", "Confirm", (MessageBoxButtons)1, (MessageBoxIcon)64) != 2)
		{
			formMain_0.method_11("Getting Potential Adminstration Entrance...");
			string[] array = WebCruiserWVS.Default.AdminPath.Split(new char[1] { ':' });
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				string state = array[i];
				ThreadPool.QueueUserWorkItem(method_0, state);
			}
		}
	}

	private void method_0(object object_0)
	{
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		string text = (string)object_0;
		string text2 = formMain_0.gclass0_0.method_10() + text;
		try
		{
			if (GClass0.genum4_0 == GEnum4.Stop)
			{
				Thread.CurrentThread.Abort();
			}
			HttpWebResponse httpWebResponse = formMain_0.gclass0_0.method_28(text2, GEnum0.GET);
			if (httpWebResponse.StatusCode != HttpStatusCode.OK)
			{
				return;
			}
			method_1(text2);
			if (string.IsNullOrEmpty(formMain_0.gclass0_0.string_5))
			{
				return;
			}
			string[] array = WebCruiserWVS.Default.AdminPage.Split(new char[1] { ':' });
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				if (GClass0.genum4_0 == GEnum4.Stop)
				{
					break;
				}
				string text3 = text2 + array[i] + formMain_0.gclass0_0.string_5;
				httpWebResponse = formMain_0.gclass0_0.method_28(text3, GEnum0.GET);
				if (httpWebResponse.StatusCode == HttpStatusCode.OK)
				{
					method_1(text3);
					formMain_0.method_11("Checking: " + text3 + " OK!");
				}
				else
				{
					formMain_0.method_11("Checking: " + text3 + " NotFound!");
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void method_1(string string_0)
	{
		if (!((Control)listViewAdminEntrance).get_InvokeRequired())
		{
			listViewAdminEntrance.get_Items().Add(string_0);
			return;
		}
		Delegate5 @delegate = method_1;
		((Control)this).Invoke((Delegate)@delegate, new object[1] { string_0 });
	}

	private void btnSearchEngine_Click(object sender, EventArgs e)
	{
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			formMain_0.method_11("Get Potential Admin Entrance By Search Engine...");
			string string_ = "http://www.google.com/search?as_occt=url&as_oq=admin&as_sitesearch=" + formMain_0.gclass0_0.method_11();
			string string_2 = formMain_0.gclass0_0.method_30(string_, GEnum0.GET);
			string[] array = formMain_0.gclass0_0.method_38(string_2, "http://www.google.com/", "");
			string[] array2 = array;
			foreach (string text in array2)
			{
				if (text.IndexOf(formMain_0.gclass0_0.method_10()) >= 0 && text.IndexOf(formMain_0.gclass0_0.method_11()) <= 10 && text.IndexOf("admin") > 0)
				{
					method_1(text);
				}
			}
			formMain_0.method_11("Done");
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void listViewAdminEntrance_MouseClick(object sender, MouseEventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		if (listViewAdminEntrance.get_SelectedItems().get_Count() >= 1)
		{
			ContextMenuStrip val = new ContextMenuStrip();
			((ToolStrip)val).get_Items().Add("Copy URL To ClipBoard", (Image)null, (EventHandler)method_2);
			((Control)listViewAdminEntrance).set_ContextMenuStrip(val);
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text;
			if ((text = ((ToolStripItem)(ToolStripMenuItem)sender).get_Text()) != null && text == "Copy URL To ClipBoard")
			{
				Clipboard.SetText(listViewAdminEntrance.get_SelectedItems().get_Item(0).get_Text());
			}
		}
		catch
		{
		}
	}
}
