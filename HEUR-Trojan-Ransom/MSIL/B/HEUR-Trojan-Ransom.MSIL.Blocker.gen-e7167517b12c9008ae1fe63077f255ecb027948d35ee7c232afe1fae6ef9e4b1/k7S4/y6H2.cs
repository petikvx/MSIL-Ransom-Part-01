using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using d6D;

namespace k7S4;

[DesignerGenerated]
public class y6H2 : Form
{
	private IContainer components;

	internal virtual Button AdminLogin
	{
		[CompilerGenerated]
		get
		{
			return _AdminLogin;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = g1PQ;
			Button adminLogin = _AdminLogin;
			if (adminLogin != null)
			{
				((Control)adminLogin).remove_Click(eventHandler);
			}
			_AdminLogin = value;
			adminLogin = _AdminLogin;
			if (adminLogin != null)
			{
				((Control)adminLogin).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button TenantLogin
	{
		[CompilerGenerated]
		get
		{
			return _TenantLogin;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Yw79;
			Button tenantLogin = _TenantLogin;
			if (tenantLogin != null)
			{
				((Control)tenantLogin).remove_Click(eventHandler);
			}
			_TenantLogin = value;
			tenantLogin = _TenantLogin;
			if (tenantLogin != null)
			{
				((Control)tenantLogin).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button ApartmentDetails
	{
		[CompilerGenerated]
		get
		{
			return _ApartmentDetails;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Lo91;
			Button apartmentDetails = _ApartmentDetails;
			if (apartmentDetails != null)
			{
				((Control)apartmentDetails).remove_Click(eventHandler);
			}
			_ApartmentDetails = value;
			apartmentDetails = _ApartmentDetails;
			if (apartmentDetails != null)
			{
				((Control)apartmentDetails).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public y6H2()
	{
		Sc45();
	}

	[DebuggerNonUserCode]
	protected override void m4MK(bool Jb83)
	{
		try
		{
			if (Jb83 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Jb83);
		}
	}

	[DebuggerStepThrough]
	private void Sc45()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(y6H2));
		AdminLogin = new Button();
		TenantLogin = new Button();
		ApartmentDetails = new Button();
		Panel1 = new Panel();
		((Control)this).SuspendLayout();
		((ButtonBase)AdminLogin).set_BackColor(SystemColors.ControlLightLight);
		((Control)AdminLogin).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)AdminLogin).set_Location(new Point(652, 121));
		((Control)AdminLogin).set_Name("AdminLogin");
		((Control)AdminLogin).set_Size(new Size(168, 50));
		((Control)AdminLogin).set_TabIndex(0);
		((ButtonBase)AdminLogin).set_Text("Admin Login");
		((ButtonBase)AdminLogin).set_UseVisualStyleBackColor(false);
		((ButtonBase)TenantLogin).set_BackColor(SystemColors.ControlLightLight);
		((Control)TenantLogin).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)TenantLogin).set_Location(new Point(652, 222));
		((Control)TenantLogin).set_Name("TenantLogin");
		((Control)TenantLogin).set_Size(new Size(168, 47));
		((Control)TenantLogin).set_TabIndex(1);
		((ButtonBase)TenantLogin).set_Text("Tenant Login");
		((ButtonBase)TenantLogin).set_UseVisualStyleBackColor(false);
		((ButtonBase)ApartmentDetails).set_BackColor(SystemColors.ControlLightLight);
		((Control)ApartmentDetails).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)ApartmentDetails).set_Location(new Point(652, 331));
		((Control)ApartmentDetails).set_Name("ApartmentDetails");
		((Control)ApartmentDetails).set_Size(new Size(168, 51));
		((Control)ApartmentDetails).set_TabIndex(2);
		((ButtonBase)ApartmentDetails).set_Text("Apartment Details");
		((ButtonBase)ApartmentDetails).set_UseVisualStyleBackColor(false);
		((Control)Panel1).set_BackgroundImage((Image)componentResourceManager.GetObject("Panel1.BackgroundImage"));
		((Control)Panel1).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Panel1).set_Location(new Point(12, 12));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(634, 501));
		((Control)Panel1).set_TabIndex(3);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(893, 583));
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).get_Controls().Add((Control)(object)ApartmentDetails);
		((Control)this).get_Controls().Add((Control)(object)TenantLogin);
		((Control)this).get_Controls().Add((Control)(object)AdminLogin);
		((Control)this).set_Name("first_page");
		((Form)this).set_Text("first_page");
		((Control)this).ResumeLayout(false);
	}

	private void g1PQ(object He61, EventArgs Tz72)
	{
		((Control)b8G.Forms.Form1).Show();
	}

	private void Yw79(object s8W6, EventArgs Wc1d)
	{
		((Control)b8G.Forms.Tenant_Login).Show();
	}

	private void Lo91(object Cr7d, EventArgs Db17)
	{
		((Control)b8G.Forms.Apartment_Details).Show();
	}

	internal static byte w5DJ(byte t1X2, byte[] Na3p, int s0CE, int Kp36)
	{
		t1X2 = (byte)(t1X2 ^ checked((byte)(Na3p[unchecked(Kp36 % Na3p.Length)] ^ ((Kp36 + unchecked(s0CE % Na3p.Length)) & s0CE))));
		return t1X2;
	}
}
