using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WeatherForecast
{
    public partial class Query4 : Form
    {
        OleDbConnection dbConnect = new OleDbConnection();
        string conStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\tsp ptoject\Database141.accdb";
        
        public Query4()
        {
            InitializeComponent();
        }
        void view(string mySelect)
        {
            dbConnect.ConnectionString = conStr;
            dbConnect.Open();
            OleDbDataAdapter adapt = new OleDbDataAdapter(mySelect, dbConnect);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            dbConnect.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query =
               "SELECT Sinoptik.Name_Sinoptik FROM Forecast INNER JOIN Sinoptik ON Forecast.Forecast_number = Sinoptik.Forecast_number WHERE (((Forecast.Forecast_type)='24 hours' Or (Forecast.Forecast_type)='5 days'));";

            OleDbCommand cmd = new OleDbCommand(query, dbConnect);

            dbConnect.ConnectionString = conStr;
            dbConnect.Open();
            cmd.ExecuteNonQuery();
            dbConnect.Close();
            view(query);
        }
    }
}
