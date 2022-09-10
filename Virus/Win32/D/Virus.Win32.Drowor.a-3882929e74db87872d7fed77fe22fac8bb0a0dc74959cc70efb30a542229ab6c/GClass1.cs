using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

public class GClass1
{
	public delegate void GDelegate0(GClass1 gclass1_0);

	public delegate string GDelegate1(string string_0);

	private GClass7 gclass7_0;

	private GDelegate0 gdelegate0_0;

	public GDelegate1 gdelegate1_0;

	public GDelegate1 gdelegate1_1;

	private List<int> list_0;

	private int int_0;

	private int int_1;

	private int int_2;

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	public void method_0(GDelegate0 gdelegate0_1)
	{
		gdelegate0_0 = (GDelegate0)Delegate.Combine(gdelegate0_0, gdelegate0_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	public void method_1(GDelegate0 gdelegate0_1)
	{
		gdelegate0_0 = (GDelegate0)Delegate.Remove(gdelegate0_0, gdelegate0_1);
	}

	[SpecialName]
	public int method_2()
	{
		return int_0;
	}

	[SpecialName]
	public int method_3()
	{
		return int_1;
	}

	[SpecialName]
	public int method_4()
	{
		list_0.Sort();
		list_0.Reverse();
		int num = 0;
		for (int i = 0; i < list_0.Count; i++)
		{
			num += list_0[i];
			if (i == 2)
			{
				break;
			}
		}
		return num;
	}

	[SpecialName]
	public string method_5()
	{
		return "( " + method_2() + " | " + method_3() + " )";
	}

	[SpecialName]
	public int method_6()
	{
		return int_2;
	}

	public GClass1(int int_3, int int_4, double double_0, int int_5, GDelegate1 gdelegate1_2, GDelegate1 gdelegate1_3)
	{
		gdelegate1_0 = gdelegate1_2;
		gdelegate1_1 = gdelegate1_3;
		int_2 = int_5;
		int_0 = int_3;
		int_1 = int_4;
		list_0 = new List<int>();
		gclass7_0 = new GClass7(int_3, int_4, 0, double_0);
		gclass7_0.ProgressChanged += gclass7_0_ProgressChanged;
		gclass7_0.RunWorkerCompleted += gclass7_0_RunWorkerCompleted;
	}

	public void method_7()
	{
		gclass7_0.RunWorkerAsync();
	}

	public void method_8()
	{
		if (gclass7_0.IsBusy)
		{
			gclass7_0.CancelAsync();
		}
	}

	protected void gclass7_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		if (gdelegate0_0 != null)
		{
			gdelegate0_0(this);
		}
	}

	protected void gclass7_0_ProgressChanged(object sender, ProgressChangedEventArgs e)
	{
		GStruct2 gStruct = (GStruct2)e.UserState;
		string string_;
		if ((string_ = gStruct.string_0) != null && string_ == "Found")
		{
			string text = gdelegate1_0(gStruct.string_1.Trim().ToLower());
			if (text == "Oasis")
			{
				string string_2 = gdelegate1_1(gStruct.string_4);
				list_0.Add(GClass2.gclass2_0.method_1(string_2));
			}
		}
	}
}
