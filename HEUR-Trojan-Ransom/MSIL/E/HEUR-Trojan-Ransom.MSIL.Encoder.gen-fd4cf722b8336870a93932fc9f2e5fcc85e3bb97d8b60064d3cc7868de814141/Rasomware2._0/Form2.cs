using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Rasomware2._0;

public class Form2 : Form
{
	private List<string> list_0 = new List<string>();

	private IContainer icontainer_0 = null;

	private Label label1;

	private TextBox txtPath;

	private Button button1;

	private ImageList imageList_0;

	private ListView listView1;

	public Form2()
	{
		InitializeComponent();
	}

	private void Form2_Load(object sender, EventArgs e)
	{
	}

	private void listView1_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		list_0.Clear();
		listView1.get_Items().Clear();
		FolderBrowserDialog val = new FolderBrowserDialog();
		val.set_Description("View Encrypted Files.");
		FolderBrowserDialog val2 = val;
		try
		{
			if ((int)((CommonDialog)val2).ShowDialog() == 1)
			{
				((Control)txtPath).set_Text(val2.get_SelectedPath());
				string[] files = Directory.GetFiles(val2.get_SelectedPath());
				foreach (string text in files)
				{
					imageList_0.get_Images().Add(Icon.ExtractAssociatedIcon(text));
					FileInfo fileInfo = new FileInfo(text);
					list_0.Add(fileInfo.FullName);
					listView1.get_Items().Add(fileInfo.Name, imageList_0.get_Images().get_Count() - 1);
				}
			}
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		icontainer_0 = new Container();
		label1 = new Label();
		txtPath = new TextBox();
		button1 = new Button();
		imageList_0 = new ImageList(icontainer_0);
		listView1 = new ListView();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Perpetua", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_Location(new Point(1, 360));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(39, 18));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Path");
		((Control)txtPath).set_Location(new Point(46, 358));
		((Control)txtPath).set_Name("txtPath");
		((TextBoxBase)txtPath).set_ReadOnly(true);
		((Control)txtPath).set_Size(new Size(525, 20));
		((Control)txtPath).set_TabIndex(1);
		((Control)button1).set_Font(new Font("Modern No. 20", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button1).set_Location(new Point(577, 358));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(2);
		((Control)button1).set_Text("......");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		imageList_0.set_ColorDepth((ColorDepth)32);
		imageList_0.set_ImageSize(new Size(32, 16));
		imageList_0.set_TransparentColor(Color.Transparent);
		listView1.set_HideSelection(false);
		listView1.set_LargeImageList(imageList_0);
		((Control)listView1).set_Location(new Point(4, 8));
		listView1.set_MultiSelect(false);
		((Control)listView1).set_Name("listView1");
		((Control)listView1).set_Size(new Size(648, 344));
		((Control)listView1).set_TabIndex(3);
		listView1.set_UseCompatibleStateImageBehavior(false);
		listView1.add_SelectedIndexChanged((EventHandler)listView1_SelectedIndexChanged);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(661, 385));
		((Control)this).get_Controls().Add((Control)(object)listView1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)txtPath);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_Name("Form2");
		((Control)this).set_Text("Form2");
		((Form)this).add_Load((EventHandler)Form2_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
