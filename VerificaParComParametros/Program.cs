int number;
interacaoUsuario();
respostaUsuario();  

// função com apenas um retorno:
bool ehPAr(int valor)
{
    bool answer = false;
    if( valor % 2 ==0)
    {
        answer = true;
    }
    return answer;
}
void interacaoUsuario()
{
    Console.Write("Informe um número para verificar se é par ou ímpar: ");
    if (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Valor inválido!!\n" +
                          "Preciso de um valor inteiro!");
    }else
        ehPAr(number);
}
void respostaUsuario()
{
    if (ehPAr(number))
        Console.WriteLine("{0}, é par!", number);
    else Console.WriteLine("{0} é impar!", number);    
}
