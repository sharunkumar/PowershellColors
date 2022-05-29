namespace PowershellColors
{
    public class ColorPool
    {
        private readonly List<uint> _colors;
        private int _index;

        public ColorPool()
        {
            _colors = new List<uint>();

            for (uint i = 0; i < 16; i++)
            {
                _colors.Add(i);
            }
        }

        public ColorPool(params uint[] excludedColors) : this()
        {
            _colors = _colors.Except(excludedColors).ToList();
        }

        public int Count() => _colors.Count;

        public uint GetNextColor()
        {
            if (_index >= _colors.Count)
            {
                _index = 0;
            }

            return _colors[_index++];
        }
    }
}