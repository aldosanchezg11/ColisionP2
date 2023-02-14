using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColisionP2
{
    public class Ball
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Radius { get; set; }
        public float SpeedX { get; set; }
        public float SpeedY { get; set; }
        public float AccelerationY { get; set; }
        public float BounceFactor { get; set; }
        public List<Ball> balls = new List<Ball>
        {
            new Ball { X = 50, Y = 50, Radius = 10, SpeedX = 5, SpeedY = 5, AccelerationY = 0.2f, BounceFactor = 0.8f },
            new Ball { X = 100, Y = 100,Radius = 20, SpeedX = -3, SpeedY = 4, AccelerationY = 0.4f, BounceFactor = 0.6f },
            new Ball { X = 150, Y = 80, Radius = 15, SpeedX = 2, SpeedY = -6, AccelerationY = 0.6f, BounceFactor = 0.7f },
            new Ball { X = 200, Y = 150, Radius = 25, SpeedX = -6, SpeedY = -3, AccelerationY = 0.8f, BounceFactor = 0.5f },
            new Ball { X = 250, Y = 50, Radius = 12, SpeedX = 4, SpeedY = -5, AccelerationY = 0.2f, BounceFactor = 0.9f }
        };
    }

    
}
