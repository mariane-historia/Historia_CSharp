using System;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Weather
{
    public partial class Form1 : Form
    {
        private const string ApiKey = "b7896fc5c61e8c8aaadb190c4c0618a3"; 

        public Form1()
        {
            InitializeComponent();
            bunifuThinButton21.Click += new EventHandler(this.BunifuThinButton21_Click);
            this.Load += new EventHandler(this.Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bunifuCustomLabel2.Text = DateTime.Now.ToString("MMMM dd, yyyy");
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            getWeather(bunifuTextbox1.text.Trim(), labDetails, labTemp, labHumidity, labCloudiness, labWindSpeed, picIcon);
        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            getWeather(bunifuTextbox2.text.Trim(), labDetails2, labTemp2, labHumidity2, labCloudiness2, labWindSpeed2, picIcon2);
        }




        private void getWeather(string city, Bunifu.Framework.UI.BunifuCustomLabel labDetails, Bunifu.Framework.UI.BunifuCustomLabel labTemp, Bunifu.Framework.UI.BunifuCustomLabel labHumidity, Bunifu.Framework.UI.BunifuCustomLabel labCloudiness, Bunifu.Framework.UI.BunifuCustomLabel labWindSpeed, PictureBox picIcon)
        {
            using (WebClient web = new WebClient())
            {
                if (string.IsNullOrWhiteSpace(city))
                {
                    MessageBox.Show("Please enter a valid city name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", city, ApiKey);
                var json = web.DownloadString(url);
                WeatherInfo initialInfo = JsonConvert.DeserializeObject<WeatherInfo>(json);
                if (initialInfo == null || initialInfo.coord == null)
                {
                    MessageBox.Show("City not found. Please check the city name and try again.", "City Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                float lat = initialInfo.coord.lat;
                float lon = initialInfo.coord.lon;

                string forecastUrl = string.Format("https://api.openweathermap.org/data/2.5/forecast?lat={0}&lon={1}&appid={2}", lat, lon, ApiKey);

                try
                {
                    var forecastJson = web.DownloadString(forecastUrl);
                    WeatherInfo info = JsonConvert.DeserializeObject<WeatherInfo>(forecastJson);

                    if (info.list == null || info.list.Length == 0)
                    {
                        MessageBox.Show("No weather information found for the specified city.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    picIcon.ImageLocation = "https://openweathermap.org/img/w/" + info.list[0].weather[0].icon + ".png";
                    labDetails.Text = info.list[0].weather[0].description;
                    labTemp.Text = info.list[0].main.temp.ToString();
                    labWindSpeed.Text = info.list[0].wind.speed.ToString();
                    labHumidity.Text = info.list[0].main.humidity.ToString();
                    labCloudiness.Text = info.list[0].clouds.all.ToString();

                }
                catch (WebException ex)
                {
                    var response = ex.Response as HttpWebResponse;
                    if (response != null && response.StatusCode == HttpStatusCode.NotFound)
                    {
                        MessageBox.Show("City not found. Please check the city name and try again.", "City Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"Error: {ex.Message}", "API Request Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}


public class WeatherInfo
{
    public Coord coord { get; set; }
    public City city { get; set; }
    public List[] list { get; set; }
}
public class City
{
    public string name { get; set; }
    public Coord coord { get; set; }
    public string country { get; set; }
}

public class Coord
{
    public float lat { get; set; }
    public float lon { get; set; }
}

public class List
{
    public long dt { get; set; }
    public Main main { get; set; }
    public WeatherApp[] weather { get; set; }
    public Clouds clouds { get; set; }
    public Wind wind { get; set; }
    public Sys sys { get; set; }
    public string dt_txt { get; set; }
}

public class Main
{
    public float temp { get; set; }
    public float feels_like { get; set; }
    public float temp_min { get; set; }
    public float temp_max { get; set; }
    public int pressure { get; set; }
    public int humidity { get; set; }
}

    public class WeatherApp
    {
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    public class Clouds
    {
        public int all { get; set; }
    }

    public class Wind
    {
        public float speed { get; set; }
    }

    public class Sys
    {
        public string pod { get; set; }
    }
