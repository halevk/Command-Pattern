namespace CommandPattern
{
    public class VolumeDown : ITvCommand
    {

        public void Execute(TV tv)
        {
            tv.VolumeDown();
        }
    }
}