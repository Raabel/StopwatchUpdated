namespace StopwatchUpdated
{
    public partial class Form1 : Form
    {
        int timeCs, timeSec, timeMin;
        bool isActive;
        

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ResetTime();
            isActive = false;
      
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            isActive=false;
            
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            isActive =false;
            ResetTime();
        }

        private void ResetTime()
        {
            timeCs = 0;
            timeSec = 0;
            timeMin = 0;
        }

        private void timer()
        {
            while(isActive)
            {
               
                timeCs++;
                
                if(timeCs >= 100)
                {
                    timeSec++;
                    timeCs = 0;

                    if (timeSec >= 60)
                    {
                        timeMin++;
                        timeSec = 0;
                    }
                }
                DrawTime();
            }

           
        }

        private void DrawTime()
        {
            lblCs.Text = String.Format("{0:00}", timeCs);
            lblSec.Text = String.Format("{0:00}", timeSec);
            lblMin.Text = String.Format("{0:00}", timeMin);
        }

        private void lblMin_Click(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            isActive = true;
            Thread timerThread = new Thread(timer);

            timerThread.IsBackground = true;
            
            timerThread.Start();
   
        }
    }
}