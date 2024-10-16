class Product
{
    private string _productName;
    private string _id;
    private double _price;
    private int _quantity;

    
    
public Product(string productName, string productId, double price, int quantity)
    {
        _productName = productName;
        _id = productId;
        _price = price;
        _quantity = quantity;
    }

    public double ProductCost()
    {
      return  _price * _quantity;
      
    }

    public string GetPackingLabel()
    {
        return $"Product: {_productName} Id: { _id}";
    }

}