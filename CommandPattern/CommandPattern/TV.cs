using System;

namespace CommandPattern
{
    public class TV
    {
        private int _volume;

        public int Volume
        {
            get { return _volume;}
        }

        public TV()
        {
            _volume = 12;
        }


        public void VolumeUp()
        {
            if (_volume < 20)
                _volume += 1;
            else
            {
                Console.WriteLine("Volume reacheed max level {0}", _volume);
            }
        }

        public void VolumeDown()
        {
            if (_volume > 0)
                _volume -= 1;
            else
            {
                Console.WriteLine("Volume muted");
            }
        }



    }
}