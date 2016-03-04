using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var tv=new TV();

            var volumeUp=new VolumeUp();
            var volumeDown =new VolumeDown();

            var remoteController = new RemoteController(volumeUp);

            remoteController.ExecuteCommand(tv);
            remoteController.ExecuteCommand(tv);

            Console.WriteLine("Current volume is {0}", tv.Volume);


            remoteController.ChangeCommand(volumeDown);

            remoteController.ExecuteCommand(tv);

            Console.WriteLine("Current volume is {0}", tv.Volume);

        }
    }
}
