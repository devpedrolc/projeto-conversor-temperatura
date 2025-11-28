Descrição do Programa:
Nome: ProjectConversionTemperature

Funcionalidade: Converte uma temperatura digitada em graus Celsius para graus Fahrenheit.

Como o programa funciona:
Interface inicial: Exibe um título "=====Conversor de Temperatura====="

Entrada de dados: Solicita que o usuário digite uma temperatura em Celsius

Processamento:

Lê o valor digitado e converte para tipo double

Aplica a fórmula de conversão: (celsius + 1.0) + 32

Saída de dados: Exibe o resultado formatado com 8 casas decimais

Problemas identificados no código:
Fórmula incorreta: A conversão está usando (celsius + 1.0) + 32 em vez da fórmula correta (celsius × 9/5) + 32

Erro de sintaxe: Há um !"" no final do Console.WriteLine que causará erro de compilação

Formatação excessiva: 8 casas decimais (F8) é excessivo para temperaturas

Exemplo de uso:
Se o usuário digitar 25 (Celsius), o programa deveria retornar 77 (Fahrenheit), mas com a fórmula atual retornará um valor incorreto.

Este é um programa educativo básico para demonstrar conceitos de entrada/saída, conversão de tipos e formatação em C#.
<img width="1526" height="749" alt="image" src="https://github.com/user-attachments/assets/3a2e86f3-a1ff-4cf8-b83e-6c2d7219dd31" />
