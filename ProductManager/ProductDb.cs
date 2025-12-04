using Microsoft.Data.SqlClient;
using ProductManager.Classes;
using System;
using System.Collections.Generic;
using System.Text;


namespace ProductManager;

public static class ProductDb
{
	/// <summary>
	/// Gets a connection object for the ProductManagerDb.
	/// The connection needs to be opened and closed after it's used.
	/// </summary>

	// Raw string literal - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/raw-string
	public static SqlConnection GetConnection()
	{
		return new SqlConnection("Data Source=localhost;Initial Catalog=ProductManagerDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30");
	}

	/// <summary>
	/// this will return all products from the database
	/// sorted in ascending order by Name.
	/// </summary>
	public static List<Product> GetAllProducts()
	{
		List<Product> products = new();

		// Use using to ensure the connection is closed/disposed
		using SqlConnection con = GetConnection();
		using SqlCommand selcmd = con.CreateCommand();
		{
			selcmd.CommandText = """
				SELECT Id, SalesPrice, Name 
				FROM Products 
				ORDER BY Name ASC
				""";

			con.Open();

			using SqlDataReader reader = selcmd.ExecuteReader();

			while (reader.Read())
			{
				Product p = new Product
				{
					Id = Convert.ToInt32(reader["Id"]),
					SalesPrice = Convert.ToDouble(reader["SalesPrice"]),
					Name = Convert.ToString(reader["Name"])
				};
				products.Add(p);
			}
		}

		return products;
	} // Work In Progress

	public static void AddProduct(Product p)
	{
		if (p is null) throw new ArgumentNullException(nameof(p));

		using SqlConnection con = GetConnection();
		using SqlCommand insertCmd = con.CreateCommand();
		insertCmd.CommandText = """
			INSERT INTO Products (SalesPrice, Name) 
			VALUES (@SalesPrice, @Name)
			""";
		insertCmd.Parameters.AddWithValue("@SalesPrice", p.SalesPrice);
		insertCmd.Parameters.AddWithValue("@Name", p.Name);

		con.Open();
		insertCmd.ExecuteNonQuery();
	} // Complete

	public static void UpdateProduct(Product p) 
	{
		if (p is null) throw new ArgumentNullException(nameof(p));
		if (p.Id <= 0) throw new ArgumentException("Product must have a valid Id to update.", nameof(p));

		using SqlConnection con = GetConnection();
		using SqlCommand updateCmd = con.CreateCommand();
		updateCmd.CommandText = """
			UPDATE Products
			SET SalesPrice = @SalesPrice,
				Name = @Name
			WHERE Id = @Id
			""";
		updateCmd.Parameters.AddWithValue("@SalesPrice", p.SalesPrice);
		updateCmd.Parameters.AddWithValue("@Name", p.Name);
		updateCmd.Parameters.AddWithValue("@Id", p.Id);

		con.Open();
		updateCmd.ExecuteNonQuery();
	} // Implemented

	public static void DeleteProduct(Product p) 
	{
		throw new NotImplementedException();
	}

	public static void DeleteProduct(int productId) 
	{
		if (productId <= 0) throw new ArgumentException("productId must be greater than zero", nameof(productId));

		using SqlConnection con = GetConnection();
		using SqlCommand deleteCmd = con.CreateCommand();
		deleteCmd.CommandText = """
			DELETE FROM Products
			WHERE Id = @Id
			""";
		deleteCmd.Parameters.AddWithValue("@Id", productId);

		con.Open();
		deleteCmd.ExecuteNonQuery();
	} // Implemented
}
