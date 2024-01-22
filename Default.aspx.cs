using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication11
{
    public partial class _Default : Page
    {
        public string conStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=rezervacije;Integrated Security=True";
        public const int min_sedista = 2;
        public const int max_sedista = 53;
        public List<int> rezervisana = new List<int>();
        private List<Button> mesta = new List<Button>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public bool rezervisano(int sedište)
        {
            foreach (int broj in rezervisana)
            {
                if (broj == sedište)
                {
                    return true;
                }
            }
            return false;
        }
        public void iscitaj()
        {
            string select = "select brojSedista from sedista";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = conStr;
            SqlCommand cmd = new SqlCommand(select, con);
            SqlDataReader reader;
            using(con)
            {
                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        rezervisana.Add(Int32.Parse(reader["brojSedista"].ToString()));
                    }
                    reader.Close();
                    con.Close();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
        private void kreirajMesta()
        {
            for (int i = min_sedista; i<=max_sedista;++i)
            {
                Button mesto = new Button();
                mesto.Text = i + "";
                mesta.Add(mesto);
            }
        }
        private void izaberiMesto(object o, EventArgs e)
        {
            Button b = (Button)o;
            TextBox1.Text = b.Text;
        }
        public void kreirajTabelu()
        {

        }
    }
}