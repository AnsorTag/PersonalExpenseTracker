using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace PersonalExpenseTracker
{
    internal class DatabaseHelper
    {
        // Connection string to the database (replace with your actual connection string)
        private static string connectionString = "Server=(LocalDb)\\MSSQLLocalDB;Database=ExpenseTrackerDB;Integrated Security=True;";

        // Add a new expense to the database
        public static void AddExpense(string description, string category, decimal amount, DateTime date)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Expenses (Description, Category, Amount, Date) VALUES (@Description, @Category, @Amount, @Date)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@Category", category);
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.Parameters.AddWithValue("@Date", date);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Log the error or display a user-friendly message
                throw new Exception("Error adding expense: " + ex.Message);
            }
        }

        // Update an existing expense in the database
        public static void UpdateExpense(int expenseId, string description, string category, decimal amount, DateTime date)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Expenses SET Description = @Description, Category = @Category, Amount = @Amount, Date = @Date WHERE ExpenseID = @ExpenseID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@Category", category);
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.Parameters.AddWithValue("@Date", date);
                    cmd.Parameters.AddWithValue("@ExpenseID", expenseId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating expense: " + ex.Message);
            }
        }

        // Delete an expense from the database
        public static void DeleteExpense(int expenseId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Expenses WHERE ExpenseID = @ExpenseID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ExpenseID", expenseId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting expense: " + ex.Message);
            }
        }

        // Retrieve all expenses from the database
        public static DataTable GetExpenses()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Expenses";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving expenses: " + ex.Message);
            }
            return dt;
        }

        // Retrieve a single expense by its ID
        public static Expense GetExpenseById(int expenseId)
        {
            Expense expense = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Expenses WHERE ExpenseID = @ExpenseID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ExpenseID", expenseId);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        expense = new Expense
                        {
                            ExpenseID = reader.GetInt32(reader.GetOrdinal("ExpenseID")),
                            Description = reader.GetString(reader.GetOrdinal("Description")),
                            Category = reader.GetString(reader.GetOrdinal("Category")),
                            Amount = reader.GetDecimal(reader.GetOrdinal("Amount")),
                            Date = reader.GetDateTime(reader.GetOrdinal("Date"))
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving expense by ID: " + ex.Message);
            }
            return expense;
        }

        // Search expenses based on filters
        public static DataTable SearchExpenses(string description, string category, DateTime startDate, DateTime endDate)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Expenses WHERE " +
                                  "(Description LIKE @Description OR @Description IS NULL) AND " +
                                  "(Category = @Category OR @Category IS NULL) AND " +
                                  "(Date BETWEEN @StartDate AND @EndDate)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Add parameters (handle null values)
                    cmd.Parameters.AddWithValue("@Description", string.IsNullOrEmpty(description) ? (object)DBNull.Value : "%" + description + "%");
                    cmd.Parameters.AddWithValue("@Category", string.IsNullOrEmpty(category) ? (object)DBNull.Value : category);
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error searching expenses: " + ex.Message);
            }
            return dt;
        }

        // Get a summary of expenses grouped by category
        public static DataTable GetExpenseSummary()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT Category, SUM(Amount) AS TotalAmount FROM Expenses GROUP BY Category";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving expense summary: " + ex.Message);
            }
            return dt;
        }
    }
}