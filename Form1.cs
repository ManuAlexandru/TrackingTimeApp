
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Cronometru4
{
    public partial class Form : System.Windows.Forms.Form
    {
        SqlConnection sqlConn = new SqlConnection();//cu ajutorul sqlConn creez conexiunea si o deschid/inchid
        SqlCommand sqlCmd = new SqlCommand();//Ma folosesc de sqlCmd pentru comenzi
        DataTable sqlDt = new DataTable();//stochez datele din Bd in forma tabelara
        string sqlQuerry;
        SqlDataReader sqlRd;//Cu sqlRd citesc datele din Db
        string dataSource = "DESKTOP-3QDGK42\\SQLEXPRESS";//Server ul
        string initialCatalog = "Timer";//Baza de date ul.
        Boolean integratedSecurity=true;//conectarea la Microsoft Sql Server
       public Color culoareButoane;
        public Color culoareBacKground;
        string date = DateTime.UtcNow.ToString("MM-dd-yyyy");
        public int designTimer = Properties.Settings.Default.AppTimerSetting;//Pentru UnitTest
        public Color designBackground = Properties.Settings.Default.AppColorBackground1;
        public Color designBackgroundBtn = Properties.Settings.Default.AppColor;
       
                 

        private FormSettings formSettings;
        

        public int secondsCount = 0;//numarul de secunde
        public int secondsCountPause=0;//numarul de secunde de pauza
        Timer disTmr = new Timer();// Declar global Timer ul
        Timer disTmrPauza = new Timer();//Timer ul pentru pauza
        public Form()
        {
            InitializeComponent();
            panouAfisare.Visible = false;
           
            UploadData();
           




        }

        

        private void UploadData()
        {
            sqlConn.ConnectionString = "Data Source=" + dataSource + "; Initial Catalog=" + initialCatalog + "; Integrated Security=" + integratedSecurity + ";";
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
          sqlCmd.CommandText = "SELECT * FROM timer2";
            sqlRd = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlRd);
            sqlRd.Close();
            sqlConn.Close();
            afisareDate.DataSource = sqlDt;



        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void disTmr_Tick(object sender, EventArgs e)//Eventul prin care numar secundele si le transpun in format hh:mm:ss
        {
            if (Properties.Settings.Default.AppTimerSetting == 1)
            {
                secondsCount++;
                TimeSpan time = new TimeSpan(0, 0, secondsCount - secondsCountPause);
                // secondsBlock.Text = time.ToString() + " secunde";
                afisareSecunde.Text = time.ToString();
            }
            else
            {
                secondsCount++;
                TimeSpan time = new TimeSpan(0, 0, secondsCount);
                //secondsBlock.Text = time.ToString() + " secunde";
                afisareSecunde.Text = time.ToString();
            }

        }
        public void disTmr_TickPauza(object sender, EventArgs e)//Eventul prin care numar secundele si le transpun in format hh:mm:ss
        {if(Properties.Settings.Default.AppTimerSetting == 1)
            {
                secondsCountPause++;
            }
            else

            {
                secondsCountPause++;
                TimeSpan timePause = new TimeSpan(0, 0, secondsCountPause);
                //secondsPause.Text = timePause.ToString() + " secunde";
                afisareSecundePauza.Text = timePause.ToString();

            }
           

        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            if (secondsCount > 0)
                MessageBox.Show("Hooo!!!!");

            else


            {
                if (Properties.Settings.Default.AppTimerSetting == 1)
                {
                    panouAfisare.Visible = true;
                    disTmr = new Timer();//Creez o noua instanta a obiectului
                    disTmr.Tick += new EventHandler(disTmr_Tick);
                    disTmr.Interval = 1000;
                    disTmr.Start();
                    afisareSecundePauza.Visible = false;
                }
                else
                {
                    panouAfisare.Visible = true;
                    disTmr = new Timer();//Creez o noua instanta a obiectului
                    disTmr.Tick += new EventHandler(disTmr_Tick);
                    disTmr.Interval = 1000;
                    disTmr.Start();
                    afisareSecundePauza.Visible = true;


                }
                if (btnPauza.Text == "O_Pauza")
                {
                    btnPauza.Text = "S_Pauza";
                    disTmrPauza.Stop();

                }
                secondsCountPause = 0;
            }
            
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            disTmr.Stop();
           
           



            sqlConn.ConnectionString = "Data Source=" + dataSource + "; Initial Catalog=" + initialCatalog + "; Integrated Security=" + integratedSecurity + ";";
                secondsCount = secondsCount - secondsCountPause;

            try
            {
                sqlConn.Open();
                if (secondsCount < 0)
                    MessageBox.Show("Uups....A aparut o eroare!");

                sqlQuerry = "insert into timer2 (Timp,Data,Pauza)"+
                    "values('"+ secondsCount+"','"+ date + "','"+ secondsCountPause +"')";
                sqlCmd = new SqlCommand(sqlQuerry,sqlConn);
                sqlRd = sqlCmd.ExecuteReader();
                sqlConn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            
            
            }
            finally
            {
                sqlConn.Close();

            }
            UploadData();
            secondsCount = 0;
            secondsCountPause = 0;
            TimeSpan timePause = new TimeSpan(0, 0, 0);
            afisareSecundePauza.Text = timePause.ToString();
            panouAfisare.Visible = false;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
           FormaEmail  formaEmail = new FormaEmail();
            formaEmail.Show();
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnPauza.Text == "S_Pauza")
            {
                btnPauza.Text = "O_Pauza";
                   disTmrPauza = new Timer();
                disTmrPauza.Start();
                disTmrPauza.Tick += new EventHandler(disTmr_TickPauza);
                disTmrPauza.Interval = 1000;
            }
            else
            {
                btnPauza.Text = "S_Pauza";
                disTmrPauza.Stop();
                

            }

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
             formSettings = new FormSettings(this);
            formSettings.Visible = true;
        }

       
       
       
        public void SetareCuloare0()
        {





           
                btnStart.BackColor = culoareButoane;
            btnAdmin.BackColor = culoareButoane;
            btnPauza.BackColor = culoareButoane;
            btnSettings.BackColor = culoareButoane;
            btnStop.BackColor = culoareButoane;
            panel1.BackColor = culoareBacKground;

            this.Update();



                
            




        }

        private void Form_Load(object sender, EventArgs e)
        {
            culoareButoane = Properties.Settings.Default.AppColor;
            culoareBacKground = Properties.Settings.Default.AppColorBackground1;
            SetareCuloare0();
        }

       
    }
}
