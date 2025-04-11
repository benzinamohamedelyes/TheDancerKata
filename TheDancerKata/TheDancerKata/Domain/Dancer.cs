namespace TheDancerKata.Domain
{
    public class Dancer
    {
        private int _position;

        private void Init()
        {
            _position = 0;
        }
        public Dancer()
        {
            Init();
        }
        public int GetPositionAt(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return -1;
            Init();
            int lastStep = -2;
            int penultimateStep = 1;
            _position = -1;
            for (int i = 3; i <= n; i++)
            {
                var step = lastStep - penultimateStep;
                _position += step;
                penultimateStep = lastStep;
                lastStep = step;
            }
            return _position;
        }
    }
}
