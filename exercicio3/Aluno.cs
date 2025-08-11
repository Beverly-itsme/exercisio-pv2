using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class Aluno : IComparable<Aluno>
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public double Nota { get; set; }

    public Aluno(int id, string nome, double nota)
    {
        Id = id;
        Nome = nome;
        Nota = nota;
    }

    // Ordenação padrão: por Id
    public int CompareTo(Aluno? other)
    {
        if (other == null) return 1;
        return this.Id.CompareTo(other.Id);
    }

    public override string ToString()
    {
        return $"Id: {Id}, Nome: {Nome}, Nota: {Nota}";
    }
}

class Program
{
    static void Main()
    {
        Aluno[] alunos = new Aluno[]
        {
            new Aluno(3, "Ana", 7.5),
            new Aluno(1, "Bruno", 8.9),
            new Aluno(2, "Carlos", 6.3),
            new Aluno(5, "Diana", 9.1),
            new Aluno(4, "Eva", 7.5)
        };

        // Ordenar por Id (CompareTo)
        Array.Sort(alunos);
        Console.WriteLine("Ordenado por Id:");
        foreach (var aluno in alunos)
        {
            Console.WriteLine(aluno);
        }

        Console.WriteLine();

        // Ordenar por Nota (lambda)
        Array.Sort(alunos, (a1, a2) => a1.Nota.CompareTo(a2.Nota));
        Console.WriteLine("Ordenado por Nota:");
        foreach (var aluno in alunos)
        {
            Console.WriteLine(aluno);
        }
    }
}
