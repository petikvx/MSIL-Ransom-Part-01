using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class GForm0 : Form
{
	private long long_0;

	private long long_1;

	private WebClient webClient_0;

	public const int int_0 = 2;

	public const int int_1 = 4;

	private const int int_2 = 8;

	private const int int_3 = 16;

	private IContainer icontainer_0;

	[CompilerGenerated]
	[AccessedThroughProperty("\u0ad8ર\u0a80\u0a92\u0ae3ષ\u0afe\u0afbધ\u0acdઅ\u0ad8\u0ad4\u0ad4")]
	private TabControl tabControl_0;

	[AccessedThroughProperty("\u0ad8ર\u0a80\u0a92\u0ae3ષ\u0afe\u0afbધ\u0acdઅ\u0ad8\u0ad4\u0ad5")]
	[CompilerGenerated]
	private TabPage tabPage_0;

	[AccessedThroughProperty("\u0ad8ર\u0a80\u0a92\u0ae3ષ\u0afe\u0afbધ\u0acdઅ\u0ad8\u0ad4\u0ad6")]
	[CompilerGenerated]
	private TabPage tabPage_1;

	[CompilerGenerated]
	[AccessedThroughProperty("\u0ad8ર\u0a80\u0a92\u0ae3ષ\u0afe\u0afbધ\u0acdઅ\u0ad8\u0ad4\u0ad7")]
	private Label label_0;

	[CompilerGenerated]
	[AccessedThroughProperty("\u0ad8ર\u0a80\u0a92\u0ae3ષ\u0afe\u0afbધ\u0acdઅ\u0ad8\u0ad4\u0ad8")]
	private Label label_1;

	[CompilerGenerated]
	[AccessedThroughProperty("\u0ad8ર\u0a80\u0a92\u0ae3ષ\u0afe\u0afbધ\u0acdઅ\u0ad8\u0ad4\u0ad9")]
	private Label label_2;

	[CompilerGenerated]
	[AccessedThroughProperty("\u0ad8ર\u0a80\u0a92\u0ae3ષ\u0afe\u0afbધ\u0acdઅ\u0ad8\u0ad4\u0ada")]
	private Label label_3;

	[CompilerGenerated]
	[AccessedThroughProperty("\u0ad8ર\u0a80\u0a92\u0ae3ષ\u0afe\u0afbધ\u0acdઅ\u0ad8\u0ad4\u0adb")]
	private Label label_4;

	[CompilerGenerated]
	[AccessedThroughProperty("\u0ad8ર\u0a80\u0a92\u0ae3ષ\u0afe\u0afbધ\u0acdઅ\u0ad8\u0ad4\u0adc")]
	private Button button_0;

	[CompilerGenerated]
	[AccessedThroughProperty("\u0ad8ર\u0a80\u0a92\u0ae3ષ\u0afe\u0afbધ\u0acdઅ\u0ad8\u0ad4\u0add")]
	private Button button_1;

	[AccessedThroughProperty("\u0ad8ર\u0a80\u0a92\u0ae3ષ\u0afe\u0afbધ\u0acdઅ\u0ad8\u0ad4\u0ade")]
	[CompilerGenerated]
	private TabPage tabPage_2;

	[CompilerGenerated]
	[AccessedThroughProperty("\u0ad8ર\u0a80\u0a92\u0ae3ષ\u0afe\u0afbધ\u0acdઅ\u0ad8\u0ad4\u0adf")]
	private Timer timer_0;

	[CompilerGenerated]
	[AccessedThroughProperty("\u0ad8ર\u0a80\u0a92\u0ae3ષ\u0afe\u0afbધ\u0acdઅ\u0ad8\u0ad4ૠ")]
	private TextBox textBox_0;

	[AccessedThroughProperty("\u0ad8ર\u0a80\u0a92\u0ae3ષ\u0afe\u0afbધ\u0acdઅ\u0ad8\u0ad4ૡ")]
	[CompilerGenerated]
	private Label label_5;

	[AccessedThroughProperty("\u0ad8ર\u0a80\u0a92\u0ae3ષ\u0afe\u0afbધ\u0acdઅ\u0ad8\u0ad4\u0ae2")]
	[CompilerGenerated]
	private RadioButton radioButton_0;

	[AccessedThroughProperty("\u0ad8ર\u0a80\u0a92\u0ae3ષ\u0afe\u0afbધ\u0acdઅ\u0ad8\u0ad4\u0ae3")]
	[CompilerGenerated]
	private RadioButton radioButton_1;

	[AccessedThroughProperty("\u0ad8ર\u0a80\u0a92\u0ae3ષ\u0afe\u0afbધ\u0acdઅ\u0ad8\u0ad4\u0ae4")]
	[CompilerGenerated]
	private Timer timer_1;

	[CompilerGenerated]
	[AccessedThroughProperty("\u0ad8ર\u0a80\u0a92\u0ae3ષ\u0afe\u0afbધ\u0acdઅ\u0ad8\u0ad4\u0ae5")]
	private Label label_6;

	[AccessedThroughProperty("\u0ad8ર\u0a80\u0a92\u0ae3ષ\u0afe\u0afbધ\u0acdઅ\u0ad8\u0ad4૦")]
	[CompilerGenerated]
	private Label label_7;

	[CompilerGenerated]
	[AccessedThroughProperty("\u0ad8ર\u0a80\u0a92\u0ae3ષ\u0afe\u0afbધ\u0acdઅ\u0ad8\u0ad4૧")]
	private Label label_8;

	[AccessedThroughProperty("\u0ad8ર\u0a80\u0a92\u0ae3ષ\u0afe\u0afbધ\u0acdઅ\u0ad8\u0ad4૨")]
	[CompilerGenerated]
	private Label label_9;

	internal virtual TabControl TabControl_0
	{
		[CompilerGenerated]
		get
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected O, but got Unknown
			return (TabControl)Class29.smethod_0(7574217, this, null);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			Class29.smethod_0(7574049, this, value);
		}
	}

	internal virtual TabPage TabPage_0
	{
		[CompilerGenerated]
		get
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected O, but got Unknown
			return (TabPage)Class29.smethod_0(7574021, this, null);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			Class29.smethod_0(7574141, this, value);
		}
	}

	internal virtual TabPage TabPage_1
	{
		[CompilerGenerated]
		get
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected O, but got Unknown
			return (TabPage)Class29.smethod_0(7574097, this, null);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			Class29.smethod_0(7574089, this, value);
		}
	}

	internal virtual Label Label_0
	{
		[CompilerGenerated]
		get
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected O, but got Unknown
			return (Label)Class29.smethod_0(7573933, this, null);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			Class29.smethod_0(7573893, this, value);
		}
	}

	internal virtual Label Label_1
	{
		[CompilerGenerated]
		get
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected O, but got Unknown
			return (Label)Class29.smethod_0(7574009, this, null);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			Class29.smethod_0(7573969, this, value);
		}
	}

	internal virtual Label Label_2
	{
		[CompilerGenerated]
		get
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected O, but got Unknown
			return (Label)Class29.smethod_0(7573813, this, null);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			Class29.smethod_0(7573805, this, value);
		}
	}

	internal virtual Label Label_3
	{
		[CompilerGenerated]
		get
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected O, but got Unknown
			return (Label)Class29.smethod_0(7573761, this, null);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			Class29.smethod_0(7573881, this, value);
		}
	}

	internal virtual Label Label_4
	{
		[CompilerGenerated]
		get
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected O, but got Unknown
			return (Label)Class29.smethod_0(7573853, this, null);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			Class29.smethod_0(7573685, this, value);
		}
	}

	internal virtual Button Button_0
	{
		[CompilerGenerated]
		get
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected O, but got Unknown
			return (Button)Class29.smethod_0(7573673, this, null);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			Class29.smethod_0(7573633, this, value);
		}
	}

	internal virtual Button Button_1
	{
		[CompilerGenerated]
		get
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected O, but got Unknown
			return (Button)Class29.smethod_0(7573594, this, null);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			Class29.smethod_0(7577522, this, value);
		}
	}

	internal virtual TabPage TabPage_2
	{
		[CompilerGenerated]
		get
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected O, but got Unknown
			return (TabPage)Class29.smethod_0(7577359, this, null);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			Class29.smethod_0(7577447, this, value);
		}
	}

	internal virtual Timer Timer_0
	{
		[CompilerGenerated]
		get
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected O, but got Unknown
			return (Timer)Class29.smethod_0(7577435, this, null);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			Class29.smethod_0(7577267, this, value);
		}
	}

	internal virtual TextBox TextBox_0
	{
		[CompilerGenerated]
		get
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected O, but got Unknown
			return (TextBox)Class29.smethod_0(7577100, this, null);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			Class29.smethod_0(7577188, this, value);
		}
	}

	internal virtual Label Label_5
	{
		[CompilerGenerated]
		get
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected O, but got Unknown
			return (Label)Class29.smethod_0(7577176, this, null);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			Class29.smethod_0(7577008, this, value);
		}
	}

	internal virtual RadioButton RadioButton_0
	{
		[CompilerGenerated]
		get
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected O, but got Unknown
			return (RadioButton)Class29.smethod_0(7576980, this, null);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			Class29.smethod_0(7576972, this, value);
		}
	}

	internal virtual RadioButton RadioButton_1
	{
		[CompilerGenerated]
		get
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected O, but got Unknown
			return (RadioButton)Class29.smethod_0(7577056, this, null);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			Class29.smethod_0(7577048, this, value);
		}
	}

	internal virtual Timer Timer_1
	{
		[CompilerGenerated]
		get
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected O, but got Unknown
			return (Timer)Class29.smethod_0(7576892, this, null);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			Class29.smethod_0(7576852, this, value);
		}
	}

	internal virtual Label Label_6
	{
		[CompilerGenerated]
		get
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected O, but got Unknown
			return (Label)Class29.smethod_0(7576800, this, null);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			Class29.smethod_0(7576792, this, value);
		}
	}

	internal virtual Label Label_7
	{
		[CompilerGenerated]
		get
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected O, but got Unknown
			return (Label)Class29.smethod_0(7576636, this, null);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			Class29.smethod_0(7576596, this, value);
		}
	}

	internal virtual Label Label_8
	{
		[CompilerGenerated]
		get
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected O, but got Unknown
			return (Label)Class29.smethod_0(7576584, this, null);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			Class29.smethod_0(7576672, this, value);
		}
	}

	internal virtual Label Label_9
	{
		[CompilerGenerated]
		get
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected O, but got Unknown
			return (Label)Class29.smethod_0(7576644, this, null);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			Class29.smethod_0(7576508, this, value);
		}
	}

	public GForm0()
	{
		((Form)this).add_Load((EventHandler)GForm0_Load);
		while (true)
		{
			int num = Class54.smethod_0(83);
			int num2 = 6;
			while (true)
			{
				IL_00c3:
				num2 ^= 0x5A;
				int num3;
				while (true)
				{
					num3 = Class54.smethod_0(90);
					while (true)
					{
						switch (num3 ^ 0x5A)
						{
						case -82:
							num3 = Class20.smethod_0(92);
							continue;
						case -80:
							goto end_IL_0043;
						case -81:
							goto IL_006c;
						case -79:
							goto IL_00c3;
						}
						break;
					}
					continue;
					end_IL_0043:
					break;
				}
				switch (num2)
				{
				case 90:
					goto IL_0076;
				case 91:
					goto IL_00b2;
				case 92:
					goto IL_00b6;
				case 89:
					goto end_IL_00c3;
				}
				num3 = -11;
				num3 = -81;
				goto IL_006c;
				IL_00b6:
				num ^= 0x4D;
				num2 = 0;
				num3 = -21;
				num3 = -79;
				continue;
				IL_006c:
				num2 = 0;
				num3 = -21;
				num3 = -79;
				continue;
				IL_00b2:
				num2 = 1;
				continue;
				IL_0076:
				switch (num)
				{
				default:
					num2 = 3;
					continue;
				case -79:
					webClient_0 = new WebClient();
					num = -2;
					break;
				case -78:
					num = -1;
					break;
				case -77:
					Delegate19.smethod_0(this);
					num = -7;
					break;
				case -76:
					return;
				}
				goto IL_00b6;
				continue;
				end_IL_00c3:
				break;
			}
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetAsyncKeyState(long long_2);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool mouse_event(int int_4, int int_5, int int_6, int int_7, int int_8);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, EntryPoint = "mouse_event", ExactSpelling = true, SetLastError = true)]
	private static extern void mouse_event_1(int int_4, int int_5, int int_6, int int_7, int int_8);

	private void GForm0_Load(object sender, EventArgs e)
	{
		Class29.smethod_0(7581692, this, sender, e);
	}

	private void method_0(object sender, EventArgs e)
	{
		Class29.smethod_0(7581171, this, sender, e);
	}

	private void method_1(object sender, EventArgs e)
	{
		Class29.smethod_0(7580752, this, sender, e);
	}

	private void method_2(object sender, EventArgs e)
	{
		Class29.smethod_0(7580267, this, sender, e);
	}

	public static void smethod_0()
	{
		Class29.smethod_0(7583538, null, null);
	}

	private void method_3(object sender, EventArgs e)
	{
		Class29.smethod_0(7582838, this, sender, e);
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		Class29.smethod_0(7582193, this, disposing);
	}

	[DebuggerStepThrough]
	private void method_4()
	{
		Class29.smethod_0(7581963, this, null);
	}
}
