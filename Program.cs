
public class Program {
public static void Main(string[] args){

    Cliente cliente1 = new Cliente();
    cliente1.setNome("Murilo");
    cliente1.setRg("123abc");
    cliente1.setCpf("111.111.111-11");
    cliente1.setCnh("456def");
    cliente1.setDataNascimento( new DateOnly(2000, 01, 01));
    cliente1.setEndereco("Rua A numero 1");
    cliente1.setTelefone("(62)3222-2222");


    Cliente cliente2 = new Cliente("cliente",
     "456abc","222.222.222-22", "789def", 
     new DateOnly(1990,12,31), "Avenida B numero 2", 
     "(62)3233-3333", null);

     Carro carro1 = new Carro();
     carro1.setModelo("Gol");
     carro1.setMarca("Volkswagen");

     Carro carro2 = new Carro();

     List<Carro> carros = new List<Carro>();
     carros.Add(carro1);
     carros.Add(carro2);

     List<Carro> resultado = new List<Carro>();

     for(int i = 0; i < carros.Count; i++){
        Carro c = carros[i];
        if(c.getModelo().ToLower().Equals("gol")){
            resultado.Add(c);
        }
     }

     printSimplificadoDadosCliente(cliente1);
     printSimplificadoDadosCliente(cliente2);

    }

    public static void printSimplificadoDadosCliente(Cliente cliente){
        Console.WriteLine("O nome do cliente é: " + cliente.getNome());
        Console.WriteLine("A cnh do cliente é: " + cliente.getCnh());
        Console.WriteLine("O telefone é: " + cliente.getTelefone());
        Console.WriteLine("A data de Nascimento é: " + cliente.getDataNascimento());
    }
    
}
