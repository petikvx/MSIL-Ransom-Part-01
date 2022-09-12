using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using Ky21;
using Microsoft.VisualBasic.CompilerServices;
using Pb3;
using Rk2t;
using Sy3;
using d3BQ;
using i1W;
using k3WY;
using o8EK;
using s5R;
using t6C;
using y8XC;

namespace Je8;

[DesignerGenerated]
public class t0Q : Window, IComponentConnector
{
	private Button _btnpatient;

	private Button _btnregdoctors;

	private Button _btnregwards;

	private Button _btndiagnosis;

	private Button _btnwardadmission;

	private Button _btnbilling;

	private bool _contentLoaded;

	internal Button W;

	internal Button K;

	internal Label y;

	internal Button Q;

	internal Button a;

	public t0Q()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		((FrameworkElement)this).add_Loaded(new RoutedEventHandler(Wj3));
		r0C();
	}

	private void Wj3(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void d4G(object sender, RoutedEventArgs e)
	{
		ProjectData.EndApp();
	}

	private void n3M(object sender, RoutedEventArgs e)
	{
		j3Q6 j3Q = new j3Q6();
		((ContentControl)j3Q.Mc0x()).set_Content(RuntimeHelpers.GetObjectValue(((ContentControl)q7Z()).get_Content()));
		((Window)j3Q).Show();
	}

	private void t3F(object sender, RoutedEventArgs e)
	{
		Ko1 ko = new Ko1();
		((ContentControl)ko.An7()).set_Content(RuntimeHelpers.GetObjectValue(((ContentControl)q7Z()).get_Content()));
		((Window)ko).Show();
	}

	private void o1B(object sender, RoutedEventArgs e)
	{
		Xt9 xt = new Xt9();
		((ContentControl)xt.n6C()).set_Content(RuntimeHelpers.GetObjectValue(((ContentControl)q7Z()).get_Content()));
		((Window)xt).Show();
	}

	private void Kw4(object sender, RoutedEventArgs e)
	{
		Te1 te = new Te1();
		((ContentControl)te.Zz7()).set_Content(RuntimeHelpers.GetObjectValue(((ContentControl)q7Z()).get_Content()));
		((Window)te).Show();
	}

	private void n4A(object sender, RoutedEventArgs e)
	{
		Hg7a hg7a = new Hg7a();
		((ContentControl)hg7a.a6F()).set_Content(RuntimeHelpers.GetObjectValue(((ContentControl)q7Z()).get_Content()));
		((Window)hg7a).Show();
	}

	private void e3E(object sender, RoutedEventArgs e)
	{
		Wi4 wi = new Wi4();
		((ContentControl)wi.Km8()).set_Content(RuntimeHelpers.GetObjectValue(((ContentControl)q7Z()).get_Content()));
		((Window)wi).Show();
	}

	private void Ek3(object sender, RoutedEventArgs e)
	{
		Gy6b gy6b = new Gy6b();
		((ContentControl)gy6b.f8S7()).set_Content(RuntimeHelpers.GetObjectValue(((ContentControl)q7Z()).get_Content()));
		((Window)gy6b).Show();
	}

	private void Kr8(object sender, RoutedEventArgs e)
	{
		Cs7 cs = new Cs7();
		((ContentControl)cs.a1Q()).set_Content(RuntimeHelpers.GetObjectValue(((ContentControl)q7Z()).get_Content()));
		((Window)cs).Show();
	}

	private void w0H(object sender, RoutedEventArgs e)
	{
		Hx4b hx4b = new Hx4b();
		((ContentControl)hx4b.Pf0m()).set_Content(RuntimeHelpers.GetObjectValue(((ContentControl)q7Z()).get_Content()));
		((Window)hx4b).Show();
	}

	private void z1S(object sender, RoutedEventArgs e)
	{
		p0R1 p0R = new p0R1();
		((ContentControl)p0R.Zg98()).set_Content(RuntimeHelpers.GetObjectValue(((ContentControl)q7Z()).get_Content()));
		((Window)p0R).Show();
	}

	private void k7W(object sender, RoutedEventArgs e)
	{
		((UIElement)Ly1()).set_IsEnabled(false);
		((UIElement)z0E()).set_IsEnabled(false);
		((UIElement)r3D()).set_IsEnabled(false);
		((UIElement)Cj8()).set_IsEnabled(false);
		((UIElement)w7R()).set_IsEnabled(false);
		((UIElement)Pt7()).set_IsEnabled(false);
		((UIElement)m4C()).set_IsEnabled(false);
		((UIElement)Tb4()).set_IsEnabled(false);
		((UIElement)Sg5()).set_IsEnabled(false);
		((UIElement)p2P()).set_IsEnabled(false);
		a3P4 a3P = new a3P4();
		((Window)a3P).Show();
		((ContentControl)a3P.Hm0c()).set_Content(RuntimeHelpers.GetObjectValue(((ContentControl)q7Z()).get_Content()));
		((Window)this).Hide();
	}

	[SpecialName]
	internal virtual Button Ly1()
	{
		return _btnpatient;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ga8(Button y2J)
	{
		_btnpatient = y2J;
	}

	[SpecialName]
	internal virtual Button z0E()
	{
		return W;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fj1(Button Yt2)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(t3F);
		Button w = W;
		if (w != null)
		{
			((ButtonBase)w).remove_Click(val);
		}
		Button val2 = (W = Yt2);
		w = W;
		if (w != null)
		{
			((ButtonBase)w).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Tb4()
	{
		return _btnregdoctors;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c7N(Button Pd9)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(o1B);
		Button btnregdoctors = _btnregdoctors;
		if (btnregdoctors != null)
		{
			((ButtonBase)btnregdoctors).remove_Click(val);
		}
		_btnregdoctors = Pd9;
		btnregdoctors = _btnregdoctors;
		if (btnregdoctors != null)
		{
			((ButtonBase)btnregdoctors).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Pt7()
	{
		return K;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q4W(Button Jk1)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Kw4);
		Button k = K;
		if (k != null)
		{
			((ButtonBase)k).remove_Click(val);
		}
		Button val2 = (K = Jk1);
		k = K;
		if (k != null)
		{
			((ButtonBase)k).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button m4C()
	{
		return _btnregwards;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ed2(Button Xe3)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(n4A);
		Button btnregwards = _btnregwards;
		if (btnregwards != null)
		{
			((ButtonBase)btnregwards).remove_Click(val);
		}
		_btnregwards = Xe3;
		btnregwards = _btnregwards;
		if (btnregwards != null)
		{
			((ButtonBase)btnregwards).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button r3D()
	{
		return _btndiagnosis;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yx9(Button w1M)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(e3E);
		Button btndiagnosis = _btndiagnosis;
		if (btndiagnosis != null)
		{
			((ButtonBase)btndiagnosis).remove_Click(val);
		}
		_btndiagnosis = w1M;
		btndiagnosis = _btndiagnosis;
		if (btndiagnosis != null)
		{
			((ButtonBase)btndiagnosis).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Cj8()
	{
		return _btnwardadmission;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dy4(Button t8J)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Ek3);
		Button btnwardadmission = _btnwardadmission;
		if (btnwardadmission != null)
		{
			((ButtonBase)btnwardadmission).remove_Click(val);
		}
		_btnwardadmission = t8J;
		btnwardadmission = _btnwardadmission;
		if (btnwardadmission != null)
		{
			((ButtonBase)btnwardadmission).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button w7R()
	{
		return _btnbilling;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g3Y(Button s0E)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Kr8);
		Button btnbilling = _btnbilling;
		if (btnbilling != null)
		{
			((ButtonBase)btnbilling).remove_Click(val);
		}
		_btnbilling = s0E;
		btnbilling = _btnbilling;
		if (btnbilling != null)
		{
			((ButtonBase)btnbilling).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Label q7Z()
	{
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bj0(Label e8W)
	{
		Label val = (y = e8W);
	}

	[SpecialName]
	internal virtual Button p2P()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ez1(Button z7Y)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(w0H);
		Button q = Q;
		if (q != null)
		{
			((ButtonBase)q).remove_Click(val);
		}
		Button val2 = (Q = z7Y);
		q = Q;
		if (q != null)
		{
			((ButtonBase)q).add_Click(val);
		}
	}

	[SpecialName]
	internal virtual Button Sg5()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Et3(Button m7W)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(z1S);
		Button val2 = a;
		if (val2 != null)
		{
			((ButtonBase)val2).remove_Click(val);
		}
		Button val3 = (a = m7W);
		val2 = a;
		if (val2 != null)
		{
			((ButtonBase)val2).add_Click(val);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void r0C()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/PatientRecordManagementSystem;component/mainnavigation.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void e8B(int m0H, object Mk6)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		switch (m0H)
		{
		case 1:
			Ga8((Button)Mk6);
			((ButtonBase)Ly1()).add_Click(new RoutedEventHandler(n3M));
			break;
		case 2:
			Fj1((Button)Mk6);
			break;
		case 3:
			c7N((Button)Mk6);
			break;
		case 4:
			q4W((Button)Mk6);
			break;
		case 5:
			Ed2((Button)Mk6);
			break;
		case 6:
			Yx9((Button)Mk6);
			break;
		case 7:
			Dy4((Button)Mk6);
			break;
		case 8:
			g3Y((Button)Mk6);
			break;
		case 9:
			Bj0((Label)Mk6);
			break;
		case 10:
			((ButtonBase)(Button)Mk6).add_Click(new RoutedEventHandler(d4G));
			break;
		case 11:
			Ez1((Button)Mk6);
			break;
		case 12:
			Et3((Button)Mk6);
			break;
		case 13:
			((ButtonBase)(Button)Mk6).add_Click(new RoutedEventHandler(k7W));
			break;
		default:
			_contentLoaded = true;
			break;
		}
	}
}
