using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace Intel.ATMAuto.ATMIA;

public class RetryErrorForm : Form
{
	private GroupBox ExceptionGroup;

	private ListBox ExceptionList;

	private Button ExceptAdd;

	private Button ExceptDelete;

	private GroupBox ErrorGroup;

	private ListBox ErrorList;

	private Label ErrIntervalLbl;

	private Label ErrCodeLbl;

	private Label ErrMsgLbl;

	private Button ErrAdd;

	private Button ErrDelete;

	private TextBox ErrIntervalTxt;

	private TextBox ErrCodeTxt;

	private TextBox ErrMsgTxt;

	private TextBox ExceptionTxt;

	private Label ExceptionLbl;

	private Button ErrEdit;

	private Button ExceptEdit;

	private Label ErrorRetryNum;

	private TextBox ErrorRetryTxt;

	private Button OK;

	private Button Cancel;

	private Container components = null;

	private XmlNode exceptionNode;

	private XmlNode errorNode;

	private XmlNode retryNode;

	private bool HasChange = false;

	public XmlNode ExceptionNode
	{
		get
		{
			return exceptionNode;
		}
		set
		{
			exceptionNode = value;
		}
	}

	public XmlNode ErrorNode
	{
		get
		{
			return errorNode;
		}
		set
		{
			errorNode = value;
		}
	}

	public XmlNode RetryNode
	{
		get
		{
			return retryNode;
		}
		set
		{
			retryNode = value;
		}
	}

	public RetryErrorForm(XmlNode InExceptionNode, XmlNode InErrorNode, XmlNode InRetryNode)
	{
		InitializeComponent();
		ExceptionNode = InExceptionNode.Clone();
		ErrorNode = InErrorNode.Clone();
		RetryNode = InRetryNode.Clone();
		((Control)ErrorRetryTxt).set_Text(RetryNode.InnerText);
		UpdateExceptionList();
		UpdateErrorList();
		HasChange = false;
	}

	private void UpdateExceptionList()
	{
		ExceptionList.get_Items().Clear();
		if (ExceptionNode.ChildNodes.Count > 0)
		{
			((Control)ExceptionTxt).set_Text(ExceptionNode.ChildNodes[0]!.InnerText);
			for (int i = 0; i < ExceptionNode.ChildNodes.Count; i++)
			{
				if (ExceptionNode.ChildNodes[i]!.NodeType != XmlNodeType.Comment)
				{
					ExceptionList.get_Items().Add((object)("Exception" + i));
				}
			}
		}
		if (ExceptionList.get_Items().get_Count() > 0)
		{
			ExceptionList.SetSelected(0, true);
		}
		else
		{
			((Control)ExceptionTxt).set_Text("");
		}
	}

	private void UpdateErrorList()
	{
		ErrorList.get_Items().Clear();
		XmlNodeList xmlNodeList = ErrorNode.SelectNodes("ErrorType");
		for (int i = 0; i < xmlNodeList.Count; i++)
		{
			if (xmlNodeList.Item(i)!.NodeType != XmlNodeType.Comment)
			{
				ErrorList.get_Items().Add((object)("Error" + i));
			}
		}
		if (ErrorList.get_Items().get_Count() > 0)
		{
			ErrorList.SetSelected(0, true);
			return;
		}
		((Control)ErrMsgTxt).set_Text("");
		((Control)ErrCodeTxt).set_Text("");
		((Control)ErrIntervalTxt).set_Text("");
	}

	private void UpdateError(XmlNode node)
	{
		XmlNode xmlNode = node.SelectSingleNode("ErrorRetryInterval");
		if (xmlNode != null)
		{
			((Control)ErrIntervalTxt).set_Text(xmlNode.InnerText);
		}
		xmlNode = node.SelectSingleNode("Error")!.SelectSingleNode("ErrorCode");
		if (xmlNode != null)
		{
			((Control)ErrCodeTxt).set_Text(xmlNode.InnerText);
		}
		else
		{
			((Control)ErrCodeTxt).set_Text("");
		}
		xmlNode = node.SelectSingleNode("Error")!.SelectSingleNode("Reason");
		if (xmlNode != null)
		{
			((Control)ErrMsgTxt).set_Text(xmlNode.InnerText);
		}
		else
		{
			((Control)ErrMsgTxt).set_Text("");
		}
	}

	private void ErrorRetryTxt_TextChanged(object sender, EventArgs e)
	{
		RetryNode.InnerText = ((Control)ErrorRetryTxt).get_Text();
		HasChange = true;
	}

	private void ExceptionList_SelectedIndexChanged(object sender, EventArgs e)
	{
		((Control)ExceptionTxt).set_Text(ExceptionNode.ChildNodes[((ListControl)ExceptionList).get_SelectedIndex()]!.InnerText);
	}

	private void ExceptAdd_Click(object sender, EventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if ("" == ((Control)ExceptionTxt).get_Text())
		{
			MessageBox.Show("Please fill out the Exception tag to add", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			return;
		}
		XmlElement xmlElement = ExceptionNode.OwnerDocument!.CreateElement("Exception");
		xmlElement.InnerText = ((Control)ExceptionTxt).get_Text();
		ExceptionNode.AppendChild(xmlElement);
		ExceptionList.get_Items().Add((object)("Exception" + ExceptionList.get_Items().get_Count()));
		ExceptionList.SetSelected(ExceptionList.get_Items().get_Count() - 1, true);
		HasChange = true;
	}

	private void ExceptDelete_Click(object sender, EventArgs e)
	{
		if (ExceptionList.get_Items().get_Count() > 0)
		{
			ExceptionNode.RemoveChild(ExceptionNode.ChildNodes[((ListControl)ExceptionList).get_SelectedIndex()]);
			UpdateExceptionList();
			HasChange = true;
		}
		else
		{
			((Control)ExceptionTxt).set_Text("");
		}
	}

	private void ExceptEdit_Click(object sender, EventArgs e)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		if (ExceptionList.get_Items().get_Count() > 0)
		{
			if ("" == ((Control)ExceptionTxt).get_Text())
			{
				MessageBox.Show("Please fill out the Exception tag to edit", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
				return;
			}
			ExceptionNode.ChildNodes[((ListControl)ExceptionList).get_SelectedIndex()]!.InnerText = ((Control)ExceptionTxt).get_Text();
			HasChange = true;
		}
		else
		{
			((Control)ExceptionTxt).set_Text("");
		}
	}

	private void ErrorList_SelectedIndexChanged(object sender, EventArgs e)
	{
		XmlNode node = ErrorNode.SelectNodes("ErrorType")!.Item(((ListControl)ErrorList).get_SelectedIndex());
		UpdateError(node);
	}

	private void ErrAdd_Click(object sender, EventArgs e)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ("" == ((Control)ErrCodeTxt).get_Text() && "" == ((Control)ErrMsgTxt).get_Text())
		{
			MessageBox.Show("Please fill out either ErrorCode or ErrorReason to add", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			return;
		}
		XmlElement xmlElement = ErrorNode.OwnerDocument!.CreateElement("ErrorType");
		XmlElement xmlElement2 = ErrorNode.OwnerDocument!.CreateElement("ErrorRetryInterval");
		xmlElement2.InnerText = ((Control)ErrIntervalTxt).get_Text();
		xmlElement.AppendChild(xmlElement2);
		XmlElement xmlElement3 = ErrorNode.OwnerDocument!.CreateElement("Error");
		if ("" != ((Control)ErrCodeTxt).get_Text())
		{
			XmlElement xmlElement4 = ErrorNode.OwnerDocument!.CreateElement("ErrorCode");
			xmlElement4.InnerText = ((Control)ErrCodeTxt).get_Text();
			xmlElement3.AppendChild(xmlElement4);
		}
		if ("" != ((Control)ErrMsgTxt).get_Text())
		{
			XmlElement xmlElement5 = ErrorNode.OwnerDocument!.CreateElement("Reason");
			xmlElement5.InnerText = ((Control)ErrMsgTxt).get_Text();
			xmlElement3.AppendChild(xmlElement5);
		}
		xmlElement.AppendChild(xmlElement3);
		ErrorNode.AppendChild(xmlElement);
		ErrorList.get_Items().Add((object)("Error" + ErrorList.get_Items().get_Count()));
		ErrorList.SetSelected(ErrorList.get_Items().get_Count() - 1, true);
		HasChange = true;
	}

	private void ErrDelete_Click(object sender, EventArgs e)
	{
		if (ErrorList.get_Items().get_Count() > 0)
		{
			XmlNode oldChild = ErrorNode.SelectNodes("ErrorType")!.Item(((ListControl)ErrorList).get_SelectedIndex());
			ErrorNode.RemoveChild(oldChild);
			UpdateErrorList();
			HasChange = true;
		}
		else
		{
			((Control)ErrMsgTxt).set_Text("");
			((Control)ErrCodeTxt).set_Text("");
			((Control)ErrIntervalTxt).set_Text("");
		}
	}

	private void ErrEdit_Click(object sender, EventArgs e)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		if (ErrorList.get_Items().get_Count() > 0)
		{
			if ("" == ((Control)ErrCodeTxt).get_Text() && "" == ((Control)ErrMsgTxt).get_Text())
			{
				MessageBox.Show("Please fill out either ErrorCode or ErrorReason to add", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
				return;
			}
			XmlNode xmlNode = ErrorNode.SelectNodes("ErrorType")!.Item(((ListControl)ErrorList).get_SelectedIndex());
			xmlNode.SelectSingleNode("ErrorRetryInterval")!.InnerText = ((Control)ErrIntervalTxt).get_Text();
			XmlNode xmlNode2 = xmlNode.SelectSingleNode("Error")!.SelectSingleNode("ErrorCode");
			if ("" != ((Control)ErrCodeTxt).get_Text())
			{
				if (xmlNode2 != null)
				{
					xmlNode2.InnerText = ((Control)ErrCodeTxt).get_Text();
				}
				else
				{
					XmlElement xmlElement = ErrorNode.OwnerDocument!.CreateElement("ErrorCode");
					xmlElement.InnerText = ((Control)ErrCodeTxt).get_Text();
					xmlNode.SelectSingleNode("Error")!.AppendChild(xmlElement);
				}
			}
			else if (xmlNode2 != null)
			{
				xmlNode.SelectSingleNode("Error")!.RemoveChild(xmlNode2);
			}
			xmlNode2 = xmlNode.SelectSingleNode("Error")!.SelectSingleNode("Reason");
			if ("" != ((Control)ErrMsgTxt).get_Text())
			{
				if (xmlNode2 != null)
				{
					xmlNode2.InnerText = ((Control)ErrMsgTxt).get_Text();
				}
				else
				{
					XmlElement xmlElement2 = ErrorNode.OwnerDocument!.CreateElement("Reason");
					xmlElement2.InnerText = ((Control)ErrMsgTxt).get_Text();
					xmlNode.SelectSingleNode("Error")!.AppendChild(xmlElement2);
				}
			}
			else if (xmlNode2 != null)
			{
				xmlNode.SelectSingleNode("Error")!.RemoveChild(xmlNode2);
			}
			HasChange = true;
		}
		else
		{
			((Control)ErrMsgTxt).set_Text("");
			((Control)ErrCodeTxt).set_Text("");
			((Control)ErrIntervalTxt).set_Text("");
		}
	}

	private void Cancel_Click(object sender, EventArgs e)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Invalid comparison between I4 and Unknown
		if (HasChange)
		{
			if (6 == (int)MessageBox.Show("The form has been modifed, are you sure to exit?", "Warning", (MessageBoxButtons)4, (MessageBoxIcon)48))
			{
				((Form)this).Close();
			}
		}
		else
		{
			((Form)this).Close();
		}
	}

	private void Exit_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
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
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		ExceptionGroup = new GroupBox();
		ExceptEdit = new Button();
		ExceptionTxt = new TextBox();
		ExceptionLbl = new Label();
		ExceptDelete = new Button();
		ExceptAdd = new Button();
		ExceptionList = new ListBox();
		ErrorGroup = new GroupBox();
		ErrEdit = new Button();
		ErrMsgTxt = new TextBox();
		ErrCodeTxt = new TextBox();
		ErrIntervalTxt = new TextBox();
		ErrDelete = new Button();
		ErrAdd = new Button();
		ErrMsgLbl = new Label();
		ErrCodeLbl = new Label();
		ErrIntervalLbl = new Label();
		ErrorList = new ListBox();
		OK = new Button();
		Cancel = new Button();
		ErrorRetryNum = new Label();
		ErrorRetryTxt = new TextBox();
		((Control)ExceptionGroup).SuspendLayout();
		((Control)ErrorGroup).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)ExceptionGroup).get_Controls().Add((Control)(object)ExceptEdit);
		((Control)ExceptionGroup).get_Controls().Add((Control)(object)ExceptionTxt);
		((Control)ExceptionGroup).get_Controls().Add((Control)(object)ExceptionLbl);
		((Control)ExceptionGroup).get_Controls().Add((Control)(object)ExceptDelete);
		((Control)ExceptionGroup).get_Controls().Add((Control)(object)ExceptAdd);
		((Control)ExceptionGroup).get_Controls().Add((Control)(object)ExceptionList);
		((Control)ExceptionGroup).set_Location(new Point(16, 16));
		((Control)ExceptionGroup).set_Name("ExceptionGroup");
		((Control)ExceptionGroup).set_Size(new Size(440, 144));
		((Control)ExceptionGroup).set_TabIndex(0);
		ExceptionGroup.set_TabStop(false);
		((Control)ExceptionGroup).set_Text("Exception Configuration");
		((Control)ExceptEdit).set_Location(new Point(360, 104));
		((Control)ExceptEdit).set_Name("ExceptEdit");
		((Control)ExceptEdit).set_Size(new Size(72, 24));
		((Control)ExceptEdit).set_TabIndex(11);
		((Control)ExceptEdit).set_Text("Edit");
		((Control)ExceptEdit).add_Click((EventHandler)ExceptEdit_Click);
		((Control)ExceptionTxt).set_Location(new Point(232, 48));
		((Control)ExceptionTxt).set_Name("ExceptionTxt");
		((Control)ExceptionTxt).set_Size(new Size(192, 20));
		((Control)ExceptionTxt).set_TabIndex(10);
		((Control)ExceptionTxt).set_Text("");
		((Control)ExceptionLbl).set_Location(new Point(152, 48));
		((Control)ExceptionLbl).set_Name("ExceptionLbl");
		((Control)ExceptionLbl).set_Size(new Size(64, 24));
		((Control)ExceptionLbl).set_TabIndex(9);
		((Control)ExceptionLbl).set_Text("Exception:");
		((Control)ExceptDelete).set_Location(new Point(260, 104));
		((Control)ExceptDelete).set_Name("ExceptDelete");
		((Control)ExceptDelete).set_Size(new Size(72, 24));
		((Control)ExceptDelete).set_TabIndex(2);
		((Control)ExceptDelete).set_Text("Delete");
		((Control)ExceptDelete).add_Click((EventHandler)ExceptDelete_Click);
		((Control)ExceptAdd).set_Location(new Point(160, 104));
		((Control)ExceptAdd).set_Name("ExceptAdd");
		((Control)ExceptAdd).set_Size(new Size(72, 24));
		((Control)ExceptAdd).set_TabIndex(1);
		((Control)ExceptAdd).set_Text("Add");
		((Control)ExceptAdd).add_Click((EventHandler)ExceptAdd_Click);
		((Control)ExceptionList).set_Location(new Point(16, 24));
		((Control)ExceptionList).set_Name("ExceptionList");
		((Control)ExceptionList).set_Size(new Size(120, 95));
		((Control)ExceptionList).set_TabIndex(0);
		ExceptionList.add_SelectedIndexChanged((EventHandler)ExceptionList_SelectedIndexChanged);
		((Control)ErrorGroup).get_Controls().Add((Control)(object)ErrEdit);
		((Control)ErrorGroup).get_Controls().Add((Control)(object)ErrMsgTxt);
		((Control)ErrorGroup).get_Controls().Add((Control)(object)ErrCodeTxt);
		((Control)ErrorGroup).get_Controls().Add((Control)(object)ErrIntervalTxt);
		((Control)ErrorGroup).get_Controls().Add((Control)(object)ErrDelete);
		((Control)ErrorGroup).get_Controls().Add((Control)(object)ErrAdd);
		((Control)ErrorGroup).get_Controls().Add((Control)(object)ErrMsgLbl);
		((Control)ErrorGroup).get_Controls().Add((Control)(object)ErrCodeLbl);
		((Control)ErrorGroup).get_Controls().Add((Control)(object)ErrIntervalLbl);
		((Control)ErrorGroup).get_Controls().Add((Control)(object)ErrorList);
		((Control)ErrorGroup).set_Location(new Point(16, 216));
		((Control)ErrorGroup).set_Name("ErrorGroup");
		((Control)ErrorGroup).set_Size(new Size(440, 192));
		((Control)ErrorGroup).set_TabIndex(1);
		ErrorGroup.set_TabStop(false);
		((Control)ErrorGroup).set_Text("Error Configuration");
		((Control)ErrEdit).set_Location(new Point(360, 144));
		((Control)ErrEdit).set_Name("ErrEdit");
		((Control)ErrEdit).set_Size(new Size(72, 24));
		((Control)ErrEdit).set_TabIndex(12);
		((Control)ErrEdit).set_Text("Edit");
		((Control)ErrEdit).add_Click((EventHandler)ErrEdit_Click);
		((Control)ErrMsgTxt).set_Location(new Point(232, 104));
		((Control)ErrMsgTxt).set_Name("ErrMsgTxt");
		((Control)ErrMsgTxt).set_Size(new Size(192, 20));
		((Control)ErrMsgTxt).set_TabIndex(8);
		((Control)ErrMsgTxt).set_Text("");
		((Control)ErrCodeTxt).set_Location(new Point(232, 64));
		((Control)ErrCodeTxt).set_Name("ErrCodeTxt");
		((Control)ErrCodeTxt).set_Size(new Size(192, 20));
		((Control)ErrCodeTxt).set_TabIndex(7);
		((Control)ErrCodeTxt).set_Text("");
		((Control)ErrIntervalTxt).set_Location(new Point(232, 24));
		((Control)ErrIntervalTxt).set_Name("ErrIntervalTxt");
		((Control)ErrIntervalTxt).set_Size(new Size(192, 20));
		((Control)ErrIntervalTxt).set_TabIndex(6);
		((Control)ErrIntervalTxt).set_Text("");
		((Control)ErrDelete).set_Location(new Point(256, 144));
		((Control)ErrDelete).set_Name("ErrDelete");
		((Control)ErrDelete).set_Size(new Size(72, 24));
		((Control)ErrDelete).set_TabIndex(5);
		((Control)ErrDelete).set_Text("Delete");
		((Control)ErrDelete).add_Click((EventHandler)ErrDelete_Click);
		((Control)ErrAdd).set_Location(new Point(160, 144));
		((Control)ErrAdd).set_Name("ErrAdd");
		((Control)ErrAdd).set_Size(new Size(72, 24));
		((Control)ErrAdd).set_TabIndex(4);
		((Control)ErrAdd).set_Text("Add");
		((Control)ErrAdd).add_Click((EventHandler)ErrAdd_Click);
		((Control)ErrMsgLbl).set_Location(new Point(160, 104));
		((Control)ErrMsgLbl).set_Name("ErrMsgLbl");
		((Control)ErrMsgLbl).set_Size(new Size(56, 24));
		((Control)ErrMsgLbl).set_TabIndex(3);
		((Control)ErrMsgLbl).set_Text("Message:");
		((Control)ErrCodeLbl).set_Location(new Point(160, 64));
		((Control)ErrCodeLbl).set_Name("ErrCodeLbl");
		((Control)ErrCodeLbl).set_Size(new Size(56, 24));
		((Control)ErrCodeLbl).set_TabIndex(2);
		((Control)ErrCodeLbl).set_Text("Code:");
		((Control)ErrIntervalLbl).set_Location(new Point(152, 24));
		((Control)ErrIntervalLbl).set_Name("ErrIntervalLbl");
		((Control)ErrIntervalLbl).set_Size(new Size(72, 24));
		((Control)ErrIntervalLbl).set_TabIndex(1);
		((Control)ErrIntervalLbl).set_Text("Interval (ms): ");
		((Control)ErrorList).set_Location(new Point(16, 24));
		((Control)ErrorList).set_Name("ErrorList");
		((Control)ErrorList).set_Size(new Size(128, 147));
		((Control)ErrorList).set_TabIndex(0);
		ErrorList.add_SelectedIndexChanged((EventHandler)ErrorList_SelectedIndexChanged);
		OK.set_DialogResult((DialogResult)1);
		((Control)OK).set_Location(new Point(152, 416));
		((Control)OK).set_Name("OK");
		((Control)OK).set_Size(new Size(72, 24));
		((Control)OK).set_TabIndex(2);
		((Control)OK).set_Text("Apply");
		((Control)OK).add_Click((EventHandler)Exit_Click);
		((Control)Cancel).set_Location(new Point(264, 416));
		((Control)Cancel).set_Name("Cancel");
		((Control)Cancel).set_Size(new Size(72, 24));
		((Control)Cancel).set_TabIndex(3);
		((Control)Cancel).set_Text("Cancel");
		((Control)Cancel).add_Click((EventHandler)Cancel_Click);
		((Control)ErrorRetryNum).set_Location(new Point(16, 176));
		((Control)ErrorRetryNum).set_Name("ErrorRetryNum");
		((Control)ErrorRetryNum).set_Size(new Size(160, 24));
		((Control)ErrorRetryNum).set_TabIndex(4);
		((Control)ErrorRetryNum).set_Text("Number of Error Retry (in ms):");
		((Control)ErrorRetryTxt).set_Location(new Point(208, 176));
		((Control)ErrorRetryTxt).set_Name("ErrorRetryTxt");
		((Control)ErrorRetryTxt).set_Size(new Size(248, 20));
		((Control)ErrorRetryTxt).set_TabIndex(5);
		((Control)ErrorRetryTxt).set_Text("");
		((Control)ErrorRetryTxt).add_TextChanged((EventHandler)ErrorRetryTxt_TextChanged);
		((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)this).set_ClientSize(new Size(480, 454));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)ErrorRetryTxt);
		((Control)this).get_Controls().Add((Control)(object)ErrorRetryNum);
		((Control)this).get_Controls().Add((Control)(object)Cancel);
		((Control)this).get_Controls().Add((Control)(object)OK);
		((Control)this).get_Controls().Add((Control)(object)ErrorGroup);
		((Control)this).get_Controls().Add((Control)(object)ExceptionGroup);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Control)this).set_Name("RetryErrorForm");
		((Control)this).set_Text("RetryErrorForm");
		((Control)ExceptionGroup).ResumeLayout(false);
		((Control)ErrorGroup).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
