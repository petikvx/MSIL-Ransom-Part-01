using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal class runPrD : FontDialog, MyEvents, MyDialogs
{
	public string TypeObj;

	public string defaultName;

	public object MyObj;

	private MyEvents.CreatedEventHandler CreatedEvent;

	public PropertysRun Props;

	public PageSetupDialog PageDialog;

	public PrintDialog PrinDialog;

	public PrintPreviewDialog PrevDialog;

	[AccessedThroughProperty("PrintDoc")]
	private PrintDocument _PrintDoc;

	private string nam;

	public object rtfPrint;

	public object tablPrint;

	public string objPrint;

	public Image picPrint;

	public bool isPreview;

	private object imageTyped;

	private object objTyped;

	private object tableTyped;

	private bool rtfTyped;

	private int checkPrint;

	private runRT txtRT;

	private string imObj;

	private int numPage;

	public virtual PrintDocument PrintDoc
	{
		get
		{
			return _PrintDoc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Expected O, but got Unknown
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected O, but got Unknown
			if (_PrintDoc != null)
			{
				_PrintDoc.remove_PrintPage(new PrintPageEventHandler(PrintDocument1_PrintPage));
				_PrintDoc.remove_BeginPrint(new PrintEventHandler(PrintDoc_BeginPrint));
			}
			_PrintDoc = value;
			if (_PrintDoc != null)
			{
				_PrintDoc.add_PrintPage(new PrintPageEventHandler(PrintDocument1_PrintPage));
				_PrintDoc.add_BeginPrint(new PrintEventHandler(PrintDoc_BeginPrint));
			}
		}
	}

	public string Name
	{
		get
		{
			if (Operators.CompareString(nam, "", false) == 0)
			{
				object proj = peremens2.proj;
				object[] array = new object[1] { defaultName };
				bool[] array2 = new bool[1] { true };
				object obj = NewLateBinding.LateGet(proj, (Type)null, "GiveName", array, (string[])null, (Type[])null, array2);
				if (array2[0])
				{
					defaultName = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
				}
				nam = Conversions.ToString(obj);
			}
			return nam;
		}
		set
		{
			nam = value;
		}
	}

	public object Left
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public object Top
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public event MyEvents.CreatedEventHandler Created
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			CreatedEvent = (MyEvents.CreatedEventHandler)Delegate.Combine(CreatedEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			CreatedEvent = (MyEvents.CreatedEventHandler)Delegate.Remove(CreatedEvent, value);
		}
	}

	public runPrD()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		TypeObj = "PoluObj";
		defaultName = peremens.trans("Окно печати");
		Props = new PropertysRun(this);
		PageDialog = new PageSetupDialog();
		PrinDialog = new PrintDialog();
		PrevDialog = new PrintPreviewDialog();
		PrintDoc = new PrintDocument();
		imageTyped = false;
		objTyped = false;
		tableTyped = false;
		rtfTyped = false;
		numPage = 0;
	}

	public void Load()
	{
		PrinDialog.set_AllowSomePages(true);
	}

	public void RaiseCreate()
	{
		CreatedEvent?.Invoke(this, new EventArgs());
	}

	public void PrintDoc_BeginPrint(object sender, PrintEventArgs e)
	{
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		imageTyped = false;
		objTyped = false;
		Thread.Sleep(1);
		if (Operators.CompareString(objPrint, "", false) != 0)
		{
			imObj = new PropertysOther(null).get_ScreenshotOfObject(new string[1] { objPrint });
		}
		checkPrint = 0;
		txtRT = null;
		rtfTyped = false;
		tableTyped = false;
		if (tablPrint != null)
		{
			if (Information.IsArray(RuntimeHelpers.GetObjectValue(tablPrint)))
			{
				tablPrint = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(tablPrint, new object[1] { 0 }, (string[])null));
			}
			object obj = NewLateBinding.LateGet(tablPrint, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array = new object[8];
			object[] array2 = array;
			object obj2 = tablPrint;
			array2[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj2, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null));
			array[1] = PrintDoc;
			array[2] = peremens.DaOrNet(Props.TableOnCenter);
			array[3] = true;
			object[] array3 = array;
			PropertysRun props = Props;
			array3[4] = props.PrintText;
			array[5] = ((FontDialog)this).get_Font();
			array[6] = ((FontDialog)this).get_Color();
			array[7] = false;
			object[] array4 = array;
			bool[] array5 = new bool[8] { true, true, false, false, true, true, true, false };
			NewLateBinding.LateCall(obj, (Type)null, "DataGridViewPrinter", array4, (string[])null, (Type[])null, array5, true);
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(obj2, (Type)null, "obj", new object[1] { RuntimeHelpers.GetObjectValue(array4[0]) }, (string[])null, (Type[])null, true, false);
			}
			if (array5[1])
			{
				PrintDoc = (PrintDocument)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[1]), typeof(PrintDocument));
			}
			if (array5[4])
			{
				props.PrintText = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[4]), typeof(string));
			}
			if (array5[5])
			{
				((FontDialog)this).set_Font((Font)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[5]), typeof(Font)));
			}
			if (array5[6])
			{
				((FontDialog)this).set_Color((Color)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[6]), typeof(Color)));
			}
		}
	}

	private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
	{
		checked
		{
			try
			{
				do
				{
					object obj = 0;
					object obj2 = 0;
					object obj3 = e.get_MarginBounds().Width;
					e.get_Graphics().Clear(Color.White);
					numPage++;
					if (isPreview || numPage <= e.get_PageSettings().get_PrinterSettings().get_ToPage())
					{
						if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(imageTyped, (object)false, false), (object)(picPrint != null))))
						{
							obj2 = e.get_MarginBounds().Left;
							obj = e.get_MarginBounds().Top;
							float num = picPrint.get_Height();
							obj3 = picPrint.get_Width();
							if (Operators.ConditionalCompareObjectLess((object)e.get_MarginBounds().Width, obj3, false))
							{
								double num2 = Conversions.ToDouble(Operators.DivideObject((object)e.get_MarginBounds().Width, obj3));
								num = (float)((double)num * num2);
								obj3 = Operators.MultiplyObject(obj3, (object)num2);
							}
							if ((float)e.get_MarginBounds().Height < num)
							{
								double num3 = (float)e.get_MarginBounds().Height / num;
								num = (float)((double)num * num3);
								obj3 = Operators.MultiplyObject(obj3, (object)num3);
							}
							if (Operators.ConditionalCompareObjectGreater((object)e.get_MarginBounds().Width, obj3, false))
							{
								obj2 = Operators.AddObject((object)e.get_MarginBounds().Left, Operators.DivideObject(Operators.SubtractObject((object)e.get_MarginBounds().Width, obj3), (object)2));
							}
							Graphics graphics = e.get_Graphics();
							Image obj4 = picPrint;
							Rectangle rectangle = new Rectangle(Conversions.ToInteger(obj2), Conversions.ToInteger(obj), Conversions.ToInteger(obj3), (int)Math.Round(num));
							graphics.DrawImage(obj4, rectangle);
							obj = Operators.AddObject(obj, (object)(num + ((FontDialog)this).get_Font().GetHeight(e.get_Graphics())));
							imageTyped = true;
						}
						if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(objTyped, (object)false, false), (object)(Operators.CompareString(objPrint, "", false) != 0)), (object)(Operators.CompareString(imObj, "", false) != 0))))
						{
							Image val = Image.FromFile(imObj);
							if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(obj, (object)0, false), Operators.CompareObjectGreater(Operators.AddObject(obj, (object)val.get_Height()), (object)e.get_MarginBounds().Height, false))))
							{
								e.set_HasMorePages(true);
								continue;
							}
							obj2 = e.get_MarginBounds().Left;
							if (Operators.ConditionalCompareObjectEqual(obj, (object)0, false))
							{
								obj = e.get_MarginBounds().Top;
							}
							float num = val.get_Height();
							obj3 = val.get_Width();
							if (Operators.ConditionalCompareObjectLess((object)e.get_MarginBounds().Width, obj3, false))
							{
								double num4 = Conversions.ToDouble(Operators.DivideObject((object)e.get_MarginBounds().Width, obj3));
								num = (float)((double)num * num4);
								obj3 = Operators.MultiplyObject(obj3, (object)num4);
							}
							if ((float)e.get_MarginBounds().Height < num)
							{
								double num5 = (float)e.get_MarginBounds().Height / num;
								num = (float)((double)num * num5);
								obj3 = Operators.MultiplyObject(obj3, (object)num5);
							}
							if (Operators.ConditionalCompareObjectGreater((object)e.get_MarginBounds().Width, obj3, false))
							{
								obj2 = Operators.AddObject((object)e.get_MarginBounds().Left, Operators.DivideObject(Operators.SubtractObject((object)e.get_MarginBounds().Width, obj3), (object)2));
							}
							Graphics graphics2 = e.get_Graphics();
							Rectangle rectangle = new Rectangle(Conversions.ToInteger(obj2), Conversions.ToInteger(obj), Conversions.ToInteger(obj3), (int)Math.Round(num));
							graphics2.DrawImage(val, rectangle);
							obj = Operators.AddObject(obj, (object)(num + ((FontDialog)this).get_Font().GetHeight(e.get_Graphics())));
							objTyped = true;
						}
						if ((Operators.CompareString(Props.PrintText, "", false) != 0) & (txtRT == null) & (tablPrint == null))
						{
							txtRT = new runRT();
							((RichTextBox)txtRT).set_Text(Props.PrintText);
							((TextBoxBase)txtRT).SelectAll();
							((RichTextBox)txtRT).set_SelectionFont(((FontDialog)this).get_Font());
							((RichTextBox)txtRT).set_SelectionColor(((FontDialog)this).get_Color());
							runRT runRT2 = txtRT;
							((RichTextBox)runRT2).set_Text(((RichTextBox)runRT2).get_Text() + "\r\n\r\n");
						}
						if (rtfPrint != null)
						{
							if (Information.IsArray(RuntimeHelpers.GetObjectValue(rtfPrint)))
							{
								rtfPrint = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(rtfPrint, new object[1] { 0 }, (string[])null));
							}
							if (txtRT == null)
							{
								txtRT = (runRT)NewLateBinding.LateGet(rtfPrint, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null);
							}
							else if (checkPrint == 0)
							{
								((TextBoxBase)txtRT).set_SelectionStart(((RichTextBox)txtRT).get_TextLength() - 1);
								runRT runRT3 = new runRT();
								((RichTextBox)runRT3).set_Rtf(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(rtfPrint, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "rtf", new object[0], (string[])null, (Type[])null, (bool[])null)));
								((TextBoxBase)runRT3).SelectAll();
								((RichTextBox)txtRT).set_SelectedRtf(((RichTextBox)runRT3).get_SelectedRtf());
							}
						}
						if (!((txtRT != null) & !rtfTyped))
						{
							goto IL_0696;
						}
						if (Operators.ConditionalCompareObjectGreater(obj, (object)e.get_MarginBounds().Height, false))
						{
							e.set_HasMorePages(true);
							continue;
						}
						checkPrint = txtRT.Print(checkPrint, ((RichTextBox)txtRT).get_TextLength(), e, Conversions.ToSingle(obj));
						if (checkPrint < ((RichTextBox)txtRT).get_TextLength())
						{
							e.set_HasMorePages(true);
							continue;
						}
						e.set_HasMorePages(false);
						obj = 1;
						rtfTyped = true;
						goto IL_0696;
					}
					e.set_Cancel(true);
					e.set_HasMorePages(false);
					numPage = 0;
					return;
					IL_0696:
					if (Conversions.ToBoolean(Operators.AndObject((object)(tablPrint != null), Operators.CompareObjectEqual(tableTyped, (object)false, false))))
					{
						if (Operators.ConditionalCompareObjectGreater(obj, (object)0, false))
						{
							e.set_HasMorePages(true);
							continue;
						}
						if (Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(tablPrint, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "DrawDataGridView", new object[1] { e.get_Graphics() }, (string[])null, (Type[])null, (bool[])null)))
						{
							e.set_HasMorePages(true);
							continue;
						}
						e.set_HasMorePages(false);
						obj = 1;
						tableTyped = true;
					}
				}
				while ((numPage < e.get_PageSettings().get_PrinterSettings().get_FromPage()) & !isPreview);
				if (!isPreview && numPage >= e.get_PageSettings().get_PrinterSettings().get_ToPage())
				{
					e.set_HasMorePages(false);
				}
				if (!e.get_HasMorePages())
				{
					numPage = 0;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				numPage = 0;
				throw ex2;
			}
		}
	}

	public void BringToFront()
	{
	}

	public void SendToBack()
	{
	}
}
