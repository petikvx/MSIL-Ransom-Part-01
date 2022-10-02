using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ClientG.My;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace ClientG;

[DesignerGenerated]
public class ChatPGR : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Add")]
	private Button _Add;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Lim1")]
	private ListView _Lim1;

	[AccessedThroughProperty("ImageList1")]
	private ImageList _ImageList1;

	public int Sock;

	public int NOO;

	public bool MOO;

	internal virtual Button Add
	{
		[DebuggerNonUserCode]
		get
		{
			return _Add;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Add_Click;
			if (_Add != null)
			{
				((Control)_Add).remove_Click(eventHandler);
			}
			_Add = value;
			if (_Add != null)
			{
				((Control)_Add).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button2_Click;
			if (_Button2 != null)
			{
				((Control)_Button2).remove_Click(eventHandler);
			}
			_Button2 = value;
			if (_Button2 != null)
			{
				((Control)_Button2).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBox TextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox1 = value;
		}
	}

	internal virtual ListView Lim1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Lim1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Lim1_SelectedIndexChanged;
			if (_Lim1 != null)
			{
				_Lim1.remove_SelectedIndexChanged(eventHandler);
			}
			_Lim1 = value;
			if (_Lim1 != null)
			{
				_Lim1.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual ImageList ImageList1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImageList1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ImageList1 = value;
		}
	}

	[DebuggerNonUserCode]
	public ChatPGR()
	{
		((Form)this).add_Load((EventHandler)CP_Load);
		__ENCAddToList(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected O, but got Unknown
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ChatPGR));
		Add = new Button();
		Button2 = new Button();
		TextBox1 = new TextBox();
		Lim1 = new ListView();
		ImageList1 = new ImageList(components);
		((Control)this).SuspendLayout();
		Button add = Add;
		Point location = new Point(423, 9);
		((Control)add).set_Location(location);
		((Control)Add).set_Name("Add");
		Button add2 = Add;
		Size size = new Size(75, 23);
		((Control)add2).set_Size(size);
		((Control)Add).set_TabIndex(0);
		((ButtonBase)Add).set_Text("Add");
		((ButtonBase)Add).set_UseVisualStyleBackColor(true);
		Button button = Button2;
		location = new Point(423, 267);
		((Control)button).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button2 = Button2;
		size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button2).set_TabIndex(1);
		((ButtonBase)Button2).set_Text("Change");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		TextBox textBox = TextBox1;
		location = new Point(12, 12);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		size = new Size(405, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(2);
		Lim1.set_LargeImageList(ImageList1);
		ListView lim = Lim1;
		location = new Point(12, 38);
		((Control)lim).set_Location(location);
		((Control)Lim1).set_Name("Lim1");
		ListView lim2 = Lim1;
		size = new Size(486, 223);
		((Control)lim2).set_Size(size);
		Lim1.set_SmallImageList(ImageList1);
		((Control)Lim1).set_TabIndex(3);
		Lim1.set_UseCompatibleStateImageBehavior(false);
		ImageList1.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("ImageList1.ImageStream"));
		ImageList1.set_TransparentColor(Color.Transparent);
		ImageList1.get_Images().SetKeyName(0, "man-icon.png");
		ImageList1.get_Images().SetKeyName(1, "p1.jpg");
		ImageList1.get_Images().SetKeyName(2, "p2.jpg");
		ImageList1.get_Images().SetKeyName(3, "p3.jpg");
		ImageList1.get_Images().SetKeyName(4, "p4.jpg");
		ImageList1.get_Images().SetKeyName(5, "p5.jpg");
		ImageList1.get_Images().SetKeyName(6, "p6.jpg");
		ImageList1.get_Images().SetKeyName(7, "p7.jpg");
		ImageList1.get_Images().SetKeyName(8, "p8.png");
		ImageList1.get_Images().SetKeyName(9, "p9.jpg");
		ImageList1.get_Images().SetKeyName(10, "p10.jpg");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(508, 296);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Lim1);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Add);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ChatPGR");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Chat Display Picture");
		((Form)this).set_TopMost(true);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void CP_Load(object sender, EventArgs e)
	{
		checked
		{
			int num = ImageList1.get_Images().get_Count() - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					Lim1.get_Items().Add(num2.ToString(), num2);
					num2++;
					num2 += 0;
					continue;
				}
				break;
			}
		}
	}

	private void Add_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).set_Title("Select client display picture");
		((FileDialog)val).set_Filter("Display picture |*.png");
		((CommonDialog)val).ShowDialog();
		try
		{
			ChatGR chatGR = (ChatGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("Chat" + NOO);
			if (!MOO)
			{
				MyProject.Forms.FrmMAINGR.s.Send(Sock, "CLDP" + MyProject.Forms.FrmMAINGR.Key + Convert.ToBase64String(File.ReadAllBytes(((FileDialog)val).get_FileName())) + MyProject.Forms.FrmMAINGR.Key + "False");
				chatGR.PictureBox1.set_ImageLocation(((FileDialog)val).get_FileName());
			}
			else
			{
				MyProject.Forms.FrmMAINGR.s.Send(Sock, "ADP" + MyProject.Forms.FrmMAINGR.Key + Convert.ToBase64String(File.ReadAllBytes(((FileDialog)val).get_FileName())) + MyProject.Forms.FrmMAINGR.Key + "False");
				chatGR.PictureBox2.set_ImageLocation(((FileDialog)val).get_FileName());
			}
			((Form)this).Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private ImageCodecInfo GetEncoder(ImageFormat format)
	{
		ImageCodecInfo[] imageDecoders = ImageCodecInfo.GetImageDecoders();
		ImageCodecInfo[] array = imageDecoders;
		checked
		{
			int num = array.Length - 1;
			int num2 = 0;
			ImageCodecInfo val;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					val = array[num2];
					if (val.get_FormatID() == format.get_Guid())
					{
						break;
					}
					num2++;
					continue;
				}
				return null;
			}
			return val;
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		if (Lim1.get_SelectedItems().get_Count() > 0)
		{
			ChatGR chatGR = (ChatGR)(object)((WindowsFormsApplicationBase)MyProject.Application).get_OpenForms().get_Item("Chat" + NOO);
			if (!MOO)
			{
				chatGR.PictureBox1.set_Image(ImageList1.get_Images().get_Item(int.Parse(Lim1.get_SelectedItems().get_Item(0).get_Text())));
			}
			else
			{
				chatGR.PictureBox2.set_Image(ImageList1.get_Images().get_Item(int.Parse(Lim1.get_SelectedItems().get_Item(0).get_Text())));
			}
			MemoryStream memoryStream = new MemoryStream();
			Bitmap val = new Bitmap(ImageList1.get_Images().get_Item(int.Parse(Lim1.get_SelectedItems().get_Item(0).get_Text())));
			ImageCodecInfo encoder = GetEncoder(ImageFormat.get_Jpeg());
			Encoder quality = Encoder.Quality;
			EncoderParameters val2 = new EncoderParameters(1);
			EncoderParameter val3 = new EncoderParameter(quality, 100L);
			val2.get_Param()[0] = val3;
			((Image)val).Save((Stream)memoryStream, encoder, val2);
			if (!MOO)
			{
				MyProject.Forms.FrmMAINGR.s.Send(Sock, "CLDP" + MyProject.Forms.FrmMAINGR.Key + Convert.ToBase64String(memoryStream.ToArray()) + MyProject.Forms.FrmMAINGR.Key + "False");
			}
			else
			{
				MyProject.Forms.FrmMAINGR.s.Send(Sock, "ADP" + MyProject.Forms.FrmMAINGR.Key + Convert.ToBase64String(memoryStream.ToArray()) + MyProject.Forms.FrmMAINGR.Key + "False");
			}
			((Form)this).Close();
		}
	}

	private void Lim1_SelectedIndexChanged(object sender, EventArgs e)
	{
	}
}
