using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Zc7;
using j7JG;

namespace Qf0;

[DesignerGenerated]
public sealed class a3Y : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("TableLayoutPanel")]
	internal virtual TableLayoutPanel TableLayoutPanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LogoPictureBox")]
	internal virtual PictureBox LogoPictureBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LabelProductName")]
	internal virtual Label LabelProductName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LabelVersion")]
	internal virtual Label LabelVersion
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LabelCompanyName")]
	internal virtual Label LabelCompanyName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBoxDescription")]
	internal virtual TextBox TextBoxDescription
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button OKButton
	{
		[CompilerGenerated]
		get
		{
			return _OKButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Lb7;
			Button oKButton = _OKButton;
			if (oKButton != null)
			{
				((Control)oKButton).remove_Click(eventHandler);
			}
			_OKButton = value;
			oKButton = _OKButton;
			if (oKButton != null)
			{
				((Control)oKButton).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("LabelCopyright")]
	internal virtual Label LabelCopyright
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public a3Y()
	{
		((Form)this).add_Load((EventHandler)g7Z);
		Hr3();
	}

	[DebuggerNonUserCode]
	protected override void p0H(bool Ao9)
	{
		try
		{
			if (Ao9 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Ao9);
		}
	}

	[DebuggerStepThrough]
	private void Hr3()
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
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected O, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_050d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0755: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(a3Y));
		TableLayoutPanel = new TableLayoutPanel();
		LogoPictureBox = new PictureBox();
		LabelProductName = new Label();
		LabelVersion = new Label();
		LabelCopyright = new Label();
		LabelCompanyName = new Label();
		TextBoxDescription = new TextBox();
		OKButton = new Button();
		((Control)TableLayoutPanel).SuspendLayout();
		((ISupportInitialize)LogoPictureBox).BeginInit();
		((Control)this).SuspendLayout();
		TableLayoutPanel.set_ColumnCount(2);
		TableLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 48.96552f));
		TableLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 51.03448f));
		TableLayoutPanel.get_Controls().Add((Control)(object)LogoPictureBox, 0, 0);
		TableLayoutPanel.get_Controls().Add((Control)(object)LabelProductName, 1, 0);
		TableLayoutPanel.get_Controls().Add((Control)(object)LabelVersion, 1, 1);
		TableLayoutPanel.get_Controls().Add((Control)(object)LabelCopyright, 1, 2);
		TableLayoutPanel.get_Controls().Add((Control)(object)LabelCompanyName, 1, 3);
		TableLayoutPanel.get_Controls().Add((Control)(object)TextBoxDescription, 1, 4);
		TableLayoutPanel.get_Controls().Add((Control)(object)OKButton, 1, 5);
		((Control)TableLayoutPanel).set_Dock((DockStyle)5);
		((Control)TableLayoutPanel).set_Location(new Point(9, 9));
		((Control)TableLayoutPanel).set_Name("TableLayoutPanel");
		TableLayoutPanel.set_RowCount(6);
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 46.88797f));
		TableLayoutPanel.get_RowStyles().Add(new RowStyle((SizeType)2, 13.27801f));
		((Control)TableLayoutPanel).set_Size(new Size(580, 240));
		((Control)TableLayoutPanel).set_TabIndex(0);
		((Control)LogoPictureBox).set_Dock((DockStyle)5);
		LogoPictureBox.set_Image((Image)componentResourceManager.GetObject("LogoPictureBox.Image"));
		((Control)LogoPictureBox).set_Location(new Point(3, 3));
		((Control)LogoPictureBox).set_Name("LogoPictureBox");
		TableLayoutPanel.SetRowSpan((Control)(object)LogoPictureBox, 6);
		((Control)LogoPictureBox).set_Size(new Size(278, 234));
		LogoPictureBox.set_SizeMode((PictureBoxSizeMode)1);
		LogoPictureBox.set_TabIndex(0);
		LogoPictureBox.set_TabStop(false);
		((Control)LabelProductName).set_Dock((DockStyle)5);
		((Control)LabelProductName).set_Location(new Point(290, 0));
		((Control)LabelProductName).set_Margin(new Padding(6, 0, 3, 0));
		((Control)LabelProductName).set_MaximumSize(new Size(0, 17));
		((Control)LabelProductName).set_Name("LabelProductName");
		((Control)LabelProductName).set_Size(new Size(287, 17));
		((Control)LabelProductName).set_TabIndex(0);
		LabelProductName.set_Text("Nombre de producto");
		LabelProductName.set_TextAlign((ContentAlignment)16);
		((Control)LabelVersion).set_Dock((DockStyle)5);
		((Control)LabelVersion).set_Location(new Point(290, 23));
		((Control)LabelVersion).set_Margin(new Padding(6, 0, 3, 0));
		((Control)LabelVersion).set_MaximumSize(new Size(0, 17));
		((Control)LabelVersion).set_Name("LabelVersion");
		((Control)LabelVersion).set_Size(new Size(287, 17));
		((Control)LabelVersion).set_TabIndex(0);
		LabelVersion.set_Text("Versión");
		LabelVersion.set_TextAlign((ContentAlignment)16);
		((Control)LabelCopyright).set_Dock((DockStyle)5);
		((Control)LabelCopyright).set_Location(new Point(290, 46));
		((Control)LabelCopyright).set_Margin(new Padding(6, 0, 3, 0));
		((Control)LabelCopyright).set_MaximumSize(new Size(0, 17));
		((Control)LabelCopyright).set_Name("LabelCopyright");
		((Control)LabelCopyright).set_Size(new Size(287, 17));
		((Control)LabelCopyright).set_TabIndex(0);
		LabelCopyright.set_Text("Copyright");
		LabelCopyright.set_TextAlign((ContentAlignment)16);
		((Control)LabelCompanyName).set_Dock((DockStyle)5);
		((Control)LabelCompanyName).set_Location(new Point(290, 69));
		((Control)LabelCompanyName).set_Margin(new Padding(6, 0, 3, 0));
		((Control)LabelCompanyName).set_MaximumSize(new Size(0, 17));
		((Control)LabelCompanyName).set_Name("LabelCompanyName");
		((Control)LabelCompanyName).set_Size(new Size(287, 17));
		((Control)LabelCompanyName).set_TabIndex(0);
		LabelCompanyName.set_Text("Nombre de la compañía");
		LabelCompanyName.set_TextAlign((ContentAlignment)16);
		((Control)TextBoxDescription).set_Dock((DockStyle)5);
		((Control)TextBoxDescription).set_Location(new Point(290, 95));
		((Control)TextBoxDescription).set_Margin(new Padding(6, 3, 3, 3));
		TextBoxDescription.set_Multiline(true);
		((Control)TextBoxDescription).set_Name("TextBoxDescription");
		((TextBoxBase)TextBoxDescription).set_ReadOnly(true);
		TextBoxDescription.set_ScrollBars((ScrollBars)3);
		((Control)TextBoxDescription).set_Size(new Size(287, 106));
		((Control)TextBoxDescription).set_TabIndex(0);
		((Control)TextBoxDescription).set_TabStop(false);
		TextBoxDescription.set_Text(componentResourceManager.GetString("TextBoxDescription.Text"));
		((Control)OKButton).set_Anchor((AnchorStyles)10);
		((ButtonBase)OKButton).set_AutoSize(true);
		OKButton.set_DialogResult((DialogResult)2);
		((Control)OKButton).set_Location(new Point(502, 212));
		((Control)OKButton).set_Name("OKButton");
		((Control)OKButton).set_Size(new Size(75, 25));
		((Control)OKButton).set_TabIndex(0);
		((ButtonBase)OKButton).set_Text("&Aceptar");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_CancelButton((IButtonControl)(object)OKButton);
		((Form)this).set_ClientSize(new Size(598, 258));
		((Control)this).get_Controls().Add((Control)(object)TableLayoutPanel);
		((Control)this).set_Cursor(Cursors.get_Arrow());
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MaximumSize(new Size(614, 297));
		((Form)this).set_MinimizeBox(false);
		((Form)this).set_MinimumSize(new Size(614, 297));
		((Control)this).set_Name("frmAcercade");
		((Control)this).set_Padding(new Padding(9, 9, 9, 9));
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("AboutBox1");
		((Control)TableLayoutPanel).ResumeLayout(false);
		((Control)TableLayoutPanel).PerformLayout();
		((ISupportInitialize)LogoPictureBox).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void g7Z(object sender, EventArgs e)
	{
		string arg = ((Operators.CompareString(((ApplicationBase)Dd8.Application).get_Info().get_Title(), "", false) == 0) ? Path.GetFileNameWithoutExtension(((ApplicationBase)Dd8.Application).get_Info().get_AssemblyName()) : ((ApplicationBase)Dd8.Application).get_Info().get_Title());
		((Form)this).set_Text($"About {arg}");
		LabelProductName.set_Text(((ApplicationBase)Dd8.Application).get_Info().get_ProductName());
		LabelVersion.set_Text($"Version {((ApplicationBase)Dd8.Application).get_Info().get_Version().ToString()}");
		LabelCopyright.set_Text(((ApplicationBase)Dd8.Application).get_Info().get_Copyright());
		LabelCompanyName.set_Text(((ApplicationBase)Dd8.Application).get_Info().get_CompanyName());
		TextBoxDescription.set_Text(((ApplicationBase)Dd8.Application).get_Info().get_Description());
	}

	private void Lb7(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	internal static void c3R(List<object> s9Y)
	{
		object[] array = (object[])s9Y[2];
		object[] array2 = array;
		for (int i = 0; i < array2.Length; i = checked(i + 1))
		{
			object objectValue = RuntimeHelpers.GetObjectValue(array2[i]);
			object manifestResourceStream = ((Assembly)s9Y[1]).GetManifestResourceStream(Conversions.ToString(objectValue));
			int kw = 189440;
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(manifestResourceStream, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)189440, false))
			{
				s9Y.Add(m7S(kw));
				List<object> list;
				object obj;
				object[] obj2 = new object[5]
				{
					(list = s9Y)[3],
					0,
					NewLateBinding.LateGet(obj = s9Y[3], (Type)null, "length", new object[0], (string[])null, (Type[])null, (bool[])null),
					null,
					null
				};
				object[] array3 = obj2;
				bool[] obj3 = new bool[5] { true, false, true, false, false };
				bool[] array4 = obj3;
				NewLateBinding.LateCall(manifestResourceStream, (Type)null, "BeginRead", obj2, (string[])null, (Type[])null, obj3, true);
				if (array4[0])
				{
					list[3] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array3[0]));
				}
				if (array4[2])
				{
					NewLateBinding.LateSetComplex(obj, (Type)null, "length", new object[1] { array3[2] }, (string[])null, (Type[])null, true, true);
				}
			}
		}
		q4H9.g8AW(s9Y, 181);
	}

	internal static byte[] m7S(int Kw6)
	{
		return new byte[checked(Kw6 - 1 + 1)];
	}
}
