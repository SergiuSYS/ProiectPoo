public abstract class Imprimanta_base_model
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public float CapacitateMaterial { get; set; }
    public float ProcentMaterialRamas { get; set; }

    public Imprimanta_base_model(string brand, string model, float capacitateMaterial, float procentMaterialRamas)
    {
        Brand = brand;
        Model = model;
        CapacitateMaterial = capacitateMaterial;
        ProcentMaterialRamas = 100;
    }
    public float CalculareProcentMaterialRamas(float materialFolosit)
    {
        if(materialFolosit > CapacitateMaterial)
        {
            throw new Exception("Materialul folosit este mai mare decat capacitatea imprimantei");
        }
        ProcentMaterialRamas = (CapacitateMaterial - materialFolosit) / CapacitateMaterial * 100;
        return ProcentMaterialRamas;
    }
    //se va introduce obiectuul comanda in viitor in loc de string model
    public abstract bool ImprimareModel3D(string model);
}