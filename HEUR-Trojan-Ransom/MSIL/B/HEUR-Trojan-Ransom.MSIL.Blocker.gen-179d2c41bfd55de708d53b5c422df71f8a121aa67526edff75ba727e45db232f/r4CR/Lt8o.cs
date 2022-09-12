using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lt35;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using o3D8;

namespace r4CR;

[DesignerGenerated]
public sealed class Lt8o : Form
{
	private TableLayoutPanel _TableLayoutPanel;

	private Label _LabelCompanyName;

	private TextBox _TextBoxDescription;

	internal PictureBox S;

	internal Label Y;

	internal Label O;

	internal Button U;

	internal Label E;

	internal IContainer P;

	public Lt8o()
	{
		((Form)this).add_Load((EventHandler)Rg0o);
		n7ZW();
	}

	protected override void s5D7(bool Qw54)
	{
		try
		{
			if (Qw54 && P != null)
			{
				P.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Qw54);
		}
	}

	[SpecialName]
	internal virtual TableLayoutPanel Qr0f()
	{
		return _TableLayoutPanel;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yq12(TableLayoutPanel b1F6)
	{
		_TableLayoutPanel = b1F6;
	}

	[SpecialName]
	internal virtual PictureBox t9H7()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Es87(PictureBox Xs8k)
	{
		PictureBox val = (S = Xs8k);
	}

	[SpecialName]
	internal virtual Label De28()
	{
		return Y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yf24(Label Hq46)
	{
		Label val = (Y = Hq46);
	}

	[SpecialName]
	internal virtual Label q6KB()
	{
		return O;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wp1j(Label w3B5)
	{
		Label val = (O = w3B5);
	}

	[SpecialName]
	internal virtual Label e8A1()
	{
		return _LabelCompanyName;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j0J9(Label Aj7t)
	{
		_LabelCompanyName = Aj7t;
	}

	[SpecialName]
	internal virtual TextBox s9GR()
	{
		return _TextBoxDescription;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wo18(TextBox Ts18)
	{
		_TextBoxDescription = Ts18;
	}

	[SpecialName]
	internal virtual Button Fz47()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Db5j(Button Rm53)
	{
		EventHandler eventHandler = m9CQ;
		Button u = U;
		if (u != null)
		{
			((Control)u).remove_Click(eventHandler);
		}
		Button val = (U = Rm53);
		u = U;
		if (u != null)
		{
			((Control)u).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Po5g()
	{
		return E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yz91(Label g4KN)
	{
		Label val = (E = g4KN);
	}

	private void n7ZW()
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
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f6: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Lt8o));
		Yq12(new TableLayoutPanel());
		Es87(new PictureBox());
		Yf24(new Label());
		Wp1j(new Label());
		Yz91(new Label());
		j0J9(new Label());
		Wo18(new TextBox());
		Db5j(new Button());
		((Control)Qr0f()).SuspendLayout();
		((ISupportInitialize)t9H7()).BeginInit();
		((Control)this).SuspendLayout();
		Qr0f().set_ColumnCount(2);
		Qr0f().get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 33f));
		Qr0f().get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 67f));
		Qr0f().get_Controls().Add((Control)(object)t9H7(), 0, 0);
		Qr0f().get_Controls().Add((Control)(object)De28(), 1, 0);
		Qr0f().get_Controls().Add((Control)(object)q6KB(), 1, 1);
		Qr0f().get_Controls().Add((Control)(object)Po5g(), 1, 2);
		Qr0f().get_Controls().Add((Control)(object)e8A1(), 1, 3);
		Qr0f().get_Controls().Add((Control)(object)s9GR(), 1, 4);
		Qr0f().get_Controls().Add((Control)(object)Fz47(), 1, 5);
		((Control)Qr0f()).set_Dock((DockStyle)5);
		((Control)Qr0f()).set_Location(new Point(9, 9));
		((Control)Qr0f()).set_Name("TableLayoutPanel");
		Qr0f().set_RowCount(6);
		Qr0f().get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		Qr0f().get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		Qr0f().get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		Qr0f().get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		Qr0f().get_RowStyles().Add(new RowStyle((SizeType)2, 50f));
		Qr0f().get_RowStyles().Add(new RowStyle((SizeType)2, 10f));
		((Control)Qr0f()).set_Size(new Size(655, 296));
		((Control)Qr0f()).set_TabIndex(0);
		((Control)t9H7()).set_Dock((DockStyle)5);
		((Control)t9H7()).set_Location(new Point(3, 3));
		((Control)t9H7()).set_Name("LogoPictureBox");
		Qr0f().SetRowSpan((Control)(object)t9H7(), 6);
		((Control)t9H7()).set_Size(new Size(210, 290));
		t9H7().set_SizeMode((PictureBoxSizeMode)1);
		t9H7().set_TabIndex(0);
		t9H7().set_TabStop(false);
		((Control)De28()).set_Dock((DockStyle)5);
		((Control)De28()).set_Location(new Point(222, 0));
		((Control)De28()).set_Margin(new Padding(6, 0, 3, 0));
		((Control)De28()).set_MaximumSize(new Size(0, 17));
		((Control)De28()).set_Name("LabelProductName");
		((Control)De28()).set_Size(new Size(430, 17));
		((Control)De28()).set_TabIndex(0);
		De28().set_Text("Library Management System");
		De28().set_TextAlign((ContentAlignment)16);
		((Control)q6KB()).set_Dock((DockStyle)5);
		((Control)q6KB()).set_Location(new Point(222, 29));
		((Control)q6KB()).set_Margin(new Padding(6, 0, 3, 0));
		((Control)q6KB()).set_MaximumSize(new Size(0, 17));
		((Control)q6KB()).set_Name("LabelVersion");
		((Control)q6KB()).set_Size(new Size(430, 17));
		((Control)q6KB()).set_TabIndex(0);
		q6KB().set_Text("1.0");
		q6KB().set_TextAlign((ContentAlignment)16);
		((Control)Po5g()).set_Dock((DockStyle)5);
		((Control)Po5g()).set_Location(new Point(222, 58));
		((Control)Po5g()).set_Margin(new Padding(6, 0, 3, 0));
		((Control)Po5g()).set_MaximumSize(new Size(0, 17));
		((Control)Po5g()).set_Name("LabelCopyright");
		((Control)Po5g()).set_Size(new Size(430, 17));
		((Control)Po5g()).set_TabIndex(0);
		Po5g().set_Text("Designed By : Shanshank and Nigel");
		Po5g().set_TextAlign((ContentAlignment)16);
		((Control)e8A1()).set_Dock((DockStyle)5);
		((Control)e8A1()).set_Location(new Point(222, 87));
		((Control)e8A1()).set_Margin(new Padding(6, 0, 3, 0));
		((Control)e8A1()).set_MaximumSize(new Size(0, 17));
		((Control)e8A1()).set_Name("LabelCompanyName");
		((Control)e8A1()).set_Size(new Size(430, 17));
		((Control)e8A1()).set_TabIndex(0);
		e8A1().set_Text("Fifth Semster CSE");
		e8A1().set_TextAlign((ContentAlignment)16);
		((Control)s9GR()).set_Dock((DockStyle)5);
		((Control)s9GR()).set_Location(new Point(222, 119));
		((Control)s9GR()).set_Margin(new Padding(6, 3, 3, 3));
		s9GR().set_Multiline(true);
		((Control)s9GR()).set_Name("TextBoxDescription");
		((TextBoxBase)s9GR()).set_ReadOnly(true);
		s9GR().set_ScrollBars((ScrollBars)3);
		((Control)s9GR()).set_Size(new Size(430, 142));
		((Control)s9GR()).set_TabIndex(0);
		((Control)s9GR()).set_TabStop(false);
		s9GR().set_Text(componentResourceManager.GetString("TextBoxDescription.Text"));
		((Control)Fz47()).set_Anchor((AnchorStyles)10);
		Fz47().set_DialogResult((DialogResult)2);
		((Control)Fz47()).set_Location(new Point(577, 270));
		((Control)Fz47()).set_Name("OKButton");
		((Control)Fz47()).set_Size(new Size(75, 23));
		((Control)Fz47()).set_TabIndex(0);
		((ButtonBase)Fz47()).set_Text("&OK");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_CancelButton((IButtonControl)(object)Fz47());
		((Form)this).set_ClientSize(new Size(673, 314));
		((Control)this).get_Controls().Add((Control)(object)Qr0f());
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("AboutBox1");
		((Control)this).set_Padding(new Padding(9));
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Form)this).set_Text("About Us");
		((Control)Qr0f()).ResumeLayout(false);
		((Control)Qr0f()).PerformLayout();
		((ISupportInitialize)t9H7()).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void Rg0o(object sender, EventArgs e)
	{
		((Form)this).set_Text(string.Format("About {0}", "Library Mangement System"));
		De28().set_Text("Library Management System");
		q6KB().set_Text($"Version {((ApplicationBase)Fb9z.Application).get_Info().get_Version().ToString()}");
		Po5g().set_Text("Designed By : Shanshank and Nigel");
		e8A1().set_Text("Fifth Semster CSE");
		s9GR().set_Text("Description :\n\n     Our project is all about how one can access the library books and different fuctions like searching books for a student and all can be done easily.\n\n     In our project user can search for books using Book Number,Author Name or but Title of the Book\n\n     In Admin mode or Librarian can Add New Books, Update the Current Books as well as he can delete the existing books in the data base.");
	}

	private void m9CQ(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	internal static bool Sr21()
	{
		string[] array = new string[2] { "https://www.google.com/", "https://www.bing.com/" };
		int num = 0;
		checked
		{
			while (num != 2)
			{
				string[] array2 = array;
				foreach (string nx in array2)
				{
					if (!g0W3.p3M6(nx))
					{
						if (num > 0)
						{
							num--;
						}
						Task.Delay(30000).Wait();
					}
					else
					{
						num++;
					}
				}
			}
			if (num == 2)
			{
				return true;
			}
			return false;
		}
	}
}
