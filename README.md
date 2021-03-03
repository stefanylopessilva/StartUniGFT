# Teste Técnico GFT 📝

Teste Técnico realizado no processo seletivo do programa START UNI da GFT em C#

## 🖩 Exercício Soma

Crie um programa que receba números do usuário e vá somando cada
número recebido. Quando a soma atingir 300 ou um número maior, exiba o
somatório para o usuário e encerre o programa.
Exiba uma mensagem caso o usuário tente cadastrar um número negativo E
NÃO SOME esse número.

## 💰 Exercício Investimento

Considerando o paradigma de orientação a objetos, escreva uma classe pai
chamada Investimento com os atributos valorInicial e jurosMensais,
passados no construtor e uma função: calcularLucro(int meses).
A função calcularLucro deve ser calculada pela seguinte fórmula de juros
compostos:

𝑟𝑒𝑡𝑜𝑟𝑛𝑜 = (𝑣𝑎𝑙𝑜𝑟𝐼𝑛𝑖𝑐𝑖𝑎𝑙 𝑥 (1 + 𝑗𝑢𝑟𝑜𝑠𝑀𝑒𝑛𝑠𝑎𝑖𝑠)𝑚𝑒𝑠𝑒𝑠) − 𝑣𝑎𝑙𝑜𝑟𝐼𝑛𝑖𝑐𝑖𝑎𝑙

Crie duas classes herdando a classe Investimento: InvestimentoComIR e
InvestimentoSemIR.
A função calcularLucro classe InvestimentoComIR deve aplicar
descontos de Imposto de Renda de acordo com os meses passados
no parâmetro:
- Menos de 6 meses: 22,5%
- Maior ou igual a 6 meses e menor que 12 meses: 20%
- Maior ou igual a 12 meses e menor que 24 meses: 17,5%
- Maior ou igual a 24 meses: 15%

A classe InvestimentoSemIR deve manter a fórmula inicial, porém
caso o valorInicial seja menor que R$1000 , uma mensagem deve
ser exibida: “O valor Inicial não pode ser menor que R$1000”
- No caso do valorInicial abaixo de R$1000, o retorno da
função calcularLucro, deve ser sempre 0.

Crie uma classe com método Main, e imprima o resultado para as duas
simulações a seguir:

| Investimento    | Valor Inicial  | Juros Mensais | Meses |
|-----------------|----------------|---------------|-------|
|InvestimentoComIR| R$5000         | 1,2%          | 17    |
|InvestimentoSemIR| R$3000         | 0,7%          | 10    |

## 💵 Exercício Investimento Usuário

Utilizando a estrutura do exercício anterior, crie uma classe Main que receba um valorInicial vindo do usuário, e simule mês a mês quanto de lucro o usuário irá receber, considerando 2 investimentos:
- InvestimentoComIR com 0,35% de juros mensais
- InvestimentoSemIR com 0,3% de juros mensais

Simule o lucro obtido em 36 meses conforme o exemplo abaixo:

![image](https://user-images.githubusercontent.com/29932387/109868922-04cd0780-7c47-11eb-814f-022f20db065d.png)
