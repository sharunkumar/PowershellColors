namespace PowershellColors
{
    public class MappedColorPool<T> : ColorPool where T : notnull
    {
        private readonly Dictionary<T, uint> _mapping;

        public MappedColorPool() : base()
        {
            _mapping = new();
        }

        public MappedColorPool(params uint[] excludedColors) : base(excludedColors)
        {
            _mapping = new();
        }

        public uint GetColor(T key)
        {
            if (!_mapping.ContainsKey(key))
                _mapping.Add(key, this.GetNextColor());

            return _mapping[key];
        }

        public uint this[T key]
        {
            get => GetColor(key);
        }

        public void FlushMappings()
        {
            _mapping.Clear();
        }
    }
}
