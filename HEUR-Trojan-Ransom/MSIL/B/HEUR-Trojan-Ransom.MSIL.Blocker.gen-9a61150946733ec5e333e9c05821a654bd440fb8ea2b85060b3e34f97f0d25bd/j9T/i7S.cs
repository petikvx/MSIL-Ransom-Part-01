using System.ComponentModel;
using System.ComponentModel.Design;
using System.Configuration;
using System.Windows.Forms;
using Ar3;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace j9T;

[HideModuleName]
[StandardModule]
internal sealed class i7S
{
	internal sealed class k3S
	{
		internal object object_0;

		internal IContainer icontainer_0;

		internal Button button_0;

		internal Button button_1;

		internal TextBox textBox_0;

		internal Button button_2;

		internal Timer timer_0;

		internal k3S()
		{
		}
	}

	[HelpKeyword("My.Settings")]
	internal static Ap6 Settings
	{
		get
		{
			ApplicationSettingsBase @default = (ApplicationSettingsBase)(object)Ap6.Default;
			return @default as Ap6;
		}
	}
}
