using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;
using 㵀㵆㴽㴉㴺㴌㴥㴐㵏㴉㴲㴐㴒㴼㴒;

namespace TicTacToe;

public class 헁햒헁햽허햒헑햒햕헁햕햒햪햎햞 : Window, IComponentConnector
{
	private bool 㧲㧎㧪㧧㦴㦴㦸㦽㧩㧐㧪㧩㦺㧪㧦;

	public 헁햒헁햽허햒헑햒햕헁햕햒햪햎햞(휷휣휂휇휋휴흆휇휅휷휬휉휓휋휴 GameWindowViewModel)
	{
		((FrameworkElement)this).set_DataContext((object)GameWindowViewModel);
		观解覽覽觯觼觃规觳视觿觀觰觱观();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void 观解覽覽觯觼觃规觳视觿觀觰觱观()
	{
		//Discarded unreachable code: IL_000a, IL_0013, IL_0016, IL_0031
		//IL_000a: Ignored invalid 'constrained' prefix
		bool flag = 㧲㧎㧪㧧㦴㦴㦸㦽㧩㧐㧪㧩㦺㧪㧦;
		/*Error near IL_0008: Could not find block for branch target IL_0010*/;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate 㦔㦍㦉㦋㥯㥹㥠㥽㥲㦉㦌㦉㥮㥱㥛(Type ﳍﲽﲎﲍﳆﲾﲾﲊﲍﲎﲎﲟﲎﲜﲺ, string 泍泅泤泶沺沶沶波沵泦泴泓泦泔注)
	{
		//Discarded unreachable code: IL_000c, IL_000e
		//IL_000e: Ignored invalid 'constrained' prefix
		Delegate @delegate = Delegate.CreateDelegate(ﳍﲽﲎﲍﳆﲾﲾﲊﲍﲎﲎﲟﲎﲜﲺ, this, 泍泅泤泶沺沶沶波沵泦泴泓泦泔注);
		/*Error near IL_000a: Could not find block for branch target IL_0014*/;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	private void 냖냜냘너너넚넙냚넇너냻넇냳냟냚(int _FF1A_FF09_FF1DＭ_FF0C_FF1CＸ_FF0B_FF0D_FF0C_FF07_FF0BＧＹ_FF0D, object _E612_E61C_E62A_E613_E61F_E614_E612_E613_E62A_E5E2_E612_E616_E5E8_E612_E5E0)
	{
		㧲㧎㧪㧧㦴㦴㦸㦽㧩㧐㧪㧩㦺㧪㧦 = true;
	}
}
