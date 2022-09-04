using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

public class Tl : DataGridView
{
	public string TypeObj;

	public string defaultName;

	public Propertys Props;

	public string LastProp;

	public string LastSobyt;

	public object MyObj;

	private DataGridView TheDataGridView;

	private PrintDocument ThePrintDocument;

	private bool IsCenterOnPage;

	private bool IsWithTitle;

	private string TheTitleText;

	private Font TheTitleFont;

	private Color TheTitleColor;

	private bool IsWithPaging;

	public int CurrentRow;

	public int PageNumber;

	private int PageWidth;

	private int PageHeight;

	private int LeftMargin;

	private int TopMargin;

	private int RightMargin;

	private int BottomMargin;

	private double CurrentY;

	private double RowHeaderHeight;

	private double[] RowsHeight;

	private double[] ColumnsWidth;

	private double TheDataGridViewWidth;

	private Point[] mColumnPoints;

	private double[] mColumnPointsWidth;

	private int mColumnPoint;

	public Tl()
	{
		TypeObj = "Obi4niy";
		defaultName = peremens.trans("Таблица");
		Props = new Propertys(this);
		LastProp = peremens.trans("Номера выделенных строк");
		LastSobyt = peremens.trans("Клик по ячейке");
		bool[] array3;
		if (peremens2.proj == null)
		{
			((Control)this).set_Name(defaultName + "1");
		}
		else
		{
			Propertys props = Props;
			object proj = peremens2.proj;
			object[] array = new object[1] { defaultName };
			object[] array2 = array;
			array3 = new bool[1] { true };
			object obj = NewLateBinding.LateGet(proj, (Type)null, "GiveName", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				defaultName = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			props.Name = Conversions.ToString(obj);
		}
		Propertys props2 = Props;
		object proj2 = peremens2.proj;
		object[] array4 = new object[1] { defaultName };
		object[] array5 = array4;
		array3 = new bool[1] { true };
		object obj2 = NewLateBinding.LateGet(proj2, (Type)null, "GiveName", array5, (string[])null, (Type[])null, array3);
		if (array3[0])
		{
			defaultName = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
		}
		props2.Name = Conversions.ToString(obj2);
		Props.Text = Props.Name;
		Props.BackColor = peremens.ToMyColor(SystemColors.AppWorkspace);
		Props.Height = 130;
		Props.Width = 244;
		Props.ScrollBars = peremens.trans("обе");
		((DataGridView)this).set_RowHeadersWidthSizeMode((DataGridViewRowHeadersWidthSizeMode)0);
		((DataGridView)this).set_RowHeadersWidth(20);
	}

	public void DataGridViewPrinter(DataGridView aDataGridView, PrintDocument aPrintDocument, bool CenterOnPage, bool WithTitle, string aTitleText, Font aTitleFont, Color aTitleColor, bool WithPaging)
	{
		TheDataGridView = aDataGridView;
		ThePrintDocument = aPrintDocument;
		IsCenterOnPage = CenterOnPage;
		IsWithTitle = WithTitle;
		TheTitleText = aTitleText;
		TheTitleFont = aTitleFont;
		TheTitleColor = aTitleColor;
		IsWithPaging = WithPaging;
		PageNumber = 0;
		RowsHeight = null;
		ColumnsWidth = null;
		mColumnPoints = null;
		mColumnPointsWidth = null;
		if (!ThePrintDocument.get_DefaultPageSettings().get_Landscape())
		{
			PageWidth = ThePrintDocument.get_DefaultPageSettings().get_PaperSize().get_Width();
			PageHeight = ThePrintDocument.get_DefaultPageSettings().get_PaperSize().get_Height();
		}
		else
		{
			PageHeight = ThePrintDocument.get_DefaultPageSettings().get_PaperSize().get_Width();
			PageWidth = ThePrintDocument.get_DefaultPageSettings().get_PaperSize().get_Height();
		}
		LeftMargin = ThePrintDocument.get_DefaultPageSettings().get_Margins().get_Left();
		TopMargin = ThePrintDocument.get_DefaultPageSettings().get_Margins().get_Top();
		RightMargin = ThePrintDocument.get_DefaultPageSettings().get_Margins().get_Right();
		BottomMargin = ThePrintDocument.get_DefaultPageSettings().get_Margins().get_Bottom();
		CurrentRow = 0;
	}

	private void Calculate(Graphics g)
	{
		if (PageNumber != 0)
		{
			return;
		}
		SizeF sizeF = default(SizeF);
		TheDataGridViewWidth = 0.0;
		checked
		{
			int num = ((BaseCollection)TheDataGridView.get_Columns()).get_Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				Font font = TheDataGridView.get_ColumnHeadersDefaultCellStyle().get_Font();
				if (font == null)
				{
					font = TheDataGridView.get_DefaultCellStyle().get_Font();
				}
				sizeF = g.MeasureString(TheDataGridView.get_Columns().get_Item(i).get_HeaderText(), font);
				double num2 = TheDataGridView.get_Columns().get_Item(i).get_Width();
				RowHeaderHeight = sizeF.Height;
				int num3 = TheDataGridView.get_Rows().get_Count() - 1;
				for (int j = 0; j <= num3; j++)
				{
					font = TheDataGridView.get_Rows().get_Item(j).get_DefaultCellStyle()
						.get_Font();
					if (font == null)
					{
						font = TheDataGridView.get_DefaultCellStyle().get_Font();
					}
					sizeF = g.MeasureString("Anything", font);
					peremens.ReDims(ref RowsHeight);
					RowsHeight[RowsHeight.Length - 1] = TheDataGridView.get_Rows().get_Item(j).get_Height();
					sizeF = g.MeasureString(TheDataGridView.get_Rows().get_Item(j).get_Cells()
						.get_Item(i)
						.get_EditedFormattedValue()
						.ToString(), font);
				}
				if (TheDataGridView.get_Columns().get_Item(i).get_Visible())
				{
					TheDataGridViewWidth += num2;
				}
				peremens.ReDims(ref ColumnsWidth);
				ColumnsWidth[ColumnsWidth.Length - 1] = num2;
			}
			int x = 0;
			int num4 = ((BaseCollection)TheDataGridView.get_Columns()).get_Count() - 1;
			for (int k = 0; k <= num4; k++)
			{
				if (TheDataGridView.get_Columns().get_Item(k).get_Visible())
				{
					x = k;
					break;
				}
			}
			int y = ((BaseCollection)TheDataGridView.get_Columns()).get_Count();
			for (int k = ((BaseCollection)TheDataGridView.get_Columns()).get_Count() - 1; k >= 0; k += -1)
			{
				if (TheDataGridView.get_Columns().get_Item(k).get_Visible())
				{
					y = k + 1;
					break;
				}
			}
			double num5 = TheDataGridViewWidth;
			double num6 = PageWidth - LeftMargin - RightMargin;
			if (TheDataGridViewWidth > num6)
			{
				num5 = 0.0;
				int num7 = ((BaseCollection)TheDataGridView.get_Columns()).get_Count() - 1;
				for (int k = 0; k <= num7; k++)
				{
					if (TheDataGridView.get_Columns().get_Item(k).get_Visible())
					{
						num5 += ColumnsWidth[k];
						if (num5 > num6)
						{
							num5 -= ColumnsWidth[k];
							peremens.ReDims(ref mColumnPoints);
							ref Point reference = ref mColumnPoints[mColumnPoints.Length - 1];
							reference = new Point(x, y);
							peremens.ReDims(ref mColumnPointsWidth);
							mColumnPointsWidth[mColumnPointsWidth.Length - 1] = num5;
							x = k;
							num5 = ColumnsWidth[k];
						}
					}
					y = k + 1;
				}
			}
			peremens.ReDims(ref mColumnPoints);
			ref Point reference2 = ref mColumnPoints[mColumnPoints.Length - 1];
			reference2 = new Point(x, y);
			peremens.ReDims(ref mColumnPointsWidth);
			mColumnPointsWidth[mColumnPointsWidth.Length - 1] = num5;
			mColumnPoint = 0;
		}
	}

	private void DrawHeader(Graphics g)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected O, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected O, but got Unknown
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected O, but got Unknown
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Expected O, but got Unknown
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Invalid comparison between Unknown and I4
		CurrentY = TopMargin;
		checked
		{
			PageNumber++;
			if (IsWithPaging)
			{
				string text = peremens.trans("Страница") + " " + PageNumber;
				StringFormat val = new StringFormat();
				val.set_Trimming((StringTrimming)2);
				val.set_FormatFlags((StringFormatFlags)28672);
				val.set_Alignment((StringAlignment)2);
				Font val2 = new Font("Tahoma", 8f, (FontStyle)0, (GraphicsUnit)3);
				RectangleF rectangleF = new RectangleF(LeftMargin, (float)CurrentY, PageWidth - RightMargin - LeftMargin, g.MeasureString(text, val2).Height);
				g.DrawString(text, val2, (Brush)new SolidBrush(Color.Black), rectangleF, val);
				CurrentY += g.MeasureString(text, val2).Height;
			}
			if (IsWithTitle)
			{
				StringFormat val3 = new StringFormat();
				val3.set_Trimming((StringTrimming)2);
				val3.set_FormatFlags((StringFormatFlags)28672);
				if (IsCenterOnPage)
				{
					val3.set_Alignment((StringAlignment)1);
				}
				else
				{
					val3.set_Alignment((StringAlignment)0);
				}
				RectangleF rectangleF2 = new RectangleF(LeftMargin, (float)CurrentY, PageWidth - RightMargin - LeftMargin, g.MeasureString(TheTitleText, TheTitleFont).Height);
				g.DrawString(TheTitleText, TheTitleFont, (Brush)new SolidBrush(TheTitleColor), rectangleF2, val3);
				CurrentY += g.MeasureString(TheTitleText, TheTitleFont).Height;
			}
			double num = LeftMargin;
			if (IsCenterOnPage)
			{
				num += ((double)(PageWidth - RightMargin - LeftMargin) - mColumnPointsWidth[mColumnPoint]) / 2.0;
			}
			Color foreColor = TheDataGridView.get_ColumnHeadersDefaultCellStyle().get_ForeColor();
			if (foreColor.IsEmpty)
			{
				foreColor = TheDataGridView.get_DefaultCellStyle().get_ForeColor();
			}
			SolidBrush val4 = new SolidBrush(foreColor);
			Color backColor = TheDataGridView.get_ColumnHeadersDefaultCellStyle().get_BackColor();
			if (backColor.IsEmpty)
			{
				backColor = TheDataGridView.get_DefaultCellStyle().get_BackColor();
			}
			object obj = (object)new SolidBrush(backColor);
			Pen val5 = new Pen(TheDataGridView.get_GridColor(), 1f);
			Font font = TheDataGridView.get_ColumnHeadersDefaultCellStyle().get_Font();
			if (font == null)
			{
				font = TheDataGridView.get_DefaultCellStyle().get_Font();
			}
			RectangleF rectangleF3 = new RectangleF((float)num, (float)CurrentY, (float)mColumnPointsWidth[mColumnPoint], (float)RowHeaderHeight);
			g.FillRectangle((Brush)obj, rectangleF3);
			object obj2 = (object)new StringFormat();
			NewLateBinding.LateSet(obj2, (Type)null, "Trimming", new object[1] { (object)(StringTrimming)2 }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(obj2, (Type)null, "FormatFlags", new object[1] { (object)(StringFormatFlags)28672 }, (string[])null, (Type[])null);
			int x = mColumnPoints[mColumnPoint].X;
			int num2 = mColumnPoints[mColumnPoint].Y - 1;
			for (int i = x; i <= num2; i++)
			{
				if (TheDataGridView.get_Columns().get_Item(i).get_Visible())
				{
					double num3 = ColumnsWidth[i];
					if (((Enum)TheDataGridView.get_ColumnHeadersDefaultCellStyle().get_Alignment()).ToString().Contains("Right"))
					{
						NewLateBinding.LateSet(obj2, (Type)null, "Alignment", new object[1] { (object)(StringAlignment)2 }, (string[])null, (Type[])null);
					}
					else if (((Enum)TheDataGridView.get_ColumnHeadersDefaultCellStyle().get_Alignment()).ToString().Contains("Center"))
					{
						NewLateBinding.LateSet(obj2, (Type)null, "Alignment", new object[1] { (object)(StringAlignment)1 }, (string[])null, (Type[])null);
					}
					else
					{
						NewLateBinding.LateSet(obj2, (Type)null, "Alignment", new object[1] { (object)(StringAlignment)0 }, (string[])null, (Type[])null);
					}
					RectangleF rectangleF4 = new RectangleF((float)num, (float)CurrentY, (float)num3, (float)RowHeaderHeight);
					g.DrawString(TheDataGridView.get_Columns().get_Item(i).get_HeaderText(), font, (Brush)(object)val4, rectangleF4, (StringFormat)obj2);
					if (unchecked((int)TheDataGridView.get_RowHeadersBorderStyle()) != 4)
					{
						g.DrawRectangle(val5, peremens.Int(Conversions.ToString(num)), peremens.Int(Conversions.ToString(CurrentY)), peremens.Int(Conversions.ToString(num3)), peremens.Int(Conversions.ToString(RowHeaderHeight)));
					}
					num += num3;
				}
			}
			CurrentY += RowHeaderHeight;
		}
	}

	private bool DrawRows(Graphics g)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Invalid comparison between Unknown and I4
		Pen val = new Pen(TheDataGridView.get_GridColor(), 1f);
		StringFormat val2 = new StringFormat();
		val2.set_Trimming((StringTrimming)2);
		checked
		{
			SolidBrush val3 = default(SolidBrush);
			Color backColor = default(Color);
			SolidBrush val4 = default(SolidBrush);
			SolidBrush val5 = default(SolidBrush);
			while (true)
			{
				if (CurrentRow < TheDataGridView.get_Rows().get_Count())
				{
					if (TheDataGridView.get_Rows().get_Item(CurrentRow).get_Visible())
					{
						Font font = TheDataGridView.get_Rows().get_Item(CurrentRow).get_DefaultCellStyle()
							.get_Font();
						if (font == null)
						{
							font = TheDataGridView.get_DefaultCellStyle().get_Font();
						}
						if (TheDataGridView.get_Rows().get_Item(CurrentRow).get_DefaultCellStyle()
							.get_ForeColor()
							.IsEmpty)
						{
							Color foreColor = TheDataGridView.get_DefaultCellStyle().get_ForeColor();
							val3 = new SolidBrush(foreColor);
							backColor = TheDataGridView.get_Rows().get_Item(CurrentRow).get_DefaultCellStyle()
								.get_BackColor();
							if (backColor.IsEmpty)
							{
								val4 = new SolidBrush(TheDataGridView.get_DefaultCellStyle().get_BackColor());
								val5 = new SolidBrush(TheDataGridView.get_AlternatingRowsDefaultCellStyle().get_BackColor());
							}
						}
						else
						{
							val4 = new SolidBrush(backColor);
							val5 = new SolidBrush(backColor);
						}
						double num = LeftMargin;
						if (IsCenterOnPage)
						{
							num += ((double)(PageWidth - RightMargin - LeftMargin) - mColumnPointsWidth[mColumnPoint]) / 2.0;
						}
						RectangleF rectangleF = new RectangleF((float)num, (float)CurrentY, (float)mColumnPointsWidth[mColumnPoint], (float)RowsHeight[CurrentRow]);
						if (unchecked(CurrentRow % 2) == 0)
						{
							g.FillRectangle((Brush)(object)val4, rectangleF);
						}
						else
						{
							g.FillRectangle((Brush)(object)val5, rectangleF);
						}
						int x = mColumnPoints[mColumnPoint].X;
						int num2 = mColumnPoints[mColumnPoint].Y - 1;
						for (int i = x; i <= num2; i++)
						{
							if (TheDataGridView.get_Columns().get_Item(i).get_Visible())
							{
								if (((Enum)TheDataGridView.get_Columns().get_Item(i).get_DefaultCellStyle()
									.get_Alignment()).ToString().Contains("Right"))
								{
									val2.set_Alignment((StringAlignment)2);
								}
								else if (((Enum)TheDataGridView.get_Columns().get_Item(i).get_DefaultCellStyle()
									.get_Alignment()).ToString().Contains("Center"))
								{
									val2.set_Alignment((StringAlignment)1);
								}
								else
								{
									val2.set_Alignment((StringAlignment)0);
								}
								double num3 = ColumnsWidth[i];
								RectangleF rectangleF2 = new RectangleF((float)num, (float)CurrentY, (float)num3, (float)RowsHeight[CurrentRow]);
								g.DrawString(TheDataGridView.get_Rows().get_Item(CurrentRow).get_Cells()
									.get_Item(i)
									.get_EditedFormattedValue()
									.ToString(), font, (Brush)(object)val3, rectangleF2, val2);
								if (unchecked((int)TheDataGridView.get_CellBorderStyle()) != 4)
								{
									g.DrawRectangle(val, peremens.Int(Conversions.ToString(num)), peremens.Int(Conversions.ToString(CurrentY)), peremens.Int(Conversions.ToString(num3)), peremens.Int(Conversions.ToString(RowsHeight[CurrentRow])));
								}
								num += num3;
							}
						}
						CurrentY += RowsHeight[CurrentRow];
						if (!(CurrentY <= (double)(PageHeight - TopMargin - BottomMargin)))
						{
							break;
						}
					}
					CurrentRow++;
					continue;
				}
				CurrentRow = 0;
				mColumnPoint++;
				if (mColumnPoint == mColumnPoints.Length)
				{
					mColumnPoint = 0;
					return false;
				}
				return true;
			}
			CurrentRow++;
			return true;
		}
	}

	public bool DrawDataGridView(Graphics g)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Calculate(g);
			DrawHeader(g);
			return DrawRows(g);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show("Operation failed: " + ex2.Message.ToString(), Application.get_ProductName() + " - Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
