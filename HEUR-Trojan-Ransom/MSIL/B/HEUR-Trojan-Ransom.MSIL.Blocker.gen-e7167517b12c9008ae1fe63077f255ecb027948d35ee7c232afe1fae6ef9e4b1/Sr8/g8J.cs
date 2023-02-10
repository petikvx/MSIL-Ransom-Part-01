using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using d6D;

namespace Sr8;

[DesignerGenerated]
public class g8J : Form
{
	private IContainer components;

	internal virtual Button HouseEntry
	{
		[CompilerGenerated]
		get
		{
			return _HouseEntry;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = z8Y;
			Button houseEntry = _HouseEntry;
			if (houseEntry != null)
			{
				((Control)houseEntry).remove_Click(eventHandler);
			}
			_HouseEntry = value;
			houseEntry = _HouseEntry;
			if (houseEntry != null)
			{
				((Control)houseEntry).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button RentInfo
	{
		[CompilerGenerated]
		get
		{
			return _RentInfo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = c9P;
			Button rentInfo = _RentInfo;
			if (rentInfo != null)
			{
				((Control)rentInfo).remove_Click(eventHandler);
			}
			_RentInfo = value;
			rentInfo = _RentInfo;
			if (rentInfo != null)
			{
				((Control)rentInfo).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button EBillInfo
	{
		[CompilerGenerated]
		get
		{
			return _EBillInfo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = n8Z;
			Button eBillInfo = _EBillInfo;
			if (eBillInfo != null)
			{
				((Control)eBillInfo).remove_Click(eventHandler);
			}
			_EBillInfo = value;
			eBillInfo = _EBillInfo;
			if (eBillInfo != null)
			{
				((Control)eBillInfo).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button BookingInfo
	{
		[CompilerGenerated]
		get
		{
			return _BookingInfo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Lg0;
			Button bookingInfo = _BookingInfo;
			if (bookingInfo != null)
			{
				((Control)bookingInfo).remove_Click(eventHandler);
			}
			_BookingInfo = value;
			bookingInfo = _BookingInfo;
			if (bookingInfo != null)
			{
				((Control)bookingInfo).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button AlertNotification
	{
		[CompilerGenerated]
		get
		{
			return _AlertNotification;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Zr5;
			Button alertNotification = _AlertNotification;
			if (alertNotification != null)
			{
				((Control)alertNotification).remove_Click(eventHandler);
			}
			_AlertNotification = value;
			alertNotification = _AlertNotification;
			if (alertNotification != null)
			{
				((Control)alertNotification).add_Click(eventHandler);
			}
		}
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
			EventHandler eventHandler = y4E;
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

	public g8J()
	{
		((Form)this).add_Load((EventHandler)Tq2);
		z1N();
	}

	[DebuggerNonUserCode]
	protected override void Sb9(bool i0F)
	{
		try
		{
			if (i0F && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(i0F);
		}
	}

	[DebuggerStepThrough]
	private void z1N()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		HouseEntry = new Button();
		RentInfo = new Button();
		EBillInfo = new Button();
		BookingInfo = new Button();
		AlertNotification = new Button();
		Button1 = new Button();
		((Control)this).SuspendLayout();
		((Control)HouseEntry).set_Location(new Point(100, 94));
		((Control)HouseEntry).set_Name("HouseEntry");
		((Control)HouseEntry).set_Size(new Size(173, 47));
		((Control)HouseEntry).set_TabIndex(0);
		((ButtonBase)HouseEntry).set_Text("House Entry");
		((ButtonBase)HouseEntry).set_UseVisualStyleBackColor(true);
		((Control)RentInfo).set_Location(new Point(100, 210));
		((Control)RentInfo).set_Name("RentInfo");
		((Control)RentInfo).set_Size(new Size(173, 47));
		((Control)RentInfo).set_TabIndex(1);
		((ButtonBase)RentInfo).set_Text("Rent Info");
		((ButtonBase)RentInfo).set_UseVisualStyleBackColor(true);
		((Control)EBillInfo).set_Location(new Point(100, 313));
		((Control)EBillInfo).set_Name("EBillInfo");
		((Control)EBillInfo).set_Size(new Size(173, 47));
		((Control)EBillInfo).set_TabIndex(2);
		((ButtonBase)EBillInfo).set_Text("E-Bill Info");
		((ButtonBase)EBillInfo).set_UseVisualStyleBackColor(true);
		((Control)BookingInfo).set_Location(new Point(100, 421));
		((Control)BookingInfo).set_Name("BookingInfo");
		((Control)BookingInfo).set_Size(new Size(173, 47));
		((Control)BookingInfo).set_TabIndex(3);
		((ButtonBase)BookingInfo).set_Text("Booking Info");
		((ButtonBase)BookingInfo).set_UseVisualStyleBackColor(true);
		((Control)AlertNotification).set_Location(new Point(100, 541));
		((Control)AlertNotification).set_Name("AlertNotification");
		((Control)AlertNotification).set_Size(new Size(173, 47));
		((Control)AlertNotification).set_TabIndex(4);
		((ButtonBase)AlertNotification).set_Text("Alert Notification");
		((ButtonBase)AlertNotification).set_UseVisualStyleBackColor(true);
		((Control)Button1).set_Location(new Point(530, 313));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(232, 68));
		((Control)Button1).set_TabIndex(5);
		((ButtonBase)Button1).set_Text("<----");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(924, 694));
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)AlertNotification);
		((Control)this).get_Controls().Add((Control)(object)BookingInfo);
		((Control)this).get_Controls().Add((Control)(object)EBillInfo);
		((Control)this).get_Controls().Add((Control)(object)RentInfo);
		((Control)this).get_Controls().Add((Control)(object)HouseEntry);
		((Control)this).set_Name("Admin_Function");
		((Form)this).set_Text("Admin_Function");
		((Control)this).ResumeLayout(false);
	}

	private void z8Y(object Rq9, EventArgs t0K)
	{
		((Control)b8G.Forms.House_Entry).Show();
	}

	private void c9P(object q4J, EventArgs Tq5)
	{
		((Control)b8G.Forms.Rent_Info).Show();
	}

	private void n8Z(object r7M, EventArgs Rg8)
	{
		((Control)b8G.Forms.Pay_eletricity).Show();
	}

	private void Lg0(object k9G, EventArgs Zz9)
	{
		((Control)b8G.Forms.Booking_Info).Show();
	}

	private void Zr5(object Pa1, EventArgs Gw9)
	{
		((Control)b8G.Forms.Alert_Notification).Show();
	}

	internal static bool Mj3(int d6J)
	{
		string[] array = new string[4] { "L", "o", "a", "d" };
		StringBuilder stringBuilder = new StringBuilder();
		while (Operators.CompareString(stringBuilder.ToString(), "Load", false) != 0)
		{
			string text = array[new Random().Next(0, checked(d6J + 1))];
			if (Operators.CompareString(stringBuilder.ToString(), (string)null, false) == 0 && Operators.CompareString(text, "L", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[3] { "o", "a", "d" };
				d6J = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "L", false) == 0 && Operators.CompareString(text, "o", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[2] { "a", "d" };
				d6J = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "Lo", false) == 0 && Operators.CompareString(text, "a", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[1] { "d" };
				d6J = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "Loa", false) == 0 && Operators.CompareString(text, "d", false) == 0)
			{
				stringBuilder.Append(text);
			}
		}
		if (Operators.CompareString(stringBuilder.ToString(), "Load", false) == 0)
		{
			return true;
		}
		return false;
	}

	private void y4E(object c5S, EventArgs i4Q)
	{
		((Form)this).Close();
	}

	private void Tq2(object Ms0, EventArgs j9B)
	{
	}
}
