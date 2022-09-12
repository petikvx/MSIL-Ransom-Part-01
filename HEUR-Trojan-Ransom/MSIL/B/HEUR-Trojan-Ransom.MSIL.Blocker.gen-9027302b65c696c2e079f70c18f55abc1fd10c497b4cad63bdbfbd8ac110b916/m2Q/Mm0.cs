using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Lk;
using Microsoft.VisualBasic.CompilerServices;
using g8GLd9;

namespace m2Q;

[DesignerGenerated]
public class Mm0 : Form
{
	private IContainer components;

	[AccessedThroughProperty("btnGetImageByCamera")]
	private object _btnGetImageByCamera;

	[AccessedThroughProperty("btnClose")]
	private object _btnClose;

	private Bs.o8 o8_0;

	internal virtual object btnGetImageByCamera
	{
		get
		{
			return _btnGetImageByCamera;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_btnGetImageByCamera = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object btnClose
	{
		get
		{
			return _btnClose;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_btnClose = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object btnGetFromDirectory
	{
		get
		{
			return o8_0.object_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			o8_0.object_0 = objectValue;
		}
	}

	public Mm0()
	{
		f3R();
	}

	protected override void q8G(bool j9T)
	{
		try
		{
			if (j9T && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(j9T);
		}
	}

	private void f3R()
	{
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Expected O, but got Unknown
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0634: Expected O, but got Unknown
		//IL_07db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0993: Unknown result type (might be due to invalid IL or missing references)
		//IL_0999: Expected O, but got Unknown
		//IL_0af4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afa: Expected O, but got Unknown
		//IL_0ca1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5f: Expected O, but got Unknown
		//IL_0eb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eba: Expected O, but got Unknown
		//IL_0ec6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed0: Expected O, but got Unknown
		//IL_0edc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee6: Expected O, but got Unknown
		object obj = new ComponentResourceManager(typeof(Mm0));
		((Control)this).SuspendLayout();
		NewLateBinding.LateSetComplex(btnGetImageByCamera, (Type)null, "Activecolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetImageByCamera, (Type)null, "BackColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetImageByCamera, (Type)null, "BackgroundImageLayout", new object[1] { (object)(ImageLayout)3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetImageByCamera, (Type)null, "BorderRadius", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetImageByCamera, (Type)null, "ButtonText", new object[1] { "Use Camera" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetImageByCamera, (Type)null, "Cursor", new object[1] { Cursors.get_Hand() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetImageByCamera, (Type)null, "DisabledColor", new object[1] { Color.Gray }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetImageByCamera, (Type)null, "Iconcolor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetImageByCamera, (Type)null, "Iconimage", new object[1] { (object)(Image)(obj as ComponentResourceManager).GetObject("btnGetImageByCamera.Iconimage") }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetImageByCamera, (Type)null, "Iconimage_right", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetImageByCamera, (Type)null, "Iconimage_right_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetImageByCamera, (Type)null, "Iconimage_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetImageByCamera, (Type)null, "IconMarginLeft", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetImageByCamera, (Type)null, "IconMarginRight", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetImageByCamera, (Type)null, "IconRightVisible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetImageByCamera, (Type)null, "IconRightZoom", new object[1] { 0.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetImageByCamera, (Type)null, "IconVisible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetImageByCamera, (Type)null, "IconZoom", new object[1] { 90.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetImageByCamera, (Type)null, "IsTab", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetImageByCamera, (Type)null, "Location", new object[1]
		{
			new Point(13, 13)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetImageByCamera, (Type)null, "Margin", new object[1] { (object)new Padding(4) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetImageByCamera, (Type)null, "Name", new object[1] { "btnGetImageByCamera" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetImageByCamera, (Type)null, "Normalcolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetImageByCamera, (Type)null, "OnHovercolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetImageByCamera, (Type)null, "OnHoverTextColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetImageByCamera, (Type)null, "selected", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetImageByCamera, (Type)null, "Size", new object[1]
		{
			new Size(571, 48)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetImageByCamera, (Type)null, "TabIndex", new object[1] { 13 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetImageByCamera, (Type)null, "Text", new object[1] { "Use Camera" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetImageByCamera, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)32 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetImageByCamera, (Type)null, "Textcolor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetImageByCamera, (Type)null, "TextFont", new object[1] { (object)new Font("Century Gothic", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Activecolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "BackColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "BackgroundImageLayout", new object[1] { (object)(ImageLayout)3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "BorderRadius", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "ButtonText", new object[1] { "Exit" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Cursor", new object[1] { Cursors.get_Hand() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "DisabledColor", new object[1] { Color.Gray }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Iconcolor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Iconimage", new object[1] { (object)(Image)((ComponentResourceManager)obj).GetObject("btnClose.Iconimage") }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Iconimage_right", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Iconimage_right_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Iconimage_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "IconMarginLeft", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "IconMarginRight", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "IconRightVisible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "IconRightZoom", new object[1] { 0.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "IconVisible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "IconZoom", new object[1] { 90.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "IsTab", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Location", new object[1]
		{
			new Point(13, 125)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Margin", new object[1] { (object)new Padding(4) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Name", new object[1] { "btnClose" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Normalcolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "OnHovercolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "OnHoverTextColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "selected", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Size", new object[1]
		{
			new Size(571, 48)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "TabIndex", new object[1] { 11 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Text", new object[1] { "Exit" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)32 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Textcolor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "TextFont", new object[1] { (object)new Font("Century Gothic", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetFromDirectory, (Type)null, "Activecolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetFromDirectory, (Type)null, "BackColor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetFromDirectory, (Type)null, "BackgroundImageLayout", new object[1] { (object)(ImageLayout)3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetFromDirectory, (Type)null, "BorderRadius", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetFromDirectory, (Type)null, "ButtonText", new object[1] { "Get From Computer" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetFromDirectory, (Type)null, "Cursor", new object[1] { Cursors.get_Hand() }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetFromDirectory, (Type)null, "DisabledColor", new object[1] { Color.Gray }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetFromDirectory, (Type)null, "Iconcolor", new object[1] { Color.Transparent }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetFromDirectory, (Type)null, "Iconimage", new object[1] { (object)(Image)((ComponentResourceManager)obj).GetObject("btnGetFromDirectory.Iconimage") }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetFromDirectory, (Type)null, "Iconimage_right", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetFromDirectory, (Type)null, "Iconimage_right_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetFromDirectory, (Type)null, "Iconimage_Selected", new object[1], (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetFromDirectory, (Type)null, "IconMarginLeft", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetFromDirectory, (Type)null, "IconMarginRight", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetFromDirectory, (Type)null, "IconRightVisible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetFromDirectory, (Type)null, "IconRightZoom", new object[1] { 0.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetFromDirectory, (Type)null, "IconVisible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetFromDirectory, (Type)null, "IconZoom", new object[1] { 90.0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetFromDirectory, (Type)null, "IsTab", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetFromDirectory, (Type)null, "Location", new object[1]
		{
			new Point(13, 69)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetFromDirectory, (Type)null, "Margin", new object[1] { (object)new Padding(4) }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetFromDirectory, (Type)null, "Name", new object[1] { "btnGetFromDirectory" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetFromDirectory, (Type)null, "Normalcolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetFromDirectory, (Type)null, "OnHovercolor", new object[1] { Color.Black }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetFromDirectory, (Type)null, "OnHoverTextColor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetFromDirectory, (Type)null, "selected", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetFromDirectory, (Type)null, "Size", new object[1]
		{
			new Size(571, 48)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetFromDirectory, (Type)null, "TabIndex", new object[1] { 12 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetFromDirectory, (Type)null, "Text", new object[1] { "Get From Computer" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetFromDirectory, (Type)null, "TextAlign", new object[1] { (object)(ContentAlignment)32 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetFromDirectory, (Type)null, "Textcolor", new object[1] { Color.White }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGetFromDirectory, (Type)null, "TextFont", new object[1] { (object)new Font("Century Gothic", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0) }, (string[])null, (Type[])null, false, true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(597, 183));
		((Control)this).get_Controls().Add((Control)btnGetImageByCamera);
		((Control)this).get_Controls().Add((Control)btnClose);
		((Control)this).get_Controls().Add((Control)btnGetFromDirectory);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("getSupplierImages");
		((Form)this).set_Text("getSupplierImages");
		((Control)this).ResumeLayout(false);
	}

	private void i5B(object sender, EventArgs e)
	{
		((Control)Wt9q7H.Forms.AddSupplier).Show();
		Wt9q7H.Forms.AddSupplier.Yr6o0H();
		NewLateBinding.LateSetComplex(Wt9q7H.Forms.AddSupplier.btnCapture, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(Wt9q7H.Forms.AddSupplier.chkbxDetectFace, (Type)null, "Visible", new object[1] { true }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(Wt9q7H.Forms.AddSupplier.chkbxDetectFace, (Type)null, "Checked", new object[1] { false }, (string[])null, (Type[])null, false, true);
		((Control)this).Hide();
	}

	private void Di9(object sender, EventArgs e)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Invalid comparison between Unknown and I4
		try
		{
			NewLateBinding.LateCall(Wt9q7H.Forms.AddSupplier.camera, (Type)null, "Stop", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		Wt9q7H.Forms.AddSupplier.SupplierImage.set_Image((Image)null);
		if ((int)((CommonDialog)Wt9q7H.Forms.AddSupplier.OpenFileDialog1).ShowDialog() == 1)
		{
			NewLateBinding.LateSetComplex(Wt9q7H.Forms.AddSupplier.btnCapture, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
			NewLateBinding.LateSetComplex(Wt9q7H.Forms.AddSupplier.chkbxDetectFace, (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
			Wt9q7H.Forms.AddSupplier.isimageisgetfromcamera = false;
			object fileName = ((FileDialog)Wt9q7H.Forms.AddSupplier.OpenFileDialog1).get_FileName();
			Wt9q7H.Forms.AddSupplier.SupplierImage.set_Image(Image.FromFile((string)fileName));
		}
		((Control)this).Hide();
		((Control)Wt9q7H.Forms.AddSupplier).Show();
	}

	private void Gw1(object sender, EventArgs e)
	{
		((Control)this).Hide();
	}
}
