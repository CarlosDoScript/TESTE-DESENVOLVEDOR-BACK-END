# Documentação - Atividades

## Atividade 1.1 - Maior Sequência de Collatz

O método `Atividade_1` encontra o número inicial entre 1 e 1 milhão que produz a maior sequência de acordo com a conjectura de Collatz. O código utiliza paralelização para melhorar o desempenho, calculando a sequência para cada número inicial e mantendo o controle do maior número e sua sequência.

### Método:

```csharp
public static void Atividade_1()
```
### Funcionamento:
<pre>
Inicializa variáveis para controlar o maior número inicial e a maior sequência.
Itera sobre os números iniciais de 1 a 1 milhão.
Calcula a sequência de Collatz para cada número usando a função CalcularSequenciaCollatz.
Utiliza um mecanismo de bloqueio (lock) para garantir a consistência dos dados compartilhados.
Exibe o maior número inicial e o tamanho da sequência resultante.
</pre>

### Função Auxiliar:
```csharp
private static int CalcularSequenciaCollatz(int numeroInicial, Dictionary<int, int> sequencias, int profundidade = 0, HashSet<int> visitados = null)
```
### Funcionamento: 
<pre>
Calcula recursivamente o tamanho da sequência de Collatz para um número inicial dado.
</pre>

## Atividade 1.2 - Manipulação de Arrays
  
O método `Atividade_2` realiza operações em um array de números, verificando se contém apenas números ímpares, exibindo os ímpares e apresentando o array inicial.

### Método: 
```csharp
public static void Atividade_2()
```
### Funcionamento
<pre>
Verifica se o array contém apenas números ímpares usando a função ContemSomenteImpares.
Exibe se o array contém apenas números ímpares ou se possui números pares.
Exibe os números ímpares contidos no array utilizando a função ObterNumerosImpares.
</pre>

### Funções Auxiliares 
```csharp
private static bool ContemSomenteImpares(int[] numeros)
private static IEnumerable<int> ObterNumerosImpares(int[] numeros)
```

### Método: 
```csharp
public static void Atividade_3()
```
### Funcionamento: 
<pre>
Exibe os dois arrays iniciais.
Encontra e exibe os números do primeiro array que não estão contidos no segundo array usando a função Except.
</pre>

## Observações Gerais:
<pre>
O código utiliza boas práticas, como a utilização de blocos lock para garantir a sincronização em ambientes multithreading.
As funções auxiliares são criadas para facilitar a leitura e manutenção do código.
Os resultados das atividades são exibidos no console para facilitar a visualização.
</pre>
