# Sistema de Celulares com POO em C#

Este projeto foi desenvolvido como parte de um desafio técnico da **Digital Innovation One (DIO)** na trilha de .NET. O objetivo principal foi aplicar os pilares da Programação Orientada a Objetos (POO) para abstrair um sistema de celulares.

## Descrição do Desafio

O desafio consiste em modelar um sistema que trabalha com celulares de diferentes marcas. Para isso, foi criada uma classe abstrata `Smartphone` que serve de molde para as classes concretas `Nokia` e `Iphone`.

O sistema deve permitir:

- Armazenar propriedades comuns (Número, Modelo, IMEI, Memória).
- Realizar ações comuns (Ligar, Receber Ligação).
- **Polimorfismo:** Implementar o método abstrato `InstalarAplicativo` de forma distinta para cada marca.

## Tecnologias Utilizadas

- **C#** (.NET 6 ou superior)
- **Visual Studio Code**

## Estrutura do Projeto

```text
DesafioPOO
├── Models
│   ├── Smartphone.cs  (Classe Abstrata)
│   ├── Nokia.cs       (Classe Filha)
│   └── Iphone.cs      (Classe Filha)
├── Program.cs         (Ponto de entrada / Testes)
└── DesafioPOO.csproj
```
## Diagrama de Classes (UML)

```text
classDiagram
    class Smartphone {
        <<abstract>>
        +String Numero
        -String Modelo
        -String IMEI
        -int Memoria
        +Ligar()
        +ReceberLigacao()
        +InstalarAplicativo(nomeApp)*
    }
    class Nokia {
        +InstalarAplicativo(nomeApp)
    }
    class Iphone {
        +InstalarAplicativo(nomeApp)
    }

    Smartphone <|-- Nokia
    Smartphone <|-- Iphone
```
## Como Executar

1. **Clone o repositório** para sua máquina local:
   ```bash
   git clone [https://github.com/katyagomes/DesafioPOO.git)
   ```
2. **Navegue** até a pasta do projeto:
  ```bash
  cd DesafioPOO
  ```
3. **Execute o projeto** usando o comando do .NET CLI:
 ```bash
dotnet run
```
## Resultados Esperados

Ao executar o programa, você verá a demonstração do polimorfismo em ação no console:

```text
--- Smartphone Nokia ---
Ligando...
Instalando o aplicativo "Whatsapp" no Nokia (Symbian/Android)...

--- Smartphone iPhone ---
Recebendo ligação...
Instalando o aplicativo "Telegram" no iPhone (iOS)...
```
## Conceitos Aplicados

* **Abstração:** Criação da classe base `Smartphone` para definir um contrato.
* **Encapsulamento:** Proteção de dados sensíveis como IMEI e Modelo usando modificadores de acesso.
* **Herança:** As classes `Nokia` e `Iphone` herdam características da classe pai.
* **Polimorfismo:** O método `InstalarAplicativo` age de forma diferente dependendo da instância (`Nokia` ou `iPhone`).
