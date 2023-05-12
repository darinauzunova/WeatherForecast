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
    public partial class Form1 : Form
    {
        Connection connection = new Connection();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ForecasterClass forecasterclass = new ForecasterClass();

            forecasterclass.ID = textBox1.Text;
            forecasterclass.Name_Sinoptik = textBox2.Text;
            forecasterclass.Date_of_forecast = dateTimePicker1.Text;
            forecasterclass.Forecast_number = textBox4.Text;

            connection.InsertForecaster(forecasterclass);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ForecasterClass forecasterclass = new ForecasterClass();

            forecasterclass.ID = textBox1.Text;

            connection.DeleteForecaster(forecasterclass);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ForecasterClass forecasterclass = new ForecasterClass();

            forecasterclass.ID = textBox1.Text;
            forecasterclass.Name_Sinoptik = textBox2.Text;

            connection.UpdateForecaster(forecasterclass);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ForecastClass forecastclass = new ForecastClass();

            forecastclass.Forecast_number = textBox4.Text;
            forecastclass.City = textBox5.Text;
            forecastclass.Forecast_type = comboBox1.SelectedItem.ToString();
            forecastclass.Forecast = textBox6.Text;
            forecastclass.Max_temp = textBox7.Text;
            forecastclass.Min_temp = textBox8.Text;
            forecastclass.Wind = textBox9.Text;
            forecastclass.Chance_of_rain = textBox10.Text;
            forecastclass.Amount_of_precipitation = textBox11.Text;
            forecastclass.Chance_of_thunderstorm = textBox12.Text;
            forecastclass.Cloud_coverage = textBox13.Text;
            forecastclass.UV_index = textBox14.Text;
            forecastclass.Sunrise = textBox15.Text;
            forecastclass.Sunset = textBox16.Text;
            forecastclass.Day_length = textBox17.Text;
            forecastclass.Moon_phase = textBox18.Text;
            forecastclass.Zodiac = textBox19.Text;
            forecastclass.Moon_day = textBox20.Text;

            connection.InsertForecast(forecastclass);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ForecastClass forecastclass = new ForecastClass();

            forecastclass.Forecast_number = textBox4.Text;

            connection.DeleteForecast(forecastclass);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ForecastClass forecastclass = new ForecastClass();

            forecastclass.Forecast_number = textBox4.Text;
            forecastclass.City = textBox5.Text;

            connection.UpdateForecast(forecastclass);
        }

        private void temp0ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Query1 query1 = new Query1();
            query1.ShowDialog();
        }

        private void temp30ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Query2 query2 = new Query2();
            query2.ShowDialog();
        }

        private void minMaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Query3 query3 = new Query3();
            query3.ShowDialog();
        }

        private void forecastersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Query4 query4 = new Query4();
            query4.ShowDialog();
        }

        private void rainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Query5 query5 = new Query5();
            query5.ShowDialog();
        }

        private void queriesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
