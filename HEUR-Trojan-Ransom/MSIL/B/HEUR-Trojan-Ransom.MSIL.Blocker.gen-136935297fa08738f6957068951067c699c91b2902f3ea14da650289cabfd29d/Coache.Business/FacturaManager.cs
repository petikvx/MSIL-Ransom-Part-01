using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using Coache.Common;
using Data;

namespace Coache.Business;

public class FacturaManager
{
	public int GenerarFactura(Proveedor proveedor, BindingList<CompraCupon> compras, DateTime fecha)
	{
		DataRow dataRow = SqlDataAccess.ExecuteDataRowQuery(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.InsertFactura", SqlDataAccessArgs.CreateWith("@Fecha", fecha).And("@ID_Proveedor", proveedor.UserID).Arguments);
		int result = int.Parse(dataRow["NroFactura"].ToString());
		int idFactura = int.Parse(dataRow["ID_Factura"].ToString());
		foreach (CompraCupon compra in compras)
		{
			AddCompraFactura(compra, idFactura);
		}
		return result;
	}

	private void AddCompraFactura(CompraCupon compra, int idFactura)
	{
		SqlDataAccess.ExecuteNonQuery(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.InsertFacturaCanjeCupon", SqlDataAccessArgs.CreateWith("@ID_Factura", idFactura).And("@ID_CanjeCupon", compra.ID).Arguments);
	}
}
