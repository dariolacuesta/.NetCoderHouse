namespace Constants
{
    public static class ConnectionString
    {
        public const string connString = @"Server=DESKTOP-ULKIVTS;DataBase=SistemaGestion;Trusted_Connection=True;";
    }

    #region ProductQuerys
    public static class ProductQuerys
    {
        public const string querySelect = "SELECT Id,Descripcion,Costo,PrecioVenta,Stock,IdUsuario FROM Producto;";
        public const string querySelectWhereId = "SELECT Id,Descripcion,Costo,PrecioVenta,Stock,IdUsuario FROM Producto where Id=@IdProducto;";
        public const string queryCreate = "INSERT INTO Producto (Descripcion,Costo,PrecioVenta,Stock,IdUsuario) VALUES (@Descripcion,@Costo,@PrecioVenta,@Stock,@IdUsuario);";
        public const string queryDelete = "DELETE FROM Producto WHERE Id = @Id;";
        public const string queryModify = "UPDATE Producto SET Descripcion = @Descripcion ,Costo = @Costo, PrecioVenta = @PrecioVenta,Stock = @Stock, IdUsuario=@IdUsuario WHERE Id = @Id;";
    }
    #endregion

    #region UserQuerys
    public static class UserQuerys
    {
        public const string querySelect = "SELECT Id,Nombre,Apellido,NombreUsuario,Contraseña,Mail FROM Usuario;";
        public const string querySelectWhereId = "SELECT Id,Nombre,Apellido,NombreUsuario,Contraseña,Mail FROM Producto where Id=@IdUsuario;";
        public const string queryCreate = "INSERT INTO Usuario (Nombre,Apellido,NombreUsuario,Contraseña,Mail) VALUES (@Nombre,@Apellido,@NombreUsuario,@Contraseña,@Mail);";
        public const string queryDelete = "DELETE FROM Usuario WHERE Id = @Id;";
        public const string queryModify = " UPDATE Usuario SET Nombre = @Nombre ,Apellido = @Apellido, NombreUsuario = @NombreUsuario,Contraseña = @Contraseña, Mail=@Mail WHERE Id = @Id;";
    }
    #endregion

    #region SalesQuerys
    public static class SalesQuerys
    {
        public const string querySelect = "SELECT Id,Comentarios,IdUsuario FROM Venta;";
        public const string querySelectWhereId = "SELECT Id,Comentarios,IdUsuario FROM Venta where Id=@IdVenta;";
        public const string queryCreate = "INSERT INTO Venta (Comentarios,IdUsuario) VALUES (@Comentarios,@IdVenta);";
        public const string queryDelete = "DELETE FROM Venta WHERE Id = @Id;";
        public const string queryModify = "UPDATE Venta SET Comentarios = @Comentarios , IdUsuario=@IdUsuario WHERE Id = @Id;";
    }
    #endregion
    #region ProductSalesQuerys
    public static class ProductSalesQuerys
    {
        public const string querySelect = "SELECT Id,IdProducto,Stock,IdVenta FROM ProductoVendido;";
        public const string querySelectWhereId = "SELECT Id,IdProducto,Stock,IdVenta FROM ProductoVendido where Id=@IdProductoVendido;";
        public const string queryCreate = "INSERT INTO ProductoVendido (IdProducto,Stock,IdVenta) VALUES (@IdProducto,@Stock,@IdVenta);";
        public const string queryDelete = "DELETE FROM ProductoVendido WHERE Id = @Id;";
        public const string queryModify = "UPDATE ProductoVendido SET IdProducto = @IdProducto , Stock=@Stock, IdVenta=@IdVenta WHERE Id = @Id;";
    }
    #endregion
}