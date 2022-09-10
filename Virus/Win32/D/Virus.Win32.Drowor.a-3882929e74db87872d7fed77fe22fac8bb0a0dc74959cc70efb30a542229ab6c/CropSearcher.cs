using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class CropSearcher : Form
{
	private IContainer icontainer_0;

	private CtrlCropSearcher ctrlCropSearcher1;

	void Form.Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		ctrlCropSearcher1 = new CtrlCropSearcher();
		((Control)this).SuspendLayout();
		((Control)ctrlCropSearcher1).set_Dock((DockStyle)5);
		((Control)ctrlCropSearcher1).set_Location(new Point(0, 0));
		((Control)ctrlCropSearcher1).set_Name("ctrlCropSearcher1");
		((Control)ctrlCropSearcher1).set_Size(new Size(661, 466));
		((Control)ctrlCropSearcher1).set_TabIndex(0);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(661, 466));
		((Control)this).get_Controls().Add((Control)(object)ctrlCropSearcher1);
		((Control)this).set_MinimumSize(new Size(669, 500));
		((Control)this).set_Name("CropSearcher");
		((Control)this).set_Text("Crop Searcher");
		((Control)this).ResumeLayout(false);
	}

	public CropSearcher()
	{
		InitializeComponent();
	}

	public void method_0(int int_0, int int_1, int int_2, double double_0, GStruct1 gstruct1_0)
	{
		ctrlCropSearcher1.method_2(int_0, int_1, int_2, double_0, gstruct1_0);
	}

	void Form.WndProc(ref Message message_0)
	{
		if (((Message)(ref message_0)).get_Msg() == 161 && ((Message)(ref message_0)).get_WParam().ToInt32() == 20)
		{
			ctrlCropSearcher1.method_12();
		}
		else
		{
			((Form)this).WndProc(ref message_0);
		}
	}
}
