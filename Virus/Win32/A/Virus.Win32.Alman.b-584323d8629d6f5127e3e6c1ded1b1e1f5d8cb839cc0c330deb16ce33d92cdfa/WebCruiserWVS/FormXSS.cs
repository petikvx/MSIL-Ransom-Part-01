using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WebCruiserWVS;

public class FormXSS : Form
{
	private delegate void Delegate21(string string_0);

	private IContainer icontainer_0;

	private Label label23;

	private ListView listViewForm;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private TextBox txtRefPage;

	private Label label19;

	private TextBox txtActionURL;

	private Label label20;

	private Button btnAutoXSSTest;

	private TextBox txtXSSUsage;

	private Button btnOpenRefPage;

	private Button btnXSSTest;

	private Button btnGetFormFromBrowser;

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
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormXSS));
		label23 = new Label();
		listViewForm = new ListView();
		columnHeader_0 = new ColumnHeader();
		columnHeader_1 = new ColumnHeader();
		txtRefPage = new TextBox();
		label19 = new Label();
		txtActionURL = new TextBox();
		label20 = new Label();
		btnAutoXSSTest = new Button();
		txtXSSUsage = new TextBox();
		btnOpenRefPage = new Button();
		btnXSSTest = new Button();
		btnGetFormFromBrowser = new Button();
		((Control)this).SuspendLayout();
		((Control)label23).set_AutoSize(true);
		((Control)label23).set_Location(new Point(5, 54));
		((Control)label23).set_Name("label23");
		((Control)label23).set_Size(new Size(77, 12));
		((Control)label23).set_TabIndex(21);
		((Control)label23).set_Text("URL / Forms:");
		listViewForm.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[2] { columnHeader_0, columnHeader_1 });
		listViewForm.set_FullRowSelect(true);
		((Control)listViewForm).set_Location(new Point(5, 72));
		((Control)listViewForm).set_Name("listViewForm");
		((Control)listViewForm).set_Size(new Size(627, 116));
		((Control)listViewForm).set_TabIndex(20);
		listViewForm.set_UseCompatibleStateImageBehavior(false);
		listViewForm.set_View((View)1);
		((Control)listViewForm).add_Click((EventHandler)listViewForm_Click);
		columnHeader_0.set_Text("ActionURL");
		columnHeader_0.set_Width(230);
		columnHeader_1.set_Text("PostData");
		columnHeader_1.set_Width(380);
		((Control)txtRefPage).set_Location(new Point(5, 29));
		((Control)txtRefPage).set_Name("txtRefPage");
		((TextBoxBase)txtRefPage).set_ReadOnly(true);
		((Control)txtRefPage).set_Size(new Size(627, 21));
		((Control)txtRefPage).set_TabIndex(19);
		((Control)label19).set_AutoSize(true);
		((Control)label19).set_Location(new Point(5, 9));
		((Control)label19).set_Name("label19");
		((Control)label19).set_Size(new Size(71, 12));
		((Control)label19).set_TabIndex(18);
		((Control)label19).set_Text("Refer Page:");
		((Control)txtActionURL).set_Location(new Point(5, 206));
		((TextBoxBase)txtActionURL).set_Multiline(true);
		((Control)txtActionURL).set_Name("txtActionURL");
		((Control)txtActionURL).set_Size(new Size(627, 83));
		((Control)txtActionURL).set_TabIndex(17);
		((Control)label20).set_AutoSize(true);
		((Control)label20).set_Location(new Point(5, 191));
		((Control)label20).set_Name("label20");
		((Control)label20).set_Size(new Size(239, 12));
		((Control)label20).set_TabIndex(16);
		((Control)label20).set_Text("ActionURL( ? For Get, and  ^ For POST):");
		((Control)btnAutoXSSTest).set_Location(new Point(5, 294));
		((Control)btnAutoXSSTest).set_Name("btnAutoXSSTest");
		((Control)btnAutoXSSTest).set_Size(new Size(97, 23));
		((Control)btnAutoXSSTest).set_TabIndex(25);
		((Control)btnAutoXSSTest).set_Text("Auto XSS Test");
		((ButtonBase)btnAutoXSSTest).set_UseVisualStyleBackColor(true);
		((Control)btnAutoXSSTest).add_Click((EventHandler)btnAutoXSSTest_Click);
		((Control)txtXSSUsage).set_Location(new Point(5, 321));
		((TextBoxBase)txtXSSUsage).set_Multiline(true);
		((Control)txtXSSUsage).set_Name("txtXSSUsage");
		((TextBoxBase)txtXSSUsage).set_ReadOnly(true);
		((Control)txtXSSUsage).set_Size(new Size(627, 95));
		((Control)txtXSSUsage).set_TabIndex(24);
		((Control)txtXSSUsage).set_Text(componentResourceManager.GetString("txtXSSUsage.Text"));
		((Control)btnOpenRefPage).set_Location(new Point(512, 294));
		((Control)btnOpenRefPage).set_Name("btnOpenRefPage");
		((Control)btnOpenRefPage).set_Size(new Size(120, 23));
		((Control)btnOpenRefPage).set_TabIndex(23);
		((Control)btnOpenRefPage).set_Text("Open Refer Page");
		((ButtonBase)btnOpenRefPage).set_UseVisualStyleBackColor(true);
		((Control)btnOpenRefPage).add_Click((EventHandler)btnOpenRefPage_Click);
		((Control)btnXSSTest).set_Location(new Point(102, 294));
		((Control)btnXSSTest).set_Name("btnXSSTest");
		((Control)btnXSSTest).set_Size(new Size(235, 23));
		((Control)btnXSSTest).set_TabIndex(22);
		((Control)btnXSSTest).set_Text(" Get Forms From URL / Manual XSS Test");
		((ButtonBase)btnXSSTest).set_UseVisualStyleBackColor(true);
		((Control)btnXSSTest).add_Click((EventHandler)btnXSSTest_Click);
		((Control)btnGetFormFromBrowser).set_Location(new Point(337, 294));
		((Control)btnGetFormFromBrowser).set_Name("btnGetFormFromBrowser");
		((Control)btnGetFormFromBrowser).set_Size(new Size(175, 23));
		((Control)btnGetFormFromBrowser).set_TabIndex(26);
		((Control)btnGetFormFromBrowser).set_Text("Get Forms From WebBrowser");
		((ButtonBase)btnGetFormFromBrowser).set_UseVisualStyleBackColor(true);
		((Control)btnGetFormFromBrowser).add_Click((EventHandler)btnGetFormFromBrowser_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(750, 425));
		((Control)this).get_Controls().Add((Control)(object)btnGetFormFromBrowser);
		((Control)this).get_Controls().Add((Control)(object)btnAutoXSSTest);
		((Control)this).get_Controls().Add((Control)(object)txtXSSUsage);
		((Control)this).get_Controls().Add((Control)(object)btnOpenRefPage);
		((Control)this).get_Controls().Add((Control)(object)btnXSSTest);
		((Control)this).get_Controls().Add((Control)(object)label23);
		((Control)this).get_Controls().Add((Control)(object)listViewForm);
		((Control)this).get_Controls().Add((Control)(object)txtRefPage);
		((Control)this).get_Controls().Add((Control)(object)label19);
		((Control)this).get_Controls().Add((Control)(object)txtActionURL);
		((Control)this).get_Controls().Add((Control)(object)label20);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("FormXSS");
		((Control)this).set_Text("FormXSS");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public FormXSS(FormMain formMain_1)
	{
		InitializeComponent();
		formMain_0 = formMain_1;
	}

	private void method_0(string string_0)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		if (!((Control)listViewForm).get_InvokeRequired())
		{
			string[] array = string_0.Split(new char[1] { '^' });
			ListViewItem val = new ListViewItem(array[0]);
			string text = "";
			for (int i = 1; i < array.Length; i++)
			{
				if (!string.IsNullOrEmpty(text))
				{
					text += "^";
				}
				text += array[i];
			}
			val.get_SubItems().Add(text);
			listViewForm.get_Items().Add(val);
			((Control)listViewForm).Refresh();
		}
		else
		{
			Delegate21 @delegate = method_0;
			((Control)this).Invoke((Delegate)@delegate, new object[1] { string_0 });
		}
	}

	private string method_1(string string_0, int int_0)
	{
		string text = "!S!WCRTESTINPUT" + $"{int_0:D6}";
		if (string_0.IndexOf(text) < 0)
		{
			text = "!S!WCRTESTTEXTAREA" + $"{int_0:D6}";
		}
		Regex regex = new Regex("(?<=(" + text + "))[.\\s\\S]*?(?=(!E!))", RegexOptions.Multiline | RegexOptions.Singleline);
		return regex.Match(string_0).Value;
	}

	private string[] method_2(string string_0)
	{
		List<string> list = new List<string>();
		if (GClass0.genum4_0 == GEnum4.Stop)
		{
			return list.ToArray();
		}
		string[] array = string_0.Split(new char[1] { '?' });
		if (array.Length < 2)
		{
			return list.ToArray();
		}
		string[] array2 = array[1].Split(new char[1] { '&' });
		for (int i = 0; i < array2.Length; i++)
		{
			string text = array[0];
			string text2 = "";
			for (int j = 0; j < i; j++)
			{
				if (!string.IsNullOrEmpty(text2))
				{
					text2 += "&";
				}
				text2 += array2[j];
			}
			string[] array3 = array2[i].Split(new char[1] { '=' });
			string text3 = array3[0];
			string string_ = GClass0.smethod_2(string_0) + "^" + text3.ToLower() + "^XSS";
			if (formMain_0.gclass0_0.method_32(string_))
			{
				continue;
			}
			formMain_0.gclass0_0.method_2(string_);
			if (!string.IsNullOrEmpty(text2))
			{
				text2 += "&";
			}
			text2 = text2 + text3 + "=" + GClass0.smethod_12(i, "<>%3c%3e%253c%253e");
			for (int k = i + 1; k < array2.Length; k++)
			{
				if (!string.IsNullOrEmpty(text2))
				{
					text2 += "&";
				}
				text2 += array2[k];
			}
			text = text + "?" + text2;
			string string_2 = formMain_0.gclass0_0.method_30(text, GEnum0.GET);
			string text4 = method_1(string_2, i);
			if (!string.IsNullOrEmpty(text4) && text4.IndexOf("<>") >= 0)
			{
				string text5 = GClass0.smethod_6(text);
				string item = string_0 + "^^" + text3 + "^^GET^^" + text5 + "^^Cross Site Scripting(URL)";
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	private void btnAutoXSSTest_Click(object sender, EventArgs e)
	{
		string text = formMain_0.method_2();
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		((Control)txtRefPage).set_Text(text);
		string string_ = formMain_0.gclass0_0.method_30(text, GEnum0.GET);
		string[] array = formMain_0.gclass0_0.method_39(string_, text);
		string[] array2 = array;
		foreach (string text2 in array2)
		{
			string string_2 = text2.Replace("!S!", "").Replace("!E!", "");
			method_0(string_2);
		}
		string[] array3 = method_2(text);
		string[] array4 = array3;
		foreach (string text3 in array4)
		{
			if (!string.IsNullOrEmpty(text3))
			{
				formMain_0.method_10(text3 + "^Cross Site Scripting(URL)");
			}
		}
		if (GClass0.genum4_0 == GEnum4.Stop)
		{
			return;
		}
		string[] array5 = formMain_0.gclass0_0.method_40(text);
		string[] array6 = array5;
		foreach (string text4 in array6)
		{
			if (!string.IsNullOrEmpty(text4))
			{
				formMain_0.method_10(text4);
			}
		}
		formMain_0.method_24("Scanner");
	}

	private void btnXSSTest_Click(object sender, EventArgs e)
	{
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		string text2 = ((Control)txtActionURL).get_Text().Trim();
		if (string.IsNullOrEmpty(text2))
		{
			string text3 = formMain_0.method_2();
			if (!string.IsNullOrEmpty(text3))
			{
				((Control)txtRefPage).set_Text(text3);
				if (text3.IndexOf('?') > 0)
				{
					method_0(text3);
				}
				text = formMain_0.gclass0_0.method_30(text3, GEnum0.GET);
				string[] array = formMain_0.gclass0_0.method_39(text, text3);
				string[] array2 = array;
				foreach (string string_ in array2)
				{
					text2 = GClass0.smethod_6(string_);
					method_0(text2);
				}
			}
			return;
		}
		text2.IndexOf('^');
		text2.IndexOf('=');
		GEnum0 genum0_ = ((text2.IndexOf('^') > 0) ? GEnum0.POST : GEnum0.GET);
		string text4 = "";
		if (text2.IndexOf("<>") > 0)
		{
			text4 = "<>";
		}
		else if (text2.IndexOf("<script>") > 0)
		{
			int num = text2.IndexOf("<script>");
			int num2 = text2.IndexOf("</script>");
			text4 = text2.Substring(num, num2 + 9 - num);
		}
		text = formMain_0.gclass0_0.method_30(text2, genum0_);
		formMain_0.method_26(text);
		int num3 = text.IndexOf(text4);
		if (num3 >= 0)
		{
			formMain_0.method_24("Code");
			formMain_0.method_27(num3, text4.Length);
			MessageBox.Show("* XSS Data Has Been Submitted, Please Check Your Input In The Response Code Box !\r\n", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
		else
		{
			MessageBox.Show("* XSS Data Has Been Submitted, Please Check The Response In The Refer Page !\r\n* Click the button \"Open Refer Page\" to view its response !", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
	}

	private void btnOpenRefPage_Click(object sender, EventArgs e)
	{
		string text = ((Control)txtRefPage).get_Text();
		if (!string.IsNullOrEmpty(text))
		{
			formMain_0.method_28(((Control)txtRefPage).get_Text(), GEnum0.GET, "");
		}
	}

	public void method_3(string string_0, string string_1)
	{
		((Control)txtRefPage).set_Text(string_0);
		((Control)txtActionURL).set_Text(string_1);
		listViewForm.get_Items().Clear();
		method_0(string_1);
	}

	private void listViewForm_Click(object sender, EventArgs e)
	{
		try
		{
			string text = listViewForm.get_SelectedItems().get_Item(0).get_Text();
			if (listViewForm.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Count() > 1 && !string.IsNullOrEmpty(listViewForm.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(1)
				.get_Text()))
			{
				text = text + "^" + listViewForm.get_SelectedItems().get_Item(0).get_SubItems()
					.get_Item(1)
					.get_Text();
			}
			((Control)txtActionURL).set_Text(text);
		}
		catch
		{
		}
	}

	private void btnGetFormFromBrowser_Click(object sender, EventArgs e)
	{
		string string_ = formMain_0.method_2();
		string string_2 = formMain_0.method_25();
		string[] array = formMain_0.gclass0_0.method_39(string_2, string_);
		string[] array2 = array;
		foreach (string string_3 in array2)
		{
			string string_4 = GClass0.smethod_6(string_3);
			method_0(string_4);
		}
		int num = formMain_0.method_46();
		for (int j = 0; j < num; j++)
		{
			try
			{
				string string_5 = formMain_0.method_47(j);
				string string_6 = formMain_0.method_48(j);
				string[] array3 = formMain_0.gclass0_0.method_39(string_5, string_6);
				string[] array4 = array3;
				foreach (string string_7 in array4)
				{
					string string_8 = GClass0.smethod_6(string_7);
					method_0(string_8);
				}
			}
			catch
			{
			}
		}
	}
}
