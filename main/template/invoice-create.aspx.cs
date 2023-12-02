using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI.WebControls;

namespace inteview_task.main.template
{
	partial class invoice_create : System.Web.UI.Page
	{

		protected void Page_Load(object sender, EventArgs e)
		{
			
			if (IsPostBack)
			{
				var itemName = Request.QueryString["itemName1"].ToString();
				var itemQuntity = Request.QueryString["qun1"].ToString();
				var unitPrice = Request.QueryString["unitp1"].ToString();
				var total = Request.QueryString["totalRowPrice"].ToString();


				try
				{

					SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegiConnectionString"].ConnectionString);
					conn.Open();
					string insertQuery = "insert into interviewDB(itemName1,qun1,unitp1,totalRowPrice,)values (@itemName,@itemQuntity,@unitPrice,@total)";
					SqlCommand cmd = new SqlCommand(insertQuery, conn);
					cmd.Parameters.AddWithValue("@itemName", itemName);
					cmd.Parameters.AddWithValue("@itemQuntity", itemQuntity);
					cmd.Parameters.AddWithValue("@unitPrice", unitPrice);
					cmd.Parameters.AddWithValue("@department", total);
					cmd.ExecuteNonQuery();

					Response.Write("Saved Successfully!!!thank you");

					conn.Close();

				}
				catch (Exception ex)
				{
					Response.Write("error" + ex.ToString());
				}



			}
		}
	
	
	
	}
	}