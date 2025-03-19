namespace VCustomVariables.Variables
{
    public class VFloat
    {
        private float _value;

        public delegate void ValueChanged(float oldValue, float newValue);
        public event ValueChanged? OnValueChanged;

        public float Value
        {
            get => _value;
            set
            {
                if (value != _value)
                {
                    float oldValue = _value;
                    _value = value;
                    OnValueChanged?.Invoke(oldValue, _value);
                }
            }
        }
        public VFloat(float value)
        {
            _value = value;
        }
        public static implicit operator VFloat(float value)
        {
            return new VFloat(value);
        }
        public static implicit operator float(VFloat value)
        {
            return value.Value;
        }
        public override string ToString()
        {
            return _value.ToString();
        }
    }
}