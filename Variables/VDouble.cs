namespace VCustomVariables.Variables
{
    public class VDouble
    {
        private double _value;

        public delegate void ValueChanged(double oldValue, double newValue);
        public event ValueChanged? OnValueChanged;

        public double Value
        {
            get => _value;
            set
            {
                if (value != _value)
                {
                    double oldValue = _value;
                    _value = value;
                    OnValueChanged?.Invoke(oldValue, _value);
                }
            }
        }
        public VDouble(double value)
        {
            _value = value;
        }
        public static implicit operator VDouble(double value)
        {
            return new VDouble(value);
        }
        public static implicit operator double(VDouble value)
        {
            return value.Value;
        }
        public override string ToString()
        {
            return _value.ToString();
        }
    }
}