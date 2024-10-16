class Address
{
    public string _street;
    public string _city;
    public string _state;
    public string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool Nationality()
    {
        return _country.ToLower() == "usa";


    }

    public string DisplayAddress()
    {
        return $"The address is {_street} {_city}, {_state} {_country}";
    }
}