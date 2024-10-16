class Customer 
{
    private string _name;
    private Address _address;

    public Customer (string name, Address address )
    {
        _name = name;
        _address = address;

    }

    public bool Nationality()
    { 
        return _address.Nationality();
    }

    public string ShippingLabel()
    {
        return $"name: {_name} \n Andress: {_address.DisplayAddress()}";
    }

}