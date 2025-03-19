namespace VCustomVariables.Variables
{
    public class VInt
    {
        private int _value;

        public delegate void ValueChanged(int oldValue, int newValue);
        public event ValueChanged? OnValueChanged;

        public int Value
        {
            get => _value;
            set
            {
                int oldValue = _value;
                _value = value;
                OnValueChanged?.Invoke(oldValue, _value);
            }
        }
        public VInt(int value)
        {
            _value = value;
        }
        public static implicit operator VInt(int value)
        {
            return new VInt(value);
        }
        public static implicit operator int(VInt value)
        {
            return value.Value;
        }
        public override string ToString()
        {
            return _value.ToString();
        }
    }
}