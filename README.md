# Baseado no projeto  Workshop - ASP.NET CORE para Iniciantes

Repositório responsável pelo workshop desenvolvido durante o evento: [.NET Conference 2018 - Goiânia](https://github.com/glaucia86/workshop-net-core-iniciantes).

## Recursos Utilizados:

Se faz necessário realizar a instalação das aplicações/frameworks abaixo:

* Visual Studio Code

    - **[Visual Studio Code](https://code.visualstudio.com/?WT.mc_id=aspcoreiniciantes-github-gllemos)**
    - **[.NET Core SDK](https://www.microsoft.com/net/download?WT.mc_id=aspcoreiniciantes-github-gllemos)**

* Baixar o Git:
    
    - **[Git](https://git-scm.com/downloads)**

## O que aprendi

Nesse workshop fui capaz de desenvolver a minha primeira aplicação Web em .NET  5.0 Razor Pages.
A aplicação constitui num CRUD (Create, Read, Update e Delete).

## Ementa do Workshop

- Parte 1: Criando Razor Pages usando o dotnet CLI & VS Code;
- Parte 2: Adicionando um modelo para a aplicaçao ASP.NET Core Razor Pages;
- Parte 3: Atualizando e gerando páginas;
- Parte 4: Adicionando busca para a aplicação Razor Pages;

## Vídeos do Workshop

- [Aula 01 - Introdução](https://youtu.be/njlmcXxSHE4)
- [Aula 02 - Criando aplicação .NET Core](https://youtu.be/QobTy9hMUsA)
- [Aula 03 - Instalando Importantes Plugins HD](https://youtu.be/QobTy9hMUsA)
- [Aula 04 - Adicionando Modelo & Criando a BD com EF Core](https://youtu.be/2UpKRHgE79I)
- [Aula 05 - Uso de Data Annotations na Classe Modelo](https://youtu.be/3rOydR0HVEk)
- **Aula 6 - Melhorias de Front-End no Projeto**
    - [Aula 6.1 - Melhorias de Front-End no Projeto: Parte I](https://youtu.be/NJ9PIn1iRSI)
    - [Aula 6.2 - Melhorias de Front-End no Projeto: Parte II](https://youtu.be/drXNN8vrG8o)
    - [Aula 6.3 - Melhorias de Front-End no Projeto: Parte III](https://youtu.be/YuB4AThdHkI)
    - [Aula 6.4 - Melhorias de Front-End no Projeto: Parte IV](https://youtu.be/47tG0qH6a_M)
    - [Aula 6.5 - Melhorias de Front-End no Projeto: Parte V](https://youtu.be/qiaqJplpNV0)
- [Aula 07 - Adicionando Busca no Index.html](https://youtu.be/2PJ5JZ5MTTo)


## Executando o Projeto Localmente

Caso queira executar o projeto de maneira local, basta executar os comandos abaixo:

```
> dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
> dotnet add package Microsoft.EntityFrameworkCore.Sqlite
> dotnet restore
> dotnet ef migrations add InitialCreate
> dotnet ef database update
```

Feito isso irá criar a base de dados para que possa ser testada na hora de executar a aplicação ao dar: **dotnet run** na raiz do projeto.

