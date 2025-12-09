using Microsoft.Data.SqlClient;
using ProductManager.Classes;
using System;
using System.Collections.Generic;
using System.Text;


namespace ProductManager;

/// <summary>
/// Provides helper methods to interact with the ProductManagerDb database.
/// </summary>
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

	/// <summary>
	/// Adds a new product to the database.
	/// </summary>
	/// <param name="p">The product to be added</param>
	/// <exception cref="SqlException">Throws if db is not available</exception>
	public static void AddProduct(Product p)
	{
		SqlConnection con = GetConnection();

		SqlCommand insertCmd = new()
		{
			Connection = con,
			// Skip the Id column as it's an identity column
			CommandText = """
				INSERT INTO Products (SalesPrice, Name)
				VALUES (@SalesPrice, @Name)
				"""
		};

		// Add parameters to prevent SQL injection attacks
		insertCmd.Parameters.AddWithValue("@SalesPrice", p.SalesPrice);
		insertCmd.Parameters.AddWithValue("@Name", p.Name);

		// open the connection
		con.Open();

		// execute the insert command
		int rows = insertCmd.ExecuteNonQuery();

		// close the connection
		con.Close();
	} // Implemented

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
	} // WIP

	public static void DeleteProduct(Product p) 
	{
		DeleteProduct(p.Id);
	} // Implemented

	/// <summary>
	/// Deletes a product from the database by its Id.
	/// </summary>
	/// <param name="productId">The id of the product we want to delete</param>
	/// <exception cref="SqlException">Throws if db is not available</exception>
	public static void DeleteProduct(int productId) 
	{
		SqlConnection con = GetConnection();

		SqlCommand delCmd = new()
		{
			Connection = con,
			CommandText = """
				DELETE FROM Products
				WHERE Id = @Id
				"""
		};
		// using a parameterized query to prevent SQL injection attacks
		delCmd.Parameters.AddWithValue("@Id", productId);

		con.Open();

		delCmd.ExecuteNonQuery();

		con.Close();
	} // Implemented
}
