using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace _111zal2;

public class get_SizeExpression : Form
{
	private IContainer BlankDataBlock = null;

	private Button _003CScanAttlist1Async_003Ed__183;

	private ProgressBar QueryAggregationOptions;

	private Class2.Class3 class3_0 = new Class2.Class3();

	public get_SizeExpression()
	{
		DataGridViewSortCompareEventArgs();
	}

	private void SmtpException(int ListChangedType)
	{
		Math.Pow(ListChangedType, ListChangedType);
	}

	public double BLOB(double HttpHeaders, double RectangleConverter)
	{
		return HttpHeaders * RectangleConverter;
	}

	private void GridEntry(object sender, EventArgs e)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		QueryAggregationOptions.set_Maximum(100);
		QueryAggregationOptions.set_Step(1);
		MulticastDelegate multicastDelegate = new DecodeXmlNamespaceForClrTypeNamespace(BLOB);
		((Control)class3_0.label_0).set_Text(((DecodeXmlNamespaceForClrTypeNamespace)multicastDelegate)(1000.0, 1000.0).ToString());
		MessageBox.Show("Calculations compleated", "Done");
	}

	protected override void SignedCmiManifest2(bool DragEventArgs)
	{
		if (DragEventArgs && BlankDataBlock != null)
		{
			BlankDataBlock.Dispose();
		}
		((Form)this).Dispose(DragEventArgs);
	}

	private void DataGridViewSortCompareEventArgs()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		_003CScanAttlist1Async_003Ed__183 = new Button();
		QueryAggregationOptions = new ProgressBar();
		object obj = (object)new Label();
		class3_0.label_0 = (Label)((obj is Label) ? obj : null);
		((Control)this).SuspendLayout();
		((Control)_003CScanAttlist1Async_003Ed__183).set_Location(new Point(144, 289));
		((Control)_003CScanAttlist1Async_003Ed__183).set_Name("button1");
		((Control)_003CScanAttlist1Async_003Ed__183).set_Size(new Size(75, 23));
		((Control)_003CScanAttlist1Async_003Ed__183).set_TabIndex(0);
		((Control)_003CScanAttlist1Async_003Ed__183).set_Text("button1");
		((ButtonBase)_003CScanAttlist1Async_003Ed__183).set_UseVisualStyleBackColor(true);
		((Control)_003CScanAttlist1Async_003Ed__183).add_Click((EventHandler)GridEntry);
		((Control)QueryAggregationOptions).set_Location(new Point(12, 260));
		((Control)QueryAggregationOptions).set_Name("progressBar1");
		((Control)QueryAggregationOptions).set_Size(new Size(336, 23));
		((Control)QueryAggregationOptions).set_TabIndex(1);
		((Control)class3_0.label_0).set_AutoSize(true);
		((Control)class3_0.label_0).set_Location(new Point(141, 244));
		((Control)class3_0.label_0).set_Name("label1");
		((Control)class3_0.label_0).set_Size(new Size(0, 13));
		((Control)class3_0.label_0).set_TabIndex(2);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(360, 324));
		((Control)this).get_Controls().Add((Control)(object)class3_0.label_0);
		((Control)this).get_Controls().Add((Control)(object)QueryAggregationOptions);
		((Control)this).get_Controls().Add((Control)(object)_003CScanAttlist1Async_003Ed__183);
		((Control)this).set_Name("AboutForm");
		((Control)this).set_Text("AboutForm");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
