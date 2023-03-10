using System.Data.SqlClient;
using System;
using Dapper;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pizza.API.Models;
{
    public static class BD
    {
        private static string _connectionString =  @"Server=SIATHERS\SQLEXPRESS;DataBase=tpFierro;Trusted_Connection=True";
        public static List<Marca> ObtenerMarcas()
        {
            List<Marca> lista = new List<Marca>();
            string sql = "SELECT * FROM Marcas";
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                lista = db.Query<Marca>(sql).AsList();
            }
            return lista;
        }

        public static Auto ObtenerAutos(int IdMarca)
        {
            Auto NuevoAuto = null;
            string sql = "SELECT * FROM Autos WHERE IdMarca = @pid";
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                NuevoAuto = db.QueryFirstOrDefault<Auto>(sql, new {pId = IdMarca});
            }
            return NuevoAuto;
        }

        public static List<Auto> ListarAutos(int Id){
        List<Auto> lista = new List<Auto>();
        string sql = "SELECT * FROM Autos where IdMarca = @pid";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            lista = db.Query<Auto>(sql, new {pid = Id}).ToList();
        }
        return lista;
        }

        public static void AgregarAutos(Auto Aut){
        string sql = "INSERT INTO Autos VALUES (@pIdAuto, @pIdMarca, @pMarca, @pModelo, @pPrecio, @pFechaCreacion, @pFoto1, @pFoto2, @pFoto3)";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            db.Execute(sql, new { pIdAuto=Aut.IdAuto, pIdMarca = Aut.IdMarca, pMarca = Aut.Marca, pModelo = Aut.Modelo, pPrecio = Aut.Precio, pFechaCreacion=Aut.FechaCreacion, pFoto1=Aut.Foto1, pFoto2=Aut.Foto2, pFoto3=Aut.Foto3 });
        }
        }

        public static void EliminarAuto(int IdAuto){
            string sql = "DELETE FROM Autos WHERE IdAuto = @pIdAuto";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                db.Execute(sql, new { pIdAuto = IdAuto });
            }
        }
    }
}


