Imports System.Data.OleDb
Imports System.Data


Public Class BD
	Dim CadenaConexion  As String
	Dim Tabla As DataTable
	Dim ConexionBD As OleDbConnection
	Dim AdaptadorBD As OleDbDataAdapter
	
	Public Sub New(base_datos As String)
		CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data source=" + base_datos
		ConexionBD = New OleDbConnection(CadenaConexion)
		AdaptadorBD = New OleDbDataAdapter()		
	End Sub
	
	Function ConsultaBD(sql As String) As DataTable
		Tabla = new DataTable
		
		ConexionBD.Open
		AdaptadorBD.SelectCommand = ConexionBD.CreateCommand
		AdaptadorBD.SelectCommand.CommandText = sql
		AdaptadorBD.SelectCommand.ExecuteNonQuery
		AdaptadorBD.Fill(Tabla)
		ConexionBD.Close
		return Tabla
	End Function
	
	sub InsertarBD(sql As String) 
		ConexionBD.Open
		
		AdaptadorBD.InsertCommand = ConexionBD.CreateCommand
		AdaptadorBD.InsertCommand.CommandText = sql
		AdaptadorBD.InsertCommand.ExecuteNonQuery
		ConexionBD.Close
	End sub	
	
	sub EliminarBD(sql As String) 
		ConexionBD.Open
		
		AdaptadorBD.DeleteCommand = ConexionBD.CreateCommand
		AdaptadorBD.DeleteCommand.CommandText = sql
		AdaptadorBD.DeleteCommand.ExecuteNonQuery
		ConexionBD.Close
	End sub	
	
	sub ActualizarBD(sql As String) 
		ConexionBD.Open
		
		AdaptadorBD.UpdateCommand = ConexionBD.CreateCommand
		AdaptadorBD.UpdateCommand.CommandText = sql
		AdaptadorBD.UpdateCommand.ExecuteNonQuery
		ConexionBD.Close
	End Sub	
	
	
End Class
