namespace ColisionP2
{
    public partial class Form1 : Form
    {
        // Ball properties
        //float ballX = 50f;
        //float ballY = 50f;
        //float ballRadius = 10f;
        //float ballSpeedX = 5f;
        //float ballSpeedY = 5f;
        //float ballAccelerationY = 0.2f;
        //float ballBounceFactor = 0.8f;

        // Rectangular area properties
        float areaX = 0f;
        float areaY = 0f;
        float areaWidth = 400f;
        float areaHeight = 400f;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 10;
            timer.Tick += UpdateBallPosition;
            timer.Start();
        }

        void UpdateBallPosition(object sender, EventArgs e)
        {
            foreach (Ball ball in balls)
            {
                ball.X += ball.SpeedX;
                ball.Y += ball.SpeedY; 
                if (ball.X - ball.Radius < areaX || ball.X + ball.Radius > areaX + areaWidth)
                    {
                        ball.SpeedX = -ball.SpeedX;
                    }
                if (ball.Y - ball.Radius < areaY)
                {
                    ball.SpeedY = -ball.SpeedY * ball.BounceFactor;
                    ball.Y = areaY + ball.Radius;
                }
                else if (ball.Y + ball.Radius > areaY + areaHeight)
                {
                    ball.SpeedY = -ball.SpeedY * ball.BounceFactor;
                    ball.Y = areaY + areaHeight - ball.Radius;
                }
                // Update the ball's Y speed based on gravity
                ball.SpeedY += ball.AccelerationY;            
            }
            Refresh();   
        }

        // Override the OnPaint method to draw the ball on the screen
        protected override void OnPaint(PaintEventArgs e)
        {
            foreach (Ball ball in balls)
            {
                base.OnPaint(e);

                Graphics graphics = e.Graphics; 
                graphics.FillEllipse(Brushes.Red, ball.X - ball.Radius, ball.Y - ball.Radius, ball.Radius * 2, ball.Radius * 2);
            }
            
        }
    }
}