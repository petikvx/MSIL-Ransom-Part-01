using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Kz7;
using Microsoft.VisualBasic.CompilerServices;
using Xz8;
using f4S;
using f8N7;
using o3K5;
using s5R7;
using t0B;

namespace n1K;

[DesignerGenerated]
public class Fi7 : Form
{
	private Button _btnItemsCheckedout;

	private Button _btnMyProfile;

	private Button _btnEditProfile;

	private Button _btnLogout;

	private Button _Button2;

	public string UserName;

	private string desig;

	internal IContainer B;

	internal Panel Q;

	internal Panel E;

	internal Button k;

	public Fi7()
	{
		((Form)this).add_Load((EventHandler)Nc1);
		p6B();
	}

	protected override void m6G(bool p3B)
	{
		try
		{
			if (p3B && B != null)
			{
				B.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(p3B);
		}
	}

	private void p6B()
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
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected O, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Expected O, but got Unknown
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Expected O, but got Unknown
		//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Expected O, but got Unknown
		Nd6(new Panel());
		y3Z(new Button());
		p9C(new Button());
		Ys3(new Button());
		Hy4(new Button());
		x3T(new Button());
		Xy6(new Button());
		De5(new Panel());
		((Control)Wk2()).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Wk2()).set_BackColor(Color.MidnightBlue);
		((Control)Wk2()).get_Controls().Add((Control)(object)j0A());
		((Control)Wk2()).get_Controls().Add((Control)(object)Xc8());
		((Control)Wk2()).get_Controls().Add((Control)(object)Ee5());
		((Control)Wk2()).get_Controls().Add((Control)(object)c8K());
		((Control)Wk2()).get_Controls().Add((Control)(object)z2S());
		((Control)Wk2()).get_Controls().Add((Control)(object)Kn5());
		((Control)Wk2()).set_Dock((DockStyle)3);
		((Control)Wk2()).set_ForeColor(Color.Black);
		((Control)Wk2()).set_Location(new Point(0, 0));
		((Control)Wk2()).set_Name("buttonPanel");
		((Control)Wk2()).set_Size(new Size(247, 681));
		((Control)Wk2()).set_TabIndex(0);
		((ButtonBase)j0A()).set_BackColor(Color.MidnightBlue);
		((Control)j0A()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)j0A()).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)j0A()).set_FlatStyle((FlatStyle)0);
		((Control)j0A()).set_Font(new Font("Franklin Gothic Book", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)j0A()).set_ForeColor(Color.White);
		((Control)j0A()).set_Location(new Point(-3, 219));
		((Control)j0A()).set_Name("btnRecommend");
		((Control)j0A()).set_Size(new Size(247, 45));
		((Control)j0A()).set_TabIndex(6);
		((ButtonBase)j0A()).set_Text("Recommend a book");
		((ButtonBase)j0A()).set_UseVisualStyleBackColor(false);
		((ButtonBase)Xc8()).set_BackColor(Color.MidnightBlue);
		((Control)Xc8()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)Xc8()).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Xc8()).set_FlatStyle((FlatStyle)0);
		((Control)Xc8()).set_Font(new Font("Franklin Gothic Book", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Xc8()).set_ForeColor(Color.White);
		((Control)Xc8()).set_Location(new Point(0, 170));
		((Control)Xc8()).set_Name("Button2");
		((Control)Xc8()).set_Size(new Size(247, 45));
		((Control)Xc8()).set_TabIndex(5);
		((ButtonBase)Xc8()).set_Text("Change Password");
		((ButtonBase)Xc8()).set_UseVisualStyleBackColor(false);
		((ButtonBase)Ee5()).set_BackColor(Color.MidnightBlue);
		((Control)Ee5()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)Ee5()).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Ee5()).set_FlatStyle((FlatStyle)0);
		((Control)Ee5()).set_Font(new Font("Franklin Gothic Book", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Ee5()).set_ForeColor(Color.White);
		((Control)Ee5()).set_Location(new Point(0, 266));
		((Control)Ee5()).set_Name("btnLogout");
		((Control)Ee5()).set_Size(new Size(247, 45));
		((Control)Ee5()).set_TabIndex(3);
		((ButtonBase)Ee5()).set_Text("Log out");
		((ButtonBase)Ee5()).set_UseVisualStyleBackColor(false);
		((ButtonBase)c8K()).set_BackColor(Color.MidnightBlue);
		((Control)c8K()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)c8K()).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)c8K()).set_FlatStyle((FlatStyle)0);
		((Control)c8K()).set_Font(new Font("Franklin Gothic Book", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)c8K()).set_ForeColor(Color.White);
		((Control)c8K()).set_Location(new Point(0, 119));
		((Control)c8K()).set_Name("btnEditProfile");
		((Control)c8K()).set_Size(new Size(247, 45));
		((Control)c8K()).set_TabIndex(2);
		((ButtonBase)c8K()).set_Text("Edit Profile");
		((ButtonBase)c8K()).set_UseVisualStyleBackColor(false);
		((ButtonBase)z2S()).set_BackColor(Color.MidnightBlue);
		((Control)z2S()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)z2S()).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)z2S()).set_FlatStyle((FlatStyle)0);
		((Control)z2S()).set_Font(new Font("Franklin Gothic Book", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)z2S()).set_ForeColor(Color.White);
		((Control)z2S()).set_Location(new Point(0, 76));
		((Control)z2S()).set_Name("btnItemsCheckedout");
		((Control)z2S()).set_Size(new Size(247, 45));
		((Control)z2S()).set_TabIndex(1);
		((ButtonBase)z2S()).set_Text("Items Checked Out");
		((ButtonBase)z2S()).set_UseVisualStyleBackColor(false);
		((ButtonBase)Kn5()).set_BackColor(Color.MidnightBlue);
		((Control)Kn5()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)Kn5()).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Kn5()).set_FlatStyle((FlatStyle)0);
		((Control)Kn5()).set_Font(new Font("Franklin Gothic Book", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Kn5()).set_ForeColor(Color.White);
		((Control)Kn5()).set_Location(new Point(0, 33));
		((Control)Kn5()).set_Name("btnMyProfile");
		((Control)Kn5()).set_Size(new Size(247, 45));
		((Control)Kn5()).set_TabIndex(0);
		((ButtonBase)Kn5()).set_Text("My Profile");
		((ButtonBase)Kn5()).set_UseVisualStyleBackColor(false);
		((Control)Sn4()).set_Dock((DockStyle)4);
		((Control)Sn4()).set_Location(new Point(255, 0));
		((Control)Sn4()).set_Name("contentPanel");
		((Control)Sn4()).set_Size(new Size(1009, 681));
		((Control)Sn4()).set_TabIndex(1);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImageLayout((ImageLayout)0);
		((Form)this).set_ClientSize(new Size(1264, 681));
		((Control)this).get_Controls().Add((Control)(object)Wk2());
		((Control)this).get_Controls().Add((Control)(object)Sn4());
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("StudentLogin");
		((Form)this).set_Text("StudentLogin");
		((Control)Wk2()).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Panel Wk2()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nd6(Panel Cg7)
	{
		Panel val = (Q = Cg7);
	}

	[SpecialName]
	internal virtual Button z2S()
	{
		return _btnItemsCheckedout;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x3T(Button f0A)
	{
		EventHandler eventHandler = p4Q;
		Button btnItemsCheckedout = _btnItemsCheckedout;
		if (btnItemsCheckedout != null)
		{
			((Control)btnItemsCheckedout).remove_Click(eventHandler);
		}
		_btnItemsCheckedout = f0A;
		btnItemsCheckedout = _btnItemsCheckedout;
		if (btnItemsCheckedout != null)
		{
			((Control)btnItemsCheckedout).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Kn5()
	{
		return _btnMyProfile;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xy6(Button Ho1)
	{
		EventHandler eventHandler = Ax3;
		Button btnMyProfile = _btnMyProfile;
		if (btnMyProfile != null)
		{
			((Control)btnMyProfile).remove_Click(eventHandler);
		}
		_btnMyProfile = Ho1;
		btnMyProfile = _btnMyProfile;
		if (btnMyProfile != null)
		{
			((Control)btnMyProfile).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Panel Sn4()
	{
		return E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void De5(Panel Rk3)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		PaintEventHandler val = new PaintEventHandler(b4X);
		Panel e = E;
		if (e != null)
		{
			((Control)e).remove_Paint(val);
		}
		Panel val2 = (E = Rk3);
		e = E;
		if (e != null)
		{
			((Control)e).add_Paint(val);
		}
	}

	[SpecialName]
	internal virtual Button c8K()
	{
		return _btnEditProfile;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hy4(Button m3M)
	{
		EventHandler eventHandler = r3T;
		Button btnEditProfile = _btnEditProfile;
		if (btnEditProfile != null)
		{
			((Control)btnEditProfile).remove_Click(eventHandler);
		}
		_btnEditProfile = m3M;
		btnEditProfile = _btnEditProfile;
		if (btnEditProfile != null)
		{
			((Control)btnEditProfile).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Ee5()
	{
		return _btnLogout;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ys3(Button Me4)
	{
		EventHandler eventHandler = b0M;
		Button btnLogout = _btnLogout;
		if (btnLogout != null)
		{
			((Control)btnLogout).remove_Click(eventHandler);
		}
		_btnLogout = Me4;
		btnLogout = _btnLogout;
		if (btnLogout != null)
		{
			((Control)btnLogout).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Xc8()
	{
		return _Button2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p9C(Button k1E)
	{
		EventHandler eventHandler = t1S;
		Button button = _Button2;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button2 = k1E;
		button = _Button2;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button j0A()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y3Z(Button Yq0)
	{
		EventHandler eventHandler = Tx3;
		Button val = k;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (k = Yq0);
		val = k;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	private void Ax3(object sender, EventArgs e)
	{
		((ButtonBase)Kn5()).set_BackColor(Color.MediumSeaGreen);
		((ButtonBase)z2S()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)c8K()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Ee5()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Xc8()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)j0A()).set_BackColor(Color.MidnightBlue);
		((Control)Sn4()).get_Controls().Clear();
		Hp4 hp = new Hp4();
		((Control)Sn4()).get_Controls().Add((Control)(object)hp);
	}

	private void p4Q(object sender, EventArgs e)
	{
		((ButtonBase)Kn5()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)z2S()).set_BackColor(Color.MediumSeaGreen);
		((ButtonBase)c8K()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Ee5()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Xc8()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)j0A()).set_BackColor(Color.MidnightBlue);
		((Control)Sn4()).get_Controls().Clear();
		((Control)Sn4()).get_Controls().Add((Control)(object)new x7H0());
	}

	private void r3T(object sender, EventArgs e)
	{
		((ButtonBase)Kn5()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)z2S()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)c8K()).set_BackColor(Color.MediumSeaGreen);
		((ButtonBase)Ee5()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Xc8()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)j0A()).set_BackColor(Color.MidnightBlue);
		((Control)Sn4()).get_Controls().Clear();
		((Control)Sn4()).get_Controls().Add((Control)(object)new r5HK());
	}

	private void b0M(object sender, EventArgs e)
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Invalid comparison between Unknown and I4
		((ButtonBase)Kn5()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)z2S()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)c8K()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Xc8()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Ee5()).set_BackColor(Color.MediumSeaGreen);
		((ButtonBase)j0A()).set_BackColor(Color.MidnightBlue);
		DialogResult val = MessageBox.Show("Do you want to logout?", "Confirm logout", (MessageBoxButtons)4);
		if ((int)val == 6)
		{
			((Form)this).Close();
			((Control)m2A.Forms.At0()).Show();
			return;
		}
		((ButtonBase)Ee5()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Kn5()).set_BackColor(Color.MediumSeaGreen);
		((Control)Sn4()).get_Controls().Clear();
		Hp4 hp = new Hp4();
		((Control)Sn4()).get_Controls().Add((Control)(object)hp);
	}

	private void Nc1(object sender, EventArgs e)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		((ButtonBase)j0A()).set_BackColor(Color.MidnightBlue);
		OleDbConnection val = new OleDbConnection(m2A.Forms.At0().connectionString);
		val.Open();
		string text = "SELECT * FROM Users WHERE UserName = '" + UserName + "'";
		OleDbCommand val2 = new OleDbCommand(text, val);
		OleDbDataReader val3 = val2.ExecuteReader();
		while (val3.Read())
		{
			desig = Conversions.ToString(val3.get_Item("Designation"));
		}
		if (Operators.CompareString(desig, "Professor", false) == 0)
		{
			((ButtonBase)j0A()).set_Text("Recommend a Book");
		}
		else
		{
			((ButtonBase)j0A()).set_Text("Your Recommendations");
		}
		((ButtonBase)Kn5()).set_BackColor(Color.MediumSeaGreen);
		((ButtonBase)z2S()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)c8K()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Xc8()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Ee5()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)j0A()).set_BackColor(Color.MidnightBlue);
		((Control)Sn4()).get_Controls().Clear();
		Hp4 hp = new Hp4();
		((Control)Sn4()).get_Controls().Add((Control)(object)hp);
	}

	private void t1S(object sender, EventArgs e)
	{
		((ButtonBase)Kn5()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)z2S()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)c8K()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Ee5()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Xc8()).set_BackColor(Color.MediumSeaGreen);
		((ButtonBase)j0A()).set_BackColor(Color.MidnightBlue);
		((Control)Sn4()).get_Controls().Clear();
		((Control)Sn4()).get_Controls().Add((Control)(object)new x2A());
	}

	private void Tx3(object sender, EventArgs e)
	{
		((ButtonBase)Kn5()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)z2S()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)c8K()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)Ee5()).set_BackColor(Color.MidnightBlue);
		((ButtonBase)j0A()).set_BackColor(Color.MediumSeaGreen);
		((ButtonBase)Xc8()).set_BackColor(Color.MidnightBlue);
		((Control)Sn4()).get_Controls().Clear();
		if (Operators.CompareString(desig, "Professor", false) == 0)
		{
			((Control)Sn4()).get_Controls().Add((Control)(object)new Gc0());
		}
		else
		{
			((Control)Sn4()).get_Controls().Add((Control)(object)new Wi35());
		}
	}

	public void Zk0()
	{
		((Control)Sn4()).get_Controls().Clear();
		((Control)Sn4()).get_Controls().Add((Control)(object)new Gc0());
	}

	private void b4X(object sender, PaintEventArgs e)
	{
	}
}
