namespace DesignPatterns.ConsoleApp.CreationalPatterns.Singleton
{
    public sealed class SingetonSample
    {
        private static SingetonSample _singetonSample;
        private static object _lockThis = new object();

        private SingetonSample()
        { }

        public static SingetonSample GetSingeton()
        {
            lock (_lockThis)
            { 
                if(_singetonSample == null)
                    _singetonSample = new SingetonSample();
            }

            return _singetonSample;
        }
    }
}
