

using System;

namespace Race
{
    public class Car
    {
        private string model_;
        private int speed_;
        public void SetModel(string model)
        {
            model_ = model;
        }
        public string GetModel()
        {
            return model_;
        }
        public void SetSpeed(int speed)
        {
            speed_ = speed;
        }
        public int GetSpeed()
        {
            return speed_;
        }
    }
}
