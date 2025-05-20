// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

string numeroS;

int resultado;

Console.WriteLine("Ingrese un numero:");
numeroS=Console.ReadLine();

resultado =InvertirNumero(numeroS); 

Console.WriteLine("Hello, World!"+resultado);




//Funciones
int InvertirNumero(string numeroS){
int numeroInvertido = 0;
int numero;
if (int.TryParse(numeroS, out numero)){

    while (numero > 0) {
        int digito = numero % 10;
        numeroInvertido = numeroInvertido * 10 + digito;
        numero /= 10;
    }
}
return numeroInvertido;
}