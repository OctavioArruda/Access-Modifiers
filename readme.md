# C# Access Modifiers

## A motivação deste repositório é aprender sobre os `Access Modifiers` de C# e de outras linguagens, por consequência.

- Observação: `Assembly` pode ser lido como `Project`. Cada `Project` cria um `Assembly`.
- A biblioteca/projeto cria uma DLL. O programa principal (Program.cs) cria um executável.
- O executável é chamado de `Assembling`.

### A palavra-chave `private`:
- O código só estará acessível dentro da mesma classe.
- Não se pode chamar métodos `private` em um projeto/assembly diferente. 

### A palavra-chave `internal`:
- O código está somente acessível dentro do próprio assembly(não em outros).
- O escopo passa a ser o projeto em que a classe foi declarada.

### A palavra-chave `public`:
- O escopo é "tudo"
- Pode ser acessado de qualquer lugar.

### A palavra-chave `protected`:
- O código fica acessível na classe, ou nas classes que herdam da classe em que ele foi declarado.
- Não costuma ser tão utilizado pois herança em si, da orientação a objeto, não é amplamente usada.

### `private protected`
- Só está acessível dentro da classe. 
- A diferença é que só fica acessível no mesmo project/assembly. 
- Fora do assembly, mesmo herdando da classe criadora, não é possível acessar.

### `protected internal`
- `Protected` dentro do projeto/assembly e `internal` fora dele.

## Anotações:
- entre classes libraries: uso de internal
- se herança é utilizada: protected deveria ser utilizado