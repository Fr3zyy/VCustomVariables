namespace VCustomVariables.Variables
{
    public class VString
    {
        private string _value;

        public delegate void ValueChanged(string oldValue, string newValue);
        public event ValueChanged? OnValueChanged;

        public string Value
        {
            get => _value;
            set
            {
                string oldValue = _value;
                _value = value;
                OnValueChanged?.Invoke(oldValue, _value);
            }
        }
        public VString(string value)
        {
            _value = value;
        }
        public static implicit operator VString(string value)
        {
            return new VString(value);
        }
        public static implicit operator string(VString value)
        {
            return value.Value;
        }
        public override string ToString()
        {
            return _value;
        }
    }
}