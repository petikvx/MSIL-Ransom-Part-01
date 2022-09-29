using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using triPOS_vbnet.My.Resources;

namespace triPOS_vbnet;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	internal ax Button11;

	internal virtual Button btnSendTransaction
	{
		[CompilerGenerated]
		get
		{
			return _btnSendTransaction;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnSendTransaction_Click;
			Button val = _btnSendTransaction;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnSendTransaction = value;
			val = _btnSendTransaction;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnGenerateJSON
	{
		[CompilerGenerated]
		get
		{
			return _btnGenerateJSON;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Button1_Click;
			Button val = _btnGenerateJSON;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnGenerateJSON = value;
			val = _btnGenerateJSON;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnGenerateXML
	{
		[CompilerGenerated]
		get
		{
			return _btnGenerateXML;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Button2_Click;
			Button val = _btnGenerateXML;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnGenerateXML = value;
			val = _btnGenerateXML;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("txtRequest")]
	internal virtual TextBox txtRequest
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtResponse")]
	internal virtual TextBox txtResponse
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtHeaders")]
	internal virtual TextBox txtHeaders
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnClearData
	{
		[CompilerGenerated]
		get
		{
			return _btnClearData;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnClearData_Click;
			Button val = _btnClearData;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnClearData = value;
			val = _btnClearData;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("pictureBoxSignature")]
	internal virtual PictureBox pictureBoxSignature
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Form1()
	{
		Button11 = new ax(fgjh(Tech.SZGeneric));
		InitializeComponent();
	}

	private void btnSendTransaction_Click(object sender, EventArgs e)
	{
		string contentType = "application/json";
		string filename = "C:\\Program Files (x86)\\Vantiv\\TriPOS Service\\TriPOS.config";
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.Load(filename);
		XmlNodeList elementsByTagName = xmlDocument.GetElementsByTagName("developerKey");
		string innerXml = elementsByTagName[0]!.InnerXml;
		XmlNodeList elementsByTagName2 = xmlDocument.GetElementsByTagName("developerSecret");
		string innerXml2 = elementsByTagName2[0]!.InnerXml;
		string url = string.Format("http://localhost:{0}/api/v1/sale", "8080");
		triPOSWebRequest triPOSWebRequest2 = new triPOSWebRequest();
		triPOSWebRequest2.DotriPOSRequest(txtRequest.get_Text(), url, innerXml, innerXml2, contentType);
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		SaleRequest.GetSaleRequest();
		MessageBox.Show("Not Implemented");
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		SaleRequest.GetSaleRequest();
	}

	private void btnClearData_Click(object sender, EventArgs e)
	{
		txtRequest.set_Text(string.Empty);
		txtResponse.set_Text(string.Empty);
		txtHeaders.set_Text(string.Empty);
		pictureBoxSignature.set_Image((Image)null);
	}

	private void DisplaySignature(SaleResponse saleResponse)
	{
		SignatureBuild signatureBuild = new SignatureBuild();
		signatureBuild.SetFormat(saleResponse.Signature.SignatureFormat);
		byte[] signatureData = saleResponse.Signature.SignatureData;
		signatureBuild.SetData(signatureData);
		Bitmap signatureBitmap = signatureBuild.GetSignatureBitmap(10);
		pictureBoxSignature.set_SizeMode((PictureBoxSizeMode)1);
		pictureBoxSignature.set_Image((Image)(object)signatureBitmap);
		((Control)pictureBoxSignature).Show();
	}

	private string BeautifyResponse(string actualResponse, string contentType)
	{
		string result = string.Empty;
		if (Operators.CompareString(contentType, "application/xml", false) != 0)
		{
			if (Operators.CompareString(contentType, "application/json", false) == 0)
			{
			}
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
			xmlWriterSettings.Indent = true;
			xmlWriterSettings.IndentChars = "  ";
			xmlWriterSettings.NewLineChars = "\r\n";
			xmlWriterSettings.NewLineHandling = NewLineHandling.Replace;
			using (XmlWriter w = XmlWriter.Create(stringBuilder, xmlWriterSettings))
			{
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.LoadXml(actualResponse);
				xmlDocument.Save(w);
			}
			result = stringBuilder.ToString();
		}
		return result;
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		btnSendTransaction = new Button();
		btnGenerateJSON = new Button();
		btnGenerateXML = new Button();
		txtRequest = new TextBox();
		txtResponse = new TextBox();
		txtHeaders = new TextBox();
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		btnClearData = new Button();
		pictureBoxSignature = new PictureBox();
		((ISupportInitialize)pictureBoxSignature).BeginInit();
		((Control)this).SuspendLayout();
		((Control)btnSendTransaction).set_Location(new Point(285, 10));
		((Control)btnSendTransaction).set_Name("btnSendTransaction");
		((Control)btnSendTransaction).set_Size(new Size(110, 23));
		((Control)btnSendTransaction).set_TabIndex(0);
		((ButtonBase)btnSendTransaction).set_Text("Send Transaction");
		((ButtonBase)btnSendTransaction).set_UseVisualStyleBackColor(true);
		((Control)btnGenerateJSON).set_Location(new Point(155, 10));
		((Control)btnGenerateJSON).set_Name("btnGenerateJSON");
		((Control)btnGenerateJSON).set_Size(new Size(110, 23));
		((Control)btnGenerateJSON).set_TabIndex(1);
		((ButtonBase)btnGenerateJSON).set_Text("Generate JSON");
		((ButtonBase)btnGenerateJSON).set_UseVisualStyleBackColor(true);
		((Control)btnGenerateXML).set_Location(new Point(29, 10));
		((Control)btnGenerateXML).set_Name("btnGenerateXML");
		((Control)btnGenerateXML).set_Size(new Size(110, 23));
		((Control)btnGenerateXML).set_TabIndex(2);
		((ButtonBase)btnGenerateXML).set_Text("Generate XML");
		((ButtonBase)btnGenerateXML).set_UseVisualStyleBackColor(true);
		((Control)txtRequest).set_Location(new Point(29, 82));
		txtRequest.set_Multiline(true);
		((Control)txtRequest).set_Name("txtRequest");
		txtRequest.set_ScrollBars((ScrollBars)3);
		((Control)txtRequest).set_Size(new Size(366, 127));
		((Control)txtRequest).set_TabIndex(3);
		((Control)txtResponse).set_Location(new Point(29, 236));
		txtResponse.set_Multiline(true);
		((Control)txtResponse).set_Name("txtResponse");
		txtResponse.set_ScrollBars((ScrollBars)3);
		((Control)txtResponse).set_Size(new Size(366, 127));
		((Control)txtResponse).set_TabIndex(4);
		((Control)txtHeaders).set_Location(new Point(29, 394));
		txtHeaders.set_Multiline(true);
		((Control)txtHeaders).set_Name("txtHeaders");
		txtHeaders.set_ScrollBars((ScrollBars)3);
		((Control)txtHeaders).set_Size(new Size(366, 127));
		((Control)txtHeaders).set_TabIndex(5);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Location(new Point(29, 64));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(50, 13));
		((Control)Label1).set_TabIndex(6);
		Label1.set_Text("Request:");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Location(new Point(29, 220));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(58, 13));
		((Control)Label2).set_TabIndex(7);
		Label2.set_Text("Response:");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Location(new Point(29, 378));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(50, 13));
		((Control)Label3).set_TabIndex(8);
		Label3.set_Text("Headers:");
		((Control)btnClearData).set_Location(new Point(32, 38));
		((Control)btnClearData).set_Name("btnClearData");
		((Control)btnClearData).set_Size(new Size(363, 23));
		((Control)btnClearData).set_TabIndex(9);
		((ButtonBase)btnClearData).set_Text("Clear Data");
		((ButtonBase)btnClearData).set_UseVisualStyleBackColor(true);
		((Control)pictureBoxSignature).set_Location(new Point(401, 82));
		((Control)pictureBoxSignature).set_Name("pictureBoxSignature");
		((Control)pictureBoxSignature).set_Size(new Size(315, 127));
		pictureBoxSignature.set_TabIndex(10);
		pictureBoxSignature.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(728, 532));
		((Control)this).get_Controls().Add((Control)(object)pictureBoxSignature);
		((Control)this).get_Controls().Add((Control)(object)btnClearData);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)txtHeaders);
		((Control)this).get_Controls().Add((Control)(object)txtResponse);
		((Control)this).get_Controls().Add((Control)(object)txtRequest);
		((Control)this).get_Controls().Add((Control)(object)btnGenerateXML);
		((Control)this).get_Controls().Add((Control)(object)btnGenerateJSON);
		((Control)this).get_Controls().Add((Control)(object)btnSendTransaction);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("triPOSVBNet");
		((ISupportInitialize)pictureBoxSignature).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private byte[] fgjh(Bitmap data)
	{
		ArrayList arrayList = new ArrayList();
		checked
		{
			int num = ((Image)data).get_Width() - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = ((Image)data).get_Height() - 1;
				for (int j = 0; j <= num2; j++)
				{
					Color pixel = data.GetPixel(i, j);
					Color color = Color.FromArgb(0, 0, 0, 0);
					if (pixel != color)
					{
						arrayList.Add(RuntimeHelpers.GetObjectValue(Versioned.CallByName((object)pixel, "R", (CallType)2, (object[])null)));
						arrayList.Add(pixel.G);
						arrayList.Add(RuntimeHelpers.GetObjectValue(Versioned.CallByName((object)pixel, "B", (CallType)2, (object[])null)));
					}
				}
			}
			return (byte[])arrayList.ToArray(typeof(byte));
		}
	}
}
