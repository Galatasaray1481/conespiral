using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Helpers;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Con_Spiral_WFA
{
    public partial class Form1 : Form
    {
        float mMidX = 0.0f, mMidY = 0.0f, mStartR = 0.0f, mMaxH = 0.0f, mMinR = 0.0f, mS = 0.0f, mWS = 0.0f, mdR = 0.0f;

        List<Point3D> list;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            list = new List<Point3D>();
            CalcSpiral();
            //picSpiral.Paint += new PaintEventHandler(this.picSpiral_Paint);
            //picSpiral.Refresh();
        }
        private void CalcSpiral()
        {

            mMidX = float.Parse(xMittelpunkt.Text); // x-koordinate Mittelpunkt
            mMidY = float.Parse(yMittelpunkt.Text); // y-koordinate Mittelpunkt
            mStartR = float.Parse(startRadius.Text); // Startradius
            mMaxH = float.Parse(maxH.Text); // maximale Höhe
            mMinR = float.Parse(minR.Text); // minimaler Radius
            mS = float.Parse(S.Text); // Steigung

            addupdateConfig(mMidX, mMidY, mStartR, mMaxH, mMinR, mS);

            // calc first point 
            float R = 0.0f;
            float H = 1.0f;

            float x = 0.0f;
            float y = 0.0f;
            float z = 5.0f;
            int i = 0;
            const float WS = (float)(20 * Math.PI / 180);
            const float deltaR = 1.0f;

            // erster Punkt
            R = mStartR;
            x = mMidX + R * (float)Math.Cos(0); // Winkel 0 als W
            y = mMidY + R * (float)Math.Sin(0);
            list.Add(new Point3D(x, y, z));

            while (!(R <= mMinR))
            {
                i++;
                 

                R = mStartR - i * deltaR;
                x = mMidX + R * (float)Math.Cos(WS);
                y = mMidY + R * (float)Math.Sin(WS);
                z += 0.25f;
                list.Add(new Point3D(x, y, z));

            }
            loadforlivechart();
        }

        private void loadforlivechart()
        {
            int i;
            int count = list.Count;
            ChartValues<ObservablePoint> List1Points = new ChartValues<ObservablePoint>();
            for (i = 0; i < count - 1; i++)
            {
                List1Points.Add(new ObservablePoint
                {
                    X = list[i].X,
                    Y = list[i].Y
                });
            }
            cartesianChart1.Series = new LiveCharts.SeriesCollection
                {
                    new LineSeries
                    {
                        Values = List1Points,
                        PointGeometrySize = 15
                    }
                };

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Point3D createCSV = new Point3D();
            if (list != null && list.Count != 0)
            {
                createCSV.ToCsvString(filenameCSV.Text, list);
            }
            else {
                MessageBox.Show("Bitte vervollständigen sie ihre Eingaben und plotten sie vorher ihre Punkte.");
            }
        }

        // um nur den letzten eingegebenen Wert als value zu speichern
        private void addupdateConfig(double midx, double midy, double startr, double maxh, double minr, double s)
        {

            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;

                // Mittelpunkt X
                if (settings["midx"] == null)
                {
                    settings.Add("midx", midx.ToString());
                }
                else
                {
                    settings["midx"].Value = midx.ToString();
                }

                // Mittelpunkt Y
                if (settings["midy"] == null)
                {
                    settings.Add("midy", midy.ToString());
                }
                else
                {
                    settings["midy"].Value = midy.ToString();
                }

                // Startradius
                if (settings["startr"] == null)
                {
                    settings.Add("startr", startr.ToString());
                }
                else
                {
                    settings["startr"].Value = startr.ToString();
                }

                // Maximale Hoehe H
                if (settings["maxh"] == null)
                {
                    settings.Add("maxh", maxh.ToString());
                }
                else
                {
                    settings["maxh"].Value = maxh.ToString();
                }

                // Minimum Radius
                if (settings["minr"] == null)
                {
                    settings.Add("minr", minr.ToString());
                }
                else
                {
                    settings["minr"].Value = minr.ToString();
                }

                // Steigung s
                if (settings["s"] == null)
                {
                    settings.Add("s", s.ToString());
                }
                else
                {
                    settings["s"].Value = s.ToString();
                }

                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }

        }

        // um jegliche Werte als value zu speichern
        private void writeinConfig(double midx, double midy, double startr, double maxh, double minr, double s)
        {

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Add("midx", midx.ToString());
            config.AppSettings.Settings.Add("midy", midy.ToString());
            config.AppSettings.Settings.Add("startr", startr.ToString());
            config.AppSettings.Settings.Add("maxh", maxh.ToString());
            config.AppSettings.Settings.Add("minr", minr.ToString());
            config.AppSettings.Settings.Add("s", s.ToString());
            config.Save(ConfigurationSaveMode.Minimal);
        }
    }
}
