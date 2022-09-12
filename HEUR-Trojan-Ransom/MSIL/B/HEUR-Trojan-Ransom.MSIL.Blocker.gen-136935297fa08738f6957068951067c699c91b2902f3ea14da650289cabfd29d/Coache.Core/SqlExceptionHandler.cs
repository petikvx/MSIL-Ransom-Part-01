using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Coache.Core;

internal class SqlExceptionHandler
{
	private static Dictionary<string, string> ConstraintMessages => new Dictionary<string, string>
	{
		{ "IX_USUARIO", "El nombre de usuario ya existe, seleccione uno nuevo" },
		{ "IX_DETALLEENTIDAD_TELEFONO", "Ya hay un usuario con el mismo teléfono" },
		{ "IX_PROVEEDOR_CUIT", "Ya hay un proveedor con el CUIT especificado" },
		{ "IX_PROVEEDOR_RSOCIAL", "Ya hay un proveedor con esa Razón Social" },
		{ "CK_CLIENTE_SALDO", "No posee saldo suficiente para realizar la compra" }
	};

	public static void Handle(SqlException exception)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		string text = ((Exception)(object)exception).Message.ToUpperInvariant();
		foreach (string key in ConstraintMessages.Keys)
		{
			if (text.Contains(key))
			{
				MessageBox.Show(ConstraintMessages[key]);
				return;
			}
		}
		MessageBox.Show(((Exception)(object)exception).Message);
	}
}
