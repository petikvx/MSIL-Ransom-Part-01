using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Windi;

[DesignerGenerated]
public class DeviceContext : Form
{
	private static List<WeakReference> logLength = new List<WeakReference>();

	private IContainer currentNames;

	[AccessedThroughProperty("Button1")]
	private Button currentUri;

	[AccessedThroughProperty("Label1")]
	private Label filterCollection;

	[AccessedThroughProperty("Label2")]
	private Label messageInitialized;

	[AccessedThroughProperty("Label3")]
	private Label categoryAvailable;

	[AccessedThroughProperty("RadioButton1")]
	private RadioButton optionsCache;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar containerList;

	[AccessedThroughProperty("TextBox1")]
	private TextBox rootContainer;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox rootValues;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox outputCollection;

	internal virtual Button AddEmulator
	{
		[DebuggerNonUserCode]
		get
		{
			return currentUri;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			currentUri = value;
		}
	}

	internal virtual Label CloseSolution
	{
		[DebuggerNonUserCode]
		get
		{
			return filterCollection;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			filterCollection = value;
		}
	}

	internal virtual Label OrderActivator
	{
		[DebuggerNonUserCode]
		get
		{
			return messageInitialized;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			messageInitialized = value;
		}
	}

	internal virtual Label DisconnectQueue
	{
		[DebuggerNonUserCode]
		get
		{
			return categoryAvailable;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			categoryAvailable = value;
		}
	}

	internal virtual RadioButton OpenClient
	{
		[DebuggerNonUserCode]
		get
		{
			return optionsCache;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			optionsCache = value;
		}
	}

	internal virtual ProgressBar ProcessView
	{
		[DebuggerNonUserCode]
		get
		{
			return containerList;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			containerList = value;
		}
	}

	internal virtual TextBox LoadPath
	{
		[DebuggerNonUserCode]
		get
		{
			return rootContainer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			rootContainer = value;
		}
	}

	internal virtual PictureBox UnregisterDialog
	{
		[DebuggerNonUserCode]
		get
		{
			return rootValues;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			rootValues = value;
		}
	}

	internal virtual PictureBox InsertXmlFile
	{
		[DebuggerNonUserCode]
		get
		{
			return outputCollection;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			outputCollection = value;
		}
	}

	[DebuggerNonUserCode]
	public DeviceContext()
	{
		((Form)this).add_Load((EventHandler)SplitFile);
		DeleteLine(this);
		BatchBuildConfig();
	}

	[DebuggerNonUserCode]
	private static void DeleteLine(object logLength)
	{
		checked
		{
			lock (DeviceContext.logLength)
			{
				if (DeviceContext.logLength.Count == DeviceContext.logLength.Capacity)
				{
					int num = 0;
					int num2 = DeviceContext.logLength.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = DeviceContext.logLength[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								DeviceContext.logLength[num] = DeviceContext.logLength[num3];
							}
							num++;
						}
						num3++;
					}
					DeviceContext.logLength.RemoveRange(num, DeviceContext.logLength.Count - num);
					DeviceContext.logLength.Capacity = DeviceContext.logLength.Count;
				}
				DeviceContext.logLength.Add(new WeakReference(RuntimeHelpers.GetObjectValue(logLength)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && currentNames != null) ? true : false)
			{
				currentNames.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void BatchBuildConfig()
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
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(DeviceContext));
		AddEmulator = new Button();
		CloseSolution = new Label();
		OrderActivator = new Label();
		DisconnectQueue = new Label();
		OpenClient = new RadioButton();
		ProcessView = new ProgressBar();
		LoadPath = new TextBox();
		UnregisterDialog = new PictureBox();
		InsertXmlFile = new PictureBox();
		((ISupportInitialize)UnregisterDialog).BeginInit();
		((ISupportInitialize)InsertXmlFile).BeginInit();
		((Control)this).SuspendLayout();
		Button addEmulator = AddEmulator;
		Point location = new Point(154, 79);
		((Control)addEmulator).set_Location(location);
		((Control)AddEmulator).set_Name("Button1");
		Button addEmulator2 = AddEmulator;
		Size size = new Size(75, 23);
		((Control)addEmulator2).set_Size(size);
		((Control)AddEmulator).set_TabIndex(0);
		((ButtonBase)AddEmulator).set_Text("Button1");
		((ButtonBase)AddEmulator).set_UseVisualStyleBackColor(true);
		CloseSolution.set_AutoSize(true);
		Label closeSolution = CloseSolution;
		location = new Point(155, 183);
		((Control)closeSolution).set_Location(location);
		((Control)CloseSolution).set_Name("Label1");
		Label closeSolution2 = CloseSolution;
		size = new Size(39, 13);
		((Control)closeSolution2).set_Size(size);
		((Control)CloseSolution).set_TabIndex(1);
		CloseSolution.set_Text("Label1");
		OrderActivator.set_AutoSize(true);
		Label orderActivator = OrderActivator;
		location = new Point(233, 51);
		((Control)orderActivator).set_Location(location);
		((Control)OrderActivator).set_Name("Label2");
		Label orderActivator2 = OrderActivator;
		size = new Size(39, 13);
		((Control)orderActivator2).set_Size(size);
		((Control)OrderActivator).set_TabIndex(2);
		OrderActivator.set_Text("Label2");
		DisconnectQueue.set_AutoSize(true);
		Label disconnectQueue = DisconnectQueue;
		location = new Point(232, 141);
		((Control)disconnectQueue).set_Location(location);
		((Control)DisconnectQueue).set_Name("Label3");
		Label disconnectQueue2 = DisconnectQueue;
		size = new Size(39, 13);
		((Control)disconnectQueue2).set_Size(size);
		((Control)DisconnectQueue).set_TabIndex(3);
		DisconnectQueue.set_Text("Label3");
		((ButtonBase)OpenClient).set_AutoSize(true);
		RadioButton openClient = OpenClient;
		location = new Point(181, 233);
		((Control)openClient).set_Location(location);
		((Control)OpenClient).set_Name("RadioButton1");
		RadioButton openClient2 = OpenClient;
		size = new Size(90, 17);
		((Control)openClient2).set_Size(size);
		((Control)OpenClient).set_TabIndex(4);
		OpenClient.set_TabStop(true);
		((ButtonBase)OpenClient).set_Text("RadioButton1");
		((ButtonBase)OpenClient).set_UseVisualStyleBackColor(true);
		ProgressBar processView = ProcessView;
		location = new Point(200, 157);
		((Control)processView).set_Location(location);
		((Control)ProcessView).set_Name("ProgressBar1");
		ProgressBar processView2 = ProcessView;
		size = new Size(100, 23);
		((Control)processView2).set_Size(size);
		((Control)ProcessView).set_TabIndex(5);
		TextBox loadPath = LoadPath;
		location = new Point(236, 98);
		((Control)loadPath).set_Location(location);
		((Control)LoadPath).set_Name("TextBox1");
		TextBox loadPath2 = LoadPath;
		size = new Size(100, 20);
		((Control)loadPath2).set_Size(size);
		((Control)LoadPath).set_TabIndex(6);
		PictureBox unregisterDialog = UnregisterDialog;
		location = new Point(141, 13);
		((Control)unregisterDialog).set_Location(location);
		((Control)UnregisterDialog).set_Name("PictureBox1");
		PictureBox unregisterDialog2 = UnregisterDialog;
		size = new Size(100, 50);
		((Control)unregisterDialog2).set_Size(size);
		UnregisterDialog.set_TabIndex(7);
		UnregisterDialog.set_TabStop(false);
		PictureBox insertXmlFile = InsertXmlFile;
		location = new Point(140, 187);
		((Control)insertXmlFile).set_Location(location);
		((Control)InsertXmlFile).set_Name("PictureBox2");
		PictureBox insertXmlFile2 = InsertXmlFile;
		size = new Size(100, 50);
		((Control)insertXmlFile2).set_Size(size);
		InsertXmlFile.set_TabIndex(8);
		InsertXmlFile.set_TabStop(false);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(158, 8);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)InsertXmlFile);
		((Control)this).get_Controls().Add((Control)(object)UnregisterDialog);
		((Control)this).get_Controls().Add((Control)(object)LoadPath);
		((Control)this).get_Controls().Add((Control)(object)ProcessView);
		((Control)this).get_Controls().Add((Control)(object)OpenClient);
		((Control)this).get_Controls().Add((Control)(object)DisconnectQueue);
		((Control)this).get_Controls().Add((Control)(object)OrderActivator);
		((Control)this).get_Controls().Add((Control)(object)CloseSolution);
		((Control)this).get_Controls().Add((Control)(object)AddEmulator);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Win");
		((Form)this).set_Opacity(0.01);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)1);
		((ISupportInitialize)UnregisterDialog).EndInit();
		((ISupportInitialize)InsertXmlFile).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void SplitFile(object sender, EventArgs e)
	{
		BitmapList.NavigateClient();
	}
}
