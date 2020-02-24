# Estudo .Net Core 3
## Criando projetos linha de comando
 - `dotnet new classlib` (Novo projeto Class Library);
 - `dotnet new webapi` (Novo projeto Web API);
 - `dotnet new mstest` (Novo projeto Test);
 - `dotnet new sln` (Nova Solution);
 - `dotnet sln add [diretorio]` (Adiciona projeto a Solution);
 - `dotnet build` (Realiza o build de aplicação);
 - `dotnet add reference [diretorio]` (Adiciona projeto ao projeto atual);
 - `code .` (Abre solution no diretório local);
 - `dotnet add package flunt` (Adiciona uma novo pacote ao projeto).

## Domínios ricos
 - Se você não quer uma classe seja instânciada, declare ela como abstract. Queremos que ela seja utilizada apens para ser extendida;
 - Sempre trabalhe mais na camada de domain que nas camadas de Infra e API, para que suas regras de negocios funcionem independente do tipo de projeto (Web API, console application, forms...), mais fácil de testar também;
 - Commands, são onde ocorre as ações do nosso sistema (CRUD e derivados), o mesmo também trabalha como DTOs.