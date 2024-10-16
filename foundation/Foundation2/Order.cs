using System.Text;

class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double TotalCost()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.ProductCost();
        }
        if (_customer.Nationality())
        {
            total += 5;
        }

        else
        {
            total += 25;
        }

        return total;

    }

    public string PackingLabel()
    {
        string label = "packing label";

        foreach (Product product in _products)
        {
            label += $"{product.GetPackingLabel}   ";
        }
        return label;
    }

    public string GetShippingLabel()

    {
       return $"Shipping label: {_customer.ShippingLabel()}";
    }





}