using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Ulq71qYO9Oc25W2GE3;

namespace QWDFVB;

[DesignerGenerated]
public sealed class SplashScreen1 : Form
{
	private static List<WeakReference> Vn7HnatkiY = new List<WeakReference>();

	[AccessedThroughProperty("ApplicationTitle")]
	private Label O1CH7N7O4J;

	[AccessedThroughProperty("Version")]
	private Label EINHsr1Vxp;

	[AccessedThroughProperty("Copyright")]
	private Label biNHJKB45W;

	[AccessedThroughProperty("MainLayoutPanel")]
	private TableLayoutPanel PyHH42tGB1;

	[AccessedThroughProperty("DetailsLayoutPanel")]
	private TableLayoutPanel jaxHGGCyN4;

	private IContainer d3OH5ACcJq;

	public MethodInfo t;

	internal virtual Label ApplicationTitle
	{
		[DebuggerNonUserCode]
		get
		{
			return O1CH7N7O4J;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			O1CH7N7O4J = value;
		}
	}

	internal virtual Label Version
	{
		[DebuggerNonUserCode]
		get
		{
			return EINHsr1Vxp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EINHsr1Vxp = value;
		}
	}

	internal virtual Label Copyright
	{
		[DebuggerNonUserCode]
		get
		{
			return biNHJKB45W;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			biNHJKB45W = value;
		}
	}

	internal virtual TableLayoutPanel MainLayoutPanel
	{
		[DebuggerNonUserCode]
		get
		{
			return PyHH42tGB1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			PyHH42tGB1 = value;
		}
	}

	internal virtual TableLayoutPanel DetailsLayoutPanel
	{
		[DebuggerNonUserCode]
		get
		{
			return jaxHGGCyN4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			jaxHGGCyN4 = value;
		}
	}

	[DebuggerNonUserCode]
	public SplashScreen1()
	{
		_ = 0;
		if (GBn4w9UnEG8bf39Bkk7())
		{
			inLffRUBItvlRa7ftJF(this);
			WsGpFZU1mVNBb7i40Hh(this, new EventHandler(vFWHMJPADn));
			qyXugRUYGOHNed3jMpv(this);
		}
		u6wMRnUx2evQZQU7BiH(this);
	}

	[DebuggerNonUserCode]
	private static void PnQH2KxISF(object object_0)
	{
		YaDcZJU4TAZwIEdPH40();
		List<WeakReference> vn7HnatkiY = default(List<WeakReference>);
		if (GBn4w9UnEG8bf39Bkk7())
		{
			vn7HnatkiY = Vn7HnatkiY;
		}
		Monitor.Enter(vn7HnatkiY);
		checked
		{
			try
			{
				bool flag;
				int num;
				int num2;
				int num3;
				if (flag = G2ctLDUkBWhw3XEx59W(Vn7HnatkiY) == Vn7HnatkiY.Capacity)
				{
					num = 0;
					num2 = G2ctLDUkBWhw3XEx59W(Vn7HnatkiY) - 1;
					num3 = 0;
					_ = 1;
					if (!YaDcZJU4TAZwIEdPH40())
					{
						goto IL_005e;
					}
					goto IL_00a2;
				}
				goto IL_00d3;
				IL_00d3:
				Vn7HnatkiY.Add(new WeakReference(RuntimeHelpers.GetObjectValue(object_0)));
				return;
				IL_00a2:
				if (flag)
				{
					if (num3 != num)
					{
						Vn7HnatkiY[num] = Vn7HnatkiY[num3];
					}
					num++;
				}
				num3++;
				goto IL_005e;
				IL_005e:
				int num4 = num3;
				int num5 = num2;
				if (num4 <= num5)
				{
					WeakReference weakReference = Vn7HnatkiY[num3];
					flag = weakReference.IsAlive;
					goto IL_00a2;
				}
				UI0OqjUdWVUxC852hKS(Vn7HnatkiY, num, G2ctLDUkBWhw3XEx59W(Vn7HnatkiY) - num);
				Vn7HnatkiY.Capacity = G2ctLDUkBWhw3XEx59W(Vn7HnatkiY);
				goto IL_00d3;
			}
			finally
			{
				Kb3Ye9UijYjY2Jrchre(vn7HnatkiY);
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			int num;
			if (disposing)
			{
				if (d3OH5ACcJq != null)
				{
					num = 1;
					goto IL_005d;
				}
				YaDcZJU4TAZwIEdPH40();
				if (!GBn4w9UnEG8bf39Bkk7())
				{
					int num2 = 2;
					if (!GBn4w9UnEG8bf39Bkk7())
					{
						goto IL_005e;
					}
					while (true)
					{
						switch (num2)
						{
						default:
							num2 = 3;
							if (GBn4w9UnEG8bf39Bkk7())
							{
								continue;
							}
							goto IL_0061;
						case 0:
						case 4:
							break;
						case 1:
						case 2:
							goto IL_005e;
						case 3:
							goto IL_0061;
						case 5:
							return;
						}
						break;
					}
				}
			}
			num = 0;
			goto IL_005d;
			IL_0061:
			QhNYKBUsnGPiPuBZeeS(d3OH5ACcJq);
			return;
			IL_005e:
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			goto IL_0061;
			IL_005d:
			flag = (byte)num != 0;
			goto IL_005e;
		}
		finally
		{
			U3b7XxULSjn5qm6Etcn(this, disposing);
		}
	}

	[DebuggerStepThrough]
	private void HPBHQZNsL3()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected O, but got Unknown
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected O, but got Unknown
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected O, but got Unknown
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected O, but got Unknown
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected O, but got Unknown
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Expected O, but got Unknown
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected O, but got Unknown
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected O, but got Unknown
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Expected O, but got Unknown
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Expected O, but got Unknown
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f2: Expected O, but got Unknown
		//IL_0504: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Expected O, but got Unknown
		GBn4w9UnEG8bf39Bkk7();
		if (!YaDcZJU4TAZwIEdPH40())
		{
			goto IL_034e;
		}
		goto IL_0669;
		IL_0669:
		((TableLayoutControlCollection)oujtkYUALAuwR56KOSn(gkLK4bUFAL2JoLVHphq(this))).Add((Control)nhSYfCUt98CG1lRtblv(this), 0, 1);
		goto IL_0632;
		IL_0632:
		TableLayoutPanel detailsLayoutPanel = DetailsLayoutPanel;
		Point location = new Point(246, 221);
		((Control)detailsLayoutPanel).set_Location(location);
		goto IL_060d;
		IL_060d:
		((Control)gkLK4bUFAL2JoLVHphq(this)).set_Name("DetailsLayoutPanel");
		int num = 24;
		if (!GBn4w9UnEG8bf39Bkk7())
		{
			goto IL_00ed;
		}
		goto IL_0547;
		IL_0547:
		Size size_;
		while (true)
		{
			switch (num)
			{
			case 44:
				break;
			case 28:
				goto IL_0044;
			case 8:
				goto IL_0069;
			case 10:
				goto IL_00ac;
			case 43:
				((Control)nhSYfCUt98CG1lRtblv(this)).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
				goto IL_00ed;
			case 9:
				goto IL_00ed;
			case 33:
				goto IL_0113;
			case 21:
				goto IL_011e;
			case 42:
				tWWG5cURMfY8EOc6KfQ(iaMMGpUEUoktYorRCvj(this), "ApplicationTitle");
				goto case 30;
			case 30:
			{
				object object_4 = iaMMGpUEUoktYorRCvj(this);
				size_ = new Size(247, 212);
				vEUoZmUINSUAMYMsuic(object_4, size_);
				((Control)iaMMGpUEUoktYorRCvj(this)).set_TabIndex(0);
				goto case 4;
			}
			case 4:
				bhnhfWUgbUfenkTyw60(iaMMGpUEUoktYorRCvj(this), "Application Title");
				u5OgeSU9l2F7T2kT8aD(iaMMGpUEUoktYorRCvj(this), (ContentAlignment)256);
				sBwy24UOaOSyB9ZPVsA(this, (AutoScaleMode)1);
				goto case 1;
			case 1:
				size_ = new Size(496, 303);
				v26iKpUD47JRALr59ck(this, size_);
				CmL7dLUhU0I4SVi9xBi(this, bool_0: false);
				((ControlCollection)qGI2fqUSCtdobcEp1oE(this)).Add((Control)(object)MainLayoutPanel);
				HTRy6nU2HL0IZGbqZpP(this, (FormBorderStyle)1);
				Yyy2EbUusp8nayuWZwT(this, bool_0: false);
				goto case 37;
			case 37:
				p6wXEvUrSNfg0BrNNU9(this, bool_0: false);
				goto IL_0113;
			case 41:
				goto IL_01e5;
			case 34:
				goto IL_022d;
			case 17:
				goto IL_024b;
			case 25:
				goto IL_0257;
			case 31:
				goto IL_0273;
			case 40:
			{
				object object_2 = nhSYfCUt98CG1lRtblv(this);
				size_ = new Size(241, 47);
				vEUoZmUINSUAMYMsuic(object_2, size_);
				((Control)Copyright).set_TabIndex(2);
				goto case 36;
			}
			case 36:
				Copyright.set_Text("Copyright");
				goto case 23;
			case 23:
				((Control)ApplicationTitle).set_Anchor((AnchorStyles)0);
				goto case 14;
			case 14:
			{
				hNiB7aUvTK0aQWuKC3X(iaMMGpUEUoktYorRCvj(this), jx8XVFUWTSqg4e7UHda());
				((Control)ApplicationTitle).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
				object object_3 = iaMMGpUEUoktYorRCvj(this);
				location = new Point(246, 3);
				WkravmUCaT9uPyHsjri(object_3, location);
				goto case 42;
			}
			case 39:
				fCiwyWU5dX9cXfcfW3i(k3dGvNUNDZlo47RtyQ4(this), bool_0: false);
				num = 2;
				if (YaDcZJU4TAZwIEdPH40())
				{
				}
				continue;
			case 0:
			case 35:
				goto IL_034e;
			case 6:
				goto IL_035e;
			case 22:
				goto IL_0369;
			case 3:
				goto IL_037f;
			case 32:
				goto IL_03ab;
			case 19:
				goto IL_03cc;
			case 20:
				goto IL_03d8;
			case 11:
				goto IL_03e4;
			case 7:
				goto IL_0400;
			case 29:
				goto IL_0434;
			case 15:
				goto IL_044c;
			case 26:
			{
				object object_ = gkLK4bUFAL2JoLVHphq(this);
				size_ = new Size(247, 79);
				vEUoZmUINSUAMYMsuic(object_, size_);
				ObTahsUUAIXCMV4ib7A(gkLK4bUFAL2JoLVHphq(this), 1);
				goto case 5;
			}
			case 5:
				VO36ElUf0TvagRhsm9A(Version, (AnchorStyles)0);
				((Control)xfSf7BUe3xZd4s7RhOJ(this)).set_BackColor(jx8XVFUWTSqg4e7UHda());
				W0N4PeUXNteoa8Tm73i(Version, (object)new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
				goto IL_0044;
			case 24:
				((TableLayoutPanel)gkLK4bUFAL2JoLVHphq(this)).get_RowStyles().Add(new RowStyle((SizeType)2, 33f));
				mi7Xd5UawFqk4YELsCU(sEB9wlUPZi1VxbACgBT(gkLK4bUFAL2JoLVHphq(this)), (object)new RowStyle((SizeType)2, 33f));
				goto case 26;
			case 13:
				z5hAJRUHXmf8A8QiwlS(this, (FormStartPosition)1);
				goto case 39;
			case 12:
				tWWG5cURMfY8EOc6KfQ(nhSYfCUt98CG1lRtblv(this), "Copyright");
				goto case 40;
			default:
				num = 5;
				if (GBn4w9UnEG8bf39Bkk7())
				{
					continue;
				}
				goto case 42;
			case 16:
				goto IL_060d;
			case 45:
				goto IL_0632;
			case 27:
				DetailsLayoutPanel.get_Controls().Add((Control)(object)Version, 0, 0);
				goto IL_0669;
			case 18:
			case 38:
				goto IL_0669;
			case 2:
				goto IL_0684;
			case 46:
				return;
			}
			break;
		}
		goto IL_0018;
		IL_00ac:
		((Control)Copyright).set_BackColor(Color.Transparent);
		num = 43;
		if (!YaDcZJU4TAZwIEdPH40())
		{
			goto IL_0547;
		}
		goto IL_0684;
		IL_037f:
		Copyright = new Label();
		vEuTIrU3Rs4jMjsFD2I(this, (object)new Label());
		((Control)MainLayoutPanel).SuspendLayout();
		wSQX5mUo8xR5liugWUo(gkLK4bUFAL2JoLVHphq(this));
		goto IL_03ab;
		IL_0684:
		fCiwyWU5dX9cXfcfW3i(DetailsLayoutPanel, bool_0: false);
		((Control)this).ResumeLayout(false);
		return;
		IL_0018:
		bTsetDUKKdprOKyHl4n(((TableLayoutPanel)gkLK4bUFAL2JoLVHphq(this)).get_ColumnStyles(), (object)new ColumnStyle((SizeType)1, 142f));
		num = 27;
		if (YaDcZJU4TAZwIEdPH40())
		{
			goto IL_0044;
		}
		goto IL_0547;
		IL_0273:
		gTgMQcUJmKUXTOLo43V(DetailsLayoutPanel, 1);
		DetailsLayoutPanel.get_ColumnStyles().Add(new ColumnStyle((SizeType)1, 142f));
		goto IL_0018;
		IL_0044:
		object object_5 = xfSf7BUe3xZd4s7RhOJ(this);
		location = new Point(3, 3);
		WkravmUCaT9uPyHsjri(object_5, location);
		tWWG5cURMfY8EOc6KfQ(xfSf7BUe3xZd4s7RhOJ(this), "Version");
		goto IL_0069;
		IL_024b:
		ObTahsUUAIXCMV4ib7A(k3dGvNUNDZlo47RtyQ4(this), 0);
		goto IL_0257;
		IL_0069:
		object obj = xfSf7BUe3xZd4s7RhOJ(this);
		size_ = new Size(241, 20);
		((Control)obj).set_Size(size_);
		ObTahsUUAIXCMV4ib7A(xfSf7BUe3xZd4s7RhOJ(this), 1);
		Version.set_Text("Version {0}.{1:00}");
		((Control)Copyright).set_Anchor((AnchorStyles)0);
		goto IL_00ac;
		IL_022d:
		TableLayoutPanel mainLayoutPanel = MainLayoutPanel;
		size_ = new Size(496, 303);
		vEUoZmUINSUAMYMsuic(mainLayoutPanel, size_);
		goto IL_024b;
		IL_01e5:
		tWWG5cURMfY8EOc6KfQ(k3dGvNUNDZlo47RtyQ4(this), "MainLayoutPanel");
		((TableLayoutRowStyleCollection)sEB9wlUPZi1VxbACgBT(k3dGvNUNDZlo47RtyQ4(this))).Add(new RowStyle((SizeType)1, 218f));
		mi7Xd5UawFqk4YELsCU(sEB9wlUPZi1VxbACgBT(MainLayoutPanel), (object)new RowStyle((SizeType)1, 38f));
		goto IL_022d;
		IL_044c:
		jDIHioUjbSEH3xKLtp0(k3dGvNUNDZlo47RtyQ4(this), (DockStyle)5);
		object object_6 = k3dGvNUNDZlo47RtyQ4(this);
		location = new Point(0, 0);
		WkravmUCaT9uPyHsjri(object_6, location);
		goto IL_01e5;
		IL_0434:
		((TableLayoutControlCollection)oujtkYUALAuwR56KOSn(k3dGvNUNDZlo47RtyQ4(this))).Add((Control)(object)ApplicationTitle, 1, 0);
		goto IL_044c;
		IL_0400:
		bTsetDUKKdprOKyHl4n(((TableLayoutPanel)k3dGvNUNDZlo47RtyQ4(this)).get_ColumnStyles(), (object)new ColumnStyle((SizeType)1, 100f));
		((TableLayoutControlCollection)oujtkYUALAuwR56KOSn(k3dGvNUNDZlo47RtyQ4(this))).Add((Control)gkLK4bUFAL2JoLVHphq(this), 1, 1);
		goto IL_0434;
		IL_03e4:
		bTsetDUKKdprOKyHl4n(ngPSeGU8GyhKFcYG2VK(MainLayoutPanel), (object)new ColumnStyle((SizeType)1, 243f));
		goto IL_0400;
		IL_00ed:
		Label copyright = Copyright;
		location = new Point(3, 29);
		WkravmUCaT9uPyHsjri(copyright, location);
		num = 12;
		if (!GBn4w9UnEG8bf39Bkk7())
		{
			goto IL_0113;
		}
		goto IL_0547;
		IL_0257:
		VO36ElUf0TvagRhsm9A(gkLK4bUFAL2JoLVHphq(this), (AnchorStyles)0);
		hNiB7aUvTK0aQWuKC3X(DetailsLayoutPanel, jx8XVFUWTSqg4e7UHda());
		goto IL_0273;
		IL_03d8:
		gTgMQcUJmKUXTOLo43V(MainLayoutPanel, 2);
		goto IL_03e4;
		IL_03cc:
		JSUabIU7JGOO8dRExbZ(k3dGvNUNDZlo47RtyQ4(this), (ImageLayout)3);
		goto IL_03d8;
		IL_03ab:
		wSQX5mUo8xR5liugWUo(this);
		ComponentResourceManager componentResourceManager = default(ComponentResourceManager);
		wKJn45UwtOGeKA6hTXS(MainLayoutPanel, (object)(Image)componentResourceManager.GetObject("MainLayoutPanel.BackgroundImage"));
		goto IL_03cc;
		IL_0113:
		((Control)this).set_Name("SplashScreen1");
		goto IL_011e;
		IL_011e:
		gmZ0s3UbRTOR87Qpji1(this, bool_0: false);
		num = 13;
		if (YaDcZJU4TAZwIEdPH40())
		{
		}
		goto IL_0547;
		IL_034e:
		componentResourceManager = new ComponentResourceManager(typeof(SplashScreen1));
		goto IL_035e;
		IL_035e:
		MainLayoutPanel = new TableLayoutPanel();
		goto IL_0369;
		IL_0369:
		DetailsLayoutPanel = new TableLayoutPanel();
		jNhim4UqU35Jipwd808(this, (object)new Label());
		goto IL_037f;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void vFWHMJPADn(object sender, EventArgs e)
	{
		while (true)
		{
			bool flag = Operators.CompareString((string)lOdgxtU60ggsXbOKNNS(TrJ4JoUT8kbb0R1YQ5N(MqE6AxUQOtY8Rp6R4qM())), "", false) != 0;
			_ = 0;
			if (!GBn4w9UnEG8bf39Bkk7())
			{
				goto IL_008a;
			}
			if (!YaDcZJU4TAZwIEdPH40())
			{
				switch (5)
				{
				case 3:
					break;
				case 1:
				case 5:
					if (flag)
					{
						goto IL_008a;
					}
					bhnhfWUgbUfenkTyw60(ApplicationTitle, C4DEFIUp8IlsMHTiJTf(((AssemblyInfo)TrJ4JoUT8kbb0R1YQ5N(uj5IdEKfuKbugcX2aA.XNvTqP1Oe)).get_AssemblyName()));
					goto IL_00a4;
				case 0:
				case 2:
					goto IL_008a;
				default:
					goto IL_00a4;
				case 7:
					goto end_IL_0001;
				case 8:
					return;
				}
				continue;
			}
			goto IL_00a4;
			IL_008a:
			bhnhfWUgbUfenkTyw60(ApplicationTitle, ((AssemblyInfo)TrJ4JoUT8kbb0R1YQ5N(uj5IdEKfuKbugcX2aA.XNvTqP1Oe)).get_Title());
			goto IL_00a4;
			IL_00a4:
			bhnhfWUgbUfenkTyw60(Version, dHorVqUcnIEY2djUeip(Version.get_Text(), ukt8t6UyEoCI2VXioA2(((AssemblyInfo)TrJ4JoUT8kbb0R1YQ5N(MqE6AxUQOtY8Rp6R4qM())).get_Version()), ((Version)AFvCAaUVFNx9y71moU6(TrJ4JoUT8kbb0R1YQ5N(MqE6AxUQOtY8Rp6R4qM()))).Minor));
			break;
			continue;
			end_IL_0001:
			break;
		}
		bhnhfWUgbUfenkTyw60(Copyright, hVmMJTU0B5qdq7xQgeV(TrJ4JoUT8kbb0R1YQ5N(MqE6AxUQOtY8Rp6R4qM())));
	}

	internal static bool GBn4w9UnEG8bf39Bkk7()
	{
		return true;
	}

	internal static bool YaDcZJU4TAZwIEdPH40()
	{
		return false;
	}

	internal static void inLffRUBItvlRa7ftJF(object object_0)
	{
		((Form)object_0)._002Ector();
	}

	internal static void WsGpFZU1mVNBb7i40Hh(object object_0, object object_1)
	{
		((Form)object_0).add_Load((EventHandler)object_1);
	}

	internal static void qyXugRUYGOHNed3jMpv(object object_0)
	{
		PnQH2KxISF(object_0);
	}

	internal static void u6wMRnUx2evQZQU7BiH(object object_0)
	{
		((SplashScreen1)object_0).HPBHQZNsL3();
	}

	internal static int G2ctLDUkBWhw3XEx59W(object object_0)
	{
		return ((List<WeakReference>)object_0).Count;
	}

	internal static void UI0OqjUdWVUxC852hKS(object object_0, int int_0, int int_1)
	{
		((List<WeakReference>)object_0).RemoveRange(int_0, int_1);
	}

	internal static void Kb3Ye9UijYjY2Jrchre(object object_0)
	{
		Monitor.Exit(object_0);
	}

	internal static void QhNYKBUsnGPiPuBZeeS(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}

	internal static void U3b7XxULSjn5qm6Etcn(object object_0, bool bool_0)
	{
		((Form)object_0).Dispose(bool_0);
	}

	internal static void jNhim4UqU35Jipwd808(object object_0, object object_1)
	{
		((SplashScreen1)object_0).Version = (Label)object_1;
	}

	internal static void vEuTIrU3Rs4jMjsFD2I(object object_0, object object_1)
	{
		((SplashScreen1)object_0).ApplicationTitle = (Label)object_1;
	}

	internal static object gkLK4bUFAL2JoLVHphq(object object_0)
	{
		return ((SplashScreen1)object_0).DetailsLayoutPanel;
	}

	internal static void wSQX5mUo8xR5liugWUo(object object_0)
	{
		((Control)object_0).SuspendLayout();
	}

	internal static void wKJn45UwtOGeKA6hTXS(object object_0, object object_1)
	{
		((Control)object_0).set_BackgroundImage((Image)object_1);
	}

	internal static object k3dGvNUNDZlo47RtyQ4(object object_0)
	{
		return ((SplashScreen1)object_0).MainLayoutPanel;
	}

	internal static void JSUabIU7JGOO8dRExbZ(object object_0, ImageLayout imageLayout_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Control)object_0).set_BackgroundImageLayout(imageLayout_0);
	}

	internal static void gTgMQcUJmKUXTOLo43V(object object_0, int int_0)
	{
		((TableLayoutPanel)object_0).set_ColumnCount(int_0);
	}

	internal static object ngPSeGU8GyhKFcYG2VK(object object_0)
	{
		return ((TableLayoutPanel)object_0).get_ColumnStyles();
	}

	internal static int bTsetDUKKdprOKyHl4n(object object_0, object object_1)
	{
		return ((TableLayoutColumnStyleCollection)object_0).Add((ColumnStyle)object_1);
	}

	internal static object oujtkYUALAuwR56KOSn(object object_0)
	{
		return ((TableLayoutPanel)object_0).get_Controls();
	}

	internal static void jDIHioUjbSEH3xKLtp0(object object_0, DockStyle dockStyle_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Control)object_0).set_Dock(dockStyle_0);
	}

	internal static void WkravmUCaT9uPyHsjri(object object_0, Point point_0)
	{
		((Control)object_0).set_Location(point_0);
	}

	internal static void tWWG5cURMfY8EOc6KfQ(object object_0, object object_1)
	{
		((Control)object_0).set_Name((string)object_1);
	}

	internal static object sEB9wlUPZi1VxbACgBT(object object_0)
	{
		return ((TableLayoutPanel)object_0).get_RowStyles();
	}

	internal static int mi7Xd5UawFqk4YELsCU(object object_0, object object_1)
	{
		return ((TableLayoutRowStyleCollection)object_0).Add((RowStyle)object_1);
	}

	internal static void vEUoZmUINSUAMYMsuic(object object_0, Size size_0)
	{
		((Control)object_0).set_Size(size_0);
	}

	internal static void ObTahsUUAIXCMV4ib7A(object object_0, int int_0)
	{
		((Control)object_0).set_TabIndex(int_0);
	}

	internal static void VO36ElUf0TvagRhsm9A(object object_0, AnchorStyles anchorStyles_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Control)object_0).set_Anchor(anchorStyles_0);
	}

	internal static Color jx8XVFUWTSqg4e7UHda()
	{
		return Color.Transparent;
	}

	internal static void hNiB7aUvTK0aQWuKC3X(object object_0, Color color_0)
	{
		((Control)object_0).set_BackColor(color_0);
	}

	internal static object nhSYfCUt98CG1lRtblv(object object_0)
	{
		return ((SplashScreen1)object_0).Copyright;
	}

	internal static object xfSf7BUe3xZd4s7RhOJ(object object_0)
	{
		return ((SplashScreen1)object_0).Version;
	}

	internal static void W0N4PeUXNteoa8Tm73i(object object_0, object object_1)
	{
		((Control)object_0).set_Font((Font)object_1);
	}

	internal static object iaMMGpUEUoktYorRCvj(object object_0)
	{
		return ((SplashScreen1)object_0).ApplicationTitle;
	}

	internal static void bhnhfWUgbUfenkTyw60(object object_0, object object_1)
	{
		((Label)object_0).set_Text((string)object_1);
	}

	internal static void u5OgeSU9l2F7T2kT8aD(object object_0, ContentAlignment contentAlignment_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Label)object_0).set_TextAlign(contentAlignment_0);
	}

	internal static void sBwy24UOaOSyB9ZPVsA(object object_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((ContainerControl)object_0).set_AutoScaleMode(autoScaleMode_0);
	}

	internal static void v26iKpUD47JRALr59ck(object object_0, Size size_0)
	{
		((Form)object_0).set_ClientSize(size_0);
	}

	internal static void CmL7dLUhU0I4SVi9xBi(object object_0, bool bool_0)
	{
		((Form)object_0).set_ControlBox(bool_0);
	}

	internal static object qGI2fqUSCtdobcEp1oE(object object_0)
	{
		return ((Control)object_0).get_Controls();
	}

	internal static void HTRy6nU2HL0IZGbqZpP(object object_0, FormBorderStyle formBorderStyle_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Form)object_0).set_FormBorderStyle(formBorderStyle_0);
	}

	internal static void Yyy2EbUusp8nayuWZwT(object object_0, bool bool_0)
	{
		((Form)object_0).set_MaximizeBox(bool_0);
	}

	internal static void p6wXEvUrSNfg0BrNNU9(object object_0, bool bool_0)
	{
		((Form)object_0).set_MinimizeBox(bool_0);
	}

	internal static void gmZ0s3UbRTOR87Qpji1(object object_0, bool bool_0)
	{
		((Form)object_0).set_ShowInTaskbar(bool_0);
	}

	internal static void z5hAJRUHXmf8A8QiwlS(object object_0, FormStartPosition formStartPosition_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Form)object_0).set_StartPosition(formStartPosition_0);
	}

	internal static void fCiwyWU5dX9cXfcfW3i(object object_0, bool bool_0)
	{
		((Control)object_0).ResumeLayout(bool_0);
	}

	internal static object MqE6AxUQOtY8Rp6R4qM()
	{
		return uj5IdEKfuKbugcX2aA.XNvTqP1Oe;
	}

	internal static object TrJ4JoUT8kbb0R1YQ5N(object object_0)
	{
		return ((ApplicationBase)object_0).get_Info();
	}

	internal static object lOdgxtU60ggsXbOKNNS(object object_0)
	{
		return ((AssemblyInfo)object_0).get_Title();
	}

	internal static object C4DEFIUp8IlsMHTiJTf(object object_0)
	{
		return Path.GetFileNameWithoutExtension((string?)object_0);
	}

	internal static int ukt8t6UyEoCI2VXioA2(object object_0)
	{
		return ((Version)object_0).Major;
	}

	internal static object AFvCAaUVFNx9y71moU6(object object_0)
	{
		return ((AssemblyInfo)object_0).get_Version();
	}

	internal static object dHorVqUcnIEY2djUeip(object object_0, object object_1, object object_2)
	{
		return string.Format((string)object_0, object_1, object_2);
	}

	internal static object hVmMJTU0B5qdq7xQgeV(object object_0)
	{
		return ((AssemblyInfo)object_0).get_Copyright();
	}
}
