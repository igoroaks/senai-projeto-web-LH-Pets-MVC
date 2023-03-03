namespace LHPet.Models;

public class Fornecedor
{
    public int Id { get; set; } // ao ditigar prop (atalho) = public int MyProperty { get; set; }
    public string? Nome { get; set; }
    public string? Cnpj { get; set; }
    public string? Email { get; set; }

    public Fornecedor(int id, string nome, string cnpj, string email) // ao ditigar ctor (atalho) = public xxx(Parameters){}
    {
        this.Id = id;
        this.Nome = nome;
        this.Cnpj = cnpj;
        this.Email = email;
    }
}