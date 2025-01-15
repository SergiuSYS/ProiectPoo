public enum ImprimantaType
{
    FDM,
    SLA
}
public class Imprimanta
{
    public int ID { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public Material material { get; set; }
    public float ProcentMaterialRamas { get; set; }
    public ImprimantaType TipImprimanta { get; set; }
    public bool Stare { get; set; }
    private Order comanda;

    public Imprimanta(string brand, string model)
    {
        Brand = brand;
        Model = model;
        ProcentMaterialRamas = 100;
    }
    public float CalculareProcentMaterialRamas(float materialFolosit)
    {
        if (materialFolosit > material.capacitateMaterial)
        {
            throw new Exception("Materialul folosit este mai mare decat capacitatea imprimantei");
        }
        ProcentMaterialRamas = (material.capacitateMaterial - materialFolosit) / material.capacitateMaterial * 100;
        return ProcentMaterialRamas;
    }
    public double TimpProcesare()
    {
        if (TipImprimanta == ImprimantaType.FDM)
        {
            return comanda.ObjectWeight * 1000;
        }
        if (TipImprimanta == ImprimantaType.SLA)
        {
            return comanda.ObjectWeight * 2000;
        }
        throw new Exception("Tipul imprimantei nu este valid.");
    }
    public void refil()
    {

    }
    public void getComanda(Order order)
    {
        comanda = order;
    }
    public bool canPrint()
    {

        return true;
    }
    public async Task<string> PrintareComanda()
    {
        if (comanda == null)
        {
            throw new Exception("Nu exista nicio comanda de imprimat.");
        }

        await Task.Delay((int)TimpProcesare());
        return "Comanda a fost printata";
    }
}