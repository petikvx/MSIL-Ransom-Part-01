using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace dfb44QxstTvciGRseP;

public class IXmyK0HJCkU2OT3BnK : Form
{
	private IContainer ldkRaVcDP;

	private Label V7uEMssGj;

	private ListBox ok6at0aBR;

	private Label bhMIsFUjq;

	private Label cxynksoXc;

	private Button o0V5ZNsZ9;

	private Button HVDPidm1p;

	internal static IXmyK0HJCkU2OT3BnK wIGdeifkj3DcgXhh92;

	public IXmyK0HJCkU2OT3BnK()
	{
		GRgbqpcvG2cupxT0496.SF54tCZzYSfdV();
		ldkRaVcDP = null;
		((Form)this)._002Ector();
		qrKCBi7xj();
	}

	private void UdDuOJvCI(object sender, EventArgs e)
	{
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		string text2;
		int num;
		if (((ListControl)ok6at0aBR).get_SelectedIndex() != -1)
		{
			string text = ok6at0aBR.get_SelectedItem().ToString();
			text2 = text;
			num = 0;
			if (rybDpKUeZJqDLMcmEv() != null)
			{
				goto IL_00cf;
			}
			goto IL_00d3;
		}
		MessageBox.Show("Select a city.");
		return;
		IL_00cf:
		int num2 = default(int);
		num = num2;
		goto IL_00d3;
		IL_00d3:
		string text3 = default(string);
		do
		{
			IL_00d3_2:
			switch (num)
			{
			case 2:
				if (!(text3 == "Minneapolis"))
				{
					if (text3 == "New York")
					{
						num = 1;
						if (!Msu8g7rWuj62marPu5())
						{
							goto IL_00d3_2;
						}
						goto case 1;
					}
					return;
				}
				((Control)cxynksoXc).set_Text("Central");
				return;
			case 1:
				((Control)cxynksoXc).set_Text("Eastern");
				num = 2;
				if (!Msu8g7rWuj62marPu5())
				{
					goto IL_00d3_2;
				}
				return;
			default:
				text3 = text2;
				switch (text3)
				{
				case "Denver":
					BpIUqM2Efc3wtGCJgA(cxynksoXc, "Mountain");
					return;
				case "San Francisco":
					BpIUqM2Efc3wtGCJgA(cxynksoXc, "Pacific");
					return;
				case "Honolulu":
					goto IL_0127;
				}
				break;
			case 3:
				goto IL_0127;
			case 4:
				return;
				IL_0127:
				((Control)cxynksoXc).set_Text("Hawaii-Aleutian");
				return;
			}
			num = 2;
		}
		while (rybDpKUeZJqDLMcmEv() == null);
		goto IL_00cf;
	}

	private void z4fMVqGcg(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && ldkRaVcDP != null)
		{
			if (rybDpKUeZJqDLMcmEv() != null)
			{
				switch (0)
				{
				}
			}
			ldkRaVcDP.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void qrKCBi7xj()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected O, but got Unknown
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager object_ = new ComponentResourceManager(typeof(IXmyK0HJCkU2OT3BnK));
		V7uEMssGj = new Label();
		ok6at0aBR = new ListBox();
		bhMIsFUjq = new Label();
		cxynksoXc = new Label();
		o0V5ZNsZ9 = new Button();
		HVDPidm1p = new Button();
		((Control)this).SuspendLayout();
		int num2 = default(int);
		while (true)
		{
			((Control)V7uEMssGj).set_AutoSize(true);
			int num = 1;
			if (!Msu8g7rWuj62marPu5())
			{
				goto IL_0150;
			}
			goto IL_04e9;
			IL_04e9:
			while (true)
			{
				switch (num)
				{
				case 13:
					((Control)bhMIsFUjq).set_TabIndex(2);
					((Control)bhMIsFUjq).set_Text("Time Zone:");
					hSH0ISvDcu3dLupsjA(cxynksoXc, (BorderStyle)1);
					((Control)cxynksoXc).set_Location(new Point(288, 322));
					kCqsG999dreOXwpNYf(cxynksoXc, new Padding(8, 0, 8, 0));
					((Control)cxynksoXc).set_Name("timeZoneLabel");
					((Control)cxynksoXc).set_Size(new Size(263, 52));
					((Control)cxynksoXc).set_TabIndex(3);
					num = 5;
					if (rybDpKUeZJqDLMcmEv() == null)
					{
						continue;
					}
					goto default;
				default:
					UyuQWb8a2TdY4feJgQ(ok6at0aBR, new Size(313, 221));
					((Control)ok6at0aBR).set_TabIndex(1);
					((Control)bhMIsFUjq).set_AutoSize(true);
					((Control)bhMIsFUjq).set_Location(new Point(109, 334));
					num = 6;
					if (rybDpKUeZJqDLMcmEv() == null)
					{
						continue;
					}
					goto IL_0150;
				case 12:
					((Control)V7uEMssGj).set_Size(new Size(583, 32));
					((Control)V7uEMssGj).set_TabIndex(0);
					BpIUqM2Efc3wtGCJgA(V7uEMssGj, "Select a city and I will give you the time zone.");
					goto case 8;
				case 8:
					((ListControl)ok6at0aBR).set_FormattingEnabled(true);
					ok6at0aBR.set_ItemHeight(31);
					goto case 7;
				case 7:
					pdrbVHc6DN7y0Km6A2(ok6at0aBR.get_Items(), new object[5] { "Denver", "Honolulu", "Minneapolis", "New York", "San Francisco" });
					((Control)ok6at0aBR).set_Location(new Point(171, 72));
					((Control)ok6at0aBR).set_Margin(new Padding(8, 7, 8, 7));
					((Control)ok6at0aBR).set_Name("cityListBox");
					num = 0;
					if (rybDpKUeZJqDLMcmEv() == null)
					{
						continue;
					}
					goto IL_0150;
				case 11:
					p9LiGkBulyLZGZ7qbO(bhMIsFUjq, "label2");
					((Control)bhMIsFUjq).set_Size(new Size(158, 32));
					num = 13;
					if (rybDpKUeZJqDLMcmEv() == null)
					{
						continue;
					}
					goto IL_0150;
				case 10:
					((Control)HVDPidm1p).set_Size(new Size(200, 55));
					((Control)HVDPidm1p).set_TabIndex(5);
					((Control)HVDPidm1p).set_Text("&Exit");
					((ButtonBase)HVDPidm1p).set_UseVisualStyleBackColor(true);
					((Control)HVDPidm1p).add_Click((EventHandler)z4fMVqGcg);
					((ContainerControl)this).set_AutoScaleDimensions(new SizeF(16f, 31f));
					((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
					((Form)this).set_ClientSize(new Size(779, 486));
					((Control)this).get_Controls().Add((Control)(object)HVDPidm1p);
					num2 = 4;
					goto case 4;
				case 4:
					((Control)this).get_Controls().Add((Control)(object)o0V5ZNsZ9);
					bmN2tQaB9WMLdL4y31(((Control)this).get_Controls(), cxynksoXc);
					((Control)this).get_Controls().Add((Control)(object)bhMIsFUjq);
					((Control)this).get_Controls().Add((Control)(object)ok6at0aBR);
					((Control)this).get_Controls().Add((Control)(object)V7uEMssGj);
					((Form)this).set_Icon((Icon)gOW6j7KKCQfJjkhmtB(object_, "$this.Icon"));
					((Form)this).set_Margin(new Padding(8, 7, 8, 7));
					((Control)this).set_Name("Form1");
					goto case 9;
				case 9:
					((Form)this).set_StartPosition((FormStartPosition)1);
					num = 3;
					if (rybDpKUeZJqDLMcmEv() == null)
					{
						continue;
					}
					goto IL_0150;
				case 6:
					((Control)bhMIsFUjq).set_Margin(new Padding(8, 0, 8, 0));
					goto case 11;
				case 5:
					cxynksoXc.set_TextAlign((ContentAlignment)32);
					((Control)o0V5ZNsZ9).set_Location(new Point(112, 405));
					goto case 2;
				case 2:
					((Control)o0V5ZNsZ9).set_Margin(new Padding(8, 7, 8, 7));
					p9LiGkBulyLZGZ7qbO(o0V5ZNsZ9, "okButton");
					((Control)o0V5ZNsZ9).set_Size(new Size(200, 55));
					((Control)o0V5ZNsZ9).set_TabIndex(4);
					((Control)o0V5ZNsZ9).set_Text("&OK");
					((ButtonBase)o0V5ZNsZ9).set_UseVisualStyleBackColor(true);
					((Control)o0V5ZNsZ9).add_Click((EventHandler)UdDuOJvCI);
					((Control)HVDPidm1p).set_Location(new Point(331, 405));
					((Control)HVDPidm1p).set_Margin(new Padding(8, 7, 8, 7));
					((Control)HVDPidm1p).set_Name("exitButton");
					goto case 10;
				case 1:
					BXQd3lAnv4NL8JS1ac(V7uEMssGj, new Point(35, 31));
					((Control)V7uEMssGj).set_Margin(new Padding(8, 0, 8, 0));
					p9LiGkBulyLZGZ7qbO(V7uEMssGj, "label1");
					goto case 12;
				case 14:
					break;
				case 3:
					((Control)this).set_Text("Time Zone");
					((Control)this).ResumeLayout(false);
					((Control)this).PerformLayout();
					return;
				}
				break;
			}
			continue;
			IL_0150:
			num = num2;
			goto IL_04e9;
		}
	}

	internal static bool Msu8g7rWuj62marPu5()
	{
		return wIGdeifkj3DcgXhh92 == null;
	}

	internal static IXmyK0HJCkU2OT3BnK rybDpKUeZJqDLMcmEv()
	{
		return wIGdeifkj3DcgXhh92;
	}

	internal static void BpIUqM2Efc3wtGCJgA(object object_0, object object_1)
	{
		((Control)object_0).set_Text((string)object_1);
	}

	internal static void BXQd3lAnv4NL8JS1ac(object object_0, Point point_0)
	{
		((Control)object_0).set_Location(point_0);
	}

	internal static void p9LiGkBulyLZGZ7qbO(object object_0, object object_1)
	{
		((Control)object_0).set_Name((string)object_1);
	}

	internal static void pdrbVHc6DN7y0Km6A2(object object_0, object object_1)
	{
		((ObjectCollection)object_0).AddRange((object[])object_1);
	}

	internal static void UyuQWb8a2TdY4feJgQ(object object_0, Size size_0)
	{
		((Control)object_0).set_Size(size_0);
	}

	internal static void hSH0ISvDcu3dLupsjA(object object_0, BorderStyle borderStyle_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Label)object_0).set_BorderStyle(borderStyle_0);
	}

	internal static void kCqsG999dreOXwpNYf(object object_0, Padding padding_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Control)object_0).set_Margin(padding_0);
	}

	internal static void bmN2tQaB9WMLdL4y31(object object_0, object object_1)
	{
		((ControlCollection)object_0).Add((Control)object_1);
	}

	internal static object gOW6j7KKCQfJjkhmtB(object object_0, object object_1)
	{
		return ((ResourceManager)object_0).GetObject((string)object_1);
	}
}
