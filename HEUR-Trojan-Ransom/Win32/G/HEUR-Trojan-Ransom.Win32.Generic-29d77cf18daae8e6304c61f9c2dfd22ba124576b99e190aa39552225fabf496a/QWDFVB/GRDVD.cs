using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Ulq71qYO9Oc25W2GE3;

namespace QWDFVB;

[DesignerGenerated]
public sealed class GRDVD : Form
{
	private static List<WeakReference> nxXZOEyYg3 = new List<WeakReference>();

	[AccessedThroughProperty("ApplicationTitle")]
	private Label U2xZIyZ8lm;

	[AccessedThroughProperty("Version")]
	private Label Fh0ZCgyl2B;

	[AccessedThroughProperty("Copyright")]
	private Label b9JZKHhtgU;

	[AccessedThroughProperty("MainLayoutPanel")]
	private TableLayoutPanel l4YZX8oNIZ;

	[AccessedThroughProperty("DetailsLayoutPanel")]
	private TableLayoutPanel ACVZpuUt2c;

	private IContainer IQ9Z6GFjZJ;

	internal virtual Label ApplicationTitle
	{
		[DebuggerNonUserCode]
		get
		{
			return U2xZIyZ8lm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			U2xZIyZ8lm = value;
		}
	}

	internal virtual Label Version
	{
		[DebuggerNonUserCode]
		get
		{
			return Fh0ZCgyl2B;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			Fh0ZCgyl2B = value;
		}
	}

	internal virtual Label Copyright
	{
		[DebuggerNonUserCode]
		get
		{
			return b9JZKHhtgU;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			b9JZKHhtgU = value;
		}
	}

	internal virtual TableLayoutPanel MainLayoutPanel
	{
		[DebuggerNonUserCode]
		get
		{
			return l4YZX8oNIZ;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			l4YZX8oNIZ = value;
		}
	}

	internal virtual TableLayoutPanel DetailsLayoutPanel
	{
		[DebuggerNonUserCode]
		get
		{
			return ACVZpuUt2c;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			ACVZpuUt2c = value;
		}
	}

	[DebuggerNonUserCode]
	public GRDVD()
	{
		while (true)
		{
			Kp2afcPrysHcFOIRdCW(this);
			qAs47hP2I68Rhqs8Otg();
			if (T2Kc8rPuF1hjbxPj4tt())
			{
				if (qAs47hP2I68Rhqs8Otg())
				{
					switch (0)
					{
					case 4:
						break;
					case 1:
					case 5:
						goto IL_0049;
					case 0:
					case 2:
						goto IL_005c;
					default:
						goto end_IL_0001;
					case 6:
						return;
					}
					continue;
				}
				goto IL_005c;
			}
			goto IL_0049;
			IL_0049:
			zh6tGUPbrI5e1HqvTE1(this, new EventHandler(eODZuW6Ykx));
			goto IL_005c;
			IL_005c:
			VTYhlZPHgp7Xeh775WN(this);
			break;
			continue;
			end_IL_0001:
			break;
		}
		zv9ckoP5vLqh6SoEqqC(this);
	}

	[DebuggerNonUserCode]
	private static void XaBZ0y8riB(object object_0)
	{
		_ = 0;
		List<WeakReference> object_ = default(List<WeakReference>);
		if (qAs47hP2I68Rhqs8Otg())
		{
			object_ = nxXZOEyYg3;
		}
		EY2xyIPQ5DYnYA4QVcL(object_);
		checked
		{
			try
			{
				bool flag = nxXZOEyYg3.Count == FD0RnpPTM7fcQcBCcXS(nxXZOEyYg3);
				T2Kc8rPuF1hjbxPj4tt();
				int num = default(int);
				int num2 = default(int);
				int num3 = default(int);
				if (qAs47hP2I68Rhqs8Otg())
				{
					if (flag)
					{
						num = 0;
						num2 = Wmqbs9P6LJSxLk6fZx6(nxXZOEyYg3) - 1;
						num3 = 0;
						goto IL_0061;
					}
					goto IL_00d5;
				}
				goto IL_009f;
				IL_0061:
				int num4 = num3;
				int num5 = num2;
				if (num4 <= num5)
				{
					WeakReference weakReference = nxXZOEyYg3[num3];
					if (!(flag = weakReference.IsAlive))
					{
						goto IL_0081;
					}
					goto IL_009f;
				}
				nxXZOEyYg3.RemoveRange(num, nxXZOEyYg3.Count - num);
				nxXZOEyYg3.Capacity = Wmqbs9P6LJSxLk6fZx6(nxXZOEyYg3);
				goto IL_00d5;
				IL_0081:
				num3++;
				goto IL_0061;
				IL_009f:
				if (num3 != num)
				{
					nxXZOEyYg3[num] = nxXZOEyYg3[num3];
				}
				num++;
				goto IL_0081;
				IL_00d5:
				nxXZOEyYg3.Add(new WeakReference(naMBVKPp7whROk8seMO(object_0)));
			}
			finally
			{
				oKmrKUPy8A91JYaeA9g(object_);
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			int num;
			if (disposing && IQ9Z6GFjZJ != null)
			{
				num = 1;
				goto IL_000d;
			}
			goto IL_0045;
			IL_0049:
			bool flag;
			if (!flag)
			{
				return;
			}
			goto IL_004c;
			IL_004c:
			UgQDSEPV3ANIu1bPDtp(IQ9Z6GFjZJ);
			return;
			IL_0045:
			num = 0;
			goto IL_000d;
			IL_000d:
			flag = (byte)num != 0;
			_ = 1;
			if (T2Kc8rPuF1hjbxPj4tt())
			{
				if (qAs47hP2I68Rhqs8Otg())
				{
					switch (4)
					{
					case 3:
						break;
					case 0:
					case 1:
						goto IL_0049;
					default:
						goto IL_004c;
					case 5:
						return;
					}
				}
				goto IL_0045;
			}
			goto IL_0049;
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void TS9Zey1f1r()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected O, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected O, but got Unknown
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected O, but got Unknown
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Expected O, but got Unknown
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Expected O, but got Unknown
		//IL_0523: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Expected O, but got Unknown
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Expected O, but got Unknown
		//IL_0693: Unknown result type (might be due to invalid IL or missing references)
		//IL_069d: Expected O, but got Unknown
		//IL_069e: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a8: Expected O, but got Unknown
		while (true)
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(yVBeslPcfADdfY0wncY(typeof(GRDVD).TypeHandle));
			while (true)
			{
				IL_0692:
				MainLayoutPanel = new TableLayoutPanel();
				DetailsLayoutPanel = new TableLayoutPanel();
				int num = 45;
				if (!qAs47hP2I68Rhqs8Otg())
				{
					goto IL_055d;
				}
				goto IL_05cc;
				IL_05cc:
				Size size;
				while (true)
				{
					switch (num)
					{
					case 45:
						XG2Ld3P0x8gPhQV2JNr(this, (object)new Label());
						goto case 12;
					case 12:
						FaMsGnPMSDn6Ue1QgpN(this, (object)new Label());
						wRMXafPZelXT1uPTvhK(this, (object)new Label());
						num = 39;
						if (T2Kc8rPuF1hjbxPj4tt())
						{
						}
						continue;
					case 44:
						break;
					case 26:
						goto IL_0046;
					case 22:
						goto IL_004d;
					case 43:
						((Control)ApplicationTitle).set_Anchor((AnchorStyles)0);
						goto case 30;
					case 30:
						oOLlt0a3myX1YjrGTWU(Y58PGSax2yn42VKbCgW(this), QdQOEiawmp2u3bSaaFx());
						goto case 27;
					case 27:
						IunCJDaN5emtHdbsHLh(Y58PGSax2yn42VKbCgW(this), (object)new Font("Microsoft Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
						goto case 1;
					case 1:
					{
						object object_2 = Y58PGSax2yn42VKbCgW(this);
						Point point_ = new Point(246, 3);
						BdjYOda8fEOLWhowSxp(object_2, point_);
						goto case 37;
					}
					case 37:
						((Control)Y58PGSax2yn42VKbCgW(this)).set_Name("ApplicationTitle");
						goto IL_00ca;
					case 35:
						goto IL_00ca;
					case 17:
					case 33:
						goto IL_00e8;
					case 7:
						goto IL_0104;
					case 34:
						goto IL_0114;
					case 8:
						goto IL_011b;
					case 11:
						goto IL_013b;
					case 42:
						m0huWZase83eOX3S4Hc(geYuYKaiMgomuUmQ0d3(MainLayoutPanel), (object)new RowStyle((SizeType)1, 218f));
						goto case 5;
					case 5:
					{
						m0huWZase83eOX3S4Hc(geYuYKaiMgomuUmQ0d3(MainLayoutPanel), (object)new RowStyle((SizeType)1, 38f));
						object object_ = X7MuA1PGDHmLUj2rknu(this);
						size = new Size(496, 303);
						sERQTOaLg9RTvbq6RwG(object_, size);
						((Control)X7MuA1PGDHmLUj2rknu(this)).set_TabIndex(0);
						IVvA37aqQJrIaoGcE25(DetailsLayoutPanel, (AnchorStyles)0);
						goto case 9;
					}
					case 9:
						oOLlt0a3myX1YjrGTWU(DRJwfSaBjCcfU6FbkB2(this), Color.Transparent);
						goto case 4;
					case 4:
						Fk9Em2amXEUOhFTAQbx(DetailsLayoutPanel, 1);
						((TableLayoutColumnStyleCollection)NyicsdanBBYcgZjbZZI(DRJwfSaBjCcfU6FbkB2(this))).Add(new ColumnStyle((SizeType)1, 142f));
						goto case 31;
					case 31:
						((TableLayoutColumnStyleCollection)NyicsdanBBYcgZjbZZI(DRJwfSaBjCcfU6FbkB2(this))).Add(new ColumnStyle((SizeType)1, 142f));
						goto case 16;
					case 16:
						DetailsLayoutPanel.get_Controls().Add((Control)yRS8MIaFWIH5LWE93Xj(this), 0, 0);
						goto case 41;
					case 41:
						((TableLayoutControlCollection)AapblsaYKZMxxsbTPOP(DetailsLayoutPanel)).Add((Control)(object)Copyright, 0, 1);
						qAs47hP2I68Rhqs8Otg();
						if (!T2Kc8rPuF1hjbxPj4tt())
						{
							num = 0;
							if (T2Kc8rPuF1hjbxPj4tt())
							{
							}
							continue;
						}
						goto IL_00e8;
					case 40:
						XNaSxMa4nRkBMyu06em(NyicsdanBBYcgZjbZZI(X7MuA1PGDHmLUj2rknu(this)), (object)new ColumnStyle((SizeType)1, 243f));
						XNaSxMa4nRkBMyu06em(((TableLayoutPanel)X7MuA1PGDHmLUj2rknu(this)).get_ColumnStyles(), (object)new ColumnStyle((SizeType)1, 100f));
						Brgof9a1qxLxnm91S85(((TableLayoutPanel)X7MuA1PGDHmLUj2rknu(this)).get_Controls(), DRJwfSaBjCcfU6FbkB2(this), 1, 1);
						((TableLayoutControlCollection)AapblsaYKZMxxsbTPOP(X7MuA1PGDHmLUj2rknu(this))).Add((Control)Y58PGSax2yn42VKbCgW(this), 1, 0);
						goto case 21;
					case 21:
					{
						XI0ajQakTHxA4le3fU8(X7MuA1PGDHmLUj2rknu(this), (DockStyle)5);
						object obj3 = X7MuA1PGDHmLUj2rknu(this);
						Point point_ = new Point(0, 0);
						((Control)obj3).set_Location(point_);
						num = 24;
						if (qAs47hP2I68Rhqs8Otg())
						{
							continue;
						}
						goto case 1;
					}
					case 39:
						yCwhkdPlyMTEfkmYqmf(X7MuA1PGDHmLUj2rknu(this));
						num = 2;
						if (T2Kc8rPuF1hjbxPj4tt())
						{
						}
						continue;
					case 38:
					{
						Label version = Version;
						Point point_ = new Point(3, 3);
						((Control)version).set_Location(point_);
						num = 13;
						if (qAs47hP2I68Rhqs8Otg())
						{
							continue;
						}
						goto case 37;
					}
					case 36:
						W8PQYOa72h3LAa3cjXl(Copyright, "Copyright");
						goto case 43;
					case 29:
						Fk9Em2amXEUOhFTAQbx(X7MuA1PGDHmLUj2rknu(this), 2);
						goto case 40;
					case 25:
						((Control)X7MuA1PGDHmLUj2rknu(this)).ResumeLayout(false);
						num = 32;
						if (qAs47hP2I68Rhqs8Otg())
						{
							continue;
						}
						goto case 40;
					case 24:
						UgwCUOadO0R3Poav2NN(X7MuA1PGDHmLUj2rknu(this), "MainLayoutPanel");
						goto case 42;
					case 20:
					{
						object obj2 = XWr8ObaJkiWEyZiaKtO(this);
						size = new Size(241, 47);
						((Control)obj2).set_Size(size);
						Q6qMusao5WZ5ocWysjV(XWr8ObaJkiWEyZiaKtO(this), 2);
						num = 36;
						if (qAs47hP2I68Rhqs8Otg())
						{
							continue;
						}
						goto IL_0114;
					}
					case 19:
						goto IL_03fe;
					default:
						goto IL_041a;
					case 0:
					case 18:
					{
						object obj = DRJwfSaBjCcfU6FbkB2(this);
						Point point_ = new Point(246, 221);
						((Control)obj).set_Location(point_);
						UgwCUOadO0R3Poav2NN(DetailsLayoutPanel, "DetailsLayoutPanel");
						((TableLayoutRowStyleCollection)geYuYKaiMgomuUmQ0d3(DRJwfSaBjCcfU6FbkB2(this))).Add(new RowStyle((SizeType)2, 33f));
						((TableLayoutRowStyleCollection)geYuYKaiMgomuUmQ0d3(DRJwfSaBjCcfU6FbkB2(this))).Add(new RowStyle((SizeType)2, 33f));
						TableLayoutPanel detailsLayoutPanel = DetailsLayoutPanel;
						size = new Size(247, 79);
						((Control)detailsLayoutPanel).set_Size(size);
						Q6qMusao5WZ5ocWysjV(DetailsLayoutPanel, 1);
						IVvA37aqQJrIaoGcE25(Version, (AnchorStyles)0);
						goto case 10;
					}
					case 10:
						oOLlt0a3myX1YjrGTWU(yRS8MIaFWIH5LWE93Xj(this), QdQOEiawmp2u3bSaaFx());
						IunCJDaN5emtHdbsHLh(yRS8MIaFWIH5LWE93Xj(this), (object)new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
						goto case 38;
					case 15:
					{
						Label copyright = Copyright;
						Point point_ = new Point(3, 29);
						BdjYOda8fEOLWhowSxp(copyright, point_);
						UgwCUOadO0R3Poav2NN(Copyright, "Copyright");
						goto case 20;
					}
					case 13:
						goto IL_055d;
					case 3:
						WN4DvqPziRGKTl5mq01(MainLayoutPanel, (object)(Image)componentResourceManager.GetObject("MainLayoutPanel.BackgroundImage"));
						((Control)X7MuA1PGDHmLUj2rknu(this)).set_BackgroundImageLayout((ImageLayout)3);
						goto case 29;
					case 2:
						yCwhkdPlyMTEfkmYqmf(DetailsLayoutPanel);
						yCwhkdPlyMTEfkmYqmf(this);
						goto case 3;
					case 28:
						goto IL_0692;
					case 23:
						goto end_IL_0692;
					case 32:
						iCFXfEaaj4eaBtlXLXR(DetailsLayoutPanel, bool_0: false);
						goto IL_06de;
					case 14:
						goto IL_06de;
					case 46:
						return;
					}
					break;
				}
				goto IL_003b;
				IL_055d:
				((Control)yRS8MIaFWIH5LWE93Xj(this)).set_Name("Version");
				object object_3 = yRS8MIaFWIH5LWE93Xj(this);
				size = new Size(241, 20);
				sERQTOaLg9RTvbq6RwG(object_3, size);
				goto IL_03fe;
				IL_03fe:
				((Control)yRS8MIaFWIH5LWE93Xj(this)).set_TabIndex(1);
				W8PQYOa72h3LAa3cjXl(Version, "Version {0}.{1:00}");
				goto IL_041a;
				IL_041a:
				IVvA37aqQJrIaoGcE25(XWr8ObaJkiWEyZiaKtO(this), (AnchorStyles)0);
				oOLlt0a3myX1YjrGTWU(XWr8ObaJkiWEyZiaKtO(this), Color.Transparent);
				((Control)Copyright).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
				num = 15;
				if (!qAs47hP2I68Rhqs8Otg())
				{
					goto IL_00ca;
				}
				goto IL_05cc;
				IL_00ca:
				Label applicationTitle = ApplicationTitle;
				size = new Size(247, 212);
				sERQTOaLg9RTvbq6RwG(applicationTitle, size);
				goto IL_00e8;
				IL_00e8:
				Q6qMusao5WZ5ocWysjV(Y58PGSax2yn42VKbCgW(this), 0);
				((Label)Y58PGSax2yn42VKbCgW(this)).set_Text("Application Title");
				goto IL_0104;
				IL_0104:
				((Label)Y58PGSax2yn42VKbCgW(this)).set_TextAlign((ContentAlignment)256);
				goto IL_0114;
				IL_0114:
				AS91i4aKiByTdxtB2Zi(this, (AutoScaleMode)1);
				goto IL_011b;
				IL_011b:
				size = new Size(496, 303);
				jBmVyWaAxTvpVSHn4ce(this, size);
				((Form)this).set_ControlBox(false);
				goto IL_013b;
				IL_013b:
				((ControlCollection)qlEsmlajC6V6AFIEYoZ(this)).Add((Control)X7MuA1PGDHmLUj2rknu(this));
				ySXGdkaCcS9HuZCDQ7d(this, (FormBorderStyle)1);
				IX0VQUaRkMYDeY3gdKI(this, bool_0: false);
				((Form)this).set_MinimizeBox(false);
				goto IL_003b;
				IL_003b:
				((Control)this).set_Name("GRDVD");
				goto IL_0046;
				IL_0046:
				((Form)this).set_ShowInTaskbar(false);
				goto IL_004d;
				IL_004d:
				B9xDDRaPWyj0UL310sK(this, (FormStartPosition)1);
				num = 25;
				if (!T2Kc8rPuF1hjbxPj4tt())
				{
					goto IL_05cc;
				}
				goto IL_06de;
				IL_06de:
				((Control)this).ResumeLayout(false);
				return;
				continue;
				end_IL_0692:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void eODZuW6Ykx(object sender, EventArgs e)
	{
		qAs47hP2I68Rhqs8Otg();
		if (!T2Kc8rPuF1hjbxPj4tt())
		{
			goto IL_001f;
		}
		int num = 3;
		if (!qAs47hP2I68Rhqs8Otg())
		{
			goto IL_0043;
		}
		goto IL_0069;
		IL_00b9:
		W8PQYOa72h3LAa3cjXl(yRS8MIaFWIH5LWE93Xj(this), string.Format((string)JvH70TatPPRJa02DrJL(yRS8MIaFWIH5LWE93Xj(this)), ((Version)yliIG6aedCHbiq4wtYp(vYh51iaU6AeCl9mCiXH(HT0TkuaImSjwqmDrGFr()))).Major, Lg8T6daX7U0Li052C5R(yliIG6aedCHbiq4wtYp(((ApplicationBase)HT0TkuaImSjwqmDrGFr()).get_Info()))));
		goto IL_0106;
		IL_0069:
		switch (num)
		{
		case 0:
		case 7:
			break;
		case 1:
		case 3:
			goto IL_0040;
		case 6:
			goto IL_0043;
		default:
			goto IL_00b9;
		case 4:
			goto IL_0106;
		case 8:
			return;
		}
		goto IL_001f;
		IL_001f:
		bool flag = Operators.CompareString(((AssemblyInfo)vYh51iaU6AeCl9mCiXH(HT0TkuaImSjwqmDrGFr())).get_Title(), "", false) != 0;
		goto IL_0040;
		IL_0040:
		if (flag)
		{
			goto IL_0043;
		}
		W8PQYOa72h3LAa3cjXl(Y58PGSax2yn42VKbCgW(this), QAGlNtavIuoNuVMDaww(sQFU2UaWXILXtLTOYSF(vYh51iaU6AeCl9mCiXH(HT0TkuaImSjwqmDrGFr()))));
		goto IL_00b9;
		IL_0043:
		W8PQYOa72h3LAa3cjXl(ApplicationTitle, ugmmaCafrQPLulRRCL9(((ApplicationBase)HT0TkuaImSjwqmDrGFr()).get_Info()));
		num = 2;
		if (T2Kc8rPuF1hjbxPj4tt())
		{
			return;
		}
		goto IL_0069;
		IL_0106:
		((Label)XWr8ObaJkiWEyZiaKtO(this)).set_Text((string)n2xQ2UaEji4KUmJfjw7(((ApplicationBase)HT0TkuaImSjwqmDrGFr()).get_Info()));
	}

	internal static bool qAs47hP2I68Rhqs8Otg()
	{
		return true;
	}

	internal static bool T2Kc8rPuF1hjbxPj4tt()
	{
		return false;
	}

	internal static void Kp2afcPrysHcFOIRdCW(object object_0)
	{
		((Form)object_0)._002Ector();
	}

	internal static void zh6tGUPbrI5e1HqvTE1(object object_0, object object_1)
	{
		((Form)object_0).add_Load((EventHandler)object_1);
	}

	internal static void VTYhlZPHgp7Xeh775WN(object object_0)
	{
		XaBZ0y8riB(object_0);
	}

	internal static void zv9ckoP5vLqh6SoEqqC(object object_0)
	{
		((GRDVD)object_0).TS9Zey1f1r();
	}

	internal static void EY2xyIPQ5DYnYA4QVcL(object object_0)
	{
		Monitor.Enter(object_0);
	}

	internal static int FD0RnpPTM7fcQcBCcXS(object object_0)
	{
		return ((List<WeakReference>)object_0).Capacity;
	}

	internal static int Wmqbs9P6LJSxLk6fZx6(object object_0)
	{
		return ((List<WeakReference>)object_0).Count;
	}

	internal static object naMBVKPp7whROk8seMO(object object_0)
	{
		return RuntimeHelpers.GetObjectValue(object_0);
	}

	internal static void oKmrKUPy8A91JYaeA9g(object object_0)
	{
		Monitor.Exit(object_0);
	}

	internal static void UgQDSEPV3ANIu1bPDtp(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}

	internal static Type yVBeslPcfADdfY0wncY(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static void XG2Ld3P0x8gPhQV2JNr(object object_0, object object_1)
	{
		((GRDVD)object_0).Version = (Label)object_1;
	}

	internal static void FaMsGnPMSDn6Ue1QgpN(object object_0, object object_1)
	{
		((GRDVD)object_0).Copyright = (Label)object_1;
	}

	internal static void wRMXafPZelXT1uPTvhK(object object_0, object object_1)
	{
		((GRDVD)object_0).ApplicationTitle = (Label)object_1;
	}

	internal static object X7MuA1PGDHmLUj2rknu(object object_0)
	{
		return ((GRDVD)object_0).MainLayoutPanel;
	}

	internal static void yCwhkdPlyMTEfkmYqmf(object object_0)
	{
		((Control)object_0).SuspendLayout();
	}

	internal static void WN4DvqPziRGKTl5mq01(object object_0, object object_1)
	{
		((Control)object_0).set_BackgroundImage((Image)object_1);
	}

	internal static void Fk9Em2amXEUOhFTAQbx(object object_0, int int_0)
	{
		((TableLayoutPanel)object_0).set_ColumnCount(int_0);
	}

	internal static object NyicsdanBBYcgZjbZZI(object object_0)
	{
		return ((TableLayoutPanel)object_0).get_ColumnStyles();
	}

	internal static int XNaSxMa4nRkBMyu06em(object object_0, object object_1)
	{
		return ((TableLayoutColumnStyleCollection)object_0).Add((ColumnStyle)object_1);
	}

	internal static object DRJwfSaBjCcfU6FbkB2(object object_0)
	{
		return ((GRDVD)object_0).DetailsLayoutPanel;
	}

	internal static void Brgof9a1qxLxnm91S85(object object_0, object object_1, int int_0, int int_1)
	{
		((TableLayoutControlCollection)object_0).Add((Control)object_1, int_0, int_1);
	}

	internal static object AapblsaYKZMxxsbTPOP(object object_0)
	{
		return ((TableLayoutPanel)object_0).get_Controls();
	}

	internal static object Y58PGSax2yn42VKbCgW(object object_0)
	{
		return ((GRDVD)object_0).ApplicationTitle;
	}

	internal static void XI0ajQakTHxA4le3fU8(object object_0, DockStyle dockStyle_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Control)object_0).set_Dock(dockStyle_0);
	}

	internal static void UgwCUOadO0R3Poav2NN(object object_0, object object_1)
	{
		((Control)object_0).set_Name((string)object_1);
	}

	internal static object geYuYKaiMgomuUmQ0d3(object object_0)
	{
		return ((TableLayoutPanel)object_0).get_RowStyles();
	}

	internal static int m0huWZase83eOX3S4Hc(object object_0, object object_1)
	{
		return ((TableLayoutRowStyleCollection)object_0).Add((RowStyle)object_1);
	}

	internal static void sERQTOaLg9RTvbq6RwG(object object_0, Size size_0)
	{
		((Control)object_0).set_Size(size_0);
	}

	internal static void IVvA37aqQJrIaoGcE25(object object_0, AnchorStyles anchorStyles_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Control)object_0).set_Anchor(anchorStyles_0);
	}

	internal static void oOLlt0a3myX1YjrGTWU(object object_0, Color color_0)
	{
		((Control)object_0).set_BackColor(color_0);
	}

	internal static object yRS8MIaFWIH5LWE93Xj(object object_0)
	{
		return ((GRDVD)object_0).Version;
	}

	internal static void Q6qMusao5WZ5ocWysjV(object object_0, int int_0)
	{
		((Control)object_0).set_TabIndex(int_0);
	}

	internal static Color QdQOEiawmp2u3bSaaFx()
	{
		return Color.Transparent;
	}

	internal static void IunCJDaN5emtHdbsHLh(object object_0, object object_1)
	{
		((Control)object_0).set_Font((Font)object_1);
	}

	internal static void W8PQYOa72h3LAa3cjXl(object object_0, object object_1)
	{
		((Label)object_0).set_Text((string)object_1);
	}

	internal static object XWr8ObaJkiWEyZiaKtO(object object_0)
	{
		return ((GRDVD)object_0).Copyright;
	}

	internal static void BdjYOda8fEOLWhowSxp(object object_0, Point point_0)
	{
		((Control)object_0).set_Location(point_0);
	}

	internal static void AS91i4aKiByTdxtB2Zi(object object_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((ContainerControl)object_0).set_AutoScaleMode(autoScaleMode_0);
	}

	internal static void jBmVyWaAxTvpVSHn4ce(object object_0, Size size_0)
	{
		((Form)object_0).set_ClientSize(size_0);
	}

	internal static object qlEsmlajC6V6AFIEYoZ(object object_0)
	{
		return ((Control)object_0).get_Controls();
	}

	internal static void ySXGdkaCcS9HuZCDQ7d(object object_0, FormBorderStyle formBorderStyle_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Form)object_0).set_FormBorderStyle(formBorderStyle_0);
	}

	internal static void IX0VQUaRkMYDeY3gdKI(object object_0, bool bool_0)
	{
		((Form)object_0).set_MaximizeBox(bool_0);
	}

	internal static void B9xDDRaPWyj0UL310sK(object object_0, FormStartPosition formStartPosition_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Form)object_0).set_StartPosition(formStartPosition_0);
	}

	internal static void iCFXfEaaj4eaBtlXLXR(object object_0, bool bool_0)
	{
		((Control)object_0).ResumeLayout(bool_0);
	}

	internal static object HT0TkuaImSjwqmDrGFr()
	{
		return uj5IdEKfuKbugcX2aA.XNvTqP1Oe;
	}

	internal static object vYh51iaU6AeCl9mCiXH(object object_0)
	{
		return ((ApplicationBase)object_0).get_Info();
	}

	internal static object ugmmaCafrQPLulRRCL9(object object_0)
	{
		return ((AssemblyInfo)object_0).get_Title();
	}

	internal static object sQFU2UaWXILXtLTOYSF(object object_0)
	{
		return ((AssemblyInfo)object_0).get_AssemblyName();
	}

	internal static object QAGlNtavIuoNuVMDaww(object object_0)
	{
		return Path.GetFileNameWithoutExtension((string?)object_0);
	}

	internal static object JvH70TatPPRJa02DrJL(object object_0)
	{
		return ((Label)object_0).get_Text();
	}

	internal static object yliIG6aedCHbiq4wtYp(object object_0)
	{
		return ((AssemblyInfo)object_0).get_Version();
	}

	internal static int Lg8T6daX7U0Li052C5R(object object_0)
	{
		return ((Version)object_0).Minor;
	}

	internal static object n2xQ2UaEji4KUmJfjw7(object object_0)
	{
		return ((AssemblyInfo)object_0).get_Copyright();
	}
}
