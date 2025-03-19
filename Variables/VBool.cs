namespace VCustomVariables.Variables
{
    public class VBool
    {
        private bool _value;

        public delegate void ValueChanged(bool oldValue, bool newValue);
        public event ValueChanged? OnValueChanged;

        public bool Value
        {
            get => _value;
            set
            {
                if (value != _value)
                {
                    bool oldValue = _value;
                    _value = value;
                    OnValueChanged?.Invoke(oldValue, _value);
                }
            }
        }
        public VBool(bool value)
        {
            _value = value;
        }
        public static implicit operator VBool(bool value)
        {
            return new VBool(value);
        }
        public static implicit operator bool(VBool value)
        {
            return value.Value;
        }
        public override string ToString()
        {
            return _value.ToString();
        }
    }
}