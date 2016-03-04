namespace CommandPattern
{
    public class VolumeUp : ITvCommand
    {
        public void Execute(TV tv)
        {
            tv.VolumeUp();
        }
    }
}