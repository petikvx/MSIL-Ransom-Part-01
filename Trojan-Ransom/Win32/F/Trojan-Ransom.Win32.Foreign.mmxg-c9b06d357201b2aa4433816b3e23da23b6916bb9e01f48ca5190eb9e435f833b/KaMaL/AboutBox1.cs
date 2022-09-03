using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using KaMaL.My;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace KaMaL;

[DesignerGenerated]
public sealed class AboutBox1 : Form
{
	private static List<WeakReference> list_0 = new List<WeakReference>();

	[AccessedThroughProperty("LabelProductName")]
	private Label label_0;

	internal TableLayoutPanel tableLayoutPanel_0;

	internal PictureBox pictureBox_0;

	internal Label label_1;

	internal Label label_2;

	internal TextBox textBox_0;

	internal Button button_0;

	internal Label label_3;

	internal IContainer icontainer_0;

	public AboutBox1()
	{
		((Form)this).add_Load((EventHandler)AboutBox1_Load);
		lock (list_0)
		{
			list_0.Add(new WeakReference(this));
		}
		InitializeComponent();
		MyComputer.smethod_7();
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && icontainer_0 != null) ? true : false)
			{
				icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[SpecialName]
	internal virtual TableLayoutPanel vmethod_0()
	{
		return tableLayoutPanel_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_1(TableLayoutPanel tableLayoutPanel_1)
	{
		TableLayoutPanel val = (tableLayoutPanel_0 = tableLayoutPanel_1);
	}

	[SpecialName]
	internal virtual PictureBox vmethod_2()
	{
		return pictureBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_3(PictureBox pictureBox_1)
	{
		PictureBox val = (pictureBox_0 = pictureBox_1);
	}

	[SpecialName]
	internal virtual Label vmethod_4()
	{
		return label_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_5(Label label_4)
	{
		label_0 = label_4;
	}

	[SpecialName]
	internal virtual Label vmethod_6()
	{
		return label_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_7(Label label_4)
	{
		Label val = (label_1 = label_4);
	}

	[SpecialName]
	internal virtual Label vmethod_8()
	{
		return label_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_9(Label label_4)
	{
		Label val = (label_2 = label_4);
	}

	[SpecialName]
	internal virtual TextBox vmethod_10()
	{
		return textBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_11(TextBox textBox_1)
	{
		TextBox val = (textBox_0 = textBox_1);
	}

	[SpecialName]
	internal virtual Button vmethod_12()
	{
		return button_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_13(Button button_1)
	{
		EventHandler eventHandler = method_0;
		if (button_0 != null)
		{
			((Control)button_0).remove_Click(eventHandler);
		}
		Button val = (button_0 = button_1);
		if (button_0 != null)
		{
			((Control)button_0).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label vmethod_14()
	{
		return label_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_15(Label label_4)
	{
		Label val = (label_3 = label_4);
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
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected O, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected O, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected O, but got Unknown
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected O, but got Unknown
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0544: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0764: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AboutBox1));
		vmethod_1(new TableLayoutPanel());
		vmethod_3(new PictureBox());
		vmethod_5(new Label());
		vmethod_7(new Label());
		vmethod_15(new Label());
		vmethod_9(new Label());
		vmethod_11(new TextBox());
		vmethod_13(new Button());
		((Control)vmethod_0()).SuspendLayout();
		((ISupportInitialize)vmethod_2()).BeginInit();
		((Control)this).SuspendLayout();
		vmethod_0().set_ColumnCount(2);
		vmethod_0().get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 33f));
		vmethod_0().get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 67f));
		vmethod_0().get_Controls().Add((Control)(object)vmethod_2(), 0, 0);
		vmethod_0().get_Controls().Add((Control)(object)vmethod_4(), 1, 0);
		vmethod_0().get_Controls().Add((Control)(object)vmethod_6(), 1, 1);
		vmethod_0().get_Controls().Add((Control)(object)vmethod_14(), 1, 2);
		vmethod_0().get_Controls().Add((Control)(object)vmethod_8(), 1, 3);
		vmethod_0().get_Controls().Add((Control)(object)vmethod_10(), 1, 4);
		vmethod_0().get_Controls().Add((Control)(object)vmethod_12(), 1, 5);
		((Control)vmethod_0()).set_Dock((DockStyle)5);
		TableLayoutPanel obj = vmethod_0();
		Point location = new Point(9, 9);
		((Control)obj).set_Location(location);
		((Control)vmethod_0()).set_Name("TableLayoutPanel");
		vmethod_0().set_RowCount(6);
		vmethod_0().get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		vmethod_0().get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		vmethod_0().get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		vmethod_0().get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		vmethod_0().get_RowStyles().Add(new RowStyle((SizeType)2, 50f));
		vmethod_0().get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		TableLayoutPanel obj2 = vmethod_0();
		Size size = new Size(396, 258);
		((Control)obj2).set_Size(size);
		((Control)vmethod_0()).set_TabIndex(0);
		((Control)vmethod_2()).set_Dock((DockStyle)5);
		vmethod_2().set_Image((Image)componentResourceManager.GetObject("LogoPictureBox.Image"));
		PictureBox obj3 = vmethod_2();
		location = new Point(3, 3);
		((Control)obj3).set_Location(location);
		((Control)vmethod_2()).set_Name("LogoPictureBox");
		vmethod_0().SetRowSpan((Control)(object)vmethod_2(), 6);
		PictureBox obj4 = vmethod_2();
		size = new Size(124, 252);
		((Control)obj4).set_Size(size);
		vmethod_2().set_SizeMode((PictureBoxSizeMode)1);
		vmethod_2().set_TabIndex(0);
		vmethod_2().set_TabStop(false);
		((Control)vmethod_4()).set_Dock((DockStyle)5);
		Label obj5 = vmethod_4();
		location = new Point(136, 0);
		((Control)obj5).set_Location(location);
		Label obj6 = vmethod_4();
		Padding val = default(Padding);
		((Padding)(ref val))._002Ector(6, 0, 3, 0);
		((Control)obj6).set_Margin(val);
		Label obj7 = vmethod_4();
		size = new Size(0, 17);
		((Control)obj7).set_MaximumSize(size);
		((Control)vmethod_4()).set_Name("LabelProductName");
		Label obj8 = vmethod_4();
		size = new Size(257, 17);
		((Control)obj8).set_Size(size);
		((Control)vmethod_4()).set_TabIndex(0);
		vmethod_4().set_Text("Product Name");
		vmethod_4().set_TextAlign((ContentAlignment)16);
		((Control)vmethod_6()).set_Dock((DockStyle)5);
		Label obj9 = vmethod_6();
		location = new Point(136, 25);
		((Control)obj9).set_Location(location);
		Label obj10 = vmethod_6();
		((Padding)(ref val))._002Ector(6, 0, 3, 0);
		((Control)obj10).set_Margin(val);
		Label obj11 = vmethod_6();
		size = new Size(0, 17);
		((Control)obj11).set_MaximumSize(size);
		((Control)vmethod_6()).set_Name("LabelVersion");
		Label obj12 = vmethod_6();
		size = new Size(257, 17);
		((Control)obj12).set_Size(size);
		((Control)vmethod_6()).set_TabIndex(0);
		vmethod_6().set_Text("Version");
		vmethod_6().set_TextAlign((ContentAlignment)16);
		((Control)vmethod_14()).set_Dock((DockStyle)5);
		Label obj13 = vmethod_14();
		location = new Point(136, 50);
		((Control)obj13).set_Location(location);
		Label obj14 = vmethod_14();
		((Padding)(ref val))._002Ector(6, 0, 3, 0);
		((Control)obj14).set_Margin(val);
		Label obj15 = vmethod_14();
		size = new Size(0, 17);
		((Control)obj15).set_MaximumSize(size);
		((Control)vmethod_14()).set_Name("LabelCopyright");
		Label obj16 = vmethod_14();
		size = new Size(257, 17);
		((Control)obj16).set_Size(size);
		((Control)vmethod_14()).set_TabIndex(0);
		vmethod_14().set_Text("Copyright");
		vmethod_14().set_TextAlign((ContentAlignment)16);
		((Control)vmethod_8()).set_Dock((DockStyle)5);
		Label obj17 = vmethod_8();
		location = new Point(136, 75);
		((Control)obj17).set_Location(location);
		Label obj18 = vmethod_8();
		((Padding)(ref val))._002Ector(6, 0, 3, 0);
		((Control)obj18).set_Margin(val);
		Label obj19 = vmethod_8();
		size = new Size(0, 17);
		((Control)obj19).set_MaximumSize(size);
		((Control)vmethod_8()).set_Name("LabelCompanyName");
		Label obj20 = vmethod_8();
		size = new Size(257, 17);
		((Control)obj20).set_Size(size);
		((Control)vmethod_8()).set_TabIndex(0);
		vmethod_8().set_Text("Company Name");
		vmethod_8().set_TextAlign((ContentAlignment)16);
		((Control)vmethod_10()).set_Dock((DockStyle)5);
		TextBox obj21 = vmethod_10();
		location = new Point(136, 103);
		((Control)obj21).set_Location(location);
		TextBox obj22 = vmethod_10();
		((Padding)(ref val))._002Ector(6, 3, 3, 3);
		((Control)obj22).set_Margin(val);
		vmethod_10().set_Multiline(true);
		((Control)vmethod_10()).set_Name("TextBoxDescription");
		((TextBoxBase)vmethod_10()).set_ReadOnly(true);
		vmethod_10().set_ScrollBars((ScrollBars)3);
		TextBox obj23 = vmethod_10();
		size = new Size(257, 123);
		((Control)obj23).set_Size(size);
		((Control)vmethod_10()).set_TabIndex(0);
		((Control)vmethod_10()).set_TabStop(false);
		vmethod_10().set_Text(componentResourceManager.GetString("TextBoxDescription.Text"));
		((Control)vmethod_12()).set_Anchor((AnchorStyles)10);
		vmethod_12().set_DialogResult((DialogResult)2);
		Button obj24 = vmethod_12();
		location = new Point(318, 232);
		((Control)obj24).set_Location(location);
		((Control)vmethod_12()).set_Name("OKButton");
		Button obj25 = vmethod_12();
		size = new Size(75, 23);
		((Control)obj25).set_Size(size);
		((Control)vmethod_12()).set_TabIndex(0);
		((ButtonBase)vmethod_12()).set_Text("&OK");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_CancelButton((IButtonControl)(object)vmethod_12());
		size = new Size(414, 276);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)vmethod_0());
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("AboutBox1");
		((Padding)(ref val))._002Ector(9);
		((Control)this).set_Padding(val);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Form)this).set_Text("AboutBox1");
		((Control)vmethod_0()).ResumeLayout(false);
		((Control)vmethod_0()).PerformLayout();
		((ISupportInitialize)vmethod_2()).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void AboutBox1_Load(object sender, EventArgs e)
	{
		string arg = ((Operators.CompareString(((ApplicationBase)MyProject.MyApplication_0).get_Info().get_Title(), "", false) == 0) ? Path.GetFileNameWithoutExtension(((ApplicationBase)MyProject.MyApplication_0).get_Info().get_AssemblyName()) : ((ApplicationBase)MyProject.MyApplication_0).get_Info().get_Title());
		((Form)this).set_Text($"About {arg}");
		vmethod_4().set_Text(((ApplicationBase)MyProject.MyApplication_0).get_Info().get_ProductName());
		vmethod_6().set_Text($"Version {((ApplicationBase)MyProject.MyApplication_0).get_Info().get_Version().ToString()}");
		vmethod_14().set_Text(((ApplicationBase)MyProject.MyApplication_0).get_Info().get_Copyright());
		vmethod_8().set_Text(((ApplicationBase)MyProject.MyApplication_0).get_Info().get_CompanyName());
		vmethod_10().set_Text(((ApplicationBase)MyProject.MyApplication_0).get_Info().get_Description());
	}

	private void method_0(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
