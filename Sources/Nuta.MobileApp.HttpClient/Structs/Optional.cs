using System.Text.Json.Serialization;

namespace Nuta.MobileApp.HttpClient.Structs;

public struct Optional<T>
{
    [JsonIgnore] public bool HasValue { get; private set; }

    private T _value;

    public T Value
    {
        get => _value;
        set
        {
            _value = value;
            HasValue = true;
        }
    }
}