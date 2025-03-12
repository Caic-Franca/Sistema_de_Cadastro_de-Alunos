namespace Arrays_Lista
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("INÍCIO!");
            // instanciando a lista de alunos
            List<Aluno> lista_alunos = new List<Aluno>();
            
            int opcao3 = 1;
            // int opcao3 refere-se  ao if que pergunta se o usuário deseja voltar ou fechar o prgrama. Como o if é no final do código,
            // é preciso colocar todo o progama dentro dele
            while (opcao3 == 1)
            {
                Console.WriteLine("Bem-vindo (a) ao sistema de cadastro de alunos!");
                Console.WriteLine("Você deseja: \n1) Cadastrar Aluno(a). \n2) Listar Alunos. \n3) Sair.");
                int opcao = int.Parse(Console.ReadLine());

            Console.Clear();

                switch (opcao)
                {
                    case 1:
                        // chamando a função criada para adição de dados de cadastro
                        Aluno alunoCriado = TelaCadastroDadosAluno();

                        //lista de dados de alunos recebendo os dados e adciona no aluno criado
                        lista_alunos.Add(alunoCriado);
                        Console.WriteLine("Aluno(a) cadastrado com sucesso!");

                        //após a adição de aluno, dentro do case 1, o programa pergunta se deseja adicionar mais um aluno
                        Console.WriteLine("Deseja adicionar mais um aluno(a)? \n1) Sim. \n2) Não.");
                        int opcao2 = int.Parse(Console.ReadLine());
                        //limpa a página
                        Console.Clear();

                        //Laço de repetição para adicionar mais de um aluno caso aceito a opção 1 na pergunta anterior
                        while (opcao2 == 1)
                        {
                            alunoCriado = TelaCadastroDadosAluno();
                            lista_alunos.Add(alunoCriado);
                            //--------------------------------
                            Console.WriteLine("Novo(a) Aluno(a) cadastrado com sucesso!");
                            Console.WriteLine("Deseja adicionar mais um aluno(a)? \n1) Sim. \n2) Não.");
                            opcao2 = int.Parse(Console.ReadLine());
                            Console.Clear();
                            //Laço adicionado para encerrar a adição de alunos
                            if (opcao2 == 2)
                            {
                                Console.WriteLine("Ok, Encerrando as adição de alunos");
                            }
                        }
                        break;


                    case 2:
                        //laço adicionado para caso não haja alunos cadastrados
                        if (lista_alunos.Count == 0)
                        {
                            Console.WriteLine("Não há alunos cadastrados!");
                            break;
                        }

                        //solicitador de lista de alunos cadastrados
                        Console.WriteLine("Muito bem, aqui está a lista de alunos:");
                        foreach (Aluno a in lista_alunos)
                        {
                            Console.WriteLine("Nome: " + a.Nome);
                            Console.WriteLine("Matrícula: " + a.Matricula);
                            Console.WriteLine("Curso: " + a.Curso.Nome);
                            Console.WriteLine("Email: " + a.Email);
                            Console.WriteLine("-------------------------------");
                        }
                        break;

                        //finaliza programa
                    case 3:
                        Console.WriteLine("Ok, saindo! \nFinalizando programa. \nVOLTE SEMPRE!");
                        Console.Clear();
                        break;

                }


                Console.WriteLine(" Qual período deseja matricular o aluno? \n1) Manhã. \n2) Tarde. \n3) Noite.");
                int periodo = int.Parse(Console.ReadLine());
                
               
                if (periodo == 1) {
                    Console.WriteLine("Aluno matriculado no período da manhã.");
                }
                if (periodo == 2)
                {
                    Console.WriteLine("Aluno matriculado no período da tarde.");
                }
                if (periodo == 3)
                {
                    Console.WriteLine("Aluno matriculado no período da noite.");
                }
                else
                {
                    Console.WriteLine("Opção inválida.");
                }

                //solicitador do laço while iniciado no começo do código para voltar ao menu principal ou encerrar o programa
                Console.WriteLine("Deseja voltar ao menu principal? \n1) Sim. \n2) Não.");
                opcao3 = int.Parse(Console.ReadLine());
                Console.Clear();
                if (opcao3 == 2)
                {
                    Console.WriteLine("Ok, Encerrando o programa.");
                }
            }
        }
        // Função criada com os dados para cadastro de aluno. Função sendo chamada na opção 1 do switch case
        public static Aluno TelaCadastroDadosAluno() {

            Console.WriteLine("Digite o nome do aluno: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a matrícula do aluno: ");
            string matricula = Console.ReadLine();
            Console.WriteLine("Digite o curso do aluno: ");
            string curso = Console.ReadLine();
            Console.WriteLine("Digite o email do aluno: ");
            string email = Console.ReadLine();

            Curso cursoObject = new Curso(curso, 12546);

            //instanciando a classe Aluno
            Aluno aluno = new Aluno(nome, matricula, cursoObject, email);

            return aluno;

        }
    }
}
