using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace SimpleChessApp.Game;

public class Repository : Component
{
	public Square PromotedSquare;

	public Board ChessBoard;

	private IContainer components = null;

	private ContextMenuStrip PawnPromotionDialog;

	private ToolStripMenuItem queenToolStripMenuItem;

	private ToolStripMenuItem rookToolStripMenuItem;

	private ToolStripMenuItem bishopToolStripMenuItem;

	private ToolStripMenuItem knightToolStripMenuItem;

	private ImageList imageList2;

	private ImageList imageList1;

	public Repository()
	{
		InitializeComponent();
		Repository.smethod_0((ToolStripItem)(object)queenToolStripMenuItem, (object)Pieces.Queen);
		Repository.smethod_0((ToolStripItem)(object)knightToolStripMenuItem, (object)Pieces.Knight);
		Repository.smethod_0((ToolStripItem)(object)rookToolStripMenuItem, (object)Pieces.Rook);
		Repository.smethod_0((ToolStripItem)(object)bishopToolStripMenuItem, (object)Pieces.Bishop);
		Repository.smethod_1((ToolStripItem)(object)queenToolStripMenuItem, (EventHandler)QueenToolStripMenuItem_Click);
		Repository.smethod_1((ToolStripItem)(object)knightToolStripMenuItem, (EventHandler)QueenToolStripMenuItem_Click);
		Repository.smethod_1((ToolStripItem)(object)rookToolStripMenuItem, (EventHandler)QueenToolStripMenuItem_Click);
		Repository.smethod_1((ToolStripItem)(object)bishopToolStripMenuItem, (EventHandler)QueenToolStripMenuItem_Click);
	}

	internal void ShowPieceSelector(Control x)
	{
		Repository.smethod_4((ToolStripDropDown)(object)PawnPromotionDialog, Repository.smethod_2(x), Repository.smethod_3(x));
	}

	private void QueenToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		Pieces kind = (Pieces)Repository.smethod_5((ToolStripItem)(ToolStripMenuItem)sender);
		PromotedSquare.Piece.Kind = kind;
		ChessBoard[PromotedSquare].Piece = PromotedSquare.Piece;
		if (PromotedSquare.Piece.Color == PieceColor.White)
		{
			ChessPiece chessPiece = ChessBoard.WhitePieces[PromotedSquare.Piece.Id];
			if (chessPiece != null)
			{
				chessPiece.Kind = kind;
			}
		}
		if (PromotedSquare.Piece.Color == PieceColor.Black)
		{
			ChessPiece chessPiece2 = ChessBoard.BlackPieces[PromotedSquare.Piece.Id];
			if (chessPiece2 != null)
			{
				chessPiece2.Kind = kind;
			}
		}
	}

	public Image GetPiece(Pieces name, PieceColor color)
	{
		int int_ = (int)(name - 1);
		return (color == PieceColor.Black) ? Repository.smethod_7(Repository.smethod_6(imageList1), int_) : Repository.smethod_7(Repository.smethod_6(imageList2), int_);
	}

	public Repository(IContainer container)
	{
		Repository.smethod_8(container, (IComponent)this);
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			Repository.smethod_9((IDisposable)components);
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected O, but got Unknown
		components = Repository.smethod_10();
		ComponentResourceManager resourceManager_ = Repository.smethod_12(Repository.smethod_11(typeof(Repository).TypeHandle));
		PawnPromotionDialog = Repository.smethod_13(components);
		queenToolStripMenuItem = Repository.smethod_14();
		rookToolStripMenuItem = Repository.smethod_14();
		bishopToolStripMenuItem = Repository.smethod_14();
		knightToolStripMenuItem = Repository.smethod_14();
		imageList2 = Repository.smethod_15(components);
		imageList1 = Repository.smethod_15(components);
		Repository.smethod_16((Control)(object)PawnPromotionDialog);
		Repository.smethod_17((Control)(object)PawnPromotionDialog, "");
		Repository.smethod_19(Repository.smethod_18((ToolStrip)(object)PawnPromotionDialog), (ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)queenToolStripMenuItem,
			(ToolStripItem)rookToolStripMenuItem,
			(ToolStripItem)bishopToolStripMenuItem,
			(ToolStripItem)knightToolStripMenuItem
		});
		Repository.smethod_20((Control)(object)PawnPromotionDialog, "contextMenuStrip1");
		Repository.smethod_21((Control)(object)PawnPromotionDialog, new Size(111, 92));
		Repository.smethod_22((ToolStripItem)(object)queenToolStripMenuItem, "queenToolStripMenuItem");
		Repository.smethod_23((ToolStripItem)(object)queenToolStripMenuItem, new Size(110, 22));
		Repository.smethod_24((ToolStripItem)(object)queenToolStripMenuItem, "Queen");
		Repository.smethod_22((ToolStripItem)(object)rookToolStripMenuItem, "rookToolStripMenuItem");
		Repository.smethod_23((ToolStripItem)(object)rookToolStripMenuItem, new Size(110, 22));
		Repository.smethod_24((ToolStripItem)(object)rookToolStripMenuItem, "Rook");
		Repository.smethod_22((ToolStripItem)(object)bishopToolStripMenuItem, "bishopToolStripMenuItem");
		Repository.smethod_23((ToolStripItem)(object)bishopToolStripMenuItem, new Size(110, 22));
		Repository.smethod_24((ToolStripItem)(object)bishopToolStripMenuItem, "Bishop");
		Repository.smethod_22((ToolStripItem)(object)knightToolStripMenuItem, "knightToolStripMenuItem");
		Repository.smethod_23((ToolStripItem)(object)knightToolStripMenuItem, new Size(110, 22));
		Repository.smethod_24((ToolStripItem)(object)knightToolStripMenuItem, "Knight");
		Repository.smethod_26(imageList2, (ImageListStreamer)Repository.smethod_25((ResourceManager)resourceManager_, "imageList2.ImageStream"));
		Repository.smethod_27(imageList2, Color.Transparent);
		Repository.smethod_28(Repository.smethod_6(imageList2), 0, "Chess_plt45.svg.png");
		Repository.smethod_28(Repository.smethod_6(imageList2), 1, "50px-Chess_nlt45.svg.png");
		Repository.smethod_28(Repository.smethod_6(imageList2), 2, "Chess_blt45.svg.png");
		Repository.smethod_28(Repository.smethod_6(imageList2), 3, "Chess_rlt45.svg.png");
		Repository.smethod_28(Repository.smethod_6(imageList2), 4, "Chess_klt45.svg.png");
		Repository.smethod_28(Repository.smethod_6(imageList2), 5, "50px-Chess_qlt45.svg.png");
		Repository.smethod_26(imageList1, (ImageListStreamer)Repository.smethod_25((ResourceManager)resourceManager_, "imageList1.ImageStream"));
		Repository.smethod_27(imageList1, Color.Transparent);
		Repository.smethod_28(Repository.smethod_6(imageList1), 0, "Chess_pdt45.svg.png");
		Repository.smethod_28(Repository.smethod_6(imageList1), 1, "50px-Chess_ndt45.svg.png");
		Repository.smethod_28(Repository.smethod_6(imageList1), 2, "50px-Chess_bdt45.svg.png");
		Repository.smethod_28(Repository.smethod_6(imageList1), 3, "50px-Chess_rdt45.svg.png");
		Repository.smethod_28(Repository.smethod_6(imageList1), 4, "50px-Chess_kdt45.svg.png");
		Repository.smethod_28(Repository.smethod_6(imageList1), 5, "50px-Chess_qdt45.svg.png");
		Repository.smethod_29((Control)(object)PawnPromotionDialog, bool_0: false);
	}

	static void smethod_0(ToolStripItem toolStripItem_0, object object_0)
	{
		toolStripItem_0.set_Tag(object_0);
	}

	static void smethod_1(ToolStripItem toolStripItem_0, EventHandler eventHandler_0)
	{
		toolStripItem_0.add_Click(eventHandler_0);
	}

	static Control smethod_2(Control control_0)
	{
		return control_0.get_Parent();
	}

	static Point smethod_3(Control control_0)
	{
		return control_0.get_Location();
	}

	static void smethod_4(ToolStripDropDown toolStripDropDown_0, Control control_0, Point point_0)
	{
		toolStripDropDown_0.Show(control_0, point_0);
	}

	static object smethod_5(ToolStripItem toolStripItem_0)
	{
		return toolStripItem_0.get_Tag();
	}

	static ImageCollection smethod_6(ImageList imageList_0)
	{
		return imageList_0.get_Images();
	}

	static Image smethod_7(ImageCollection imageCollection_0, int int_0)
	{
		return imageCollection_0.get_Item(int_0);
	}

	static void smethod_8(IContainer icontainer_0, IComponent icomponent_0)
	{
		icontainer_0.Add(icomponent_0);
	}

	static void smethod_9(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Container smethod_10()
	{
		return new Container();
	}

	static Type smethod_11(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static ComponentResourceManager smethod_12(Type type_0)
	{
		return new ComponentResourceManager(type_0);
	}

	static ContextMenuStrip smethod_13(IContainer icontainer_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new ContextMenuStrip(icontainer_0);
	}

	static ToolStripMenuItem smethod_14()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ToolStripMenuItem();
	}

	static ImageList smethod_15(IContainer icontainer_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new ImageList(icontainer_0);
	}

	static void smethod_16(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_17(Control control_0, string string_0)
	{
		control_0.set_AccessibleDescription(string_0);
	}

	static ToolStripItemCollection smethod_18(ToolStrip toolStrip_0)
	{
		return toolStrip_0.get_Items();
	}

	static void smethod_19(ToolStripItemCollection toolStripItemCollection_0, ToolStripItem[] toolStripItem_0)
	{
		toolStripItemCollection_0.AddRange(toolStripItem_0);
	}

	static void smethod_20(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_21(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_22(ToolStripItem toolStripItem_0, string string_0)
	{
		toolStripItem_0.set_Name(string_0);
	}

	static void smethod_23(ToolStripItem toolStripItem_0, Size size_0)
	{
		toolStripItem_0.set_Size(size_0);
	}

	static void smethod_24(ToolStripItem toolStripItem_0, string string_0)
	{
		toolStripItem_0.set_Text(string_0);
	}

	static object smethod_25(ResourceManager resourceManager_0, string string_0)
	{
		return resourceManager_0.GetObject(string_0);
	}

	static void smethod_26(ImageList imageList_0, ImageListStreamer imageListStreamer_0)
	{
		imageList_0.set_ImageStream(imageListStreamer_0);
	}

	static void smethod_27(ImageList imageList_0, Color color_0)
	{
		imageList_0.set_TransparentColor(color_0);
	}

	static void smethod_28(ImageCollection imageCollection_0, int int_0, string string_0)
	{
		imageCollection_0.SetKeyName(int_0, string_0);
	}

	static void smethod_29(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}
}
