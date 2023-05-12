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
    public partial class Query5 : Form
    {
        OleDbConnection dbConnect = new OleDbConnection();
        string conStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\tsp ptoject\Database141.accdb";

        public Query5()
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
               "SELECT Sinoptik.Date_of_forecast FROM Forecast INNER JOIN Sinoptik ON Forecast.Forecast_number = Sinoptik.Forecast_number WHERE (((Forecast.Amount_of_precipitation)>0));";

            OleDbCommand cmd = new OleDbCommand(query, dbConnect);

            dbConnect.ConnectionString = conStr;
            dbConnect.Open();
            cmd.ExecuteNonQuery();
            dbConnect.Close();
            view(query);
        }
    }
}
