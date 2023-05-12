using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using WeatherForecast;

namespace WeatherForecast
{
    class Connection
    {
        OleDbConnection connect;
        OleDbCommand command;

        private void ConnectionTo()
        {
            connect = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\tsp ptoject\Database141.accdb");
            command = connect.CreateCommand();
        }

        public Connection()
        {
            ConnectionTo();
        }

        public void InsertForecaster(ForecasterClass forecaster)
        {
            try
            {
                command.CommandText =
                "Insert into Sinoptik(Name_Sinoptik, Date_of_forecast, Forecast_number) Values ('" +
                forecaster.Name_Sinoptik + "','" + forecaster.Date_of_forecast + "'," + forecaster.Forecast_number + ")";

                command.CommandType = System.Data.CommandType.Text;
                connect.Open();
                command.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show("Added Forecaster.");
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }

        public void InsertForecast(ForecastClass forecast)
        {
            try
            {
                command.CommandText =
                "Insert into Forecast(City, Forecast_type, Forecast, Max_temp, Min_temp, Wind, Chance_of_rain, Amount_of_precipitation, Chance_of_thunderstorm, Cloud_coverage, UV_index, Sunrise, Sunset, Day_length, Moon_phase, Zodiac, Moon_day) Values ('" +
                forecast.City + "','" + forecast.Forecast_type + "','" +
                forecast.Forecast + "'," + forecast.Max_temp + "," +
                forecast.Min_temp + "," + forecast.Wind + "," +
                forecast.Chance_of_rain + "," + forecast.Amount_of_precipitation + "," +
                forecast.Chance_of_thunderstorm + "," + forecast.Cloud_coverage + "," +
                forecast.UV_index + ",'" + forecast.Sunrise + "','" +
                forecast.Sunset + "','" + forecast.Day_length + "','" +
                forecast.Moon_phase + "','" + forecast.Zodiac + "','" +
                forecast.Moon_day + "')";

                command.CommandType = System.Data.CommandType.Text;
                connect.Open();
                command.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show("Added forecast");
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }
        public void UpdateForecaster(ForecasterClass forecaster)
        {
            try
            {
                command.CommandText =
                "UPDATE Sinoptik SET Name_Sinoptik = '" + forecaster.Name_Sinoptik + "' WHERE ID=" + forecaster.ID;

                command.CommandType = System.Data.CommandType.Text;
                connect.Open();
                command.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show("Updated Forecaster.");
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }
        public void UpdateForecast(ForecastClass forecast)
        {
            try
            {
                command.CommandText =
                "UPDATE Forecast SET City = '" + forecast.City + "' WHERE Forecast_number=" + forecast.Forecast_number;
                command.CommandType = System.Data.CommandType.Text;
                connect.Open();
                command.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show("Updated forecast");
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }
        public void DeleteForecaster(ForecasterClass forecaster)
        {
            try
            {
                command.CommandText =
                "DELETE FROM Sinoptik WHERE ID=" + forecaster.ID;
                command.CommandType = System.Data.CommandType.Text;
                connect.Open();
                command.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show("Deleted Forecaster.");
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }
        public void DeleteForecast(ForecastClass forecast)
        {
            try
            {
                command.CommandText =
                "DELETE FROM Forecast WHERE Forecast_number=" + forecast.Forecast_number;
                command.CommandType = System.Data.CommandType.Text;
                connect.Open();
                command.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show("Deleted forecast");
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }

    }
}
