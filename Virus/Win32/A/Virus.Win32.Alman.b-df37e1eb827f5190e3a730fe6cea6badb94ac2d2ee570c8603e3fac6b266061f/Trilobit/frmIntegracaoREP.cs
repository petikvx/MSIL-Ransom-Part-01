using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using RepTrilobit;

namespace Trilobit;

public class frmIntegracaoREP : Form
{
	private IContainer components;

	private Timer timer1;

	private GroupBox groupBox1;

	private Label lblMensagem;

	public REP _TRep;

	private cLogDiario _Log;

	private extern string _IP
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	private extern string _Porta
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	private extern string _Senha
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	private extern string _Tipo
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	private unsafe string _Visivel
	{
		[CompilerGenerated]
		get
		{
			//Discarded unreachable code: IL_0013
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			/*Error: stloc 2 (out-of-bounds)*/;
			_ = ~/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: stloc 2 (out-of-bounds)*/;
			_003F val = ~/*Error near IL_0004: Stack underflow*/;
			/*Error near IL_0006: stloc 2 (out-of-bounds)*/;
			_ = ~val;
			/*Error near IL_0008: stloc 2 (out-of-bounds)*/;
			_ = /*Error near IL_000a: Stack underflow*/>> (int)/*Error near IL_000a: Stack underflow*/;
			/*Error near IL_000a: stloc 2 (out-of-bounds)*/;
			/*Error near IL_000b: stloc 2 (out-of-bounds)*/;
			/*Error near IL_000c: stloc 2 (out-of-bounds)*/;
			_ = *(long*)(nint)/*Error near IL_000e: Stack underflow*/;
			/*Error near IL_000e: Invalid metadata token*/;
		}
		[CompilerGenerated]
		set
		{
			//Discarded unreachable code: IL_000b, IL_0015
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Expected F4, but got I8
			/*Error: stloc 2 (out-of-bounds)*/;
			_ = /*Error near IL_0002: Stack underflow*/>> (int)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: stloc 2 (out-of-bounds)*/;
			/*Error near IL_0003: stloc 2 (out-of-bounds)*/;
			/*Error near IL_0004: stloc 2 (out-of-bounds)*/;
			_ = *(long*)(nint)/*Error near IL_0006: Stack underflow*/;
			/*Error near IL_0006: Invalid metadata token*/;
		}
	}

	private extern string _Arquivo
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	private extern string _DataInicial
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	private extern string _DataFinal
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	protected override extern void Dispose(bool disposing);

	private extern void InitializeComponent();

	public extern frmIntegracaoREP();

	private extern string GetParametro(string[] Parametro, int posicao);

	private extern void frmIntegracaoREP_Load(object sender, EventArgs e);

	private extern void TratarTimer(object sender, EventArgs e);

	private extern void LogarErro(int Codigo, string msg);

	private extern bool ParametrosValidos();

	private void TratarParametros()
	{
		switch (_Tipo)
		{
		case "4":
			ExportarConfiguracao();
			break;
		case "3":
			ExportarEmpregados();
			break;
		case "2":
			ExportarAFD();
			break;
		case "1":
			ImportarArquivo();
			break;
		}
	}

	private string TirarEspacos(string Valor)
	{
		try
		{
			string text = Valor.Trim();
			if (text.IndexOf('\0') >= 0)
			{
				text = text.Substring(0, text.IndexOf('\0'));
			}
			return text;
		}
		catch
		{
			throw;
		}
	}

	private void ExportarConfiguracao()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		try
		{
			_TRep = new REP();
			REP tRep = _TRep;
			try
			{
				bool flag = false;
				if (_DataInicial.ToUpper().Equals("S"))
				{
					flag = true;
				}
				if (!_TRep.LerConfiguracoes(_IP, int.Parse(_Porta), int.Parse(_Senha), _Arquivo, flag))
				{
					LogarErro(17, _TRep.get_ErrorException().Message);
					return;
				}
			}
			finally
			{
				((IDisposable)tRep)?.Dispose();
			}
			LogarErro(0, "Arquivo [" + _Arquivo + "] gerado com êxito.");
		}
		catch (Exception ex)
		{
			LogarErro(18, ex.Message);
		}
	}

	private void ExportarEmpregados()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		try
		{
			_TRep = new REP();
			REP tRep = _TRep;
			try
			{
				bool flag = false;
				if (_DataInicial.ToUpper().Equals("S"))
				{
					flag = true;
				}
				if (!_TRep.LerEmpregados(_IP, int.Parse(_Porta), int.Parse(_Senha), _Arquivo, flag))
				{
					LogarErro(15, _TRep.get_ErrorException().Message);
					return;
				}
			}
			finally
			{
				((IDisposable)tRep)?.Dispose();
			}
			LogarErro(0, "Arquivo [" + _Arquivo + "] gerado com êxito.");
		}
		catch (Exception ex)
		{
			LogarErro(16, ex.Message);
		}
	}

	private void ExportarAFD()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		try
		{
			_TRep = new REP();
			REP tRep = _TRep;
			try
			{
				if (!_TRep.LerAFD(_IP, int.Parse(_Porta), int.Parse(_Senha), _DataInicial, _DataFinal, _Arquivo))
				{
					LogarErro(3, _TRep.get_ErrorException().Message);
					return;
				}
			}
			finally
			{
				((IDisposable)tRep)?.Dispose();
			}
			LogarErro(0, "Arquivo [" + _Arquivo + "] gerado com êxito.");
		}
		catch (Exception ex)
		{
			LogarErro(4, ex.Message);
		}
	}

	private void ImportarArquivo()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		try
		{
			cImportar val = new cImportar(_Log);
			int codigo = 0;
			string msg = "";
			val.Arquivo(_Arquivo, _IP, int.Parse(_Porta), int.Parse(_Senha), ref codigo, ref msg);
			LogarErro(codigo, msg);
		}
		catch (Exception ex)
		{
			LogarErro(9, ex.Message);
		}
	}
}
