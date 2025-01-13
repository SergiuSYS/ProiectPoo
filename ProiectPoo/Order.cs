public class Order
{
    public int ID { get; private set; }
    public string ObjectName { get; private set; }
    public double ObjectWeight { get; private set; }
    public string ObjectColour { get; private set; }
    public decimal PaymentSum { get; private set; }
    public string DeliveryAdress { get; private set; }
    public string Email { get; private set; }
    public string PhoneNumber { get; private set; }

    public Order(int id, string objectname, double objectweight, string objectcolour, decimal paymentsum, string deliveryadress, string email, string phonenumber)
    {
        ID = id;
        ObjectName = objectname;
        ObjectColour = objectcolour;
        ObjectWeight = objectweight;
        PaymentSum = paymentsum;
        DeliveryAdress = deliveryadress;
        Email = email;
        PhoneNumber = phonenumber;
    }
}